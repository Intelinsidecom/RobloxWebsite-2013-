using System;
using System.Linq;
using Roblox.Agents;
using Roblox.ContentRatings;
using Roblox.Economy;
using Roblox.Economy.Business_Logic;
using Roblox.Economy.Common;
using Roblox.Economy.Properties;
using Roblox.EventLog;
using Roblox.Instrumentation;
using Roblox.Platform.AssetOwnership;
using Roblox.Platform.AssetOwnership.Properties;
using Roblox.Properties;

namespace Roblox;

public static class EconomyHelper
{
	/// <summary>
	/// This enum is duplicated in ServerClassLibrary.EconomyHelper, Roblox.Marketplace, Roblox.Marketplace.Client.MarketplaceAuthority and Roblox.Platform.VirtualEconomy. They must all be kept in sync!
	/// </summary>
	public enum TransactionStatus
	{
		Success,
		AlreadyOwned,
		ApplicationError,
		EconomyDisabled,
		InsufficientFunds,
		InsufficientMembership,
		InvalidTransaction,
		NotAvailableInRobux,
		NotForSale,
		PriceChanged,
		SaleExpired,
		SupplyExausted,
		ContentRatingRestricted,
		UnknownBirthday,
		AffiliateSalesDisabled,
		BadAffiliateSaleProduct,
		ExceptionOccurred,
		IOSOnlyItem,
		InvalidParameter,
		TooManyPurchases,
		Unauthorized,
		AccountRestrictionsRestricted,
		PendingTransactionAlreadyExists
	}

	private static readonly long _MinimumFee_Robux = 1L;

	private static readonly ICounterRegistry _CounterRegistry = StaticCounterRegistry.Instance;

	private const int quantity = 1;

	private const long discount = 0L;

	private static LegacyUserAssetOptionAuthority _LegacyUserAssetOptionAuthority { get; } = new LegacyUserAssetOptionAuthority();


	private static LegacyUserAssetExpirationAuthority _LegacyUserAssetExpirationAuthority { get; } = new LegacyUserAssetExpirationAuthority();


	private static IAssetOwnershipAuthority _AssetOwnershipAuthority { get; } = new AssetOwnershipAuthority(Asset.LookupAssetTypeId, "ServerClassLibrary", NoOpLogger.Instance);


	public static event Action<long> SaleCreationEvent;

	/// <summary>
	/// Gets the marketplace fee for price and agent id.
	/// </summary>
	/// <param name="currencyTypeId">The currency type id.</param>
	/// <param name="purchasePrice">The purchase price.</param>
	/// <param name="sellerAgentId">The agent id of the seller.</param>
	/// <param name="isPremiumUser">Whether the seller is a Premium user.</param>
	/// <returns>Amount of price that is taxed.</returns>
	/// <exception cref="T:System.ArgumentException">Agent with sellerAgentId {sellerAgentId} does not exist.</exception>
	public static long GetMarketplaceFee(byte currencyTypeId, long purchasePrice, long sellerAgentId, bool isPremiumUser)
	{
		try
		{
			_CounterRegistry?.GetRateOfCountsPerSecondCounter("EconomyHelper", "GetMarketplaceFee")?.Increment();
		}
		catch (Exception ex)
		{
			ExceptionHandler.LogException(ex);
		}
		double num = Convert.ToDouble(purchasePrice);
		float commissionRate = GetCommissionRate(sellerAgentId, isPremiumUser);
		long val = Convert.ToInt64(Math.Round(num * (double)commissionRate));
		long minimumFee = ((currencyTypeId == CurrencyType.RobuxID) ? _MinimumFee_Robux : 0);
		return Math.Max(val, minimumFee);
	}

