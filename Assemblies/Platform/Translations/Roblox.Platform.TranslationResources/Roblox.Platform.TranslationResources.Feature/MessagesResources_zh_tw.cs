namespace Roblox.TranslationResources.Feature;

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
	public override string ActionArchive => "封存";

	/// <summary>
	/// Key: "Action.Back"
	/// English String: "Back"
	/// </summary>
	public override string ActionBack => "返回";

	/// <summary>
	/// Key: "Action.Discard"
	/// English String: "Discard"
	/// </summary>
	public override string ActionDiscard => "捨棄";

	/// <summary>
	/// Key: "Action.MarkAsRead"
	/// English String: "Mark As Read"
	/// </summary>
	public override string ActionMarkAsRead => "標為已讀";

	/// <summary>
	/// Key: "Action.MarkAsUnread"
	/// English String: "Mark As Unread"
	/// </summary>
	public override string ActionMarkAsUnread => "標為未讀";

	/// <summary>
	/// Key: "Action.MoveToInbox"
	/// English String: "Move To Inbox"
	/// </summary>
	public override string ActionMoveToInbox => "移到收件箱";

	/// <summary>
	/// Key: "Action.Reply"
	/// English String: "Reply"
	/// </summary>
	public override string ActionReply => "回覆";

	/// <summary>
	/// Key: "Action.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string ActionReportAbuse => "檢舉濫用";

	/// <summary>
	/// Key: "Action.Send"
	/// English String: "Send"
	/// </summary>
	public override string ActionSend => "傳送";

	/// <summary>
	/// Key: "Action.SendReply"
	/// English String: "Send Reply"
	/// </summary>
	public override string ActionSendReply => "傳送回覆";

	/// <summary>
	/// Key: "Heading.Message"
	/// English String: "Messages"
	/// </summary>
	public override string HeadingMessage => "訊息";

	/// <summary>
	/// Key: "Heading.NewMessages"
	/// English String: "New Message"
	/// </summary>
	public override string HeadingNewMessages => "新訊息";

	/// <summary>
	/// Key: "Heading.Response"
	/// English String: "Responses:"
	/// </summary>
	public override string HeadingResponse => "回覆：";

	/// <summary>
	/// Key: "Label.All"
	/// English String: "All"
	/// </summary>
	public override string LabelAll => "全部";

	/// <summary>
	/// Key: "Label.Archive"
	/// English String: "Archive"
	/// </summary>
	public override string LabelArchive => "封存";

	/// <summary>
	/// Key: "Label.Inbox"
	/// English String: "Inbox"
	/// </summary>
	public override string LabelInbox => "收件箱";

	/// <summary>
	/// Key: "Label.IncludeMessage"
	/// English String: "Include Previous Message"
	/// </summary>
	public override string LabelIncludeMessage => "包括前一則訊息";

	/// <summary>
	/// Key: "Label.News"
	/// English String: "News"
	/// </summary>
	public override string LabelNews => "消息";

	/// <summary>
	/// Key: "Label.Of"
	/// English String: "Of"
	/// </summary>
	public override string LabelOf => "/";

	/// <summary>
	/// Key: "Label.Select"
	/// English String: "Select..."
	/// </summary>
	public override string LabelSelect => "選擇…";

	/// <summary>
	/// Key: "Label.Sent"
	/// English String: "Sent"
	/// </summary>
	public override string LabelSent => "已傳送";

	/// <summary>
	/// Key: "Label.Subject"
	/// English String: "Subject:"
	/// </summary>
	public override string LabelSubject => "主旨：";

	/// <summary>
	/// Key: "Label.To"
	/// English String: "To:"
	/// </summary>
	public override string LabelTo => "收件人：";

	/// <summary>
	/// Key: "Message.BodyCantBlank"
	/// English String: "The message body can't be blank."
	/// </summary>
	public override string MessageBodyCantBlank => "訊息內文不可空白。";

	/// <summary>
	/// Key: "Message.GeneralError"
	/// English String: "Sorry, an error occurred sending your message."
	/// </summary>
	public override string MessageGeneralError => "對不起，傳送您的訊息時發生錯誤。";

	/// <summary>
	/// Key: "Message.IdTheftWarning"
	/// English String: "Remember, Roblox staff will never ask you for your password. People who ask for your password are trying to steal your account."
	/// </summary>
	public override string MessageIdTheftWarning => "請記住，Roblox 員工絕對不會向您詢問您的密碼。若有人詢問您的密碼，他們是在企圖盜取您的帳號。";

	/// <summary>
	/// Key: "Message.NoMessageExist"
	/// English String: "Message doesn't exist"
	/// </summary>
	public override string MessageNoMessageExist => "訊息不存在";

	/// <summary>
	/// Key: "Message.NoNews"
	/// English String: "You have no news."
	/// </summary>
	public override string MessageNoNews => "您沒有消息。";

	/// <summary>
	/// Key: "Message.NoRecipient"
	/// English String: "Recipient doesn't exist!"
	/// </summary>
	public override string MessageNoRecipient => "收件人不存在！";

	/// <summary>
	/// Key: "Message.NotAuthorizeToManipulate"
	/// English String: "Not authorized to manipulate message"
	/// </summary>
	public override string MessageNotAuthorizeToManipulate => "權限不足，無法操作訊息";

	/// <summary>
	/// Key: "Message.NotSendAndModerated"
	/// English String: "Your message was not sent because it was moderated."
	/// </summary>
	public override string MessageNotSendAndModerated => "您的訊息遭到過濾而未送出。";

	/// <summary>
	/// Key: "Message.RecipientPrivacySettingsTooHigh"
	/// English String: "The recipient's privacy settings prevent you from sending this message."
	/// </summary>
	public override string MessageRecipientPrivacySettingsTooHigh => "因收件人的隱私權設定，您無法傳送此訊息。";

	/// <summary>
	/// Key: "Message.ReplyHere"
	/// English String: "Reply here..."
	/// </summary>
	public override string MessageReplyHere => "在此處回覆…";

	/// <summary>
	/// Key: "Message.RobloxWarning"
	/// English String: "Remember, Roblox staff will never ask you for your password. People who ask for your password are trying to steal your account."
	/// </summary>
	public override string MessageRobloxWarning => "請記住，Roblox 員工絕對不會向您詢問您的密碼。若有人詢問您的密碼，他們是在企圖盜取您的帳號。";

	/// <summary>
	/// Key: "Message.SendSuccessfully"
	/// English String: "Successfully sent message."
	/// </summary>
	public override string MessageSendSuccessfully => "已成功傳送訊息。";

	/// <summary>
	/// Key: "Message.SendTooManyMessages"
	/// English String: "You're sending too many messages too quickly."
	/// </summary>
	public override string MessageSendTooManyMessages => "您傳送訊息頻率過高。";

	/// <summary>
	/// Key: "Message.SubjectCantBlank"
	/// English String: "The message subject can't be blank."
	/// </summary>
	public override string MessageSubjectCantBlank => "訊息主旨不可空白。";

	/// <summary>
	/// Key: "Message.UnknownError"
	/// English String: "Unknown error"
	/// </summary>
	public override string MessageUnknownError => "未知錯誤";

	/// <summary>
	/// Key: "Message.UnknownMessageType"
	/// This serves as the fallback string for when an message type is received that the web chat does not know how to render.
	/// English String: "A message cannot be displayed"
	/// </summary>
	public override string MessageUnknownMessageType => "無法顯示訊息";

	/// <summary>
	/// Key: "Message.WriteYourMessage"
	/// English String: "Write your message..."
	/// </summary>
	public override string MessageWriteYourMessage => "寫下您的訊息…";

	public MessagesResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionArchive()
	{
		return "封存";
	}

	protected override string _GetTemplateForActionBack()
	{
		return "返回";
	}

	protected override string _GetTemplateForActionDiscard()
	{
		return "捨棄";
	}

	protected override string _GetTemplateForActionMarkAsRead()
	{
		return "標為已讀";
	}

	protected override string _GetTemplateForActionMarkAsUnread()
	{
		return "標為未讀";
	}

	protected override string _GetTemplateForActionMoveToInbox()
	{
		return "移到收件箱";
	}

	protected override string _GetTemplateForActionReply()
	{
		return "回覆";
	}

	protected override string _GetTemplateForActionReportAbuse()
	{
		return "檢舉濫用";
	}

	protected override string _GetTemplateForActionSend()
	{
		return "傳送";
	}

	protected override string _GetTemplateForActionSendReply()
	{
		return "傳送回覆";
	}

	protected override string _GetTemplateForHeadingMessage()
	{
		return "訊息";
	}

	protected override string _GetTemplateForHeadingNewMessages()
	{
		return "新訊息";
	}

	protected override string _GetTemplateForHeadingResponse()
	{
		return "回覆：";
	}

	protected override string _GetTemplateForLabelAll()
	{
		return "全部";
	}

	protected override string _GetTemplateForLabelArchive()
	{
		return "封存";
	}

	protected override string _GetTemplateForLabelInbox()
	{
		return "收件箱";
	}

	protected override string _GetTemplateForLabelIncludeMessage()
	{
		return "包括前一則訊息";
	}

	protected override string _GetTemplateForLabelNews()
	{
		return "消息";
	}

	/// <summary>
	/// Key: "Label.NoMessagesInCategory"
	/// English String: "You have no {activeTab} messages."
	/// </summary>
	public override string LabelNoMessagesInCategory(string activeTab)
	{
		return $"您沒有{activeTab}的訊息。";
	}

	protected override string _GetTemplateForLabelNoMessagesInCategory()
	{
		return "您沒有{activeTab}的訊息。";
	}

	protected override string _GetTemplateForLabelOf()
	{
		return "/";
	}

	protected override string _GetTemplateForLabelSelect()
	{
		return "選擇…";
	}

	protected override string _GetTemplateForLabelSent()
	{
		return "已傳送";
	}

	protected override string _GetTemplateForLabelSubject()
	{
		return "主旨：";
	}

	protected override string _GetTemplateForLabelTo()
	{
		return "收件人：";
	}

	protected override string _GetTemplateForMessageBodyCantBlank()
	{
		return "訊息內文不可空白。";
	}

	/// <summary>
	/// Key: "Message.BodyTooLong"
	/// English String: "Please shorten your message to {maxLength} characters or less and try again."
	/// </summary>
	public override string MessageBodyTooLong(string maxLength)
	{
		return $"請將訊息縮短為 {maxLength} 個字元或更少，然後重新嘗試。";
	}

	protected override string _GetTemplateForMessageBodyTooLong()
	{
		return "請將訊息縮短為 {maxLength} 個字元或更少，然後重新嘗試。";
	}

	protected override string _GetTemplateForMessageGeneralError()
	{
		return "對不起，傳送您的訊息時發生錯誤。";
	}

	protected override string _GetTemplateForMessageIdTheftWarning()
	{
		return "請記住，Roblox 員工絕對不會向您詢問您的密碼。若有人詢問您的密碼，他們是在企圖盜取您的帳號。";
	}

	protected override string _GetTemplateForMessageNoMessageExist()
	{
		return "訊息不存在";
	}

	protected override string _GetTemplateForMessageNoNews()
	{
		return "您沒有消息。";
	}

	protected override string _GetTemplateForMessageNoRecipient()
	{
		return "收件人不存在！";
	}

	protected override string _GetTemplateForMessageNotAuthorizeToManipulate()
	{
		return "權限不足，無法操作訊息";
	}

	protected override string _GetTemplateForMessageNotSendAndModerated()
	{
		return "您的訊息遭到過濾而未送出。";
	}

	protected override string _GetTemplateForMessageRecipientPrivacySettingsTooHigh()
	{
		return "因收件人的隱私權設定，您無法傳送此訊息。";
	}

	protected override string _GetTemplateForMessageReplyHere()
	{
		return "在此處回覆…";
	}

	protected override string _GetTemplateForMessageRobloxWarning()
	{
		return "請記住，Roblox 員工絕對不會向您詢問您的密碼。若有人詢問您的密碼，他們是在企圖盜取您的帳號。";
	}

	/// <summary>
	/// Key: "Message.SenderPrivacySettingTooHeight"
	/// English String: "Your {frontLink}privacy settings{endLink} prevent you from sending this message."
	/// </summary>
	public override string MessageSenderPrivacySettingTooHeight(string frontLink, string endLink)
	{
		return $"您的{frontLink}隱私權設定{endLink}禁止您傳送此訊息。";
	}

	protected override string _GetTemplateForMessageSenderPrivacySettingTooHeight()
	{
		return "您的{frontLink}隱私權設定{endLink}禁止您傳送此訊息。";
	}

	protected override string _GetTemplateForMessageSendSuccessfully()
	{
		return "已成功傳送訊息。";
	}

	protected override string _GetTemplateForMessageSendTooManyMessages()
	{
		return "您傳送訊息頻率過高。";
	}

	protected override string _GetTemplateForMessageSubjectCantBlank()
	{
		return "訊息主旨不可空白。";
	}

	protected override string _GetTemplateForMessageUnknownError()
	{
		return "未知錯誤";
	}

	protected override string _GetTemplateForMessageUnknownMessageType()
	{
		return "無法顯示訊息";
	}

	/// <summary>
	/// Key: "Message.VerifySenderEmail"
	/// English String: "You must verify your email on the {frontLink}Account Settings{endLink} page before you can send messages."
	/// </summary>
	public override string MessageVerifySenderEmail(string frontLink, string endLink)
	{
		return $"若要傳送訊息，請先在{frontLink}帳號設定{endLink}頁面驗證電子郵件地址。";
	}

	protected override string _GetTemplateForMessageVerifySenderEmail()
	{
		return "若要傳送訊息，請先在{frontLink}帳號設定{endLink}頁面驗證電子郵件地址。";
	}

	protected override string _GetTemplateForMessageWriteYourMessage()
	{
		return "寫下您的訊息…";
	}
}
