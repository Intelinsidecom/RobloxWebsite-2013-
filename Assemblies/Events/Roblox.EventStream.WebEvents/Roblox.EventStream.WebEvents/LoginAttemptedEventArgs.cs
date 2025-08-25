using System;

namespace Roblox.Platform.EventStream.WebEvents;

public class LoginAttemptedEventArgs : WebEventArgs
{
	/// <summary>
	/// The context for the event
	/// </summary>
	public string Context { get; set; }

	/// <summary>
	/// The credentials type used for login.
	/// </summary>
	public string CredentialsType { get; set; }

	/// <summary>
	/// The result code for the login operation.
	/// </summary>
	public string ResultCode { get; set; }

	/// <summary>
	/// The time the event happened.
	/// </summary>
	public DateTime EventTime { get; set; }
}
