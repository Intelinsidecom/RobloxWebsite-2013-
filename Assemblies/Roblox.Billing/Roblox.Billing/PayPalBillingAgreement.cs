using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Billing;

public class PayPalBillingAgreement : IRobloxEntity<int, PayPalBillingAgreementDAL>, ICacheableObject<int>, ICacheableObject
{
	private PayPalBillingAgreementDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.Billing.PayPalBillingAgreement", isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	public long AccountID
	{
		get
		{
			return _EntityDAL.AccountID;
		}
		set
		{
			_EntityDAL.AccountID = value;
		}
	}

	public string BillingAgreementID
	{
		get
		{
			return _EntityDAL.BillingAgreementID;
		}
		set
		{
			_EntityDAL.BillingAgreementID = value;
		}
	}

	public bool IsActive
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

	public PayPalBillingAgreement()
	{
		_EntityDAL = new PayPalBillingAgreementDAL();
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

	public static PayPalBillingAgreement CreateNew(long accountid, string billingagreementid, bool isactive)
	{
		PayPalBillingAgreement payPalBillingAgreement = new PayPalBillingAgreement();
		payPalBillingAgreement.AccountID = accountid;
		payPalBillingAgreement.BillingAgreementID = billingagreementid;
		payPalBillingAgreement.IsActive = isactive;
		payPalBillingAgreement.Save();
		return payPalBillingAgreement;
	}

	public static PayPalBillingAgreement Get(int id)
	{
		return EntityHelper.GetEntity<int, PayPalBillingAgreementDAL, PayPalBillingAgreement>(EntityCacheInfo, id, () => PayPalBillingAgreementDAL.Get(id));
	}

	public void Construct(PayPalBillingAgreementDAL dal)
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
