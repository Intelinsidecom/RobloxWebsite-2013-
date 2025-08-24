namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides FriendsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class FriendsResources_de_de : FriendsResources_en_us, IFriendsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Accept"
	/// English String: "Accept"
	/// </summary>
	public override string ActionAccept => "Annehmen";

	/// <summary>
	/// Key: "Action.FindFriends"
	/// English String: "Find Friends"
	/// </summary>
	public override string ActionFindFriends => "Freunde finden";

	/// <summary>
	/// Key: "Action.Follow"
	/// English String: "Follow"
	/// </summary>
	public override string ActionFollow => "Folgen";

	/// <summary>
	/// Key: "Action.Ignore"
	/// English String: "Ignore"
	/// </summary>
	public override string ActionIgnore => "Ignorieren";

	/// <summary>
	/// Key: "Action.IgnoreAll"
	/// English String: "Ignore All"
	/// </summary>
	public override string ActionIgnoreAll => "Alle ignorieren";

	/// <summary>
	/// Key: "Action.Unfollow"
	/// English String: "Unfollow"
	/// </summary>
	public override string ActionUnfollow => "Nicht mehr folgen";

	/// <summary>
	/// Key: "Action.Unfriend"
	/// English String: "Unfriend"
	/// </summary>
	public override string ActionUnfriend => "Von Freundesliste entfernen";

	/// <summary>
	/// Key: "Heading.MyFriends"
	/// English String: "My Friends"
	/// </summary>
	public override string HeadingMyFriends => "Meine Freunde";

	/// <summary>
	/// Key: "Label.ErrorTitle"
	/// English String: "Error"
	/// </summary>
	public override string LabelErrorTitle => "Fehler";

	/// <summary>
	/// Key: "Label.Followers"
	/// English String: "Followers"
	/// </summary>
	public override string LabelFollowers => "Follower";

	/// <summary>
	/// Key: "Label.Following"
	/// English String: "Following"
	/// </summary>
	public override string LabelFollowing => "Ich folge";

	/// <summary>
	/// Key: "Label.FriendRequests"
	/// English String: "Friend Requests"
	/// </summary>
	public override string LabelFriendRequests => "Freundesanfragen";

	/// <summary>
	/// Key: "Label.Friends"
	/// English String: "Friends"
	/// </summary>
	public override string LabelFriends => "Freunde";

	/// <summary>
	/// Key: "Label.Offline"
	/// English String: "Offline"
	/// </summary>
	public override string LabelOffline => "Offline";

	/// <summary>
	/// Key: "Label.Ok"
	/// English String: "Ok"
	/// </summary>
	public override string LabelOk => "Okay";

	/// <summary>
	/// Key: "Label.Online"
	/// English String: "Online"
	/// </summary>
	public override string LabelOnline => "Online";

	/// <summary>
	/// Key: "Label.Requests"
	/// English String: "Requests"
	/// </summary>
	public override string LabelRequests => "Anfragen";

	/// <summary>
	/// Key: "Label.SearchFriends"
	/// When user doesn't have any friends.
	/// English String: "Search for Friends"
	/// </summary>
	public override string LabelSearchFriends => "Suche nach Freunden";

	/// <summary>
	/// Key: "Label.Unfollowed"
	/// Unfollowed
	/// English String: "Unfollowed"
	/// </summary>
	public override string LabelUnfollowed => "Nicht mehr gefolgt";

	/// <summary>
	/// Key: "Message.ActionNotAllowedError"
	/// English String: "Action not allowed"
	/// </summary>
	public override string MessageActionNotAllowedError => "Aktion ist nicht erlaubt.";

	/// <summary>
	/// Key: "Message.AlreadyExistsError"
	/// English String: "Already exists."
	/// </summary>
	public override string MessageAlreadyExistsError => "Existiert bereits.";

	/// <summary>
	/// Key: "Message.CurrentInvalidParametersError"
	/// English String: "Invalid parameters."
	/// </summary>
	public override string MessageCurrentInvalidParametersError => "Ungültige Angaben.";

	/// <summary>
	/// Key: "Message.CurrentUserFriendsLimitExceededError"
	/// English String: "You have reached the maximum number of Friends. Please remove a Friend before accepting any more Friend Requests."
	/// </summary>
	public override string MessageCurrentUserFriendsLimitExceededError => "Du hast die maximale Anzahl an Freunden erreicht. Bitte entferne einen Freund, bevor du weitere Freundesanfragen annimmst.";

	/// <summary>
	/// Key: "Message.DefaultError"
	/// English String: "An error ocurred."
	/// </summary>
	public override string MessageDefaultError => "Ein Fehler ist aufgetreten.";

	/// <summary>
	/// Key: "Message.FloodLimitExceededError"
	/// English String: "You are performing this action too often. Please wait a minute and try again."
	/// </summary>
	public override string MessageFloodLimitExceededError => "Du führst diese Aktion zu häufig durch. Bitte warte eine Minute und versuche es dann erneut.";

	/// <summary>
	/// Key: "Message.FollowerTabTooltip"
	/// English String: "People who have chosen to follow your activity."
	/// </summary>
	public override string MessageFollowerTabTooltip => "Leute, die deinen Aktivitäten folgen möchten.";

	/// <summary>
	/// Key: "Message.FollowingTabTooltip"
	/// English String: "People whose activity you have chosen to follow."
	/// </summary>
	public override string MessageFollowingTabTooltip => "Leute, deren Aktivitäten du folgen möchtest.";

	/// <summary>
	/// Key: "Message.ForGeneralError"
	/// English String: "Something went wrong."
	/// </summary>
	public override string MessageForGeneralError => "Ein Problem ist aufgetreten.";

	/// <summary>
	/// Key: "Message.ForGeneralFooter"
	/// English String: "Please check back in few minutes."
	/// </summary>
	public override string MessageForGeneralFooter => "Bitte versuche es in einigen Minuten erneut.";

	/// <summary>
	/// Key: "Message.ForMaxFriendsError"
	/// English String: "Unable to process Request.You currently have the max number of Friends allowed. "
	/// </summary>
	public override string MessageForMaxFriendsError => "Anfrage kann nicht bearbeitet werden. Du hast derzeit die maximal erlaubte Anzahl an Freunden. ";

	/// <summary>
	/// Key: "Message.ForMaxFriendsFooter"
	/// English String: "Unfriend someone before accepting any more Friend Requests."
	/// </summary>
	public override string MessageForMaxFriendsFooter => "Entferne jemanden von deiner Freundesliste, bevor du weitere Freundesanfragen annimmst.";

	/// <summary>
	/// Key: "Message.ForMaxRequestsError"
	/// English String: "Unable to process Request. That user currently has the max number of Friends allowed."
	/// </summary>
	public override string MessageForMaxRequestsError => "Anfrage kann nicht bearbeitet werden. Dieser Benutzer hat derzeit die maximal erlaubte Anzahl an Freunden.";

	/// <summary>
	/// Key: "Message.ForMaxRequestsFooter"
	/// English String: "You can not accept their Friend Request until they remove a Friend."
	/// </summary>
	public override string MessageForMaxRequestsFooter => "Du kannst seine Freundesanfrage erst annehmen, nachdem er einen Freund entfernt hat.";

	/// <summary>
	/// Key: "Message.FriendRequestNotExistError"
	/// English String: "Friend request does not exist"
	/// </summary>
	public override string MessageFriendRequestNotExistError => "Freundesanfrage existiert nicht.";

	/// <summary>
	/// Key: "Message.FriendsLimitExceededError"
	/// English String: "Friends limit exceeded."
	/// </summary>
	public override string MessageFriendsLimitExceededError => "Max. Anzahl an Freunden überschritten.";

	/// <summary>
	/// Key: "Message.FriendsTabTooltip"
	/// English String: "Friends are established when two Roblox users mutually agree to friendship."
	/// </summary>
	public override string MessageFriendsTabTooltip => "Wenn zwei Roblox-Benutzer einer Freundschaft zustimmen, werden sie zu Freunden.";

	/// <summary>
	/// Key: "Message.NotRecipientError"
	/// English String: "You are not the recipient of this friend request."
	/// </summary>
	public override string MessageNotRecipientError => "Du bist nicht der Empfänger dieser Freundesanfrage.";

	/// <summary>
	/// Key: "Message.OtherUserFriendsLimitExceededError"
	/// English String: "Friends limit exceeded."
	/// </summary>
	public override string MessageOtherUserFriendsLimitExceededError => "Max. Anzahl an Freunden überschritten.";

	/// <summary>
	/// Key: "Message.RequestsTabTooltip"
	/// English String: "Friends are established when two Roblox users mutually agree to friendship."
	/// </summary>
	public override string MessageRequestsTabTooltip => "Wenn zwei Roblox-Benutzer einer Freundschaft zustimmen, werden sie zu Freunden.";

	/// <summary>
	/// Key: "Message.RobloxIsMoreFunWithFriends"
	/// English String: "Roblox is more fun with friends!"
	/// </summary>
	public override string MessageRobloxIsMoreFunWithFriends => "Roblox macht mehr Spaß mit Freunden!";

	/// <summary>
	/// Key: "Message.SelfFollowingAttemptError"
	/// English String: "You cannot follow yourself."
	/// </summary>
	public override string MessageSelfFollowingAttemptError => "Du kannst dir nicht selbst folgen.";

	/// <summary>
	/// Key: "Message.SelfFriendingAttemptError"
	/// English String: "You cannot be friends with yourself."
	/// </summary>
	public override string MessageSelfFriendingAttemptError => "Du kannst nicht mit dir selbst befreundet sein.";

	/// <summary>
	/// Key: "Message.SystemUnavailableError"
	/// English String: "Friends and Followers system is unavailable."
	/// </summary>
	public override string MessageSystemUnavailableError => "Das System für Freunde und Follower ist nicht verfügbar.";

	/// <summary>
	/// Key: "Message.UnblockUserPinLockedError"
	/// English String: "Pin is locked."
	/// </summary>
	public override string MessageUnblockUserPinLockedError => "PIN ist gesperrt.";

	/// <summary>
	/// Key: "Message.UserBlockedError"
	/// English String: "User is blocked"
	/// </summary>
	public override string MessageUserBlockedError => "Benutzer ist gesperrt.";

	/// <summary>
	/// Key: "Message.UserHasNotPassedCaptchaError"
	/// English String: "You need to pass Captcha."
	/// </summary>
	public override string MessageUserHasNotPassedCaptchaError => "Du musst das Captcha abschließen.";

	/// <summary>
	/// Key: "Message.UsersAreNotInSameGameError"
	/// English String: "Users need to be in the same game."
	/// </summary>
	public override string MessageUsersAreNotInSameGameError => "Benutzer müssen sich im selben Spiel befinden.";

	public FriendsResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAccept()
	{
		return "Annehmen";
	}

	protected override string _GetTemplateForActionFindFriends()
	{
		return "Freunde finden";
	}

	protected override string _GetTemplateForActionFollow()
	{
		return "Folgen";
	}

	protected override string _GetTemplateForActionIgnore()
	{
		return "Ignorieren";
	}

	protected override string _GetTemplateForActionIgnoreAll()
	{
		return "Alle ignorieren";
	}

	protected override string _GetTemplateForActionUnfollow()
	{
		return "Nicht mehr folgen";
	}

	protected override string _GetTemplateForActionUnfriend()
	{
		return "Von Freundesliste entfernen";
	}

	/// <summary>
	/// Key: "Description.SearchFriends"
	/// When user doesn't have friends, this suggestive text will show up.
	/// English String: "Tap the magnifying glass icon above and search for a user or {startLink}play games{endLink} to meet people."
	/// </summary>
	public override string DescriptionSearchFriends(string startLink, string endLink)
	{
		return $"Tippe auf das Lupensymbol oben und suche nach einem Benutzer oder {startLink}spiele Spiele{endLink}, um Leute kennenzulernen.";
	}

	protected override string _GetTemplateForDescriptionSearchFriends()
	{
		return "Tippe auf das Lupensymbol oben und suche nach einem Benutzer oder {startLink}spiele Spiele{endLink}, um Leute kennenzulernen.";
	}

	protected override string _GetTemplateForHeadingMyFriends()
	{
		return "Meine Freunde";
	}

	/// <summary>
	/// Key: "Heading.UsersFriends"
	/// English String: "{username}'s Friends"
	/// </summary>
	public override string HeadingUsersFriends(string username)
	{
		return $"Freunde von {username}";
	}

	protected override string _GetTemplateForHeadingUsersFriends()
	{
		return "Freunde von {username}";
	}

	protected override string _GetTemplateForLabelErrorTitle()
	{
		return "Fehler";
	}

	protected override string _GetTemplateForLabelFollowers()
	{
		return "Follower";
	}

	protected override string _GetTemplateForLabelFollowing()
	{
		return "Ich folge";
	}

	protected override string _GetTemplateForLabelFriendRequests()
	{
		return "Freundesanfragen";
	}

	protected override string _GetTemplateForLabelFriends()
	{
		return "Freunde";
	}

	/// <summary>
	/// Key: "Label.NearbyUpsell"
	/// Shown when a user is on the Universal Friend Finder page and has no friend requests. This tells them to try another feature to find friends called "Nearby"
	/// English String: "You have no pending friend requests. To add friends, check out {startSpan}Nearby{endSpan}."
	/// </summary>
	public override string LabelNearbyUpsell(string startSpan, string endSpan)
	{
		return $"Du hast keine ausstehenden Freundesanfragen. Füge Freunde {startSpan}In der Nähe{endSpan} hinzu.";
	}

	protected override string _GetTemplateForLabelNearbyUpsell()
	{
		return "Du hast keine ausstehenden Freundesanfragen. Füge Freunde {startSpan}In der Nähe{endSpan} hinzu.";
	}

	protected override string _GetTemplateForLabelOffline()
	{
		return "Offline";
	}

	protected override string _GetTemplateForLabelOk()
	{
		return "Okay";
	}

	protected override string _GetTemplateForLabelOnline()
	{
		return "Online";
	}

	protected override string _GetTemplateForLabelRequests()
	{
		return "Anfragen";
	}

	protected override string _GetTemplateForLabelSearchFriends()
	{
		return "Suche nach Freunden";
	}

	protected override string _GetTemplateForLabelUnfollowed()
	{
		return "Nicht mehr gefolgt";
	}

	protected override string _GetTemplateForMessageActionNotAllowedError()
	{
		return "Aktion ist nicht erlaubt.";
	}

	protected override string _GetTemplateForMessageAlreadyExistsError()
	{
		return "Existiert bereits.";
	}

	protected override string _GetTemplateForMessageCurrentInvalidParametersError()
	{
		return "Ungültige Angaben.";
	}

	protected override string _GetTemplateForMessageCurrentUserFriendsLimitExceededError()
	{
		return "Du hast die maximale Anzahl an Freunden erreicht. Bitte entferne einen Freund, bevor du weitere Freundesanfragen annimmst.";
	}

	protected override string _GetTemplateForMessageDefaultError()
	{
		return "Ein Fehler ist aufgetreten.";
	}

	protected override string _GetTemplateForMessageFloodLimitExceededError()
	{
		return "Du führst diese Aktion zu häufig durch. Bitte warte eine Minute und versuche es dann erneut.";
	}

	protected override string _GetTemplateForMessageFollowerTabTooltip()
	{
		return "Leute, die deinen Aktivitäten folgen möchten.";
	}

	protected override string _GetTemplateForMessageFollowingTabTooltip()
	{
		return "Leute, deren Aktivitäten du folgen möchtest.";
	}

	protected override string _GetTemplateForMessageForGeneralError()
	{
		return "Ein Problem ist aufgetreten.";
	}

	protected override string _GetTemplateForMessageForGeneralFooter()
	{
		return "Bitte versuche es in einigen Minuten erneut.";
	}

	protected override string _GetTemplateForMessageForMaxFriendsError()
	{
		return "Anfrage kann nicht bearbeitet werden. Du hast derzeit die maximal erlaubte Anzahl an Freunden. ";
	}

	protected override string _GetTemplateForMessageForMaxFriendsFooter()
	{
		return "Entferne jemanden von deiner Freundesliste, bevor du weitere Freundesanfragen annimmst.";
	}

	protected override string _GetTemplateForMessageForMaxRequestsError()
	{
		return "Anfrage kann nicht bearbeitet werden. Dieser Benutzer hat derzeit die maximal erlaubte Anzahl an Freunden.";
	}

	protected override string _GetTemplateForMessageForMaxRequestsFooter()
	{
		return "Du kannst seine Freundesanfrage erst annehmen, nachdem er einen Freund entfernt hat.";
	}

	protected override string _GetTemplateForMessageFriendRequestNotExistError()
	{
		return "Freundesanfrage existiert nicht.";
	}

	protected override string _GetTemplateForMessageFriendsLimitExceededError()
	{
		return "Max. Anzahl an Freunden überschritten.";
	}

	protected override string _GetTemplateForMessageFriendsTabTooltip()
	{
		return "Wenn zwei Roblox-Benutzer einer Freundschaft zustimmen, werden sie zu Freunden.";
	}

	protected override string _GetTemplateForMessageNotRecipientError()
	{
		return "Du bist nicht der Empfänger dieser Freundesanfrage.";
	}

	protected override string _GetTemplateForMessageOtherUserFriendsLimitExceededError()
	{
		return "Max. Anzahl an Freunden überschritten.";
	}

	protected override string _GetTemplateForMessageRequestsTabTooltip()
	{
		return "Wenn zwei Roblox-Benutzer einer Freundschaft zustimmen, werden sie zu Freunden.";
	}

	protected override string _GetTemplateForMessageRobloxIsMoreFunWithFriends()
	{
		return "Roblox macht mehr Spaß mit Freunden!";
	}

	protected override string _GetTemplateForMessageSelfFollowingAttemptError()
	{
		return "Du kannst dir nicht selbst folgen.";
	}

	protected override string _GetTemplateForMessageSelfFriendingAttemptError()
	{
		return "Du kannst nicht mit dir selbst befreundet sein.";
	}

	protected override string _GetTemplateForMessageSystemUnavailableError()
	{
		return "Das System für Freunde und Follower ist nicht verfügbar.";
	}

	protected override string _GetTemplateForMessageUnblockUserPinLockedError()
	{
		return "PIN ist gesperrt.";
	}

	protected override string _GetTemplateForMessageUserBlockedError()
	{
		return "Benutzer ist gesperrt.";
	}

	protected override string _GetTemplateForMessageUserHasNotPassedCaptchaError()
	{
		return "Du musst das Captcha abschließen.";
	}

	protected override string _GetTemplateForMessageUsersAreNotInSameGameError()
	{
		return "Benutzer müssen sich im selben Spiel befinden.";
	}
}
