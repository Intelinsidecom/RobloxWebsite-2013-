using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.DataAccess;

namespace Roblox;

[Serializable]
public class BadgeType : IRobloxEntity<int, BadgeTypeDAL>, ICacheableObject<int>, ICacheableObject, IRemoteCacheableObject
{
	private BadgeTypeDAL _EntityDAL;

	public static readonly int BuildersClubID;

	public const string BuildersClubValue = "Builders Club";

	public static readonly int TurboBuildersClubID;

	public const string TurboBuildersClubValue = "Turbo Builders Club";

	public static readonly int OutrageousBuildersClubID;

	public const string OutrageousBuildersClubValue = "Outrageous Builders Club";

	public static readonly int WelcomeToTheClubID;

	public const string OfficialModelMakerValue = "Official Model Maker";

	public static readonly int OfficialModelMakerID;

	public const string WelcomeToTheClubValue = "Welcome To The Club";

	public static readonly int AdministratorID;

	public const string AdministratorValue = "Administrator";

	public static readonly int FriendshipID;

	public const string FriendshipValue = "Friendship";

	public static readonly int HomesteadID;

	public const string HomesteadValue = "Homestead";

	public static readonly int BricksmithID;

	public const string BricksmithValue = "Bricksmith";

	public static readonly int VeteranID;

	public const string VeteranValue = "Veteran";

	public static readonly int AmbassadorID;

	public const string AmbassadorValue = "Ambassador";

	public static readonly int InviterID;

	public const string InviterValue = "Inviter";

	public static readonly int CombatInitiationID;

	public const string CombatInitiationValue = "Combat Initiation";

	public static readonly int WarriorID;

	public const string WarriorValue = "Warrior";

	public static readonly int BloxxerID;

	public const string BloxxerValue = "Bloxxer";

	public static CacheInfo EntityCacheInfo;

	public int ID
	{
		get
		{
			return _EntityDAL.ID;
		}
		set
		{
			_EntityDAL.ID = value;
		}
	}

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

	public string Description
	{
		get
		{
			return _EntityDAL.Description;
		}
		set
		{
			_EntityDAL.Description = value;
		}
	}

	public string Abbreviation
	{
		get
		{
			return _EntityDAL.Abbreviation;
		}
		set
		{
			_EntityDAL.Abbreviation = value;
		}
	}

	public string ImageName
	{
		get
		{
			return _EntityDAL.ImageName;
		}
		set
		{
			_EntityDAL.ImageName = value;
		}
	}

	public DateTime Created => _EntityDAL.Created;

	public DateTime Updated => _EntityDAL.Updated;

	public bool IsAnyBuildersClub
	{
		get
		{
			if (ID != BuildersClubID && ID != TurboBuildersClubID)
			{
				return ID == OutrageousBuildersClubID;
			}
			return true;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public BadgeType(BadgeTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public BadgeType()
	{
		_EntityDAL = new BadgeTypeDAL();
	}

	static BadgeType()
	{
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true), "BadgeType", isNullCacheable: true);
		BuildersClubID = Get("Builders Club").ID;
		TurboBuildersClubID = Get("Turbo Builders Club").ID;
		OutrageousBuildersClubID = Get("Outrageous Builders Club").ID;
		OfficialModelMakerID = Get("Official Model Maker").ID;
		WelcomeToTheClubID = Get("Welcome To The Club").ID;
		AdministratorID = Get("Administrator").ID;
		FriendshipID = Get("Friendship").ID;
		HomesteadID = Get("Homestead").ID;
		BricksmithID = Get("Bricksmith").ID;
		VeteranID = Get("Veteran").ID;
		AmbassadorID = Get("Ambassador").ID;
		InviterID = Get("Inviter").ID;
		CombatInitiationID = Get("Combat Initiation").ID;
		WarriorID = Get("Warrior").ID;
		BloxxerID = Get("Bloxxer").ID;
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

	public static BadgeType Get(int id)
	{
		return EntityHelper.GetEntity<int, BadgeTypeDAL, BadgeType>(EntityCacheInfo, id, () => BadgeTypeDAL.Get(id));
	}

	public static BadgeType Get(string value)
	{
		if (string.IsNullOrWhiteSpace(value))
		{
			return null;
		}
		return EntityHelper.GetEntityByLookup<int, BadgeTypeDAL, BadgeType>(EntityCacheInfo, "Value:" + value, () => BadgeTypeDAL.Get(value));
	}

	public static BadgeType Get(int? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	public static ICollection<BadgeType> GetBadgeTypes()
	{
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.UnqualifiedNonExpiringCachePolicy, "GetBadgeTypes", BadgeTypeDAL.GetBadgeTypeIDs, Get);
	}

	public static BadgeType Register(string value, string description)
	{
		BadgeType t;
		if (BadgeTypeDAL.Get(value) != null)
		{
			t = Get(value);
		}
		else
		{
			t = new BadgeType
			{
				Value = value,
				Description = description
			};
			t.Save();
		}
		return t;
	}

	public void Construct(BadgeTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return "Value:" + Value;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}
}
