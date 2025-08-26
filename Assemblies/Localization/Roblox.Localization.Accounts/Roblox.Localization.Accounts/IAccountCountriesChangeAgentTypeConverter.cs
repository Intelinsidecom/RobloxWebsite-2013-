using Roblox.Platform.Localization.Audit;
namespace Roblox.Localization.Accountsinternal {
    interface IAccountCountriesChangeAgentTypeConverter

{
	byte GetEntityIdFromEnum(AccountCountriesChangeAgentType changeAgentType);

	AccountCountriesChangeAgentType GetEnumFromEntity(IAccountCountriesChangeAgentTypeEntity changeAgentEntity);
}


}
