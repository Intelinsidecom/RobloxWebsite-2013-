using Roblox.Platform.Core;

namespace Roblox.Platform.Assets;

public class UnknownAssetException : PlatformException
{
	public UnknownAssetException()
		: base("Unknown Asset")
	{
	}

	public UnknownAssetException(long id)
		: base("Unknown Asset " + id)
	{
	}
}
