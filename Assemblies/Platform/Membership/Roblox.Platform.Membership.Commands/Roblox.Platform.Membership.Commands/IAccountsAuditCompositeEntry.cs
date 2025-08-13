using System;

namespace Roblox.Platform.Membership.Commands;

/// <summary>
/// Audit information on the change of Account data entity, comprising of the raw data (prefixed with "Audit_") and additional meta data.
/// </summary>
public interface IAccountsAuditCompositeEntry
{
	/// <summary>
	/// The Id of the meta data.
	/// </summary>
	long Id { get; }

	/// <summary>
	/// [Metadata] User who made the change - may be null
	/// </summary>
	IUser ActorUser { get; }

	/// <summary>
	/// [Metadata] What kind of change was made to the account
	/// </summary>
	AccountsAuditChangeType ChangeType { get; }

	/// <summary>
	/// [Metadata] User whose account was changed
	/// </summary>
	IUser TargetUser { get; }

	/// <summary>
	/// [Metadata] When this metadata record was created
	/// </summary>
	DateTime Created { get; }

	/// <summary>
	/// Value of "AccountStatus" of the Account record at the audit event.
	/// </summary>
	AccountStatus Audit_AccountStatus { get; }
}
