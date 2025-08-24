using System;
using Roblox.Platform.Membership;

namespace Roblox.Platform.AccountPins;

/// <summary>
/// Metadata surrounding a change to an account pin
/// </summary>
public interface IAccountPinHashesAuditMetadata
{
	long Id { get; }

	/// <summary>
	/// User whose account pin was changed
	/// </summary>
	IUser Owner { get; }

	/// <summary>
	/// User who made the change - may be null
	/// </summary>
	IUser Actor { get; }

	/// <summary>
	/// What kind of change was made to the account pin
	/// </summary>
	AccountPinChangeType ChangeType { get; }

	/// <summary>
	/// When this metadata record was created
	/// </summary>
	DateTime Created { get; }
}
