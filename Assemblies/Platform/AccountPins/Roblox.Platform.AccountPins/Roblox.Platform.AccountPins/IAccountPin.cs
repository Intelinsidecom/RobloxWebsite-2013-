using System;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.AccountPins;

/// <summary>
/// The PIN for the given account.
/// Note that we only acknowledge the validity of the PIN, not its actual value.
/// </summary>
public interface IAccountPin
{
	/// <summary>
	/// Gets the identifier.
	/// </summary>
	/// <value>
	/// The identifier.
	/// </value>
	long Id { get; }

	/// <summary>
	/// Returns true if Account pin is valid.
	/// </summary>
	/// <value>
	///   <c>true</c> if this instance is valid; otherwise, <c>false</c>.
	/// </value>
	bool IsValid { get; }

	/// <summary>
	/// Gets the created.
	/// </summary>
	/// <value>
	/// The created.
	/// </value>
	DateTime Created { get; }

	/// <summary>
	/// Deletes this instance.
	/// <exception cref="T:Roblox.Platform.Core.PlatformDataIntegrityException">Thrown if the entity was not found while deleting.</exception>
	/// </summary>
	/// <param name="actorUserIdentity">The identifier of the user performing the action.</param>
	void Delete(IUserIdentifier actorUserIdentity);
}
