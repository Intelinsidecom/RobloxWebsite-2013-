using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Games.Entities;

internal class PrivateServerCancellationTaskStatusType : IRobloxEntity<int, PrivateServerCancellationTaskStatusTypeDAL>, ICacheableObject<int>, ICacheableObject
{
	private PrivateServerCancellationTaskStatusTypeDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(PrivateServerCancellationTaskStatusType).ToString(), isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	internal string Value
	{
		get
		{
			return _EntityDAL.Value;
		}
		set
		{
			_EntityDAL.Value = value;
		}
	}

	internal DateTime Created
	{
		get
		{
			return _EntityDAL.Created;
		}
		set
		{
			_EntityDAL.Created = value;
		}
	}

	internal DateTime Updated
	{
		get
		{
			return _EntityDAL.Updated;
		}
		set
		{
			_EntityDAL.Updated = value;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public PrivateServerCancellationTaskStatusType()
	{
		_EntityDAL = new PrivateServerCancellationTaskStatusTypeDAL();
	}

	public PrivateServerCancellationTaskStatusType(PrivateServerCancellationTaskStatusTypeDAL entityDAL)
	{
		_EntityDAL = entityDAL;
	}

	internal void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	internal void Save()
	{
		EntityHelper.SaveEntity(this, delegate
		{
			_EntityDAL.Created = DateTime.Now;
			_EntityDAL.Updated = _EntityDAL.Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	internal static PrivateServerCancellationTaskStatusType Get(int id)
	{
		return EntityHelper.GetEntity<int, PrivateServerCancellationTaskStatusTypeDAL, PrivateServerCancellationTaskStatusType>(EntityCacheInfo, id, () => PrivateServerCancellationTaskStatusTypeDAL.Get(id));
	}

	private static ICollection<PrivateServerCancellationTaskStatusType> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.MultiGetEntity<int, PrivateServerCancellationTaskStatusTypeDAL, PrivateServerCancellationTaskStatusType>(ids, EntityCacheInfo, PrivateServerCancellationTaskStatusTypeDAL.MultiGet);
	}

	public static PrivateServerCancellationTaskStatusType GetOrCreate(string value)
	{
		return EntityHelper.GetOrCreateEntity<int, PrivateServerCancellationTaskStatusType>(EntityCacheInfo, GetLookupCacheKeysByValue(value), () => DoGetOrCreate(value));
	}

	private static PrivateServerCancellationTaskStatusType DoGetOrCreate(string value)
	{
		return EntityHelper.DoGetOrCreate<int, PrivateServerCancellationTaskStatusTypeDAL, PrivateServerCancellationTaskStatusType>(() => PrivateServerCancellationTaskStatusTypeDAL.GetOrCreatePrivateServerCancellationTaskStatusType(value));
	}

	public void Construct(PrivateServerCancellationTaskStatusTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeysByValue(Value);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	private static string GetLookupCacheKeysByPrivateServerCancellationTaskID(long privateServerCancellationTaskId)
	{
		return $"PrivateServerCancellationTaskID:{privateServerCancellationTaskId}";
	}

	private static string GetLookupCacheKeysByValue(string value)
	{
		return $"Value:{value}";
	}
}
