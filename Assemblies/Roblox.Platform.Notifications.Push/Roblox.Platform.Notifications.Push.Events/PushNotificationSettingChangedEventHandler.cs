using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Notifications.Push.Events;

public delegate void PushNotificationSettingChangedEventHandler(IUserIdentifier userId, bool isEnabled, string receiverDestinationType, string receiverDestinationId);
