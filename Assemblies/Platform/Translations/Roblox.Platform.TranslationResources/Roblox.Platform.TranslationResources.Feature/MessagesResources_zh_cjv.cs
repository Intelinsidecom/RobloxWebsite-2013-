namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides MessagesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class MessagesResources_zh_cjv : MessagesResources_en_us, IMessagesResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Archive"
	/// English String: "Archive"
	/// </summary>
	public override string ActionArchive => "å½’æ¡£";

	/// <summary>
	/// Key: "Action.Back"
	/// English String: "Back"
	/// </summary>
	public override string ActionBack => "è¿”å›ž";

	/// <summary>
	/// Key: "Action.Discard"
	/// English String: "Discard"
	/// </summary>
	public override string ActionDiscard => "æ”¾å¼ƒ";

	/// <summary>
	/// Key: "Action.MarkAsRead"
	/// English String: "Mark As Read"
	/// </summary>
	public override string ActionMarkAsRead => "æ ‡è®°ä¸ºå·²è¯»";

	/// <summary>
	/// Key: "Action.MarkAsUnread"
	/// English String: "Mark As Unread"
	/// </summary>
	public override string ActionMarkAsUnread => "æ ‡è®°ä¸ºæœªè¯»";

	/// <summary>
	/// Key: "Action.MoveToInbox"
	/// English String: "Move To Inbox"
	/// </summary>
	public override string ActionMoveToInbox => "ç§»è‡³æ”¶ä»¶ç®±";

	/// <summary>
	/// Key: "Action.Reply"
	/// English String: "Reply"
	/// </summary>
	public override string ActionReply => "å›žå¤";

	/// <summary>
	/// Key: "Action.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string ActionReportAbuse => "æŠ¥å‘Šæ»¥ç”¨è¡Œä¸º";

	/// <summary>
	/// Key: "Action.Send"
	/// English String: "Send"
	/// </summary>
	public override string ActionSend => "å‘é€";

	/// <summary>
	/// Key: "Action.SendReply"
	/// English String: "Send Reply"
	/// </summary>
	public override string ActionSendReply => "å‘é€å›žå¤";

	/// <summary>
	/// Key: "Heading.Message"
	/// English String: "Messages"
	/// </summary>
	public override string HeadingMessage => "ä¿¡æ¯";

	/// <summary>
	/// Key: "Heading.NewMessages"
	/// English String: "New Message"
	/// </summary>
	public override string HeadingNewMessages => "æ–°ä¿¡æ¯";

	/// <summary>
	/// Key: "Heading.Response"
	/// English String: "Responses:"
	/// </summary>
	public override string HeadingResponse => "å›žå¤ï¼š";

	/// <summary>
	/// Key: "Label.All"
	/// English String: "All"
	/// </summary>
	public override string LabelAll => "æ‰€æœ‰";

	/// <summary>
	/// Key: "Label.Archive"
	/// English String: "Archive"
	/// </summary>
	public override string LabelArchive => "å½’æ¡£";

	/// <summary>
	/// Key: "Label.Inbox"
	/// English String: "Inbox"
	/// </summary>
	public override string LabelInbox => "æ”¶ä»¶ç®±";

	/// <summary>
	/// Key: "Label.IncludeMessage"
	/// English String: "Include Previous Message"
	/// </summary>
	public override string LabelIncludeMessage => "åŒ…å«å‰ä¸€æ¡ä¿¡æ¯";

	/// <summary>
	/// Key: "Label.News"
	/// English String: "News"
	/// </summary>
	public override string LabelNews => "æ–°é—»";

	/// <summary>
	/// Key: "Label.Of"
	/// English String: "Of"
	/// </summary>
	public override string LabelOf => "/";

	/// <summary>
	/// Key: "Label.Select"
	/// English String: "Select..."
	/// </summary>
	public override string LabelSelect => "é€‰æ‹©...";

	/// <summary>
	/// Key: "Label.Sent"
	/// English String: "Sent"
	/// </summary>
	public override string LabelSent => "å·²å‘é€";

	/// <summary>
	/// Key: "Label.Subject"
	/// English String: "Subject:"
	/// </summary>
	public override string LabelSubject => "ä¸»é¢˜ï¼š";

	/// <summary>
	/// Key: "Label.To"
	/// English String: "To:"
	/// </summary>
	public override string LabelTo => "æ”¶ä»¶äººï¼š";

	/// <summary>
	/// Key: "Message.BodyCantBlank"
	/// English String: "The message body can't be blank."
	/// </summary>
	public override string MessageBodyCantBlank => "ä¿¡æ¯æ­£æ–‡ä¸èƒ½ä¸ºç©ºã€‚";

	/// <summary>
	/// Key: "Message.GeneralError"
	/// English String: "Sorry, an error occurred sending your message."
	/// </summary>
	public override string MessageGeneralError => "æŠ±æ­‰ï¼Œå‘é€ä¿¡æ¯æ—¶å‘ç”Ÿé”™è¯¯ã€‚";

	/// <summary>
	/// Key: "Message.IdTheftWarning"
	/// English String: "Remember, Roblox staff will never ask you for your password. People who ask for your password are trying to steal your account."
	/// </summary>
	public override string MessageIdTheftWarning => "è¯·è®°ä½ï¼ŒRoblox å‘˜å·¥ç»å¯¹ä¸ä¼šå‘ä½ ç´¢å–å¯†ç ã€‚å¦‚æžœæœ‰äººè¿™æ ·åšï¼Œé‚£ä¹ˆä»–ä»¬æ˜¯åœ¨ä¼å›¾ç›—å–ä½ çš„å¸æˆ·ã€‚";

	/// <summary>
	/// Key: "Message.NoMessageExist"
	/// English String: "Message doesn't exist"
	/// </summary>
	public override string MessageNoMessageExist => "ä¿¡æ¯ä¸å­˜åœ¨";

	/// <summary>
	/// Key: "Message.NoNews"
	/// English String: "You have no news."
	/// </summary>
	public override string MessageNoNews => "ä½ æ²¡æœ‰æ–°é—»ã€‚";

	/// <summary>
	/// Key: "Message.NoRecipient"
	/// English String: "Recipient doesn't exist!"
	/// </summary>
	public override string MessageNoRecipient => "æ”¶ä»¶äººä¸å­˜åœ¨ï¼";

	/// <summary>
	/// Key: "Message.NotAuthorizeToManipulate"
	/// English String: "Not authorized to manipulate message"
	/// </summary>
	public override string MessageNotAuthorizeToManipulate => "æ— æ“æŽ§ä¿¡æ¯çš„æƒé™";

	/// <summary>
	/// Key: "Message.NotSendAndModerated"
	/// English String: "Your message was not sent because it was moderated."
	/// </summary>
	public override string MessageNotSendAndModerated => "ä½ çš„ä¿¡æ¯å·²è¢«è¿‡æ»¤ï¼Œæœªèƒ½å‘é€ã€‚";

	/// <summary>
	/// Key: "Message.RecipientPrivacySettingsTooHigh"
	/// English String: "The recipient's privacy settings prevent you from sending this message."
	/// </summary>
	public override string MessageRecipientPrivacySettingsTooHigh => "æ”¶ä»¶äººçš„éšç§è®¾ç½®é˜»æ­¢ä½ å‘é€æ­¤ä¿¡æ¯ã€‚";

	/// <summary>
	/// Key: "Message.ReplyHere"
	/// English String: "Reply here..."
	/// </summary>
	public override string MessageReplyHere => "åœ¨æ­¤å›žå¤...";

	/// <summary>
	/// Key: "Message.RobloxWarning"
	/// English String: "Remember, Roblox staff will never ask you for your password. People who ask for your password are trying to steal your account."
	/// </summary>
	public override string MessageRobloxWarning => "è¯·è®°ä½ï¼ŒRoblox å‘˜å·¥ç»å¯¹ä¸ä¼šå‘ä½ ç´¢å–å¯†ç ã€‚å¦‚æžœæœ‰äººè¿™æ ·åšï¼Œé‚£ä¹ˆä»–ä»¬æ˜¯åœ¨ä¼å›¾ç›—å–ä½ çš„å¸æˆ·ã€‚";

	/// <summary>
	/// Key: "Message.SendSuccessfully"
	/// English String: "Successfully sent message."
	/// </summary>
	public override string MessageSendSuccessfully => "ä¿¡æ¯å·²æˆåŠŸå‘é€ã€‚";

	/// <summary>
	/// Key: "Message.SendTooManyMessages"
	/// English String: "You're sending too many messages too quickly."
	/// </summary>
	public override string MessageSendTooManyMessages => "ä½ çŸ­æ—¶é—´å†…å‘é€äº†è¿‡å¤šä¿¡æ¯ã€‚";

	/// <summary>
	/// Key: "Message.SubjectCantBlank"
	/// English String: "The message subject can't be blank."
	/// </summary>
	public override string MessageSubjectCantBlank => "ä¿¡æ¯ä¸»é¢˜ä¸èƒ½ä¸ºç©ºã€‚";

	/// <summary>
	/// Key: "Message.UnknownError"
	/// English String: "Unknown error"
	/// </summary>
	public override string MessageUnknownError => "æœªçŸ¥é”™è¯¯";

	/// <summary>
	/// Key: "Message.UnknownMessageType"
	/// This serves as the fallback string for when an message type is received that the web chat does not know how to render.
	/// English String: "A message cannot be displayed"
	/// </summary>
	public override string MessageUnknownMessageType => "ä¿¡æ¯æ— æ³•æ˜¾ç¤º";

	/// <summary>
	/// Key: "Message.WriteYourMessage"
	/// English String: "Write your message..."
	/// </summary>
	public override string MessageWriteYourMessage => "ç¼–å†™ä½ çš„ä¿¡æ¯...";

	public MessagesResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionArchive()
	{
		return "å½’æ¡£";
	}

	protected override string _GetTemplateForActionBack()
	{
		return "è¿”å›ž";
	}

	protected override string _GetTemplateForActionDiscard()
	{
		return "æ”¾å¼ƒ";
	}

	protected override string _GetTemplateForActionMarkAsRead()
	{
		return "æ ‡è®°ä¸ºå·²è¯»";
	}

	protected override string _GetTemplateForActionMarkAsUnread()
	{
		return "æ ‡è®°ä¸ºæœªè¯»";
	}

	protected override string _GetTemplateForActionMoveToInbox()
	{
		return "ç§»è‡³æ”¶ä»¶ç®±";
	}

	protected override string _GetTemplateForActionReply()
	{
		return "å›žå¤";
	}

	protected override string _GetTemplateForActionReportAbuse()
	{
		return "æŠ¥å‘Šæ»¥ç”¨è¡Œä¸º";
	}

	protected override string _GetTemplateForActionSend()
	{
		return "å‘é€";
	}

	protected override string _GetTemplateForActionSendReply()
	{
		return "å‘é€å›žå¤";
	}

	protected override string _GetTemplateForHeadingMessage()
	{
		return "ä¿¡æ¯";
	}

	protected override string _GetTemplateForHeadingNewMessages()
	{
		return "æ–°ä¿¡æ¯";
	}

	protected override string _GetTemplateForHeadingResponse()
	{
		return "å›žå¤ï¼š";
	}

	protected override string _GetTemplateForLabelAll()
	{
		return "æ‰€æœ‰";
	}

	protected override string _GetTemplateForLabelArchive()
	{
		return "å½’æ¡£";
	}

	protected override string _GetTemplateForLabelInbox()
	{
		return "æ”¶ä»¶ç®±";
	}

	protected override string _GetTemplateForLabelIncludeMessage()
	{
		return "åŒ…å«å‰ä¸€æ¡ä¿¡æ¯";
	}

	protected override string _GetTemplateForLabelNews()
	{
		return "æ–°é—»";
	}

	/// <summary>
	/// Key: "Label.NoMessagesInCategory"
	/// English String: "You have no {activeTab} messages."
	/// </summary>
	public override string LabelNoMessagesInCategory(string activeTab)
	{
		return $"ä½ æ²¡æœ‰{activeTab}ä¿¡æ¯ã€‚";
	}

	protected override string _GetTemplateForLabelNoMessagesInCategory()
	{
		return "ä½ æ²¡æœ‰{activeTab}ä¿¡æ¯ã€‚";
	}

	protected override string _GetTemplateForLabelOf()
	{
		return "/";
	}

	protected override string _GetTemplateForLabelSelect()
	{
		return "é€‰æ‹©...";
	}

	protected override string _GetTemplateForLabelSent()
	{
		return "å·²å‘é€";
	}

	protected override string _GetTemplateForLabelSubject()
	{
		return "ä¸»é¢˜ï¼š";
	}

	protected override string _GetTemplateForLabelTo()
	{
		return "æ”¶ä»¶äººï¼š";
	}

	protected override string _GetTemplateForMessageBodyCantBlank()
	{
		return "ä¿¡æ¯æ­£æ–‡ä¸èƒ½ä¸ºç©ºã€‚";
	}

	/// <summary>
	/// Key: "Message.BodyTooLong"
	/// English String: "Please shorten your message to {maxLength} characters or less and try again."
	/// </summary>
	public override string MessageBodyTooLong(string maxLength)
	{
		return $"è¯·å°†ä½ çš„ä¿¡æ¯ç¼©çŸ­è‡³ {maxLength} ä¸ªå­—ç¬¦æˆ–ä»¥å†…ï¼Œå¹¶é‡è¯•ã€‚";
	}

	protected override string _GetTemplateForMessageBodyTooLong()
	{
		return "è¯·å°†ä½ çš„ä¿¡æ¯ç¼©çŸ­è‡³ {maxLength} ä¸ªå­—ç¬¦æˆ–ä»¥å†…ï¼Œå¹¶é‡è¯•ã€‚";
	}

	protected override string _GetTemplateForMessageGeneralError()
	{
		return "æŠ±æ­‰ï¼Œå‘é€ä¿¡æ¯æ—¶å‘ç”Ÿé”™è¯¯ã€‚";
	}

	protected override string _GetTemplateForMessageIdTheftWarning()
	{
		return "è¯·è®°ä½ï¼ŒRoblox å‘˜å·¥ç»å¯¹ä¸ä¼šå‘ä½ ç´¢å–å¯†ç ã€‚å¦‚æžœæœ‰äººè¿™æ ·åšï¼Œé‚£ä¹ˆä»–ä»¬æ˜¯åœ¨ä¼å›¾ç›—å–ä½ çš„å¸æˆ·ã€‚";
	}

	protected override string _GetTemplateForMessageNoMessageExist()
	{
		return "ä¿¡æ¯ä¸å­˜åœ¨";
	}

	protected override string _GetTemplateForMessageNoNews()
	{
		return "ä½ æ²¡æœ‰æ–°é—»ã€‚";
	}

	protected override string _GetTemplateForMessageNoRecipient()
	{
		return "æ”¶ä»¶äººä¸å­˜åœ¨ï¼";
	}

	protected override string _GetTemplateForMessageNotAuthorizeToManipulate()
	{
		return "æ— æ“æŽ§ä¿¡æ¯çš„æƒé™";
	}

	protected override string _GetTemplateForMessageNotSendAndModerated()
	{
		return "ä½ çš„ä¿¡æ¯å·²è¢«è¿‡æ»¤ï¼Œæœªèƒ½å‘é€ã€‚";
	}

	protected override string _GetTemplateForMessageRecipientPrivacySettingsTooHigh()
	{
		return "æ”¶ä»¶äººçš„éšç§è®¾ç½®é˜»æ­¢ä½ å‘é€æ­¤ä¿¡æ¯ã€‚";
	}

	protected override string _GetTemplateForMessageReplyHere()
	{
		return "åœ¨æ­¤å›žå¤...";
	}

	protected override string _GetTemplateForMessageRobloxWarning()
	{
		return "è¯·è®°ä½ï¼ŒRoblox å‘˜å·¥ç»å¯¹ä¸ä¼šå‘ä½ ç´¢å–å¯†ç ã€‚å¦‚æžœæœ‰äººè¿™æ ·åšï¼Œé‚£ä¹ˆä»–ä»¬æ˜¯åœ¨ä¼å›¾ç›—å–ä½ çš„å¸æˆ·ã€‚";
	}

	/// <summary>
	/// Key: "Message.SenderPrivacySettingTooHeight"
	/// English String: "Your {frontLink}privacy settings{endLink} prevent you from sending this message."
	/// </summary>
	public override string MessageSenderPrivacySettingTooHeight(string frontLink, string endLink)
	{
		return $"ä½ çš„{frontLink}éšç§è®¾ç½®{endLink}é˜»æ­¢ä½ å‘é€æ­¤ä¿¡æ¯ã€‚";
	}

	protected override string _GetTemplateForMessageSenderPrivacySettingTooHeight()
	{
		return "ä½ çš„{frontLink}éšç§è®¾ç½®{endLink}é˜»æ­¢ä½ å‘é€æ­¤ä¿¡æ¯ã€‚";
	}

	protected override string _GetTemplateForMessageSendSuccessfully()
	{
		return "ä¿¡æ¯å·²æˆåŠŸå‘é€ã€‚";
	}

	protected override string _GetTemplateForMessageSendTooManyMessages()
	{
		return "ä½ çŸ­æ—¶é—´å†…å‘é€äº†è¿‡å¤šä¿¡æ¯ã€‚";
	}

	protected override string _GetTemplateForMessageSubjectCantBlank()
	{
		return "ä¿¡æ¯ä¸»é¢˜ä¸èƒ½ä¸ºç©ºã€‚";
	}

	protected override string _GetTemplateForMessageUnknownError()
	{
		return "æœªçŸ¥é”™è¯¯";
	}

	protected override string _GetTemplateForMessageUnknownMessageType()
	{
		return "ä¿¡æ¯æ— æ³•æ˜¾ç¤º";
	}

	/// <summary>
	/// Key: "Message.VerifySenderEmail"
	/// English String: "You must verify your email on the {frontLink}Account Settings{endLink} page before you can send messages."
	/// </summary>
	public override string MessageVerifySenderEmail(string frontLink, string endLink)
	{
		return $"ä½ å¿…é¡»å…ˆåœ¨{frontLink}å¸æˆ·è®¾ç½®{endLink}é¡µé¢éªŒè¯ç”µå­é‚®ä»¶ï¼Œç„¶åŽæ‰èƒ½å‘é€ä¿¡æ¯ã€‚";
	}

	protected override string _GetTemplateForMessageVerifySenderEmail()
	{
		return "ä½ å¿…é¡»å…ˆåœ¨{frontLink}å¸æˆ·è®¾ç½®{endLink}é¡µé¢éªŒè¯ç”µå­é‚®ä»¶ï¼Œç„¶åŽæ‰èƒ½å‘é€ä¿¡æ¯ã€‚";
	}

	protected override string _GetTemplateForMessageWriteYourMessage()
	{
		return "ç¼–å†™ä½ çš„ä¿¡æ¯...";
	}
}


}
