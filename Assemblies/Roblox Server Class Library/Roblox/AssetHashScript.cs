using System;
using System.Collections.Generic;
using System.ComponentModel;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox;

[Serializable]
public class AssetHashScript : IEquatable<AssetHashScript>, IRobloxEntity<long, AssetHashScriptDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private AssetHashScriptDAL _EntityDAL;

	[DataObjectField(true, true)]
	public long ID => _EntityDAL.ID;

	[DataObjectField(false)]
	public int ScriptID
	{
		get
		{
			return _EntityDAL.ScriptID;
		}
		set
		{
			_EntityDAL.ScriptID = value;
		}
	}

	[DataObjectField(false, false, false)]
	public long AssetHashID
	{
		get
		{
			return _EntityDAL.AssetHashID;
		}
		set
		{
			_EntityDAL.AssetHashID = value;
		}
	}

	[DataObjectField(false)]
	public DateTime Created => _EntityDAL.Created;

	[DataObjectField(false)]
	public DateTime Updated => _EntityDAL.Updated;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public static CacheInfo EntityCacheInfo => new CacheInfo("AssetHashScript");

	public AssetHashScript()
	{
		_EntityDAL = new AssetHashScriptDAL();
	}

	public AssetHashScript(AssetHashScriptDAL dal)
	{
		_EntityDAL = dal;
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
			_EntityDAL.Updated = Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	private static AssetHashScript DoGetOrCreate(int scriptId, long assetHashId)
	{
		return EntityHelper.DoGetOrCreate<long, AssetHashScriptDAL, AssetHashScript>(() => AssetHashScriptDAL.GetOrCreate(scriptId, assetHashId));
	}

	public static AssetHashScript Get(long id)
	{
		return EntityHelper.GetEntity<long, AssetHashScriptDAL, AssetHashScript>(EntityCacheInfo, id, () => AssetHashScriptDAL.Get(id));
	}

	public static AssetHashScript GetOrCreate(int scriptId, long assetHashId)
	{
		return EntityHelper.GetOrCreateEntity<long, AssetHashScript>(EntityCacheInfo, $"ScriptID:{scriptId}_AssetHashID:{assetHashId}", () => DoGetOrCreate(scriptId, assetHashId));
	}

	public static ICollection<AssetHashScript> GetAssetHashScriptsByAssetHashIDPaged(long AssetHashID, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetAssetHashScriptsByAssetHashIDPaged_AssetHashID:{AssetHashID}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"AssetHashID:{AssetHashID}"), collectionId, () => AssetHashScriptDAL.GetAssetHashScriptIDsByAssetHashIDPaged(AssetHashID, startRowIndex + 1, maximumRows), Get);
	}

	public static ICollection<AssetHashScript> GetAssetHashScriptsByScriptIDPaged(int scriptId, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetAssetHashScriptsByScriptIDPaged_ScriptID:{scriptId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"ScriptID:{scriptId}"), collectionId, () => AssetHashScriptDAL.GetAssetHashScriptIDsByScriptIDPaged(scriptId, startRowIndex + 1, maximumRows), Get);
	}

	public static int GetTotalNumberOfAssetHashScriptsByAssetHashID(long AssetHashID)
	{
		if (AssetHashID == 0L)
		{
			return 0;
		}
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"AssetHashID:{AssetHashID}"), $"GetTotalNumberOfAssetHashScriptsByAssetHashID_AssetHashID:{AssetHashID}", () => AssetHashScriptDAL.GetTotalNumberOfAssetHashScriptsByAssetHashID(AssetHashID));
	}

	public static int GetTotalNumberOfAssetHashScriptsByScriptID(int ScriptID)
	{
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"ScriptID:{ScriptID}"), $"GetTotalNumberOfAssetHashScriptsByScriptID_ScriptID:{ScriptID}", () => AssetHashScriptDAL.GetTotalNumberOfAssetHashScriptsByScriptID(ScriptID));
	}

	public bool Equals(AssetHashScript other)
	{
		if (other == null)
		{
			return false;
		}
		return ID == other.ID;
	}

	public void Construct(AssetHashScriptDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"ScriptID:{ScriptID}_AssetHashID:{AssetHashID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		return new List<StateToken>
		{
			new StateToken($"ScriptID:{ScriptID}"),
			new StateToken($"AssetHashID:{AssetHashID}")
		};
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}
}
