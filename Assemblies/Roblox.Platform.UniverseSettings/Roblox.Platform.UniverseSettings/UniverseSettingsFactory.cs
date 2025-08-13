using System.Collections.Generic;
using Roblox.Common;
using Roblox.Platform.Core;
using Roblox.Platform.Groups;
using Roblox.Platform.Membership;
using Roblox.Platform.Outfits;
using Roblox.Platform.Universes;

namespace Roblox.Platform.UniverseSettings;

internal class UniverseSettingsFactory : IUniverseSettingsFactory, IUniverseSettingsFactoryForAdmins
{
	private readonly IUniverseAvatarSettingsEntityFactory _UniverseAvatarSettingsEntityFactory;

	private readonly UniverseDomainFactories _UniverseDomainFactories;

	private readonly UniversePermissionsVerifier _UniversePermissionsVerifier;

	private readonly IUniverseAvatarAssetOverrideFactory _UniverseAvatarAssetOverrideFactory;

	private readonly IScaleFactory _ScaleFactory;

	private readonly UniverseAvatarSettingsDefaults _UniverseAvatarSettingsDefaults;

	private readonly OutfitDomainFactories _OutfitDomainFactories;

	public UniverseSettingsFactory(IUniverseAvatarSettingsEntityFactory universeAvatarSettingsEntityFactory, IUniverseAvatarAssetOverrideFactory universeAvatarAssetOverrideFactory, UniverseDomainFactories universeDomainFactories, GroupMembershipFactory groupMembershipFactory, IScaleFactory scaleFactory, OutfitDomainFactories outfitDomainFactories)
	{
		_UniverseAvatarSettingsEntityFactory = universeAvatarSettingsEntityFactory ?? throw new PlatformArgumentNullException("universeAvatarSettingsEntityFactory");
		_UniverseAvatarAssetOverrideFactory = universeAvatarAssetOverrideFactory ?? throw new PlatformArgumentNullException("universeAvatarAssetOverrideFactory");
		_UniverseDomainFactories = universeDomainFactories ?? throw new PlatformArgumentNullException("universeDomainFactories");
		_UniversePermissionsVerifier = new UniversePermissionsVerifier(groupMembershipFactory);
		_ScaleFactory = scaleFactory ?? throw new PlatformArgumentNullException("scaleFactory");
		_OutfitDomainFactories = outfitDomainFactories ?? throw new PlatformArgumentNullException("outfitDomainFactories");
		_UniverseAvatarSettingsDefaults = new UniverseAvatarSettingsDefaults(_ScaleFactory);
	}

	/// <inheritdocs />
	public UniverseAvatarSettingsResponseModel GetUniverseAvatarSettings(long universeId)
	{
		IUniverseAvatarSettingEntity entity = _UniverseAvatarSettingsEntityFactory.GetOrCreate(universeId);
		return new UniverseAvatarSettingsResponseModel
		{
			UniverseId = universeId,
			UniverseAvatarType = (EnumUtils.StrictTryParseEnum<UniverseAvatarType>(entity.UniverseAvatarTypeId.ToString()) ?? _UniverseAvatarSettingsDefaults.GetDefaultNewUniverseAvatarType()),
			UniverseScaleType = (EnumUtils.StrictTryParseEnum<UniverseScaleType>(entity.UniverseScaleTypeId?.ToString() ?? "") ?? _UniverseAvatarSettingsDefaults.GetDefaultNewUniverseScaleType()),
			UniverseAvatarAnimationType = (EnumUtils.StrictTryParseEnum<UniverseAvatarAnimationType>(entity.UniverseAvatarAnimationTypeId?.ToString() ?? "") ?? _UniverseAvatarSettingsDefaults.GetDefaultNewUniverseAvatarAnimationType()),
			UniverseAvatarCollisionType = (EnumUtils.StrictTryParseEnum<UniverseAvatarCollisionType>(entity.UniverseAvatarCollisionTypeId?.ToString() ?? "") ?? _UniverseAvatarSettingsDefaults.GetDefaultNewUniverseAvatarCollisionType()),
			UniverseAvatarBodyType = (EnumUtils.StrictTryParseEnum<UniverseAvatarBodyType>(entity.UniverseAvatarBodyTypeId?.ToString() ?? "") ?? _UniverseAvatarSettingsDefaults.GetDefaultNewUniverseAvatarBodyType()),
			UniverseAvatarJointPositioningType = (EnumUtils.StrictTryParseEnum<UniverseAvatarJointPositioningType>(entity.UniverseAvatarJointPositioningTypeId?.ToString() ?? "") ?? _UniverseAvatarSettingsDefaults.GetDefaultNewUniverseAvatarJointPositioningType()),
			UniverseAvatarMinScaleId = GetClampedScaleId(GetEffectiveUniverseAvatarScaleId(entity, isMin: true)),
			UniverseAvatarMaxScaleId = GetClampedScaleId(GetEffectiveUniverseAvatarScaleId(entity, isMin: false)),
			UniverseAvatarAssetOverrides = _UniverseAvatarAssetOverrideFactory.GetAllUniverseAvatarAssetOverridesByUniverseId(universeId)
		};
	}

