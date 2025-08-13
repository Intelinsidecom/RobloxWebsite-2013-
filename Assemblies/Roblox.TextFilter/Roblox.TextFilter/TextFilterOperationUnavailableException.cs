using System;

namespace Roblox.TextFilter;

/// <summary>
/// This TextFilter operation was unavailable for some reason.
/// </summary>
public class TextFilterOperationUnavailableException : Exception
{
	/// <summary>
	/// Default constructor including inner exception.
	/// </summary>
	/// <param name="message"></param>
	/// <param name="innerException"></param>
	public TextFilterOperationUnavailableException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
