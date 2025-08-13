using System;
using System.IO;
using System.Net;

namespace Roblox.Billing;

/// A csharp binding to Rixty's Name-Value pair protocol. 
public class NVPClient
{
	private string rixtyUrl;

	private string apiUser;

	private string apiPassword;

	private string apiSignature;

	/// Create an NVPClient to issue transactions using the Rixty NVP API.
	///
	/// See the Rixty Administration Guide
	/// for information about setting up your API Profile.
	///
	/// @param rixtyUrl The URL to communicate with Rixty's NVP API
	/// @param apiUser The User specified in your API Profile.
	/// @param apiPassword The Password specified in your API Profile
	/// @param apiSignature The Signature specified in your API Profile
	public NVPClient(string rixtyUrl, string apiUser, string apiPassword, string apiSignature)
	{
		this.rixtyUrl = rixtyUrl;
		this.apiUser = apiUser;
		this.apiPassword = apiPassword;
		this.apiSignature = apiSignature;
	}

	/// Send purchase details to Rixty for approval by a Rixty account holder.
	///
	/// @param amt Amount for this transaction
	/// @param description Description for listing on payments page
	/// @param userid A unique identifier for your user, such as username
	/// @return Name-value pairs: {@link NVPCodec.Field#CHECKOUTURL}, {@link NVPCodec.Field#TOKEN},
	/// @throws NVPException if unsuccessful
	/// @see #getRixtyCheckoutDetails(string token)
	/// @see NVPCodec#encode(Field field, string value)
	public NVPCodec setRixtyCheckout(double amt, string description, string userid)
	{
		return setRixtyCheckout(amt, description, userid, new NVPCodec());
	}

	public NVPCodec setRixtyCheckout(double amt, string description, string userid, NVPCodec extras)
	{
		extras.put(NVPCodec.Field.AMT, string.Concat(amt));
		extras.put(NVPCodec.Field.DESC, description);
		extras.put(NVPCodec.Field.USERID, userid);
		return setRixtyCheckout(extras);
	}

	public NVPCodec setRixtyCheckout(NVPCodec nvps)
	{
		nvps.put(NVPCodec.Field.METHOD, "SetRixtyCheckout");
		return callService(nvps);
	}

	public NVPCodec setRixtyPin(string pin, string type, string userid, string postbackUrl)
	{
		return setRixtyPin(pin, type, userid, postbackUrl, new NVPCodec());
	}

	public NVPCodec setRixtyPin(string pin, string type, string userid, string postbackUrl, NVPCodec extras)
	{
		extras.put(NVPCodec.Field.PIN, pin);
		extras.put(NVPCodec.Field.PAYMENTTYPE, type);
		extras.put(NVPCodec.Field.USERID, userid);
		extras.put(NVPCodec.Field.POSTBACKURL, postbackUrl);
		return setRixtyPin(extras);
	}

	public NVPCodec setRixtyPin(NVPCodec nvps)
	{
		nvps.put(NVPCodec.Field.METHOD, "RedeemPin");
		return callService(nvps);
	}

	/// After a user approves a transaction (initiated via setRixtyCheckout), the details of the transaction
	/// can be retrieved via getRixtyCheckoutDetails.  The transaction is committed via doRixtyCheckoutPayment().
	///
	/// @param token
	/// @return Name-Value pairs {@link NVPCodec.Field#TOKEN}, {@link NVPCodec.Field#SKU}, 
	/// {@link NVPCodec.Field#PAYERID}, {@link NVPCodec.Field#COUNTRYCODE}, {@link NVPCodec.Field#BUTTONSOURCE},
	/// {@link NVPCodec.Field#AMT}, {@link NVPCodec.Field#CURRENCYCODE}, {@link NVPCodec.Field#NOTIFYURL},
	/// {@link NVPCodec.Field#CUSTOM}, {@link NVPCodec.Field#INVNUM}
	/// @throws NVPException if unsuccessful
	/// @see #doRixtyCheckoutPayment(string token, string payerid)
	public NVPCodec getRixtyCheckoutDetails(string token)
	{
		NVPCodec inputs = new NVPCodec();
		inputs.put(NVPCodec.Field.METHOD, "GetRixtyCheckoutDetails");
		inputs.put(NVPCodec.Field.TOKEN, token);
		return callService(inputs);
	}

