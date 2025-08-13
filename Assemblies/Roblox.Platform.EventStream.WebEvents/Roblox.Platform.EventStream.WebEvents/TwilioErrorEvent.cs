using System;

namespace Roblox.Platform.EventStream.WebEvents;

/// <summary>
/// Event triggered when an error occurs sending an SMS with Twilio
/// </summary>
public class TwilioErrorEvent : WebEventBase
{
	private const string _Name = "twilioError";

	private const string _PhoneNumber = "phoneNumber";

	private const string _HttpStatus = "httpStatus";

	private const string _ErrorCode = "errorCode";

	/// <summary>
	/// Constructs a <see cref="T:Roblox.Platform.EventStream.WebEvents.TwilioErrorEvent" /> with the given <see cref="T:Roblox.Platform.EventStream.IEventStreamer" /> and <see cref="T:Roblox.Platform.EventStream.WebEvents.TwilioErrorEventArgs" />
	/// </summary>
	/// <param name="eventStreamer">The streamer to send the event</param>
	/// <param name="twilioErrorEventArgs">The arguments for this event</param>
	/// <exception cref="T:System.ArgumentException">If the phone number is is not defined in the arguments</exception>
	public TwilioErrorEvent(IEventStreamer eventStreamer, TwilioErrorEventArgs twilioErrorEventArgs)
		: base(eventStreamer, "twilioError", twilioErrorEventArgs)
	{
		if (string.IsNullOrWhiteSpace(twilioErrorEventArgs.PhoneNumber))
		{
			throw new ArgumentException(string.Format("{0}.PhoneNumber must be defined", "twilioErrorEventArgs"));
		}
		AddEventArg("phoneNumber", twilioErrorEventArgs.PhoneNumber);
		if (twilioErrorEventArgs.ErrorCode.HasValue)
		{
			AddEventArg("errorCode", twilioErrorEventArgs.ErrorCode.Value.ToString());
		}
		if (twilioErrorEventArgs.HttpStatus.HasValue)
		{
			AddEventArg("httpStatus", twilioErrorEventArgs.HttpStatus.Value.ToString());
		}
	}
}
