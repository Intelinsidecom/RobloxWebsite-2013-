using System;
using System.Threading.Tasks;
using Roblox.DurableCounters.Client;
using Roblox.EventLog;

namespace Roblox.Platform.Counters;

/// <summary>
/// The default implementation of an <see cref="T:Roblox.Platform.Counters.ICounter" />
/// </summary>
internal class Counter : ICounter
{
	private readonly IDurableCountersClient _DurableCountersClient;

	private readonly string _CounterKey;

	internal Counter(IDurableCountersClient client, string counterKey, ILogger logger)
	{
		_DurableCountersClient = client ?? throw new ArgumentNullException("client");
		_CounterKey = counterKey ?? throw new ArgumentNullException("counterKey");
	}

	/// <inheritdoc />
	public void Increment(double value = 1.0)
	{
		_DurableCountersClient.Increment(_CounterKey, value, (CounterType)32, (DateTime?)null);
	}

	/// <inheritdoc />
	public void Decrement(double value = 1.0)
	{
		_DurableCountersClient.Decrement(_CounterKey, value, (CounterType)32, (DateTime?)null);
	}

	/// <inheritdoc />
	public double GetCount(bool useCache = true, TimeSpan? cacheDuration = null)
	{
		return _DurableCountersClient.GetCount(_CounterKey, (CounterType)32, (DateTime?)null, (DateTime?)null, true, (TimeSpan?)null);
	}

	/// <inheritdoc />
	public string GetKey()
	{
		return _CounterKey;
	}

	/// <inheritdoc />
	public void IncrementInBackground(double value = 1.0, Action<Exception> exceptionHandler = null)
	{
		QueueDurableCountersApiCall(delegate
		{
			Increment(value);
		}, exceptionHandler);
	}

	/// <inheritdoc />
	public void DecrementInBackground(double value = 1.0, Action<Exception> exceptionHandler = null)
	{
		QueueDurableCountersApiCall(delegate
		{
			Decrement(value);
		}, exceptionHandler);
	}

	protected void QueueDurableCountersApiCall(Action action, Action<Exception> errorLogger = null)
	{
		Task.Factory.StartNew(delegate
		{
			try
			{
				action();
			}
			catch (Exception obj)
			{
				if (errorLogger != null)
				{
					try
					{
						errorLogger(obj);
						return;
					}
					catch
					{
						return;
					}
				}
			}
		});
	}
}
