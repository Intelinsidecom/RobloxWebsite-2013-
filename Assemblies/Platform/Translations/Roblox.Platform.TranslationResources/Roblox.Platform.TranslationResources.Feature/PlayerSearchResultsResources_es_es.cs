namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PlayerSearchResultsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PlayerSearchResultsResources_es_es : PlayerSearchResultsResources_en_us, IPlayerSearchResultsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AcceptRequest"
	/// English String: "Accept Request"
	/// </summary>
	public override string ActionAcceptRequest => "Aceptar solicitud";

	/// <summary>
	/// Key: "Action.AddFriend"
	/// English String: "Add Friend"
	/// </summary>
	public override string ActionAddFriend => "Añadir amigo";

	/// <summary>
	/// Key: "Action.Chat"
	/// English String: "Chat"
	/// </summary>
	public override string ActionChat => "Chat";

	/// <summary>
	/// Key: "Action.JoinGame"
	/// English String: "Join Game"
	/// </summary>
	public override string ActionJoinGame => "Unirse al juego";

	/// <summary>
	/// Key: "Action.RequestSent"
	/// English String: "Request Sent"
	/// </summary>
	public override string ActionRequestSent => "Solicitud enviada";

	/// <summary>
	/// Key: "Label.AlsoKnownAsAbbreviation"
	/// English String: "aka."
	/// </summary>
	public override string LabelAlsoKnownAsAbbreviation => "alias";

	/// <summary>
	/// Key: "Label.Offline"
	/// English String: "Offline"
	/// </summary>
	public override string LabelOffline => "Sin conexión";

	/// <summary>
	/// Key: "Label.Online"
	/// English String: "Online"
	/// </summary>
	public override string LabelOnline => "En línea";

	/// <summary>
	/// Key: "Label.Search"
	/// English String: "Search"
	/// </summary>
	public override string LabelSearch => "Buscar";

	/// <summary>
	/// Key: "Label.ThisIsYou"
	/// English String: "This is you"
	/// </summary>
	public override string LabelThisIsYou => "Este eres tú";

	/// <summary>
	/// Key: "Label.UnsafeInput"
	/// English String: "You have entered unsafe input. Please try your search again."
	/// </summary>
	public override string LabelUnsafeInput => "Has introducido una cadena no segura. Intenta hacer otra búsqueda.";

	/// <summary>
	/// Key: "Label.YouAreFollowing"
	/// English String: "You are following"
	/// </summary>
	public override string LabelYouAreFollowing => "Lo sigues";

	/// <summary>
	/// Key: "Label.YouAreFriends"
	/// English String: "You are friends"
	/// </summary>
	public override string LabelYouAreFriends => "Sois amigos";

	public PlayerSearchResultsResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAcceptRequest()
	{
		return "Aceptar solicitud";
	}

	protected override string _GetTemplateForActionAddFriend()
	{
		return "Añadir amigo";
	}

	protected override string _GetTemplateForActionChat()
	{
		return "Chat";
	}

	protected override string _GetTemplateForActionJoinGame()
	{
		return "Unirse al juego";
	}

	protected override string _GetTemplateForActionRequestSent()
	{
		return "Solicitud enviada";
	}

	/// <summary>
	/// Key: "Heading.PlayerResultsFor"
	/// English String: "Player Results for {startSpan}{keyword}{endSpan}"
	/// </summary>
	public override string HeadingPlayerResultsFor(string startSpan, string keyword, string endSpan)
	{
		return $"Resultados de jugadores para {startSpan}{keyword}{endSpan}";
	}

	protected override string _GetTemplateForHeadingPlayerResultsFor()
	{
		return "Resultados de jugadores para {startSpan}{keyword}{endSpan}";
	}

	protected override string _GetTemplateForLabelAlsoKnownAsAbbreviation()
	{
		return "alias";
	}

	/// <summary>
	/// Key: "Label.EnterMinCharacters"
	/// English String: "Please enter at least {keywordMinLength} characters."
	/// </summary>
	public override string LabelEnterMinCharacters(string keywordMinLength)
	{
		return $"Introduce al menos {keywordMinLength} caracteres.";
	}

	protected override string _GetTemplateForLabelEnterMinCharacters()
	{
		return "Introduce al menos {keywordMinLength} caracteres.";
	}

	/// <summary>
	/// Key: "Label.NoMatchesAvailable"
	/// English String: "There are no matches available for \"{keyword}\""
	/// </summary>
	public override string LabelNoMatchesAvailable(string keyword)
	{
		return $"No hay resultados disponibles para «{keyword}».";
	}

	protected override string _GetTemplateForLabelNoMatchesAvailable()
	{
		return "No hay resultados disponibles para «{keyword}».";
	}

	protected override string _GetTemplateForLabelOffline()
	{
		return "Sin conexión";
	}

	protected override string _GetTemplateForLabelOnline()
	{
		return "En línea";
	}

	protected override string _GetTemplateForLabelSearch()
	{
		return "Buscar";
	}

	/// <summary>
	/// Key: "Label.ShowingCountOfResults"
	/// English String: "{countStartSpan}{resultsStart} - {resultsInPage} of {countEndSpan}{totalStartSpan}{totalResults}{totalEndSpan}"
	/// </summary>
	public override string LabelShowingCountOfResults(string countStartSpan, string resultsStart, string resultsInPage, string countEndSpan, string totalStartSpan, string totalResults, string totalEndSpan)
	{
		return $"{countStartSpan}{resultsStart}: {resultsInPage} de {countEndSpan}{totalStartSpan}{totalResults}{totalEndSpan}";
	}

	protected override string _GetTemplateForLabelShowingCountOfResults()
	{
		return "{countStartSpan}{resultsStart}: {resultsInPage} de {countEndSpan}{totalStartSpan}{totalResults}{totalEndSpan}";
	}

	protected override string _GetTemplateForLabelThisIsYou()
	{
		return "Este eres tú";
	}

	protected override string _GetTemplateForLabelUnsafeInput()
	{
		return "Has introducido una cadena no segura. Intenta hacer otra búsqueda.";
	}

	protected override string _GetTemplateForLabelYouAreFollowing()
	{
		return "Lo sigues";
	}

	protected override string _GetTemplateForLabelYouAreFriends()
	{
		return "Sois amigos";
	}
}
