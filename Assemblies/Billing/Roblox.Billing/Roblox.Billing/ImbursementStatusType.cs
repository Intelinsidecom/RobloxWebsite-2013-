using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Billing;

public class ImbursementStatusType : IRobloxEntity<byte, ImbursementStatusTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	public ImbursementStatusTypeDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true), typeof(ImbursementStatusType).ToString(), isNullCacheable: true);

	public static ImbursementStatusType Pending => GetByValue("Pending");

	public static ImbursementStatusType Completed => GetByValue("Completed");

	public static ImbursementStatusType Rejected => GetByValue("Rejected");

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

	public ImbursementStatusType()
	{
		_EntityDAL = new ImbursementStatusTypeDAL();
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

	public static ImbursementStatusType CreateNew(string name)
	{
		ImbursementStatusType imbursementStatusType = new ImbursementStatusType();
		imbursementStatusType.Value = name;
		imbursementStatusType.Save();
		return imbursementStatusType;
	}

	public static ImbursementStatusType Get(byte id)
	{
		return EntityHelper.GetEntity<byte, ImbursementStatusTypeDAL, ImbursementStatusType>(EntityCacheInfo, id, () => ImbursementStatusTypeDAL.Get(id));
	}

	public static ImbursementStatusType GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<byte, ImbursementStatusTypeDAL, ImbursementStatusType>(EntityCacheInfo, $"Value:{value}", () => ImbursementStatusTypeDAL.GetByValue(value));
	}

	public static ICollection<ImbursementStatusType> GetAll()
	{
		byte totalNumber = ImbursementStatusTypeDAL.GetTotalNumberOfImbursementStatusTypes();
		string collectionID = $"ImbursementStatusType_GetAll";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.UnqualifiedNonExpiringCachePolicy, collectionID, () => ImbursementStatusTypeDAL.GetImbursementStatusTypes_Paged(1, totalNumber), Get);
	}

	public void Construct(ImbursementStatusTypeDAL dal)
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
