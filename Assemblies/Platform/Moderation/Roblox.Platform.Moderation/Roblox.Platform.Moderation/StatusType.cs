using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Moderation;

public class StatusType : IRobloxEntity<byte, StatusTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	private StatusTypeDAL _EntityDAL;

	private static readonly StatusType _Green;

	private static readonly StatusType _Yellow;

	private static readonly StatusType _Orange;

	private static readonly StatusType _Red;

	public static CacheInfo EntityCacheInfo;

	public byte ID => _EntityDAL.ID;

	public string Value
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

	public byte Rank
	{
		get
		{
			return _EntityDAL.Rank;
		}
		set
		{
			_EntityDAL.Rank = value;
		}
	}

	public DateTime Created
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

	public DateTime Updated
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

	public static StatusType Green => _Green;

	public static StatusType Yellow => _Yellow;

	public static StatusType Orange => _Orange;

	public static StatusType Red => _Red;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public StatusType()
	{
		_EntityDAL = new StatusTypeDAL();
	}

	static StatusType()
	{
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), typeof(StatusType).ToString(), isNullCacheable: true);
		_Green = Get("Green");
		_Yellow = Get("Yellow");
		_Orange = Get("Orange");
		_Red = Get("Red");
	}

	public void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	public void Save()
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

	public static StatusType CreateNew(string value, byte rank)
	{
		StatusType statusType = new StatusType();
		statusType.Value = value;
		statusType.Rank = rank;
		statusType.Save();
		return statusType;
	}

	public static StatusType Get(byte id)
	{
		return EntityHelper.GetEntity<byte, StatusTypeDAL, StatusType>(EntityCacheInfo, id, () => StatusTypeDAL.Get(id));
	}

	public static StatusType Get(string value)
	{
		return EntityHelper.GetEntityByLookup<byte, StatusTypeDAL, StatusType>(EntityCacheInfo, value, () => StatusTypeDAL.Get(value));
	}

	public void Construct(StatusTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
