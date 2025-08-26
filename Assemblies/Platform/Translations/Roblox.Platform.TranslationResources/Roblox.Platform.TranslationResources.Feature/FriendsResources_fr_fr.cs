namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides FriendsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class FriendsResources_fr_fr : FriendsResources_en_us, IFriendsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Accept"
	/// English String: "Accept"
	/// </summary>
	public override string ActionAccept => "Accepter";

	/// <summary>
	/// Key: "Action.FindFriends"
	/// English String: "Find Friends"
	/// </summary>
	public override string ActionFindFriends => "Trouver des amis";

	/// <summary>
	/// Key: "Action.Follow"
	/// English String: "Follow"
	/// </summary>
	public override string ActionFollow => "Suivre";

	/// <summary>
	/// Key: "Action.Ignore"
	/// English String: "Ignore"
	/// </summary>
	public override string ActionIgnore => "Ignorer";

	/// <summary>
	/// Key: "Action.IgnoreAll"
	/// English String: "Ignore All"
	/// </summary>
	public override string ActionIgnoreAll => "Ignorer tout";

	/// <summary>
	/// Key: "Action.Unfollow"
	/// English String: "Unfollow"
	/// </summary>
	public override string ActionUnfollow => "Ne plus suivre";

	/// <summary>
	/// Key: "Action.Unfriend"
	/// English String: "Unfriend"
	/// </summary>
	public override string ActionUnfriend => "Retirer des amis";

	/// <summary>
	/// Key: "Heading.MyFriends"
	/// English String: "My Friends"
	/// </summary>
	public override string HeadingMyFriends => "Mes amis";

	/// <summary>
	/// Key: "Label.ErrorTitle"
	/// English String: "Error"
	/// </summary>
	public override string LabelErrorTitle => "Erreur";

	/// <summary>
	/// Key: "Label.Followers"
	/// English String: "Followers"
	/// </summary>
	public override string LabelFollowers => "AbonnÃ©s";

	/// <summary>
	/// Key: "Label.Following"
	/// English String: "Following"
	/// </summary>
	public override string LabelFollowing => "Abonnements";

	/// <summary>
	/// Key: "Label.FriendRequests"
	/// English String: "Friend Requests"
	/// </summary>
	public override string LabelFriendRequests => "Demandes d'amitiÃ©";

	/// <summary>
	/// Key: "Label.Friends"
	/// English String: "Friends"
	/// </summary>
	public override string LabelFriends => "Amis";

	/// <summary>
	/// Key: "Label.Offline"
	/// English String: "Offline"
	/// </summary>
	public override string LabelOffline => "DÃ©connectÃ©";

	/// <summary>
	/// Key: "Label.Ok"
	/// English String: "Ok"
	/// </summary>
	public override string LabelOk => "Ok";

	/// <summary>
	/// Key: "Label.Online"
	/// English String: "Online"
	/// </summary>
	public override string LabelOnline => "ConnectÃ©";

	/// <summary>
	/// Key: "Label.Requests"
	/// English String: "Requests"
	/// </summary>
	public override string LabelRequests => "Demandes";

	/// <summary>
	/// Key: "Label.SearchFriends"
	/// When user doesn't have any friends.
	/// English String: "Search for Friends"
	/// </summary>
	public override string LabelSearchFriends => "Rechercher des amis";

	/// <summary>
	/// Key: "Label.Unfollowed"
	/// Unfollowed
	/// English String: "Unfollowed"
	/// </summary>
	public override string LabelUnfollowed => "Plus suivi(e)";

	/// <summary>
	/// Key: "Message.ActionNotAllowedError"
	/// English String: "Action not allowed"
	/// </summary>
	public override string MessageActionNotAllowedError => "Action non autorisÃ©e.";

	/// <summary>
	/// Key: "Message.AlreadyExistsError"
	/// English String: "Already exists."
	/// </summary>
	public override string MessageAlreadyExistsError => "Existe dÃ©jÃ .";

	/// <summary>
	/// Key: "Message.CurrentInvalidParametersError"
	/// English String: "Invalid parameters."
	/// </summary>
	public override string MessageCurrentInvalidParametersError => "ParamÃ¨tres non valides.";

	/// <summary>
	/// Key: "Message.CurrentUserFriendsLimitExceededError"
	/// English String: "You have reached the maximum number of Friends. Please remove a Friend before accepting any more Friend Requests."
	/// </summary>
	public override string MessageCurrentUserFriendsLimitExceededError => "Tu as atteint le nombre maximum d'amis autorisÃ©s. Retire des utilisateurs de ta liste d'amis pour en accepter d'autres.";

	/// <summary>
	/// Key: "Message.DefaultError"
	/// English String: "An error ocurred."
	/// </summary>
	public override string MessageDefaultError => "Une erreur est survenue.";

	/// <summary>
	/// Key: "Message.FloodLimitExceededError"
	/// English String: "You are performing this action too often. Please wait a minute and try again."
	/// </summary>
	public override string MessageFloodLimitExceededError => "Vous effectuez cette action trop souvent. Veuillez patienter un moment avant de rÃ©essayer.";

	/// <summary>
	/// Key: "Message.FollowerTabTooltip"
	/// English String: "People who have chosen to follow your activity."
	/// </summary>
	public override string MessageFollowerTabTooltip => "Les utilisateurs qui ont choisi de suivre ton activitÃ©.";

	/// <summary>
	/// Key: "Message.FollowingTabTooltip"
	/// English String: "People whose activity you have chosen to follow."
	/// </summary>
	public override string MessageFollowingTabTooltip => "Les utilisateurs dont vous avez choisi de suivre l'activitÃ©.";

	/// <summary>
	/// Key: "Message.ForGeneralError"
	/// English String: "Something went wrong."
	/// </summary>
	public override string MessageForGeneralError => "Un problÃ¨me est survenu.";

	/// <summary>
	/// Key: "Message.ForGeneralFooter"
	/// English String: "Please check back in few minutes."
	/// </summary>
	public override string MessageForGeneralFooter => "Veuillez rÃ©essayer dans quelques minutes.";

	/// <summary>
	/// Key: "Message.ForMaxFriendsError"
	/// English String: "Unable to process Request.You currently have the max number of Friends allowed. "
	/// </summary>
	public override string MessageForMaxFriendsError => "Impossible de traiter la demande. Vous disposez du nombre maximum d'amis autorisÃ©s. ";

	/// <summary>
	/// Key: "Message.ForMaxFriendsFooter"
	/// English String: "Unfriend someone before accepting any more Friend Requests."
	/// </summary>
	public override string MessageForMaxFriendsFooter => "Retire des utilisateurs de ta liste d'amis pour en accepter d'autres.";

	/// <summary>
	/// Key: "Message.ForMaxRequestsError"
	/// English String: "Unable to process Request. That user currently has the max number of Friends allowed."
	/// </summary>
	public override string MessageForMaxRequestsError => "Impossible de traiter la demande. L'utilisateur dispose du nombre maximum d'amis autorisÃ©s.";

	/// <summary>
	/// Key: "Message.ForMaxRequestsFooter"
	/// English String: "You can not accept their Friend Request until they remove a Friend."
	/// </summary>
	public override string MessageForMaxRequestsFooter => "Vous ne pouvez pas accepter sa demande jusqu'Ã  ce qu'il libÃ¨re de la place dans sa liste d'amis.";

	/// <summary>
	/// Key: "Message.FriendRequestNotExistError"
	/// English String: "Friend request does not exist"
	/// </summary>
	public override string MessageFriendRequestNotExistError => "La demande d'amitiÃ© n'existe pas.";

	/// <summary>
	/// Key: "Message.FriendsLimitExceededError"
	/// English String: "Friends limit exceeded."
	/// </summary>
	public override string MessageFriendsLimitExceededError => "Limite d'amis atteinte.";

	/// <summary>
	/// Key: "Message.FriendsTabTooltip"
	/// English String: "Friends are established when two Roblox users mutually agree to friendship."
	/// </summary>
	public override string MessageFriendsTabTooltip => "Des utilisateurs sont ajoutÃ©s Ã  ta liste quand vous acceptez mutuellement de devenir amis.";

	/// <summary>
	/// Key: "Message.NotRecipientError"
	/// English String: "You are not the recipient of this friend request."
	/// </summary>
	public override string MessageNotRecipientError => "Vous n'Ãªtes pas le destinataire de cette demande d'amitiÃ©.";

	/// <summary>
	/// Key: "Message.OtherUserFriendsLimitExceededError"
	/// English String: "Friends limit exceeded."
	/// </summary>
	public override string MessageOtherUserFriendsLimitExceededError => "Limite d'amis atteinte.";

	/// <summary>
	/// Key: "Message.RequestsTabTooltip"
	/// English String: "Friends are established when two Roblox users mutually agree to friendship."
	/// </summary>
	public override string MessageRequestsTabTooltip => "Des utilisateurs sont ajoutÃ©s Ã  ta liste quand vous acceptez mutuellement de devenir amis.";

	/// <summary>
	/// Key: "Message.RobloxIsMoreFunWithFriends"
	/// English String: "Roblox is more fun with friends!"
	/// </summary>
	public override string MessageRobloxIsMoreFunWithFriends => "Roblox est plus amusant entre amis\u00a0!";

	/// <summary>
	/// Key: "Message.SelfFollowingAttemptError"
	/// English String: "You cannot follow yourself."
	/// </summary>
	public override string MessageSelfFollowingAttemptError => "Tu ne peux pas suivre ta propre activitÃ©.";

	/// <summary>
	/// Key: "Message.SelfFriendingAttemptError"
	/// English String: "You cannot be friends with yourself."
	/// </summary>
	public override string MessageSelfFriendingAttemptError => "Vous ne pouvez pas Ãªtre ami(e) avec vous-mÃªme.";

	/// <summary>
	/// Key: "Message.SystemUnavailableError"
	/// English String: "Friends and Followers system is unavailable."
	/// </summary>
	public override string MessageSystemUnavailableError => "Le systÃ¨me d'amis et d'abonnÃ©s n'est pas disponible.";

	/// <summary>
	/// Key: "Message.UnblockUserPinLockedError"
	/// English String: "Pin is locked."
	/// </summary>
	public override string MessageUnblockUserPinLockedError => "Le code PIN est verrouillÃ©.";

	/// <summary>
	/// Key: "Message.UserBlockedError"
	/// English String: "User is blocked"
	/// </summary>
	public override string MessageUserBlockedError => "L'utilisateur est bloquÃ©.";

	/// <summary>
	/// Key: "Message.UserHasNotPassedCaptchaError"
	/// English String: "You need to pass Captcha."
	/// </summary>
	public override string MessageUserHasNotPassedCaptchaError => "Vous devez valider le captcha.";

	/// <summary>
	/// Key: "Message.UsersAreNotInSameGameError"
	/// English String: "Users need to be in the same game."
	/// </summary>
	public override string MessageUsersAreNotInSameGameError => "Les utilisateurs doivent Ãªtre dans le mÃªme jeu.";

	public FriendsResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAccept()
	{
		return "Accepter";
	}

	protected override string _GetTemplateForActionFindFriends()
	{
		return "Trouver des amis";
	}

	protected override string _GetTemplateForActionFollow()
	{
		return "Suivre";
	}

	protected override string _GetTemplateForActionIgnore()
	{
		return "Ignorer";
	}

	protected override string _GetTemplateForActionIgnoreAll()
	{
		return "Ignorer tout";
	}

	protected override string _GetTemplateForActionUnfollow()
	{
		return "Ne plus suivre";
	}

	protected override string _GetTemplateForActionUnfriend()
	{
		return "Retirer des amis";
	}

	/// <summary>
	/// Key: "Description.SearchFriends"
	/// When user doesn't have friends, this suggestive text will show up.
	/// English String: "Tap the magnifying glass icon above and search for a user or {startLink}play games{endLink} to meet people."
	/// </summary>
	public override string DescriptionSearchFriends(string startLink, string endLink)
	{
		return $"Appuyez sur l'icÃ´ne de loupe ci-dessus pour rechercher un utilisateur ou {startLink}jouez{endLink} afin de rencontrer des gens.";
	}

	protected override string _GetTemplateForDescriptionSearchFriends()
	{
		return "Appuyez sur l'icÃ´ne de loupe ci-dessus pour rechercher un utilisateur ou {startLink}jouez{endLink} afin de rencontrer des gens.";
	}

	protected override string _GetTemplateForHeadingMyFriends()
	{
		return "Mes amis";
	}

	/// <summary>
	/// Key: "Heading.UsersFriends"
	/// English String: "{username}'s Friends"
	/// </summary>
	public override string HeadingUsersFriends(string username)
	{
		return $"Amis de {username}";
	}

	protected override string _GetTemplateForHeadingUsersFriends()
	{
		return "Amis de {username}";
	}

	protected override string _GetTemplateForLabelErrorTitle()
	{
		return "Erreur";
	}

	protected override string _GetTemplateForLabelFollowers()
	{
		return "AbonnÃ©s";
	}

	protected override string _GetTemplateForLabelFollowing()
	{
		return "Abonnements";
	}

	protected override string _GetTemplateForLabelFriendRequests()
	{
		return "Demandes d'amitiÃ©";
	}

	protected override string _GetTemplateForLabelFriends()
	{
		return "Amis";
	}

	/// <summary>
	/// Key: "Label.NearbyUpsell"
	/// Shown when a user is on the Universal Friend Finder page and has no friend requests. This tells them to try another feature to find friends called "Nearby"
	/// English String: "You have no pending friend requests. To add friends, check out {startSpan}Nearby{endSpan}."
	/// </summary>
	public override string LabelNearbyUpsell(string startSpan, string endSpan)
	{
		return $"Vous n'avez aucune demande d'amitiÃ© en attente. Pour ajouter un ami, consultez {startSpan}Proche{endSpan}.";
	}

	protected override string _GetTemplateForLabelNearbyUpsell()
	{
		return "Vous n'avez aucune demande d'amitiÃ© en attente. Pour ajouter un ami, consultez {startSpan}Proche{endSpan}.";
	}

	protected override string _GetTemplateForLabelOffline()
	{
		return "DÃ©connectÃ©";
	}

	protected override string _GetTemplateForLabelOk()
	{
		return "Ok";
	}

	protected override string _GetTemplateForLabelOnline()
	{
		return "ConnectÃ©";
	}

	protected override string _GetTemplateForLabelRequests()
	{
		return "Demandes";
	}

	protected override string _GetTemplateForLabelSearchFriends()
	{
		return "Rechercher des amis";
	}

	protected override string _GetTemplateForLabelUnfollowed()
	{
		return "Plus suivi(e)";
	}

	protected override string _GetTemplateForMessageActionNotAllowedError()
	{
		return "Action non autorisÃ©e.";
	}

	protected override string _GetTemplateForMessageAlreadyExistsError()
	{
		return "Existe dÃ©jÃ .";
	}

	protected override string _GetTemplateForMessageCurrentInvalidParametersError()
	{
		return "ParamÃ¨tres non valides.";
	}

	protected override string _GetTemplateForMessageCurrentUserFriendsLimitExceededError()
	{
		return "Tu as atteint le nombre maximum d'amis autorisÃ©s. Retire des utilisateurs de ta liste d'amis pour en accepter d'autres.";
	}

	protected override string _GetTemplateForMessageDefaultError()
	{
		return "Une erreur est survenue.";
	}

	protected override string _GetTemplateForMessageFloodLimitExceededError()
	{
		return "Vous effectuez cette action trop souvent. Veuillez patienter un moment avant de rÃ©essayer.";
	}

	protected override string _GetTemplateForMessageFollowerTabTooltip()
	{
		return "Les utilisateurs qui ont choisi de suivre ton activitÃ©.";
	}

	protected override string _GetTemplateForMessageFollowingTabTooltip()
	{
		return "Les utilisateurs dont vous avez choisi de suivre l'activitÃ©.";
	}

	protected override string _GetTemplateForMessageForGeneralError()
	{
		return "Un problÃ¨me est survenu.";
	}

	protected override string _GetTemplateForMessageForGeneralFooter()
	{
		return "Veuillez rÃ©essayer dans quelques minutes.";
	}

	protected override string _GetTemplateForMessageForMaxFriendsError()
	{
		return "Impossible de traiter la demande. Vous disposez du nombre maximum d'amis autorisÃ©s. ";
	}

	protected override string _GetTemplateForMessageForMaxFriendsFooter()
	{
		return "Retire des utilisateurs de ta liste d'amis pour en accepter d'autres.";
	}

	protected override string _GetTemplateForMessageForMaxRequestsError()
	{
		return "Impossible de traiter la demande. L'utilisateur dispose du nombre maximum d'amis autorisÃ©s.";
	}

	protected override string _GetTemplateForMessageForMaxRequestsFooter()
	{
		return "Vous ne pouvez pas accepter sa demande jusqu'Ã  ce qu'il libÃ¨re de la place dans sa liste d'amis.";
	}

	protected override string _GetTemplateForMessageFriendRequestNotExistError()
	{
		return "La demande d'amitiÃ© n'existe pas.";
	}

	protected override string _GetTemplateForMessageFriendsLimitExceededError()
	{
		return "Limite d'amis atteinte.";
	}

	protected override string _GetTemplateForMessageFriendsTabTooltip()
	{
		return "Des utilisateurs sont ajoutÃ©s Ã  ta liste quand vous acceptez mutuellement de devenir amis.";
	}

	protected override string _GetTemplateForMessageNotRecipientError()
	{
		return "Vous n'Ãªtes pas le destinataire de cette demande d'amitiÃ©.";
	}

	protected override string _GetTemplateForMessageOtherUserFriendsLimitExceededError()
	{
		return "Limite d'amis atteinte.";
	}

	protected override string _GetTemplateForMessageRequestsTabTooltip()
	{
		return "Des utilisateurs sont ajoutÃ©s Ã  ta liste quand vous acceptez mutuellement de devenir amis.";
	}

	protected override string _GetTemplateForMessageRobloxIsMoreFunWithFriends()
	{
		return "Roblox est plus amusant entre amis\u00a0!";
	}

	protected override string _GetTemplateForMessageSelfFollowingAttemptError()
	{
		return "Tu ne peux pas suivre ta propre activitÃ©.";
	}

	protected override string _GetTemplateForMessageSelfFriendingAttemptError()
	{
		return "Vous ne pouvez pas Ãªtre ami(e) avec vous-mÃªme.";
	}

	protected override string _GetTemplateForMessageSystemUnavailableError()
	{
		return "Le systÃ¨me d'amis et d'abonnÃ©s n'est pas disponible.";
	}

	protected override string _GetTemplateForMessageUnblockUserPinLockedError()
	{
		return "Le code PIN est verrouillÃ©.";
	}

	protected override string _GetTemplateForMessageUserBlockedError()
	{
		return "L'utilisateur est bloquÃ©.";
	}

	protected override string _GetTemplateForMessageUserHasNotPassedCaptchaError()
	{
		return "Vous devez valider le captcha.";
	}

	protected override string _GetTemplateForMessageUsersAreNotInSameGameError()
	{
		return "Les utilisateurs doivent Ãªtre dans le mÃªme jeu.";
	}
}


}
