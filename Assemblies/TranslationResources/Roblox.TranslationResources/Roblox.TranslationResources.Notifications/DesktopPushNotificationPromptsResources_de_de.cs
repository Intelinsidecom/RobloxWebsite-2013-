namespace Roblox.TranslationResources.Notifications;

/// <summary>
/// This class overrides DesktopPushNotificationPromptsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class DesktopPushNotificationPromptsResources_de_de : DesktopPushNotificationPromptsResources_en_us, IDesktopPushNotificationPromptsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AcceptNotificationPrompt"
	/// Notify Me
	/// English String: "Notify Me"
	/// </summary>
	public override string ActionAcceptNotificationPrompt => "Ich möchte eine Benachrichtigung";

	/// <summary>
	/// Key: "Action.Close"
	/// Close
	/// English String: "Close"
	/// </summary>
	public override string ActionClose => "Schließen";

	/// <summary>
	/// Key: "Heading.TurnNotificationsBackOn"
	/// Turn Push Notifications Back On
	/// English String: "Turn Push Notifications Back On"
	/// </summary>
	public override string HeadingTurnNotificationsBackOn => "Push-Benachrichtigungen wieder aktivieren";

	/// <summary>
	/// Key: "Heading.TurnNotificationsOn"
	/// Enable Desktop Push Notifications
	/// English String: "Enable Desktop Push Notifications"
	/// </summary>
	public override string HeadingTurnNotificationsOn => "Desktop-Push-Benachrichtigung aktivieren";

	/// <summary>
	/// Key: "Label.ClickGreenLockOnUrl"
	/// Click the green lock next to the URL bar to open up your site permissions.
	/// English String: "Click the green lock next to the URL bar to open up your site permissions."
	/// </summary>
	public override string LabelClickGreenLockOnUrl => "Klicke auf das grüne Vorhängeschloss neben der URL-Leiste, um die Websiteberechtigungen zu öffnen.";

	/// <summary>
	/// Key: "Message.PushNotificationsDisabledSuccess"
	/// Push notifications have been disabled.
	/// English String: "Push notifications have been disabled."
	/// </summary>
	public override string MessagePushNotificationsDisabledSuccess => "Push-Benachrichtigungen wurden deaktiviert.";

	/// <summary>
	/// Key: "Message.PushNotificationsEnabledSuccess"
	/// Push notifications have been enabled!
	/// English String: "Push notifications have been enabled!"
	/// </summary>
	public override string MessagePushNotificationsEnabledSuccess => "Push-Benachrichtigungen wurden aktiviert!";

	/// <summary>
	/// Key: "Message.SendNotificationsPrompt"
	/// Can we send you notifications on this computer?
	/// English String: "Can we send you notifications on this computer?"
	/// </summary>
	public override string MessageSendNotificationsPrompt => "Dürfen wir dir Benachrichtigungen auf diesem Computer senden?";

	public DesktopPushNotificationPromptsResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAcceptNotificationPrompt()
	{
		return "Ich möchte eine Benachrichtigung";
	}

	protected override string _GetTemplateForActionClose()
	{
		return "Schließen";
	}

	protected override string _GetTemplateForHeadingTurnNotificationsBackOn()
	{
		return "Push-Benachrichtigungen wieder aktivieren";
	}

	protected override string _GetTemplateForHeadingTurnNotificationsOn()
	{
		return "Desktop-Push-Benachrichtigung aktivieren";
	}

	protected override string _GetTemplateForLabelClickGreenLockOnUrl()
	{
		return "Klicke auf das grüne Vorhängeschloss neben der URL-Leiste, um die Websiteberechtigungen zu öffnen.";
	}

	/// <summary>
	/// Key: "Label.InstructionAllowNotificationsBackOn"
	/// Select {startBold}Allow{endBold} to turn notifications back on.
	/// English String: "Select {startBold}Allow{endBold} to turn notifications back on."
	/// </summary>
	public override string LabelInstructionAllowNotificationsBackOn(string startBold, string endBold)
	{
		return $"Wähle {startBold}Erlauben{endBold}, um Benachrichtigungen wieder zu aktivieren.";
	}

	protected override string _GetTemplateForLabelInstructionAllowNotificationsBackOn()
	{
		return "Wähle {startBold}Erlauben{endBold}, um Benachrichtigungen wieder zu aktivieren.";
	}

	/// <summary>
	/// Key: "Label.InstructionAllowReceiveNotifications"
	/// Now just click {startBold}Allow{endBold} in your browser, and we'll start sending you push notifications!
	/// English String: "Now just click {startBold}Allow{endBold} in your browser, and we'll start sending you push notifications!"
	/// </summary>
	public override string LabelInstructionAllowReceiveNotifications(string startBold, string endBold)
	{
		return $"Klicke jetzt einfach in deinem Browser auf {startBold}Erlauben{endBold} und wir werden dir ab sofort Push-Benachrichtigungen senden!";
	}

	protected override string _GetTemplateForLabelInstructionAllowReceiveNotifications()
	{
		return "Klicke jetzt einfach in deinem Browser auf {startBold}Erlauben{endBold} und wir werden dir ab sofort Push-Benachrichtigungen senden!";
	}

	/// <summary>
	/// Key: "Label.InstructionAlwaysAllowNotificationsBackOn"
	/// Select {startBold}Always allow on this site{endBold} to turn notifications back on.
	/// English String: "Select {startBold}Always allow on this site{endBold} to turn notifications back on."
	/// </summary>
	public override string LabelInstructionAlwaysAllowNotificationsBackOn(string startBold, string endBold)
	{
		return $"Wähle {startBold}Auf dieser Website immer erlauben{endBold}, um Benachrichtigungen wieder zu aktivieren.";
	}

	protected override string _GetTemplateForLabelInstructionAlwaysAllowNotificationsBackOn()
	{
		return "Wähle {startBold}Auf dieser Website immer erlauben{endBold}, um Benachrichtigungen wieder zu aktivieren.";
	}

	/// <summary>
	/// Key: "Label.InstructionAlwaysReceiveNotifications"
	/// Now just click {startBold}Always Receive Notifications{endBold} in your browser, and we'll start sending you push notifications!
	/// English String: "Now just click {startBold}Always Receive Notifications{endBold} in your browser, and we'll start sending you push notifications!"
	/// </summary>
	public override string LabelInstructionAlwaysReceiveNotifications(string startBold, string endBold)
	{
		return $"Klicke jetzt einfach in deinem Browser auf {startBold}Benachrichtigungen immer erhalten{endBold} und wir werden dir ab sofort Push-Benachrichtigungen senden!";
	}

	protected override string _GetTemplateForLabelInstructionAlwaysReceiveNotifications()
	{
		return "Klicke jetzt einfach in deinem Browser auf {startBold}Benachrichtigungen immer erhalten{endBold} und wir werden dir ab sofort Push-Benachrichtigungen senden!";
	}

	/// <summary>
	/// Key: "Label.InstructionClickPermissionDropdown"
	/// Click the drop-down arrow next to Notifications in the {startBold}Permissions{endBold} tab.
	/// English String: "Click the drop-down arrow next to Notifications in the {startBold}Permissions{endBold} tab."
	/// </summary>
	public override string LabelInstructionClickPermissionDropdown(string startBold, string endBold)
	{
		return $"Klicke im Reiter {startBold}Berechtigungen{endBold} auf den Dropdownpfeil neben den Benachrichtigungen.";
	}

	protected override string _GetTemplateForLabelInstructionClickPermissionDropdown()
	{
		return "Klicke im Reiter {startBold}Berechtigungen{endBold} auf den Dropdownpfeil neben den Benachrichtigungen.";
	}

	protected override string _GetTemplateForMessagePushNotificationsDisabledSuccess()
	{
		return "Push-Benachrichtigungen wurden deaktiviert.";
	}

	protected override string _GetTemplateForMessagePushNotificationsEnabledSuccess()
	{
		return "Push-Benachrichtigungen wurden aktiviert!";
	}

	protected override string _GetTemplateForMessageSendNotificationsPrompt()
	{
		return "Dürfen wir dir Benachrichtigungen auf diesem Computer senden?";
	}
}