	/// <summary>
	/// Gets the commission rate for the specified agent.
	/// </summary>
	/// <param name="agentId">The agent target id of the seller.</param>
	/// <param name="isPremiumUser">Whether the seller is a Premium user (does not apply to groups).</param>
	/// <returns></returns>
	/// <exception cref="T:System.ArgumentException">
	/// Invalid agent id
	/// or
	/// User does not exist
	/// or
	/// agentId does not match group or user
	/// </exception>
	public static float GetCommissionRate(long agentId, bool isPremiumUser)
	{
		try
		{
			_CounterRegistry?.GetRateOfCountsPerSecondCounter("EconomyHelper", "GetCommissionRate")?.Increment();
		}
		catch (Exception ex)
		{
			ExceptionHandler.LogException(ex);
		}
		IAgent agent = AgentFactory.Get(agentId);
		if (agent == null)
		{
			throw new ArgumentException("Invalid agent id");
		}
		switch (agent.AgentType)
		{
		case AgentType.User:
			if (!((User.Get(agent.AgentTargetId) ?? throw new ArgumentException("Target user does not exist")).IsAnyBuildersClubMember() || isPremiumUser))
			{
				return Roblox.Properties.Settings.Default.AssetSaleCommissionRateNonBC;
			}
			return Roblox.Properties.Settings.Default.AssetSaleCommissionRate;
		case AgentType.Group:
			return Roblox.Properties.Settings.Default.AssetSaleCommissionRate;
		default:
			throw new ArgumentException("agentId does not match group or user");
		}
	}

	private static bool HandleForAuctionProductTransaction(long purchaserId, Product product, long purchasePrice, out TransactionStatus status, byte platformTypeId, Action purchaseOperation = null)
	{
		if (!UserBalance.TryDebitRobux(purchaserId, purchasePrice))
		{
			string priceInRobuxString = (product.PriceInRobux.HasValue ? product.PriceInRobux.Value.ToString("#,###") : "null");
			ExceptionHandler.LogException($"User: {purchaserId} has insufficent funds to purchase Product: {product.ID}.  Purchaser balance: R$ {UserBalance.GetRobuxBalance(purchaserId):#,###}.  Price: R$ {priceInRobuxString}.");
			status = TransactionStatus.InsufficientFunds;
			return false;
		}
		if (purchaseOperation != null)
		{
			try
			{
				purchaseOperation();
			}
			catch (Exception ex)
			{
				status = TransactionStatus.ApplicationError;
				ExceptionHandler.LogException(ex);
				return false;
			}
		}
		Sale sale = Sale.CreateNew(purchaserId, 1L, product, CurrencyType.RobuxID, 1, purchasePrice, 0L, purchasePrice, 0L);
		SaleMetadata.CreateNew(sale.ID, platformTypeId, SaleLocationType.WebsiteSaleLocationTypeID);
		Payment.CreateNew(sale.ID, sale.UnitPrice, sale.CurrencyTypeID, PaymentStatusType.Success, sale.Created);
		PublishSaleEvent(sale.ID);
		TransactionHistory.Submit(purchaserId, TransactionType.DebitID, TransactionOriginType.SaleOfGoodsID, CurrencyType.RobuxID, purchasePrice, sale.ID);
		status = TransactionStatus.Success;
		return true;
	}

