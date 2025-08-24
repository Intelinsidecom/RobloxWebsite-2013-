using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Moderation;

public class InGameReportContext : IRobloxEntity<long, InGameReportContextDAL>, ICacheableObject<long>, ICacheableObject, IInGameReportContext, IReportContext
{
	private InGameReportContextDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(InGameReportContext).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public long PlaceID
	{
		get
		{
			return _EntityDAL.PlaceID;
		}
		set
		{
			_EntityDAL.PlaceID = value;
		}
	}

	public long UniverseID
	{
		get
		{
			return _EntityDAL.UniverseID;
		}
		set
		{
			_EntityDAL.UniverseID = value;
		}
	}

	public Guid GameInstanceID
	{
		get
		{
			return _EntityDAL.GameInstanceID;
		}
		set
		{
			_EntityDAL.GameInstanceID = value;
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

	public InGameReportContext()
	{
		_EntityDAL = new InGameReportContextDAL();
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

	internal static InGameReportContext CreateNew(long placeID, long universeID, Guid gameinstanceID)
	{
		InGameReportContext inGameReportContext = new InGameReportContext();
		inGameReportContext.PlaceID = placeID;
		inGameReportContext.UniverseID = universeID;
		inGameReportContext.GameInstanceID = gameinstanceID;
		inGameReportContext.Save();
		return inGameReportContext;
	}

	internal static InGameReportContext Get(long id)
	{
		return EntityHelper.GetEntity<long, InGameReportContextDAL, InGameReportContext>(EntityCacheInfo, id, () => InGameReportContextDAL.Get(id));
	}

	internal static InGameReportContext GetOrCreate(long placeID, long universeID, Guid gameinstanceID)
	{
		return EntityHelper.GetOrCreateEntity<long, InGameReportContext>(EntityCacheInfo, $"PlaceID:{placeID}_UniverseID:{universeID}_GameInstanceID:{gameinstanceID}", () => DoGetOrCreate(placeID, universeID, gameinstanceID));
	}

	private static InGameReportContext DoGetOrCreate(long placeID, long universeID, Guid gameinstanceID)
	{
		return EntityHelper.DoGetOrCreate<long, InGameReportContextDAL, InGameReportContext>(() => InGameReportContextDAL.GetOrCreate(placeID, universeID, gameinstanceID));
	}

	public void Construct(InGameReportContextDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return $"PlaceID:{PlaceID}_UniverseID:{UniverseID}_GameInstanceID:{GameInstanceID}";
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
