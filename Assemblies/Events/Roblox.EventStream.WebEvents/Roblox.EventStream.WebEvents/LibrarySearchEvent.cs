using Roblox.EventStream.WebEvents.EventArgs;
using System;
namespace Roblox.EventStream.WebEvents {
    public class LibrarySearchEvent : WebEventBase

{
	private const string _Name = "librarySearch";

	public LibrarySearchEvent(IEventStreamer streamer, CatalogKeywordSearchEventArgs eventArgs)
		: base(streamer, "librarySearch", eventArgs)
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
		if (eventArgs.AssetsReturned != null)
		{
			AddEventArg("assetsReturned", eventArgs.AssetsReturned);
		}
	}

	/// <summary>
	/// Sends library search events to event stream.
	/// </summary>
	/// <param name="eventArgs"></param>
	/// <param name="IEventStreamer"></param>
	/// <param name="assetReturned"></param>
	/// <param name="keyword"></param>
	/// <param name="page"></param>
	/// <param name="category"></param>
	/// <param name="subCategory"></param>
	/// <param name="sortType"></param>
	public static void SendLibrarySearchEvent(CatalogKeywordSearchEventArgs eventArgs, IEventStreamer IEventStreamer, string assetReturned, string keyword, string page, string category, string subCategory = null, string sortType = null)
	{
		if (!string.IsNullOrEmpty(keyword))
		{
			eventArgs.Keyword = keyword;
			eventArgs.Category = category;
			eventArgs.Page = page;
			eventArgs.AssetsReturned = assetReturned;
			if (!string.IsNullOrEmpty(sortType))
			{
				eventArgs.Sort = sortType;
			}
			if (!string.IsNullOrEmpty(subCategory))
			{
				eventArgs.SubCategory = subCategory;
			}
			new LibrarySearchEvent(IEventStreamer, eventArgs).Stream();
		}
	}
}


}






