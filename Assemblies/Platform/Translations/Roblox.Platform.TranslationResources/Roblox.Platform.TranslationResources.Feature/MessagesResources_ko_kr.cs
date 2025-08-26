namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides MessagesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class MessagesResources_ko_kr : MessagesResources_en_us, IMessagesResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Archive"
	/// English String: "Archive"
	/// </summary>
	public override string ActionArchive => "ë³´ê´€";

	/// <summary>
	/// Key: "Action.Back"
	/// English String: "Back"
	/// </summary>
	public override string ActionBack => "ë’¤ë¡œ";

	/// <summary>
	/// Key: "Action.Discard"
	/// English String: "Discard"
	/// </summary>
	public override string ActionDiscard => "ì·¨ì†Œ";

	/// <summary>
	/// Key: "Action.MarkAsRead"
	/// English String: "Mark As Read"
	/// </summary>
	public override string ActionMarkAsRead => "ì½ìŒìœ¼ë¡œ í‘œì‹œ";

	/// <summary>
	/// Key: "Action.MarkAsUnread"
	/// English String: "Mark As Unread"
	/// </summary>
	public override string ActionMarkAsUnread => "ì½ì§€ ì•ŠìŒìœ¼ë¡œ í‘œì‹œ";

	/// <summary>
	/// Key: "Action.MoveToInbox"
	/// English String: "Move To Inbox"
	/// </summary>
	public override string ActionMoveToInbox => "ìˆ˜ì‹ í•¨ìœ¼ë¡œ ì´ë™";

	/// <summary>
	/// Key: "Action.Reply"
	/// English String: "Reply"
	/// </summary>
	public override string ActionReply => "ë‹µë³€";

	/// <summary>
	/// Key: "Action.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string ActionReportAbuse => "ì‹ ê³ í•˜ê¸°";

	/// <summary>
	/// Key: "Action.Send"
	/// English String: "Send"
	/// </summary>
	public override string ActionSend => "ë³´ë‚´ê¸°";

	/// <summary>
	/// Key: "Action.SendReply"
	/// English String: "Send Reply"
	/// </summary>
	public override string ActionSendReply => "ë‹µë³€ ë³´ë‚´ê¸°";

	/// <summary>
	/// Key: "Heading.Message"
	/// English String: "Messages"
	/// </summary>
	public override string HeadingMessage => "ë©”ì‹œì§€";

	/// <summary>
	/// Key: "Heading.NewMessages"
	/// English String: "New Message"
	/// </summary>
	public override string HeadingNewMessages => "ìƒˆ ë©”ì‹œì§€";

	/// <summary>
	/// Key: "Heading.Response"
	/// English String: "Responses:"
	/// </summary>
	public override string HeadingResponse => "ì‘ë‹µ:";

	/// <summary>
	/// Key: "Label.All"
	/// English String: "All"
	/// </summary>
	public override string LabelAll => "ì „ì²´";

	/// <summary>
	/// Key: "Label.Archive"
	/// English String: "Archive"
	/// </summary>
	public override string LabelArchive => "ë³´ê´€í•¨";

	/// <summary>
	/// Key: "Label.Inbox"
	/// English String: "Inbox"
	/// </summary>
	public override string LabelInbox => "ìˆ˜ì‹ í•¨";

	/// <summary>
	/// Key: "Label.IncludeMessage"
	/// English String: "Include Previous Message"
	/// </summary>
	public override string LabelIncludeMessage => "ì´ì „ ë©”ì‹œì§€ í¬í•¨";

	/// <summary>
	/// Key: "Label.News"
	/// English String: "News"
	/// </summary>
	public override string LabelNews => "ìƒˆì†Œì‹";

	/// <summary>
	/// Key: "Label.Of"
	/// English String: "Of"
	/// </summary>
	public override string LabelOf => "/";

	/// <summary>
	/// Key: "Label.Select"
	/// English String: "Select..."
	/// </summary>
	public override string LabelSelect => "ì„ íƒ...";

	/// <summary>
	/// Key: "Label.Sent"
	/// English String: "Sent"
	/// </summary>
	public override string LabelSent => "ë°œì‹ í•¨";

	/// <summary>
	/// Key: "Label.Subject"
	/// English String: "Subject:"
	/// </summary>
	public override string LabelSubject => "ì œëª©:";

	/// <summary>
	/// Key: "Label.To"
	/// English String: "To:"
	/// </summary>
	public override string LabelTo => "ìˆ˜ì‹ ìž:";

	/// <summary>
	/// Key: "Message.BodyCantBlank"
	/// English String: "The message body can't be blank."
	/// </summary>
	public override string MessageBodyCantBlank => "ë©”ì‹œì§€ ë‚´ìš©ì„ ìž…ë ¥í•˜ì…”ì•¼ í•©ë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Message.GeneralError"
	/// English String: "Sorry, an error occurred sending your message."
	/// </summary>
	public override string MessageGeneralError => "ì£„ì†¡í•©ë‹ˆë‹¤. ë©”ì‹œì§€ë¥¼ ì „ì†¡ ì¤‘ ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”.";

	/// <summary>
	/// Key: "Message.IdTheftWarning"
	/// English String: "Remember, Roblox staff will never ask you for your password. People who ask for your password are trying to steal your account."
	/// </summary>
	public override string MessageIdTheftWarning => "RobloxëŠ” ì ˆëŒ€ ë¹„ë°€ë²ˆí˜¸ë¥¼ ë¬¼ì–´ë³´ì§€ ì•ŠìŠµë‹ˆë‹¤. ë¹„ë°€ë²ˆí˜¸ë¥¼ ìš”êµ¬í•˜ëŠ” í–‰ìœ„ëŠ” ê³„ì •ì„ ë„ìš©í•˜ë ¤ëŠ” ì‹œë„ë¼ëŠ” ì‚¬ì‹¤, ìžŠì§€ë§ˆì„¸ìš”.";

	/// <summary>
	/// Key: "Message.NoMessageExist"
	/// English String: "Message doesn't exist"
	/// </summary>
	public override string MessageNoMessageExist => "ë©”ì‹œì§€ê°€ ì—†ì–´ìš”";

	/// <summary>
	/// Key: "Message.NoNews"
	/// English String: "You have no news."
	/// </summary>
	public override string MessageNoNews => "ìƒˆì†Œì‹ì´ ì—†ì–´ìš”.";

	/// <summary>
	/// Key: "Message.NoRecipient"
	/// English String: "Recipient doesn't exist!"
	/// </summary>
	public override string MessageNoRecipient => "ìˆ˜ì‹ ìžê°€ ì—†ì–´ìš”!";

	/// <summary>
	/// Key: "Message.NotAuthorizeToManipulate"
	/// English String: "Not authorized to manipulate message"
	/// </summary>
	public override string MessageNotAuthorizeToManipulate => "ë©”ì‹œì§€ë¥¼ ì¡°ìž‘í•  ê¶Œí•œ ì—†ìŒ";

	/// <summary>
	/// Key: "Message.NotSendAndModerated"
	/// English String: "Your message was not sent because it was moderated."
	/// </summary>
	public override string MessageNotSendAndModerated => "ë©”ì‹œì§€ê°€ ê²€ì—´ì„ í†µê³¼í•˜ì§€ ëª»í•´ ì „ì†¡ë˜ì§€ ì•Šì•˜ì–´ìš”.";

	/// <summary>
	/// Key: "Message.RecipientPrivacySettingsTooHigh"
	/// English String: "The recipient's privacy settings prevent you from sending this message."
	/// </summary>
	public override string MessageRecipientPrivacySettingsTooHigh => "ìˆ˜ì‹ ìžì˜ ê°œì¸ì •ë³´ ì„¤ì • ë•Œë¬¸ì— ë³¸ ë©”ì‹œì§€ë¥¼ ë³´ë‚¼ ìˆ˜ ì—†ì–´ìš”.";

	/// <summary>
	/// Key: "Message.ReplyHere"
	/// English String: "Reply here..."
	/// </summary>
	public override string MessageReplyHere => "ë‹µë³€ ìž‘ì„±...";

	/// <summary>
	/// Key: "Message.RobloxWarning"
	/// English String: "Remember, Roblox staff will never ask you for your password. People who ask for your password are trying to steal your account."
	/// </summary>
	public override string MessageRobloxWarning => "RobloxëŠ” ì ˆëŒ€ ë¹„ë°€ë²ˆí˜¸ë¥¼ ë¬¼ì–´ë³´ì§€ ì•ŠìŠµë‹ˆë‹¤. ë¹„ë°€ë²ˆí˜¸ë¥¼ ë¬¼ì–´ë³´ëŠ” í–‰ìœ„ëŠ” ê³„ì •ì„ ë„ìš©í•˜ë ¤ëŠ” ì‹œë„ë¼ëŠ” ì‚¬ì‹¤, ìžŠì§€ë§ˆì„¸ìš”.";

	/// <summary>
	/// Key: "Message.SendSuccessfully"
	/// English String: "Successfully sent message."
	/// </summary>
	public override string MessageSendSuccessfully => "ë©”ì‹œì§€ ì „ì†¡ ì™„ë£Œ.";

	/// <summary>
	/// Key: "Message.SendTooManyMessages"
	/// English String: "You're sending too many messages too quickly."
	/// </summary>
	public override string MessageSendTooManyMessages => "ì§§ì€ ì‹œê°„ ì•ˆì— ë„ˆë¬´ ë§Žì€ ë©”ì‹œì§€ë¥¼ ë³´ë‚´ê³  ìžˆìŠµë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Message.SubjectCantBlank"
	/// English String: "The message subject can't be blank."
	/// </summary>
	public override string MessageSubjectCantBlank => "ë©”ì‹œì§€ ì œëª©ì„ ìž…ë ¥í•˜ì…”ì•¼ í•©ë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Message.UnknownError"
	/// English String: "Unknown error"
	/// </summary>
	public override string MessageUnknownError => "ì•Œ ìˆ˜ ì—†ëŠ” ì˜¤ë¥˜";

	/// <summary>
	/// Key: "Message.UnknownMessageType"
	/// This serves as the fallback string for when an message type is received that the web chat does not know how to render.
	/// English String: "A message cannot be displayed"
	/// </summary>
	public override string MessageUnknownMessageType => "ë©”ì‹œì§€ë¥¼ í‘œì‹œí•  ìˆ˜ ì—†ìŒ";

	/// <summary>
	/// Key: "Message.WriteYourMessage"
	/// English String: "Write your message..."
	/// </summary>
	public override string MessageWriteYourMessage => "ë©”ì‹œì§€ë¥¼ ìž‘ì„±í•˜ì„¸ìš”...";

	public MessagesResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionArchive()
	{
		return "ë³´ê´€";
	}

	protected override string _GetTemplateForActionBack()
	{
		return "ë’¤ë¡œ";
	}

	protected override string _GetTemplateForActionDiscard()
	{
		return "ì·¨ì†Œ";
	}

	protected override string _GetTemplateForActionMarkAsRead()
	{
		return "ì½ìŒìœ¼ë¡œ í‘œì‹œ";
	}

	protected override string _GetTemplateForActionMarkAsUnread()
	{
		return "ì½ì§€ ì•ŠìŒìœ¼ë¡œ í‘œì‹œ";
	}

	protected override string _GetTemplateForActionMoveToInbox()
	{
		return "ìˆ˜ì‹ í•¨ìœ¼ë¡œ ì´ë™";
	}

	protected override string _GetTemplateForActionReply()
	{
		return "ë‹µë³€";
	}

	protected override string _GetTemplateForActionReportAbuse()
	{
		return "ì‹ ê³ í•˜ê¸°";
	}

	protected override string _GetTemplateForActionSend()
	{
		return "ë³´ë‚´ê¸°";
	}

	protected override string _GetTemplateForActionSendReply()
	{
		return "ë‹µë³€ ë³´ë‚´ê¸°";
	}

	protected override string _GetTemplateForHeadingMessage()
	{
		return "ë©”ì‹œì§€";
	}

	protected override string _GetTemplateForHeadingNewMessages()
	{
		return "ìƒˆ ë©”ì‹œì§€";
	}

	protected override string _GetTemplateForHeadingResponse()
	{
		return "ì‘ë‹µ:";
	}

	protected override string _GetTemplateForLabelAll()
	{
		return "ì „ì²´";
	}

	protected override string _GetTemplateForLabelArchive()
	{
		return "ë³´ê´€í•¨";
	}

	protected override string _GetTemplateForLabelInbox()
	{
		return "ìˆ˜ì‹ í•¨";
	}

	protected override string _GetTemplateForLabelIncludeMessage()
	{
		return "ì´ì „ ë©”ì‹œì§€ í¬í•¨";
	}

	protected override string _GetTemplateForLabelNews()
	{
		return "ìƒˆì†Œì‹";
	}

	/// <summary>
	/// Key: "Label.NoMessagesInCategory"
	/// English String: "You have no {activeTab} messages."
	/// </summary>
	public override string LabelNoMessagesInCategory(string activeTab)
	{
		return $"{activeTab} ë©”ì‹œì§€ê°€ ì—†ì–´ìš”.";
	}

	protected override string _GetTemplateForLabelNoMessagesInCategory()
	{
		return "{activeTab} ë©”ì‹œì§€ê°€ ì—†ì–´ìš”.";
	}

	protected override string _GetTemplateForLabelOf()
	{
		return "/";
	}

	protected override string _GetTemplateForLabelSelect()
	{
		return "ì„ íƒ...";
	}

	protected override string _GetTemplateForLabelSent()
	{
		return "ë°œì‹ í•¨";
	}

	protected override string _GetTemplateForLabelSubject()
	{
		return "ì œëª©:";
	}

	protected override string _GetTemplateForLabelTo()
	{
		return "ìˆ˜ì‹ ìž:";
	}

	protected override string _GetTemplateForMessageBodyCantBlank()
	{
		return "ë©”ì‹œì§€ ë‚´ìš©ì„ ìž…ë ¥í•˜ì…”ì•¼ í•©ë‹ˆë‹¤.";
	}

	/// <summary>
	/// Key: "Message.BodyTooLong"
	/// English String: "Please shorten your message to {maxLength} characters or less and try again."
	/// </summary>
	public override string MessageBodyTooLong(string maxLength)
	{
		return $"ë©”ì‹œì§€ ë‚´ìš©ì„ {maxLength}ìž ì´í•˜ë¡œ ì¤„ì¸ ë‹¤ìŒ ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForMessageBodyTooLong()
	{
		return "ë©”ì‹œì§€ ë‚´ìš©ì„ {maxLength}ìž ì´í•˜ë¡œ ì¤„ì¸ ë‹¤ìŒ ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForMessageGeneralError()
	{
		return "ì£„ì†¡í•©ë‹ˆë‹¤. ë©”ì‹œì§€ë¥¼ ì „ì†¡ ì¤‘ ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”.";
	}

	protected override string _GetTemplateForMessageIdTheftWarning()
	{
		return "RobloxëŠ” ì ˆëŒ€ ë¹„ë°€ë²ˆí˜¸ë¥¼ ë¬¼ì–´ë³´ì§€ ì•ŠìŠµë‹ˆë‹¤. ë¹„ë°€ë²ˆí˜¸ë¥¼ ìš”êµ¬í•˜ëŠ” í–‰ìœ„ëŠ” ê³„ì •ì„ ë„ìš©í•˜ë ¤ëŠ” ì‹œë„ë¼ëŠ” ì‚¬ì‹¤, ìžŠì§€ë§ˆì„¸ìš”.";
	}

	protected override string _GetTemplateForMessageNoMessageExist()
	{
		return "ë©”ì‹œì§€ê°€ ì—†ì–´ìš”";
	}

	protected override string _GetTemplateForMessageNoNews()
	{
		return "ìƒˆì†Œì‹ì´ ì—†ì–´ìš”.";
	}

	protected override string _GetTemplateForMessageNoRecipient()
	{
		return "ìˆ˜ì‹ ìžê°€ ì—†ì–´ìš”!";
	}

	protected override string _GetTemplateForMessageNotAuthorizeToManipulate()
	{
		return "ë©”ì‹œì§€ë¥¼ ì¡°ìž‘í•  ê¶Œí•œ ì—†ìŒ";
	}

	protected override string _GetTemplateForMessageNotSendAndModerated()
	{
		return "ë©”ì‹œì§€ê°€ ê²€ì—´ì„ í†µê³¼í•˜ì§€ ëª»í•´ ì „ì†¡ë˜ì§€ ì•Šì•˜ì–´ìš”.";
	}

	protected override string _GetTemplateForMessageRecipientPrivacySettingsTooHigh()
	{
		return "ìˆ˜ì‹ ìžì˜ ê°œì¸ì •ë³´ ì„¤ì • ë•Œë¬¸ì— ë³¸ ë©”ì‹œì§€ë¥¼ ë³´ë‚¼ ìˆ˜ ì—†ì–´ìš”.";
	}

	protected override string _GetTemplateForMessageReplyHere()
	{
		return "ë‹µë³€ ìž‘ì„±...";
	}

	protected override string _GetTemplateForMessageRobloxWarning()
	{
		return "RobloxëŠ” ì ˆëŒ€ ë¹„ë°€ë²ˆí˜¸ë¥¼ ë¬¼ì–´ë³´ì§€ ì•ŠìŠµë‹ˆë‹¤. ë¹„ë°€ë²ˆí˜¸ë¥¼ ë¬¼ì–´ë³´ëŠ” í–‰ìœ„ëŠ” ê³„ì •ì„ ë„ìš©í•˜ë ¤ëŠ” ì‹œë„ë¼ëŠ” ì‚¬ì‹¤, ìžŠì§€ë§ˆì„¸ìš”.";
	}

	/// <summary>
	/// Key: "Message.SenderPrivacySettingTooHeight"
	/// English String: "Your {frontLink}privacy settings{endLink} prevent you from sending this message."
	/// </summary>
	public override string MessageSenderPrivacySettingTooHeight(string frontLink, string endLink)
	{
		return $"íšŒì›ë‹˜ì˜ {frontLink}ê°œì¸ì •ë³´ ì„¤ì •{endLink} ë•Œë¬¸ì— ë³¸ ë©”ì‹œì§€ë¥¼ ë³´ë‚¼ ìˆ˜ ì—†ì–´ìš”.";
	}

	protected override string _GetTemplateForMessageSenderPrivacySettingTooHeight()
	{
		return "íšŒì›ë‹˜ì˜ {frontLink}ê°œì¸ì •ë³´ ì„¤ì •{endLink} ë•Œë¬¸ì— ë³¸ ë©”ì‹œì§€ë¥¼ ë³´ë‚¼ ìˆ˜ ì—†ì–´ìš”.";
	}

	protected override string _GetTemplateForMessageSendSuccessfully()
	{
		return "ë©”ì‹œì§€ ì „ì†¡ ì™„ë£Œ.";
	}

	protected override string _GetTemplateForMessageSendTooManyMessages()
	{
		return "ì§§ì€ ì‹œê°„ ì•ˆì— ë„ˆë¬´ ë§Žì€ ë©”ì‹œì§€ë¥¼ ë³´ë‚´ê³  ìžˆìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForMessageSubjectCantBlank()
	{
		return "ë©”ì‹œì§€ ì œëª©ì„ ìž…ë ¥í•˜ì…”ì•¼ í•©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForMessageUnknownError()
	{
		return "ì•Œ ìˆ˜ ì—†ëŠ” ì˜¤ë¥˜";
	}

	protected override string _GetTemplateForMessageUnknownMessageType()
	{
		return "ë©”ì‹œì§€ë¥¼ í‘œì‹œí•  ìˆ˜ ì—†ìŒ";
	}

	/// <summary>
	/// Key: "Message.VerifySenderEmail"
	/// English String: "You must verify your email on the {frontLink}Account Settings{endLink} page before you can send messages."
	/// </summary>
	public override string MessageVerifySenderEmail(string frontLink, string endLink)
	{
		return $"ë©”ì‹œì§€ë¥¼ ë³´ë‚´ë ¤ë©´ {frontLink}ê³„ì • ì„¤ì •{endLink} íŽ˜ì´ì§€ì—ì„œ ì´ë©”ì¼ ì¸ì¦ì„ ì™„ë£Œí•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForMessageVerifySenderEmail()
	{
		return "ë©”ì‹œì§€ë¥¼ ë³´ë‚´ë ¤ë©´ {frontLink}ê³„ì • ì„¤ì •{endLink} íŽ˜ì´ì§€ì—ì„œ ì´ë©”ì¼ ì¸ì¦ì„ ì™„ë£Œí•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForMessageWriteYourMessage()
	{
		return "ë©”ì‹œì§€ë¥¼ ìž‘ì„±í•˜ì„¸ìš”...";
	}
}


}
