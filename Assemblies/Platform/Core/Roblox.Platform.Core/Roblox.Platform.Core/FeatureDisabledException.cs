using System;

namespace Roblox.Platform.Core;

/// <summary>
/// The exception thrown when a disabled feature is used.
/// </summary>
public class FeatureDisabledException : PlatformException
{
	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Core.FeatureDisabledException" /> class.
	/// </summary>
	public FeatureDisabledException()
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Core.FeatureDisabledException" /> class with the given error message.
	/// </summary>
	/// <param name="message">The message that describes the error.</param>
	public FeatureDisabledException(string message)
		: base(message)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Core.FeatureDisabledException" /> class with
	/// the given error message and inner exception.
	/// </summary>
	/// <param name="message">The message that describes the error.</param>
	/// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
	public FeatureDisabledException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
