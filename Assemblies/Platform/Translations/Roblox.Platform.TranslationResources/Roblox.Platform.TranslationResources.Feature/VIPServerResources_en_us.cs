using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class VIPServerResources_en_us : TranslationResourcesBase, IVIPServerResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.Add"
	/// English String: "Add"
	/// </summary>
	public virtual string ActionAdd => "Add";

	/// <summary>
	/// Key: "Action.AddPlayers"
	/// English String: "Add Players"
	/// </summary>
	public virtual string ActionAddPlayers => "Add Players";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public virtual string ActionCancel => "Cancel";

	/// <summary>
	/// Key: "Action.CancelPayments"
	/// English String: "Cancel Payments"
	/// </summary>
	public virtual string ActionCancelPayments => "Cancel Payments";

	/// <summary>
	/// Key: "Action.ChangeName"
	/// English String: "Change Name"
	/// </summary>
	public virtual string ActionChangeName => "Change Name";

	/// <summary>
	/// Key: "Action.GoBack"
	/// English String: "Go Back"
	/// </summary>
	public virtual string ActionGoBack => "Go Back";

	/// <summary>
	/// Key: "Action.RegenerateJoinLink"
	/// English String: "Regenerate"
	/// </summary>
	public virtual string ActionRegenerateJoinLink => "Regenerate";

	/// <summary>
	/// Key: "Action.Remove"
	/// English String: "Remove"
	/// </summary>
	public virtual string ActionRemove => "Remove";

	/// <summary>
	/// Key: "Action.RenewVipServer"
	/// English String: "Renew VIP Server"
	/// </summary>
	public virtual string ActionRenewVipServer => "Renew VIP Server";

	/// <summary>
	/// Key: "Action.SeeAll"
	/// English String: "See All"
	/// </summary>
	public virtual string ActionSeeAll => "See All";

	/// <summary>
	/// Key: "Heading.CancelPayments"
	/// English String: "Cancel Payments"
	/// </summary>
	public virtual string HeadingCancelPayments => "Cancel Payments";

	/// <summary>
	/// Key: "Heading.ChangeName"
	/// English String: "Change VIP Server Name"
	/// </summary>
	public virtual string HeadingChangeName => "Change VIP Server Name";

	/// <summary>
	/// Key: "Heading.ConfigureVipServer"
	/// English String: "Configure VIP Server"
	/// </summary>
	public virtual string HeadingConfigureVipServer => "Configure VIP Server";

	/// <summary>
	/// Key: "Heading.RemovePlayer"
	/// English String: "Remove Player"
	/// </summary>
	public virtual string HeadingRemovePlayer => "Remove Player";

	/// <summary>
	/// Key: "Heading.RenewVipServer"
	/// English String: "Renew VIP Server"
	/// </summary>
	public virtual string HeadingRenewVipServer => "Renew VIP Server";

	/// <summary>
	/// Key: "Label.ChangeNamePlaceholder"
	/// English String: "VIP Server Name (1-50 Characters)"
	/// </summary>
	public virtual string LabelChangeNamePlaceholder => "VIP Server Name (1-50 Characters)";

	/// <summary>
	/// Key: "Label.ClanAccess"
	/// English String: "Clan Access"
	/// </summary>
	public virtual string LabelClanAccess => "Clan Access";

	/// <summary>
	/// Key: "Label.FriendsAllowed"
	/// English String: "Friends Allowed"
	/// </summary>
	public virtual string LabelFriendsAllowed => "Friends Allowed";

	/// <summary>
	/// Key: "Label.GameName"
	/// English String: "Game Name"
	/// </summary>
	public virtual string LabelGameName => "Game Name";

	/// <summary>
	/// Key: "Label.JoinGameLink"
	/// English String: "Join Game Link..."
	/// </summary>
	public virtual string LabelJoinGameLink => "Join Game Link...";

	/// <summary>
	/// Key: "Label.None"
	/// English String: "None"
	/// </summary>
	public virtual string LabelNone => "None";

	/// <summary>
	/// Key: "Label.Off"
	/// English String: "Off"
	/// </summary>
	public virtual string LabelOff => "Off";

	/// <summary>
	/// Key: "Label.On"
	/// English String: "On"
	/// </summary>
	public virtual string LabelOn => "On";

	/// <summary>
	/// Key: "Label.PickEnemyClan"
	/// English String: "Pick Enemy Clan"
	/// </summary>
	public virtual string LabelPickEnemyClan => "Pick Enemy Clan";

	/// <summary>
	/// Key: "Label.SearchForPlayers"
	/// English String: "Search for Players"
	/// </summary>
	public virtual string LabelSearchForPlayers => "Search for Players";

	/// <summary>
	/// Key: "Label.Server"
	/// English String: "Server"
	/// </summary>
	public virtual string LabelServer => "Server";

	/// <summary>
	/// Key: "Label.ServerMembers"
	/// English String: "Server Members"
	/// </summary>
	public virtual string LabelServerMembers => "Server Members";

	/// <summary>
	/// Key: "Label.SubscriptionStatus"
	/// English String: "Subscription Status"
	/// </summary>
	public virtual string LabelSubscriptionStatus => "Subscription Status";

	/// <summary>
	/// Key: "Label.VIPServerLink"
	/// English String: "VIP Server Link"
	/// </summary>
	public virtual string LabelVIPServerLink => "VIP Server Link";

	/// <summary>
	/// Key: "Label.VIPServerStatus"
	/// English String: "VIP Server Status"
	/// </summary>
	public virtual string LabelVIPServerStatus => "VIP Server Status";

	/// <summary>
	/// Key: "Label.YourClan"
	/// English String: "Your Clan"
	/// </summary>
	public virtual string LabelYourClan => "Your Clan";

	public VIPServerResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.Add",
				_GetTemplateForActionAdd()
			},
			{
				"Action.AddPlayers",
				_GetTemplateForActionAddPlayers()
			},
			{
				"Action.Cancel",
				_GetTemplateForActionCancel()
			},
			{
				"Action.CancelPayments",
				_GetTemplateForActionCancelPayments()
			},
			{
				"Action.ChangeName",
				_GetTemplateForActionChangeName()
			},
			{
				"Action.GoBack",
				_GetTemplateForActionGoBack()
			},
			{
				"Action.RegenerateJoinLink",
				_GetTemplateForActionRegenerateJoinLink()
			},
			{
				"Action.Remove",
				_GetTemplateForActionRemove()
			},
			{
				"Action.RenewVipServer",
				_GetTemplateForActionRenewVipServer()
			},
			{
				"Action.SeeAll",
				_GetTemplateForActionSeeAll()
			},
			{
				"Heading.CancelPayments",
				_GetTemplateForHeadingCancelPayments()
			},
			{
				"Heading.ChangeName",
				_GetTemplateForHeadingChangeName()
			},
			{
				"Heading.ConfigureVipServer",
				_GetTemplateForHeadingConfigureVipServer()
			},
			{
				"Heading.RemovePlayer",
				_GetTemplateForHeadingRemovePlayer()
			},
			{
				"Heading.RenewVipServer",
				_GetTemplateForHeadingRenewVipServer()
			},
			{
				"Label.ChangeNameBodyMessage",
				_GetTemplateForLabelChangeNameBodyMessage()
			},
			{
				"Label.ChangeNamePlaceholder",
				_GetTemplateForLabelChangeNamePlaceholder()
			},
			{
				"Label.ClanAccess",
				_GetTemplateForLabelClanAccess()
			},
			{
				"Label.FriendsAllowed",
				_GetTemplateForLabelFriendsAllowed()
			},
			{
				"Label.GameName",
				_GetTemplateForLabelGameName()
			},
			{
				"Label.JoinGameLink",
				_GetTemplateForLabelJoinGameLink()
			},
			{
				"Label.None",
				_GetTemplateForLabelNone()
			},
			{
				"Label.Off",
				_GetTemplateForLabelOff()
			},
			{
				"Label.On",
				_GetTemplateForLabelOn()
			},
			{
				"Label.PickEnemyClan",
				_GetTemplateForLabelPickEnemyClan()
			},
			{
				"Label.RemovePlayerBodyMessage",
				_GetTemplateForLabelRemovePlayerBodyMessage()
			},
			{
				"Label.RenewVipServerBodyMessageConfirmation",
				_GetTemplateForLabelRenewVipServerBodyMessageConfirmation()
			},
			{
				"Label.RenewVipServerBodyMessageStart",
				_GetTemplateForLabelRenewVipServerBodyMessageStart()
			},
			{
				"Label.SearchForPlayers",
				_GetTemplateForLabelSearchForPlayers()
			},
			{
				"Label.Server",
				_GetTemplateForLabelServer()
			},
			{
				"Label.ServerExpirationDate",
				_GetTemplateForLabelServerExpirationDate()
			},
			{
				"Label.ServerMembers",
				_GetTemplateForLabelServerMembers()
			},
			{
				"Label.SubscriptionChargeDate",
				_GetTemplateForLabelSubscriptionChargeDate()
			},
			{
				"Label.SubscriptionMonthlyPaymentDue",
				_GetTemplateForLabelSubscriptionMonthlyPaymentDue()
			},
			{
				"Label.SubscriptionStatus",
				_GetTemplateForLabelSubscriptionStatus()
			},
			{
				"Label.VIPServerLink",
				_GetTemplateForLabelVIPServerLink()
			},
			{
				"Label.VIPServerStatus",
				_GetTemplateForLabelVIPServerStatus()
			},
			{
				"Label.YourClan",
				_GetTemplateForLabelYourClan()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.VIPServer";
	}

	protected virtual string _GetTemplateForActionAdd()
	{
		return "Add";
	}

	protected virtual string _GetTemplateForActionAddPlayers()
	{
		return "Add Players";
	}

	protected virtual string _GetTemplateForActionCancel()
	{
		return "Cancel";
	}

	protected virtual string _GetTemplateForActionCancelPayments()
	{
		return "Cancel Payments";
	}

	protected virtual string _GetTemplateForActionChangeName()
	{
		return "Change Name";
	}

	protected virtual string _GetTemplateForActionGoBack()
	{
		return "Go Back";
	}

	protected virtual string _GetTemplateForActionRegenerateJoinLink()
	{
		return "Regenerate";
	}

	protected virtual string _GetTemplateForActionRemove()
	{
		return "Remove";
	}

	protected virtual string _GetTemplateForActionRenewVipServer()
	{
		return "Renew VIP Server";
	}

	protected virtual string _GetTemplateForActionSeeAll()
	{
		return "See All";
	}

	protected virtual string _GetTemplateForHeadingCancelPayments()
	{
		return "Cancel Payments";
	}

	protected virtual string _GetTemplateForHeadingChangeName()
	{
		return "Change VIP Server Name";
	}

	protected virtual string _GetTemplateForHeadingConfigureVipServer()
	{
		return "Configure VIP Server";
	}

	protected virtual string _GetTemplateForHeadingRemovePlayer()
	{
		return "Remove Player";
	}

	protected virtual string _GetTemplateForHeadingRenewVipServer()
	{
		return "Renew VIP Server";
	}

	/// <summary>
	/// Key: "Label.ChangeNameBodyMessage"
	/// English String: "Are you sure you want to cancel future payments for your VIP Server of {name} by {creator}? If you cancel, your VIP Server will be deactivated on {date}."
	/// </summary>
	public virtual string LabelChangeNameBodyMessage(string name, string creator, string date)
	{
		return $"Are you sure you want to cancel future payments for your VIP Server of {name} by {creator}? If you cancel, your VIP Server will be deactivated on {date}.";
	}

	protected virtual string _GetTemplateForLabelChangeNameBodyMessage()
	{
		return "Are you sure you want to cancel future payments for your VIP Server of {name} by {creator}? If you cancel, your VIP Server will be deactivated on {date}.";
	}

	protected virtual string _GetTemplateForLabelChangeNamePlaceholder()
	{
		return "VIP Server Name (1-50 Characters)";
	}

	protected virtual string _GetTemplateForLabelClanAccess()
	{
		return "Clan Access";
	}

	protected virtual string _GetTemplateForLabelFriendsAllowed()
	{
		return "Friends Allowed";
	}

	protected virtual string _GetTemplateForLabelGameName()
	{
		return "Game Name";
	}

	protected virtual string _GetTemplateForLabelJoinGameLink()
	{
		return "Join Game Link...";
	}

	protected virtual string _GetTemplateForLabelNone()
	{
		return "None";
	}

	protected virtual string _GetTemplateForLabelOff()
	{
		return "Off";
	}

	protected virtual string _GetTemplateForLabelOn()
	{
		return "On";
	}

	protected virtual string _GetTemplateForLabelPickEnemyClan()
	{
		return "Pick Enemy Clan";
	}

	/// <summary>
	/// Key: "Label.RemovePlayerBodyMessage"
	/// English String: "Are you sure you want to remove {name} from your VIP Server? They will no longer be able to join your VIP Server."
	/// </summary>
	public virtual string LabelRemovePlayerBodyMessage(string name)
	{
		return $"Are you sure you want to remove {name} from your VIP Server? They will no longer be able to join your VIP Server.";
	}

	protected virtual string _GetTemplateForLabelRemovePlayerBodyMessage()
	{
		return "Are you sure you want to remove {name} from your VIP Server? They will no longer be able to join your VIP Server.";
	}

	/// <summary>
	/// Key: "Label.RenewVipServerBodyMessageConfirmation"
	/// English String: "Are you sure you want to enable future payments for your VIP Server of {name} by {creator}?"
	/// </summary>
	public virtual string LabelRenewVipServerBodyMessageConfirmation(string name, string creator)
	{
		return $"Are you sure you want to enable future payments for your VIP Server of {name} by {creator}?";
	}

	protected virtual string _GetTemplateForLabelRenewVipServerBodyMessageConfirmation()
	{
		return "Are you sure you want to enable future payments for your VIP Server of {name} by {creator}?";
	}

	/// <summary>
	/// Key: "Label.RenewVipServerBodyMessageStart"
	/// English String: "This VIP Server will start renewing every month at {date} until you cancel."
	/// </summary>
	public virtual string LabelRenewVipServerBodyMessageStart(string date)
	{
		return $"This VIP Server will start renewing every month at {date} until you cancel.";
	}

	protected virtual string _GetTemplateForLabelRenewVipServerBodyMessageStart()
	{
		return "This VIP Server will start renewing every month at {date} until you cancel.";
	}

	protected virtual string _GetTemplateForLabelSearchForPlayers()
	{
		return "Search for Players";
	}

	protected virtual string _GetTemplateForLabelServer()
	{
		return "Server";
	}

	/// <summary>
	/// Key: "Label.ServerExpirationDate"
	/// English String: "Your VIP Server expired on{date}"
	/// </summary>
	public virtual string LabelServerExpirationDate(string date)
	{
		return $"Your VIP Server expired on{date}";
	}

	protected virtual string _GetTemplateForLabelServerExpirationDate()
	{
		return "Your VIP Server expired on{date}";
	}

	protected virtual string _GetTemplateForLabelServerMembers()
	{
		return "Server Members";
	}

	/// <summary>
	/// Key: "Label.SubscriptionChargeDate"
	/// English String: "You will be charged again on {date}"
	/// </summary>
	public virtual string LabelSubscriptionChargeDate(string date)
	{
		return $"You will be charged again on {date}";
	}

	protected virtual string _GetTemplateForLabelSubscriptionChargeDate()
	{
		return "You will be charged again on {date}";
	}

	/// <summary>
	/// Key: "Label.SubscriptionMonthlyPaymentDue"
	/// English String: "Your VIP Server monthly payment is {value}"
	/// </summary>
	public virtual string LabelSubscriptionMonthlyPaymentDue(string value)
	{
		return $"Your VIP Server monthly payment is {value}";
	}

	protected virtual string _GetTemplateForLabelSubscriptionMonthlyPaymentDue()
	{
		return "Your VIP Server monthly payment is {value}";
	}

	protected virtual string _GetTemplateForLabelSubscriptionStatus()
	{
		return "Subscription Status";
	}

	protected virtual string _GetTemplateForLabelVIPServerLink()
	{
		return "VIP Server Link";
	}

	protected virtual string _GetTemplateForLabelVIPServerStatus()
	{
		return "VIP Server Status";
	}

	protected virtual string _GetTemplateForLabelYourClan()
	{
		return "Your Clan";
	}
}
