using System;

namespace Roblox.Platform.EventStream.WebEvents;

public class PeopleSearchEvent : WebEventBase
{
	private const string _Name = "peopleSearch";

	public PeopleSearchEvent(EventStreamer streamer, PeopleSearchEventArgs eventArgs)
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
	/// <param name="eventStreamer"></param>
	/// <param name="keyword"></param>
	/// <param name="pageNumber"></param>
	/// <param name="peopleReturned"></param>
	/// <param name="isMobileApp"></param>
	public static void SendPeopleSearchEvent(PeopleSearchEventArgs eventArgs, EventStreamer eventStreamer, string keyword, int pageNumber, string peopleReturned, bool isMobileApp)
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
			new PeopleSearchEvent(eventStreamer, eventArgs).Stream();
		}
	}
}
