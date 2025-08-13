using Roblox.Platform.Core;

namespace Roblox.Platform.Assets;

public class UnknownNamespaceException : PlatformException
{
	public UnknownNamespaceException()
		: base("Unknown Namespace")
	{
	}

	public UnknownNamespaceException(string namespaceType, long? namespaceTargetId)
		: base("Unknown namespace of type " + namespaceType + " and id " + (namespaceTargetId.HasValue ? namespaceTargetId.Value.ToString() : string.Empty))
	{
	}
}
