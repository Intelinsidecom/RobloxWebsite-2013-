using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using BeIT.MemCached;
using Roblox.Common.NetStandard;
using Roblox.Configuration;
using Roblox.EventLog;

namespace Roblox.Caching.Properties;

[Obsolete("This is the global version for MemcachedObject and MemcachedWeb, a more specialized implementation exists in ClusterSettings")]
public class MemCachedClientSettings : IMemCachedClientSettings, IMemcachedClientDnsSettings, INotifyPropertyChanged
{
	private readonly Settings _Settings;

	private readonly ILogger _Logger;

	public int MaximumNumberOfSocketsPerPool => MaximumNumberOfSocketsPerPoolOverride?.Invoke() ?? _Settings.MemcachedMaximumNumberOfSocketsPerPool;

	public static Func<int> MaximumNumberOfSocketsPerPoolOverride { get; set; }

	public TimeSpan PooledSocketConstructionSocketConnectTimeout { get; private set; }

	public TimeSpan ConnectionCircuitBreakerRetryInterval { get; private set; }

	public bool IsExecutionCircuitBreakerEnabled { get; private set; }

	public TimeSpan ExecutionCircuitBreakerRetryInterval { get; private set; }

	public HashSet<SocketError> SocketErrorsThatTripExecutionCircuitBreaker { get; private set; }

	public int ExecutionCircuitBreakerExceptionCountForTripping { get; private set; }

	public TimeSpan ExecutionCircuitBreakerExceptionIntervalForTripping { get; private set; }

	public IReadOnlyDictionary<string, TimeSpan> PerHostExpiryOverrides { get; private set; }

	public bool PerHostExpiryOverridesEnabled { get; private set; }

	public int ConnectionCircuitBreakerExceptionCountForTripping { get; private set; }

	public TimeSpan ConnectionCircuitBreakerExceptionIntervalForTripping { get; private set; }

	public HashSet<string> ExceptionTypeNamesToForceResetBytes { get; private set; }

	public int ForceResetBytesMaxAttempts { get; private set; }

	public int ForceResetBytesMaxNumberOfBytes { get; private set; }

	public bool LogVerboseExceptions { get; private set; }

	public bool IsRespectingMaxPoolSizeEnabled { get; private set; }

	public uint MinimumPoolSize { get; private set; }

	public uint MaximumPoolSize { get; private set; }

	public TimeSpan SendReceiveTimeout { get; private set; }

	public TimeSpan SocketRecycleAge { get; private set; }

	public uint CompressionThreshold { get; private set; }

	public bool UseRoundRobinSocketPoolSelection { get; private set; }

	public int MaximumSelectionAttemptsForRoundRobin { get; private set; }

	public IMemcachedClientDnsSettings DnsSettings => this;

	public bool IsUpgradedDnsResolvingEnabled { get; private set; }

	public IPAddress[] Nameservers { get; private set; }

	public TimeSpan EndpointCacheExpiry { get; private set; }

	public bool IsConnectionCreationRateLimitingEnabled { get; private set; }

	public TimeSpan ConnectionCreationRateLimitPeriodLength { get; private set; }

	public int MaximumConnectionCreationsPerPeriod { get; private set; }

	public event PropertyChangedEventHandler PropertyChanged;

