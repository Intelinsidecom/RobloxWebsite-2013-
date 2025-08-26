namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides MessagesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class MessagesResources_zh_tw : MessagesResources_en_us, IMessagesResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Archive"
	/// English String: "Archive"
	/// </summary>
	public override string ActionArchive => "å°å­˜";

	/// <summary>
	/// Key: "Action.Back"
	/// English String: "Back"
	/// </summary>
	public override string ActionBack => "è¿”å›ž";

	/// <summary>
	/// Key: "Action.Discard"
	/// English String: "Discard"
	/// </summary>
	public override string ActionDiscard => "æ¨æ£„";

	/// <summary>
	/// Key: "Action.MarkAsRead"
	/// English String: "Mark As Read"
	/// </summary>
	public override string ActionMarkAsRead => "æ¨™ç‚ºå·²è®€";

	/// <summary>
	/// Key: "Action.MarkAsUnread"
	/// English String: "Mark As Unread"
	/// </summary>
	public override string ActionMarkAsUnread => "æ¨™ç‚ºæœªè®€";

	/// <summary>
	/// Key: "Action.MoveToInbox"
	/// English String: "Move To Inbox"
	/// </summary>
	public override string ActionMoveToInbox => "ç§»åˆ°æ”¶ä»¶ç®±";

	/// <summary>
	/// Key: "Action.Reply"
	/// English String: "Reply"
	/// </summary>
	public override string ActionReply => "å›žè¦†";

	/// <summary>
	/// Key: "Action.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string ActionReportAbuse => "æª¢èˆ‰æ¿«ç”¨";

	/// <summary>
	/// Key: "Action.Send"
	/// English String: "Send"
	/// </summary>
	public override string ActionSend => "å‚³é€";

	/// <summary>
	/// Key: "Action.SendReply"
	/// English String: "Send Reply"
	/// </summary>
	public override string ActionSendReply => "å‚³é€å›žè¦†";

	/// <summary>
	/// Key: "Heading.Message"
	/// English String: "Messages"
	/// </summary>
	public override string HeadingMessage => "è¨Šæ¯";

	/// <summary>
	/// Key: "Heading.NewMessages"
	/// English String: "New Message"
	/// </summary>
	public override string HeadingNewMessages => "æ–°è¨Šæ¯";

	/// <summary>
	/// Key: "Heading.Response"
	/// English String: "Responses:"
	/// </summary>
	public override string HeadingResponse => "å›žè¦†ï¼š";

	/// <summary>
	/// Key: "Label.All"
	/// English String: "All"
	/// </summary>
	public override string LabelAll => "å…¨éƒ¨";

	/// <summary>
	/// Key: "Label.Archive"
	/// English String: "Archive"
	/// </summary>
	public override string LabelArchive => "å°å­˜";

	/// <summary>
	/// Key: "Label.Inbox"
	/// English String: "Inbox"
	/// </summary>
	public override string LabelInbox => "æ”¶ä»¶ç®±";

	/// <summary>
	/// Key: "Label.IncludeMessage"
	/// English String: "Include Previous Message"
	/// </summary>
	public override string LabelIncludeMessage => "åŒ…æ‹¬å‰ä¸€å‰‡è¨Šæ¯";

	/// <summary>
	/// Key: "Label.News"
	/// English String: "News"
	/// </summary>
	public override string LabelNews => "æ¶ˆæ¯";

	/// <summary>
	/// Key: "Label.Of"
	/// English String: "Of"
	/// </summary>
	public override string LabelOf => "/";

	/// <summary>
	/// Key: "Label.Select"
	/// English String: "Select..."
	/// </summary>
	public override string LabelSelect => "é¸æ“‡â€¦";

	/// <summary>
	/// Key: "Label.Sent"
	/// English String: "Sent"
	/// </summary>
	public override string LabelSent => "å·²å‚³é€";

	/// <summary>
	/// Key: "Label.Subject"
	/// English String: "Subject:"
	/// </summary>
	public override string LabelSubject => "ä¸»æ—¨ï¼š";

	/// <summary>
	/// Key: "Label.To"
	/// English String: "To:"
	/// </summary>
	public override string LabelTo => "æ”¶ä»¶äººï¼š";

	/// <summary>
	/// Key: "Message.BodyCantBlank"
	/// English String: "The message body can't be blank."
	/// </summary>
	public override string MessageBodyCantBlank => "è¨Šæ¯å…§æ–‡ä¸å¯ç©ºç™½ã€‚";

	/// <summary>
	/// Key: "Message.GeneralError"
	/// English String: "Sorry, an error occurred sending your message."
	/// </summary>
	public override string MessageGeneralError => "å°ä¸èµ·ï¼Œå‚³é€æ‚¨çš„è¨Šæ¯æ™‚ç™¼ç”ŸéŒ¯èª¤ã€‚";

	/// <summary>
	/// Key: "Message.IdTheftWarning"
	/// English String: "Remember, Roblox staff will never ask you for your password. People who ask for your password are trying to steal your account."
	/// </summary>
	public override string MessageIdTheftWarning => "è«‹è¨˜ä½ï¼ŒRoblox å“¡å·¥çµ•å°ä¸æœƒå‘æ‚¨è©¢å•æ‚¨çš„å¯†ç¢¼ã€‚è‹¥æœ‰äººè©¢å•æ‚¨çš„å¯†ç¢¼ï¼Œä»–å€‘æ˜¯åœ¨ä¼åœ–ç›œå–æ‚¨çš„å¸³è™Ÿã€‚";

	/// <summary>
	/// Key: "Message.NoMessageExist"
	/// English String: "Message doesn't exist"
	/// </summary>
	public override string MessageNoMessageExist => "è¨Šæ¯ä¸å­˜åœ¨";

	/// <summary>
	/// Key: "Message.NoNews"
	/// English String: "You have no news."
	/// </summary>
	public override string MessageNoNews => "æ‚¨æ²’æœ‰æ¶ˆæ¯ã€‚";

	/// <summary>
	/// Key: "Message.NoRecipient"
	/// English String: "Recipient doesn't exist!"
	/// </summary>
	public override string MessageNoRecipient => "æ”¶ä»¶äººä¸å­˜åœ¨ï¼";

	/// <summary>
	/// Key: "Message.NotAuthorizeToManipulate"
	/// English String: "Not authorized to manipulate message"
	/// </summary>
	public override string MessageNotAuthorizeToManipulate => "æ¬Šé™ä¸è¶³ï¼Œç„¡æ³•æ“ä½œè¨Šæ¯";

	/// <summary>
	/// Key: "Message.NotSendAndModerated"
	/// English String: "Your message was not sent because it was moderated."
	/// </summary>
	public override string MessageNotSendAndModerated => "æ‚¨çš„è¨Šæ¯é­åˆ°éŽæ¿¾è€Œæœªé€å‡ºã€‚";

	/// <summary>
	/// Key: "Message.RecipientPrivacySettingsTooHigh"
	/// English String: "The recipient's privacy settings prevent you from sending this message."
	/// </summary>
	public override string MessageRecipientPrivacySettingsTooHigh => "å› æ”¶ä»¶äººçš„éš±ç§æ¬Šè¨­å®šï¼Œæ‚¨ç„¡æ³•å‚³é€æ­¤è¨Šæ¯ã€‚";

	/// <summary>
	/// Key: "Message.ReplyHere"
	/// English String: "Reply here..."
	/// </summary>
	public override string MessageReplyHere => "åœ¨æ­¤è™•å›žè¦†â€¦";

	/// <summary>
	/// Key: "Message.RobloxWarning"
	/// English String: "Remember, Roblox staff will never ask you for your password. People who ask for your password are trying to steal your account."
	/// </summary>
	public override string MessageRobloxWarning => "è«‹è¨˜ä½ï¼ŒRoblox å“¡å·¥çµ•å°ä¸æœƒå‘æ‚¨è©¢å•æ‚¨çš„å¯†ç¢¼ã€‚è‹¥æœ‰äººè©¢å•æ‚¨çš„å¯†ç¢¼ï¼Œä»–å€‘æ˜¯åœ¨ä¼åœ–ç›œå–æ‚¨çš„å¸³è™Ÿã€‚";

	/// <summary>
	/// Key: "Message.SendSuccessfully"
	/// English String: "Successfully sent message."
	/// </summary>
	public override string MessageSendSuccessfully => "å·²æˆåŠŸå‚³é€è¨Šæ¯ã€‚";

	/// <summary>
	/// Key: "Message.SendTooManyMessages"
	/// English String: "You're sending too many messages too quickly."
	/// </summary>
	public override string MessageSendTooManyMessages => "æ‚¨å‚³é€è¨Šæ¯é »çŽ‡éŽé«˜ã€‚";

	/// <summary>
	/// Key: "Message.SubjectCantBlank"
	/// English String: "The message subject can't be blank."
	/// </summary>
	public override string MessageSubjectCantBlank => "è¨Šæ¯ä¸»æ—¨ä¸å¯ç©ºç™½ã€‚";

	/// <summary>
	/// Key: "Message.UnknownError"
	/// English String: "Unknown error"
	/// </summary>
	public override string MessageUnknownError => "æœªçŸ¥éŒ¯èª¤";

	/// <summary>
	/// Key: "Message.UnknownMessageType"
	/// This serves as the fallback string for when an message type is received that the web chat does not know how to render.
	/// English String: "A message cannot be displayed"
	/// </summary>
	public override string MessageUnknownMessageType => "ç„¡æ³•é¡¯ç¤ºè¨Šæ¯";

	/// <summary>
	/// Key: "Message.WriteYourMessage"
	/// English String: "Write your message..."
	/// </summary>
	public override string MessageWriteYourMessage => "å¯«ä¸‹æ‚¨çš„è¨Šæ¯â€¦";

	public MessagesResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionArchive()
	{
		return "å°å­˜";
	}

	protected override string _GetTemplateForActionBack()
	{
		return "è¿”å›ž";
	}

	protected override string _GetTemplateForActionDiscard()
	{
		return "æ¨æ£„";
	}

	protected override string _GetTemplateForActionMarkAsRead()
	{
		return "æ¨™ç‚ºå·²è®€";
	}

	protected override string _GetTemplateForActionMarkAsUnread()
	{
		return "æ¨™ç‚ºæœªè®€";
	}

	protected override string _GetTemplateForActionMoveToInbox()
	{
		return "ç§»åˆ°æ”¶ä»¶ç®±";
	}

	protected override string _GetTemplateForActionReply()
	{
		return "å›žè¦†";
	}

	protected override string _GetTemplateForActionReportAbuse()
	{
		return "æª¢èˆ‰æ¿«ç”¨";
	}

	protected override string _GetTemplateForActionSend()
	{
		return "å‚³é€";
	}

	protected override string _GetTemplateForActionSendReply()
	{
		return "å‚³é€å›žè¦†";
	}

	protected override string _GetTemplateForHeadingMessage()
	{
		return "è¨Šæ¯";
	}

	protected override string _GetTemplateForHeadingNewMessages()
	{
		return "æ–°è¨Šæ¯";
	}

	protected override string _GetTemplateForHeadingResponse()
	{
		return "å›žè¦†ï¼š";
	}

	protected override string _GetTemplateForLabelAll()
	{
		return "å…¨éƒ¨";
	}

	protected override string _GetTemplateForLabelArchive()
	{
		return "å°å­˜";
	}

	protected override string _GetTemplateForLabelInbox()
	{
		return "æ”¶ä»¶ç®±";
	}

	protected override string _GetTemplateForLabelIncludeMessage()
	{
		return "åŒ…æ‹¬å‰ä¸€å‰‡è¨Šæ¯";
	}

	protected override string _GetTemplateForLabelNews()
	{
		return "æ¶ˆæ¯";
	}

	/// <summary>
	/// Key: "Label.NoMessagesInCategory"
	/// English String: "You have no {activeTab} messages."
	/// </summary>
	public override string LabelNoMessagesInCategory(string activeTab)
	{
		return $"æ‚¨æ²’æœ‰{activeTab}çš„è¨Šæ¯ã€‚";
	}

	protected override string _GetTemplateForLabelNoMessagesInCategory()
	{
		return "æ‚¨æ²’æœ‰{activeTab}çš„è¨Šæ¯ã€‚";
	}

	protected override string _GetTemplateForLabelOf()
	{
		return "/";
	}

	protected override string _GetTemplateForLabelSelect()
	{
		return "é¸æ“‡â€¦";
	}

	protected override string _GetTemplateForLabelSent()
	{
		return "å·²å‚³é€";
	}

	protected override string _GetTemplateForLabelSubject()
	{
		return "ä¸»æ—¨ï¼š";
	}

	protected override string _GetTemplateForLabelTo()
	{
		return "æ”¶ä»¶äººï¼š";
	}

	protected override string _GetTemplateForMessageBodyCantBlank()
	{
		return "è¨Šæ¯å…§æ–‡ä¸å¯ç©ºç™½ã€‚";
	}

	/// <summary>
	/// Key: "Message.BodyTooLong"
	/// English String: "Please shorten your message to {maxLength} characters or less and try again."
	/// </summary>
	public override string MessageBodyTooLong(string maxLength)
	{
		return $"è«‹å°‡è¨Šæ¯ç¸®çŸ­ç‚º {maxLength} å€‹å­—å…ƒæˆ–æ›´å°‘ï¼Œç„¶å¾Œé‡æ–°å˜—è©¦ã€‚";
	}

	protected override string _GetTemplateForMessageBodyTooLong()
	{
		return "è«‹å°‡è¨Šæ¯ç¸®çŸ­ç‚º {maxLength} å€‹å­—å…ƒæˆ–æ›´å°‘ï¼Œç„¶å¾Œé‡æ–°å˜—è©¦ã€‚";
	}

	protected override string _GetTemplateForMessageGeneralError()
	{
		return "å°ä¸èµ·ï¼Œå‚³é€æ‚¨çš„è¨Šæ¯æ™‚ç™¼ç”ŸéŒ¯èª¤ã€‚";
	}

	protected override string _GetTemplateForMessageIdTheftWarning()
	{
		return "è«‹è¨˜ä½ï¼ŒRoblox å“¡å·¥çµ•å°ä¸æœƒå‘æ‚¨è©¢å•æ‚¨çš„å¯†ç¢¼ã€‚è‹¥æœ‰äººè©¢å•æ‚¨çš„å¯†ç¢¼ï¼Œä»–å€‘æ˜¯åœ¨ä¼åœ–ç›œå–æ‚¨çš„å¸³è™Ÿã€‚";
	}

	protected override string _GetTemplateForMessageNoMessageExist()
	{
		return "è¨Šæ¯ä¸å­˜åœ¨";
	}

	protected override string _GetTemplateForMessageNoNews()
	{
		return "æ‚¨æ²’æœ‰æ¶ˆæ¯ã€‚";
	}

	protected override string _GetTemplateForMessageNoRecipient()
	{
		return "æ”¶ä»¶äººä¸å­˜åœ¨ï¼";
	}

	protected override string _GetTemplateForMessageNotAuthorizeToManipulate()
	{
		return "æ¬Šé™ä¸è¶³ï¼Œç„¡æ³•æ“ä½œè¨Šæ¯";
	}

	protected override string _GetTemplateForMessageNotSendAndModerated()
	{
		return "æ‚¨çš„è¨Šæ¯é­åˆ°éŽæ¿¾è€Œæœªé€å‡ºã€‚";
	}

	protected override string _GetTemplateForMessageRecipientPrivacySettingsTooHigh()
	{
		return "å› æ”¶ä»¶äººçš„éš±ç§æ¬Šè¨­å®šï¼Œæ‚¨ç„¡æ³•å‚³é€æ­¤è¨Šæ¯ã€‚";
	}

	protected override string _GetTemplateForMessageReplyHere()
	{
		return "åœ¨æ­¤è™•å›žè¦†â€¦";
	}

	protected override string _GetTemplateForMessageRobloxWarning()
	{
		return "è«‹è¨˜ä½ï¼ŒRoblox å“¡å·¥çµ•å°ä¸æœƒå‘æ‚¨è©¢å•æ‚¨çš„å¯†ç¢¼ã€‚è‹¥æœ‰äººè©¢å•æ‚¨çš„å¯†ç¢¼ï¼Œä»–å€‘æ˜¯åœ¨ä¼åœ–ç›œå–æ‚¨çš„å¸³è™Ÿã€‚";
	}

	/// <summary>
	/// Key: "Message.SenderPrivacySettingTooHeight"
	/// English String: "Your {frontLink}privacy settings{endLink} prevent you from sending this message."
	/// </summary>
	public override string MessageSenderPrivacySettingTooHeight(string frontLink, string endLink)
	{
		return $"æ‚¨çš„{frontLink}éš±ç§æ¬Šè¨­å®š{endLink}ç¦æ­¢æ‚¨å‚³é€æ­¤è¨Šæ¯ã€‚";
	}

	protected override string _GetTemplateForMessageSenderPrivacySettingTooHeight()
	{
		return "æ‚¨çš„{frontLink}éš±ç§æ¬Šè¨­å®š{endLink}ç¦æ­¢æ‚¨å‚³é€æ­¤è¨Šæ¯ã€‚";
	}

	protected override string _GetTemplateForMessageSendSuccessfully()
	{
		return "å·²æˆåŠŸå‚³é€è¨Šæ¯ã€‚";
	}

	protected override string _GetTemplateForMessageSendTooManyMessages()
	{
		return "æ‚¨å‚³é€è¨Šæ¯é »çŽ‡éŽé«˜ã€‚";
	}

	protected override string _GetTemplateForMessageSubjectCantBlank()
	{
		return "è¨Šæ¯ä¸»æ—¨ä¸å¯ç©ºç™½ã€‚";
	}

	protected override string _GetTemplateForMessageUnknownError()
	{
		return "æœªçŸ¥éŒ¯èª¤";
	}

	protected override string _GetTemplateForMessageUnknownMessageType()
	{
		return "ç„¡æ³•é¡¯ç¤ºè¨Šæ¯";
	}

	/// <summary>
	/// Key: "Message.VerifySenderEmail"
	/// English String: "You must verify your email on the {frontLink}Account Settings{endLink} page before you can send messages."
	/// </summary>
	public override string MessageVerifySenderEmail(string frontLink, string endLink)
	{
		return $"è‹¥è¦å‚³é€è¨Šæ¯ï¼Œè«‹å…ˆåœ¨{frontLink}å¸³è™Ÿè¨­å®š{endLink}é é¢é©—è­‰é›»å­éƒµä»¶åœ°å€ã€‚";
	}

	protected override string _GetTemplateForMessageVerifySenderEmail()
	{
		return "è‹¥è¦å‚³é€è¨Šæ¯ï¼Œè«‹å…ˆåœ¨{frontLink}å¸³è™Ÿè¨­å®š{endLink}é é¢é©—è­‰é›»å­éƒµä»¶åœ°å€ã€‚";
	}

	protected override string _GetTemplateForMessageWriteYourMessage()
	{
		return "å¯«ä¸‹æ‚¨çš„è¨Šæ¯â€¦";
	}
}


}
