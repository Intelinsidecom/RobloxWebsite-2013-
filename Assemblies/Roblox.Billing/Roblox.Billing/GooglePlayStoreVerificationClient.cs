using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Google;
using Roblox.Billing.Business_Logic_Layer;
using Roblox.Billing.GooglePlayStoreExceptions;
using Roblox.Billing.Properties;
using Roblox.Demographics;
using Roblox.GoogleAPI.Interfaces;
using Roblox.Platform.Membership;

namespace Roblox.Billing;

public class GooglePlayStoreVerificationClient : VerificationClientBase, IGooglePlayStoreVerificationClient
{
	private const int _InformationLogLevel = 1;

	private const int _WarningLogLevel = 2;

	private readonly IUserFactory _UserFactory;

	private bool IsLocalPricingEnabled => Settings.Default.IsLocalPricingEnabled;

	private string MobileLocalPricingSupportedCurrencies => Settings.Default.MobileLocalPricingSupportedCurrencies;

	private bool IsGooglePlayStoreLocalPricingEnabled => Settings.Default.IsGooglePlayStoreLocalPricingEnabled;

	private string GooglePlayStoreLocalPricingSupportedCurrencies => Settings.Default.GooglePlayStoreLocalPricingSupportedCurrencies;

	public IAndroidPublisher GoogleClient { get; private set; }

	public GooglePlayStoreVerificationClient(IAndroidPublisher googleClient, IUserFactory userFactory)
	{
		GoogleClient = googleClient;
		_UserFactory = userFactory ?? throw new ArgumentNullException("userFactory");
	}

	public IPurchase Verify(GooglePlayStoreProofOfPurchase proofOfPurchase, Action<string, int> checkoutSessionLogger, IPurchaser purchaser)
	{
		//IL_00c3: Expected O, but got Unknown
		try
		{
			checkoutSessionLogger($"Before contacting Google endpoint - ProductId: {proofOfPurchase.PlayStoreProductId}, Token: {proofOfPurchase.Token}", 1);
			IInAppPurchase inAppPurchase = GoogleClient.GetInAppPurchase(proofOfPurchase.PackageName, proofOfPurchase.PlayStoreProductId, proofOfPurchase.Token);
			proofOfPurchase.Response = new GooglePlayStoreProofOfPurchase.PurchaseResponse
			{
				PurchaseTime = inAppPurchase.PurchaseTime.Value,
				PurchaseState = inAppPurchase.PurchaseState.Value,
				ConsumptionState = inAppPurchase.ConsumptionState.Value,
				DeveloperPayload = inAppPurchase.DeveloperPayload
			};
			checkoutSessionLogger($"After contacting Google endpoint - ProductId: {proofOfPurchase.PlayStoreProductId} - ConsumptionState: {inAppPurchase.ConsumptionState.Value}", 1);
		}
		catch (GoogleApiException val)
		{
			GoogleApiException gEx = val;
			checkoutSessionLogger($"Hit GoogleApiException on GooglePlayStoreVerificationClient.Verify - Message: {((Exception)(object)gEx).Message} HTTP Status Code: {gEx.HttpStatusCode}", 2);
			if (gEx.HttpStatusCode == HttpStatusCode.NotFound)
			{
				throw new VerificationFailedException("Token Not Found", proofOfPurchase.PackageName, proofOfPurchase.PlayStoreProductId, proofOfPurchase.Token);
			}
			if (gEx.HttpStatusCode == HttpStatusCode.Unauthorized)
			{
				throw new VerificationFailedException("Unauthorized Token", proofOfPurchase.PackageName, proofOfPurchase.PlayStoreProductId, proofOfPurchase.Token);
			}
			if (gEx.HttpStatusCode == HttpStatusCode.BadRequest)
			{
				throw new VerificationFailedException("Bad Formatted Token", proofOfPurchase.PackageName, proofOfPurchase.PlayStoreProductId, proofOfPurchase.Token);
			}
			throw;
		}
		catch (Exception ex4)
		{
			checkoutSessionLogger($"Hit a general exception on GooglePlayStoreVerificationClient.Verify - Message: {ex4.Message}", 2);
			throw;
		}
		if (proofOfPurchase.Response.PurchaseState != 0)
		{
			checkoutSessionLogger("PurchaseState was not marked as Purchased on GooglePlayStoreVerificationClient.Verify", 1);
			throw new PurchaseCancelledException(proofOfPurchase.Token);
		}
		if (proofOfPurchase.Response.ConsumptionState == 1)
		{
			checkoutSessionLogger("ConsumptionState was marked as Consumed on GooglePlayStoreVerificationClient.Verify", 1);
			if (!Settings.Default.IsConsumedProductMustBeGrantedWhenPaymentNotExistsEnabled || GooglePlayStorePaymentProvider.IsDuplicatePurchase(proofOfPurchase))
			{
				checkoutSessionLogger("ProofOfPurchase was identified as duplicated on GooglePlayStoreVerificationClient.Verify", 1);
				throw new PurchaseAlreadyConsumedException(proofOfPurchase.Token);
			}
			checkoutSessionLogger($"ProofOfPurchase was identified as Consumed but not a duplicate on GooglePlayStoreVerificationClient.Verify - Token:{proofOfPurchase.Token}", 1);
		}
		IPurchase purchase = null;
		IProduct product = null;
		CountryCurrency countryCurrency = null;
		try
		{
			product = GooglePlayStoreProductFactory.Singleton.GetProduct(proofOfPurchase.PlayStoreProductId);
		}
		catch (Exception ex3)
		{
			checkoutSessionLogger($"Hit a general exception on GooglePlayStoreVerificationClient.Verify while trying GetProduct - Message: {ex3.Message}", 2);
			throw new PurchaseFailedException(proofOfPurchase.PlayStoreProductId);
		}
		try
		{
			HashSet<string> mobileEnabledCurrencies = new HashSet<string>(MobileLocalPricingSupportedCurrencies.Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries));
			HashSet<string> googlePlayStoreLocalPricingEnabledCurrencies = new HashSet<string>(GooglePlayStoreLocalPricingSupportedCurrencies.Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries));
			countryCurrency = ((IsLocalPricingEnabled && IsGooglePlayStoreLocalPricingEnabled && googlePlayStoreLocalPricingEnabledCurrencies.Any()) ? GetCountryCurrencyForPurchaser(purchaser.Id, googlePlayStoreLocalPricingEnabledCurrencies, _UserFactory) : ((!IsLocalPricingEnabled || !mobileEnabledCurrencies.Any()) ? CountryCurrency.GetByCountryTypeIDAndCurrencyTypeID(Country.GetUSACountry().ID, CurrencyType.GetUSDCurrencyTypeID) : GetCountryCurrencyForPurchaser(purchaser.Id, mobileEnabledCurrencies, _UserFactory)));
		}
		catch (Exception ex2)
		{
			checkoutSessionLogger($"Hit a general exception on GooglePlayStoreVerificationClient.Verify while trying to determine CountryCurrency - Message: {ex2.Message}", 2);
			throw new PurchaseFailedException(proofOfPurchase.PlayStoreProductId);
		}
		try
		{
			return PurchaseFactory.Singleton.GetPurchase(product, PaymentProviderType.GooglePlayStore, countryCurrency);
		}
		catch (Exception ex)
		{
			checkoutSessionLogger($"Hit a general exception on GooglePlayStoreVerificationClient.Verify while trying GetPurchase - Message: {ex.Message}", 2);
			throw new PurchaseFailedException(proofOfPurchase.PlayStoreProductId);
		}
	}
}
