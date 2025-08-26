namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides VotingPanelResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class VotingPanelResources_es_es : VotingPanelResources_en_us, IVotingPanelResources, ITranslationResources
{
	/// <summary>
	/// Key: "Label.Accept"
	/// English String: "Verify"
	/// </summary>
	public override string LabelAccept => "Verificar";

	/// <summary>
	/// Key: "Label.AccountPageTitle"
	/// English String: "Account"
	/// </summary>
	public override string LabelAccountPageTitle => "Cuenta";

	/// <summary>
	/// Key: "Label.AccountUnderDayOneMessage"
	/// English String: "You will be able to vote on Games and Studio Models later, after you've had a chance to experience Roblox a bit more. Come back to this page in a couple days."
	/// </summary>
	public override string LabelAccountUnderDayOneMessage => "PodrÃ¡s votar juegos y modelos de Studio mÃ¡s tarde, cuando hayas podido experimentar Roblox un poco mÃ¡s. Vuelve a esta pÃ¡gina en un par de dÃ­as.";

	/// <summary>
	/// Key: "Label.AccountUnderDayOneTitle"
	/// English String: "Voter Feedback"
	/// </summary>
	public override string LabelAccountUnderDayOneTitle => "OpiniÃ³n del votante";

	/// <summary>
	/// Key: "Label.AssetNotVoteableMessage"
	/// English String: "This asset may not be voted on at this time."
	/// </summary>
	public override string LabelAssetNotVoteableMessage => "No se puede votar este recurso en este momento.";

	/// <summary>
	/// Key: "Label.AssetNotVoteableTitle"
	/// English String: "Unable to Vote"
	/// </summary>
	public override string LabelAssetNotVoteableTitle => "No se puede votar";

	/// <summary>
	/// Key: "Label.BuyGamePassMessage"
	/// English String: "You must own this game pass before you can vote on it."
	/// </summary>
	public override string LabelBuyGamePassMessage => "Debes poseer este pase de juego para poder votarlo.";

	/// <summary>
	/// Key: "Label.BuyGamePassTitle"
	/// English String: "Buy Game Pass"
	/// </summary>
	public override string LabelBuyGamePassTitle => "Compra el pase de juego";

	/// <summary>
	/// Key: "Label.Decline"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelDecline => "Cancelar";

	/// <summary>
	/// Key: "Label.EmailVerifiedTitle"
	/// English String: "Verify Your Email"
	/// </summary>
	public override string LabelEmailVerifiedTitle => "Verifica tu correo electrÃ³nico";

	/// <summary>
	/// Key: "Label.FloodCheckMessage"
	/// English String: "You're voting too quickly. Come back later and try again."
	/// </summary>
	public override string LabelFloodCheckMessage => "EstÃ¡s votando demasiado deprisa. Vuelve mÃ¡s tarde e intÃ©ntalo de nuevo.";

	/// <summary>
	/// Key: "Label.FloodCheckTitle"
	/// English String: "Slow Down"
	/// </summary>
	public override string LabelFloodCheckTitle => "Ve mÃ¡s despacio";

	/// <summary>
	/// Key: "Label.GuestUserTitle"
	/// English String: "Login to Vote"
	/// </summary>
	public override string LabelGuestUserTitle => "Inicia sesiÃ³n para votar";

	/// <summary>
	/// Key: "Label.InstallPluginMessage"
	/// English String: "You must install this plugin before you can vote on it."
	/// </summary>
	public override string LabelInstallPluginMessage => "Debes instalar este complemento para poder votarlo.";

	/// <summary>
	/// Key: "Label.InstallPluginTitle"
	/// English String: "Install Plugin"
	/// </summary>
	public override string LabelInstallPluginTitle => "Instala el complemento";

	/// <summary>
	/// Key: "Label.Login"
	/// English String: "Login"
	/// </summary>
	public override string LabelLogin => "Iniciar sesiÃ³n";

	/// <summary>
	/// Key: "Label.LoginOrRegisterPageTitle"
	/// English String: "login or register"
	/// </summary>
	public override string LabelLoginOrRegisterPageTitle => "inicia sesiÃ³n o regÃ­strate";

	/// <summary>
	/// Key: "Label.Ok"
	/// English String: "OK"
	/// </summary>
	public override string LabelOk => "Aceptar";

	/// <summary>
	/// Key: "Label.PlayGameMessage"
	/// English String: "You must play the game before you can vote on it."
	/// </summary>
	public override string LabelPlayGameMessage => "Debes probar el juego para poder votarlo.";

	/// <summary>
	/// Key: "Label.PlayGameTitle"
	/// English String: "Play Game"
	/// </summary>
	public override string LabelPlayGameTitle => "Prueba el juego";

	/// <summary>
	/// Key: "Label.UnknownProblemMessage"
	/// English String: "There was an unknown problem voting. Please try again."
	/// </summary>
	public override string LabelUnknownProblemMessage => "Se ha producido un error desconocido al votar. IntÃ©ntalo de nuevo.";

	/// <summary>
	/// Key: "Label.UnknownProblemTitle"
	/// English String: "Something Broke"
	/// </summary>
	public override string LabelUnknownProblemTitle => "Algo se ha roto";

	/// <summary>
	/// Key: "Label.UseModelMessage"
	/// English String: "You must use this model before you can vote on it."
	/// </summary>
	public override string LabelUseModelMessage => "Debes usar este modelo para poder votarlo.";

	/// <summary>
	/// Key: "Label.UseModelTitle"
	/// English String: "Use Model"
	/// </summary>
	public override string LabelUseModelTitle => "Usa el modelo";

	/// <summary>
	/// Key: "Label.YouMustLoginToVote"
	/// English String: "You must login to vote."
	/// </summary>
	public override string LabelYouMustLoginToVote => "Debes iniciar sesiÃ³n para votar.";

	public VotingPanelResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelAccept()
	{
		return "Verificar";
	}

	protected override string _GetTemplateForLabelAccountPageTitle()
	{
		return "Cuenta";
	}

	protected override string _GetTemplateForLabelAccountUnderDayOneMessage()
	{
		return "PodrÃ¡s votar juegos y modelos de Studio mÃ¡s tarde, cuando hayas podido experimentar Roblox un poco mÃ¡s. Vuelve a esta pÃ¡gina en un par de dÃ­as.";
	}

	protected override string _GetTemplateForLabelAccountUnderDayOneTitle()
	{
		return "OpiniÃ³n del votante";
	}

	protected override string _GetTemplateForLabelAssetNotVoteableMessage()
	{
		return "No se puede votar este recurso en este momento.";
	}

	protected override string _GetTemplateForLabelAssetNotVoteableTitle()
	{
		return "No se puede votar";
	}

	protected override string _GetTemplateForLabelBuyGamePassMessage()
	{
		return "Debes poseer este pase de juego para poder votarlo.";
	}

	protected override string _GetTemplateForLabelBuyGamePassTitle()
	{
		return "Compra el pase de juego";
	}

	protected override string _GetTemplateForLabelDecline()
	{
		return "Cancelar";
	}

	/// <summary>
	/// Key: "Label.EmailVerifiedMessage"
	/// English String: "You must verify your email before you can vote. You can verify your email on the {accountPageLink} page."
	/// </summary>
	public override string LabelEmailVerifiedMessage(string accountPageLink)
	{
		return $"Debes verificar tu correo electrÃ³nico para poder votar. Puedes verificar tu correo electrÃ³nico en la pÃ¡gina {accountPageLink}.";
	}

	protected override string _GetTemplateForLabelEmailVerifiedMessage()
	{
		return "Debes verificar tu correo electrÃ³nico para poder votar. Puedes verificar tu correo electrÃ³nico en la pÃ¡gina {accountPageLink}.";
	}

	protected override string _GetTemplateForLabelEmailVerifiedTitle()
	{
		return "Verifica tu correo electrÃ³nico";
	}

	protected override string _GetTemplateForLabelFloodCheckMessage()
	{
		return "EstÃ¡s votando demasiado deprisa. Vuelve mÃ¡s tarde e intÃ©ntalo de nuevo.";
	}

	protected override string _GetTemplateForLabelFloodCheckTitle()
	{
		return "Ve mÃ¡s despacio";
	}

	/// <summary>
	/// Key: "Label.GuestUserMessage"
	/// English String: "Please {loginOrRegisterPageLink} to continue."
	/// </summary>
	public override string LabelGuestUserMessage(string loginOrRegisterPageLink)
	{
		return $"Por favor, {loginOrRegisterPageLink} para continuar.";
	}

	protected override string _GetTemplateForLabelGuestUserMessage()
	{
		return "Por favor, {loginOrRegisterPageLink} para continuar.";
	}

	protected override string _GetTemplateForLabelGuestUserTitle()
	{
		return "Inicia sesiÃ³n para votar";
	}

	protected override string _GetTemplateForLabelInstallPluginMessage()
	{
		return "Debes instalar este complemento para poder votarlo.";
	}

	protected override string _GetTemplateForLabelInstallPluginTitle()
	{
		return "Instala el complemento";
	}

	protected override string _GetTemplateForLabelLogin()
	{
		return "Iniciar sesiÃ³n";
	}

	protected override string _GetTemplateForLabelLoginOrRegisterPageTitle()
	{
		return "inicia sesiÃ³n o regÃ­strate";
	}

	protected override string _GetTemplateForLabelOk()
	{
		return "Aceptar";
	}

	protected override string _GetTemplateForLabelPlayGameMessage()
	{
		return "Debes probar el juego para poder votarlo.";
	}

	protected override string _GetTemplateForLabelPlayGameTitle()
	{
		return "Prueba el juego";
	}

	protected override string _GetTemplateForLabelUnknownProblemMessage()
	{
		return "Se ha producido un error desconocido al votar. IntÃ©ntalo de nuevo.";
	}

	protected override string _GetTemplateForLabelUnknownProblemTitle()
	{
		return "Algo se ha roto";
	}

	protected override string _GetTemplateForLabelUseModelMessage()
	{
		return "Debes usar este modelo para poder votarlo.";
	}

	protected override string _GetTemplateForLabelUseModelTitle()
	{
		return "Usa el modelo";
	}

	protected override string _GetTemplateForLabelYouMustLoginToVote()
	{
		return "Debes iniciar sesiÃ³n para votar.";
	}
}


}
