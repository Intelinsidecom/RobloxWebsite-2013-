using Roblox.Platform.Core;

namespace Roblox.Platform.Groups;

public class ClanIsFullException : PlatformException
{
	public ClanIsFullException()
		: base("The Clan is full! Kick a Clan member or cancel a pending invitation.")
	{
	}
}
