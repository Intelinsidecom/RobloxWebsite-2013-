using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Assets.Places.Entities;

[ExcludeFromCodeCoverage]
internal class SocialSlotType : IRobloxEntity<int, SocialSlotTypeDAL>, ICacheableObject<int>, ICacheableObject, IRemoteCacheableObject
{
	private SocialSlotTypeDAL _EntityDAL;

	public static readonly CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(SocialSlotType).ToString(), isNullCacheable: true);

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

	internal DateTime CreatedUtc
	{
		get
		{
			return _EntityDAL.CreatedUtc;
		}
		set
		{
			_EntityDAL.CreatedUtc = value;
		}
	}

	internal DateTime UpdatedUtc
	{
		get
		{
			return _EntityDAL.UpdatedUtc;
		}
		set
		{
			_EntityDAL.UpdatedUtc = value;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public SocialSlotType()
	{
		_EntityDAL = new SocialSlotTypeDAL();
	}

	public SocialSlotType(SocialSlotTypeDAL entityDAL)
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
			_EntityDAL.CreatedUtc = DateTime.UtcNow;
			_EntityDAL.UpdatedUtc = _EntityDAL.CreatedUtc;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.UpdatedUtc = DateTime.UtcNow;
			_EntityDAL.Update();
		});
	}

	internal static SocialSlotType Get(int id)
	{
		return EntityHelper.GetEntity<int, SocialSlotTypeDAL, SocialSlotType>(EntityCacheInfo, id, () => SocialSlotTypeDAL.Get(id));
	}

	private static ICollection<SocialSlotType> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.MultiGetEntity<int, SocialSlotTypeDAL, SocialSlotType>(ids, EntityCacheInfo, SocialSlotTypeDAL.MultiGet);
	}

	public static SocialSlotType GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<int, SocialSlotTypeDAL, SocialSlotType>(EntityCacheInfo, GetLookupCacheKeysByValue(value), () => SocialSlotTypeDAL.GetSocialSlotTypeByValue(value));
	}

	public void Construct(SocialSlotTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeysByValue(Value);
		yield return GetLookupCacheKeysAll();
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	private static string GetLookupCacheKeysByID(int id)
	{
		return $"ID:{id}";
	}

	private static string GetLookupCacheKeysByValue(string value)
	{
		return $"Value:{value}";
	}

	private static string GetLookupCacheKeysAll()
	{
		return $"GetAll";
	}
}
