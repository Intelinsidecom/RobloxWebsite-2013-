namespace Roblox.TranslationResources.Purchasing;

/// <summary>
/// This class overrides RedeemGameCardResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class RedeemGameCardResources_fr_fr : RedeemGameCardResources_en_us, IRedeemGameCardResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Dialog.Close"
	/// button text
	/// English String: "Close"
	/// </summary>
	public override string ActionDialogClose => "Fermer";

	/// <summary>
	/// Key: "Action.Dialog.Login"
	/// button text
	/// English String: "Login"
	/// </summary>
	public override string ActionDialogLogin => "Connexion";

	/// <summary>
	/// Key: "Action.Dialog.SignUp"
	/// button text
	/// English String: "Sign Up"
	/// </summary>
	public override string ActionDialogSignUp => "Inscription";

	/// <summary>
	/// Key: "Action.PurchaseCard"
	/// link text
	/// English String: "Purchase Card"
	/// </summary>
	public override string ActionPurchaseCard => "Acheter une carte";

	/// <summary>
	/// Key: "Action.Redeem"
	/// button text
	/// English String: "Redeem"
	/// </summary>
	public override string ActionRedeem => "Activer";

	/// <summary>
	/// Key: "Description.CombineCards"
	/// bullet point in a list
	/// English String: "Combine cards for more Roblox credit."
	/// </summary>
	public override string DescriptionCombineCards => "Combinez les cartes pour augmenter vos crédits Roblox.";

	/// <summary>
	/// Key: "Description.Dialog.RobloxRedeemCard"
	/// diglog main text
	/// English String: "You must be logged in to your Roblox account to redeem your Game Card!"
	/// </summary>
	public override string DescriptionDialogRobloxRedeemCard => "Vous devez être connecté(e) à votre compte Roblox afin d'activer une carte de jeu\u00a0!";

	/// <summary>
	/// Key: "Description.LegalDisclaimer"
	/// descrption text
	/// English String: "Purchases can be made with only one form of payment. Game card credits cannot be combined with other forms of payment."
	/// </summary>
	public override string DescriptionLegalDisclaimer => "Les achats ne peuvent être effectués qu'avec un seul moyen de paiement. Les crédits de carte de jeu ne peuvent pas être associés à d'autres moyens de paiement.";

	/// <summary>
	/// Key: "Description.RetailersInfo"
	/// bullet point of a list
	/// English String: "Buy a Roblox game card at one of the participating retailers or receive a Roblox gift card from someone."
	/// </summary>
	public override string DescriptionRetailersInfo => "Achetez une carte de jeu Roblox dans l'un des magasins participants ou utilisez-en une reçue en cadeau.";

	/// <summary>
	/// Key: "Description.SpendRobloxCredit"
	/// bullet point of a list
	/// English String: "Spend your Roblox credit on Robux and Builders Club!"
	/// </summary>
	public override string DescriptionSpendRobloxCredit => "Dépensez vos crédits Roblox pour acheter des Robux et dans le Builders Club\u00a0!";

	/// <summary>
	/// Key: "Description.TypeCardPin"
	/// bullet point in a list
	/// English String: "Type in your card PIN in the redeem section."
	/// </summary>
	public override string DescriptionTypeCardPin => "Saisissez le code PIN de la carte dans la section d'activation.";

	/// <summary>
	/// Key: "Heading.EnterPin"
	/// section heading  - please keep PIN capitalized if the languiage supports it
	/// English String: "Enter PIN"
	/// </summary>
	public override string HeadingEnterPin => "Saisir le code PIN";

	/// <summary>
	/// Key: "Heading.GetRobloxCreditFor"
	/// section heading
	/// English String: "Get Roblox credit for"
	/// </summary>
	public override string HeadingGetRobloxCreditFor => "Obtenir des crédits Roblox pour";

	/// <summary>
	/// Key: "Heading.HowToRedeem"
	/// modal(dialog box) heading
	/// English String: "How to Redeem"
	/// </summary>
	public override string HeadingHowToRedeem => "Instructions d'activation";

	/// <summary>
	/// Key: "Heading.HowToUse"
	/// section heading
	/// English String: "How to Use"
	/// </summary>
	public override string HeadingHowToUse => "Fonctionnement";

	/// <summary>
	/// Key: "Heading.RedeemRobloxCards"
	/// page heading
	/// English String: "Redeem Roblox cards"
	/// </summary>
	public override string HeadingRedeemRobloxCards => "Activer une carte Roblox";

	/// <summary>
	/// Key: "Label.Dialog.RedeemGameCard"
	/// dialog title
	/// English String: "Redeem Roblox Game Card"
	/// </summary>
	public override string LabelDialogRedeemGameCard => "Activer une carte de jeu Roblox";

	/// <summary>
	/// Key: "Label.NeedGameCard"
	/// label
	/// English String: "Need a Roblox game card?"
	/// </summary>
	public override string LabelNeedGameCard => "Besoin d'une carte de jeu Roblox\u00a0?";

	/// <summary>
	/// Key: "Label.PinCode"
	/// please keep PIN capitalized if language supports capitalization
	/// English String: "PIN Code"
	/// </summary>
	public override string LabelPinCode => "Code PIN";

	/// <summary>
	/// Key: "Label.RobuxRedeemed"
	/// English String: "Robux Redeemed:"
	/// </summary>
	public override string LabelRobuxRedeemed => "Robux activés :";

	/// <summary>
	/// Key: "Label.YourBalance"
	/// label
	/// English String: "Your Credit Balance:"
	/// </summary>
	public override string LabelYourBalance => "Ton solde\u00a0:";

	/// <summary>
	/// Key: "Response.AlreadyRedeemedError"
	/// error message
	/// English String: "This gift card has already been redeemed."
	/// </summary>
	public override string ResponseAlreadyRedeemedError => "Cette carte cadeau a déjà été activée.";

	/// <summary>
	/// Key: "Response.BonusPreview"
	/// success message upsell text
	/// English String: "Redeem one more Roblox card from GameStop to receive your bonus Robux."
	/// </summary>
	public override string ResponseBonusPreview => "Activez une autre carte Roblox de GameStop pour recevoir votre bonus de Robux.";

	/// <summary>
	/// Key: "Response.BuildersClubExtended"
	/// success message
	/// English String: "Your Builders Club Membership has successfully been extended!"
	/// </summary>
	public override string ResponseBuildersClubExtended => "Votre abonnement au Builders Club a bien été prolongé\u00a0!";

	/// <summary>
	/// Key: "Response.BuildersClubExtendedSubText"
	/// sub text on success message
	/// English String: "Please allow up to 5 minutes for the changes to take effect."
	/// </summary>
	public override string ResponseBuildersClubExtendedSubText => "Les changements peuvent prendre jusqu'à cinq minutes avant d'entrer en vigueur.";

	/// <summary>
	/// Key: "Response.BuildersClubRedeemed"
	/// success message
	/// English String: "Your Builders Club Membership has successfully been redeemed!"
	/// </summary>
	public override string ResponseBuildersClubRedeemed => "Votre abonnement au Builders Club a bien été activé\u00a0!";

	/// <summary>
	/// Key: "Response.CodeNotFoundError"
	/// error message
	/// English String: "No matching code found."
	/// </summary>
	public override string ResponseCodeNotFoundError => "Aucun code correspondant trouvé.";

	/// <summary>
	/// Key: "Response.CouldNotFindObject"
	/// error message
	/// English String: "Could not find requested object."
	/// </summary>
	public override string ResponseCouldNotFindObject => "Impossible de trouver l'élément recherché.";

	/// <summary>
	/// Key: "Response.FeatureDisabledError"
	/// error message
	/// English String: "This feature is currently disabled."
	/// </summary>
	public override string ResponseFeatureDisabledError => "Cette fonctionnalité est actuellement désactivée.";

	/// <summary>
	/// Key: "Response.GenericError"
	/// error message
	/// English String: "Something went wrong, please try again later."
	/// </summary>
	public override string ResponseGenericError => "Un problème est survenu. Veuillez réessayer plus tard.";

	/// <summary>
	/// Key: "Response.InvalidPIN"
	/// error message
	/// English String: "Invalid PIN"
	/// </summary>
	public override string ResponseInvalidPIN => "Code PIN invalide";

	/// <summary>
	/// Key: "Response.LoginRequiredError"
	/// error message
	/// English String: "You must be logged in to perform this action."
	/// </summary>
	public override string ResponseLoginRequiredError => "Vous devez être connecté(e) afin d'effectuer cette action.";

	/// <summary>
	/// Key: "Response.ObjectNotFoundError"
	/// error message
	/// English String: "Could not find the requested object. Please try your request again and contact customer service if this problem persists."
	/// </summary>
	public override string ResponseObjectNotFoundError => "Impossible de trouver l'élément recherché. Veuillez réessayer plus tard ou contacter l'assistance clientèle si le problème persiste.";

	/// <summary>
	/// Key: "Response.RedeemSuccess"
	/// success message
	/// English String: "You have successfully redeemed your card!"
	/// </summary>
	public override string ResponseRedeemSuccess => "Votre carte a bien été activée\u00a0!";

	/// <summary>
	/// Key: "Response.TooManyCodesRedeemedError"
	/// error message
	/// English String: "Too many codes redeemed. Try your request again later."
	/// </summary>
	public override string ResponseTooManyCodesRedeemedError => "Trop de codes activés. Veuillez renouveler votre requête plus tard.";

	/// <summary>
	/// Key: "Response.TooManyRequestsError"
	/// error messages
	/// English String: "Too many failed request attempts. Try your request again later."
	/// </summary>
	public override string ResponseTooManyRequestsError => "Trop de tentatives de requête incorrectes. Veuillez renouveler votre requête plus tard.";

	public RedeemGameCardResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDialogClose()
	{
		return "Fermer";
	}

	protected override string _GetTemplateForActionDialogLogin()
	{
		return "Connexion";
	}

	protected override string _GetTemplateForActionDialogSignUp()
	{
		return "Inscription";
	}

	protected override string _GetTemplateForActionPurchaseCard()
	{
		return "Acheter une carte";
	}

	protected override string _GetTemplateForActionRedeem()
	{
		return "Activer";
	}

	protected override string _GetTemplateForDescriptionCombineCards()
	{
		return "Combinez les cartes pour augmenter vos crédits Roblox.";
	}

	protected override string _GetTemplateForDescriptionDialogRobloxRedeemCard()
	{
		return "Vous devez être connecté(e) à votre compte Roblox afin d'activer une carte de jeu\u00a0!";
	}

	protected override string _GetTemplateForDescriptionLegalDisclaimer()
	{
		return "Les achats ne peuvent être effectués qu'avec un seul moyen de paiement. Les crédits de carte de jeu ne peuvent pas être associés à d'autres moyens de paiement.";
	}

	/// <summary>
	/// Key: "Description.RetailerLink"
	/// bullet point in a list
	/// English String: "Buy a Roblox game card at one of the {retailerLinkStart}participating retailers{retailerLinkEnd} or receive a Roblox gift card from someone. "
	/// </summary>
	public override string DescriptionRetailerLink(string retailerLinkStart, string retailerLinkEnd)
	{
		return $"Achetez une carte de jeu Roblox dans l'un des {retailerLinkStart}magasins participants{retailerLinkEnd} ou utilisez-en une reçue en cadeau. ";
	}

	protected override string _GetTemplateForDescriptionRetailerLink()
	{
		return "Achetez une carte de jeu Roblox dans l'un des {retailerLinkStart}magasins participants{retailerLinkEnd} ou utilisez-en une reçue en cadeau. ";
	}

	protected override string _GetTemplateForDescriptionRetailersInfo()
	{
		return "Achetez une carte de jeu Roblox dans l'un des magasins participants ou utilisez-en une reçue en cadeau.";
	}

	protected override string _GetTemplateForDescriptionSpendRobloxCredit()
	{
		return "Dépensez vos crédits Roblox pour acheter des Robux et dans le Builders Club\u00a0!";
	}

	protected override string _GetTemplateForDescriptionTypeCardPin()
	{
		return "Saisissez le code PIN de la carte dans la section d'activation.";
	}

	protected override string _GetTemplateForHeadingEnterPin()
	{
		return "Saisir le code PIN";
	}

	protected override string _GetTemplateForHeadingGetRobloxCreditFor()
	{
		return "Obtenir des crédits Roblox pour";
	}

	protected override string _GetTemplateForHeadingHowToRedeem()
	{
		return "Instructions d'activation";
	}

	protected override string _GetTemplateForHeadingHowToUse()
	{
		return "Fonctionnement";
	}

	protected override string _GetTemplateForHeadingRedeemRobloxCards()
	{
		return "Activer une carte Roblox";
	}

	protected override string _GetTemplateForLabelDialogRedeemGameCard()
	{
		return "Activer une carte de jeu Roblox";
	}

	protected override string _GetTemplateForLabelNeedGameCard()
	{
		return "Besoin d'une carte de jeu Roblox\u00a0?";
	}

	protected override string _GetTemplateForLabelPinCode()
	{
		return "Code PIN";
	}

	protected override string _GetTemplateForLabelRobuxRedeemed()
	{
		return "Robux activés :";
	}

	protected override string _GetTemplateForLabelYourBalance()
	{
		return "Ton solde\u00a0:";
	}

	protected override string _GetTemplateForResponseAlreadyRedeemedError()
	{
		return "Cette carte cadeau a déjà été activée.";
	}

	protected override string _GetTemplateForResponseBonusPreview()
	{
		return "Activez une autre carte Roblox de GameStop pour recevoir votre bonus de Robux.";
	}

	protected override string _GetTemplateForResponseBuildersClubExtended()
	{
		return "Votre abonnement au Builders Club a bien été prolongé\u00a0!";
	}

	protected override string _GetTemplateForResponseBuildersClubExtendedSubText()
	{
		return "Les changements peuvent prendre jusqu'à cinq minutes avant d'entrer en vigueur.";
	}

	protected override string _GetTemplateForResponseBuildersClubRedeemed()
	{
		return "Votre abonnement au Builders Club a bien été activé\u00a0!";
	}

	protected override string _GetTemplateForResponseCodeNotFoundError()
	{
		return "Aucun code correspondant trouvé.";
	}

	protected override string _GetTemplateForResponseCouldNotFindObject()
	{
		return "Impossible de trouver l'élément recherché.";
	}

	protected override string _GetTemplateForResponseFeatureDisabledError()
	{
		return "Cette fonctionnalité est actuellement désactivée.";
	}

	protected override string _GetTemplateForResponseGenericError()
	{
		return "Un problème est survenu. Veuillez réessayer plus tard.";
	}

	protected override string _GetTemplateForResponseInvalidPIN()
	{
		return "Code PIN invalide";
	}

	protected override string _GetTemplateForResponseLoginRequiredError()
	{
		return "Vous devez être connecté(e) afin d'effectuer cette action.";
	}

	/// <summary>
	/// Key: "Response.MerchantNotFoundError"
	/// error message
	/// English String: "User tried to redeem Pin but the merchant does not exist. UserId: {authenticatedUserId} Pin Number: {cardPin}"
	/// </summary>
	public override string ResponseMerchantNotFoundError(string authenticatedUserId, string cardPin)
	{
		return $"L'utilisateur a essayé d'activer un code PIN mais le vendeur n'existe pas. ID utilisateur\u00a0: {authenticatedUserId} Code PIN\u00a0: {cardPin}";
	}

	protected override string _GetTemplateForResponseMerchantNotFoundError()
	{
		return "L'utilisateur a essayé d'activer un code PIN mais le vendeur n'existe pas. ID utilisateur\u00a0: {authenticatedUserId} Code PIN\u00a0: {cardPin}";
	}

	protected override string _GetTemplateForResponseObjectNotFoundError()
	{
		return "Impossible de trouver l'élément recherché. Veuillez réessayer plus tard ou contacter l'assistance clientèle si le problème persiste.";
	}

	protected override string _GetTemplateForResponseRedeemSuccess()
	{
		return "Votre carte a bien été activée\u00a0!";
	}

	/// <summary>
	/// Key: "Response.RedeemSuccessForProduct"
	/// success message
	/// English String: "You have successfully redeemed your card for {productName}"
	/// </summary>
	public override string ResponseRedeemSuccessForProduct(string productName)
	{
		return $"Votre carte pour {productName} a bien été activée.";
	}

	protected override string _GetTemplateForResponseRedeemSuccessForProduct()
	{
		return "Votre carte pour {productName} a bien été activée.";
	}

	protected override string _GetTemplateForResponseTooManyCodesRedeemedError()
	{
		return "Trop de codes activés. Veuillez renouveler votre requête plus tard.";
	}

	protected override string _GetTemplateForResponseTooManyRequestsError()
	{
		return "Trop de tentatives de requête incorrectes. Veuillez renouveler votre requête plus tard.";
	}

	/// <summary>
	/// Key: "Response.TwoCardsBonus"
	/// success message
	/// English String: "Thanks for redeeming two Roblox cards from GameStop. {robuxCount} Robux have been added to your account."
	/// </summary>
	public override string ResponseTwoCardsBonus(string robuxCount)
	{
		return $"Merci d'avoir activé deux cartes Roblox de GameStop. {robuxCount}\u00a0Robux ont été crédités à votre compte.";
	}

	protected override string _GetTemplateForResponseTwoCardsBonus()
	{
		return "Merci d'avoir activé deux cartes Roblox de GameStop. {robuxCount}\u00a0Robux ont été crédités à votre compte.";
	}

	/// <summary>
	/// Key: "Response.WalmartRewardUpsell"
	/// upsell message
	/// English String: "Redeem one more Roblox card from Walmart to receive {rewardName}."
	/// </summary>
	public override string ResponseWalmartRewardUpsell(string rewardName)
	{
		return $"Activez une autre carte Roblox de Walmart pour recevoir\u00a0: {rewardName}.";
	}

	protected override string _GetTemplateForResponseWalmartRewardUpsell()
	{
		return "Activez une autre carte Roblox de Walmart pour recevoir\u00a0: {rewardName}.";
	}
}
