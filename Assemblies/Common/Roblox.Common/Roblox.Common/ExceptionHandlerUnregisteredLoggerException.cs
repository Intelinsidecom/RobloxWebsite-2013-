using System;

namespace Roblox.Common;

/// <summary>
/// Thrown when ExceptionHandler tries to use StaticLoggerRegistry but the logger is not registered.
/// Contains the inner exception so we don't lose that information.
/// </summary>
public class ExceptionHandlerUnregisteredLoggerException : Exception
{
	/// <summary>
	/// Instantiates a <see cref="T:Roblox.Common.ExceptionHandlerUnregisteredLoggerException" />
	/// </summary>
	public ExceptionHandlerUnregisteredLoggerException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
