using Roblox.Platform.Localization.Audit;

namespace Roblox.Platform.Localization.Accounts;

internal interface IAccountLocalesAuditMetadataTypeConverter
{
	byte GetEntityIdFromEnum(AccountLocalesAuditEntryMetadataType metadataType);

	AccountLocalesAuditEntryMetadataType GetEnumFromEntity(IAccountLocalesAuditMetadataTypeEntity metadataTypeEntity);
}
