using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Marketing.Core.Entities;

internal class ContentItemType : IRobloxEntity<byte, ContentItemTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	private ContentItemTypeDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(ContentItemType).ToString(), isNullCacheable: true);

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

	public ContentItemType()
	{
		_EntityDAL = new ContentItemTypeDAL();
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

	internal static ContentItemType Get(byte id)
	{
		return EntityHelper.GetEntity<byte, ContentItemTypeDAL, ContentItemType>(EntityCacheInfo, id, () => ContentItemTypeDAL.Get(id));
	}

	internal static ICollection<ContentItemType> MultiGet(ICollection<byte> ids)
	{
		return EntityHelper.MultiGetEntity<byte, ContentItemTypeDAL, ContentItemType>(ids, EntityCacheInfo, ContentItemTypeDAL.MultiGet);
	}

	public static ContentItemType GetOrCreate(string value)
	{
		return EntityHelper.GetOrCreateEntity<byte, ContentItemType>(EntityCacheInfo, $"Value:{value}", () => DoGetOrCreate(value));
	}

	private static ContentItemType DoGetOrCreate(string value)
	{
		return EntityHelper.DoGetOrCreate<byte, ContentItemTypeDAL, ContentItemType>(() => ContentItemTypeDAL.GetOrCreateContentItemType(value));
	}

	public void Construct(ContentItemTypeDAL dal)
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
