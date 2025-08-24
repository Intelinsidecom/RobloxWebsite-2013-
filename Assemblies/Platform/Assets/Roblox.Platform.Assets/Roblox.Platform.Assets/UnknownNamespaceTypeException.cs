using Roblox.Platform.Core;

namespace Roblox.Platform.Assets;

public class UnknownNamespaceTypeException : PlatformException
{
	public UnknownNamespaceTypeException()
		: base("Unknown NamespaceType")
	{
	}

	public UnknownNamespaceTypeException(string namespaceType)
		: base("Unknown NamespaceType: " + namespaceType)
	{
	}
}
