using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Billing.Properties;
using Roblox.BillingTransactionEventPublisher;

namespace Roblox.Billing.Providers;

public abstract class RenewalProviderBase
{
	public enum SubscriptionPaymentStatus
	{
		Current,
		Delinquent,
		Pending
	}

	public static TimeSpan _DarkOrdersWindow => TimeSpan.FromDays((int)Settings.Default.DarkOrdersWindowInDays);

	public static void RenewOrder(int saleId)
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
				PendingStatusAction(sale);
				break;
			case SubscriptionPaymentStatus.Delinquent:
				DelinquentStatusAction(sale);
				break;
			}
		}
	}

	public static void CurrentStatusAction(Sale sale)
	{
		throw new NotImplementedException();
	}

	public static void PendingStatusAction(Sale sale)
	{
		throw new NotImplementedException();
	}

	public static void DelinquentStatusAction(Sale sale)
	{
		throw new NotImplementedException();
	}

	public static SubscriptionPaymentStatus GetSubscriptionPaymentStatus(Sale sale)
	{
		throw new NotImplementedException();
	}

	public static long WindowInTicks(Sale sale)
	{
		long renewalPeriodInMonths = 0L;
		if (sale.RenewalPeriodTypeID == RenewalPeriodType.Monthly.ID)
		{
			renewalPeriodInMonths = 1L;
		}
		else if (sale.RenewalPeriodTypeID == RenewalPeriodType.Quarterly.ID)
		{
			renewalPeriodInMonths = 3L;
		}
		else if (sale.RenewalPeriodTypeID == RenewalPeriodType.SemiAnnual.ID)
		{
			renewalPeriodInMonths = 6L;
		}
		else if (sale.RenewalPeriodTypeID == RenewalPeriodType.Annual.ID)
		{
			renewalPeriodInMonths = 12L;
		}
		return 25920000000000L * renewalPeriodInMonths / 2;
	}

	public static Cancellation CancelRenewals(Sale sale)
	{
		Payment mostRecentPayment = Payment.GetPaymentsBySale(sale.ID).FirstOrDefault();
		if (mostRecentPayment == null)
		{
			throw new Exception($"No Payments associated with SaleID: {sale.ID}");
		}
		TransactionLog associatedTransactionLog = TransactionLog.GetByPaymentID(mostRecentPayment.ID);
		if (associatedTransactionLog == null)
		{
			throw new Exception($"No Transaction Log associated with PayentID: {mostRecentPayment.ID}");
		}
		Cancellation cancellation = Cancellation.CreateNew(sale.ID, associatedTransactionLog.AccountID);
		if (cancellation != null)
		{
			sale.RenewalDate = null;
			sale.SaleStatusTypeID = SaleStatusType.Cancelled.ID;
			sale.Save();
		}
		return cancellation;
	}

	public static void PublishRenewalEvent(Sale sale)
	{
		Payment mostRecentPayment = Payment.GetPaymentsBySale(sale.ID).FirstOrDefault();
		if (mostRecentPayment == null)
		{
			return;
		}
		User user = User.GetByAccountID(sale.PurchaserAccountID.GetValueOrDefault());
		try
		{
			Roblox.BillingTransactionEventPublisher.BillingTransactionEventPublisher.PublishStatically(new BillingTransactionMessage
			{
				Amount = sale.RecurringPrice.Value,
				CurrencyTypeID = sale.CurrencyTypeID.GetValueOrDefault(),
				PaymentDate = mostRecentPayment.PaymentDate,
				PaymentID = mostRecentPayment.ID,
				PaymentProviderTypeID = mostRecentPayment.PaymentProviderTypeID,
				ProductIDs = new List<int> { sale.Products.First((SaleProduct s) => s.RecurringPrice.HasValue).ProductID },
				PurchaserUserID = (user?.ID ?? 0),
				TransactionType = BillingTransactionType.Renewal
			});
		}
		catch (Exception ex)
		{
			ExceptionHandler.LogException(ex);
		}
	}
}
