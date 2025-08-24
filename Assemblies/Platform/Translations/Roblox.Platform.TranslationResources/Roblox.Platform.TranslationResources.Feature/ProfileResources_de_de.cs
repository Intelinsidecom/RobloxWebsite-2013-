namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides ProfileResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ProfileResources_de_de : ProfileResources_en_us, IProfileResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Accept"
	/// English String: "Accept"
	/// </summary>
	public override string ActionAccept => "Annehmen";

	/// <summary>
	/// Key: "Action.AddFriend"
	/// English String: "Add Friend"
	/// </summary>
	public override string ActionAddFriend => "Freund hinzufügen";

	/// <summary>
	/// Key: "Action.BlockUser"
	/// English String: "Block User"
	/// </summary>
	public override string ActionBlockUser => "Benutzer sperren";

	/// <summary>
	/// Key: "Action.CancelBlockUser"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancelBlockUser => "Abbrechen";

	/// <summary>
	/// Key: "Action.Chat"
	/// English String: "Chat"
	/// </summary>
	public override string ActionChat => "Chatten";

	/// <summary>
	/// Key: "Action.Close"
	/// close modal
	/// English String: "Close"
	/// </summary>
	public override string ActionClose => "Schließen";

	/// <summary>
	/// Key: "Action.ConfirmBlockUser"
	/// English String: "Block"
	/// </summary>
	public override string ActionConfirmBlockUser => "Sperren";

	/// <summary>
	/// Key: "Action.ConfirmUnblockUser"
	/// English String: "Unblock"
	/// </summary>
	public override string ActionConfirmUnblockUser => "Nicht mehr sperren";

	/// <summary>
	/// Key: "Action.Favorites"
	/// English String: "Favorites"
	/// </summary>
	public override string ActionFavorites => "Favoriten";

	/// <summary>
	/// Key: "Action.Follow"
	/// English String: "Follow"
	/// </summary>
	public override string ActionFollow => "Folgen";

	/// <summary>
	/// Key: "Action.GridView"
	/// English String: "Grid View"
	/// </summary>
	public override string ActionGridView => "Rasteransicht";

	/// <summary>
	/// Key: "Action.ImpersonateUser"
	/// English String: "Impersonate User"
	/// </summary>
	public override string ActionImpersonateUser => "Imitierenden Benutzer melden";

	/// <summary>
	/// Key: "Action.Inventory"
	/// English String: "Inventory"
	/// </summary>
	public override string ActionInventory => "Inventar";

	/// <summary>
	/// Key: "Action.JoinGame"
	/// English String: "Join Game"
	/// </summary>
	public override string ActionJoinGame => "Spiel beitreten";

	/// <summary>
	/// Key: "Action.Message"
	/// English String: "Message"
	/// </summary>
	public override string ActionMessage => "Nachricht schreiben";

	/// <summary>
	/// Key: "Action.Pending"
	/// English String: "Pending"
	/// </summary>
	public override string ActionPending => "Ausstehend";

	/// <summary>
	/// Key: "Action.Save"
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "Speichern";

	/// <summary>
	/// Key: "Action.SeeAll"
	/// English String: "See All"
	/// </summary>
	public override string ActionSeeAll => "Alle ansehen";

	/// <summary>
	/// Key: "Action.SeeLess"
	/// English String: "See Less"
	/// </summary>
	public override string ActionSeeLess => "Weniger ansehen";

	/// <summary>
	/// Key: "Action.SeeMore"
	/// English String: "See More"
	/// </summary>
	public override string ActionSeeMore => "Mehr ansehen";

	/// <summary>
	/// Key: "Action.SlideshowView"
	/// English String: "Slideshow View"
	/// </summary>
	public override string ActionSlideshowView => "Diashow-Ansicht";

	/// <summary>
	/// Key: "Action.Trade"
	/// English String: "Trade"
	/// </summary>
	public override string ActionTrade => "Handeln";

	/// <summary>
	/// Key: "Action.TradeItems"
	/// English String: "Trade Items"
	/// </summary>
	public override string ActionTradeItems => "Mit Artikeln handeln";

	/// <summary>
	/// Key: "Action.UnblockUser"
	/// English String: "Unblock User"
	/// </summary>
	public override string ActionUnblockUser => "Benutzer nicht mehr sperren";

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
	/// Key: "Action.UpdateStatus"
	/// English String: "Update Status"
	/// </summary>
	public override string ActionUpdateStatus => "Status aktualisieren";

	/// <summary>
	/// Key: "Description.BlockUserFooter"
	/// English String: "When you've blocked a user, neither of you can directly contact the other."
	/// </summary>
	public override string DescriptionBlockUserFooter => "Wenn du einen Benutzer sperrst, könnt ihr euch nicht mehr gegenseitig kontaktieren.";

	/// <summary>
	/// Key: "Description.BlockUserPrompt"
	/// English String: "Are you sure you want to block this user?"
	/// </summary>
	public override string DescriptionBlockUserPrompt => "Möchtest du diesen Benutzer wirklich sperren?";

	/// <summary>
	/// Key: "Description.ChangeAlias"
	/// English String: "Only you can see this information"
	/// </summary>
	public override string DescriptionChangeAlias => "Nur du kannst diese Informationen sehen";

	/// <summary>
	/// Key: "Description.UnblockUserPrompt"
	/// English String: "Are you sure you want to unblock this user?"
	/// </summary>
	public override string DescriptionUnblockUserPrompt => "Möchtest du diesen Benutzer wirklich nicht mehr sperren?";

	/// <summary>
	/// Key: "Heading.AboutTab"
	/// this is for the heading under About tab on profile page
	/// English String: "About"
	/// </summary>
	public override string HeadingAboutTab => "Info";

	/// <summary>
	/// Key: "Heading.BlockUserTitle"
	/// English String: "Warning"
	/// </summary>
	public override string HeadingBlockUserTitle => "Warnung";

	/// <summary>
	/// Key: "Heading.Collections"
	/// English String: "Collections"
	/// </summary>
	public override string HeadingCollections => "Sammlungen";

	/// <summary>
	/// Key: "Heading.CurrentlyWearing"
	/// English String: "Currently Wearing"
	/// </summary>
	public override string HeadingCurrentlyWearing => "Derzeit getragen";

	/// <summary>
	/// Key: "Heading.FavoriteGames"
	/// English String: "Favorites"
	/// </summary>
	public override string HeadingFavoriteGames => "Favoriten";

	/// <summary>
	/// Key: "Heading.Friends"
	/// English String: "Friends"
	/// </summary>
	public override string HeadingFriends => "Freunde";

	/// <summary>
	/// Key: "Heading.Games"
	/// English String: "Games"
	/// </summary>
	public override string HeadingGames => "Spiele";

	/// <summary>
	/// Key: "Heading.GameTitle"
	/// English String: "Games"
	/// </summary>
	public override string HeadingGameTitle => "Spiele";

	/// <summary>
	/// Key: "Heading.Groups"
	/// English String: "Groups"
	/// </summary>
	public override string HeadingGroups => "Gruppen";

	/// <summary>
	/// Key: "Heading.PlayerAssetsBadges"
	/// English String: "Player Badges"
	/// </summary>
	public override string HeadingPlayerAssetsBadges => "Spielerabzeichen";

	/// <summary>
	/// Key: "Heading.PlayerAssetsClothing"
	/// English String: "Clothing"
	/// </summary>
	public override string HeadingPlayerAssetsClothing => "Kleidung";

	/// <summary>
	/// Key: "Heading.PlayerAssetsModels"
	/// English String: "Models"
	/// </summary>
	public override string HeadingPlayerAssetsModels => "Modelle";

	/// <summary>
	/// Key: "Heading.PlayerBadge"
	/// English String: "Player Badges"
	/// </summary>
	public override string HeadingPlayerBadge => "Spielerabzeichen";

	/// <summary>
	/// Key: "Heading.Profile"
	/// English String: "Profile"
	/// </summary>
	public override string HeadingProfile => "Profil";

	/// <summary>
	/// Key: "Heading.ProfileGroups"
	/// English String: "Groups"
	/// </summary>
	public override string HeadingProfileGroups => "Gruppen";

	/// <summary>
	/// Key: "Heading.RobloxBadge"
	/// English String: "Roblox Badges"
	/// </summary>
	public override string HeadingRobloxBadge => "Roblox-Abzeichen";

	/// <summary>
	/// Key: "Heading.Statistics"
	/// English String: "Statistics"
	/// </summary>
	public override string HeadingStatistics => "Statistiken";

	/// <summary>
	/// Key: "Label.About"
	/// English String: "About"
	/// </summary>
	public override string LabelAbout => "Info";

	/// <summary>
	/// Key: "Label.Alias"
	/// Friends Tag, nickname
	/// English String: "Alias"
	/// </summary>
	public override string LabelAlias => "Alias";

	/// <summary>
	/// Key: "Label.BlockWarningBody"
	/// English String: "Are you sure you want to block this user?"
	/// </summary>
	public override string LabelBlockWarningBody => "Möchtest du diesen Benutzer wirklich sperren?";

	/// <summary>
	/// Key: "Label.BlockWarningConfirm"
	/// English String: "Block"
	/// </summary>
	public override string LabelBlockWarningConfirm => "Sperren";

	/// <summary>
	/// Key: "Label.BlockWarningFooter"
	/// English String: "When you've blocked a user, neither of you can directly contact the other."
	/// </summary>
	public override string LabelBlockWarningFooter => "Wenn du einen Benutzer sperrst, könnt ihr euch nicht mehr gegenseitig kontaktieren.";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "Abbrechen";

	/// <summary>
	/// Key: "Label.ChangeAlias"
	/// set nickname
	/// English String: "Set Alias"
	/// </summary>
	public override string LabelChangeAlias => "Alias festlegen";

	/// <summary>
	/// Key: "Label.Creations"
	/// English String: "Creations"
	/// </summary>
	public override string LabelCreations => "Benutzerinhalte";

	/// <summary>
	/// Key: "Label.Followers"
	/// English String: "Followers"
	/// </summary>
	public override string LabelFollowers => "Follower";

	/// <summary>
	/// Key: "Label.Following"
	/// English String: "Following"
	/// </summary>
	public override string LabelFollowing => "Folgt";

	/// <summary>
	/// Key: "Label.ForumPosts"
	/// English String: "Forum Posts"
	/// </summary>
	public override string LabelForumPosts => "Forumposts";

	/// <summary>
	/// Key: "Label.Friends"
	/// English String: "Friends"
	/// </summary>
	public override string LabelFriends => "Freunde";

	/// <summary>
	/// Key: "Label.GridView"
	/// English String: "Grid View"
	/// </summary>
	public override string LabelGridView => "Rasteransicht";

	/// <summary>
	/// Key: "Label.JoinDate"
	/// English String: "Join Date"
	/// </summary>
	public override string LabelJoinDate => "Beitrittsdatum";

	/// <summary>
	/// Key: "Label.LoadMore"
	/// English String: "Load More"
	/// </summary>
	public override string LabelLoadMore => "Mehr laden";

	/// <summary>
	/// Key: "Label.Members"
	/// English String: "Members"
	/// </summary>
	public override string LabelMembers => "Mitglieder";

	/// <summary>
	/// Key: "Label.PastUsername"
	/// English String: "Past Usernames"
	/// </summary>
	public override string LabelPastUsername => "Vorherige Benutzernamen";

	/// <summary>
	/// Key: "Label.PastUsernames"
	/// English String: "Past usernames"
	/// </summary>
	public override string LabelPastUsernames => "Vorherige Benutzernamen";

	/// <summary>
	/// Key: "Label.PlaceVisits"
	/// English String: "Place Visits"
	/// </summary>
	public override string LabelPlaceVisits => "Ortsbesuche";

	/// <summary>
	/// Key: "Label.Playing"
	/// English String: "Playing"
	/// </summary>
	public override string LabelPlaying => "Spielt";

	/// <summary>
	/// Key: "Label.Rank"
	/// English String: "Rank"
	/// </summary>
	public override string LabelRank => "Rang";

	/// <summary>
	/// Key: "Label.ReadMore"
	/// English String: "Read More"
	/// </summary>
	public override string LabelReadMore => "Weiterlesen";

	/// <summary>
	/// Key: "Label.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string LabelReportAbuse => "Verstoß melden";

	/// <summary>
	/// Key: "Label.ShowLess"
	/// English String: "Show Less"
	/// </summary>
	public override string LabelShowLess => "Weniger anzeigen";

	/// <summary>
	/// Key: "Label.SlideshowView"
	/// English String: "Slideshow View"
	/// </summary>
	public override string LabelSlideshowView => "Diashow-Ansicht";

	/// <summary>
	/// Key: "Label.UnblockWarningBody"
	/// English String: "Are you sure you want to unblock this user?"
	/// </summary>
	public override string LabelUnblockWarningBody => "Möchtest du diesen Benutzer wirklich nicht mehr sperren?";

	/// <summary>
	/// Key: "Label.UnblockWarningConfirm"
	/// English String: "Unblock"
	/// </summary>
	public override string LabelUnblockWarningConfirm => "Nicht mehr sperren";

	/// <summary>
	/// Key: "Label.Visits"
	/// English String: "Visits"
	/// </summary>
	public override string LabelVisits => "Besuche";

	/// <summary>
	/// Key: "Label.WarningTitle"
	/// English String: "Warning"
	/// </summary>
	public override string LabelWarningTitle => "Warnung";

	/// <summary>
	/// Key: "Message.AliasHasError"
	/// English String: "An error has occurred. Please try again later"
	/// </summary>
	public override string MessageAliasHasError => "Ein Fehler ist aufgetreten. Bitte versuche es später erneut";

	/// <summary>
	/// Key: "Message.AliasIsModerated"
	/// English String: "Please avoid using full names or offensive language."
	/// </summary>
	public override string MessageAliasIsModerated => "Bitte keine vollständige Namen oder anstößige Sprache verwenden.";

	/// <summary>
	/// Key: "Message.ChangeStatus"
	/// English String: "What are you up to?"
	/// </summary>
	public override string MessageChangeStatus => "Was machst du so?";

	/// <summary>
	/// Key: "Message.ErrorBlockLimit"
	/// English String: "Operation failed! You may have blocked too many people."
	/// </summary>
	public override string MessageErrorBlockLimit => "Aktion fehlgeschlagen! Du hast eventuell zu viele Benutzer gesperrt.";

	/// <summary>
	/// Key: "Message.ErrorGeneral"
	/// English String: "Something went wrong. Please check back in a few minutes."
	/// </summary>
	public override string MessageErrorGeneral => "Etwas ist schiefgelaufen. Bitte versuche es in einigen Minuten erneut.";

	/// <summary>
	/// Key: "Message.Sharing"
	/// English String: "Sharing..."
	/// </summary>
	public override string MessageSharing => "Wird geteilt\u00a0...";

	/// <summary>
	/// Key: "Response.TooManyAttempts"
	/// flood error response
	/// English String: "Too Many Attempts"
	/// </summary>
	public override string ResponseTooManyAttempts => "Zu viele Versuche";

	public ProfileResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAccept()
	{
		return "Annehmen";
	}

	protected override string _GetTemplateForActionAddFriend()
	{
		return "Freund hinzufügen";
	}

	protected override string _GetTemplateForActionBlockUser()
	{
		return "Benutzer sperren";
	}

	protected override string _GetTemplateForActionCancelBlockUser()
	{
		return "Abbrechen";
	}

	protected override string _GetTemplateForActionChat()
	{
		return "Chatten";
	}

	protected override string _GetTemplateForActionClose()
	{
		return "Schließen";
	}

	protected override string _GetTemplateForActionConfirmBlockUser()
	{
		return "Sperren";
	}

	protected override string _GetTemplateForActionConfirmUnblockUser()
	{
		return "Nicht mehr sperren";
	}

	protected override string _GetTemplateForActionFavorites()
	{
		return "Favoriten";
	}

	protected override string _GetTemplateForActionFollow()
	{
		return "Folgen";
	}

	protected override string _GetTemplateForActionGridView()
	{
		return "Rasteransicht";
	}

	protected override string _GetTemplateForActionImpersonateUser()
	{
		return "Imitierenden Benutzer melden";
	}

	protected override string _GetTemplateForActionInventory()
	{
		return "Inventar";
	}

	protected override string _GetTemplateForActionJoinGame()
	{
		return "Spiel beitreten";
	}

	protected override string _GetTemplateForActionMessage()
	{
		return "Nachricht schreiben";
	}

	protected override string _GetTemplateForActionPending()
	{
		return "Ausstehend";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "Speichern";
	}

	protected override string _GetTemplateForActionSeeAll()
	{
		return "Alle ansehen";
	}

	protected override string _GetTemplateForActionSeeLess()
	{
		return "Weniger ansehen";
	}

	protected override string _GetTemplateForActionSeeMore()
	{
		return "Mehr ansehen";
	}

	protected override string _GetTemplateForActionSlideshowView()
	{
		return "Diashow-Ansicht";
	}

	protected override string _GetTemplateForActionTrade()
	{
		return "Handeln";
	}

	protected override string _GetTemplateForActionTradeItems()
	{
		return "Mit Artikeln handeln";
	}

	protected override string _GetTemplateForActionUnblockUser()
	{
		return "Benutzer nicht mehr sperren";
	}

	protected override string _GetTemplateForActionUnfollow()
	{
		return "Nicht mehr folgen";
	}

	protected override string _GetTemplateForActionUnfriend()
	{
		return "Von Freundesliste entfernen";
	}

	protected override string _GetTemplateForActionUpdateStatus()
	{
		return "Status aktualisieren";
	}

	protected override string _GetTemplateForDescriptionBlockUserFooter()
	{
		return "Wenn du einen Benutzer sperrst, könnt ihr euch nicht mehr gegenseitig kontaktieren.";
	}

	protected override string _GetTemplateForDescriptionBlockUserPrompt()
	{
		return "Möchtest du diesen Benutzer wirklich sperren?";
	}

	protected override string _GetTemplateForDescriptionChangeAlias()
	{
		return "Nur du kannst diese Informationen sehen";
	}

	protected override string _GetTemplateForDescriptionUnblockUserPrompt()
	{
		return "Möchtest du diesen Benutzer wirklich nicht mehr sperren?";
	}

	protected override string _GetTemplateForHeadingAboutTab()
	{
		return "Info";
	}

	protected override string _GetTemplateForHeadingBlockUserTitle()
	{
		return "Warnung";
	}

	protected override string _GetTemplateForHeadingCollections()
	{
		return "Sammlungen";
	}

	protected override string _GetTemplateForHeadingCurrentlyWearing()
	{
		return "Derzeit getragen";
	}

	protected override string _GetTemplateForHeadingFavoriteGames()
	{
		return "Favoriten";
	}

	protected override string _GetTemplateForHeadingFriends()
	{
		return "Freunde";
	}

	/// <summary>
	/// Key: "Heading.FriendsNum"
	/// English String: "Friends ({friendsCount})"
	/// </summary>
	public override string HeadingFriendsNum(string friendsCount)
	{
		return $"Freunde ({friendsCount})";
	}

	protected override string _GetTemplateForHeadingFriendsNum()
	{
		return "Freunde ({friendsCount})";
	}

	protected override string _GetTemplateForHeadingGames()
	{
		return "Spiele";
	}

	protected override string _GetTemplateForHeadingGameTitle()
	{
		return "Spiele";
	}

	protected override string _GetTemplateForHeadingGroups()
	{
		return "Gruppen";
	}

	protected override string _GetTemplateForHeadingPlayerAssetsBadges()
	{
		return "Spielerabzeichen";
	}

	protected override string _GetTemplateForHeadingPlayerAssetsClothing()
	{
		return "Kleidung";
	}

	protected override string _GetTemplateForHeadingPlayerAssetsModels()
	{
		return "Modelle";
	}

	protected override string _GetTemplateForHeadingPlayerBadge()
	{
		return "Spielerabzeichen";
	}

	protected override string _GetTemplateForHeadingProfile()
	{
		return "Profil";
	}

	protected override string _GetTemplateForHeadingProfileGroups()
	{
		return "Gruppen";
	}

	protected override string _GetTemplateForHeadingRobloxBadge()
	{
		return "Roblox-Abzeichen";
	}

	protected override string _GetTemplateForHeadingStatistics()
	{
		return "Statistiken";
	}

	protected override string _GetTemplateForLabelAbout()
	{
		return "Info";
	}

	protected override string _GetTemplateForLabelAlias()
	{
		return "Alias";
	}

	protected override string _GetTemplateForLabelBlockWarningBody()
	{
		return "Möchtest du diesen Benutzer wirklich sperren?";
	}

	protected override string _GetTemplateForLabelBlockWarningConfirm()
	{
		return "Sperren";
	}

	protected override string _GetTemplateForLabelBlockWarningFooter()
	{
		return "Wenn du einen Benutzer sperrst, könnt ihr euch nicht mehr gegenseitig kontaktieren.";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "Abbrechen";
	}

	protected override string _GetTemplateForLabelChangeAlias()
	{
		return "Alias festlegen";
	}

	protected override string _GetTemplateForLabelCreations()
	{
		return "Benutzerinhalte";
	}

	protected override string _GetTemplateForLabelFollowers()
	{
		return "Follower";
	}

	protected override string _GetTemplateForLabelFollowing()
	{
		return "Folgt";
	}

	protected override string _GetTemplateForLabelForumPosts()
	{
		return "Forumposts";
	}

	protected override string _GetTemplateForLabelFriends()
	{
		return "Freunde";
	}

	protected override string _GetTemplateForLabelGridView()
	{
		return "Rasteransicht";
	}

	protected override string _GetTemplateForLabelJoinDate()
	{
		return "Beitrittsdatum";
	}

	protected override string _GetTemplateForLabelLoadMore()
	{
		return "Mehr laden";
	}

	protected override string _GetTemplateForLabelMembers()
	{
		return "Mitglieder";
	}

	protected override string _GetTemplateForLabelPastUsername()
	{
		return "Vorherige Benutzernamen";
	}

	protected override string _GetTemplateForLabelPastUsernames()
	{
		return "Vorherige Benutzernamen";
	}

	protected override string _GetTemplateForLabelPlaceVisits()
	{
		return "Ortsbesuche";
	}

	protected override string _GetTemplateForLabelPlaying()
	{
		return "Spielt";
	}

	/// <summary>
	/// Key: "Label.Quotation"
	/// You only need to localize the quotation mark, e.g. 「{userStatus}」
	/// English String: "\"{userStatus}\""
	/// </summary>
	public override string LabelQuotation(string userStatus)
	{
		return $"„{userStatus}“";
	}

	protected override string _GetTemplateForLabelQuotation()
	{
		return "„{userStatus}“";
	}

	protected override string _GetTemplateForLabelRank()
	{
		return "Rang";
	}

	protected override string _GetTemplateForLabelReadMore()
	{
		return "Weiterlesen";
	}

	protected override string _GetTemplateForLabelReportAbuse()
	{
		return "Verstoß melden";
	}

	protected override string _GetTemplateForLabelShowLess()
	{
		return "Weniger anzeigen";
	}

	protected override string _GetTemplateForLabelSlideshowView()
	{
		return "Diashow-Ansicht";
	}

	protected override string _GetTemplateForLabelUnblockWarningBody()
	{
		return "Möchtest du diesen Benutzer wirklich nicht mehr sperren?";
	}

	protected override string _GetTemplateForLabelUnblockWarningConfirm()
	{
		return "Nicht mehr sperren";
	}

	protected override string _GetTemplateForLabelVisits()
	{
		return "Besuche";
	}

	protected override string _GetTemplateForLabelWarningTitle()
	{
		return "Warnung";
	}

	protected override string _GetTemplateForMessageAliasHasError()
	{
		return "Ein Fehler ist aufgetreten. Bitte versuche es später erneut";
	}

	protected override string _GetTemplateForMessageAliasIsModerated()
	{
		return "Bitte keine vollständige Namen oder anstößige Sprache verwenden.";
	}

	protected override string _GetTemplateForMessageChangeStatus()
	{
		return "Was machst du so?";
	}

	protected override string _GetTemplateForMessageErrorBlockLimit()
	{
		return "Aktion fehlgeschlagen! Du hast eventuell zu viele Benutzer gesperrt.";
	}

	protected override string _GetTemplateForMessageErrorGeneral()
	{
		return "Etwas ist schiefgelaufen. Bitte versuche es in einigen Minuten erneut.";
	}

	/// <summary>
	/// Key: "Message.NoCreation"
	/// English String: "{username} has no creations."
	/// </summary>
	public override string MessageNoCreation(string username)
	{
		return $"{username} hat keine Benutzerinhalte.";
	}

	protected override string _GetTemplateForMessageNoCreation()
	{
		return "{username} hat keine Benutzerinhalte.";
	}

	protected override string _GetTemplateForMessageSharing()
	{
		return "Wird geteilt\u00a0...";
	}

	protected override string _GetTemplateForResponseTooManyAttempts()
	{
		return "Zu viele Versuche";
	}
}
