using Roblox.Platform.Localization.Audit;
namespace Roblox.Localization.Accountsinternal {
    interface IAccountLocalesChangeAgentTypeConverter

{
	byte GetEntityIdFromEnum(AccountLocalesChangeAgentType changeAgentType);

	AccountLocalesChangeAgentType GetEnumFromEntity(IAccountLocalesChangeAgentTypeEntity changeAgentTypeEntity);
}


}