	internal int GetEffectiveUniverseAvatarScaleId(IUniverseAvatarSettingEntity entity, bool isMin)
	{
		UniverseScaleType universeScaleType = EnumUtils.StrictTryParseEnum<UniverseScaleType>(entity.UniverseScaleTypeId?.ToString() ?? "") ?? _UniverseAvatarSettingsDefaults.GetDefaultNewUniverseScaleType();
		UniverseAvatarBodyType universeAvatarBodyType = EnumUtils.StrictTryParseEnum<UniverseAvatarBodyType>(entity.UniverseAvatarBodyTypeId?.ToString() ?? "") ?? _UniverseAvatarSettingsDefaults.GetDefaultNewUniverseAvatarBodyType();
		if (isMin && entity.UniverseAvatarMinScaleId.HasValue)
		{
			return entity.UniverseAvatarMinScaleId.Value;
		}
		if (!isMin && entity.UniverseAvatarMaxScaleId.HasValue)
		{
			return entity.UniverseAvatarMaxScaleId.Value;
		}
		decimal width = 0.00m;
		decimal height = 0.00m;
		decimal head = 0.00m;
		decimal proportion = 0.00m;
		decimal bodyType = 0.00m;
		switch (universeScaleType)
		{
		case UniverseScaleType.NoScales:
			width = ScaleRules.Width.Default;
			height = ScaleRules.Height.Default;
			head = ScaleRules.Head.Default;
			break;
		case UniverseScaleType.AllScales:
			width = (isMin ? ScaleRules.Width.Min : ScaleRules.Width.Max);
			height = (isMin ? ScaleRules.Height.Min : ScaleRules.Height.Max);
			head = (isMin ? ScaleRules.Head.Min : ScaleRules.Head.Max);
			break;
		}
		switch (universeAvatarBodyType)
		{
		case UniverseAvatarBodyType.Standard:
			proportion = ScaleRules.Proportion.Default;
			bodyType = ScaleRules.BodyType.Default;
			break;
		case UniverseAvatarBodyType.PlayerChoice:
			proportion = (isMin ? ScaleRules.Proportion.Min : ScaleRules.Proportion.Max);
			bodyType = (isMin ? ScaleRules.BodyType.Min : ScaleRules.BodyType.Max);
			break;
		}
		return _ScaleFactory.GetOrCreate(height, width, head, proportion, bodyType).Id;
	}

	/// <inheritdocs />
	public ICollection<UniverseAvatarAssetOverrideResponseModel> GetValidUniverseAvatarAssetOverrides(long? universeId)
	{
		if (!universeId.HasValue || universeId == 0)
		{
			return new List<UniverseAvatarAssetOverrideResponseModel>();
		}
		return _UniverseAvatarAssetOverrideFactory.GetAllUniverseAvatarAssetOverridesByUniverseId(universeId.Value);
	}

	/// <inheritdocs />
	public Scale GetValidUniverseMinScale(long? universeId)
	{
		if (!universeId.HasValue || universeId == 0)
		{
			return _ScaleFactory.Get(_UniverseAvatarSettingsDefaults.GetDefaultNewUniverseAvatarMinScaleId());
		}
		IUniverseAvatarSettingEntity entity = _UniverseAvatarSettingsEntityFactory.GetOrCreate(universeId.Value);
		return GetClampedScale(entity.UniverseAvatarMinScaleId ?? GetEffectiveUniverseAvatarScaleId(entity, isMin: true));
	}

	/// <inheritdocs />
	public Scale GetValidUniverseMaxScale(long? universeId)
	{
		if (!universeId.HasValue || universeId == 0)
		{
			return _ScaleFactory.Get(_UniverseAvatarSettingsDefaults.GetDefaultNewUniverseAvatarMaxScaleId());
		}
		IUniverseAvatarSettingEntity entity = _UniverseAvatarSettingsEntityFactory.GetOrCreate(universeId.Value);
		return GetClampedScale(entity.UniverseAvatarMaxScaleId ?? GetEffectiveUniverseAvatarScaleId(entity, isMin: false));
	}

