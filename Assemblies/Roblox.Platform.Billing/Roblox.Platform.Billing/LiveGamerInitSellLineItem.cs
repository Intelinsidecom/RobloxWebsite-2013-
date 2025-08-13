namespace Roblox.Platform.Billing;

public class LiveGamerInitSellLineItem
{
	public LineItem LineItem { get; private set; }

	public string Image { get; private set; }

	public string Description { get; private set; }

	public LiveGamerInitSellLineItem(LineItem lineItem, string image, string description)
	{
		Description = description;
		Image = image;
		LineItem = lineItem;
	}
}
