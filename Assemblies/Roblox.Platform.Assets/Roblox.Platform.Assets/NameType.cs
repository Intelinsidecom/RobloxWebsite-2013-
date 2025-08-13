using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Assets;

internal class NameType : IRobloxEntity<byte, NameTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	private NameTypeDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), typeof(NameType).ToString(), isNullCacheable: true);

	public byte ID => _EntityDAL.ID;

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

	public NameType()
	{
		_EntityDAL = new NameTypeDAL();
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

	internal static NameType Get(byte id)
	{
		return EntityHelper.GetEntity<byte, NameTypeDAL, NameType>(EntityCacheInfo, id, () => NameTypeDAL.Get(id));
	}

	internal static ICollection<NameType> MultiGet(ICollection<byte> ids)
	{
		return EntityHelper.MultiGetEntity<byte, NameTypeDAL, NameType>(ids, EntityCacheInfo, NameTypeDAL.MultiGet);
	}

	public static NameType GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<byte, NameTypeDAL, NameType>(EntityCacheInfo, $"Value:{value}", () => NameTypeDAL.GetNameTypeByValue(value));
	}

	public void Construct(NameTypeDAL dal)
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
