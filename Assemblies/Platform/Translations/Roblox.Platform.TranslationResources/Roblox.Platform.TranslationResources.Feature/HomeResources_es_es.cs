namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides HomeResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class HomeResources_es_es : HomeResources_en_us, IHomeResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.BackToTop"
	/// English String: "Back To Top"
	/// </summary>
	public override string ActionBackToTop => "Volver arriba";

	/// <summary>
	/// Key: "ActionLearnMore"
	/// English String: "Learn More"
	/// </summary>
	public override string ActionLearnMore => "Más información";

	/// <summary>
	/// Key: "ActionSeeAll"
	/// English String: "See All"
	/// </summary>
	public override string ActionSeeAll => "Ver todo";

	/// <summary>
	/// Key: "ActionSeeMore"
	/// English String: "See More"
	/// </summary>
	public override string ActionSeeMore => "Ver más";

	/// <summary>
	/// Key: "ActionShare"
	/// English String: "Share"
	/// </summary>
	public override string ActionShare => "Compartir";

	/// <summary>
	/// Key: "ActionWhatAreYouUpto"
	/// English String: "What are you up to?"
	/// </summary>
	public override string ActionWhatAreYouUpto => "¿Qué cuentas?";

	/// <summary>
	/// Key: "HeadingBlogNews"
	/// English String: "Blog News"
	/// </summary>
	public override string HeadingBlogNews => "Noticias del blog";

	/// <summary>
	/// Key: "HeadingDeveloperExchange"
	/// English String: "Developer Exchange"
	/// </summary>
	public override string HeadingDeveloperExchange => "Cambio para desarrolladores";

	/// <summary>
	/// Key: "HeadingFriendActivity"
	/// English String: "Friend Activity"
	/// </summary>
	public override string HeadingFriendActivity => "Actividad de tus amigos";

	/// <summary>
	/// Key: "HeadingFriendsTitle"
	/// English String: "Friends"
	/// </summary>
	public override string HeadingFriendsTitle => "Amigos";

	/// <summary>
	/// Key: "HeadingMyFavorites"
	/// English String: "My Favorites"
	/// </summary>
	public override string HeadingMyFavorites => "Mis favoritos";

	/// <summary>
	/// Key: "HeadingMyFeed"
	/// English String: "My Feed"
	/// </summary>
	public override string HeadingMyFeed => "Mis noticias";

	/// <summary>
	/// Key: "HeadingRecentlyPlayed"
	/// English String: "Recently Played"
	/// </summary>
	public override string HeadingRecentlyPlayed => "Jugados recientemente";

	/// <summary>
	/// Key: "Label.FindMyFeed"
	/// English String: "Looking for My Feed? It's now on the side menu"
	/// </summary>
	public override string LabelFindMyFeed => "¿Estás buscando Mis noticias? Ahora las encontrarás en el menú lateral.";

	/// <summary>
	/// Key: "LabelAnnouncement"
	/// English String: "Announcement"
	/// </summary>
	public override string LabelAnnouncement => "Anuncio";

	/// <summary>
	/// Key: "LabelCreateEarn"
	/// English String: "Create games, earn money"
	/// </summary>
	public override string LabelCreateEarn => "Crea juegos, gana dinero";

	/// <summary>
	/// Key: "LabelSharing"
	/// English String: "Sharing..."
	/// </summary>
	public override string LabelSharing => "Compartiendo...";

	/// <summary>
	/// Key: "LabelStatusUpdateFailed"
	/// English String: "Status update failed."
	/// </summary>
	public override string LabelStatusUpdateFailed => "Ha fallado la actualización de estado.";

	/// <summary>
	/// Key: "ResponseErrorNoBlank"
	/// English String: "Update cannot be blank. Please try again."
	/// </summary>
	public override string ResponseErrorNoBlank => "La actualización no puede estar vacía. Inténtalo de nuevo.";

	/// <summary>
	/// Key: "ResponseErrorNoLogin"
	/// English String: "Please log into your account."
	/// </summary>
	public override string ResponseErrorNoLogin => "Inicia sesión en tu cuenta.";

	/// <summary>
	/// Key: "ResponseErrorOther"
	/// English String: "System issue. Please try again later, then contact Support."
	/// </summary>
	public override string ResponseErrorOther => "Problema con el sistema. Inténtalo de nuevo más tarde y, después, ponte en contacto con asistencia técnica.";

	/// <summary>
	/// Key: "ResponseErrorTooManyUpdates"
	/// English String: "Too many updates. Please try again later."
	/// </summary>
	public override string ResponseErrorTooManyUpdates => "Demasiadas actualizaciones. Inténtalo de nuevo más tarde.";

	public HomeResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBackToTop()
	{
		return "Volver arriba";
	}

	protected override string _GetTemplateForActionLearnMore()
	{
		return "Más información";
	}

	protected override string _GetTemplateForActionSeeAll()
	{
		return "Ver todo";
	}

	protected override string _GetTemplateForActionSeeMore()
	{
		return "Ver más";
	}

	protected override string _GetTemplateForActionShare()
	{
		return "Compartir";
	}

	protected override string _GetTemplateForActionWhatAreYouUpto()
	{
		return "¿Qué cuentas?";
	}

	protected override string _GetTemplateForHeadingBlogNews()
	{
		return "Noticias del blog";
	}

	protected override string _GetTemplateForHeadingDeveloperExchange()
	{
		return "Cambio para desarrolladores";
	}

	protected override string _GetTemplateForHeadingFriendActivity()
	{
		return "Actividad de tus amigos";
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
		return "Mis favoritos";
	}

	protected override string _GetTemplateForHeadingMyFeed()
	{
		return "Mis noticias";
	}

	protected override string _GetTemplateForHeadingRecentlyPlayed()
	{
		return "Jugados recientemente";
	}

	protected override string _GetTemplateForLabelFindMyFeed()
	{
		return "¿Estás buscando Mis noticias? Ahora las encontrarás en el menú lateral.";
	}

	protected override string _GetTemplateForLabelAnnouncement()
	{
		return "Anuncio";
	}

	protected override string _GetTemplateForLabelCreateEarn()
	{
		return "Crea juegos, gana dinero";
	}

	/// <summary>
	/// Key: "LabelGreeting"
	/// English String: "Hello, {username}!"
	/// </summary>
	public override string LabelGreeting(string username)
	{
		return $"¡Hola, {username}!";
	}

	protected override string _GetTemplateForLabelGreeting()
	{
		return "¡Hola, {username}!";
	}

	protected override string _GetTemplateForLabelSharing()
	{
		return "Compartiendo...";
	}

	protected override string _GetTemplateForLabelStatusUpdateFailed()
	{
		return "Ha fallado la actualización de estado.";
	}

	protected override string _GetTemplateForResponseErrorNoBlank()
	{
		return "La actualización no puede estar vacía. Inténtalo de nuevo.";
	}

	protected override string _GetTemplateForResponseErrorNoLogin()
	{
		return "Inicia sesión en tu cuenta.";
	}

	protected override string _GetTemplateForResponseErrorOther()
	{
		return "Problema con el sistema. Inténtalo de nuevo más tarde y, después, ponte en contacto con asistencia técnica.";
	}

	protected override string _GetTemplateForResponseErrorTooManyUpdates()
	{
		return "Demasiadas actualizaciones. Inténtalo de nuevo más tarde.";
	}
}
