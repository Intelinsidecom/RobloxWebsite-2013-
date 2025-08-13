namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PremiumResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PremiumResources_fr_fr : PremiumResources_en_us, IPremiumResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Bought"
	/// English String: "Bought"
	/// </summary>
	public override string ActionBought => "Achat effectué";

	/// <summary>
	/// Key: "Action.BuyNow"
	/// English String: "Buy Now!"
	/// </summary>
	public override string ActionBuyNow => "Achetez\u00a0!";

	/// <summary>
	/// Key: "Action.BuyRobux"
	/// English String: "Buy Robux"
	/// </summary>
	public override string ActionBuyRobux => "Acheter des Robux";

	/// <summary>
	/// Key: "Description.GetMoreRobux"
	/// English String: "Get 10% more when purchasing Robux"
	/// </summary>
	public override string DescriptionGetMoreRobux => "Obtenez 10\u00a0% de Robux en plus pour le même prix.";

	/// <summary>
	/// Key: "Description.RobloxPremiumSubtitle"
	/// English String: "Joining Roblox Premium gets you a monthly Robux allowance and a 10% bonus when buying Robux. You will also get access to Roblox's economy features including buying, selling, and trading items, as well as increased revenue share on all sales in your games."
	/// </summary>
	public override string DescriptionRobloxPremiumSubtitle => "Rejoindre Roblox Premium te donne des Robux tous les mois et un bonus de 10% lorsque tu achètes des Robux. Tu auras également accès aux fonctionnalitées économiques de Roblox, incluant l'achat, la vent et l'échange d'objets. Ainsi qu'une part de revenu plus élevée pour toutes les ventes faites dans tes jeux.";

	/// <summary>
	/// Key: "Description.SellMoreItems"
	/// English String: "Resell items and get more Robux selling your creations"
	/// </summary>
	public override string DescriptionSellMoreItems => "Revendez des objets et obtenez plus de Robux grâce à vos créations.";

	/// <summary>
	/// Key: "Description.Trade"
	/// English String: "Trade items with other Premium members"
	/// </summary>
	public override string DescriptionTrade => "Échangez des objets avec les autres membres premium.";

	/// <summary>
	/// Key: "Heading.BuyRobux"
	/// The title of Robux page
	/// English String: "Buy Robux"
	/// </summary>
	public override string HeadingBuyRobux => "Acheter des Robux";

	/// <summary>
	/// Key: "Heading.ConfirmCancellation"
	/// English String: "Confirm Cancellation"
	/// </summary>
	public override string HeadingConfirmCancellation => "Confirmer l'annulation";

	/// <summary>
	/// Key: "Heading.EvenMoreFeatures"
	/// English String: "Even more Features"
	/// </summary>
	public override string HeadingEvenMoreFeatures => "Encore plus de fonctionnalités";

	/// <summary>
	/// Key: "Heading.GeneralError"
	/// English String: "Error"
	/// </summary>
	public override string HeadingGeneralError => "Erreur";

	/// <summary>
	/// Key: "Heading.PremiumRobuxDiscounts"
	/// English String: "As a Premium user, you get discounts on Robux!"
	/// </summary>
	public override string HeadingPremiumRobuxDiscounts => "En tant qu'utilisateur premium, vous bénéficiez de réductions sur les Robux\u00a0!";

	/// <summary>
	/// Key: "Heading.RobloxPremium"
	/// The title of Subscription page
	/// English String: "Roblox Premium"
	/// </summary>
	public override string HeadingRobloxPremium => "Roblox Premium";

	/// <summary>
	/// Key: "Heading.ServerError"
	/// English String: "Server Error"
	/// </summary>
	public override string HeadingServerError => "Erreur serveur";

	/// <summary>
	/// Key: "Heading.SubscriptionUnavailable"
	/// English String: "Subscription Unavailable"
	/// </summary>
	public override string HeadingSubscriptionUnavailable => "Abonnement indisponible";

	/// <summary>
	/// Key: "Heading.SwitchPlanModal"
	/// English String: "Confirm Subscription Update"
	/// </summary>
	public override string HeadingSwitchPlanModal => "Confirmer la mise à jour de l'abonnement";

	/// <summary>
	/// Key: "Heading.UnableToFindBc"
	/// English String: "Cannot find Builders Club"
	/// </summary>
	public override string HeadingUnableToFindBc => "Builders Club introuvable";

	/// <summary>
	/// Key: "Heading.UpgradeToPremium"
	/// English String: "Upgrade to Roblox Premium"
	/// </summary>
	public override string HeadingUpgradeToPremium => "Abonne-toi à Roblox Premium";

	/// <summary>
	/// Key: "Heading.UpgradeUnavailable"
	/// English String: "Upgrade Unavailable"
	/// </summary>
	public override string HeadingUpgradeUnavailable => "Mise à jour indisponible";

	/// <summary>
	/// Key: "Label.10PercentMoreRobux"
	/// Part 1 of a two part label (Label.SinceYouSubscribed)
	/// English String: "You'll get 10% more Robux"
	/// </summary>
	public override string Label10PercentMoreRobux => "Vous obtiendrez 10\u00a0% de Robux en plus";

	/// <summary>
	/// Key: "Label.AndGetMore"
	/// English String: "and get more!"
	/// </summary>
	public override string LabelAndGetMore => "et bien plus\u00a0!";

	/// <summary>
	/// Key: "Label.BecauseYouSubscribed"
	/// English String: "Because you Subscribed!"
	/// </summary>
	public override string LabelBecauseYouSubscribed => "En raison de votre abonnement\u00a0!";

	/// <summary>
	/// Key: "Label.BuyOnce"
	/// English String: "Buy Once"
	/// </summary>
	public override string LabelBuyOnce => "Acheter une fois";

	/// <summary>
	/// Key: "Label.BuyRobux"
	/// English String: "Buy Robux"
	/// </summary>
	public override string LabelBuyRobux => "Acheter des Robux";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "Annuler";

	/// <summary>
	/// Key: "Label.Confirm"
	/// English String: "Confirm"
	/// </summary>
	public override string LabelConfirm => "Confirmer";

	/// <summary>
	/// Key: "Label.CurrentPlan"
	/// English String: "Your Current Plan"
	/// </summary>
	public override string LabelCurrentPlan => "Votre plan actuel";

	/// <summary>
	/// Key: "Label.Get10PercentOffRobux"
	/// English String: "Get 10% off Robux"
	/// </summary>
	public override string LabelGet10PercentOffRobux => "Obtenez 10\u00a0% de réduction sur les Robux";

	/// <summary>
	/// Key: "Label.GetMoreRobux"
	/// English String: "Get More Robux"
	/// </summary>
	public override string LabelGetMoreRobux => "Obtenir plus de Robux";

	/// <summary>
	/// Key: "Label.MembershipManagementRecurring"
	/// English String: "To manage your Premium subscription, please go to your Billing settings using a browser."
	/// </summary>
	public override string LabelMembershipManagementRecurring => "Pour gérer ton abonnement Premium, utilise les paramètres de facturation depuis un navigateur.";

	/// <summary>
	/// Key: "Label.No"
	/// English String: "No"
	/// </summary>
	public override string LabelNo => "Non";

	/// <summary>
	/// Key: "Label.PremiumClub2200"
	/// English String: "Roblox Premium 2200"
	/// </summary>
	public override string LabelPremiumClub2200 => "Roblox Premium 2200";

	/// <summary>
	/// Key: "Label.RobloxPremium"
	/// English String: "Roblox Premium"
	/// </summary>
	public override string LabelRobloxPremium => "Roblox Premium";

	/// <summary>
	/// Key: "Label.RobloxPremium1000"
	/// English String: "Roblox Premium 1000"
	/// </summary>
	public override string LabelRobloxPremium1000 => "Roblox Premium 1000";

	/// <summary>
	/// Key: "Label.RobloxPremium1000OneMonth"
	/// English String: "Roblox Premium 1000 One Month"
	/// </summary>
	public override string LabelRobloxPremium1000OneMonth => "Roblox Premium 1000 Un mois";

	/// <summary>
	/// Key: "Label.RobloxPremium2200"
	/// English String: "Roblox Premium 2200"
	/// </summary>
	public override string LabelRobloxPremium2200 => "Roblox Premium 2200";

	/// <summary>
	/// Key: "Label.RobloxPremium2200OneMonth"
	/// English String: "Roblox Premium 2200 One Month"
	/// </summary>
	public override string LabelRobloxPremium2200OneMonth => "Roblox Premium 2200 Un mois";

	/// <summary>
	/// Key: "Label.RobloxPremium450"
	/// English String: "Roblox Premium 450"
	/// </summary>
	public override string LabelRobloxPremium450 => "Roblox Premium 450";

	/// <summary>
	/// Key: "Label.RobloxPremium450OneMonth"
	/// English String: "Roblox Premium 450 One Month"
	/// </summary>
	public override string LabelRobloxPremium450OneMonth => "Roblox Premium 450 Un mois";

	/// <summary>
	/// Key: "Label.SellMore"
	/// English String: "Sell More"
	/// </summary>
	public override string LabelSellMore => "Vendre plus";

	/// <summary>
	/// Key: "Label.SinceYouSubscribed"
	/// Part 2 of a 2 part label
	/// English String: "since you subscribed"
	/// </summary>
	public override string LabelSinceYouSubscribed => "grâce à votre abonnement";

	/// <summary>
	/// Key: "Label.Subscribe"
	/// English String: "Subscribe"
	/// </summary>
	public override string LabelSubscribe => "S'inscrire";

	/// <summary>
	/// Key: "Label.Trade"
	/// English String: "Trade"
	/// </summary>
	public override string LabelTrade => "Échange";

	/// <summary>
	/// Key: "Label.ValuePacks"
	/// English String: "Value Packs"
	/// </summary>
	public override string LabelValuePacks => "Offre avantageuse";

	/// <summary>
	/// Key: "Label.WantMoreRobux"
	/// English String: "Want more Robux?"
	/// </summary>
	public override string LabelWantMoreRobux => "Vous voulez plus de Robux\u00a0?";

	/// <summary>
	/// Key: "Label.Yes"
	/// English String: "Yes"
	/// </summary>
	public override string LabelYes => "Oui";

	/// <summary>
	/// Key: "Message.GeneralError"
	/// English String: "An error occurred while updating your subscription. Please try again later."
	/// </summary>
	public override string MessageGeneralError => "Une erreur est survenue lors de la mise à jour de votre abonnement. Veuillez réessayer plus tard.";

	/// <summary>
	/// Key: "Message.NoDataError"
	/// English String: "No subscriptions information."
	/// </summary>
	public override string MessageNoDataError => "Aucune information sur l'abonnement.";

	/// <summary>
	/// Key: "Message.ServerError"
	/// English String: "A server error occurred while updating your subscription. Please try again later."
	/// </summary>
	public override string MessageServerError => "Une erreur serveur est survenue lors de la mise à jour de votre abonnement. Veuillez réessayer plus tard.";

	/// <summary>
	/// Key: "Message.UnableToFindBc"
	/// English String: "Cannot find Builders Club information for this user."
	/// </summary>
	public override string MessageUnableToFindBc => "Information du Builders Club introuvable pour cet utilisateur.";

	/// <summary>
	/// Key: "Message.UpgradeUnavailableModal"
	/// English String: "We are sorry, we cannot change your subscription because there is currently no package equivalent to Lifetime Builders Club."
	/// </summary>
	public override string MessageUpgradeUnavailableModal => "Nous ne pouvons malheureusement pas modifier votre abonnement car il n'existe actuellement aucune option équivalente au Builders Club à vie.";

	/// <summary>
	/// Key: "SwitchPlanTitle"
	/// Wrong string. Do translate this.
	/// English String: "Confirm Subscription Update"
	/// </summary>
	public override string SwitchPlanTitle => "Confirmer la mise à jour de l'abonnement";

	public PremiumResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBought()
	{
		return "Achat effectué";
	}

	protected override string _GetTemplateForActionBuyNow()
	{
		return "Achetez\u00a0!";
	}

	protected override string _GetTemplateForActionBuyRobux()
	{
		return "Acheter des Robux";
	}

	/// <summary>
	/// Key: "Description.BuyMoreRobuxSubtitle"
	/// English String: "Buy Robux to purchase upgrades for your avatar or special abilities in games.{lineBreak} Subscribe to Roblox Premium and get even more Robux each month, as well as bonus features. Premium is billed every month until cancelled. {learnMoreLinkStart}Learn more here.{learnMoreLinkEnd}"
	/// </summary>
	public override string DescriptionBuyMoreRobuxSubtitle(string lineBreak, string learnMoreLinkStart, string learnMoreLinkEnd)
	{
		return $"Achetez des Robux pour acheter des améliorations d'avatar ou des capacités spéciales dans vos jeux.{lineBreak} Abonnez-vous à Roblox Premium pour obtenir plus de Robux chaque mois, en plus de fonctionnalités exclusives. Roblox Premium vous sera facturé chaque mois jusqu'à son annulation. {learnMoreLinkStart}En savoir plus{learnMoreLinkEnd}.";
	}

	protected override string _GetTemplateForDescriptionBuyMoreRobuxSubtitle()
	{
		return "Achetez des Robux pour acheter des améliorations d'avatar ou des capacités spéciales dans vos jeux.{lineBreak} Abonnez-vous à Roblox Premium pour obtenir plus de Robux chaque mois, en plus de fonctionnalités exclusives. Roblox Premium vous sera facturé chaque mois jusqu'à son annulation. {learnMoreLinkStart}En savoir plus{learnMoreLinkEnd}.";
	}

	/// <summary>
	/// Key: "Description.BuyRobuxSubtitle"
	/// English String: "Get Robux to purchase upgrades for your avatar or buy special abilities in games. For more information on how to earn Robux, visit our {helpLinkStart}Robux Help page{helpLinkEnd}.{paragraphBreaker}Purchase Roblox Premium to get more Robux for the same price. Roblox Premium is billed every month until cancelled. {learnMoreLinkStart}Learn more here{learnMoreLinkEnd}."
	/// </summary>
	public override string DescriptionBuyRobuxSubtitle(string helpLinkStart, string helpLinkEnd, string paragraphBreaker, string learnMoreLinkStart, string learnMoreLinkEnd)
	{
		return $"Obtenez des Robux pour acheter des améliorations d'avatar ou des capacités spéciales dans vos jeux. Pour plus d'informations sur comment gagner des Robux, rendez-vous sur la {helpLinkStart}page d'aide Robux{helpLinkEnd}.{paragraphBreaker}Achetez Roblox Premium pour obtenir plus de Robux par achat. Roblox Premium vous sera facturé chaque mois jusqu'à son annulation. {learnMoreLinkStart}En savoir plus\u00a0: {learnMoreLinkEnd}.";
	}

	protected override string _GetTemplateForDescriptionBuyRobuxSubtitle()
	{
		return "Obtenez des Robux pour acheter des améliorations d'avatar ou des capacités spéciales dans vos jeux. Pour plus d'informations sur comment gagner des Robux, rendez-vous sur la {helpLinkStart}page d'aide Robux{helpLinkEnd}.{paragraphBreaker}Achetez Roblox Premium pour obtenir plus de Robux par achat. Roblox Premium vous sera facturé chaque mois jusqu'à son annulation. {learnMoreLinkStart}En savoir plus\u00a0: {learnMoreLinkEnd}.";
	}

	protected override string _GetTemplateForDescriptionGetMoreRobux()
	{
		return "Obtenez 10\u00a0% de Robux en plus pour le même prix.";
	}

	/// <summary>
	/// Key: "Description.IosMonthlySubscriptionDisclosure"
	/// English String: "Roblox Premium is a monthly subscription that costs {costPrice}. Payment will be charged to the iTunes Account at confirmation of purchase. Roblox Premium will automatically renew unless auto-renewal is turned off at least 24-hours before the end of the current period. Your account will be charged {renewalPrice} for renewal within 24-hours prior to the end of the current period. Subscriptions may be managed and auto-renewal may be turned off by going to your Account Settings. If you're under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted."
	/// </summary>
	public override string DescriptionIosMonthlySubscriptionDisclosure(string costPrice, string renewalPrice)
	{
		return $"Roblox Premium est un abonnement mensuel qui coûte {costPrice}. Ce montant sera facturé au compte iTunes dès la confirmation de l'achat. Roblox Premium se renouvellera automatiquement, à moins que cette option soit désactivée au moins 24\u00a0heures avant la fin de la période actuelle. Un montant de {renewalPrice} sera facturé à votre compte pour le renouvellement dans les 24\u00a0heures précédant la fin de la période actuelle. Il est possible de gérer les abonnements et de désactiver le renouvellement automatique dans les paramètres de votre compte. Si vous avez moins de 18\u00a0ans, vérifiez d'avoir l'autorisation de vos parents ou de votre tuteur légal avant d'effectuer un achat. Tout achat non autorisé peut entraîner la suppression de votre compte.";
	}

	protected override string _GetTemplateForDescriptionIosMonthlySubscriptionDisclosure()
	{
		return "Roblox Premium est un abonnement mensuel qui coûte {costPrice}. Ce montant sera facturé au compte iTunes dès la confirmation de l'achat. Roblox Premium se renouvellera automatiquement, à moins que cette option soit désactivée au moins 24\u00a0heures avant la fin de la période actuelle. Un montant de {renewalPrice} sera facturé à votre compte pour le renouvellement dans les 24\u00a0heures précédant la fin de la période actuelle. Il est possible de gérer les abonnements et de désactiver le renouvellement automatique dans les paramètres de votre compte. Si vous avez moins de 18\u00a0ans, vérifiez d'avoir l'autorisation de vos parents ou de votre tuteur légal avant d'effectuer un achat. Tout achat non autorisé peut entraîner la suppression de votre compte.";
	}

	/// <summary>
	/// Key: "Description.IosSubscriptionDisclosure"
	/// English String: "Roblox Premium is a {durationType} subscription that costs {costPrice}. Payment will be charged to the iTunes Account at confirmation of purchase. Roblox Premium will automatically renew unless auto-renewal is turned off at least 24-hours before the end of the current period. Your account will be charged {renewalPrice} for renewal within 24-hours prior to the end of the current period. Subscriptions may be managed and auto-renewal may be turned off by going to your Account Settings."
	/// </summary>
	public override string DescriptionIosSubscriptionDisclosure(string durationType, string costPrice, string renewalPrice)
	{
		return $"Roblox Premium est un abonnement de {durationType} qui coûte {costPrice}. Ce montant sera facturé au compte iTunes dès la confirmation de l'achat. Roblox Premium se renouvellera automatiquement, à moins que cette option soit désactivée au moins 24\u00a0heures avant la fin de la période actuelle. Un montant de {renewalPrice} sera facturé à votre compte pour le renouvellement dans les 24\u00a0heures précédant la fin de la période actuelle. Il est possible de gérer les abonnements et de désactiver le renouvellement automatique dans les paramètres de votre compte.";
	}

	protected override string _GetTemplateForDescriptionIosSubscriptionDisclosure()
	{
		return "Roblox Premium est un abonnement de {durationType} qui coûte {costPrice}. Ce montant sera facturé au compte iTunes dès la confirmation de l'achat. Roblox Premium se renouvellera automatiquement, à moins que cette option soit désactivée au moins 24\u00a0heures avant la fin de la période actuelle. Un montant de {renewalPrice} sera facturé à votre compte pour le renouvellement dans les 24\u00a0heures précédant la fin de la période actuelle. Il est possible de gérer les abonnements et de désactiver le renouvellement automatique dans les paramètres de votre compte.";
	}

	/// <summary>
	/// Key: "Description.legalDisclosuresPremiumRobuxPage"
	/// English String: "When you buy Robux, you receive only a limited, non-refundable, non-transferable, revocable license to use Robux, which have no value in real currency. See {termsLinkStart}Terms of Use{termsLinkEnd} for other limitations.  If you're under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted."
	/// </summary>
	public override string DescriptionlegalDisclosuresPremiumRobuxPage(string termsLinkStart, string termsLinkEnd)
	{
		return $"En achetant des Robux, vous recevez une autorisation limitée, non remboursable, non transférable et révocable d'utiliser des Robux qui n'ont aucune valeur en tant que monnaie réelle. Consultez les {termsLinkStart}Conditions d'utilisation{termsLinkEnd} pour plus de détails. Si vous avez moins de 18\u00a0ans, vérifiez d'avoir l'autorisation de vos parents ou de votre tuteur légal avant d'effectuer un achat. Tout achat non autorisé peut entraîner la suppression de votre compte.";
	}

	protected override string _GetTemplateForDescriptionlegalDisclosuresPremiumRobuxPage()
	{
		return "En achetant des Robux, vous recevez une autorisation limitée, non remboursable, non transférable et révocable d'utiliser des Robux qui n'ont aucune valeur en tant que monnaie réelle. Consultez les {termsLinkStart}Conditions d'utilisation{termsLinkEnd} pour plus de détails. Si vous avez moins de 18\u00a0ans, vérifiez d'avoir l'autorisation de vos parents ou de votre tuteur légal avant d'effectuer un achat. Tout achat non autorisé peut entraîner la suppression de votre compte.";
	}

	/// <summary>
	/// Key: "Description.legalDisclosuresPremiumUpgradePage"
	/// English String: "If you are under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted.  By clicking “Submit Order” (1) you authorize us to charge your account every month until you cancel the subscription, and (2) you represent that you understand and agree to the {termsLinkStart}Terms of Use{termsLinkEnd} and {privacyLinkStart}Privacy Policy{privatyLinkEnd}. You can cancel at any time by clicking “Cancel membership” on the {billingLinkStart}billing tab{billingLinkEnd}  of the setting page. If you cancel, you will still be charged for the current billing period."
	/// </summary>
	public override string DescriptionlegalDisclosuresPremiumUpgradePage(string termsLinkStart, string termsLinkEnd, string privacyLinkStart, string privatyLinkEnd, string billingLinkStart, string billingLinkEnd)
	{
		return $"Si vous avez moins de 18\u00a0ans, vérifiez d'avoir l'autorisation de vos parents ou de votre tuteur légal avant d'effectuer un achat. Tout achat non autorisé peut entraîner la suppression de votre compte. En cliquant sur «\u00a0Envoyer la commande\u00a0», (1) vous nous autorisez à facturer votre compte tous les mois jusqu'à annulation de l'abonnement, et (2) vous certifiez avoir lu et accepté les {termsLinkStart}Conditions d'utilisation{termsLinkEnd} et la {privacyLinkStart}Politique de confidentialité{privatyLinkEnd}. Vous pouvez annuler l'abonnement en cliquant sur le bouton «\u00a0Annulation d'abonnement\u00a0» situé dans l'{billingLinkStart}onglet de facturation{billingLinkEnd} de la page des paramètres. En cas d'annulation, la période en cours vous sera tout de même facturée.";
	}

	protected override string _GetTemplateForDescriptionlegalDisclosuresPremiumUpgradePage()
	{
		return "Si vous avez moins de 18\u00a0ans, vérifiez d'avoir l'autorisation de vos parents ou de votre tuteur légal avant d'effectuer un achat. Tout achat non autorisé peut entraîner la suppression de votre compte. En cliquant sur «\u00a0Envoyer la commande\u00a0», (1) vous nous autorisez à facturer votre compte tous les mois jusqu'à annulation de l'abonnement, et (2) vous certifiez avoir lu et accepté les {termsLinkStart}Conditions d'utilisation{termsLinkEnd} et la {privacyLinkStart}Politique de confidentialité{privatyLinkEnd}. Vous pouvez annuler l'abonnement en cliquant sur le bouton «\u00a0Annulation d'abonnement\u00a0» situé dans l'{billingLinkStart}onglet de facturation{billingLinkEnd} de la page des paramètres. En cas d'annulation, la période en cours vous sera tout de même facturée.";
	}

	/// <summary>
	/// Key: "Description.PremiumSubscriptionDisclosure"
	/// Duplicated
	/// English String: "If you're under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted.  By clicking “Submit Order” (1) you authorize us to charge your account every month until you cancel the subscription, and (2) you represent that you understand and agree to the {teamOfUseLinkStart}Terms of Use{teamOfUseLinkEnd} and {privacyPolicyLinkStart}Privacy Policy{privacyPolicyLinkEnd}. You can cancel at any time by clicking “Cancel membership” on the {billingTabLinkStart}billing tab{billingTabLinkEnd} of the setting page. If you cancel, you will still be charged for the current billing period."
	/// </summary>
	public override string DescriptionPremiumSubscriptionDisclosure(string teamOfUseLinkStart, string teamOfUseLinkEnd, string privacyPolicyLinkStart, string privacyPolicyLinkEnd, string billingTabLinkStart, string billingTabLinkEnd)
	{
		return $"Si vous avez moins de 18\u00a0ans, vérifiez d'avoir l'autorisation de vos parents ou de votre tuteur légal avant d'effectuer un achat. Tout achat non autorisé peut entraîner la suppression de votre compte. En cliquant sur «\u00a0Envoyer la commande\u00a0», (1) vous nous autorisez à facturer votre compte tous les mois jusqu'à annulation de l'abonnement, et (2) vous certifiez avoir lu et accepté les {teamOfUseLinkStart}Conditions d'utilisation{teamOfUseLinkEnd} et la {privacyPolicyLinkStart}Politique de confidentialité{privacyPolicyLinkEnd}. Vous pouvez annuler l'abonnement en cliquant sur le bouton «\u00a0Annulation d'abonnement\u00a0» situé dans l'{billingTabLinkStart}onglet de facturation{billingTabLinkEnd} de la page des paramètres. En cas d'annulation, la période en cours vous sera tout de même facturée.";
	}

	protected override string _GetTemplateForDescriptionPremiumSubscriptionDisclosure()
	{
		return "Si vous avez moins de 18\u00a0ans, vérifiez d'avoir l'autorisation de vos parents ou de votre tuteur légal avant d'effectuer un achat. Tout achat non autorisé peut entraîner la suppression de votre compte. En cliquant sur «\u00a0Envoyer la commande\u00a0», (1) vous nous autorisez à facturer votre compte tous les mois jusqu'à annulation de l'abonnement, et (2) vous certifiez avoir lu et accepté les {teamOfUseLinkStart}Conditions d'utilisation{teamOfUseLinkEnd} et la {privacyPolicyLinkStart}Politique de confidentialité{privacyPolicyLinkEnd}. Vous pouvez annuler l'abonnement en cliquant sur le bouton «\u00a0Annulation d'abonnement\u00a0» situé dans l'{billingTabLinkStart}onglet de facturation{billingTabLinkEnd} de la page des paramètres. En cas d'annulation, la période en cours vous sera tout de même facturée.";
	}

	protected override string _GetTemplateForDescriptionRobloxPremiumSubtitle()
	{
		return "Rejoindre Roblox Premium te donne des Robux tous les mois et un bonus de 10% lorsque tu achètes des Robux. Tu auras également accès aux fonctionnalitées économiques de Roblox, incluant l'achat, la vent et l'échange d'objets. Ainsi qu'une part de revenu plus élevée pour toutes les ventes faites dans tes jeux.";
	}

	protected override string _GetTemplateForDescriptionSellMoreItems()
	{
		return "Revendez des objets et obtenez plus de Robux grâce à vos créations.";
	}

	protected override string _GetTemplateForDescriptionTrade()
	{
		return "Échangez des objets avec les autres membres premium.";
	}

	protected override string _GetTemplateForHeadingBuyRobux()
	{
		return "Acheter des Robux";
	}

	protected override string _GetTemplateForHeadingConfirmCancellation()
	{
		return "Confirmer l'annulation";
	}

	protected override string _GetTemplateForHeadingEvenMoreFeatures()
	{
		return "Encore plus de fonctionnalités";
	}

	protected override string _GetTemplateForHeadingGeneralError()
	{
		return "Erreur";
	}

	protected override string _GetTemplateForHeadingPremiumRobuxDiscounts()
	{
		return "En tant qu'utilisateur premium, vous bénéficiez de réductions sur les Robux\u00a0!";
	}

	protected override string _GetTemplateForHeadingRobloxPremium()
	{
		return "Roblox Premium";
	}

	protected override string _GetTemplateForHeadingServerError()
	{
		return "Erreur serveur";
	}

	protected override string _GetTemplateForHeadingSubscriptionUnavailable()
	{
		return "Abonnement indisponible";
	}

	protected override string _GetTemplateForHeadingSwitchPlanModal()
	{
		return "Confirmer la mise à jour de l'abonnement";
	}

	protected override string _GetTemplateForHeadingUnableToFindBc()
	{
		return "Builders Club introuvable";
	}

	protected override string _GetTemplateForHeadingUpgradeToPremium()
	{
		return "Abonne-toi à Roblox Premium";
	}

	protected override string _GetTemplateForHeadingUpgradeUnavailable()
	{
		return "Mise à jour indisponible";
	}

	protected override string _GetTemplateForLabel10PercentMoreRobux()
	{
		return "Vous obtiendrez 10\u00a0% de Robux en plus";
	}

	protected override string _GetTemplateForLabelAndGetMore()
	{
		return "et bien plus\u00a0!";
	}

	protected override string _GetTemplateForLabelBecauseYouSubscribed()
	{
		return "En raison de votre abonnement\u00a0!";
	}

	protected override string _GetTemplateForLabelBuyOnce()
	{
		return "Acheter une fois";
	}

	protected override string _GetTemplateForLabelBuyRobux()
	{
		return "Acheter des Robux";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "Annuler";
	}

	protected override string _GetTemplateForLabelConfirm()
	{
		return "Confirmer";
	}

	protected override string _GetTemplateForLabelCurrentPlan()
	{
		return "Votre plan actuel";
	}

	protected override string _GetTemplateForLabelGet10PercentOffRobux()
	{
		return "Obtenez 10\u00a0% de réduction sur les Robux";
	}

	protected override string _GetTemplateForLabelGetMoreRobux()
	{
		return "Obtenir plus de Robux";
	}

	protected override string _GetTemplateForLabelMembershipManagementRecurring()
	{
		return "Pour gérer ton abonnement Premium, utilise les paramètres de facturation depuis un navigateur.";
	}

	/// <summary>
	/// Key: "Label.MembershipStatus"
	/// English String: "Your current plan is {premiumSubscription}. It will expire on {expirationDate}."
	/// </summary>
	public override string LabelMembershipStatus(string premiumSubscription, string expirationDate)
	{
		return $"Ton abonnement actuel est {premiumSubscription}. Il expire le {expirationDate}";
	}

	protected override string _GetTemplateForLabelMembershipStatus()
	{
		return "Ton abonnement actuel est {premiumSubscription}. Il expire le {expirationDate}";
	}

	/// <summary>
	/// Key: "Label.MembershipStatusExpiration"
	/// English String: "Your current plan is {premiumSubscription}. It will expire on {expirationDate}. You can repurchase or buy a new plan once your membership expires. "
	/// </summary>
	public override string LabelMembershipStatusExpiration(string premiumSubscription, string expirationDate)
	{
		return $"Ton plan actuel est: {premiumSubscription}. Il expirera le {expirationDate}. Tu peux le renouveler ou acheter un nouveau plan une fois le plan actuel expiré. ";
	}

	protected override string _GetTemplateForLabelMembershipStatusExpiration()
	{
		return "Ton plan actuel est: {premiumSubscription}. Il expirera le {expirationDate}. Tu peux le renouveler ou acheter un nouveau plan une fois le plan actuel expiré. ";
	}

	/// <summary>
	/// Key: "Label.MembershipStatusRecurring"
	/// English String: "Your current plan is {premiumSubscription}. It will renew on {renewal}."
	/// </summary>
	public override string LabelMembershipStatusRecurring(string premiumSubscription, string renewal)
	{
		return $"Ton abonnement actuel est {premiumSubscription}. Il sera renouvellé le {renewal}";
	}

	protected override string _GetTemplateForLabelMembershipStatusRecurring()
	{
		return "Ton abonnement actuel est {premiumSubscription}. Il sera renouvellé le {renewal}";
	}

	protected override string _GetTemplateForLabelNo()
	{
		return "Non";
	}

	protected override string _GetTemplateForLabelPremiumClub2200()
	{
		return "Roblox Premium 2200";
	}

	/// <summary>
	/// Key: "Label.PriceMonth"
	/// English String: "{robux}{subTextStart}/month{subTextEnd}"
	/// </summary>
	public override string LabelPriceMonth(string robux, string subTextStart, string subTextEnd)
	{
		return $"{robux}{subTextStart} par mois{subTextEnd}";
	}

	protected override string _GetTemplateForLabelPriceMonth()
	{
		return "{robux}{subTextStart} par mois{subTextEnd}";
	}

	/// <summary>
	/// Key: "Label.PricePerMonth"
	/// Please don't translate this one. This should be removed.
	/// English String: "{robuxAmount}/month"
	/// </summary>
	public override string LabelPricePerMonth(string robuxAmount)
	{
		return $"{robuxAmount} par mois";
	}

	protected override string _GetTemplateForLabelPricePerMonth()
	{
		return "{robuxAmount} par mois";
	}

	protected override string _GetTemplateForLabelRobloxPremium()
	{
		return "Roblox Premium";
	}

	protected override string _GetTemplateForLabelRobloxPremium1000()
	{
		return "Roblox Premium 1000";
	}

	protected override string _GetTemplateForLabelRobloxPremium1000OneMonth()
	{
		return "Roblox Premium 1000 Un mois";
	}

	protected override string _GetTemplateForLabelRobloxPremium2200()
	{
		return "Roblox Premium 2200";
	}

	protected override string _GetTemplateForLabelRobloxPremium2200OneMonth()
	{
		return "Roblox Premium 2200 Un mois";
	}

	protected override string _GetTemplateForLabelRobloxPremium450()
	{
		return "Roblox Premium 450";
	}

	protected override string _GetTemplateForLabelRobloxPremium450OneMonth()
	{
		return "Roblox Premium 450 Un mois";
	}

	protected override string _GetTemplateForLabelSellMore()
	{
		return "Vendre plus";
	}

	protected override string _GetTemplateForLabelSinceYouSubscribed()
	{
		return "grâce à votre abonnement";
	}

	protected override string _GetTemplateForLabelSubscribe()
	{
		return "S'inscrire";
	}

	/// <summary>
	/// Key: "Label.SubscribeUpsell"
	/// English String: "Subscribe {upsellLinkStart}and get more!{upsellLinkEnd}"
	/// </summary>
	public override string LabelSubscribeUpsell(string upsellLinkStart, string upsellLinkEnd)
	{
		return $"Abonnez-vous {upsellLinkStart}pour en recevoir plus\u00a0!{upsellLinkEnd}";
	}

	protected override string _GetTemplateForLabelSubscribeUpsell()
	{
		return "Abonnez-vous {upsellLinkStart}pour en recevoir plus\u00a0!{upsellLinkEnd}";
	}

	protected override string _GetTemplateForLabelTrade()
	{
		return "Échange";
	}

	protected override string _GetTemplateForLabelValuePacks()
	{
		return "Offre avantageuse";
	}

	protected override string _GetTemplateForLabelWantMoreRobux()
	{
		return "Vous voulez plus de Robux\u00a0?";
	}

	protected override string _GetTemplateForLabelYes()
	{
		return "Oui";
	}

	/// <summary>
	/// Key: "Message.ConfirmCancellationModal"
	/// English String: "By clicking \"Confirm\" will end your Builders Club membership so you can subscribe to Roblox Premium.{newLine} You will receive a one-time payout of {robuxAmount}"
	/// </summary>
	public override string MessageConfirmCancellationModal(string newLine, string robuxAmount)
	{
		return $"En cliquant sur «\u00a0Confirmer\u00a0», vous mettrez fin à votre abonnement au Builders Club afin de vous inscrire à Roblox Premium.{newLine} Vous recevrez un paiement unique de {robuxAmount}";
	}

	protected override string _GetTemplateForMessageConfirmCancellationModal()
	{
		return "En cliquant sur «\u00a0Confirmer\u00a0», vous mettrez fin à votre abonnement au Builders Club afin de vous inscrire à Roblox Premium.{newLine} Vous recevrez un paiement unique de {robuxAmount}";
	}

	protected override string _GetTemplateForMessageGeneralError()
	{
		return "Une erreur est survenue lors de la mise à jour de votre abonnement. Veuillez réessayer plus tard.";
	}

	protected override string _GetTemplateForMessageNoDataError()
	{
		return "Aucune information sur l'abonnement.";
	}

	protected override string _GetTemplateForMessageServerError()
	{
		return "Une erreur serveur est survenue lors de la mise à jour de votre abonnement. Veuillez réessayer plus tard.";
	}

	/// <summary>
	/// Key: "Message.SubscriptionUnavailableModal"
	/// English String: "We are sorry, you cannot subscribe until your current cancelled plan has expired. Please re-subscribe on {expiredDate}."
	/// </summary>
	public override string MessageSubscriptionUnavailableModal(string expiredDate)
	{
		return $"Vous ne pouvez malheureusement pas vous abonner avant l'expiration de votre plan annulé. Veuillez vous abonner de nouveau le {expiredDate}.";
	}

	protected override string _GetTemplateForMessageSubscriptionUnavailableModal()
	{
		return "Vous ne pouvez malheureusement pas vous abonner avant l'expiration de votre plan annulé. Veuillez vous abonner de nouveau le {expiredDate}.";
	}

	/// <summary>
	/// Key: "Message.SwitchPlanBody"
	/// English String: "By clicking \"Confirm\" you authorize us to charge you {price} each month until you cancel or switch subscriptions effective {renewalDate}"
	/// </summary>
	public override string MessageSwitchPlanBody(string price, string renewalDate)
	{
		return $"En cliquant sur «\u00a0Confirmer\u00a0», vous nous autorisez à vous facturer {price} tous les mois jusqu'à ce que vous annuliez ou modifiez votre abonnement, à partir du {renewalDate}";
	}

	protected override string _GetTemplateForMessageSwitchPlanBody()
	{
		return "En cliquant sur «\u00a0Confirmer\u00a0», vous nous autorisez à vous facturer {price} tous les mois jusqu'à ce que vous annuliez ou modifiez votre abonnement, à partir du {renewalDate}";
	}

	protected override string _GetTemplateForMessageUnableToFindBc()
	{
		return "Information du Builders Club introuvable pour cet utilisateur.";
	}

	protected override string _GetTemplateForMessageUpgradeUnavailableModal()
	{
		return "Nous ne pouvons malheureusement pas modifier votre abonnement car il n'existe actuellement aucune option équivalente au Builders Club à vie.";
	}

	protected override string _GetTemplateForSwitchPlanTitle()
	{
		return "Confirmer la mise à jour de l'abonnement";
	}
}
