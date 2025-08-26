using Roblox.Platform.Localization.Audit;
namespace Roblox.Localization.Accountsinternal {
    interface IAccountCountriesAutomationTypeConverter

{
	byte GetEntityIdFromEnum(AccountCountriesAutomationType automationType);

	AccountCountriesAutomationType GetEnumFromEntity(IAccountCountriesAutomationTypeEntity automationEntity);
}


}
