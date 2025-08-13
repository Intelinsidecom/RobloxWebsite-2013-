using System;
using System.Web;
using System.Web.Caching;
using Roblox.Billing.Exceptions;
using Roblox.Billing.Properties;
using Roblox.Common;
using Roblox.EventLog;

namespace Roblox.Billing;

public class RixtyPinCreditProvider
{
	private readonly ILogger _Logger;

	public RixtyPinCreditProvider(ILogger logger)
	{
		_Logger = logger;
	}

	public string CreditAccount(User user, string pin)
	{
		if (user == null)
		{
			throw new ApplicationException("No user to credit");
		}
		return CreditAccount(user.ID, user.AccountID, user.Name, pin);
	}

	public string CreditAccount(long userId, long accountId, string username, string pin)
	{
		if (!Settings.Default.RixtyIsEnabled)
		{
			throw new ApplicationException("Rixty is no longer supported. Please use another payment method.");
		}
		if (userId == 0L)
		{
			throw new ApplicationException("No user to credit");
		}
		if (accountId == 0L)
		{
			throw new ApplicationException("No account to credit");
		}
		if (FloodCheck(userId))
		{
			throw new ApplicationException($"UserId: {userId} has failed Rixty floodcheck.");
		}
		RixtyPinRedemptionLog rprl = RixtyPinRedemptionLog.GetByCardPIN(pin);
		if (rprl != null)
		{
			if (rprl.PaymentStatusTypeID == PaymentStatusType.Complete.ID)
			{
				return "PIN already redeemed";
			}
			if (rprl.PaymentStatusTypeID == PaymentStatusType.Pending.ID && rprl.Updated.AddMinutes(5.0) > DateTime.Now)
			{
				return "Error: please reload the page";
			}
			rprl.AccountID = accountId;
			rprl.PaymentStatusTypeID = PaymentStatusType.Pending.ID;
			rprl.TransactionID = "";
			rprl.CardValue = 0m;
			rprl.Save();
		}
		else
		{
			rprl = RixtyPinRedemptionLog.CreateNew(accountId, PaymentStatusType.Pending.ID, "", 0m, pin);
		}
		NVPClient rixtyClient = new NVPClient(BillingHelper.RixtyURL, BillingHelper.RixtyUser, BillingHelper.RixtyPassword, BillingHelper.RixtySignature);
		NVPCodec extras = new NVPCodec();
		extras.put(NVPCodec.Field.CUSTOM, "No sale, just PIN");
		try
		{
			NVPCodec response = rixtyClient.setRixtyPin(pin, "RXT", username, Settings.Default.RixtyPinPostbackUrl + "?UserName=" + username + "&Pin=" + pin + "&Password=" + Settings.Default.RixtyCallbackPassword, extras);
			if (response.get(NVPCodec.Field.ACK) == "Success")
			{
				return "";
			}
			rprl.PaymentStatusTypeID = PaymentStatusType.Error.ID;
			rprl.Save();
			return response.get(NVPCodec.Field.ERRORMESSAGE);
		}
		catch
		{
			throw new RixtyPinRedemptionException("Unexpected error while connecting rixty.");
		}
	}

	/// When we call Rixty's site to validate the PIN, Rixty pings one of our URLs... 
	/// the context passed here contains the form variables necessary to complete the transaction
	public bool FinalizePay(HttpContext context)
	{
		if (!Settings.Default.RixtyIsEnabled)
		{
			throw new ApplicationException("Rixty is no longer supported. Please use another payment method.");
		}
		string username = context.Request.QueryString["UserName"];
		string token;
		string payerId;
		string password;
		string pin;
		if (username != null)
		{
			token = context.Request.QueryString["TOKEN"];
			payerId = context.Request.QueryString["PayerID"];
			password = context.Request.QueryString["Password"];
			pin = context.Request.QueryString["Pin"];
		}
		else
		{
			username = context.Request.Form["UserName"];
			token = context.Request.Form["TOKEN"];
			payerId = context.Request.Form["PayerID"];
			password = context.Request.Form["Password"];
			pin = context.Request.Form["Pin"];
		}
		if (string.IsNullOrEmpty(username))
		{
			throw new ApplicationException("No username provided while attempting to POST a Rixty transaction");
		}
		Account account = Account.Get(username);
		if (account == null)
		{
			throw new ApplicationException($"Could not find user name \"{username}\" returned by Rixty");
		}
		if (context.GetOriginIP() != Settings.Default.RixtyCallbackIP)
		{
			throw new ApplicationException($"Attempt to POST Rixty transaction from {context.GetOriginIP()}; denied");
		}
		if (password != Settings.Default.RixtyCallbackPassword)
		{
			throw new ApplicationException("Invalid password on Rixty callback");
		}
		NVPClient nVPClient = new NVPClient(BillingHelper.RixtyURL, BillingHelper.RixtyUser, BillingHelper.RixtyPassword, BillingHelper.RixtySignature);
		NVPCodec extras = new NVPCodec();
		extras.put(NVPCodec.Field.TOKEN, token);
		extras.put(NVPCodec.Field.PAYERID, payerId);
		extras.put(NVPCodec.Field.CUSTOM, $"PIN {pin}");
		NVPCodec response = nVPClient.doRixtyCheckoutPayment(token, "", extras);
		string text = response.get(NVPCodec.Field.ACK);
		RixtyPinRedemptionLog rprl = RixtyPinRedemptionLog.GetByCardPIN(pin);
		if (text != "Success")
		{
			if (rprl != null)
			{
				rprl.PaymentStatusTypeID = PaymentStatusType.Error.ID;
				rprl.Save();
			}
			return false;
		}
		try
		{
			decimal amountRedeemed = decimal.Parse(response.get(NVPCodec.Field.AMT));
			if (rprl != null)
			{
				rprl.CardValue = amountRedeemed;
				rprl.TransactionID = response.get(NVPCodec.Field.TRANSACTIONID);
				rprl.PaymentStatusTypeID = PaymentStatusType.Complete.ID;
				rprl.Save();
			}
			CreditBalance.GetOrCreate(account.ID).Credit(amountRedeemed);
			CreditTransactionHistory.Submit(account.ID, CreditTransactionType.CreditID, response.get(NVPCodec.Field.TRANSACTIONID), CreditTransactionOriginType.RixtyPinID, amountRedeemed);
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
		}
		return true;
	}

	private static bool FloodCheck(User user)
	{
		return FloodCheck(user.ID);
	}

	private static bool FloodCheck(long userId)
	{
		string lookup = $"RixtyPinRequest_{userId}";
		int numAttempts = 0;
		if (HttpContext.Current.Cache.Get(lookup) != null)
		{
			numAttempts = (int)HttpContext.Current.Cache.Get(lookup);
			HttpContext.Current.Cache.Remove(lookup);
		}
		numAttempts++;
		HttpContext.Current.Cache.Insert(lookup, numAttempts, null, DateTime.Now.AddMinutes(30.0), Cache.NoSlidingExpiration);
		if (numAttempts > 10)
		{
			return true;
		}
		return false;
	}
}
