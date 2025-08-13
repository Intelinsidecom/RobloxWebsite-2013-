using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web.Script.Serialization;
using Roblox.Billing.AppleAppStoreExceptions;
using Roblox.Billing.Business_Logic_Layer;
using Roblox.Billing.Properties;
using Roblox.Demographics;
using Roblox.FloodCheckers;
using Roblox.Platform.Email.Delivery;
using Roblox.Platform.Membership;

namespace Roblox.Billing;

public class AppleAppStoreVerificationClient : VerificationClientBase, IAppleAppStoreVerificationClient
{
	private const int _InformationLogLevel = 1;

	private const int _WarningLogLevel = 2;

	private const string _EmailType = "AppleSandboxPurchaseOnLiveSite";

	private readonly IEmailSender _EmailSender;

	private readonly IUserFactory _UserFactory;

	private bool IsLocalPricingEnabled => Settings.Default.IsLocalPricingEnabled;

	private string MobileLocalPricingSupportedCurrencies => Settings.Default.MobileLocalPricingSupportedCurrencies;

	private bool IsAppleAppStoreLocalPricingEnabled => Settings.Default.IsAppleAppStoreLocalPricingEnabled;

	private string AppleAppStoreLocalPricingSupportedCurrencies => Settings.Default.AppleAppStoreLocalPricingSupportedCurrencies;

	internal AppleAppStoreVerificationClient(IEmailSender emailSender, IUserFactory userFactory)
	{
		_EmailSender = emailSender ?? throw new ArgumentNullException("emailSender");
		_UserFactory = userFactory ?? throw new ArgumentNullException("userFactory");
	}

	private string VerifyPurchase(byte[] receiptTicket)
	{
		return VerifyPurchase(receiptTicket, Settings.Default.AppleAppStoreVerificationEndpoint);
	}

	private string VerifyPurchase(byte[] receiptTicket, string verificationEndpoint)
	{
		WebRequest verificationRequest = WebRequest.Create(verificationEndpoint);
		verificationRequest.Method = "POST";
		verificationRequest.ContentType = "application/json";
		using (Stream requestStream = verificationRequest.GetRequestStream())
		{
			requestStream.Write(receiptTicket, 0, receiptTicket.Length);
		}
		using WebResponse webResponse = verificationRequest.GetResponse();
		using Stream responseStream = webResponse.GetResponseStream();
		string characterSet = (webResponse as HttpWebResponse).CharacterSet;
		Encoding encoding = (string.IsNullOrEmpty(characterSet) ? Encoding.UTF8 : Encoding.GetEncoding(characterSet));
		using StreamReader streamReader = new StreamReader(responseStream, encoding);
		return streamReader.ReadToEnd();
	}

