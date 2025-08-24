using System;

namespace Roblox.Platform.AccountPins;

/// <summary>
/// Wrapper for the user of a PIN.
/// Effectively an unlock for the given AccountId.
/// </summary>
public interface IPinEntry
{
	/// <summary>
	/// Gets the pin hash identifier.
	/// </summary>
	/// <value>The pin hash identifier.</value>
	long PinHashId { get; }

	/// <summary>
	/// Gets the account identifier.
	/// </summary>
	/// <value>
	/// The account identifier.
	/// </value>
	long AccountId { get; }

	/// <summary>
	/// Gets the created.
	/// </summary>
	/// <value>
	/// The created.
	/// </value>
	DateTime Created { get; }

	/// <summary>
	/// Gets the unlocked until.
	/// </summary>
	/// <value>
	/// The unlocked until.
	/// </value>
	DateTime UnlockedUntil { get; }

	/// <summary>
	/// Gets the number of seconds unlocked until.
	/// Based on <see cref="P:Roblox.Platform.AccountPins.IPinEntry.UnlockedUntil" /> value.
	/// </summary>
	double SecondsUnlockedUntil { get; }

	/// <summary>
	/// Deletes this instance.
	/// </summary>
	/// <exception cref="T:Roblox.Platform.Core.PlatformDataIntegrityException"></exception>
	void Delete();
}
