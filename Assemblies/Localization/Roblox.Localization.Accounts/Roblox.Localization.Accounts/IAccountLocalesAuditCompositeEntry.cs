using System;

namespace Roblox.Platform.Localization.Accounts;

/// <summary>
/// Audit information on the AccountLocales data entry, comprising of the raw data (prefixed with "Audit") and additional metadata.
/// </summary>
public interface IAccountLocalesAuditCompositeEntry
{
	/// <summary>
	/// The primary identifier for the entry. The metadata Id.
	/// </summary>
	long Id { get; }

	/// <summary>
	/// [Metadata] The AccountLocale Id associated with this record.
	/// </summary>
	long AccountLocaleId { get; }

	/// <summary>
	/// [Metadata] The cause triggering the audit event, such as a change in supported locale.
	/// </summary>
	AccountLocalesAuditEntryMetadataType MetadataType { get; }

	/// <summary>
	/// [Metadata] The person/machine making changes, such as a user or migrator.
	/// </summary>
	AccountLocalesChangeAgentType ChangeAgentType { get; }

	/// <summary>
	/// [Metadata] The target Id with respect to the <see cref="T:Roblox.Platform.Localization.Accounts.AccountLocalesChangeAgentType" />.
	/// </summary>
	long? ChangeAgentTargetId { get; }

	/// <summary>
	/// The value of "AccountId" from the AccountLocale record at the time of the audit event.
	/// </summary>
	long? AuditAccountId { get; }

	/// <summary>
	/// The value of "ObservedLocaleId" from the AccountLocale record at the time of the audit event.
	/// </summary>
	int? AuditObservedLocaleId { get; }

	/// <summary>
	/// The value of "SupportedLocaleId" from the AccountLocale record at the time of the audit event.
	/// </summary>
	int? AuditSupportedLocaleId { get; }

	/// <summary>
	/// The value of "Created" from the AccountLocale record at the time of the audit event.
	/// </summary>
	DateTime? AuditCreated { get; }

	/// <summary>
	/// The value of "Updated" from the AccountLocale record at the time of the audit event.
	/// </summary>
	DateTime? AuditUpdated { get; }

	/// <summary>
	/// Get the name of our change agent.
	/// </summary>
	/// <returns>The name of our change agent, null if it can't be found.</returns>
	string GetChangeAgentName();
}
