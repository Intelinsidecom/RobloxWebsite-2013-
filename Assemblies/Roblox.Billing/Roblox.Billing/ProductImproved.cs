namespace Roblox.Billing;

internal class ProductImproved : IProduct
{
	public int Id { get; private set; }

	public bool IsRenewable { get; private set; }

	public string Name { get; private set; }

	public decimal Price { get; private set; }

	public IProductGroup ProductGroup { get; private set; }

	internal ProductImproved(int id, string name, IProductGroup productGroup, bool isRenewable, decimal price)
	{
		Id = id;
		Name = name;
		ProductGroup = productGroup;
		IsRenewable = isRenewable;
		Price = price;
	}
}
