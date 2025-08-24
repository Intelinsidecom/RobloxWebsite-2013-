using System;

namespace Roblox.Platform.Localization.Accounts;

/// <summary>
/// Audit information on the AccountCountries data entry, comprising of the raw data (prefixed with "Audit_") and additional meta data.
/// </summary>
public interface IAccountCountriesAuditCompositeEntry
{
	/// <summary>
	/// The primary identifier of the entry.
	/// </summary>
	long Id { get; }

	/// <summary>
	/// [Metadata] The AccountCountry ID associated with this record.
	/// </summary>
	long AccountCountriesId { get; }

	/// <summary>
	/// [Metadata] The cause triggering the audit event, such as a change in country.
	/// </summary>
	AccountCountriesAuditEntryMetadataType MetadataType { get; }

	/// <summary>
	/// [Metadata] The person/machine making changes, such as a user or migrator.
	/// </summary>
	AccountCountriesChangeAgentType ChangeAgentType { get; }

	/// <summary>
	/// [Metadata] The target Id with respect to the <see cref="P:Roblox.Platform.Localization.Accounts.IAccountCountriesAuditCompositeEntry.ChangeAgentType" />.
	/// </summary>
	long? ChangeAgentTargetId { get; }

	/// <summary>
	/// Value of "CountryId" field of the AccountCountries record at the audit event. <seealso cref="T:Roblox.Platform.Localization.Accounts.IAccountCountry" />
	/// </summary>
	int? AuditCountryId { get; }

	/// <summary>
	/// Value of "Updated" field of the AccountCountries record at the audit event. <seealso cref="T:Roblox.Platform.Localization.Accounts.IAccountCountry" />
	/// </summary>
	DateTime? AuditUpdated { get; }

	/// <summary>
	/// Value of "Created" field of the AccountCountries record at the audit event. <seealso cref="T:Roblox.Platform.Localization.Accounts.IAccountCountry" />
	/// </summary>
	DateTime? AuditCreated { get; }

	/// <summary>
	/// Value of "AccountID" field of the AccountCountries record at the audit event. <seealso cref="T:Roblox.Platform.Localization.Accounts.IAccountCountry" />
	/// </summary>
	long? AuditAccountID { get; }

	/// <summary>
	/// Get the name of our change agent.
	/// </summary>
	/// <returns>The name of the change agent, null if it can't be found.</returns>
	string GetChangeAgentName();
}
