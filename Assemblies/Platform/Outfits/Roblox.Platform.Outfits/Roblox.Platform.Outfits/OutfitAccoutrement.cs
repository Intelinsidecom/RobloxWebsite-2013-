using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Outfits;

public class OutfitAccoutrement : IRobloxEntity<long, OutfitAccoutrementDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private OutfitAccoutrementDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: false, hasUnqualifiedCollections: false), typeof(OutfitAccoutrement).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public long OutfitID
	{
		get
		{
			return _EntityDAL.OutfitID;
		}
		set
		{
			_EntityDAL.OutfitID = value;
		}
	}

	public long AssetID
	{
		get
		{
			return _EntityDAL.AssetID;
		}
		set
		{
			_EntityDAL.AssetID = value;
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

	public OutfitAccoutrement()
	{
		_EntityDAL = new OutfitAccoutrementDAL();
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

	public static OutfitAccoutrement Create(long outfitid, long assetid)
	{
		OutfitAccoutrement outfitAccoutrement = new OutfitAccoutrement();
		outfitAccoutrement.OutfitID = outfitid;
		outfitAccoutrement.AssetID = assetid;
		outfitAccoutrement.Save();
		return outfitAccoutrement;
	}

	public static OutfitAccoutrement Get(long id)
	{
		return EntityHelper.GetEntity<long, OutfitAccoutrementDAL, OutfitAccoutrement>(EntityCacheInfo, id, () => OutfitAccoutrementDAL.Get(id));
	}

	public static ICollection<OutfitAccoutrement> GetOutfitAccoutrementsByOutfitIDPaged(long outfitId, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetOutfitAccoutrementIDsByOutfitIDPaged_OutfitID:{outfitId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"OutfitID:{outfitId}"), collectionId, () => OutfitAccoutrementDAL.GetOutfitAccoutrementIDsByOutfitIDPaged(outfitId, startRowIndex, maximumRows), Get);
	}

	public static int GetTotalNumberOfOutfitAccoutrementsByOutfitID(long outfitId)
	{
		string countId = $"GetTotalNumberOfOutfitAccoutrementsByOutfitID:{outfitId}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"OutfitID:{outfitId}"), countId, () => OutfitAccoutrementDAL.GetTotalNumberOfOutfitAccoutrementsByOutfitID(outfitId));
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	public void Construct(OutfitAccoutrementDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"OutfitID:{OutfitID}");
	}
}
