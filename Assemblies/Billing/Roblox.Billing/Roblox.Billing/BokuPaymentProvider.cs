using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using Roblox.Billing.Business_Logic_Layer;
using Roblox.Billing.Properties;
using Roblox.Common;

namespace Roblox.Billing;

public class BokuPaymentProvider
{
	private Payment _InitialCharge;

	private bool _NetSuccessOrFailure;

	private Sale _Sale;

	public bool Enabled => true;

	public static string SecurityKey => "RQXNplGqLc9TsJfC013jU0RdOdNVzvTsxk4gkCCxzophUBnj44vWCohW70Jepas8LU6aA0unLbwuKXbDHJs1lToOoFr1MbGmAHSt";

	public Payment InitialCharge => _InitialCharge;

	public bool NetSuccessOrFailure => _NetSuccessOrFailure;

	public static PaymentProviderType Type => PaymentProviderType.Boku;

	public Sale Sale => _Sale;

	public bool SupportsRecurringBilling => false;

	public void BeginCheckOut(ShoppingCart shoppingCart, string userName, byte platformTypeId, byte? currencyTypeID = null)
	{
		IEnumerable<ShoppingCartProduct> source = shoppingCart.Contents.Where((ShoppingCartProduct x) => x.IsRenewable);
		if (!currencyTypeID.HasValue)
		{
			currencyTypeID = CurrencyType.GetUSDCurrencyTypeID;
		}
		if (!PaymentHelper.IsValidProductBundle(shoppingCart, Type))
		{
			throw new ApplicationException("There is a product in the shopping cart that cannot be purchased using Boku. Please use another payment method.");
		}
		if (source.Count() > 0)
		{
			throw new ApplicationException("Recurring billing has not been implemented for Boku. Use credit card.");
		}
		_Sale = shoppingCart.CheckOut(platformTypeId, performPurchaseLimitCheck: true, currencyTypeID);
		if (_Sale.DiscountedPriceTotal == 0m)
		{
			throw new ApplicationException("Cannot process free product transaction through Boku");
		}
		_Sale.SaleStatusTypeID = SaleStatusType.Pending.ID;
		_Sale.CurrencyTypeID = currencyTypeID.Value;
		_Sale.Save();
		_InitialCharge = new Payment();
		_InitialCharge.PaymentDate = DateTime.Now;
		_InitialCharge.PaymentProviderTypeID = PaymentProviderType.Boku.ID;
		_InitialCharge.PaymentStatusTypeID = PaymentStatusType.Pending.ID;
		_InitialCharge.Amount = _Sale.DiscountedPriceTotal;
		_InitialCharge.SaleID = _Sale.ID;
		_InitialCharge.CurrencyTypeID = currencyTypeID.Value;
		_InitialCharge.Save();
	}

	private string getMd5Hash(string input)
	{
		byte[] data = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(input));
		StringBuilder sBuilder = new StringBuilder();
		for (int i = 0; i < data.Length; i++)
		{
			sBuilder.Append(data[i].ToString("x2"));
		}
		return sBuilder.ToString();
	}

	private string GenerateSignature(string queryString)
	{
		queryString = new Regex("&sig=([a-fA-F\\d]{32})").Replace(queryString, "");
		string[] args = queryString.Split('&');
		Array.Sort(args);
		string stringToHash = string.Join("", args);
		stringToHash = stringToHash.Replace("=", "");
		stringToHash += SecurityKey;
		return getMd5Hash(stringToHash);
	}

	/// <summary>
	/// After the user pays at Boku (from our IFrame) Boku pings a URL... 
	/// the context passed here contains the form variables necessary to complete the transaction
	/// </summary>
	/// <param name="context"></param>
	/// <returns></returns>
	public void FinalizePay(HttpContext context, bool BokuInternationalEnabled = false)
	{
		string queryString = HttpUtility.UrlDecode(context.Request.QueryString.ToString());
		string text = GenerateSignature(queryString);
		int epochTime = (int)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds;
		if (text != context.Request.QueryString["sig"] || epochTime - Convert.ToInt32(context.Request.QueryString["timestamp"]) > 300)
		{
			return;
		}
		_InitialCharge = Payment.Get(long.Parse(context.Request.QueryString["param"]));
		if (_InitialCharge.PaymentStatusTypeID != PaymentStatusType.Pending.ID)
		{
			return;
		}
		string test = context.Request.QueryString["test"];
		bool isTestCallbackOutsideTestMode = !string.IsNullOrEmpty(test) && test.Equals("1") && !Settings.Default.UseTestMode;
		if (context.Request.QueryString["result-code"] == "0" && !isTestCallbackOutsideTestMode)
		{
			byte? currencyTypeID = null;
			decimal pricePaid;
			if (BokuInternationalEnabled)
			{
				pricePaid = Convert.ToDecimal(context.Request.QueryString["paid"]) / 100m;
				CurrencyType currency = CurrencyType.GetByCode(context.Request.QueryString["currency"].ToUpper());
				if (currency != null)
				{
					currencyTypeID = currency.ID;
				}
			}
			else
			{
				pricePaid = Convert.ToDecimal(context.Request.QueryString["reference-paid"]) / 100m;
				currencyTypeID = CurrencyType.GetUSDCurrencyTypeID;
			}
			_InitialCharge.PaymentStatusTypeID = PaymentStatusType.Complete.ID;
			_InitialCharge.Amount = pricePaid;
			_InitialCharge.CurrencyTypeID = currencyTypeID;
			_InitialCharge.Save();
			_Sale = Sale.Get(_InitialCharge.SaleID);
			_Sale.SaleStatusTypeID = SaleStatusType.Complete.ID;
			_Sale.DiscountedPriceTotal = pricePaid;
			_Sale.CurrencyTypeID = currencyTypeID;
			_Sale.Save();
			LogTransaction(context.Request.QueryString["trx-id"], "Success", "Boku Success", currencyTypeID);
			_NetSuccessOrFailure = true;
			SaleProductPremiumFeatureQueue.GrantPremiumFeatures(_Sale.Products);
			if (_Sale.Products.Where((SaleProduct x) => x.Product.ProductGroupID == ProductGroup.BC.ID).Count() > 0)
			{
				PayPalHelper.CancelPreviousRecurringPaymentOnUpgrade(_Sale);
			}
			PaymentProviderBase.TryToPublishBillingTransactionEvent(_Sale);
		}
		else
		{
			_InitialCharge.PaymentStatusTypeID = PaymentStatusType.Error.ID;
			_InitialCharge.Save();
			_Sale = Sale.Get(_InitialCharge.SaleID);
			_Sale.SaleStatusTypeID = SaleStatusType.Error.ID;
			_Sale.Save();
			LogTransaction(context.Request.QueryString["trx-id"], "Failure", isTestCallbackOutsideTestMode ? "Boku test callback outside of test mode" : "Boku Failure");
			_NetSuccessOrFailure = false;
		}
	}

	private void LogTransaction(string transactionID, string transactionResult, string transactionMessage, byte? currencyTypeID = null)
	{
		TransactionLog obj = new TransactionLog
		{
			Amount = _Sale.DiscountedPriceTotal,
			UserAccountID = _Sale.PurchaserAccountID,
			AccountID = _Sale.PurchaserAccountID.ToString(),
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
		obj.CurrencyTypeID = currencyTypeID;
		obj.Save();
	}
}
