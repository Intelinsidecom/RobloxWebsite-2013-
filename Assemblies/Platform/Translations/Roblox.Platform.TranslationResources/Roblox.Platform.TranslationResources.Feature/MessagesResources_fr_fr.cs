namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides MessagesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class MessagesResources_fr_fr : MessagesResources_en_us, IMessagesResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Archive"
	/// English String: "Archive"
	/// </summary>
	public override string ActionArchive => "Archiver";

	/// <summary>
	/// Key: "Action.Back"
	/// English String: "Back"
	/// </summary>
	public override string ActionBack => "Retour";

	/// <summary>
	/// Key: "Action.Discard"
	/// English String: "Discard"
	/// </summary>
	public override string ActionDiscard => "Abandonner";

	/// <summary>
	/// Key: "Action.MarkAsRead"
	/// English String: "Mark As Read"
	/// </summary>
	public override string ActionMarkAsRead => "Marquer comme lu";

	/// <summary>
	/// Key: "Action.MarkAsUnread"
	/// English String: "Mark As Unread"
	/// </summary>
	public override string ActionMarkAsUnread => "Marquer comme non lu";

	/// <summary>
	/// Key: "Action.MoveToInbox"
	/// English String: "Move To Inbox"
	/// </summary>
	public override string ActionMoveToInbox => "DÃ©placer dans la boÃ®te de rÃ©ception";

	/// <summary>
	/// Key: "Action.Reply"
	/// English String: "Reply"
	/// </summary>
	public override string ActionReply => "RÃ©pondre";

	/// <summary>
	/// Key: "Action.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string ActionReportAbuse => "Signaler un comportement abusif";

	/// <summary>
	/// Key: "Action.Send"
	/// English String: "Send"
	/// </summary>
	public override string ActionSend => "Envoyer";

	/// <summary>
	/// Key: "Action.SendReply"
	/// English String: "Send Reply"
	/// </summary>
	public override string ActionSendReply => "Envoyer une rÃ©ponse";

	/// <summary>
	/// Key: "Heading.Message"
	/// English String: "Messages"
	/// </summary>
	public override string HeadingMessage => "Messages";

	/// <summary>
	/// Key: "Heading.NewMessages"
	/// English String: "New Message"
	/// </summary>
	public override string HeadingNewMessages => "Nouveau message";

	/// <summary>
	/// Key: "Heading.Response"
	/// English String: "Responses:"
	/// </summary>
	public override string HeadingResponse => "RÃ©ponses\u00a0:";

	/// <summary>
	/// Key: "Label.All"
	/// English String: "All"
	/// </summary>
	public override string LabelAll => "Tous";

	/// <summary>
	/// Key: "Label.Archive"
	/// English String: "Archive"
	/// </summary>
	public override string LabelArchive => "ArchivÃ©s";

	/// <summary>
	/// Key: "Label.Inbox"
	/// English String: "Inbox"
	/// </summary>
	public override string LabelInbox => "BoÃ®te de rÃ©ception";

	/// <summary>
	/// Key: "Label.IncludeMessage"
	/// English String: "Include Previous Message"
	/// </summary>
	public override string LabelIncludeMessage => "Inclure le message prÃ©cÃ©dent";

	/// <summary>
	/// Key: "Label.News"
	/// English String: "News"
	/// </summary>
	public override string LabelNews => "ActualitÃ©s";

	/// <summary>
	/// Key: "Label.Of"
	/// English String: "Of"
	/// </summary>
	public override string LabelOf => "De";

	/// <summary>
	/// Key: "Label.Select"
	/// English String: "Select..."
	/// </summary>
	public override string LabelSelect => "SÃ©lectionner...";

	/// <summary>
	/// Key: "Label.Sent"
	/// English String: "Sent"
	/// </summary>
	public override string LabelSent => "EnvoyÃ©s";

	/// <summary>
	/// Key: "Label.Subject"
	/// English String: "Subject:"
	/// </summary>
	public override string LabelSubject => "Objet\u00a0:";

	/// <summary>
	/// Key: "Label.To"
	/// English String: "To:"
	/// </summary>
	public override string LabelTo => "Ã€\u00a0:";

	/// <summary>
	/// Key: "Message.BodyCantBlank"
	/// English String: "The message body can't be blank."
	/// </summary>
	public override string MessageBodyCantBlank => "Le corps du message ne peut pas Ãªtre vide.";

	/// <summary>
	/// Key: "Message.GeneralError"
	/// English String: "Sorry, an error occurred sending your message."
	/// </summary>
	public override string MessageGeneralError => "DÃ©solÃ©, une erreur est survenue lors de l'envoi du message.";

	/// <summary>
	/// Key: "Message.IdTheftWarning"
	/// English String: "Remember, Roblox staff will never ask you for your password. People who ask for your password are trying to steal your account."
	/// </summary>
	public override string MessageIdTheftWarning => "N'oublie pas que l'Ã©quipe de Roblox ne te demandera jamais ton mot de passe. Si un utilisateur te demande ton mot de passe, c'est qu'il tente de voler ton compte.";

	/// <summary>
	/// Key: "Message.NoMessageExist"
	/// English String: "Message doesn't exist"
	/// </summary>
	public override string MessageNoMessageExist => "Le message n'existe pas.";

	/// <summary>
	/// Key: "Message.NoNews"
	/// English String: "You have no news."
	/// </summary>
	public override string MessageNoNews => "Aucune actualitÃ©.";

	/// <summary>
	/// Key: "Message.NoRecipient"
	/// English String: "Recipient doesn't exist!"
	/// </summary>
	public override string MessageNoRecipient => "Le destinataire n'existe pas\u00a0!";

	/// <summary>
	/// Key: "Message.NotAuthorizeToManipulate"
	/// English String: "Not authorized to manipulate message"
	/// </summary>
	public override string MessageNotAuthorizeToManipulate => "Vous n'avez pas l'autorisation de manipuler le message.";

	/// <summary>
	/// Key: "Message.NotSendAndModerated"
	/// English String: "Your message was not sent because it was moderated."
	/// </summary>
	public override string MessageNotSendAndModerated => "Ton message n'a pas Ã©tÃ© envoyÃ©, car il a Ã©tÃ© modÃ©rÃ©.";

	/// <summary>
	/// Key: "Message.RecipientPrivacySettingsTooHigh"
	/// English String: "The recipient's privacy settings prevent you from sending this message."
	/// </summary>
	public override string MessageRecipientPrivacySettingsTooHigh => "Les paramÃ¨tres de confidentialitÃ© du destinataire vous empÃªchent d'envoyer ce message.";

	/// <summary>
	/// Key: "Message.ReplyHere"
	/// English String: "Reply here..."
	/// </summary>
	public override string MessageReplyHere => "RÃ©pondez ici...";

	/// <summary>
	/// Key: "Message.RobloxWarning"
	/// English String: "Remember, Roblox staff will never ask you for your password. People who ask for your password are trying to steal your account."
	/// </summary>
	public override string MessageRobloxWarning => "N'oublie pas que l'Ã©quipe de Roblox ne te demandera jamais ton mot de passe. Si un utilisateur te demande ton mot de passe, c'est qu'il tente de voler ton compte.";

	/// <summary>
	/// Key: "Message.SendSuccessfully"
	/// English String: "Successfully sent message."
	/// </summary>
	public override string MessageSendSuccessfully => "Message envoyÃ©.";

	/// <summary>
	/// Key: "Message.SendTooManyMessages"
	/// English String: "You're sending too many messages too quickly."
	/// </summary>
	public override string MessageSendTooManyMessages => "Vous envoyez trop de messages Ã  un rythme trop soutenu.";

	/// <summary>
	/// Key: "Message.SubjectCantBlank"
	/// English String: "The message subject can't be blank."
	/// </summary>
	public override string MessageSubjectCantBlank => "L'objet du message ne peut pas Ãªtre vide.";

	/// <summary>
	/// Key: "Message.UnknownError"
	/// English String: "Unknown error"
	/// </summary>
	public override string MessageUnknownError => "Erreur inconnue";

	/// <summary>
	/// Key: "Message.UnknownMessageType"
	/// This serves as the fallback string for when an message type is received that the web chat does not know how to render.
	/// English String: "A message cannot be displayed"
	/// </summary>
	public override string MessageUnknownMessageType => "Un message ne peut Ãªtre affichÃ©";

	/// <summary>
	/// Key: "Message.WriteYourMessage"
	/// English String: "Write your message..."
	/// </summary>
	public override string MessageWriteYourMessage => "RÃ©dige ton message...";

	public MessagesResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionArchive()
	{
		return "Archiver";
	}

	protected override string _GetTemplateForActionBack()
	{
		return "Retour";
	}

	protected override string _GetTemplateForActionDiscard()
	{
		return "Abandonner";
	}

	protected override string _GetTemplateForActionMarkAsRead()
	{
		return "Marquer comme lu";
	}

	protected override string _GetTemplateForActionMarkAsUnread()
	{
		return "Marquer comme non lu";
	}

	protected override string _GetTemplateForActionMoveToInbox()
	{
		return "DÃ©placer dans la boÃ®te de rÃ©ception";
	}

	protected override string _GetTemplateForActionReply()
	{
		return "RÃ©pondre";
	}

	protected override string _GetTemplateForActionReportAbuse()
	{
		return "Signaler un comportement abusif";
	}

	protected override string _GetTemplateForActionSend()
	{
		return "Envoyer";
	}

	protected override string _GetTemplateForActionSendReply()
	{
		return "Envoyer une rÃ©ponse";
	}

	protected override string _GetTemplateForHeadingMessage()
	{
		return "Messages";
	}

	protected override string _GetTemplateForHeadingNewMessages()
	{
		return "Nouveau message";
	}

	protected override string _GetTemplateForHeadingResponse()
	{
		return "RÃ©ponses\u00a0:";
	}

	protected override string _GetTemplateForLabelAll()
	{
		return "Tous";
	}

	protected override string _GetTemplateForLabelArchive()
	{
		return "ArchivÃ©s";
	}

	protected override string _GetTemplateForLabelInbox()
	{
		return "BoÃ®te de rÃ©ception";
	}

	protected override string _GetTemplateForLabelIncludeMessage()
	{
		return "Inclure le message prÃ©cÃ©dent";
	}

	protected override string _GetTemplateForLabelNews()
	{
		return "ActualitÃ©s";
	}

	/// <summary>
	/// Key: "Label.NoMessagesInCategory"
	/// English String: "You have no {activeTab} messages."
	/// </summary>
	public override string LabelNoMessagesInCategory(string activeTab)
	{
		return $"Vous n'avez aucun message dans l'onglet {activeTab}.";
	}

	protected override string _GetTemplateForLabelNoMessagesInCategory()
	{
		return "Vous n'avez aucun message dans l'onglet {activeTab}.";
	}

	protected override string _GetTemplateForLabelOf()
	{
		return "De";
	}

	protected override string _GetTemplateForLabelSelect()
	{
		return "SÃ©lectionner...";
	}

	protected override string _GetTemplateForLabelSent()
	{
		return "EnvoyÃ©s";
	}

	protected override string _GetTemplateForLabelSubject()
	{
		return "Objet\u00a0:";
	}

	protected override string _GetTemplateForLabelTo()
	{
		return "Ã€\u00a0:";
	}

	protected override string _GetTemplateForMessageBodyCantBlank()
	{
		return "Le corps du message ne peut pas Ãªtre vide.";
	}

	/// <summary>
	/// Key: "Message.BodyTooLong"
	/// English String: "Please shorten your message to {maxLength} characters or less and try again."
	/// </summary>
	public override string MessageBodyTooLong(string maxLength)
	{
		return $"Modifie ton message pour qu'il compte moins de {maxLength}\u00a0caractÃ¨res, puis rÃ©essaye.";
	}

	protected override string _GetTemplateForMessageBodyTooLong()
	{
		return "Modifie ton message pour qu'il compte moins de {maxLength}\u00a0caractÃ¨res, puis rÃ©essaye.";
	}

	protected override string _GetTemplateForMessageGeneralError()
	{
		return "DÃ©solÃ©, une erreur est survenue lors de l'envoi du message.";
	}

	protected override string _GetTemplateForMessageIdTheftWarning()
	{
		return "N'oublie pas que l'Ã©quipe de Roblox ne te demandera jamais ton mot de passe. Si un utilisateur te demande ton mot de passe, c'est qu'il tente de voler ton compte.";
	}

	protected override string _GetTemplateForMessageNoMessageExist()
	{
		return "Le message n'existe pas.";
	}

	protected override string _GetTemplateForMessageNoNews()
	{
		return "Aucune actualitÃ©.";
	}

	protected override string _GetTemplateForMessageNoRecipient()
	{
		return "Le destinataire n'existe pas\u00a0!";
	}

	protected override string _GetTemplateForMessageNotAuthorizeToManipulate()
	{
		return "Vous n'avez pas l'autorisation de manipuler le message.";
	}

	protected override string _GetTemplateForMessageNotSendAndModerated()
	{
		return "Ton message n'a pas Ã©tÃ© envoyÃ©, car il a Ã©tÃ© modÃ©rÃ©.";
	}

	protected override string _GetTemplateForMessageRecipientPrivacySettingsTooHigh()
	{
		return "Les paramÃ¨tres de confidentialitÃ© du destinataire vous empÃªchent d'envoyer ce message.";
	}

	protected override string _GetTemplateForMessageReplyHere()
	{
		return "RÃ©pondez ici...";
	}

	protected override string _GetTemplateForMessageRobloxWarning()
	{
		return "N'oublie pas que l'Ã©quipe de Roblox ne te demandera jamais ton mot de passe. Si un utilisateur te demande ton mot de passe, c'est qu'il tente de voler ton compte.";
	}

	/// <summary>
	/// Key: "Message.SenderPrivacySettingTooHeight"
	/// English String: "Your {frontLink}privacy settings{endLink} prevent you from sending this message."
	/// </summary>
	public override string MessageSenderPrivacySettingTooHeight(string frontLink, string endLink)
	{
		return $"Vos {frontLink}paramÃ¨tres de confidentialitÃ©{endLink} vous empÃªchent d'envoyer ce message.";
	}

	protected override string _GetTemplateForMessageSenderPrivacySettingTooHeight()
	{
		return "Vos {frontLink}paramÃ¨tres de confidentialitÃ©{endLink} vous empÃªchent d'envoyer ce message.";
	}

	protected override string _GetTemplateForMessageSendSuccessfully()
	{
		return "Message envoyÃ©.";
	}

	protected override string _GetTemplateForMessageSendTooManyMessages()
	{
		return "Vous envoyez trop de messages Ã  un rythme trop soutenu.";
	}

	protected override string _GetTemplateForMessageSubjectCantBlank()
	{
		return "L'objet du message ne peut pas Ãªtre vide.";
	}

	protected override string _GetTemplateForMessageUnknownError()
	{
		return "Erreur inconnue";
	}

	protected override string _GetTemplateForMessageUnknownMessageType()
	{
		return "Un message ne peut Ãªtre affichÃ©";
	}

	/// <summary>
	/// Key: "Message.VerifySenderEmail"
	/// English String: "You must verify your email on the {frontLink}Account Settings{endLink} page before you can send messages."
	/// </summary>
	public override string MessageVerifySenderEmail(string frontLink, string endLink)
	{
		return $"Tu dois vÃ©rifier ton adresse e-mail depuis la page des {frontLink}paramÃ¨tres du compte{endLink} avant de pouvoir envoyer des messages.";
	}

	protected override string _GetTemplateForMessageVerifySenderEmail()
	{
		return "Tu dois vÃ©rifier ton adresse e-mail depuis la page des {frontLink}paramÃ¨tres du compte{endLink} avant de pouvoir envoyer des messages.";
	}

	protected override string _GetTemplateForMessageWriteYourMessage()
	{
		return "RÃ©dige ton message...";
	}
}


}
