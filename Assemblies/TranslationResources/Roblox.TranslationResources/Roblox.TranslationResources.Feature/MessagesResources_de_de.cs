namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides MessagesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class MessagesResources_de_de : MessagesResources_en_us, IMessagesResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Archive"
	/// English String: "Archive"
	/// </summary>
	public override string ActionArchive => "Archivieren";

	/// <summary>
	/// Key: "Action.Back"
	/// English String: "Back"
	/// </summary>
	public override string ActionBack => "Zurück";

	/// <summary>
	/// Key: "Action.Discard"
	/// English String: "Discard"
	/// </summary>
	public override string ActionDiscard => "Verwerfen";

	/// <summary>
	/// Key: "Action.MarkAsRead"
	/// English String: "Mark As Read"
	/// </summary>
	public override string ActionMarkAsRead => "Als gelesen markieren";

	/// <summary>
	/// Key: "Action.MarkAsUnread"
	/// English String: "Mark As Unread"
	/// </summary>
	public override string ActionMarkAsUnread => "Als ungelesen markieren";

	/// <summary>
	/// Key: "Action.MoveToInbox"
	/// English String: "Move To Inbox"
	/// </summary>
	public override string ActionMoveToInbox => "In Posteingang verschieben";

	/// <summary>
	/// Key: "Action.Reply"
	/// English String: "Reply"
	/// </summary>
	public override string ActionReply => "Antworten";

	/// <summary>
	/// Key: "Action.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string ActionReportAbuse => "Verstoß melden";

	/// <summary>
	/// Key: "Action.Send"
	/// English String: "Send"
	/// </summary>
	public override string ActionSend => "Senden";

	/// <summary>
	/// Key: "Action.SendReply"
	/// English String: "Send Reply"
	/// </summary>
	public override string ActionSendReply => "Antwort senden";

	/// <summary>
	/// Key: "Heading.Message"
	/// English String: "Messages"
	/// </summary>
	public override string HeadingMessage => "Nachrichten";

	/// <summary>
	/// Key: "Heading.NewMessages"
	/// English String: "New Message"
	/// </summary>
	public override string HeadingNewMessages => "Neue Nachricht";

	/// <summary>
	/// Key: "Heading.Response"
	/// English String: "Responses:"
	/// </summary>
	public override string HeadingResponse => "Antworten:";

	/// <summary>
	/// Key: "Label.All"
	/// English String: "All"
	/// </summary>
	public override string LabelAll => "Alle";

	/// <summary>
	/// Key: "Label.Archive"
	/// English String: "Archive"
	/// </summary>
	public override string LabelArchive => "Archiv";

	/// <summary>
	/// Key: "Label.Inbox"
	/// English String: "Inbox"
	/// </summary>
	public override string LabelInbox => "Posteingang";

	/// <summary>
	/// Key: "Label.IncludeMessage"
	/// English String: "Include Previous Message"
	/// </summary>
	public override string LabelIncludeMessage => "Vorherige Nachricht einfügen";

	/// <summary>
	/// Key: "Label.News"
	/// English String: "News"
	/// </summary>
	public override string LabelNews => "Neuigkeiten";

	/// <summary>
	/// Key: "Label.Of"
	/// English String: "Of"
	/// </summary>
	public override string LabelOf => "Von";

	/// <summary>
	/// Key: "Label.Select"
	/// English String: "Select..."
	/// </summary>
	public override string LabelSelect => "Wählen\u00a0...";

	/// <summary>
	/// Key: "Label.Sent"
	/// English String: "Sent"
	/// </summary>
	public override string LabelSent => "Gesendet";

	/// <summary>
	/// Key: "Label.Subject"
	/// English String: "Subject:"
	/// </summary>
	public override string LabelSubject => "Betreff:";

	/// <summary>
	/// Key: "Label.To"
	/// English String: "To:"
	/// </summary>
	public override string LabelTo => "An:";

	/// <summary>
	/// Key: "Message.BodyCantBlank"
	/// English String: "The message body can't be blank."
	/// </summary>
	public override string MessageBodyCantBlank => "Der Nachrichtentext darf nicht leer sein.";

	/// <summary>
	/// Key: "Message.GeneralError"
	/// English String: "Sorry, an error occurred sending your message."
	/// </summary>
	public override string MessageGeneralError => "Beim Senden deiner Nachricht ist leider ein Fehler aufgetreten.";

	/// <summary>
	/// Key: "Message.IdTheftWarning"
	/// English String: "Remember, Roblox staff will never ask you for your password. People who ask for your password are trying to steal your account."
	/// </summary>
	public override string MessageIdTheftWarning => "Vergiss nicht, dass Roblox-Mitarbeiter dich niemals nach deinem Passwort fragen werden. Personen, die dich nach deinem Passwort fragen, möchten dein Konto stehlen.";

	/// <summary>
	/// Key: "Message.NoMessageExist"
	/// English String: "Message doesn't exist"
	/// </summary>
	public override string MessageNoMessageExist => "Nachricht existiert nicht.";

	/// <summary>
	/// Key: "Message.NoNews"
	/// English String: "You have no news."
	/// </summary>
	public override string MessageNoNews => "Du hast keine Neuigkeiten.";

	/// <summary>
	/// Key: "Message.NoRecipient"
	/// English String: "Recipient doesn't exist!"
	/// </summary>
	public override string MessageNoRecipient => "Empfänger existiert nicht!";

	/// <summary>
	/// Key: "Message.NotAuthorizeToManipulate"
	/// English String: "Not authorized to manipulate message"
	/// </summary>
	public override string MessageNotAuthorizeToManipulate => "Du bist nicht dazu berechtigt, die Nachricht zu bearbeiten.";

	/// <summary>
	/// Key: "Message.NotSendAndModerated"
	/// English String: "Your message was not sent because it was moderated."
	/// </summary>
	public override string MessageNotSendAndModerated => "Deine Nachricht wurde nicht gesendet, da sie von einem Moderator angepasst wurde.";

	/// <summary>
	/// Key: "Message.RecipientPrivacySettingsTooHigh"
	/// English String: "The recipient's privacy settings prevent you from sending this message."
	/// </summary>
	public override string MessageRecipientPrivacySettingsTooHigh => "Aufgrund der Datenschutzeinstellungen des Empfängers kannst du diese Nachricht nicht senden.";

	/// <summary>
	/// Key: "Message.ReplyHere"
	/// English String: "Reply here..."
	/// </summary>
	public override string MessageReplyHere => "Antworte hier\u00a0...";

	/// <summary>
	/// Key: "Message.RobloxWarning"
	/// English String: "Remember, Roblox staff will never ask you for your password. People who ask for your password are trying to steal your account."
	/// </summary>
	public override string MessageRobloxWarning => "Vergiss nicht, dass Roblox-Mitarbeiter dich niemals nach deinem Passwort fragen werden. Personen, die dich nach deinem Passwort fragen, möchten dein Konto stehlen.";

	/// <summary>
	/// Key: "Message.SendSuccessfully"
	/// English String: "Successfully sent message."
	/// </summary>
	public override string MessageSendSuccessfully => "Nachricht erfolgreich gesendet.";

	/// <summary>
	/// Key: "Message.SendTooManyMessages"
	/// English String: "You're sending too many messages too quickly."
	/// </summary>
	public override string MessageSendTooManyMessages => "Du sendest zu schnell zu viele Nachrichten.";

	/// <summary>
	/// Key: "Message.SubjectCantBlank"
	/// English String: "The message subject can't be blank."
	/// </summary>
	public override string MessageSubjectCantBlank => "Der Nachrichtenbetreff darf nicht leer sein.";

	/// <summary>
	/// Key: "Message.UnknownError"
	/// English String: "Unknown error"
	/// </summary>
	public override string MessageUnknownError => "Unbekannter Fehler";

	/// <summary>
	/// Key: "Message.UnknownMessageType"
	/// This serves as the fallback string for when an message type is received that the web chat does not know how to render.
	/// English String: "A message cannot be displayed"
	/// </summary>
	public override string MessageUnknownMessageType => "Eine Nachricht kann nicht angezeigt werden";

	/// <summary>
	/// Key: "Message.WriteYourMessage"
	/// English String: "Write your message..."
	/// </summary>
	public override string MessageWriteYourMessage => "Verfasse deine Nachricht\u00a0...";

	public MessagesResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionArchive()
	{
		return "Archivieren";
	}

	protected override string _GetTemplateForActionBack()
	{
		return "Zurück";
	}

	protected override string _GetTemplateForActionDiscard()
	{
		return "Verwerfen";
	}

	protected override string _GetTemplateForActionMarkAsRead()
	{
		return "Als gelesen markieren";
	}

	protected override string _GetTemplateForActionMarkAsUnread()
	{
		return "Als ungelesen markieren";
	}

	protected override string _GetTemplateForActionMoveToInbox()
	{
		return "In Posteingang verschieben";
	}

	protected override string _GetTemplateForActionReply()
	{
		return "Antworten";
	}

	protected override string _GetTemplateForActionReportAbuse()
	{
		return "Verstoß melden";
	}

	protected override string _GetTemplateForActionSend()
	{
		return "Senden";
	}

	protected override string _GetTemplateForActionSendReply()
	{
		return "Antwort senden";
	}

	protected override string _GetTemplateForHeadingMessage()
	{
		return "Nachrichten";
	}

	protected override string _GetTemplateForHeadingNewMessages()
	{
		return "Neue Nachricht";
	}

	protected override string _GetTemplateForHeadingResponse()
	{
		return "Antworten:";
	}

	protected override string _GetTemplateForLabelAll()
	{
		return "Alle";
	}

	protected override string _GetTemplateForLabelArchive()
	{
		return "Archiv";
	}

	protected override string _GetTemplateForLabelInbox()
	{
		return "Posteingang";
	}

	protected override string _GetTemplateForLabelIncludeMessage()
	{
		return "Vorherige Nachricht einfügen";
	}

	protected override string _GetTemplateForLabelNews()
	{
		return "Neuigkeiten";
	}

	/// <summary>
	/// Key: "Label.NoMessagesInCategory"
	/// English String: "You have no {activeTab} messages."
	/// </summary>
	public override string LabelNoMessagesInCategory(string activeTab)
	{
		return $"Du hast keine „{activeTab}“-Nachrichten.";
	}

	protected override string _GetTemplateForLabelNoMessagesInCategory()
	{
		return "Du hast keine „{activeTab}“-Nachrichten.";
	}

	protected override string _GetTemplateForLabelOf()
	{
		return "Von";
	}

	protected override string _GetTemplateForLabelSelect()
	{
		return "Wählen\u00a0...";
	}

	protected override string _GetTemplateForLabelSent()
	{
		return "Gesendet";
	}

	protected override string _GetTemplateForLabelSubject()
	{
		return "Betreff:";
	}

	protected override string _GetTemplateForLabelTo()
	{
		return "An:";
	}

	protected override string _GetTemplateForMessageBodyCantBlank()
	{
		return "Der Nachrichtentext darf nicht leer sein.";
	}

	/// <summary>
	/// Key: "Message.BodyTooLong"
	/// English String: "Please shorten your message to {maxLength} characters or less and try again."
	/// </summary>
	public override string MessageBodyTooLong(string maxLength)
	{
		return $"Bitte kürze deine Nachricht auf maximal {maxLength} Zeichen und versuche es dann erneut.";
	}

	protected override string _GetTemplateForMessageBodyTooLong()
	{
		return "Bitte kürze deine Nachricht auf maximal {maxLength} Zeichen und versuche es dann erneut.";
	}

	protected override string _GetTemplateForMessageGeneralError()
	{
		return "Beim Senden deiner Nachricht ist leider ein Fehler aufgetreten.";
	}

	protected override string _GetTemplateForMessageIdTheftWarning()
	{
		return "Vergiss nicht, dass Roblox-Mitarbeiter dich niemals nach deinem Passwort fragen werden. Personen, die dich nach deinem Passwort fragen, möchten dein Konto stehlen.";
	}

	protected override string _GetTemplateForMessageNoMessageExist()
	{
		return "Nachricht existiert nicht.";
	}

	protected override string _GetTemplateForMessageNoNews()
	{
		return "Du hast keine Neuigkeiten.";
	}

	protected override string _GetTemplateForMessageNoRecipient()
	{
		return "Empfänger existiert nicht!";
	}

	protected override string _GetTemplateForMessageNotAuthorizeToManipulate()
	{
		return "Du bist nicht dazu berechtigt, die Nachricht zu bearbeiten.";
	}

	protected override string _GetTemplateForMessageNotSendAndModerated()
	{
		return "Deine Nachricht wurde nicht gesendet, da sie von einem Moderator angepasst wurde.";
	}

	protected override string _GetTemplateForMessageRecipientPrivacySettingsTooHigh()
	{
		return "Aufgrund der Datenschutzeinstellungen des Empfängers kannst du diese Nachricht nicht senden.";
	}

	protected override string _GetTemplateForMessageReplyHere()
	{
		return "Antworte hier\u00a0...";
	}

	protected override string _GetTemplateForMessageRobloxWarning()
	{
		return "Vergiss nicht, dass Roblox-Mitarbeiter dich niemals nach deinem Passwort fragen werden. Personen, die dich nach deinem Passwort fragen, möchten dein Konto stehlen.";
	}

	/// <summary>
	/// Key: "Message.SenderPrivacySettingTooHeight"
	/// English String: "Your {frontLink}privacy settings{endLink} prevent you from sending this message."
	/// </summary>
	public override string MessageSenderPrivacySettingTooHeight(string frontLink, string endLink)
	{
		return $"Aufgrund deiner {frontLink}Datenschutzeinstellungen{endLink} kannst du diese Nachricht nicht senden.";
	}

	protected override string _GetTemplateForMessageSenderPrivacySettingTooHeight()
	{
		return "Aufgrund deiner {frontLink}Datenschutzeinstellungen{endLink} kannst du diese Nachricht nicht senden.";
	}

	protected override string _GetTemplateForMessageSendSuccessfully()
	{
		return "Nachricht erfolgreich gesendet.";
	}

	protected override string _GetTemplateForMessageSendTooManyMessages()
	{
		return "Du sendest zu schnell zu viele Nachrichten.";
	}

	protected override string _GetTemplateForMessageSubjectCantBlank()
	{
		return "Der Nachrichtenbetreff darf nicht leer sein.";
	}

	protected override string _GetTemplateForMessageUnknownError()
	{
		return "Unbekannter Fehler";
	}

	protected override string _GetTemplateForMessageUnknownMessageType()
	{
		return "Eine Nachricht kann nicht angezeigt werden";
	}

	/// <summary>
	/// Key: "Message.VerifySenderEmail"
	/// English String: "You must verify your email on the {frontLink}Account Settings{endLink} page before you can send messages."
	/// </summary>
	public override string MessageVerifySenderEmail(string frontLink, string endLink)
	{
		return $"Bevor du Nachrichten senden kannst, musst du deine E-Mail-Adresse auf der Seite „{frontLink}Kontoeinstellungen{endLink}“ verifizieren.";
	}

	protected override string _GetTemplateForMessageVerifySenderEmail()
	{
		return "Bevor du Nachrichten senden kannst, musst du deine E-Mail-Adresse auf der Seite „{frontLink}Kontoeinstellungen{endLink}“ verifizieren.";
	}

	protected override string _GetTemplateForMessageWriteYourMessage()
	{
		return "Verfasse deine Nachricht\u00a0...";
	}
}
