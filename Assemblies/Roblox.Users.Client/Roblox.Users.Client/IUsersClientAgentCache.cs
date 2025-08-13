namespace Roblox.Users.Client;

public interface IUsersClientAgentCache
{
	void SaveAgent(AgentData agentData);

	bool TryGetAgentById(long agentId, out AgentData agentData);

	bool TryGetAgentByTypeAndTarget(AssociatedEntityType agentType, long agentTargetId, out AgentData agentData);
}
