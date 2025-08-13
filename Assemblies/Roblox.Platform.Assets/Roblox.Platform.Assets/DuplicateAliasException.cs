using Roblox.Platform.Core;

namespace Roblox.Platform.Assets;

public class DuplicateAliasException : PlatformException
{
	public DuplicateAliasException()
		: base("Alias already exists")
	{
	}

	public DuplicateAliasException(long namespaceId, string name)
		: base("Alias " + name + " in namespace " + namespaceId + " already exists")
	{
	}
}
