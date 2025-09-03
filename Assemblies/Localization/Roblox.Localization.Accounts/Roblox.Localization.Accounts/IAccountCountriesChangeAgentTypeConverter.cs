using Roblox.Localization.Audit;
namespace Roblox.Localization.Accounts {
    interface IAccountCountriesChangeAgentTypeConverter

{
	byte GetEntityIdFromEnum(AccountCountriesChangeAgentType changeAgentType);

	AccountCountriesChangeAgentType GetEnumFromEntity(IAccountCountriesChangeAgentTypeEntity changeAgentEntity);
}


}
