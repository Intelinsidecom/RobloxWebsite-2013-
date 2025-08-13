using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Billing;

public class ImbursementRejectionType : IRobloxEntity<byte, ImbursementRejectionTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	private ImbursementRejectionTypeDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), typeof(ImbursementRejectionType).ToString(), isNullCacheable: true);

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

	public ImbursementRejectionType()
	{
		_EntityDAL = new ImbursementRejectionTypeDAL();
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

	public static ImbursementRejectionType Get(byte id)
	{
		return EntityHelper.GetEntity<byte, ImbursementRejectionTypeDAL, ImbursementRejectionType>(EntityCacheInfo, id, () => ImbursementRejectionTypeDAL.Get(id));
	}

	public static ImbursementRejectionType GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<byte, ImbursementRejectionTypeDAL, ImbursementRejectionType>(EntityCacheInfo, $"Value:{value}", () => ImbursementRejectionTypeDAL.GetImbursementRejectionTypeByValue(value));
	}

	internal static ICollection<ImbursementRejectionType> MultiGet(ICollection<byte> ids)
	{
		return EntityHelper.MultiGetEntity<byte, ImbursementRejectionTypeDAL, ImbursementRejectionType>(ids, EntityCacheInfo, ImbursementRejectionTypeDAL.MultiGet);
	}

	private static int GetTotalNumberOfImbursementRejectionTypes()
	{
		return EntityHelper.GetEntityCount(EntityCacheInfo, CacheManager.UnqualifiedNonExpiringCachePolicy, "GetTotalNumberOfImbursementRejectionTypes", ImbursementRejectionTypeDAL.GetTotalNumberOfImbursementRejectionTypes);
	}

	public static ICollection<ImbursementRejectionType> GetImbursementRejectionTypesPaged(byte startRowIndex, byte maximumRows)
	{
		string collectionId = $"GetImbursementRejectionTypesPaged_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.UnqualifiedNonExpiringCachePolicy, collectionId, () => ImbursementRejectionTypeDAL.GetImbursementRejectionTypes_Paged(startRowIndex + 1, maximumRows), MultiGet);
	}

	public static ICollection<ImbursementRejectionType> GetAll()
	{
		return GetImbursementRejectionTypesPaged(0, byte.MaxValue);
	}

	public void Construct(ImbursementRejectionTypeDAL dal)
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
