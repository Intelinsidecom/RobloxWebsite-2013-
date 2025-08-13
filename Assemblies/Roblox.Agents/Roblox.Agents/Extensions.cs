using Roblox.Agents.Entities;

namespace Roblox.Agents;

internal static class Extensions
{
	public static IAgent Translate(this Roblox.Agents.Entities.Agent entity)
	{
		if (entity == null)
		{
			return null;
		}
		return new Agent
		{
			Id = entity.ID,
			AgentType = (AgentType)entity.AgentTypeID,
			AgentTargetId = entity.AgentTargetID
		};
	}
}
