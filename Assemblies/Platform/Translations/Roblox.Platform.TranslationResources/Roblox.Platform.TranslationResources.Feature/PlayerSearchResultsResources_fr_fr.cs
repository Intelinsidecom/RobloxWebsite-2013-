namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides PlayerSearchResultsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PlayerSearchResultsResources_fr_fr : PlayerSearchResultsResources_en_us, IPlayerSearchResultsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AcceptRequest"
	/// English String: "Accept Request"
	/// </summary>
	public override string ActionAcceptRequest => "Accepter la demande";

	/// <summary>
	/// Key: "Action.AddFriend"
	/// English String: "Add Friend"
	/// </summary>
	public override string ActionAddFriend => "Ajouter ami";

	/// <summary>
	/// Key: "Action.Chat"
	/// English String: "Chat"
	/// </summary>
	public override string ActionChat => "Chat";

	/// <summary>
	/// Key: "Action.JoinGame"
	/// English String: "Join Game"
	/// </summary>
	public override string ActionJoinGame => "Rejoindre la partie";

	/// <summary>
	/// Key: "Action.RequestSent"
	/// English String: "Request Sent"
	/// </summary>
	public override string ActionRequestSent => "Demande envoyÃ©e";

	/// <summary>
	/// Key: "Label.AlsoKnownAsAbbreviation"
	/// English String: "aka."
	/// </summary>
	public override string LabelAlsoKnownAsAbbreviation => "alias";

	/// <summary>
	/// Key: "Label.Offline"
	/// English String: "Offline"
	/// </summary>
	public override string LabelOffline => "DÃ©connectÃ©";

	/// <summary>
	/// Key: "Label.Online"
	/// English String: "Online"
	/// </summary>
	public override string LabelOnline => "ConnectÃ©";

	/// <summary>
	/// Key: "Label.Search"
	/// English String: "Search"
	/// </summary>
	public override string LabelSearch => "Rechercher";

	/// <summary>
	/// Key: "Label.ThisIsYou"
	/// English String: "This is you"
	/// </summary>
	public override string LabelThisIsYou => "C'est vous";

	/// <summary>
	/// Key: "Label.UnsafeInput"
	/// English String: "You have entered unsafe input. Please try your search again."
	/// </summary>
	public override string LabelUnsafeInput => "Saisie non conforme au rÃ¨glement. Recommence ta recherche.";

	/// <summary>
	/// Key: "Label.YouAreFollowing"
	/// English String: "You are following"
	/// </summary>
	public override string LabelYouAreFollowing => "Vous suivez";

	/// <summary>
	/// Key: "Label.YouAreFriends"
	/// English String: "You are friends"
	/// </summary>
	public override string LabelYouAreFriends => "Vous Ãªtes amis";

	public PlayerSearchResultsResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAcceptRequest()
	{
		return "Accepter la demande";
	}

	protected override string _GetTemplateForActionAddFriend()
	{
		return "Ajouter ami";
	}

	protected override string _GetTemplateForActionChat()
	{
		return "Chat";
	}

	protected override string _GetTemplateForActionJoinGame()
	{
		return "Rejoindre la partie";
	}

	protected override string _GetTemplateForActionRequestSent()
	{
		return "Demande envoyÃ©e";
	}

	/// <summary>
	/// Key: "Heading.PlayerResultsFor"
	/// English String: "Player Results for {startSpan}{keyword}{endSpan}"
	/// </summary>
	public override string HeadingPlayerResultsFor(string startSpan, string keyword, string endSpan)
	{
		return $"RÃ©sultats de joueurs pour {startSpan}{keyword}{endSpan}";
	}

	protected override string _GetTemplateForHeadingPlayerResultsFor()
	{
		return "RÃ©sultats de joueurs pour {startSpan}{keyword}{endSpan}";
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
		return $"Veuillez saisir au moins {keywordMinLength}\u00a0caractÃ¨res.";
	}

	protected override string _GetTemplateForLabelEnterMinCharacters()
	{
		return "Veuillez saisir au moins {keywordMinLength}\u00a0caractÃ¨res.";
	}

	/// <summary>
	/// Key: "Label.NoMatchesAvailable"
	/// English String: "There are no matches available for \"{keyword}\""
	/// </summary>
	public override string LabelNoMatchesAvailable(string keyword)
	{
		return $"Aucun rÃ©sultat disponible pour Â«\u00a0{keyword}\u00a0Â».";
	}

	protected override string _GetTemplateForLabelNoMatchesAvailable()
	{
		return "Aucun rÃ©sultat disponible pour Â«\u00a0{keyword}\u00a0Â».";
	}

	protected override string _GetTemplateForLabelOffline()
	{
		return "DÃ©connectÃ©";
	}

	protected override string _GetTemplateForLabelOnline()
	{
		return "ConnectÃ©";
	}

	protected override string _GetTemplateForLabelSearch()
	{
		return "Rechercher";
	}

	/// <summary>
	/// Key: "Label.ShowingCountOfResults"
	/// English String: "{countStartSpan}{resultsStart} - {resultsInPage} of {countEndSpan}{totalStartSpan}{totalResults}{totalEndSpan}"
	/// </summary>
	public override string LabelShowingCountOfResults(string countStartSpan, string resultsStart, string resultsInPage, string countEndSpan, string totalStartSpan, string totalResults, string totalEndSpan)
	{
		return $"{countStartSpan}{resultsStart} - {resultsInPage} sur {countEndSpan}{totalStartSpan}{totalResults}{totalEndSpan}";
	}

	protected override string _GetTemplateForLabelShowingCountOfResults()
	{
		return "{countStartSpan}{resultsStart} - {resultsInPage} sur {countEndSpan}{totalStartSpan}{totalResults}{totalEndSpan}";
	}

	protected override string _GetTemplateForLabelThisIsYou()
	{
		return "C'est vous";
	}

	protected override string _GetTemplateForLabelUnsafeInput()
	{
		return "Saisie non conforme au rÃ¨glement. Recommence ta recherche.";
	}

	protected override string _GetTemplateForLabelYouAreFollowing()
	{
		return "Vous suivez";
	}

	protected override string _GetTemplateForLabelYouAreFriends()
	{
		return "Vous Ãªtes amis";
	}
}


}
