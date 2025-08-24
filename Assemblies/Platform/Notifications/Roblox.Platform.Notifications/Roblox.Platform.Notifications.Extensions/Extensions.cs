using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Common;
using Roblox.EventLog;
using Roblox.Platform.Core;
using Roblox.Platform.Membership;
using Roblox.Platform.Notifications.Core;
using Roblox.Platform.Notifications.Properties;
using Roblox.Platform.Notifications.Push;
using Roblox.Platform.Notifications.Stream;

namespace Roblox.Platform.Notifications.Extensions;

public static class Extensions
{
	private static IReadOnlyList<NotificationSourceType> _AllNotificationSourceTypes;

	private static IReadOnlyList<ReceiverDestinationType> _AllReceiverDestinationTypes;

	private static List<PushPlatformType> _DesktopPushPlatforms;

	private static List<PushPlatformType> _MobilePushPlatforms;

	private static Dictionary<PushPlatformType, ReceiverDestinationType> _PushPlatformReceiverDestinationMap;

	public static NotificationGenerator ToNotificationGenerator(this IUser user)
	{
		return new NotificationGenerator
		{
			GeneratorType = NotificationGeneratorType.User,
			GeneratorId = user.Id
		};
	}

	public static bool IsNotificationSettingsEnabled(this IUser user)
	{
		if (user == null)
		{
			return false;
		}
		if (Settings.Default.NotificationSettingsEnabledForAll)
		{
			return true;
		}
		if (Settings.Default.NotificationSettingsEnabledForBetaTesters && user.IsBetaTester())
		{
			return true;
		}
		if (Settings.Default.NotificationSettingsEnabledForSoothSayers && user.IsSoothSayer())
		{
			return true;
		}
		return false;
	}

	public static bool IsNotificationSourceTypeBlacklisted(this IUser user, NotificationSourceType notificationSourceType, ILogger logger)
	{
		if (user == null)
		{
			return true;
		}
		if (user.IsSoothSayer())
		{
			return false;
		}
		try
		{
			string blacklistString = ((!user.IsBetaTester()) ? Settings.Default.NotificationSettingsSourceTypeBlacklistForRegularUsers : Settings.Default.NotificationSettingsSourceTypeBlacklistForBetaTesters);
			return new HashSet<NotificationSourceType>(new SeparatedString<NotificationSourceType>(blacklistString).SafeParseToEnumerable()).Contains(notificationSourceType);
		}
		catch (Exception exception)
		{
			logger.Error(exception);
			return false;
		}
	}

	public static IEnumerable<NotificationSourceType> GetAllowedNotificationSourceTypes(this IUser user, ILogger logger)
	{
		if (_AllNotificationSourceTypes == null)
		{
			_AllNotificationSourceTypes = (NotificationSourceType[])Enum.GetValues(typeof(NotificationSourceType));
		}
		if (user == null)
		{
			return new List<NotificationSourceType>();
		}
		try
		{
			string blacklistString = (user.IsSoothSayer() ? Settings.Default.NotificationSettingsSourceTypeBlacklistForSoothsayers : ((!user.IsBetaTester()) ? Settings.Default.NotificationSettingsSourceTypeBlacklistForRegularUsers : Settings.Default.NotificationSettingsSourceTypeBlacklistForBetaTesters));
			HashSet<NotificationSourceType> blacklist = new HashSet<NotificationSourceType>(new SeparatedString<NotificationSourceType>(blacklistString).SafeParseToEnumerable());
			return _AllNotificationSourceTypes.Where((NotificationSourceType type) => !blacklist.Contains(type));
		}
		catch (Exception exception)
		{
			logger.Error(exception);
			return _AllNotificationSourceTypes;
		}
	}

	public static IEnumerable<ReceiverDestinationType> GetAllowedReceiverDestinationTypes(this IUser user, ILogger logger)
	{
		if (_AllReceiverDestinationTypes == null)
		{
			_AllReceiverDestinationTypes = (ReceiverDestinationType[])Enum.GetValues(typeof(ReceiverDestinationType));
		}
		if (user == null || !user.IsNotificationSettingsEnabled())
		{
			return new List<ReceiverDestinationType>();
		}
		if (user.IsSoothSayer())
		{
			return _AllReceiverDestinationTypes;
		}
		try
		{
			string blacklistString = ((!user.IsBetaTester()) ? Settings.Default.NotificationSettingsReceiverDestinationTypeBlacklistForRegularUsers : Settings.Default.NotificationSettingsReceiverDestinationTypeBlacklistForBetaTesters);
			HashSet<ReceiverDestinationType> blacklist = new HashSet<ReceiverDestinationType>(new SeparatedString<ReceiverDestinationType>(blacklistString).SafeParseToEnumerable());
			return from type in _AllReceiverDestinationTypes
				where !blacklist.Contains(type)
				where IsFeatureEnabledForUser(user, type)
				select type;
		}
		catch (Exception exception)
		{
			logger.Error(exception);
			return _AllReceiverDestinationTypes;
		}
	}

	private static bool IsFeatureEnabledForUser(IUser user, ReceiverDestinationType type)
	{
		switch (type)
		{
		case ReceiverDestinationType.DesktopPush:
		case ReceiverDestinationType.MobilePush:
			return user.IsPushNotificationsEnabled();
		case ReceiverDestinationType.NotificationStream:
			return user.IsNotificationStreamEnabled();
		default:
			return true;
		}
	}

	public static void RegisterReceiverResolverForType(this INotificationReceiverResolver receiverResolverGetter)
	{
		if (receiverResolverGetter == null)
		{
			throw new PlatformArgumentNullException("Cannot register a null getter");
		}
		Accessors.NotificationReceiverResolverRegistry.RegisterReceiverResolverForType(receiverResolverGetter);
	}

	public static ICollection<PushPlatformType> GetCorrespondingPushPlatformTypes(this ReceiverDestinationType destinationType)
	{
		if (_DesktopPushPlatforms == null || _MobilePushPlatforms == null)
		{
			PopulatePushToReceiverDestinationMappings();
		}
		return destinationType switch
		{
			ReceiverDestinationType.DesktopPush => _DesktopPushPlatforms, 
			ReceiverDestinationType.MobilePush => _MobilePushPlatforms, 
			_ => new List<PushPlatformType>(), 
		};
	}

	public static ReceiverDestinationType GetCorrespondingReceiverDestinationType(this PushPlatformType pushPlatformType)
	{
		if (_PushPlatformReceiverDestinationMap == null)
		{
			PopulatePushToReceiverDestinationMappings();
		}
		return _PushPlatformReceiverDestinationMap[pushPlatformType];
	}

	private static void PopulatePushToReceiverDestinationMappings()
	{
		Dictionary<PushPlatformType, ReceiverDestinationType> pushPlatformReceiverDestinationMap = new Dictionary<PushPlatformType, ReceiverDestinationType>();
		foreach (PushPlatformType platformType in Enum.GetValues(typeof(PushPlatformType)))
		{
			pushPlatformReceiverDestinationMap[platformType] = ((!platformType.IsDesktopPlatform()) ? ReceiverDestinationType.MobilePush : ReceiverDestinationType.DesktopPush);
		}
		_DesktopPushPlatforms = (from entry in pushPlatformReceiverDestinationMap
			where entry.Value == ReceiverDestinationType.DesktopPush
			select entry.Key).ToList();
		_MobilePushPlatforms = (from entry in pushPlatformReceiverDestinationMap
			where entry.Value == ReceiverDestinationType.MobilePush
			select entry.Key).ToList();
		_PushPlatformReceiverDestinationMap = pushPlatformReceiverDestinationMap;
	}
}
