using Roblox.Localization.Audit;
namespace Roblox.Localization.Accounts {
    interface IAccountLocalesAuditMetadataTypeConverter

{
	byte GetEntityIdFromEnum(AccountLocalesAuditEntryMetadataType metadataType);

	AccountLocalesAuditEntryMetadataType GetEnumFromEntity(IAccountLocalesAuditMetadataTypeEntity metadataTypeEntity);
}


}