	private static bool HandleUserAssetTransaction(long purchaserId, long sellerId, long userAssetId, long purchasePrice, out TransactionStatus status, byte platformTypeId)
	{
		IUserAsset userAsset = _AssetOwnershipAuthority.GetUserAssetByUserAssetId(userAssetId);
		IUserAssetOption userAssetOption = _LegacyUserAssetOptionAuthority.GetUserAssetOptionByUserAssetId(userAsset.Id);
		if (userAssetOption == null || !userAssetOption.PriceInRobux.HasValue || userAssetOption.PriceInRobux.Value != purchasePrice || userAsset.UserId != sellerId)
		{
			ExceptionHandler.LogException(new ApplicationException($"UserAsset: {userAsset.Id} is not for sale."));
			status = TransactionStatus.NotForSale;
			return false;
		}
		if (!_AssetOwnershipAuthority.Transfer(userAssetId, sellerId, purchaserId, out var _))
		{
			ExceptionHandler.LogException($"UserAsset.Transfer Failed. UserID: {purchaserId}, UserAssetID: {userAsset.Id}.");
			status = TransactionStatus.ApplicationError;
			return false;
		}
		if (!UserBalance.TryDebitRobux(purchaserId, purchasePrice))
		{
			if (!_AssetOwnershipAuthority.Transfer(userAssetId, purchaserId, sellerId, out var _))
			{
				ExceptionHandler.LogException($"UserAsset.Transfer Failed on rollback step. UserID: {sellerId}, UserAssetID: {userAsset.Id}.");
			}
			IUserAssetOption restoredUserAssetOption = _LegacyUserAssetOptionAuthority.GetUserAssetOptionById(userAssetOption.Id);
			restoredUserAssetOption.PriceInRobux = purchasePrice;
			_LegacyUserAssetOptionAuthority.SaveUserAssetOption(restoredUserAssetOption.UserAssetId, restoredUserAssetOption.ProductId, restoredUserAssetOption.SerialNumber, restoredUserAssetOption.PriceInRobux, restoredUserAssetOption.Id);
			ExceptionHandler.LogException(string.Format("User: {0} has insufficent funds to purchase Product: {1}.  Purchaser balance: R$ {2}.  Price: R$ {3}.", purchaserId, restoredUserAssetOption.Id, UserBalance.GetRobuxBalance(purchaserId).ToString("#,###"), restoredUserAssetOption.PriceInRobux.HasValue ? restoredUserAssetOption.PriceInRobux.Value.ToString("#,###") : "0"));
			status = TransactionStatus.InsufficientFunds;
			return false;
		}
		long marketplaceFee = (long)((float)purchasePrice * Roblox.Platform.AssetOwnership.Properties.Settings.Default.AssetResaleCommissionRate);
		Product product = Product.GetByUserAssetID(userAssetId);
		if (product == null)
		{
			Product originalProduct = Product.GetByAssetID(userAsset.AssetId);
			if (originalProduct == null)
			{
				throw new ApplicationException("There was no original product associated with this asset.");
			}
			product = Product.CreateNewResellableProduct(userAssetId, originalProduct);
		}
		Sale sale = Sale.CreateNew(purchaserId, sellerId, product, CurrencyType.RobuxID, 1, purchasePrice, 0L, purchasePrice, marketplaceFee);
		SaleMetadata.CreateNew(sale.ID, platformTypeId, SaleLocationType.WebsiteSaleLocationTypeID);
		Payment.CreateNew(sale.ID, sale.UnitPrice, sale.CurrencyTypeID, PaymentStatusType.Success, sale.Created);
		PublishSaleEvent(sale.ID);
		Asset asset = Asset.Get(userAsset.AssetId);
		if (asset != null)
		{
			AssetSale.CreateNew(sale.ID, asset.ID, asset.AssetTypeID, sale.Created, sale.TotalPrice, sale.CurrencyTypeID, sale.SellerID);
		}
		TransactionHistory.Submit(purchaserId, TransactionType.DebitID, TransactionOriginType.SaleOfGoodsID, CurrencyType.RobuxID, purchasePrice, sale.ID);
		long sellerCredit = purchasePrice - marketplaceFee;
		if (sellerCredit > 0)
		{
			UserBalance.CreditRobux(sellerId, sellerCredit);
			TransactionHistory.Submit(sale.SellerID.Value, TransactionType.CreditID, TransactionOriginType.SaleOfGoodsID, CurrencyType.RobuxID, sellerCredit, sale.ID);
		}
		long assetId = userAsset.AssetId;
		AssetSalesHistory ph = AssetSalesHistory.GetByAssetID(assetId);
		if (ph == null)
		{
			AssetSalesHistory.CreateNew(assetId, string.Empty, string.Empty, 0, 0, string.Empty, string.Empty, 0, 0, string.Empty, string.Empty, 0, 0, (int)purchasePrice);
		}
		else
		{
			ph.RecentAveragePrice = (int)((double)ph.RecentAveragePrice * 0.9 + (double)purchasePrice * 0.1);
			ph.Save();
		}
		status = TransactionStatus.Success;
		return true;
	}

	private static Sale DebitBuyer(long purchasePrice, long purchaserId, Product product, long sellerId, byte platformTypeId, bool isPremiumUser)
	{
		if (!UserBalance.TryDebitRobux(purchaserId, purchasePrice))
		{
			throw new InvalidOperationException(string.Format("User: {0} has insufficent funds to purchase Product: {1}.  Purchaser balance: R$ {2}.  Price: R$ {3}.", purchaserId, product.ID, UserBalance.GetRobuxBalance(purchaserId), purchasePrice.ToString("#,###")));
		}
		long totalPrice = purchasePrice;
		long marketplaceFee = GetMarketplaceFee(CurrencyType.RobuxID, totalPrice, sellerId, isPremiumUser);
		Sale sale = Sale.CreateNew(purchaserId, sellerId, product, CurrencyType.RobuxID, 1, purchasePrice, 0L, totalPrice, marketplaceFee);
		SaleMetadata.CreateNew(sale.ID, platformTypeId, SaleLocationType.WebsiteSaleLocationTypeID);
		Payment.CreateNew(sale.ID, sale.UnitPrice, sale.CurrencyTypeID, PaymentStatusType.Success, sale.Created);
		PublishSaleEvent(sale.ID);
		TransactionHistory.Submit(purchaserId, TransactionType.DebitID, TransactionOriginType.SaleOfGoodsID, CurrencyType.RobuxID, totalPrice, sale.ID);
		return sale;
	}

