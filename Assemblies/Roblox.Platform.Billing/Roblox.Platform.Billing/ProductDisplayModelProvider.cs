using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Billing;
using Roblox.Billing.Business_Logic_Layer;
using Roblox.Platform.Billing.Properties;
using Roblox.PremiumFeatures;
using Roblox.PremiumFeatures.Models.Core;

namespace Roblox.Platform.Billing;

public class ProductDisplayModelProvider : IProductDisplayModelProvider
{
	private const string _BCImageFile = "BC_L";

	private const string _TBCImageFile = "TBC_L";

	private const string _OBCImageFile = "OBC_L";

	private const string _RobuxImageFile = "RB_L";

	private const string _GiftCardImageFile = "GC_L";

	private const string _USDCurrencySymbol = "$";

	private const string _BCProductName = "Builders Club";

	private const string _TBCProductName = "Turbo Builders Club";

	private const string _OBCProductName = "Outrageous Builders Club";

	private const string _PremiumName = "Roblox Premium";

	private const string _MonthlyDuration = "Monthly";

	private const string _EverySixMonthsDuration = "Every 6 Months";

	private const string _AnnuallyDuration = "Annually";

	private const string _SixMonthsDuration = "6 Months";

	private const string _TwelveMonthsDuration = "12 Months";

	private const string _LifeTimeDuration = "Lifetime";

	private const string _ThirtyDaysDuration = "30 Days";

	private const string _FortyFiveDaysDuration = "45 Days";

	private readonly Product _Premium400Robux = Product.Get("Premium 400 Robux");

	private readonly Product _Premium800Robux = Product.Get("Premium 800 Robux");

	private readonly Product _Premium1700Robux = Product.Get("Premium 1700 Robux");

	private readonly Product _Premium4500Robux = Product.Get("Premium 4500 Robux");

	private readonly Product _Premium10000Robux = Product.Get("Premium 10000 Robux");

	private readonly Product _Premium440Subscribed = Product.Get("Premium 440 Subscribed");

	private readonly Product _Premium880Subscribed = Product.Get("Premium 880 Subscribed");

	private readonly Product _Premium1870Subscribed = Product.Get("Premium 1870 Subscribed");

	private readonly Product _Premium4950Subscribed = Product.Get("Premium 4950 Subscribed");

	private readonly Product _Premium11000Subscribed = Product.Get("Premium 11000 Subscribed");

	private bool _isPremiumIconEnabled;

	private Dictionary<int, ProductDisplayModel> ProductDisplays { get; set; }

	private Dictionary<int, ProductDisplayModel> UpsellRobuxDisplays { get; set; }

	private Dictionary<int, ProductDisplayModel> UpsellBcDisplays { get; set; }

	public ProductDisplayModelProvider(IEnumerable<PremiumFeaturesAvailableProductModel> premiumProductList)
	{
		InitializeProductDisplays(premiumProductList);
		InitializeUpsellRobuxList();
		InitializeUpsellBcList();
	}

	private void InitializeProductDisplays(IEnumerable<PremiumFeaturesAvailableProductModel> premiumProductList)
	{
		ProductDisplays = new Dictionary<int, ProductDisplayModel>();
		DateTime now = DateTime.Now;
		foreach (ProductDisplayModel bcProduct in GetDisplayedBuildersClubProducts())
		{
			ProductDisplays.Add(bcProduct.ProductId, bcProduct);
		}
		string displayName = (_isPremiumIconEnabled ? "Roblox Premium" : "Builders Club");
		ProductDisplays.Add(Product.BC30DaysID, new ProductDisplayModel(Product.BC30DaysID, displayName, "30 Days", now.AddDays(30.0), PremiumFeature.BC30Days.IsRenewal, "BC_L"));
		ProductDisplays.Add(Product.BC45DaysID, new ProductDisplayModel(Product.BC45DaysID, displayName, "45 Days", now.AddDays(45.0), PremiumFeature.BC45Days.IsRenewal, "BC_L"));
		foreach (ProductDisplayModel premiumProduct in GetDisplayPremiumProducts(premiumProductList))
		{
			ProductDisplays.Add(premiumProduct.ProductId, premiumProduct);
		}
		foreach (Product giftcardProduct in GetGiftcardProducts())
		{
			ProductDisplays.Add(giftcardProduct.ID, new ProductDisplayModel(giftcardProduct.ID, giftcardProduct.Name, "", null, renewable: false, "GC_L"));
		}
	}

