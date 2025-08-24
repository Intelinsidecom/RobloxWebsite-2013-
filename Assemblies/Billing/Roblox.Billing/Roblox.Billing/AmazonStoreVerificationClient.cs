using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Script.Serialization;
using Roblox.Billing.AmazonStoreExceptions;
using Roblox.Billing.Business_Logic_Layer;
using Roblox.Billing.Properties;
using Roblox.Demographics;
using Roblox.Platform.Email.Delivery;
using Roblox.Platform.Membership;

namespace Roblox.Billing;

/// <summary>
/// Provides common methods for using the Amazon store verification service.
/// </summary>
public class AmazonStoreVerificationClient : VerificationClientBase, IAmazonStoreVerificationClient
{
	private readonly IEmailSender _EmailSender;

	private readonly IUserFactory _UserFactory;

	private const string _EmailType = "AmazonSandboxPurchaseOnLiveSite";

	private bool IsLocalPricingEnabled => Settings.Default.IsLocalPricingEnabled;

	private string MobileLocalPricingSupportedCurrencies => Settings.Default.MobileLocalPricingSupportedCurrencies;

	private bool IsAmazonStoreLocalPricingEnabled => Settings.Default.IsAmazonStoreLocalPricingEnabled;

	private string AmazonStoreLocalPricingSupportedCurrencies => Settings.Default.AmazonStoreLocalPricingSupportedCurrencies;

	/// <summary>
	/// Gets the URL for verifying a receipt with amazon.
	/// </summary>
	protected string AmazonVerificationUrl => Settings.Default.AmazonVerificationUrl;

	/// <summary>
	/// Gets the developer secret that Amazon uses for verification.
	/// </summary>
	protected string AmazonDeveloperSecret => Settings.Default.AmazonDeveloperSecret;

	internal AmazonStoreVerificationClient(IEmailSender emailSender, IUserFactory userFactory)
	{
		_EmailSender = emailSender ?? throw new ArgumentNullException("emailSender");
		_UserFactory = userFactory ?? throw new ArgumentNullException("userFactory");
	}

	/// <summary>
	/// Uses the given JSON response to update the purchase's fields.
	/// </summary>
	/// <param name="jsonResponse">The JSON response.</param>
	private void UpdateFieldsFromJsonResponse(AmazonStoreProofOfPurchase proofOfPurchase, string jsonResponse)
	{
		Dictionary<string, object> jsonObject = new JavaScriptSerializer().Deserialize<Dictionary<string, object>>(jsonResponse);
		proofOfPurchase.AmazonProductId = SafeGet(jsonObject, "productId");
		if (jsonObject.ContainsKey("purchaseDate"))
		{
			proofOfPurchase.PurchaseDate = Convert.ToInt64(jsonObject["purchaseDate"]);
		}
		else
		{
			proofOfPurchase.PurchaseDate = null;
		}
		proofOfPurchase.CancelDate = SafeGet(jsonObject, "cancelDate");
		proofOfPurchase.ProductType = SafeGet(jsonObject, "productType");
		proofOfPurchase.IsTestTransaction = jsonObject.ContainsKey("testTransaction") && Convert.ToBoolean(jsonObject["testTransaction"]);
	}

	/// <summary>
	/// Sends a verification message to Amazon.
	/// </summary>
	/// <param name="amazonUserId">The ID of the Amazon user that made the purchase.</param>
	/// <param name="amazonReceiptId">The ID of the receipt supplied by Amazon.</param>
	/// <returns>If the information was verified, returns a JSON object in the format
	/// <code>
	/// {  
	///     "betaProduct":false,
	///     "productId":"com.amazon.iapsamplev2.gold_medal",
	///     "productType":"CONSUMABLE",
	///     "purchaseDate":1399070221749,
	///     "quantity":1,
	///     "receiptId":"wE1EG1gsEZI9q9UnI5YoZ2OxeoVKPdR5bvPMqyKQq5Y=:1:11",
	///     "testTransaction":true
	/// }
	/// </code>
	/// If the verification failed then the call throws a <see cref="T:System.Net.WebException" />.
	/// Amazon indicates verification failure through status codes:<br />
	/// HTTP 400 - The transaction represented by this receipt ID is invalid.<br />
	/// HTTP 496 - Invalid sharedSecret.<br />
	/// HTTP 497 - Invalid user ID.<br />
	/// HTTP 500 - Internal server error.
	/// </returns>
	/// <exception cref="T:System.Net.WebException">Thrown if there was an error getting a response from Amazon.</exception>
	private string SendVerification(string amazonUserId, string amazonReceiptId)
	{
		using WebClient webClient = new WebClient();
		string uri = string.Format(AmazonVerificationUrl, AmazonDeveloperSecret, amazonUserId, amazonReceiptId);
		return webClient.DownloadString(uri);
	}

