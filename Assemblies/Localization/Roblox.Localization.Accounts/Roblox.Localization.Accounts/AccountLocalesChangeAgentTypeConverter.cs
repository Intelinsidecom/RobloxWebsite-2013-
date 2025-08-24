using Roblox.Common;
using Roblox.Platform.Core;
using Roblox.Platform.Localization.Audit;

namespace Roblox.Platform.Localization.Accounts;

internal class AccountLocalesChangeAgentTypeConverter : IAccountLocalesChangeAgentTypeConverter
{
	private readonly IAccountLocalesChangeAgentTypeEntityFactory _ChangeAgentTypeEntityFactory;

	public AccountLocalesChangeAgentTypeConverter(IAccountLocalesChangeAgentTypeEntityFactory changeAgentTypeEntityFactory)
	{
		_ChangeAgentTypeEntityFactory = changeAgentTypeEntityFactory.AssignOrThrowIfNull("changeAgentTypeEntityFactory");
	}

	public byte GetEntityIdFromEnum(AccountLocalesChangeAgentType changeAgentType)
	{
		return (_ChangeAgentTypeEntityFactory.GetByValue(changeAgentType.ToString()) ?? throw new PlatformException($"Could not find an entity for change agent type: {changeAgentType.ToString()}.")).Id;
	}

	public AccountLocalesChangeAgentType GetEnumFromEntity(IAccountLocalesChangeAgentTypeEntity changeAgentTypeEntity)
	{
		if (changeAgentTypeEntity == null)
		{
			throw new PlatformArgumentNullException("changeAgentTypeEntity");
		}
		AccountLocalesChangeAgentType? changeAgentTypeEnum = EnumUtils.StrictTryParseEnum<AccountLocalesChangeAgentType>(changeAgentTypeEntity.Value);
		if (!changeAgentTypeEnum.HasValue)
		{
			throw new PlatformException($"Value: {changeAgentTypeEntity.Value} has no corresponding enum value. Please add it.");
		}
		return changeAgentTypeEnum.Value;
	}
}
