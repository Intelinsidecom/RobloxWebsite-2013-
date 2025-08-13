using Roblox.Platform.Membership;

namespace Roblox.Platform.Billing;

internal class LiveGamerProviderFactory
{
	internal static ILiveGamerPaymentProvider GetLiveGamerProvider(IUser user)
	{
		return new LiveGamerPaymentProvider(user);
	}
}
