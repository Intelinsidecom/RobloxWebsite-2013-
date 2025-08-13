using System;
using System.Collections.Generic;
using Roblox.Billing.Business_Logic_Layer;
using Roblox.Billing.Properties;
using Roblox.Billing.XboxStoreExceptions;
using Roblox.Classification;
using Roblox.EventLog;
using Roblox.Users;

namespace Roblox.Billing;

internal class XboxStorePaymentProvider : AppStorePaymentProviderBase, IXboxStorePaymentProvider
{
	protected override PaymentProviderType _PaymentProviderType => PaymentProviderType.XboxStore;

	/// <summary>
	/// Process Consumption
	/// </summary>
	/// <param name="purchaser">Roblox User</param>
	/// <param name="transactionId">TransactionID associated (GUID)</param>
	/// <param name="titleId">Xbox Title Id</param>
	/// <param name="xboxStoreProductId">Xbox Store Product Id (GUID)</param>
	/// <param name="consumableUrl">ConsumableUrl used for consuming the product (Can't save this on our DB)</param>
	/// <param name="sandboxId">SandboxId of the client</param>
	/// <param name="purchasedDate">Purchased Date of the consumable Product</param>        
	/// <param name="consumeOrVerifyConsumption">Client used to consume the product against Xbox Live Service</param>
	public IReadOnlyCollection<Sale> Process(IPurchaser purchaser, string transactionId, string titleId, string xboxStoreProductId, string consumableUrl, string sandboxId, DateTime purchasedDate, Func<XboxStorePayment, bool> consumeOrVerifyConsumption, ILogger logger = null)
	{
		if (!Settings.Default.XboxStorePurchaseEnabled)
		{
			throw new BlockedPurchaseException(PaymentStatusChangeReasonType.Technical.ID, "Xbox Store Purchase Disabled");
		}
		IPurchase purchase = GetPurchaseFromXboxStoreProductId(xboxStoreProductId);
		CheckPurchaseWellformedness(purchase);
		CheckPurchaseEligibility(purchase);
		Sale pendingSale = null;
		Payment pendingPayment = null;
		XboxStorePayment xboxStorePayment = null;
		try
		{
			pendingSale = CreateSale(purchaser, purchase, PlatformType.XboxOneID, isPending: true);
			pendingPayment = CreatePayment(pendingSale, isPending: true);
			xboxStorePayment = GetOrCreateXboxStorePayment(pendingPayment, transactionId, titleId, xboxStoreProductId, sandboxId, purchasedDate);
		}
		catch (Exception ex)
		{
			ExceptionHandler.LogException(ex);
			throw new PurchaseFailedException(consumableUrl);
		}
		List<Sale> successfulSales = new List<Sale>();
		if (pendingSale != null && pendingPayment != null && xboxStorePayment != null)
		{
			bool isSuccessfullyConsumed = consumeOrVerifyConsumption(xboxStorePayment);
			ProcessTransaction(pendingSale, pendingPayment, isSuccessfullyConsumed, logger);
			if (isSuccessfullyConsumed)
			{
				successfulSales.Add(pendingSale);
			}
		}
		return successfulSales;
	}

