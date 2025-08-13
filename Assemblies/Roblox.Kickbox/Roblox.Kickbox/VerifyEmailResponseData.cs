using Newtonsoft.Json;

namespace Roblox.Kickbox;

internal class VerifyEmailResponseData
{
	/// <summary>
	/// The verification result: deliverable, undeliverable, risky, unknown
	/// </summary>
	[JsonProperty("result")]
	public string Result { get; set; }

	/// <summary>
	/// The reason code. The reason for the result. Possible reasons are:
	///  - invalid_email - Specified email is not a valid email address syntax
	///  - invalid_domain - Domain for email does not exist
	///  - rejected_email - Email address was rejected by the SMTP server, email address does not exist
	///  - accepted_email - Email address was accepted by the SMTP server
	///  - low_quality - Email address has quality issues that may make it a risky or low-value address
	///  - low_deliverability - Email address appears to be deliverable, but deliverability cannot be guaranteed
	///  - no_connect - Could not connect to SMTP server
	///  - timeout - SMTP session timed out
	///  - invalid_smtp - SMTP server returned an unexpected/invalid response
	///  - unavailable_smtp - SMTP server was unavailable to process our request
	///  - unexpected_error - An unexpected error has occurred
	/// </summary>
	[JsonProperty("reason")]
	public string Reason { get; set; }

	/// <summary>
	/// true if the email address is a role address (postmaster@example.com, support@example.com, etc)
	/// </summary>
	[JsonProperty("role")]
	public bool Role { get; set; }

	/// <summary>
	/// true if the email address uses a free email service like gmail.com or yahoo.com
	/// </summary>
	[JsonProperty("free")]
	public bool Free { get; set; }

	/// <summary>
	/// Whether the email was identified as a disposable address.
	/// </summary>
	[JsonProperty("disposable")]
	public bool Disposable { get; set; }

	/// <summary>
	/// true if the email was accepted, but the domain appears to accept all emails addressed to that domain
	/// </summary>
	[JsonProperty("accept_all")]
	public bool AcceptAll { get; set; }

	/// <summary>
	/// Returns a suggested email if a possible spelling error was detected. (bill.lumbergh@gamil.com -&gt; bill.lumbergh@gmail.com)
	/// </summary>
	[JsonProperty("did_you_mean")]
	public string DidYouMean { get; set; }

	/// <summary>
	/// A quality score of the provided email address ranging between 0 (no quality) and 1 (perfect quality). More information on the Sendex Score can be found here
	/// </summary>
	[JsonProperty("sendex")]
	public double Sendex { get; set; }

	/// <summary>
	/// Returns a normalized version of the provided email address. (BoB@example.com -&gt; bob@example.com)
	/// </summary>
	[JsonProperty("email")]
	public string Email { get; set; }

	/// <summary>
	/// The username part of the email address
	/// </summary>
	[JsonProperty("user")]
	public string User { get; set; }

	/// <summary>
	/// The email address domain.
	/// </summary>
	[JsonProperty("domain")]
	public string Domain { get; set; }

	/// <summary>
	/// true if the API request was successful (i.e., no authentication or unexpected errors occurred)
	/// </summary>
	[JsonProperty("success")]
	public bool Success { get; set; }

	/// <summary>
	/// The Kickbox error description.
	/// </summary>
	[JsonProperty("message")]
	public string Message { get; set; }
}
