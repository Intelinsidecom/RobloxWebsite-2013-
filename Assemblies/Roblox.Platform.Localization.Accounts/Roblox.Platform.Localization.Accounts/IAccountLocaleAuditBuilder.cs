namespace Roblox.Platform.Localization.Accounts;

internal interface IAccountLocaleAuditBuilder
{
	void CreateAuditRecords(IAccountLocaleEntity accountLocaleEntity, IAccountLocalesChangeAgent changeAgent, AccountLocalesAuditEntryMetadataType metadataType);
}
