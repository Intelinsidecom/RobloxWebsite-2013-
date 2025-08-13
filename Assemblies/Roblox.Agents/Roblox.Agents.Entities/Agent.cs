using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Agents.Entities;

internal class Agent : IRobloxEntity<long, AgentDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private AgentDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), "Roblox.Agent", isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public byte AgentTypeID
	{
		get
		{
			return _EntityDAL.AgentTypeID;
		}
		set
		{
			_EntityDAL.AgentTypeID = value;
		}
	}

	public long AgentTargetID
	{
		get
		{
			return _EntityDAL.AgentTargetID;
		}
		set
		{
			_EntityDAL.AgentTargetID = value;
		}
	}

	public DateTime Created => _EntityDAL.Created;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public Agent()
	{
		_EntityDAL = new AgentDAL();
	}

	public Agent(AgentDAL dal)
	{
		_EntityDAL = dal;
	}

	public static Agent Get(long id)
	{
		return EntityHelper.GetEntity<long, AgentDAL, Agent>(EntityCacheInfo, id, () => AgentDAL.Get(id));
	}

	public static Agent GetByAgentTypeIdAndAgentTargetId(byte agentTypeId, long agentTargetId)
	{
		return EntityHelper.GetEntityByLookup<long, AgentDAL, Agent>(EntityCacheInfo, "AgentTypeID:" + agentTypeId + "_AgentTargetID:" + agentTargetId, () => AgentDAL.GetByAgentTypeIdAndAgentTargetId(agentTypeId, agentTargetId));
	}

	public static Agent MustGet(long id)
	{
		return EntityHelper.MustGet(id, Get);
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"AgentTypeID:{AgentTypeID}_AgentTargetID:{AgentTargetID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	public void Construct(AgentDAL dal)
	{
		_EntityDAL = dal;
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}
}
