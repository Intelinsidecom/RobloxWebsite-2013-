using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Mail;
using System.Net.Mime;
using System.Text.RegularExpressions;
using Roblox.Common.Mime;

namespace Roblox.Common;

/// <summary>
/// This class adds a few internet mail headers not already exposed by the 
/// System.Net.MailMessage.  It also provides support to encapsulate the
/// nested mail attachments in the Children collection.
/// </summary>
public class MailMessageEx : MailMessage
{
	public const string EmailRegexPattern = "(['\"]{1,}.+['\"]{1,}\\s+)?<?[\\w\\.\\-]+@[^\\.][\\w\\.\\-]+\\.[a-z]{2,}>?";

	private readonly List<MailMessageEx> _Children;

	public long Octets { get; set; }

	/// <summary>
	/// Gets or sets the message number of the MailMessage on the POP3 server.
	/// </summary>
	/// <value>The message number.</value>
	public int MessageNumber { get; internal set; }

	/// <summary>
	/// Gets the children MailMessage attachments.
	/// </summary>
	/// <value>The children MailMessage attachments.</value>
	public List<MailMessageEx> Children => _Children;

	public string PlainTextBody
	{
		get
		{
			if (ContentType.MediaType == MediaTypes.TextPlain)
			{
				return base.Body;
			}
			foreach (AlternateView view in base.AlternateViews)
			{
				if (view.ContentType.MediaType == MediaTypes.TextPlain)
				{
					return new StreamReader(view.ContentStream).ReadToEnd();
				}
			}
			return "";
		}
	}

	/// <summary>
	/// Gets the delivery date.
	/// </summary>
	/// <value>The delivery date.</value>
	public DateTime DeliveryDate
	{
		get
		{
			string date = GetHeader("date");
			if (string.IsNullOrEmpty(date))
			{
				return DateTime.MinValue;
			}
			return Convert.ToDateTime(date);
		}
	}

	/// <summary>
	/// Gets the return address.
	/// </summary>
	/// <value>The return address.</value>
	public MailAddress ReturnAddress
	{
		get
		{
			string replyTo = GetHeader("reply-to");
			if (string.IsNullOrEmpty(replyTo))
			{
				return null;
			}
			return CreateMailAddress(replyTo);
		}
	}

	/// <summary>
	/// Gets the routing.
	/// </summary>
	/// <value>The routing.</value>
	public string Routing => GetHeader("received");

	/// <summary>
	/// Gets the message id.
	/// </summary>
	/// <value>The message id.</value>
	public string MessageId => GetHeader("message-id");

	public string ReplyToMessageId => GetHeader("in-reply-to", stripBrackets: true);

	/// <summary>
	/// Gets the MIME version.
	/// </summary>
	/// <value>The MIME version.</value>
	public string MimeVersion => GetHeader("mime-version");

	/// <summary>
	/// Gets the content id.
	/// </summary>
	/// <value>The content id.</value>
	public string ContentId => GetHeader("content-id");

	/// <summary>
	/// Gets the content description.
	/// </summary>
	/// <value>The content description.</value>
	public string ContentDescription => GetHeader("content-description");

	/// <summary>
	/// Gets the content disposition.
	/// </summary>
	/// <value>The content disposition.</value>
	public ContentDisposition ContentDisposition
	{
		get
		{
			string contentDisposition = GetHeader("content-disposition");
			if (string.IsNullOrEmpty(contentDisposition))
			{
				return null;
			}
			return new ContentDisposition(contentDisposition);
		}
	}

	/// <summary>
	/// Gets the type of the content.
	/// </summary>
	/// <value>The type of the content.</value>
	public ContentType ContentType
	{
		get
		{
			string contentType = GetHeader("content-type");
			if (string.IsNullOrEmpty(contentType))
			{
				return null;
			}
			return MimeReader.GetContentType(contentType);
		}
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Common.MailMessageEx" /> class.
	/// </summary>
	public MailMessageEx()
	{
		_Children = new List<MailMessageEx>();
	}

	/// <summary>
	/// Gets the header.
	/// </summary>
	/// <param name="header">The header.</param>
	/// <returns></returns>
	private string GetHeader(string header)
	{
		return GetHeader(header, stripBrackets: false);
	}

	private string GetHeader(string header, bool stripBrackets)
	{
		if (stripBrackets)
		{
			return MimeEntity.TrimBrackets(base.Headers[header]);
		}
		return base.Headers[header];
	}

	/// <summary>
	/// Creates the mail message from entity.
	/// </summary>
	/// <param name="entity">The entity.</param>
	/// <returns></returns>
	public static MailMessageEx CreateMailMessageFromEntity(MimeEntity entity)
	{
		MailMessageEx message = new MailMessageEx();
		string[] allKeys = entity.Headers.AllKeys;
		foreach (string key in allKeys)
		{
			string value = entity.Headers[key];
			if (value.Equals(string.Empty))
			{
				value = " ";
			}
			message.Headers.Add(key.ToLowerInvariant(), value);
			switch (key.ToLowerInvariant())
			{
			case "bcc":
				PopulateAddressList(value, message.Bcc);
				break;
			case "cc":
				PopulateAddressList(value, message.CC);
				break;
			case "from":
				message.From = CreateMailAddress(value);
				break;
			case "reply-to":
				message.ReplyToList.Add(CreateMailAddress(value));
				break;
			case "subject":
				message.Subject = value;
				break;
			case "to":
				PopulateAddressList(value, message.To);
				break;
			}
		}
		return message;
	}

	/// <summary>
	/// Creates the mail address.
	/// </summary>
	/// <param name="address">The address.</param>
	/// <returns></returns>
	public static MailAddress CreateMailAddress(string address)
	{
		try
		{
			return new MailAddress(address.Trim('\t'));
		}
		catch (FormatException e)
		{
			throw new ApplicationException($"Unable to create mail address from provided string: {address}", e);
		}
	}

	/// <summary>
	/// Populates the address list.
	/// </summary>
	/// <param name="addressList">The address list.</param>
	/// <param name="recipients">The recipients.</param>
	public static void PopulateAddressList(string addressList, MailAddressCollection recipients)
	{
		foreach (MailAddress address in GetMailAddresses(addressList))
		{
			recipients.Add(address);
		}
	}

	/// <summary>
	/// Gets the mail addresses.
	/// </summary>
	/// <param name="addressList">The address list.</param>
	/// <returns></returns>
	private static IEnumerable<MailAddress> GetMailAddresses(string addressList)
	{
		Regex email = new Regex("(['\"]{1,}.+['\"]{1,}\\s+)?<?[\\w\\.\\-]+@[^\\.][\\w\\.\\-]+\\.[a-z]{2,}>?");
		foreach (Match match in email.Matches(addressList))
		{
			yield return CreateMailAddress(match.Value);
		}
	}
}
