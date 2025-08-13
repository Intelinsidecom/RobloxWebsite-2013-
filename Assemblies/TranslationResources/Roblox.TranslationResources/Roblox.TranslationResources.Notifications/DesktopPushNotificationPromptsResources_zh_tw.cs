namespace Roblox.TranslationResources.Notifications;

/// <summary>
/// This class overrides DesktopPushNotificationPromptsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class DesktopPushNotificationPromptsResources_zh_tw : DesktopPushNotificationPromptsResources_en_us, IDesktopPushNotificationPromptsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AcceptNotificationPrompt"
	/// Notify Me
	/// English String: "Notify Me"
	/// </summary>
	public override string ActionAcceptNotificationPrompt => "通知我";

	/// <summary>
	/// Key: "Action.Close"
	/// Close
	/// English String: "Close"
	/// </summary>
	public override string ActionClose => "關閉";

	/// <summary>
	/// Key: "Heading.TurnNotificationsBackOn"
	/// Turn Push Notifications Back On
	/// English String: "Turn Push Notifications Back On"
	/// </summary>
	public override string HeadingTurnNotificationsBackOn => "重新開啟推播通知";

	/// <summary>
	/// Key: "Heading.TurnNotificationsOn"
	/// Enable Desktop Push Notifications
	/// English String: "Enable Desktop Push Notifications"
	/// </summary>
	public override string HeadingTurnNotificationsOn => "啟用桌面推播通知";

	/// <summary>
	/// Key: "Label.ClickGreenLockOnUrl"
	/// Click the green lock next to the URL bar to open up your site permissions.
	/// English String: "Click the green lock next to the URL bar to open up your site permissions."
	/// </summary>
	public override string LabelClickGreenLockOnUrl => "按下網址列旁的綠色鎖頭開啟您的網站權限。";

	/// <summary>
	/// Key: "Message.PushNotificationsDisabledSuccess"
	/// Push notifications have been disabled.
	/// English String: "Push notifications have been disabled."
	/// </summary>
	public override string MessagePushNotificationsDisabledSuccess => "已停用推播通知。";

	/// <summary>
	/// Key: "Message.PushNotificationsEnabledSuccess"
	/// Push notifications have been enabled!
	/// English String: "Push notifications have been enabled!"
	/// </summary>
	public override string MessagePushNotificationsEnabledSuccess => "已啟用推播通知！";

	/// <summary>
	/// Key: "Message.SendNotificationsPrompt"
	/// Can we send you notifications on this computer?
	/// English String: "Can we send you notifications on this computer?"
	/// </summary>
	public override string MessageSendNotificationsPrompt => "我們可以在此電腦傳送通知給您嗎？";

	public DesktopPushNotificationPromptsResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAcceptNotificationPrompt()
	{
		return "通知我";
	}

	protected override string _GetTemplateForActionClose()
	{
		return "關閉";
	}

	protected override string _GetTemplateForHeadingTurnNotificationsBackOn()
	{
		return "重新開啟推播通知";
	}

	protected override string _GetTemplateForHeadingTurnNotificationsOn()
	{
		return "啟用桌面推播通知";
	}

	protected override string _GetTemplateForLabelClickGreenLockOnUrl()
	{
		return "按下網址列旁的綠色鎖頭開啟您的網站權限。";
	}

	/// <summary>
	/// Key: "Label.InstructionAllowNotificationsBackOn"
	/// Select {startBold}Allow{endBold} to turn notifications back on.
	/// English String: "Select {startBold}Allow{endBold} to turn notifications back on."
	/// </summary>
	public override string LabelInstructionAllowNotificationsBackOn(string startBold, string endBold)
	{
		return $"選擇{startBold}允許{endBold}重新開啟通知。";
	}

	protected override string _GetTemplateForLabelInstructionAllowNotificationsBackOn()
	{
		return "選擇{startBold}允許{endBold}重新開啟通知。";
	}

	/// <summary>
	/// Key: "Label.InstructionAllowReceiveNotifications"
	/// Now just click {startBold}Allow{endBold} in your browser, and we'll start sending you push notifications!
	/// English String: "Now just click {startBold}Allow{endBold} in your browser, and we'll start sending you push notifications!"
	/// </summary>
	public override string LabelInstructionAllowReceiveNotifications(string startBold, string endBold)
	{
		return $"只要在瀏覽器按下{startBold}允許{endBold}，我們就會開始傳送推播通知給您！";
	}

	protected override string _GetTemplateForLabelInstructionAllowReceiveNotifications()
	{
		return "只要在瀏覽器按下{startBold}允許{endBold}，我們就會開始傳送推播通知給您！";
	}

	/// <summary>
	/// Key: "Label.InstructionAlwaysAllowNotificationsBackOn"
	/// Select {startBold}Always allow on this site{endBold} to turn notifications back on.
	/// English String: "Select {startBold}Always allow on this site{endBold} to turn notifications back on."
	/// </summary>
	public override string LabelInstructionAlwaysAllowNotificationsBackOn(string startBold, string endBold)
	{
		return $"選擇{startBold}永遠在此網站允許{endBold}重新開啟通知。";
	}

	protected override string _GetTemplateForLabelInstructionAlwaysAllowNotificationsBackOn()
	{
		return "選擇{startBold}永遠在此網站允許{endBold}重新開啟通知。";
	}

	/// <summary>
	/// Key: "Label.InstructionAlwaysReceiveNotifications"
	/// Now just click {startBold}Always Receive Notifications{endBold} in your browser, and we'll start sending you push notifications!
	/// English String: "Now just click {startBold}Always Receive Notifications{endBold} in your browser, and we'll start sending you push notifications!"
	/// </summary>
	public override string LabelInstructionAlwaysReceiveNotifications(string startBold, string endBold)
	{
		return $"現在只要在瀏覽器按下 {startBold}永遠收到通知{endBold}，我們就會開始傳送推播通知給您！";
	}

	protected override string _GetTemplateForLabelInstructionAlwaysReceiveNotifications()
	{
		return "現在只要在瀏覽器按下 {startBold}永遠收到通知{endBold}，我們就會開始傳送推播通知給您！";
	}

	/// <summary>
	/// Key: "Label.InstructionClickPermissionDropdown"
	/// Click the drop-down arrow next to Notifications in the {startBold}Permissions{endBold} tab.
	/// English String: "Click the drop-down arrow next to Notifications in the {startBold}Permissions{endBold} tab."
	/// </summary>
	public override string LabelInstructionClickPermissionDropdown(string startBold, string endBold)
	{
		return $"在{startBold}權限{endBold}標籤中，按下「通知」旁的下拉箭頭。";
	}

	protected override string _GetTemplateForLabelInstructionClickPermissionDropdown()
	{
		return "在{startBold}權限{endBold}標籤中，按下「通知」旁的下拉箭頭。";
	}

	protected override string _GetTemplateForMessagePushNotificationsDisabledSuccess()
	{
		return "已停用推播通知。";
	}

	protected override string _GetTemplateForMessagePushNotificationsEnabledSuccess()
	{
		return "已啟用推播通知！";
	}

	protected override string _GetTemplateForMessageSendNotificationsPrompt()
	{
		return "我們可以在此電腦傳送通知給您嗎？";
	}
}
