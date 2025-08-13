using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;

namespace Roblox.Caching;

internal class RetryQueue<T> where T : IRetriableItem
{
	private readonly Action<T> _RetryAction;

	private readonly ConcurrentQueue<T> _Queue = new ConcurrentQueue<T>();

	private readonly Timer _Timer;

	public int MaxAttempts { get; set; }

	public int RetryIntervalInMilliseconds { get; set; }

	internal event Action<T> OnSuccessfulAttempt;

	internal event Action<Exception> OnFatalFailure;

	public RetryQueue(Action<T> retryAction, int maxAttempts, int retryIntervalInMilliseconds)
	{
		_RetryAction = retryAction;
		MaxAttempts = maxAttempts;
		RetryIntervalInMilliseconds = retryIntervalInMilliseconds;
		_Timer = new Timer(Retry, null, RetryIntervalInMilliseconds, RetryIntervalInMilliseconds);
	}

	public void AddItem(T item)
	{
		_Queue.Enqueue(item);
	}

	private void Retry(object context)
	{
		try
		{
			_Timer.Change(-1, -1);
			Queue<T> queue = new Queue<T>();
			T result;
			while (_Queue.TryDequeue(out result))
			{
				if (result.CurrentAttempt < MaxAttempts)
				{
					result.CurrentAttempt++;
					try
					{
						_RetryAction(result);
						this.OnSuccessfulAttempt?.Invoke(result);
					}
					catch (Exception)
					{
						queue.Enqueue(result);
					}
				}
				else
				{
					this.OnFatalFailure?.Invoke(new Exception("Fatal exception in redis subscription" + result));
				}
			}
			foreach (T item in queue)
			{
				_Queue.Enqueue(item);
			}
		}
		catch (Exception innerException)
		{
			this.OnFatalFailure?.Invoke(new Exception("Fatal exception in redis retry queue", innerException));
		}
		_Timer.Change(RetryIntervalInMilliseconds, RetryIntervalInMilliseconds);
	}
}
