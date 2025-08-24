using Roblox.Platform.Core;

namespace Roblox.Platform.Assets;

public class UnknownRawContentException : PlatformException
{
	public UnknownRawContentException()
		: base("Unknown RawContent")
	{
	}

	public UnknownRawContentException(long rawContentId)
		: base("Unknown RawContent " + rawContentId)
	{
	}
}