	/// <inheritdocs />
	public UniverseAvatarType GetValidUniverseAvatarType(long? universeId)
	{
		if (!universeId.HasValue || universeId == 0)
		{
			return _UniverseAvatarSettingsDefaults.GetDefaultPlaceUniverseAvatarTypeForUnknownPlace();
		}
		return EnumUtils.StrictTryParseEnum<UniverseAvatarType>(_UniverseAvatarSettingsEntityFactory.GetOrCreate(universeId.Value).UniverseAvatarTypeId.ToString()) ?? _UniverseAvatarSettingsDefaults.GetDefaultNewUniverseAvatarType();
	}

	/// <inheritdocs />
	public UniverseScaleType GetValidUniverseScaleType(long? universeId)
	{
		if (!universeId.HasValue || universeId == 0)
		{
			return _UniverseAvatarSettingsDefaults.GetDefaultNewUniverseScaleType();
		}
		return EnumUtils.StrictTryParseEnum<UniverseScaleType>(_UniverseAvatarSettingsEntityFactory.GetOrCreate(universeId.Value).UniverseScaleTypeId?.ToString() ?? "") ?? _UniverseAvatarSettingsDefaults.GetDefaultNewUniverseScaleType();
	}

	/// <inheritdocs />
	public UniverseAvatarAnimationType GetValidUniverseAvatarAnimationType(long? universeId)
	{
		if (!universeId.HasValue || universeId == 0)
		{
			return _UniverseAvatarSettingsDefaults.GetDefaultNewUniverseAvatarAnimationType();
		}
		return EnumUtils.StrictTryParseEnum<UniverseAvatarAnimationType>(_UniverseAvatarSettingsEntityFactory.GetOrCreate(universeId.Value).UniverseAvatarAnimationTypeId?.ToString() ?? "") ?? _UniverseAvatarSettingsDefaults.GetDefaultNewUniverseAvatarAnimationType();
	}

	/// <inheritdocs />
	public UniverseAvatarCollisionType GetValidUniverseAvatarCollisionType(long? universeId)
	{
		if (!universeId.HasValue || universeId == 0)
		{
			return _UniverseAvatarSettingsDefaults.GetDefaultNewUniverseAvatarCollisionType();
		}
		return EnumUtils.StrictTryParseEnum<UniverseAvatarCollisionType>(_UniverseAvatarSettingsEntityFactory.GetOrCreate(universeId.Value).UniverseAvatarCollisionTypeId?.ToString() ?? "") ?? _UniverseAvatarSettingsDefaults.GetDefaultNewUniverseAvatarCollisionType();
	}

	/// <inheritdocs />
	public UniverseAvatarBodyType GetValidUniverseAvatarBodyType(long? universeId)
	{
		if (!universeId.HasValue || universeId == 0)
		{
			return _UniverseAvatarSettingsDefaults.GetDefaultPlaceUniverseBodyTypeForUnknownPlace();
		}
		return EnumUtils.StrictTryParseEnum<UniverseAvatarBodyType>(_UniverseAvatarSettingsEntityFactory.GetOrCreate(universeId.Value).UniverseAvatarBodyTypeId.ToString()) ?? _UniverseAvatarSettingsDefaults.GetDefaultNewUniverseAvatarBodyType();
	}

	/// <inheritdocs />
	public UniverseAvatarJointPositioningType GetValidUniverseAvatarJointPositioningType(long? universeId)
	{
		if (!universeId.HasValue || universeId == 0)
		{
			return _UniverseAvatarSettingsDefaults.GetDefaultNewUniverseAvatarJointPositioningType();
		}
		return EnumUtils.StrictTryParseEnum<UniverseAvatarJointPositioningType>(_UniverseAvatarSettingsEntityFactory.GetOrCreate(universeId.Value).UniverseAvatarJointPositioningTypeId.ToString()) ?? _UniverseAvatarSettingsDefaults.GetDefaultNewUniverseAvatarJointPositioningType();
	}

	/// <inheritdocs />
	public bool SetUniverseAvatarType(IUser user, long universeId, UniverseAvatarType universeAvatarType)
	{
		if (VerifyUniverseExistsAndUserCanManageUniverse(user, universeId))
		{
			return SetUniverseAvatarType(universeId, universeAvatarType);
		}
		return false;
	}

