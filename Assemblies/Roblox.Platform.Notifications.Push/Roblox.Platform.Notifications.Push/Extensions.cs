using System;
using System.Linq;
using Roblox.Platform.Membership;
using Roblox.Platform.Notifications.Core;
using Roblox.Platform.Notifications.Push.Entities;
using Roblox.Platform.Notifications.Push.Properties;

namespace Roblox.Platform.Notifications.Push;

public static class Extensions
{
	public static bool IsPushNotificationsEnabled(this IUser user)
	{
		if (user == null)
		{
			return false;
		}
		if (user.AgeBracket == AgeBracket.AgeUnder13)
		{
			return false;
		}
		if (user.Id % 100 < Settings.Default.PushNotificationsRegularUserRolloutPercentage)
		{
			return true;
		}
		if (Settings.Default.IsPushNotificationsEnabledForBetaTesters && user.IsBetaTester())
		{
			return true;
		}
		if (Settings.Default.IsPushNotificationsEnabledForSoothsayers && user.IsSoothSayer())
		{
			return true;
		}
		return false;
	}

	public static bool IsPushNotificationsEnabledOnChrome(this IUser user)
	{
		if (user == null)
		{
			return false;
		}
		if (!Settings.Default.IsPushNotificationsEnabledOnChromeForRegularUsers)
		{
			if (Settings.Default.IsPushNotificationsEnabledOnChromeForSoothsayers)
			{
				return user.IsSoothSayer();
			}
			return false;
		}
		return true;
	}

	public static bool IsPushNotificationsEnabledOnFirefox(this IUser user)
	{
		if (user == null)
		{
			return false;
		}
		if (!Settings.Default.IsPushNotificationsEnabledOnFirefoxForRegularUsers)
		{
			if (Settings.Default.IsPushNotificationsEnabledOnFirefoxForSoothsayers)
			{
				return user.IsSoothSayer();
			}
			return false;
		}
		return true;
	}

	public static bool IsPushNotificationsEnabledOnAndroid(this IUser user)
	{
		if (user == null)
		{
			return false;
		}
		if (!Settings.Default.IsPushNotificationsEnabledOnAndroidForRegularUsers)
		{
			if (Settings.Default.IsPushNotificationsEnabledOnAndroidForSoothsayers)
			{
				return user.IsSoothSayer();
			}
			return false;
		}
		return true;
	}

	public static bool IsPushNotificationsEnabledOnAndroidAmazon(this IUser user)
	{
		if (user == null)
		{
			return false;
		}
		if (!Settings.Default.IsPushNotificationsEnabledOnAndroidAmazonForRegularUsers)
		{
			if (Settings.Default.IsPushNotificationsEnabledOnAndroidAmazonForSoothsayers)
			{
				return user.IsSoothSayer();
			}
			return false;
		}
		return true;
	}

	public static bool IsPushNotificationsEnabledOnIOS(this IUser user)
	{
		if (user == null)
		{
			return false;
		}
		if (user.AgeBracket == AgeBracket.AgeUnder13)
		{
			return false;
		}
		if (!Settings.Default.IsPushNotificationsEnabledOnIOSForRegularUsers)
		{
			if (Settings.Default.IsPushNotificationsEnabledOnIOSForSoothsayers)
			{
				return user.IsSoothSayer();
			}
			return false;
		}
		return true;
	}

	public static bool IsMobilePushNotificationsBlacklisted(this IUser user, string notificationType, MobilePlatforms platform)
	{
		if (user.IsSoothSayer())
		{
			return false;
		}
		bool isBlacklisted = false;
		if (platform == MobilePlatforms.Android)
		{
			isBlacklisted = user.GetBlacklistedNotificationSourceTypesForAndroid().Contains(notificationType);
		}
		if (platform == MobilePlatforms.IOS)
		{
			isBlacklisted = user.GetBlacklistedNotificationSourceTypesForIOS().Contains(notificationType);
		}
		return isBlacklisted;
	}

	public static bool IsDesktopPlatform(this PushPlatformType platformType)
	{
		string name = Enum.GetName(typeof(PushPlatformType), platformType);
		return typeof(PushPlatformType).GetField(name).GetCustomAttributes(inherit: false).OfType<IsDesktopPlatformAttribute>()
			.SingleOrDefault()?.IsDestkop ?? false;
	}

	internal static IReceiver ToReceiver(this IUser user, ReceiverTypeLookup receiverTypeLookup)
	{
		return new Receiver(receiverTypeLookup.User.Id, user.Id);
	}

	internal static IReceiver GetReceiver(this IReceiverDestinationEntity receiverDestination)
	{
		return new Receiver(receiverDestination.ReceiverTypeId, receiverDestination.ReceiverTargetId);
	}

	internal static long ToUserId(this IReceiver participant, ReceiverTypeLookup receiverTypeLookup)
	{
		if (!participant.IsUser(receiverTypeLookup))
		{
			throw new ReceiverConversionException("Attempting to extract a User ID from a non-user participant");
		}
		return participant.TargetId;
	}

	internal static bool IsUser(this IReceiver participant, ReceiverTypeLookup receiverTypeLookup)
	{
		return participant.TypeId == receiverTypeLookup.User.Id;
	}

	internal static bool IsOfApplicationType(this IReceiverDestinationEntity receiverDestination, IApplicationTypeEntity applicationType, PushDomainFactory pushDomainFactory)
	{
		IDestinationEntity destination = pushDomainFactory.DestinationEntityFactory.Get(receiverDestination.DestinationId);
		return pushDomainFactory.DestinationTypeEntityFactory.Get(destination.DestinationTypeId).ApplicationTypeId == applicationType.Id;
	}

	internal static PushPlatformType ToPlatformType(this IReceiverDestinationEntity receiverDestination, PushDomainFactory pushDomainFactory, TypeLookup<IPlatformTypeEntity, PushPlatformType> platformTypeLookup)
	{
		IDestinationEntity destination = pushDomainFactory.DestinationEntityFactory.Get(receiverDestination.DestinationId);
		IDestinationTypeEntity destinationType = pushDomainFactory.DestinationTypeEntityFactory.Get(destination.DestinationTypeId);
		return platformTypeLookup.LookupEnum(destinationType.PlatformTypeId);
	}
}
