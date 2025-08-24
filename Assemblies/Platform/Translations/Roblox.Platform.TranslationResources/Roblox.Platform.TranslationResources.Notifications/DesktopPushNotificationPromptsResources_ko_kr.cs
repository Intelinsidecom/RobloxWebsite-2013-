namespace Roblox.TranslationResources.Notifications;

/// <summary>
/// This class overrides DesktopPushNotificationPromptsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class DesktopPushNotificationPromptsResources_ko_kr : DesktopPushNotificationPromptsResources_en_us, IDesktopPushNotificationPromptsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AcceptNotificationPrompt"
	/// Notify Me
	/// English String: "Notify Me"
	/// </summary>
	public override string ActionAcceptNotificationPrompt => "알려주세요";

	/// <summary>
	/// Key: "Action.Close"
	/// Close
	/// English String: "Close"
	/// </summary>
	public override string ActionClose => "닫기";

	/// <summary>
	/// Key: "Heading.TurnNotificationsBackOn"
	/// Turn Push Notifications Back On
	/// English String: "Turn Push Notifications Back On"
	/// </summary>
	public override string HeadingTurnNotificationsBackOn => "푸시 알림 다시 켜기";

	/// <summary>
	/// Key: "Heading.TurnNotificationsOn"
	/// Enable Desktop Push Notifications
	/// English String: "Enable Desktop Push Notifications"
	/// </summary>
	public override string HeadingTurnNotificationsOn => "데스크톱 푸시 알림 활성화";

	/// <summary>
	/// Key: "Label.ClickGreenLockOnUrl"
	/// Click the green lock next to the URL bar to open up your site permissions.
	/// English String: "Click the green lock next to the URL bar to open up your site permissions."
	/// </summary>
	public override string LabelClickGreenLockOnUrl => "URL 입력창 옆의 녹색 자물쇠를 클릭하여 웹 사이트 권한을 여세요.";

	/// <summary>
	/// Key: "Message.PushNotificationsDisabledSuccess"
	/// Push notifications have been disabled.
	/// English String: "Push notifications have been disabled."
	/// </summary>
	public override string MessagePushNotificationsDisabledSuccess => "푸시 알림이 비활성화되었어요.";

	/// <summary>
	/// Key: "Message.PushNotificationsEnabledSuccess"
	/// Push notifications have been enabled!
	/// English String: "Push notifications have been enabled!"
	/// </summary>
	public override string MessagePushNotificationsEnabledSuccess => "푸시 알림이 활성화되었어요!";

	/// <summary>
	/// Key: "Message.SendNotificationsPrompt"
	/// Can we send you notifications on this computer?
	/// English String: "Can we send you notifications on this computer?"
	/// </summary>
	public override string MessageSendNotificationsPrompt => "사용 중인 컴퓨터에서 알림을 받고 싶나요?";

	public DesktopPushNotificationPromptsResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAcceptNotificationPrompt()
	{
		return "알려주세요";
	}

	protected override string _GetTemplateForActionClose()
	{
		return "닫기";
	}

	protected override string _GetTemplateForHeadingTurnNotificationsBackOn()
	{
		return "푸시 알림 다시 켜기";
	}

	protected override string _GetTemplateForHeadingTurnNotificationsOn()
	{
		return "데스크톱 푸시 알림 활성화";
	}

	protected override string _GetTemplateForLabelClickGreenLockOnUrl()
	{
		return "URL 입력창 옆의 녹색 자물쇠를 클릭하여 웹 사이트 권한을 여세요.";
	}

	/// <summary>
	/// Key: "Label.InstructionAllowNotificationsBackOn"
	/// Select {startBold}Allow{endBold} to turn notifications back on.
	/// English String: "Select {startBold}Allow{endBold} to turn notifications back on."
	/// </summary>
	public override string LabelInstructionAllowNotificationsBackOn(string startBold, string endBold)
	{
		return $"{startBold}허용{endBold}을 선택하여 알림을 다시 켜세요.";
	}

	protected override string _GetTemplateForLabelInstructionAllowNotificationsBackOn()
	{
		return "{startBold}허용{endBold}을 선택하여 알림을 다시 켜세요.";
	}

	/// <summary>
	/// Key: "Label.InstructionAllowReceiveNotifications"
	/// Now just click {startBold}Allow{endBold} in your browser, and we'll start sending you push notifications!
	/// English String: "Now just click {startBold}Allow{endBold} in your browser, and we'll start sending you push notifications!"
	/// </summary>
	public override string LabelInstructionAllowReceiveNotifications(string startBold, string endBold)
	{
		return $"브라우저에서 {startBold}허용{endBold}을 클릭하시면, 저희가 보내드리는 푸시 알림을 받게 된답니다!";
	}

	protected override string _GetTemplateForLabelInstructionAllowReceiveNotifications()
	{
		return "브라우저에서 {startBold}허용{endBold}을 클릭하시면, 저희가 보내드리는 푸시 알림을 받게 된답니다!";
	}

	/// <summary>
	/// Key: "Label.InstructionAlwaysAllowNotificationsBackOn"
	/// Select {startBold}Always allow on this site{endBold} to turn notifications back on.
	/// English String: "Select {startBold}Always allow on this site{endBold} to turn notifications back on."
	/// </summary>
	public override string LabelInstructionAlwaysAllowNotificationsBackOn(string startBold, string endBold)
	{
		return $"{startBold}이 사이트에서 항상 허용{endBold}을 선택하여 알림을 다시 켜세요.";
	}

	protected override string _GetTemplateForLabelInstructionAlwaysAllowNotificationsBackOn()
	{
		return "{startBold}이 사이트에서 항상 허용{endBold}을 선택하여 알림을 다시 켜세요.";
	}

	/// <summary>
	/// Key: "Label.InstructionAlwaysReceiveNotifications"
	/// Now just click {startBold}Always Receive Notifications{endBold} in your browser, and we'll start sending you push notifications!
	/// English String: "Now just click {startBold}Always Receive Notifications{endBold} in your browser, and we'll start sending you push notifications!"
	/// </summary>
	public override string LabelInstructionAlwaysReceiveNotifications(string startBold, string endBold)
	{
		return $"브라우저에서 {startBold}항상 알림 받기{endBold}를 클릭하시면, 저희가 보내드리는 푸시 알림을 받게 된답니다!";
	}

	protected override string _GetTemplateForLabelInstructionAlwaysReceiveNotifications()
	{
		return "브라우저에서 {startBold}항상 알림 받기{endBold}를 클릭하시면, 저희가 보내드리는 푸시 알림을 받게 된답니다!";
	}

	/// <summary>
	/// Key: "Label.InstructionClickPermissionDropdown"
	/// Click the drop-down arrow next to Notifications in the {startBold}Permissions{endBold} tab.
	/// English String: "Click the drop-down arrow next to Notifications in the {startBold}Permissions{endBold} tab."
	/// </summary>
	public override string LabelInstructionClickPermissionDropdown(string startBold, string endBold)
	{
		return $"{startBold}권한{endBold} 탭의 알림 옆에 있는 드롭다운 화살표를 클릭하세요.";
	}

	protected override string _GetTemplateForLabelInstructionClickPermissionDropdown()
	{
		return "{startBold}권한{endBold} 탭의 알림 옆에 있는 드롭다운 화살표를 클릭하세요.";
	}

	protected override string _GetTemplateForMessagePushNotificationsDisabledSuccess()
	{
		return "푸시 알림이 비활성화되었어요.";
	}

	protected override string _GetTemplateForMessagePushNotificationsEnabledSuccess()
	{
		return "푸시 알림이 활성화되었어요!";
	}

	protected override string _GetTemplateForMessageSendNotificationsPrompt()
	{
		return "사용 중인 컴퓨터에서 알림을 받고 싶나요?";
	}
}
