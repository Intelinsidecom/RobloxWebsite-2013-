namespace Roblox.TranslationResources.Purchasing;

/// <summary>
/// This class overrides RixtyPinResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class RixtyPinResources_fr_fr : RixtyPinResources_en_us, IRixtyPinResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.BuyNow"
	/// English String: "Buy Now"
	/// </summary>
	public override string ActionBuyNow => "Acheter maintenant";

	/// <summary>
	/// Key: "Action.BuyRobux"
	/// English String: "Buy Robux"
	/// </summary>
	public override string ActionBuyRobux => "Acheter des Robux";

	/// <summary>
	/// Key: "Action.MoreBCOptions"
	/// English String: "More Builders Club Options"
	/// </summary>
	public override string ActionMoreBCOptions => "Autres options du Builders Club";

	/// <summary>
	/// Key: "Action.Redeem"
	/// English String: "Redeem"
	/// </summary>
	public override string ActionRedeem => "Activer";

	/// <summary>
	/// Key: "Heading.AlreadyHaveCredit"
	/// English String: "You have Roblox Credit!"
	/// </summary>
	public override string HeadingAlreadyHaveCredit => "Vous avez des crédits Roblox\u00a0!";

	/// <summary>
	/// Key: "Heading.BuyRobuxUsingRixty"
	/// English String: "Buy Robux using Rixty"
	/// </summary>
	public override string HeadingBuyRobuxUsingRixty => "Acheter des Robux avec des Rixty";

	/// <summary>
	/// Key: "Heading.GetRobuxOrBcWithRixty"
	/// English String: "Get Robux or Builders Club with Rixty"
	/// </summary>
	public override string HeadingGetRobuxOrBcWithRixty => "Obtenir des Robux ou Builders club avec des Rixty";

	/// <summary>
	/// Key: "Heading.GetRobuxWithRixty"
	/// English String: "Get Robux with Rixty"
	/// </summary>
	public override string HeadingGetRobuxWithRixty => "Obtenir des Robux avec Rixty";

	/// <summary>
	/// Key: "Heading.HowToUse"
	/// English String: "How to Use"
	/// </summary>
	public override string HeadingHowToUse => "Fonctionnement";

	/// <summary>
	/// Key: "Heading.PayWithRixty"
	/// English String: "Pay with Rixty"
	/// </summary>
	public override string HeadingPayWithRixty => "Payer avec des Rixty";

	/// <summary>
	/// Key: "Heading.RedeemRixtyCards"
	/// English String: "Redeem Rixty Cards"
	/// </summary>
	public override string HeadingRedeemRixtyCards => "Activer une carte Rixty";

	/// <summary>
	/// Key: "Label.AlreadyHaveAccount"
	/// English String: "I already have a Rixty account"
	/// </summary>
	public override string LabelAlreadyHaveAccount => "J'ai déjà un compte Rixty";

	/// <summary>
	/// Key: "Label.BuildersClubImage"
	/// Alternate text for Builders Club image
	/// English String: "Builders Club"
	/// </summary>
	public override string LabelBuildersClubImage => "Builders Club";

	/// <summary>
	/// Key: "Label.EnterPin"
	/// English String: "Enter PIN:"
	/// </summary>
	public override string LabelEnterPin => "Saisissez le code PIN\u00a0:";

	/// <summary>
	/// Key: "Label.EnterPinImage"
	/// English String: "Enter Your PIN"
	/// </summary>
	public override string LabelEnterPinImage => "Saisissez le code PIN";

	/// <summary>
	/// Key: "Label.FortyFiveDaysBC"
	/// English String: "45 Day Builders Club Extension - $10.00 (Existing BC members only)"
	/// </summary>
	public override string LabelFortyFiveDaysBC => "Prolongation de 45\u00a0jours au Builders Club - 10,00\u00a0$ (réservé aux membres du BC)";

	/// <summary>
	/// Key: "Label.InstructionForCombineCards"
	/// English String: "Combine cards for more Roblox credit."
	/// </summary>
	public override string LabelInstructionForCombineCards => "Combinez les cartes pour augmenter vos crédits Roblox.";

	/// <summary>
	/// Key: "Label.InstructionForEnterPin"
	/// English String: "Enter your Rixty PIN."
	/// </summary>
	public override string LabelInstructionForEnterPin => "Saisissez le code PIN de votre carte Rixty.";

	/// <summary>
	/// Key: "Label.OrUppercase"
	/// English String: "OR"
	/// </summary>
	public override string LabelOrUppercase => "OU";

	/// <summary>
	/// Key: "Label.PinImageText"
	/// English String: "Your PIN is on your receipt"
	/// </summary>
	public override string LabelPinImageText => "Le code PIN est indiqué sur votre reçu";

	/// <summary>
	/// Key: "Label.RixtyLogo"
	/// English String: "Rixty Logo"
	/// </summary>
	public override string LabelRixtyLogo => "Logo Rixty";

	/// <summary>
	/// Key: "Label.Robux"
	/// English String: "Robux"
	/// </summary>
	public override string LabelRobux => "Robux";

	/// <summary>
	/// Key: "Label.ThirtyDaysBC"
	/// English String: "30 Days of Builders Club - $10.00"
	/// </summary>
	public override string LabelThirtyDaysBC => "30\u00a0jours au Builders Club - 10,00\u00a0$";

	/// <summary>
	/// Key: "Label.WhySpendCredit"
	/// English String: "Spend your Roblox credit on Robux and Builders Club!"
	/// </summary>
	public override string LabelWhySpendCredit => "Dépensez vos crédits Roblox pour acheter des Robux et dans le Builders Club\u00a0!";

	/// <summary>
	/// Key: "Label.YourBalance"
	/// English String: "Your Balance:"
	/// </summary>
	public override string LabelYourBalance => "Votre solde\u00a0:";

	/// <summary>
	/// Key: "Message.AnErrorOccurred"
	/// English String: "An error occurred"
	/// </summary>
	public override string MessageAnErrorOccurred => "Une erreur est survenue.";

	/// <summary>
	/// Key: "Message.Failure"
	/// English String: "Failure"
	/// </summary>
	public override string MessageFailure => "Échec";

	/// <summary>
	/// Key: "Message.Loading"
	/// English String: "Loading"
	/// </summary>
	public override string MessageLoading => "Chargement";

	/// <summary>
	/// Key: "Message.PinAlreadyRedeemed"
	/// English String: "PIN already redeemed"
	/// </summary>
	public override string MessagePinAlreadyRedeemed => "Code PIN déjà activé";

	/// <summary>
	/// Key: "Message.RixtyUnavailable"
	/// English String: "Currently unavailable. Please try again later."
	/// </summary>
	public override string MessageRixtyUnavailable => "Indisponible pour le moment, veuillez réessayer plus tard.";

	/// <summary>
	/// Key: "Message.Success"
	/// English String: "Success"
	/// </summary>
	public override string MessageSuccess => "Succès";

	/// <summary>
	/// Key: "Message.SuccessfulRedemption"
	/// English String: "You have successfully redeemed your PIN!"
	/// </summary>
	public override string MessageSuccessfulRedemption => "Votre code PIN a été activé\u00a0!";

	public RixtyPinResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuyNow()
	{
		return "Acheter maintenant";
	}

	protected override string _GetTemplateForActionBuyRobux()
	{
		return "Acheter des Robux";
	}

	protected override string _GetTemplateForActionMoreBCOptions()
	{
		return "Autres options du Builders Club";
	}

	protected override string _GetTemplateForActionRedeem()
	{
		return "Activer";
	}

	/// <summary>
	/// Key: "Description.UseCashForRobux"
	/// English String: "With Rixty, you can use cash and coins to buy Robux and Builders Club.{lineBreak}No credit card? No problem!"
	/// </summary>
	public override string DescriptionUseCashForRobux(string lineBreak)
	{
		return $"Avec Rixty, vous pouvez utiliser de l'argent et des pièces pour acheter des Robux et Builders Club.{lineBreak}Pas de carte de crédit ? Pas de problème !";
	}

	protected override string _GetTemplateForDescriptionUseCashForRobux()
	{
		return "Avec Rixty, vous pouvez utiliser de l'argent et des pièces pour acheter des Robux et Builders Club.{lineBreak}Pas de carte de crédit ? Pas de problème !";
	}

	/// <summary>
	/// Key: "Description.UseCashForRobuxAndPremium"
	/// English String: "With Rixty, you can use cash and coins to buy Robux and Builders Club.{lineBreak}No credit card? No problem!"
	/// </summary>
	public override string DescriptionUseCashForRobuxAndPremium(string lineBreak)
	{
		return $"Avec Rixty, vous pouvez utiliser de l'argent et des pièces pour acheter des Robux et Builders Club.{lineBreak}Pas de carte de crédit\u00a0? Pas de problème\u00a0!";
	}

	protected override string _GetTemplateForDescriptionUseCashForRobuxAndPremium()
	{
		return "Avec Rixty, vous pouvez utiliser de l'argent et des pièces pour acheter des Robux et Builders Club.{lineBreak}Pas de carte de crédit\u00a0? Pas de problème\u00a0!";
	}

	protected override string _GetTemplateForHeadingAlreadyHaveCredit()
	{
		return "Vous avez des crédits Roblox\u00a0!";
	}

	protected override string _GetTemplateForHeadingBuyRobuxUsingRixty()
	{
		return "Acheter des Robux avec des Rixty";
	}

	protected override string _GetTemplateForHeadingGetRobuxOrBcWithRixty()
	{
		return "Obtenir des Robux ou Builders club avec des Rixty";
	}

	protected override string _GetTemplateForHeadingGetRobuxWithRixty()
	{
		return "Obtenir des Robux avec Rixty";
	}

	protected override string _GetTemplateForHeadingHowToUse()
	{
		return "Fonctionnement";
	}

	protected override string _GetTemplateForHeadingPayWithRixty()
	{
		return "Payer avec des Rixty";
	}

	protected override string _GetTemplateForHeadingRedeemRixtyCards()
	{
		return "Activer une carte Rixty";
	}

	protected override string _GetTemplateForLabelAlreadyHaveAccount()
	{
		return "J'ai déjà un compte Rixty";
	}

	/// <summary>
	/// Key: "Label.BuildersClubExtensionExisting"
	/// For example, 45 Day Builders Club Extension - $10.00 (Existing BC members only)
	/// English String: "{numberOfDays} Day Builders Club Extension - {cost} (Existing BC members only)"
	/// </summary>
	public override string LabelBuildersClubExtensionExisting(string numberOfDays, string cost)
	{
		return $"Prolongation de {numberOfDays}\u00a0jours au Builders Club - {cost} (réservé aux membres du BC)";
	}

	protected override string _GetTemplateForLabelBuildersClubExtensionExisting()
	{
		return "Prolongation de {numberOfDays}\u00a0jours au Builders Club - {cost} (réservé aux membres du BC)";
	}

	protected override string _GetTemplateForLabelBuildersClubImage()
	{
		return "Builders Club";
	}

	/// <summary>
	/// Key: "Label.BuildersClubOffer"
	/// New purchase offer of builders club
	/// English String: "{numberOfDays} Days of Builders Club - {cost}"
	/// </summary>
	public override string LabelBuildersClubOffer(string numberOfDays, string cost)
	{
		return $"{numberOfDays}\u00a0jours au Builders Club - {cost}";
	}

	protected override string _GetTemplateForLabelBuildersClubOffer()
	{
		return "{numberOfDays}\u00a0jours au Builders Club - {cost}";
	}

	/// <summary>
	/// Key: "Label.BuyRobuxWithRixty"
	/// For example, "400 Robux for $4.95"
	/// English String: "{robuxAmount} Robux for {currencyAmount}"
	/// </summary>
	public override string LabelBuyRobuxWithRixty(string robuxAmount, string currencyAmount)
	{
		return $"{robuxAmount}\u00a0Robux pour {currencyAmount}";
	}

	protected override string _GetTemplateForLabelBuyRobuxWithRixty()
	{
		return "{robuxAmount}\u00a0Robux pour {currencyAmount}";
	}

	protected override string _GetTemplateForLabelEnterPin()
	{
		return "Saisissez le code PIN\u00a0:";
	}

	protected override string _GetTemplateForLabelEnterPinImage()
	{
		return "Saisissez le code PIN";
	}

	protected override string _GetTemplateForLabelFortyFiveDaysBC()
	{
		return "Prolongation de 45\u00a0jours au Builders Club - 10,00\u00a0$ (réservé aux membres du BC)";
	}

	/// <summary>
	/// Key: "Label.GetPhysicalRixtyCard"
	/// English String: "{startLink}Go to your local store{endLink} and get a Rixty Card."
	/// </summary>
	public override string LabelGetPhysicalRixtyCard(string startLink, string endLink)
	{
		return $"{startLink}Rendez-vous en magasin{endLink} et procurez-vous une carte Rixty.";
	}

	protected override string _GetTemplateForLabelGetPhysicalRixtyCard()
	{
		return "{startLink}Rendez-vous en magasin{endLink} et procurez-vous une carte Rixty.";
	}

	protected override string _GetTemplateForLabelInstructionForCombineCards()
	{
		return "Combinez les cartes pour augmenter vos crédits Roblox.";
	}

	protected override string _GetTemplateForLabelInstructionForEnterPin()
	{
		return "Saisissez le code PIN de votre carte Rixty.";
	}

	protected override string _GetTemplateForLabelOrUppercase()
	{
		return "OU";
	}

	protected override string _GetTemplateForLabelPinImageText()
	{
		return "Le code PIN est indiqué sur votre reçu";
	}

	protected override string _GetTemplateForLabelRixtyLogo()
	{
		return "Logo Rixty";
	}

	protected override string _GetTemplateForLabelRobux()
	{
		return "Robux";
	}

	protected override string _GetTemplateForLabelThirtyDaysBC()
	{
		return "30\u00a0jours au Builders Club - 10,00\u00a0$";
	}

	protected override string _GetTemplateForLabelWhySpendCredit()
	{
		return "Dépensez vos crédits Roblox pour acheter des Robux et dans le Builders Club\u00a0!";
	}

	protected override string _GetTemplateForLabelYourBalance()
	{
		return "Votre solde\u00a0:";
	}

	protected override string _GetTemplateForMessageAnErrorOccurred()
	{
		return "Une erreur est survenue.";
	}

	protected override string _GetTemplateForMessageFailure()
	{
		return "Échec";
	}

	protected override string _GetTemplateForMessageLoading()
	{
		return "Chargement";
	}

	protected override string _GetTemplateForMessagePinAlreadyRedeemed()
	{
		return "Code PIN déjà activé";
	}

	protected override string _GetTemplateForMessageRixtyUnavailable()
	{
		return "Indisponible pour le moment, veuillez réessayer plus tard.";
	}

	protected override string _GetTemplateForMessageSuccess()
	{
		return "Succès";
	}

	protected override string _GetTemplateForMessageSuccessfulRedemption()
	{
		return "Votre code PIN a été activé\u00a0!";
	}
}
