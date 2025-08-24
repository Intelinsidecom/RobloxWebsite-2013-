using Roblox.Platform.Core;

namespace Roblox.Platform.Party;

public class PartyFullException : PlatformException
{
	public PartyFullException(string message)
		: base(message)
	{
	}
}
