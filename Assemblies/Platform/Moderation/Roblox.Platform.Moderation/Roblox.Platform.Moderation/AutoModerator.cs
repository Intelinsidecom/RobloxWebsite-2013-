using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;
using Roblox.Moderation.Properties;

namespace Roblox.Moderation;

internal class AutoModerator
{
	private static readonly BlockingCollection<object> _ModerationTasksQueue;

	internal static readonly HashSet<byte> SkippableAbuseTypes;

	static AutoModerator()
	{
		_ModerationTasksQueue = new BlockingCollection<object>();
		SkippableAbuseTypes = new HashSet<byte>
		{
			AbuseType.Profanity.ID,
			AbuseType.Inappropriate.ID,
			AbuseType.Advertisement.ID,
			AbuseType.Spam.ID
		};
		for (int i = 0; i < Settings.Default.NumberOfThreads; i++)
		{
			Task.Factory.StartNew(delegate
			{
				while (true)
				{
					try
					{
						object obj = _ModerationTasksQueue.Take();
						if (obj is AssetApprovalTask)
						{
							HandleAssetApproval((AssetApprovalTask)obj);
						}
					}
					catch (Exception ex)
					{
						ExceptionHandler.LogException(ex);
					}
				}
			}, TaskCreationOptions.LongRunning);
		}
	}

	private static void HandleAssetApproval(AssetApprovalTask assetApprovalTask)
	{
		assetApprovalTask.ReviewableAsset.SetApproval(assetApprovalTask.IsApproved, isReviewed: true);
		AssetReviewTask assetReviewTask = AssetReviewTask.Get(AssetReviewTask.LookupFilter.AssetHashID, assetApprovalTask.ReviewableAsset.HashID);
		assetReviewTask.ModeratorID = assetApprovalTask.ModeratorID;
		assetReviewTask.Reviewed = DateTime.Now;
		assetReviewTask.Save();
	}

	internal static void RequestAssetApproval(AssetApprovalTask task)
	{
		_ModerationTasksQueue.Add(task);
	}
}
