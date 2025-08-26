namespace Roblox.Platform.TranslationResources.Notifications {
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
	public override string ActionAcceptNotificationPrompt => "é€šçŸ¥ã™ã‚‹";

	/// <summary>
	/// Key: "Action.Close"
	/// Close
	/// English String: "Close"
	/// </summary>
	public override string ActionClose => "é–‰ã˜ã‚‹";

	/// <summary>
	/// Key: "Heading.TurnNotificationsBackOn"
	/// Turn Push Notifications Back On
	/// English String: "Turn Push Notifications Back On"
	/// </summary>
	public override string HeadingTurnNotificationsBackOn => "ãƒ—ãƒƒã‚·ãƒ¥é€šçŸ¥ã‚’ã‚ªãƒ³ã«æˆ»ã™";

	/// <summary>
	/// Key: "Heading.TurnNotificationsOn"
	/// Enable Desktop Push Notifications
	/// English String: "Enable Desktop Push Notifications"
	/// </summary>
	public override string HeadingTurnNotificationsOn => "ãƒ‡ã‚¹ã‚¯ãƒˆãƒƒãƒ—ãƒ—ãƒƒã‚·ãƒ¥é€šçŸ¥ã‚’æœ‰åŠ¹ã«ã™ã‚‹";

	/// <summary>
	/// Key: "Label.ClickGreenLockOnUrl"
	/// Click the green lock next to the URL bar to open up your site permissions.
	/// English String: "Click the green lock next to the URL bar to open up your site permissions."
	/// </summary>
	public override string LabelClickGreenLockOnUrl => "URLãƒãƒ¼ã®æ¨ªã«ã‚ã‚‹ç·‘è‰²ã®ã‚«ã‚®ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¦ã€ã‚µã‚¤ãƒˆã®è¨±å¯ã‚’é–‹ãã¾ã™ã€‚";

	/// <summary>
	/// Key: "Message.PushNotificationsDisabledSuccess"
	/// Push notifications have been disabled.
	/// English String: "Push notifications have been disabled."
	/// </summary>
	public override string MessagePushNotificationsDisabledSuccess => "ãƒ—ãƒƒã‚·ãƒ¥é€šçŸ¥ãŒç„¡åŠ¹ã«ãªã‚Šã¾ã—ãŸï¼";

	/// <summary>
	/// Key: "Message.PushNotificationsEnabledSuccess"
	/// Push notifications have been enabled!
	/// English String: "Push notifications have been enabled!"
	/// </summary>
	public override string MessagePushNotificationsEnabledSuccess => "ãƒ—ãƒƒã‚·ãƒ¥é€šçŸ¥ãŒæœ‰åŠ¹ã«ãªã‚Šã¾ã—ãŸï¼";

	/// <summary>
	/// Key: "Message.SendNotificationsPrompt"
	/// Can we send you notifications on this computer?
	/// English String: "Can we send you notifications on this computer?"
	/// </summary>
	public override string MessageSendNotificationsPrompt => "ã“ã®ãƒ‘ã‚½ã‚³ãƒ³ã§é€šçŸ¥ã‚’å—ã‘å–ã‚Šã¾ã™ã‹ã€‚";

	public DesktopPushNotificationPromptsResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAcceptNotificationPrompt()
	{
		return "é€šçŸ¥ã™ã‚‹";
	}

	protected override string _GetTemplateForActionClose()
	{
		return "é–‰ã˜ã‚‹";
	}

	protected override string _GetTemplateForHeadingTurnNotificationsBackOn()
	{
		return "ãƒ—ãƒƒã‚·ãƒ¥é€šçŸ¥ã‚’ã‚ªãƒ³ã«æˆ»ã™";
	}

	protected override string _GetTemplateForHeadingTurnNotificationsOn()
	{
		return "ãƒ‡ã‚¹ã‚¯ãƒˆãƒƒãƒ—ãƒ—ãƒƒã‚·ãƒ¥é€šçŸ¥ã‚’æœ‰åŠ¹ã«ã™ã‚‹";
	}

	protected override string _GetTemplateForLabelClickGreenLockOnUrl()
	{
		return "URLãƒãƒ¼ã®æ¨ªã«ã‚ã‚‹ç·‘è‰²ã®ã‚«ã‚®ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¦ã€ã‚µã‚¤ãƒˆã®è¨±å¯ã‚’é–‹ãã¾ã™ã€‚";
	}

	/// <summary>
	/// Key: "Label.InstructionAllowNotificationsBackOn"
	/// Select {startBold}Allow{endBold} to turn notifications back on.
	/// English String: "Select {startBold}Allow{endBold} to turn notifications back on."
	/// </summary>
	public override string LabelInstructionAllowNotificationsBackOn(string startBold, string endBold)
	{
		return $"é€šçŸ¥ã‚’ã‚ªãƒ³ã«æˆ»ã™ã«ã¯ã€ã€Œ{startBold}è¨±å¯{endBold}ã€ã‚’é¸æŠžã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForLabelInstructionAllowNotificationsBackOn()
	{
		return "é€šçŸ¥ã‚’ã‚ªãƒ³ã«æˆ»ã™ã«ã¯ã€ã€Œ{startBold}è¨±å¯{endBold}ã€ã‚’é¸æŠžã—ã¦ãã ã•ã„ã€‚";
	}

	/// <summary>
	/// Key: "Label.InstructionAllowReceiveNotifications"
	/// Now just click {startBold}Allow{endBold} in your browser, and we'll start sending you push notifications!
	/// English String: "Now just click {startBold}Allow{endBold} in your browser, and we'll start sending you push notifications!"
	/// </summary>
	public override string LabelInstructionAllowReceiveNotifications(string startBold, string endBold)
	{
		return $"ãƒ–ãƒ©ã‚¦ã‚¶ã§ã€Œ{startBold}è¨±å¯{endBold}ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã™ã‚‹ã¨ã€ãƒ—ãƒƒã‚·ãƒ¥é€šçŸ¥ã®é€ä¿¡ã‚’é–‹å§‹ã—ã¾ã™ï¼";
	}

	protected override string _GetTemplateForLabelInstructionAllowReceiveNotifications()
	{
		return "ãƒ–ãƒ©ã‚¦ã‚¶ã§ã€Œ{startBold}è¨±å¯{endBold}ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã™ã‚‹ã¨ã€ãƒ—ãƒƒã‚·ãƒ¥é€šçŸ¥ã®é€ä¿¡ã‚’é–‹å§‹ã—ã¾ã™ï¼";
	}

	/// <summary>
	/// Key: "Label.InstructionAlwaysAllowNotificationsBackOn"
	/// Select {startBold}Always allow on this site{endBold} to turn notifications back on.
	/// English String: "Select {startBold}Always allow on this site{endBold} to turn notifications back on."
	/// </summary>
	public override string LabelInstructionAlwaysAllowNotificationsBackOn(string startBold, string endBold)
	{
		return $"é€šçŸ¥ã‚’ã‚ªãƒ³ã«æˆ»ã™ã«ã¯ã€ã€Œ{startBold}ã“ã®ã‚µã‚¤ãƒˆã§ã¯å¸¸ã«è¨±å¯{endBold}ã€ã‚’é¸æŠžã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForLabelInstructionAlwaysAllowNotificationsBackOn()
	{
		return "é€šçŸ¥ã‚’ã‚ªãƒ³ã«æˆ»ã™ã«ã¯ã€ã€Œ{startBold}ã“ã®ã‚µã‚¤ãƒˆã§ã¯å¸¸ã«è¨±å¯{endBold}ã€ã‚’é¸æŠžã—ã¦ãã ã•ã„ã€‚";
	}

	/// <summary>
	/// Key: "Label.InstructionAlwaysReceiveNotifications"
	/// Now just click {startBold}Always Receive Notifications{endBold} in your browser, and we'll start sending you push notifications!
	/// English String: "Now just click {startBold}Always Receive Notifications{endBold} in your browser, and we'll start sending you push notifications!"
	/// </summary>
	public override string LabelInstructionAlwaysReceiveNotifications(string startBold, string endBold)
	{
		return $"ãƒ–ãƒ©ã‚¦ã‚¶ã§ã€Œ{startBold}å¸¸ã«é€šçŸ¥ã‚’å—ã‘å–ã‚‹{endBold}ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã™ã‚‹ã¨ã€ãƒ—ãƒƒã‚·ãƒ¥é€šçŸ¥ã®é€ä¿¡ã‚’é–‹å§‹ã—ã¾ã™ï¼";
	}

	protected override string _GetTemplateForLabelInstructionAlwaysReceiveNotifications()
	{
		return "ãƒ–ãƒ©ã‚¦ã‚¶ã§ã€Œ{startBold}å¸¸ã«é€šçŸ¥ã‚’å—ã‘å–ã‚‹{endBold}ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã™ã‚‹ã¨ã€ãƒ—ãƒƒã‚·ãƒ¥é€šçŸ¥ã®é€ä¿¡ã‚’é–‹å§‹ã—ã¾ã™ï¼";
	}

	/// <summary>
	/// Key: "Label.InstructionClickPermissionDropdown"
	/// Click the drop-down arrow next to Notifications in the {startBold}Permissions{endBold} tab.
	/// English String: "Click the drop-down arrow next to Notifications in the {startBold}Permissions{endBold} tab."
	/// </summary>
	public override string LabelInstructionClickPermissionDropdown(string startBold, string endBold)
	{
		return $"{startBold}è¨±å¯{endBold}ã‚¿ãƒ–ã®ã€Œé€šçŸ¥ã€ã®æ¨ªã«ã‚ã‚‹ãƒ‰ãƒ­ãƒƒãƒ—ãƒ€ã‚¦ãƒ³ã®çŸ¢å°ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¾ã™ã€‚";
	}

	protected override string _GetTemplateForLabelInstructionClickPermissionDropdown()
	{
		return "{startBold}è¨±å¯{endBold}ã‚¿ãƒ–ã®ã€Œé€šçŸ¥ã€ã®æ¨ªã«ã‚ã‚‹ãƒ‰ãƒ­ãƒƒãƒ—ãƒ€ã‚¦ãƒ³ã®çŸ¢å°ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¾ã™ã€‚";
	}

	protected override string _GetTemplateForMessagePushNotificationsDisabledSuccess()
	{
		return "ãƒ—ãƒƒã‚·ãƒ¥é€šçŸ¥ãŒç„¡åŠ¹ã«ãªã‚Šã¾ã—ãŸï¼";
	}

	protected override string _GetTemplateForMessagePushNotificationsEnabledSuccess()
	{
		return "ãƒ—ãƒƒã‚·ãƒ¥é€šçŸ¥ãŒæœ‰åŠ¹ã«ãªã‚Šã¾ã—ãŸï¼";
	}

	protected override string _GetTemplateForMessageSendNotificationsPrompt()
	{
		return "ã“ã®ãƒ‘ã‚½ã‚³ãƒ³ã§é€šçŸ¥ã‚’å—ã‘å–ã‚Šã¾ã™ã‹ã€‚";
	}
}


}
