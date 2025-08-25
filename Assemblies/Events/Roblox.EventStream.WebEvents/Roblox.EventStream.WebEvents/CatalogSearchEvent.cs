namespace Roblox.Platform.EventStream.WebEvents;

public class CatalogSearchEvent : WebEventBase
{
	private const string _Name = "catalogSort";

	public CatalogSearchEvent(IEventStreamer streamer, CatalogSearchEventArgs eventArgs)
		: base(streamer, "catalogSort", eventArgs)
	{
		if (!string.IsNullOrEmpty(eventArgs.Category))
		{
			AddEventArg("category", eventArgs.Category);
		}
		if (!string.IsNullOrEmpty(eventArgs.Sort))
		{
			AddEventArg("sort", eventArgs.Sort);
		}
		if (!string.IsNullOrEmpty(eventArgs.Page))
		{
			AddEventArg("page", eventArgs.Page);
		}
		if (eventArgs.AssetsReturned != null)
		{
			AddEventArg("assetsReturned", eventArgs.AssetsReturned);
		}
		if (!string.IsNullOrEmpty(eventArgs.Genre))
		{
			AddEventArg("genre", eventArgs.Genre);
		}
		if (!string.IsNullOrEmpty(eventArgs.SubCategory))
		{
			AddEventArg("subcategory", eventArgs.SubCategory);
		}
		if (!string.IsNullOrEmpty(eventArgs.Gears))
		{
			AddEventArg("gears", eventArgs.Gears);
		}
		if (eventArgs.AlgorithmName != null)
		{
			AddEventArg("algorithmName", eventArgs.AlgorithmName);
		}
		if (eventArgs.PriceMin >= 0)
		{
			AddEventArg("priceMin", eventArgs.PriceMin.ToString());
		}
		if (eventArgs.PriceMax >= 0)
		{
			AddEventArg("priceMax", eventArgs.PriceMax.ToString());
		}
		if (eventArgs.HttpStatusCode >= 0)
		{
			AddEventArg("httpStatusCode", eventArgs.HttpStatusCode.ToString());
		}
		if (eventArgs.IncludeNotForSale)
		{
			AddEventArg("includeNotForSale", eventArgs.IncludeNotForSale.ToString());
		}
		if (!string.IsNullOrEmpty(eventArgs.UserItemModelName))
		{
			AddEventArg("userItemModelName", eventArgs.UserItemModelName);
		}
	}

	/// <summary>
	/// Sends catalog sort events to event stream.
	/// </summary>
	/// <param name="eventArgs"></param>
	/// <param name="eventStreamer"></param>
	public static void SendCatalogSearchEvent(CatalogSearchEventArgs eventArgs, IEventStreamer eventStreamer)
	{
		new CatalogSearchEvent(eventStreamer, eventArgs).Stream();
	}
}
