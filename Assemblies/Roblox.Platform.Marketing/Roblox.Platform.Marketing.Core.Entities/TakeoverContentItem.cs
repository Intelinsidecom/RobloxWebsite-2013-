using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Marketing.Core.Entities;

internal class TakeoverContentItem : IRobloxEntity<int, TakeoverContentItemDAL>, ICacheableObject<int>, ICacheableObject
{
	private TakeoverContentItemDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(TakeoverContentItem).ToString(), isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	internal int TakeoverID
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

	internal byte ContentItemTypeID
	{
		get
		{
			return _EntityDAL.ContentItemTypeID;
		}
		set
		{
			_EntityDAL.ContentItemTypeID = value;
		}
	}

	internal long ContentItemTargetID
	{
		get
		{
			return _EntityDAL.ContentItemTargetID;
		}
		set
		{
			_EntityDAL.ContentItemTargetID = value;
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

	public TakeoverContentItem()
	{
		_EntityDAL = new TakeoverContentItemDAL();
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

	internal static TakeoverContentItem Get(int id)
	{
		return EntityHelper.GetEntity<int, TakeoverContentItemDAL, TakeoverContentItem>(EntityCacheInfo, id, () => TakeoverContentItemDAL.Get(id));
	}

	internal static ICollection<TakeoverContentItem> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.MultiGetEntity<int, TakeoverContentItemDAL, TakeoverContentItem>(ids, EntityCacheInfo, TakeoverContentItemDAL.MultiGet);
	}

	internal static ICollection<TakeoverContentItem> GetTakeoverContentItemsByTakeoverIDPaged(int takeoverID, long startRowIndex, long maximumRows)
	{
		string collectionId = $"GetTakeoverContentItemsByTakeoverIDPaged_TakeoverID:{takeoverID}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy($"TakeoverID:{takeoverID}"), collectionId, () => TakeoverContentItemDAL.GetTakeoverContentItemIDsByTakeoverIDPaged(takeoverID, startRowIndex + 1, maximumRows), MultiGet);
	}

	internal static long GetTotalNumberOfTakeoverContentItemsByTakeoverId(int takeoverID)
	{
		string countId = $"GetTotalNumberOfTakeoverContentItemsByTakeoverId_TakeoverID:{takeoverID}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy($"TakeoverID:{takeoverID}"), countId, () => TakeoverContentItemDAL.GetTotalNumberOfTakeoverContentItemsByTakeoverID(takeoverID));
	}

	internal static ICollection<TakeoverContentItem> GetTakeoverContentItemsByContentItemTypeIDAndContentItemTargetIDPaged(byte contentItemTypeID, long contentItemTargetID, long startRowIndex, long maximumRows)
	{
		string collectionId = $"GetTakeoverContentItemsByContentItemTypeIDAndContentItemTargetIDPaged_ContentItemTypeID:{contentItemTypeID}_ContentItemTargetID:{contentItemTargetID}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy($"ContentItemTypeID:{contentItemTypeID}_ContentItemTargetID:{contentItemTargetID}"), collectionId, () => TakeoverContentItemDAL.GetTakeoverContentItemIDsByContentItemTypeIDAndContentItemTargetIDPaged(contentItemTypeID, contentItemTargetID, startRowIndex + 1, maximumRows), MultiGet);
	}

	internal static long GetTotalNumberOfTakeoverContentItemsByContentItemTypeIdAndContentItemTargetId(byte contentItemTypeID, long contentItemTargetID)
	{
		string countId = $"GetTotalNumberOfTakeoverContentItemsByContentItemTypeIdAndContentItemTargetId_ContentItemTypeID:{contentItemTypeID}_ContentItemTargetID:{contentItemTargetID}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy($"ContentItemTypeID:{contentItemTypeID}_ContentItemTargetID:{contentItemTargetID}"), countId, () => TakeoverContentItemDAL.GetTotalNumberOfTakeoverContentItemsByContentItemTypeIDAndContentItemTargetID(contentItemTypeID, contentItemTargetID));
	}

	public static TakeoverContentItem GetByTakeoverIDContentItemTypeIDAndContentItemTargetID(int takeoverID, byte contentItemTypeID, long contentItemTargetID)
	{
		return EntityHelper.GetEntityByLookup<int, TakeoverContentItemDAL, TakeoverContentItem>(EntityCacheInfo, $"TakeoverID:{takeoverID}_ContentItemTypeID:{contentItemTypeID}_ContentItemTargetID:{contentItemTargetID}", () => TakeoverContentItemDAL.GetTakeoverContentItemByTakeoverIDContentItemTypeIDAndContentItemTargetID(takeoverID, contentItemTypeID, contentItemTargetID));
	}

	public void Construct(TakeoverContentItemDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"TakeoverID:{TakeoverID}_ContentItemTypeID:{ContentItemTypeID}_ContentItemTargetID:{ContentItemTargetID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"TakeoverID:{TakeoverID}");
		yield return new StateToken($"ContentItemTypeID:{ContentItemTypeID}_ContentItemTargetID:{ContentItemTargetID}");
	}
}