	private void InitializeUpsellRobuxList()
	{
		UpsellRobuxDisplays = new Dictionary<int, ProductDisplayModel>();
		UpsellRobuxDisplays.Add(_Premium800Robux.ID, new ProductDisplayModel(_Premium800Robux.ID, _Premium800Robux.Name.Replace("Premium", ""), "", null, renewable: false, "RB_L"));
		UpsellRobuxDisplays.Add(_Premium1700Robux.ID, new ProductDisplayModel(_Premium1700Robux.ID, _Premium1700Robux.Name.Replace("Premium", ""), "", null, renewable: false, "RB_L"));
		UpsellRobuxDisplays.Add(_Premium4500Robux.ID, new ProductDisplayModel(_Premium4500Robux.ID, _Premium4500Robux.Name.Replace("Premium", ""), "", null, renewable: false, "RB_L"));
	}

	private void InitializeUpsellBcList()
	{
		UpsellBcDisplays = new Dictionary<int, ProductDisplayModel>();
		DateTime now = DateTime.Now;
		UpsellBcDisplays.Add(Product.BCMonthlyID, new ProductDisplayModel(Product.BCMonthlyID, "Builders Club", "Monthly", now.AddMonths(1), PremiumFeature.BCMonthly.IsRenewal, "BC_L", ProductRank.BC, PremiumFeature.BCMonthly.ID));
		UpsellBcDisplays.Add(Product.TBCMonthlyID, new ProductDisplayModel(Product.TBCMonthlyID, "Turbo Builders Club", "Monthly", now.AddMonths(1), PremiumFeature.TBCMonthly.IsRenewal, "TBC_L", ProductRank.TBC, PremiumFeature.TBCMonthly.ID));
		UpsellBcDisplays.Add(Product.OBCMonthlyID, new ProductDisplayModel(Product.OBCMonthlyID, "Outrageous Builders Club", "Monthly", now.AddMonths(1), PremiumFeature.OBCMonthly.IsRenewal, "OBC_L", ProductRank.OBC, PremiumFeature.OBCMonthly.ID));
	}

	public IEnumerable<ProductDisplayModel> GetDisplayPremiumProducts(IEnumerable<PremiumFeaturesAvailableProductModel> premiumProductList)
	{
		DateTime now = DateTime.Now;
		List<ProductDisplayModel> premiumcProducts = new List<ProductDisplayModel>();
		foreach (PremiumFeaturesAvailableProductModel item in premiumProductList ?? Enumerable.Empty<PremiumFeaturesAvailableProductModel>())
		{
			int premiumProductId = Convert.ToInt32(item.ProductId);
			bool isSubscription = item.PremiumFeatureTypeName == "Subscription";
			string name = item.Description;
			string duration = (isSubscription ? "Monthly" : "");
			string productImageFile = (isSubscription ? null : "RB_L");
			DateTime? expiredDate = (isSubscription ? new DateTime?(now.AddMonths(1)) : null);
			premiumcProducts.Add(new ProductDisplayModel(premiumProductId, name, duration, expiredDate, isSubscription, productImageFile));
		}
		return premiumcProducts;
	}

