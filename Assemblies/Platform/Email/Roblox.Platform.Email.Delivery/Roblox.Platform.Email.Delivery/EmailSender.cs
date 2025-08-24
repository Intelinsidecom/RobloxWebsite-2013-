using System;
using Roblox.Common.Properties;
using Roblox.EventLog;
using Roblox.Instrumentation;
using Roblox.Platform.Core;
using Roblox.TranslationResources.Communication;

namespace Roblox.Platform.Email.Delivery;

/// <summary>
/// An implementation of <see cref="T:Roblox.Platform.Email.Delivery.IEmailSender" />.
/// </summary>
/// <seealso cref="T:Roblox.Platform.Email.Delivery.IEmailSender" />
public class EmailSender : IEmailSender
{
	internal readonly ILogger _Logger;

	internal readonly IEmailPerformanceMonitor _EmailPerformanceMonitor;

	internal readonly IEmailDeliveryEventsPublisher _EmailDeliveryEventsPublisher;

	internal const string TestEmailSubjectAddition = " [THIS IS A TEST MESSAGE]";

	internal const string TestEmailPlainBodyAddition = "\r\n\r\nThis message was sent from a test site and is intended for Roblox test administrators only. If you are not a Roblox test administrator you have received this message in error. We're sorry for our mistake. Please forward this email to info@roblox.com. No real money was ever involved in any transaction described in this email, and your account on the main Roblox site does not have any relationship to any information in this email.";

