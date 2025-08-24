using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Notifications;

internal class NotificationStreamResources_en_us : TranslationResourcesBase, INotificationStreamResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.Accept"
	/// English String: "Accept"
	/// </summary>
	public virtual string ActionAccept => "Accept";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public virtual string ActionCancel => "Cancel";

	/// <summary>
	/// Key: "Action.Chat"
	/// English String: "Chat"
	/// </summary>
	public virtual string ActionChat => "Chat";

	/// <summary>
	/// Key: "Action.Ignore"
	/// English String: "Ignore"
	/// </summary>
	public virtual string ActionIgnore => "Ignore";

	/// <summary>
	/// Key: "Action.Play"
	/// Label for button to launch game.
	/// English String: "Play"
	/// </summary>
	public virtual string ActionPlay => "Play";

	/// <summary>
	/// Key: "Action.ReportAbuse"
	/// Label for link to report a game update message
	/// English String: "Report Abuse"
	/// </summary>
	public virtual string ActionReportAbuse => "Report Abuse";

	/// <summary>
	/// Key: "Action.Undo"
	/// Label for Undo link to reverse the unfollow action
	/// English String: "Undo"
	/// </summary>
	public virtual string ActionUndo => "Undo";

	/// <summary>
	/// Key: "Action.View"
	/// English String: "View"
	/// </summary>
	public virtual string ActionView => "View";

	/// <summary>
	/// Key: "Action.ViewAll"
	/// English String: "View All"
	/// </summary>
	public virtual string ActionViewAll => "View All";

	/// <summary>
	/// Key: "Heading.BackToAllNotifications"
	/// Heading displayed in game updates view, containing back link to notifications main view.
	/// English String: "All Notifications"
	/// </summary>
	public virtual string HeadingBackToAllNotifications => "All Notifications";

	/// <summary>
	/// Key: "Label.NoNetworkConnectionText"
	/// English String: "Connecting..."
	/// </summary>
	public virtual string LabelNoNetworkConnectionText => "Connecting...";

	/// <summary>
	/// Key: "Label.NoNotifications"
	/// English String: "No Notifications"
	/// </summary>
	public virtual string LabelNoNotifications => "No Notifications";

	/// <summary>
	/// Key: "Label.Notifications"
	/// English String: "Notifications"
	/// </summary>
	public virtual string LabelNotifications => "Notifications";

	/// <summary>
	/// Key: "Label.Settings"
	/// English String: "Settings"
	/// </summary>
	public virtual string LabelSettings => "Settings";

	/// <summary>
	/// Key: "Message.GameNotPlayableOnDevice"
	/// Message displayed on game update card when the game is not playable on the device type.
	/// English String: "Not playable on this device"
	/// </summary>
	public virtual string MessageGameNotPlayableOnDevice => "Not playable on this device";

	/// <summary>
	/// Key: "Message.TooManyFriendsOther"
	/// English String: "That user already has the max number of friends."
	/// </summary>
	public virtual string MessageTooManyFriendsOther => "That user already has the max number of friends.";

	/// <summary>
	/// Key: "Message.TooManyFriendsSelf"
	/// English String: "You already have the max number of friends."
	/// </summary>
	public virtual string MessageTooManyFriendsSelf => "You already have the max number of friends.";

	public NotificationStreamResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.Accept",
				_GetTemplateForActionAccept()
			},
			{
				"Action.Cancel",
				_GetTemplateForActionCancel()
			},
			{
				"Action.Chat",
				_GetTemplateForActionChat()
			},
			{
				"Action.Ignore",
				_GetTemplateForActionIgnore()
			},
			{
				"Action.Play",
				_GetTemplateForActionPlay()
			},
			{
				"Action.ReportAbuse",
				_GetTemplateForActionReportAbuse()
			},
			{
				"Action.Undo",
				_GetTemplateForActionUndo()
			},
			{
				"Action.UnfollowGame",
				_GetTemplateForActionUnfollowGame()
			},
			{
				"Action.View",
				_GetTemplateForActionView()
			},
			{
				"Action.ViewAll",
				_GetTemplateForActionViewAll()
			},
			{
				"Heading.BackToAllNotifications",
				_GetTemplateForHeadingBackToAllNotifications()
			},
			{
				"Label.NoNetworkConnectionText",
				_GetTemplateForLabelNoNetworkConnectionText()
			},
			{
				"Label.NoNotifications",
				_GetTemplateForLabelNoNotifications()
			},
			{
				"Label.Notifications",
				_GetTemplateForLabelNotifications()
			},
			{
				"Label.Settings",
				_GetTemplateForLabelSettings()
			},
			{
				"Message.AggregatedGameUpdateDouble",
				_GetTemplateForMessageAggregatedGameUpdateDouble()
			},
			{
				"Message.AggregatedGameUpdateMultiple",
				_GetTemplateForMessageAggregatedGameUpdateMultiple()
			},
			{
				"Message.ConfirmAcceptedDouble",
				_GetTemplateForMessageConfirmAcceptedDouble()
			},
			{
				"Message.ConfirmAcceptedMultiple",
				_GetTemplateForMessageConfirmAcceptedMultiple()
			},
			{
				"Message.ConfirmAcceptedSingle",
				_GetTemplateForMessageConfirmAcceptedSingle()
			},
			{
				"Message.ConfirmSentDouble",
				_GetTemplateForMessageConfirmSentDouble()
			},
			{
				"Message.ConfirmSentMultiple",
				_GetTemplateForMessageConfirmSentMultiple()
			},
			{
				"Message.ConfirmSentSingle",
				_GetTemplateForMessageConfirmSentSingle()
			},
			{
				"Message.DeveloperMetricsAvailable",
				_GetTemplateForMessageDeveloperMetricsAvailable()
			},
			{
				"Message.DeveloperMetricsAvailableMultiple",
				_GetTemplateForMessageDeveloperMetricsAvailableMultiple()
			},
			{
				"Message.DeveloperMetricsAvailableMultiple2",
				_GetTemplateForMessageDeveloperMetricsAvailableMultiple2()
			},
			{
				"Message.FriendRequestAcceptedDouble",
				_GetTemplateForMessageFriendRequestAcceptedDouble()
			},
			{
				"Message.FriendRequestAcceptedMultiple",
				_GetTemplateForMessageFriendRequestAcceptedMultiple()
			},
			{
				"Message.FriendRequestAcceptedSingle",
				_GetTemplateForMessageFriendRequestAcceptedSingle()
			},
			{
				"Message.FriendRequestSentDouble",
				_GetTemplateForMessageFriendRequestSentDouble()
			},
			{
				"Message.FriendRequestSentMultiple",
				_GetTemplateForMessageFriendRequestSentMultiple()
			},
			{
				"Message.FriendRequestSentSingle",
				_GetTemplateForMessageFriendRequestSentSingle()
			},
			{
				"Message.GameNotPlayableOnDevice",
				_GetTemplateForMessageGameNotPlayableOnDevice()
			},
			{
				"Message.MessageAndPreview",
				_GetTemplateForMessageMessageAndPreview()
			},
			{
				"Message.MessageFrom",
				_GetTemplateForMessageMessageFrom()
			},
			{
				"Message.NumberofNewNotifications",
				_GetTemplateForMessageNumberofNewNotifications()
			},
			{
				"Message.TooManyFriendsOther",
				_GetTemplateForMessageTooManyFriendsOther()
			},
			{
				"Message.TooManyFriendsSelf",
				_GetTemplateForMessageTooManyFriendsSelf()
			},
			{
				"Message.UnfollowedGame",
				_GetTemplateForMessageUnfollowedGame()
			},
			{
				"Message.YouHaveNewFriendRequests",
				_GetTemplateForMessageYouHaveNewFriendRequests()
			},
			{
				"Message.YouHaveNewFriends",
				_GetTemplateForMessageYouHaveNewFriends()
			},
			{
				"Message.YouReceivedMessages",
				_GetTemplateForMessageYouReceivedMessages()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Notifications.NotificationStream";
	}

	protected virtual string _GetTemplateForActionAccept()
	{
		return "Accept";
	}

	protected virtual string _GetTemplateForActionCancel()
	{
		return "Cancel";
	}

	protected virtual string _GetTemplateForActionChat()
	{
		return "Chat";
	}

	protected virtual string _GetTemplateForActionIgnore()
	{
		return "Ignore";
	}

	protected virtual string _GetTemplateForActionPlay()
	{
		return "Play";
	}

	protected virtual string _GetTemplateForActionReportAbuse()
	{
		return "Report Abuse";
	}

	protected virtual string _GetTemplateForActionUndo()
	{
		return "Undo";
	}

	/// <summary>
	/// Key: "Action.UnfollowGame"
	/// Label of menu item to unfollow the game
	/// English String: "Unfollow {gameName}"
	/// </summary>
	public virtual string ActionUnfollowGame(string gameName)
	{
		return $"Unfollow {gameName}";
	}

	protected virtual string _GetTemplateForActionUnfollowGame()
	{
		return "Unfollow {gameName}";
	}

	protected virtual string _GetTemplateForActionView()
	{
		return "View";
	}

	protected virtual string _GetTemplateForActionViewAll()
	{
		return "View All";
	}

	protected virtual string _GetTemplateForHeadingBackToAllNotifications()
	{
		return "All Notifications";
	}

	protected virtual string _GetTemplateForLabelNoNetworkConnectionText()
	{
		return "Connecting...";
	}

	protected virtual string _GetTemplateForLabelNoNotifications()
	{
		return "No Notifications";
	}

	protected virtual string _GetTemplateForLabelNotifications()
	{
		return "Notifications";
	}

	protected virtual string _GetTemplateForLabelSettings()
	{
		return "Settings";
	}

	/// <summary>
	/// Key: "Message.AggregatedGameUpdateDouble"
	/// Message displayed on aggregated game update notification card, when there are exactly two games sending update.
	/// English String: "{gameOne} and {gameTwo} sent updates."
	/// </summary>
	public virtual string MessageAggregatedGameUpdateDouble(string gameOne, string gameTwo)
	{
		return $"{gameOne} and {gameTwo} sent updates.";
	}

	protected virtual string _GetTemplateForMessageAggregatedGameUpdateDouble()
	{
		return "{gameOne} and {gameTwo} sent updates.";
	}

	protected virtual string _GetTemplateForMessageAggregatedGameUpdateMultiple()
	{
		return "{gameOne}, {gameTwo}, and {otherCount, plural, =1 {# other game} other {# other games}} sent updates.";
	}

	/// <summary>
	/// Key: "Message.ConfirmAcceptedDouble"
	/// English String: "{userOne} and {userTwo}"
	/// </summary>
	public virtual string MessageConfirmAcceptedDouble(string userOne, string userTwo)
	{
		return $"{userOne} and {userTwo}";
	}

	protected virtual string _GetTemplateForMessageConfirmAcceptedDouble()
	{
		return "{userOne} and {userTwo}";
	}

	protected virtual string _GetTemplateForMessageConfirmAcceptedMultiple()
	{
		return "{userOne}, {userTwo}, and {userMultipleCount, plural, =1 {# other} other {# others}}";
	}

	/// <summary>
	/// Key: "Message.ConfirmAcceptedSingle"
	/// English String: "{userOne}"
	/// </summary>
	public virtual string MessageConfirmAcceptedSingle(string userOne)
	{
		return $"{userOne}";
	}

	protected virtual string _GetTemplateForMessageConfirmAcceptedSingle()
	{
		return "{userOne}";
	}

	/// <summary>
	/// Key: "Message.ConfirmSentDouble"
	/// English String: "{userOne} and {userTwo} are now your friends!"
	/// </summary>
	public virtual string MessageConfirmSentDouble(string userOne, string userTwo)
	{
		return $"{userOne} and {userTwo} are now your friends!";
	}

	protected virtual string _GetTemplateForMessageConfirmSentDouble()
	{
		return "{userOne} and {userTwo} are now your friends!";
	}

	protected virtual string _GetTemplateForMessageConfirmSentMultiple()
	{
		return "{userOne}, {userTwo}, and {userMultipleCount, plural, =1 {# other} other {# others}} are now your friends!";
	}

	/// <summary>
	/// Key: "Message.ConfirmSentSingle"
	/// English String: "{userOne} is now your friend!"
	/// </summary>
	public virtual string MessageConfirmSentSingle(string userOne)
	{
		return $"{userOne} is now your friend!";
	}

	protected virtual string _GetTemplateForMessageConfirmSentSingle()
	{
		return "{userOne} is now your friend!";
	}

	/// <summary>
	/// Key: "Message.DeveloperMetricsAvailable"
	/// English String: "{month} {year} Analytics Report for {gameName} available."
	/// </summary>
	public virtual string MessageDeveloperMetricsAvailable(string month, string year, string gameName)
	{
		return $"{month} {year} Analytics Report for {gameName} available.";
	}

	protected virtual string _GetTemplateForMessageDeveloperMetricsAvailable()
	{
		return "{month} {year} Analytics Report for {gameName} available.";
	}

	protected virtual string _GetTemplateForMessageDeveloperMetricsAvailableMultiple()
	{
		return "{month} {year} Analytics Report for {gameName} and {otherCount, plural, =1 {# other game} other {# other games}} available";
	}

	/// <summary>
	/// Key: "Message.DeveloperMetricsAvailableMultiple2"
	/// English String: "{month} {year} Analytics Report for {gameCount} games available."
	/// </summary>
	public virtual string MessageDeveloperMetricsAvailableMultiple2(string month, string year, string gameCount)
	{
		return $"{month} {year} Analytics Report for {gameCount} games available.";
	}

	protected virtual string _GetTemplateForMessageDeveloperMetricsAvailableMultiple2()
	{
		return "{month} {year} Analytics Report for {gameCount} games available.";
	}

	/// <summary>
	/// Key: "Message.FriendRequestAcceptedDouble"
	/// English String: "{userOne} and {userTwo} accepted your friend request."
	/// </summary>
	public virtual string MessageFriendRequestAcceptedDouble(string userOne, string userTwo)
	{
		return $"{userOne} and {userTwo} accepted your friend request.";
	}

	protected virtual string _GetTemplateForMessageFriendRequestAcceptedDouble()
	{
		return "{userOne} and {userTwo} accepted your friend request.";
	}

	protected virtual string _GetTemplateForMessageFriendRequestAcceptedMultiple()
	{
		return "{userOne}, {userTwo}, and {userMultipleCount, plural, =1 {# other} other {# others}} accepted your friend request.";
	}

	/// <summary>
	/// Key: "Message.FriendRequestAcceptedSingle"
	/// English String: "{userOne} accepted your friend request."
	/// </summary>
	public virtual string MessageFriendRequestAcceptedSingle(string userOne)
	{
		return $"{userOne} accepted your friend request.";
	}

	protected virtual string _GetTemplateForMessageFriendRequestAcceptedSingle()
	{
		return "{userOne} accepted your friend request.";
	}

	/// <summary>
	/// Key: "Message.FriendRequestSentDouble"
	/// English String: "{userOne} and {userTwo} sent you friend requests."
	/// </summary>
	public virtual string MessageFriendRequestSentDouble(string userOne, string userTwo)
	{
		return $"{userOne} and {userTwo} sent you friend requests.";
	}

	protected virtual string _GetTemplateForMessageFriendRequestSentDouble()
	{
		return "{userOne} and {userTwo} sent you friend requests.";
	}

	protected virtual string _GetTemplateForMessageFriendRequestSentMultiple()
	{
		return "{userOne}, {userTwo}, and {userMultipleCount, plural, =1 {# other} other {# others}} sent you friend requests.";
	}

	/// <summary>
	/// Key: "Message.FriendRequestSentSingle"
	/// English String: "{userOne} sent you a friend request."
	/// </summary>
	public virtual string MessageFriendRequestSentSingle(string userOne)
	{
		return $"{userOne} sent you a friend request.";
	}

	protected virtual string _GetTemplateForMessageFriendRequestSentSingle()
	{
		return "{userOne} sent you a friend request.";
	}

	protected virtual string _GetTemplateForMessageGameNotPlayableOnDevice()
	{
		return "Not playable on this device";
	}

	/// <summary>
	/// Key: "Message.MessageAndPreview"
	/// English String: "{titleStart}Message from {username}:{titleEnd} {message}"
	/// </summary>
	public virtual string MessageMessageAndPreview(string titleStart, string username, string titleEnd, string message)
	{
		return $"{titleStart}Message from {username}:{titleEnd} {message}";
	}

	protected virtual string _GetTemplateForMessageMessageAndPreview()
	{
		return "{titleStart}Message from {username}:{titleEnd} {message}";
	}

	/// <summary>
	/// Key: "Message.MessageFrom"
	/// English String: "Message from {username}:"
	/// </summary>
	public virtual string MessageMessageFrom(string username)
	{
		return $"Message from {username}:";
	}

	protected virtual string _GetTemplateForMessageMessageFrom()
	{
		return "Message from {username}:";
	}

	protected virtual string _GetTemplateForMessageNumberofNewNotifications()
	{
		return "{notificationCount, plural, =1 {# New Notification} other {# New Notifications}}";
	}

	protected virtual string _GetTemplateForMessageTooManyFriendsOther()
	{
		return "That user already has the max number of friends.";
	}

	protected virtual string _GetTemplateForMessageTooManyFriendsSelf()
	{
		return "You already have the max number of friends.";
	}

	/// <summary>
	/// Key: "Message.UnfollowedGame"
	/// Message displayed in game update card after user unfollowed the game
	/// English String: "Unfollowed {gameName}"
	/// </summary>
	public virtual string MessageUnfollowedGame(string gameName)
	{
		return $"Unfollowed {gameName}";
	}

	protected virtual string _GetTemplateForMessageUnfollowedGame()
	{
		return "Unfollowed {gameName}";
	}

	protected virtual string _GetTemplateForMessageYouHaveNewFriendRequests()
	{
		return "You have {numberOfRequests} new {numberOfRequests, plural, =1 {friend request} other {friend requests}}.";
	}

	protected virtual string _GetTemplateForMessageYouHaveNewFriends()
	{
		return "You have {numberOfFriends} new {numberOfFriends, plural, =1 {friend} other {friends}}.";
	}

	protected virtual string _GetTemplateForMessageYouReceivedMessages()
	{
		return "You received {numberOfMessagesText} {numberOfMessages, plural, =1 {message} other {messages}}";
	}
}
