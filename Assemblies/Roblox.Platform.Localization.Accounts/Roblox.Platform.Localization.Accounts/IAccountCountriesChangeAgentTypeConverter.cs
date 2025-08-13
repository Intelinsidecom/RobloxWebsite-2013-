using Roblox.Platform.Localization.Audit;

namespace Roblox.Platform.Localization.Accounts;

internal interface IAccountCountriesChangeAgentTypeConverter
{
	byte GetEntityIdFromEnum(AccountCountriesChangeAgentType changeAgentType);

	AccountCountriesChangeAgentType GetEnumFromEntity(IAccountCountriesChangeAgentTypeEntity changeAgentEntity);
}