	internal MemCachedClientSettings(Settings settings, ILogger logger)
	{
		_Settings = settings ?? throw new ArgumentNullException("settings");
		_Logger = logger ?? throw new ArgumentNullException("logger");
		if (settings == null)
		{
			throw new ArgumentNullException("settings");
		}
		settings.ReadValueAndMonitorChanges((Settings s) => s.MemcachedPooledSocketConstructionSocketConnectTimeout, delegate(TimeSpan v)
		{
			PooledSocketConstructionSocketConnectTimeout = v;
		});
		settings.ReadValueAndMonitorChanges((Settings s) => s.MemcachedClientConnectionCircuitBreakerRetryInterval, delegate(TimeSpan v)
		{
			ConnectionCircuitBreakerRetryInterval = v;
		});
		settings.ReadValueAndMonitorChanges((Settings s) => s.IsMemcachedClientExecutionCircuitBreakerEnabled, delegate(bool v)
		{
			IsExecutionCircuitBreakerEnabled = v;
		});
		settings.ReadValueAndMonitorChanges((Settings s) => s.MemcachedClientExecutionCircuitBreakerRetryInterval, delegate(TimeSpan v)
		{
			ExecutionCircuitBreakerRetryInterval = v;
		});
		settings.ReadValueAndMonitorChanges((Settings s) => s.MemcachedClientExecutionSocketErrorsThatTripCircuitBreakerCsv, delegate(string v)
		{
			SocketErrorsThatTripExecutionCircuitBreaker = ParseSocketErrors(v);
		});
		settings.ReadValueAndMonitorChanges((Settings s) => s.MemcachedClientExecutionCircuitBreakerExceptionCountForTripping, delegate(int v)
		{
			ExecutionCircuitBreakerExceptionCountForTripping = v;
		});
		settings.ReadValueAndMonitorChanges((Settings s) => s.MemcachedClientExecutionCircuitBreakerExceptionIntervalForTripping, delegate(TimeSpan v)
		{
			ExecutionCircuitBreakerExceptionIntervalForTripping = v;
		});
		settings.ReadValueAndMonitorChanges((Settings s) => s.MemcachedClientPerHostExpiryOverrides, delegate(string v)
		{
			PerHostExpiryOverrides = ParseExpiryOverrides(v);
		});
		settings.ReadValueAndMonitorChanges((Settings s) => s.MemcachedClientPerHostExpiryOverridesEnabled, delegate(bool v)
		{
			PerHostExpiryOverridesEnabled = v;
		});
		settings.ReadValueAndMonitorChanges((Settings s) => s.MemcachedClientConnectionCircuitBreakerExceptionCountForTripping, delegate(int v)
		{
			ConnectionCircuitBreakerExceptionCountForTripping = v;
		});
		settings.ReadValueAndMonitorChanges((Settings s) => s.MemcachedClientConnectionCircuitBreakerExceptionIntervalForTripping, delegate(TimeSpan v)
		{
			ConnectionCircuitBreakerExceptionIntervalForTripping = v;
		});
		settings.ReadValueAndMonitorChanges((Settings s) => s.MemcachedClientExceptionTypeNamesToForceResetBytes, delegate(string v)
		{
			ExceptionTypeNamesToForceResetBytes = ParseExceptionNames(v);
		});
		settings.ReadValueAndMonitorChanges((Settings s) => s.MemcachedClientForceResetBytesMaxAttempts, delegate(int v)
		{
			ForceResetBytesMaxAttempts = v;
		});
		settings.ReadValueAndMonitorChanges((Settings s) => s.MemcachedClientForceResetBytesMaxNumberOfBytes, delegate(int v)
		{
			ForceResetBytesMaxNumberOfBytes = v;
		});
		settings.ReadValueAndMonitorChanges((Settings s) => s.MemcachedClientLogVerboseExceptions, delegate(bool v)
		{
			LogVerboseExceptions = v;
		});
		settings.ReadValueAndMonitorChanges((Settings s) => s.IsMemcachedClientRespectingMaxPoolSizeEnabled, delegate(bool v)
		{
			IsRespectingMaxPoolSizeEnabled = v;
		});
		settings.ReadValueAndMonitorChanges((Settings s) => s.MemcachedClientUseRoundRobinSocketPoolSelection, delegate(bool v)
		{
			UseRoundRobinSocketPoolSelection = v;
		});
		settings.ReadValueAndMonitorChanges((Settings s) => s.MemcachedClientMaximumSelectionAttemptsForRoundRobin, delegate(int v)
		{
			MaximumSelectionAttemptsForRoundRobin = v;
		});
		settings.ReadValueAndMonitorChanges((Settings s) => s.MinPoolSize, delegate(uint v)
		{
			MinimumPoolSize = v;
		});
		settings.ReadValueAndMonitorChanges((Settings s) => s.MaxPoolSize, delegate(uint v)
		{
			MaximumPoolSize = v;
		});
		settings.ReadValueAndMonitorChanges((Settings s) => s.MemcachedSendReceiveTimeout, delegate(TimeSpan v)
		{
			SendReceiveTimeout = v;
		});
		settings.ReadValueAndMonitorChanges((Settings s) => s.MemcachedSocketRecycleAge, delegate(TimeSpan v)
		{
			SocketRecycleAge = v;
		});
		settings.ReadValueAndMonitorChanges((Settings s) => s.MemcachedCompressionThreshold, delegate(uint v)
		{
			CompressionThreshold = v;
		});
		settings.ReadValueAndMonitorChanges((Settings s) => s.IsUpgradedDnsResolvingEnabled, delegate(bool v)
		{
			IsUpgradedDnsResolvingEnabled = v;
		});
		settings.ReadValueAndMonitorChanges((Settings s) => s.NameserversCsv, delegate(string v)
		{
			Nameservers = ParseIpAddresses(v);
		});
		settings.ReadValueAndMonitorChanges((Settings s) => s.EndpointCacheExpiry, delegate(TimeSpan v)
		{
			EndpointCacheExpiry = v;
		});
		settings.ReadValueAndMonitorChanges((Settings s) => s.IsConnectionCreationRateLimitingEnabled, delegate(bool v)
		{
			IsConnectionCreationRateLimitingEnabled = v;
		});
		settings.ReadValueAndMonitorChanges((Settings s) => s.MaximumConnectionCreationsPerPeriod, delegate(int v)
		{
			MaximumConnectionCreationsPerPeriod = v;
		});
		settings.ReadValueAndMonitorChanges((Settings s) => s.ConnectionCreationRateLimitPeriodLength, delegate(TimeSpan v)
		{
			ConnectionCreationRateLimitPeriodLength = v;
		});
	}

