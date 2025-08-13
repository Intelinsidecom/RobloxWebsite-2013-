namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides RedeemToyResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class RedeemToyResources_fr_fr : RedeemToyResources_en_us, IRedeemToyResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// button text
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Annuler";

	/// <summary>
	/// Key: "Action.CantFindCode"
	/// link text
	/// English String: "Can't find your code?"
	/// </summary>
	public override string ActionCantFindCode => "Vous ne trouvez pas votre code\u00a0?";

	/// <summary>
	/// Key: "Action.Close"
	/// button text
	/// English String: "Close"
	/// </summary>
	public override string ActionClose => "Fermer";

	/// <summary>
	/// Key: "Action.ContinueVideo"
	/// button text
	/// English String: "Continue to Video"
	/// </summary>
	public override string ActionContinueVideo => "Continuer vers la vidéo";

	/// <summary>
	/// Key: "Action.HavePromoCode"
	/// link text
	/// English String: "Have a promo code? Click here"
	/// </summary>
	public override string ActionHavePromoCode => "Vous avez un code promotionnel\u00a0? Cliquez ici";

	/// <summary>
	/// Key: "Action.HowToRedeem"
	/// link text
	/// English String: "How to redeem"
	/// </summary>
	public override string ActionHowToRedeem => "Instructions d'activation";

	/// <summary>
	/// Key: "Action.Login"
	/// button text
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "Connexion";

	/// <summary>
	/// Key: "Action.Redeem"
	/// button text
	/// English String: "Redeem"
	/// </summary>
	public override string ActionRedeem => "Activer";

	/// <summary>
	/// Key: "Action.RedeemAnotherItem"
	/// button text
	/// English String: "Redeem Another Item"
	/// </summary>
	public override string ActionRedeemAnotherItem => "Activer un autre objet";

	/// <summary>
	/// Key: "Action.SignUp"
	/// button text
	/// English String: "Sign Up"
	/// </summary>
	public override string ActionSignUp => "Inscription";

	/// <summary>
	/// Key: "Action.ViewItem"
	/// button text
	/// English String: "View Item"
	/// </summary>
	public override string ActionViewItem => "Voir l'objet";

	/// <summary>
	/// Key: "Description.LeavingRoblox"
	/// modal description text warning user that they are leaving Roblox main site
	/// English String: "You are about to leave Roblox to view a video on Youtube. Youtube is not part of Roblox.com and is governed by a separate privacy policy."
	/// </summary>
	public override string DescriptionLeavingRoblox => "Vous êtes sur le point de quitter Roblox pour visionner une vidéo sur YouTube. YouTube ne fait pas partie du site web Roblox.com et dispose de sa propre politique de confidentialité.";

	/// <summary>
	/// Key: "Heading.Dialog.Success"
	/// modal heading
	/// English String: "Successfully Redeemed"
	/// </summary>
	public override string HeadingDialogSuccess => "Activation réussie";

	/// <summary>
	/// Key: "Heading.RedeemVirtualItem"
	/// page heading
	/// English String: "Redeem Roblox Virtual Item"
	/// </summary>
	public override string HeadingRedeemVirtualItem => "Activer un objet virtuel Roblox";

	/// <summary>
	/// Key: "Heading.YoureLeavingRoblox"
	/// modal heading
	/// English String: "You are leaving Roblox"
	/// </summary>
	public override string HeadingYoureLeavingRoblox => "Vous quittez Roblox";

	/// <summary>
	/// Key: "Label.EnterToyCode"
	/// label
	/// English String: "Enter Toy Code"
	/// </summary>
	public override string LabelEnterToyCode => "Saisir le code jouet";

	/// <summary>
	/// Key: "Response.InvalidCodeTryAgain"
	/// error message
	/// English String: "Invalid code, please try again."
	/// </summary>
	public override string ResponseInvalidCodeTryAgain => "Code non valide, veuillez réessayer.";

	/// <summary>
	/// Key: "Response.LoginRequiredToRedeem"
	/// error message
	/// English String: "You must be logged in to your Roblox account to redeem the code for your virtual item!"
	/// </summary>
	public override string ResponseLoginRequiredToRedeem => "Vous devez être connecté(e) à votre compte Roblox afin d'activer le code de votre objet virtuel\u00a0!";

	/// <summary>
	/// Key: "Response.RedeemSuccess"
	/// success message
	/// English String: "You have successfully redeemed your item."
	/// </summary>
	public override string ResponseRedeemSuccess => "Votre objet a bien été activé.";

	public RedeemToyResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Annuler";
	}

	protected override string _GetTemplateForActionCantFindCode()
	{
		return "Vous ne trouvez pas votre code\u00a0?";
	}

	protected override string _GetTemplateForActionClose()
	{
		return "Fermer";
	}

	protected override string _GetTemplateForActionContinueVideo()
	{
		return "Continuer vers la vidéo";
	}

	protected override string _GetTemplateForActionHavePromoCode()
	{
		return "Vous avez un code promotionnel\u00a0? Cliquez ici";
	}

	protected override string _GetTemplateForActionHowToRedeem()
	{
		return "Instructions d'activation";
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "Connexion";
	}

	protected override string _GetTemplateForActionRedeem()
	{
		return "Activer";
	}

	protected override string _GetTemplateForActionRedeemAnotherItem()
	{
		return "Activer un autre objet";
	}

	protected override string _GetTemplateForActionSignUp()
	{
		return "Inscription";
	}

	protected override string _GetTemplateForActionViewItem()
	{
		return "Voir l'objet";
	}

	/// <summary>
	/// Key: "Description.Dialog.Success"
	/// modal description text for successful redeem
	/// English String: "You have successfully redeemed {spanTagStart}{itemName}{spanTagEnd} ({itemType}) from {creatorName}."
	/// </summary>
	public override string DescriptionDialogSuccess(string spanTagStart, string itemName, string spanTagEnd, string itemType, string creatorName)
	{
		return $"Vous avez activé l'objet {spanTagStart}{itemName}{spanTagEnd} ({itemType}) de {creatorName}.";
	}

	protected override string _GetTemplateForDescriptionDialogSuccess()
	{
		return "Vous avez activé l'objet {spanTagStart}{itemName}{spanTagEnd} ({itemType}) de {creatorName}.";
	}

	protected override string _GetTemplateForDescriptionLeavingRoblox()
	{
		return "Vous êtes sur le point de quitter Roblox pour visionner une vidéo sur YouTube. YouTube ne fait pas partie du site web Roblox.com et dispose de sa propre politique de confidentialité.";
	}

	protected override string _GetTemplateForHeadingDialogSuccess()
	{
		return "Activation réussie";
	}

	protected override string _GetTemplateForHeadingRedeemVirtualItem()
	{
		return "Activer un objet virtuel Roblox";
	}

	protected override string _GetTemplateForHeadingYoureLeavingRoblox()
	{
		return "Vous quittez Roblox";
	}

	protected override string _GetTemplateForLabelEnterToyCode()
	{
		return "Saisir le code jouet";
	}

	protected override string _GetTemplateForResponseInvalidCodeTryAgain()
	{
		return "Code non valide, veuillez réessayer.";
	}

	protected override string _GetTemplateForResponseLoginRequiredToRedeem()
	{
		return "Vous devez être connecté(e) à votre compte Roblox afin d'activer le code de votre objet virtuel\u00a0!";
	}

	protected override string _GetTemplateForResponseRedeemSuccess()
	{
		return "Votre objet a bien été activé.";
	}
}
