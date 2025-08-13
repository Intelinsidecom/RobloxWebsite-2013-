namespace Roblox.TranslationResources.Notifications;

/// <summary>
/// This class overrides DesktopPushNotificationPromptsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class DesktopPushNotificationPromptsResources_ja_jp : DesktopPushNotificationPromptsResources_en_us, IDesktopPushNotificationPromptsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AcceptNotificationPrompt"
	/// Notify Me
	/// English String: "Notify Me"
	/// </summary>
	public override string ActionAcceptNotificationPrompt => "通知する";

	/// <summary>
	/// Key: "Action.Close"
	/// Close
	/// English String: "Close"
	/// </summary>
	public override string ActionClose => "閉じる";

	/// <summary>
	/// Key: "Heading.TurnNotificationsBackOn"
	/// Turn Push Notifications Back On
	/// English String: "Turn Push Notifications Back On"
	/// </summary>
	public override string HeadingTurnNotificationsBackOn => "プッシュ通知をオンに戻す";

	/// <summary>
	/// Key: "Heading.TurnNotificationsOn"
	/// Enable Desktop Push Notifications
	/// English String: "Enable Desktop Push Notifications"
	/// </summary>
	public override string HeadingTurnNotificationsOn => "デスクトッププッシュ通知を有効にする";

	/// <summary>
	/// Key: "Label.ClickGreenLockOnUrl"
	/// Click the green lock next to the URL bar to open up your site permissions.
	/// English String: "Click the green lock next to the URL bar to open up your site permissions."
	/// </summary>
	public override string LabelClickGreenLockOnUrl => "URLバーの横にある緑色のカギをクリックして、サイトの許可を開きます。";

	/// <summary>
	/// Key: "Message.PushNotificationsDisabledSuccess"
	/// Push notifications have been disabled.
	/// English String: "Push notifications have been disabled."
	/// </summary>
	public override string MessagePushNotificationsDisabledSuccess => "プッシュ通知が無効になりました！";

	/// <summary>
	/// Key: "Message.PushNotificationsEnabledSuccess"
	/// Push notifications have been enabled!
	/// English String: "Push notifications have been enabled!"
	/// </summary>
	public override string MessagePushNotificationsEnabledSuccess => "プッシュ通知が有効になりました！";

	/// <summary>
	/// Key: "Message.SendNotificationsPrompt"
	/// Can we send you notifications on this computer?
	/// English String: "Can we send you notifications on this computer?"
	/// </summary>
	public override string MessageSendNotificationsPrompt => "このパソコンで通知を受け取りますか。";

	public DesktopPushNotificationPromptsResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAcceptNotificationPrompt()
	{
		return "通知する";
	}

	protected override string _GetTemplateForActionClose()
	{
		return "閉じる";
	}

	protected override string _GetTemplateForHeadingTurnNotificationsBackOn()
	{
		return "プッシュ通知をオンに戻す";
	}

	protected override string _GetTemplateForHeadingTurnNotificationsOn()
	{
		return "デスクトッププッシュ通知を有効にする";
	}

	protected override string _GetTemplateForLabelClickGreenLockOnUrl()
	{
		return "URLバーの横にある緑色のカギをクリックして、サイトの許可を開きます。";
	}

	/// <summary>
	/// Key: "Label.InstructionAllowNotificationsBackOn"
	/// Select {startBold}Allow{endBold} to turn notifications back on.
	/// English String: "Select {startBold}Allow{endBold} to turn notifications back on."
	/// </summary>
	public override string LabelInstructionAllowNotificationsBackOn(string startBold, string endBold)
	{
		return $"通知をオンに戻すには、「{startBold}許可{endBold}」を選択してください。";
	}

	protected override string _GetTemplateForLabelInstructionAllowNotificationsBackOn()
	{
		return "通知をオンに戻すには、「{startBold}許可{endBold}」を選択してください。";
	}

	/// <summary>
	/// Key: "Label.InstructionAllowReceiveNotifications"
	/// Now just click {startBold}Allow{endBold} in your browser, and we'll start sending you push notifications!
	/// English String: "Now just click {startBold}Allow{endBold} in your browser, and we'll start sending you push notifications!"
	/// </summary>
	public override string LabelInstructionAllowReceiveNotifications(string startBold, string endBold)
	{
		return $"ブラウザで「{startBold}許可{endBold}」をクリックすると、プッシュ通知の送信を開始します！";
	}

	protected override string _GetTemplateForLabelInstructionAllowReceiveNotifications()
	{
		return "ブラウザで「{startBold}許可{endBold}」をクリックすると、プッシュ通知の送信を開始します！";
	}

	/// <summary>
	/// Key: "Label.InstructionAlwaysAllowNotificationsBackOn"
	/// Select {startBold}Always allow on this site{endBold} to turn notifications back on.
	/// English String: "Select {startBold}Always allow on this site{endBold} to turn notifications back on."
	/// </summary>
	public override string LabelInstructionAlwaysAllowNotificationsBackOn(string startBold, string endBold)
	{
		return $"通知をオンに戻すには、「{startBold}このサイトでは常に許可{endBold}」を選択してください。";
	}

	protected override string _GetTemplateForLabelInstructionAlwaysAllowNotificationsBackOn()
	{
		return "通知をオンに戻すには、「{startBold}このサイトでは常に許可{endBold}」を選択してください。";
	}

	/// <summary>
	/// Key: "Label.InstructionAlwaysReceiveNotifications"
	/// Now just click {startBold}Always Receive Notifications{endBold} in your browser, and we'll start sending you push notifications!
	/// English String: "Now just click {startBold}Always Receive Notifications{endBold} in your browser, and we'll start sending you push notifications!"
	/// </summary>
	public override string LabelInstructionAlwaysReceiveNotifications(string startBold, string endBold)
	{
		return $"ブラウザで「{startBold}常に通知を受け取る{endBold}」をクリックすると、プッシュ通知の送信を開始します！";
	}

	protected override string _GetTemplateForLabelInstructionAlwaysReceiveNotifications()
	{
		return "ブラウザで「{startBold}常に通知を受け取る{endBold}」をクリックすると、プッシュ通知の送信を開始します！";
	}

	/// <summary>
	/// Key: "Label.InstructionClickPermissionDropdown"
	/// Click the drop-down arrow next to Notifications in the {startBold}Permissions{endBold} tab.
	/// English String: "Click the drop-down arrow next to Notifications in the {startBold}Permissions{endBold} tab."
	/// </summary>
	public override string LabelInstructionClickPermissionDropdown(string startBold, string endBold)
	{
		return $"{startBold}許可{endBold}タブの「通知」の横にあるドロップダウンの矢印をクリックします。";
	}

	protected override string _GetTemplateForLabelInstructionClickPermissionDropdown()
	{
		return "{startBold}許可{endBold}タブの「通知」の横にあるドロップダウンの矢印をクリックします。";
	}

	protected override string _GetTemplateForMessagePushNotificationsDisabledSuccess()
	{
		return "プッシュ通知が無効になりました！";
	}

	protected override string _GetTemplateForMessagePushNotificationsEnabledSuccess()
	{
		return "プッシュ通知が有効になりました！";
	}

	protected override string _GetTemplateForMessageSendNotificationsPrompt()
	{
		return "このパソコンで通知を受け取りますか。";
	}
}
