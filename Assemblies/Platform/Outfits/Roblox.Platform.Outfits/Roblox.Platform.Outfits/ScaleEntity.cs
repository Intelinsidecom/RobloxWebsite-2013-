using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Outfits;

internal class ScaleEntity : IRobloxEntity<int, ScaleDAL>, ICacheableObject<int>, ICacheableObject, IRemoteCacheableObject
{
	private ScaleDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), "Roblox.Platform.Avatar.Scale", isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	internal decimal Height
	{
		get
		{
			return _EntityDAL.Height;
		}
		set
		{
			_EntityDAL.Height = value;
		}
	}

	internal decimal Width
	{
		get
		{
			return _EntityDAL.Width;
		}
		set
		{
			_EntityDAL.Width = value;
		}
	}

	internal decimal Head
	{
		get
		{
			return _EntityDAL.Head;
		}
		set
		{
			_EntityDAL.Head = value;
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

	internal decimal Proportion
	{
		get
		{
			return _EntityDAL.Proportion ?? 0.00m;
		}
		set
		{
			_EntityDAL.Proportion = value;
		}
	}

	internal decimal BodyType
	{
		get
		{
			return _EntityDAL.BodyType ?? 0.00m;
		}
		set
		{
			_EntityDAL.BodyType = value;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public ScaleEntity()
	{
		_EntityDAL = new ScaleDAL();
	}

	public ScaleEntity(ScaleDAL scaleDAL)
	{
		_EntityDAL = scaleDAL;
	}

	internal void Delete()
	{
		EntityHelper.DeleteEntityWithRemoteCache(this, _EntityDAL.Delete);
	}

	internal void Save()
	{
		EntityHelper.SaveEntityWithRemoteCache(this, delegate
		{
			_EntityDAL.Created = DateTime.Now;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Update();
		});
	}

	internal static ScaleEntity Get(int id)
	{
		return EntityHelper.GetEntity<int, ScaleDAL, ScaleEntity>(EntityCacheInfo, id, () => ScaleDAL.Get(id));
	}

	private static ICollection<ScaleEntity> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.MultiGetEntity<int, ScaleDAL, ScaleEntity>(ids, EntityCacheInfo, ScaleDAL.MultiGet);
	}

	public static ScaleEntity GetOrCreate(decimal height, decimal width, decimal head, decimal proportion, decimal bodyType)
	{
		return EntityHelper.GetOrCreateEntityWithRemoteCache<int, ScaleEntity>(EntityCacheInfo, GetLookupCacheKeys(height, width, head, proportion, bodyType), () => DoGetOrCreate(height, width, head, proportion, bodyType), Get);
	}

	private static ScaleEntity DoGetOrCreate(decimal height, decimal width, decimal head, decimal proportion, decimal bodyType)
	{
		return EntityHelper.DoGetOrCreate<int, ScaleDAL, ScaleEntity>(() => ScaleDAL.GetOrCreateScale(height, width, head, proportion, bodyType));
	}

	public void Construct(ScaleDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeys(Height, Width, Head, Proportion, BodyType);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	private static string GetLookupCacheKeys(decimal height, decimal width, decimal head, decimal proportion, decimal bodyType)
	{
		return $"Height:{height:0.00}_Width:{width:0.00}_Head:{head:0.00}_Proportion:{proportion:0.00}_BodyType:{bodyType:0.00}";
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}
}
