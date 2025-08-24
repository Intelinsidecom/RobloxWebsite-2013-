using Roblox.Billing;

namespace Roblox.Platform.Billing;

public class ProductPair
{
	public Product NBCProduct;

	public Product BCProduct;

	public ProductPair(Product nbcProduct, Product bcProduct)
	{
		NBCProduct = nbcProduct;
		BCProduct = bcProduct;
	}
}
