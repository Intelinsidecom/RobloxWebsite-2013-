using Roblox.Localization.Audit;
namespace Roblox.Localization.Accounts {
    interface IAccountLocalesChangeAgentTypeConverter

{
	byte GetEntityIdFromEnum(AccountLocalesChangeAgentType changeAgentType);

	AccountLocalesChangeAgentType GetEnumFromEntity(IAccountLocalesChangeAgentTypeEntity changeAgentTypeEntity);
}


}