	internal const string TestEmailHtmlBodyAddition = "<br/><br/>This message was sent from a test site and is intended for Roblox test administrators only. If you are not a Roblox test administrator you have received this message in error. We're sorry for our mistake. Please forward this email to info@roblox.com. No real money was ever involved in any transaction described in this email, and your account on the main Roblox site does not have any relationship to any information in this email.";

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Email.Delivery.EmailSender" /> class. Used for testing purposes.
	/// </summary>
	/// <param name="logger">The <see cref="T:Roblox.EventLog.ILogger" />.</param>
	/// <param name="emailDeliveryEventsPublisher">The <see cref="T:Roblox.Platform.Email.Delivery.IEmailDeliveryEventsPublisher" />.</param>
	/// <param name="emailPerformanceMonitor">The <see cref="T:Roblox.Platform.Email.Delivery.IEmailPerformanceMonitor" />.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">
	/// logger
	/// or
	/// emailDeliveryEventsPublisher
	/// or
	/// emailPerformanceMonitor
	/// </exception>
	internal EmailSender(ILogger logger, IEmailDeliveryEventsPublisher emailDeliveryEventsPublisher, IEmailPerformanceMonitor emailPerformanceMonitor)
	{
		_Logger = logger ?? throw new PlatformArgumentNullException("logger");
		_EmailDeliveryEventsPublisher = emailDeliveryEventsPublisher ?? throw new PlatformArgumentNullException("emailDeliveryEventsPublisher");
		_EmailPerformanceMonitor = emailPerformanceMonitor ?? throw new PlatformArgumentNullException("emailPerformanceMonitor");
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Email.Delivery.EmailSender" /> class.
	/// </summary>
	/// <param name="logger">The <see cref="T:Roblox.EventLog.ILogger" />.</param>
	/// <param name="counterRegistry">the counter registry (used by the <see cref="T:Roblox.Instrumentation.ICounterReporter" /> for telemetry)</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">The <see cref="T:Roblox.EventLog.ILogger" />.</exception>
	public EmailSender(ILogger logger, ICounterRegistry counterRegistry)
		: this(logger, new EmailDeliveryEventsPublisher(counterRegistry), new EmailPerformanceMonitor(counterRegistry))
	{
	}

	/// <inheritdoc />
	public void SendEmail(IEmail email)
	{
		SendEmail(email, null);
	}

	/// <inheritdoc />
	public void SendEmail(IEmail email, ICommonEmailResources commonEmailResources)
	{
		ValidateInputEmail(email);
		try
		{
			PublishEmailToSns(email, commonEmailResources);
		}
		catch (Exception ex)
		{
			_EmailPerformanceMonitor.RecordEmailException(email, ex);
			_Logger.Error(ex);
			throw new EmailQueueingException("Error queuing email to SNS.", ex);
		}
		_EmailPerformanceMonitor.RecordEmailSent(email);
	}

	internal void PublishEmailToSns(IEmail email, ICommonEmailResources commonEmailResources = null)
	{
		string subject = email.Subject;
		string plainBody = email.PlainBody;
		string htmlBody = email.HtmlBody;
		if (email.BodyType == EmailBodyType.Plain)
		{
			if (ShouldIncludeTestEmailIdentifiers())
			{
				subject += " [THIS IS A TEST MESSAGE]";
				plainBody += "\r\n\r\nThis message was sent from a test site and is intended for Roblox test administrators only. If you are not a Roblox test administrator you have received this message in error. We're sorry for our mistake. Please forward this email to info@roblox.com. No real money was ever involved in any transaction described in this email, and your account on the main Roblox site does not have any relationship to any information in this email.";
			}
			plainBody = plainBody + "\r\n\r\n" + GetEnviromentIdentifierGeneratedMessage(commonEmailResources);
		}
		else
		{
			if (ShouldIncludeTestEmailIdentifiers())
			{
				subject += " [THIS IS A TEST MESSAGE]";
				plainBody += "\r\n\r\nThis message was sent from a test site and is intended for Roblox test administrators only. If you are not a Roblox test administrator you have received this message in error. We're sorry for our mistake. Please forward this email to info@roblox.com. No real money was ever involved in any transaction described in this email, and your account on the main Roblox site does not have any relationship to any information in this email.";
				htmlBody += "<br/><br/>This message was sent from a test site and is intended for Roblox test administrators only. If you are not a Roblox test administrator you have received this message in error. We're sorry for our mistake. Please forward this email to info@roblox.com. No real money was ever involved in any transaction described in this email, and your account on the main Roblox site does not have any relationship to any information in this email.";
			}
			plainBody = plainBody + "\r\n\r\n" + GetEnviromentIdentifierGeneratedMessage(commonEmailResources);
			htmlBody = htmlBody + "<br/><br/>" + GetEnviromentIdentifierGeneratedMessage(commonEmailResources);
		}
		EmailDeliveryEvent emailDeliveryEvent = new EmailDeliveryEvent
		{
			To = email.To,
			From = email.From,
			Subject = subject,
			PlainTextBody = plainBody,
			HtmlBody = htmlBody,
			EmailType = email.EmailType,
			EmailBodyType = email.BodyType
		};
		_EmailDeliveryEventsPublisher.Publish(emailDeliveryEvent);
	}

	private void ValidateInputEmail(IEmail email)
	{
		if (email == null)
		{
			throw new PlatformArgumentNullException("email");
		}
		if (string.IsNullOrWhiteSpace(email.From))
		{
			throw new EmailInvalidException(string.Format("{0} is null or white space.", "From"), "Invalid email address.");
		}
		if (string.IsNullOrWhiteSpace(email.To))
		{
			throw new EmailInvalidException(string.Format("{0} is null or white space.", "To"), "Invalid email address.");
		}
		if (string.IsNullOrWhiteSpace(email.Subject))
		{
			throw new EmailInvalidException(string.Format("{0} is null or white space.", "Subject"), "Invalid email subject.");
		}
		if (string.IsNullOrWhiteSpace(email.EmailType))
		{
			throw new EmailInvalidException(string.Format("{0} is null or white space.", "EmailType"), "Invalid email type.");
		}
		switch (email.BodyType)
		{
		case EmailBodyType.Plain:
			if (string.IsNullOrWhiteSpace(email.PlainBody))
			{
				throw new EmailInvalidException(string.Format("{0} is {1} but {2} is null or white space.", "BodyType", email.BodyType, "PlainBody"), "Invalid email body.");
			}
			break;
		case EmailBodyType.Html:
			if (string.IsNullOrWhiteSpace(email.HtmlBody))
			{
				throw new EmailInvalidException(string.Format("{0} is {1} but {2} is null or white space.", "BodyType", email.BodyType, "HtmlBody"), "Invalid email body.");
			}
			break;
		case EmailBodyType.Mime:
			if (string.IsNullOrWhiteSpace(email.PlainBody))
			{
				throw new EmailInvalidException(string.Format("{0} is {1} but {2} is null or white space.", "BodyType", email.BodyType, "PlainBody"), "Invalid email body.");
			}
			if (string.IsNullOrWhiteSpace(email.HtmlBody))
			{
				throw new EmailInvalidException(string.Format("{0} is {1} but {2} is null or white space.", "BodyType", email.BodyType, "HtmlBody"), "Invalid email body.");
			}
			break;
		}
	}

	internal virtual bool ShouldIncludeTestEmailIdentifiers()
	{
		return Settings.Default.IncludeTestEmailIdentifiers;
	}

	internal virtual string GetEnviromentIdentifierGeneratedMessage(ICommonEmailResources commonEmailResources = null)
	{
		if (commonEmailResources == null)
		{
			return "This message was generated by " + Settings.Default.EnvironmentIdentifier;
		}
		return commonEmailResources.DescriptionMessageGenerationContent(Settings.Default.EnvironmentIdentifier);
	}
}
