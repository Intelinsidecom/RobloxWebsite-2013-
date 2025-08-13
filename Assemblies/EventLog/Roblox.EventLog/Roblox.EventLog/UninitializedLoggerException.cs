using System;

namespace Roblox.EventLog;

public class UninitializedLoggerException : Exception
{
	public UninitializedLoggerException()
		: base(string.Format("{0} does not have a logger registered. Please instantiate an ILogger in your component's startup code with IsDefaultLog set to true.", "StaticLoggerRegistry"))
	{
	}
}
