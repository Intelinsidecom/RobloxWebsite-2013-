namespace Roblox.Platform.Email.Delivery;

/// <summary>
/// Provides a common interface for an object that represents an Email.
/// </summary>
public interface IEmail
{
	/// <summary>
	/// The From field of the email.
	/// </summary>
	string From { get; }

	/// <summary>
	/// The To field of the email.
	/// </summary>
	string To { get; }

	/// <summary>
	/// The Subject of the email.
	/// </summary>
	string Subject { get; }

	/// <summary>
	/// The body of a plain email.
	/// </summary>
	string PlainBody { get; }

	/// <summary>
	/// The body of a html email.
	/// </summary>
	string HtmlBody { get; }

	/// <summary>
	/// The body type of the email.
	/// </summary>
	EmailBodyType BodyType { get; }

	/// <summary>
	/// The type of the email being tracked in PerfMon Counters
	/// and displayed in performance charts.
	/// </summary>
	string EmailType { get; }
}
