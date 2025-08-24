namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PlayerSearchResultsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PlayerSearchResultsResources_pt_br : PlayerSearchResultsResources_en_us, IPlayerSearchResultsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AcceptRequest"
	/// English String: "Accept Request"
	/// </summary>
	public override string ActionAcceptRequest => "Aceitar pedido";

	/// <summary>
	/// Key: "Action.AddFriend"
	/// English String: "Add Friend"
	/// </summary>
	public override string ActionAddFriend => "Adicionar amigo";

	/// <summary>
	/// Key: "Action.Chat"
	/// English String: "Chat"
	/// </summary>
	public override string ActionChat => "Chat";

	/// <summary>
	/// Key: "Action.JoinGame"
	/// English String: "Join Game"
	/// </summary>
	public override string ActionJoinGame => "Entrar no jogo";

	/// <summary>
	/// Key: "Action.RequestSent"
	/// English String: "Request Sent"
	/// </summary>
	public override string ActionRequestSent => "Pedido enviado";

	/// <summary>
	/// Key: "Label.AlsoKnownAsAbbreviation"
	/// English String: "aka."
	/// </summary>
	public override string LabelAlsoKnownAsAbbreviation => "também conhecido como";

	/// <summary>
	/// Key: "Label.Offline"
	/// English String: "Offline"
	/// </summary>
	public override string LabelOffline => "Offline";

	/// <summary>
	/// Key: "Label.Online"
	/// English String: "Online"
	/// </summary>
	public override string LabelOnline => "Online";

	/// <summary>
	/// Key: "Label.Search"
	/// English String: "Search"
	/// </summary>
	public override string LabelSearch => "Pesquisar";

	/// <summary>
	/// Key: "Label.ThisIsYou"
	/// English String: "This is you"
	/// </summary>
	public override string LabelThisIsYou => "Este é você";

	/// <summary>
	/// Key: "Label.UnsafeInput"
	/// English String: "You have entered unsafe input. Please try your search again."
	/// </summary>
	public override string LabelUnsafeInput => "Você inseriu dados não seguros. Tente pesquisar de novo.";

	/// <summary>
	/// Key: "Label.YouAreFollowing"
	/// English String: "You are following"
	/// </summary>
	public override string LabelYouAreFollowing => "Você está seguindo";

	/// <summary>
	/// Key: "Label.YouAreFriends"
	/// English String: "You are friends"
	/// </summary>
	public override string LabelYouAreFriends => "Vocês são amigos";

	public PlayerSearchResultsResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAcceptRequest()
	{
		return "Aceitar pedido";
	}

	protected override string _GetTemplateForActionAddFriend()
	{
		return "Adicionar amigo";
	}

	protected override string _GetTemplateForActionChat()
	{
		return "Chat";
	}

	protected override string _GetTemplateForActionJoinGame()
	{
		return "Entrar no jogo";
	}

	protected override string _GetTemplateForActionRequestSent()
	{
		return "Pedido enviado";
	}

	/// <summary>
	/// Key: "Heading.PlayerResultsFor"
	/// English String: "Player Results for {startSpan}{keyword}{endSpan}"
	/// </summary>
	public override string HeadingPlayerResultsFor(string startSpan, string keyword, string endSpan)
	{
		return $"Resultados de jogador para {startSpan}{keyword}{endSpan}";
	}

	protected override string _GetTemplateForHeadingPlayerResultsFor()
	{
		return "Resultados de jogador para {startSpan}{keyword}{endSpan}";
	}

	protected override string _GetTemplateForLabelAlsoKnownAsAbbreviation()
	{
		return "também conhecido como";
	}

	/// <summary>
	/// Key: "Label.EnterMinCharacters"
	/// English String: "Please enter at least {keywordMinLength} characters."
	/// </summary>
	public override string LabelEnterMinCharacters(string keywordMinLength)
	{
		return $"Insira pelo menos {keywordMinLength} caracteres.";
	}

	protected override string _GetTemplateForLabelEnterMinCharacters()
	{
		return "Insira pelo menos {keywordMinLength} caracteres.";
	}

	/// <summary>
	/// Key: "Label.NoMatchesAvailable"
	/// English String: "There are no matches available for \"{keyword}\""
	/// </summary>
	public override string LabelNoMatchesAvailable(string keyword)
	{
		return $"Nenhuma partida disponível para \"{keyword}\"";
	}

	protected override string _GetTemplateForLabelNoMatchesAvailable()
	{
		return "Nenhuma partida disponível para \"{keyword}\"";
	}

	protected override string _GetTemplateForLabelOffline()
	{
		return "Offline";
	}

	protected override string _GetTemplateForLabelOnline()
	{
		return "Online";
	}

	protected override string _GetTemplateForLabelSearch()
	{
		return "Pesquisar";
	}

	/// <summary>
	/// Key: "Label.ShowingCountOfResults"
	/// English String: "{countStartSpan}{resultsStart} - {resultsInPage} of {countEndSpan}{totalStartSpan}{totalResults}{totalEndSpan}"
	/// </summary>
	public override string LabelShowingCountOfResults(string countStartSpan, string resultsStart, string resultsInPage, string countEndSpan, string totalStartSpan, string totalResults, string totalEndSpan)
	{
		return $"{countStartSpan}{resultsStart} - {resultsInPage} de {countEndSpan}{totalStartSpan}{totalResults}{totalEndSpan}";
	}

	protected override string _GetTemplateForLabelShowingCountOfResults()
	{
		return "{countStartSpan}{resultsStart} - {resultsInPage} de {countEndSpan}{totalStartSpan}{totalResults}{totalEndSpan}";
	}

	protected override string _GetTemplateForLabelThisIsYou()
	{
		return "Este é você";
	}

	protected override string _GetTemplateForLabelUnsafeInput()
	{
		return "Você inseriu dados não seguros. Tente pesquisar de novo.";
	}

	protected override string _GetTemplateForLabelYouAreFollowing()
	{
		return "Você está seguindo";
	}

	protected override string _GetTemplateForLabelYouAreFriends()
	{
		return "Vocês são amigos";
	}
}
