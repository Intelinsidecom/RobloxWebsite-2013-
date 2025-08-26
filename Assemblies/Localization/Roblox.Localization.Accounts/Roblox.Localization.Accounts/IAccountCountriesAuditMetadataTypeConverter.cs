using Roblox.Platform.Localization.Audit;
namespace Roblox.Localization.Accountsinternal {
    interface IAccountCountriesAuditMetadataTypeConverter

{
	byte GetEntityIdFromEnum(AccountCountriesAuditEntryMetadataType metadataType);

	AccountCountriesAuditEntryMetadataType GetEnumFromEntity(IAccountCountriesAuditMetadataTypeEntity metadataTypeEntity);
}


}
