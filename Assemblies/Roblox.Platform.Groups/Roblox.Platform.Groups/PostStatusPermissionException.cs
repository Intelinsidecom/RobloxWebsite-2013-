using System;

namespace Roblox.Platform.Groups;

public class PostStatusPermissionException : Exception
{
	internal PostStatusPermissionException(string message)
		: base(message)
	{
	}
}
