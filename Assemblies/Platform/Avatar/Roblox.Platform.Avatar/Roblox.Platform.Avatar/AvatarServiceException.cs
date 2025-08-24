using System;
using Roblox.Platform.Core;

namespace Roblox.Platform.Avatar;

public class AvatarServiceException : PlatformException
{
	internal AvatarServiceException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
