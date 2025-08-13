using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using Roblox.Agents;
using Roblox.Assets.Client;
using Roblox.Data;
using Roblox.DataV2.Core;
using Roblox.Platform.Assets.Entities;
using Roblox.Platform.Assets.Events;
using Roblox.Platform.Assets.Properties;
using Roblox.Platform.Core;
using Roblox.Platform.Core.ExclusiveStartPaging;
using Roblox.Properties;

namespace Roblox.Platform.Assets;

public class AssetVersionFactory : IAssetVersionFactory_Internal, IAssetVersionFactory
{
	private readonly AssetDomainFactories _DomainFactories;

	private readonly IAssetVersionsConfigurationProvider _AssetVersionsConfigurationProvider;

	private static IAssetVersionFactory_Internal _Singleton;

	private ISettings Settings => _DomainFactories.Settings;

	[Obsolete("Use AssetDomainFactories.AssetVersionFactoryInternal instead")]
	internal static IAssetVersionFactory_Internal Singleton
	{
		get
		{
			if (_Singleton == null)
			{
				_Singleton = Factories.DomainFactories.AssetVersionFactoryInternal;
			}
			return _Singleton;
		}
		set
		{
			_Singleton = value;
		}
	}

	[Obsolete("Use AssetDomainFactories.AssetVersionFactory instead")]
	public static IAssetVersionFactory GetSingleton()
	{
		return Singleton;
	}

	/// <summary>
	/// Constructor.
	/// </summary>
	/// <param name="domainFactories">Asset domain factories.</param>
	internal AssetVersionFactory(AssetDomainFactories domainFactories)
		: this(domainFactories, new AssetVersionsConfigurationProvider())
	{
	}

	/// <summary>
	/// Constructor with injected configuration provider for unit testing.
	/// </summary>
	/// <param name="domainFactories">Asset domain factories.</param>
	/// <param name="assetVersionsConfigurationProvider">Configuration for publishing and servind asset versions.</param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="domainFactories" />, <paramref name="assetVersionsConfigurationProvider" /></exception>
	internal AssetVersionFactory(AssetDomainFactories domainFactories, IAssetVersionsConfigurationProvider assetVersionsConfigurationProvider)
	{
		_DomainFactories = domainFactories ?? throw new ArgumentNullException("domainFactories");
		_AssetVersionsConfigurationProvider = assetVersionsConfigurationProvider ?? throw new ArgumentNullException("assetVersionsConfigurationProvider");
	}

	public IAssetVersion Create(IAsset asset, CreatorType creatorType, long creatorTargetId, IAssetVersion parentAssetVersion, Stream content, DecompressionMethods decompressionMethod = DecompressionMethods.None, int? expectedContentSize = null, string expectedContentHash = null, long? creatingUniverseId = null, CreationContextType? creationContext = null, string mimeType = null, bool isSavedVersionOnly = false)
	{
		asset.VerifyCreatingUniverseId(creatingUniverseId);
		IRawContent rawContent = _DomainFactories.RawContentFactory.GetOrCreate(asset.TypeId, creatorType, creatorTargetId, content, decompressionMethod, expectedContentSize, expectedContentHash, mimeType);
		return Create(asset, creatorType, creatorTargetId, rawContent, parentAssetVersion, creatingUniverseId, creationContext, isSavedVersionOnly);
	}

