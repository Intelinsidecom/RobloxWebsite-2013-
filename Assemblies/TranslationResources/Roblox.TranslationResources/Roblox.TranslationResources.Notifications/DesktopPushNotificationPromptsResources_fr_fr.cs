namespace Roblox.TranslationResources.Notifications;

/// <summary>
/// This class overrides DesktopPushNotificationPromptsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class DesktopPushNotificationPromptsResources_fr_fr : DesktopPushNotificationPromptsResources_en_us, IDesktopPushNotificationPromptsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AcceptNotificationPrompt"
	/// Notify Me
	/// English String: "Notify Me"
	/// </summary>
	public override string ActionAcceptNotificationPrompt => "M'avertir";

	/// <summary>
	/// Key: "Action.Close"
	/// Close
	/// English String: "Close"
	/// </summary>
	public override string ActionClose => "Fermer";

	/// <summary>
	/// Key: "Heading.TurnNotificationsBackOn"
	/// Turn Push Notifications Back On
	/// English String: "Turn Push Notifications Back On"
	/// </summary>
	public override string HeadingTurnNotificationsBackOn => "Réactiver les notifications push";

	/// <summary>
	/// Key: "Heading.TurnNotificationsOn"
	/// Enable Desktop Push Notifications
	/// English String: "Enable Desktop Push Notifications"
	/// </summary>
	public override string HeadingTurnNotificationsOn => "Activer les notifications push sur le bureau";

	/// <summary>
	/// Key: "Label.ClickGreenLockOnUrl"
	/// Click the green lock next to the URL bar to open up your site permissions.
	/// English String: "Click the green lock next to the URL bar to open up your site permissions."
	/// </summary>
	public override string LabelClickGreenLockOnUrl => "Cliquez sur le cadenas vert situé à côté de la barre d'adresse afin d'ouvrir les permissions du site.";

	/// <summary>
	/// Key: "Message.PushNotificationsDisabledSuccess"
	/// Push notifications have been disabled.
	/// English String: "Push notifications have been disabled."
	/// </summary>
	public override string MessagePushNotificationsDisabledSuccess => "Les notifications push ont été désactivées.";

	/// <summary>
	/// Key: "Message.PushNotificationsEnabledSuccess"
	/// Push notifications have been enabled!
	/// English String: "Push notifications have been enabled!"
	/// </summary>
	public override string MessagePushNotificationsEnabledSuccess => "Les notifications push ont été activées\u00a0!";

	/// <summary>
	/// Key: "Message.SendNotificationsPrompt"
	/// Can we send you notifications on this computer?
	/// English String: "Can we send you notifications on this computer?"
	/// </summary>
	public override string MessageSendNotificationsPrompt => "Nous autorisez-vous à envoyer des notifications sur cet ordinateur\u00a0?";

	public DesktopPushNotificationPromptsResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAcceptNotificationPrompt()
	{
		return "M'avertir";
	}

	protected override string _GetTemplateForActionClose()
	{
		return "Fermer";
	}

	protected override string _GetTemplateForHeadingTurnNotificationsBackOn()
	{
		return "Réactiver les notifications push";
	}

	protected override string _GetTemplateForHeadingTurnNotificationsOn()
	{
		return "Activer les notifications push sur le bureau";
	}

	protected override string _GetTemplateForLabelClickGreenLockOnUrl()
	{
		return "Cliquez sur le cadenas vert situé à côté de la barre d'adresse afin d'ouvrir les permissions du site.";
	}

	/// <summary>
	/// Key: "Label.InstructionAllowNotificationsBackOn"
	/// Select {startBold}Allow{endBold} to turn notifications back on.
	/// English String: "Select {startBold}Allow{endBold} to turn notifications back on."
	/// </summary>
	public override string LabelInstructionAllowNotificationsBackOn(string startBold, string endBold)
	{
		return $"Sélectionnez {startBold}Autoriser{endBold} afin d'activer de nouveau les notifications.";
	}

	protected override string _GetTemplateForLabelInstructionAllowNotificationsBackOn()
	{
		return "Sélectionnez {startBold}Autoriser{endBold} afin d'activer de nouveau les notifications.";
	}

	/// <summary>
	/// Key: "Label.InstructionAllowReceiveNotifications"
	/// Now just click {startBold}Allow{endBold} in your browser, and we'll start sending you push notifications!
	/// English String: "Now just click {startBold}Allow{endBold} in your browser, and we'll start sending you push notifications!"
	/// </summary>
	public override string LabelInstructionAllowReceiveNotifications(string startBold, string endBold)
	{
		return $"Maintenant, clique sur {startBold}Autoriser{endBold} dans ton navigateur et nous commencerons à t'envoyer des notifications push\u00a0!";
	}

	protected override string _GetTemplateForLabelInstructionAllowReceiveNotifications()
	{
		return "Maintenant, clique sur {startBold}Autoriser{endBold} dans ton navigateur et nous commencerons à t'envoyer des notifications push\u00a0!";
	}

	/// <summary>
	/// Key: "Label.InstructionAlwaysAllowNotificationsBackOn"
	/// Select {startBold}Always allow on this site{endBold} to turn notifications back on.
	/// English String: "Select {startBold}Always allow on this site{endBold} to turn notifications back on."
	/// </summary>
	public override string LabelInstructionAlwaysAllowNotificationsBackOn(string startBold, string endBold)
	{
		return $"Sélectionnez {startBold}Toujours autoriser pour ce site{endBold} afin d'activer de nouveau les notifications.";
	}

	protected override string _GetTemplateForLabelInstructionAlwaysAllowNotificationsBackOn()
	{
		return "Sélectionnez {startBold}Toujours autoriser pour ce site{endBold} afin d'activer de nouveau les notifications.";
	}

	/// <summary>
	/// Key: "Label.InstructionAlwaysReceiveNotifications"
	/// Now just click {startBold}Always Receive Notifications{endBold} in your browser, and we'll start sending you push notifications!
	/// English String: "Now just click {startBold}Always Receive Notifications{endBold} in your browser, and we'll start sending you push notifications!"
	/// </summary>
	public override string LabelInstructionAlwaysReceiveNotifications(string startBold, string endBold)
	{
		return $"Maintenant, clique sur {startBold}Toujours recevoir des notifications{endBold} dans ton navigateur et nous commencerons à t'envoyer des notifications push\u00a0!";
	}

	protected override string _GetTemplateForLabelInstructionAlwaysReceiveNotifications()
	{
		return "Maintenant, clique sur {startBold}Toujours recevoir des notifications{endBold} dans ton navigateur et nous commencerons à t'envoyer des notifications push\u00a0!";
	}

	/// <summary>
	/// Key: "Label.InstructionClickPermissionDropdown"
	/// Click the drop-down arrow next to Notifications in the {startBold}Permissions{endBold} tab.
	/// English String: "Click the drop-down arrow next to Notifications in the {startBold}Permissions{endBold} tab."
	/// </summary>
	public override string LabelInstructionClickPermissionDropdown(string startBold, string endBold)
	{
		return $"Cliquez sur la flèche du menu déroulant à côté de Notifications dans l'onglet {startBold}Autorisations{endBold}.";
	}

	protected override string _GetTemplateForLabelInstructionClickPermissionDropdown()
	{
		return "Cliquez sur la flèche du menu déroulant à côté de Notifications dans l'onglet {startBold}Autorisations{endBold}.";
	}

	protected override string _GetTemplateForMessagePushNotificationsDisabledSuccess()
	{
		return "Les notifications push ont été désactivées.";
	}

	protected override string _GetTemplateForMessagePushNotificationsEnabledSuccess()
	{
		return "Les notifications push ont été activées\u00a0!";
	}

	protected override string _GetTemplateForMessageSendNotificationsPrompt()
	{
		return "Nous autorisez-vous à envoyer des notifications sur cet ordinateur\u00a0?";
	}
}
