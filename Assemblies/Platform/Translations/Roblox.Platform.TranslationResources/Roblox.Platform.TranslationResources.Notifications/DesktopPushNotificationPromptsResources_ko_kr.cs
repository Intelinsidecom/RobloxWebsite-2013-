namespace Roblox.Platform.TranslationResources.Notifications {
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
	public override string ActionAcceptNotificationPrompt => "ì•Œë ¤ì£¼ì„¸ìš”";

	/// <summary>
	/// Key: "Action.Close"
	/// Close
	/// English String: "Close"
	/// </summary>
	public override string ActionClose => "ë‹«ê¸°";

	/// <summary>
	/// Key: "Heading.TurnNotificationsBackOn"
	/// Turn Push Notifications Back On
	/// English String: "Turn Push Notifications Back On"
	/// </summary>
	public override string HeadingTurnNotificationsBackOn => "í‘¸ì‹œ ì•Œë¦¼ ë‹¤ì‹œ ì¼œê¸°";

	/// <summary>
	/// Key: "Heading.TurnNotificationsOn"
	/// Enable Desktop Push Notifications
	/// English String: "Enable Desktop Push Notifications"
	/// </summary>
	public override string HeadingTurnNotificationsOn => "ë°ìŠ¤í¬í†± í‘¸ì‹œ ì•Œë¦¼ í™œì„±í™”";

	/// <summary>
	/// Key: "Label.ClickGreenLockOnUrl"
	/// Click the green lock next to the URL bar to open up your site permissions.
	/// English String: "Click the green lock next to the URL bar to open up your site permissions."
	/// </summary>
	public override string LabelClickGreenLockOnUrl => "URL ìž…ë ¥ì°½ ì˜†ì˜ ë…¹ìƒ‰ ìžë¬¼ì‡ ë¥¼ í´ë¦­í•˜ì—¬ ì›¹ ì‚¬ì´íŠ¸ ê¶Œí•œì„ ì—¬ì„¸ìš”.";

	/// <summary>
	/// Key: "Message.PushNotificationsDisabledSuccess"
	/// Push notifications have been disabled.
	/// English String: "Push notifications have been disabled."
	/// </summary>
	public override string MessagePushNotificationsDisabledSuccess => "í‘¸ì‹œ ì•Œë¦¼ì´ ë¹„í™œì„±í™”ë˜ì—ˆì–´ìš”.";

	/// <summary>
	/// Key: "Message.PushNotificationsEnabledSuccess"
	/// Push notifications have been enabled!
	/// English String: "Push notifications have been enabled!"
	/// </summary>
	public override string MessagePushNotificationsEnabledSuccess => "í‘¸ì‹œ ì•Œë¦¼ì´ í™œì„±í™”ë˜ì—ˆì–´ìš”!";

	/// <summary>
	/// Key: "Message.SendNotificationsPrompt"
	/// Can we send you notifications on this computer?
	/// English String: "Can we send you notifications on this computer?"
	/// </summary>
	public override string MessageSendNotificationsPrompt => "ì‚¬ìš© ì¤‘ì¸ ì»´í“¨í„°ì—ì„œ ì•Œë¦¼ì„ ë°›ê³  ì‹¶ë‚˜ìš”?";

	public DesktopPushNotificationPromptsResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAcceptNotificationPrompt()
	{
		return "ì•Œë ¤ì£¼ì„¸ìš”";
	}

	protected override string _GetTemplateForActionClose()
	{
		return "ë‹«ê¸°";
	}

	protected override string _GetTemplateForHeadingTurnNotificationsBackOn()
	{
		return "í‘¸ì‹œ ì•Œë¦¼ ë‹¤ì‹œ ì¼œê¸°";
	}

	protected override string _GetTemplateForHeadingTurnNotificationsOn()
	{
		return "ë°ìŠ¤í¬í†± í‘¸ì‹œ ì•Œë¦¼ í™œì„±í™”";
	}

	protected override string _GetTemplateForLabelClickGreenLockOnUrl()
	{
		return "URL ìž…ë ¥ì°½ ì˜†ì˜ ë…¹ìƒ‰ ìžë¬¼ì‡ ë¥¼ í´ë¦­í•˜ì—¬ ì›¹ ì‚¬ì´íŠ¸ ê¶Œí•œì„ ì—¬ì„¸ìš”.";
	}

	/// <summary>
	/// Key: "Label.InstructionAllowNotificationsBackOn"
	/// Select {startBold}Allow{endBold} to turn notifications back on.
	/// English String: "Select {startBold}Allow{endBold} to turn notifications back on."
	/// </summary>
	public override string LabelInstructionAllowNotificationsBackOn(string startBold, string endBold)
	{
		return $"{startBold}í—ˆìš©{endBold}ì„ ì„ íƒí•˜ì—¬ ì•Œë¦¼ì„ ë‹¤ì‹œ ì¼œì„¸ìš”.";
	}

	protected override string _GetTemplateForLabelInstructionAllowNotificationsBackOn()
	{
		return "{startBold}í—ˆìš©{endBold}ì„ ì„ íƒí•˜ì—¬ ì•Œë¦¼ì„ ë‹¤ì‹œ ì¼œì„¸ìš”.";
	}

	/// <summary>
	/// Key: "Label.InstructionAllowReceiveNotifications"
	/// Now just click {startBold}Allow{endBold} in your browser, and we'll start sending you push notifications!
	/// English String: "Now just click {startBold}Allow{endBold} in your browser, and we'll start sending you push notifications!"
	/// </summary>
	public override string LabelInstructionAllowReceiveNotifications(string startBold, string endBold)
	{
		return $"ë¸Œë¼ìš°ì €ì—ì„œ {startBold}í—ˆìš©{endBold}ì„ í´ë¦­í•˜ì‹œë©´, ì €í¬ê°€ ë³´ë‚´ë“œë¦¬ëŠ” í‘¸ì‹œ ì•Œë¦¼ì„ ë°›ê²Œ ëœë‹µë‹ˆë‹¤!";
	}

	protected override string _GetTemplateForLabelInstructionAllowReceiveNotifications()
	{
		return "ë¸Œë¼ìš°ì €ì—ì„œ {startBold}í—ˆìš©{endBold}ì„ í´ë¦­í•˜ì‹œë©´, ì €í¬ê°€ ë³´ë‚´ë“œë¦¬ëŠ” í‘¸ì‹œ ì•Œë¦¼ì„ ë°›ê²Œ ëœë‹µë‹ˆë‹¤!";
	}

	/// <summary>
	/// Key: "Label.InstructionAlwaysAllowNotificationsBackOn"
	/// Select {startBold}Always allow on this site{endBold} to turn notifications back on.
	/// English String: "Select {startBold}Always allow on this site{endBold} to turn notifications back on."
	/// </summary>
	public override string LabelInstructionAlwaysAllowNotificationsBackOn(string startBold, string endBold)
	{
		return $"{startBold}ì´ ì‚¬ì´íŠ¸ì—ì„œ í•­ìƒ í—ˆìš©{endBold}ì„ ì„ íƒí•˜ì—¬ ì•Œë¦¼ì„ ë‹¤ì‹œ ì¼œì„¸ìš”.";
	}

	protected override string _GetTemplateForLabelInstructionAlwaysAllowNotificationsBackOn()
	{
		return "{startBold}ì´ ì‚¬ì´íŠ¸ì—ì„œ í•­ìƒ í—ˆìš©{endBold}ì„ ì„ íƒí•˜ì—¬ ì•Œë¦¼ì„ ë‹¤ì‹œ ì¼œì„¸ìš”.";
	}

	/// <summary>
	/// Key: "Label.InstructionAlwaysReceiveNotifications"
	/// Now just click {startBold}Always Receive Notifications{endBold} in your browser, and we'll start sending you push notifications!
	/// English String: "Now just click {startBold}Always Receive Notifications{endBold} in your browser, and we'll start sending you push notifications!"
	/// </summary>
	public override string LabelInstructionAlwaysReceiveNotifications(string startBold, string endBold)
	{
		return $"ë¸Œë¼ìš°ì €ì—ì„œ {startBold}í•­ìƒ ì•Œë¦¼ ë°›ê¸°{endBold}ë¥¼ í´ë¦­í•˜ì‹œë©´, ì €í¬ê°€ ë³´ë‚´ë“œë¦¬ëŠ” í‘¸ì‹œ ì•Œë¦¼ì„ ë°›ê²Œ ëœë‹µë‹ˆë‹¤!";
	}

	protected override string _GetTemplateForLabelInstructionAlwaysReceiveNotifications()
	{
		return "ë¸Œë¼ìš°ì €ì—ì„œ {startBold}í•­ìƒ ì•Œë¦¼ ë°›ê¸°{endBold}ë¥¼ í´ë¦­í•˜ì‹œë©´, ì €í¬ê°€ ë³´ë‚´ë“œë¦¬ëŠ” í‘¸ì‹œ ì•Œë¦¼ì„ ë°›ê²Œ ëœë‹µë‹ˆë‹¤!";
	}

	/// <summary>
	/// Key: "Label.InstructionClickPermissionDropdown"
	/// Click the drop-down arrow next to Notifications in the {startBold}Permissions{endBold} tab.
	/// English String: "Click the drop-down arrow next to Notifications in the {startBold}Permissions{endBold} tab."
	/// </summary>
	public override string LabelInstructionClickPermissionDropdown(string startBold, string endBold)
	{
		return $"{startBold}ê¶Œí•œ{endBold} íƒ­ì˜ ì•Œë¦¼ ì˜†ì— ìžˆëŠ” ë“œë¡­ë‹¤ìš´ í™”ì‚´í‘œë¥¼ í´ë¦­í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForLabelInstructionClickPermissionDropdown()
	{
		return "{startBold}ê¶Œí•œ{endBold} íƒ­ì˜ ì•Œë¦¼ ì˜†ì— ìžˆëŠ” ë“œë¡­ë‹¤ìš´ í™”ì‚´í‘œë¥¼ í´ë¦­í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForMessagePushNotificationsDisabledSuccess()
	{
		return "í‘¸ì‹œ ì•Œë¦¼ì´ ë¹„í™œì„±í™”ë˜ì—ˆì–´ìš”.";
	}

	protected override string _GetTemplateForMessagePushNotificationsEnabledSuccess()
	{
		return "í‘¸ì‹œ ì•Œë¦¼ì´ í™œì„±í™”ë˜ì—ˆì–´ìš”!";
	}

	protected override string _GetTemplateForMessageSendNotificationsPrompt()
	{
		return "ì‚¬ìš© ì¤‘ì¸ ì»´í“¨í„°ì—ì„œ ì•Œë¦¼ì„ ë°›ê³  ì‹¶ë‚˜ìš”?";
	}
}


}
