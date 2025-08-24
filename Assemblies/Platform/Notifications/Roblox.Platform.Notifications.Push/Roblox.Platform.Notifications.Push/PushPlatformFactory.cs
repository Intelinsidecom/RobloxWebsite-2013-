using System;
using Roblox.EventLog;
using Roblox.Platform.Membership;
using Roblox.Platform.Notifications.Push.Entities;
using Roblox.Platform.Notifications.Push.PushPlatforms;

namespace Roblox.Platform.Notifications.Push;

internal static class PushPlatformFactory
{
	public static IPushPlatform GetPushPlatform(PushServiceClientFactory pushServiceClientFactory, PushPlatformType platform, IDestinationTypeEntity destinationType, IUserFactory userFactory, ReceiverTypeLookup receiverTypeLookup, ILogger logger)
	{
		return platform switch
		{
			PushPlatformType.ChromeOnDesktop => new ChromeOnDesktop(pushServiceClientFactory, destinationType, userFactory, receiverTypeLookup), 
			PushPlatformType.AndroidNative => new AndroidNative(pushServiceClientFactory, destinationType, userFactory, receiverTypeLookup), 
			PushPlatformType.FirefoxOnDesktop => new FirefoxOnDesktop(pushServiceClientFactory, destinationType, userFactory, receiverTypeLookup), 
			PushPlatformType.IOSNative => new IOSNative(pushServiceClientFactory, destinationType, userFactory, receiverTypeLookup, logger), 
			PushPlatformType.AndroidAmazon => new AndroidAmazon(pushServiceClientFactory, destinationType, userFactory, receiverTypeLookup), 
			_ => throw new NotImplementedException(), 
		};
	}
}
