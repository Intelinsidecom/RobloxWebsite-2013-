using Roblox.Platform.Localization.Audit;
namespace Roblox.Localization.Accountsinternal {
    interface IAccountLocalesAuditCompositeEntryFactory

{
	IAccountLocalesAuditCompositeEntry Create(IAccountLocalesAuditMetadataEntity metadata, IAccountLocalesAuditEntryEntity auditEntry);
}


}
