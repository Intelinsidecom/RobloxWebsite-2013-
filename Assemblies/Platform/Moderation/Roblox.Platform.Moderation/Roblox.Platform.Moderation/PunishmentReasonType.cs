using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Moderation;

public class PunishmentReasonType : IRobloxEntity<byte, PunishmentReasonTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	private PunishmentReasonTypeDAL _EntityDAL;

	public static readonly byte OtherID;

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

	public static ICollection<PunishmentReasonType> AllPunishmentReasonTypes => GetAllActivePunishmentReasonTypes();

	public static PunishmentReasonType Other => Get(OtherID);

	public CacheInfo CacheInfo => EntityCacheInfo;

	public PunishmentReasonType()
	{
		_EntityDAL = new PunishmentReasonTypeDAL();
	}

	static PunishmentReasonType()
	{
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), typeof(PunishmentReasonType).ToString(), isNullCacheable: true);
		OtherID = GetByValue("Other").ID;
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

	private static PunishmentReasonType CreateNew(string value)
	{
		PunishmentReasonType punishmentReasonType = new PunishmentReasonType();
		punishmentReasonType.Value = value;
		punishmentReasonType.Save();
		return punishmentReasonType;
	}

	internal static PunishmentReasonType Get(byte id)
	{
		return EntityHelper.GetEntity<byte, PunishmentReasonTypeDAL, PunishmentReasonType>(EntityCacheInfo, id, () => PunishmentReasonTypeDAL.Get(id));
	}

	public static PunishmentReasonType GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<byte, PunishmentReasonTypeDAL, PunishmentReasonType>(EntityCacheInfo, value, () => PunishmentReasonTypeDAL.GetByValue(value));
	}

	public static ICollection<PunishmentReasonType> GetAllActivePunishmentReasonTypes()
	{
		return (from reason in GetPunishmentReasonTypesPaged(0, GetTotalNumberOfPunishmentReasonTypes())
			where reason.Value != "Hate Speech"
			select reason).ToList();
	}

	public static ICollection<PunishmentReasonType> GetPunishmentReasonTypesPaged(int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetPunishmentReasonTypesPaged_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.UnqualifiedNonExpiringCachePolicy, collectionId, () => PunishmentReasonTypeDAL.GetPunishmentReasonTypeIDsPaged(startRowIndex + 1, maximumRows), Get);
	}

	public static int GetTotalNumberOfPunishmentReasonTypes()
	{
		return EntityHelper.GetEntityCount(EntityCacheInfo, CacheManager.UnqualifiedNonExpiringCachePolicy, "GetTotalNumberOfPunishmentReasonTypes", PunishmentReasonTypeDAL.GetTotalNumberOfPunishmentReasonTypes);
	}

	public void Construct(PunishmentReasonTypeDAL dal)
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
