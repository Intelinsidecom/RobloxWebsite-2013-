using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Currency.Client;
using Roblox.EphemeralCounters;
using Roblox.EventLog;
using Roblox.Platform.Assets;
using Roblox.Platform.Avatar;
using Roblox.Platform.Billing;
using Roblox.Platform.Core;
using Roblox.Platform.Counters;
using Roblox.Platform.Devices;
using Roblox.Platform.Games.Counters.Properties;
using Roblox.Platform.Membership;
using Roblox.Platform.Outfits;
using Roblox.Platform.Universes;
using Roblox.Platform.UniverseSettings;

namespace Roblox.Platform.Games.Counters;

public class PlaySessionCounterRecorder
{
	private readonly IDurableCounterFactory _DurableCounterFactory;

	private readonly BufferedTimeBucketedCounter _PlaceTimePlayedBufferedCounter;

	private readonly BufferedTimeBucketedCounter _PlaceVisitsByDeviceTypeBufferedCounter;

	private readonly BufferedAllTimeCounter _PlaceVisitsByDeviceTypeBufferedAllTimeCounter;

	private readonly BufferedTimeBucketedCounter _PlaceVisitsByAgeGroupBufferedCounter;

	private readonly BufferedAllTimeCounter _PlaceVisitsByAgeGroupBufferedAllTimeCounter;

	private readonly PlaySessionAvatarDataCounter _PlaySessionAvatarDataCounter;

	private readonly PlaySessionFromVRCounter _PlaySessionFromVRCounter;

	private readonly PlaySessionUserCharacteristicCounter _PlaySessionUserCharacteristicCounter;

	private readonly PlaySessionUserPaymentDataCounter _PlaySessionUserPaymentDataCounter;

	private readonly PlaySessionDataCounter _PlaySessionDataRecorder;

	private readonly ILogger _Logger;

	private readonly IUniverseFactory _UniverseFactory;

	private readonly AvatarDomainFactories _AvatarDomainFactories;

	private readonly ICurrencyAuthority _CurrencyAuthority;

	private readonly AvatarPlaceSettingsResolver _AvatarPlaceSettingsResolver;

	private readonly UniverseSettingsDomainFactories _UniverseSettingsDomainFactories;

	private readonly Dictionary<int, string> _AccoutrementAssetTypes = new Dictionary<int, string>();

	private static CounterType _CounterType
	{
		get
		{
			CounterType aggregatedCounterType = CounterType.Hourly | CounterType.Daily | CounterType.Monthly;
			if (!Settings.Default.AreAggregatedCounterTypesForPlaceVisitsEnabled)
			{
				return CounterType.Hourly;
			}
			return aggregatedCounterType;
		}
	}

