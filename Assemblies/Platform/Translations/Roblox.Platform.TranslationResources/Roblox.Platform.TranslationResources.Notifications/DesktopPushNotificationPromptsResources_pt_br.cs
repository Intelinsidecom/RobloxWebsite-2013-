namespace Roblox.Platform.TranslationResources.Notifications {
    /// <summary>

/// This class overrides DesktopPushNotificationPromptsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class DesktopPushNotificationPromptsResources_pt_br : DesktopPushNotificationPromptsResources_en_us, IDesktopPushNotificationPromptsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AcceptNotificationPrompt"
	/// Notify Me
	/// English String: "Notify Me"
	/// </summary>
	public override string ActionAcceptNotificationPrompt => "Avise-me";

	/// <summary>
	/// Key: "Action.Close"
	/// Close
	/// English String: "Close"
	/// </summary>
	public override string ActionClose => "Fechar";

	/// <summary>
	/// Key: "Heading.TurnNotificationsBackOn"
	/// Turn Push Notifications Back On
	/// English String: "Turn Push Notifications Back On"
	/// </summary>
	public override string HeadingTurnNotificationsBackOn => "Reativar notificaÃ§Ãµes push";

	/// <summary>
	/// Key: "Heading.TurnNotificationsOn"
	/// Enable Desktop Push Notifications
	/// English String: "Enable Desktop Push Notifications"
	/// </summary>
	public override string HeadingTurnNotificationsOn => "Habilitar notificaÃ§Ãµes push de desktop";

	/// <summary>
	/// Key: "Label.ClickGreenLockOnUrl"
	/// Click the green lock next to the URL bar to open up your site permissions.
	/// English String: "Click the green lock next to the URL bar to open up your site permissions."
	/// </summary>
	public override string LabelClickGreenLockOnUrl => "Clique no cadeado verde prÃ³ximo Ã  barra de URL para abrir suas permissÃµes do site.";

	/// <summary>
	/// Key: "Message.PushNotificationsDisabledSuccess"
	/// Push notifications have been disabled.
	/// English String: "Push notifications have been disabled."
	/// </summary>
	public override string MessagePushNotificationsDisabledSuccess => "NotificaÃ§Ãµes push desabilitadas.";

	/// <summary>
	/// Key: "Message.PushNotificationsEnabledSuccess"
	/// Push notifications have been enabled!
	/// English String: "Push notifications have been enabled!"
	/// </summary>
	public override string MessagePushNotificationsEnabledSuccess => "NotificaÃ§Ãµes push habilitadas!";

	/// <summary>
	/// Key: "Message.SendNotificationsPrompt"
	/// Can we send you notifications on this computer?
	/// English String: "Can we send you notifications on this computer?"
	/// </summary>
	public override string MessageSendNotificationsPrompt => "Podemos lhe enviar notificaÃ§Ãµes neste computador?";

	public DesktopPushNotificationPromptsResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAcceptNotificationPrompt()
	{
		return "Avise-me";
	}

	protected override string _GetTemplateForActionClose()
	{
		return "Fechar";
	}

	protected override string _GetTemplateForHeadingTurnNotificationsBackOn()
	{
		return "Reativar notificaÃ§Ãµes push";
	}

	protected override string _GetTemplateForHeadingTurnNotificationsOn()
	{
		return "Habilitar notificaÃ§Ãµes push de desktop";
	}

	protected override string _GetTemplateForLabelClickGreenLockOnUrl()
	{
		return "Clique no cadeado verde prÃ³ximo Ã  barra de URL para abrir suas permissÃµes do site.";
	}

	/// <summary>
	/// Key: "Label.InstructionAllowNotificationsBackOn"
	/// Select {startBold}Allow{endBold} to turn notifications back on.
	/// English String: "Select {startBold}Allow{endBold} to turn notifications back on."
	/// </summary>
	public override string LabelInstructionAllowNotificationsBackOn(string startBold, string endBold)
	{
		return $"Selecione {startBold}Permitir{endBold} para reativar as notificaÃ§Ãµes.";
	}

	protected override string _GetTemplateForLabelInstructionAllowNotificationsBackOn()
	{
		return "Selecione {startBold}Permitir{endBold} para reativar as notificaÃ§Ãµes.";
	}

	/// <summary>
	/// Key: "Label.InstructionAllowReceiveNotifications"
	/// Now just click {startBold}Allow{endBold} in your browser, and we'll start sending you push notifications!
	/// English String: "Now just click {startBold}Allow{endBold} in your browser, and we'll start sending you push notifications!"
	/// </summary>
	public override string LabelInstructionAllowReceiveNotifications(string startBold, string endBold)
	{
		return $"Agora Ã© sÃ³ clicar em {startBold}Permitir{endBold}, no seu navegador, e vamos comeÃ§ar a enviar notificaÃ§Ãµes push para vocÃª!";
	}

	protected override string _GetTemplateForLabelInstructionAllowReceiveNotifications()
	{
		return "Agora Ã© sÃ³ clicar em {startBold}Permitir{endBold}, no seu navegador, e vamos comeÃ§ar a enviar notificaÃ§Ãµes push para vocÃª!";
	}

	/// <summary>
	/// Key: "Label.InstructionAlwaysAllowNotificationsBackOn"
	/// Select {startBold}Always allow on this site{endBold} to turn notifications back on.
	/// English String: "Select {startBold}Always allow on this site{endBold} to turn notifications back on."
	/// </summary>
	public override string LabelInstructionAlwaysAllowNotificationsBackOn(string startBold, string endBold)
	{
		return $"Selecione {startBold}Sempre permitir neste site{endBold} para reativar as notificaÃ§Ãµes.";
	}

	protected override string _GetTemplateForLabelInstructionAlwaysAllowNotificationsBackOn()
	{
		return "Selecione {startBold}Sempre permitir neste site{endBold} para reativar as notificaÃ§Ãµes.";
	}

	/// <summary>
	/// Key: "Label.InstructionAlwaysReceiveNotifications"
	/// Now just click {startBold}Always Receive Notifications{endBold} in your browser, and we'll start sending you push notifications!
	/// English String: "Now just click {startBold}Always Receive Notifications{endBold} in your browser, and we'll start sending you push notifications!"
	/// </summary>
	public override string LabelInstructionAlwaysReceiveNotifications(string startBold, string endBold)
	{
		return $"Agora Ã© sÃ³ clicar em {startBold}Sempre receber notificaÃ§Ãµes{endBold}, no seu navegador, e vamos comeÃ§ar a enviar notificaÃ§Ãµes push para vocÃª!";
	}

	protected override string _GetTemplateForLabelInstructionAlwaysReceiveNotifications()
	{
		return "Agora Ã© sÃ³ clicar em {startBold}Sempre receber notificaÃ§Ãµes{endBold}, no seu navegador, e vamos comeÃ§ar a enviar notificaÃ§Ãµes push para vocÃª!";
	}

	/// <summary>
	/// Key: "Label.InstructionClickPermissionDropdown"
	/// Click the drop-down arrow next to Notifications in the {startBold}Permissions{endBold} tab.
	/// English String: "Click the drop-down arrow next to Notifications in the {startBold}Permissions{endBold} tab."
	/// </summary>
	public override string LabelInstructionClickPermissionDropdown(string startBold, string endBold)
	{
		return $"Clique na seta suspensa, prÃ³xima a NotificaÃ§Ãµes, na aba {startBold}PermissÃµes{endBold}.";
	}

	protected override string _GetTemplateForLabelInstructionClickPermissionDropdown()
	{
		return "Clique na seta suspensa, prÃ³xima a NotificaÃ§Ãµes, na aba {startBold}PermissÃµes{endBold}.";
	}

	protected override string _GetTemplateForMessagePushNotificationsDisabledSuccess()
	{
		return "NotificaÃ§Ãµes push desabilitadas.";
	}

	protected override string _GetTemplateForMessagePushNotificationsEnabledSuccess()
	{
		return "NotificaÃ§Ãµes push habilitadas!";
	}

	protected override string _GetTemplateForMessageSendNotificationsPrompt()
	{
		return "Podemos lhe enviar notificaÃ§Ãµes neste computador?";
	}
}


}
