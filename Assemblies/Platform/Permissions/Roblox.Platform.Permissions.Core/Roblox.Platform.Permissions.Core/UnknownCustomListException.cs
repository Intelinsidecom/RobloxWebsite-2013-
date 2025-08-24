using Roblox.Platform.Core;

namespace Roblox.Platform.Permissions.Core;

public class UnknownCustomListException : PlatformException
{
	public UnknownCustomListException()
		: base("Unknown CustomList")
	{
	}

	public UnknownCustomListException(long id)
		: base("Unknown CustomList " + id)
	{
	}
}
