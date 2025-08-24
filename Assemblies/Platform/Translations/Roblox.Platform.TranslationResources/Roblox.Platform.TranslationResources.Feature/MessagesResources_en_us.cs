using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class MessagesResources_en_us : TranslationResourcesBase, IMessagesResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.Archive"
	/// English String: "Archive"
	/// </summary>
	public virtual string ActionArchive => "Archive";

	/// <summary>
	/// Key: "Action.Back"
	/// English String: "Back"
	/// </summary>
	public virtual string ActionBack => "Back";

	/// <summary>
	/// Key: "Action.Discard"
	/// English String: "Discard"
	/// </summary>
	public virtual string ActionDiscard => "Discard";

	/// <summary>
	/// Key: "Action.MarkAsRead"
	/// English String: "Mark As Read"
	/// </summary>
	public virtual string ActionMarkAsRead => "Mark As Read";

	/// <summary>
	/// Key: "Action.MarkAsUnread"
	/// English String: "Mark As Unread"
	/// </summary>
	public virtual string ActionMarkAsUnread => "Mark As Unread";

	/// <summary>
	/// Key: "Action.MoveToInbox"
	/// English String: "Move To Inbox"
	/// </summary>
	public virtual string ActionMoveToInbox => "Move To Inbox";

	/// <summary>
	/// Key: "Action.Reply"
	/// English String: "Reply"
	/// </summary>
	public virtual string ActionReply => "Reply";

	/// <summary>
	/// Key: "Action.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public virtual string ActionReportAbuse => "Report Abuse";

	/// <summary>
	/// Key: "Action.Send"
	/// English String: "Send"
	/// </summary>
	public virtual string ActionSend => "Send";

	/// <summary>
	/// Key: "Action.SendReply"
	/// English String: "Send Reply"
	/// </summary>
	public virtual string ActionSendReply => "Send Reply";

	/// <summary>
	/// Key: "Heading.Message"
	/// English String: "Messages"
	/// </summary>
	public virtual string HeadingMessage => "Messages";

	/// <summary>
	/// Key: "Heading.NewMessages"
	/// English String: "New Message"
	/// </summary>
	public virtual string HeadingNewMessages => "New Message";

	/// <summary>
	/// Key: "Heading.Response"
	/// English String: "Responses:"
	/// </summary>
	public virtual string HeadingResponse => "Responses:";

	/// <summary>
	/// Key: "Label.All"
	/// English String: "All"
	/// </summary>
	public virtual string LabelAll => "All";

	/// <summary>
	/// Key: "Label.Archive"
	/// English String: "Archive"
	/// </summary>
	public virtual string LabelArchive => "Archive";

	/// <summary>
	/// Key: "Label.Inbox"
	/// English String: "Inbox"
	/// </summary>
	public virtual string LabelInbox => "Inbox";

	/// <summary>
	/// Key: "Label.IncludeMessage"
	/// English String: "Include Previous Message"
	/// </summary>
	public virtual string LabelIncludeMessage => "Include Previous Message";

	/// <summary>
	/// Key: "Label.News"
	/// English String: "News"
	/// </summary>
	public virtual string LabelNews => "News";

	/// <summary>
	/// Key: "Label.Of"
	/// English String: "Of"
	/// </summary>
	public virtual string LabelOf => "Of";

	/// <summary>
	/// Key: "Label.Select"
	/// English String: "Select..."
	/// </summary>
	public virtual string LabelSelect => "Select...";

	/// <summary>
	/// Key: "Label.Sent"
	/// English String: "Sent"
	/// </summary>
	public virtual string LabelSent => "Sent";

	/// <summary>
	/// Key: "Label.Subject"
	/// English String: "Subject:"
	/// </summary>
	public virtual string LabelSubject => "Subject:";

	/// <summary>
	/// Key: "Label.To"
	/// English String: "To:"
	/// </summary>
	public virtual string LabelTo => "To:";

	/// <summary>
	/// Key: "Message.BodyCantBlank"
	/// English String: "The message body can't be blank."
	/// </summary>
	public virtual string MessageBodyCantBlank => "The message body can't be blank.";

	/// <summary>
	/// Key: "Message.GeneralError"
	/// English String: "Sorry, an error occurred sending your message."
	/// </summary>
	public virtual string MessageGeneralError => "Sorry, an error occurred sending your message.";

	/// <summary>
	/// Key: "Message.IdTheftWarning"
	/// English String: "Remember, Roblox staff will never ask you for your password. People who ask for your password are trying to steal your account."
	/// </summary>
	public virtual string MessageIdTheftWarning => "Remember, Roblox staff will never ask you for your password. People who ask for your password are trying to steal your account.";

	/// <summary>
	/// Key: "Message.NoMessageExist"
	/// English String: "Message doesn't exist"
	/// </summary>
	public virtual string MessageNoMessageExist => "Message doesn't exist";

	/// <summary>
	/// Key: "Message.NoNews"
	/// English String: "You have no news."
	/// </summary>
	public virtual string MessageNoNews => "You have no news.";

	/// <summary>
	/// Key: "Message.NoRecipient"
	/// English String: "Recipient doesn't exist!"
	/// </summary>
	public virtual string MessageNoRecipient => "Recipient doesn't exist!";

	/// <summary>
	/// Key: "Message.NotAuthorizeToManipulate"
	/// English String: "Not authorized to manipulate message"
	/// </summary>
	public virtual string MessageNotAuthorizeToManipulate => "Not authorized to manipulate message";

	/// <summary>
	/// Key: "Message.NotSendAndModerated"
	/// English String: "Your message was not sent because it was moderated."
	/// </summary>
	public virtual string MessageNotSendAndModerated => "Your message was not sent because it was moderated.";

	/// <summary>
	/// Key: "Message.RecipientPrivacySettingsTooHigh"
	/// English String: "The recipient's privacy settings prevent you from sending this message."
	/// </summary>
	public virtual string MessageRecipientPrivacySettingsTooHigh => "The recipient's privacy settings prevent you from sending this message.";

	/// <summary>
	/// Key: "Message.ReplyHere"
	/// English String: "Reply here..."
	/// </summary>
	public virtual string MessageReplyHere => "Reply here...";

	/// <summary>
	/// Key: "Message.RobloxWarning"
	/// English String: "Remember, Roblox staff will never ask you for your password. People who ask for your password are trying to steal your account."
	/// </summary>
	public virtual string MessageRobloxWarning => "Remember, Roblox staff will never ask you for your password. People who ask for your password are trying to steal your account.";

	/// <summary>
	/// Key: "Message.SendSuccessfully"
	/// English String: "Successfully sent message."
	/// </summary>
	public virtual string MessageSendSuccessfully => "Successfully sent message.";

	/// <summary>
	/// Key: "Message.SendTooManyMessages"
	/// English String: "You're sending too many messages too quickly."
	/// </summary>
	public virtual string MessageSendTooManyMessages => "You're sending too many messages too quickly.";

	/// <summary>
	/// Key: "Message.SubjectCantBlank"
	/// English String: "The message subject can't be blank."
	/// </summary>
	public virtual string MessageSubjectCantBlank => "The message subject can't be blank.";

	/// <summary>
	/// Key: "Message.UnknownError"
	/// English String: "Unknown error"
	/// </summary>
	public virtual string MessageUnknownError => "Unknown error";

	/// <summary>
	/// Key: "Message.UnknownMessageType"
	/// This serves as the fallback string for when an message type is received that the web chat does not know how to render.
	/// English String: "A message cannot be displayed"
	/// </summary>
	public virtual string MessageUnknownMessageType => "A message cannot be displayed";

	/// <summary>
	/// Key: "Message.WriteYourMessage"
	/// English String: "Write your message..."
	/// </summary>
	public virtual string MessageWriteYourMessage => "Write your message...";

	public MessagesResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.Archive",
				_GetTemplateForActionArchive()
			},
			{
				"Action.Back",
				_GetTemplateForActionBack()
			},
			{
				"Action.Discard",
				_GetTemplateForActionDiscard()
			},
			{
				"Action.MarkAsRead",
				_GetTemplateForActionMarkAsRead()
			},
			{
				"Action.MarkAsUnread",
				_GetTemplateForActionMarkAsUnread()
			},
			{
				"Action.MoveToInbox",
				_GetTemplateForActionMoveToInbox()
			},
			{
				"Action.Reply",
				_GetTemplateForActionReply()
			},
			{
				"Action.ReportAbuse",
				_GetTemplateForActionReportAbuse()
			},
			{
				"Action.Send",
				_GetTemplateForActionSend()
			},
			{
				"Action.SendReply",
				_GetTemplateForActionSendReply()
			},
			{
				"Heading.Message",
				_GetTemplateForHeadingMessage()
			},
			{
				"Heading.NewMessages",
				_GetTemplateForHeadingNewMessages()
			},
			{
				"Heading.Response",
				_GetTemplateForHeadingResponse()
			},
			{
				"Label.All",
				_GetTemplateForLabelAll()
			},
			{
				"Label.Archive",
				_GetTemplateForLabelArchive()
			},
			{
				"Label.Inbox",
				_GetTemplateForLabelInbox()
			},
			{
				"Label.IncludeMessage",
				_GetTemplateForLabelIncludeMessage()
			},
			{
				"Label.News",
				_GetTemplateForLabelNews()
			},
			{
				"Label.NoMessagesInCategory",
				_GetTemplateForLabelNoMessagesInCategory()
			},
			{
				"Label.Of",
				_GetTemplateForLabelOf()
			},
			{
				"Label.Select",
				_GetTemplateForLabelSelect()
			},
			{
				"Label.Sent",
				_GetTemplateForLabelSent()
			},
			{
				"Label.Subject",
				_GetTemplateForLabelSubject()
			},
			{
				"Label.To",
				_GetTemplateForLabelTo()
			},
			{
				"Message.BodyCantBlank",
				_GetTemplateForMessageBodyCantBlank()
			},
			{
				"Message.BodyTooLong",
				_GetTemplateForMessageBodyTooLong()
			},
			{
				"Message.GeneralError",
				_GetTemplateForMessageGeneralError()
			},
			{
				"Message.IdTheftWarning",
				_GetTemplateForMessageIdTheftWarning()
			},
			{
				"Message.NoMessageExist",
				_GetTemplateForMessageNoMessageExist()
			},
			{
				"Message.NoNews",
				_GetTemplateForMessageNoNews()
			},
			{
				"Message.NoRecipient",
				_GetTemplateForMessageNoRecipient()
			},
			{
				"Message.NotAuthorizeToManipulate",
				_GetTemplateForMessageNotAuthorizeToManipulate()
			},
			{
				"Message.NotSendAndModerated",
				_GetTemplateForMessageNotSendAndModerated()
			},
			{
				"Message.RecipientPrivacySettingsTooHigh",
				_GetTemplateForMessageRecipientPrivacySettingsTooHigh()
			},
			{
				"Message.ReplyHere",
				_GetTemplateForMessageReplyHere()
			},
			{
				"Message.RobloxWarning",
				_GetTemplateForMessageRobloxWarning()
			},
			{
				"Message.SenderPrivacySettingTooHeight",
				_GetTemplateForMessageSenderPrivacySettingTooHeight()
			},
			{
				"Message.SendSuccessfully",
				_GetTemplateForMessageSendSuccessfully()
			},
			{
				"Message.SendTooManyMessages",
				_GetTemplateForMessageSendTooManyMessages()
			},
			{
				"Message.SubjectCantBlank",
				_GetTemplateForMessageSubjectCantBlank()
			},
			{
				"Message.UnknownError",
				_GetTemplateForMessageUnknownError()
			},
			{
				"Message.UnknownMessageType",
				_GetTemplateForMessageUnknownMessageType()
			},
			{
				"Message.VerifySenderEmail",
				_GetTemplateForMessageVerifySenderEmail()
			},
			{
				"Message.WriteYourMessage",
				_GetTemplateForMessageWriteYourMessage()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.Messages";
	}

	protected virtual string _GetTemplateForActionArchive()
	{
		return "Archive";
	}

	protected virtual string _GetTemplateForActionBack()
	{
		return "Back";
	}

	protected virtual string _GetTemplateForActionDiscard()
	{
		return "Discard";
	}

	protected virtual string _GetTemplateForActionMarkAsRead()
	{
		return "Mark As Read";
	}

	protected virtual string _GetTemplateForActionMarkAsUnread()
	{
		return "Mark As Unread";
	}

	protected virtual string _GetTemplateForActionMoveToInbox()
	{
		return "Move To Inbox";
	}

	protected virtual string _GetTemplateForActionReply()
	{
		return "Reply";
	}

	protected virtual string _GetTemplateForActionReportAbuse()
	{
		return "Report Abuse";
	}

	protected virtual string _GetTemplateForActionSend()
	{
		return "Send";
	}

	protected virtual string _GetTemplateForActionSendReply()
	{
		return "Send Reply";
	}

	protected virtual string _GetTemplateForHeadingMessage()
	{
		return "Messages";
	}

	protected virtual string _GetTemplateForHeadingNewMessages()
	{
		return "New Message";
	}

	protected virtual string _GetTemplateForHeadingResponse()
	{
		return "Responses:";
	}

	protected virtual string _GetTemplateForLabelAll()
	{
		return "All";
	}

	protected virtual string _GetTemplateForLabelArchive()
	{
		return "Archive";
	}

	protected virtual string _GetTemplateForLabelInbox()
	{
		return "Inbox";
	}

	protected virtual string _GetTemplateForLabelIncludeMessage()
	{
		return "Include Previous Message";
	}

	protected virtual string _GetTemplateForLabelNews()
	{
		return "News";
	}

	/// <summary>
	/// Key: "Label.NoMessagesInCategory"
	/// English String: "You have no {activeTab} messages."
	/// </summary>
	public virtual string LabelNoMessagesInCategory(string activeTab)
	{
		return $"You have no {activeTab} messages.";
	}

	protected virtual string _GetTemplateForLabelNoMessagesInCategory()
	{
		return "You have no {activeTab} messages.";
	}

	protected virtual string _GetTemplateForLabelOf()
	{
		return "Of";
	}

	protected virtual string _GetTemplateForLabelSelect()
	{
		return "Select...";
	}

	protected virtual string _GetTemplateForLabelSent()
	{
		return "Sent";
	}

	protected virtual string _GetTemplateForLabelSubject()
	{
		return "Subject:";
	}

	protected virtual string _GetTemplateForLabelTo()
	{
		return "To:";
	}

	protected virtual string _GetTemplateForMessageBodyCantBlank()
	{
		return "The message body can't be blank.";
	}

	/// <summary>
	/// Key: "Message.BodyTooLong"
	/// English String: "Please shorten your message to {maxLength} characters or less and try again."
	/// </summary>
	public virtual string MessageBodyTooLong(string maxLength)
	{
		return $"Please shorten your message to {maxLength} characters or less and try again.";
	}

	protected virtual string _GetTemplateForMessageBodyTooLong()
	{
		return "Please shorten your message to {maxLength} characters or less and try again.";
	}

	protected virtual string _GetTemplateForMessageGeneralError()
	{
		return "Sorry, an error occurred sending your message.";
	}

	protected virtual string _GetTemplateForMessageIdTheftWarning()
	{
		return "Remember, Roblox staff will never ask you for your password. People who ask for your password are trying to steal your account.";
	}

	protected virtual string _GetTemplateForMessageNoMessageExist()
	{
		return "Message doesn't exist";
	}

	protected virtual string _GetTemplateForMessageNoNews()
	{
		return "You have no news.";
	}

	protected virtual string _GetTemplateForMessageNoRecipient()
	{
		return "Recipient doesn't exist!";
	}

	protected virtual string _GetTemplateForMessageNotAuthorizeToManipulate()
	{
		return "Not authorized to manipulate message";
	}

	protected virtual string _GetTemplateForMessageNotSendAndModerated()
	{
		return "Your message was not sent because it was moderated.";
	}

	protected virtual string _GetTemplateForMessageRecipientPrivacySettingsTooHigh()
	{
		return "The recipient's privacy settings prevent you from sending this message.";
	}

	protected virtual string _GetTemplateForMessageReplyHere()
	{
		return "Reply here...";
	}

	protected virtual string _GetTemplateForMessageRobloxWarning()
	{
		return "Remember, Roblox staff will never ask you for your password. People who ask for your password are trying to steal your account.";
	}

	/// <summary>
	/// Key: "Message.SenderPrivacySettingTooHeight"
	/// English String: "Your {frontLink}privacy settings{endLink} prevent you from sending this message."
	/// </summary>
	public virtual string MessageSenderPrivacySettingTooHeight(string frontLink, string endLink)
	{
		return $"Your {frontLink}privacy settings{endLink} prevent you from sending this message.";
	}

	protected virtual string _GetTemplateForMessageSenderPrivacySettingTooHeight()
	{
		return "Your {frontLink}privacy settings{endLink} prevent you from sending this message.";
	}

	protected virtual string _GetTemplateForMessageSendSuccessfully()
	{
		return "Successfully sent message.";
	}

	protected virtual string _GetTemplateForMessageSendTooManyMessages()
	{
		return "You're sending too many messages too quickly.";
	}

	protected virtual string _GetTemplateForMessageSubjectCantBlank()
	{
		return "The message subject can't be blank.";
	}

	protected virtual string _GetTemplateForMessageUnknownError()
	{
		return "Unknown error";
	}

	protected virtual string _GetTemplateForMessageUnknownMessageType()
	{
		return "A message cannot be displayed";
	}

	/// <summary>
	/// Key: "Message.VerifySenderEmail"
	/// English String: "You must verify your email on the {frontLink}Account Settings{endLink} page before you can send messages."
	/// </summary>
	public virtual string MessageVerifySenderEmail(string frontLink, string endLink)
	{
		return $"You must verify your email on the {frontLink}Account Settings{endLink} page before you can send messages.";
	}

	protected virtual string _GetTemplateForMessageVerifySenderEmail()
	{
		return "You must verify your email on the {frontLink}Account Settings{endLink} page before you can send messages.";
	}

	protected virtual string _GetTemplateForMessageWriteYourMessage()
	{
		return "Write your message...";
	}
}
