using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Billing;

public class ImbursementTaxFormOnFile : IRobloxEntity<int, ImbursementTaxFormOnFileDAL>, ICacheableObject<int>, ICacheableObject
{
	private ImbursementTaxFormOnFileDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(ImbursementTaxFormOnFile).ToString(), isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	internal long UserID
	{
		get
		{
			return _EntityDAL.UserID;
		}
		set
		{
			_EntityDAL.UserID = value;
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

	public ImbursementTaxFormOnFile()
	{
		_EntityDAL = new ImbursementTaxFormOnFileDAL();
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

	internal static ImbursementTaxFormOnFile Get(int id)
	{
		return EntityHelper.GetEntity<int, ImbursementTaxFormOnFileDAL, ImbursementTaxFormOnFile>(EntityCacheInfo, id, () => ImbursementTaxFormOnFileDAL.Get(id));
	}

	internal static ICollection<ImbursementTaxFormOnFile> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.MultiGetEntity<int, ImbursementTaxFormOnFileDAL, ImbursementTaxFormOnFile>(ids, EntityCacheInfo, ImbursementTaxFormOnFileDAL.MultiGet);
	}

	public static ImbursementTaxFormOnFile GetByUserID(long userID)
	{
		return EntityHelper.GetEntityByLookup<int, ImbursementTaxFormOnFileDAL, ImbursementTaxFormOnFile>(EntityCacheInfo, $"UserID:{userID}", () => ImbursementTaxFormOnFileDAL.GetImbursementTaxFormOnFileByUserID(userID));
	}

	public static ImbursementTaxFormOnFile CreateNew(long userID)
	{
		ImbursementTaxFormOnFile imbursementTaxFormOnFile = new ImbursementTaxFormOnFile();
		imbursementTaxFormOnFile.UserID = userID;
		imbursementTaxFormOnFile.Save();
		return imbursementTaxFormOnFile;
	}

	public void RemoveTaxForm()
	{
		Delete();
	}

	public void Construct(ImbursementTaxFormOnFileDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"UserID:{UserID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	public static bool IsTaxFormOnFile(long userID)
	{
		return GetByUserID(userID) != null;
	}
}