	public IEnumerable<ProductDisplayModel> GetDisplayedBuildersClubProducts()
	{
		List<ProductDisplayModel> bcProducts = new List<ProductDisplayModel>();
		DateTime now = DateTime.Now;
		bcProducts.Add(new ProductDisplayModel(Product.BCMonthlyID, "Builders Club", "Monthly", now.AddMonths(1), PremiumFeature.BCMonthly.IsRenewal, "BC_L", ProductRank.BC, PremiumFeature.BCMonthly.ID));
		bcProducts.Add(new ProductDisplayModel(Product.TBCMonthlyID, "Turbo Builders Club", "Monthly", now.AddMonths(1), PremiumFeature.TBCMonthly.IsRenewal, "TBC_L", ProductRank.TBC, PremiumFeature.TBCMonthly.ID));
		bcProducts.Add(new ProductDisplayModel(Product.OBCMonthlyID, "Outrageous Builders Club", "Monthly", now.AddMonths(1), PremiumFeature.OBCMonthly.IsRenewal, "OBC_L", ProductRank.OBC, PremiumFeature.OBCMonthly.ID));
		if (!Settings.Default.RemoveSixMonthAndLifetimeBCEnabled)
		{
			bcProducts.Add(new ProductDisplayModel(Product.BC6MonthsRenewalID, "Builders Club", "Every 6 Months", now.AddMonths(6), PremiumFeature.BC6MonthsRenewing.IsRenewal, "BC_L", ProductRank.BC, PremiumFeature.BC6MonthsRenewing.ID));
			bcProducts.Add(new ProductDisplayModel(Product.TBC6MonthsRenewalID, "Turbo Builders Club", "Every 6 Months", now.AddMonths(6), PremiumFeature.TBC6MonthsRenewing.IsRenewal, "TBC_L", ProductRank.TBC, PremiumFeature.TBC6MonthsRenewing.ID));
			bcProducts.Add(new ProductDisplayModel(Product.OBC6MonthsRenewalID, "Outrageous Builders Club", "Every 6 Months", now.AddMonths(6), PremiumFeature.OBC6MonthsRenewing.IsRenewal, "OBC_L", ProductRank.OBC, PremiumFeature.OBC6MonthsRenewing.ID));
		}
		bcProducts.Add(new ProductDisplayModel(Product.BC12MonthsRenewalID, "Builders Club", "Annually", now.AddMonths(12), PremiumFeature.BC12MonthsRenewing.IsRenewal, "BC_L", ProductRank.BC, PremiumFeature.BC12MonthsRenewing.ID));
		bcProducts.Add(new ProductDisplayModel(Product.TBC12MonthsRenewalID, "Turbo Builders Club", "Annually", now.AddMonths(12), PremiumFeature.TBC12MonthsRenewing.IsRenewal, "TBC_L", ProductRank.TBC, PremiumFeature.TBC12MonthsRenewing.ID));
		bcProducts.Add(new ProductDisplayModel(Product.OBC12MonthsRenewalID, "Outrageous Builders Club", "Annually", now.AddMonths(12), PremiumFeature.OBC12MonthsRenewing.IsRenewal, "OBC_L", ProductRank.OBC, PremiumFeature.OBC12MonthsRenewing.ID));
		if (!Settings.Default.RemoveSixMonthAndLifetimeBCEnabled)
		{
			bcProducts.Add(new ProductDisplayModel(Product.BCLifetimeID, "Builders Club", "Lifetime", now.AddYears(100), PremiumFeature.BCLifetime.IsRenewal, "BC_L", ProductRank.BC, PremiumFeature.BCLifetime.ID));
			bcProducts.Add(new ProductDisplayModel(Product.TBCLifetimeID, "Turbo Builders Club", "Lifetime", now.AddYears(100), PremiumFeature.TBCLifetime.IsRenewal, "TBC_L", ProductRank.TBC, PremiumFeature.TBCLifetime.ID));
			bcProducts.Add(new ProductDisplayModel(Product.OBCLifetimeID, "Outrageous Builders Club", "Lifetime", now.AddYears(100), PremiumFeature.OBCLifetime.IsRenewal, "OBC_L", ProductRank.OBC, PremiumFeature.OBCLifetime.ID));
		}
		return bcProducts;
	}

	public IEnumerable<ProductDisplayModel> GetUpsellProducts(byte paymentProviderTypeId, int countryCurrencyId, byte mainProductGroupId)
	{
		if (mainProductGroupId == ProductGroup.BC.ID)
		{
			return GetUpsellRobuxList(paymentProviderTypeId, countryCurrencyId);
		}
		if (mainProductGroupId == ProductGroup.Robux.ID)
		{
			return GetUpsellBcList(paymentProviderTypeId, countryCurrencyId);
		}
		return null;
	}

	public ProductDisplayModel GetByProductId(int productId)
	{
		if (ProductDisplays.TryGetValue(productId, out var selectedProduct))
		{
			return selectedProduct.Clone();
		}
		return null;
	}

	public bool IsUpsellRobuxProduct(int productId)
	{
		return UpsellRobuxDisplays.ContainsKey(productId);
	}

	public bool IsUpsellBcProduct(int productId)
	{
		return UpsellBcDisplays.ContainsKey(productId);
	}

