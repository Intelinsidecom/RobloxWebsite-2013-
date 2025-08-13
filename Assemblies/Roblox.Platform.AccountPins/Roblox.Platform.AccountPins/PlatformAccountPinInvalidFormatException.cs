using System;
using Roblox.Platform.Core;

namespace Roblox.Platform.AccountPins;

/// <summary>
/// A platform exception to throw when entering an invalid pin.
/// </summary>
/// <seealso cref="T:Roblox.Platform.Core.PlatformException" />
public class PlatformAccountPinInvalidFormatException : PlatformException
{
	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.AccountPins.PlatformAccountPinInvalidFormatException" /> class.
	/// </summary>
	public PlatformAccountPinInvalidFormatException()
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.AccountPins.PlatformAccountPinInvalidFormatException" /> class.
	/// </summary>
	/// <param name="message">The message.</param>
	public PlatformAccountPinInvalidFormatException(string message)
		: base(message)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.AccountPins.PlatformAccountPinInvalidFormatException" /> class.
	/// </summary>
	/// <param name="message">The message.</param>
	/// <param name="innerException">The inner exception.</param>
	public PlatformAccountPinInvalidFormatException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
