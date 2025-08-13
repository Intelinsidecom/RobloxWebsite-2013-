using System;

namespace Roblox.Common;

/// <summary>
/// The exception that is thrown when an operation is currently unavailable, but may be available at another time.
/// </summary>
public class OperationUnavailableException : Exception
{
	public OperationUnavailableException()
	{
	}

	public OperationUnavailableException(string message)
		: base(message)
	{
	}

	public OperationUnavailableException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
