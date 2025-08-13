using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Studio.Entities;

internal class ToolboxSearchAlgorithm : IRobloxEntity<int, ToolboxSearchAlgorithmDAL>, ICacheableObject<int>, ICacheableObject
{
	private ToolboxSearchAlgorithmDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(ToolboxSearchAlgorithm).ToString(), isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	internal string Name
	{
		get
		{
			return _EntityDAL.Name;
		}
		set
		{
			_EntityDAL.Name = value;
		}
	}

	internal string Desciption
	{
		get
		{
			return _EntityDAL.Desciption;
		}
		set
		{
			_EntityDAL.Desciption = value;
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

	public ToolboxSearchAlgorithm()
	{
		_EntityDAL = new ToolboxSearchAlgorithmDAL();
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

	public static ToolboxSearchAlgorithm GetByName(string name)
	{
		return EntityHelper.GetEntityByLookup<int, ToolboxSearchAlgorithmDAL, ToolboxSearchAlgorithm>(EntityCacheInfo, GetLookupCacheKeysByName(name), () => ToolboxSearchAlgorithmDAL.GetToolboxSearchAlgorithmByName(name));
	}

	internal static ToolboxSearchAlgorithm Get(int id)
	{
		return EntityHelper.GetEntity<int, ToolboxSearchAlgorithmDAL, ToolboxSearchAlgorithm>(EntityCacheInfo, id, () => ToolboxSearchAlgorithmDAL.Get(id));
	}

	private static ICollection<ToolboxSearchAlgorithm> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.MultiGetEntity<int, ToolboxSearchAlgorithmDAL, ToolboxSearchAlgorithm>(ids, EntityCacheInfo, ToolboxSearchAlgorithmDAL.MultiGet);
	}

	internal static ICollection<ToolboxSearchAlgorithm> GetToolboxSearchAlgorithmsPaged(int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetToolboxSearchAlgorithmsPaged_ToolboxSearchAlgorithms_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysAll()), collectionId, () => ToolboxSearchAlgorithmDAL.GetToolboxSearchAlgorithmIDsPaged(startRowIndex + 1, maximumRows), MultiGet);
	}

	public void Construct(ToolboxSearchAlgorithmDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeysByName(Name);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken(GetLookupCacheKeysAll());
	}

	private static string GetLookupCacheKeysByName(string name)
	{
		return $"Name:{name}";
	}

	private static string GetLookupCacheKeysAll()
	{
		return $"GetAll";
	}
}
