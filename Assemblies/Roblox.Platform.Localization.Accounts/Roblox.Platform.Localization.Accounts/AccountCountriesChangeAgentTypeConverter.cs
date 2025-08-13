using Roblox.Common;
using Roblox.Platform.Core;
using Roblox.Platform.Localization.Audit;

namespace Roblox.Platform.Localization.Accounts;

internal class AccountCountriesChangeAgentTypeConverter : IAccountCountriesChangeAgentTypeConverter
{
	private readonly IAccountCountriesChangeAgentTypeEntityFactory _ChangeAgentTypeEntityFactory;

	public AccountCountriesChangeAgentTypeConverter(IAccountCountriesChangeAgentTypeEntityFactory changeAgentTypeEntityFactory)
	{
		_ChangeAgentTypeEntityFactory = changeAgentTypeEntityFactory.AssignOrThrowIfNull("changeAgentTypeEntityFactory");
	}

	public byte GetEntityIdFromEnum(AccountCountriesChangeAgentType changeAgentType)
	{
		return (_ChangeAgentTypeEntityFactory.GetByValue(changeAgentType.ToString()) ?? throw new PlatformException($"Could not find an entity for change agent type: {changeAgentType.ToString()}.")).Id;
	}

	public AccountCountriesChangeAgentType GetEnumFromEntity(IAccountCountriesChangeAgentTypeEntity changeAgentEntity)
	{
		if (changeAgentEntity == null)
		{
			throw new PlatformArgumentNullException("changeAgentEntity");
		}
		AccountCountriesChangeAgentType? changeAgentTypeEnum = EnumUtils.StrictTryParseEnum<AccountCountriesChangeAgentType>(changeAgentEntity.Value);
		if (!changeAgentTypeEnum.HasValue)
		{
			throw new PlatformException($"Value: {changeAgentEntity.Value} has no corresponding enum value. Please add it.");
		}
		return changeAgentTypeEnum.Value;
	}
}
