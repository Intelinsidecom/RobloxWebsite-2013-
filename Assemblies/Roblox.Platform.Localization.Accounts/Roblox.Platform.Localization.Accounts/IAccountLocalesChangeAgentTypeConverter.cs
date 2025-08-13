using Roblox.Platform.Localization.Audit;

namespace Roblox.Platform.Localization.Accounts;

internal interface IAccountLocalesChangeAgentTypeConverter
{
	byte GetEntityIdFromEnum(AccountLocalesChangeAgentType changeAgentType);

	AccountLocalesChangeAgentType GetEnumFromEntity(IAccountLocalesChangeAgentTypeEntity changeAgentTypeEntity);
}
