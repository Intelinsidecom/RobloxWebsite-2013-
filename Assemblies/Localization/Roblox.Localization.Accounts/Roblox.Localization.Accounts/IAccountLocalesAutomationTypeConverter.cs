using Roblox.Platform.Localization.Audit;
namespace Roblox.Localization.Accountsinternal {
    interface IAccountLocalesAutomationTypeConverter

{
	byte GetEntityIdFromEnum(AccountLocalesAutomationType automationType);

	AccountLocalesAutomationType GetEnumFromEntity(IAccountLocalesAutomationTypeEntity automationTypeEntity);
}


}
