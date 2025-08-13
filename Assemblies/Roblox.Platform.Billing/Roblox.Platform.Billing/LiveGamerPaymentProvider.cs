using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Billing;
using Roblox.Billing.Business_Logic_Layer;
using Roblox.LiveGamer;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Billing;

internal class LiveGamerPaymentProvider : ILiveGamerPaymentProvider
{
	private readonly IUser currentUser;

	public LiveGamerPaymentProvider(IUser currentUser)
	{
		this.currentUser = currentUser;
	}

	public LiveGamerInitTransactionResult Begin(ICollection<LiveGamerInitSellLineItem> liveGamerSellLineItems, byte platformTypeId)
	{
		Roblox.Billing.Sale sale = liveGamerSellLineItems.Select((LiveGamerInitSellLineItem lgsl) => lgsl.LineItem).ToArray().ToShoppingCart(currentUser)
			.CheckOut(platformTypeId);
		Payment payment = new Payment();
		payment.PaymentDate = DateTime.Now;
		payment.PaymentProviderTypeID = Roblox.Billing.PaymentProviderType.LiveGamer.ID;
		payment.PaymentStatusTypeID = Roblox.Billing.PaymentStatusType.Pending.ID;
		payment.Amount = sale.DiscountedPriceTotal;
		payment.SaleID = sale.ID;
		payment.CurrencyTypeID = sale.CurrencyTypeID;
		payment.Save();
		LiveGamerPayment liveGamerPayment = LiveGamerPayment.CreateNew(payment.ID, LiveGamerPaymentStatusType.Pending.ID, null, null, null, null, null, null);
		string emailAddress = "";
		AccountEmailAddress accountEmail = AccountEmailAddress.GetCurrent(currentUser.AccountId);
		if (accountEmail != null)
		{
			emailAddress = accountEmail.GetEmailAddress().Address;
		}
		return new LiveGamerInitTransactionResult
		{
			LineItems = liveGamerSellLineItems.Select((LiveGamerInitSellLineItem lis) => lis.Translate()).ToArray(),
			UserId = Convert.ToInt32(currentUser.Id),
			CountryCode = "US",
			LiveGamerTransactionId = liveGamerPayment.ID,
			UserEmail = emailAddress
		};
	}

	public LiveGamerTransactionResult Finalize(LiveGamerTransactionInfo transactionInfo)
	{
		LiveGamerTransactionResult result = new LiveGamerTransactionResult();
		LiveGamerPayment liveGamerPayment = LiveGamerPayment.Get(transactionInfo.InternalPaymentId);
		if (liveGamerPayment != null && liveGamerPayment.LiveGamerPaymentStatusTypeID == LiveGamerPaymentStatusType.Pending.ID)
		{
			Payment payment = Payment.Get(liveGamerPayment.PaymentID);
			Roblox.Billing.Sale sale = Roblox.Billing.Sale.Get(payment.SaleID);
			liveGamerPayment.ExternalOrderId = transactionInfo.PurchaseOrderId;
			liveGamerPayment.Tax = transactionInfo.Tax;
			liveGamerPayment.TaxModel = transactionInfo.TaxModel;
			liveGamerPayment.PaymentType = transactionInfo.PaymentType;
			liveGamerPayment.CallbackXmlContent = transactionInfo.CallbackXmlContent;
			liveGamerPayment.Signature = transactionInfo.Signature;
			liveGamerPayment.LiveGamerPaymentStatusTypeID = transactionInfo.PaymentStatusId;
			payment.PaymentStatusTypeID = Roblox.Billing.PaymentStatusType.Error.ID;
			sale.SaleStatusTypeID = Roblox.Billing.SaleStatusType.Error.ID;
			if (liveGamerPayment.LiveGamerPaymentStatusTypeID == LiveGamerPaymentStatusType.Charged.ID)
			{
				byte? paymentCurrencyId = (payment.CurrencyTypeID.HasValue ? payment.CurrencyTypeID : new byte?(Roblox.Billing.Business_Logic_Layer.CurrencyType.GetUSDCurrencyTypeID));
				if (transactionInfo.Price == payment.Amount && Enum.TryParse<CurrencyType>(transactionInfo.Currency, out var currency) && currency.Translate().ID == paymentCurrencyId)
				{
					SaleProductPremiumFeatureQueue.GrantPremiumFeatures(sale.Products);
					sale.SaleStatusTypeID = Roblox.Billing.SaleStatusType.Complete.ID;
					payment.PaymentStatusTypeID = Roblox.Billing.PaymentStatusType.Complete.ID;
				}
				else
				{
					liveGamerPayment.LiveGamerPaymentStatusTypeID = LiveGamerPaymentStatusType.NotValid.ID;
				}
			}
			else if (liveGamerPayment.LiveGamerPaymentStatusTypeID == LiveGamerPaymentStatusType.ChargedBack.ID)
			{
				payment.PaymentStatusTypeID = Roblox.Billing.PaymentStatusType.ChargedBack.ID;
				sale.SaleStatusTypeID = Roblox.Billing.SaleStatusType.Cancelled.ID;
			}
			else if (liveGamerPayment.LiveGamerPaymentStatusTypeID == LiveGamerPaymentStatusType.Refunded.ID)
			{
				payment.PaymentStatusTypeID = Roblox.Billing.PaymentStatusType.Refunded.ID;
				sale.SaleStatusTypeID = Roblox.Billing.SaleStatusType.Cancelled.ID;
			}
			sale.Save();
			payment.Save();
			liveGamerPayment.Save();
			result.SuccessfullyHandle = true;
		}
		return result;
	}
}
