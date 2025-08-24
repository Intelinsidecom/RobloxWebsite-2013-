using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Moderation;

public class ItemType : IRobloxEntity<byte, ItemTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	private ItemTypeDAL _EntityDAL;

	private static readonly ItemType _Asset;

	public static readonly ItemType _User;

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

	public static ItemType Asset => _Asset;

	public static ItemType User => _User;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public ItemType()
	{
		_EntityDAL = new ItemTypeDAL();
	}

	static ItemType()
	{
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), typeof(ItemType).ToString(), isNullCacheable: true);
		_Asset = Get("Asset");
		_User = Get("User");
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

	private static ItemType CreateNew(string value)
	{
		ItemType itemType = new ItemType();
		itemType.Value = value;
		itemType.Save();
		return itemType;
	}

	public static ItemType Get(byte id)
	{
		return EntityHelper.GetEntity<byte, ItemTypeDAL, ItemType>(EntityCacheInfo, id, () => ItemTypeDAL.Get(id));
	}

	public static ItemType Get(string value)
	{
		return EntityHelper.GetEntityByLookup<byte, ItemTypeDAL, ItemType>(EntityCacheInfo, value, () => ItemTypeDAL.Get(value));
	}

	public void Construct(ItemTypeDAL dal)
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
