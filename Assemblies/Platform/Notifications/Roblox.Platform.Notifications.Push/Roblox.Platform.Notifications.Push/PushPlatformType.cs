namespace Roblox.Platform.Notifications.Push;

public enum PushPlatformType
{
	[IsDesktopPlatform(true)]
	ChromeOnDesktop,
	[IsDesktopPlatform(false)]
	AndroidNative,
	[IsDesktopPlatform(true)]
	FirefoxOnDesktop,
	[IsDesktopPlatform(false)]
	IOSNative,
	[IsDesktopPlatform(false)]
	AndroidAmazon
}
