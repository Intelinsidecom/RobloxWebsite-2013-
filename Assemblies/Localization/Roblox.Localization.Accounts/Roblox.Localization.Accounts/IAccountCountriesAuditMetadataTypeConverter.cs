using Roblox.Localization.Audit;
namespace Roblox.Localization.Accounts {
    interface IAccountCountriesAuditMetadataTypeConverter

{
	byte GetEntityIdFromEnum(AccountCountriesAuditEntryMetadataType metadataType);

	AccountCountriesAuditEntryMetadataType GetEnumFromEntity(IAccountCountriesAuditMetadataTypeEntity metadataTypeEntity);
}


}
