using System.Collections.Generic;
using System.Linq;
using Roblox.Common;
using Roblox.Configuration;
using Roblox.Platform.Assets;
using Roblox.Platform.Core;
using Roblox.Platform.UniverseSettings.Properties;

namespace Roblox.Platform.UniverseSettings;

/// <summary>
/// Factory to manipulate Universe Assets in UniverseSettings
/// </summary>
internal class UniverseAvatarAssetOverrideFactory : IUniverseAvatarAssetOverrideFactory
{
	private readonly IAssetFactory _AssetFactory;

	private readonly UniverseAvatarAssetOverrideEntityFactory _UniverseAvatarAssetOverrideEntityFactory;

	/// <summary>
	/// A collection of asset types allowed to be overridden
	/// </summary>
	public ICollection<AssetType> AllowedAssetTypes { get; set; }

	/// <summary>
	/// Constructs a new UniverseAvatarAssetOverrideFactory
	/// <param name="assetFactory">The <see cref="T:Roblox.Platform.Assets.IAssetFactory" /></param>
	/// <param name="universeAvatarAssetOverrideEntityFactory">The <see cref="T:Roblox.Platform.UniverseSettings.UniverseAvatarAssetOverrideEntityFactory" /></param>
	/// </summary>
	public UniverseAvatarAssetOverrideFactory(IAssetFactory assetFactory, UniverseAvatarAssetOverrideEntityFactory universeAvatarAssetOverrideEntityFactory)
	{
		_AssetFactory = assetFactory ?? throw new PlatformArgumentNullException("assetFactory");
		_UniverseAvatarAssetOverrideEntityFactory = universeAvatarAssetOverrideEntityFactory ?? throw new PlatformArgumentNullException("universeAvatarAssetOverrideEntityFactory");
		Settings.Default.ReadValueAndMonitorChanges((Settings settings) => settings.AllowedAssetOverrides, UpdateAllowedAssetTypes);
	}

	/// <summary>
	/// Creates a Avatar Asset Overrides for a given universeId if not in db. Updates the existing Asset Override if in db.
	/// If PlayerChoice is true, then the AssetID will be zero'ed out and no asset or assetType validation will run.
	/// ^ This is to make data consistent. The client should have checks on if the assetID is zero and default to the default asset (which is defined in the client).
	/// </summary>
	/// <param name="universeId">The Id of the Universe to set Asset Override for</param>
	/// <param name="assetId">The assetId to update the Avatar Asset Override to</param>
	/// <param name="assetTypeId">The assetTypeId to update the Avatar Asset Override to</param>
	/// <param name="isPlayerChoice">Whteher or not the Avatar Asset Override Player Choice</param>
	public virtual void CreateOrUpdate(long universeId, long assetId, int assetTypeId, bool isPlayerChoice)
	{
		AssetType? assetType = EnumUtils.StrictTryParseEnum<AssetType>(assetTypeId.ToString());
		if (!assetType.HasValue || !AllowedAssetTypes.Contains(assetType.Value))
		{
			throw new PlatformArgumentException($"The asset type {assetType} is not allowed to be overridden.");
		}
		if (isPlayerChoice)
		{
			assetId = 0L;
		}
		else if ((_AssetFactory.GetAsset(assetId) ?? throw new PlatformArgumentException($"The asset with ID {assetId} does not exist.")).TypeId != assetTypeId)
		{
			throw new PlatformArgumentException("The asset's actual asset type does not match the given asset type.");
		}
		ICollection<UniverseAvatarAssetOverrideEntity> assetOverrides = _UniverseAvatarAssetOverrideEntityFactory.GetUniverseAvatarAssetOverridesPaged(universeId, Settings.Default.MaxAvatarAssetOverridesPerUniverse, 0L);
		UniverseAvatarAssetOverrideEntity existingAssetOverride = assetOverrides?.FirstOrDefault((UniverseAvatarAssetOverrideEntity x) => x.AssetTypeID.Equals(assetTypeId));
		if (existingAssetOverride != null)
		{
			existingAssetOverride.AssetID = assetId;
			existingAssetOverride.IsPlayerChoice = isPlayerChoice;
			existingAssetOverride.Save();
			return;
		}
		if (assetOverrides.Count() >= Settings.Default.MaxAvatarAssetOverridesPerUniverse)
		{
			throw new PlatformArgumentException("Max number of rows have been reached for UniverseAvatarAssetOverrides.");
		}
		_UniverseAvatarAssetOverrideEntityFactory.Create(universeId, assetId, assetTypeId, isPlayerChoice);
	}

	/// <summary>
	/// Gets the maximum number of Avatar Asset Overrides allowed for a given universeId
	/// </summary>
	/// <param name="universeId">The Id of the Universe to get Asset Overrides for</param>
	public ICollection<UniverseAvatarAssetOverrideResponseModel> GetAllUniverseAvatarAssetOverridesByUniverseId(long universeId)
	{
		return (_UniverseAvatarAssetOverrideEntityFactory.GetUniverseAvatarAssetOverridesPaged(universeId, Settings.Default.MaxAvatarAssetOverridesPerUniverse, 0L)?.Select((UniverseAvatarAssetOverrideEntity o) => _UniverseAvatarAssetOverrideEntityFactory.Get(o.ID))).Select((IUniverseAvatarAssetOverrideEntity x) => TranslateUniverseAvatarAssetOverride(x)).ToList();
	}

	/// <summary>
	/// Gets the Avatar Asset Override from the db
	/// </summary>
	/// <param name="id">The Id of the Avatar Asset override to get</param>
	public UniverseAvatarAssetOverrideResponseModel GetUniverseAssetOverride(long id)
	{
		IUniverseAvatarAssetOverrideEntity entity = _UniverseAvatarAssetOverrideEntityFactory.Get(id);
		return TranslateUniverseAvatarAssetOverride(entity);
	}

	private UniverseAvatarAssetOverrideResponseModel TranslateUniverseAvatarAssetOverride(IUniverseAvatarAssetOverrideEntity entity)
	{
		return new UniverseAvatarAssetOverrideResponseModel
		{
			AssetID = entity.AssetId,
			AssetTypeID = entity.AssetTypeId,
			IsPlayerChoice = entity.IsPlayerChoice
		};
	}

	private void UpdateAllowedAssetTypes(string csvValue)
	{
		List<AssetType> result = new List<AssetType>();
		char[] chArray = new char[1] { ',' };
		string[] array = csvValue.Split(chArray);
		for (int i = 0; i < array.Length; i++)
		{
			AssetType? toAdd = EnumUtils.StrictTryParseEnum<AssetType>(array[i]);
			if (toAdd.HasValue)
			{
				result.Add(toAdd.Value);
			}
		}
		AllowedAssetTypes = result;
	}
}