	/// <summary>
	/// If previous transaction failed at the stage where we give Robux after consumption was successful, we need to re-process them to give the Robux
	/// </summary>
	/// <param name="purchaser"></param>
	/// <param name="consumeOrVerifyConsumption"></param>
	public IReadOnlyCollection<Sale> ProcessPendingTransactions(IPurchaser purchaser, Func<XboxStorePayment, bool> consumeOrVerifyConsumption, ILogger logger = null)
	{
		if (!Settings.Default.XboxStorePurchaseEnabled)
		{
			throw new BlockedPurchaseException(PaymentStatusChangeReasonType.Technical.ID, "Xbox Store Purchase Disabled");
		}
		List<Sale> successfulSales = new List<Sale>();
		foreach (Sale pendingSale in Sale.GetSalesByPurchaserAndStatus(purchaser.Id, SaleStatusType.Pending.ID))
		{
			bool isSuccessfullyConsumed = false;
			foreach (Payment payment in Payment.GetPaymentsBySale(pendingSale.ID))
			{
				if (payment.PaymentProviderTypeID == _PaymentProviderType.ID && payment.PaymentStatusTypeID == PaymentStatusType.Pending.ID)
				{
					XboxStorePayment xboxStorePayment = XboxStorePayment.GetByPaymentID(payment.ID);
					if (xboxStorePayment != null)
					{
						isSuccessfullyConsumed = consumeOrVerifyConsumption(xboxStorePayment);
						GetPurchaseFromXboxStoreProductId(xboxStorePayment.XboxStoreProductID);
						_ = xboxStorePayment.XboxStoreTransactionID;
					}
					ProcessTransaction(pendingSale, payment, isSuccessfullyConsumed, logger);
					if (isSuccessfullyConsumed)
					{
						successfulSales.Add(pendingSale);
					}
				}
			}
		}
		return successfulSales;
	}

	/// <summary>
	/// Where we give the ROBUX and finalize the log
	/// </summary>
	/// <param name="sale"></param>
	/// <param name="payment"></param>        
	/// <param name="isSuccessfullyConsumed"></param>
	/// <param name="logger"></param>
	private void ProcessTransaction(Sale sale, Payment payment, bool isSuccessfullyConsumed, ILogger logger = null)
	{
		if (!TryDebounce(payment, isSuccessfullyConsumed))
		{
			try
			{
				if (isSuccessfullyConsumed)
				{
					AwardProducts(sale);
				}
				FinalizeAndLogTransaction(sale, payment, isSuccessfullyConsumed, logger);
			}
			catch (Exception ex)
			{
				ExceptionHandler.LogException(ex);
			}
		}
		if (!isSuccessfullyConsumed)
		{
			throw new VerificationFailedException("Verification Failed");
		}
	}

	private bool TryDebounce(Payment payment, bool isPurchaseSuccessful)
	{
		return HasDuplicateStatusRecord(isPurchaseSuccessful, payment.PaymentStatusTypeID);
	}

	/// <summary>
	/// Get or create a XboxStorePayment log.
	/// </summary>
	/// <param name="payment"></param>
	/// <param name="transactionId"></param>
	/// <param name="titleId"></param>
	/// <param name="xboxStoreProductId"></param>
	/// <param name="sandboxId"></param>
	/// <param name="purchasedDate"></param>
	/// <returns></returns>
	private XboxStorePayment GetOrCreateXboxStorePayment(Payment payment, string transactionId, string titleId, string xboxStoreProductId, string sandboxId, DateTime purchasedDate)
	{
		XboxStorePayment xboxStorePayment = XboxStorePayment.GetByPaymentID(payment.ID);
		if (xboxStorePayment == null)
		{
			xboxStorePayment = new XboxStorePayment
			{
				PaymentID = payment.ID,
				XboxStoreProductID = xboxStoreProductId,
				XboxStoreTransactionID = transactionId,
				XboxStoreTitleID = titleId,
				XboxStoreSandboxID = sandboxId,
				PurchaseTime = purchasedDate
			};
		}
		xboxStorePayment.Save();
		return xboxStorePayment;
	}

	private IPurchase GetPurchaseFromXboxStoreProductId(string xboxStoreProductId)
	{
		CountryCurrency countryCurrency = CountryCurrency.GetByCountryTypeIDAndCurrencyTypeID(Country.GetUSACountry().ID, CurrencyType.GetUSDCurrencyTypeID);
		IProduct product = XboxStoreProductFactory.GetProductFromXboxStoreProductId(xboxStoreProductId);
		return PurchaseFactory.Singleton.GetPurchase(product, PaymentProviderType.XboxStore, countryCurrency);
	}
}
