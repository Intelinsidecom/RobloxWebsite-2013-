using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using Amazon;
using Amazon.SQS;
using Roblox.Amazon.Sqs;
using Roblox.Configuration;
using Roblox.Platform.Core;
using Roblox.Thumbs.Properties;

namespace Roblox.Thumbs;

public class ThumbnailDependenciesInvalidator : DomainObjectBase<ThumbnailDomainFactories>, IThumbnailDependenciesInvalidator
{
	private const int _MaximumRowsPerDatabaseTrip = 100;

	private readonly IRobloxSqsClientFactory _SqsClientFactory;

	private IAmazonSQS _SqsClient;

	private readonly ConcurrentDictionary<long, byte> _TemporarilySkipAssetThumbnailInvalidation = new ConcurrentDictionary<long, byte>();

	public ThumbnailDependenciesInvalidator(ThumbnailDomainFactories domainFactories)
		: base(domainFactories)
	{
		_SqsClientFactory = RobloxSqsClientFactory.Instance;
		_SqsClient = CreateAmazonSqsClient();
		_SqsClientFactory.DefaultClientSettingsChanged += OnSqsClientDefaultSettingsChange;
		Settings.Default.MonitorChanges((Settings s) => s.AwsAccessKey, OnSqsClientAwsCredentialsChange);
		Settings.Default.MonitorChanges((Settings s) => s.AwsSecretAccessKey, OnSqsClientAwsCredentialsChange);
	}

	public void AddAssetIdToTemporaryThumbnailInvalidationSkipList(long assetId)
	{
		_TemporarilySkipAssetThumbnailInvalidation.TryAdd(assetId, 0);
	}

	public void Register()
	{
		AssetHash.ApprovalChanged += InvalidateAssetsOnApprovalChange;
		AssetVersion.VersionChanged += delegate(Roblox.Asset asset)
		{
			AssetReference assetReference = new AssetReference(asset, AssetReference.AssetReferenceTypes.AssetSubscription);
			if (ShouldInvalidateAssetThumbnail(asset.ID))
			{
				InvalidateThumbnailsForAssetReferenceId(assetReference.ID);
			}
			else
			{
				RemoveAssetIdFromTemporaryThumbnailInvalidationSkipList(asset.ID);
			}
		};
	}

	private IAmazonSQS CreateAmazonSqsClient()
	{
		return _SqsClientFactory.Create(Settings.Default.AwsAccessKey, Settings.Default.AwsSecretAccessKey, RegionEndpoint.USEast1, "ThumbnailDependenciesInvalidator");
	}

	private void OnSqsClientDefaultSettingsChange(RobloxSqsClientDefaultSettings defaultSettings)
	{
		try
		{
			_SqsClient = CreateAmazonSqsClient();
		}
		catch (Exception)
		{
		}
	}

	private void OnSqsClientAwsCredentialsChange()
	{
		try
		{
			_SqsClient = CreateAmazonSqsClient();
		}
		catch (Exception)
		{
		}
	}

	private bool ShouldInvalidateAssetThumbnail(long assetId)
	{
		byte val;
		return !_TemporarilySkipAssetThumbnailInvalidation.TryGetValue(assetId, out val);
	}

	private void RemoveAssetIdFromTemporaryThumbnailInvalidationSkipList(long assetId)
	{
		_TemporarilySkipAssetThumbnailInvalidation.TryRemove(assetId, out var _);
	}

	private void InvalidateAssetsOnApprovalChange(long assetHashId)
	{
		RobloxThreadPool.QueueUserWorkItem(delegate
		{
			int num = 0;
			HashSet<long> hashSet = new HashSet<long>();
			int num2;
			do
			{
				num2 = 0;
				int startRowIndex = 100 * num;
				foreach (AssetVersion current in AssetVersion.GetAssetVersionsPagedByAssetHashID(assetHashId, startRowIndex, 100))
				{
					AssetReference assetReference = new AssetReference(current, AssetReference.AssetReferenceTypes.AssetVersion);
					InvalidateThumbnailsForAssetReferenceId(assetReference.ID);
					hashSet.Add(current.AssetID);
					num2++;
				}
				num++;
			}
			while (num2 == 100);
			foreach (long item in hashSet)
			{
				AssetReference assetReference2 = new AssetReference(Roblox.Asset.Get(item), AssetReference.AssetReferenceTypes.AssetSubscription);
				InvalidateThumbnailsForAssetReferenceId(assetReference2.ID);
			}
			if (AssetHash.Get(assetHashId).AssetTypeID == AssetType.ImageID)
			{
				base.DomainFactories.ThumbnailInvalidator.InvalidateThumbnailsByAssetHashIds(assetHashId);
			}
		});
	}

	/// <summary>
	/// Invalidates all thumbnails for a given AssetRefID, in other words, Invalidates Thumbnails based on AssetVersion or AssetSubscription but not both
	/// </summary>
	private void InvalidateThumbnailsForAssetReferenceId(long assetReferenceId)
	{
		SqsOperations.SendSingleMessage(_SqsClient, Settings.Default.InvalidationQueueUrl, assetReferenceId.ToString());
	}
}
