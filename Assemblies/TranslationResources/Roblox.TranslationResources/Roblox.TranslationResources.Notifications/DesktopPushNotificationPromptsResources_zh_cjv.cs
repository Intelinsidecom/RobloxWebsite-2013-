namespace Roblox.TranslationResources.Notifications;

/// <summary>
/// This class overrides DesktopPushNotificationPromptsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class DesktopPushNotificationPromptsResources_zh_cjv : DesktopPushNotificationPromptsResources_en_us, IDesktopPushNotificationPromptsResources, ITranslationResources
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
	public override string ActionClose => "关闭";

	/// <summary>
	/// Key: "Heading.TurnNotificationsBackOn"
	/// Turn Push Notifications Back On
	/// English String: "Turn Push Notifications Back On"
	/// </summary>
	public override string HeadingTurnNotificationsBackOn => "重新开启推送通知";

	/// <summary>
	/// Key: "Heading.TurnNotificationsOn"
	/// Enable Desktop Push Notifications
	/// English String: "Enable Desktop Push Notifications"
	/// </summary>
	public override string HeadingTurnNotificationsOn => "启用桌面推送通知";

	/// <summary>
	/// Key: "Label.ClickGreenLockOnUrl"
	/// Click the green lock next to the URL bar to open up your site permissions.
	/// English String: "Click the green lock next to the URL bar to open up your site permissions."
	/// </summary>
	public override string LabelClickGreenLockOnUrl => "点按 URL 栏旁边的绿色锁，开启你的网站权限。";

	/// <summary>
	/// Key: "Message.PushNotificationsDisabledSuccess"
	/// Push notifications have been disabled.
	/// English String: "Push notifications have been disabled."
	/// </summary>
	public override string MessagePushNotificationsDisabledSuccess => "推送通知已停用。";

	/// <summary>
	/// Key: "Message.PushNotificationsEnabledSuccess"
	/// Push notifications have been enabled!
	/// English String: "Push notifications have been enabled!"
	/// </summary>
	public override string MessagePushNotificationsEnabledSuccess => "推送通知已启用！";

	/// <summary>
	/// Key: "Message.SendNotificationsPrompt"
	/// Can we send you notifications on this computer?
	/// English String: "Can we send you notifications on this computer?"
	/// </summary>
	public override string MessageSendNotificationsPrompt => "我们是否可将通知发送至这台电脑?";

	public DesktopPushNotificationPromptsResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAcceptNotificationPrompt()
	{
		return "通知我";
	}

	protected override string _GetTemplateForActionClose()
	{
		return "关闭";
	}

	protected override string _GetTemplateForHeadingTurnNotificationsBackOn()
	{
		return "重新开启推送通知";
	}

	protected override string _GetTemplateForHeadingTurnNotificationsOn()
	{
		return "启用桌面推送通知";
	}

	protected override string _GetTemplateForLabelClickGreenLockOnUrl()
	{
		return "点按 URL 栏旁边的绿色锁，开启你的网站权限。";
	}

	/// <summary>
	/// Key: "Label.InstructionAllowNotificationsBackOn"
	/// Select {startBold}Allow{endBold} to turn notifications back on.
	/// English String: "Select {startBold}Allow{endBold} to turn notifications back on."
	/// </summary>
	public override string LabelInstructionAllowNotificationsBackOn(string startBold, string endBold)
	{
		return $"选择{startBold}允许{endBold}以重新开启通知功能。";
	}

	protected override string _GetTemplateForLabelInstructionAllowNotificationsBackOn()
	{
		return "选择{startBold}允许{endBold}以重新开启通知功能。";
	}

	/// <summary>
	/// Key: "Label.InstructionAllowReceiveNotifications"
	/// Now just click {startBold}Allow{endBold} in your browser, and we'll start sending you push notifications!
	/// English String: "Now just click {startBold}Allow{endBold} in your browser, and we'll start sending you push notifications!"
	/// </summary>
	public override string LabelInstructionAllowReceiveNotifications(string startBold, string endBold)
	{
		return $"现在只要在你的浏览器中点击{startBold}允许{endBold}，我们就会开始发送推送通知给你了！";
	}

	protected override string _GetTemplateForLabelInstructionAllowReceiveNotifications()
	{
		return "现在只要在你的浏览器中点击{startBold}允许{endBold}，我们就会开始发送推送通知给你了！";
	}

	/// <summary>
	/// Key: "Label.InstructionAlwaysAllowNotificationsBackOn"
	/// Select {startBold}Always allow on this site{endBold} to turn notifications back on.
	/// English String: "Select {startBold}Always allow on this site{endBold} to turn notifications back on."
	/// </summary>
	public override string LabelInstructionAlwaysAllowNotificationsBackOn(string startBold, string endBold)
	{
		return $"选择{startBold}此网站始终允许{endBold}以重新开启通知功能。";
	}

	protected override string _GetTemplateForLabelInstructionAlwaysAllowNotificationsBackOn()
	{
		return "选择{startBold}此网站始终允许{endBold}以重新开启通知功能。";
	}

	/// <summary>
	/// Key: "Label.InstructionAlwaysReceiveNotifications"
	/// Now just click {startBold}Always Receive Notifications{endBold} in your browser, and we'll start sending you push notifications!
	/// English String: "Now just click {startBold}Always Receive Notifications{endBold} in your browser, and we'll start sending you push notifications!"
	/// </summary>
	public override string LabelInstructionAlwaysReceiveNotifications(string startBold, string endBold)
	{
		return $"现在只要在你的浏览器中点击{startBold}始终接收通知{endBold}，我们就会开始发送推送通知给你了！";
	}

	protected override string _GetTemplateForLabelInstructionAlwaysReceiveNotifications()
	{
		return "现在只要在你的浏览器中点击{startBold}始终接收通知{endBold}，我们就会开始发送推送通知给你了！";
	}

	/// <summary>
	/// Key: "Label.InstructionClickPermissionDropdown"
	/// Click the drop-down arrow next to Notifications in the {startBold}Permissions{endBold} tab.
	/// English String: "Click the drop-down arrow next to Notifications in the {startBold}Permissions{endBold} tab."
	/// </summary>
	public override string LabelInstructionClickPermissionDropdown(string startBold, string endBold)
	{
		return $"在{startBold}权限{endBold}标签中，点按“通知”旁边的下拉箭头。";
	}

	protected override string _GetTemplateForLabelInstructionClickPermissionDropdown()
	{
		return "在{startBold}权限{endBold}标签中，点按“通知”旁边的下拉箭头。";
	}

	protected override string _GetTemplateForMessagePushNotificationsDisabledSuccess()
	{
		return "推送通知已停用。";
	}

	protected override string _GetTemplateForMessagePushNotificationsEnabledSuccess()
	{
		return "推送通知已启用！";
	}

	protected override string _GetTemplateForMessageSendNotificationsPrompt()
	{
		return "我们是否可将通知发送至这台电脑?";
	}
}
