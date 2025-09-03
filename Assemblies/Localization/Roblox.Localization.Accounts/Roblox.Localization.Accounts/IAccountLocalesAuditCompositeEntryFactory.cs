using Roblox.Localization.Audit;
namespace Roblox.Localization.Accounts {
    interface IAccountLocalesAuditCompositeEntryFactory

{
	IAccountLocalesAuditCompositeEntry Create(IAccountLocalesAuditMetadataEntity metadata, IAccountLocalesAuditEntryEntity auditEntry);
}


}
