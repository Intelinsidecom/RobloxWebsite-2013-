using Roblox.Platform.Core;

namespace Roblox.Platform.Email.Delivery;

/// <summary>
/// A default implementation class of <see cref="T:Roblox.Platform.Email.Delivery.IEmail" />.
/// </summary>
public class Email : IEmail
{
	/// <summary>
	/// The From field of the email.
	/// </summary>
	public string From { get; }

	/// <summary>
	/// The To field of the email.
	/// </summary>
	public string To { get; }

	/// <summary>
	/// The Subject of the email.
	/// </summary>
	public string Subject { get; }

	/// <summary>
	/// The body of a plain email.
	/// </summary>
	public string PlainBody { get; }

	/// <summary>
	/// The body of a html email.
	/// </summary>
	public string HtmlBody { get; }

	/// <summary>
	/// The body type of the email.
	/// </summary>
	public EmailBodyType BodyType { get; }

	/// <summary>
	/// The type of the email being tracked in PerfMon Counters.
	/// </summary>
	public string EmailType { get; }

	/// <summary>
	/// The default constructor of the <see cref="T:Roblox.Platform.Email.Delivery.Email" />.
	/// </summary>
	/// <param name="from">The from field.</param>
	/// <param name="to">The to field.</param>
	/// <param name="subject">The subject field.</param>
	/// <param name="bodyType">The email body type.</param>
	/// <param name="emailType">The type of the email being tracked.</param>
	/// <param name="plainBody">The plain body.</param>
	/// <param name="htmlBody">The html body.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">from
	/// or
	/// to
	/// or
	/// subject
	/// is null or white space.</exception>
	public Email(string from, string to, string subject, EmailBodyType bodyType, string emailType, string plainBody, string htmlBody = null)
	{
		if (string.IsNullOrWhiteSpace(from))
		{
			throw new PlatformArgumentException("from");
		}
		if (string.IsNullOrWhiteSpace(to))
		{
			throw new PlatformArgumentException("to");
		}
		if (string.IsNullOrWhiteSpace(subject))
		{
			throw new PlatformArgumentException("subject");
		}
		switch (bodyType)
		{
		case EmailBodyType.Plain:
			if (string.IsNullOrWhiteSpace(plainBody))
			{
				throw new PlatformArgumentException("plainBody");
			}
			break;
		case EmailBodyType.Html:
			if (string.IsNullOrWhiteSpace(htmlBody))
			{
				throw new PlatformArgumentException("htmlBody");
			}
			break;
		case EmailBodyType.Mime:
			if (string.IsNullOrWhiteSpace(plainBody) && string.IsNullOrWhiteSpace(htmlBody))
			{
				throw new PlatformArgumentException("plainBodyor htmlBody");
			}
			break;
		}
		From = from;
		To = to;
		Subject = subject;
		PlainBody = plainBody;
		HtmlBody = htmlBody;
		BodyType = bodyType;
		EmailType = emailType;
	}
}
