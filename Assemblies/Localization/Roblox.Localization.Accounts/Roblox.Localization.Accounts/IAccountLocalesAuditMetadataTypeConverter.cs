using Roblox.Platform.Localization.Audit;
namespace Roblox.Localization.Accountsinternal {
    interface IAccountLocalesAuditMetadataTypeConverter

{
	byte GetEntityIdFromEnum(AccountLocalesAuditEntryMetadataType metadataType);

	AccountLocalesAuditEntryMetadataType GetEnumFromEntity(IAccountLocalesAuditMetadataTypeEntity metadataTypeEntity);
}


}
