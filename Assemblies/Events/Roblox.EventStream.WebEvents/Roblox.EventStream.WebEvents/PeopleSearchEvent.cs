using Roblox.EventStream.WebEvents.EventArgs;
using System;
namespace Roblox.EventStream.WebEvents {
    public class PeopleSearchEvent : WebEventBase

{
	private const string _Name = "peopleSearch";

	public PeopleSearchEvent(IEventStreamer streamer, PeopleSearchEventArgs eventArgs)
		: base(streamer, "peopleSearch", eventArgs)
	{
		if (string.IsNullOrWhiteSpace(eventArgs.Keyword))
		{
			throw new ArgumentException("eventArgs.Keyword is required");
		}
		AddEventArg("kwd", eventArgs.Keyword);
		AddEventArg("page", eventArgs.Page);
		if (eventArgs.PeopleReturned != null)
		{
			AddEventArg("peopleReturned", eventArgs.PeopleReturned);
		}
	}

	/// <summary>
	/// Sends people search events to event streams.
	/// </summary>
	/// <param name="eventArgs"></param>
	/// <param name="IEventStreamer"></param>
	/// <param name="keyword"></param>
	/// <param name="pageNumber"></param>
	/// <param name="peopleReturned"></param>
	/// <param name="isMobileApp"></param>
	public static void SendPeopleSearchEvent(PeopleSearchEventArgs eventArgs, IEventStreamer IEventStreamer, string keyword, int pageNumber, string peopleReturned, bool isMobileApp)
	{
		if (!string.IsNullOrEmpty(keyword))
		{
			int page = pageNumber;
			eventArgs.Page = page.ToString();
			eventArgs.Keyword = keyword;
			eventArgs.PeopleReturned = peopleReturned;
			if (isMobileApp)
			{
				eventArgs.Target = EventTarget.MobileApp;
			}
			new PeopleSearchEvent(IEventStreamer, eventArgs).Stream();
		}
	}
}


}






