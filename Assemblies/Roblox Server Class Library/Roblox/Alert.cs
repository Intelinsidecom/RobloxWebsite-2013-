using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox;

public class Alert : IRobloxEntity<int, AlertDAL>, ICacheableObject<int>, ICacheableObject
{
	private AlertDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.Alert", isNullCacheable: true);

	public int ID => _EntityDAL.ID;

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

	public User User
	{
		get
		{
			return User.Get(UserID);
		}
		set
		{
			if (value != null)
			{
				UserID = value.ID;
			}
			else
			{
				UserID = 0L;
			}
		}
	}

	public string Text
	{
		get
		{
			return _EntityDAL.Text;
		}
		set
		{
			_EntityDAL.Text = value;
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

	public int VisibilityTypeID
	{
		get
		{
			return _EntityDAL.VisibilityTypeID;
		}
		set
		{
			_EntityDAL.VisibilityTypeID = value;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public Alert()
	{
		_EntityDAL = new AlertDAL();
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

	public static Alert CreateNew(long userid, string text, AlertVisibilityType visibilityType)
	{
		Alert alert = new Alert();
		alert.UserID = userid;
		alert.Text = text;
		alert.VisibilityTypeID = visibilityType.ID;
		alert.Save();
		return alert;
	}

	public static Alert Get(int id)
	{
		return EntityHelper.GetEntity<int, AlertDAL, Alert>(EntityCacheInfo, id, () => AlertDAL.Get(id));
	}

	public static ICollection<Alert> GetMostRecentAlertsPaged(int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetMostRecentAlertsPaged_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.UnqualifiedNonExpiringCachePolicy, collectionId, () => AlertDAL.GetMostRecentIDsPaged(startRowIndex + 1, maximumRows), Get);
	}

	public static Alert GetLast()
	{
		List<Alert> mostRecent = new List<Alert>(GetMostRecentAlertsPaged(0, 1));
		if (mostRecent.Count > 0)
		{
			return mostRecent[0];
		}
		return null;
	}

	public void Construct(AlertDAL dal)
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
