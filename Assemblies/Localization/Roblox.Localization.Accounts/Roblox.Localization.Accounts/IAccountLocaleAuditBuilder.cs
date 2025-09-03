namespace Roblox.Localization.Accounts {
    interface IAccountLocaleAuditBuilder

{
	void CreateAuditRecords(IAccountLocaleEntity accountLocaleEntity, IAccountLocalesChangeAgent changeAgent, AccountLocalesAuditEntryMetadataType metadataType);
}


}
