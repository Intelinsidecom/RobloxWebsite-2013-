using System;

namespace Roblox.Platform.Groups;

public class ClaimGroupException : Exception
{
	internal ClaimGroupException(string message, Exception ex)
		: base(message, ex)
	{
	}

	internal ClaimGroupException(string message)
		: base(message)
	{
	}
}