	private static void CreditSeller(Sale sale)
	{
		if (sale.SellerID.HasValue)
		{
			long sellerId = sale.SellerID.Value;
			long sellerCredit = sale.TotalPrice - sale.MarketplaceFee;
			if (sellerCredit > 0)
			{
				UserBalance.CreditRobux(sellerId, sellerCredit);
				TransactionHistory.Submit(sellerId, TransactionType.CreditID, TransactionOriginType.SaleOfGoodsID, sale.CurrencyTypeID, sellerCredit, sale.ID);
			}
		}
	}

	public static void PublishSaleEvent(long saleId)
	{
		if (EconomyHelper.SaleCreationEvent != null)
		{
			EconomyHelper.SaleCreationEvent(saleId);
		}
	}

	public static bool ConductSaleWithTransfer(long purchaserId, long sellerId, long userAssetId, long purchasePrice, byte currencyTypeId, out TransactionStatus status, byte platformTypeId, bool allowMultiplePurchase = false)
	{
		if (!ValidateUserAssetTransaction(purchaserId, sellerId, userAssetId, purchasePrice, currencyTypeId, out status, allowMultiplePurchase))
		{
			return false;
		}
		return HandleUserAssetTransaction(purchaserId, sellerId, userAssetId, purchasePrice, out status, platformTypeId);
	}

	public static bool ConductRobloxProductSale(long purchaserId, long productId, long purchasePrice, out TransactionStatus status, byte platformTypeId, bool isPremiumUser, int? assetTypeId = null)
	{
		long sellerId = User.RobloxAccountID;
		if (!ValidateTransaction(purchaserId, sellerId, productId, purchasePrice, CurrencyType.RobuxID, out status))
		{
			return false;
		}
		Product product = Product.Get(productId);
		CreditSeller(DebitBuyer(purchasePrice, purchaserId, product, sellerId, platformTypeId, isPremiumUser));
		status = TransactionStatus.Success;
		return true;
	}

	public static bool ConductSaleOfRobloxProductByAuction(long purchaserId, long productId, long purchasePrice, out TransactionStatus status, byte platformTypeId, Action purchaseOperation = null)
	{
		Product product = Product.Get(productId);
		if (product == null)
		{
			ExceptionHandler.LogException(new ApplicationException($"Failed to load Product: {productId}."));
			status = TransactionStatus.ApplicationError;
			return false;
		}
		IAgent purchaserAgent = AgentFactory.Get(purchaserId);
		User purchaser = null;
		if (purchaserAgent == null)
		{
			ExceptionHandler.LogException(new ApplicationException($"Failed to load User: {purchaserId}."));
			status = TransactionStatus.ApplicationError;
			return false;
		}
		if (purchaserAgent.AgentType == AgentType.User)
		{
			purchaser = User.Get(purchaserId);
		}
		if (product.ProductTypeID != ProductType.RobloxProductID)
		{
			ExceptionHandler.LogException(new ApplicationException($"ConductRobloxProductSaleByAuction. Incorrect ProductType.  Product: {productId}."));
			status = TransactionStatus.ApplicationError;
			return false;
		}
		if (!product.IsForSale)
		{
			ExceptionHandler.LogException(new ApplicationException($"Product: {productId} is not For Sale."));
			status = TransactionStatus.NotForSale;
			return false;
		}
		if (purchaser != null && !purchaser.HasMinimumBCLevelToObtain(product))
		{
			ExceptionHandler.LogException($"User does not have minimum BC requirement to purchase product. UserID: {purchaserId}, ProductID: {product.ID}");
			status = TransactionStatus.InsufficientMembership;
			return false;
		}
		if (!MarketPlaceSwitches.IsItemsXchangeEnabled)
		{
			ExceptionHandler.LogException("The virtual economy has been temporarily disabled.");
			status = TransactionStatus.EconomyDisabled;
			return false;
		}
		return HandleForAuctionProductTransaction(purchaserId, product, purchasePrice, out status, platformTypeId, purchaseOperation);
	}

