using System;

namespace Roblox.Platform.EventStream.WebEvents.Events;

public class CountryChangedByUserEvent : WebEventBase
{
	private const string _EventName = "countryChanged";

	private const string _CountryChangedTo = "countryIdChangedTo";

	private const string _CountryChangedFrom = "countryIdChangedFrom";

	private const string _ActorId = "actorId";

	private const string _EventTime = "lt";

	public CountryChangedByUserEvent(IEventStreamer streamer, CountryChangedByUserEventArgs countryChangedByUserEventArgs)
		: base(streamer, "countryChanged", countryChangedByUserEventArgs)
	{
		if (!countryChangedByUserEventArgs.UserId.HasValue)
		{
			throw new ArgumentException(string.Format("{0}.UserId must be defined", "countryChangedByUserEventArgs"));
		}
		AddEventArg("lt", countryChangedByUserEventArgs.EventTime.ToString());
		AddEventArg("countryIdChangedTo", countryChangedByUserEventArgs.NewCountryId.ToString());
		if (countryChangedByUserEventArgs.PreviousCountryId.HasValue)
		{
			AddEventArg("countryIdChangedFrom", countryChangedByUserEventArgs.PreviousCountryId.Value.ToString());
		}
		AddEventArg("actorId", countryChangedByUserEventArgs.ActorId.ToString());
	}
}
