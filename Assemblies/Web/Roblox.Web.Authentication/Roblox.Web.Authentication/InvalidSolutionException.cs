using System;

namespace Roblox.Web.Authentication;

/// <summary>
/// Thrown when the solution entered by the user is invalid
/// </summary>
public class InvalidSolutionException : Exception
{
	/// <summary>
	/// Initializes an <see cref="T:Roblox.Web.Authentication.InvalidSolutionException" />
	/// </summary>
	public InvalidSolutionException()
	{
	}

	/// <summary>
	/// Initializes an <see cref="T:Roblox.Web.Authentication.InvalidSolutionException" />
	/// </summary>
	/// <param name="message"></param>
	public InvalidSolutionException(string message)
		: base(message)
	{
	}

	/// <summary>
	/// Initializes an <see cref="T:Roblox.Web.Authentication.InvalidSolutionException" />
	/// </summary>
	/// <param name="message"></param>
	/// <param name="innerException"></param>
	public InvalidSolutionException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
