namespace Roblox.TranslationResources.Feature;

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
	public override string ActionArchive => "归档";

	/// <summary>
	/// Key: "Action.Back"
	/// English String: "Back"
	/// </summary>
	public override string ActionBack => "返回";

	/// <summary>
	/// Key: "Action.Discard"
	/// English String: "Discard"
	/// </summary>
	public override string ActionDiscard => "放弃";

	/// <summary>
	/// Key: "Action.MarkAsRead"
	/// English String: "Mark As Read"
	/// </summary>
	public override string ActionMarkAsRead => "标记为已读";

	/// <summary>
	/// Key: "Action.MarkAsUnread"
	/// English String: "Mark As Unread"
	/// </summary>
	public override string ActionMarkAsUnread => "标记为未读";

	/// <summary>
	/// Key: "Action.MoveToInbox"
	/// English String: "Move To Inbox"
	/// </summary>
	public override string ActionMoveToInbox => "移至收件箱";

	/// <summary>
	/// Key: "Action.Reply"
	/// English String: "Reply"
	/// </summary>
	public override string ActionReply => "回复";

	/// <summary>
	/// Key: "Action.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string ActionReportAbuse => "报告滥用行为";

	/// <summary>
	/// Key: "Action.Send"
	/// English String: "Send"
	/// </summary>
	public override string ActionSend => "发送";

	/// <summary>
	/// Key: "Action.SendReply"
	/// English String: "Send Reply"
	/// </summary>
	public override string ActionSendReply => "发送回复";

	/// <summary>
	/// Key: "Heading.Message"
	/// English String: "Messages"
	/// </summary>
	public override string HeadingMessage => "信息";

	/// <summary>
	/// Key: "Heading.NewMessages"
	/// English String: "New Message"
	/// </summary>
	public override string HeadingNewMessages => "新信息";

	/// <summary>
	/// Key: "Heading.Response"
	/// English String: "Responses:"
	/// </summary>
	public override string HeadingResponse => "回复：";

	/// <summary>
	/// Key: "Label.All"
	/// English String: "All"
	/// </summary>
	public override string LabelAll => "所有";

	/// <summary>
	/// Key: "Label.Archive"
	/// English String: "Archive"
	/// </summary>
	public override string LabelArchive => "归档";

	/// <summary>
	/// Key: "Label.Inbox"
	/// English String: "Inbox"
	/// </summary>
	public override string LabelInbox => "收件箱";

	/// <summary>
	/// Key: "Label.IncludeMessage"
	/// English String: "Include Previous Message"
	/// </summary>
	public override string LabelIncludeMessage => "包含前一条信息";

	/// <summary>
	/// Key: "Label.News"
	/// English String: "News"
	/// </summary>
	public override string LabelNews => "新闻";

	/// <summary>
	/// Key: "Label.Of"
	/// English String: "Of"
	/// </summary>
	public override string LabelOf => "/";

	/// <summary>
	/// Key: "Label.Select"
	/// English String: "Select..."
	/// </summary>
	public override string LabelSelect => "选择...";

	/// <summary>
	/// Key: "Label.Sent"
	/// English String: "Sent"
	/// </summary>
	public override string LabelSent => "已发送";

	/// <summary>
	/// Key: "Label.Subject"
	/// English String: "Subject:"
	/// </summary>
	public override string LabelSubject => "主题：";

	/// <summary>
	/// Key: "Label.To"
	/// English String: "To:"
	/// </summary>
	public override string LabelTo => "收件人：";

	/// <summary>
	/// Key: "Message.BodyCantBlank"
	/// English String: "The message body can't be blank."
	/// </summary>
	public override string MessageBodyCantBlank => "信息正文不能为空。";

	/// <summary>
	/// Key: "Message.GeneralError"
	/// English String: "Sorry, an error occurred sending your message."
	/// </summary>
	public override string MessageGeneralError => "抱歉，发送信息时发生错误。";

	/// <summary>
	/// Key: "Message.IdTheftWarning"
	/// English String: "Remember, Roblox staff will never ask you for your password. People who ask for your password are trying to steal your account."
	/// </summary>
	public override string MessageIdTheftWarning => "请记住，Roblox 员工绝对不会向你索取密码。如果有人这样做，那么他们是在企图盗取你的帐户。";

	/// <summary>
	/// Key: "Message.NoMessageExist"
	/// English String: "Message doesn't exist"
	/// </summary>
	public override string MessageNoMessageExist => "信息不存在";

	/// <summary>
	/// Key: "Message.NoNews"
	/// English String: "You have no news."
	/// </summary>
	public override string MessageNoNews => "你没有新闻。";

	/// <summary>
	/// Key: "Message.NoRecipient"
	/// English String: "Recipient doesn't exist!"
	/// </summary>
	public override string MessageNoRecipient => "收件人不存在！";

	/// <summary>
	/// Key: "Message.NotAuthorizeToManipulate"
	/// English String: "Not authorized to manipulate message"
	/// </summary>
	public override string MessageNotAuthorizeToManipulate => "无操控信息的权限";

	/// <summary>
	/// Key: "Message.NotSendAndModerated"
	/// English String: "Your message was not sent because it was moderated."
	/// </summary>
	public override string MessageNotSendAndModerated => "你的信息已被过滤，未能发送。";

	/// <summary>
	/// Key: "Message.RecipientPrivacySettingsTooHigh"
	/// English String: "The recipient's privacy settings prevent you from sending this message."
	/// </summary>
	public override string MessageRecipientPrivacySettingsTooHigh => "收件人的隐私设置阻止你发送此信息。";

	/// <summary>
	/// Key: "Message.ReplyHere"
	/// English String: "Reply here..."
	/// </summary>
	public override string MessageReplyHere => "在此回复...";

	/// <summary>
	/// Key: "Message.RobloxWarning"
	/// English String: "Remember, Roblox staff will never ask you for your password. People who ask for your password are trying to steal your account."
	/// </summary>
	public override string MessageRobloxWarning => "请记住，Roblox 员工绝对不会向你索取密码。如果有人这样做，那么他们是在企图盗取你的帐户。";

	/// <summary>
	/// Key: "Message.SendSuccessfully"
	/// English String: "Successfully sent message."
	/// </summary>
	public override string MessageSendSuccessfully => "信息已成功发送。";

	/// <summary>
	/// Key: "Message.SendTooManyMessages"
	/// English String: "You're sending too many messages too quickly."
	/// </summary>
	public override string MessageSendTooManyMessages => "你短时间内发送了过多信息。";

	/// <summary>
	/// Key: "Message.SubjectCantBlank"
	/// English String: "The message subject can't be blank."
	/// </summary>
	public override string MessageSubjectCantBlank => "信息主题不能为空。";

	/// <summary>
	/// Key: "Message.UnknownError"
	/// English String: "Unknown error"
	/// </summary>
	public override string MessageUnknownError => "未知错误";

	/// <summary>
	/// Key: "Message.UnknownMessageType"
	/// This serves as the fallback string for when an message type is received that the web chat does not know how to render.
	/// English String: "A message cannot be displayed"
	/// </summary>
	public override string MessageUnknownMessageType => "信息无法显示";

	/// <summary>
	/// Key: "Message.WriteYourMessage"
	/// English String: "Write your message..."
	/// </summary>
	public override string MessageWriteYourMessage => "编写你的信息...";

	public MessagesResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionArchive()
	{
		return "归档";
	}

	protected override string _GetTemplateForActionBack()
	{
		return "返回";
	}

	protected override string _GetTemplateForActionDiscard()
	{
		return "放弃";
	}

	protected override string _GetTemplateForActionMarkAsRead()
	{
		return "标记为已读";
	}

	protected override string _GetTemplateForActionMarkAsUnread()
	{
		return "标记为未读";
	}

	protected override string _GetTemplateForActionMoveToInbox()
	{
		return "移至收件箱";
	}

	protected override string _GetTemplateForActionReply()
	{
		return "回复";
	}

	protected override string _GetTemplateForActionReportAbuse()
	{
		return "报告滥用行为";
	}

	protected override string _GetTemplateForActionSend()
	{
		return "发送";
	}

	protected override string _GetTemplateForActionSendReply()
	{
		return "发送回复";
	}

	protected override string _GetTemplateForHeadingMessage()
	{
		return "信息";
	}

	protected override string _GetTemplateForHeadingNewMessages()
	{
		return "新信息";
	}

	protected override string _GetTemplateForHeadingResponse()
	{
		return "回复：";
	}

	protected override string _GetTemplateForLabelAll()
	{
		return "所有";
	}

	protected override string _GetTemplateForLabelArchive()
	{
		return "归档";
	}

	protected override string _GetTemplateForLabelInbox()
	{
		return "收件箱";
	}

	protected override string _GetTemplateForLabelIncludeMessage()
	{
		return "包含前一条信息";
	}

	protected override string _GetTemplateForLabelNews()
	{
		return "新闻";
	}

	/// <summary>
	/// Key: "Label.NoMessagesInCategory"
	/// English String: "You have no {activeTab} messages."
	/// </summary>
	public override string LabelNoMessagesInCategory(string activeTab)
	{
		return $"你没有{activeTab}信息。";
	}

	protected override string _GetTemplateForLabelNoMessagesInCategory()
	{
		return "你没有{activeTab}信息。";
	}

	protected override string _GetTemplateForLabelOf()
	{
		return "/";
	}

	protected override string _GetTemplateForLabelSelect()
	{
		return "选择...";
	}

	protected override string _GetTemplateForLabelSent()
	{
		return "已发送";
	}

	protected override string _GetTemplateForLabelSubject()
	{
		return "主题：";
	}

	protected override string _GetTemplateForLabelTo()
	{
		return "收件人：";
	}

	protected override string _GetTemplateForMessageBodyCantBlank()
	{
		return "信息正文不能为空。";
	}

	/// <summary>
	/// Key: "Message.BodyTooLong"
	/// English String: "Please shorten your message to {maxLength} characters or less and try again."
	/// </summary>
	public override string MessageBodyTooLong(string maxLength)
	{
		return $"请将你的信息缩短至 {maxLength} 个字符或以内，并重试。";
	}

	protected override string _GetTemplateForMessageBodyTooLong()
	{
		return "请将你的信息缩短至 {maxLength} 个字符或以内，并重试。";
	}

	protected override string _GetTemplateForMessageGeneralError()
	{
		return "抱歉，发送信息时发生错误。";
	}

	protected override string _GetTemplateForMessageIdTheftWarning()
	{
		return "请记住，Roblox 员工绝对不会向你索取密码。如果有人这样做，那么他们是在企图盗取你的帐户。";
	}

	protected override string _GetTemplateForMessageNoMessageExist()
	{
		return "信息不存在";
	}

	protected override string _GetTemplateForMessageNoNews()
	{
		return "你没有新闻。";
	}

	protected override string _GetTemplateForMessageNoRecipient()
	{
		return "收件人不存在！";
	}

	protected override string _GetTemplateForMessageNotAuthorizeToManipulate()
	{
		return "无操控信息的权限";
	}

	protected override string _GetTemplateForMessageNotSendAndModerated()
	{
		return "你的信息已被过滤，未能发送。";
	}

	protected override string _GetTemplateForMessageRecipientPrivacySettingsTooHigh()
	{
		return "收件人的隐私设置阻止你发送此信息。";
	}

	protected override string _GetTemplateForMessageReplyHere()
	{
		return "在此回复...";
	}

	protected override string _GetTemplateForMessageRobloxWarning()
	{
		return "请记住，Roblox 员工绝对不会向你索取密码。如果有人这样做，那么他们是在企图盗取你的帐户。";
	}

	/// <summary>
	/// Key: "Message.SenderPrivacySettingTooHeight"
	/// English String: "Your {frontLink}privacy settings{endLink} prevent you from sending this message."
	/// </summary>
	public override string MessageSenderPrivacySettingTooHeight(string frontLink, string endLink)
	{
		return $"你的{frontLink}隐私设置{endLink}阻止你发送此信息。";
	}

	protected override string _GetTemplateForMessageSenderPrivacySettingTooHeight()
	{
		return "你的{frontLink}隐私设置{endLink}阻止你发送此信息。";
	}

	protected override string _GetTemplateForMessageSendSuccessfully()
	{
		return "信息已成功发送。";
	}

	protected override string _GetTemplateForMessageSendTooManyMessages()
	{
		return "你短时间内发送了过多信息。";
	}

	protected override string _GetTemplateForMessageSubjectCantBlank()
	{
		return "信息主题不能为空。";
	}

	protected override string _GetTemplateForMessageUnknownError()
	{
		return "未知错误";
	}

	protected override string _GetTemplateForMessageUnknownMessageType()
	{
		return "信息无法显示";
	}

	/// <summary>
	/// Key: "Message.VerifySenderEmail"
	/// English String: "You must verify your email on the {frontLink}Account Settings{endLink} page before you can send messages."
	/// </summary>
	public override string MessageVerifySenderEmail(string frontLink, string endLink)
	{
		return $"你必须先在{frontLink}帐户设置{endLink}页面验证电子邮件，然后才能发送信息。";
	}

	protected override string _GetTemplateForMessageVerifySenderEmail()
	{
		return "你必须先在{frontLink}帐户设置{endLink}页面验证电子邮件，然后才能发送信息。";
	}

	protected override string _GetTemplateForMessageWriteYourMessage()
	{
		return "编写你的信息...";
	}
}