	public IAssetVersion Create(IAsset asset, CreatorType creatorType, long creatorTargetId, IRawContent rawContent, IAssetVersion parentAssetVersion, long? creatingUniverseId, CreationContextType? creationContext = null, bool isSavedVersionOnly = false, string localeCodeOverride = null)
	{
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		asset.VerifyCreatingUniverseId(creatingUniverseId);
		if (isSavedVersionOnly)
		{
			IAssetVersion currentSavedVersion = GetCurrentAssetSavedVersion(asset);
			if (currentSavedVersion != null && currentSavedVersion.RawContentId == rawContent.Id)
			{
				return currentSavedVersion;
			}
		}
		else
		{
			IAssetVersion currentPublishedVersion = GetCurrentAssetPublishedVersion(asset);
			if (currentPublishedVersion != null && currentPublishedVersion.RawContentId == rawContent.Id)
			{
				return currentPublishedVersion;
			}
		}
		CreatorRef creatorRef = LoadCreatorRef(creatorType, creatorTargetId);
		Roblox.AssetVersion assetVersionEntity = CreateAssetVersionForAssetAndCreator(asset, rawContent, parentAssetVersion, creatingUniverseId, creatorRef);
		UpdateCreationContextForAsset(asset, creatorType, creatorTargetId, creatingUniverseId, creationContext);
		if (_DomainFactories.Settings.IsAssetVersionIdSetToZeroLoggingEnabled)
		{
			try
			{
				if (_DomainFactories.AssetEntityFactory.Get(asset.Id)._EntityDAL.CurrentVersionID == 0L)
				{
					_DomainFactories.Logger.Error($"Current Version Id for {asset.Id} is set to 0");
				}
			}
			catch
			{
			}
		}
		asset.UpdateUpdated();
		if (_DomainFactories.Settings.IsAssetVersionIdSetToZeroLoggingEnabled)
		{
			try
			{
				if (_DomainFactories.AssetEntityFactory.Get(asset.Id)._EntityDAL.CurrentVersionID == 0L)
				{
					_DomainFactories.Logger.Error($"Current Version Id for {asset.Id} is set to 0");
				}
			}
			catch
			{
			}
		}
		IAssetVersion assetVersion = GetAssetVersion(assetVersionEntity);
		AssetType? platformAssetType = _DomainFactories.AssetTypeFactory.GetAssetType(asset.TypeId);
		if (!platformAssetType.HasValue)
		{
			throw new ArgumentException($"Invalid Asset type Id {asset.TypeId}");
		}
		if (_AssetVersionsConfigurationProvider.IsPublishToAssetPublishedVersionsEnabledForAssetType(platformAssetType.Value) && (!isSavedVersionOnly || !Settings.IsCloudSavedGamesEnabled) && assetVersion != null)
		{
			if (!Enum.TryParse<AssetType>(platformAssetType.Value.ToString(), out AssetType clientAssetType))
			{
				throw new ArgumentException($"Invalid Asset type {platformAssetType}");
			}
			_DomainFactories.AssetsClient.CreateAssetPublishedVersion(clientAssetType, assetVersion.AssetId.ToString(CultureInfo.InvariantCulture), (long)assetVersion.VersionNumber, assetVersion.CreatorTargetId.ToString(CultureInfo.InvariantCulture), assetVersion.CreatorType.ToString());
		}
		_DomainFactories.AssetVersionCreationEventPublisher.Publish(assetVersion, localeCodeOverride);
		if (Roblox.Platform.Assets.Properties.Settings.Default.IsAssetVersionChangeReportingToAllGamesESEnabled)
		{
			_DomainFactories.AssetChangeReporter.EntityChanged(asset.Id, asset.TypeId, Roblox.Platform.Assets.Events.AssetChangeType.VersionChanged);
		}
		return assetVersion;
	}

	/// <inheritdoc />
	public IAssetVersion GetCurrentPlacePublishedVersion(IAsset place)
	{
		return GetCurrentAssetPublishedVersion(place);
	}

	/// <inheritdoc />
	public IAssetVersion GetCurrentPlacePublishedVersion(IAsset place, bool isJvRequest)
	{
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		if (isJvRequest && Settings.IsJvDelayedPlaceLaunchEnabled)
		{
			AssetType? assetType = _DomainFactories.AssetTypeFactory.GetAssetType(place.TypeId);
			if (!assetType.HasValue)
			{
				throw new ArgumentException($"Invalid Asset type Id {place.TypeId}");
			}
			if (!Enum.TryParse<AssetType>(assetType.Value.ToString(), out AssetType clientAssetType))
			{
				throw new ArgumentException($"Invalid Asset type {assetType}");
			}
			DateTime expectedLatestTime = DateTime.UtcNow.Subtract(Settings.JvPlaceLaunchDelayTimeSpan);
			expectedLatestTime = RoundUpJvDateTime(expectedLatestTime);
			GetCurrentAssetPublishedVersionResponse response = _DomainFactories.AssetsClient.GetCurrentAssetPublishedVersion(clientAssetType, place.Id.ToString(CultureInfo.InvariantCulture), (DateTime?)expectedLatestTime);
			IAssetVersionFactory assetVersionFactory = _DomainFactories.AssetVersionFactory;
			AssetPublishedVersion assetPublishedVersion = response.AssetPublishedVersion;
			long assetId = Convert.ToInt64(((AssetPublishedVersion)(ref assetPublishedVersion)).AssetId);
			assetPublishedVersion = response.AssetPublishedVersion;
			return assetVersionFactory.GetByAssetIdAndVersionNumber(assetId, (int)((AssetPublishedVersion)(ref assetPublishedVersion)).AssetVersionNumber);
		}
		return _DomainFactories.AssetVersionFactory.GetCurrentAssetPublishedVersion(place);
	}

