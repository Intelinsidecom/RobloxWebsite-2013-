namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides MessagesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class MessagesResources_ja_jp : MessagesResources_en_us, IMessagesResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Archive"
	/// English String: "Archive"
	/// </summary>
	public override string ActionArchive => "ã‚¢ãƒ¼ã‚«ã‚¤ãƒ–";

	/// <summary>
	/// Key: "Action.Back"
	/// English String: "Back"
	/// </summary>
	public override string ActionBack => "æˆ»ã‚‹";

	/// <summary>
	/// Key: "Action.Discard"
	/// English String: "Discard"
	/// </summary>
	public override string ActionDiscard => "ç ´æ£„";

	/// <summary>
	/// Key: "Action.MarkAsRead"
	/// English String: "Mark As Read"
	/// </summary>
	public override string ActionMarkAsRead => "æ—¢èª­ã«ã™ã‚‹";

	/// <summary>
	/// Key: "Action.MarkAsUnread"
	/// English String: "Mark As Unread"
	/// </summary>
	public override string ActionMarkAsUnread => "æœªèª­ã«ã™ã‚‹";

	/// <summary>
	/// Key: "Action.MoveToInbox"
	/// English String: "Move To Inbox"
	/// </summary>
	public override string ActionMoveToInbox => "å—ä¿¡ãƒˆãƒ¬ã‚¤ã«ç§»å‹•";

	/// <summary>
	/// Key: "Action.Reply"
	/// English String: "Reply"
	/// </summary>
	public override string ActionReply => "è¿”ä¿¡";

	/// <summary>
	/// Key: "Action.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string ActionReportAbuse => "è¦ç´„é•åã‚’å ±å‘Š";

	/// <summary>
	/// Key: "Action.Send"
	/// English String: "Send"
	/// </summary>
	public override string ActionSend => "é€ä¿¡";

	/// <summary>
	/// Key: "Action.SendReply"
	/// English String: "Send Reply"
	/// </summary>
	public override string ActionSendReply => "è¿”ä¿¡";

	/// <summary>
	/// Key: "Heading.Message"
	/// English String: "Messages"
	/// </summary>
	public override string HeadingMessage => "ãƒ¡ãƒƒã‚»ãƒ¼ã‚¸";

	/// <summary>
	/// Key: "Heading.NewMessages"
	/// English String: "New Message"
	/// </summary>
	public override string HeadingNewMessages => "æ–°ç€ãƒ¡ãƒƒã‚»ãƒ¼ã‚¸";

	/// <summary>
	/// Key: "Heading.Response"
	/// English String: "Responses:"
	/// </summary>
	public override string HeadingResponse => "è¿”ä¿¡:";

	/// <summary>
	/// Key: "Label.All"
	/// English String: "All"
	/// </summary>
	public override string LabelAll => "ã™ã¹ã¦";

	/// <summary>
	/// Key: "Label.Archive"
	/// English String: "Archive"
	/// </summary>
	public override string LabelArchive => "ã‚¢ãƒ¼ã‚«ã‚¤ãƒ–";

	/// <summary>
	/// Key: "Label.Inbox"
	/// English String: "Inbox"
	/// </summary>
	public override string LabelInbox => "å—ä¿¡ãƒˆãƒ¬ã‚¤";

	/// <summary>
	/// Key: "Label.IncludeMessage"
	/// English String: "Include Previous Message"
	/// </summary>
	public override string LabelIncludeMessage => "å‰ã®ãƒ¡ãƒƒã‚»ãƒ¼ã‚¸ã‚’å«ã‚ã‚‹";

	/// <summary>
	/// Key: "Label.News"
	/// English String: "News"
	/// </summary>
	public override string LabelNews => "ãƒ‹ãƒ¥ãƒ¼ã‚¹";

	/// <summary>
	/// Key: "Label.Of"
	/// English String: "Of"
	/// </summary>
	public override string LabelOf => " /";

	/// <summary>
	/// Key: "Label.Select"
	/// English String: "Select..."
	/// </summary>
	public override string LabelSelect => "é¸æŠž...";

	/// <summary>
	/// Key: "Label.Sent"
	/// English String: "Sent"
	/// </summary>
	public override string LabelSent => "é€ä¿¡æ¸ˆã¿";

	/// <summary>
	/// Key: "Label.Subject"
	/// English String: "Subject:"
	/// </summary>
	public override string LabelSubject => "ä»¶å:";

	/// <summary>
	/// Key: "Label.To"
	/// English String: "To:"
	/// </summary>
	public override string LabelTo => "å®›å…ˆ:";

	/// <summary>
	/// Key: "Message.BodyCantBlank"
	/// English String: "The message body can't be blank."
	/// </summary>
	public override string MessageBodyCantBlank => "ãƒ¡ãƒƒã‚»ãƒ¼ã‚¸æœ¬æ–‡ã¯ç©ºç™½ã«ã§ãã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Message.GeneralError"
	/// English String: "Sorry, an error occurred sending your message."
	/// </summary>
	public override string MessageGeneralError => "ç”³ã—è¨³ã‚ã‚Šã¾ã›ã‚“ãŒã€ãƒ¡ãƒƒã‚»ãƒ¼ã‚¸é€ä¿¡ä¸­ã«ã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚";

	/// <summary>
	/// Key: "Message.IdTheftWarning"
	/// English String: "Remember, Roblox staff will never ask you for your password. People who ask for your password are trying to steal your account."
	/// </summary>
	public override string MessageIdTheftWarning => "Robloxã®ã‚¹ã‚¿ãƒƒãƒ•ãŒã€ã‚ãªãŸã®ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã‚’èžãã“ã¨ã¯ã‚ã‚Šã¾ã›ã‚“ã€‚ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã‚’èžãå‡ºãã†ã¨ã™ã‚‹äººã¯ã€ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’ç›—ã‚‚ã†ã¨ã—ã¦ã„ã‚‹ã®ã§ã”æ³¨æ„ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Message.NoMessageExist"
	/// English String: "Message doesn't exist"
	/// </summary>
	public override string MessageNoMessageExist => "ãƒ¡ãƒƒã‚»ãƒ¼ã‚¸ãŒå­˜åœ¨ã—ã¾ã›ã‚“";

	/// <summary>
	/// Key: "Message.NoNews"
	/// English String: "You have no news."
	/// </summary>
	public override string MessageNoNews => "ãƒ‹ãƒ¥ãƒ¼ã‚¹ã¯ã‚ã‚Šã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Message.NoRecipient"
	/// English String: "Recipient doesn't exist!"
	/// </summary>
	public override string MessageNoRecipient => "é€ä¿¡å…ˆãŒå­˜åœ¨ã—ã¾ã›ã‚“ï¼";

	/// <summary>
	/// Key: "Message.NotAuthorizeToManipulate"
	/// English String: "Not authorized to manipulate message"
	/// </summary>
	public override string MessageNotAuthorizeToManipulate => "ãƒ¡ãƒƒã‚»ãƒ¼ã‚¸ã‚’æ“ä½œã™ã‚‹æ¨©é™ãŒã‚ã‚Šã¾ã›ã‚“";

	/// <summary>
	/// Key: "Message.NotSendAndModerated"
	/// English String: "Your message was not sent because it was moderated."
	/// </summary>
	public override string MessageNotSendAndModerated => "ãƒ¡ãƒƒã‚»ãƒ¼ã‚¸ã¯ã€è¦åˆ¶ã«ã‚ˆã‚Šé€ä¿¡ã•ã‚Œã¾ã›ã‚“ã§ã—ãŸã€‚";

	/// <summary>
	/// Key: "Message.RecipientPrivacySettingsTooHigh"
	/// English String: "The recipient's privacy settings prevent you from sending this message."
	/// </summary>
	public override string MessageRecipientPrivacySettingsTooHigh => "å—ä¿¡è€…ã®ãƒ—ãƒ©ã‚¤ãƒã‚·ãƒ¼è¨­å®šã«ã‚ˆã‚Šã€ã“ã®ãƒ¡ãƒƒã‚»ãƒ¼ã‚¸ã‚’é€ä¿¡ã§ãã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Message.ReplyHere"
	/// English String: "Reply here..."
	/// </summary>
	public override string MessageReplyHere => "è¿”ä¿¡ã¯ã“ã¡ã‚‰...";

	/// <summary>
	/// Key: "Message.RobloxWarning"
	/// English String: "Remember, Roblox staff will never ask you for your password. People who ask for your password are trying to steal your account."
	/// </summary>
	public override string MessageRobloxWarning => "Robloxã®ã‚¹ã‚¿ãƒƒãƒ•ãŒã€ã‚ãªãŸã®ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã‚’èžãã“ã¨ã¯ã‚ã‚Šã¾ã›ã‚“ã€‚ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã‚’èžãå‡ºãã†ã¨ã™ã‚‹äººã¯ã€ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’ç›—ã‚‚ã†ã¨ã—ã¦ã„ã‚‹ã®ã§ã”æ³¨æ„ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Message.SendSuccessfully"
	/// English String: "Successfully sent message."
	/// </summary>
	public override string MessageSendSuccessfully => "ãƒ¡ãƒƒã‚»ãƒ¼ã‚¸ã‚’é€ä¿¡ã—ã¾ã—ãŸã€‚";

	/// <summary>
	/// Key: "Message.SendTooManyMessages"
	/// English String: "You're sending too many messages too quickly."
	/// </summary>
	public override string MessageSendTooManyMessages => "é »ç¹ã«ãƒ¡ãƒƒã‚»ãƒ¼ã‚¸ã‚’é€ä¿¡ã—ã™ãŽã¦ã„ã¾ã™ã€‚";

	/// <summary>
	/// Key: "Message.SubjectCantBlank"
	/// English String: "The message subject can't be blank."
	/// </summary>
	public override string MessageSubjectCantBlank => "ãƒ¡ãƒƒã‚»ãƒ¼ã‚¸ã®ä»¶åã¯ç©ºç™½ã«ã§ãã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Message.UnknownError"
	/// English String: "Unknown error"
	/// </summary>
	public override string MessageUnknownError => "ä¸æ˜Žãªã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸ";

	/// <summary>
	/// Key: "Message.UnknownMessageType"
	/// This serves as the fallback string for when an message type is received that the web chat does not know how to render.
	/// English String: "A message cannot be displayed"
	/// </summary>
	public override string MessageUnknownMessageType => "ãƒ¡ãƒƒã‚»ãƒ¼ã‚¸ã‚’è¡¨ç¤ºã§ãã¾ã›ã‚“";

	/// <summary>
	/// Key: "Message.WriteYourMessage"
	/// English String: "Write your message..."
	/// </summary>
	public override string MessageWriteYourMessage => "ãƒ¡ãƒƒã‚»ãƒ¼ã‚¸ã‚’å…¥åŠ›...";

	public MessagesResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionArchive()
	{
		return "ã‚¢ãƒ¼ã‚«ã‚¤ãƒ–";
	}

	protected override string _GetTemplateForActionBack()
	{
		return "æˆ»ã‚‹";
	}

	protected override string _GetTemplateForActionDiscard()
	{
		return "ç ´æ£„";
	}

	protected override string _GetTemplateForActionMarkAsRead()
	{
		return "æ—¢èª­ã«ã™ã‚‹";
	}

	protected override string _GetTemplateForActionMarkAsUnread()
	{
		return "æœªèª­ã«ã™ã‚‹";
	}

	protected override string _GetTemplateForActionMoveToInbox()
	{
		return "å—ä¿¡ãƒˆãƒ¬ã‚¤ã«ç§»å‹•";
	}

	protected override string _GetTemplateForActionReply()
	{
		return "è¿”ä¿¡";
	}

	protected override string _GetTemplateForActionReportAbuse()
	{
		return "è¦ç´„é•åã‚’å ±å‘Š";
	}

	protected override string _GetTemplateForActionSend()
	{
		return "é€ä¿¡";
	}

	protected override string _GetTemplateForActionSendReply()
	{
		return "è¿”ä¿¡";
	}

	protected override string _GetTemplateForHeadingMessage()
	{
		return "ãƒ¡ãƒƒã‚»ãƒ¼ã‚¸";
	}

	protected override string _GetTemplateForHeadingNewMessages()
	{
		return "æ–°ç€ãƒ¡ãƒƒã‚»ãƒ¼ã‚¸";
	}

	protected override string _GetTemplateForHeadingResponse()
	{
		return "è¿”ä¿¡:";
	}

	protected override string _GetTemplateForLabelAll()
	{
		return "ã™ã¹ã¦";
	}

	protected override string _GetTemplateForLabelArchive()
	{
		return "ã‚¢ãƒ¼ã‚«ã‚¤ãƒ–";
	}

	protected override string _GetTemplateForLabelInbox()
	{
		return "å—ä¿¡ãƒˆãƒ¬ã‚¤";
	}

	protected override string _GetTemplateForLabelIncludeMessage()
	{
		return "å‰ã®ãƒ¡ãƒƒã‚»ãƒ¼ã‚¸ã‚’å«ã‚ã‚‹";
	}

	protected override string _GetTemplateForLabelNews()
	{
		return "ãƒ‹ãƒ¥ãƒ¼ã‚¹";
	}

	/// <summary>
	/// Key: "Label.NoMessagesInCategory"
	/// English String: "You have no {activeTab} messages."
	/// </summary>
	public override string LabelNoMessagesInCategory(string activeTab)
	{
		return $"{activeTab} ã®ãƒ¡ãƒƒã‚»ãƒ¼ã‚¸ã¯ã‚ã‚Šã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForLabelNoMessagesInCategory()
	{
		return "{activeTab} ã®ãƒ¡ãƒƒã‚»ãƒ¼ã‚¸ã¯ã‚ã‚Šã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForLabelOf()
	{
		return " /";
	}

	protected override string _GetTemplateForLabelSelect()
	{
		return "é¸æŠž...";
	}

	protected override string _GetTemplateForLabelSent()
	{
		return "é€ä¿¡æ¸ˆã¿";
	}

	protected override string _GetTemplateForLabelSubject()
	{
		return "ä»¶å:";
	}

	protected override string _GetTemplateForLabelTo()
	{
		return "å®›å…ˆ:";
	}

	protected override string _GetTemplateForMessageBodyCantBlank()
	{
		return "ãƒ¡ãƒƒã‚»ãƒ¼ã‚¸æœ¬æ–‡ã¯ç©ºç™½ã«ã§ãã¾ã›ã‚“ã€‚";
	}

	/// <summary>
	/// Key: "Message.BodyTooLong"
	/// English String: "Please shorten your message to {maxLength} characters or less and try again."
	/// </summary>
	public override string MessageBodyTooLong(string maxLength)
	{
		return $"ãƒ¡ãƒƒã‚»ãƒ¼ã‚¸ã‚’ {maxLength} æ–‡å­—ä»¥ä¸‹ã«ã—ã¦ã€ã‚„ã‚Šç›´ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForMessageBodyTooLong()
	{
		return "ãƒ¡ãƒƒã‚»ãƒ¼ã‚¸ã‚’ {maxLength} æ–‡å­—ä»¥ä¸‹ã«ã—ã¦ã€ã‚„ã‚Šç›´ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForMessageGeneralError()
	{
		return "ç”³ã—è¨³ã‚ã‚Šã¾ã›ã‚“ãŒã€ãƒ¡ãƒƒã‚»ãƒ¼ã‚¸é€ä¿¡ä¸­ã«ã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚";
	}

	protected override string _GetTemplateForMessageIdTheftWarning()
	{
		return "Robloxã®ã‚¹ã‚¿ãƒƒãƒ•ãŒã€ã‚ãªãŸã®ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã‚’èžãã“ã¨ã¯ã‚ã‚Šã¾ã›ã‚“ã€‚ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã‚’èžãå‡ºãã†ã¨ã™ã‚‹äººã¯ã€ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’ç›—ã‚‚ã†ã¨ã—ã¦ã„ã‚‹ã®ã§ã”æ³¨æ„ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForMessageNoMessageExist()
	{
		return "ãƒ¡ãƒƒã‚»ãƒ¼ã‚¸ãŒå­˜åœ¨ã—ã¾ã›ã‚“";
	}

	protected override string _GetTemplateForMessageNoNews()
	{
		return "ãƒ‹ãƒ¥ãƒ¼ã‚¹ã¯ã‚ã‚Šã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForMessageNoRecipient()
	{
		return "é€ä¿¡å…ˆãŒå­˜åœ¨ã—ã¾ã›ã‚“ï¼";
	}

	protected override string _GetTemplateForMessageNotAuthorizeToManipulate()
	{
		return "ãƒ¡ãƒƒã‚»ãƒ¼ã‚¸ã‚’æ“ä½œã™ã‚‹æ¨©é™ãŒã‚ã‚Šã¾ã›ã‚“";
	}

	protected override string _GetTemplateForMessageNotSendAndModerated()
	{
		return "ãƒ¡ãƒƒã‚»ãƒ¼ã‚¸ã¯ã€è¦åˆ¶ã«ã‚ˆã‚Šé€ä¿¡ã•ã‚Œã¾ã›ã‚“ã§ã—ãŸã€‚";
	}

	protected override string _GetTemplateForMessageRecipientPrivacySettingsTooHigh()
	{
		return "å—ä¿¡è€…ã®ãƒ—ãƒ©ã‚¤ãƒã‚·ãƒ¼è¨­å®šã«ã‚ˆã‚Šã€ã“ã®ãƒ¡ãƒƒã‚»ãƒ¼ã‚¸ã‚’é€ä¿¡ã§ãã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForMessageReplyHere()
	{
		return "è¿”ä¿¡ã¯ã“ã¡ã‚‰...";
	}

	protected override string _GetTemplateForMessageRobloxWarning()
	{
		return "Robloxã®ã‚¹ã‚¿ãƒƒãƒ•ãŒã€ã‚ãªãŸã®ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã‚’èžãã“ã¨ã¯ã‚ã‚Šã¾ã›ã‚“ã€‚ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã‚’èžãå‡ºãã†ã¨ã™ã‚‹äººã¯ã€ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’ç›—ã‚‚ã†ã¨ã—ã¦ã„ã‚‹ã®ã§ã”æ³¨æ„ãã ã•ã„ã€‚";
	}

	/// <summary>
	/// Key: "Message.SenderPrivacySettingTooHeight"
	/// English String: "Your {frontLink}privacy settings{endLink} prevent you from sending this message."
	/// </summary>
	public override string MessageSenderPrivacySettingTooHeight(string frontLink, string endLink)
	{
		return $"ã‚ãªãŸã®{frontLink}ãƒ—ãƒ©ã‚¤ãƒã‚·ãƒ¼è¨­å®š{endLink}ã«ã‚ˆã‚Šã€ã“ã®ãƒ¡ãƒƒã‚»ãƒ¼ã‚¸ã‚’é€ä¿¡ã§ãã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForMessageSenderPrivacySettingTooHeight()
	{
		return "ã‚ãªãŸã®{frontLink}ãƒ—ãƒ©ã‚¤ãƒã‚·ãƒ¼è¨­å®š{endLink}ã«ã‚ˆã‚Šã€ã“ã®ãƒ¡ãƒƒã‚»ãƒ¼ã‚¸ã‚’é€ä¿¡ã§ãã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForMessageSendSuccessfully()
	{
		return "ãƒ¡ãƒƒã‚»ãƒ¼ã‚¸ã‚’é€ä¿¡ã—ã¾ã—ãŸã€‚";
	}

	protected override string _GetTemplateForMessageSendTooManyMessages()
	{
		return "é »ç¹ã«ãƒ¡ãƒƒã‚»ãƒ¼ã‚¸ã‚’é€ä¿¡ã—ã™ãŽã¦ã„ã¾ã™ã€‚";
	}

	protected override string _GetTemplateForMessageSubjectCantBlank()
	{
		return "ãƒ¡ãƒƒã‚»ãƒ¼ã‚¸ã®ä»¶åã¯ç©ºç™½ã«ã§ãã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForMessageUnknownError()
	{
		return "ä¸æ˜Žãªã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸ";
	}

	protected override string _GetTemplateForMessageUnknownMessageType()
	{
		return "ãƒ¡ãƒƒã‚»ãƒ¼ã‚¸ã‚’è¡¨ç¤ºã§ãã¾ã›ã‚“";
	}

	/// <summary>
	/// Key: "Message.VerifySenderEmail"
	/// English String: "You must verify your email on the {frontLink}Account Settings{endLink} page before you can send messages."
	/// </summary>
	public override string MessageVerifySenderEmail(string frontLink, string endLink)
	{
		return $"ãƒ¡ãƒƒã‚»ãƒ¼ã‚¸ã‚’é€ä¿¡ã™ã‚‹å‰ã«ã€{frontLink}ã‚¢ã‚«ã‚¦ãƒ³ãƒˆè¨­å®š{endLink}ãƒšãƒ¼ã‚¸ã§ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã®èªè¨¼ã‚’è¡Œã†å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚";
	}

	protected override string _GetTemplateForMessageVerifySenderEmail()
	{
		return "ãƒ¡ãƒƒã‚»ãƒ¼ã‚¸ã‚’é€ä¿¡ã™ã‚‹å‰ã«ã€{frontLink}ã‚¢ã‚«ã‚¦ãƒ³ãƒˆè¨­å®š{endLink}ãƒšãƒ¼ã‚¸ã§ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã®èªè¨¼ã‚’è¡Œã†å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚";
	}

	protected override string _GetTemplateForMessageWriteYourMessage()
	{
		return "ãƒ¡ãƒƒã‚»ãƒ¼ã‚¸ã‚’å…¥åŠ›...";
	}
}


}
