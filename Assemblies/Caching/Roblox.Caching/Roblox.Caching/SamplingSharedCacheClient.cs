using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BeIT.MemCached;
using Roblox.Caching.Shared;
using Roblox.Common.NetStandard;
using Roblox.EventLog;

namespace Roblox.Caching;

internal sealed class SamplingSharedCacheClient : ISharedCacheClient, IDisposable
{
	private sealed class InfluxDbSampleLogger : IDisposable
	{
		private enum LogItemType
		{
			Read,
			Write
		}

		private class LogItem
		{
			public LogItemType Type { get; }

			public string StackTrace { get; }

			public int? Size { get; }

			public DateTime TimeStamp { get; }

			public LogItem(LogItemType type, string stackTrace, int? size, DateTime timeStamp)
			{
				Type = type;
				StackTrace = stackTrace;
				Size = size;
				TimeStamp = timeStamp;
			}
		}

		private static readonly DateTime _Epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

		private readonly ISamplingSharedCacheClientSettings _Settings;

		private readonly ISharedCacheClient _BackingSharedCacheClient;

		private readonly CancellationTokenSource _LoggingTaskCancellationTokenSource;

		private readonly ConcurrentQueue<LogItem> _LogItems;

		private readonly AutoResetEvent _LogItemsEvent;

		private readonly ThreadLocal<Random> _ThreadLocalRandom;

		private readonly ILogger _Logger;

		private volatile bool _IsDisposed;

		public InfluxDbSampleLogger(ISharedCacheClient backingSharedCacheClient, ILogger logger, ISamplingSharedCacheClientSettings settings)
		{
			_BackingSharedCacheClient = backingSharedCacheClient ?? throw new ArgumentNullException("backingSharedCacheClient");
			_Logger = logger ?? throw new ArgumentException("logger");
			_Settings = settings ?? throw new ArgumentNullException("settings");
			_LoggingTaskCancellationTokenSource = new CancellationTokenSource();
			_LogItems = new ConcurrentQueue<LogItem>();
			_LogItemsEvent = new AutoResetEvent(initialState: false);
			_ThreadLocalRandom = new ThreadLocal<Random>(() => new Random());
			Task.Factory.StartNew(LogLoop, TaskCreationOptions.LongRunning);
		}

		~InfluxDbSampleLogger()
		{
			Dispose(isDisposing: false);
		}

		public void LogBytesRead(int? size)
		{
			if (!_IsDisposed && ShouldSample())
			{
				string stackTraceString = GetStackTraceString();
				LogItem item = new LogItem(LogItemType.Read, stackTraceString, size, DateTime.UtcNow);
				_LogItems.Enqueue(item);
				_LogItemsEvent.Set();
			}
		}

		public void LogBytesWritten(int? size)
		{
			if (!_IsDisposed && ShouldSample())
			{
				string stackTraceString = GetStackTraceString();
				LogItem item = new LogItem(LogItemType.Write, stackTraceString, size, DateTime.UtcNow);
				_LogItems.Enqueue(item);
				_LogItemsEvent.Set();
			}
		}

		private bool ShouldSample()
		{
			return _ThreadLocalRandom.Value.Next(0, 1000) < _Settings.SampleRatePerThousand;
		}

		private void LogLoop()
		{
			while (!_LoggingTaskCancellationTokenSource.IsCancellationRequested || _LogItems.Any())
			{
				try
				{
					_LogItemsEvent.WaitOne();
				}
				catch (ObjectDisposedException)
				{
					break;
				}
				List<LogItem> list = new List<LogItem>(_LogItems.Count);
				LogItem result;
				while (_LogItems.TryDequeue(out result))
				{
					list.Add(result);
				}
				WriteEntries(list);
			}
		}

