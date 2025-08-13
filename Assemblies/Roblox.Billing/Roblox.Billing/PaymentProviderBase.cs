using System;
using System.Linq;
using Roblox.Billing.Properties;
using Roblox.BillingTransactionEventPublisher;
using Roblox.EphemeralCounters;
using Roblox.EventLog;

namespace Roblox.Billing;

public abstract class PaymentProviderBase
{
	protected readonly CancelExistingActiveMembershipSaleHandler CancelExsitingActiveMembershipSaleAction;

	protected readonly ILogger Logger;

	protected static ICounter TransactionPublicationFailureCounter;

	protected readonly Roblox.BillingTransactionEventPublisher.BillingTransactionEventPublisher TransactionEventPublisher;

	/// <summary>
	/// Base payment provider. Logger and counters can be null.
	/// </summary>
	/// <param name="cancelExistingActiveMembershipSale"></param>
	/// <param name="logger">The <see cref="T:Roblox.EventLog.ILogger" /> to be used to log any exceptions. Can be null.</param>
	/// <param name="counterFactory">The <see cref="T:Roblox.EphemeralCounters.IEphemeralCounterFactory" /> to be used to count any exceptions. Can be null.</param>
	protected PaymentProviderBase(CancelExistingActiveMembershipSaleHandler cancelExistingActiveMembershipSale, ILogger logger = null, IEphemeralCounterFactory counterFactory = null)
	{
		CancelExsitingActiveMembershipSaleAction = cancelExistingActiveMembershipSale ?? throw new ArgumentNullException("cancelExistingActiveMembershipSale");
		Logger = logger;
		TransactionPublicationFailureCounter = counterFactory?.GetCounter("BasePaymentProvider_TransactionPublishFailure");
	}

	/// <summary>
	/// Tries to publish a sale, and logs any publishing errors if possible instead of throwing.
	/// </summary>
	/// <param name="sale">The <see cref="T:Roblox.Billing.Sale" /> to be published.</param>
	protected bool TryToPublishBillingTransaction(Sale sale, ILogger logger, IEphemeralCounterFactory counterFactory)
	{
		try
		{
			PublishBillingTransaction(sale);
			return true;
		}
		catch (Exception exception)
		{
			counterFactory?.GetCounter("BasePaymentProvider_TransactionPublishFailure")?.IncrementInBackground();
			logger?.Error($"Publishing the billing transaction for SaleID ({sale.ID}) failed: {exception}");
			return false;
		}
	}

	/// <summary>
	/// Tries to publish a sale, and logs any publishing errors if possible instead of throwing.
	/// Note: Using this method won't log SNS errors.
	/// </summary>
	/// <param name="sale">The <see cref="T:Roblox.Billing.Sale" /> to be published.</param>
	/// <param name="logger">The <see cref="T:Roblox.EventLog.ILogger" /> to be used to log any exceptions. Can be null.</param>
	/// <param name="counterFactory">The <see cref="T:Roblox.EphemeralCounters.IEphemeralCounterFactory" /> to be used to count any exceptions. Can be null.</param>
	public static bool TryToPublishBillingTransactionEvent(Sale sale, ILogger logger = null, IEphemeralCounterFactory counterFactory = null)
	{
		try
		{
			PublishBillingTransactionEvent(sale);
			return true;
		}
		catch (Exception exception)
		{
			counterFactory?.GetCounter("BasePaymentProvider_TransactionPublishFailure")?.IncrementInBackground();
			logger?.Error($"Publishing the billing transaction for SaleID ({sale.ID}) failed: {exception}");
			return false;
		}
	}

	/// <summary>
	/// Publishes a sale, but doesn't catch publishing errors.
	/// </summary>
	/// <param name="sale">The <see cref="T:Roblox.Billing.Sale" /> to be published.</param>
	private void PublishBillingTransaction(Sale sale)
	{
		User user = User.GetByAccountID(sale.PurchaserAccountID.GetValueOrDefault());
		new Roblox.BillingTransactionEventPublisher.BillingTransactionEventPublisher(Logger).Publish(new BillingTransactionMessage
		{
			Amount = sale.DiscountedPriceTotal,
			CurrencyTypeID = sale.CurrencyTypeID.GetValueOrDefault(),
			PaymentDate = sale.Payments.First().PaymentDate,
			PaymentID = sale.Payments.First().ID,
			PaymentProviderTypeID = sale.Payments.First().PaymentProviderTypeID,
			ProductIDs = sale.Products.Select((SaleProduct p) => p.ProductID).ToList(),
			PurchaserUserID = (user?.ID ?? 0),
			TransactionType = BillingTransactionType.NewPurchase
		});
	}

	/// <summary>
	/// Publishes a sale, but doesn't catch publishing errors.
	/// Note: Using this method won't log any SNS errors.
	/// </summary>
	/// <param name="sale">The <see cref="T:Roblox.Billing.Sale" /> to be published.</param>
	private static void PublishBillingTransactionEvent(Sale sale)
	{
		User user = User.GetByAccountID(sale.PurchaserAccountID.GetValueOrDefault());
		Roblox.BillingTransactionEventPublisher.BillingTransactionEventPublisher.PublishStatically(new BillingTransactionMessage
		{
			Amount = sale.DiscountedPriceTotal,
			CurrencyTypeID = sale.CurrencyTypeID.GetValueOrDefault(),
			PaymentDate = sale.Payments.First().PaymentDate,
			PaymentID = sale.Payments.First().ID,
			PaymentProviderTypeID = sale.Payments.First().PaymentProviderTypeID,
			ProductIDs = sale.Products.Select((SaleProduct p) => p.ProductID).ToList(),
			PurchaserUserID = (user?.ID ?? 0),
			TransactionType = BillingTransactionType.NewPurchase
		});
	}

	protected void CancelExistingRecurringMembershipSale(Sale currentNewSale)
	{
		if (Settings.Default.IsBillingV2FindAndCancelPurchasesEnabled)
		{
			CancelExsitingActiveMembershipSaleAction(currentNewSale.ID);
		}
		else
		{
			PayPalHelper.CancelPreviousRecurringPaymentOnUpgrade(currentNewSale);
		}
	}
}
