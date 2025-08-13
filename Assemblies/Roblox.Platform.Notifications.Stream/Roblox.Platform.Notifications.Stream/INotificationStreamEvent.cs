using System;
using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications.Stream;

public interface INotificationStreamEvent
{
	Guid EventId { get; }

	EventTarget EventTargetId { get; }

	bool IsInteracted { get; }
}
