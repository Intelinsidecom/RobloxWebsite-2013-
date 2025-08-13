using System;

namespace Roblox.Platform.Core;

/// <summary>
/// An exception thrown if the Description has too many characters and will be cropped by caching. It is intended to be thrown to stop asset creation.
/// </summary>
public class LongDescriptionException : Exception
{
	/// <summary>
	/// A long desription exception without a comment
	/// </summary>
	public LongDescriptionException()
	{
	}

	/// <summary>
	/// A long description exception with a comment
	/// </summary>
	/// <param name="message">The comment for the circumstances of the throw</param>
	public LongDescriptionException(string message)
		: base(message)
	{
	}

	/// <summary>
	/// A long description exception with a comment and inner exception
	/// </summary>
	/// <param name="message">The comment for the circumstances of the throw</param>
	/// <param name="innerException">The associated exception</param>
	public LongDescriptionException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
