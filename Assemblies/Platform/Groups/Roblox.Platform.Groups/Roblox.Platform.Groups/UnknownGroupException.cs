using Roblox.Platform.Core;

namespace Roblox.Platform.Groups;

public class UnknownGroupException : PlatformArgumentException
{
	public UnknownGroupException()
		: base("Unknown Group.")
	{
	}

	public UnknownGroupException(long id)
		: base("Unknown group: " + id)
	{
	}
}
