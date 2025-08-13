namespace Roblox.Platform.EventStream.WebEvents;

public class TwilioErrorEventArgs : WebEventArgs
{
	/// <summary>
	/// The error code specified by Twilio
	/// </summary>
	public int? ErrorCode { get; set; }

	/// <summary>
	/// The status of the underlying HTTP request
	/// </summary>
	public int? HttpStatus { get; set; }

	/// <summary>
	/// The phone that we tried to contact
	/// </summary>
	public string PhoneNumber { get; set; }
}
