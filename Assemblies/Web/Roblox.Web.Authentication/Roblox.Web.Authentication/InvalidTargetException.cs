using System;

namespace Roblox.Web.Authentication;

/// <summary>
/// Thrown when the target entered is invalid
/// </summary>
public class InvalidTargetException : Exception
{
	/// <summary>
	/// Initializes an <see cref="T:Roblox.Web.Authentication.InvalidTargetException" />
	/// </summary>
	public InvalidTargetException()
	{
	}

	/// <summary>
	/// /// <summary>
	/// Initializes an <see cref="T:Roblox.Web.Authentication.InvalidTargetException" />
	/// </summary>
	/// </summary>
	/// <param name="message"></param>
	public InvalidTargetException(string message)
		: base(message)
	{
	}

	/// <summary>
	/// Initializes an <see cref="T:Roblox.Web.Authentication.InvalidTargetException" />
	/// </summary>
	/// <param name="message"></param>
	/// <param name="innerException"></param>
	public InvalidTargetException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