	/// Commit a transaction that has been approved by the Rixty account holder.
	///
	/// @param token The token identifying the transaction, returned by setRixtyCheckout()
	/// @param payerid The account ID for the Rixty user.  This ID is passed to your RETURNURL, and can also be retrieved
	/// via getRixtyCheckoutDetails()
	/// @return Name-Value pairs: {@link NVPCodec.Field#TRANSACTIONID}, {@link NVPCodec.Field#TRANSACTIONTYPE},
	/// {@link NVPCodec.Field#AMT}, {@link NVPCodec.Field#RETURNURL}, {@link NVPCodec.Field#SETTLEAMT},
	/// {@link NVPCodec.Field#FEEAMT}, {@link NVPCodec.Field#ORDERTIME}, {@link NVPCodec.Field#CURRENCYCODE},
	/// {@link NVPCodec.Field#PAYMENTTYPE}, {@link NVPCodec.Field#PAYMENTSTATUS}
	/// @throws NVPException if unsuccessful
	/// @see #getTransactionDetails(string transactionId)
	public NVPCodec doRixtyCheckoutPayment(string token, string payerid)
	{
		return doRixtyCheckoutPayment(token, payerid, new NVPCodec());
	}

	public NVPCodec doRixtyCheckoutPayment(string token, string payerid, NVPCodec extras)
	{
		extras.put(NVPCodec.Field.METHOD, "DoRixtyCheckoutPayment");
		extras.put(NVPCodec.Field.TOKEN, token);
		extras.put(NVPCodec.Field.PAYERID, payerid);
		return callService(extras);
	}

	/// Get details of a committed transaction.
	/// @param transactionId The transactionID returned by doRixtyCheckoutPayment()
	/// @return Name-Value pairs: {@link NVPCodec.Field#TRANSACTIONID}, {@link NVPCodec.Field#TRANSACTIONTYPE},
	/// {@link NVPCodec.Field#AMT}, {@link NVPCodec.Field#SETTLEAMT}, {@link NVPCodec.Field#FEEAMT}
	/// {@link NVPCodec.Field#ORDERTIME}, {@link NVPCodec.Field#CURRENCYCODE}, {@link NVPCodec.Field#PAYMENTTYPE},
	/// {@link NVPCodec.Field#PAYMENTSTATUS}
	/// @throws NVPException if unsuccessful
	/// @see #doRixtyCheckoutPayment(string token, string payerid)
	public NVPCodec getTransactionDetails(string transactionId)
	{
		NVPCodec inputs = new NVPCodec();
		inputs.put(NVPCodec.Field.METHOD, "GetTransactionDetails");
		inputs.put(NVPCodec.Field.TRANSACTIONID, transactionId);
		return callService(inputs);
	}

	/// Perform a full refund of a committed transaction.
	/// @param transactionId The transactionID returned by doRixtyCheckoutPayment()
	/// @param note optional note to associate with this refund (may be null)
	/// @return Name-Value pairs: {@link NVPCodec.Field#REFUNDTRANSACTIONID}, {@link NVPCodec.Field#FEEREFUNDAMT},
	/// {@link NVPCodec.Field#GROSSREFUNDAMT}, {@link NVPCodec.Field#NETREFUNDAMT}
	/// @throws NVPException if unsuccessful
	public NVPCodec refundTransactionFull(string transactionId, string note)
	{
		NVPCodec inputs = new NVPCodec();
		inputs.put(NVPCodec.Field.METHOD, "RefundTransaction");
		inputs.put(NVPCodec.Field.TRANSACTIONID, transactionId);
		inputs.put(NVPCodec.Field.REFUNDTYPE, "Full");
		if (note != null)
		{
			inputs.put(NVPCodec.Field.NOTE, note);
		}
		return callService(inputs);
	}

