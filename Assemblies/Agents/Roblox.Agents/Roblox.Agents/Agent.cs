namespace Roblox.Agents;

internal class Agent : IAgent
{
	public long Id { get; set; }

	public AgentType AgentType { get; set; }

	public long AgentTargetId { get; set; }
}
