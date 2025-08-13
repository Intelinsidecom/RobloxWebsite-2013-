using Roblox.LiveGamer;

namespace Roblox.Platform.Billing;

public class LiveGamerCommunicatorFactory
{
	public static ILiveGamerCommunicator GetCommunicator()
	{
		return new LiveGamerCommunicator();
	}
}
