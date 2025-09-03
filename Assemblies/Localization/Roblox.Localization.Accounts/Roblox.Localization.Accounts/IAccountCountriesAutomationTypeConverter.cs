using Roblox.Localization.Audit;
namespace Roblox.Localization.Accounts {
    interface IAccountCountriesAutomationTypeConverter

{
	byte GetEntityIdFromEnum(AccountCountriesAutomationType automationType);

	AccountCountriesAutomationType GetEnumFromEntity(IAccountCountriesAutomationTypeEntity automationEntity);
}


}
