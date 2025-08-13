using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.Web.ElevatedActions.Base;
using Roblox.Web.ElevatedActions.DAL;

namespace Roblox.Web.ElevatedActions.BLL;

public class RoleSetElevatedAction : IRobloxEntity<int, RoleSetElevatedActionDAL>, ICacheableObject<int>, ICacheableObject, IRoleSetElevatedAction
{
	private RoleSetElevatedActionDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.Web.ElevatedActions.BLL.RoleSetElevatedAction", isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	public int RoleSetID
	{
		get
		{
			return _EntityDAL.RoleSetID;
		}
		set
		{
			_EntityDAL.RoleSetID = value;
		}
	}

	public int ElevatedActionID
	{
		get
		{
			return _EntityDAL.ElevatedActionID;
		}
		set
		{
			_EntityDAL.ElevatedActionID = value;
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

	public RoleSetElevatedAction()
	{
		_EntityDAL = new RoleSetElevatedActionDAL();
	}

	public void Save()
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

	public void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	public static RoleSetElevatedAction CreateNew(int roleSetId, int elevatedActionId)
	{
		RoleSetElevatedAction roleSetElevatedAction = new RoleSetElevatedAction();
		roleSetElevatedAction.RoleSetID = roleSetId;
		roleSetElevatedAction.ElevatedActionID = elevatedActionId;
		roleSetElevatedAction.Save();
		return roleSetElevatedAction;
	}

	public static RoleSetElevatedAction Get(int id)
	{
		return EntityHelper.GetEntity<int, RoleSetElevatedActionDAL, RoleSetElevatedAction>(EntityCacheInfo, id, () => RoleSetElevatedActionDAL.Get(id));
	}

	public static RoleSetElevatedAction Get(int roleSetId, int elevatedActionId)
	{
		return EntityHelper.GetEntityByLookup<int, RoleSetElevatedActionDAL, RoleSetElevatedAction>(EntityCacheInfo, $"RoleSetID:{roleSetId}_ElevatedActionID:{elevatedActionId}", () => RoleSetElevatedActionDAL.Get(roleSetId, elevatedActionId));
	}

	public static ICollection<RoleSetElevatedAction> GetRoleSetElevatedActionsByRoleSetID(int roleSetId)
	{
		string collectionId = $"GetRoleSetElevatedActionsByRoleSetID_RoleSetID:{roleSetId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"RoleSetID:{roleSetId}"), collectionId, () => RoleSetElevatedActionDAL.GetRoleSetElevatedActionIDsByRoleSetID(roleSetId), Get);
	}

	public void Construct(RoleSetElevatedActionDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"RoleSetID:{RoleSetID}_ElevatedActionID:{ElevatedActionID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"RoleSetID:{RoleSetID}");
	}
}
