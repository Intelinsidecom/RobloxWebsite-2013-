using System;
using Roblox.Platform.Core;

namespace Roblox.Platform.VirtualCurrency;

/// <summary>
/// The exception thrown when an operation failed because the actor had insufficient funds.
/// </summary>
public class InsufficientFundsException : PlatformException
{
	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.VirtualCurrency.InsufficientFundsException" /> class.
	/// </summary>
	public InsufficientFundsException()
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.VirtualCurrency.InsufficientFundsException" /> class.
	/// </summary>
	/// <param name="message">The message.</param>
	public InsufficientFundsException(string message)
		: base(message)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.VirtualCurrency.InsufficientFundsException" /> class.
	/// </summary>
	/// <param name="message">The message.</param>
	/// <param name="innerException">The inner exception.</param>
	public InsufficientFundsException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
