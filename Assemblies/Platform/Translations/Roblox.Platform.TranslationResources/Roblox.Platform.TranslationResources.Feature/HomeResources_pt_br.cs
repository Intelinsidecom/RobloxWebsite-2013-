namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides HomeResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class HomeResources_pt_br : HomeResources_en_us, IHomeResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.BackToTop"
	/// English String: "Back To Top"
	/// </summary>
	public override string ActionBackToTop => "Voltar para o topo";

	/// <summary>
	/// Key: "ActionLearnMore"
	/// English String: "Learn More"
	/// </summary>
	public override string ActionLearnMore => "Saiba mais";

	/// <summary>
	/// Key: "ActionSeeAll"
	/// English String: "See All"
	/// </summary>
	public override string ActionSeeAll => "Ver todos";

	/// <summary>
	/// Key: "ActionSeeMore"
	/// English String: "See More"
	/// </summary>
	public override string ActionSeeMore => "Ver mais";

	/// <summary>
	/// Key: "ActionShare"
	/// English String: "Share"
	/// </summary>
	public override string ActionShare => "Compartilhar";

	/// <summary>
	/// Key: "ActionWhatAreYouUpto"
	/// English String: "What are you up to?"
	/// </summary>
	public override string ActionWhatAreYouUpto => "O que você está fazendo?";

	/// <summary>
	/// Key: "HeadingBlogNews"
	/// English String: "Blog News"
	/// </summary>
	public override string HeadingBlogNews => "Novidades do blog";

	/// <summary>
	/// Key: "HeadingDeveloperExchange"
	/// English String: "Developer Exchange"
	/// </summary>
	public override string HeadingDeveloperExchange => "Central do desenvolvedor";

	/// <summary>
	/// Key: "HeadingFriendActivity"
	/// English String: "Friend Activity"
	/// </summary>
	public override string HeadingFriendActivity => "Atividade de amigo";

	/// <summary>
	/// Key: "HeadingFriendsTitle"
	/// English String: "Friends"
	/// </summary>
	public override string HeadingFriendsTitle => "Amigos";

	/// <summary>
	/// Key: "HeadingMyFavorites"
	/// English String: "My Favorites"
	/// </summary>
	public override string HeadingMyFavorites => "Favoritos";

	/// <summary>
	/// Key: "HeadingMyFeed"
	/// English String: "My Feed"
	/// </summary>
	public override string HeadingMyFeed => "Meu feed";

	/// <summary>
	/// Key: "HeadingRecentlyPlayed"
	/// English String: "Recently Played"
	/// </summary>
	public override string HeadingRecentlyPlayed => "Jogados recentemente";

	/// <summary>
	/// Key: "Label.FindMyFeed"
	/// English String: "Looking for My Feed? It's now on the side menu"
	/// </summary>
	public override string LabelFindMyFeed => "Procurando Meu Feed? Confira o menu lateral";

	/// <summary>
	/// Key: "LabelAnnouncement"
	/// English String: "Announcement"
	/// </summary>
	public override string LabelAnnouncement => "Anúncio";

	/// <summary>
	/// Key: "LabelCreateEarn"
	/// English String: "Create games, earn money"
	/// </summary>
	public override string LabelCreateEarn => "Crie jogos, ganhe dinheiro";

	/// <summary>
	/// Key: "LabelSharing"
	/// English String: "Sharing..."
	/// </summary>
	public override string LabelSharing => "Compartilhando...";

	/// <summary>
	/// Key: "LabelStatusUpdateFailed"
	/// English String: "Status update failed."
	/// </summary>
	public override string LabelStatusUpdateFailed => "Falha na atualização do status.";

	/// <summary>
	/// Key: "ResponseErrorNoBlank"
	/// English String: "Update cannot be blank. Please try again."
	/// </summary>
	public override string ResponseErrorNoBlank => "Atualização não pode ficar em branco. Tente novamente.";

	/// <summary>
	/// Key: "ResponseErrorNoLogin"
	/// English String: "Please log into your account."
	/// </summary>
	public override string ResponseErrorNoLogin => "Conecte-se à sua conta.";

	/// <summary>
	/// Key: "ResponseErrorOther"
	/// English String: "System issue. Please try again later, then contact Support."
	/// </summary>
	public override string ResponseErrorOther => "Problema de sistema. Tente novamente mais tarde e depois contate o Suporte.";

	/// <summary>
	/// Key: "ResponseErrorTooManyUpdates"
	/// English String: "Too many updates. Please try again later."
	/// </summary>
	public override string ResponseErrorTooManyUpdates => "Atualizações excessivas. Tente de novo mais tarde.";

	public HomeResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBackToTop()
	{
		return "Voltar para o topo";
	}

	protected override string _GetTemplateForActionLearnMore()
	{
		return "Saiba mais";
	}

	protected override string _GetTemplateForActionSeeAll()
	{
		return "Ver todos";
	}

	protected override string _GetTemplateForActionSeeMore()
	{
		return "Ver mais";
	}

	protected override string _GetTemplateForActionShare()
	{
		return "Compartilhar";
	}

	protected override string _GetTemplateForActionWhatAreYouUpto()
	{
		return "O que você está fazendo?";
	}

	protected override string _GetTemplateForHeadingBlogNews()
	{
		return "Novidades do blog";
	}

	protected override string _GetTemplateForHeadingDeveloperExchange()
	{
		return "Central do desenvolvedor";
	}

	protected override string _GetTemplateForHeadingFriendActivity()
	{
		return "Atividade de amigo";
	}

	/// <summary>
	/// Key: "HeadingFriends"
	/// English String: "Friends ({friendCount})"
	/// </summary>
	public override string HeadingFriends(string friendCount)
	{
		return $"Amigos ({friendCount})";
	}

	protected override string _GetTemplateForHeadingFriends()
	{
		return "Amigos ({friendCount})";
	}

	protected override string _GetTemplateForHeadingFriendsTitle()
	{
		return "Amigos";
	}

	protected override string _GetTemplateForHeadingMyFavorites()
	{
		return "Favoritos";
	}

	protected override string _GetTemplateForHeadingMyFeed()
	{
		return "Meu feed";
	}

	protected override string _GetTemplateForHeadingRecentlyPlayed()
	{
		return "Jogados recentemente";
	}

	protected override string _GetTemplateForLabelFindMyFeed()
	{
		return "Procurando Meu Feed? Confira o menu lateral";
	}

	protected override string _GetTemplateForLabelAnnouncement()
	{
		return "Anúncio";
	}

	protected override string _GetTemplateForLabelCreateEarn()
	{
		return "Crie jogos, ganhe dinheiro";
	}

	/// <summary>
	/// Key: "LabelGreeting"
	/// English String: "Hello, {username}!"
	/// </summary>
	public override string LabelGreeting(string username)
	{
		return $"Olá, {username}!";
	}

	protected override string _GetTemplateForLabelGreeting()
	{
		return "Olá, {username}!";
	}

	protected override string _GetTemplateForLabelSharing()
	{
		return "Compartilhando...";
	}

	protected override string _GetTemplateForLabelStatusUpdateFailed()
	{
		return "Falha na atualização do status.";
	}

	protected override string _GetTemplateForResponseErrorNoBlank()
	{
		return "Atualização não pode ficar em branco. Tente novamente.";
	}

	protected override string _GetTemplateForResponseErrorNoLogin()
	{
		return "Conecte-se à sua conta.";
	}

	protected override string _GetTemplateForResponseErrorOther()
	{
		return "Problema de sistema. Tente novamente mais tarde e depois contate o Suporte.";
	}

	protected override string _GetTemplateForResponseErrorTooManyUpdates()
	{
		return "Atualizações excessivas. Tente de novo mais tarde.";
	}
}
