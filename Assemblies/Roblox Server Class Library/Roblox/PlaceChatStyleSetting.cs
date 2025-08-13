using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.Properties;

namespace Roblox;

public class PlaceChatStyleSetting : IRobloxEntity<long, PlaceChatStyleSettingDAL>, ICacheableObject<long>, ICacheableObject
{
	private PlaceChatStyleSettingDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.PlaceChatStyleSetting", isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public long AssetID
	{
		get
		{
			return _EntityDAL.AssetID;
		}
		private set
		{
			_EntityDAL.AssetID = value;
		}
	}

	public byte PlaceChatStyleTypeID
	{
		get
		{
			return _EntityDAL.PlaceChatStyleTypeID;
		}
		set
		{
			_EntityDAL.PlaceChatStyleTypeID = value;
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

	public static bool IsBubbleChatEnabled => Settings.Default.IsBubbleChatEnabled;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public PlaceChatStyleSetting()
	{
		_EntityDAL = new PlaceChatStyleSettingDAL();
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

	public static PlaceChatStyleSetting Get(long id)
	{
		return EntityHelper.GetEntity<long, PlaceChatStyleSettingDAL, PlaceChatStyleSetting>(EntityCacheInfo, id, () => PlaceChatStyleSettingDAL.Get(id));
	}

	public static PlaceChatStyleSetting GetByAssetID(long assetId)
	{
		return EntityHelper.GetEntityByLookup<long, PlaceChatStyleSettingDAL, PlaceChatStyleSetting>(EntityCacheInfo, $"AssetID:{assetId}", () => PlaceChatStyleSettingDAL.GetByAssetID(assetId));
	}

	public static PlaceChatStyleSetting CreateNew(long assetId, byte placeChatStyleTypeId)
	{
		PlaceChatStyleSetting placeChatStyleSetting = new PlaceChatStyleSetting();
		placeChatStyleSetting.AssetID = assetId;
		placeChatStyleSetting.PlaceChatStyleTypeID = placeChatStyleTypeId;
		placeChatStyleSetting.Save();
		return placeChatStyleSetting;
	}

	public void Construct(PlaceChatStyleSettingDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"AssetID:{AssetID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
