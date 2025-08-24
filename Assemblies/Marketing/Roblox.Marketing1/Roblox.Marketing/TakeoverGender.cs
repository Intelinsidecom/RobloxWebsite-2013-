using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Marketing;

public class TakeoverGender : IRobloxEntity<int, TakeoverGenderDAL>, ICacheableObject<int>, ICacheableObject
{
	private TakeoverGenderDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(TakeoverGender).ToString(), isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	public int TakeoverID
	{
		get
		{
			return _EntityDAL.TakeoverID;
		}
		set
		{
			_EntityDAL.TakeoverID = value;
		}
	}

	public byte GenderTypeID
	{
		get
		{
			return _EntityDAL.GenderTypeID;
		}
		set
		{
			_EntityDAL.GenderTypeID = value;
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

	public TakeoverGender()
	{
		_EntityDAL = new TakeoverGenderDAL();
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

	public static TakeoverGender CreateNew(int takeoverid, byte genderTypeId)
	{
		TakeoverGender takeoverGender = new TakeoverGender();
		takeoverGender.TakeoverID = takeoverid;
		takeoverGender.GenderTypeID = genderTypeId;
		takeoverGender.Save();
		return takeoverGender;
	}

	internal static TakeoverGender Get(int id)
	{
		return EntityHelper.GetEntity<int, TakeoverGenderDAL, TakeoverGender>(EntityCacheInfo, id, () => TakeoverGenderDAL.Get(id));
	}

	public static TakeoverGender GetByTakeoverID(int takeoverID)
	{
		return EntityHelper.GetEntityByLookup<int, TakeoverGenderDAL, TakeoverGender>(EntityCacheInfo, $"TakeoverID:{takeoverID}", () => TakeoverGenderDAL.GetTakeoverGenderByTakeoverID(takeoverID));
	}

	public static ICollection<TakeoverGender> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.MultiGetEntity<int, TakeoverGenderDAL, TakeoverGender>(ids, EntityCacheInfo, TakeoverGenderDAL.MultiGet);
	}

	public void Construct(TakeoverGenderDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"TakeoverID:{TakeoverID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
