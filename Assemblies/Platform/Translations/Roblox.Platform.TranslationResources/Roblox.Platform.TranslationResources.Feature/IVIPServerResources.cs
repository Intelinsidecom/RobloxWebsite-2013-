namespace Roblox.TranslationResources.Feature;

public interface IVIPServerResources : ITranslationResources
{
	/// <summary>
	/// Key: "Action.Add"
	/// English String: "Add"
	/// </summary>
	string ActionAdd { get; }

	/// <summary>
	/// Key: "Action.AddPlayers"
	/// English String: "Add Players"
	/// </summary>
	string ActionAddPlayers { get; }

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	string ActionCancel { get; }

	/// <summary>
	/// Key: "Action.CancelPayments"
	/// English String: "Cancel Payments"
	/// </summary>
	string ActionCancelPayments { get; }

	/// <summary>
	/// Key: "Action.ChangeName"
	/// English String: "Change Name"
	/// </summary>
	string ActionChangeName { get; }

	/// <summary>
	/// Key: "Action.GoBack"
	/// English String: "Go Back"
	/// </summary>
	string ActionGoBack { get; }

	/// <summary>
	/// Key: "Action.RegenerateJoinLink"
	/// English String: "Regenerate"
	/// </summary>
	string ActionRegenerateJoinLink { get; }

	/// <summary>
	/// Key: "Action.Remove"
	/// English String: "Remove"
	/// </summary>
	string ActionRemove { get; }

	/// <summary>
	/// Key: "Action.RenewVipServer"
	/// English String: "Renew VIP Server"
	/// </summary>
	string ActionRenewVipServer { get; }

	/// <summary>
	/// Key: "Action.SeeAll"
	/// English String: "See All"
	/// </summary>
	string ActionSeeAll { get; }

	/// <summary>
	/// Key: "Heading.CancelPayments"
	/// English String: "Cancel Payments"
	/// </summary>
	string HeadingCancelPayments { get; }

	/// <summary>
	/// Key: "Heading.ChangeName"
	/// English String: "Change VIP Server Name"
	/// </summary>
	string HeadingChangeName { get; }

	/// <summary>
	/// Key: "Heading.ConfigureVipServer"
	/// English String: "Configure VIP Server"
	/// </summary>
	string HeadingConfigureVipServer { get; }

	/// <summary>
	/// Key: "Heading.RemovePlayer"
	/// English String: "Remove Player"
	/// </summary>
	string HeadingRemovePlayer { get; }

	/// <summary>
	/// Key: "Heading.RenewVipServer"
	/// English String: "Renew VIP Server"
	/// </summary>
	string HeadingRenewVipServer { get; }

	/// <summary>
	/// Key: "Label.ChangeNamePlaceholder"
	/// English String: "VIP Server Name (1-50 Characters)"
	/// </summary>
	string LabelChangeNamePlaceholder { get; }

	/// <summary>
	/// Key: "Label.ClanAccess"
	/// English String: "Clan Access"
	/// </summary>
	string LabelClanAccess { get; }

	/// <summary>
	/// Key: "Label.FriendsAllowed"
	/// English String: "Friends Allowed"
	/// </summary>
	string LabelFriendsAllowed { get; }

	/// <summary>
	/// Key: "Label.GameName"
	/// English String: "Game Name"
	/// </summary>
	string LabelGameName { get; }

	/// <summary>
	/// Key: "Label.JoinGameLink"
	/// English String: "Join Game Link..."
	/// </summary>
	string LabelJoinGameLink { get; }

	/// <summary>
	/// Key: "Label.None"
	/// English String: "None"
	/// </summary>
	string LabelNone { get; }

	/// <summary>
	/// Key: "Label.Off"
	/// English String: "Off"
	/// </summary>
	string LabelOff { get; }

	/// <summary>
	/// Key: "Label.On"
	/// English String: "On"
	/// </summary>
	string LabelOn { get; }

	/// <summary>
	/// Key: "Label.PickEnemyClan"
	/// English String: "Pick Enemy Clan"
	/// </summary>
	string LabelPickEnemyClan { get; }

	/// <summary>
	/// Key: "Label.SearchForPlayers"
	/// English String: "Search for Players"
	/// </summary>
	string LabelSearchForPlayers { get; }

	/// <summary>
	/// Key: "Label.Server"
	/// English String: "Server"
	/// </summary>
	string LabelServer { get; }

	/// <summary>
	/// Key: "Label.ServerMembers"
	/// English String: "Server Members"
	/// </summary>
	string LabelServerMembers { get; }

	/// <summary>
	/// Key: "Label.SubscriptionStatus"
	/// English String: "Subscription Status"
	/// </summary>
	string LabelSubscriptionStatus { get; }

	/// <summary>
	/// Key: "Label.VIPServerLink"
	/// English String: "VIP Server Link"
	/// </summary>
	string LabelVIPServerLink { get; }

	/// <summary>
	/// Key: "Label.VIPServerStatus"
	/// English String: "VIP Server Status"
	/// </summary>
	string LabelVIPServerStatus { get; }

	/// <summary>
	/// Key: "Label.YourClan"
	/// English String: "Your Clan"
	/// </summary>
	string LabelYourClan { get; }

	/// <summary>
	/// Key: "Label.ChangeNameBodyMessage"
	/// English String: "Are you sure you want to cancel future payments for your VIP Server of {name} by {creator}? If you cancel, your VIP Server will be deactivated on {date}."
	/// </summary>
	string LabelChangeNameBodyMessage(string name, string creator, string date);

	/// <summary>
	/// Key: "Label.RemovePlayerBodyMessage"
	/// English String: "Are you sure you want to remove {name} from your VIP Server? They will no longer be able to join your VIP Server."
	/// </summary>
	string LabelRemovePlayerBodyMessage(string name);

	/// <summary>
	/// Key: "Label.RenewVipServerBodyMessageConfirmation"
	/// English String: "Are you sure you want to enable future payments for your VIP Server of {name} by {creator}?"
	/// </summary>
	string LabelRenewVipServerBodyMessageConfirmation(string name, string creator);

	/// <summary>
	/// Key: "Label.RenewVipServerBodyMessageStart"
	/// English String: "This VIP Server will start renewing every month at {date} until you cancel."
	/// </summary>
	string LabelRenewVipServerBodyMessageStart(string date);

	/// <summary>
	/// Key: "Label.ServerExpirationDate"
	/// English String: "Your VIP Server expired on{date}"
	/// </summary>
	string LabelServerExpirationDate(string date);

	/// <summary>
	/// Key: "Label.SubscriptionChargeDate"
	/// English String: "You will be charged again on {date}"
	/// </summary>
	string LabelSubscriptionChargeDate(string date);

	/// <summary>
	/// Key: "Label.SubscriptionMonthlyPaymentDue"
	/// English String: "Your VIP Server monthly payment is {value}"
	/// </summary>
	string LabelSubscriptionMonthlyPaymentDue(string value);
}
