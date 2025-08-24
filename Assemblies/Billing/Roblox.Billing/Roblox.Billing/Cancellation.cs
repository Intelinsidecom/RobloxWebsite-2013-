using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using PayPal.Payments.Common.Utility;
using PayPal.Payments.DataObjects;
using PayPal.Payments.Transactions;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.EventLog;

namespace Roblox.Billing;

public class Cancellation : IRobloxEntity<int, CancellationDAL>, ICacheableObject<int>, ICacheableObject, IParallelWorkTask
{
	private CancellationDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.Billing.Cancellation", isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	public int SaleID
	{
		get
		{
			return _EntityDAL.SaleID;
		}
		set
		{
			_EntityDAL.SaleID = value;
		}
	}

	public string PaypalAccountID
	{
		get
		{
			return _EntityDAL.PaypalAccountID;
		}
		set
		{
			_EntityDAL.PaypalAccountID = value;
		}
	}

	public Guid? WorkerID
	{
		get
		{
			return _EntityDAL.WorkerID;
		}
		set
		{
			_EntityDAL.WorkerID = value;
		}
	}

	public bool SentToPayPal
	{
		get
		{
			return _EntityDAL.SentToPayPal;
		}
		set
		{
			_EntityDAL.SentToPayPal = value;
		}
	}

	public DateTime? LeaseExpiration
	{
		get
		{
			return _EntityDAL.LeaseExpiration;
		}
		set
		{
			_EntityDAL.LeaseExpiration = value;
		}
	}

	public DateTime Created => _EntityDAL.Created;

	public DateTime Updated => _EntityDAL.Updated;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public string UniqueId => ID.ToString();

	public Cancellation()
	{
		_EntityDAL = new CancellationDAL();
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

	public static Cancellation CreateNew(int saleId, string payPalAccountId)
	{
		Cancellation cancellation = new Cancellation();
		cancellation.SaleID = saleId;
		cancellation.PaypalAccountID = payPalAccountId;
		cancellation.Save();
		return cancellation;
	}

	public static Cancellation Get(int id)
	{
		return EntityHelper.GetEntity<int, CancellationDAL, Cancellation>(EntityCacheInfo, id, () => CancellationDAL.Get(id));
	}

	public static ICollection<IParallelWorkTask> LeaseWorkItems(Guid workerId, int numberOfItems, int leaseDurationInMinutes, int maxCancellationsPerDay, ILogger logger)
	{
		ICollection<IParallelWorkTask> entities = new List<IParallelWorkTask>();
		if (!BillingHelper.Enabled)
		{
			return entities;
		}
		List<int> ids = new List<int>();
		try
		{
			ids = (List<int>)CancellationDAL.LeasePendingCancellations(workerId, numberOfItems, leaseDurationInMinutes, maxCancellationsPerDay);
		}
		catch (SqlException)
		{
			logger.Error("MaxCancellationsPerDayReached");
			return entities;
		}
		foreach (int id in ids)
		{
			try
			{
				CancellationDAL entityDal = CancellationDAL.Get(id);
				if (entityDal != null)
				{
					Cancellation entity = new Cancellation();
					entity.Construct(entityDal);
					CacheManager.ProcessEntityChange(entity, StateChangeEventType.Modification);
					entities.Add(entity);
				}
			}
			catch (Exception ex2)
			{
				ExceptionHandler.LogException(ex2);
			}
		}
		return entities;
	}

	public void Construct(CancellationDAL dal)
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

	public void ProcessTaskAndMarkComplete()
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_0093: Expected O, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (!SentToPayPal && !(WorkerID.Value != ParallelTaskWorker.ID) && (!LeaseExpiration.HasValue || !(LeaseExpiration.Value <= DateTime.Now)))
		{
			PayflowConnectionData payflowConnectionData = new PayflowConnectionData(PayPalHelper.Connection);
			UserInfo val = new UserInfo(PayPalHelper.CredentialsUser, PayPalHelper.CredentialsVendor, PayPalHelper.CredentialsPartner, PayPalHelper.CredentialsPassword);
			RecurringInfo recurringInfo = new RecurringInfo();
			recurringInfo.OrigProfileId = PaypalAccountID;
			TransactionResponse transactionResponse = (((BaseTransaction)new RecurringCancelTransaction(val, payflowConnectionData, recurringInfo, PayflowUtility.RequestId)).SubmitTransaction() ?? throw new Exception($"Attempt to CancelRenewals failed for ProfileID: {PaypalAccountID}.  Unable to obtain response from PayPal.")).TransactionResponse;
			if (transactionResponse == null)
			{
				throw new Exception($"PayflowPro Error: Attempt to cancel recurring billing for ProfileID: {PaypalAccountID} failed.  TransactionResponseResult: {transactionResponse.Result}.  TransactionResponseMessage: {transactionResponse.RespMsg}.");
			}
			if (transactionResponse.Result == 33)
			{
				ExceptionHandler.LogException(new Exception($"PayflowPro Error: Attempt to cancel recurring billing for ProfileID: {PaypalAccountID} failed.  TransactionResponseResult: {transactionResponse.Result}.  TransactionResponseMessage: {transactionResponse.RespMsg}."));
			}
			else if (transactionResponse.Result == 37)
			{
				ExceptionHandler.LogException(new Exception($"PayflowPro Error: Attempt to cancel recurring billing for ProfileID: {PaypalAccountID} failed.  TransactionResponseResult: {transactionResponse.Result}.  TransactionResponseMessage: {transactionResponse.RespMsg}."));
			}
			else if (transactionResponse.Result != 0)
			{
				throw new Exception($"PayflowPro Error: Attempt to cancel recurring billing for ProfileID: {PaypalAccountID} failed.  TransactionResponseResult: {transactionResponse.Result}.  TransactionResponseMessage: {transactionResponse.RespMsg}.");
			}
			SentToPayPal = true;
			Save();
		}
	}
}
