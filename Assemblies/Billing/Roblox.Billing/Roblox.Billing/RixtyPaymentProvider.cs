using System;
using System.Linq;
using System.Web;
using Roblox.Billing.Properties;
using Roblox.Common;
using Roblox.EventLog;

namespace Roblox.Billing;

public class RixtyPaymentProvider : PaymentProviderBase
{
	private string _UserName;

	private readonly ILogger _Logger;

	private Payment _InitialCharge;

	private bool _NetSuccessOrFailure;

	private Sale _Sale;

	public static PaymentProviderType Type => PaymentProviderType.Rixty;

	public bool Enabled => true;

	public Payment InitialCharge => _InitialCharge;

	public bool NetSuccessOrFailure => _NetSuccessOrFailure;

	public Sale Sale => _Sale;

	public bool SupportsRecurringBilling => false;

	public RixtyPaymentProvider(CancelExistingActiveMembershipSaleHandler cancelExistingActiveMembershipSale, ILogger logger = null)
		: base(cancelExistingActiveMembershipSale, logger)
	{
		_Logger = logger;
	}

	public string BeginCheckOut(ShoppingCart shoppingCart, string userName, string productName, byte platformTypeId)
	{
		if (!Settings.Default.RixtyIsEnabled)
		{
			throw new ApplicationException("Rixty is no longer supported. Please use another payment method.");
		}
		_UserName = userName;
		if (shoppingCart.Contents.Where((ShoppingCartProduct x) => x.IsRenewable).Count() > 0)
		{
			throw new ApplicationException("Recurring billing has not been implemented for Rixty. Use credit card.");
		}
		if (!PaymentHelper.IsValidProductBundle(shoppingCart, Type))
		{
			throw new ApplicationException("There is a product in the shopping cart that cannot be purchased using Rixty. Please use another payment method.");
		}
		_Sale = shoppingCart.CheckOut(platformTypeId);
		if (_Sale.DiscountedPriceTotal == 0m)
		{
			throw new ApplicationException("Cannot process free product transaction through Rixty");
		}
		_Sale.SaleStatusTypeID = SaleStatusType.Pending.ID;
		_Sale.Save();
		_InitialCharge = new Payment();
		_InitialCharge.PaymentDate = DateTime.Now;
		_InitialCharge.PaymentProviderTypeID = PaymentProviderType.Rixty.ID;
		_InitialCharge.PaymentStatusTypeID = PaymentStatusType.Pending.ID;
		_InitialCharge.Amount = _Sale.DiscountedPriceTotal;
		_InitialCharge.SaleID = _Sale.ID;
		_InitialCharge.Save();
		NVPClient nVPClient = new NVPClient(BillingHelper.RixtyURL, BillingHelper.RixtyUser, BillingHelper.RixtyPassword, BillingHelper.RixtySignature);
		NVPCodec extras = new NVPCodec();
		extras.put(NVPCodec.Field.USERID, _UserName);
		extras.put(NVPCodec.Field.CUSTOM, _Sale.ID.ToString());
		extras.put(NVPCodec.Field.RETURNURL, BillingHelper.RixtyReturnURL + "?paymentID=" + _InitialCharge.ID);
		extras.put(NVPCodec.Field.CANCELURL, BillingHelper.RixtyCancelURL);
		return nVPClient.setRixtyCheckout(Convert.ToDouble(_Sale.DiscountedPriceTotal), "", productName, extras).get(NVPCodec.Field.CHECKOUTURL);
	}

	public bool FinalizePay(long paymentId, string token, string PayerID)
	{
		if (!Settings.Default.RixtyIsEnabled)
		{
			throw new ApplicationException("Rixty is no longer supported. Please use another payment method.");
		}
		_InitialCharge = Payment.Get(paymentId);
		_Sale = Sale.Get(_InitialCharge.SaleID);
		NVPCodec nVPCodec = new NVPClient(BillingHelper.RixtyURL, BillingHelper.RixtyUser, BillingHelper.RixtyPassword, BillingHelper.RixtySignature).doRixtyCheckoutPayment(token, PayerID);
		string transactionID = nVPCodec.get(NVPCodec.Field.TRANSACTIONID);
		if (nVPCodec.get(NVPCodec.Field.ACK) == "Success")
		{
			_InitialCharge.PaymentStatusTypeID = PaymentStatusType.Complete.ID;
			_InitialCharge.Save();
			_Sale.SaleStatusTypeID = SaleStatusType.Complete.ID;
			_Sale.Save();
			string transactionResult2 = "Rixty Success";
			string transactionMessage2 = "";
			LogTransaction(transactionID, transactionResult2, transactionMessage2);
			_NetSuccessOrFailure = true;
			SaleProductPremiumFeatureQueue.GrantPremiumFeatures(_Sale.Products);
			if (_Sale.Products.Any((SaleProduct x) => x.Product.ProductGroupID == ProductGroup.BC.ID))
			{
				CancelExistingRecurringMembershipSale(_Sale);
			}
			TryToPublishBillingTransaction(_Sale, _Logger, null);
		}
		else
		{
			_InitialCharge.PaymentStatusTypeID = PaymentStatusType.Error.ID;
			_InitialCharge.Save();
			_Sale.SaleStatusTypeID = SaleStatusType.Error.ID;
			_Sale.Save();
			string transactionResult = "Rixty Epic Fail";
			string transactionMessage = "";
			LogTransaction(transactionID, transactionResult, transactionMessage);
			_NetSuccessOrFailure = false;
		}
		return _NetSuccessOrFailure;
	}

	private void LogTransaction(string transactionID, string transactionResult, string transactionMessage)
	{
		TransactionLog obj = new TransactionLog
		{
			Amount = _Sale.DiscountedPriceTotal,
			UserAccountID = _Sale.PurchaserAccountID,
			AccountID = _UserName,
			ClientIP = HttpContext.Current.GetOriginIP(),
			TransactionType = transactionResult,
			TransactionID = transactionID,
			SaleID = _Sale.ID,
			PaymentID = _InitialCharge.ID,
			PaymentStatusTypeID = _InitialCharge.PaymentStatusTypeID,
			TransactionDate = DateTime.Now
		};
		string errorMessage = (obj.Description = transactionMessage);
		obj.ErrorMessage = errorMessage;
		obj.Save();
	}
}
