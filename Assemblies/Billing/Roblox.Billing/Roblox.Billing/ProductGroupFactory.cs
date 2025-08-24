namespace Roblox.Billing;

public class ProductGroupFactory
{
	public static readonly ProductGroupFactory Singleton = new ProductGroupFactory();

	private ProductGroupFactory()
	{
	}

	public IProductGroup GetProductGroup(byte id)
	{
		ProductGroup productGroupEntity = ProductGroup.Get(id);
		return new ProductGroupImproved(productGroupEntity.ID, productGroupEntity.Name);
	}

	public IProductGroup GetProductGroup(string name)
	{
		ProductGroup productGroupEntity = ProductGroup.Get(name);
		return new ProductGroupImproved(productGroupEntity.ID, productGroupEntity.Name);
	}
}