	public IPurchase Verify(AppleAppStoreProofOfPurchase proofOfPurchase, Action<string, int> checkoutSessionLogger)
	{
		Dictionary<string, string> receiptData = new Dictionary<string, string>();
		receiptData.Add("receipt-data", proofOfPurchase.Receipt);
		JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
		string receiptDataJson = javaScriptSerializer.Serialize(receiptData);
		byte[] receiptTicket = Encoding.ASCII.GetBytes(receiptDataJson);
		try
		{
			checkoutSessionLogger($"Before contacting Apple endpoint - ProductId: {proofOfPurchase.ProductId}", 1);
			string verifiedReceiptJson = VerifyPurchase(receiptTicket);
			checkoutSessionLogger($"After contacting Apple endpoint - ProductId: {proofOfPurchase.ProductId}", 1);
			Dictionary<string, object> verifiedReceipt = javaScriptSerializer.Deserialize<Dictionary<string, object>>(verifiedReceiptJson);
			proofOfPurchase.Status = (int)verifiedReceipt["status"];
			if (!proofOfPurchase.IsVerified)
			{
				if (!CheckForSandboxFallBackEligibility(proofOfPurchase))
				{
					if (Settings.Default.AppleAppStoreLogReceiptOnVerifyFailure)
					{
						throw new VerificationFailedException($"Apple returned status {proofOfPurchase.Status} (expected 0) for purchase by AccountID {proofOfPurchase.AccountId}.  JSON: {verifiedReceiptJson}  Receipt: {proofOfPurchase.Receipt}");
					}
					throw new VerificationFailedException($"Apple returned status {proofOfPurchase.Status} (expected 0) for purchase by AccountID {proofOfPurchase.AccountId}.  JSON: {verifiedReceiptJson}");
				}
				verifiedReceiptJson = VerifyPurchase(receiptTicket, Settings.Default.AppleAppStoreSandboxVerificationEndpoint);
				verifiedReceipt = javaScriptSerializer.Deserialize<Dictionary<string, object>>(verifiedReceiptJson);
				proofOfPurchase.Status = (int)verifiedReceipt["status"];
				if (!proofOfPurchase.IsVerified)
				{
					if (Settings.Default.AppleAppStoreLogReceiptOnVerifyFailure)
					{
						throw new VerificationFailedException($"Apple returned status {proofOfPurchase.Status} (expected 0) for purchase by AccountID {proofOfPurchase.AccountId}.  JSON: {verifiedReceiptJson}  Receipt: {proofOfPurchase.Receipt}");
					}
					throw new VerificationFailedException($"Apple returned status {proofOfPurchase.Status} (expected 0) for purchase by AccountID {proofOfPurchase.AccountId}.  JSON: {verifiedReceiptJson}");
				}
			}
			Dictionary<string, object> receipt = (Dictionary<string, object>)verifiedReceipt["receipt"];
			string productId = SafeGet(receipt, "product_id");
			if (!productId.StartsWith("com.roblox"))
			{
				throw new VerificationFailedException("Invalid Product");
			}
			proofOfPurchase.AppItemId = SafeGet(receipt, "app_item_id");
			proofOfPurchase.Bid = SafeGet(receipt, "bid");
			proofOfPurchase.BVRS = SafeGet(receipt, "bvrs");
			proofOfPurchase.ItemId = SafeGet(receipt, "item_id");
			proofOfPurchase.OriginalPurchaseDate = SafeGet(receipt, "original_purchase_date");
			proofOfPurchase.OriginalTransactionId = SafeGet(receipt, "original_transaction_id");
			proofOfPurchase.ProductId = productId;
			proofOfPurchase.PurchaseDate = SafeGet(receipt, "purchase_date");
			proofOfPurchase.Quantity = SafeGet(receipt, "quantity");
			proofOfPurchase.TransactionId = SafeGet(receipt, "transaction_id");
			proofOfPurchase.VersionExternalIdentifier = SafeGet(receipt, "version_external_identifier");
		}
		catch (VerificationFailedException ex2)
		{
			checkoutSessionLogger($"Hit AppleAppStoreExceptions.VerificationFailedException on AppleAppStoreVerificationClient.Verify - Message: {ex2.Message}", 2);
			throw;
		}
		IPurchase purchase = null;
		try
		{
			IProduct product = AppleAppStoreProductFactory.Singleton.GetProduct(proofOfPurchase.ProductId);
			if (Settings.Default.AppleAppStoreUseProductPrice)
			{
				CountryCurrency countryCurrency = CountryCurrency.GetByCountryTypeIDAndCurrencyTypeID(Country.GetUSACountry().ID, CurrencyType.GetUSDCurrencyTypeID);
				HashSet<string> mobileEnabledCurrencies = new HashSet<string>(MobileLocalPricingSupportedCurrencies.Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries));
				HashSet<string> appleAppStoreEnabledCurrencies = new HashSet<string>(AppleAppStoreLocalPricingSupportedCurrencies.Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries));
				if (IsLocalPricingEnabled && IsAppleAppStoreLocalPricingEnabled && appleAppStoreEnabledCurrencies.Any())
				{
					countryCurrency = GetCountryCurrencyForPurchaser(proofOfPurchase.AccountId, appleAppStoreEnabledCurrencies, _UserFactory);
				}
				else if (IsLocalPricingEnabled && mobileEnabledCurrencies.Any())
				{
					countryCurrency = GetCountryCurrencyForPurchaser(proofOfPurchase.AccountId, mobileEnabledCurrencies, _UserFactory);
				}
				return PurchaseFactory.Singleton.GetPurchase(product, PaymentProviderType.AppleAppStore, countryCurrency);
			}
			return PurchaseFactory.Singleton.GetPurchase(product);
		}
		catch (Exception ex)
		{
			checkoutSessionLogger($"Hit general Exception in AppleAppStoreVerificationClient.Verify - Message: {ex.Message}", 2);
			proofOfPurchase.Status = 2;
			throw new PurchaseFailedException(proofOfPurchase.ProductId);
		}
	}

	private bool CheckForSandboxFallBackEligibility(AppleAppStoreProofOfPurchase proofOfPurchase)
	{
		if (proofOfPurchase.Status != 21007)
		{
			return false;
		}
		string accountName = GetUserNameFromAppleProofOfPurchase(proofOfPurchase) ?? "Unable to find Username.";
		Email email = new Email("noreply@roblox.com", Settings.Default.AppleAppStoreSandboxEmailAlert, "Apple App Store Sandbox purchase attempted on live site.", EmailBodyType.Plain, "AppleSandboxPurchaseOnLiveSite", $"AccountID: {proofOfPurchase.AccountId}{Environment.NewLine}Username: {accountName}{Environment.NewLine}Receipt: {proofOfPurchase.Receipt}");
		_EmailSender.SendEmail(email);
		ExceptionHandler.LogException("Apple App Store Sandbox purchase attempted on live site.  AccountID: " + proofOfPurchase.AccountId + "  Receipt:  " + proofOfPurchase.Receipt);
		if (!Settings.Default.AppleAppStoreSandboxFallbackEnabled)
		{
			return false;
		}
		if (!new List<string>(Settings.Default.AppleAppStoreSandboxValidAccountIDs.Split(',')).Contains(proofOfPurchase.AccountId.ToString()))
		{
			return false;
		}
		AppleAppStoreSandboxFloodCheck floodChecker = new AppleAppStoreSandboxFloodCheck();
		if (floodChecker.IsFlooded())
		{
			return false;
		}
		floodChecker.UpdateCount();
		return true;
	}

	/// <summary>
	/// Gets the username from the given proofOfPurchase.
	/// </summary>
	/// <param name="proofOfPurchase">The Apple proofOfPurchase we are going to get the username for.</param>
	/// <returns>The username attatched to the proofOfPurchase.AccountId. If no account or username exists it returns null.</returns>
	private string GetUserNameFromAppleProofOfPurchase(AppleAppStoreProofOfPurchase proofOfPurchase)
	{
		return Account.Get(proofOfPurchase.AccountId)?.Name;
	}
}
