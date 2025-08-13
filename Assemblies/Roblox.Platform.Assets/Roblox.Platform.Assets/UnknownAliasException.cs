using Roblox.Platform.Core;

namespace Roblox.Platform.Assets;

public class UnknownAliasException : PlatformException
{
	public UnknownAliasException()
		: base("Unknown Alias")
	{
	}

	public UnknownAliasException(long namespaceId, string name)
		: base("Unknown Alias " + name + " in namespace " + namespaceId)
	{
	}

	public UnknownAliasException(string namespaceType, long? namespaceTargetId, string name)
		: base("Unknown Alias " + name + " in namespace of type " + namespaceType + " and id " + namespaceTargetId)
	{
	}
}
