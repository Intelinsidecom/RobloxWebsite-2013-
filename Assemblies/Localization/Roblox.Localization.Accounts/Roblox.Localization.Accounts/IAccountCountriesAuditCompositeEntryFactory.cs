using Roblox.Platform.Localization.Audit;
namespace Roblox.Localization.Accountsinternal {
    interface IAccountCountriesAuditCompositeEntryFactory

{
	IAccountCountriesAuditCompositeEntry Create(IAccountCountriesAuditMetadataEntity metadata, IAccountCountriesAuditEntryEntity auditEntry);
}


}
