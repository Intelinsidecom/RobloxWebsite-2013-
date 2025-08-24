namespace Roblox.Billing;

public class ProductFactory
{
	public static readonly ProductFactory Singleton = new ProductFactory();

	private ProductFactory()
	{
	}

	public IProduct GetProduct(int id)
	{
		Product productEntity = Product.Get(id);
		IProductGroup productGroup = ProductGroupFactory.Singleton.GetProductGroup(productEntity.ProductGroupID);
		return new ProductImproved(productEntity.ID, productEntity.Name, productGroup, productEntity.IsRenewable, productEntity.Price);
	}

	public IProduct GetProduct(string name)
	{
		Product productEntity = Product.Get(name);
		IProductGroup productGroup = ProductGroupFactory.Singleton.GetProductGroup(productEntity.ProductGroupID);
		return new ProductImproved(productEntity.ID, productEntity.Name, productGroup, productEntity.IsRenewable, productEntity.Price);
	}
}
