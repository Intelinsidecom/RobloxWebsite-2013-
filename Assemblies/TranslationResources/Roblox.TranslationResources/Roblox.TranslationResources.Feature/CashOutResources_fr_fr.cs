namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides CashOutResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CashOutResources_fr_fr : CashOutResources_en_us, ICashOutResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Annuler";

	/// <summary>
	/// Key: "Action.CashOut"
	/// English String: "Cash Out"
	/// </summary>
	public override string ActionCashOut => "Encaisser";

	/// <summary>
	/// Key: "Action.GetItNow"
	/// button text
	/// English String: "Get it now"
	/// </summary>
	public override string ActionGetItNow => "Obtenir maintenant";

	/// <summary>
	/// Key: "Action.GetObc"
	/// English String: "Get OBC Now"
	/// </summary>
	public override string ActionGetObc => "Obtenir OBC maintenant";

	/// <summary>
	/// Key: "Action.UpgradeMembership"
	/// English String: "Upgrade Membership"
	/// </summary>
	public override string ActionUpgradeMembership => "Mettre à jour l'abonnement";

	/// <summary>
	/// Key: "Action.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "Vérifier";

	/// <summary>
	/// Key: "Action.VerifyEmail"
	/// English String: "Verify Email"
	/// </summary>
	public override string ActionVerifyEmail => "Vérifier l'adresse e-mail";

	/// <summary>
	/// Key: "Action.VerifyNow"
	/// English String: "Verify Now"
	/// </summary>
	public override string ActionVerifyNow => "Vérifier maintenant";

	/// <summary>
	/// Key: "Action.VisitDevEx"
	/// English String: "Visit DevEx"
	/// </summary>
	public override string ActionVisitDevEx => "Visiter DevEx";

	/// <summary>
	/// Key: "Heading.CreateGamesEarnMoney"
	/// section heading
	/// English String: "Developer Exchange: Create games, earn money."
	/// </summary>
	public override string HeadingCreateGamesEarnMoney => "Developer Exchange\u00a0: créez des jeux et gagnez de l'argent";

	/// <summary>
	/// Key: "Heading.DeveloperExchange"
	/// heading
	/// English String: "Developer Exchange"
	/// </summary>
	public override string HeadingDeveloperExchange => "Developer Exchange";

	/// <summary>
	/// Key: "Heading.YourUpdate"
	/// section heading
	/// English String: "Your Update"
	/// </summary>
	public override string HeadingYourUpdate => "Ta mise à jour";

	/// <summary>
	/// Key: "Label.AlmostReady"
	/// English String: "You're almost ready!"
	/// </summary>
	public override string LabelAlmostReady => "Vous êtes presque prêt(e)\u00a0!";

	/// <summary>
	/// Key: "Label.BuilderClubForCash"
	/// English String: "You'll need Outrageous Builder's Club to exchange Robux for cash."
	/// </summary>
	public override string LabelBuilderClubForCash => "Vous avez besoin d'Outrageous Builders Club afin d'échanger des Robux contre de l'argent.";

	/// <summary>
	/// Key: "Label.BuildersCludForCashout"
	/// English String: "You need Outrageous Builders Club to Cash Out."
	/// </summary>
	public override string LabelBuildersCludForCashout => "Vous avez besoin d'Outrageous Builders Club afin de pouvoir effectuer un encaissement.";

	/// <summary>
	/// Key: "Label.CurrentExchangeRate"
	/// English String: "Current Rate"
	/// </summary>
	public override string LabelCurrentExchangeRate => "Taux actuel";

	/// <summary>
	/// Key: "Label.DevExStatusCompleted"
	/// label
	/// English String: "Its status is Completed"
	/// </summary>
	public override string LabelDevExStatusCompleted => "Son statut est\u00a0: Terminée";

	/// <summary>
	/// Key: "Label.DevExStatusPending"
	/// label
	/// English String: "Its status is Pending"
	/// </summary>
	public override string LabelDevExStatusPending => "Son statut est\u00a0: En attente";

	/// <summary>
	/// Key: "Label.DevExStatusRejected"
	/// label
	/// English String: "Its status is Rejected"
	/// </summary>
	public override string LabelDevExStatusRejected => "Son statut est\u00a0: Rejetée";

	/// <summary>
	/// Key: "Label.NeedVerifiedEmail"
	/// English String: "You need a verified email address to use DevEx."
	/// </summary>
	public override string LabelNeedVerifiedEmail => "Vous devez avoir une adresse e-mail vérifiée afin d'utiliser DevEx.";

	/// <summary>
	/// Key: "Label.NotEligible"
	/// English String: "You are not eligible currently."
	/// </summary>
	public override string LabelNotEligible => "Vous n'êtes pas admissible pour le moment.";

	/// <summary>
	/// Key: "Label.NotEnoughRobuxForCashout"
	/// English String: "You don't have enough Robux to Cash Out."
	/// </summary>
	public override string LabelNotEnoughRobuxForCashout => "Vous n'avez pas assez de Robux pour effectuer un encaissement.";

	/// <summary>
	/// Key: "Label.PremiumForCash"
	/// English String: "You'll need Roblox Premium to exchange Robux for cash."
	/// </summary>
	public override string LabelPremiumForCash => "Tu as besoin de Roblox Premium pour échanger tes Robux contre de l'argent réel.";

	/// <summary>
	/// Key: "Label.Robux"
	/// English String: "Robux"
	/// </summary>
	public override string LabelRobux => "Robux";

	/// <summary>
	/// Key: "Label.TradingRobux"
	/// English String: "You're on your way to trading Robux for cash!"
	/// </summary>
	public override string LabelTradingRobux => "Vous serez bientôt en mesure d'échanger des Robux contre de l'argent\u00a0!";

	/// <summary>
	/// Key: "Label.TradingRobuxCash"
	/// English String: "You're almost there! You almost qualify to trade your Robux for cash!"
	/// </summary>
	public override string LabelTradingRobuxCash => "Vous y êtes presque\u00a0! Vous serez bientôt admissible pour échanger des Robux contre de l'argent\u00a0!";

	/// <summary>
	/// Key: "Label.VerifiedEmailForCashout"
	/// English String: "You must verify your email before you can cash out."
	/// </summary>
	public override string LabelVerifiedEmailForCashout => "Tu dois vérifier ton adresse e-mail avant de pouvoir effectuer un encaissement.";

	public CashOutResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Annuler";
	}

	protected override string _GetTemplateForActionCashOut()
	{
		return "Encaisser";
	}

	protected override string _GetTemplateForActionGetItNow()
	{
		return "Obtenir maintenant";
	}

	protected override string _GetTemplateForActionGetObc()
	{
		return "Obtenir OBC maintenant";
	}

	protected override string _GetTemplateForActionUpgradeMembership()
	{
		return "Mettre à jour l'abonnement";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "Vérifier";
	}

	protected override string _GetTemplateForActionVerifyEmail()
	{
		return "Vérifier l'adresse e-mail";
	}

	protected override string _GetTemplateForActionVerifyNow()
	{
		return "Vérifier maintenant";
	}

	protected override string _GetTemplateForActionVisitDevEx()
	{
		return "Visiter DevEx";
	}

	/// <summary>
	/// Key: "Description.DevExRequestCompleted"
	/// description
	/// English String: "Your DevEx request has been completed. Check your {startMoneyLink}Money{endMoneyLink} page for details."
	/// </summary>
	public override string DescriptionDevExRequestCompleted(string startMoneyLink, string endMoneyLink)
	{
		return $"Ta requête DevEx a été terminée. Consulte ta page {startMoneyLink}Argent{endMoneyLink} pour les détails.";
	}

	protected override string _GetTemplateForDescriptionDevExRequestCompleted()
	{
		return "Ta requête DevEx a été terminée. Consulte ta page {startMoneyLink}Argent{endMoneyLink} pour les détails.";
	}

	/// <summary>
	/// Key: "Description.DevExRequestSubmittedOn"
	/// description
	/// English String: "Your DevEx request was submitted on: {requestDate}"
	/// </summary>
	public override string DescriptionDevExRequestSubmittedOn(string requestDate)
	{
		return $"Ta requête DevEx a été soumise le\u00a0: {requestDate}";
	}

	protected override string _GetTemplateForDescriptionDevExRequestSubmittedOn()
	{
		return "Ta requête DevEx a été soumise le\u00a0: {requestDate}";
	}

	/// <summary>
	/// Key: "Description.DevExTermsDisclaimer"
	/// description
	/// English String: "* Old Robux may be cashed out at a different rate. Please click {helpLinkStart}here{helpLinkEnd} for more information."
	/// </summary>
	public override string DescriptionDevExTermsDisclaimer(string helpLinkStart, string helpLinkEnd)
	{
		return $"* Les anciens Robux peuvent être encaissés à un taux différent. Cliquez {helpLinkStart}ici{helpLinkEnd} pour plus d'informations.";
	}

	protected override string _GetTemplateForDescriptionDevExTermsDisclaimer()
	{
		return "* Les anciens Robux peuvent être encaissés à un taux différent. Cliquez {helpLinkStart}ici{helpLinkEnd} pour plus d'informations.";
	}

	/// <summary>
	/// Key: "Description.LearnMoreAboutDevEx"
	/// descption
	/// English String: "{startDevExLink}Learn more{endDevExLink} about our Developer Exchange."
	/// </summary>
	public override string DescriptionLearnMoreAboutDevEx(string startDevExLink, string endDevExLink)
	{
		return $"{startDevExLink}Apprenez-en plus{endDevExLink} à propos du programme Developer Exchange.";
	}

	protected override string _GetTemplateForDescriptionLearnMoreAboutDevEx()
	{
		return "{startDevExLink}Apprenez-en plus{endDevExLink} à propos du programme Developer Exchange.";
	}

	/// <summary>
	/// Key: "Description.VisitDevEx"
	/// description
	/// English String: "{startDevExLink}Visit{endDevExLink} our Developer Exchange."
	/// </summary>
	public override string DescriptionVisitDevEx(string startDevExLink, string endDevExLink)
	{
		return $"{startDevExLink}Découvrez{endDevExLink} le programme Developer Exchange.";
	}

	protected override string _GetTemplateForDescriptionVisitDevEx()
	{
		return "{startDevExLink}Découvrez{endDevExLink} le programme Developer Exchange.";
	}

	protected override string _GetTemplateForHeadingCreateGamesEarnMoney()
	{
		return "Developer Exchange\u00a0: créez des jeux et gagnez de l'argent";
	}

	protected override string _GetTemplateForHeadingDeveloperExchange()
	{
		return "Developer Exchange";
	}

	protected override string _GetTemplateForHeadingYourUpdate()
	{
		return "Ta mise à jour";
	}

	protected override string _GetTemplateForLabelAlmostReady()
	{
		return "Vous êtes presque prêt(e)\u00a0!";
	}

	/// <summary>
	/// Key: "Label.AmountRobux"
	/// label
	/// English String: "{amount} Robux"
	/// </summary>
	public override string LabelAmountRobux(string amount)
	{
		return $"{amount}\u00a0Robux";
	}

	protected override string _GetTemplateForLabelAmountRobux()
	{
		return "{amount}\u00a0Robux";
	}

	protected override string _GetTemplateForLabelBuilderClubForCash()
	{
		return "Vous avez besoin d'Outrageous Builders Club afin d'échanger des Robux contre de l'argent.";
	}

	protected override string _GetTemplateForLabelBuildersCludForCashout()
	{
		return "Vous avez besoin d'Outrageous Builders Club afin de pouvoir effectuer un encaissement.";
	}

	protected override string _GetTemplateForLabelCurrentExchangeRate()
	{
		return "Taux actuel";
	}

	/// <summary>
	/// Key: "Label.CurrentRateCaption"
	/// English String: "Current rate applies to all amounts greater than {minimumDevexRobuxAmount} Robux"
	/// </summary>
	public override string LabelCurrentRateCaption(string minimumDevexRobuxAmount)
	{
		return $"Le taux actuel s'applique à tous les montants supérieurs à {minimumDevexRobuxAmount}\u00a0Robux.";
	}

	protected override string _GetTemplateForLabelCurrentRateCaption()
	{
		return "Le taux actuel s'applique à tous les montants supérieurs à {minimumDevexRobuxAmount}\u00a0Robux.";
	}

	protected override string _GetTemplateForLabelDevExStatusCompleted()
	{
		return "Son statut est\u00a0: Terminée";
	}

	protected override string _GetTemplateForLabelDevExStatusPending()
	{
		return "Son statut est\u00a0: En attente";
	}

	protected override string _GetTemplateForLabelDevExStatusRejected()
	{
		return "Son statut est\u00a0: Rejetée";
	}

	protected override string _GetTemplateForLabelNeedVerifiedEmail()
	{
		return "Vous devez avoir une adresse e-mail vérifiée afin d'utiliser DevEx.";
	}

	protected override string _GetTemplateForLabelNotEligible()
	{
		return "Vous n'êtes pas admissible pour le moment.";
	}

	protected override string _GetTemplateForLabelNotEnoughRobuxForCashout()
	{
		return "Vous n'avez pas assez de Robux pour effectuer un encaissement.";
	}

	protected override string _GetTemplateForLabelPremiumForCash()
	{
		return "Tu as besoin de Roblox Premium pour échanger tes Robux contre de l'argent réel.";
	}

	protected override string _GetTemplateForLabelRobux()
	{
		return "Robux";
	}

	/// <summary>
	/// Key: "Label.RobuxToUSD"
	/// label
	/// English String: "{robuxAmount} Robux for {usdAmount}"
	/// </summary>
	public override string LabelRobuxToUSD(string robuxAmount, string usdAmount)
	{
		return $"{robuxAmount}\u00a0Robux pour {usdAmount}";
	}

	protected override string _GetTemplateForLabelRobuxToUSD()
	{
		return "{robuxAmount}\u00a0Robux pour {usdAmount}";
	}

	protected override string _GetTemplateForLabelTradingRobux()
	{
		return "Vous serez bientôt en mesure d'échanger des Robux contre de l'argent\u00a0!";
	}

	protected override string _GetTemplateForLabelTradingRobuxCash()
	{
		return "Vous y êtes presque\u00a0! Vous serez bientôt admissible pour échanger des Robux contre de l'argent\u00a0!";
	}

	protected override string _GetTemplateForLabelVerifiedEmailForCashout()
	{
		return "Tu dois vérifier ton adresse e-mail avant de pouvoir effectuer un encaissement.";
	}
}
