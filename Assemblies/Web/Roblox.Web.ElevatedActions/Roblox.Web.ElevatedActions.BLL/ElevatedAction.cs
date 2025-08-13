using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.Web.ElevatedActions.Base;
using Roblox.Web.ElevatedActions.DAL;

namespace Roblox.Web.ElevatedActions.BLL;

public class ElevatedAction : IRobloxEntity<int, ElevatedActionDAL>, ICacheableObject<int>, ICacheableObject, IElevatedAction
{
	private ElevatedActionDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.Properties.Settings.ElevatedAction", isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	public string Name => _EntityDAL.Name;

	public string Description => _EntityDAL.Description;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public ElevatedAction()
	{
		_EntityDAL = new ElevatedActionDAL();
	}

	private static ElevatedAction Get(int id)
	{
		return EntityHelper.GetEntity<int, ElevatedActionDAL, ElevatedAction>(EntityCacheInfo, id, () => ElevatedActionDAL.Get(id));
	}

	public static ElevatedAction Get(string name)
	{
		return EntityHelper.GetEntityByLookup<int, ElevatedActionDAL, ElevatedAction>(EntityCacheInfo, $"Name:{name}", () => ElevatedActionDAL.Get(name));
	}

	public static ICollection<ElevatedAction> GetAllElevatedActions()
	{
		string collectionId = "GetAllElevatedActions";
		string cachedStateQualifier = "GetAllElevatedActions";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(cachedStateQualifier), collectionId, ElevatedActionDAL.GetAllElevatedActionIDs, Get);
	}

	public void Construct(ElevatedActionDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"Name:{Name}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken("GetAllElevatedActions");
	}
}
