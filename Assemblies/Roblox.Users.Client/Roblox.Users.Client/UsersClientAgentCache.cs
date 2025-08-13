using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Collections;
using Roblox.Users.Client.Properties;

namespace Roblox.Users.Client;

public class UsersClientAgentCache : IUsersClientAgentCache
{
	private readonly ExpirableDictionary<long, AgentData> _AgentCacheById;

	private readonly ExpirableDictionary<string, AgentData> _AgentCacheByTypeAndTargetId;

	[ExcludeFromCodeCoverage]
	public UsersClientAgentCache()
		: this(Settings.Default)
	{
	}

	internal UsersClientAgentCache(ISettings settings)
	{
		if (settings == null)
		{
			throw new ArgumentNullException("settings");
		}
		_AgentCacheById = new ExpirableDictionary<long, AgentData>(() => settings.AgentLocalCacheExpiry, ExpirationPolicy.RenewOnRead);
		_AgentCacheByTypeAndTargetId = new ExpirableDictionary<string, AgentData>(() => settings.AgentLocalCacheExpiry, ExpirationPolicy.RenewOnRead);
	}

	public void SaveAgent(AgentData agentData)
	{
		if (agentData != null)
		{
			string key = BuildAgentByTypeAndTargetCacheKey(agentData.Type, agentData.TargetId);
			_AgentCacheById.Set(agentData.Id, agentData);
			_AgentCacheByTypeAndTargetId.Set(key, agentData);
		}
	}

	public bool TryGetAgentById(long agentId, out AgentData agentData)
	{
		if (agentId <= 0)
		{
			agentData = null;
			return true;
		}
		agentData = _AgentCacheById.Get(agentId);
		return agentData != null;
	}

	public bool TryGetAgentByTypeAndTarget(AssociatedEntityType agentType, long agentTargetId, out AgentData agentData)
	{
		if (agentTargetId <= 0 || !Enum.IsDefined(typeof(AssociatedEntityType), agentType))
		{
			agentData = null;
			return true;
		}
		string key = BuildAgentByTypeAndTargetCacheKey(agentType, agentTargetId);
		agentData = _AgentCacheByTypeAndTargetId.Get(key);
		return agentData != null;
	}

	internal void RemoveAgentById(long agentId)
	{
		_AgentCacheById.Remove(agentId);
	}

	internal void RemoveAgentByTypeAndTargetId(AssociatedEntityType agentType, long agentTargetId)
	{
		string key = BuildAgentByTypeAndTargetCacheKey(agentType, agentTargetId);
		_AgentCacheByTypeAndTargetId.Remove(key);
	}

	private string BuildAgentByTypeAndTargetCacheKey(AssociatedEntityType agentType, long agentTargetId)
	{
		return $"agentType:{agentType}_agentTargetId:{agentTargetId}";
	}
}
