using System;
using System.Linq;
using Roblox.Billing.Providers;
using Roblox.EphemeralCounters;

namespace Roblox.Billing;

public class CreditSaleRenewer : RenewalProviderBase
{
	private const string _CreditRenewalAttemptCounter = "CreditRenewal_Attempt";

	private const string _CreditRenewalSuccessCounter = "CreditRenewal_Success";

	private const string _CreditRenewalFailureCounter = "CreditRenewal_Failure";

	private const string _CreditRenewalErrorCounter = "CreditRenewal_Error";

	public new static void CurrentStatusAction(Sale sale)
	{
	}

	public static void PendingStatusAction(Sale sale, IEphemeralCounterFactory ephemeralCounterFactory)
	{
		Payment mostRecentPayment = Payment.GetPaymentsBySale(sale.ID).FirstOrDefault();
		if (mostRecentPayment == null)
		{
			throw new Exception($"No Payments associated with SaleID: {sale.ID}");
		}
		TransactionLog associatedTransactionLog = TransactionLog.GetByPaymentID(mostRecentPayment.ID);
		if (associatedTransactionLog == null)
		{
			throw new Exception($"No TransactionLog associated with PaymentID: {mostRecentPayment.ID}");
		}
		if (!sale.PurchaserAccountID.HasValue)
		{
			throw new Exception($"No account ID associated with SaleID: {sale.ID}");
		}
		if (!sale.RecurringPrice.HasValue)
		{
			throw new Exception($"No recurring price associated with SaleID: {sale.ID}");
		}
		if (Charge(sale))
		{
			ProcessRenewal(sale, associatedTransactionLog);
			RenewalProviderBase.PublishRenewalEvent(sale);
			IncrementEphemeralCounter(ephemeralCounterFactory, "CreditRenewal_Success");
		}
		else
		{
			RenewalProviderBase.CancelRenewals(sale);
			IncrementEphemeralCounter(ephemeralCounterFactory, "CreditRenewal_Failure");
		}
	}

	public static void DelinquentStatusAction(Sale sale, IEphemeralCounterFactory ephemeralCounterFactory)
	{
		RenewalProviderBase.CancelRenewals(sale);
		CancellationAuditLog.CreateNew(sale.ID, "credit");
		IncrementEphemeralCounter(ephemeralCounterFactory, "CreditRenewal_Failure");
	}

	public static void RenewOrder(int saleId, IEphemeralCounterFactory ephemeralCounterFactory)
	{
		IncrementEphemeralCounter(ephemeralCounterFactory, "CreditRenewal_Attempt");
		try
		{
			Sale sale = Sale.Get(saleId);
			if (sale != null)
			{
				switch (GetSubscriptionPaymentStatus(sale))
				{
				case SubscriptionPaymentStatus.Current:
					CurrentStatusAction(sale);
					break;
				case SubscriptionPaymentStatus.Pending:
					PendingStatusAction(sale, ephemeralCounterFactory);
					break;
				case SubscriptionPaymentStatus.Delinquent:
					DelinquentStatusAction(sale, ephemeralCounterFactory);
					break;
				}
			}
		}
		catch (Exception)
		{
			IncrementEphemeralCounter(ephemeralCounterFactory, "CreditRenewal_Error");
			throw;
		}
	}

	private static bool Charge(Sale sale)
	{
		sale.SaleStatusTypeID = SaleStatusType.Pending.ID;
		sale.Save();
		Payment mostRecentPayment = Payment.GetPaymentsBySale(sale.ID).FirstOrDefault();
		if (mostRecentPayment != null)
		{
			TransactionLog oldLog = TransactionLog.GetByPaymentID(mostRecentPayment.ID);
			if (oldLog == null)
			{
				throw new Exception($"No TransactionLog associated with PaymentID {mostRecentPayment.ID}");
			}
			Payment payment = Payment.CreateNew(sale.ID, PaymentProviderType.Credit.ID, PaymentStatusType.Pending.ID, DateTime.Now, sale.RecurringPrice.Value, sale.CurrencyTypeID);
			bool num = CreditBalance.GetOrCreate(sale.PurchaserAccountID.Value).TryDebit(payment.Amount);
			string trxId = sale.ID.ToString();
			if (num)
			{
				payment.PaymentStatusTypeID = PaymentStatusType.Complete.ID;
				payment.Save();
				sale.SaleStatusTypeID = SaleStatusType.Complete.ID;
				sale.Save();
				CreditTransactionHistory.Submit(sale.PurchaserAccountID.Value, CreditTransactionType.DebitID, trxId, CreditTransactionOriginType.SaleOfGoodsID, payment.Amount);
			}
			else
			{
				payment.PaymentStatusTypeID = PaymentStatusType.Error.ID;
				payment.Save();
			}
			LogTransaction(sale, payment, oldLog);
			return num;
		}
		throw new Exception($"No payments associated with SaleID {sale.ID}");
	}