	internal Dictionary<string, TimeSpan> ParseExpiryOverrides(string csv)
	{
		Dictionary<string, TimeSpan> dictionary = new Dictionary<string, TimeSpan>();
		try
		{
			string[] array = csv.Split(new char[1] { ',' });
			foreach (string text in array)
			{
				if (string.IsNullOrWhiteSpace(text))
				{
					continue;
				}
				string[] array2 = text.Split(new char[1] { '=' });
				if (array2.Length != 2)
				{
					_Logger.Error($"Invalid pair found in ExpiryOverride setting, expected host and expiry to be separated by equals sign: '{text}'");
					continue;
				}
				string text2 = array2[0].Trim();
				string text3 = array2[1].Trim();
				TimeSpan result;
				if (string.IsNullOrEmpty(text2))
				{
					_Logger.Error($"Invalid pair found in ExpiryOverride setting, invalid host: '{text2}'");
				}
				else if (!TimeSpan.TryParse(text3, out result))
				{
					_Logger.Error($"Invalid pair found in ExpiryOverride setting, invalid expiry timespan: '{text3}'");
				}
				else if (dictionary.ContainsKey(text2))
				{
					_Logger.Error($"Duplicate host '{text2}' found in ExpiryOverride setting, ignoring");
				}
				else
				{
					dictionary.Add(text2, result);
				}
			}
		}
		catch (Exception arg)
		{
			_Logger.Error($"Uncaught exception parsing ExpiryOverride setting! Returning incomplete results. Exception: {arg}");
		}
		return dictionary;
	}

	private HashSet<SocketError> ParseSocketErrors(string csv)
	{
		HashSet<SocketError> hashSet = new HashSet<SocketError>();
		try
		{
			string[] array = csv.Split(new char[1] { ',' });
			foreach (string text in array)
			{
				if (!string.IsNullOrWhiteSpace(text))
				{
					SocketError? socketError = EnumUtils.StrictTryParseEnum<SocketError>(text);
					if (socketError.HasValue)
					{
						hashSet.Add(socketError.Value);
					}
					else
					{
						_Logger.Error(string.Format("Invalid SocketError {0} in setting. Not going to be used for {1}", text, "SocketErrorsThatTripExecutionCircuitBreaker"));
					}
				}
			}
		}
		catch (Exception arg)
		{
			_Logger.Error($"Uncaught exception parsing SocketErrors csv setting! Returning incomplete results. Exception: {arg}");
		}
		return hashSet;
	}

	private HashSet<string> ParseExceptionNames(string csv)
	{
		try
		{
			return new HashSet<string>(from n in csv.Split(new char[1] { ',' })
				select n.Trim() into n
				where !string.IsNullOrWhiteSpace(n)
				select n);
		}
		catch (Exception arg)
		{
			_Logger.Error($"Error while parsing exception names: '{csv}' {arg}");
			return new HashSet<string>();
		}
	}

	private IPAddress[] ParseIpAddresses(string csv)
	{
		List<IPAddress> list = new List<IPAddress>();
		try
		{
			string[] array = csv.Split(',', ';');
			foreach (string text in array)
			{
				if (!string.IsNullOrWhiteSpace(text))
				{
					if (IPAddress.TryParse(text.Trim(), out var address))
					{
						list.Add(address);
					}
					else
					{
						_Logger.Error($"Failed to parse IP Address {text}");
					}
				}
			}
		}
		catch (Exception arg)
		{
			_Logger.Error($"Uncaught exception parsing IPAddresses setting! Returning incomplete results. Exception: {arg}");
		}
		return list.ToArray();
	}
}
