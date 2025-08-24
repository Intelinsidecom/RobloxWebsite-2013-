using System;
using System.Collections.Generic;
using System.ComponentModel;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Moderation;

[DataObject]
public class AbuseType : IRobloxEntity<byte, AbuseTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	private AbuseTypeDAL _EntityDAL;

	public static readonly byte NoneID;

	public static readonly byte ProfanityID;

	public static readonly byte HarassmentID;

	public static readonly byte SpamID;

	public static readonly byte AdvertisementID;

	public static readonly byte ScammingID;

	public static readonly byte AdultContentID;

	public static readonly byte InappropriateID;

	public static readonly byte PrivacyID;

	public static readonly byte UnclassifiedMildID;

	public static readonly byte BlockedContentID;

	public static CacheInfo EntityCacheInfo;

	[DataObjectField(true, true, false)]
	public byte ID => _EntityDAL.ID;

	[DataObjectField(false, false, false)]
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

	[DataObjectField(false, false, false)]
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

	[DataObjectField(false, false, true)]
	public double? AutoReportThreshhold
	{
		get
		{
			return _EntityDAL.AutoReportThreshhold;
		}
		set
		{
			_EntityDAL.AutoReportThreshhold = value;
		}
	}

	[DataObjectField(false, false, true)]
	public double? AutoReviewThreshhold
	{
		get
		{
			return _EntityDAL.AutoReviewThreshhold;
		}
		set
		{
			_EntityDAL.AutoReviewThreshhold = value;
		}
	}

	[DataObjectField(false, false, true)]
	public double? AutoPunishThreshhold
	{
		get
		{
			return _EntityDAL.AutoPunishThreshhold;
		}
		set
		{
			_EntityDAL.AutoPunishThreshhold = value;
		}
	}

	[DataObjectField(false, false, false)]
	public byte MinimumPunishmentTypeID
	{
		get
		{
			return _EntityDAL.MinimumPunishmentTypeID;
		}
		set
		{
			_EntityDAL.MinimumPunishmentTypeID = value;
		}
	}

	[DataObjectField(false, false, false)]
	public byte MaximumPunishmentTypeID
	{
		get
		{
			return _EntityDAL.MaximumPunishmentTypeID;
		}
		set
		{
			_EntityDAL.MaximumPunishmentTypeID = value;
		}
	}

	[DataObjectField(false, false, false)]
	public double PunishmentStep
	{
		get
		{
			return _EntityDAL.PunishmentStep;
		}
		set
		{
			_EntityDAL.PunishmentStep = value;
		}
	}

	[DataObjectField(false, false, false)]
	public byte SeverityRank
	{
		get
		{
			return _EntityDAL.SeverityRank;
		}
		set
		{
			_EntityDAL.SeverityRank = value;
		}
	}

	[DataObjectField(false, false, false)]
	public DateTime Created => _EntityDAL.Created;

	[DataObjectField(false, false, false)]
	public DateTime Updated => _EntityDAL.Updated;

	public static AbuseType None => Get(NoneID);

	public static AbuseType Profanity => Get(ProfanityID);

	public static AbuseType Harassment => Get(HarassmentID);

	public static AbuseType Spam => Get(SpamID);

	public static AbuseType Advertisement => Get(AdvertisementID);

	public static AbuseType Scamming => Get(ScammingID);

	public static AbuseType AdultContent => Get(AdultContentID);

	public static AbuseType Inappropriate => Get(InappropriateID);

	public static AbuseType Privacy => Get(PrivacyID);

	public static AbuseType UnclassifiedMild => Get(UnclassifiedMildID);

	public static AbuseType BlockedContent => Get(BlockedContentID);

	public static ICollection<AbuseType> AllAbuseTypes => GetAbuseTypesPaged(0, GetTotalNumberOfAbuseTypes());

	public static IEnumerable<AbuseType> LimitedAbuseTypes
	{
		get
		{
			yield return None;
			yield return UnclassifiedMild;
			yield return Inappropriate;
			yield return AdultContent;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public AbuseType()
	{
		_EntityDAL = new AbuseTypeDAL();
	}

	static AbuseType()
	{
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "AbuseType", isNullCacheable: true);
		NoneID = Get("None").ID;
		ProfanityID = Get("Profanity").ID;
		HarassmentID = Get("Harassment").ID;
		SpamID = Get("Spam").ID;
		AdvertisementID = Get("Advertisement").ID;
		ScammingID = Get("Scamming").ID;
		AdultContentID = Get("Adult Content").ID;
		InappropriateID = Get("Inappropriate").ID;
		PrivacyID = Get("Privacy").ID;
		UnclassifiedMildID = Get("Unclassified Mild").ID;
		BlockedContentID = Get("BlockedContent").ID;
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

	[DataObjectMethod(DataObjectMethodType.Update)]
	public static void Update(byte id, string value, byte sortOrder, double? autoReportThreshhold, double? autoReviewThreshhold, double? autoPunishThreshhold, byte minimumPunishmentTypeID, byte maximumPunishmentTypeID, double punishmentStep, byte severityRank)
	{
		AbuseType abuseType = Get(id);
		abuseType.Value = value;
		abuseType.SortOrder = sortOrder;
		abuseType.AutoReportThreshhold = autoReportThreshhold;
		abuseType.AutoReviewThreshhold = autoReviewThreshhold;
		abuseType.AutoPunishThreshhold = autoPunishThreshhold;
		abuseType.MinimumPunishmentTypeID = minimumPunishmentTypeID;
		abuseType.MaximumPunishmentTypeID = maximumPunishmentTypeID;
		abuseType.PunishmentStep = punishmentStep;
		abuseType.SeverityRank = severityRank;
		abuseType.Save();
	}

	private static AbuseType DoGet(byte id)
	{
		return EntityHelper.DoGet<byte, AbuseTypeDAL, AbuseType>(() => AbuseTypeDAL.Get(id), id);
	}

	private static AbuseType DoGet(string value)
	{
		return EntityHelper.DoGetByLookup<byte, AbuseTypeDAL, AbuseType>(() => AbuseTypeDAL.Get(value), value);
	}

	public static AbuseType CreateNew(string value, PunishmentType minimumPunishment, PunishmentType maximumPunishment, double punishmentStep)
	{
		AbuseType abuseType = new AbuseType();
		abuseType.Value = value;
		abuseType.MinimumPunishmentTypeID = minimumPunishment.ID;
		abuseType.MaximumPunishmentTypeID = maximumPunishment.ID;
		abuseType.PunishmentStep = punishmentStep;
		abuseType.Save();
		return abuseType;
	}

	public static AbuseType Get(byte id)
	{
		return EntityHelper.GetEntityOld(EntityCacheInfo, id, () => DoGet(id));
	}

	public static AbuseType Get(byte? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	public static AbuseType Get(string value)
	{
		return EntityHelper.GetEntityByLookupOld<byte, AbuseType>(EntityCacheInfo, value, () => DoGet(value));
	}

	public static ICollection<AbuseType> GetAbuseTypesPaged(int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetAbuseTypesPaged_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.UnqualifiedNonExpiringCachePolicy, collectionId, () => AbuseTypeDAL.GetAbuseTypeIDsPaged(startRowIndex + 1, maximumRows), Get);
	}

	public static int GetTotalNumberOfAbuseTypes()
	{
		return EntityHelper.GetEntityCount(EntityCacheInfo, CacheManager.UnqualifiedNonExpiringCachePolicy, "GetTotalNumberOfAbuseTypes", AbuseTypeDAL.GetTotalNumberOfAbuseTypes);
	}

	public void Construct(AbuseTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return Value;
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
