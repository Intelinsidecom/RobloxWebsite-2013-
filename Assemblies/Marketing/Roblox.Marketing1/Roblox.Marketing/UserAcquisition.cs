using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Marketing;

public class UserAcquisition : IRobloxEntity<long, UserAcquisitionDAL>, ICacheableObject<long>, ICacheableObject
{
	private UserAcquisitionDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.Marketing.UserAcquisition", isNullCacheable: true);

	public long ID => _EntityDAL.ID;

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

	public string AcquisitionMedium
	{
		get
		{
			return _EntityDAL.AcquisitionMedium;
		}
		set
		{
			_EntityDAL.AcquisitionMedium = value;
		}
	}

	public string AcquisitionSource
	{
		get
		{
			return _EntityDAL.AcquisitionSource;
		}
		set
		{
			_EntityDAL.AcquisitionSource = value;
		}
	}

	public string AcquisitionCampaign
	{
		get
		{
			return _EntityDAL.AcquisitionCampaign;
		}
		set
		{
			_EntityDAL.AcquisitionCampaign = value;
		}
	}

	public DateTime? AcquisitionTime
	{
		get
		{
			return _EntityDAL.AcquisitionTime;
		}
		set
		{
			_EntityDAL.AcquisitionTime = value;
		}
	}

	public string AcquisitionReferrer
	{
		get
		{
			return _EntityDAL.AcquisitionReferrer;
		}
		set
		{
			_EntityDAL.AcquisitionReferrer = value;
		}
	}

	public string AcquisitionAdGroup
	{
		get
		{
			return _EntityDAL.AcquisitionAdGroup;
		}
		set
		{
			_EntityDAL.AcquisitionAdGroup = value;
		}
	}

	public string AcquisitionKeyword
	{
		get
		{
			return _EntityDAL.AcquisitionKeyword;
		}
		set
		{
			_EntityDAL.AcquisitionKeyword = value;
		}
	}

	public string AcquisitionMatchType
	{
		get
		{
			return _EntityDAL.AcquisitionMatchType;
		}
		set
		{
			_EntityDAL.AcquisitionMatchType = value;
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

	public byte? PlatformTypeID
	{
		get
		{
			return _EntityDAL.PlatformTypeID;
		}
		set
		{
			_EntityDAL.PlatformTypeID = value;
		}
	}

	public byte? WoMUserAcquisitionSourceTypeID
	{
		get
		{
			return _EntityDAL.WoMUserAcquisitionSourceTypeID;
		}
		set
		{
			_EntityDAL.WoMUserAcquisitionSourceTypeID = value;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public UserAcquisition()
	{
		_EntityDAL = new UserAcquisitionDAL();
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

	public static UserAcquisition CreateNew(long userId, string acquisitionMedium, string acquisitionSource, string acquisitionCampaign, DateTime? acquisitionTime, string acquisitionReferrer, string acquisitionAdGroup, string acquisitionKeyword, string acquisitionMatchType, byte platformTypeId, byte? womUserAcquisitionSourceTypeID = null)
	{
		UserAcquisition userAcquisition = new UserAcquisition();
		userAcquisition.UserID = userId;
		userAcquisition.AcquisitionMedium = acquisitionMedium;
		userAcquisition.AcquisitionSource = acquisitionSource;
		userAcquisition.AcquisitionCampaign = acquisitionCampaign;
		userAcquisition.AcquisitionTime = acquisitionTime;
		userAcquisition.AcquisitionReferrer = acquisitionReferrer;
		userAcquisition.AcquisitionAdGroup = acquisitionAdGroup;
		userAcquisition.AcquisitionKeyword = acquisitionKeyword;
		userAcquisition.AcquisitionMatchType = acquisitionMatchType;
		userAcquisition.PlatformTypeID = platformTypeId;
		userAcquisition.WoMUserAcquisitionSourceTypeID = womUserAcquisitionSourceTypeID;
		userAcquisition.Save();
		return userAcquisition;
	}

	public static UserAcquisition Get(long id)
	{
		return EntityHelper.GetEntity<long, UserAcquisitionDAL, UserAcquisition>(EntityCacheInfo, id, () => UserAcquisitionDAL.Get(id));
	}

	public static UserAcquisition GetByUserID(long userId)
	{
		return EntityHelper.GetEntityByLookup<long, UserAcquisitionDAL, UserAcquisition>(EntityCacheInfo, $"UserID:{userId}", () => UserAcquisitionDAL.GetByUserID(userId));
	}

	public void Construct(UserAcquisitionDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"UserID:{UserID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
