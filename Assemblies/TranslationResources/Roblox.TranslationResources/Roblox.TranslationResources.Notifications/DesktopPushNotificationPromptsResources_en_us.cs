using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Notifications;

internal class DesktopPushNotificationPromptsResources_en_us : TranslationResourcesBase, IDesktopPushNotificationPromptsResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.AcceptNotificationPrompt"
	/// Notify Me
	/// English String: "Notify Me"
	/// </summary>
	public virtual string ActionAcceptNotificationPrompt => "Notify Me";

	/// <summary>
	/// Key: "Action.Close"
	/// Close
	/// English String: "Close"
	/// </summary>
	public virtual string ActionClose => "Close";

	/// <summary>
	/// Key: "Heading.TurnNotificationsBackOn"
	/// Turn Push Notifications Back On
	/// English String: "Turn Push Notifications Back On"
	/// </summary>
	public virtual string HeadingTurnNotificationsBackOn => "Turn Push Notifications Back On";

	/// <summary>
	/// Key: "Heading.TurnNotificationsOn"
	/// Enable Desktop Push Notifications
	/// English String: "Enable Desktop Push Notifications"
	/// </summary>
	public virtual string HeadingTurnNotificationsOn => "Enable Desktop Push Notifications";

	/// <summary>
	/// Key: "Label.ClickGreenLockOnUrl"
	/// Click the green lock next to the URL bar to open up your site permissions.
	/// English String: "Click the green lock next to the URL bar to open up your site permissions."
	/// </summary>
	public virtual string LabelClickGreenLockOnUrl => "Click the green lock next to the URL bar to open up your site permissions.";

	/// <summary>
	/// Key: "Message.PushNotificationsDisabledSuccess"
	/// Push notifications have been disabled.
	/// English String: "Push notifications have been disabled."
	/// </summary>
	public virtual string MessagePushNotificationsDisabledSuccess => "Push notifications have been disabled.";

	/// <summary>
	/// Key: "Message.PushNotificationsEnabledSuccess"
	/// Push notifications have been enabled!
	/// English String: "Push notifications have been enabled!"
	/// </summary>
	public virtual string MessagePushNotificationsEnabledSuccess => "Push notifications have been enabled!";

	/// <summary>
	/// Key: "Message.SendNotificationsPrompt"
	/// Can we send you notifications on this computer?
	/// English String: "Can we send you notifications on this computer?"
	/// </summary>
	public virtual string MessageSendNotificationsPrompt => "Can we send you notifications on this computer?";

	public DesktopPushNotificationPromptsResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.AcceptNotificationPrompt",
				_GetTemplateForActionAcceptNotificationPrompt()
			},
			{
				"Action.Close",
				_GetTemplateForActionClose()
			},
			{
				"Heading.TurnNotificationsBackOn",
				_GetTemplateForHeadingTurnNotificationsBackOn()
			},
			{
				"Heading.TurnNotificationsOn",
				_GetTemplateForHeadingTurnNotificationsOn()
			},
			{
				"Label.ClickGreenLockOnUrl",
				_GetTemplateForLabelClickGreenLockOnUrl()
			},
			{
				"Label.InstructionAllowNotificationsBackOn",
				_GetTemplateForLabelInstructionAllowNotificationsBackOn()
			},
			{
				"Label.InstructionAllowReceiveNotifications",
				_GetTemplateForLabelInstructionAllowReceiveNotifications()
			},
			{
				"Label.InstructionAlwaysAllowNotificationsBackOn",
				_GetTemplateForLabelInstructionAlwaysAllowNotificationsBackOn()
			},
			{
				"Label.InstructionAlwaysReceiveNotifications",
				_GetTemplateForLabelInstructionAlwaysReceiveNotifications()
			},
			{
				"Label.InstructionClickPermissionDropdown",
				_GetTemplateForLabelInstructionClickPermissionDropdown()
			},
			{
				"Message.PushNotificationsDisabledSuccess",
				_GetTemplateForMessagePushNotificationsDisabledSuccess()
			},
			{
				"Message.PushNotificationsEnabledSuccess",
				_GetTemplateForMessagePushNotificationsEnabledSuccess()
			},
			{
				"Message.SendNotificationsPrompt",
				_GetTemplateForMessageSendNotificationsPrompt()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Notifications.DesktopPushNotificationPrompts";
	}

	protected virtual string _GetTemplateForActionAcceptNotificationPrompt()
	{
		return "Notify Me";
	}

	protected virtual string _GetTemplateForActionClose()
	{
		return "Close";
	}

	protected virtual string _GetTemplateForHeadingTurnNotificationsBackOn()
	{
		return "Turn Push Notifications Back On";
	}

	protected virtual string _GetTemplateForHeadingTurnNotificationsOn()
	{
		return "Enable Desktop Push Notifications";
	}

	protected virtual string _GetTemplateForLabelClickGreenLockOnUrl()
	{
		return "Click the green lock next to the URL bar to open up your site permissions.";
	}

	/// <summary>
	/// Key: "Label.InstructionAllowNotificationsBackOn"
	/// Select {startBold}Allow{endBold} to turn notifications back on.
	/// English String: "Select {startBold}Allow{endBold} to turn notifications back on."
	/// </summary>
	public virtual string LabelInstructionAllowNotificationsBackOn(string startBold, string endBold)
	{
		return $"Select {startBold}Allow{endBold} to turn notifications back on.";
	}

	protected virtual string _GetTemplateForLabelInstructionAllowNotificationsBackOn()
	{
		return "Select {startBold}Allow{endBold} to turn notifications back on.";
	}

	/// <summary>
	/// Key: "Label.InstructionAllowReceiveNotifications"
	/// Now just click {startBold}Allow{endBold} in your browser, and we'll start sending you push notifications!
	/// English String: "Now just click {startBold}Allow{endBold} in your browser, and we'll start sending you push notifications!"
	/// </summary>
	public virtual string LabelInstructionAllowReceiveNotifications(string startBold, string endBold)
	{
		return $"Now just click {startBold}Allow{endBold} in your browser, and we'll start sending you push notifications!";
	}

	protected virtual string _GetTemplateForLabelInstructionAllowReceiveNotifications()
	{
		return "Now just click {startBold}Allow{endBold} in your browser, and we'll start sending you push notifications!";
	}

	/// <summary>
	/// Key: "Label.InstructionAlwaysAllowNotificationsBackOn"
	/// Select {startBold}Always allow on this site{endBold} to turn notifications back on.
	/// English String: "Select {startBold}Always allow on this site{endBold} to turn notifications back on."
	/// </summary>
	public virtual string LabelInstructionAlwaysAllowNotificationsBackOn(string startBold, string endBold)
	{
		return $"Select {startBold}Always allow on this site{endBold} to turn notifications back on.";
	}

	protected virtual string _GetTemplateForLabelInstructionAlwaysAllowNotificationsBackOn()
	{
		return "Select {startBold}Always allow on this site{endBold} to turn notifications back on.";
	}

	/// <summary>
	/// Key: "Label.InstructionAlwaysReceiveNotifications"
	/// Now just click {startBold}Always Receive Notifications{endBold} in your browser, and we'll start sending you push notifications!
	/// English String: "Now just click {startBold}Always Receive Notifications{endBold} in your browser, and we'll start sending you push notifications!"
	/// </summary>
	public virtual string LabelInstructionAlwaysReceiveNotifications(string startBold, string endBold)
	{
		return $"Now just click {startBold}Always Receive Notifications{endBold} in your browser, and we'll start sending you push notifications!";
	}

	protected virtual string _GetTemplateForLabelInstructionAlwaysReceiveNotifications()
	{
		return "Now just click {startBold}Always Receive Notifications{endBold} in your browser, and we'll start sending you push notifications!";
	}

	/// <summary>
	/// Key: "Label.InstructionClickPermissionDropdown"
	/// Click the drop-down arrow next to Notifications in the {startBold}Permissions{endBold} tab.
	/// English String: "Click the drop-down arrow next to Notifications in the {startBold}Permissions{endBold} tab."
	/// </summary>
	public virtual string LabelInstructionClickPermissionDropdown(string startBold, string endBold)
	{
		return $"Click the drop-down arrow next to Notifications in the {startBold}Permissions{endBold} tab.";
	}

	protected virtual string _GetTemplateForLabelInstructionClickPermissionDropdown()
	{
		return "Click the drop-down arrow next to Notifications in the {startBold}Permissions{endBold} tab.";
	}

	protected virtual string _GetTemplateForMessagePushNotificationsDisabledSuccess()
	{
		return "Push notifications have been disabled.";
	}

	protected virtual string _GetTemplateForMessagePushNotificationsEnabledSuccess()
	{
		return "Push notifications have been enabled!";
	}

	protected virtual string _GetTemplateForMessageSendNotificationsPrompt()
	{
		return "Can we send you notifications on this computer?";
	}
}
