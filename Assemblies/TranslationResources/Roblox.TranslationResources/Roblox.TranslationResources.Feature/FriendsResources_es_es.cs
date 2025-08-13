namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides FriendsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class FriendsResources_es_es : FriendsResources_en_us, IFriendsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Accept"
	/// English String: "Accept"
	/// </summary>
	public override string ActionAccept => "Aceptar";

	/// <summary>
	/// Key: "Action.FindFriends"
	/// English String: "Find Friends"
	/// </summary>
	public override string ActionFindFriends => "Buscar amigos";

	/// <summary>
	/// Key: "Action.Follow"
	/// English String: "Follow"
	/// </summary>
	public override string ActionFollow => "Seguir";

	/// <summary>
	/// Key: "Action.Ignore"
	/// English String: "Ignore"
	/// </summary>
	public override string ActionIgnore => "Ignorar";

	/// <summary>
	/// Key: "Action.IgnoreAll"
	/// English String: "Ignore All"
	/// </summary>
	public override string ActionIgnoreAll => "Ignorar todas";

	/// <summary>
	/// Key: "Action.Unfollow"
	/// English String: "Unfollow"
	/// </summary>
	public override string ActionUnfollow => "Dejar de seguir";

	/// <summary>
	/// Key: "Action.Unfriend"
	/// English String: "Unfriend"
	/// </summary>
	public override string ActionUnfriend => "Cancelar amistad";

	/// <summary>
	/// Key: "Heading.MyFriends"
	/// English String: "My Friends"
	/// </summary>
	public override string HeadingMyFriends => "Mis amigos";

	/// <summary>
	/// Key: "Label.ErrorTitle"
	/// English String: "Error"
	/// </summary>
	public override string LabelErrorTitle => "Error";

	/// <summary>
	/// Key: "Label.Followers"
	/// English String: "Followers"
	/// </summary>
	public override string LabelFollowers => "Seguidores";

	/// <summary>
	/// Key: "Label.Following"
	/// English String: "Following"
	/// </summary>
	public override string LabelFollowing => "Siguiendo";

	/// <summary>
	/// Key: "Label.FriendRequests"
	/// English String: "Friend Requests"
	/// </summary>
	public override string LabelFriendRequests => "Solicitudes de amistad";

	/// <summary>
	/// Key: "Label.Friends"
	/// English String: "Friends"
	/// </summary>
	public override string LabelFriends => "Amigos";

	/// <summary>
	/// Key: "Label.Offline"
	/// English String: "Offline"
	/// </summary>
	public override string LabelOffline => "Sin conexión";

	/// <summary>
	/// Key: "Label.Ok"
	/// English String: "Ok"
	/// </summary>
	public override string LabelOk => "Aceptar";

	/// <summary>
	/// Key: "Label.Online"
	/// English String: "Online"
	/// </summary>
	public override string LabelOnline => "Conectado";

	/// <summary>
	/// Key: "Label.Requests"
	/// English String: "Requests"
	/// </summary>
	public override string LabelRequests => "Solicitudes";

	/// <summary>
	/// Key: "Label.SearchFriends"
	/// When user doesn't have any friends.
	/// English String: "Search for Friends"
	/// </summary>
	public override string LabelSearchFriends => "Buscar amigos";

	/// <summary>
	/// Key: "Label.Unfollowed"
	/// Unfollowed
	/// English String: "Unfollowed"
	/// </summary>
	public override string LabelUnfollowed => "Dejaste de seguir";

	/// <summary>
	/// Key: "Message.ActionNotAllowedError"
	/// English String: "Action not allowed"
	/// </summary>
	public override string MessageActionNotAllowedError => "Acción no permitida.";

	/// <summary>
	/// Key: "Message.AlreadyExistsError"
	/// English String: "Already exists."
	/// </summary>
	public override string MessageAlreadyExistsError => "Ya existe.";

	/// <summary>
	/// Key: "Message.CurrentInvalidParametersError"
	/// English String: "Invalid parameters."
	/// </summary>
	public override string MessageCurrentInvalidParametersError => "Parámetros no válidos.";

	/// <summary>
	/// Key: "Message.CurrentUserFriendsLimitExceededError"
	/// English String: "You have reached the maximum number of Friends. Please remove a Friend before accepting any more Friend Requests."
	/// </summary>
	public override string MessageCurrentUserFriendsLimitExceededError => "Has alcanzado la cantidad máxima de amigos. Elimina a un amigo antes de aceptar más solicitudes de amistad.";

	/// <summary>
	/// Key: "Message.DefaultError"
	/// English String: "An error ocurred."
	/// </summary>
	public override string MessageDefaultError => "Se ha producido un error.";

	/// <summary>
	/// Key: "Message.FloodLimitExceededError"
	/// English String: "You are performing this action too often. Please wait a minute and try again."
	/// </summary>
	public override string MessageFloodLimitExceededError => "Estás llevando a cabo esta acción demasiado a menudo. Espera un minuto e inténtalo de nuevo.";

	/// <summary>
	/// Key: "Message.FollowerTabTooltip"
	/// English String: "People who have chosen to follow your activity."
	/// </summary>
	public override string MessageFollowerTabTooltip => "Personas que han decidido seguir tu actividad.";

	/// <summary>
	/// Key: "Message.FollowingTabTooltip"
	/// English String: "People whose activity you have chosen to follow."
	/// </summary>
	public override string MessageFollowingTabTooltip => "Personas cuya actividad has decidido seguir.";

	/// <summary>
	/// Key: "Message.ForGeneralError"
	/// English String: "Something went wrong."
	/// </summary>
	public override string MessageForGeneralError => "Algo ha ido mal";

	/// <summary>
	/// Key: "Message.ForGeneralFooter"
	/// English String: "Please check back in few minutes."
	/// </summary>
	public override string MessageForGeneralFooter => "Vuelve a intentarlo dentro de unos minutos.";

	/// <summary>
	/// Key: "Message.ForMaxFriendsError"
	/// English String: "Unable to process Request.You currently have the max number of Friends allowed. "
	/// </summary>
	public override string MessageForMaxFriendsError => "No se ha podido procesar la solicitud. En este momento tienes la máxima cantidad de amigos permitida. ";

	/// <summary>
	/// Key: "Message.ForMaxFriendsFooter"
	/// English String: "Unfriend someone before accepting any more Friend Requests."
	/// </summary>
	public override string MessageForMaxFriendsFooter => "Cancela la amistad con alguien antes de aceptar más solicitudes de amistad.";

	/// <summary>
	/// Key: "Message.ForMaxRequestsError"
	/// English String: "Unable to process Request. That user currently has the max number of Friends allowed."
	/// </summary>
	public override string MessageForMaxRequestsError => "No se ha podido procesar la solicitud. Ese usuario tiene la máxima cantidad de amigos permitida.";

	/// <summary>
	/// Key: "Message.ForMaxRequestsFooter"
	/// English String: "You can not accept their Friend Request until they remove a Friend."
	/// </summary>
	public override string MessageForMaxRequestsFooter => "No puedes aceptar su solicitud de amistad hasta que elimine a un amigo.";

	/// <summary>
	/// Key: "Message.FriendRequestNotExistError"
	/// English String: "Friend request does not exist"
	/// </summary>
	public override string MessageFriendRequestNotExistError => "La solicitud de amistad no existe.";

	/// <summary>
	/// Key: "Message.FriendsLimitExceededError"
	/// English String: "Friends limit exceeded."
	/// </summary>
	public override string MessageFriendsLimitExceededError => "Límite de amigos excedido.";

	/// <summary>
	/// Key: "Message.FriendsTabTooltip"
	/// English String: "Friends are established when two Roblox users mutually agree to friendship."
	/// </summary>
	public override string MessageFriendsTabTooltip => "Una amistad se establece cuando dos usuarios de Roblox acceden mutuamente a ser amigos.";

	/// <summary>
	/// Key: "Message.NotRecipientError"
	/// English String: "You are not the recipient of this friend request."
	/// </summary>
	public override string MessageNotRecipientError => "Tú no eres el destinatario de esta solicitud de amistad.";

	/// <summary>
	/// Key: "Message.OtherUserFriendsLimitExceededError"
	/// English String: "Friends limit exceeded."
	/// </summary>
	public override string MessageOtherUserFriendsLimitExceededError => "Límite de amigos excedido.";

	/// <summary>
	/// Key: "Message.RequestsTabTooltip"
	/// English String: "Friends are established when two Roblox users mutually agree to friendship."
	/// </summary>
	public override string MessageRequestsTabTooltip => "Una amistad se establece cuando dos usuarios de Roblox acceden mutuamente a ser amigos.";

	/// <summary>
	/// Key: "Message.RobloxIsMoreFunWithFriends"
	/// English String: "Roblox is more fun with friends!"
	/// </summary>
	public override string MessageRobloxIsMoreFunWithFriends => "¡Roblox es más divertido con amigos!";

	/// <summary>
	/// Key: "Message.SelfFollowingAttemptError"
	/// English String: "You cannot follow yourself."
	/// </summary>
	public override string MessageSelfFollowingAttemptError => "No puedes seguir a tu propio usuario.";

	/// <summary>
	/// Key: "Message.SelfFriendingAttemptError"
	/// English String: "You cannot be friends with yourself."
	/// </summary>
	public override string MessageSelfFriendingAttemptError => "No puedes ser amigo de tu propio usuario.";

	/// <summary>
	/// Key: "Message.SystemUnavailableError"
	/// English String: "Friends and Followers system is unavailable."
	/// </summary>
	public override string MessageSystemUnavailableError => "El sistema de amigos y seguidores no está disponible.";

	/// <summary>
	/// Key: "Message.UnblockUserPinLockedError"
	/// English String: "Pin is locked."
	/// </summary>
	public override string MessageUnblockUserPinLockedError => "El PIN está bloqueado.";

	/// <summary>
	/// Key: "Message.UserBlockedError"
	/// English String: "User is blocked"
	/// </summary>
	public override string MessageUserBlockedError => "El usuario está bloqueado.";

	/// <summary>
	/// Key: "Message.UserHasNotPassedCaptchaError"
	/// English String: "You need to pass Captcha."
	/// </summary>
	public override string MessageUserHasNotPassedCaptchaError => "Necesitas aprobar el Captcha.";

	/// <summary>
	/// Key: "Message.UsersAreNotInSameGameError"
	/// English String: "Users need to be in the same game."
	/// </summary>
	public override string MessageUsersAreNotInSameGameError => "Los usuarios necesitan estar en el mismo juego.";

	public FriendsResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAccept()
	{
		return "Aceptar";
	}

	protected override string _GetTemplateForActionFindFriends()
	{
		return "Buscar amigos";
	}

	protected override string _GetTemplateForActionFollow()
	{
		return "Seguir";
	}

	protected override string _GetTemplateForActionIgnore()
	{
		return "Ignorar";
	}

	protected override string _GetTemplateForActionIgnoreAll()
	{
		return "Ignorar todas";
	}

	protected override string _GetTemplateForActionUnfollow()
	{
		return "Dejar de seguir";
	}

	protected override string _GetTemplateForActionUnfriend()
	{
		return "Cancelar amistad";
	}

	/// <summary>
	/// Key: "Description.SearchFriends"
	/// When user doesn't have friends, this suggestive text will show up.
	/// English String: "Tap the magnifying glass icon above and search for a user or {startLink}play games{endLink} to meet people."
	/// </summary>
	public override string DescriptionSearchFriends(string startLink, string endLink)
	{
		return $"Toca el icono de lupa arriba para buscar un usuario o {startLink}juega{endLink} para conocer a gente.";
	}

	protected override string _GetTemplateForDescriptionSearchFriends()
	{
		return "Toca el icono de lupa arriba para buscar un usuario o {startLink}juega{endLink} para conocer a gente.";
	}

	protected override string _GetTemplateForHeadingMyFriends()
	{
		return "Mis amigos";
	}

	/// <summary>
	/// Key: "Heading.UsersFriends"
	/// English String: "{username}'s Friends"
	/// </summary>
	public override string HeadingUsersFriends(string username)
	{
		return $"Amigos de {username}";
	}

	protected override string _GetTemplateForHeadingUsersFriends()
	{
		return "Amigos de {username}";
	}

	protected override string _GetTemplateForLabelErrorTitle()
	{
		return "Error";
	}

	protected override string _GetTemplateForLabelFollowers()
	{
		return "Seguidores";
	}

	protected override string _GetTemplateForLabelFollowing()
	{
		return "Siguiendo";
	}

	protected override string _GetTemplateForLabelFriendRequests()
	{
		return "Solicitudes de amistad";
	}

	protected override string _GetTemplateForLabelFriends()
	{
		return "Amigos";
	}

	/// <summary>
	/// Key: "Label.NearbyUpsell"
	/// Shown when a user is on the Universal Friend Finder page and has no friend requests. This tells them to try another feature to find friends called "Nearby"
	/// English String: "You have no pending friend requests. To add friends, check out {startSpan}Nearby{endSpan}."
	/// </summary>
	public override string LabelNearbyUpsell(string startSpan, string endSpan)
	{
		return $"No tienes solicitudes de amistad pendientes. Para agregar amigos, prueba la función {startSpan}Cerca{endSpan}.";
	}

	protected override string _GetTemplateForLabelNearbyUpsell()
	{
		return "No tienes solicitudes de amistad pendientes. Para agregar amigos, prueba la función {startSpan}Cerca{endSpan}.";
	}

	protected override string _GetTemplateForLabelOffline()
	{
		return "Sin conexión";
	}

	protected override string _GetTemplateForLabelOk()
	{
		return "Aceptar";
	}

	protected override string _GetTemplateForLabelOnline()
	{
		return "Conectado";
	}

	protected override string _GetTemplateForLabelRequests()
	{
		return "Solicitudes";
	}

	protected override string _GetTemplateForLabelSearchFriends()
	{
		return "Buscar amigos";
	}

	protected override string _GetTemplateForLabelUnfollowed()
	{
		return "Dejaste de seguir";
	}

	protected override string _GetTemplateForMessageActionNotAllowedError()
	{
		return "Acción no permitida.";
	}

	protected override string _GetTemplateForMessageAlreadyExistsError()
	{
		return "Ya existe.";
	}

	protected override string _GetTemplateForMessageCurrentInvalidParametersError()
	{
		return "Parámetros no válidos.";
	}

	protected override string _GetTemplateForMessageCurrentUserFriendsLimitExceededError()
	{
		return "Has alcanzado la cantidad máxima de amigos. Elimina a un amigo antes de aceptar más solicitudes de amistad.";
	}

	protected override string _GetTemplateForMessageDefaultError()
	{
		return "Se ha producido un error.";
	}

	protected override string _GetTemplateForMessageFloodLimitExceededError()
	{
		return "Estás llevando a cabo esta acción demasiado a menudo. Espera un minuto e inténtalo de nuevo.";
	}

	protected override string _GetTemplateForMessageFollowerTabTooltip()
	{
		return "Personas que han decidido seguir tu actividad.";
	}

	protected override string _GetTemplateForMessageFollowingTabTooltip()
	{
		return "Personas cuya actividad has decidido seguir.";
	}

	protected override string _GetTemplateForMessageForGeneralError()
	{
		return "Algo ha ido mal";
	}

	protected override string _GetTemplateForMessageForGeneralFooter()
	{
		return "Vuelve a intentarlo dentro de unos minutos.";
	}

	protected override string _GetTemplateForMessageForMaxFriendsError()
	{
		return "No se ha podido procesar la solicitud. En este momento tienes la máxima cantidad de amigos permitida. ";
	}

	protected override string _GetTemplateForMessageForMaxFriendsFooter()
	{
		return "Cancela la amistad con alguien antes de aceptar más solicitudes de amistad.";
	}

	protected override string _GetTemplateForMessageForMaxRequestsError()
	{
		return "No se ha podido procesar la solicitud. Ese usuario tiene la máxima cantidad de amigos permitida.";
	}

	protected override string _GetTemplateForMessageForMaxRequestsFooter()
	{
		return "No puedes aceptar su solicitud de amistad hasta que elimine a un amigo.";
	}

	protected override string _GetTemplateForMessageFriendRequestNotExistError()
	{
		return "La solicitud de amistad no existe.";
	}

	protected override string _GetTemplateForMessageFriendsLimitExceededError()
	{
		return "Límite de amigos excedido.";
	}

	protected override string _GetTemplateForMessageFriendsTabTooltip()
	{
		return "Una amistad se establece cuando dos usuarios de Roblox acceden mutuamente a ser amigos.";
	}

	protected override string _GetTemplateForMessageNotRecipientError()
	{
		return "Tú no eres el destinatario de esta solicitud de amistad.";
	}

	protected override string _GetTemplateForMessageOtherUserFriendsLimitExceededError()
	{
		return "Límite de amigos excedido.";
	}

	protected override string _GetTemplateForMessageRequestsTabTooltip()
	{
		return "Una amistad se establece cuando dos usuarios de Roblox acceden mutuamente a ser amigos.";
	}

	protected override string _GetTemplateForMessageRobloxIsMoreFunWithFriends()
	{
		return "¡Roblox es más divertido con amigos!";
	}

	protected override string _GetTemplateForMessageSelfFollowingAttemptError()
	{
		return "No puedes seguir a tu propio usuario.";
	}

	protected override string _GetTemplateForMessageSelfFriendingAttemptError()
	{
		return "No puedes ser amigo de tu propio usuario.";
	}

	protected override string _GetTemplateForMessageSystemUnavailableError()
	{
		return "El sistema de amigos y seguidores no está disponible.";
	}

	protected override string _GetTemplateForMessageUnblockUserPinLockedError()
	{
		return "El PIN está bloqueado.";
	}

	protected override string _GetTemplateForMessageUserBlockedError()
	{
		return "El usuario está bloqueado.";
	}

	protected override string _GetTemplateForMessageUserHasNotPassedCaptchaError()
	{
		return "Necesitas aprobar el Captcha.";
	}

	protected override string _GetTemplateForMessageUsersAreNotInSameGameError()
	{
		return "Los usuarios necesitan estar en el mismo juego.";
	}
}
