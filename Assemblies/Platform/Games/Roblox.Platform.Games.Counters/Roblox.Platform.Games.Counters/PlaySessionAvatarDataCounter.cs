using Roblox.EphemeralCounters;
using Roblox.EventLog;
using Roblox.Platform.Avatar;
using Roblox.Platform.Core;
using Roblox.Platform.Outfits;
using Roblox.Platform.UniverseSettings;

namespace Roblox.Platform.Games.Counters;

public class PlaySessionAvatarDataCounter : PlaySessionCounterBase
{
	/// <summary>
	/// In playsession context, the playSessionEvent.PlayerId is actually a random negative number which encodes the genderTypeId.
	/// i.e. guests have characterAppearanceId as billyBloxer or bettyBloxer, but their actual userId is overridden.
	/// </summary>
	public string GetGuestGender(long playerId)
	{
		if (playerId < 0)
		{
			return (playerId % 3) switch
			{
				0L => "Female", 
				1L => "Unknown", 
				_ => "Male", 
			};
		}
		throw new PlatformArgumentException("Cannot use this function to get logged in user gender.");
	}

	public PlaySessionAvatarDataCounter(IEphemeralCounterFactory ephemeralCounterFactory, ILogger logger)
		: base(ephemeralCounterFactory, logger)
	{
	}

	public void IncrementPlayerAvatarType(PlayerAvatarType playerAvatarType, int seconds)
	{
		string key = $"GameJoins_PlayerAvatarType_{playerAvatarType}";
		IncrementCountAndTotalSeconds(key, seconds);
	}

	public void IncrementResolvedAvatarType(ResolvedAvatarTypeEnum resolvedAvatarType, bool guest, int seconds)
	{
		string guestStr = (guest ? "_Guest" : "");
		string key = $"GameJoins_ResolvedAvatarType{guestStr}_{resolvedAvatarType}";
		IncrementCountAndTotalSeconds(key, seconds);
	}

	public void IncrementUniverseAvatarType(UniverseAvatarType universeAvatarType, bool guest, int seconds)
	{
		string guestStr = (guest ? "_Guest" : "");
		string key = $"GameJoins_UniverseAvatarType{guestStr}_{universeAvatarType}";
		IncrementCountAndTotalSeconds(key, seconds);
	}

	public void IncrementScaleDescription(ScaleDescriptionEnum scaleDescription, bool guest, string gender, int seconds)
	{
		string guestStr = (guest ? "_Guest" : "");
		string key = $"GameJoins_ScaleDescription{guestStr}_{gender}_{scaleDescription}";
		IncrementCountAndTotalSeconds(key, seconds);
	}

	public void IncrementUniverseScaleType(UniverseScaleType universeScaleType, bool guest, int seconds)
	{
		string guestStr = (guest ? "_Guest" : "");
		string key = $"GameJoins_UniverseScaleType{guestStr}_{universeScaleType}";
		IncrementCountAndTotalSeconds(key, seconds);
	}

	public void IncrementUniverseAvatarAnimationType(UniverseAvatarAnimationType universeAvatarAnimationType, bool guest, int seconds)
	{
		string guestStr = (guest ? "_Guest" : "");
		string key = $"GameJoins_UniverseAvatarAnimationType{guestStr}_{universeAvatarAnimationType}";
		IncrementCountAndTotalSeconds(key, seconds);
	}

	public void IncrementUniverseAvatarCollisionType(UniverseAvatarCollisionType universeAvatarCollisionType, bool guest, int seconds)
	{
		string guestStr = (guest ? "_Guest" : "");
		string key = $"GameJoins_UniverseAvatarCollisionType{guestStr}_{universeAvatarCollisionType}";
		IncrementCountAndTotalSeconds(key, seconds);
	}

	public void IncrementUniverseAvatarBodyType(UniverseAvatarBodyType universeAvatarBodyType, bool guest, int seconds)
	{
		string guestStr = (guest ? "_Guest" : "");
		string key = $"GameJoins_UniverseAvatarBodyType{guestStr}_{universeAvatarBodyType}";
		IncrementCountAndTotalSeconds(key, seconds);
	}

	public void IncrementUniverseAvatarJointPositioningType(UniverseAvatarJointPositioningType universeAvatarJointPositioningType, bool guest, int seconds)
	{
		string guestStr = (guest ? "_Guest" : "");
		string key = $"GameJoins_UniverseAvatarJointPositioningType{guestStr}_{universeAvatarJointPositioningType}";
		IncrementCountAndTotalSeconds(key, seconds);
	}

	public void IncrementAnimationCount(int animationCount, int seconds)
	{
		string key = $"GameJoins_WornAnimations_{animationCount}";
		IncrementCountAndTotalSeconds(key, seconds);
	}

	public void IncrementBodyPartCount(int bodyPartCount, int seconds)
	{
		string key = $"GameJoins_WornBodyParts_{bodyPartCount}";
		IncrementCountAndTotalSeconds(key, seconds);
	}

	public void IncrementAccessoryCount(int accessoryCount, int seconds)
	{
		string key = $"GameJoins_WornAccessories_{accessoryCount}";
		IncrementCountAndTotalSeconds(key, seconds);
	}

	public void IncrementBodyColorCount(int colorCount, int seconds)
	{
		string key = $"GameJoins_WornColors_{colorCount}";
		IncrementCountAndTotalSeconds(key, seconds);
	}

	public void IncrementClothingCount(int clothingCount, int seconds)
	{
		string key = $"GameJoins_WornClothing_{clothingCount}";
		IncrementCountAndTotalSeconds(key, seconds);
	}

	public void IncrementUsingAdvancedAccessories(int seconds)
	{
		string key = "GameJoins_UsingAdvancedAccessories";
		IncrementCountAndTotalSeconds(key, seconds);
	}

	public void IncrementWearingAssetTypeId(string assetType, int seconds)
	{
		string key = $"GameJoins_WearingAssetType_{assetType}";
		IncrementCountAndTotalSeconds(key, seconds);
	}

	public void IncrementWearingDefaultPants(int seconds)
	{
		string key = "GameJoins_WearingDefaultPants";
		IncrementCountAndTotalSeconds(key, seconds);
	}

	public void IncrementWearingDefaultShirt(int seconds)
	{
		string key = "GameJoins_WearingDefaultShirt";
		IncrementCountAndTotalSeconds(key, seconds);
	}
}
