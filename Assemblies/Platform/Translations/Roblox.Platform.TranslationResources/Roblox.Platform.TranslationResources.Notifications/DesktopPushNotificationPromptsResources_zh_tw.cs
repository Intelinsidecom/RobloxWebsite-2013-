namespace Roblox.Platform.TranslationResources.Notifications {
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
	public override string ActionAcceptNotificationPrompt => "é€šçŸ¥æˆ‘";

	/// <summary>
	/// Key: "Action.Close"
	/// Close
	/// English String: "Close"
	/// </summary>
	public override string ActionClose => "é—œé–‰";

	/// <summary>
	/// Key: "Heading.TurnNotificationsBackOn"
	/// Turn Push Notifications Back On
	/// English String: "Turn Push Notifications Back On"
	/// </summary>
	public override string HeadingTurnNotificationsBackOn => "é‡æ–°é–‹å•ŸæŽ¨æ’­é€šçŸ¥";

	/// <summary>
	/// Key: "Heading.TurnNotificationsOn"
	/// Enable Desktop Push Notifications
	/// English String: "Enable Desktop Push Notifications"
	/// </summary>
	public override string HeadingTurnNotificationsOn => "å•Ÿç”¨æ¡Œé¢æŽ¨æ’­é€šçŸ¥";

	/// <summary>
	/// Key: "Label.ClickGreenLockOnUrl"
	/// Click the green lock next to the URL bar to open up your site permissions.
	/// English String: "Click the green lock next to the URL bar to open up your site permissions."
	/// </summary>
	public override string LabelClickGreenLockOnUrl => "æŒ‰ä¸‹ç¶²å€åˆ—æ—çš„ç¶ è‰²éŽ–é ­é–‹å•Ÿæ‚¨çš„ç¶²ç«™æ¬Šé™ã€‚";

	/// <summary>
	/// Key: "Message.PushNotificationsDisabledSuccess"
	/// Push notifications have been disabled.
	/// English String: "Push notifications have been disabled."
	/// </summary>
	public override string MessagePushNotificationsDisabledSuccess => "å·²åœç”¨æŽ¨æ’­é€šçŸ¥ã€‚";

	/// <summary>
	/// Key: "Message.PushNotificationsEnabledSuccess"
	/// Push notifications have been enabled!
	/// English String: "Push notifications have been enabled!"
	/// </summary>
	public override string MessagePushNotificationsEnabledSuccess => "å·²å•Ÿç”¨æŽ¨æ’­é€šçŸ¥ï¼";

	/// <summary>
	/// Key: "Message.SendNotificationsPrompt"
	/// Can we send you notifications on this computer?
	/// English String: "Can we send you notifications on this computer?"
	/// </summary>
	public override string MessageSendNotificationsPrompt => "æˆ‘å€‘å¯ä»¥åœ¨æ­¤é›»è…¦å‚³é€é€šçŸ¥çµ¦æ‚¨å—Žï¼Ÿ";

	public DesktopPushNotificationPromptsResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAcceptNotificationPrompt()
	{
		return "é€šçŸ¥æˆ‘";
	}

	protected override string _GetTemplateForActionClose()
	{
		return "é—œé–‰";
	}

	protected override string _GetTemplateForHeadingTurnNotificationsBackOn()
	{
		return "é‡æ–°é–‹å•ŸæŽ¨æ’­é€šçŸ¥";
	}

	protected override string _GetTemplateForHeadingTurnNotificationsOn()
	{
		return "å•Ÿç”¨æ¡Œé¢æŽ¨æ’­é€šçŸ¥";
	}

	protected override string _GetTemplateForLabelClickGreenLockOnUrl()
	{
		return "æŒ‰ä¸‹ç¶²å€åˆ—æ—çš„ç¶ è‰²éŽ–é ­é–‹å•Ÿæ‚¨çš„ç¶²ç«™æ¬Šé™ã€‚";
	}

	/// <summary>
	/// Key: "Label.InstructionAllowNotificationsBackOn"
	/// Select {startBold}Allow{endBold} to turn notifications back on.
	/// English String: "Select {startBold}Allow{endBold} to turn notifications back on."
	/// </summary>
	public override string LabelInstructionAllowNotificationsBackOn(string startBold, string endBold)
	{
		return $"é¸æ“‡{startBold}å…è¨±{endBold}é‡æ–°é–‹å•Ÿé€šçŸ¥ã€‚";
	}

	protected override string _GetTemplateForLabelInstructionAllowNotificationsBackOn()
	{
		return "é¸æ“‡{startBold}å…è¨±{endBold}é‡æ–°é–‹å•Ÿé€šçŸ¥ã€‚";
	}

	/// <summary>
	/// Key: "Label.InstructionAllowReceiveNotifications"
	/// Now just click {startBold}Allow{endBold} in your browser, and we'll start sending you push notifications!
	/// English String: "Now just click {startBold}Allow{endBold} in your browser, and we'll start sending you push notifications!"
	/// </summary>
	public override string LabelInstructionAllowReceiveNotifications(string startBold, string endBold)
	{
		return $"åªè¦åœ¨ç€è¦½å™¨æŒ‰ä¸‹{startBold}å…è¨±{endBold}ï¼Œæˆ‘å€‘å°±æœƒé–‹å§‹å‚³é€æŽ¨æ’­é€šçŸ¥çµ¦æ‚¨ï¼";
	}

	protected override string _GetTemplateForLabelInstructionAllowReceiveNotifications()
	{
		return "åªè¦åœ¨ç€è¦½å™¨æŒ‰ä¸‹{startBold}å…è¨±{endBold}ï¼Œæˆ‘å€‘å°±æœƒé–‹å§‹å‚³é€æŽ¨æ’­é€šçŸ¥çµ¦æ‚¨ï¼";
	}

	/// <summary>
	/// Key: "Label.InstructionAlwaysAllowNotificationsBackOn"
	/// Select {startBold}Always allow on this site{endBold} to turn notifications back on.
	/// English String: "Select {startBold}Always allow on this site{endBold} to turn notifications back on."
	/// </summary>
	public override string LabelInstructionAlwaysAllowNotificationsBackOn(string startBold, string endBold)
	{
		return $"é¸æ“‡{startBold}æ°¸é åœ¨æ­¤ç¶²ç«™å…è¨±{endBold}é‡æ–°é–‹å•Ÿé€šçŸ¥ã€‚";
	}

	protected override string _GetTemplateForLabelInstructionAlwaysAllowNotificationsBackOn()
	{
		return "é¸æ“‡{startBold}æ°¸é åœ¨æ­¤ç¶²ç«™å…è¨±{endBold}é‡æ–°é–‹å•Ÿé€šçŸ¥ã€‚";
	}

	/// <summary>
	/// Key: "Label.InstructionAlwaysReceiveNotifications"
	/// Now just click {startBold}Always Receive Notifications{endBold} in your browser, and we'll start sending you push notifications!
	/// English String: "Now just click {startBold}Always Receive Notifications{endBold} in your browser, and we'll start sending you push notifications!"
	/// </summary>
	public override string LabelInstructionAlwaysReceiveNotifications(string startBold, string endBold)
	{
		return $"ç¾åœ¨åªè¦åœ¨ç€è¦½å™¨æŒ‰ä¸‹ {startBold}æ°¸é æ”¶åˆ°é€šçŸ¥{endBold}ï¼Œæˆ‘å€‘å°±æœƒé–‹å§‹å‚³é€æŽ¨æ’­é€šçŸ¥çµ¦æ‚¨ï¼";
	}

	protected override string _GetTemplateForLabelInstructionAlwaysReceiveNotifications()
	{
		return "ç¾åœ¨åªè¦åœ¨ç€è¦½å™¨æŒ‰ä¸‹ {startBold}æ°¸é æ”¶åˆ°é€šçŸ¥{endBold}ï¼Œæˆ‘å€‘å°±æœƒé–‹å§‹å‚³é€æŽ¨æ’­é€šçŸ¥çµ¦æ‚¨ï¼";
	}

	/// <summary>
	/// Key: "Label.InstructionClickPermissionDropdown"
	/// Click the drop-down arrow next to Notifications in the {startBold}Permissions{endBold} tab.
	/// English String: "Click the drop-down arrow next to Notifications in the {startBold}Permissions{endBold} tab."
	/// </summary>
	public override string LabelInstructionClickPermissionDropdown(string startBold, string endBold)
	{
		return $"åœ¨{startBold}æ¬Šé™{endBold}æ¨™ç±¤ä¸­ï¼ŒæŒ‰ä¸‹ã€Œé€šçŸ¥ã€æ—çš„ä¸‹æ‹‰ç®­é ­ã€‚";
	}

	protected override string _GetTemplateForLabelInstructionClickPermissionDropdown()
	{
		return "åœ¨{startBold}æ¬Šé™{endBold}æ¨™ç±¤ä¸­ï¼ŒæŒ‰ä¸‹ã€Œé€šçŸ¥ã€æ—çš„ä¸‹æ‹‰ç®­é ­ã€‚";
	}

	protected override string _GetTemplateForMessagePushNotificationsDisabledSuccess()
	{
		return "å·²åœç”¨æŽ¨æ’­é€šçŸ¥ã€‚";
	}

	protected override string _GetTemplateForMessagePushNotificationsEnabledSuccess()
	{
		return "å·²å•Ÿç”¨æŽ¨æ’­é€šçŸ¥ï¼";
	}

	protected override string _GetTemplateForMessageSendNotificationsPrompt()
	{
		return "æˆ‘å€‘å¯ä»¥åœ¨æ­¤é›»è…¦å‚³é€é€šçŸ¥çµ¦æ‚¨å—Žï¼Ÿ";
	}
}


}