	public PlaySessionCounterRecorder(IDurableCounterFactory durableCounterFactory, IEphemeralCounterFactory ephemeralCounterFactory, IUniverseFactory universeFactory, AvatarDomainFactories avatarDomainFactories, UniverseSettingsDomainFactories universeSettingsDomainFactories, ILogger logger, Func<string> apiKeyGetter)
	{
		_DurableCounterFactory = durableCounterFactory ?? throw new PlatformArgumentNullException("durableCounterFactory");
		_UniverseFactory = universeFactory ?? throw new PlatformArgumentNullException("universeFactory");
		_AvatarDomainFactories = avatarDomainFactories ?? throw new PlatformArgumentNullException("avatarDomainFactories");
		_UniverseSettingsDomainFactories = universeSettingsDomainFactories ?? throw new ArgumentNullException("universeSettingsDomainFactories");
		_Logger = logger ?? throw new PlatformArgumentNullException("logger");
		_CurrencyAuthority = CurrencyAuthorityFactory.Singleton.GetCurrencyAuthority(apiKeyGetter);
		_AvatarPlaceSettingsResolver = new AvatarPlaceSettingsResolver(logger);
		_PlaceTimePlayedBufferedCounter = new BufferedTimeBucketedCounter(_DurableCounterFactory, logger);
		_PlaceVisitsByDeviceTypeBufferedCounter = new BufferedTimeBucketedCounter(_DurableCounterFactory, logger);
		_PlaceVisitsByDeviceTypeBufferedAllTimeCounter = new BufferedAllTimeCounter(_DurableCounterFactory, logger);
		_PlaySessionAvatarDataCounter = new PlaySessionAvatarDataCounter(ephemeralCounterFactory, logger);
		_PlaySessionUserCharacteristicCounter = new PlaySessionUserCharacteristicCounter(ephemeralCounterFactory, logger);
		_PlaySessionDataRecorder = new PlaySessionDataCounter(ephemeralCounterFactory, logger);
		_PlaySessionUserPaymentDataCounter = new PlaySessionUserPaymentDataCounter(ephemeralCounterFactory, logger);
		_PlaySessionFromVRCounter = new PlaySessionFromVRCounter(ephemeralCounterFactory, logger);
		_PlaceVisitsByAgeGroupBufferedCounter = new BufferedTimeBucketedCounter(_DurableCounterFactory, logger);
		_PlaceVisitsByAgeGroupBufferedAllTimeCounter = new BufferedAllTimeCounter(_DurableCounterFactory, logger);
		foreach (IList<int> item in new List<IList<int>>
		{
			AvatarAnimationAssetTypes.GetAvatarAnimationAssetTypeIds,
			ClothingAssetTypes.GetClothingAssetTypeIds,
			BodyPartAssetTypes.GetBodyPartAssetTypeIds,
			AccessoryAssetTypes.GetAccessoryAssetTypeIds
		})
		{
			foreach (int assetTypeId in item)
			{
				AssetType assetType = AssetType.Get(assetTypeId);
				_AccoutrementAssetTypes[assetTypeId] = assetType.Value.Replace(" ", "");
			}
		}
		_AccoutrementAssetTypes[AssetType.GearID] = "Gear";
	}

	/// <summary>
	/// Buffers Place Visits by device type counter and periodically increments it
	/// </summary>
	/// <param name="placeId">The place identifier.</param>
	/// <param name="deviceType">The <see cref="T:Roblox.Platform.Devices.DeviceType" />.</param>
	/// <param name="incrementTime">The time bucket.</param>
	/// <param name="incrementBy">The increment amount.</param>
	public void IncrementPlaceVisitsByDeviceTypes(long placeId, DeviceType? deviceType, DateTime incrementTime, long incrementBy = 1L)
	{
		ITimeBucketedCounter placeVisitsByDeviceTypeTimeBucketedCounter = _DurableCounterFactory.GetPlaceVisitsByDeviceTypeTimeBucketedCounter(placeId, deviceType, _CounterType);
		_PlaceVisitsByDeviceTypeBufferedCounter.Increment(placeVisitsByDeviceTypeTimeBucketedCounter, incrementTime, incrementBy);
		Roblox.Platform.Counters.ICounter placeVisitsByDeviceTypeAllTimeCounter = _DurableCounterFactory.GetPlaceVisitsByDeviceTypeCounter(placeId, deviceType);
		_PlaceVisitsByDeviceTypeBufferedAllTimeCounter.Increment(placeVisitsByDeviceTypeAllTimeCounter.GetKey(), incrementBy);
	}

	/// <summary>
	/// Buffers the place visits by age group counter and periodically increments it.
	/// </summary>
	/// <param name="placeId">The place identifier.</param>
	/// <param name="devStatsUserAgeGroup">The <see cref="T:Roblox.Platform.Counters.DevStatsUserAgeGroup" />.</param>
	/// <param name="incrementTime">The time bucket.</param>
	/// <param name="incrementBy">The increment amount.</param>
	public void IncrementPlaceVisitsByAgeGroup(long placeId, DevStatsUserAgeGroup? devStatsUserAgeGroup, DateTime incrementTime, long incrementBy = 1L)
	{
		ITimeBucketedCounter placeVisitsByAgeGroupTimeBucketedCounter = _DurableCounterFactory.GetPlaceVisitsByAgeGroupTimeBucketedCounter(placeId, devStatsUserAgeGroup, _CounterType);
		_PlaceVisitsByAgeGroupBufferedCounter.Increment(placeVisitsByAgeGroupTimeBucketedCounter, incrementTime, incrementBy);
		Roblox.Platform.Counters.ICounter placeVisitsByAgeGroupCounter = _DurableCounterFactory.GetPlaceVisitsByAgeGroupCounter(placeId, devStatsUserAgeGroup, _CounterType);
		_PlaceVisitsByAgeGroupBufferedAllTimeCounter.Increment(placeVisitsByAgeGroupCounter.GetKey(), incrementBy);
	}

