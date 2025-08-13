using System;
using System.Collections.Specialized;
using System.Text;
using System.Web;

namespace Roblox.Billing;

public class NVPCodec : NameValueCollection
{
	public enum Field
	{
		/// Success or Error status of METHOD 
		ACK,
		/// Dollar amount for a transaction 
		AMT,
		/// URL to direct the browser on Cancel 
		CANCELURL,
		/// HTML target attribute for cancel link 
		CANCELURLTARGET,
		/// URL to direct the browser for payment approval 
		CHECKOUTURL,
		/// User Country Code 
		COUNTRYCODE,
		/// Currency Code for this transaction 
		CURRENCYCODE,
		/// Custom field for your use 
		CUSTOM,
		/// Description of purchase 
		DESC,
		/// Message if ACK is Error 
		ERRORMESSAGE,
		/// Virtual Currency Exchange Rate 
		EXCHANGERATE,
		/// Commission on a transaction 
		FEEAMT,
		/// Commission refunded 
		FEEREFUNDAMT,
		/// Amount refunded to payer 
		GROSSREFUNDAMT,
		/// IFrame URL 
		IFRAMEURL,
		/// Invoice Number 
		INVNUM,
		/// NVP API Method to invoke 
		METHOD,
		/// Mobile checkout url 
		MOBILEURL,
		/// Amount deducted from merchant account 
		NETREFUNDAMT,
		/// Note to associate with a transaction 
		NOTE,
		/// Notification URL associated with merchant 
		NOTIFYURL,
		/// Transaction time in ISO 8601 format 
		ORDERTIME,
		/// Rixty Payer ID 
		PAYERID,
		/// Status of Payment 
		PAYMENTSTATUS,
		/// Currently unused 
		PAYMENTTYPE,
		PIN,
		/// Process transactions without browser redirect 
		POSTBACKURL,
		/// API Password 
		PWD,
		/// Frequency of subscription billing 
		SUBSCRIPTION,
		/// Subscription ID 
		SUBSCRIPTIONID,
		/// Subscription may be renewed 
		AUTORENEW,
		/// Subscription Status 
		STATUS,
		/// Subscription Renew Price 
		RENEWAMT,
		/// Susbscription Period Start 
		PERIODSTART,
		/// Susbscription Period End 
		PERIODEND,
		/// Property ID 
		RECEIVERID,
		/// ID associated with a Refund 
		REFUNDTRANSACTIONID,
		/// Full or Partial Refund 
		REFUNDTYPE,
		/// URL to direct browser following a successful transaction 
		RETURNURL,
		/// HTML target attribute for return link 
		RETURNURLTARGET,
		/// Transaction amount due merchant 
		SETTLEAMT,
		/// API Signature 
		SIGNATURE,
		/// Merchant SKU for a purchase 
		SKU,
		/// Token to identify a purchase being processed
		TOKEN,
		/// Identifier for a completed transaction 
		TRANSACTIONID,
		/// Type of transaction 
		TRANSACTIONTYPE,
		/// API User 
		USER,
		/// Merchant's USERID, for support purposes 
		USERID,
		/// Merchant's USERNAME, for async purchases 
		USERNAME,
		/// Rixty Protocol Version 
		VERSION
	}

	public NVPCodec()
	{
	}

	public NVPCodec(string s)
	{
		fromString(s);
	}

	public void fromString(string nvps)
	{
		char[] amp = new char[1] { '&' };
		char[] eq = new char[1] { '=' };
		string[] pairs = nvps.Split(amp);
		for (int i = 0; i < pairs.Length; i++)
		{
			string[] array = pairs[i].Split(eq);
			string decodedName = HttpUtility.UrlDecode(array[0]);
			string decodedValue = HttpUtility.UrlDecode(array[1]);
			Console.WriteLine(decodedName);
			Console.WriteLine(decodedValue);
			Add(decodedName, decodedValue);
		}
	}

	public void put(Field f, string value)
	{
		string name = Enum.GetName(typeof(Field), f);
		Add(name, value);
	}

	public void put(string name, string value)
	{
		if (name != null && value != null)
		{
			Add(name.ToUpper(), value);
		}
	}

	public string get(Field f)
	{
		string name = Enum.GetName(typeof(Field), f);
		return GetValues(name)[0];
	}

	public string get(string name)
	{
		return GetValues(name.ToUpper())[0];
	}

	public override string ToString()
	{
		StringBuilder nvps = new StringBuilder();
		foreach (string key in Keys)
		{
			nvps.Append(Encode(key, get(key)));
			nvps.Append('&');
		}
		if (nvps.Length > 0)
		{
			nvps.Remove(nvps.Length - 1, 1);
		}
		return nvps.ToString();
	}

	public static string Encode(Field field, string value)
	{
		return Encode(Enum.GetName(typeof(Field), field), value);
	}

	public static string Encode(string key, string val)
	{
		return HttpUtility.UrlEncode(key) + "=" + HttpUtility.UrlEncode(val);
	}
}