	/// Perform a partial refund of a committed transaction.
	///
	/// @param transactionId The transactionID returned by doRixtyCheckoutPayment()
	/// @param amount Amount to refund to the user, in dollars.
	/// @param note Optional note to associate wtih this refund (may be null)
	/// @return Name-Value pairs: {@link NVPCodec.Field#REFUNDTRANSACTIONID}, {@link NVPCodec.Field#FEEREFUNDAMT},
	/// {@link NVPCodec.Field#GROSSREFUNDAMT}, {@link NVPCodec.Field#NETREFUNDAMT}
	/// @throws NVPException if unsuccessful
	public NVPCodec refundTransactionPartial(string transactionId, double amount, string note)
	{
		NVPCodec inputs = new NVPCodec();
		inputs.put(NVPCodec.Field.METHOD, "RefundTransaction");
		inputs.put(NVPCodec.Field.TRANSACTIONID, transactionId);
		inputs.put(NVPCodec.Field.REFUNDTYPE, "Partial");
		inputs.put(NVPCodec.Field.AMT, string.Concat(amount));
		if (note != null)
		{
			inputs.put(NVPCodec.Field.NOTE, note);
		}
		return callService(inputs);
	}

	/// Renew a subscription
	/// @param suscriptionId The subscriptionID originally obtained from getTransactionDetails()
	/// @return Name-Value pairs: {@link NVPCodec.Field#SUBSCRIPTIONID} 
	/// @throws NVPException if unsuccessful
	/// @see #getTransactionDetails(String transactionId)
	public NVPCodec renewSubscription(string subscriptionId)
	{
		NVPCodec inputs = new NVPCodec();
		inputs.put(NVPCodec.Field.METHOD, "RenewSubscription");
		inputs.put(NVPCodec.Field.SUBSCRIPTIONID, subscriptionId);
		return callService(inputs);
	}

	/// Cancel a subscription
	/// @param suscriptionId The subscriptionID originally obtained from getTransactionDetails()
	/// @return Name-Value pairs: {@link NVPCodec.Field#SUBSCRIPTIONID} 
	/// @throws NVPException if unsuccessful
	/// @see #getTransactionDetails(String transactionId)
	public NVPCodec cancelSubscription(string subscriptionId)
	{
		NVPCodec inputs = new NVPCodec();
		inputs.put(NVPCodec.Field.METHOD, "CancelSubscription");
		inputs.put(NVPCodec.Field.SUBSCRIPTIONID, subscriptionId);
		return callService(inputs);
	}

	/// Get details of a subscription
	public NVPCodec getSubscriptionDetails(string subscriptionId)
	{
		NVPCodec inputs = new NVPCodec();
		inputs.put(NVPCodec.Field.METHOD, "GetSubscriptionDetails");
		inputs.put(NVPCodec.Field.SUBSCRIPTIONID, subscriptionId);
		return callService(inputs);
	}

	private void addSignature(NVPCodec nvp)
	{
		nvp.put(NVPCodec.Field.USER, apiUser);
		nvp.put(NVPCodec.Field.PWD, apiPassword);
		nvp.put(NVPCodec.Field.SIGNATURE, apiSignature);
	}

	private NVPCodec callService(NVPCodec nvps)
	{
		addSignature(nvps);
		nvps.put(NVPCodec.Field.VERSION, "2");
		WebRequest webRequest = WebRequest.Create(rixtyUrl);
		webRequest.Method = "POST";
		try
		{
			StreamWriter streamWriter = new StreamWriter(webRequest.GetRequestStream());
			streamWriter.Write(nvps.ToString());
			streamWriter.Close();
		}
		catch (WebException ex)
		{
			Console.WriteLine(ex.Message);
		}
		try
		{
			WebResponse webResponse = webRequest.GetResponse();
			if (webResponse == null)
			{
				return null;
			}
			return new NVPCodec(new StreamReader(webResponse.GetResponseStream()).ReadToEnd().Trim());
		}
		catch (WebException ex2)
		{
			Console.WriteLine(ex2.Message);
		}
		return null;
	}
}
