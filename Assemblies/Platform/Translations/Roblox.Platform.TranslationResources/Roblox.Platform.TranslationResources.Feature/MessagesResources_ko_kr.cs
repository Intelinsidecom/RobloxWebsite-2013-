namespace Roblox.TranslationResources.Feature;

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
	public override string ActionArchive => "보관";

	/// <summary>
	/// Key: "Action.Back"
	/// English String: "Back"
	/// </summary>
	public override string ActionBack => "뒤로";

	/// <summary>
	/// Key: "Action.Discard"
	/// English String: "Discard"
	/// </summary>
	public override string ActionDiscard => "취소";

	/// <summary>
	/// Key: "Action.MarkAsRead"
	/// English String: "Mark As Read"
	/// </summary>
	public override string ActionMarkAsRead => "읽음으로 표시";

	/// <summary>
	/// Key: "Action.MarkAsUnread"
	/// English String: "Mark As Unread"
	/// </summary>
	public override string ActionMarkAsUnread => "읽지 않음으로 표시";

	/// <summary>
	/// Key: "Action.MoveToInbox"
	/// English String: "Move To Inbox"
	/// </summary>
	public override string ActionMoveToInbox => "수신함으로 이동";

	/// <summary>
	/// Key: "Action.Reply"
	/// English String: "Reply"
	/// </summary>
	public override string ActionReply => "답변";

	/// <summary>
	/// Key: "Action.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string ActionReportAbuse => "신고하기";

	/// <summary>
	/// Key: "Action.Send"
	/// English String: "Send"
	/// </summary>
	public override string ActionSend => "보내기";

	/// <summary>
	/// Key: "Action.SendReply"
	/// English String: "Send Reply"
	/// </summary>
	public override string ActionSendReply => "답변 보내기";

	/// <summary>
	/// Key: "Heading.Message"
	/// English String: "Messages"
	/// </summary>
	public override string HeadingMessage => "메시지";

	/// <summary>
	/// Key: "Heading.NewMessages"
	/// English String: "New Message"
	/// </summary>
	public override string HeadingNewMessages => "새 메시지";

	/// <summary>
	/// Key: "Heading.Response"
	/// English String: "Responses:"
	/// </summary>
	public override string HeadingResponse => "응답:";

	/// <summary>
	/// Key: "Label.All"
	/// English String: "All"
	/// </summary>
	public override string LabelAll => "전체";

	/// <summary>
	/// Key: "Label.Archive"
	/// English String: "Archive"
	/// </summary>
	public override string LabelArchive => "보관함";

	/// <summary>
	/// Key: "Label.Inbox"
	/// English String: "Inbox"
	/// </summary>
	public override string LabelInbox => "수신함";

	/// <summary>
	/// Key: "Label.IncludeMessage"
	/// English String: "Include Previous Message"
	/// </summary>
	public override string LabelIncludeMessage => "이전 메시지 포함";

	/// <summary>
	/// Key: "Label.News"
	/// English String: "News"
	/// </summary>
	public override string LabelNews => "새소식";

	/// <summary>
	/// Key: "Label.Of"
	/// English String: "Of"
	/// </summary>
	public override string LabelOf => "/";

	/// <summary>
	/// Key: "Label.Select"
	/// English String: "Select..."
	/// </summary>
	public override string LabelSelect => "선택...";

	/// <summary>
	/// Key: "Label.Sent"
	/// English String: "Sent"
	/// </summary>
	public override string LabelSent => "발신함";

	/// <summary>
	/// Key: "Label.Subject"
	/// English String: "Subject:"
	/// </summary>
	public override string LabelSubject => "제목:";

	/// <summary>
	/// Key: "Label.To"
	/// English String: "To:"
	/// </summary>
	public override string LabelTo => "수신자:";

	/// <summary>
	/// Key: "Message.BodyCantBlank"
	/// English String: "The message body can't be blank."
	/// </summary>
	public override string MessageBodyCantBlank => "메시지 내용을 입력하셔야 합니다.";

	/// <summary>
	/// Key: "Message.GeneralError"
	/// English String: "Sorry, an error occurred sending your message."
	/// </summary>
	public override string MessageGeneralError => "죄송합니다. 메시지를 전송 중 오류가 발생했어요.";

	/// <summary>
	/// Key: "Message.IdTheftWarning"
	/// English String: "Remember, Roblox staff will never ask you for your password. People who ask for your password are trying to steal your account."
	/// </summary>
	public override string MessageIdTheftWarning => "Roblox는 절대 비밀번호를 물어보지 않습니다. 비밀번호를 요구하는 행위는 계정을 도용하려는 시도라는 사실, 잊지마세요.";

	/// <summary>
	/// Key: "Message.NoMessageExist"
	/// English String: "Message doesn't exist"
	/// </summary>
	public override string MessageNoMessageExist => "메시지가 없어요";

	/// <summary>
	/// Key: "Message.NoNews"
	/// English String: "You have no news."
	/// </summary>
	public override string MessageNoNews => "새소식이 없어요.";

	/// <summary>
	/// Key: "Message.NoRecipient"
	/// English String: "Recipient doesn't exist!"
	/// </summary>
	public override string MessageNoRecipient => "수신자가 없어요!";

	/// <summary>
	/// Key: "Message.NotAuthorizeToManipulate"
	/// English String: "Not authorized to manipulate message"
	/// </summary>
	public override string MessageNotAuthorizeToManipulate => "메시지를 조작할 권한 없음";

	/// <summary>
	/// Key: "Message.NotSendAndModerated"
	/// English String: "Your message was not sent because it was moderated."
	/// </summary>
	public override string MessageNotSendAndModerated => "메시지가 검열을 통과하지 못해 전송되지 않았어요.";

	/// <summary>
	/// Key: "Message.RecipientPrivacySettingsTooHigh"
	/// English String: "The recipient's privacy settings prevent you from sending this message."
	/// </summary>
	public override string MessageRecipientPrivacySettingsTooHigh => "수신자의 개인정보 설정 때문에 본 메시지를 보낼 수 없어요.";

	/// <summary>
	/// Key: "Message.ReplyHere"
	/// English String: "Reply here..."
	/// </summary>
	public override string MessageReplyHere => "답변 작성...";

	/// <summary>
	/// Key: "Message.RobloxWarning"
	/// English String: "Remember, Roblox staff will never ask you for your password. People who ask for your password are trying to steal your account."
	/// </summary>
	public override string MessageRobloxWarning => "Roblox는 절대 비밀번호를 물어보지 않습니다. 비밀번호를 물어보는 행위는 계정을 도용하려는 시도라는 사실, 잊지마세요.";

	/// <summary>
	/// Key: "Message.SendSuccessfully"
	/// English String: "Successfully sent message."
	/// </summary>
	public override string MessageSendSuccessfully => "메시지 전송 완료.";

	/// <summary>
	/// Key: "Message.SendTooManyMessages"
	/// English String: "You're sending too many messages too quickly."
	/// </summary>
	public override string MessageSendTooManyMessages => "짧은 시간 안에 너무 많은 메시지를 보내고 있습니다.";

	/// <summary>
	/// Key: "Message.SubjectCantBlank"
	/// English String: "The message subject can't be blank."
	/// </summary>
	public override string MessageSubjectCantBlank => "메시지 제목을 입력하셔야 합니다.";

	/// <summary>
	/// Key: "Message.UnknownError"
	/// English String: "Unknown error"
	/// </summary>
	public override string MessageUnknownError => "알 수 없는 오류";

	/// <summary>
	/// Key: "Message.UnknownMessageType"
	/// This serves as the fallback string for when an message type is received that the web chat does not know how to render.
	/// English String: "A message cannot be displayed"
	/// </summary>
	public override string MessageUnknownMessageType => "메시지를 표시할 수 없음";

	/// <summary>
	/// Key: "Message.WriteYourMessage"
	/// English String: "Write your message..."
	/// </summary>
	public override string MessageWriteYourMessage => "메시지를 작성하세요...";

	public MessagesResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionArchive()
	{
		return "보관";
	}

	protected override string _GetTemplateForActionBack()
	{
		return "뒤로";
	}

	protected override string _GetTemplateForActionDiscard()
	{
		return "취소";
	}

	protected override string _GetTemplateForActionMarkAsRead()
	{
		return "읽음으로 표시";
	}

	protected override string _GetTemplateForActionMarkAsUnread()
	{
		return "읽지 않음으로 표시";
	}

	protected override string _GetTemplateForActionMoveToInbox()
	{
		return "수신함으로 이동";
	}

	protected override string _GetTemplateForActionReply()
	{
		return "답변";
	}

	protected override string _GetTemplateForActionReportAbuse()
	{
		return "신고하기";
	}

	protected override string _GetTemplateForActionSend()
	{
		return "보내기";
	}

	protected override string _GetTemplateForActionSendReply()
	{
		return "답변 보내기";
	}

	protected override string _GetTemplateForHeadingMessage()
	{
		return "메시지";
	}

	protected override string _GetTemplateForHeadingNewMessages()
	{
		return "새 메시지";
	}

	protected override string _GetTemplateForHeadingResponse()
	{
		return "응답:";
	}

	protected override string _GetTemplateForLabelAll()
	{
		return "전체";
	}

	protected override string _GetTemplateForLabelArchive()
	{
		return "보관함";
	}

	protected override string _GetTemplateForLabelInbox()
	{
		return "수신함";
	}

	protected override string _GetTemplateForLabelIncludeMessage()
	{
		return "이전 메시지 포함";
	}

	protected override string _GetTemplateForLabelNews()
	{
		return "새소식";
	}

	/// <summary>
	/// Key: "Label.NoMessagesInCategory"
	/// English String: "You have no {activeTab} messages."
	/// </summary>
	public override string LabelNoMessagesInCategory(string activeTab)
	{
		return $"{activeTab} 메시지가 없어요.";
	}

	protected override string _GetTemplateForLabelNoMessagesInCategory()
	{
		return "{activeTab} 메시지가 없어요.";
	}

	protected override string _GetTemplateForLabelOf()
	{
		return "/";
	}

	protected override string _GetTemplateForLabelSelect()
	{
		return "선택...";
	}

	protected override string _GetTemplateForLabelSent()
	{
		return "발신함";
	}

	protected override string _GetTemplateForLabelSubject()
	{
		return "제목:";
	}

	protected override string _GetTemplateForLabelTo()
	{
		return "수신자:";
	}

	protected override string _GetTemplateForMessageBodyCantBlank()
	{
		return "메시지 내용을 입력하셔야 합니다.";
	}

	/// <summary>
	/// Key: "Message.BodyTooLong"
	/// English String: "Please shorten your message to {maxLength} characters or less and try again."
	/// </summary>
	public override string MessageBodyTooLong(string maxLength)
	{
		return $"메시지 내용을 {maxLength}자 이하로 줄인 다음 다시 시도하세요.";
	}

	protected override string _GetTemplateForMessageBodyTooLong()
	{
		return "메시지 내용을 {maxLength}자 이하로 줄인 다음 다시 시도하세요.";
	}

	protected override string _GetTemplateForMessageGeneralError()
	{
		return "죄송합니다. 메시지를 전송 중 오류가 발생했어요.";
	}

	protected override string _GetTemplateForMessageIdTheftWarning()
	{
		return "Roblox는 절대 비밀번호를 물어보지 않습니다. 비밀번호를 요구하는 행위는 계정을 도용하려는 시도라는 사실, 잊지마세요.";
	}

	protected override string _GetTemplateForMessageNoMessageExist()
	{
		return "메시지가 없어요";
	}

	protected override string _GetTemplateForMessageNoNews()
	{
		return "새소식이 없어요.";
	}

	protected override string _GetTemplateForMessageNoRecipient()
	{
		return "수신자가 없어요!";
	}

	protected override string _GetTemplateForMessageNotAuthorizeToManipulate()
	{
		return "메시지를 조작할 권한 없음";
	}

	protected override string _GetTemplateForMessageNotSendAndModerated()
	{
		return "메시지가 검열을 통과하지 못해 전송되지 않았어요.";
	}

	protected override string _GetTemplateForMessageRecipientPrivacySettingsTooHigh()
	{
		return "수신자의 개인정보 설정 때문에 본 메시지를 보낼 수 없어요.";
	}

	protected override string _GetTemplateForMessageReplyHere()
	{
		return "답변 작성...";
	}

	protected override string _GetTemplateForMessageRobloxWarning()
	{
		return "Roblox는 절대 비밀번호를 물어보지 않습니다. 비밀번호를 물어보는 행위는 계정을 도용하려는 시도라는 사실, 잊지마세요.";
	}

	/// <summary>
	/// Key: "Message.SenderPrivacySettingTooHeight"
	/// English String: "Your {frontLink}privacy settings{endLink} prevent you from sending this message."
	/// </summary>
	public override string MessageSenderPrivacySettingTooHeight(string frontLink, string endLink)
	{
		return $"회원님의 {frontLink}개인정보 설정{endLink} 때문에 본 메시지를 보낼 수 없어요.";
	}

	protected override string _GetTemplateForMessageSenderPrivacySettingTooHeight()
	{
		return "회원님의 {frontLink}개인정보 설정{endLink} 때문에 본 메시지를 보낼 수 없어요.";
	}

	protected override string _GetTemplateForMessageSendSuccessfully()
	{
		return "메시지 전송 완료.";
	}

	protected override string _GetTemplateForMessageSendTooManyMessages()
	{
		return "짧은 시간 안에 너무 많은 메시지를 보내고 있습니다.";
	}

	protected override string _GetTemplateForMessageSubjectCantBlank()
	{
		return "메시지 제목을 입력하셔야 합니다.";
	}

	protected override string _GetTemplateForMessageUnknownError()
	{
		return "알 수 없는 오류";
	}

	protected override string _GetTemplateForMessageUnknownMessageType()
	{
		return "메시지를 표시할 수 없음";
	}

	/// <summary>
	/// Key: "Message.VerifySenderEmail"
	/// English String: "You must verify your email on the {frontLink}Account Settings{endLink} page before you can send messages."
	/// </summary>
	public override string MessageVerifySenderEmail(string frontLink, string endLink)
	{
		return $"메시지를 보내려면 {frontLink}계정 설정{endLink} 페이지에서 이메일 인증을 완료하세요.";
	}

	protected override string _GetTemplateForMessageVerifySenderEmail()
	{
		return "메시지를 보내려면 {frontLink}계정 설정{endLink} 페이지에서 이메일 인증을 완료하세요.";
	}

	protected override string _GetTemplateForMessageWriteYourMessage()
	{
		return "메시지를 작성하세요...";
	}
}
