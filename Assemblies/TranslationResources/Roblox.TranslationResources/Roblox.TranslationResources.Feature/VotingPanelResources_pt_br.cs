namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides VotingPanelResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class VotingPanelResources_pt_br : VotingPanelResources_en_us, IVotingPanelResources, ITranslationResources
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
	public override string LabelAccountPageTitle => "Conta";

	/// <summary>
	/// Key: "Label.AccountUnderDayOneMessage"
	/// English String: "You will be able to vote on Games and Studio Models later, after you've had a chance to experience Roblox a bit more. Come back to this page in a couple days."
	/// </summary>
	public override string LabelAccountUnderDayOneMessage => "Você poderá votar em jogos e modelos do Studio mais tarde, depois de ter tido a chance de conhecer um pouco mais sobre o Roblox. Volte a esta página em alguns dias.";

	/// <summary>
	/// Key: "Label.AccountUnderDayOneTitle"
	/// English String: "Voter Feedback"
	/// </summary>
	public override string LabelAccountUnderDayOneTitle => "Opinião de votante";

	/// <summary>
	/// Key: "Label.AssetNotVoteableMessage"
	/// English String: "This asset may not be voted on at this time."
	/// </summary>
	public override string LabelAssetNotVoteableMessage => "Você não pode votar neste elemento no momento.";

	/// <summary>
	/// Key: "Label.AssetNotVoteableTitle"
	/// English String: "Unable to Vote"
	/// </summary>
	public override string LabelAssetNotVoteableTitle => "Impossível votar";

	/// <summary>
	/// Key: "Label.BuyGamePassMessage"
	/// English String: "You must own this game pass before you can vote on it."
	/// </summary>
	public override string LabelBuyGamePassMessage => "Você precisa ter esse passe de jogo antes de poder votar nele.";

	/// <summary>
	/// Key: "Label.BuyGamePassTitle"
	/// English String: "Buy Game Pass"
	/// </summary>
	public override string LabelBuyGamePassTitle => "Comprar passe de jogo";

	/// <summary>
	/// Key: "Label.Decline"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelDecline => "Cancelar";

	/// <summary>
	/// Key: "Label.EmailVerifiedTitle"
	/// English String: "Verify Your Email"
	/// </summary>
	public override string LabelEmailVerifiedTitle => "Verifique seu e-mail";

	/// <summary>
	/// Key: "Label.FloodCheckMessage"
	/// English String: "You're voting too quickly. Come back later and try again."
	/// </summary>
	public override string LabelFloodCheckMessage => "Você está votando rápido demais. Volte mais tarde e tente novamente.";

	/// <summary>
	/// Key: "Label.FloodCheckTitle"
	/// English String: "Slow Down"
	/// </summary>
	public override string LabelFloodCheckTitle => "Calma";

	/// <summary>
	/// Key: "Label.GuestUserTitle"
	/// English String: "Login to Vote"
	/// </summary>
	public override string LabelGuestUserTitle => "Conecte-se para votar";

	/// <summary>
	/// Key: "Label.InstallPluginMessage"
	/// English String: "You must install this plugin before you can vote on it."
	/// </summary>
	public override string LabelInstallPluginMessage => "Você precisa instalar este plugin antes de poder votar nele.";

	/// <summary>
	/// Key: "Label.InstallPluginTitle"
	/// English String: "Install Plugin"
	/// </summary>
	public override string LabelInstallPluginTitle => "Instalar plugin";

	/// <summary>
	/// Key: "Label.Login"
	/// English String: "Login"
	/// </summary>
	public override string LabelLogin => "Conectar-se";

	/// <summary>
	/// Key: "Label.LoginOrRegisterPageTitle"
	/// English String: "login or register"
	/// </summary>
	public override string LabelLoginOrRegisterPageTitle => "conecte-se ou cadastre-se";

	/// <summary>
	/// Key: "Label.Ok"
	/// English String: "OK"
	/// </summary>
	public override string LabelOk => "OK";

	/// <summary>
	/// Key: "Label.PlayGameMessage"
	/// English String: "You must play the game before you can vote on it."
	/// </summary>
	public override string LabelPlayGameMessage => "Você precisa jogar o jogo para poder votar nele.";

	/// <summary>
	/// Key: "Label.PlayGameTitle"
	/// English String: "Play Game"
	/// </summary>
	public override string LabelPlayGameTitle => "Jogar";

	/// <summary>
	/// Key: "Label.UnknownProblemMessage"
	/// English String: "There was an unknown problem voting. Please try again."
	/// </summary>
	public override string LabelUnknownProblemMessage => "Ocorreu um erro desconhecido na votação. Tente novamente.";

	/// <summary>
	/// Key: "Label.UnknownProblemTitle"
	/// English String: "Something Broke"
	/// </summary>
	public override string LabelUnknownProblemTitle => "Algo quebrou";

	/// <summary>
	/// Key: "Label.UseModelMessage"
	/// English String: "You must use this model before you can vote on it."
	/// </summary>
	public override string LabelUseModelMessage => "Você precisa usar este modelo antes de poder votar nele.";

	/// <summary>
	/// Key: "Label.UseModelTitle"
	/// English String: "Use Model"
	/// </summary>
	public override string LabelUseModelTitle => "Usar modelo";

	/// <summary>
	/// Key: "Label.YouMustLoginToVote"
	/// English String: "You must login to vote."
	/// </summary>
	public override string LabelYouMustLoginToVote => "Você precisa se conectar para votar.";

	public VotingPanelResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelAccept()
	{
		return "Verificar";
	}

	protected override string _GetTemplateForLabelAccountPageTitle()
	{
		return "Conta";
	}

	protected override string _GetTemplateForLabelAccountUnderDayOneMessage()
	{
		return "Você poderá votar em jogos e modelos do Studio mais tarde, depois de ter tido a chance de conhecer um pouco mais sobre o Roblox. Volte a esta página em alguns dias.";
	}

	protected override string _GetTemplateForLabelAccountUnderDayOneTitle()
	{
		return "Opinião de votante";
	}

	protected override string _GetTemplateForLabelAssetNotVoteableMessage()
	{
		return "Você não pode votar neste elemento no momento.";
	}

	protected override string _GetTemplateForLabelAssetNotVoteableTitle()
	{
		return "Impossível votar";
	}

	protected override string _GetTemplateForLabelBuyGamePassMessage()
	{
		return "Você precisa ter esse passe de jogo antes de poder votar nele.";
	}

	protected override string _GetTemplateForLabelBuyGamePassTitle()
	{
		return "Comprar passe de jogo";
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
		return $"Você precisa validar o seu e-mail antes de poder votar. Você pode verificar seu e-mail na página {accountPageLink}.";
	}

	protected override string _GetTemplateForLabelEmailVerifiedMessage()
	{
		return "Você precisa validar o seu e-mail antes de poder votar. Você pode verificar seu e-mail na página {accountPageLink}.";
	}

	protected override string _GetTemplateForLabelEmailVerifiedTitle()
	{
		return "Verifique seu e-mail";
	}

	protected override string _GetTemplateForLabelFloodCheckMessage()
	{
		return "Você está votando rápido demais. Volte mais tarde e tente novamente.";
	}

	protected override string _GetTemplateForLabelFloodCheckTitle()
	{
		return "Calma";
	}

	/// <summary>
	/// Key: "Label.GuestUserMessage"
	/// English String: "Please {loginOrRegisterPageLink} to continue."
	/// </summary>
	public override string LabelGuestUserMessage(string loginOrRegisterPageLink)
	{
		return $"{loginOrRegisterPageLink} para continuar.";
	}

	protected override string _GetTemplateForLabelGuestUserMessage()
	{
		return "{loginOrRegisterPageLink} para continuar.";
	}

	protected override string _GetTemplateForLabelGuestUserTitle()
	{
		return "Conecte-se para votar";
	}

	protected override string _GetTemplateForLabelInstallPluginMessage()
	{
		return "Você precisa instalar este plugin antes de poder votar nele.";
	}

	protected override string _GetTemplateForLabelInstallPluginTitle()
	{
		return "Instalar plugin";
	}

	protected override string _GetTemplateForLabelLogin()
	{
		return "Conectar-se";
	}

	protected override string _GetTemplateForLabelLoginOrRegisterPageTitle()
	{
		return "conecte-se ou cadastre-se";
	}

	protected override string _GetTemplateForLabelOk()
	{
		return "OK";
	}

	protected override string _GetTemplateForLabelPlayGameMessage()
	{
		return "Você precisa jogar o jogo para poder votar nele.";
	}

	protected override string _GetTemplateForLabelPlayGameTitle()
	{
		return "Jogar";
	}

	protected override string _GetTemplateForLabelUnknownProblemMessage()
	{
		return "Ocorreu um erro desconhecido na votação. Tente novamente.";
	}

	protected override string _GetTemplateForLabelUnknownProblemTitle()
	{
		return "Algo quebrou";
	}

	protected override string _GetTemplateForLabelUseModelMessage()
	{
		return "Você precisa usar este modelo antes de poder votar nele.";
	}

	protected override string _GetTemplateForLabelUseModelTitle()
	{
		return "Usar modelo";
	}

	protected override string _GetTemplateForLabelYouMustLoginToVote()
	{
		return "Você precisa se conectar para votar.";
	}
}
