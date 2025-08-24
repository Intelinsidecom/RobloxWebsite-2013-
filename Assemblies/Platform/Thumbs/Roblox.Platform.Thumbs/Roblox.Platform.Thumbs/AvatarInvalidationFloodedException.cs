using System;

namespace Roblox.Thumbs;

public class AvatarInvalidationFloodedException : Exception
{
	public AvatarInvalidationFloodedException(string exception)
		: base(exception)
	{
	}
}