	private static bool ValidateUserAssetTransaction(long purchaserId, long sellerId, long userAssetId, long purchasePrice, byte currencyTypeId, out TransactionStatus status, bool allowMultiplePurchase = false)
	{
		if (!MarketPlaceSwitches.IsItemsXchangeEnabled || !MarketPlaceSwitches.IsItemResaleEnabled)
		{
			status = TransactionStatus.EconomyDisabled;
			return false;
		}
		if (sellerId == purchaserId)
		{
			status = TransactionStatus.AlreadyOwned;
			return false;
		}
		if (CurrencyType.Get(currencyTypeId) == null)
		{
			ExceptionHandler.LogException(new ApplicationException($"Failed to load CurrencyType for UserAssetTransaction - CurrencyTypeID: {currencyTypeId}"));
			status = TransactionStatus.ApplicationError;
			return false;
		}
		IUserAsset userAsset = _AssetOwnershipAuthority.GetUserAssetByUserAssetId(userAssetId);
		if (userAsset == null)
		{
			ExceptionHandler.LogException(new ApplicationException($"Failed to load UserAsset for UserAssetTransaction, UserAssetID: {userAssetId}."));
			status = TransactionStatus.ApplicationError;
			return false;
		}
		Product product = Product.Get(Product.LookupFilter.AssetID, userAsset.AssetId);
		if (product == null)
		{
			ExceptionHandler.LogException(new ApplicationException($"Failed to load Product for UserAssetTransaction, AssetId: {userAsset.AssetId}."));
			status = TransactionStatus.ApplicationError;
			return false;
		}
		User purchaser = User.Get(purchaserId);
		if (currencyTypeId != CurrencyType.RobuxID)
		{
			ExceptionHandler.LogException(new ApplicationException("User assets may only be sold in Robux."));
			status = TransactionStatus.ApplicationError;
			return false;
		}
		if (!product.IsResellable || !_LegacyUserAssetOptionAuthority.GetUserAssetOptionByUserAssetId(userAsset.Id).PriceInRobux.HasValue)
		{
			status = TransactionStatus.NotForSale;
			return false;
		}
		if (!ContentRatingManager.CanOwnAsset(Asset.Get(userAsset.AssetId).AssetHashID, purchaser.BirthDate))
		{
			if (!purchaser.BirthDate.HasValue)
			{
				status = TransactionStatus.UnknownBirthday;
				return false;
			}
			status = TransactionStatus.ContentRatingRestricted;
			return false;
		}
		if (!purchaser.HasMinimumBCLevelToObtain(product))
		{
			status = TransactionStatus.InsufficientMembership;
			return false;
		}
		if (_LegacyUserAssetOptionAuthority.GetUserAssetOptionByUserAssetId(userAsset.Id).PriceInRobux != purchasePrice)
		{
			status = TransactionStatus.PriceChanged;
			return false;
		}
		if (sellerId != userAsset.UserId)
		{
			status = TransactionStatus.InvalidTransaction;
			return false;
		}
		if (!allowMultiplePurchase && _AssetOwnershipAuthority.AgentOwnsAsset(purchaserId, userAsset.AssetId))
		{
			status = TransactionStatus.AlreadyOwned;
			return false;
		}
		if (UserBalance.GetRobuxBalance(purchaserId) < purchasePrice)
		{
			status = TransactionStatus.InsufficientFunds;
			return false;
		}
		status = TransactionStatus.Success;
		return true;
	}

