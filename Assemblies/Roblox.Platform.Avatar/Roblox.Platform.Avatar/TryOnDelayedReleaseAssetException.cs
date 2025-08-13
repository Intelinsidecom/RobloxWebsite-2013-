using System;
using Roblox.Platform.Core;

namespace Roblox.Platform.Avatar;

public class TryOnDelayedReleaseAssetException : PlatformException
{
	internal TryOnDelayedReleaseAssetException(string message, Exception innerException = null)
		: base(message, innerException)
	{
	}
}
