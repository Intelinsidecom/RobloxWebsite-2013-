using Roblox.Common;
using Roblox.Platform.Core;
using Roblox.Platform.Localization.Audit;

namespace Roblox.Platform.Localization.Accounts;

internal class AccountCountriesAutomationTypeConverter : IAccountCountriesAutomationTypeConverter
{
	private readonly IAccountCountriesAutomationTypeEntityFactory _AutomationTypeEntityFactory;

	public AccountCountriesAutomationTypeConverter(IAccountCountriesAutomationTypeEntityFactory automationTypeEntityFactory)
	{
		_AutomationTypeEntityFactory = automationTypeEntityFactory.AssignOrThrowIfNull("automationTypeEntityFactory");
	}

	public byte GetEntityIdFromEnum(AccountCountriesAutomationType automationType)
	{
		return (_AutomationTypeEntityFactory.GetByValue(automationType.ToString()) ?? throw new PlatformException($"Could not find an entity for automation type: {automationType.ToString()}.")).Id;
	}

	public AccountCountriesAutomationType GetEnumFromEntity(IAccountCountriesAutomationTypeEntity automationEntity)
	{
		if (automationEntity == null)
		{
			throw new PlatformArgumentNullException("automationEntity");
		}
		AccountCountriesAutomationType? automationTypeEnum = EnumUtils.StrictTryParseEnum<AccountCountriesAutomationType>(automationEntity.Value);
		if (!automationTypeEnum.HasValue)
		{
			throw new PlatformException($"Value: {automationEntity.Value} has no corresponding enum value. Please add it.");
		}
		return automationTypeEnum.Value;
	}
}
