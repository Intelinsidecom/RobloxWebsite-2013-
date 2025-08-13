using Roblox.Common;
using Roblox.Platform.Core;
using Roblox.Platform.Localization.Audit;

namespace Roblox.Platform.Localization.Accounts;

internal class AccountCountriesAuditMetadataTypeConverter : IAccountCountriesAuditMetadataTypeConverter
{
	private readonly IAccountCountriesAuditMetadataTypeEntityFactory _MetadataTypeEntityFactory;

	public AccountCountriesAuditMetadataTypeConverter(IAccountCountriesAuditMetadataTypeEntityFactory metadataTypeEntityFactory)
	{
		_MetadataTypeEntityFactory = metadataTypeEntityFactory.AssignOrThrowIfNull("metadataTypeEntityFactory");
	}

	public byte GetEntityIdFromEnum(AccountCountriesAuditEntryMetadataType metadataType)
	{
		return (_MetadataTypeEntityFactory.GetByValue(metadataType.ToString()) ?? throw new PlatformException($"Could not find an entity for metadata type: {metadataType.ToString()}.")).Id;
	}

	public AccountCountriesAuditEntryMetadataType GetEnumFromEntity(IAccountCountriesAuditMetadataTypeEntity metadataTypeEntity)
	{
		if (metadataTypeEntity == null)
		{
			throw new PlatformArgumentNullException("metadataTypeEntity");
		}
		AccountCountriesAuditEntryMetadataType? metadataTypeEnum = EnumUtils.StrictTryParseEnum<AccountCountriesAuditEntryMetadataType>(metadataTypeEntity.Value);
		if (!metadataTypeEnum.HasValue)
		{
			throw new PlatformException($"Value: {metadataTypeEntity.Value} has no corresponding enum value. Please add it.");
		}
		return metadataTypeEnum.Value;
	}
}
