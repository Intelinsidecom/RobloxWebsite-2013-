namespace Roblox.Agents;

/// <summary>
/// Factory to get or create Agents
/// </summary>
public interface IAgentFactory
{
	/// <summary>
	/// Get an agent by its Id.
	/// </summary>
	/// <param name="agentId"></param>
	/// <returns>Agent if found, otherwise null</returns>
	IAgent Get(long agentId);

	/// <summary>
	/// Get an agent by its Id, throws if not found.
	/// </summary>
	/// <param name="agentId"></param>
	/// <returns>The non-null agent</returns>
	IAgent MustGet(long agentId);

	/// <summary>
	/// Lookup an agent by the Agent Type and the target Id
	/// </summary>
	/// <param name="agentType"></param>
	/// <param name="agentTargetId"></param>
	/// <returns></returns>
	IAgent GetByAgentTypeAndAgentTargetId(AgentType agentType, long agentTargetId);
}
