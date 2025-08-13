using Roblox.Platform.Localization.Audit;

namespace Roblox.Platform.Localization.Accounts;

internal interface IAccountLocalesAuditCompositeEntryFactory
{
	IAccountLocalesAuditCompositeEntry Create(IAccountLocalesAuditMetadataEntity metadata, IAccountLocalesAuditEntryEntity auditEntry);
}
