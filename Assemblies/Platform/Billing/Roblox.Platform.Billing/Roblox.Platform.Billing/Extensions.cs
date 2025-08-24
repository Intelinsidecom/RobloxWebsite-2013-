using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Billing;
using Roblox.Billing.Business_Logic_Layer;
using Roblox.LiveGamer;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Billing;

public static class Extensions
{
	internal static Roblox.Billing.Business_Logic_Layer.CurrencyType Translate(this CurrencyType currencyType)
	{
		return Roblox.Billing.Business_Logic_Layer.CurrencyType.GetByCode(currencyType.ToString());
	}

	internal static void ValidateProductBundle(this ICollection<LineItem> lineItems)
	{
		if (lineItems.Count((LineItem lineItem) => lineItem.RenewalStartDate.HasValue) > 1)
		{
			throw new InvalidProductException("Only one recurring product per cart has been implemented.");
		}
		if (lineItems.Any((LineItem lineItem) => lineItem.Quantity != 1))
		{
			throw new InvalidProductException("Invalid quantity.");
		}
		if (lineItems.IsGiftCardPurchase())
		{
			throw new InvalidProductException("Giftcard Purchase is currently disabled.");
		}
		if (lineItems.GetProducts().Any((IProduct product) => !ProductPaymentProviderType.IsValidPaymentProviderType(product.Id, Roblox.Billing.PaymentProviderType.CreditCard.ID)))
		{
			throw new InvalidProductException("There is a product in the shopping cart that cannot be purchased using a credit card. Please use another payment method.");
		}
		if (lineItems.Any((LineItem item) => item.ProductPrice.GetProduct().IsRenewable && !item.RenewalStartDate.HasValue))
		{
			throw new InvalidProductException("Renewable product must have a starting renewal date.");
		}
	}

	internal static IEnumerable<IProduct> GetProducts(this IEnumerable<LineItem> lineItems)
	{
		return lineItems.Select((LineItem lineItem) => ProductFactory.Singleton.GetProduct(lineItem.ProductPrice.GetProduct().ID)).ToList();
	}

	internal static decimal GetTotalListPrice(this IEnumerable<LineItem> lineItems)
	{
		return lineItems.Sum((LineItem i) => i.ProductPrice.Price);
	}

	internal static decimal GetTotalActualPrice(this IEnumerable<LineItem> lineItems)
	{
		return lineItems.Sum((LineItem i) => i.FinalPrice);
	}

	internal static bool IsGiftCardPurchase(this IEnumerable<LineItem> lineItems)
	{
		return lineItems.Any((LineItem item) => GiftCard.IsGiftCardProduct(item.ProductPrice.GetProduct()));
	}

	public static bool IsMembershipPurchase(this IEnumerable<LineItem> lineItems)
	{
		return lineItems.Any((LineItem item) => item.ProductPrice.GetProduct().ProductGroupID == ProductGroup.BC.ID);
	}

	internal static LineItem GetMembershipItem(this IEnumerable<LineItem> lineItems)
	{
		return lineItems.FirstOrDefault((LineItem item) => item.ProductPrice.GetProduct().ProductGroupID == ProductGroup.BC.ID);
	}

	internal static ShoppingCart ToShoppingCart(this IEnumerable<LineItem> lineItems, IUser user)
	{
		if (user == null)
		{
			throw new InvalidProductException("Error determining identity.");
		}
		ShoppingCart shoppingCart = ShoppingCart.RetrieveCart(Convert.ToInt32(user.AccountId));
		return lineItems.ToShoppingCart(shoppingCart);
	}

	internal static ShoppingCart ToShoppingCart(this IEnumerable<LineItem> lineItems, long browserTrackerId)
	{
		if (browserTrackerId == 0L)
		{
			throw new InvalidProductException("Error determining identity.");
		}
		ShoppingCart shoppingCart = ShoppingCart.RetrieveCart(null, browserTrackerId);
		return lineItems.ToShoppingCart(shoppingCart);
	}

	private static ShoppingCart ToShoppingCart(this IEnumerable<LineItem> lineItems, ShoppingCart shoppingCart)
	{
		if (!lineItems.IsGiftCardPurchase())
		{
			if (shoppingCart.Contents.Count != 0)
			{
				shoppingCart.RemoveAll();
			}
			foreach (LineItem lineItem in lineItems)
			{
				shoppingCart.AddToCart(lineItem.ProductPrice.GetProduct().ID, lineItem.FinalPrice);
			}
		}
		return shoppingCart;
	}

	internal static Product GetProduct(this ProductPrice productPrice)
	{
		return Product.Get(ProductPaymentProviderType.Get(productPrice.ProductPaymentProviderTypeID).ProductID);
	}

	/// <summary>
	/// Verifies the credit cards checksum using the Luhn algorithm
	/// http://rosettacode.org/wiki/Luhn_test_of_credit_card_numbers#C.23
	/// </summary>
	/// <param name="creditCard">The credit card to be validated</param>
	public static bool IsValidCreditCardChecksum(this ICreditCard creditCard)
	{
		return new CreditCardValidator().IsValidChecksum(creditCard);
	}

	/// <summary>
	/// Tests if CerditCard expiration date is valid.
	/// </summary>
	/// <param name="creditCard">The credit card to be validated</param>
	/// <param name="validDateTime">DateTime to validate the card against</param>
	/// <returns>false if the CreditCard expiration date is in the past or can't be parsed</returns>
	public static bool IsValidCreditCardExpirationDate(this ICreditCard creditCard, DateTime validDateTime)
	{
		return new CreditCardValidator().IsValidExpirationDate(creditCard, DateTime.Now);
	}

	/// <summary>
	/// Verify the credit card number and length is valid for the type
	/// </summary>
	/// <param name="creditCard">The credit card to be verified</param>
	public static bool IsValidCreditCardType(this ICreditCard creditCard)
	{
		return new CreditCardValidator().IsValidType(creditCard);
	}

	internal static LiveGamerLineItem Translate(this LiveGamerInitSellLineItem sellLineItem)
	{
		LiveGamerLineItem liveGamerLineItem = new LiveGamerLineItem();
		Roblox.Billing.Business_Logic_Layer.CurrencyType currencyType = Roblox.Billing.Business_Logic_Layer.CurrencyType.Get(CountryCurrency.Get(sellLineItem.LineItem.ProductPrice.CountryCurrencyID).CurrencyTypeID);
		liveGamerLineItem.CurrencyCode = currencyType.Code;
		liveGamerLineItem.Price = sellLineItem.LineItem.FinalPrice;
		liveGamerLineItem.Id = sellLineItem.LineItem.ProductPrice.GetProduct().ID;
		liveGamerLineItem.Description = sellLineItem.Description;
		liveGamerLineItem.Image = sellLineItem.Image;
		return liveGamerLineItem;
	}

	public static string GetLiveGamerPaymentInitUrl(this LiveGamerInitTransactionResult transactionResult)
	{
		return LiveGamerCommunicatorFactory.GetCommunicator().GetPaymentInitUrl(transactionResult);
	}

	internal static IEnumerable<ITransactionLog> CompletedTransactionsInTheLastXDaysExcludingStoreCredit(this IUser user, int days)
	{
		TransactionsProvider transactionProvider = new TransactionsProvider();
		return transactionProvider.GetTransactionsByAccountIdAndCreatedAfterDate(Convert.ToInt32(user.AccountId), DateTime.Now.AddDays(-days)).Where(transactionProvider.IsPaymentCompleteAndNotPaidWithStoreCredit);
	}
}
