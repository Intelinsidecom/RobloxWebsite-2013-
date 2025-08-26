namespace Roblox.Localization.Accountsinternal {
    interface IAccountLocaleAuditBuilder

{
	void CreateAuditRecords(IAccountLocaleEntity accountLocaleEntity, IAccountLocalesChangeAgent changeAgent, AccountLocalesAuditEntryMetadataType metadataType);
}


}