	/// <summary>
	/// Buffers Play duration counter and periodically increments it
	/// </summary>
	/// <param name="placeId">The place identifier.</param>
	/// <param name="deviceType">The <see cref="T:Roblox.Platform.Devices.DeviceType" />.</param>
	/// <param name="incrementTime">The time bucket.</param>
	/// <param name="playDuration">Duration of the play.</param>
	public void IncrementPlacePlayDuration(long placeId, DeviceType? deviceType, DateTime incrementTime, TimeSpan playDuration)
	{
		ITimeBucketedCounter placeTimePlayed = _DurableCounterFactory.GetPlaceTimePlayedTimeBucketedCounter(placeId, deviceType, _CounterType);
		_PlaceTimePlayedBufferedCounter.Increment(placeTimePlayed, incrementTime, playDuration.TotalSeconds);
	}

	public void RecordPlaySessionData(bool isParty, int seconds)
	{
		if (isParty)
		{
			_PlaySessionDataRecorder.IncrementPartyJoinCount(seconds);
		}
	}

	public void RecordUserPaymentDataForPlaySession(IUser user, int seconds)
	{
		_Logger.Verbose(() => "PlaySessionsAggregator: RecordUserPaymentDataForPlaySession");
		if (user == null)
		{
			return;
		}
		if (user.IsAnyBuildersClubMember())
		{
			_PlaySessionUserPaymentDataCounter.IncrementIsAnyBC(seconds);
			if (user.IsBCMember(MembershipLevels.BCMembershipLevel.TBC))
			{
				_PlaySessionUserPaymentDataCounter.IncrementIsOBC(seconds);
			}
			else if (user.IsBCMember(MembershipLevels.BCMembershipLevel.OBC))
			{
				_PlaySessionUserPaymentDataCounter.IncrementIsTBC(seconds);
			}
			else if (user.IsBCMember(MembershipLevels.BCMembershipLevel.BC))
			{
				_PlaySessionUserPaymentDataCounter.IncrementIsBC(seconds);
			}
		}
		long balance = _CurrencyAuthority.GetCurrencyBalances(user.Id).RobuxBalance;
		int digits = ((balance != 0L) ? ((int)Math.Floor(Math.Log10(balance) + 1.0)) : 0);
		_PlaySessionUserPaymentDataCounter.IncrementRobuxBalanceSignificantDigitsCount(digits, seconds);
		if (user.IsPaidUser())
		{
			_PlaySessionUserPaymentDataCounter.IncrementPaidUsers(seconds);
		}
	}