	public IEnumerable<ProductPair> ConstructRobuxPairList()
	{
		return new List<ProductPair>
		{
			new ProductPair(_Premium400Robux, _Premium440Subscribed),
			new ProductPair(_Premium800Robux, _Premium880Subscribed),
			new ProductPair(_Premium1700Robux, _Premium1870Subscribed),
			new ProductPair(_Premium4500Robux, _Premium4950Subscribed),
			new ProductPair(_Premium10000Robux, _Premium11000Subscribed)
		};
	}

	public bool GetPremiumRobuxProductIdFromNonPremiumRobux(int productId, out int bcProductId)
	{
		bcProductId = productId;
		ProductPair selectedPair = ConstructRobuxPairList().ToList().FirstOrDefault((ProductPair x) => x.NBCProduct.ID == productId);
		if (selectedPair != null)
		{
			bcProductId = selectedPair.BCProduct.ID;
			return true;
		}
		return false;
	}

	private IEnumerable<ProductDisplayModel> GetUpsellRobuxList(byte paymentProviderTypeId, int countryCurrencyId)
	{
		List<ProductDisplayModel> upsellList = new List<ProductDisplayModel>();
		CountryCurrency countryCurrency = CountryCurrency.Get(countryCurrencyId);
		string currencySymbol = ((countryCurrency != null) ? Roblox.Billing.Business_Logic_Layer.CurrencyType.Get(countryCurrency.CurrencyTypeID).Symbol : "$");
		foreach (ProductDisplayModel displayModel in UpsellRobuxDisplays.Select((KeyValuePair<int, ProductDisplayModel> upsellEntry) => upsellEntry.Value.Clone()))
		{
			displayModel.Price = BillingHelper.GetProductPriceByPaymentProviderTypeIDAndCountryCurrencyID(paymentProviderTypeId, countryCurrencyId, displayModel.ProductId);
			if (displayModel.Price.HasValue)
			{
				displayModel.PriceText = FormatPriceText(currencySymbol, displayModel.Price);
			}
			upsellList.Add(displayModel);
		}
		return upsellList;
	}

	private IEnumerable<ProductDisplayModel> GetUpsellBcList(byte paymentProviderTypeId, int countryCurrencyId)
	{
		CountryCurrency countryCurrency = CountryCurrency.Get(countryCurrencyId);
		string currencySymbol = ((countryCurrency != null) ? Roblox.Billing.Business_Logic_Layer.CurrencyType.Get(countryCurrency.CurrencyTypeID).Symbol : "$");
		List<ProductDisplayModel> upsellList = new List<ProductDisplayModel>();
		foreach (ProductDisplayModel displayModel in UpsellBcDisplays.Select((KeyValuePair<int, ProductDisplayModel> upsellEntry) => upsellEntry.Value.Clone()))
		{
			displayModel.Price = BillingHelper.GetProductPriceByPaymentProviderTypeIDAndCountryCurrencyID(paymentProviderTypeId, countryCurrencyId, displayModel.ProductId);
			displayModel.RenewOrExpireText = $"Renews On: {Convert.ToDateTime(displayModel.Expiration).ToShortDateString()}";
			if (displayModel.Price.HasValue)
			{
				displayModel.PriceText = FormatPriceText(currencySymbol, displayModel.Price);
			}
			upsellList.Add(displayModel);
		}
		return upsellList;
	}

	private string FormatPriceText(string currencySymbol, decimal? price)
	{
		return currencySymbol + price?.ToString("N2");
	}

	private IEnumerable<Product> GetNbcRobuxProducts()
	{
		return new List<Product> { _Premium400Robux, _Premium800Robux, _Premium1700Robux, _Premium4500Robux, _Premium10000Robux };
	}

	private IEnumerable<Product> GetBcRobuxProducts()
	{
		return new List<Product> { _Premium440Subscribed, _Premium880Subscribed, _Premium1870Subscribed, _Premium4950Subscribed, _Premium11000Subscribed };
	}

	private static IEnumerable<Product> GetGiftcardProducts()
	{
		return new List<Product>
		{
			Product.Get("Gift Custom Value"),
			Product.Get("Gift 6 Months Builders Club"),
			Product.Get("Gift 6 Months Turbo Builders Club"),
			Product.Get("Gift 12 Months Builders Club"),
			Product.Get("Gift 12 Months Turbo Builders Club"),
			Product.Get("Gift 12 Months Outrageous Builders Club")
		};
	}
}
