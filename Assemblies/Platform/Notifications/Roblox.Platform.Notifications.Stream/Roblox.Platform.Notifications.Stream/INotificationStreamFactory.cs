using System.Collections.Generic;
using Roblox.Platform.Membership;
using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications.Stream;

public interface INotificationStreamFactory
{
	ICollection<INotificationStreamEventGroupWithMetadata> GetRecentNotifications(IReceiver receiver, int startIndex, int maxRows);

	long GetUnreadNotificationCount(IReceiver receiver);

	void MarkUserInteractedWithNotificationStream(IUser user);

	bool HasUserInteractedWithNotificationStream(IUser user);

	bool IsUserAccountOldEnoughForNotificationStreamPrompt(IUser user);

	bool ShouldShowNotificationStreamPromptToUser(IUser user);
}
