using Roblox.Platform.Core;

namespace Roblox.Platform.Games.Exceptions;

public class InvalidReservedServerAccessCodeException : PlatformException
{
	public InvalidReservedServerAccessCodeException(string reservedServerAccessCode)
		: base("Unable to parse access code " + reservedServerAccessCode)
	{
	}
}
