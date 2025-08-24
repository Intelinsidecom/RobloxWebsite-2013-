namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides FriendsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class FriendsResources_pt_br : FriendsResources_en_us, IFriendsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Accept"
	/// English String: "Accept"
	/// </summary>
	public override string ActionAccept => "Aceitar";

	/// <summary>
	/// Key: "Action.FindFriends"
	/// English String: "Find Friends"
	/// </summary>
	public override string ActionFindFriends => "Encontrar amigos";

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
	public override string ActionIgnoreAll => "Ignorar todos";

	/// <summary>
	/// Key: "Action.Unfollow"
	/// English String: "Unfollow"
	/// </summary>
	public override string ActionUnfollow => "Deixar de seguir";

	/// <summary>
	/// Key: "Action.Unfriend"
	/// English String: "Unfriend"
	/// </summary>
	public override string ActionUnfriend => "Remover amigo";

	/// <summary>
	/// Key: "Heading.MyFriends"
	/// English String: "My Friends"
	/// </summary>
	public override string HeadingMyFriends => "Meus amigos";

	/// <summary>
	/// Key: "Label.ErrorTitle"
	/// English String: "Error"
	/// </summary>
	public override string LabelErrorTitle => "Erro";

	/// <summary>
	/// Key: "Label.Followers"
	/// English String: "Followers"
	/// </summary>
	public override string LabelFollowers => "Seguidores";

	/// <summary>
	/// Key: "Label.Following"
	/// English String: "Following"
	/// </summary>
	public override string LabelFollowing => "Seguindo";

	/// <summary>
	/// Key: "Label.FriendRequests"
	/// English String: "Friend Requests"
	/// </summary>
	public override string LabelFriendRequests => "Pedidos de amizade";

	/// <summary>
	/// Key: "Label.Friends"
	/// English String: "Friends"
	/// </summary>
	public override string LabelFriends => "Amigos";

	/// <summary>
	/// Key: "Label.Offline"
	/// English String: "Offline"
	/// </summary>
	public override string LabelOffline => "Offline";

	/// <summary>
	/// Key: "Label.Ok"
	/// English String: "Ok"
	/// </summary>
	public override string LabelOk => "Ok";

	/// <summary>
	/// Key: "Label.Online"
	/// English String: "Online"
	/// </summary>
	public override string LabelOnline => "Online";

	/// <summary>
	/// Key: "Label.Requests"
	/// English String: "Requests"
	/// </summary>
	public override string LabelRequests => "Pedidos";

	/// <summary>
	/// Key: "Label.SearchFriends"
	/// When user doesn't have any friends.
	/// English String: "Search for Friends"
	/// </summary>
	public override string LabelSearchFriends => "Pesquisar amigos";

	/// <summary>
	/// Key: "Label.Unfollowed"
	/// Unfollowed
	/// English String: "Unfollowed"
	/// </summary>
	public override string LabelUnfollowed => "Deixou de seguir";

	/// <summary>
	/// Key: "Message.ActionNotAllowedError"
	/// English String: "Action not allowed"
	/// </summary>
	public override string MessageActionNotAllowedError => "Ação não permitida";

	/// <summary>
	/// Key: "Message.AlreadyExistsError"
	/// English String: "Already exists."
	/// </summary>
	public override string MessageAlreadyExistsError => "Já existe.";

	/// <summary>
	/// Key: "Message.CurrentInvalidParametersError"
	/// English String: "Invalid parameters."
	/// </summary>
	public override string MessageCurrentInvalidParametersError => "Parâmetros inválidos.";

	/// <summary>
	/// Key: "Message.CurrentUserFriendsLimitExceededError"
	/// English String: "You have reached the maximum number of Friends. Please remove a Friend before accepting any more Friend Requests."
	/// </summary>
	public override string MessageCurrentUserFriendsLimitExceededError => "Você alcançou o número máximo de amigos. Remova um amigo antes de aceitar mais pedidos de amizade.";

	/// <summary>
	/// Key: "Message.DefaultError"
	/// English String: "An error ocurred."
	/// </summary>
	public override string MessageDefaultError => "Ocorreu um erro.";

	/// <summary>
	/// Key: "Message.FloodLimitExceededError"
	/// English String: "You are performing this action too often. Please wait a minute and try again."
	/// </summary>
	public override string MessageFloodLimitExceededError => "Você está realizando esta ação muitas vezes. Espere um minuto e tente de novo.";

	/// <summary>
	/// Key: "Message.FollowerTabTooltip"
	/// English String: "People who have chosen to follow your activity."
	/// </summary>
	public override string MessageFollowerTabTooltip => "Pessoas que estão acompanhando as suas atividades.";

	/// <summary>
	/// Key: "Message.FollowingTabTooltip"
	/// English String: "People whose activity you have chosen to follow."
	/// </summary>
	public override string MessageFollowingTabTooltip => "Pessoas cujas atividades você acompanha.";

	/// <summary>
	/// Key: "Message.ForGeneralError"
	/// English String: "Something went wrong."
	/// </summary>
	public override string MessageForGeneralError => "Algo deu errado.";

	/// <summary>
	/// Key: "Message.ForGeneralFooter"
	/// English String: "Please check back in few minutes."
	/// </summary>
	public override string MessageForGeneralFooter => "Volte para conferir em alguns minutos.";

	/// <summary>
	/// Key: "Message.ForMaxFriendsError"
	/// English String: "Unable to process Request.You currently have the max number of Friends allowed. "
	/// </summary>
	public override string MessageForMaxFriendsError => "Impossível processar o pedido. Você possui o número máximo de amigos permitidos no momento. ";

	/// <summary>
	/// Key: "Message.ForMaxFriendsFooter"
	/// English String: "Unfriend someone before accepting any more Friend Requests."
	/// </summary>
	public override string MessageForMaxFriendsFooter => "Remova um amigo para poder aceitar mais pedidos de amizade.";

	/// <summary>
	/// Key: "Message.ForMaxRequestsError"
	/// English String: "Unable to process Request. That user currently has the max number of Friends allowed."
	/// </summary>
	public override string MessageForMaxRequestsError => "Impossível processar pedido. O usuário possui o número máximo de amigos permitidos no momento.";

	/// <summary>
	/// Key: "Message.ForMaxRequestsFooter"
	/// English String: "You can not accept their Friend Request until they remove a Friend."
	/// </summary>
	public override string MessageForMaxRequestsFooter => "Você não poderá aceitar seu pedido de amizade até que ele(a) remova um amigo.";

	/// <summary>
	/// Key: "Message.FriendRequestNotExistError"
	/// English String: "Friend request does not exist"
	/// </summary>
	public override string MessageFriendRequestNotExistError => "Pedido de amizade inexistente";

	/// <summary>
	/// Key: "Message.FriendsLimitExceededError"
	/// English String: "Friends limit exceeded."
	/// </summary>
	public override string MessageFriendsLimitExceededError => "Limite de amigos excedido.";

	/// <summary>
	/// Key: "Message.FriendsTabTooltip"
	/// English String: "Friends are established when two Roblox users mutually agree to friendship."
	/// </summary>
	public override string MessageFriendsTabTooltip => "Amizades são estabelecidas quando dois usuários Roblox concordam em se adicionar mutuamente.";

	/// <summary>
	/// Key: "Message.NotRecipientError"
	/// English String: "You are not the recipient of this friend request."
	/// </summary>
	public override string MessageNotRecipientError => "Você não é o destinatário deste pedido de amizade.";

	/// <summary>
	/// Key: "Message.OtherUserFriendsLimitExceededError"
	/// English String: "Friends limit exceeded."
	/// </summary>
	public override string MessageOtherUserFriendsLimitExceededError => "Limite de amigos excedido.";

	/// <summary>
	/// Key: "Message.RequestsTabTooltip"
	/// English String: "Friends are established when two Roblox users mutually agree to friendship."
	/// </summary>
	public override string MessageRequestsTabTooltip => "Amizades são estabelecidas quando dois usuários Roblox concordam em se adicionar mutuamente.";

	/// <summary>
	/// Key: "Message.RobloxIsMoreFunWithFriends"
	/// English String: "Roblox is more fun with friends!"
	/// </summary>
	public override string MessageRobloxIsMoreFunWithFriends => "Roblox fica mais divertido com amigos!";

	/// <summary>
	/// Key: "Message.SelfFollowingAttemptError"
	/// English String: "You cannot follow yourself."
	/// </summary>
	public override string MessageSelfFollowingAttemptError => "Você não pode seguir a si mesmo.";

	/// <summary>
	/// Key: "Message.SelfFriendingAttemptError"
	/// English String: "You cannot be friends with yourself."
	/// </summary>
	public override string MessageSelfFriendingAttemptError => "Você não pode ser amigo de si mesmo.";

	/// <summary>
	/// Key: "Message.SystemUnavailableError"
	/// English String: "Friends and Followers system is unavailable."
	/// </summary>
	public override string MessageSystemUnavailableError => "O sistema de amigos e seguidores não está disponível.";

	/// <summary>
	/// Key: "Message.UnblockUserPinLockedError"
	/// English String: "Pin is locked."
	/// </summary>
	public override string MessageUnblockUserPinLockedError => "PIN bloqueado";

	/// <summary>
	/// Key: "Message.UserBlockedError"
	/// English String: "User is blocked"
	/// </summary>
	public override string MessageUserBlockedError => "Usuário bloqueado";

	/// <summary>
	/// Key: "Message.UserHasNotPassedCaptchaError"
	/// English String: "You need to pass Captcha."
	/// </summary>
	public override string MessageUserHasNotPassedCaptchaError => "Você precisa passar por Captcha.";

	/// <summary>
	/// Key: "Message.UsersAreNotInSameGameError"
	/// English String: "Users need to be in the same game."
	/// </summary>
	public override string MessageUsersAreNotInSameGameError => "Os usuários precisam estar no mesmo jogo.";

	public FriendsResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAccept()
	{
		return "Aceitar";
	}

	protected override string _GetTemplateForActionFindFriends()
	{
		return "Encontrar amigos";
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
		return "Ignorar todos";
	}

	protected override string _GetTemplateForActionUnfollow()
	{
		return "Deixar de seguir";
	}

	protected override string _GetTemplateForActionUnfriend()
	{
		return "Remover amigo";
	}

	/// <summary>
	/// Key: "Description.SearchFriends"
	/// When user doesn't have friends, this suggestive text will show up.
	/// English String: "Tap the magnifying glass icon above and search for a user or {startLink}play games{endLink} to meet people."
	/// </summary>
	public override string DescriptionSearchFriends(string startLink, string endLink)
	{
		return $"Toque no ícone da lupa, acima, e procure por um usuário ou {startLink}jogue{endLink} para conhecer pessoas.";
	}

	protected override string _GetTemplateForDescriptionSearchFriends()
	{
		return "Toque no ícone da lupa, acima, e procure por um usuário ou {startLink}jogue{endLink} para conhecer pessoas.";
	}

	protected override string _GetTemplateForHeadingMyFriends()
	{
		return "Meus amigos";
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
		return "Erro";
	}

	protected override string _GetTemplateForLabelFollowers()
	{
		return "Seguidores";
	}

	protected override string _GetTemplateForLabelFollowing()
	{
		return "Seguindo";
	}

	protected override string _GetTemplateForLabelFriendRequests()
	{
		return "Pedidos de amizade";
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
		return $"Você não possui pedidos de amizade pendentes. Para adicionar amigos, dê uma conferida por {startSpan}perto{endSpan}.";
	}

	protected override string _GetTemplateForLabelNearbyUpsell()
	{
		return "Você não possui pedidos de amizade pendentes. Para adicionar amigos, dê uma conferida por {startSpan}perto{endSpan}.";
	}

	protected override string _GetTemplateForLabelOffline()
	{
		return "Offline";
	}

	protected override string _GetTemplateForLabelOk()
	{
		return "Ok";
	}

	protected override string _GetTemplateForLabelOnline()
	{
		return "Online";
	}

	protected override string _GetTemplateForLabelRequests()
	{
		return "Pedidos";
	}

	protected override string _GetTemplateForLabelSearchFriends()
	{
		return "Pesquisar amigos";
	}

	protected override string _GetTemplateForLabelUnfollowed()
	{
		return "Deixou de seguir";
	}

	protected override string _GetTemplateForMessageActionNotAllowedError()
	{
		return "Ação não permitida";
	}

	protected override string _GetTemplateForMessageAlreadyExistsError()
	{
		return "Já existe.";
	}

	protected override string _GetTemplateForMessageCurrentInvalidParametersError()
	{
		return "Parâmetros inválidos.";
	}

	protected override string _GetTemplateForMessageCurrentUserFriendsLimitExceededError()
	{
		return "Você alcançou o número máximo de amigos. Remova um amigo antes de aceitar mais pedidos de amizade.";
	}

	protected override string _GetTemplateForMessageDefaultError()
	{
		return "Ocorreu um erro.";
	}

	protected override string _GetTemplateForMessageFloodLimitExceededError()
	{
		return "Você está realizando esta ação muitas vezes. Espere um minuto e tente de novo.";
	}

	protected override string _GetTemplateForMessageFollowerTabTooltip()
	{
		return "Pessoas que estão acompanhando as suas atividades.";
	}

	protected override string _GetTemplateForMessageFollowingTabTooltip()
	{
		return "Pessoas cujas atividades você acompanha.";
	}

	protected override string _GetTemplateForMessageForGeneralError()
	{
		return "Algo deu errado.";
	}

	protected override string _GetTemplateForMessageForGeneralFooter()
	{
		return "Volte para conferir em alguns minutos.";
	}

	protected override string _GetTemplateForMessageForMaxFriendsError()
	{
		return "Impossível processar o pedido. Você possui o número máximo de amigos permitidos no momento. ";
	}

	protected override string _GetTemplateForMessageForMaxFriendsFooter()
	{
		return "Remova um amigo para poder aceitar mais pedidos de amizade.";
	}

	protected override string _GetTemplateForMessageForMaxRequestsError()
	{
		return "Impossível processar pedido. O usuário possui o número máximo de amigos permitidos no momento.";
	}

	protected override string _GetTemplateForMessageForMaxRequestsFooter()
	{
		return "Você não poderá aceitar seu pedido de amizade até que ele(a) remova um amigo.";
	}

	protected override string _GetTemplateForMessageFriendRequestNotExistError()
	{
		return "Pedido de amizade inexistente";
	}

	protected override string _GetTemplateForMessageFriendsLimitExceededError()
	{
		return "Limite de amigos excedido.";
	}

	protected override string _GetTemplateForMessageFriendsTabTooltip()
	{
		return "Amizades são estabelecidas quando dois usuários Roblox concordam em se adicionar mutuamente.";
	}

	protected override string _GetTemplateForMessageNotRecipientError()
	{
		return "Você não é o destinatário deste pedido de amizade.";
	}

	protected override string _GetTemplateForMessageOtherUserFriendsLimitExceededError()
	{
		return "Limite de amigos excedido.";
	}

	protected override string _GetTemplateForMessageRequestsTabTooltip()
	{
		return "Amizades são estabelecidas quando dois usuários Roblox concordam em se adicionar mutuamente.";
	}

	protected override string _GetTemplateForMessageRobloxIsMoreFunWithFriends()
	{
		return "Roblox fica mais divertido com amigos!";
	}

	protected override string _GetTemplateForMessageSelfFollowingAttemptError()
	{
		return "Você não pode seguir a si mesmo.";
	}

	protected override string _GetTemplateForMessageSelfFriendingAttemptError()
	{
		return "Você não pode ser amigo de si mesmo.";
	}

	protected override string _GetTemplateForMessageSystemUnavailableError()
	{
		return "O sistema de amigos e seguidores não está disponível.";
	}

	protected override string _GetTemplateForMessageUnblockUserPinLockedError()
	{
		return "PIN bloqueado";
	}

	protected override string _GetTemplateForMessageUserBlockedError()
	{
		return "Usuário bloqueado";
	}

	protected override string _GetTemplateForMessageUserHasNotPassedCaptchaError()
	{
		return "Você precisa passar por Captcha.";
	}

	protected override string _GetTemplateForMessageUsersAreNotInSameGameError()
	{
		return "Os usuários precisam estar no mesmo jogo.";
	}
}
