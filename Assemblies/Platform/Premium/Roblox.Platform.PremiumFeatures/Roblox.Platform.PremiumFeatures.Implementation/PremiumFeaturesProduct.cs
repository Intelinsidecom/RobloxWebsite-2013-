using System;
using Roblox.Billing.Client;
using Roblox.EventLog;
using Roblox.Platform.Core;
using Roblox.Platform.Demographics;
using Roblox.Platform.Localization.Accounts;
using Roblox.Platform.PremiumFeatures.Interfaces;
using Roblox.PremiumFeatures.Client.Interfaces;
using Roblox.Platform.PremiumFeatures.Models.Enums;
using Roblox.Platform.PremiumFeatures.Models.Requests;
using Roblox.Platform.PremiumFeatures.Models.Responses;

namespace Roblox.Platform.PremiumFeatures.Implementation;

/// <summary>
/// Logic layer for PremiumFeatures Products
/// </summary>
public class PremiumFeaturesProduct : IPremiumFeaturesProduct
{
	private const int USACountryId = 1;

	protected readonly IPremiumFeaturesClient PremiumFeaturesClient;

	protected readonly IBillingClient BillingClient;

	protected readonly IAccountCountryAccessor AccountCountryAccessor;

	protected readonly IGeolocationFactory GeolocationFactory;

	protected readonly ILogger Logger;

	/// <summary>
	/// Initialize PremiumFeaturesProduct 
	/// </summary>
	/// <param name="premiumFeaturesClient"><see cref="T:Roblox.PremiumFeatures.Client.Interfaces.IPremiumFeaturesClient" /></param>
	/// <param name="billingClient"><see cref="T:Roblox.Billing.Client.IBillingClient" /></param>
	/// <param name="accountCountryAccessor"><see cref="T:Roblox.Platform.Localization.Accounts.IAccountCountryAccessor" /></param>
	/// <param name="geolocationFactory"><see cref="T:Roblox.Platform.Demographics.IGeolocationFactory" /></param>
	/// <param name="logger"><see cref="T:Roblox.EventLog.ILogger" /></param>
	public PremiumFeaturesProduct(IPremiumFeaturesClient premiumFeaturesClient, IBillingClient billingClient, IAccountCountryAccessor accountCountryAccessor, IGeolocationFactory geolocationFactory, ILogger logger)
	{
		if (premiumFeaturesClient == null) throw new ArgumentNullException("premiumFeaturesClient");
		if (billingClient == null) throw new ArgumentNullException("billingClient");
		if (accountCountryAccessor == null) throw new ArgumentNullException("accountCountryAccessor");
		if (geolocationFactory == null) throw new ArgumentNullException("geolocationFactory");
		if (logger == null) throw new ArgumentNullException("logger");
		PremiumFeaturesClient = premiumFeaturesClient;
		BillingClient = billingClient;
		AccountCountryAccessor = accountCountryAccessor;
		GeolocationFactory = geolocationFactory;
		Logger = logger;
	}

	/// <summary>
	/// Get all available premium feature products for a user
	/// </summary>
	/// <param name="accountId">Account Id</param>
	/// <param name="ip">User IP</param>
	/// <param name="premiumFeatureType"><see cref="T:Roblox.PremiumFeatures.Models.Enums.PremiumFeatureType" /></param>
	/// <param name="isMobile">Is request coming from Mobile</param>
	/// <param name="platformType"></param>
	/// <returns>Collection of <see cref="T:Roblox.PremiumFeatures.Models.Core.PremiumFeaturesAvailableProductModel" /></returns>
	public PremiumFeaturesAvailableProductResponse GetPremiumFeaturesProducts(long accountId, string ip, PremiumFeatureType premiumFeatureType, bool isMobile, PremiumFeaturesProductPlatformType platformType = PremiumFeaturesProductPlatformType.Default)
	{
		PremiumFeatureProductModelResponse response = PremiumFeaturesClient.GetAvailablePremiumFeaturesProducts(premiumFeatureType);
		PremiumFeatureProductDetailRequest request = new PremiumFeatureProductDetailRequest
		{
			PremiumFeatureProducts = response.PremiumFeatureProducts,
			IsMobile = isMobile,
			AccountId = accountId,
			PlatformType = platformType
		};
		try
		{
			request.CountryId = (((accountId != 0L) ? AccountCountryAccessor.GetAccountCountry(accountId) : null)?.CountryId?.Id ?? GeolocationFactory.GetOrCreateGeolocation(ip)?.CountryId) ?? 1;
		}
		catch (Exception e)
		{
			Logger.Error($"Premium Feature can not find country id by account Id {accountId} and IP {ip}. {e}");
		}
		return BillingClient.GetProductDetailFromPremiumFeatureProducts(request);
	}
}
