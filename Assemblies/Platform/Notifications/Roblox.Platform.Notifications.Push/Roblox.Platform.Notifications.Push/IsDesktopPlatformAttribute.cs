using System;

namespace Roblox.Platform.Notifications.Push;

internal class IsDesktopPlatformAttribute : Attribute
{
	public bool IsDestkop { get; }

	internal IsDesktopPlatformAttribute(bool isDestkop)
	{
		IsDestkop = isDestkop;
	}
}
