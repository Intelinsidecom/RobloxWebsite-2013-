using Roblox.Localization.Audit;
namespace Roblox.Localization.Accounts {
    interface IAccountLocalesAutomationTypeConverter

{
	byte GetEntityIdFromEnum(AccountLocalesAutomationType automationType);

	AccountLocalesAutomationType GetEnumFromEntity(IAccountLocalesAutomationTypeEntity automationTypeEntity);
}


}
