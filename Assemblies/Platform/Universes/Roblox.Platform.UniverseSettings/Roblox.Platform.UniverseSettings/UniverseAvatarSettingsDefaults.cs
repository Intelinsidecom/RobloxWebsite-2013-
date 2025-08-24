using Roblox.Common;
using Roblox.Platform.Core;
using Roblox.Platform.Outfits;
using Roblox.Platform.UniverseSettings.Properties;

namespace Roblox.Platform.UniverseSettings;

public class UniverseAvatarSettingsDefaults
{
	private IScaleFactory _ScaleFactory;

	public UniverseAvatarSettingsDefaults(IScaleFactory scaleFactory)
	{
		_ScaleFactory = scaleFactory ?? throw new PlatformArgumentNullException("scaleFactory");
	}

	public UniverseAvatarType GetDefaultPlaceUniverseAvatarTypeForUnknownPlace()
	{
		UniverseAvatarType? universeAvatarType = EnumUtils.StrictTryParseEnum<UniverseAvatarType>(Settings.Default.DefaultUniverseAvatarTypeForUnknownPlace);
		if (!universeAvatarType.HasValue)
		{
			return UniverseAvatarType.PlayerChoice;
		}
		return universeAvatarType.Value;
	}

	public UniverseAvatarBodyType GetDefaultPlaceUniverseBodyTypeForUnknownPlace()
	{
		UniverseAvatarBodyType? universeBodyType = EnumUtils.StrictTryParseEnum<UniverseAvatarBodyType>(Settings.Default.DefaultUniverseBodyTypeForUnknownPlace);
		if (!universeBodyType.HasValue)
		{
			return UniverseAvatarBodyType.PlayerChoice;
		}
		return universeBodyType.Value;
	}

	public UniverseAvatarType GetDefaultNewUniverseAvatarType()
	{
		UniverseAvatarType? universeAvatarType = EnumUtils.StrictTryParseEnum<UniverseAvatarType>(Settings.Default.DefaultUniverseAvatarType);
		if (!universeAvatarType.HasValue)
		{
			return UniverseAvatarType.MorphToR6;
		}
		return universeAvatarType.Value;
	}

	public UniverseScaleType GetDefaultNewUniverseScaleType()
	{
		UniverseScaleType? universeScaleType = EnumUtils.StrictTryParseEnum<UniverseScaleType>(Settings.Default.DefaultUniverseScaleType);
		if (!universeScaleType.HasValue)
		{
			return UniverseScaleType.NoScales;
		}
		return universeScaleType.Value;
	}

	public UniverseAvatarAnimationType GetDefaultNewUniverseAvatarAnimationType()
	{
		UniverseAvatarAnimationType? universeAvatarAnimationType = EnumUtils.StrictTryParseEnum<UniverseAvatarAnimationType>(Settings.Default.DefaultUniverseAvatarAnimationType);
		if (!universeAvatarAnimationType.HasValue)
		{
			return UniverseAvatarAnimationType.PlayerChoice;
		}
		return universeAvatarAnimationType.Value;
	}

	public UniverseAvatarCollisionType GetDefaultNewUniverseAvatarCollisionType()
	{
		UniverseAvatarCollisionType? universeAvatarCollisionType = EnumUtils.StrictTryParseEnum<UniverseAvatarCollisionType>(Settings.Default.DefaultUniverseAvatarCollisionType);
		if (!universeAvatarCollisionType.HasValue)
		{
			return UniverseAvatarCollisionType.OuterBox;
		}
		return universeAvatarCollisionType.Value;
	}

	public UniverseAvatarBodyType GetDefaultNewUniverseAvatarBodyType()
	{
		UniverseAvatarBodyType? universeAvatarBodyType = EnumUtils.StrictTryParseEnum<UniverseAvatarBodyType>(Settings.Default.DefaultUniverseAvatarBodyType);
		if (!universeAvatarBodyType.HasValue)
		{
			return UniverseAvatarBodyType.Standard;
		}
		return universeAvatarBodyType.Value;
	}

	public UniverseAvatarJointPositioningType GetDefaultNewUniverseAvatarJointPositioningType()
	{
		UniverseAvatarJointPositioningType? universeAvatarJointPositioningType = EnumUtils.StrictTryParseEnum<UniverseAvatarJointPositioningType>(Settings.Default.DefaultUniverseAvatarJointPositioningType);
		if (!universeAvatarJointPositioningType.HasValue)
		{
			return UniverseAvatarJointPositioningType.Standard;
		}
		return universeAvatarJointPositioningType.Value;
	}

	public int GetDefaultNewUniverseAvatarMaxScaleId()
	{
		return GetDefaultNewUniverseAvatarMaxScale().Id;
	}

	public int GetDefaultNewUniverseAvatarMinScaleId()
	{
		return GetDefaultNewUniverseAvatarMinScale().Id;
	}

	public Scale GetDefaultNewUniverseAvatarMaxScale()
	{
		return _ScaleFactory.GetOrCreate(Settings.Default.UniverseAvatarMaxHeightDefault, Settings.Default.UniverseAvatarMaxWidthDefault, Settings.Default.UniverseAvatarMaxHeadDefault, Settings.Default.UniverseAvatarMaxProportionDefault, Settings.Default.UniverseAvatarMaxBodyTypeDefault);
	}

	public Scale GetDefaultNewUniverseAvatarMinScale()
	{
		return _ScaleFactory.GetOrCreate(Settings.Default.UniverseAvatarMinHeightDefault, Settings.Default.UniverseAvatarMinWidthDefault, Settings.Default.UniverseAvatarMinHeadDefault, Settings.Default.UniverseAvatarMinProportionDefault, Settings.Default.UniverseAvatarMinBodyTypeDefault);
	}
}
