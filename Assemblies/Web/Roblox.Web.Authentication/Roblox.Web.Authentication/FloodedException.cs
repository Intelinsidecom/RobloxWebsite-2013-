using System;

namespace Roblox.Web.Authentication;

/// <summary>
/// Exception to be thrown if the request is flooded.
/// </summary>
/// <seealso cref="T:System.Exception" />
public class FloodedException : Exception
{
	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Web.Authentication.FloodedException" /> class.
	/// </summary>
	public FloodedException()
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Web.Authentication.FloodedException" /> class.
	/// </summary>
	/// <param name="message">The message.</param>
	public FloodedException(string message)
		: base(message)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Web.Authentication.FloodedException" /> class.
	/// </summary>
	/// <param name="message">The message.</param>
	/// <param name="innerException">The inner exception.</param>
	public FloodedException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
