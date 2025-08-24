using Roblox.Common;
using Roblox.Platform.Core;
using Roblox.Platform.Localization.Audit;

namespace Roblox.Platform.Localization.Accounts;

internal class AccountLocalesAutomationTypeConverter : IAccountLocalesAutomationTypeConverter
{
	private readonly IAccountLocalesAutomationTypeEntityFactory _AutomationTypeEntityFactory;

	public AccountLocalesAutomationTypeConverter(IAccountLocalesAutomationTypeEntityFactory automationTypeEntityFactory)
	{
		_AutomationTypeEntityFactory = automationTypeEntityFactory.AssignOrThrowIfNull("automationTypeEntityFactory");
	}

	public byte GetEntityIdFromEnum(AccountLocalesAutomationType automationType)
	{
		return (_AutomationTypeEntityFactory.GetByValue(automationType.ToString()) ?? throw new PlatformException($"Could not find an entity for automation type: {automationType.ToString()}.")).Id;
	}

	public AccountLocalesAutomationType GetEnumFromEntity(IAccountLocalesAutomationTypeEntity automationTypeEntity)
	{
		if (automationTypeEntity == null)
		{
			throw new PlatformArgumentNullException("automationTypeEntity");
		}
		AccountLocalesAutomationType? automationTypeEnum = EnumUtils.StrictTryParseEnum<AccountLocalesAutomationType>(automationTypeEntity.Value);
		if (!automationTypeEnum.HasValue)
		{
			throw new PlatformException($"Value: {automationTypeEntity.Value} has no corresponding enum value. Please add it.");
		}
		return automationTypeEnum.Value;
	}
}