	private static bool ValidateTransaction(long purchaserId, long expectedSellerId, long productId, long expectedPrice, byte currencyTypeId, out TransactionStatus status)
	{
		if (!MarketPlaceSwitches.IsItemsXchangeEnabled || (!MarketPlaceSwitches.IsNonRobloxSalesEnabled && expectedSellerId != User.RobloxAccountID))
		{
			ExceptionHandler.LogException("The virtual economy has been temporarily disabled.");
			status = TransactionStatus.EconomyDisabled;
			return false;
		}
		CurrencyType currencyType = CurrencyType.Get(currencyTypeId);
		Product product = Product.Get(productId);
		User purchaser = null;
		if (AgentFactory.Get(purchaserId).AgentType == AgentType.User)
		{
			purchaser = User.Get(purchaserId);
		}
		if (currencyType == null || product == null)
		{
			ExceptionHandler.LogException(new ApplicationException($"Failed to load CurrencyType, or Product for Transaction - CurrencyTypeID: {currencyTypeId}, ProductID: {productId}."));
			status = TransactionStatus.ApplicationError;
			return false;
		}
		if (product.TargetID.HasValue && !ContentRatingManager.CanOwnAsset(Asset.Get(product.TargetID).AssetHashID, purchaser?.BirthDate))
		{
			if (purchaser == null || !purchaser.BirthDate.HasValue)
			{
				status = TransactionStatus.UnknownBirthday;
				return false;
			}
			status = TransactionStatus.ContentRatingRestricted;
			return false;
		}
		long sellerId = (product.CreatorID.HasValue ? product.CreatorID.Value : (product.TargetID.HasValue ? Asset.Get(product.TargetID).CreatorRefObject.AgentID : User.RobloxAccountID));
		if (expectedSellerId != sellerId)
		{
			status = TransactionStatus.ApplicationError;
			return false;
		}
		if (purchaser != null && !purchaser.HasMinimumBCLevelToObtain(product))
		{
			status = TransactionStatus.InsufficientMembership;
			return false;
		}
		if (product.IsResellable)
		{
			status = TransactionStatus.SupplyExausted;
			return false;
		}
		if (product.ProductOptions.OffSaleDeadline.HasValue && product.ProductOptions.OffSaleDeadline.Value < DateTime.Now)
		{
			status = TransactionStatus.SaleExpired;
			return false;
		}
		if (product.ProductTypeID == ProductType.UserProductID)
		{
			foreach (IUserAsset userAsset in _AssetOwnershipAuthority.GetUserAssets(purchaserId, product.TargetID.Value))
			{
				if (userAsset != null && (!AssetOption.GetOrCreate(userAsset.AssetId).IsExpireable || !_LegacyUserAssetExpirationAuthority.UserAssetIsExpired(userAsset)))
				{
					status = TransactionStatus.AlreadyOwned;
					return false;
				}
			}
		}
		if (!product.IsPublicDomain)
		{
			if (!product.IsForSale)
			{
				status = TransactionStatus.NotForSale;
				return false;
			}
			long productPrice = 0L;
			long userBalance = 0L;
			if (currencyTypeId == CurrencyType.RobuxID)
			{
				if (!product.PriceInRobux.HasValue)
				{
					ExceptionHandler.LogException(new ApplicationException($"Product: {product.ID} is not available for Robux."));
					status = TransactionStatus.NotAvailableInRobux;
					return false;
				}
				productPrice = product.PriceInRobux.Value;
				userBalance = UserBalance.GetRobuxBalance(purchaserId);
			}
			if (productPrice != expectedPrice)
			{
				status = TransactionStatus.PriceChanged;
				return false;
			}
			if (userBalance < expectedPrice)
			{
				status = TransactionStatus.InsufficientFunds;
				return false;
			}
		}
		status = TransactionStatus.Success;
		return true;
	}

	public static bool ValidatePlaceProductPromotionData(long purchaserId, long sellerId, long productId, long expectedPrice, byte currencyTypeId, out TransactionStatus status, long placeProductPromotionId)
	{
		if (!ValidateTransaction(purchaserId, sellerId, productId, expectedPrice, currencyTypeId, out status))
		{
			return false;
		}
		Product.Get(productId);
		if (!ProductIsValidForPlaceProductPromotion(productId))
		{
			status = TransactionStatus.InvalidTransaction;
			return false;
		}
		if (placeProductPromotionId == 0L)
		{
			status = TransactionStatus.InvalidTransaction;
			return false;
		}
		if (PlaceProductPromotion.Get(placeProductPromotionId) == null)
		{
			status = TransactionStatus.InvalidTransaction;
			return false;
		}
		status = TransactionStatus.Success;
		return true;
	}

	public static bool CanBecomeLimited(long assetId)
	{
		if (Asset.Get(assetId) == null)
		{
			return false;
		}
		Product product = Product.Get(Product.LookupFilter.AssetID, assetId);
		if (product == null || product.IsResellable)
		{
			return false;
		}
		if (product.IsForSale)
		{
			return product.PriceInRobux.HasValue;
		}
		return false;
	}

	public static bool CanBePublicDomain(long assetId)
	{
		Asset asset = Asset.Get(assetId);
		if (asset == null)
		{
			return false;
		}
		if (asset.AssetTypeID == AssetType.ModelID)
		{
			return true;
		}
		if (asset.AssetTypeID == AssetType.DecalID)
		{
			return true;
		}
		return false;
	}

