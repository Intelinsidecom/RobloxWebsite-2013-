using Roblox.Platform.Core;

namespace Roblox.Platform.Party;

public class PartyAuthorizationException : PlatformException
{
	public PartyAuthorizationException(string message)
		: base(message)
	{
	}
}
