using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.Marketing.DAL;

namespace Roblox.Marketing.BLL;

public class WoMUserAcquisitionSourceType : IRobloxEntity<byte, WoMUserAcquisitionSourceTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	private WoMUserAcquisitionSourceTypeDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), typeof(WoMUserAcquisitionSourceType).ToString(), isNullCacheable: true);

	public byte ID => _EntityDAL.ID;

	public string Value
	{
		get
		{
			return _EntityDAL.Value;
		}
		set
		{
			_EntityDAL.Value = value;
		}
	}

	internal bool IsActive
	{
		get
		{
			return _EntityDAL.IsActive;
		}
		set
		{
			_EntityDAL.IsActive = value;
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

	public WoMUserAcquisitionSourceType()
	{
		_EntityDAL = new WoMUserAcquisitionSourceTypeDAL();
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

	private static WoMUserAcquisitionSourceType CreateNew(string value, bool isactive)
	{
		WoMUserAcquisitionSourceType woMUserAcquisitionSourceType = new WoMUserAcquisitionSourceType();
		woMUserAcquisitionSourceType.Value = value;
		woMUserAcquisitionSourceType.IsActive = isactive;
		woMUserAcquisitionSourceType.Save();
		return woMUserAcquisitionSourceType;
	}

	public static WoMUserAcquisitionSourceType Get(byte id)
	{
		return EntityHelper.GetEntity<byte, WoMUserAcquisitionSourceTypeDAL, WoMUserAcquisitionSourceType>(EntityCacheInfo, id, () => WoMUserAcquisitionSourceTypeDAL.Get(id));
	}

	public static ICollection<WoMUserAcquisitionSourceType> GetActiveWoMUserAcquisitionSourceTypes(byte startRowIndex, byte maximumRows)
	{
		string collectionId = $"GetActiveWoMUserAcquisitionSourceTypes_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Unqualified, null), collectionId, () => WoMUserAcquisitionSourceTypeDAL.GetActiveWoMUserAcquisitionSourceTypeIDsPaged((byte)(startRowIndex + 1), maximumRows), Get);
	}

	public void Construct(WoMUserAcquisitionSourceTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