	/// <summary>
	///
	/// </summary>
	/// <param name="user">If null, it means user is a guest, consult playerId.</param>
	/// <param name="playerId"></param>
	/// <param name="placeId"></param>
	public void RecordUserCharacteristicsForPlaySession(IUser user, long playerId, long placeId, int seconds)
	{
		_PlaySessionUserCharacteristicCounter.IncrementPlaySessionEnded(seconds);
		_Logger.Verbose(() => "PlaySessionsAggregator: RecordUserCharacteristicsForPlaySession");
		string gender;
		if (playerId < 0)
		{
			gender = _PlaySessionAvatarDataCounter.GetGuestGender(playerId);
			_PlaySessionUserCharacteristicCounter.IncrementGuestPlaySessionEnded(seconds);
			_PlaySessionUserCharacteristicCounter.IncrementGenderAndGuestCount(gender, guest: true, seconds);
			return;
		}
		gender = user.GenderType.ToString();
		_PlaySessionUserCharacteristicCounter.IncrementLoggedInUserPlaySessionEnded(seconds);
		_PlaySessionUserCharacteristicCounter.IncrementGenderAndGuestCount(gender, guest: false, seconds);
		if (user.HasVerifiedEmail())
		{
			_PlaySessionUserCharacteristicCounter.IncrementHasVerifiedEmail(seconds);
		}
		double? testPlayerAge = user.ApproximateAgeInDoubleYears();
		string playerAgeValue;
		if (testPlayerAge.HasValue)
		{
			double ageGroup = Math.Floor(testPlayerAge.Value / 5.0) * 5.0;
			playerAgeValue = $"{ageGroup}-{ageGroup + 5.0}";
		}
		else
		{
			playerAgeValue = "Unknown";
		}
		_PlaySessionUserCharacteristicCounter.IncrementPlayerAgeCount(playerAgeValue, seconds);
		int accountAge = (int)Math.Floor((decimal)DateTime.Now.Subtract(user.Created).Days / 365m);
		_PlaySessionUserCharacteristicCounter.IncrementAccountAgeInYearsCount(accountAge, seconds);
	}

