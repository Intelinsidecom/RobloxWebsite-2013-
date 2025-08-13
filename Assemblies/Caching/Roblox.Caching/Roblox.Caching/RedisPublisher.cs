using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Roblox.Redis;
using StackExchange.Redis;

namespace Roblox.Caching;

internal class RedisPublisher
{
	private class WorkItem : IRetriableItem
	{
		public string EntityType { get; set; }

		public string Message { get; set; }

		public int CurrentAttempt { get; set; }

		public override string ToString()
		{
			return $"Message:{Message}_EntityType:{EntityType}_CurrentAttempt:{CurrentAttempt}";
		}
	}

	private readonly BlockingCollection<WorkItem> _OutgoingMessages;

	private int _RoundRobinSlot;

	private IReadOnlyCollection<ISubscriber> _Publishers;

	private readonly IRedisInvalidationSettingsProvider _RedisInvalidationSettingsProvider;

	private bool _IsRunning;

	public event Action<string> PublishCompleted;

	public event Action<Exception> ExceptionOccured;

	public event Action<string> QueueOverflowed;

	public RedisPublisher(IReadOnlyCollection<ISubscriber> publishers, IRedisInvalidationSettingsProvider settingsProvider)
	{
		_Publishers = publishers;
		_RedisInvalidationSettingsProvider = settingsProvider;
		_OutgoingMessages = new BlockingCollection<WorkItem>(_RedisInvalidationSettingsProvider.GetInvalidationPublisherQueueSize());
	}

	public void Start()
	{
		if (!_IsRunning)
		{
			_IsRunning = true;
			Initialize();
		}
	}

	public void Stop()
	{
		_IsRunning = false;
	}

	public void PublishMessage(string message, string entityType)
	{
		if (_IsRunning)
		{
			WorkItem workItem = new WorkItem
			{
				Message = message,
				CurrentAttempt = 0,
				EntityType = entityType
			};
			AddToQueue(workItem);
		}
	}

	public void OnPubSubHandlesAdded(IReadOnlyCollection<ISubscriber> addedPublishers)
	{
		List<ISubscriber> list = new List<ISubscriber>(_Publishers);
		list.AddRange(addedPublishers);
		_Publishers = list;
	}

	public void OnPubSubHandlesRemoved(IReadOnlyCollection<ISubscriber> removedPublishers)
	{
		Dictionary<string, ISubscriber> publishersDictionary = removedPublishers.ToDictionary((ISubscriber pub) => pub.Multiplexer.GetIpPortCombo());
		List<ISubscriber> publishers = _Publishers.Where((ISubscriber publisher) => !publishersDictionary.ContainsKey(publisher.Multiplexer.GetIpPortCombo())).ToList();
		_Publishers = publishers;
	}

	private void Initialize()
	{
		Task.Factory.StartNew(delegate
		{
			while (_IsRunning)
			{
				try
				{
					WorkItem workItem = _OutgoingMessages.Take();
					ProcessWorkItem(workItem);
				}
				catch (ThreadAbortException)
				{
				}
				catch (Exception obj)
				{
					this.ExceptionOccured?.Invoke(obj);
				}
			}
		}, TaskCreationOptions.LongRunning);
	}

	private async void ProcessWorkItem(WorkItem workItem)
	{
		ISubscriber publisherByRoundRobin = GetPublisherByRoundRobin();
		if (publisherByRoundRobin == null)
		{
			AddToQueue(workItem);
			return;
		}
		string entityType = workItem.EntityType;
		try
		{
			await publisherByRoundRobin.PublishAsync(entityType, workItem.Message);
		}
		catch (Exception obj)
		{
			if (workItem.CurrentAttempt < _RedisInvalidationSettingsProvider.GetNumberOfAttemptsForInvalidationMessageDelivery())
			{
				workItem.CurrentAttempt++;
				AddToQueue(workItem);
			}
			else
			{
				this.ExceptionOccured?.Invoke(obj);
			}
			return;
		}
		this.PublishCompleted?.Invoke(workItem.Message);
	}

	private ISubscriber GetPublisherByRoundRobin()
	{
		try
		{
			IReadOnlyCollection<ISubscriber> publishers = _Publishers;
			int count = publishers.Count;
			if (count == 0)
			{
				this.ExceptionOccured?.Invoke(new Exception("Fatal exception: No publishers to publish Redis invalidations with"));
				return null;
			}
			int index = Math.Abs(Interlocked.Increment(ref _RoundRobinSlot) % count);
			return publishers.ElementAt(index);
		}
		catch (Exception obj)
		{
			this.ExceptionOccured?.Invoke(obj);
		}
		return null;
	}

	private void AddToQueue(WorkItem workItem)
	{
		if (!_OutgoingMessages.TryAdd(workItem))
		{
			this.QueueOverflowed?.Invoke(workItem.Message);
		}
	}
}
