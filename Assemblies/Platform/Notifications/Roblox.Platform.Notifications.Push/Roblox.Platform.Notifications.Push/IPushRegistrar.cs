using System.Collections.Generic;
using Roblox.Platform.Authentication;
using Roblox.Platform.Membership;
using Roblox.Platform.Notifications.Push.Events;

namespace Roblox.Platform.Notifications.Push;

public interface IPushRegistrar
{
	event PushNotificationSettingChangedEventHandler PushNotificationSettingChanged;

	IUserPushDestination Register(PushApplicationType applicationType, PushPlatformType platformType, IUser user, ISessionToken sessionToken, string notificationToken, string notificationEndpoint, bool authorizationRequested, bool authorizeByDefault, string deviceName);

	bool DeauthorizeSessionDestinations(PushApplicationType application, IUser user, ISessionToken sessionToken);

	bool DeauthorizeAllDestinations(PushApplicationType application, IUser user);

	IUserPushDestination GetUserPushDestinationByDestinationId(long destinationId);

	IEnumerable<IUserPushDestination> GetValidDestinations(PushApplicationType application, IUser user);

	IUserPushDestination GetSessionDestination(PushApplicationType application, IUser user, ISessionToken sessionToken);

	IUserPushDestination GetSessionDestination(PushApplicationType application, IUser user, ISessionToken sessionToken, string notificationToken);

	IPushDestinationType GetDestinationType(PushApplicationType application, PushPlatformType platform);

	IEnumerable<IPushDestinationType> GetDestinationTypes(PushApplicationType application);

	void CreateDestinationType(PushApplicationType application, PushPlatformType platform, string registrationEndpoint);

	void UpdateDestinationType(PushApplicationType application, PushPlatformType platform, string registrationEndpoint);
}
