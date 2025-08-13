namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides VotingPanelResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class VotingPanelResources_de_de : VotingPanelResources_en_us, IVotingPanelResources, ITranslationResources
{
	/// <summary>
	/// Key: "Label.Accept"
	/// English String: "Verify"
	/// </summary>
	public override string LabelAccept => "Verifizieren";

	/// <summary>
	/// Key: "Label.AccountPageTitle"
	/// English String: "Account"
	/// </summary>
	public override string LabelAccountPageTitle => "Konto";

	/// <summary>
	/// Key: "Label.AccountUnderDayOneMessage"
	/// English String: "You will be able to vote on Games and Studio Models later, after you've had a chance to experience Roblox a bit more. Come back to this page in a couple days."
	/// </summary>
	public override string LabelAccountUnderDayOneMessage => "Wenn du dich bei Roblox ein bisschen umgeschaut hast, darfst du auch über Spiele und Studio-Modelle abstimmen. Besuche diese Seite einfach in einigen Tagen nochmal.";

	/// <summary>
	/// Key: "Label.AccountUnderDayOneTitle"
	/// English String: "Voter Feedback"
	/// </summary>
	public override string LabelAccountUnderDayOneTitle => "Abstimmungs-Feedback";

	/// <summary>
	/// Key: "Label.AssetNotVoteableMessage"
	/// English String: "This asset may not be voted on at this time."
	/// </summary>
	public override string LabelAssetNotVoteableMessage => "Über dieses Objekt kann derzeit nicht abgestimmt werden.";

	/// <summary>
	/// Key: "Label.AssetNotVoteableTitle"
	/// English String: "Unable to Vote"
	/// </summary>
	public override string LabelAssetNotVoteableTitle => "Abstimmen nicht möglich";

	/// <summary>
	/// Key: "Label.BuyGamePassMessage"
	/// English String: "You must own this game pass before you can vote on it."
	/// </summary>
	public override string LabelBuyGamePassMessage => "Bevor du über diesen Spielpass abstimmen kannst, musst du ihn besitzen.";

	/// <summary>
	/// Key: "Label.BuyGamePassTitle"
	/// English String: "Buy Game Pass"
	/// </summary>
	public override string LabelBuyGamePassTitle => "Spielpass kaufen";

	/// <summary>
	/// Key: "Label.Decline"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelDecline => "Abbrechen";

	/// <summary>
	/// Key: "Label.EmailVerifiedTitle"
	/// English String: "Verify Your Email"
	/// </summary>
	public override string LabelEmailVerifiedTitle => "Verifiziere deine E-Mail-Adresse";

	/// <summary>
	/// Key: "Label.FloodCheckMessage"
	/// English String: "You're voting too quickly. Come back later and try again."
	/// </summary>
	public override string LabelFloodCheckMessage => "Du stimmst zu schnell ab. Komm später wieder und versuche es erneut.";

	/// <summary>
	/// Key: "Label.FloodCheckTitle"
	/// English String: "Slow Down"
	/// </summary>
	public override string LabelFloodCheckTitle => "Immer mit der Ruhe";

	/// <summary>
	/// Key: "Label.GuestUserTitle"
	/// English String: "Login to Vote"
	/// </summary>
	public override string LabelGuestUserTitle => "Zum Abstimmen anmelden";

	/// <summary>
	/// Key: "Label.InstallPluginMessage"
	/// English String: "You must install this plugin before you can vote on it."
	/// </summary>
	public override string LabelInstallPluginMessage => "Bevor du über diesen Plug-in abstimmen kannst, musst du ihn installieren.";

	/// <summary>
	/// Key: "Label.InstallPluginTitle"
	/// English String: "Install Plugin"
	/// </summary>
	public override string LabelInstallPluginTitle => "Plug-in installieren";

	/// <summary>
	/// Key: "Label.Login"
	/// English String: "Login"
	/// </summary>
	public override string LabelLogin => "Anmelden";

	/// <summary>
	/// Key: "Label.LoginOrRegisterPageTitle"
	/// English String: "login or register"
	/// </summary>
	public override string LabelLoginOrRegisterPageTitle => "anmelden oder registrieren";

	/// <summary>
	/// Key: "Label.Ok"
	/// English String: "OK"
	/// </summary>
	public override string LabelOk => "Okay";

	/// <summary>
	/// Key: "Label.PlayGameMessage"
	/// English String: "You must play the game before you can vote on it."
	/// </summary>
	public override string LabelPlayGameMessage => "Bevor du über das Spiel abstimmen kannst, musst du es spielen.";

	/// <summary>
	/// Key: "Label.PlayGameTitle"
	/// English String: "Play Game"
	/// </summary>
	public override string LabelPlayGameTitle => "Spiel spielen";

	/// <summary>
	/// Key: "Label.UnknownProblemMessage"
	/// English String: "There was an unknown problem voting. Please try again."
	/// </summary>
	public override string LabelUnknownProblemMessage => "Beim Abstimmen ist ein unbekanntes Problem aufgetreten. Bitte versuche es erneut.";

	/// <summary>
	/// Key: "Label.UnknownProblemTitle"
	/// English String: "Something Broke"
	/// </summary>
	public override string LabelUnknownProblemTitle => "Etwas ging schief";

	/// <summary>
	/// Key: "Label.UseModelMessage"
	/// English String: "You must use this model before you can vote on it."
	/// </summary>
	public override string LabelUseModelMessage => "Bevor du über dieses Modell abstimmen kannst, musst du es verwenden.";

	/// <summary>
	/// Key: "Label.UseModelTitle"
	/// English String: "Use Model"
	/// </summary>
	public override string LabelUseModelTitle => "Modell verwenden";

	/// <summary>
	/// Key: "Label.YouMustLoginToVote"
	/// English String: "You must login to vote."
	/// </summary>
	public override string LabelYouMustLoginToVote => "Zum Abstimmen musst du dich anmelden.";

	public VotingPanelResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelAccept()
	{
		return "Verifizieren";
	}

	protected override string _GetTemplateForLabelAccountPageTitle()
	{
		return "Konto";
	}

	protected override string _GetTemplateForLabelAccountUnderDayOneMessage()
	{
		return "Wenn du dich bei Roblox ein bisschen umgeschaut hast, darfst du auch über Spiele und Studio-Modelle abstimmen. Besuche diese Seite einfach in einigen Tagen nochmal.";
	}

	protected override string _GetTemplateForLabelAccountUnderDayOneTitle()
	{
		return "Abstimmungs-Feedback";
	}

	protected override string _GetTemplateForLabelAssetNotVoteableMessage()
	{
		return "Über dieses Objekt kann derzeit nicht abgestimmt werden.";
	}

	protected override string _GetTemplateForLabelAssetNotVoteableTitle()
	{
		return "Abstimmen nicht möglich";
	}

	protected override string _GetTemplateForLabelBuyGamePassMessage()
	{
		return "Bevor du über diesen Spielpass abstimmen kannst, musst du ihn besitzen.";
	}

	protected override string _GetTemplateForLabelBuyGamePassTitle()
	{
		return "Spielpass kaufen";
	}

	protected override string _GetTemplateForLabelDecline()
	{
		return "Abbrechen";
	}

	/// <summary>
	/// Key: "Label.EmailVerifiedMessage"
	/// English String: "You must verify your email before you can vote. You can verify your email on the {accountPageLink} page."
	/// </summary>
	public override string LabelEmailVerifiedMessage(string accountPageLink)
	{
		return $"Bevor du abstimmen kannst, musst du deine E-Mail-Adresse verifizieren. Dies kannst du auf der Seite „{accountPageLink}“ tun.";
	}

	protected override string _GetTemplateForLabelEmailVerifiedMessage()
	{
		return "Bevor du abstimmen kannst, musst du deine E-Mail-Adresse verifizieren. Dies kannst du auf der Seite „{accountPageLink}“ tun.";
	}

	protected override string _GetTemplateForLabelEmailVerifiedTitle()
	{
		return "Verifiziere deine E-Mail-Adresse";
	}

	protected override string _GetTemplateForLabelFloodCheckMessage()
	{
		return "Du stimmst zu schnell ab. Komm später wieder und versuche es erneut.";
	}

	protected override string _GetTemplateForLabelFloodCheckTitle()
	{
		return "Immer mit der Ruhe";
	}

	/// <summary>
	/// Key: "Label.GuestUserMessage"
	/// English String: "Please {loginOrRegisterPageLink} to continue."
	/// </summary>
	public override string LabelGuestUserMessage(string loginOrRegisterPageLink)
	{
		return $"Zum Fortfahren bitte {loginOrRegisterPageLink}.";
	}

	protected override string _GetTemplateForLabelGuestUserMessage()
	{
		return "Zum Fortfahren bitte {loginOrRegisterPageLink}.";
	}

	protected override string _GetTemplateForLabelGuestUserTitle()
	{
		return "Zum Abstimmen anmelden";
	}

	protected override string _GetTemplateForLabelInstallPluginMessage()
	{
		return "Bevor du über diesen Plug-in abstimmen kannst, musst du ihn installieren.";
	}

	protected override string _GetTemplateForLabelInstallPluginTitle()
	{
		return "Plug-in installieren";
	}

	protected override string _GetTemplateForLabelLogin()
	{
		return "Anmelden";
	}

	protected override string _GetTemplateForLabelLoginOrRegisterPageTitle()
	{
		return "anmelden oder registrieren";
	}

	protected override string _GetTemplateForLabelOk()
	{
		return "Okay";
	}

	protected override string _GetTemplateForLabelPlayGameMessage()
	{
		return "Bevor du über das Spiel abstimmen kannst, musst du es spielen.";
	}

	protected override string _GetTemplateForLabelPlayGameTitle()
	{
		return "Spiel spielen";
	}

	protected override string _GetTemplateForLabelUnknownProblemMessage()
	{
		return "Beim Abstimmen ist ein unbekanntes Problem aufgetreten. Bitte versuche es erneut.";
	}

	protected override string _GetTemplateForLabelUnknownProblemTitle()
	{
		return "Etwas ging schief";
	}

	protected override string _GetTemplateForLabelUseModelMessage()
	{
		return "Bevor du über dieses Modell abstimmen kannst, musst du es verwenden.";
	}

	protected override string _GetTemplateForLabelUseModelTitle()
	{
		return "Modell verwenden";
	}

	protected override string _GetTemplateForLabelYouMustLoginToVote()
	{
		return "Zum Abstimmen musst du dich anmelden.";
	}
}
