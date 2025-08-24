using System.Collections.Generic;

namespace Roblox.Platform.Billing;

public interface IProductDisplayModelProvider
{
	/// <summary>
	/// Gets displayed Builders Club products
	/// </summary>
	/// <returns>A list of <see cref="T:Roblox.Platform.Billing.ProductDisplayModel" /></returns>
	IEnumerable<ProductDisplayModel> GetDisplayedBuildersClubProducts();

	/// <summary>
	/// Gets a list of <see cref="T:Roblox.Platform.Billing.ProductPair" /> with NBC-Robux and BC-Robux
	/// </summary>
	/// <returns>A list of <see cref="T:Roblox.Platform.Billing.ProductPair" /></returns>
	IEnumerable<ProductPair> ConstructRobuxPairList();

	/// <summary>
	/// Gets a paired premium version product Id by a given product Id
	/// </summary>
	/// <param name="productId">The given product id</param>
	/// <param name="bcProductId">The outcome of premium version product Id. The same as the given product Id if there is non premium version</param>
	/// <returns>True if there is a premium version product Id by the given produt Id, otherwise false.</returns>
	bool GetPremiumRobuxProductIdFromNonPremiumRobux(int productId, out int bcProductId);

	/// <summary>
	/// Gets displayed upsell products by payment provider type id, country currentcy id and main product group id.
	/// </summary>
	/// <param name="paymentProviderTypeId">The given payment provider type id</param>
	/// <param name="countryCurrencyId">The given country currency id</param>
	/// <param name="mainProductGroupId">The main product group id</param>
	/// <returns>A list of <see cref="T:Roblox.Platform.Billing.ProductDisplayModel" /></returns>
	IEnumerable<ProductDisplayModel> GetUpsellProducts(byte paymentProviderTypeId, int countryCurrencyId, byte mainProductGroupId);

	/// <summary>
	/// Get a displayed product by product id
	/// </summary>
	/// <param name="productId">The given product id</param>
	/// <returns>A <see cref="T:Roblox.Platform.Billing.ProductDisplayModel" /> for the product</returns>
	ProductDisplayModel GetByProductId(int productId);

	/// <summary>
	/// Check if it is an upsell Robux product by product id
	/// </summary>
	/// <param name="productId">The given product id</param>
	/// <returns>True if it's an upsell Robux product, otherwise false</returns>
	bool IsUpsellRobuxProduct(int productId);

	/// <summary>
	/// Check if it is an upsell Builders club product by product id
	/// </summary>
	/// <param name="productId">The given product id</param>
	/// <returns>True if it's an upsell Builders club product, otherwise false</returns>
	bool IsUpsellBcProduct(int productId);
}
