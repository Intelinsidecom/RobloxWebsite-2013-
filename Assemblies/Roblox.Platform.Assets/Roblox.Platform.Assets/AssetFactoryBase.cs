using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Agents;
using Roblox.Assets.Client;
using Roblox.Configuration;
using Roblox.Platform.Assets.Entities;
using Roblox.Platform.Assets.Entities.AssetHash;
using Roblox.Platform.Assets.Entities.Audit;
using Roblox.Platform.Assets.Properties;
using Roblox.Platform.Core;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Assets;

public abstract class AssetFactoryBase<T> : IAssetFactoryBase<T> where T : IAsset
{
	protected readonly IAssetDependenciesConfigurationProvider _AssetDependenciesConfigurationProvider;

	private int AssetDescriptionMaxCharacterCount => Settings.Default.AssetDescriptionMaxCharacterCount;

	protected AssetDomainFactories DomainFactories { get; }

	protected abstract int AssetTypeId { get; }

	protected Uri AssetUrl => new Uri($"{RobloxEnvironment.WebsiteUrl}/asset/");

	protected AssetFactoryBase(AssetDomainFactories domainFactories)
	{
		DomainFactories = domainFactories ?? throw new PlatformArgumentNullException("domainFactories");
		_AssetDependenciesConfigurationProvider = new AssetDependenciesConfigurationProvider();
	}

	protected abstract T BuildChildAsset(IAsset genericAsset);

	internal virtual IAssetEntity CreateEntity(ITrustedAssetTextInfo trustedAssetTextInfo, AssetCreatorInfo assetCreatorInfo, IRawContent rawContent, IUserIdentifier actorUserIdentity)
	{
		Roblox.AssetType assetTypeEntity = Roblox.AssetType.MustGet(AssetTypeId);
		IAgent creatorAgent = DomainFactories.AgentFactory.GetByAgentTypeAndAgentTargetId(assetCreatorInfo.CreatorType.ToAgentType(), assetCreatorInfo.CreatorTargetId);
		ICreator creator = CreatorRef.CreateNewRefFromAgentId(creatorAgent.Id).GetCreator();
		IAssetHashEntity assetHash = DomainFactories.AssetHashEntityFactory.GetOrCreate(assetTypeEntity.ID, rawContent.Md5Hash, creator);
		DataUpdateResult<IAssetEntity, IAssetsAuditEntryEntity> result = DomainFactories.AssetEntityFactory.Create(assetTypeEntity, assetHash, trustedAssetTextInfo, creatorAgent);
		OnCreated(result.AuditEntryEntity, actorUserIdentity);
		return result.DataEntity;
	}

	internal void OnCreated(IAssetsAuditEntryEntity auditEntryEntity, IUserIdentifier actorUserIdentity)
	{
		if (auditEntryEntity != null)
		{
			DomainFactories.AssetsAuditMetadataEntityFactory.CreateNew(auditEntryEntity, AssetChangeType.TextSaved, actorUserIdentity);
		}
	}

	public T CheckedGet(long id)
	{
		T val = Get(id);
		val.VerifyIsNotNull();
		return val;
	}

	private ITrustedAssetTextInfo FilterText(IAssetNameAndDescription assetNameAndDescription)
	{
		AssetTextFilterRequestV2 filterRequest = new AssetTextFilterRequestV2(assetNameAndDescription, (AssetType)AssetTypeId);
		IAssetTextFilterResult filteredText = DomainFactories.AssetTextFilter.FilterAssetText(filterRequest);
		return new TrustedAssetTextInfo(filteredText.Name, filteredText.Description);
	}

	private void CheckDescriptionLength(string description)
	{
		if (!string.IsNullOrEmpty(description) && description.Length > AssetDescriptionMaxCharacterCount)
		{
			throw new LongDescriptionException($"The description is {description.Length} characters long but the max is {AssetDescriptionMaxCharacterCount}.");
		}
	}

	/// <summary>
	/// Assets that need text filtering should be created using this method.
	/// </summary>
	public T Create(IAssetNameAndDescription assetNameAndDescription, AssetCreatorInfo assetCreatorInfo, StreamCreatorInfo stream, IUserIdentifier actorUserIdentity)
	{
		CheckDescriptionLength(assetNameAndDescription.Description);
		ITrustedAssetTextInfo trustedAssetTextInfo = FilterText(assetNameAndDescription);
		return Create(trustedAssetTextInfo, assetCreatorInfo, stream, actorUserIdentity);
	}

	/// <summary>
	/// Assets that could bypass text filtering can be created using this method.
	/// This method should be called from the implementing typed asset factories.
	/// </summary>
	protected T Create(ITrustedAssetTextInfo trustedAssetTextInfo, AssetCreatorInfo assetCreatorInfo, StreamCreatorInfo stream, IUserIdentifier actorUserIdentity, string localeCodeOverride = null)
	{
		CheckDescriptionLength(trustedAssetTextInfo.Description);
		IRawContent rawContent = DomainFactories.RawContentFactory.GetOrCreate(AssetTypeId, assetCreatorInfo.CreatorType, assetCreatorInfo.CreatorTargetId, stream.Content, stream.DecompressionMethod, stream.ExpectedContentSize, stream.ExpectedContentHash, stream.MimeType);
		return Create(trustedAssetTextInfo, assetCreatorInfo, rawContent, actorUserIdentity, localeCodeOverride);
	}