	/// <summary>
	/// UniverseAvatarSettings entities may not have existed for this universe, or may have had 0/null as the typeIDs.
	/// </summary>
	/// <param name="universeId">The Id of the universe to modify.</param>
	/// <param name="universeAvatarType">The type of Avatars that will be allowed by the universe.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">This exception is thrown when the a universe doesn't exist for the given UniverseId or the universeId is invalid.</exception>
	public bool SetUniverseAvatarTypeByAdmin(long universeId, UniverseAvatarType universeAvatarType)
	{
		if (_UniverseDomainFactories.UniverseFactory.GetUniverse(universeId) == null)
		{
			throw new PlatformArgumentException("universeId");
		}
		return SetUniverseAvatarType(universeId, universeAvatarType);
	}

	private bool SetUniverseAvatarType(long universeId, UniverseAvatarType universeAvatarType)
	{
		IUniverseAvatarSettingEntity entity = _UniverseAvatarSettingsEntityFactory.GetOrCreate(universeId);
		byte incomingAvatarTypeId = (byte)universeAvatarType;
		if (entity.UniverseAvatarTypeId == 0)
		{
			entity.UniverseAvatarTypeId = incomingAvatarTypeId;
			entity.Update();
			if (universeAvatarType != GetValidUniverseAvatarType(null))
			{
				return true;
			}
			return false;
		}
		if (entity.UniverseAvatarTypeId != incomingAvatarTypeId)
		{
			entity.UniverseAvatarTypeId = incomingAvatarTypeId;
			entity.Update();
			return true;
		}
		return false;
	}

	/// <inheritdocs />
	public void SetUniverseScaleType(IUser user, long universeId, UniverseScaleType universeScaleType)
	{
		if (VerifyUniverseExistsAndUserCanManageUniverse(user, universeId))
		{
			IUniverseAvatarSettingEntity entity = _UniverseAvatarSettingsEntityFactory.GetOrCreate(universeId);
			SetUniverseScaleType(entity, universeScaleType);
		}
	}

	/// <summary>
	/// UniverseAvatarSettings entities may not have existed for this universe, or may have had 0/null as the typeIDs.
	/// </summary>
	/// <param name="universeId">The Id of the universe to modify.</param>
	/// <param name="universeScaleType">The type of scales that will be allowed by the universe.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">This exception is thrown when the a universe doesn't exist for the given UniverseId or the universeId is invalid.</exception>
	public void SetUniverseScaleTypeByAdmin(long universeId, UniverseScaleType universeScaleType)
	{
		if (_UniverseDomainFactories.UniverseFactory.GetUniverse(universeId) == null)
		{
			throw new PlatformArgumentException("universeId");
		}
		IUniverseAvatarSettingEntity entity = _UniverseAvatarSettingsEntityFactory.GetOrCreate(universeId);
		byte incomingScaleTypeId = (byte)universeScaleType;
		if (incomingScaleTypeId != entity.UniverseScaleTypeId)
		{
			entity.UniverseScaleTypeId = incomingScaleTypeId;
			entity.Update();
		}
	}

	private void SetUniverseScaleType(IUniverseAvatarSettingEntity entity, UniverseScaleType universeScaleType)
	{
		byte incomingScaleTypeId = (byte)universeScaleType;
		if (incomingScaleTypeId != entity.UniverseScaleTypeId)
		{
			entity.UniverseScaleTypeId = incomingScaleTypeId;
			entity.Update();
		}
	}

	/// <inheritdocs />
	public void SetUniverseAvatarAnimationType(IUser user, long universeId, UniverseAvatarAnimationType universeAvatarAnimationType)
	{
		if (VerifyUniverseExistsAndUserCanManageUniverse(user, universeId))
		{
			IUniverseAvatarSettingEntity entity = _UniverseAvatarSettingsEntityFactory.GetOrCreate(universeId);
			byte incomingAnimationTypeId = (byte)universeAvatarAnimationType;
			if (incomingAnimationTypeId != entity.UniverseAvatarAnimationTypeId)
			{
				entity.UniverseAvatarAnimationTypeId = incomingAnimationTypeId;
				entity.Update();
			}
		}
	}

	/// <inheritdocs />
	public void SetUniverseAvatarCollisionType(IUser user, long universeId, UniverseAvatarCollisionType universeAvatarCollisionType)
	{
		if (VerifyUniverseExistsAndUserCanManageUniverse(user, universeId))
		{
			IUniverseAvatarSettingEntity entity = _UniverseAvatarSettingsEntityFactory.GetOrCreate(universeId);
			byte incomingCollisionTypeId = (byte)universeAvatarCollisionType;
			if (incomingCollisionTypeId != entity.UniverseAvatarCollisionTypeId)
			{
				entity.UniverseAvatarCollisionTypeId = incomingCollisionTypeId;
				entity.Update();
			}
		}
	}

