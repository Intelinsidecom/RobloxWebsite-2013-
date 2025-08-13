using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Users;

public class GenderType : IRobloxEntity<byte, GenderTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	private GenderTypeDAL _EntityDAL;

	private const string UnknownValue = "Unknown";

	public static readonly byte UnknownID;

	private const string MaleValue = "Male";

	public static readonly byte MaleID;

	private const string FemaleValue = "Female";

	public static readonly byte FemaleID;

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

	public CacheInfo CacheInfo => EntityCacheInfo;

	public GenderType()
	{
		_EntityDAL = new GenderTypeDAL();
	}

	static GenderType()
	{
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.GenderType", isNullCacheable: true);
		UnknownID = Get("Unknown").ID;
		MaleID = Get("Male").ID;
		FemaleID = Get("Female").ID;
	}

	public void Save()
	{
		EntityHelper.SaveEntity(this, delegate
		{
			_EntityDAL.Created = DateTime.Now;
			_EntityDAL.Updated = Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	public static GenderType Get(byte id)
	{
		return EntityHelper.GetEntity<byte, GenderTypeDAL, GenderType>(EntityCacheInfo, id, () => GenderTypeDAL.Get(id));
	}

	public static GenderType Get(string value)
	{
		return EntityHelper.GetEntityByLookup<byte, GenderTypeDAL, GenderType>(EntityCacheInfo, $"Value:{value}", () => GenderTypeDAL.Get(value));
	}

	public void Construct(GenderTypeDAL dal)
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