	/// <summary>
	/// Assets that need text filtering should be created using this method.
	/// </summary>
	public T Create(IAssetNameAndDescription assetNameAndDescription, AssetCreatorInfo assetCreatorInfo, IRawContent rawContent, IUserIdentifier actorUserIdentity)
	{
		CheckDescriptionLength(assetNameAndDescription.Description);
		ITrustedAssetTextInfo trustedAssetTextInfo = FilterText(assetNameAndDescription);
		return Create(trustedAssetTextInfo, assetCreatorInfo, rawContent, actorUserIdentity);
	}

	public T CreateWithDependency(IAssetNameAndDescription assetNameAndDescription, AssetCreatorInfo assetCreatorInfo, IRawContent rawContent, IUserIdentifier actorUserIdentity, IImage image, AssetType dependsAssetType)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		T createdAsset = Create(assetNameAndDescription, assetCreatorInfo, rawContent, actorUserIdentity);
		if (_AssetDependenciesConfigurationProvider.IsCreateAssetDependencyAllowedForAsset(createdAsset.Id))
		{
			bool createDependencyResult = true;
			try
			{
				createDependencyResult = DomainFactories.AssetsClient.CreateAssetDependency(new CreateAssetDependencyRequest
				{
					DependsAssetId = createdAsset.Id.ToString(),
					DependsAssetType = dependsAssetType,
					DependsAssetVersionNumber = DomainFactories.AssetVersionFactory.GetCurrentAssetPublishedVersion(createdAsset).VersionNumber,
					SupportsAssetId = image.Id.ToString(),
					SupportsAssetType = (AssetType)0,
					SupportsAssetVersionNumber = DomainFactories.AssetVersionFactory.GetCurrentAssetPublishedVersion(image).VersionNumber
				});
			}
			catch (Exception ex)
			{
				DomainFactories.Logger.Error(ex);
				if (Settings.Default.ShouldOperationFailIfAssetDependenciesServiceFails)
				{
					throw new AssetDependencyCreationFailureException($"Creation of dependency between asset with ID {createdAsset.Id} and ID {image.Id} failed.{ex}");
				}
			}
			if (Settings.Default.ShouldOperationFailIfAssetDependenciesServiceFails && !createDependencyResult)
			{
				throw new AssetDependencyCreationFailureException($"Creation of dependency between asset with ID {createdAsset.Id} and ID {image.Id} failed.");
			}
		}
		return createdAsset;
	}

	/// <summary>
	/// Assets that could bypass text filtering can be created using this method.
	/// This method should be called from the implementing typed asset factories.
	/// </summary>
	protected T Create(ITrustedAssetTextInfo trustedAssetTextInfo, AssetCreatorInfo assetCreatorInfo, IRawContent rawContent, IUserIdentifier actorUserIdentity, string localeCodeOverride = null)
	{
		CheckDescriptionLength(trustedAssetTextInfo.Description);
		IAssetEntity assetEntity = CreateEntity(trustedAssetTextInfo, assetCreatorInfo, rawContent, actorUserIdentity);
		IAsset genericAsset = DomainFactories.AssetFactoryInternal.GetGenericAsset(assetEntity, assetCreatorInfo);
		T childAsset = BuildChildAsset(genericAsset);
		DomainFactories.AssetVersionFactoryInternal.Create(childAsset, assetCreatorInfo.CreatorType, assetCreatorInfo.CreatorTargetId, rawContent, null, assetCreatorInfo.CreatingUniverseId, assetCreatorInfo.CreationContext, isSavedVersionOnly: false, localeCodeOverride);
		return childAsset;
	}

	public T Get(long id)
	{
		IAsset asset = DomainFactories.AssetFactoryInternal.GetGenericAsset(id);
		if (asset == null)
		{
			return default(T);
		}
		if (asset.TypeId != AssetTypeId)
		{
			return default(T);
		}
		return BuildChildAsset(asset);
	}

	/// <inheritdoc cref="M:Roblox.Platform.Assets.IAssetFactoryBase`1.Get(System.Collections.Generic.IReadOnlyCollection{System.Int64},System.Boolean)" />
	public IEnumerable<T> Get(IReadOnlyCollection<long> ids, bool filterNulls = false)
	{
		IAsset[] assets = DomainFactories.AssetFactoryInternal.GetGenericAssets(ids).ToArray();
		if (filterNulls)
		{
			return assets.Where((IAsset a) => a?.TypeId == AssetTypeId).Select(BuildChildAsset);
		}
		return assets.Where((IAsset a) => a.TypeId == AssetTypeId).Select(BuildChildAsset);
	}
}
