using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class SendMessageFloodCheckerByUser : FloodChecker
{
	public SendMessageFloodCheckerByUser(long userId)
		: base($"SendMessageFloodCheckerByUser_UserId:{userId}", Settings.Default.SendMessageFloodCheckerLimit, Settings.Default.SendMessageFloodCheckerExpiry)
	{
	}
}
