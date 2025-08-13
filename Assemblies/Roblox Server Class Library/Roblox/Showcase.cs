using System;
using System.Collections.Generic;
using System.ComponentModel;
using Roblox.Agents;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.DataAccess;
using Roblox.PremiumFeatures;
using Roblox.Properties;

namespace Roblox;

[DataObject]
public class Showcase : IRobloxEntity<long, ShowcaseDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private ShowcaseDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), "Showcase", isNullCacheable: true);

	[DataObjectField(true, true)]
	public long ID
	{
		get
		{
			return _EntityDAL.ID;
		}
		set
		{
			_EntityDAL.ID = value;
		}
	}

	[DataObjectField(false, false, false)]
	public long UserID
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

	[DataObjectField(false, false, false)]
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

	[DataObjectField(false, false, false)]
	public byte SortOrder
	{
		get
		{
			return _EntityDAL.SortOrder;
		}
		set
		{
			_EntityDAL.SortOrder = value;
		}
	}

	[DataObjectField(false, false)]
	public DateTime Created => _EntityDAL.Created;

	[DataObjectField(false, false)]
	public DateTime Updated => _EntityDAL.Updated;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public static event Action<long> OnShowcaseDeleted;

	private static bool CanAddShowcase(long agentId)
	{
		IAgent agent = AgentFactory.Get(agentId);
		if (agent.AgentType == AgentType.Group)
		{
			return true;
		}
		User user = User.Get(agent.AgentTargetId);
		int totalNumberOfShowcases = GetTotalNumberOfShowcases(user.ID);
		if (Settings.Default.IsIncreasedActiveUniverseLimitEnabled)
		{
			return totalNumberOfShowcases < Settings.Default.MaxActiveUniversesCount;
		}
		byte showcaseAllotment = AccountFeatureSet.GetOrCreate(user.AccountID).ShowcaseAllotment;
		return totalNumberOfShowcases < showcaseAllotment;
	}

	public Showcase(ShowcaseDAL dal)
	{
		_EntityDAL = dal;
	}

	public Showcase()
	{
		_EntityDAL = new ShowcaseDAL();
	}

	public void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
		Showcase.OnShowcaseDeleted?.Invoke(AssetID);
	}

	public void Save()
	{
		if (_EntityDAL == null)
		{
			throw new ApplicationException("Required object not provided: EntityDAL.");
		}
		if (!CanAddShowcase(UserID))
		{
			throw new InvalidOperationException($"User {UserID} is at maximum # showcases for membership level");
		}
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

	public static Showcase CreateNew(long userId, long assetId)
	{
		Showcase showcase = new Showcase();
		showcase.UserID = userId;
		showcase.AssetID = assetId;
		showcase.Save();
		return showcase;
	}

	[DataObjectMethod(DataObjectMethodType.Delete, true)]
	public static void Delete(long id)
	{
		if (id == 0L)
		{
			throw new ApplicationException("Required value not specified: ID");
		}
		Get(id)?.Delete();
	}

	[DataObjectMethod(DataObjectMethodType.Select, true)]
	public static Showcase Get(long id)
	{
		return EntityHelper.GetEntity<long, ShowcaseDAL, Showcase>(EntityCacheInfo, id, () => ShowcaseDAL.Get(id));
	}

	public static Showcase Get(long? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	[DataObjectMethod(DataObjectMethodType.Select, false)]
	public static Showcase Get(long userId, long assetId)
	{
		return EntityHelper.GetEntityByLookup<long, ShowcaseDAL, Showcase>(EntityCacheInfo, $"UserID:{userId}_AssetID:{assetId}", () => ShowcaseDAL.Get(userId, assetId));
	}

	[DataObjectMethod(DataObjectMethodType.Select, false)]
	public static ICollection<Showcase> GetShowcases(long userId, string sortExpression, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetShowcases_UserID:{userId}_Keyword:_SortExpression:{sortExpression}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy($"UserID:{userId}"), collectionId, () => ShowcaseDAL.GetShowcaseIDs(userId, sortExpression, startRowIndex + 1, maximumRows), Get);
	}

	[DataObjectMethod(DataObjectMethodType.Select, false)]
	public static int GetTotalNumberOfShowcases(long userId)
	{
		string countId = $"GetTotalNumberOfShowcases_UserID:{userId}_Keyword:";
		return EntityHelper.GetEntityCount(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy($"UserID:{userId}"), countId, () => ShowcaseDAL.GetTotalNumberOfShowcases(userId));
	}

	public static void RemoveExtraneousShowcases(long accountId)
	{
		User byAccountID = User.GetByAccountID(accountId);
		ICollection<Showcase> obj = GetShowcases(maximumRows: GetTotalNumberOfShowcases(byAccountID.ID), userId: byAccountID.ID, sortExpression: string.Empty, startRowIndex: 0);
		int showcaseAllotment = AccountFeatureSet.GetOrCreate(accountId).ShowcaseAllotment;
		if (Settings.Default.IsIncreasedActiveUniverseLimitEnabled)
		{
			showcaseAllotment = Settings.Default.MaxActiveUniversesCount;
		}
		int counter = 0;
		foreach (Showcase showcase in obj)
		{
			counter++;
			if (counter > showcaseAllotment)
			{
				showcase?.Delete();
			}
		}
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	public void Construct(ShowcaseDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"UserID:{UserID}_AssetID:{AssetID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"UserID:{UserID}_AssetID:{AssetID}");
		yield return new StateToken($"UserID:{UserID}");
	}
}
