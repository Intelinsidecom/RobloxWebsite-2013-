namespace Roblox.TranslationResources.Feature;

public interface IMessagesResources : ITranslationResources
{
	/// <summary>
	/// Key: "Action.Archive"
	/// English String: "Archive"
	/// </summary>
	string ActionArchive { get; }

	/// <summary>
	/// Key: "Action.Back"
	/// English String: "Back"
	/// </summary>
	string ActionBack { get; }

	/// <summary>
	/// Key: "Action.Discard"
	/// English String: "Discard"
	/// </summary>
	string ActionDiscard { get; }

	/// <summary>
	/// Key: "Action.MarkAsRead"
	/// English String: "Mark As Read"
	/// </summary>
	string ActionMarkAsRead { get; }

	/// <summary>
	/// Key: "Action.MarkAsUnread"
	/// English String: "Mark As Unread"
	/// </summary>
	string ActionMarkAsUnread { get; }

	/// <summary>
	/// Key: "Action.MoveToInbox"
	/// English String: "Move To Inbox"
	/// </summary>
	string ActionMoveToInbox { get; }

	/// <summary>
	/// Key: "Action.Reply"
	/// English String: "Reply"
	/// </summary>
	string ActionReply { get; }

	/// <summary>
	/// Key: "Action.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	string ActionReportAbuse { get; }

	/// <summary>
	/// Key: "Action.Send"
	/// English String: "Send"
	/// </summary>
	string ActionSend { get; }

	/// <summary>
	/// Key: "Action.SendReply"
	/// English String: "Send Reply"
	/// </summary>
	string ActionSendReply { get; }

	/// <summary>
	/// Key: "Heading.Message"
	/// English String: "Messages"
	/// </summary>
	string HeadingMessage { get; }

	/// <summary>
	/// Key: "Heading.NewMessages"
	/// English String: "New Message"
	/// </summary>
	string HeadingNewMessages { get; }

	/// <summary>
	/// Key: "Heading.Response"
	/// English String: "Responses:"
	/// </summary>
	string HeadingResponse { get; }

	/// <summary>
	/// Key: "Label.All"
	/// English String: "All"
	/// </summary>
	string LabelAll { get; }

	/// <summary>
	/// Key: "Label.Archive"
	/// English String: "Archive"
	/// </summary>
	string LabelArchive { get; }

	/// <summary>
	/// Key: "Label.Inbox"
	/// English String: "Inbox"
	/// </summary>
	string LabelInbox { get; }

	/// <summary>
	/// Key: "Label.IncludeMessage"
	/// English String: "Include Previous Message"
	/// </summary>
	string LabelIncludeMessage { get; }

	/// <summary>
	/// Key: "Label.News"
	/// English String: "News"
	/// </summary>
	string LabelNews { get; }

	/// <summary>
	/// Key: "Label.Of"
	/// English String: "Of"
	/// </summary>
	string LabelOf { get; }

	/// <summary>
	/// Key: "Label.Select"
	/// English String: "Select..."
	/// </summary>
	string LabelSelect { get; }

	/// <summary>
	/// Key: "Label.Sent"
	/// English String: "Sent"
	/// </summary>
	string LabelSent { get; }

	/// <summary>
	/// Key: "Label.Subject"
	/// English String: "Subject:"
	/// </summary>
	string LabelSubject { get; }

	/// <summary>
	/// Key: "Label.To"
	/// English String: "To:"
	/// </summary>
	string LabelTo { get; }

	/// <summary>
	/// Key: "Message.BodyCantBlank"
	/// English String: "The message body can't be blank."
	/// </summary>
	string MessageBodyCantBlank { get; }

	/// <summary>
	/// Key: "Message.GeneralError"
	/// English String: "Sorry, an error occurred sending your message."
	/// </summary>
	string MessageGeneralError { get; }

	/// <summary>
	/// Key: "Message.IdTheftWarning"
	/// English String: "Remember, Roblox staff will never ask you for your password. People who ask for your password are trying to steal your account."
	/// </summary>
	string MessageIdTheftWarning { get; }

	/// <summary>
	/// Key: "Message.NoMessageExist"
	/// English String: "Message doesn't exist"
	/// </summary>
	string MessageNoMessageExist { get; }

	/// <summary>
	/// Key: "Message.NoNews"
	/// English String: "You have no news."
	/// </summary>
	string MessageNoNews { get; }

	/// <summary>
	/// Key: "Message.NoRecipient"
	/// English String: "Recipient doesn't exist!"
	/// </summary>
	string MessageNoRecipient { get; }

	/// <summary>
	/// Key: "Message.NotAuthorizeToManipulate"
	/// English String: "Not authorized to manipulate message"
	/// </summary>
	string MessageNotAuthorizeToManipulate { get; }

	/// <summary>
	/// Key: "Message.NotSendAndModerated"
	/// English String: "Your message was not sent because it was moderated."
	/// </summary>
	string MessageNotSendAndModerated { get; }

	/// <summary>
	/// Key: "Message.RecipientPrivacySettingsTooHigh"
	/// English String: "The recipient's privacy settings prevent you from sending this message."
	/// </summary>
	string MessageRecipientPrivacySettingsTooHigh { get; }

	/// <summary>
	/// Key: "Message.ReplyHere"
	/// English String: "Reply here..."
	/// </summary>
	string MessageReplyHere { get; }

	/// <summary>
	/// Key: "Message.RobloxWarning"
	/// English String: "Remember, Roblox staff will never ask you for your password. People who ask for your password are trying to steal your account."
	/// </summary>
	string MessageRobloxWarning { get; }

	/// <summary>
	/// Key: "Message.SendSuccessfully"
	/// English String: "Successfully sent message."
	/// </summary>
	string MessageSendSuccessfully { get; }

	/// <summary>
	/// Key: "Message.SendTooManyMessages"
	/// English String: "You're sending too many messages too quickly."
	/// </summary>
	string MessageSendTooManyMessages { get; }

	/// <summary>
	/// Key: "Message.SubjectCantBlank"
	/// English String: "The message subject can't be blank."
	/// </summary>
	string MessageSubjectCantBlank { get; }

	/// <summary>
	/// Key: "Message.UnknownError"
	/// English String: "Unknown error"
	/// </summary>
	string MessageUnknownError { get; }

	/// <summary>
	/// Key: "Message.UnknownMessageType"
	/// This serves as the fallback string for when an message type is received that the web chat does not know how to render.
	/// English String: "A message cannot be displayed"
	/// </summary>
	string MessageUnknownMessageType { get; }

	/// <summary>
	/// Key: "Message.WriteYourMessage"
	/// English String: "Write your message..."
	/// </summary>
	string MessageWriteYourMessage { get; }

	/// <summary>
	/// Key: "Label.NoMessagesInCategory"
	/// English String: "You have no {activeTab} messages."
	/// </summary>
	string LabelNoMessagesInCategory(string activeTab);

	/// <summary>
	/// Key: "Message.BodyTooLong"
	/// English String: "Please shorten your message to {maxLength} characters or less and try again."
	/// </summary>
	string MessageBodyTooLong(string maxLength);

	/// <summary>
	/// Key: "Message.SenderPrivacySettingTooHeight"
	/// English String: "Your {frontLink}privacy settings{endLink} prevent you from sending this message."
	/// </summary>
	string MessageSenderPrivacySettingTooHeight(string frontLink, string endLink);

	/// <summary>
	/// Key: "Message.VerifySenderEmail"
	/// English String: "You must verify your email on the {frontLink}Account Settings{endLink} page before you can send messages."
	/// </summary>
	string MessageVerifySenderEmail(string frontLink, string endLink);
}
