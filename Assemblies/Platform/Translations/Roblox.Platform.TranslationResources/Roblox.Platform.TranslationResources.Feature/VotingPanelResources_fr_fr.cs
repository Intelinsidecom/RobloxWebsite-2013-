namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides VotingPanelResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class VotingPanelResources_fr_fr : VotingPanelResources_en_us, IVotingPanelResources, ITranslationResources
{
	/// <summary>
	/// Key: "Label.Accept"
	/// English String: "Verify"
	/// </summary>
	public override string LabelAccept => "VÃ©rifier";

	/// <summary>
	/// Key: "Label.AccountPageTitle"
	/// English String: "Account"
	/// </summary>
	public override string LabelAccountPageTitle => "Compte";

	/// <summary>
	/// Key: "Label.AccountUnderDayOneMessage"
	/// English String: "You will be able to vote on Games and Studio Models later, after you've had a chance to experience Roblox a bit more. Come back to this page in a couple days."
	/// </summary>
	public override string LabelAccountUnderDayOneMessage => "Vous aurez l'occasion de donner un vote aux jeux et aux modÃ¨les Studio plus tard, une fois que vous aurez passÃ© un peu plus de temps dans Roblox. Consultez de nouveau cette page dans quelques jours.";

	/// <summary>
	/// Key: "Label.AccountUnderDayOneTitle"
	/// English String: "Voter Feedback"
	/// </summary>
	public override string LabelAccountUnderDayOneTitle => "Commentaire du votant";

	/// <summary>
	/// Key: "Label.AssetNotVoteableMessage"
	/// English String: "This asset may not be voted on at this time."
	/// </summary>
	public override string LabelAssetNotVoteableMessage => "Cet Ã©lÃ©ment n'accepte pas les votes pour le moment.";

	/// <summary>
	/// Key: "Label.AssetNotVoteableTitle"
	/// English String: "Unable to Vote"
	/// </summary>
	public override string LabelAssetNotVoteableTitle => "Impossible de voter";

	/// <summary>
	/// Key: "Label.BuyGamePassMessage"
	/// English String: "You must own this game pass before you can vote on it."
	/// </summary>
	public override string LabelBuyGamePassMessage => "Vous devez possÃ©der ce passe de jeu avant de pouvoir voter.";

	/// <summary>
	/// Key: "Label.BuyGamePassTitle"
	/// English String: "Buy Game Pass"
	/// </summary>
	public override string LabelBuyGamePassTitle => "Acheter le passe de jeu";

	/// <summary>
	/// Key: "Label.Decline"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelDecline => "Annuler";

	/// <summary>
	/// Key: "Label.EmailVerifiedTitle"
	/// English String: "Verify Your Email"
	/// </summary>
	public override string LabelEmailVerifiedTitle => "VÃ©rifie ton adresse e-mail";

	/// <summary>
	/// Key: "Label.FloodCheckMessage"
	/// English String: "You're voting too quickly. Come back later and try again."
	/// </summary>
	public override string LabelFloodCheckMessage => "Vous votez trop rapidement. Revenez plus tard et rÃ©essayez.";

	/// <summary>
	/// Key: "Label.FloodCheckTitle"
	/// English String: "Slow Down"
	/// </summary>
	public override string LabelFloodCheckTitle => "Moins vite";

	/// <summary>
	/// Key: "Label.GuestUserTitle"
	/// English String: "Login to Vote"
	/// </summary>
	public override string LabelGuestUserTitle => "Connexion requise pour voter";

	/// <summary>
	/// Key: "Label.InstallPluginMessage"
	/// English String: "You must install this plugin before you can vote on it."
	/// </summary>
	public override string LabelInstallPluginMessage => "Vous devez installer ce plugin avant de pouvoir voter.";

	/// <summary>
	/// Key: "Label.InstallPluginTitle"
	/// English String: "Install Plugin"
	/// </summary>
	public override string LabelInstallPluginTitle => "Installer le plugin";

	/// <summary>
	/// Key: "Label.Login"
	/// English String: "Login"
	/// </summary>
	public override string LabelLogin => "Connexion";

	/// <summary>
	/// Key: "Label.LoginOrRegisterPageTitle"
	/// English String: "login or register"
	/// </summary>
	public override string LabelLoginOrRegisterPageTitle => "vous connecter ou vous inscrire";

	/// <summary>
	/// Key: "Label.Ok"
	/// English String: "OK"
	/// </summary>
	public override string LabelOk => "OK";

	/// <summary>
	/// Key: "Label.PlayGameMessage"
	/// English String: "You must play the game before you can vote on it."
	/// </summary>
	public override string LabelPlayGameMessage => "Vous devez jouer Ã  ce jeu avant de pouvoir voter.";

	/// <summary>
	/// Key: "Label.PlayGameTitle"
	/// English String: "Play Game"
	/// </summary>
	public override string LabelPlayGameTitle => "Jouer";

	/// <summary>
	/// Key: "Label.UnknownProblemMessage"
	/// English String: "There was an unknown problem voting. Please try again."
	/// </summary>
	public override string LabelUnknownProblemMessage => "Un problÃ¨me inconnu est survenu lors du vote. Veuillez rÃ©essayer.";

	/// <summary>
	/// Key: "Label.UnknownProblemTitle"
	/// English String: "Something Broke"
	/// </summary>
	public override string LabelUnknownProblemTitle => "Une erreur s'est produite";

	/// <summary>
	/// Key: "Label.UseModelMessage"
	/// English String: "You must use this model before you can vote on it."
	/// </summary>
	public override string LabelUseModelMessage => "Vous devez utiliser ce modÃ¨le avant de pouvoir voter.";

	/// <summary>
	/// Key: "Label.UseModelTitle"
	/// English String: "Use Model"
	/// </summary>
	public override string LabelUseModelTitle => "Utiliser le modÃ¨le";

	/// <summary>
	/// Key: "Label.YouMustLoginToVote"
	/// English String: "You must login to vote."
	/// </summary>
	public override string LabelYouMustLoginToVote => "Vous devez vous connecter afin de pouvoir voter.";

	public VotingPanelResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelAccept()
	{
		return "VÃ©rifier";
	}

	protected override string _GetTemplateForLabelAccountPageTitle()
	{
		return "Compte";
	}

	protected override string _GetTemplateForLabelAccountUnderDayOneMessage()
	{
		return "Vous aurez l'occasion de donner un vote aux jeux et aux modÃ¨les Studio plus tard, une fois que vous aurez passÃ© un peu plus de temps dans Roblox. Consultez de nouveau cette page dans quelques jours.";
	}

	protected override string _GetTemplateForLabelAccountUnderDayOneTitle()
	{
		return "Commentaire du votant";
	}

	protected override string _GetTemplateForLabelAssetNotVoteableMessage()
	{
		return "Cet Ã©lÃ©ment n'accepte pas les votes pour le moment.";
	}

	protected override string _GetTemplateForLabelAssetNotVoteableTitle()
	{
		return "Impossible de voter";
	}

	protected override string _GetTemplateForLabelBuyGamePassMessage()
	{
		return "Vous devez possÃ©der ce passe de jeu avant de pouvoir voter.";
	}

	protected override string _GetTemplateForLabelBuyGamePassTitle()
	{
		return "Acheter le passe de jeu";
	}

	protected override string _GetTemplateForLabelDecline()
	{
		return "Annuler";
	}

	/// <summary>
	/// Key: "Label.EmailVerifiedMessage"
	/// English String: "You must verify your email before you can vote. You can verify your email on the {accountPageLink} page."
	/// </summary>
	public override string LabelEmailVerifiedMessage(string accountPageLink)
	{
		return $"Tu dois vÃ©rifier ton adresse e-mail avant de pouvoir voter. Pour ce faire, rendez-vous sur la page\u00a0: {accountPageLink}.";
	}

	protected override string _GetTemplateForLabelEmailVerifiedMessage()
	{
		return "Tu dois vÃ©rifier ton adresse e-mail avant de pouvoir voter. Pour ce faire, rendez-vous sur la page\u00a0: {accountPageLink}.";
	}

	protected override string _GetTemplateForLabelEmailVerifiedTitle()
	{
		return "VÃ©rifie ton adresse e-mail";
	}

	protected override string _GetTemplateForLabelFloodCheckMessage()
	{
		return "Vous votez trop rapidement. Revenez plus tard et rÃ©essayez.";
	}

	protected override string _GetTemplateForLabelFloodCheckTitle()
	{
		return "Moins vite";
	}

	/// <summary>
	/// Key: "Label.GuestUserMessage"
	/// English String: "Please {loginOrRegisterPageLink} to continue."
	/// </summary>
	public override string LabelGuestUserMessage(string loginOrRegisterPageLink)
	{
		return $"Veuillez {loginOrRegisterPageLink} pour continuer.";
	}

	protected override string _GetTemplateForLabelGuestUserMessage()
	{
		return "Veuillez {loginOrRegisterPageLink} pour continuer.";
	}

	protected override string _GetTemplateForLabelGuestUserTitle()
	{
		return "Connexion requise pour voter";
	}

	protected override string _GetTemplateForLabelInstallPluginMessage()
	{
		return "Vous devez installer ce plugin avant de pouvoir voter.";
	}

	protected override string _GetTemplateForLabelInstallPluginTitle()
	{
		return "Installer le plugin";
	}

	protected override string _GetTemplateForLabelLogin()
	{
		return "Connexion";
	}

	protected override string _GetTemplateForLabelLoginOrRegisterPageTitle()
	{
		return "vous connecter ou vous inscrire";
	}

	protected override string _GetTemplateForLabelOk()
	{
		return "OK";
	}

	protected override string _GetTemplateForLabelPlayGameMessage()
	{
		return "Vous devez jouer Ã  ce jeu avant de pouvoir voter.";
	}

	protected override string _GetTemplateForLabelPlayGameTitle()
	{
		return "Jouer";
	}

	protected override string _GetTemplateForLabelUnknownProblemMessage()
	{
		return "Un problÃ¨me inconnu est survenu lors du vote. Veuillez rÃ©essayer.";
	}

	protected override string _GetTemplateForLabelUnknownProblemTitle()
	{
		return "Une erreur s'est produite";
	}

	protected override string _GetTemplateForLabelUseModelMessage()
	{
		return "Vous devez utiliser ce modÃ¨le avant de pouvoir voter.";
	}

	protected override string _GetTemplateForLabelUseModelTitle()
	{
		return "Utiliser le modÃ¨le";
	}

	protected override string _GetTemplateForLabelYouMustLoginToVote()
	{
		return "Vous devez vous connecter afin de pouvoir voter.";
	}
}


}
