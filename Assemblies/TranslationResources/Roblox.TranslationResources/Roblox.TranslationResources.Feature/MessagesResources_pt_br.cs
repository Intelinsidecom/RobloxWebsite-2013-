namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides MessagesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class MessagesResources_pt_br : MessagesResources_en_us, IMessagesResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Archive"
	/// English String: "Archive"
	/// </summary>
	public override string ActionArchive => "Arquivar";

	/// <summary>
	/// Key: "Action.Back"
	/// English String: "Back"
	/// </summary>
	public override string ActionBack => "Voltar";

	/// <summary>
	/// Key: "Action.Discard"
	/// English String: "Discard"
	/// </summary>
	public override string ActionDiscard => "Descartar";

	/// <summary>
	/// Key: "Action.MarkAsRead"
	/// English String: "Mark As Read"
	/// </summary>
	public override string ActionMarkAsRead => "Marcar como lida";

	/// <summary>
	/// Key: "Action.MarkAsUnread"
	/// English String: "Mark As Unread"
	/// </summary>
	public override string ActionMarkAsUnread => "Marcar como não lida";

	/// <summary>
	/// Key: "Action.MoveToInbox"
	/// English String: "Move To Inbox"
	/// </summary>
	public override string ActionMoveToInbox => "Mover para a caixa de entrada";

	/// <summary>
	/// Key: "Action.Reply"
	/// English String: "Reply"
	/// </summary>
	public override string ActionReply => "Responder";

	/// <summary>
	/// Key: "Action.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string ActionReportAbuse => "Denunciar abuso";

	/// <summary>
	/// Key: "Action.Send"
	/// English String: "Send"
	/// </summary>
	public override string ActionSend => "Enviar";

	/// <summary>
	/// Key: "Action.SendReply"
	/// English String: "Send Reply"
	/// </summary>
	public override string ActionSendReply => "Enviar resposta";

	/// <summary>
	/// Key: "Heading.Message"
	/// English String: "Messages"
	/// </summary>
	public override string HeadingMessage => "Mensagens";

	/// <summary>
	/// Key: "Heading.NewMessages"
	/// English String: "New Message"
	/// </summary>
	public override string HeadingNewMessages => "Nova mensagem";

	/// <summary>
	/// Key: "Heading.Response"
	/// English String: "Responses:"
	/// </summary>
	public override string HeadingResponse => "Respostas:";

	/// <summary>
	/// Key: "Label.All"
	/// English String: "All"
	/// </summary>
	public override string LabelAll => "Todas";

	/// <summary>
	/// Key: "Label.Archive"
	/// English String: "Archive"
	/// </summary>
	public override string LabelArchive => "Arquivar";

	/// <summary>
	/// Key: "Label.Inbox"
	/// English String: "Inbox"
	/// </summary>
	public override string LabelInbox => "Caixa de entrada";

	/// <summary>
	/// Key: "Label.IncludeMessage"
	/// English String: "Include Previous Message"
	/// </summary>
	public override string LabelIncludeMessage => "Incluir mensagem anterior";

	/// <summary>
	/// Key: "Label.News"
	/// English String: "News"
	/// </summary>
	public override string LabelNews => "Notícias";

	/// <summary>
	/// Key: "Label.Of"
	/// English String: "Of"
	/// </summary>
	public override string LabelOf => "De";

	/// <summary>
	/// Key: "Label.Select"
	/// English String: "Select..."
	/// </summary>
	public override string LabelSelect => "Selecione...";

	/// <summary>
	/// Key: "Label.Sent"
	/// English String: "Sent"
	/// </summary>
	public override string LabelSent => "Enviado";

	/// <summary>
	/// Key: "Label.Subject"
	/// English String: "Subject:"
	/// </summary>
	public override string LabelSubject => "Assunto:";

	/// <summary>
	/// Key: "Label.To"
	/// English String: "To:"
	/// </summary>
	public override string LabelTo => "Para:";

	/// <summary>
	/// Key: "Message.BodyCantBlank"
	/// English String: "The message body can't be blank."
	/// </summary>
	public override string MessageBodyCantBlank => "O corpo da mensagem não pode estar em branco.";

	/// <summary>
	/// Key: "Message.GeneralError"
	/// English String: "Sorry, an error occurred sending your message."
	/// </summary>
	public override string MessageGeneralError => "Ops! Ocorreu um erro ao enviar a mensagem.";

	/// <summary>
	/// Key: "Message.IdTheftWarning"
	/// English String: "Remember, Roblox staff will never ask you for your password. People who ask for your password are trying to steal your account."
	/// </summary>
	public override string MessageIdTheftWarning => "Não esqueça que a equipe do Roblox nunca pedirá para você fornecer a sua senha. Pessoas que solicitarem a sua senha estão tentando roubar a sua conta.";

	/// <summary>
	/// Key: "Message.NoMessageExist"
	/// English String: "Message doesn't exist"
	/// </summary>
	public override string MessageNoMessageExist => "Mensagem inexistente";

	/// <summary>
	/// Key: "Message.NoNews"
	/// English String: "You have no news."
	/// </summary>
	public override string MessageNoNews => "Você não possui notícias.";

	/// <summary>
	/// Key: "Message.NoRecipient"
	/// English String: "Recipient doesn't exist!"
	/// </summary>
	public override string MessageNoRecipient => "Destinatário inexistente!";

	/// <summary>
	/// Key: "Message.NotAuthorizeToManipulate"
	/// English String: "Not authorized to manipulate message"
	/// </summary>
	public override string MessageNotAuthorizeToManipulate => "Não autorizado a manipular a mensagem";

	/// <summary>
	/// Key: "Message.NotSendAndModerated"
	/// English String: "Your message was not sent because it was moderated."
	/// </summary>
	public override string MessageNotSendAndModerated => "Sua mensagem não foi enviada pois ela foi moderada.";

	/// <summary>
	/// Key: "Message.RecipientPrivacySettingsTooHigh"
	/// English String: "The recipient's privacy settings prevent you from sending this message."
	/// </summary>
	public override string MessageRecipientPrivacySettingsTooHigh => "As configurações de privacidade do destinatário impedem que você envie esta mensagem.";

	/// <summary>
	/// Key: "Message.ReplyHere"
	/// English String: "Reply here..."
	/// </summary>
	public override string MessageReplyHere => "Responda aqui...";

	/// <summary>
	/// Key: "Message.RobloxWarning"
	/// English String: "Remember, Roblox staff will never ask you for your password. People who ask for your password are trying to steal your account."
	/// </summary>
	public override string MessageRobloxWarning => "Não esqueça que a equipe do Roblox nunca pedirá para você fornecer a sua senha. Pessoas que solicitarem a sua senha estão tentando roubar a sua conta.";

	/// <summary>
	/// Key: "Message.SendSuccessfully"
	/// English String: "Successfully sent message."
	/// </summary>
	public override string MessageSendSuccessfully => "Mensagem enviada com sucesso.";

	/// <summary>
	/// Key: "Message.SendTooManyMessages"
	/// English String: "You're sending too many messages too quickly."
	/// </summary>
	public override string MessageSendTooManyMessages => "Você está enviando mensagens demais e rápido demais.";

	/// <summary>
	/// Key: "Message.SubjectCantBlank"
	/// English String: "The message subject can't be blank."
	/// </summary>
	public override string MessageSubjectCantBlank => "O assunto da mensagem não pode estar em branco.";

	/// <summary>
	/// Key: "Message.UnknownError"
	/// English String: "Unknown error"
	/// </summary>
	public override string MessageUnknownError => "Erro desconhecido";

	/// <summary>
	/// Key: "Message.UnknownMessageType"
	/// This serves as the fallback string for when an message type is received that the web chat does not know how to render.
	/// English String: "A message cannot be displayed"
	/// </summary>
	public override string MessageUnknownMessageType => "Uma mensagem não pode ser exibida";

	/// <summary>
	/// Key: "Message.WriteYourMessage"
	/// English String: "Write your message..."
	/// </summary>
	public override string MessageWriteYourMessage => "Escreva a sua mensagem...";

	public MessagesResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionArchive()
	{
		return "Arquivar";
	}

	protected override string _GetTemplateForActionBack()
	{
		return "Voltar";
	}

	protected override string _GetTemplateForActionDiscard()
	{
		return "Descartar";
	}

	protected override string _GetTemplateForActionMarkAsRead()
	{
		return "Marcar como lida";
	}

	protected override string _GetTemplateForActionMarkAsUnread()
	{
		return "Marcar como não lida";
	}

	protected override string _GetTemplateForActionMoveToInbox()
	{
		return "Mover para a caixa de entrada";
	}

	protected override string _GetTemplateForActionReply()
	{
		return "Responder";
	}

	protected override string _GetTemplateForActionReportAbuse()
	{
		return "Denunciar abuso";
	}

	protected override string _GetTemplateForActionSend()
	{
		return "Enviar";
	}

	protected override string _GetTemplateForActionSendReply()
	{
		return "Enviar resposta";
	}

	protected override string _GetTemplateForHeadingMessage()
	{
		return "Mensagens";
	}

	protected override string _GetTemplateForHeadingNewMessages()
	{
		return "Nova mensagem";
	}

	protected override string _GetTemplateForHeadingResponse()
	{
		return "Respostas:";
	}

	protected override string _GetTemplateForLabelAll()
	{
		return "Todas";
	}

	protected override string _GetTemplateForLabelArchive()
	{
		return "Arquivar";
	}

	protected override string _GetTemplateForLabelInbox()
	{
		return "Caixa de entrada";
	}

	protected override string _GetTemplateForLabelIncludeMessage()
	{
		return "Incluir mensagem anterior";
	}

	protected override string _GetTemplateForLabelNews()
	{
		return "Notícias";
	}

	/// <summary>
	/// Key: "Label.NoMessagesInCategory"
	/// English String: "You have no {activeTab} messages."
	/// </summary>
	public override string LabelNoMessagesInCategory(string activeTab)
	{
		return $"Você não possui mensagens em {activeTab}.";
	}

	protected override string _GetTemplateForLabelNoMessagesInCategory()
	{
		return "Você não possui mensagens em {activeTab}.";
	}

	protected override string _GetTemplateForLabelOf()
	{
		return "De";
	}

	protected override string _GetTemplateForLabelSelect()
	{
		return "Selecione...";
	}

	protected override string _GetTemplateForLabelSent()
	{
		return "Enviado";
	}

	protected override string _GetTemplateForLabelSubject()
	{
		return "Assunto:";
	}

	protected override string _GetTemplateForLabelTo()
	{
		return "Para:";
	}

	protected override string _GetTemplateForMessageBodyCantBlank()
	{
		return "O corpo da mensagem não pode estar em branco.";
	}

	/// <summary>
	/// Key: "Message.BodyTooLong"
	/// English String: "Please shorten your message to {maxLength} characters or less and try again."
	/// </summary>
	public override string MessageBodyTooLong(string maxLength)
	{
		return $"Encurte sua mensagem para {maxLength} caracteres ou menos e tente novamente.";
	}

	protected override string _GetTemplateForMessageBodyTooLong()
	{
		return "Encurte sua mensagem para {maxLength} caracteres ou menos e tente novamente.";
	}

	protected override string _GetTemplateForMessageGeneralError()
	{
		return "Ops! Ocorreu um erro ao enviar a mensagem.";
	}

	protected override string _GetTemplateForMessageIdTheftWarning()
	{
		return "Não esqueça que a equipe do Roblox nunca pedirá para você fornecer a sua senha. Pessoas que solicitarem a sua senha estão tentando roubar a sua conta.";
	}

	protected override string _GetTemplateForMessageNoMessageExist()
	{
		return "Mensagem inexistente";
	}

	protected override string _GetTemplateForMessageNoNews()
	{
		return "Você não possui notícias.";
	}

	protected override string _GetTemplateForMessageNoRecipient()
	{
		return "Destinatário inexistente!";
	}

	protected override string _GetTemplateForMessageNotAuthorizeToManipulate()
	{
		return "Não autorizado a manipular a mensagem";
	}

	protected override string _GetTemplateForMessageNotSendAndModerated()
	{
		return "Sua mensagem não foi enviada pois ela foi moderada.";
	}

	protected override string _GetTemplateForMessageRecipientPrivacySettingsTooHigh()
	{
		return "As configurações de privacidade do destinatário impedem que você envie esta mensagem.";
	}

	protected override string _GetTemplateForMessageReplyHere()
	{
		return "Responda aqui...";
	}

	protected override string _GetTemplateForMessageRobloxWarning()
	{
		return "Não esqueça que a equipe do Roblox nunca pedirá para você fornecer a sua senha. Pessoas que solicitarem a sua senha estão tentando roubar a sua conta.";
	}

	/// <summary>
	/// Key: "Message.SenderPrivacySettingTooHeight"
	/// English String: "Your {frontLink}privacy settings{endLink} prevent you from sending this message."
	/// </summary>
	public override string MessageSenderPrivacySettingTooHeight(string frontLink, string endLink)
	{
		return $"Suas {frontLink}configurações de privacidade{endLink} impedem que você envie esta mensagem.";
	}

	protected override string _GetTemplateForMessageSenderPrivacySettingTooHeight()
	{
		return "Suas {frontLink}configurações de privacidade{endLink} impedem que você envie esta mensagem.";
	}

	protected override string _GetTemplateForMessageSendSuccessfully()
	{
		return "Mensagem enviada com sucesso.";
	}

	protected override string _GetTemplateForMessageSendTooManyMessages()
	{
		return "Você está enviando mensagens demais e rápido demais.";
	}

	protected override string _GetTemplateForMessageSubjectCantBlank()
	{
		return "O assunto da mensagem não pode estar em branco.";
	}

	protected override string _GetTemplateForMessageUnknownError()
	{
		return "Erro desconhecido";
	}

	protected override string _GetTemplateForMessageUnknownMessageType()
	{
		return "Uma mensagem não pode ser exibida";
	}

	/// <summary>
	/// Key: "Message.VerifySenderEmail"
	/// English String: "You must verify your email on the {frontLink}Account Settings{endLink} page before you can send messages."
	/// </summary>
	public override string MessageVerifySenderEmail(string frontLink, string endLink)
	{
		return $"Você precisa validar o seu e-mail na página de {frontLink}Configurações de Conta{endLink} antes de poder enviar mensagens.";
	}

	protected override string _GetTemplateForMessageVerifySenderEmail()
	{
		return "Você precisa validar o seu e-mail na página de {frontLink}Configurações de Conta{endLink} antes de poder enviar mensagens.";
	}

	protected override string _GetTemplateForMessageWriteYourMessage()
	{
		return "Escreva a sua mensagem...";
	}
}
