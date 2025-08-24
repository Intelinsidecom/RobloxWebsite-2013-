using Roblox.Platform.Localization.Audit;

namespace Roblox.Platform.Localization.Accounts;

internal interface IAccountLocalesAutomationTypeConverter
{
	byte GetEntityIdFromEnum(AccountLocalesAutomationType automationType);

	AccountLocalesAutomationType GetEnumFromEntity(IAccountLocalesAutomationTypeEntity automationTypeEntity);
}
