using System;

namespace Roblox.Platform.EventStream.WebEvents;

public class GroupSearchEvent : WebEventBase
{
	private const string _Name = "groupSearch";

	public GroupSearchEvent(EventStreamer streamer, GroupSearchEventArgs eventArgs)
		: base(streamer, "groupSearch", eventArgs)
	{
		if (string.IsNullOrWhiteSpace(eventArgs.Keyword))
		{
			throw new ArgumentException("eventArgs.Keyword is required");
		}
		AddEventArg("kwd", eventArgs.Keyword);
		AddEventArg("page", eventArgs.Page);
		if (eventArgs.GroupsReturned != null)
		{
			AddEventArg("groupsReturned", eventArgs.GroupsReturned);
		}
	}

	/// <summary>
	/// Sends group search events to event stream.
	/// </summary>
	/// <param name="eventArgs"></param>
	/// <param name="eventStreamer"></param>
	/// <param name="keyword"></param>
	/// <param name="pageNumber"></param>
	/// <param name="groupsReturned"></param>
	/// <param name="isMobileApp"></param>
	public static void SendGroupSearchEvent(GroupSearchEventArgs eventArgs, EventStreamer eventStreamer, string keyword, int pageNumber, string groupsReturned, bool isMobileApp)
	{
		if (!string.IsNullOrEmpty(keyword))
		{
			eventArgs.Page = pageNumber.ToString();
			eventArgs.Keyword = keyword;
			eventArgs.GroupsReturned = groupsReturned;
			if (isMobileApp)
			{
				eventArgs.Target = EventTarget.MobileApp;
			}
			new GroupSearchEvent(eventStreamer, eventArgs).Stream();
		}
	}
}