		private void WriteEntries(IReadOnlyCollection<LogItem> logItems)
		{
			HashSet<string> hashSet = new HashSet<string>();
			string influxUrl = _Settings.InfluxUrl;
			if (influxUrl == string.Empty)
			{
				return;
			}
			influxUrl += $"/write?db=${_Settings.InfluxDatabase}";
			StringBuilder stringBuilder = new StringBuilder();
			bool flag = true;
			foreach (LogItem logItem in logItems)
			{
				string text = HashFunctions.ComputeMd5HashString(logItem.StackTrace);
				if (!hashSet.Contains(text))
				{
					try
					{
						_BackingSharedCacheClient.Set($"MemcachedUsageStackTraceHash:{text}", logItem.StackTrace, _Settings.SampleLogExpiration);
						hashSet.Add(text);
					}
					catch (Exception ex)
					{
						_Logger.Error(ex);
					}
				}
				if (!flag)
				{
					stringBuilder.Append("\n");
				}
				else
				{
					flag = false;
				}
				long num = logItem.TimeStamp.Subtract(_Epoch).Ticks * 100;
				stringBuilder.Append($"{logItem.Type}s,stackTraceHash={text},knownSize={logItem.Size.HasValue} size={logItem.Size ?? 1} {num}");
			}
			try
			{
				using WebClient webClient = new WebClient();
				webClient.UploadString(influxUrl, stringBuilder.ToString());
			}
			catch (Exception ex2)
			{
				_Logger.Error(ex2);
			}
		}

		private string GetStackTraceString()
		{
			string text = new StackTrace().ToString();
			int sampleStackTraceSubstringLength = _Settings.SampleStackTraceSubstringLength;
			if (text.Length > sampleStackTraceSubstringLength)
			{
				text = text.Substring(0, sampleStackTraceSubstringLength);
			}
			return text;
		}

		public void Dispose()
		{
			Dispose(isDisposing: true);
			GC.SuppressFinalize(this);
		}

		private void Dispose(bool isDisposing)
		{
			if (!_IsDisposed)
			{
				_IsDisposed = true;
				if (isDisposing)
				{
					_LoggingTaskCancellationTokenSource.Cancel();
					_LoggingTaskCancellationTokenSource.Dispose();
					_LogItemsEvent.Dispose();
				}
			}
		}
	}

	private readonly ISharedCacheClient _BackingCacheClient;

	private readonly InfluxDbSampleLogger _SampleLogger;

	public SamplingSharedCacheClient(ISharedCacheClient backingCacheClient, ILogger logger, ISamplingSharedCacheClientSettings settings)
	{
		_BackingCacheClient = backingCacheClient ?? throw new ArgumentNullException("backingCacheClient");
		if (logger == null)
		{
			throw new ArgumentNullException("logger");
		}
		if (settings == null)
		{
			throw new ArgumentNullException("settings");
		}
		_SampleLogger = new InfluxDbSampleLogger(backingCacheClient, logger, settings);
	}

	public bool Add(string key, string value, TimeSpan expiration)
	{
		_SampleLogger.LogBytesWritten(GetStringSize(value));
		return _BackingCacheClient.Add(key, value, expiration);
	}

	public bool Append(string key, string appendedValue)
	{
		_SampleLogger.LogBytesWritten(GetStringSize(appendedValue));
		return _BackingCacheClient.Append(key, appendedValue);
	}

	public SharedCacheClient.CasResult CheckAndSet(string key, string value, TimeSpan policy, ulong uniqueFromQuery)
	{
		_SampleLogger.LogBytesWritten(value?.Length);
		return _BackingCacheClient.CheckAndSet(key, value, policy, uniqueFromQuery);
	}

	public SharedCacheClient.CasResult CheckAndSet<TValue>(string key, TValue value, TimeSpan policy, ulong uniqueFromQuery) where TValue : struct
	{
		_SampleLogger.LogBytesWritten(null);
		return _BackingCacheClient.CheckAndSet(key, value, policy, uniqueFromQuery);
	}

	public SharedCacheClient.CasResult CheckAndSet(string key, byte[] value, TimeSpan policy, ulong uniqueFromQuery)
	{
		_SampleLogger.LogBytesWritten(value?.Length);
		return _BackingCacheClient.CheckAndSet(key, value, policy, uniqueFromQuery);
	}

	public ulong? Decrement(string key, ulong value)
	{
		_SampleLogger.LogBytesWritten(8);
		return _BackingCacheClient.Decrement(key, value);
	}