	public void RecordAvatarDataForPlaySession(IUser user, long playerId, long placeId, int usingGuestUserId, int seconds)
	{
		_Logger.Verbose(() => "PlaySessionsAggregator: RecordAvatarDataForPlaySession");
		IUniverse universe = _UniverseFactory.GetPlaceUniverse(placeId);
		bool isGuest = playerId < 0;
		IAvatar avatar;
		string gender;
		if (isGuest)
		{
			avatar = _AvatarDomainFactories.AvatarFactory.GetAvatar(usingGuestUserId);
			gender = _PlaySessionAvatarDataCounter.GetGuestGender(playerId);
		}
		else
		{
			avatar = _AvatarDomainFactories.AvatarFactory.GetAvatar(user.Id);
			gender = user.GenderType.ToString();
		}
		UniverseAvatarSettingsResponseModel universeAvatarSettings = _UniverseSettingsDomainFactories.UniverseSettingsFactory.GetUniverseAvatarSettings(universe.Id);
		_PlaySessionAvatarDataCounter.IncrementUniverseAvatarType(universeAvatarSettings.UniverseAvatarType, isGuest, seconds);
		ResolvedAvatarTypeEnum resolvedAvatarType = _AvatarPlaceSettingsResolver.GetResolvedAvatarType(avatar, universeAvatarSettings.UniverseAvatarType);
		_PlaySessionAvatarDataCounter.IncrementResolvedAvatarType(resolvedAvatarType, isGuest, seconds);
		_PlaySessionAvatarDataCounter.IncrementUniverseScaleType(universeAvatarSettings.UniverseScaleType, isGuest, seconds);
		_PlaySessionAvatarDataCounter.IncrementUniverseAvatarAnimationType(universeAvatarSettings.UniverseAvatarAnimationType, isGuest, seconds);
		_PlaySessionAvatarDataCounter.IncrementUniverseAvatarCollisionType(universeAvatarSettings.UniverseAvatarCollisionType, isGuest, seconds);
		_PlaySessionAvatarDataCounter.IncrementUniverseAvatarBodyType(universeAvatarSettings.UniverseAvatarBodyType, isGuest, seconds);
		_PlaySessionAvatarDataCounter.IncrementUniverseAvatarJointPositioningType(universeAvatarSettings.UniverseAvatarJointPositioningType, isGuest, seconds);
		ScaleDescriptionEnum scaleDescription = _AvatarPlaceSettingsResolver.GetResolvedScale(avatar, universeAvatarSettings.UniverseScaleType, universeAvatarSettings.UniverseAvatarBodyType).GetScaleDescription();
		_PlaySessionAvatarDataCounter.IncrementScaleDescription(scaleDescription, isGuest, gender, seconds);
		if (isGuest)
		{
			return;
		}
		_PlaySessionAvatarDataCounter.IncrementPlayerAvatarType(avatar.GetPlayerAvatarType(), seconds);
		IReadOnlyDictionary<int, int> wornAssetTypeIdCounts = avatar.GetWornAssetTypeIdCounts();
		int animationCount = wornAssetTypeIdCounts.Where((KeyValuePair<int, int> kvp) => AvatarAnimationAssetTypes.GetAvatarAnimationAssetTypeIds.Contains(kvp.Key)).Sum((KeyValuePair<int, int> kvp2) => kvp2.Value);
		int clothesCount = wornAssetTypeIdCounts.Where((KeyValuePair<int, int> kvp) => ClothingAssetTypes.GetClothingAssetTypeIds.Contains(kvp.Key)).Sum((KeyValuePair<int, int> kvp2) => kvp2.Value);
		int bodypartCount = wornAssetTypeIdCounts.Where((KeyValuePair<int, int> kvp) => BodyPartAssetTypes.GetBodyPartAssetTypeIds.Contains(kvp.Key)).Sum((KeyValuePair<int, int> kvp2) => kvp2.Value);
		int accessoryCount = wornAssetTypeIdCounts.Where((KeyValuePair<int, int> kvp) => AccessoryAssetTypes.GetAccessoryAssetTypeIds.Contains(kvp.Key)).Sum((KeyValuePair<int, int> kvp2) => kvp2.Value);
		_PlaySessionAvatarDataCounter.IncrementAnimationCount(animationCount, seconds);
		_PlaySessionAvatarDataCounter.IncrementClothingCount(clothesCount, seconds);
		_PlaySessionAvatarDataCounter.IncrementBodyPartCount(bodypartCount, seconds);
		_PlaySessionAvatarDataCounter.IncrementAccessoryCount(accessoryCount, seconds);
		foreach (KeyValuePair<int, string> kvp3 in _AccoutrementAssetTypes)
		{
			int assetTypeId = kvp3.Key;
			if (wornAssetTypeIdCounts.ContainsKey(assetTypeId) && wornAssetTypeIdCounts[assetTypeId] > 0)
			{
				_PlaySessionAvatarDataCounter.IncrementWearingAssetTypeId(kvp3.Value, seconds);
			}
		}
		IBrickBodyColorSet bodyColors = avatar.GetBodyColors();
		int distinctBodyColorCount = new HashSet<int> { bodyColors.HeadBrickColorId, bodyColors.LeftArmBrickColorId, bodyColors.LeftLegBrickColorId, bodyColors.RightArmBrickColorId, bodyColors.RightLegBrickColorId, bodyColors.TorsoBrickColorId }.Count;
		_PlaySessionAvatarDataCounter.IncrementBodyColorCount(distinctBodyColorCount, seconds);
		if (_AvatarDomainFactories.DefaultClothingEnforcer.GetDefaultClothingState(avatar, out var shirt, out var pants))
		{
			if (pants)
			{
				_PlaySessionAvatarDataCounter.IncrementWearingDefaultPants(seconds);
			}
			if (shirt)
			{
				_PlaySessionAvatarDataCounter.IncrementWearingDefaultShirt(seconds);
			}
		}
		if (avatar.IsUsingAdvancedAccessories(_AvatarDomainFactories))
		{
			_PlaySessionAvatarDataCounter.IncrementUsingAdvancedAccessories(seconds);
		}
	}

	/// <summary>
	/// Increments counter for game joins from VR for specified device type
	/// </summary>
	/// <param name="deviceType">The type of device <see cref="T:Roblox.Platform.Devices.DeviceType" /></param>
	public void IncrementGameJoinsFromVRByDeviceType(DeviceType deviceType)
	{
		_PlaySessionFromVRCounter.IncrementForDeviceType(deviceType);
	}

	/// <summary>
	/// Increments counter for game joins from VR (total amount of joins from VR)
	/// </summary>
	public void IncrementGameJoinsFromVR()
	{
		_PlaySessionFromVRCounter.IncrementTotal();
	}
}
