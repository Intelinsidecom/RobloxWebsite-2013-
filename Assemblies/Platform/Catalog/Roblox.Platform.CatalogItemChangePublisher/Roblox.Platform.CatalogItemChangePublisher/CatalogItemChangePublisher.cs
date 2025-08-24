using System;
using System.Collections.Generic;
using System.Threading;
using Newtonsoft.Json;
using Roblox.Amazon.Sqs;
using Roblox.CatalogItemChangePublisher.Properties;

namespace Roblox.CatalogItemChangePublisher;

public class CatalogItemChangePublisher : ICatalogItemChangePublisher
{
	private static SqsBatchSender _DelayedBatchSender;

	private static SqsBatchSender _BatchSender;

	public static long EnqueueCount;

	public static long CompletedCount;

	private static CatalogItemChangePublisher internalObject;

	private static object locker;

	public static CatalogItemChangePublisher Singleton
	{
		get
		{
			if (internalObject == null)
			{
				lock (locker)
				{
					if (internalObject == null)
					{
						internalObject = new CatalogItemChangePublisher();
					}
				}
			}
			return internalObject;
		}
	}

	public static event Action<ICollection<string>> BatchCompleted;

	private static void OnBatchComplete(ICollection<string> args)
	{
		EnqueueCount -= args.Count;
		CompletedCount += args.Count;
	}

	static CatalogItemChangePublisher()
	{
		EnqueueCount = 0L;
		CompletedCount = 0L;
		locker = new object();
		Settings.Default.PropertyChanged += delegate
		{
			EnqueueCount = 0L;
			CompletedCount = 0L;
			if (_DelayedBatchSender != null)
			{
				_DelayedBatchSender.Stop();
				_DelayedBatchSender = null;
			}
			if (_BatchSender != null)
			{
				_BatchSender.Stop();
				_BatchSender = null;
			}
		};
		BatchCompleted += OnBatchComplete;
	}

	private void EnsureSendersAreInitializedAndIncrementEnqueueCount()
	{
		LazyInitializer.EnsureInitialized(ref _DelayedBatchSender, delegate
		{
			SqsBatchSender sqsBatchSender2 = new SqsBatchSender(Settings.Default.AwsAccessKey, Settings.Default.AwsSecretAccessKey, Settings.Default.AmazonSqsUrl, 10, 100, (int)Settings.Default.LeaseDelay.TotalSeconds, retryInOtherRegions: true);
			sqsBatchSender2.ExceptionOccured += ExceptionHandler.LogException;
			sqsBatchSender2.BatchCompleted += CatalogItemChangePublisher.BatchCompleted;
			sqsBatchSender2.Start();
			return sqsBatchSender2;
		});
		LazyInitializer.EnsureInitialized(ref _BatchSender, delegate
		{
			SqsBatchSender sqsBatchSender = new SqsBatchSender(Settings.Default.AwsAccessKey, Settings.Default.AwsSecretAccessKey, Settings.Default.AmazonSqsUrl, 10, 100, 0, retryInOtherRegions: true);
			sqsBatchSender.ExceptionOccured += ExceptionHandler.LogException;
			sqsBatchSender.BatchCompleted += CatalogItemChangePublisher.BatchCompleted;
			sqsBatchSender.Start();
			return sqsBatchSender;
		});
		EnqueueCount++;
	}

	public void Publish(long assetId, bool useDelay = false)
	{
		EnsureSendersAreInitializedAndIncrementEnqueueCount();
		string message = assetId.ToString();
		(useDelay ? _DelayedBatchSender : _BatchSender).SendMessage(message);
	}

	public void Publish(long targetId, CatalogItemType catalogItemType, bool useDelay = false)
	{
		EnsureSendersAreInitializedAndIncrementEnqueueCount();
		string message = JsonConvert.SerializeObject(new CatalogItemChangeEvent(targetId, catalogItemType));
		(useDelay ? _DelayedBatchSender : _BatchSender).SendMessage(message);
	}
}