	/// <inheritdocs />
	public void SetUniverseAvatarBodyType(IUser user, long universeId, UniverseAvatarBodyType universeAvatarBodyType)
	{
		if (VerifyUniverseExistsAndUserCanManageUniverse(user, universeId))
		{
			IUniverseAvatarSettingEntity entity = _UniverseAvatarSettingsEntityFactory.GetOrCreate(universeId);
			byte incomingBodyTypeId = (byte)universeAvatarBodyType;
			if (incomingBodyTypeId != entity.UniverseAvatarBodyTypeId)
			{
				entity.UniverseAvatarBodyTypeId = incomingBodyTypeId;
				entity.Update();
			}
		}
	}

	/// <inheritdocs />
	public void SetUniverseAvatarJointPositioningType(IUser user, long universeId, UniverseAvatarJointPositioningType universeAvatarJointPositioningType)
	{
		if (VerifyUniverseExistsAndUserCanManageUniverse(user, universeId))
		{
			IUniverseAvatarSettingEntity entity = _UniverseAvatarSettingsEntityFactory.GetOrCreate(universeId);
			byte incomingJointPostioningTypeId = (byte)universeAvatarJointPositioningType;
			if (incomingJointPostioningTypeId != entity.UniverseAvatarJointPositioningTypeId)
			{
				entity.UniverseAvatarJointPositioningTypeId = incomingJointPostioningTypeId;
				entity.Update();
			}
		}
	}

	/// <inheritdoc />
	public void SetUniverseAvatarMinScale(IUser user, long universeId, Scale clampedMinScale)
	{
		if (VerifyUniverseExistsAndUserCanManageUniverse(user, universeId))
		{
			IUniverseAvatarSettingEntity entity = _UniverseAvatarSettingsEntityFactory.GetOrCreate(universeId);
			Scale minScaleToSave = _ScaleFactory.GetOrCreate(clampedMinScale.Height, clampedMinScale.Width, clampedMinScale.Head.Value, clampedMinScale.Proportion.Value, clampedMinScale.BodyType.Value);
			if (minScaleToSave.Id != entity.UniverseAvatarMinScaleId)
			{
				entity.UniverseAvatarMinScaleId = minScaleToSave.Id;
				entity.Update();
			}
		}
	}

	/// <inheritdoc />
	public void SetUniverseAvatarMaxScale(IUser user, long universeId, Scale clampedMaxScale)
	{
		if (VerifyUniverseExistsAndUserCanManageUniverse(user, universeId))
		{
			IUniverseAvatarSettingEntity entity = _UniverseAvatarSettingsEntityFactory.GetOrCreate(universeId);
			Scale maxScaleToSave = _ScaleFactory.GetOrCreate(clampedMaxScale.Height, clampedMaxScale.Width, clampedMaxScale.Head.Value, clampedMaxScale.Proportion.Value, clampedMaxScale.BodyType.Value);
			if (maxScaleToSave.Id != entity.UniverseAvatarMaxScaleId)
			{
				entity.UniverseAvatarMaxScaleId = maxScaleToSave.Id;
				entity.Update();
			}
		}
	}

	private bool VerifyUniverseExistsAndUserCanManageUniverse(IUser user, long universeId)
	{
		IUniverse universe = _UniverseDomainFactories.UniverseFactory.GetUniverse(universeId);
		if (universe == null)
		{
			throw new PlatformArgumentException("universeId");
		}
		if (!_UniversePermissionsVerifier.CanUserManageUniverse(user, universe))
		{
			throw new PlatformPermissionDeniedException("user");
		}
		return true;
	}

	private int GetClampedScaleId(int scaleId)
	{
		Scale clampedScales = GetClampedScale(scaleId);
		return _ScaleFactory.GetOrCreate(clampedScales.Height, clampedScales.Width, clampedScales.Head.Value, clampedScales.Proportion.Value, clampedScales.BodyType.Value).Id;
	}

	private Scale GetClampedScale(int scaleId)
	{
		Scale originalScales = _ScaleFactory.Get(scaleId);
		bool minValid;
		return _OutfitDomainFactories.ScaleAuthority.GetClampedScale(out minValid, originalScales, null);
	}
}
