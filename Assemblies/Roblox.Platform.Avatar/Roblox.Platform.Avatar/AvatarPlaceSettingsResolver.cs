using Roblox.Common;
using Roblox.EventLog;
using Roblox.Platform.Avatar.Properties;
using Roblox.Platform.Core;
using Roblox.Platform.Outfits;
using Roblox.Platform.UniverseSettings;

namespace Roblox.Platform.Avatar;

/// <summary>
/// This answers questions related to creating an avatar for a given user and place.
/// </summary>
public class AvatarPlaceSettingsResolver
{
	private ILogger Logger;

	public AvatarPlaceSettingsResolver(ILogger logger)
	{
		Logger = logger ?? throw new PlatformArgumentNullException("logger");
	}

	/// <summary>
	/// What resolvedAvatarType most directly matches the player's one, with no input from the universe?
	/// </summary>
	public static ResolvedAvatarTypeEnum ConvertToResolvedAvatarType(PlayerAvatarType playerAvatarType)
	{
		return playerAvatarType switch
		{
			PlayerAvatarType.R6 => ResolvedAvatarTypeEnum.R6, 
			PlayerAvatarType.R15 => ResolvedAvatarTypeEnum.R15, 
			_ => ResolvedAvatarTypeEnum.R6, 
		};
	}

	/// <summary>
	/// If someone is trying to get into a game, and we don't have any information on player preference,
	/// Determine how to resolve the user solely based on the universe's UniverseAvatarType.
	/// </summary>
	/// <param name="universeAvatarType"></param>
	/// <returns></returns>
	public ResolvedAvatarTypeEnum ConvertToResolvedAvatarType(UniverseAvatarType universeAvatarType)
	{
		switch (universeAvatarType)
		{
		case UniverseAvatarType.MorphToR6:
			return ResolvedAvatarTypeEnum.R6;
		case UniverseAvatarType.MorphToR15:
			return ResolvedAvatarTypeEnum.R15;
		case UniverseAvatarType.PlayerChoice:
			Logger.Error($"Unexpected value for universeAvatarType: {universeAvatarType.ToString()}");
			return ResolvedAvatarTypeEnum.R6;
		default:
			Logger.Error($"Unexpected value for universeAvatarType: {universeAvatarType.ToString()}");
			return ResolvedAvatarTypeEnum.R6;
		}
	}

	/// <summary>
	/// What resolvedAvatarType should a certain player have in a certain place?
	/// This combines what we know of the player's desires with what the dev has set up as allowed for their universe, into a resolvedAvatarType.
	///
	/// This method is called on game join.  For logged in users, it receives their real avatar.
	/// for guests, it's called with the avatar of their "CharacterAppearanceId", who is just the avatar they look like.
	/// </summary>
	public ResolvedAvatarTypeEnum GetResolvedAvatarType(IAvatar avatar, UniverseAvatarType universeAvatarType)
	{
		if (avatar == null)
		{
			return ConvertToResolvedAvatarType(universeAvatarType);
		}
		if (universeAvatarType == UniverseAvatarType.PlayerChoice)
		{
			return ConvertToResolvedAvatarType(avatar.GetPlayerAvatarType());
		}
		return ConvertToResolvedAvatarType(universeAvatarType);
	}

	/// <summary>
	/// Interpret an optional setting string as a playerAvatarType.
	/// This coerces settings values into only valid enum values
	/// </summary>
	public static PlayerAvatarType? InterpretPlayerAvatarTypeSetting(string settingValue)
	{
		return EnumUtils.StrictTryParseEnum<PlayerAvatarType>(settingValue);
	}

	/// <summary>
	/// Interpret an optional setting string as a resolvedAvatarType.
	/// This coerces settings values into only valid enum values
	/// </summary>
	public static ResolvedAvatarTypeEnum? InterpretResolvedAvatarTypeSetting(string settingValue)
	{
		return EnumUtils.StrictTryParseEnum<ResolvedAvatarTypeEnum>(settingValue);
	}

	/// <summary>
	/// Avatar type for thumbnailing when no resolvedAvatarType is specified.
	/// </summary>
	public static ResolvedAvatarTypeEnum GetDefaultThumbnailResolvedAvatarType()
	{
		ResolvedAvatarTypeEnum? defaultThumbnailAvatarType = InterpretResolvedAvatarTypeSetting(Settings.Default.DefaultThumbnailAvatarType);
		if (defaultThumbnailAvatarType.HasValue)
		{
			return defaultThumbnailAvatarType.Value;
		}
		return ResolvedAvatarTypeEnum.R6;
	}

	/// <summary>
	/// Globally override resolvedAvatarType the thumbnailer uses.
	/// </summary>
	public static ResolvedAvatarTypeEnum? GetOverrideThumbnailResolvedAvatarType()
	{
		return InterpretResolvedAvatarTypeSetting(Settings.Default.OverrideThumbnailAvatarType);
	}

	/// <summary>
	/// Gets the resolved scale for an avatar.
	/// https://confluence.roblox.com/display/PLATFORM/Avatar+Scaling+and+Scales
	/// </summary>
	/// <param name="avatar">The avatar</param>
	/// <param name="universeScaleType">The universeScaleType of the universe the avatar is joining</param>
	/// <param name="universeBodyType"></param>
	/// <returns></returns>
	public IAvatarScale GetResolvedScale(IAvatar avatar, Roblox.Platform.UniverseSettings.UniverseScaleType universeScaleType, UniverseAvatarBodyType universeBodyType)
	{
		IAvatarScale defaultScale = avatar.GetDefaultScale();
		AvatarScale scale = Translate(defaultScale);
		if (universeScaleType != Roblox.Platform.UniverseSettings.UniverseScaleType.NoScales)
		{
			IAvatarScale avatarScale2 = avatar.GetScale();
			scale.Height = avatarScale2.Height;
			scale.Width = avatarScale2.Width;
			scale.Head = avatarScale2.Head;
			scale.Depth = ScaleRules.Depth.CalculateDepth(avatarScale2.Width);
		}
		scale.Proportion = ScaleRules.Proportion.Default;
		scale.BodyType = ScaleRules.BodyType.Default;
		if (universeBodyType != UniverseAvatarBodyType.Standard)
		{
			IAvatarScale avatarScale = avatar.GetScale();
			scale.Proportion = avatarScale.Proportion;
			scale.BodyType = avatarScale.BodyType;
		}
		return scale;
	}

	private AvatarScale Translate(IAvatarScale avatarScale)
	{
		return new AvatarScale(avatarScale.Height, avatarScale.Width, avatarScale.Head, avatarScale.Depth, avatarScale.Proportion, avatarScale.BodyType);
	}
}
