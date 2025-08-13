using System;
using System.Collections.Generic;

namespace Roblox.Platform.EventStream.WebEvents;

public class CatalogKeywordSearchEvent : WebEventBase
{
	private const string _Name = "catalogSearch";

	public CatalogKeywordSearchEvent(IEventStreamer streamer, CatalogKeywordSearchEventArgs eventArgs)
		: base(streamer, "catalogSearch", eventArgs)
	{
		if (string.IsNullOrWhiteSpace(eventArgs.Keyword))
		{
			throw new ArgumentException("eventArgs.Keyword is required");
		}
		AddEventArg("kwd", eventArgs.Keyword);
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
		if (!string.IsNullOrEmpty(eventArgs.SubCategory))
		{
			AddEventArg("subcategory", eventArgs.SubCategory);
		}
		if (!string.IsNullOrEmpty(eventArgs.Gears))
		{
			AddEventArg("gears", eventArgs.Gears);
		}
		if (eventArgs.AssetsReturned != null)
		{
			AddEventArg("assetsReturned", eventArgs.AssetsReturned);
		}
		if (eventArgs.Genre != null)
		{
			AddEventArg("genre", eventArgs.Genre);
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
		IReadOnlyCollection<string> tagNames = eventArgs.TagNames;
		if (tagNames != null && tagNames.Count > 0)
		{
			AddEventArg("tagNames", string.Join(",", eventArgs.TagNames));
		}
	}

	/// <summary>
	/// Sends catalog search events to event stream.
	/// </summary>
	/// <param name="eventArgs"></param>
	/// <param name="eventStreamer"></param>
	public static void SendCatalogKeywordSearchEvent(CatalogKeywordSearchEventArgs eventArgs, IEventStreamer eventStreamer)
	{
		if (!string.IsNullOrEmpty(eventArgs.Keyword))
		{
			new CatalogKeywordSearchEvent(eventStreamer, eventArgs).Stream();
		}
	}
}
