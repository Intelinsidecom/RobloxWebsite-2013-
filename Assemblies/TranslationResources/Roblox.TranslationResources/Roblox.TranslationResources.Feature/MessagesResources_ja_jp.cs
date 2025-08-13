namespace Roblox.TranslationResources.Feature;

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
	public override string ActionArchive => "アーカイブ";

	/// <summary>
	/// Key: "Action.Back"
	/// English String: "Back"
	/// </summary>
	public override string ActionBack => "戻る";

	/// <summary>
	/// Key: "Action.Discard"
	/// English String: "Discard"
	/// </summary>
	public override string ActionDiscard => "破棄";

	/// <summary>
	/// Key: "Action.MarkAsRead"
	/// English String: "Mark As Read"
	/// </summary>
	public override string ActionMarkAsRead => "既読にする";

	/// <summary>
	/// Key: "Action.MarkAsUnread"
	/// English String: "Mark As Unread"
	/// </summary>
	public override string ActionMarkAsUnread => "未読にする";

	/// <summary>
	/// Key: "Action.MoveToInbox"
	/// English String: "Move To Inbox"
	/// </summary>
	public override string ActionMoveToInbox => "受信トレイに移動";

	/// <summary>
	/// Key: "Action.Reply"
	/// English String: "Reply"
	/// </summary>
	public override string ActionReply => "返信";

	/// <summary>
	/// Key: "Action.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string ActionReportAbuse => "規約違反を報告";

	/// <summary>
	/// Key: "Action.Send"
	/// English String: "Send"
	/// </summary>
	public override string ActionSend => "送信";

	/// <summary>
	/// Key: "Action.SendReply"
	/// English String: "Send Reply"
	/// </summary>
	public override string ActionSendReply => "返信";

	/// <summary>
	/// Key: "Heading.Message"
	/// English String: "Messages"
	/// </summary>
	public override string HeadingMessage => "メッセージ";

	/// <summary>
	/// Key: "Heading.NewMessages"
	/// English String: "New Message"
	/// </summary>
	public override string HeadingNewMessages => "新着メッセージ";

	/// <summary>
	/// Key: "Heading.Response"
	/// English String: "Responses:"
	/// </summary>
	public override string HeadingResponse => "返信:";

	/// <summary>
	/// Key: "Label.All"
	/// English String: "All"
	/// </summary>
	public override string LabelAll => "すべて";

	/// <summary>
	/// Key: "Label.Archive"
	/// English String: "Archive"
	/// </summary>
	public override string LabelArchive => "アーカイブ";

	/// <summary>
	/// Key: "Label.Inbox"
	/// English String: "Inbox"
	/// </summary>
	public override string LabelInbox => "受信トレイ";

	/// <summary>
	/// Key: "Label.IncludeMessage"
	/// English String: "Include Previous Message"
	/// </summary>
	public override string LabelIncludeMessage => "前のメッセージを含める";

	/// <summary>
	/// Key: "Label.News"
	/// English String: "News"
	/// </summary>
	public override string LabelNews => "ニュース";

	/// <summary>
	/// Key: "Label.Of"
	/// English String: "Of"
	/// </summary>
	public override string LabelOf => " /";

	/// <summary>
	/// Key: "Label.Select"
	/// English String: "Select..."
	/// </summary>
	public override string LabelSelect => "選択...";

	/// <summary>
	/// Key: "Label.Sent"
	/// English String: "Sent"
	/// </summary>
	public override string LabelSent => "送信済み";

	/// <summary>
	/// Key: "Label.Subject"
	/// English String: "Subject:"
	/// </summary>
	public override string LabelSubject => "件名:";

	/// <summary>
	/// Key: "Label.To"
	/// English String: "To:"
	/// </summary>
	public override string LabelTo => "宛先:";

	/// <summary>
	/// Key: "Message.BodyCantBlank"
	/// English String: "The message body can't be blank."
	/// </summary>
	public override string MessageBodyCantBlank => "メッセージ本文は空白にできません。";

	/// <summary>
	/// Key: "Message.GeneralError"
	/// English String: "Sorry, an error occurred sending your message."
	/// </summary>
	public override string MessageGeneralError => "申し訳ありませんが、メッセージ送信中にエラーが発生しました。";

	/// <summary>
	/// Key: "Message.IdTheftWarning"
	/// English String: "Remember, Roblox staff will never ask you for your password. People who ask for your password are trying to steal your account."
	/// </summary>
	public override string MessageIdTheftWarning => "Robloxのスタッフが、あなたのパスワードを聞くことはありません。パスワードを聞き出そうとする人は、アカウントを盗もうとしているのでご注意ください。";

	/// <summary>
	/// Key: "Message.NoMessageExist"
	/// English String: "Message doesn't exist"
	/// </summary>
	public override string MessageNoMessageExist => "メッセージが存在しません";

	/// <summary>
	/// Key: "Message.NoNews"
	/// English String: "You have no news."
	/// </summary>
	public override string MessageNoNews => "ニュースはありません。";

	/// <summary>
	/// Key: "Message.NoRecipient"
	/// English String: "Recipient doesn't exist!"
	/// </summary>
	public override string MessageNoRecipient => "送信先が存在しません！";

	/// <summary>
	/// Key: "Message.NotAuthorizeToManipulate"
	/// English String: "Not authorized to manipulate message"
	/// </summary>
	public override string MessageNotAuthorizeToManipulate => "メッセージを操作する権限がありません";

	/// <summary>
	/// Key: "Message.NotSendAndModerated"
	/// English String: "Your message was not sent because it was moderated."
	/// </summary>
	public override string MessageNotSendAndModerated => "メッセージは、規制により送信されませんでした。";

	/// <summary>
	/// Key: "Message.RecipientPrivacySettingsTooHigh"
	/// English String: "The recipient's privacy settings prevent you from sending this message."
	/// </summary>
	public override string MessageRecipientPrivacySettingsTooHigh => "受信者のプライバシー設定により、このメッセージを送信できません。";

	/// <summary>
	/// Key: "Message.ReplyHere"
	/// English String: "Reply here..."
	/// </summary>
	public override string MessageReplyHere => "返信はこちら...";

	/// <summary>
	/// Key: "Message.RobloxWarning"
	/// English String: "Remember, Roblox staff will never ask you for your password. People who ask for your password are trying to steal your account."
	/// </summary>
	public override string MessageRobloxWarning => "Robloxのスタッフが、あなたのパスワードを聞くことはありません。パスワードを聞き出そうとする人は、アカウントを盗もうとしているのでご注意ください。";

	/// <summary>
	/// Key: "Message.SendSuccessfully"
	/// English String: "Successfully sent message."
	/// </summary>
	public override string MessageSendSuccessfully => "メッセージを送信しました。";

	/// <summary>
	/// Key: "Message.SendTooManyMessages"
	/// English String: "You're sending too many messages too quickly."
	/// </summary>
	public override string MessageSendTooManyMessages => "頻繁にメッセージを送信しすぎています。";

	/// <summary>
	/// Key: "Message.SubjectCantBlank"
	/// English String: "The message subject can't be blank."
	/// </summary>
	public override string MessageSubjectCantBlank => "メッセージの件名は空白にできません。";

	/// <summary>
	/// Key: "Message.UnknownError"
	/// English String: "Unknown error"
	/// </summary>
	public override string MessageUnknownError => "不明なエラーが発生しました";

	/// <summary>
	/// Key: "Message.UnknownMessageType"
	/// This serves as the fallback string for when an message type is received that the web chat does not know how to render.
	/// English String: "A message cannot be displayed"
	/// </summary>
	public override string MessageUnknownMessageType => "メッセージを表示できません";

	/// <summary>
	/// Key: "Message.WriteYourMessage"
	/// English String: "Write your message..."
	/// </summary>
	public override string MessageWriteYourMessage => "メッセージを入力...";

	public MessagesResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionArchive()
	{
		return "アーカイブ";
	}

	protected override string _GetTemplateForActionBack()
	{
		return "戻る";
	}

	protected override string _GetTemplateForActionDiscard()
	{
		return "破棄";
	}

	protected override string _GetTemplateForActionMarkAsRead()
	{
		return "既読にする";
	}

	protected override string _GetTemplateForActionMarkAsUnread()
	{
		return "未読にする";
	}

	protected override string _GetTemplateForActionMoveToInbox()
	{
		return "受信トレイに移動";
	}

	protected override string _GetTemplateForActionReply()
	{
		return "返信";
	}

	protected override string _GetTemplateForActionReportAbuse()
	{
		return "規約違反を報告";
	}

	protected override string _GetTemplateForActionSend()
	{
		return "送信";
	}

	protected override string _GetTemplateForActionSendReply()
	{
		return "返信";
	}

	protected override string _GetTemplateForHeadingMessage()
	{
		return "メッセージ";
	}

	protected override string _GetTemplateForHeadingNewMessages()
	{
		return "新着メッセージ";
	}

	protected override string _GetTemplateForHeadingResponse()
	{
		return "返信:";
	}

	protected override string _GetTemplateForLabelAll()
	{
		return "すべて";
	}

	protected override string _GetTemplateForLabelArchive()
	{
		return "アーカイブ";
	}

	protected override string _GetTemplateForLabelInbox()
	{
		return "受信トレイ";
	}

	protected override string _GetTemplateForLabelIncludeMessage()
	{
		return "前のメッセージを含める";
	}

	protected override string _GetTemplateForLabelNews()
	{
		return "ニュース";
	}

	/// <summary>
	/// Key: "Label.NoMessagesInCategory"
	/// English String: "You have no {activeTab} messages."
	/// </summary>
	public override string LabelNoMessagesInCategory(string activeTab)
	{
		return $"{activeTab} のメッセージはありません。";
	}

	protected override string _GetTemplateForLabelNoMessagesInCategory()
	{
		return "{activeTab} のメッセージはありません。";
	}

	protected override string _GetTemplateForLabelOf()
	{
		return " /";
	}

	protected override string _GetTemplateForLabelSelect()
	{
		return "選択...";
	}

	protected override string _GetTemplateForLabelSent()
	{
		return "送信済み";
	}

	protected override string _GetTemplateForLabelSubject()
	{
		return "件名:";
	}

	protected override string _GetTemplateForLabelTo()
	{
		return "宛先:";
	}

	protected override string _GetTemplateForMessageBodyCantBlank()
	{
		return "メッセージ本文は空白にできません。";
	}

	/// <summary>
	/// Key: "Message.BodyTooLong"
	/// English String: "Please shorten your message to {maxLength} characters or less and try again."
	/// </summary>
	public override string MessageBodyTooLong(string maxLength)
	{
		return $"メッセージを {maxLength} 文字以下にして、やり直してください。";
	}

	protected override string _GetTemplateForMessageBodyTooLong()
	{
		return "メッセージを {maxLength} 文字以下にして、やり直してください。";
	}

	protected override string _GetTemplateForMessageGeneralError()
	{
		return "申し訳ありませんが、メッセージ送信中にエラーが発生しました。";
	}

	protected override string _GetTemplateForMessageIdTheftWarning()
	{
		return "Robloxのスタッフが、あなたのパスワードを聞くことはありません。パスワードを聞き出そうとする人は、アカウントを盗もうとしているのでご注意ください。";
	}

	protected override string _GetTemplateForMessageNoMessageExist()
	{
		return "メッセージが存在しません";
	}

	protected override string _GetTemplateForMessageNoNews()
	{
		return "ニュースはありません。";
	}

	protected override string _GetTemplateForMessageNoRecipient()
	{
		return "送信先が存在しません！";
	}

	protected override string _GetTemplateForMessageNotAuthorizeToManipulate()
	{
		return "メッセージを操作する権限がありません";
	}

	protected override string _GetTemplateForMessageNotSendAndModerated()
	{
		return "メッセージは、規制により送信されませんでした。";
	}

	protected override string _GetTemplateForMessageRecipientPrivacySettingsTooHigh()
	{
		return "受信者のプライバシー設定により、このメッセージを送信できません。";
	}

	protected override string _GetTemplateForMessageReplyHere()
	{
		return "返信はこちら...";
	}

	protected override string _GetTemplateForMessageRobloxWarning()
	{
		return "Robloxのスタッフが、あなたのパスワードを聞くことはありません。パスワードを聞き出そうとする人は、アカウントを盗もうとしているのでご注意ください。";
	}

	/// <summary>
	/// Key: "Message.SenderPrivacySettingTooHeight"
	/// English String: "Your {frontLink}privacy settings{endLink} prevent you from sending this message."
	/// </summary>
	public override string MessageSenderPrivacySettingTooHeight(string frontLink, string endLink)
	{
		return $"あなたの{frontLink}プライバシー設定{endLink}により、このメッセージを送信できません。";
	}

	protected override string _GetTemplateForMessageSenderPrivacySettingTooHeight()
	{
		return "あなたの{frontLink}プライバシー設定{endLink}により、このメッセージを送信できません。";
	}

	protected override string _GetTemplateForMessageSendSuccessfully()
	{
		return "メッセージを送信しました。";
	}

	protected override string _GetTemplateForMessageSendTooManyMessages()
	{
		return "頻繁にメッセージを送信しすぎています。";
	}

	protected override string _GetTemplateForMessageSubjectCantBlank()
	{
		return "メッセージの件名は空白にできません。";
	}

	protected override string _GetTemplateForMessageUnknownError()
	{
		return "不明なエラーが発生しました";
	}

	protected override string _GetTemplateForMessageUnknownMessageType()
	{
		return "メッセージを表示できません";
	}

	/// <summary>
	/// Key: "Message.VerifySenderEmail"
	/// English String: "You must verify your email on the {frontLink}Account Settings{endLink} page before you can send messages."
	/// </summary>
	public override string MessageVerifySenderEmail(string frontLink, string endLink)
	{
		return $"メッセージを送信する前に、{frontLink}アカウント設定{endLink}ページでメールアドレスの認証を行う必要があります。";
	}

	protected override string _GetTemplateForMessageVerifySenderEmail()
	{
		return "メッセージを送信する前に、{frontLink}アカウント設定{endLink}ページでメールアドレスの認証を行う必要があります。";
	}

	protected override string _GetTemplateForMessageWriteYourMessage()
	{
		return "メッセージを入力...";
	}
}
