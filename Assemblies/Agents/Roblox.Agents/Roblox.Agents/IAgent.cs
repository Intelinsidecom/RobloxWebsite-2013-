namespace Roblox.Agents;

/// <summary>
/// Interface representing an Agent entity
/// </summary>
public interface IAgent
{
	/// <summary>
	/// The Agent ID
	/// </summary>
	long Id { get; }

	/// <summary>
	/// The Agent Type enum, either User or Group
	/// </summary>
	AgentType AgentType { get; }

	/// <summary>
	/// The Agent Target ID, either the User ID or the Group ID, depending on the Agent Type
	/// </summary>
	long AgentTargetId { get; }
}
