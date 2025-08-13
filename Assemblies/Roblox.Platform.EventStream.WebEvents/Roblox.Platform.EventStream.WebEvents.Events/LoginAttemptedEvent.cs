using System;

namespace Roblox.Platform.EventStream.WebEvents.Events;

public class LoginAttemptedEvent : WebEventBase
{
	private const string _Name = "loginAttempted";

	private const string _ContextArgName = "ctx";

	private const string _CredentialsTypeArgName = "ctype";

	private const string _ResultCodeArgName = "rcode";

	private const string _EventTimeArgName = "lt";

	public LoginAttemptedEvent(IEventStreamer streamer, LoginAttemptedEventArgs loginAttemptedEventArgs)
		: base(streamer, "loginAttempted", loginAttemptedEventArgs)
	{
		if (string.IsNullOrWhiteSpace(loginAttemptedEventArgs.CredentialsType))
		{
			throw new ArgumentException(string.Format("{0}. Can not be null or whitespace.", "CredentialsType"));
		}
		if (string.IsNullOrWhiteSpace(loginAttemptedEventArgs.ResultCode))
		{
			throw new ArgumentException(string.Format("{0}. Can not be null or whitespace.", "ResultCode"));
		}
		AddEventArg("ctx", loginAttemptedEventArgs.Context);
		AddEventArg("ctype", loginAttemptedEventArgs.CredentialsType);
		AddEventArg("rcode", loginAttemptedEventArgs.ResultCode);
		AddEventArg("lt", loginAttemptedEventArgs.EventTime.ToString());
	}
}