	public static bool CanBeSold(long assetId)
	{
		Asset asset = Asset.Get(assetId);
		if (asset == null)
		{
			return false;
		}
		if (asset.AssetTypeID == AssetType.ShirtID)
		{
			return true;
		}
		if (asset.AssetTypeID == AssetType.PantsID)
		{
			return true;
		}
		if (asset.AssetTypeID == AssetType.TeeShirtID)
		{
			return true;
		}
		return false;
	}

	public static bool ProductEligibleForAffilitiateSale(long productId)
	{
		if (!Roblox.Properties.Settings.Default.AffiliateSalesEnabled || productId == 0L)
		{
			return false;
		}
		Product product = Product.Get(productId);
		if (product == null)
		{
			return false;
		}
		ProductOption option = ProductOption.GetByProductID(product.ID);
		if (product != null && option != null && !option.HasOffSaleDeadline && product.IsForSale && !product.IsPublicDomain && !product.IsLimitedEdition)
		{
			return !product.IsResellable;
		}
		return false;
	}

	public static bool ProductIsValidForPlaceProductPromotion(long productId)
	{
		if (!ProductEligibleForAffilitiateSale(productId))
		{
			return false;
		}
		Product product = Product.Get(productId);
		if (product != null)
		{
			int? assetTypeID = product.AssetTypeID;
			int gearID = AssetType.GearID;
			if (assetTypeID.GetValueOrDefault() == gearID && assetTypeID.HasValue && product.PriceInRobux.HasValue && product.AffiliateFeePercentage.HasValue && product.CreatorID.HasValue)
			{
				return product.CreatorID.Value == User.RobloxAccountID;
			}
		}
		return false;
	}

	/// <summary>
	/// This is the alternative to a performance-intensive bulk update of prices.
	/// This code can be deprecated once all items are updated.
	/// </summary>
	/// <param name="productId">Unique ID with which a Product can be fetched.</param>
	/// <param name="priceInRobux"></param>
	/// <param name="robuxPriceUpdated"></param>
	public static void EnforceUserProductMinimumPrice(long productId, long? priceInRobux, out bool robuxPriceUpdated)
	{
		robuxPriceUpdated = false;
		if (!Roblox.Properties.Settings.Default.LazyUpdateForUserItemsMinPriceEnabled)
		{
			return;
		}
		Product product = Product.Get(productId);
		int[] assetTypesCreateableByUsers = new int[3]
		{
			AssetType.TeeShirtID,
			AssetType.ShirtID,
			AssetType.PantsID
		};
		if (product != null && (!product.CreatorID.HasValue || product.CreatorID.Value != User.RobloxAccountID) && product.IsForSale && product.ProductType.Value == "User Product" && product.AssetTypeID.HasValue && assetTypesCreateableByUsers.Contains(product.AssetTypeID.Value))
		{
			if (priceInRobux.HasValue && priceInRobux.Value != 0L && priceInRobux.Value < MinimumRobuxPrice(product.AssetTypeID.Value))
			{
				product.PriceInRobux = MinimumRobuxPrice(product.AssetTypeID.Value);
				robuxPriceUpdated = true;
			}
			if (robuxPriceUpdated)
			{
				product.Save();
			}
		}
	}

	public static long MinimumRobuxPrice(long assetTypeId)
	{
		if (assetTypeId == AssetType.PlaceID)
		{
			return Roblox.Economy.Properties.Settings.Default.MinimumRobuxPriceForPlaceSales;
		}
		if (assetTypeId == AssetType.TeeShirtID)
		{
			return Roblox.Economy.Properties.Settings.Default.MinimumRobuxPriceForTShirtSales;
		}
		if (assetTypeId == AssetType.ShirtID)
		{
			return Roblox.Economy.Properties.Settings.Default.MinimumRobuxPriceForShirtSales;
		}
		if (assetTypeId == AssetType.PantsID)
		{
			return Roblox.Economy.Properties.Settings.Default.MinimumRobuxPriceForPantSales;
		}
		return Roblox.Economy.Properties.Settings.Default.MinimumRobuxPriceForUserSales;
	}

	public static long MaximumRobuxPrice(long assetTypeId)
	{
		return Roblox.Economy.Properties.Settings.Default.MaximumRobuxPriceForUserSales;
	}
}
