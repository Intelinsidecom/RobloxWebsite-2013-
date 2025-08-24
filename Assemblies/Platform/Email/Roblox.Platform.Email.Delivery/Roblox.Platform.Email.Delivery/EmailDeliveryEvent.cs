namespace Roblox.Platform.Email.Delivery;

/// <summary>
/// A class used to hold the details necessary for the consuming code to send emails.
/// </summary>
public class EmailDeliveryEvent
{
	/// <summary>
	/// The 'To' field
	/// </summary>
	public string To { get; set; }

	/// <summary>
	/// The 'From' field.
	/// </summary>
	public string From { get; set; }

	/// <summary>
	/// The 'Subject' field.
	/// </summary>
	public string Subject { get; set; }

	/// <summary>
	/// The 'HTML body'.
	/// </summary>
	public string HtmlBody { get; set; }

	/// <summary>
	/// The plain text body.
	/// </summary>
	public string PlainTextBody { get; set; }

	/// <summary>
	/// The Email body type.
	/// </summary>
	public EmailBodyType EmailBodyType { get; set; }

	/// <summary>
	/// The type of the email.
	/// </summary>
	public string EmailType { get; set; }
}
