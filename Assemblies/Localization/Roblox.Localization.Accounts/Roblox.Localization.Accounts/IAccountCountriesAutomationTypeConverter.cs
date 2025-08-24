using Roblox.Platform.Localization.Audit;

namespace Roblox.Platform.Localization.Accounts;

internal interface IAccountCountriesAutomationTypeConverter
{
	byte GetEntityIdFromEnum(AccountCountriesAutomationType automationType);

	AccountCountriesAutomationType GetEnumFromEntity(IAccountCountriesAutomationTypeEntity automationEntity);
}
