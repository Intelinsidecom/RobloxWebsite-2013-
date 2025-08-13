namespace Roblox.Kickbox;

public enum ErrorCodeType
{
	/// <summary>
	/// Specified email is not a valid email address syntax
	/// </summary>
	invalid_email,
	/// <summary>
	/// Domain for email does not exist
	/// </summary>
	invalid_domain,
	/// <summary>
	/// Email address was rejected by the SMTP server, email address does not exist
	/// </summary>
	rejected_email,
	/// <summary>
	/// Email address was accepted by the SMTP server
	/// </summary>
	accepted_email,
	/// <summary>
	/// Email address has quality issues that may make it a risky or low-value address
	/// </summary>
	low_quality,
	/// <summary>
	/// Email address appears to be deliverable, but deliverability cannot be guaranteed
	/// </summary>
	low_deliverability,
	/// <summary>
	/// Could not connect to SMTP server
	/// </summary>
	no_connect,
	/// <summary>
	/// SMTP session timed out
	/// </summary>
	timeout,
	/// <summary>
	/// SMTP server returned an unexpected/invalid response
	/// </summary>
	invalid_smtp,
	/// <summary>
	/// SMTP server was unavailable to process our request
	/// </summary>
	unavailable_smtp,
	/// <summary>
	/// An unexpected error has occurred
	/// </summary>
	unexpected_error
}
