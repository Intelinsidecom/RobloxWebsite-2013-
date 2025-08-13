using Roblox.Common;
using Roblox.Platform.Core;
using Roblox.Platform.Localization.Audit;

namespace Roblox.Platform.Localization.Accounts;

internal class AccountLocalesAuditMetadataTypeConverter : IAccountLocalesAuditMetadataTypeConverter
{
	private readonly IAccountLocalesAuditMetadataTypeEntityFactory _MetadataTypeEntityFactory;

	public AccountLocalesAuditMetadataTypeConverter(IAccountLocalesAuditMetadataTypeEntityFactory metadataTypeEntityFactory)
	{
		_MetadataTypeEntityFactory = metadataTypeEntityFactory.AssignOrThrowIfNull("metadataTypeEntityFactory");
	}

	public byte GetEntityIdFromEnum(AccountLocalesAuditEntryMetadataType metadataType)
	{
		return (_MetadataTypeEntityFactory.GetByValue(metadataType.ToString()) ?? throw new PlatformException($"Could not find an entity for metadata type: {metadataType.ToString()}.")).Id;
	}

	public AccountLocalesAuditEntryMetadataType GetEnumFromEntity(IAccountLocalesAuditMetadataTypeEntity metadataTypeEntity)
	{
		if (metadataTypeEntity == null)
		{
			throw new PlatformArgumentNullException("metadataTypeEntity");
		}
		AccountLocalesAuditEntryMetadataType? metadataTypeEnum = EnumUtils.StrictTryParseEnum<AccountLocalesAuditEntryMetadataType>(metadataTypeEntity.Value);
		if (!metadataTypeEnum.HasValue)
		{
			throw new PlatformException($"Value: {metadataTypeEntity.Value} has no corresponding enum value. Please add it.");
		}
		return metadataTypeEnum.Value;
	}
}
