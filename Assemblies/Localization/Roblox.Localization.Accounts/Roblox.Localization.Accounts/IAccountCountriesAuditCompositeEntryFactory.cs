using Roblox.Localization.Audit;
namespace Roblox.Localization.Accounts {
    interface IAccountCountriesAuditCompositeEntryFactory

{
	IAccountCountriesAuditCompositeEntry Create(IAccountCountriesAuditMetadataEntity metadata, IAccountCountriesAuditEntryEntity auditEntry);
}


}
