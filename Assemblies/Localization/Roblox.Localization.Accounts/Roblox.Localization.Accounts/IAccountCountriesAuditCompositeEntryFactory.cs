using Roblox.Platform.Localization.Audit;

namespace Roblox.Platform.Localization.Accounts;

internal interface IAccountCountriesAuditCompositeEntryFactory
{
	IAccountCountriesAuditCompositeEntry Create(IAccountCountriesAuditMetadataEntity metadata, IAccountCountriesAuditEntryEntity auditEntry);
}
