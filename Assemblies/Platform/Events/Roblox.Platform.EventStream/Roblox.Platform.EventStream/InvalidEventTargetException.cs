using System;

namespace Roblox.Platform.EventStream;

public class InvalidEventTargetException : Exception
{
	private string _Message;

	public InvalidEventTargetException(string message)
	{
		_Message = message;
	}
}
