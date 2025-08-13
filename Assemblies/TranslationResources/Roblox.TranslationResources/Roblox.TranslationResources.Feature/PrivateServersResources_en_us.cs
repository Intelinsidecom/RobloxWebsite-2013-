using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class PrivateServersResources_en_us : TranslationResourcesBase, IPrivateServersResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.CreateVipServer"
	/// English String: "Create VIP Server"
	/// </summary>
	public virtual string ActionCreateVipServer => "Create VIP Server";

	/// <summary>
	/// Key: "Action.Refresh"
	/// English String: "Refresh"
	/// </summary>
	public virtual string ActionRefresh => "Refresh";

	/// <summary>
	/// Key: "Heading.InvalidLink"
	/// Dialog title when the link to a VIP server is invalid
	/// English String: "Invalid Link"
	/// </summary>
	public virtual string HeadingInvalidLink => "Invalid Link";

	/// <summary>
	/// Key: "Heading.VipServers"
	/// English String: "VIP Servers"
	/// </summary>
	public virtual string HeadingVipServers => "VIP Servers";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public virtual string LabelCancel => "Cancel";

	/// <summary>
	/// Key: "Label.GameJoinPrivateErrorTitle"
	/// Title of error window when trying to join a private server user does not have access to.
	/// English String: "Unable to join"
	/// </summary>
	public virtual string LabelGameJoinPrivateErrorTitle => "Unable to join";

	/// <summary>
	/// Key: "Label.GameName"
	/// English String: "Game Name"
	/// </summary>
	public virtual string LabelGameName => "Game Name";

	/// <summary>
	/// Key: "Label.NoVipServers"
	/// No VIP Server Instances Found.
	/// English String: "No VIP Server Instances Found."
	/// </summary>
	public virtual string LabelNoVipServers => "No VIP Server Instances Found.";

	/// <summary>
	/// Key: "Label.PlayWithOthers"
	/// English String: "Play this game with friends and other people you invite."
	/// </summary>
	public virtual string LabelPlayWithOthers => "Play this game with friends and other people you invite.";

	/// <summary>
	/// Key: "Label.Renew"
	/// English String: "Renew"
	/// </summary>
	public virtual string LabelRenew => "Renew";

	/// <summary>
	/// Key: "Label.RenewPrivateServer"
	/// English String: "Renew Private Server"
	/// </summary>
	public virtual string LabelRenewPrivateServer => "Renew Private Server";

	/// <summary>
	/// Key: "Label.ServerName"
	/// English String: "Server Name"
	/// </summary>
	public virtual string LabelServerName => "Server Name";

	/// <summary>
	/// Key: "Label.Servers"
	/// English String: "Servers"
	/// </summary>
	public virtual string LabelServers => "Servers";

	/// <summary>
	/// Key: "Label.VIPServerGameJoinErrorAcknowledgement"
	/// Confirmation text for game join private error dialog.
	/// English String: "OK"
	/// </summary>
	public virtual string LabelVIPServerGameJoinErrorAcknowledgement => "OK";

	/// <summary>
	/// Key: "Label.VipServerJoinGamePrivateError"
	/// Error when user wants to join a VIP server when the game is marked private
	/// English String: "You cannot join this VIP server because the game is private."
	/// </summary>
	public virtual string LabelVipServerJoinGamePrivateError => "You cannot join this VIP server because the game is private.";

	/// <summary>
	/// Key: "Label.VipServersAbout"
	/// English String: "VIP servers let you play this game privately with friends, your clan, or people you invite!"
	/// </summary>
	public virtual string LabelVipServersAbout => "VIP servers let you play this game privately with friends, your clan, or people you invite!";

	/// <summary>
	/// Key: "Message.InvalidLink"
	/// Dialog content when the link to a VIP server is invalid
	/// English String: "This VIP Server link is no longer valid."
	/// </summary>
	public virtual string MessageInvalidLink => "This VIP Server link is no longer valid.";

	public PrivateServersResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.CreateVipServer",
				_GetTemplateForActionCreateVipServer()
			},
			{
				"Action.Refresh",
				_GetTemplateForActionRefresh()
			},
			{
				"Heading.InvalidLink",
				_GetTemplateForHeadingInvalidLink()
			},
			{
				"Heading.VipServers",
				_GetTemplateForHeadingVipServers()
			},
			{
				"Label.Cancel",
				_GetTemplateForLabelCancel()
			},
			{
				"Label.ConfirmEnableFuturePayments",
				_GetTemplateForLabelConfirmEnableFuturePayments()
			},
			{
				"Label.CreateVipServerFor",
				_GetTemplateForLabelCreateVipServerFor()
			},
			{
				"Label.FooterText",
				_GetTemplateForLabelFooterText()
			},
			{
				"Label.GameJoinPrivateErrorTitle",
				_GetTemplateForLabelGameJoinPrivateErrorTitle()
			},
			{
				"Label.GameName",
				_GetTemplateForLabelGameName()
			},
			{
				"Label.NoVipServers",
				_GetTemplateForLabelNoVipServers()
			},
			{
				"Label.PlayWithOthers",
				_GetTemplateForLabelPlayWithOthers()
			},
			{
				"Label.Renew",
				_GetTemplateForLabelRenew()
			},
			{
				"Label.RenewPrivateServer",
				_GetTemplateForLabelRenewPrivateServer()
			},
			{
				"Label.SeeAllServers",
				_GetTemplateForLabelSeeAllServers()
			},
			{
				"Label.ServerName",
				_GetTemplateForLabelServerName()
			},
			{
				"Label.Servers",
				_GetTemplateForLabelServers()
			},
			{
				"Label.StartRenewingPrice",
				_GetTemplateForLabelStartRenewingPrice()
			},
			{
				"Label.VIPServerGameJoinErrorAcknowledgement",
				_GetTemplateForLabelVIPServerGameJoinErrorAcknowledgement()
			},
			{
				"Label.VipServerJoinGamePrivateError",
				_GetTemplateForLabelVipServerJoinGamePrivateError()
			},
			{
				"Label.VipServersAbout",
				_GetTemplateForLabelVipServersAbout()
			},
			{
				"Label.VipServersNotSupported",
				_GetTemplateForLabelVipServersNotSupported()
			},
			{
				"Message.InvalidLink",
				_GetTemplateForMessageInvalidLink()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.PrivateServers";
	}

	protected virtual string _GetTemplateForActionCreateVipServer()
	{
		return "Create VIP Server";
	}

	protected virtual string _GetTemplateForActionRefresh()
	{
		return "Refresh";
	}

	protected virtual string _GetTemplateForHeadingInvalidLink()
	{
		return "Invalid Link";
	}

	protected virtual string _GetTemplateForHeadingVipServers()
	{
		return "VIP Servers";
	}

	protected virtual string _GetTemplateForLabelCancel()
	{
		return "Cancel";
	}

	/// <summary>
	/// Key: "Label.ConfirmEnableFuturePayments"
	/// English String: "Are you sure you want to enable future payments for your private VIP version of {placeName} by {creatorName}?"
	/// </summary>
	public virtual string LabelConfirmEnableFuturePayments(string placeName, string creatorName)
	{
		return $"Are you sure you want to enable future payments for your private VIP version of {placeName} by {creatorName}?";
	}

	protected virtual string _GetTemplateForLabelConfirmEnableFuturePayments()
	{
		return "Are you sure you want to enable future payments for your private VIP version of {placeName} by {creatorName}?";
	}

	/// <summary>
	/// Key: "Label.CreateVipServerFor"
	/// English String: "Create a VIP Server for {target}?"
	/// </summary>
	public virtual string LabelCreateVipServerFor(string target)
	{
		return $"Create a VIP Server for {target}?";
	}

	protected virtual string _GetTemplateForLabelCreateVipServerFor()
	{
		return "Create a VIP Server for {target}?";
	}

	/// <summary>
	/// Key: "Label.FooterText"
	/// English String: "Your balance after this transaction will be {robuxIcon}. This is a subscription-based feature. It will auto-renew once a month until you cancel the subscription."
	/// </summary>
	public virtual string LabelFooterText(string robuxIcon)
	{
		return $"Your balance after this transaction will be {robuxIcon}. This is a subscription-based feature. It will auto-renew once a month until you cancel the subscription.";
	}

	protected virtual string _GetTemplateForLabelFooterText()
	{
		return "Your balance after this transaction will be {robuxIcon}. This is a subscription-based feature. It will auto-renew once a month until you cancel the subscription.";
	}

	protected virtual string _GetTemplateForLabelGameJoinPrivateErrorTitle()
	{
		return "Unable to join";
	}

	protected virtual string _GetTemplateForLabelGameName()
	{
		return "Game Name";
	}

	protected virtual string _GetTemplateForLabelNoVipServers()
	{
		return "No VIP Server Instances Found.";
	}

	protected virtual string _GetTemplateForLabelPlayWithOthers()
	{
		return "Play this game with friends and other people you invite.";
	}

	protected virtual string _GetTemplateForLabelRenew()
	{
		return "Renew";
	}

	protected virtual string _GetTemplateForLabelRenewPrivateServer()
	{
		return "Renew Private Server";
	}

	/// <summary>
	/// Key: "Label.SeeAllServers"
	/// English String: "See all your VIP servers in the {serversLink} tab."
	/// </summary>
	public virtual string LabelSeeAllServers(string serversLink)
	{
		return $"See all your VIP servers in the {serversLink} tab.";
	}

	protected virtual string _GetTemplateForLabelSeeAllServers()
	{
		return "See all your VIP servers in the {serversLink} tab.";
	}

	protected virtual string _GetTemplateForLabelServerName()
	{
		return "Server Name";
	}

	protected virtual string _GetTemplateForLabelServers()
	{
		return "Servers";
	}

	/// <summary>
	/// Key: "Label.StartRenewingPrice"
	/// English String: "This VIP Server will start renewing every month at {price} until you cancel."
	/// </summary>
	public virtual string LabelStartRenewingPrice(string price)
	{
		return $"This VIP Server will start renewing every month at {price} until you cancel.";
	}

	protected virtual string _GetTemplateForLabelStartRenewingPrice()
	{
		return "This VIP Server will start renewing every month at {price} until you cancel.";
	}

	protected virtual string _GetTemplateForLabelVIPServerGameJoinErrorAcknowledgement()
	{
		return "OK";
	}

	protected virtual string _GetTemplateForLabelVipServerJoinGamePrivateError()
	{
		return "You cannot join this VIP server because the game is private.";
	}

	protected virtual string _GetTemplateForLabelVipServersAbout()
	{
		return "VIP servers let you play this game privately with friends, your clan, or people you invite!";
	}

	/// <summary>
	/// Key: "Label.VipServersNotSupported"
	/// English String: "This game does not support {vipServersLink}."
	/// </summary>
	public virtual string LabelVipServersNotSupported(string vipServersLink)
	{
		return $"This game does not support {vipServersLink}.";
	}

	protected virtual string _GetTemplateForLabelVipServersNotSupported()
	{
		return "This game does not support {vipServersLink}.";
	}

	protected virtual string _GetTemplateForMessageInvalidLink()
	{
		return "This VIP Server link is no longer valid.";
	}
}
