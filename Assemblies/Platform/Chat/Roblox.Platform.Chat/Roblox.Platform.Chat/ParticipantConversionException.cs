using Roblox.Platform.Core;

namespace Roblox.Platform.Chat;

internal class ParticipantConversionException : PlatformException
{
	public ParticipantConversionException(string message)
		: base(message)
	{
	}
}
