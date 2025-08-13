using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Throttling.Entities;

internal class ActionType : IRobloxEntity<long, ActionTypeDAL>, ICacheableObject<long>, ICacheableObject
{
	private ActionTypeDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(ActionType).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

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

	public ActionType()
	{
		_EntityDAL = new ActionTypeDAL();
	}

	private static ActionType DoGetOrCreate(string value)
	{
		return EntityHelper.DoGetOrCreate<long, ActionTypeDAL, ActionType>(() => ActionTypeDAL.GetOrCreateActionType(value));
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

	internal static ActionType Get(long id)
	{
		return EntityHelper.GetEntity<long, ActionTypeDAL, ActionType>(EntityCacheInfo, id, () => ActionTypeDAL.Get(id));
	}

	internal static ActionType GetOrCreate(string value)
	{
		return EntityHelper.GetOrCreateEntity<long, ActionType>(EntityCacheInfo, $"Value:{value}", () => DoGetOrCreate(value));
	}

	public void Construct(ActionTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"Value:{Value}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
