using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.PremiumFeatures;

public class ContentPrivilegeType : IRobloxEntity<byte, ContentPrivilegeTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	private ContentPrivilegeTypeDAL _EntityDAL;

	public const string NoneValue = "None";

	public static readonly byte NoneID;

	public const string CreateAndSellValue = "Create and Sell";

	public static readonly byte CreateAndSellID;

	internal static CacheInfo EntityCacheInfo;

	public byte ID => _EntityDAL.ID;

	public string Value
	{
		get
		{
			return _EntityDAL.Value;
		}
		private set
		{
			_EntityDAL.Value = value;
		}
	}

	internal DateTime Created => _EntityDAL.Created;

	internal DateTime Updated => _EntityDAL.Updated;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public ContentPrivilegeType()
	{
		_EntityDAL = new ContentPrivilegeTypeDAL();
	}

	static ContentPrivilegeType()
	{
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "ContentPrivilegeType", isNullCacheable: true);
		NoneID = GetByValue("None").ID;
		CreateAndSellID = GetByValue("Create and Sell").ID;
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
			_EntityDAL.Updated = Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	public static ContentPrivilegeType Get(byte id)
	{
		return EntityHelper.GetEntity<byte, ContentPrivilegeTypeDAL, ContentPrivilegeType>(EntityCacheInfo, id, () => ContentPrivilegeTypeDAL.Get(id));
	}

	internal static ContentPrivilegeType Get(byte? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	internal static ContentPrivilegeType GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<byte, ContentPrivilegeTypeDAL, ContentPrivilegeType>(EntityCacheInfo, $"Value:{value}", () => ContentPrivilegeTypeDAL.GetByValue(value));
	}

	public void Construct(ContentPrivilegeTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return $"Value:{Value}";
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
