using System.Collections.Generic;
using Roblox.Billing.Properties;
using Roblox.Billing.XboxStoreExceptions;

namespace Roblox.Billing;

/// <summary>
/// A factory to get billing product information for Xbox billing products.
/// </summary>
/// <remarks>
/// Unfortunately, Xbox Live Service does not give us readable name of the consumable products...
/// https://developer.xboxlive.com/en-us/platform/development/documentation/software/Pages/InventoryItem_Marketplace_MXS_T_AllMembers_jul15.aspx
/// </remarks>
public class XboxStoreProductFactory
{
	private static IDictionary<string, int> XboxProductIds => new Dictionary<string, int>
	{
		[Settings.Default.XboxStore200RobuxProductId] = Product.Get("200 Robux - Xbox").ID,
		[Settings.Default.XboxStore400RobuxProductId] = Product.Get("400 Robux").ID,
		[Settings.Default.XboxStore800RobuxProductId] = Product.Get("800 Robux").ID,
		[Settings.Default.XboxStore1700RobuxProductId] = Product.Get("1700 Robux").ID,
		[Settings.Default.XboxStore4500RobuxProductId] = Product.Get("4500 Robux").ID,
		[Settings.Default.XboxStore10000RobuxProductId] = Product.Get("10000 Robux").ID,
		[Settings.Default.XboxStore22500RobuxProductId] = Product.Get("22500 Robux").ID,
		[Settings.Default.XboxStoreStarterPack1MaleProductId] = Product.Get(Settings.Default.XboxStoreStarterPack1MaleBillingProductName).ID,
		[Settings.Default.XboxStoreStarterPack1FemaleProductId] = Product.Get(Settings.Default.XboxStoreStarterPack1FemaleBillingProductName).ID
	};

	/// <summary>
	/// Gets the product corresponding to the given Xbox product ID.
	/// </summary>
	/// <param name="xboxStoreProductId">The XboxLive product ID of the product to get.</param>
	/// <returns>The <see cref="T:Roblox.Billing.IProduct" /> corresponding to the given Xbox product ID.</returns>
	public static IProduct GetProductFromXboxStoreProductId(string xboxStoreProductId)
	{
		if (!XboxProductIds.ContainsKey(xboxStoreProductId))
		{
			throw new InvalidXboxProductException(xboxStoreProductId);
		}
		return ProductFactory.Singleton.GetProduct(XboxProductIds[xboxStoreProductId]);
	}

	public static ICollection<string> GetAllXboxStoreProductIds()
	{
		return XboxProductIds.Keys;
	}
}
