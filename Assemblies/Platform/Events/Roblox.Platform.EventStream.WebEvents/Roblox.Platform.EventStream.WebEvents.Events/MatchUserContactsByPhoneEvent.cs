using System;

namespace Roblox.Platform.EventStream.WebEvents.Events;

public class MatchUserContactsByPhoneEvent : WebEventBase
{
	private const string _Name = "contactFriendFinderContactsMatched";

	private const string _TotalNumberOfContacts = "contacts";

	private const string _NumberOfMatchedContacts = "matches";

	private const string _EventTime = "lt";

	public MatchUserContactsByPhoneEvent(IEventStreamer streamer, MatchUserContactsByPhoneEventArgs matchUserContactsEventArgs)
		: base(streamer, "contactFriendFinderContactsMatched", matchUserContactsEventArgs)
	{
		if (!matchUserContactsEventArgs.UserId.HasValue)
		{
			throw new ArgumentException(string.Format("{0}.UserId must be defined", "matchUserContactsEventArgs"));
		}
		AddEventArg("lt", matchUserContactsEventArgs.EventTime.ToString());
		AddEventArg("contacts", matchUserContactsEventArgs.Contacts.ToString());
		AddEventArg("matches", matchUserContactsEventArgs.Matches.ToString());
	}
}