	/// <summary>
	/// Verifies the proof of purchase and updates its data with data provided by Amazon.
	/// </summary>
	/// <returns>The verified purchase.</returns>
	/// <exception cref="T:System.Net.WebException">Thrown if the validation with amazon failed.</exception>
	public IPurchase Verify(AmazonStoreProofOfPurchase proofOfPurchase)
	{
		string response = SendVerification(proofOfPurchase.AmazonUserId, proofOfPurchase.AmazonReceiptId);
		UpdateFieldsFromJsonResponse(proofOfPurchase, response);
		if (proofOfPurchase.IsTestTransaction)
		{
			List<string> accountIds = new List<string>(Settings.Default.AmazonStoreTestAccountIDs.Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries));
			if (!Settings.Default.AmazonStoreTestAccountFallbackEnabled || !accountIds.Contains(proofOfPurchase.AccountId.ToString()))
			{
				throw new VerificationFailedException("Amazon receipt verification for receipt '" + proofOfPurchase.AmazonReceiptId + "' response indicated transaction was a test transaction");
			}
			string accountName = GetUserNameFromAmazonProofOfPurchase(proofOfPurchase) ?? "Unable to find Username.";
			Email email = new Email("noreply@roblox.com", Settings.Default.AmazonStoreTestAccountEmailAlert, "Amazon Test account purchase attempted on live site.", EmailBodyType.Plain, "AmazonSandboxPurchaseOnLiveSite", $"AccountID: {proofOfPurchase.AccountId}{Environment.NewLine}Username: {accountName}{Environment.NewLine}Receipt: {proofOfPurchase.AmazonReceiptId}");
			_EmailSender.SendEmail(email);
		}
		try
		{
			IProduct product = AmazonStoreProductFactory.GetProductFromAmazonProductId(proofOfPurchase.AmazonProductId);
			CountryCurrency countryCurrency = CountryCurrency.GetByCountryTypeIDAndCurrencyTypeID(Country.GetUSACountry().ID, CurrencyType.GetUSDCurrencyTypeID);
			HashSet<string> mobileEnabledCurrencies = new HashSet<string>(MobileLocalPricingSupportedCurrencies.Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries));
			HashSet<string> amazonStoreLocalPricingEnabledCurrencies = new HashSet<string>(AmazonStoreLocalPricingSupportedCurrencies.Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries));
			if (IsLocalPricingEnabled && IsAmazonStoreLocalPricingEnabled && amazonStoreLocalPricingEnabledCurrencies.Any())
			{
				countryCurrency = GetCountryCurrencyForPurchaser(proofOfPurchase.AccountId, amazonStoreLocalPricingEnabledCurrencies, _UserFactory);
			}
			else if (IsLocalPricingEnabled && mobileEnabledCurrencies.Any())
			{
				countryCurrency = GetCountryCurrencyForPurchaser(proofOfPurchase.AccountId, mobileEnabledCurrencies, _UserFactory);
			}
			return PurchaseFactory.Singleton.GetPurchase(product, PaymentProviderType.AmazonStore, countryCurrency);
		}
		catch
		{
			throw new PurchaseFailedException(proofOfPurchase.AmazonProductId);
		}
	}

	/// <summary>
	/// Gets the username from the given proofOfPurchase.
	/// </summary>
	/// <param name="proofOfPurchase">The Amazon proofOfPurchase we are going to get the username for.</param>
	/// <returns>The username attatched to the proofOfPurchase.AccountId. If no account or username exists it returns null.</returns>
	private string GetUserNameFromAmazonProofOfPurchase(AmazonStoreProofOfPurchase proofOfPurchase)
	{
		return Account.Get(proofOfPurchase.AccountId)?.Name;
	}
}
