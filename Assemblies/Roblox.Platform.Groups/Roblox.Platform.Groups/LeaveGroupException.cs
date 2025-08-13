using System;

namespace Roblox.Platform.Groups;

public class LeaveGroupException : Exception
{
	internal LeaveGroupException(string message, Exception ex)
		: base(message, ex)
	{
	}

	internal LeaveGroupException(string message)
		: base(message)
	{
	}
}