	private static void ProcessRenewal(Sale sale, TransactionLog log)
	{
		if (sale.RenewalPeriodTypeID == RenewalPeriodType.Monthly.ID)
		{
			sale.RenewalDate = DateTime.Now.AddMonths(1);
		}
		else if (sale.RenewalPeriodTypeID == RenewalPeriodType.Quarterly.ID)
		{
			sale.RenewalDate = DateTime.Now.AddMonths(3);
		}
		else if (sale.RenewalPeriodTypeID == RenewalPeriodType.SemiAnnual.ID)
		{
			sale.RenewalDate = DateTime.Now.AddMonths(6);
		}
		else if (sale.RenewalPeriodTypeID == RenewalPeriodType.Annual.ID)
		{
			sale.RenewalDate = DateTime.Now.AddMonths(12);
		}
		sale.Save();
		SaleProductPremiumFeatureQueue.CreateNew(sale.Products.Where((SaleProduct x) => x.RecurringPrice.HasValue).First());
	}

	private static void LogTransaction(Sale sale, Payment newPayment, TransactionLog oldLog)
	{
		TransactionLog newLog = new TransactionLog();
		newLog.PaymentID = newPayment.ID;
		newLog.SaleID = oldLog.SaleID;
		newLog.TransactionType = "credit recurring";
		newLog.UserAccountID = oldLog.UserAccountID;
		newLog.PaymentStatusTypeID = newPayment.PaymentStatusTypeID;
		newLog.Amount = newPayment.Amount;
		newLog.AccountID = oldLog.AccountID;
		newLog.Number = oldLog.Number;
		newLog.Month = oldLog.Month;
		newLog.Year = oldLog.Year;
		newLog.FirstName = oldLog.FirstName;
		newLog.LastName = oldLog.LastName;
		newLog.Address = oldLog.Address;
		newLog.City = oldLog.City;
		newLog.StateProvince = oldLog.StateProvince;
		newLog.ZipPostal = oldLog.ZipPostal;
		newLog.TransactionDate = DateTime.Now;
		newLog.TransactionID = sale.ID.ToString();
		if (newPayment.PaymentStatusTypeID == PaymentStatusType.Error.ID)
		{
			newLog.Description = "Low balance.";
		}
		newLog.Save();
	}

	public new static SubscriptionPaymentStatus GetSubscriptionPaymentStatus(Sale sale)
	{
		if (sale == null)
		{
			throw new ApplicationException("Required value not specified: Sale.");
		}
		DateTime? renewalDate = sale.RenewalDate;
		if (renewalDate.HasValue && DateTime.Now > renewalDate.Value.Add(RenewalProviderBase._DarkOrdersWindow))
		{
			return SubscriptionPaymentStatus.Delinquent;
		}
		SubscriptionPaymentStatus subscriptionPaymentStatus = SubscriptionPaymentStatus.Pending;
		long windowInTicks = RenewalProviderBase.WindowInTicks(sale);
		Payment mostRecentPayment = Payment.GetPaymentsBySale(sale.ID).FirstOrDefault();
		if (mostRecentPayment != null && mostRecentPayment.PaymentStatusTypeID == PaymentStatusType.Complete.ID)
		{
			DateTime? renewalDate2 = sale.RenewalDate;
			DateTime dateTime = mostRecentPayment.PaymentDate.AddTicks(-1 * windowInTicks);
			if (renewalDate2.HasValue && renewalDate2.GetValueOrDefault() > dateTime && sale.RenewalDate < mostRecentPayment.PaymentDate.AddTicks(windowInTicks))
			{
				subscriptionPaymentStatus = SubscriptionPaymentStatus.Current;
			}
		}
		return subscriptionPaymentStatus;
	}

	private static void IncrementEphemeralCounter(IEphemeralCounterFactory ephemeralCounterFactory, string counterName, int amount = 1)
	{
		ephemeralCounterFactory.GetCounter(counterName).IncrementInBackground(amount);
	}
}