	public bool Delete(string key)
	{
		_SampleLogger.LogBytesWritten(null);
		return _BackingCacheClient.Delete(key);
	}

	public ulong? GetCounter(string key)
	{
		_SampleLogger.LogBytesRead(8);
		return _BackingCacheClient.GetCounter(key);
	}

	public ulong?[] GetCounters(string[] keys)
	{
		_SampleLogger.LogBytesRead(8 * keys?.Length);
		return _BackingCacheClient.GetCounters(keys);
	}

	public IEnumerable<Stat> GetStats()
	{
		return _BackingCacheClient.GetStats();
	}

	public ulong? Increment(string key, ulong value)
	{
		_SampleLogger.LogBytesWritten(8);
		return _BackingCacheClient.Increment(key, value);
	}

	public TValue[] MultiGet<TValue>(string[] keys)
	{
		_SampleLogger.LogBytesRead(null);
		return _BackingCacheClient.MultiGet<TValue>(keys);
	}

	public string[] MultiGetAsStrings(string[] keys)
	{
		string[] array = _BackingCacheClient.MultiGetAsStrings(keys);
		_SampleLogger.LogBytesRead(((IEnumerable<string>)array).Sum((Func<string, int>)GetStringSize));
		return array;
	}

	public bool Query<TValue>(string key, out TValue value)
	{
		_SampleLogger.LogBytesRead(null);
		return _BackingCacheClient.Query(key, out value);
	}

	public bool Query<TValue>(string key, out TValue value, out ulong unique)
	{
		_SampleLogger.LogBytesRead(null);
		return _BackingCacheClient.Query(key, out value, out unique);
	}

	public bool Query(string key, out string value)
	{
		bool result = _BackingCacheClient.Query(key, out value);
		_SampleLogger.LogBytesRead(GetStringSize(value));
		return result;
	}

	public bool Query(string key, out string value, out ulong unique)
	{
		bool result = _BackingCacheClient.Query(key, out value, out unique);
		_SampleLogger.LogBytesRead(GetStringSize(value));
		return result;
	}

	public bool QueryBytes(string key, out byte[] value)
	{
		bool result = _BackingCacheClient.QueryBytes(key, out value);
		_SampleLogger.LogBytesRead(value?.Length);
		return result;
	}

	public bool QueryBytes(string key, out byte[] value, out ulong unique)
	{
		bool result = _BackingCacheClient.QueryBytes(key, out value, out unique);
		_SampleLogger.LogBytesRead(value?.Length);
		return result;
	}

	public IEnumerable<(string Key, byte[] Bytes, bool CacheHit)> QueryBytes(string[] keys)
	{
		return _BackingCacheClient.QueryBytes(keys);
	}

	public bool Remove(string key)
	{
		_SampleLogger.LogBytesWritten(null);
		return _BackingCacheClient.Remove(key);
	}

	public bool Set(string key, string value, TimeSpan policy)
	{
		_SampleLogger.LogBytesWritten(GetStringSize(value));
		return _BackingCacheClient.Set(key, value, policy);
	}

	public bool Set<TValue>(string key, TValue value, TimeSpan expiration)
	{
		_SampleLogger.LogBytesWritten(null);
		return _BackingCacheClient.Set(key, value, expiration);
	}

	public bool SetBytes(string key, byte[] value, TimeSpan expiration)
	{
		_SampleLogger.LogBytesWritten(value?.Length);
		return _BackingCacheClient.SetBytes(key, value, expiration);
	}

	public void SetCounter(string key, ulong value, TimeSpan expiration)
	{
		_SampleLogger.LogBytesWritten(8);
		_BackingCacheClient.SetCounter(key, value, expiration);
	}

	public bool SetNull(string key, TimeSpan expiration)
	{
		_SampleLogger.LogBytesWritten(null);
		return _BackingCacheClient.SetNull(key, expiration);
	}

	public void Dispose()
	{
		_BackingCacheClient.Dispose();
		_SampleLogger?.Dispose();
	}

	private int GetStringSize(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return 0;
		}
		return Encoding.UTF8.GetBytes(value).Length;
	}
}
