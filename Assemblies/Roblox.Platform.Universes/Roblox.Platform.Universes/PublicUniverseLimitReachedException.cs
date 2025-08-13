using System;

namespace Roblox.Platform.Universes;

/// <summary>
/// An exception thrown if a you try to make a universe public when the public universe limit 
/// has been reached for the creator of the universe.
/// </summary>
/// <seealso cref="T:System.Exception" />
public class PublicUniverseLimitReachedException : Exception
{
	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Universes.PublicUniverseLimitReachedException" /> class.
	/// </summary>
	public PublicUniverseLimitReachedException()
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Universes.PublicUniverseLimitReachedException" /> class.
	/// </summary>
	/// <param name="message">The message.</param>
	public PublicUniverseLimitReachedException(string message)
		: base(message)
	{
	}
}
