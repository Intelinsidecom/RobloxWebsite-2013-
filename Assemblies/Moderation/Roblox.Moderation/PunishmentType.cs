using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Moderation;

public class PunishmentType : IRobloxEntity<byte, PunishmentTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	private PunishmentTypeDAL _EntityDAL;

	public static readonly PunishmentType None;

	public static readonly PunishmentType Remind;

	public static readonly PunishmentType Warn;

	public static readonly PunishmentType Ban1Day;

	public static readonly PunishmentType Ban3Days;

	public static readonly PunishmentType Ban7Days;

	public static readonly PunishmentType Ban14Days;

	public static readonly PunishmentType DeleteAccount;

	public static readonly PunishmentType MACBanAccount;

	public static readonly PunishmentType PoisonMachine;

	public static readonly PunishmentType MinActivePunishment;

	public static readonly ICollection<PunishmentType> AllPunishmentTypes;

	public static CacheInfo EntityCacheInfo;

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

	public byte AccountStatusID
	{
		get
		{
			return _EntityDAL.AccountStatusID;
		}
		set
		{
			_EntityDAL.AccountStatusID = value;
		}
	}

	public byte? DurationInDays
	{
		get
		{
			return _EntityDAL.DurationInDays;
		}
		set
		{
			_EntityDAL.DurationInDays = value;
		}
	}

	public byte SortOrder
	{
		get
		{
			return _EntityDAL.SortOrder;
		}
		set
		{
			_EntityDAL.SortOrder = value;
		}
	}

	public string IconName
	{
		get
		{
			return _EntityDAL.IconName;
		}
		set
		{
			_EntityDAL.IconName = value;
		}
	}

	public DateTime Created => _EntityDAL.Created;

	public DateTime Updated => _EntityDAL.Updated;

	public bool IsActive
	{
		get
		{
			if (_EntityDAL.IsActive.HasValue)
			{
				return _EntityDAL.IsActive.Value;
			}
			return false;
		}
		set
		{
			_EntityDAL.IsActive = value;
		}
	}

	public byte SeverityRank
	{
		get
		{
			if (!_EntityDAL.SeverityRank.HasValue)
			{
				return 0;
			}
			return _EntityDAL.SeverityRank.Value;
		}
		set
		{
			_EntityDAL.SeverityRank = value;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public PunishmentType()
	{
		_EntityDAL = new PunishmentTypeDAL();
	}

	static PunishmentType()
	{
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "PunishmentType", isNullCacheable: true);
		None = Get("None");
		Remind = Get("Remind");
		Warn = Get("Warn");
		Ban1Day = Get("Ban 1 Day");
		Ban3Days = Get("Ban 3 Days");
		Ban7Days = Get("Ban 7 Days");
		Ban14Days = Get("Ban 14 Days");
		DeleteAccount = Get("Delete");
		MACBanAccount = Get("MAC Ban");
		PoisonMachine = Get("Poison");
		AllPunishmentTypes = GetPunishmentTypesPaged(0, GetTotalNumberOfPunishmentTypes());
		MinActivePunishment = (from pt in AllPunishmentTypes
			orderby pt.SeverityRank, pt.SortOrder
			select pt).First((PunishmentType pt) => pt.IsActive);
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

	private static PunishmentType DoGet(byte id)
	{
		return EntityHelper.DoGet<byte, PunishmentTypeDAL, PunishmentType>(() => PunishmentTypeDAL.Get(id), id);
	}

	private static PunishmentType DoGet(string value)
	{
		return EntityHelper.DoGetByLookup<byte, PunishmentTypeDAL, PunishmentType>(() => PunishmentTypeDAL.Get(value), value);
	}

	public static PunishmentType CreateNew(string value, byte accountStatusId, byte? durationInDays, string iconName)
	{
		PunishmentType punishmentType = new PunishmentType();
		punishmentType.Value = value;
		punishmentType.AccountStatusID = accountStatusId;
		punishmentType.DurationInDays = durationInDays;
		punishmentType.IconName = iconName;
		punishmentType.Save();
		return punishmentType;
	}

	public static PunishmentType Get(byte id)
	{
		return EntityHelper.GetEntityOld(EntityCacheInfo, id, () => DoGet(id));
	}

	public static PunishmentType Get(byte? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	public static PunishmentType Get(string value)
	{
		return EntityHelper.GetEntityByLookupOld<byte, PunishmentType>(EntityCacheInfo, value, () => DoGet(value));
	}

	public static ICollection<PunishmentType> GetPunishmentTypesPaged(int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetPunishmentTypesPaged_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.UnqualifiedNonExpiringCachePolicy, collectionId, () => PunishmentTypeDAL.GetPunishmentTypeIDsPaged(startRowIndex + 1, maximumRows), Get);
	}

	public static int GetTotalNumberOfPunishmentTypes()
	{
		return EntityHelper.GetEntityCount(EntityCacheInfo, CacheManager.UnqualifiedNonExpiringCachePolicy, "GetTotalNumberOfPunishmentTypes", PunishmentTypeDAL.GetTotalNumberOfPunishmentTypes);
	}

	public static PunishmentType GetWorsePunishmentType(PunishmentType currentType, PunishmentType defaultType)
	{
		return GetWorsePunishmentType(currentType) ?? defaultType;
	}

	public static PunishmentType GetWorsePunishmentType(PunishmentType currentType)
	{
		return (from pt in AllPunishmentTypes
			orderby pt.SeverityRank, pt.SortOrder
			select pt).FirstOrDefault((PunishmentType pt) => pt.IsActive && pt.SeverityRank > currentType.SeverityRank);
	}

	public static PunishmentType GetWeakerPunishmentType(PunishmentType currentType, PunishmentType defaultType)
	{
		return GetWeakerPunishmentType(currentType) ?? defaultType;
	}

	public static PunishmentType GetWeakerPunishmentType(PunishmentType currentType)
	{
		return (from pt in AllPunishmentTypes
			orderby pt.SeverityRank descending, pt.SortOrder
			select pt).FirstOrDefault((PunishmentType pt) => pt.IsActive && pt.SeverityRank < currentType.SeverityRank);
	}

	public void Construct(PunishmentTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		ICollection<string> idLookups = new List<string>();
		if (_EntityDAL != null)
		{
			idLookups.Add(Value);
		}
		return idLookups;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
