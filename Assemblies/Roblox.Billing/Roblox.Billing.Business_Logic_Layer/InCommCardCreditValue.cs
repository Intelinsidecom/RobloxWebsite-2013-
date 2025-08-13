using System;
using System.Collections.Generic;
using Roblox.Billing.Data_Logic_Layer;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Billing.Business_Logic_Layer;

public class InCommCardCreditValue : IRobloxEntity<short, InCommCardCreditValueDAL>, ICacheableObject<short>, ICacheableObject
{
	private InCommCardCreditValueDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.Billing.Data_Logic_Layer.InCommCardCreditValue", isNullCacheable: true);

	public short ID => _EntityDAL.ID;

	public short InCommCardID
	{
		get
		{
			return _EntityDAL.InCommCardID;
		}
		set
		{
			_EntityDAL.InCommCardID = value;
		}
	}

	public decimal? CreditValue
	{
		get
		{
			return _EntityDAL.CreditValue;
		}
		set
		{
			_EntityDAL.CreditValue = value;
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

	public InCommCardCreditValue()
	{
		_EntityDAL = new InCommCardCreditValueDAL();
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

	public void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	public static InCommCardCreditValue CreateNew(short InCommCardId, decimal creditValue)
	{
		InCommCardCreditValue inCommCardCreditValue = new InCommCardCreditValue();
		inCommCardCreditValue.InCommCardID = InCommCardId;
		inCommCardCreditValue.CreditValue = creditValue;
		inCommCardCreditValue.Save();
		return inCommCardCreditValue;
	}

	public static InCommCardCreditValue Get(short id)
	{
		return EntityHelper.GetEntity<short, InCommCardCreditValueDAL, InCommCardCreditValue>(EntityCacheInfo, id, () => InCommCardCreditValueDAL.Get(id));
	}

	public static InCommCardCreditValue GetOrCreate(short inCommCardId)
	{
		return EntityHelper.GetOrCreateEntity<short, InCommCardCreditValue>(EntityCacheInfo, $"InCommCardID:{inCommCardId}", () => DoGetOrCreate(inCommCardId));
	}

	private static InCommCardCreditValue DoGetOrCreate(short inCommCardId)
	{
		return EntityHelper.DoGetOrCreate<short, InCommCardCreditValueDAL, InCommCardCreditValue>(() => InCommCardCreditValueDAL.GetOrCreate(inCommCardId));
	}

	public static InCommCardCreditValue GetInCommCardCreditValueByInCommCardID(short inCommCardId)
	{
		return EntityHelper.GetEntityByLookup<short, InCommCardCreditValueDAL, InCommCardCreditValue>(EntityCacheInfo, $"InCommCardID:{inCommCardId}", () => InCommCardCreditValueDAL.GetInCommCardCreditValueByInCommCardID(inCommCardId));
	}

	public void Construct(InCommCardCreditValueDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"InCommCardID:{InCommCardID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
