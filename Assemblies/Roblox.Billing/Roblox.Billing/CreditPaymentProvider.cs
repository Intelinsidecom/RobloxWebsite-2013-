using System;
using System.Linq;
using System.Web;
using Roblox.Common;
using Roblox.EphemeralCounters;
using Roblox.EventLog;

namespace Roblox.Billing;

public class CreditPaymentProvider : PaymentProviderBase, ISynchronousPaymentProvider, IPaymentProvider
{
	private string _UserName = string.Empty;

	private long _AccountID;

	protected ILogger _Logger;

	protected ICounter _TransactionFailureCounter;

	private Sale _Sale;

	public static PaymentProviderType Type => PaymentProviderType.Credit;

	public bool Enabled => true;

	public Payment InitialCharge { get; set; }

	public bool NetSuccessOrFailure { get; set; }

	public Sale Sale => _Sale;

	public bool SupportsRecurringBilling => false;

	public CreditPaymentProvider(CancelExistingActiveMembershipSaleHandler cancelExistingActiveMembershipSale, ILogger logger, IEphemeralCounterFactory counterFactory)
		: base(cancelExistingActiveMembershipSale, logger, counterFactory)
	{
		_Logger = logger ?? throw new ArgumentNullException("logger");
		counterFactory = counterFactory ?? throw new ArgumentNullException("counterFactory");
		_TransactionFailureCounter = counterFactory.GetCounter("CreditPaymentProvider_TransactionFailure");
	}

	private void LogTransaction(string transactionId, string transactionType, string transactionMessage)
	{
		TransactionLog t = new TransactionLog();
		t.PaymentID = InitialCharge.ID;
		t.UserAccountID = _Sale.PurchaserAccountID;
		t.SaleID = _Sale.ID;
		t.Amount = InitialCharge.Amount;
		t.TransactionDate = DateTime.Now;
		t.PaymentStatusTypeID = InitialCharge.PaymentStatusTypeID;
		t.AccountID = _UserName;
		t.TransactionID = transactionId;
		t.TransactionType = transactionType;
		string errorMessage = (t.Description = transactionMessage);
		t.ErrorMessage = errorMessage;
		if (HttpContext.Current != null)
		{
			t.ClientIP = HttpContext.Current.GetOriginIP();
		}
		t.Save();
	}

	private void ProcessTransaction()
	{
		CreditBalance cb = CreditBalance.GetOrCreate(_AccountID);
		NetSuccessOrFailure = cb.TryDebit(_Sale.DiscountedPriceTotal);
		string trxId = _Sale.ID.ToString();
		string message;
		if (NetSuccessOrFailure)
		{
			message = "Credit Success";
			InitialCharge.PaymentStatusTypeID = PaymentStatusType.Complete.ID;
			InitialCharge.Save();
			_Sale.SaleStatusTypeID = SaleStatusType.Complete.ID;
			_Sale.Save();
			CreditTransactionHistory.Submit(_AccountID, CreditTransactionType.DebitID, trxId, CreditTransactionOriginType.SaleOfGoodsID, _Sale.DiscountedPriceTotal);
			TryToPublishBillingTransaction(_Sale, _Logger, null);
		}
		else
		{
			message = "Credit Failure";
			InitialCharge.PaymentStatusTypeID = PaymentStatusType.Error.ID;
			InitialCharge.Save();
			_Sale.SaleStatusTypeID = SaleStatusType.Error.ID;
			_Sale.Save();
		}
		LogTransaction(trxId, "sale", message);
	}

	private bool Pay()
	{
		_Sale.SaleStatusTypeID = SaleStatusType.Pending.ID;
		_Sale.Save();
		InitialCharge = new Payment();
		InitialCharge.PaymentDate = DateTime.Now;
		InitialCharge.PaymentProviderTypeID = PaymentProviderType.Credit.ID;
		InitialCharge.PaymentStatusTypeID = PaymentStatusType.Pending.ID;
		InitialCharge.Amount = _Sale.DiscountedPriceTotal;
		InitialCharge.SaleID = _Sale.ID;
		InitialCharge.Save();
		try
		{
			ProcessTransaction();
		}
		catch (Exception e)
		{
			_TransactionFailureCounter.IncrementInBackground();
			_Logger.Error($"Credit payment provider transaction processing failed: {e}");
		}
		if (NetSuccessOrFailure)
		{
			SaleProductPremiumFeatureQueue.GrantPremiumFeatures(_Sale.Products);
			if (_Sale.Products.Any((SaleProduct x) => x.Product.ProductGroupID == ProductGroup.BC.ID))
			{
				CancelExistingRecurringMembershipSale(_Sale);
			}
		}
		return NetSuccessOrFailure;
	}

	public bool CheckOut(ShoppingCart shoppingCart, string userName, byte platformTypeId)
	{
		Account account = Account.Get(userName);
		if (account == null)
		{
			throw new ApplicationException($"There is no account named: {userName}");
		}
		_AccountID = account.ID;
		_UserName = userName;
		if (!PaymentHelper.IsValidProductBundle(shoppingCart, Type))
		{
			throw new ApplicationException("There is an item in the cart that cannot be purchased using Roblox Credits. Please use another payment method.");
		}
		_Sale = shoppingCart.CheckOut(platformTypeId, performPurchaseLimitCheck: false);
		return Pay();
	}

	public bool CheckOut(ShoppingCart shoppingCart, DateTime renewalDate, string userName, byte platformTypeId)
	{
		return false;
	}

	public bool CheckOut(ShoppingCart shoppingCart, string userName, byte countryId, byte platformTypeId, DateTime? renewalDate = null)
	{
		Account account = Account.Get(userName);
		if (account == null)
		{
			throw new ApplicationException($"There is no account named: {userName}");
		}
		_AccountID = account.ID;
		_UserName = userName;
		if (!PaymentHelper.IsValidProductBundle(shoppingCart, Type))
		{
			throw new ApplicationException("There is an item in the cart that cannot be purchased using Roblox Credits. Please use another payment method.");
		}
		_Sale = shoppingCart.CheckOut(countryId, PaymentProviderType.Credit.ID, platformTypeId, performPurchaseLimitCheck: false);
		if (renewalDate.HasValue)
		{
			_Sale.RenewalDate = renewalDate;
			_Sale.Save();
		}
		return Pay();
	}
}
