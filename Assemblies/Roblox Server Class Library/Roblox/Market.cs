using System;
using Roblox.Economy;
using Roblox.Economy.Common;
using Roblox.Marketplace.Client;

namespace Roblox;

public static class Market
{
	private static MarketplaceAuthority _Client;

	public static MarketplaceAuthority Client
	{
		get
		{
			return _Client ?? throw new ApplicationException("Client for Market has not been initialized");
		}
		set
		{
			_Client = value;
		}
	}

	/// <summary>
	/// Purchase a virtual economy product.
	/// </summary>
	/// <param name="purchaserId">Purchaser's userId</param>
	/// <param name="sellerId">Seller's userId</param>
	/// <param name="productId">Id of product being purchased</param>
	/// <param name="purchasePrice"></param>
	/// <param name="placeInHold">If true, don't grant the funds to the seller right away, add them to a currency hold instead.</param>
	/// <param name="platformTypeId"></param>
	/// <param name="status">After execution, either Success or a reason for failure.</param>
	/// <param name="placeProductPromotionId">If sold as an affiliate sale (eg, in a user's place) the placeProductPromotionId.</param>
	/// <returns>True if successful.  If false, the reason is in status out parameter.</returns>
	public static bool PurchaseProduct(long purchaserId, long sellerId, long productId, long purchasePrice, bool placeInHold, byte platformTypeId, out EconomyHelper.TransactionStatus status, long placeProductPromotionId = 0L, SaleLocationType saleLocationType = 0, long? saleLocationId = null)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		PurchaseProductResult purchaseResult = PurchaseProduct(purchaserId, sellerId, productId, purchasePrice, placeInHold, platformTypeId, placeProductPromotionId, saleLocationType, saleLocationId);
		status = (EconomyHelper.TransactionStatus)purchaseResult.Status;
		return purchaseResult.Status.Equals(0);
	}

	/// <summary>
	/// Purchase a virtual economy product.
	/// </summary>
	/// <param name="purchaserId">Purchaser's userId</param>
	/// <param name="sellerId">Seller's userId</param>
	/// <param name="productId">Id of product being purchased</param>
	/// <param name="purchasePrice"></param>
	/// <param name="placeInHold">If true, don't grant the funds to the seller right away, add them to a currency hold instead.</param>
	/// <param name="platformTypeId"></param>
	/// <param name="placeProductPromotionId">If sold as an affiliate sale (eg, in a user's place) the placeProductPromotionId.</param>
	/// <param name="saleLocationType">The location where the product was purchased</param>
	/// <param name="saleLocationId">The location id where the product was purchased</param>
	/// <returns>True if successful.  If false, the reason is in status out parameter.</returns>
	public static PurchaseProductResult PurchaseProduct(long purchaserId, long sellerId, long productId, long purchasePrice, bool placeInHold, byte platformTypeId, long placeProductPromotionId = 0L, SaleLocationType saleLocationType = 0, long? saleLocationId = null)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		if (sellerId != 0L)
		{
			Product product = Product.Get(productId);
			if (product != null && product.CreatorID.HasValue && product.CreatorID != sellerId)
			{
				return new PurchaseProductResult
				{
					Status = 6
				};
			}
		}
		return Client.PurchaseProduct(purchaserId, productId, (int)CurrencyType.RobuxID, purchasePrice, placeInHold, placeProductPromotionId, platformTypeId, saleLocationType, saleLocationId);
	}
}
