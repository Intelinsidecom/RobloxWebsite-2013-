namespace Roblox.Platform.TranslationResources.Notifications {
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
	public override string ActionAcceptNotificationPrompt => "é€šçŸ¥æˆ‘";

	/// <summary>
	/// Key: "Action.Close"
	/// Close
	/// English String: "Close"
	/// </summary>
	public override string ActionClose => "å…³é—­";

	/// <summary>
	/// Key: "Heading.TurnNotificationsBackOn"
	/// Turn Push Notifications Back On
	/// English String: "Turn Push Notifications Back On"
	/// </summary>
	public override string HeadingTurnNotificationsBackOn => "é‡æ–°å¼€å¯æŽ¨é€é€šçŸ¥";

	/// <summary>
	/// Key: "Heading.TurnNotificationsOn"
	/// Enable Desktop Push Notifications
	/// English String: "Enable Desktop Push Notifications"
	/// </summary>
	public override string HeadingTurnNotificationsOn => "å¯ç”¨æ¡Œé¢æŽ¨é€é€šçŸ¥";

	/// <summary>
	/// Key: "Label.ClickGreenLockOnUrl"
	/// Click the green lock next to the URL bar to open up your site permissions.
	/// English String: "Click the green lock next to the URL bar to open up your site permissions."
	/// </summary>
	public override string LabelClickGreenLockOnUrl => "ç‚¹æŒ‰ URL æ æ—è¾¹çš„ç»¿è‰²é”ï¼Œå¼€å¯ä½ çš„ç½‘ç«™æƒé™ã€‚";

	/// <summary>
	/// Key: "Message.PushNotificationsDisabledSuccess"
	/// Push notifications have been disabled.
	/// English String: "Push notifications have been disabled."
	/// </summary>
	public override string MessagePushNotificationsDisabledSuccess => "æŽ¨é€é€šçŸ¥å·²åœç”¨ã€‚";

	/// <summary>
	/// Key: "Message.PushNotificationsEnabledSuccess"
	/// Push notifications have been enabled!
	/// English String: "Push notifications have been enabled!"
	/// </summary>
	public override string MessagePushNotificationsEnabledSuccess => "æŽ¨é€é€šçŸ¥å·²å¯ç”¨ï¼";

	/// <summary>
	/// Key: "Message.SendNotificationsPrompt"
	/// Can we send you notifications on this computer?
	/// English String: "Can we send you notifications on this computer?"
	/// </summary>
	public override string MessageSendNotificationsPrompt => "æˆ‘ä»¬æ˜¯å¦å¯å°†é€šçŸ¥å‘é€è‡³è¿™å°ç”µè„‘?";

	public DesktopPushNotificationPromptsResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAcceptNotificationPrompt()
	{
		return "é€šçŸ¥æˆ‘";
	}

	protected override string _GetTemplateForActionClose()
	{
		return "å…³é—­";
	}

	protected override string _GetTemplateForHeadingTurnNotificationsBackOn()
	{
		return "é‡æ–°å¼€å¯æŽ¨é€é€šçŸ¥";
	}

	protected override string _GetTemplateForHeadingTurnNotificationsOn()
	{
		return "å¯ç”¨æ¡Œé¢æŽ¨é€é€šçŸ¥";
	}

	protected override string _GetTemplateForLabelClickGreenLockOnUrl()
	{
		return "ç‚¹æŒ‰ URL æ æ—è¾¹çš„ç»¿è‰²é”ï¼Œå¼€å¯ä½ çš„ç½‘ç«™æƒé™ã€‚";
	}

	/// <summary>
	/// Key: "Label.InstructionAllowNotificationsBackOn"
	/// Select {startBold}Allow{endBold} to turn notifications back on.
	/// English String: "Select {startBold}Allow{endBold} to turn notifications back on."
	/// </summary>
	public override string LabelInstructionAllowNotificationsBackOn(string startBold, string endBold)
	{
		return $"é€‰æ‹©{startBold}å…è®¸{endBold}ä»¥é‡æ–°å¼€å¯é€šçŸ¥åŠŸèƒ½ã€‚";
	}

	protected override string _GetTemplateForLabelInstructionAllowNotificationsBackOn()
	{
		return "é€‰æ‹©{startBold}å…è®¸{endBold}ä»¥é‡æ–°å¼€å¯é€šçŸ¥åŠŸèƒ½ã€‚";
	}

	/// <summary>
	/// Key: "Label.InstructionAllowReceiveNotifications"
	/// Now just click {startBold}Allow{endBold} in your browser, and we'll start sending you push notifications!
	/// English String: "Now just click {startBold}Allow{endBold} in your browser, and we'll start sending you push notifications!"
	/// </summary>
	public override string LabelInstructionAllowReceiveNotifications(string startBold, string endBold)
	{
		return $"çŽ°åœ¨åªè¦åœ¨ä½ çš„æµè§ˆå™¨ä¸­ç‚¹å‡»{startBold}å…è®¸{endBold}ï¼Œæˆ‘ä»¬å°±ä¼šå¼€å§‹å‘é€æŽ¨é€é€šçŸ¥ç»™ä½ äº†ï¼";
	}

	protected override string _GetTemplateForLabelInstructionAllowReceiveNotifications()
	{
		return "çŽ°åœ¨åªè¦åœ¨ä½ çš„æµè§ˆå™¨ä¸­ç‚¹å‡»{startBold}å…è®¸{endBold}ï¼Œæˆ‘ä»¬å°±ä¼šå¼€å§‹å‘é€æŽ¨é€é€šçŸ¥ç»™ä½ äº†ï¼";
	}

	/// <summary>
	/// Key: "Label.InstructionAlwaysAllowNotificationsBackOn"
	/// Select {startBold}Always allow on this site{endBold} to turn notifications back on.
	/// English String: "Select {startBold}Always allow on this site{endBold} to turn notifications back on."
	/// </summary>
	public override string LabelInstructionAlwaysAllowNotificationsBackOn(string startBold, string endBold)
	{
		return $"é€‰æ‹©{startBold}æ­¤ç½‘ç«™å§‹ç»ˆå…è®¸{endBold}ä»¥é‡æ–°å¼€å¯é€šçŸ¥åŠŸèƒ½ã€‚";
	}

	protected override string _GetTemplateForLabelInstructionAlwaysAllowNotificationsBackOn()
	{
		return "é€‰æ‹©{startBold}æ­¤ç½‘ç«™å§‹ç»ˆå…è®¸{endBold}ä»¥é‡æ–°å¼€å¯é€šçŸ¥åŠŸèƒ½ã€‚";
	}

	/// <summary>
	/// Key: "Label.InstructionAlwaysReceiveNotifications"
	/// Now just click {startBold}Always Receive Notifications{endBold} in your browser, and we'll start sending you push notifications!
	/// English String: "Now just click {startBold}Always Receive Notifications{endBold} in your browser, and we'll start sending you push notifications!"
	/// </summary>
	public override string LabelInstructionAlwaysReceiveNotifications(string startBold, string endBold)
	{
		return $"çŽ°åœ¨åªè¦åœ¨ä½ çš„æµè§ˆå™¨ä¸­ç‚¹å‡»{startBold}å§‹ç»ˆæŽ¥æ”¶é€šçŸ¥{endBold}ï¼Œæˆ‘ä»¬å°±ä¼šå¼€å§‹å‘é€æŽ¨é€é€šçŸ¥ç»™ä½ äº†ï¼";
	}

	protected override string _GetTemplateForLabelInstructionAlwaysReceiveNotifications()
	{
		return "çŽ°åœ¨åªè¦åœ¨ä½ çš„æµè§ˆå™¨ä¸­ç‚¹å‡»{startBold}å§‹ç»ˆæŽ¥æ”¶é€šçŸ¥{endBold}ï¼Œæˆ‘ä»¬å°±ä¼šå¼€å§‹å‘é€æŽ¨é€é€šçŸ¥ç»™ä½ äº†ï¼";
	}

	/// <summary>
	/// Key: "Label.InstructionClickPermissionDropdown"
	/// Click the drop-down arrow next to Notifications in the {startBold}Permissions{endBold} tab.
	/// English String: "Click the drop-down arrow next to Notifications in the {startBold}Permissions{endBold} tab."
	/// </summary>
	public override string LabelInstructionClickPermissionDropdown(string startBold, string endBold)
	{
		return $"åœ¨{startBold}æƒé™{endBold}æ ‡ç­¾ä¸­ï¼Œç‚¹æŒ‰â€œé€šçŸ¥â€æ—è¾¹çš„ä¸‹æ‹‰ç®­å¤´ã€‚";
	}

	protected override string _GetTemplateForLabelInstructionClickPermissionDropdown()
	{
		return "åœ¨{startBold}æƒé™{endBold}æ ‡ç­¾ä¸­ï¼Œç‚¹æŒ‰â€œé€šçŸ¥â€æ—è¾¹çš„ä¸‹æ‹‰ç®­å¤´ã€‚";
	}

	protected override string _GetTemplateForMessagePushNotificationsDisabledSuccess()
	{
		return "æŽ¨é€é€šçŸ¥å·²åœç”¨ã€‚";
	}

	protected override string _GetTemplateForMessagePushNotificationsEnabledSuccess()
	{
		return "æŽ¨é€é€šçŸ¥å·²å¯ç”¨ï¼";
	}

	protected override string _GetTemplateForMessageSendNotificationsPrompt()
	{
		return "æˆ‘ä»¬æ˜¯å¦å¯å°†é€šçŸ¥å‘é€è‡³è¿™å°ç”µè„‘?";
	}
}


}