	/// <summary>
	/// This method rounds up expectedLatestTime to the nearest time span specified by the setting JvPlaceLaunchRoundUpToNearestTimeSpan
	/// </summary>
	/// <param name="expectedLatestTime">date time to be rounded up</param>
	/// <returns></returns>
	internal DateTime RoundUpJvDateTime(DateTime expectedLatestTime)
	{
		return new DateTime((expectedLatestTime.Ticks + Settings.JvPlaceLaunchRoundUpToNearestTimeSpan.Ticks - 1) / Settings.JvPlaceLaunchRoundUpToNearestTimeSpan.Ticks * Settings.JvPlaceLaunchRoundUpToNearestTimeSpan.Ticks, expectedLatestTime.Kind);
	}

	/// <inheritdoc />
	public IAssetVersion GetCurrentPlaceSavedVersion(IAsset place)
	{
		return GetCurrentAssetSavedVersion(place);
	}

	/// <inheritdoc />
	public IAssetVersion GetCurrentAssetPublishedVersion(IAsset asset)
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		AssetType? assetType = _DomainFactories.AssetTypeFactory.GetAssetType(asset.TypeId);
		if (!assetType.HasValue)
		{
			throw new ArgumentException($"Invalid Asset type Id {asset.TypeId}");
		}
		if (_AssetVersionsConfigurationProvider.IsServeFromAssetPublishedVersionsEnabledForAssetType(assetType.Value, asset.Id))
		{
			if (!Enum.TryParse<AssetType>(assetType.Value.ToString(), out AssetType clientAssetType))
			{
				throw new ArgumentException($"Invalid Asset type {assetType}");
			}
			PaginatedAssetPublishedVersionResult response = _DomainFactories.AssetsClient.GetAssetPublishedVersionByAssetIdAndAssetType(clientAssetType, asset.Id.ToString(CultureInfo.InvariantCulture), (string)null, 1);
			if (response.AssetPublishedVersion != null && response.AssetPublishedVersion.Count > 0)
			{
				AssetPublishedVersion assetPublishedVersion = response.AssetPublishedVersion.First();
				return _DomainFactories.AssetVersionFactory.GetByAssetIdAndVersionNumber(Convert.ToInt64(((AssetPublishedVersion)(ref assetPublishedVersion)).AssetId), (int)((AssetPublishedVersion)(ref assetPublishedVersion)).AssetVersionNumber);
			}
			return null;
		}
		return GetCurrentAssetSavedVersion(asset);
	}

	public IAssetVersion GetCurrentAssetSavedVersion(IAsset asset)
	{
		return _DomainFactories.AssetVersionFactory.GetAssetVersionsPaged(asset, 0L, 1L).FirstOrDefault();
	}

	/// <inheritdoc />
	public IAssetVersion GetCurrentAssetVersion(IAsset asset)
	{
		if (_DomainFactories.AssetTypeFactory.GetAssetType(asset.TypeId) == AssetType.Place)
		{
			if (Roblox.Properties.Settings.Default.IsTestingSite)
			{
				_DomainFactories.Logger.Warning(string.Format("Looking up current versions for places using {0} method is depricated", "GetCurrentAssetVersion"));
			}
			return _DomainFactories.AssetVersionFactory.GetCurrentPlacePublishedVersion(asset);
		}
		return GetCurrentAssetSavedVersion(asset);
	}

	/// <inheritdoc />
	public IEnumerable<IAssetVersion> GetAssetVersionsPaged(IAsset asset, long offset, long count)
	{
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		return Roblox.AssetVersion.GetAssetVersionsPagedByAssetID(asset.Id, (int)offset, (int)count).Select(Singleton.GetAssetVersion);
	}

	/// <inheritdoc />
	public IEnumerable<IAssetVersion> GetAssetPublishedVersionsPaged(IAsset asset, long startRowIndex, long count, bool catchClientExceptions = false)
	{
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		if (count < 1)
		{
			throw new ArgumentException($"Count must be greater than 0, is {count}.", "count");
		}
		AssetType? assetType = _DomainFactories.AssetTypeFactory.GetAssetType(asset.TypeId);
		if (!assetType.HasValue)
		{
			throw new ArgumentException($"Invalid Asset type Id {asset.TypeId}");
		}
		if (_AssetVersionsConfigurationProvider.IsServeFromAssetPublishedVersionsEnabledForAssetType(assetType.Value, asset.Id))
		{
			long endRowIndex = startRowIndex + count;
			string startKey = null;
			List<AssetPublishedVersion> assetPublishedVersions = new List<AssetPublishedVersion>();
			if (!Enum.TryParse<AssetType>(assetType.Value.ToString(), out AssetType clientAssetType))
			{
				throw new ArgumentException($"Invalid Asset type {assetType}");
			}
			try
			{
				do
				{
					PaginatedAssetPublishedVersionResult response = _DomainFactories.AssetsClient.GetAssetPublishedVersionByAssetIdAndAssetType(clientAssetType, asset.Id.ToString(), startKey, 50);
					if (response != null)
					{
						assetPublishedVersions.AddRange(response.AssetPublishedVersion);
						startKey = response.ExclusiveStartKey;
						endRowIndex -= response.AssetPublishedVersion.Count();
						continue;
					}
					break;
				}
				while (endRowIndex > 0 && startKey != null);
			}
			catch (Exception e)
			{
				if (catchClientExceptions)
				{
					_DomainFactories.Logger.Error(e.StackTrace);
					throw new ApplicationException("An internal server error has occured.");
				}
				throw;
			}
			if (assetPublishedVersions.Count() > startRowIndex)
			{
				long desiredItems = ((assetPublishedVersions.Count() - startRowIndex < count) ? (assetPublishedVersions.Count() - startRowIndex) : count);
				return from p in assetPublishedVersions.GetRange((int)startRowIndex, (int)desiredItems).AsParallel().AsOrdered()
						.WithDegreeOfParallelism(_DomainFactories.Settings.AssetVersionLookUpParallelizationDegree)
					select _DomainFactories.AssetVersionFactory.GetByAssetIdAndVersionNumber(Convert.ToInt64(((AssetPublishedVersion)(ref p)).AssetId), (int)((AssetPublishedVersion)(ref p)).AssetVersionNumber);
			}
			return Array.Empty<IAssetVersion>();
		}
		return _DomainFactories.AssetVersionFactory.GetAssetVersionsPaged(asset, startRowIndex, count);
	}

	/// <inheritdoc />
	public IPlatformPageResponse<string, IAssetVersion> GetAssetSavedVersionsPaged(IAsset asset, IExclusiveStartKeyInfo<string> exclusiveStartKeyInfo)
	{
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		if (exclusiveStartKeyInfo == null)
		{
			throw new ArgumentNullException("exclusiveStartKeyInfo");
		}
		if (exclusiveStartKeyInfo.Count <= 0)
		{
			throw new ArgumentException($"Count must be greater than 0, is {exclusiveStartKeyInfo.Count}.", "exclusiveStartKeyInfo");
		}
		SortOrder dbSortOrder = exclusiveStartKeyInfo.GetDatabaseRequestSortOrder();
		int dbCount = exclusiveStartKeyInfo.Count + 1;
		int? exclusiveStartVersionNumber = null;
		if (exclusiveStartKeyInfo.TryGetExclusiveStartKey(out var exclusiveStartKey))
		{
			exclusiveStartVersionNumber = int.Parse(exclusiveStartKey, CultureInfo.InvariantCulture);
		}
		return new PlatformPageResponse<string, IAssetVersion>(GetAssetSavedVersionsPaged(asset, exclusiveStartVersionNumber, dbCount, dbSortOrder)?.ToArray() ?? Array.Empty<IAssetVersion>(), exclusiveStartKeyInfo, (IAssetVersion v) => v.VersionNumber.ToString(CultureInfo.InvariantCulture));
	}

	public ICollection<IAssetVersion> GetAssetSavedVersionsPaged(IAsset asset, int? exclusiveStartVersionNumber, int count, SortOrder sortOrder)
	{
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		return Roblox.AssetVersion.GetAssetVersionsPagedByAssetID(asset.Id, exclusiveStartVersionNumber, count, sortOrder)?.Select(Singleton.GetAssetVersion)?.ToList();
	}

	/// <inheritdoc />
	public IPlatformPageResponse<string, IAssetVersion> GetAssetPublishedVersionsPaged(IAsset asset, IExclusiveStartKeyInfo<string> exclusiveStartKeyInfo)
	{
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		if (exclusiveStartKeyInfo == null)
		{
			throw new ArgumentNullException("exclusiveStartKeyInfo");
		}
		if (exclusiveStartKeyInfo.Count <= 0)
		{
			throw new ArgumentException($"Count must be greater than 0, is {exclusiveStartKeyInfo.Count}.", "exclusiveStartKeyInfo");
		}
		AssetType? platformAssetType = _DomainFactories.AssetTypeFactory.GetAssetType(asset.TypeId);
		if (!platformAssetType.HasValue)
		{
			throw new ArgumentException($"Cannot get asset type. Asset type ID: {asset.TypeId}.", "asset");
		}
		if (!_AssetVersionsConfigurationProvider.IsServeFromAssetPublishedVersionsEnabledForAssetType(platformAssetType.Value, asset.Id))
		{
			return GetAssetSavedVersionsPaged(asset, exclusiveStartKeyInfo);
		}
		AssetType clientAssetType = _DomainFactories.AssetTypeFactory.ToAssetsClientAssetType(platformAssetType.Value);
		exclusiveStartKeyInfo.TryGetExclusiveStartKey(out var exclusiveStartKey);
		PaginatedAssetPublishedVersionResult response = _DomainFactories.AssetsClient.GetAssetPublishedVersionByAssetIdAndAssetType(clientAssetType, asset.Id.ToString(CultureInfo.InvariantCulture), exclusiveStartKey, exclusiveStartKeyInfo.Count);
		return new PlatformPageResponse<string, IAssetVersion>((from v in response.AssetPublishedVersion
			select Roblox.AssetVersion.Get(asset.Id, (int)((AssetPublishedVersion)(ref v)).AssetVersionNumber) into v
			select GetAssetVersion(v)).ToArray(), exclusiveStartKeyInfo, null, (response.ExclusiveStartKey == null) ? null : new ExclusiveStartKeyContainer<string>(response.ExclusiveStartKey));
	}

	/// <inheritdoc />
	public int GetTotalNumberOfAssetVersionsByAssetID(long assetId)
	{
		return Roblox.AssetVersion.GetTotalNumberOfAssetVersionsByAssetID(assetId);
	}

	/// <inheritdoc />
	public int GetTotalNumberOfAssetVersionsByAssetHashID(long assetHashId)
	{
		return Roblox.AssetVersion.GetTotalNumberOfAssetVersionsByAssetHashID(assetHashId);
	}

	public ICollection<PlatformAssetPublishedVersionsResponse> GetAssetSavedVersionsWithPublishedFlagPaged(IAsset asset, int? versionNumberExclusiveStartKey, int count, SortOrder sortOrder)
	{
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		if (count <= 0)
		{
			throw new ArgumentNullException($"Count must be greater than 0, is {count}.", "count");
		}
		ICollection<IAssetVersion> assetVersions = _DomainFactories.AssetVersionFactory.GetAssetSavedVersionsPaged(asset, versionNumberExclusiveStartKey, count, sortOrder);
		AssetType? platformAssetType = _DomainFactories.AssetTypeFactory.GetAssetType(asset.TypeId);
		if (!platformAssetType.HasValue)
		{
			throw new ArgumentException($"Invalid Asset type Id {asset.TypeId}");
		}
		if (!_AssetVersionsConfigurationProvider.IsServeFromAssetPublishedVersionsEnabledForAssetType(platformAssetType.Value, asset.Id))
		{
			return assetVersions.Select((IAssetVersion p) => new PlatformAssetPublishedVersionsResponse
			{
				AssetVersion = p,
				IsPublished = true
			}).ToList();
		}
		if (!Enum.TryParse<AssetType>(platformAssetType.Value.ToString(), out AssetType clientAssetType))
		{
			throw new ArgumentException($"Invalid Asset type {platformAssetType}");
		}
		List<MultiGetAssetPublishedVersionsRequestItem> requestItems = ((IEnumerable<IAssetVersion>)assetVersions).Select((Func<IAssetVersion, MultiGetAssetPublishedVersionsRequestItem>)((IAssetVersion p) => new MultiGetAssetPublishedVersionsRequestItem
		{
			AssetId = p.AssetId.ToString(),
			AssetType = clientAssetType,
			AssetVersionNumber = p.VersionNumber
		})).ToList();
		MultiGetAssetPublishedVersionsResponse clientResults = _DomainFactories.AssetsClient.MultiGetAssetPublishedVersionsByAssetIdAndAssetVersionId(requestItems);
		return assetVersions.Select((IAssetVersion p) => new PlatformAssetPublishedVersionsResponse
		{
			AssetVersion = p,
			IsPublished = clientResults.AssetPublishedVersions.Any((AssetPublishedVersion q) => ((AssetPublishedVersion)(ref q)).AssetId.Equals(p.AssetId.ToString()) && ((AssetPublishedVersion)(ref q)).AssetVersionNumber == p.VersionNumber)
		}).ToList();
	}

	/// <inheritdoc />
	public ICollection<PlatformAssetPublishedVersionsResponse> GetAssetSavedVersionsWithPublishedFlagPaged(IAsset asset, int offset, int count)
	{
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		if (count <= 0)
		{
			throw new ArgumentNullException($"Count must be greater than 0, is {count}.", "count");
		}
		if (offset < 0)
		{
			throw new ArgumentNullException($"offset must be greater than 0, is {offset}.", "offset");
		}
		List<IAssetVersion> assetVersions = _DomainFactories.AssetVersionFactory.GetAssetVersionsPaged(asset, offset, count).ToList();
		AssetType? platformAssetType = _DomainFactories.AssetTypeFactory.GetAssetType(asset.TypeId);
		if (!platformAssetType.HasValue)
		{
			throw new ArgumentException($"Invalid Asset type Id {asset.TypeId}");
		}
		if (!_AssetVersionsConfigurationProvider.IsServeFromAssetPublishedVersionsEnabledForAssetType(platformAssetType.Value, asset.Id))
		{
			return assetVersions.Select((IAssetVersion p) => new PlatformAssetPublishedVersionsResponse
			{
				AssetVersion = p,
				IsPublished = true
			}).ToList();
		}
		if (!Enum.TryParse<AssetType>(platformAssetType.Value.ToString(), out AssetType clientAssetType))
		{
			throw new ArgumentException($"Invalid Asset type {platformAssetType}");
		}
		List<MultiGetAssetPublishedVersionsRequestItem> requestItems = ((IEnumerable<IAssetVersion>)assetVersions).Select((Func<IAssetVersion, MultiGetAssetPublishedVersionsRequestItem>)((IAssetVersion p) => new MultiGetAssetPublishedVersionsRequestItem
		{
			AssetId = p.AssetId.ToString(),
			AssetType = clientAssetType,
			AssetVersionNumber = p.VersionNumber
		})).ToList();
		MultiGetAssetPublishedVersionsResponse clientResults = _DomainFactories.AssetsClient.MultiGetAssetPublishedVersionsByAssetIdAndAssetVersionId(requestItems);
		return assetVersions.Select((IAssetVersion p) => new PlatformAssetPublishedVersionsResponse
		{
			AssetVersion = p,
			IsPublished = clientResults.AssetPublishedVersions.Any((AssetPublishedVersion q) => ((AssetPublishedVersion)(ref q)).AssetId.Equals(p.AssetId.ToString()) && ((AssetPublishedVersion)(ref q)).AssetVersionNumber == p.VersionNumber)
		}).ToList();
	}

	private static CreatorRef LoadCreatorRef(CreatorType creatorType, long creatorTargetId)
	{
		return CreatorRef.CreateNewRefFromAgentId(AgentFactory.GetByAgentTypeAndAgentTargetId(creatorType.ToAgentType(), creatorTargetId).Id);
	}

	private static Roblox.AssetVersion CreateAssetVersionForAssetAndCreator(IAsset asset, IRawContent rawContent, IAssetVersion parentAssetVersion, long? creatingUniverseId, CreatorRef creatorRef)
	{
		Roblox.Asset assetEntity = Roblox.Asset.MustGet(asset.Id);
		if (parentAssetVersion != null)
		{
			return Roblox.AssetVersion.CreateNew_PLATFORMONLY(assetEntity, creatorRef, rawContent.Md5Hash, parentAssetVersion.Id, rawContent.Id, creatingUniverseId);
		}
		return Roblox.AssetVersion.CreateNew_PLATFORMONLY(assetEntity, creatorRef, rawContent.Md5Hash, creatingUniverseId);
	}

	private static void UpdateCreationContextForAsset(IAsset asset, CreatorType creatorType, long creatorTargetId, long? creatingUniverseId, CreationContextType? creationContext)
	{
		if (creationContext.HasValue)
		{
			Creation.GetOrCreate(CreationContext.GetOrCreate((byte)creationContext.Value, (byte)creatorType, creatorTargetId, asset.TypeId, creatingUniverseId).ID, asset.Id).Save();
		}
	}

	public ICollection<IAssetVersion> GetAssetVersionsByRawContent(IRawContent rawContent, int startRowIndex, int maximumRows)
	{
		if (rawContent == null)
		{
			throw new PlatformArgumentNullException("rawContent");
		}
		return Roblox.AssetVersion.GetAssetVersionsPagedByAssetHashID(rawContent.Id, startRowIndex, maximumRows).Select(GetAssetVersion).ToArray();
	}

	public IAssetVersion GetAssetVersion(Roblox.AssetVersion assetVersionEntity)
	{
		if (assetVersionEntity == null)
		{
			return null;
		}
		IAgent obj = AgentFactory.Get(assetVersionEntity.CreatorID) ?? throw new DataIntegrityException($"AssetVersionID={assetVersionEntity.ID} has CreatorID={assetVersionEntity.CreatorID} which does not exist");
		CreatorType creatorType = obj.AgentType.ToCreatorType();
		long creatorTargetId = obj.AgentTargetId;
		return new AssetVersion(_DomainFactories, assetVersionEntity.ID, assetVersionEntity.AssetID, assetVersionEntity.VersionNumber, assetVersionEntity.AssetHashID, assetVersionEntity.ParentAssetVersionID, creatorType, creatorTargetId, assetVersionEntity.CreatingUniverseID, assetVersionEntity.Created, assetVersionEntity.Updated);
	}

	[Obsolete("Use AssetDomainFactories.AssetVersionFactory.CheckedGet() instead")]
	public static IAssetVersion CheckedGet(long? id)
	{
		return GetSingleton().CheckedGet(id);
	}

	IAssetVersion IAssetVersionFactory.CheckedGet(long? id)
	{
		IAssetVersion assetVersion = Get(id);
		assetVersion.VerifyIsNotNull();
		return assetVersion;
	}

	[Obsolete("Use AssetDomainFactories.AssetVersionFactory.Get() instead")]
	public static IAssetVersion Get(long? id)
	{
		return GetSingleton().Get(id);
	}

	IAssetVersion IAssetVersionFactory.Get(long? id)
	{
		Roblox.AssetVersion assetVersionEntity = Roblox.AssetVersion.Get(id);
		return GetAssetVersion(assetVersionEntity);
	}

	[Obsolete("Use AssetDomainFactories.AssetVersionFactory.GetByAssetAndVersionNumber() instead")]
	public static IAssetVersion GetByAssetAndVersionNumber(IAsset asset, int versionNumber)
	{
		return GetSingleton().GetByAssetAndVersionNumber(asset, versionNumber);
	}

	IAssetVersion IAssetVersionFactory.GetByAssetAndVersionNumber(IAsset asset, int versionNumber)
	{
		asset.VerifyIsNotNull();
		return ((IAssetVersionFactory)this).GetByAssetIdAndVersionNumber(asset.Id, versionNumber);
	}

	[Obsolete("Use AssetDomainFactories.AssetVersionFactory.GetByAssetIdAndVersionNumber instead")]
	public static IAssetVersion GetByAssetIdAndVersionNumber(long assetId, int versionNumber)
	{
		return GetSingleton().GetByAssetIdAndVersionNumber(assetId, versionNumber);
	}

	IAssetVersion IAssetVersionFactory.GetByAssetIdAndVersionNumber(long assetId, int versionNumber)
	{
		return GetAssetVersion(Roblox.AssetVersion.Get(assetId, versionNumber));
	}
}
