namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PremiumResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PremiumResources_de_de : PremiumResources_en_us, IPremiumResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Bought"
	/// English String: "Bought"
	/// </summary>
	public override string ActionBought => "Gekauft";

	/// <summary>
	/// Key: "Action.BuyNow"
	/// English String: "Buy Now!"
	/// </summary>
	public override string ActionBuyNow => "Jetzt kaufen!";

	/// <summary>
	/// Key: "Action.BuyRobux"
	/// English String: "Buy Robux"
	/// </summary>
	public override string ActionBuyRobux => "Robux kaufen";

	/// <summary>
	/// Key: "Description.GetMoreRobux"
	/// English String: "Get 10% more when purchasing Robux"
	/// </summary>
	public override string DescriptionGetMoreRobux => "Erhalte 10\u00a0% mehr beim Kauf von Robux";

	/// <summary>
	/// Key: "Description.GooglePlayMonthlySubscriptionDisclosure"
	/// English String: "Roblox Premium is a monthly subscription that is charged to your Google Play account at confirmation of purchase. Roblox Premium will automatically renew unless auto-renewal is turned off at least 24-hours before the end of the current period. Your account will be charged for renewal within 24-hours prior to the end of the current period. Subscriptions may be managed and auto-renewal may be turned off by going to your Google Play account settings. If you’re under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted."
	/// </summary>
	public override string DescriptionGooglePlayMonthlySubscriptionDisclosure => "Roblox-Premium ist ein monatliches Abonnement, das deinem Google Play-Konto bei Bestätigung des Kaufs belastet wird. Roblox-Premium verlängert sich automatisch, sofern die automatische Verlängerung nicht mindestens 24 Stunden vor dem Ende des aktuellen Zeitraums deaktiviert wird. Dein Konto wird innerhalb von 24 Stunden vor dem Ende des aktuellen Zeitraums mit der Verlängerung belastet. Abonnements können verwaltet und die automatische Verlängerung kann in den Einstellungen deines Google Play-Kontos deaktiviert werden. Wenn du jünger als 18 Jahre bist, vergewissere dich, dass du die Erlaubnis deiner Eltern oder Erziehungsberechtigten haben, bevor Sie einen Kauf tätigst. Ein Kauf ohne Erlaubnis kann dazu führen, dass dein Konto gelöscht wird.";

	/// <summary>
	/// Key: "Description.RobloxPremiumSubtitle"
	/// English String: "Joining Roblox Premium gets you a monthly Robux allowance and a 10% bonus when buying Robux. You will also get access to Roblox's economy features including buying, selling, and trading items, as well as increased revenue share on all sales in your games."
	/// </summary>
	public override string DescriptionRobloxPremiumSubtitle => "Wenn du Roblox Premium beitrittst, erhältst du monatlich eine gewisse Menge an Robux sowie einen Bonus von 10\u00a0% beim Kauf von Robux. Zudem erhältst du Zugang zu den wirtschaftlichen Features von Roblox (unter anderem kannst du Artikel kaufen, verkaufen und mit ihnen handeln). Und du erhältst einen größeren Umsatzanteil für alle in deinen Spielen getätigten Verkäufe.";

	/// <summary>
	/// Key: "Description.SellMoreItems"
	/// English String: "Resell items and get more Robux selling your creations"
	/// </summary>
	public override string DescriptionSellMoreItems => "Verkaufe Artikel weiter und erhalte mehr Robux für den Verkauf deiner Schöpfungen";

	/// <summary>
	/// Key: "Description.Trade"
	/// English String: "Trade items with other Premium members"
	/// </summary>
	public override string DescriptionTrade => "Handle mit anderen Premium-Mitgliedern um Artikel";

	/// <summary>
	/// Key: "Heading.BuyRobux"
	/// The title of Robux page
	/// English String: "Buy Robux"
	/// </summary>
	public override string HeadingBuyRobux => "Robux kaufen";

	/// <summary>
	/// Key: "Heading.ConfirmCancellation"
	/// English String: "Confirm Cancellation"
	/// </summary>
	public override string HeadingConfirmCancellation => "Kündigung bestätigen";

	/// <summary>
	/// Key: "Heading.EvenMoreFeatures"
	/// English String: "Even more Features"
	/// </summary>
	public override string HeadingEvenMoreFeatures => "Noch mehr Features";

	/// <summary>
	/// Key: "Heading.GeneralError"
	/// English String: "Error"
	/// </summary>
	public override string HeadingGeneralError => "Fehler";

	/// <summary>
	/// Key: "Heading.PremiumRobuxDiscounts"
	/// English String: "As a Premium user, you get discounts on Robux!"
	/// </summary>
	public override string HeadingPremiumRobuxDiscounts => "Als Premium-Mitglied erhältst du Rabatte auf Robux!";

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
	public override string HeadingServerError => "Serverfehler";

	/// <summary>
	/// Key: "Heading.SubscriptionUnavailable"
	/// English String: "Subscription Unavailable"
	/// </summary>
	public override string HeadingSubscriptionUnavailable => "Abonnement nicht verfügbar";

	/// <summary>
	/// Key: "Heading.SwitchPlanModal"
	/// English String: "Confirm Subscription Update"
	/// </summary>
	public override string HeadingSwitchPlanModal => "Abonnementaktualisierung bestätigen";

	/// <summary>
	/// Key: "Heading.UnableToFindBc"
	/// English String: "Cannot find Builders Club"
	/// </summary>
	public override string HeadingUnableToFindBc => "Builders Club kann nicht gefunden werden";

	/// <summary>
	/// Key: "Heading.UpgradeToPremium"
	/// English String: "Upgrade to Roblox Premium"
	/// </summary>
	public override string HeadingUpgradeToPremium => "Auf Roblox-Premium aufwerten";

	/// <summary>
	/// Key: "Heading.UpgradeUnavailable"
	/// English String: "Upgrade Unavailable"
	/// </summary>
	public override string HeadingUpgradeUnavailable => "Aufwertung nicht verfügbar";

	/// <summary>
	/// Key: "Label.10PercentMoreRobux"
	/// Part 1 of a two part label (Label.SinceYouSubscribed)
	/// English String: "You'll get 10% more Robux"
	/// </summary>
	public override string Label10PercentMoreRobux => "Du erhältst 10% mehr Robux";

	/// <summary>
	/// Key: "Label.AndGetMore"
	/// English String: "and get more!"
	/// </summary>
	public override string LabelAndGetMore => "und mehr erhalten!";

	/// <summary>
	/// Key: "Label.BecauseYouSubscribed"
	/// English String: "Because you Subscribed!"
	/// </summary>
	public override string LabelBecauseYouSubscribed => "Weil du ein Abo abgeschlossen hast!";

	/// <summary>
	/// Key: "Label.BuyOnce"
	/// English String: "Buy Once"
	/// </summary>
	public override string LabelBuyOnce => "Einmal kaufen";

	/// <summary>
	/// Key: "Label.BuyRobux"
	/// English String: "Buy Robux"
	/// </summary>
	public override string LabelBuyRobux => "Robux kaufen";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "Abbrechen";

	/// <summary>
	/// Key: "Label.Confirm"
	/// English String: "Confirm"
	/// </summary>
	public override string LabelConfirm => "Bestätigen";

	/// <summary>
	/// Key: "Label.CurrentPlan"
	/// English String: "Your Current Plan"
	/// </summary>
	public override string LabelCurrentPlan => "Dein aktuelles Abo";

	/// <summary>
	/// Key: "Label.Get10PercentOffRobux"
	/// English String: "Get 10% off Robux"
	/// </summary>
	public override string LabelGet10PercentOffRobux => "Erhalte 10% Rabatt auf Robux";

	/// <summary>
	/// Key: "Label.GetMoreRobux"
	/// English String: "Get More Robux"
	/// </summary>
	public override string LabelGetMoreRobux => "Mehr Robux holen";

	/// <summary>
	/// Key: "Label.MembershipManagementRecurring"
	/// English String: "To manage your Premium subscription, please go to your Billing settings using a browser."
	/// </summary>
	public override string LabelMembershipManagementRecurring => "Um dein Premium-Abonnement zu verwalten, ruf die Abrechnungseinstellungen über einen Browser auf.";

	/// <summary>
	/// Key: "Label.No"
	/// English String: "No"
	/// </summary>
	public override string LabelNo => "Nein";

	/// <summary>
	/// Key: "Label.PremiumClub2200"
	/// English String: "Roblox Premium 2200"
	/// </summary>
	public override string LabelPremiumClub2200 => "Roblox Premium 2200";

	/// <summary>
	/// Key: "Label.RobloxPremium"
	/// English String: "Roblox Premium"
	/// </summary>
	public override string LabelRobloxPremium => "Roblox-Premium";

	/// <summary>
	/// Key: "Label.RobloxPremium1000"
	/// English String: "Roblox Premium 1000"
	/// </summary>
	public override string LabelRobloxPremium1000 => "Roblox Premium 1000";

	/// <summary>
	/// Key: "Label.RobloxPremium1000OneMonth"
	/// English String: "Roblox Premium 1000 One Month"
	/// </summary>
	public override string LabelRobloxPremium1000OneMonth => "Roblox Premiun 1000 Ein Monat";

	/// <summary>
	/// Key: "Label.RobloxPremium2200"
	/// English String: "Roblox Premium 2200"
	/// </summary>
	public override string LabelRobloxPremium2200 => "Roblox Premium 2200";

	/// <summary>
	/// Key: "Label.RobloxPremium2200OneMonth"
	/// English String: "Roblox Premium 2200 One Month"
	/// </summary>
	public override string LabelRobloxPremium2200OneMonth => "Roblox Premiun 2200 Ein Monat";

	/// <summary>
	/// Key: "Label.RobloxPremium450"
	/// English String: "Roblox Premium 450"
	/// </summary>
	public override string LabelRobloxPremium450 => "Roblox Premium 450";

	/// <summary>
	/// Key: "Label.RobloxPremium450OneMonth"
	/// English String: "Roblox Premium 450 One Month"
	/// </summary>
	public override string LabelRobloxPremium450OneMonth => "Roblox Premium 450 ein Monag";

	/// <summary>
	/// Key: "Label.SellMore"
	/// English String: "Sell More"
	/// </summary>
	public override string LabelSellMore => "Mehr verkaufen";

	/// <summary>
	/// Key: "Label.SinceYouSubscribed"
	/// Part 2 of a 2 part label
	/// English String: "since you subscribed"
	/// </summary>
	public override string LabelSinceYouSubscribed => "da du abonniert hast";

	/// <summary>
	/// Key: "Label.Subscribe"
	/// English String: "Subscribe"
	/// </summary>
	public override string LabelSubscribe => "Abonnieren";

	/// <summary>
	/// Key: "Label.Trade"
	/// English String: "Trade"
	/// </summary>
	public override string LabelTrade => "Handeln";

	/// <summary>
	/// Key: "Label.ValuePacks"
	/// English String: "Value Packs"
	/// </summary>
	public override string LabelValuePacks => "Vorteilspakete";

	/// <summary>
	/// Key: "Label.WantMoreRobux"
	/// English String: "Want more Robux?"
	/// </summary>
	public override string LabelWantMoreRobux => "Du brauchst mehr Robux?";

	/// <summary>
	/// Key: "Label.Yes"
	/// English String: "Yes"
	/// </summary>
	public override string LabelYes => "Ja";

	/// <summary>
	/// Key: "Message.GeneralError"
	/// English String: "An error occurred while updating your subscription. Please try again later."
	/// </summary>
	public override string MessageGeneralError => "Bei der Aktualisierung deines Abonnements ist ein Fehler aufgetreten. Bitte versuche es später erneut.";

	/// <summary>
	/// Key: "Message.NoDataError"
	/// English String: "No subscriptions information."
	/// </summary>
	public override string MessageNoDataError => "Keine Informationen zu Abonnements.";

	/// <summary>
	/// Key: "Message.ServerError"
	/// English String: "A server error occurred while updating your subscription. Please try again later."
	/// </summary>
	public override string MessageServerError => "Bei der Aktualisierung deines Abonnements ist ein Serverfehler aufgetreten. Bitte versuche es später erneut.";

	/// <summary>
	/// Key: "Message.UnableToFindBc"
	/// English String: "Cannot find Builders Club information for this user."
	/// </summary>
	public override string MessageUnableToFindBc => "Informationen zum Builders Club dieses Benutzers können nicht gefunden werden.";

	/// <summary>
	/// Key: "Message.UpgradeUnavailableModal"
	/// English String: "We are sorry, we cannot change your subscription because there is currently no package equivalent to Lifetime Builders Club."
	/// </summary>
	public override string MessageUpgradeUnavailableModal => "Es tut uns leid, wir können dein Abonnement nicht ändern, weil es momentan kein gleichwertiges Paket zum Builders Club auf Lebenszeit gibt.";

	/// <summary>
	/// Key: "SwitchPlanTitle"
	/// Wrong string. Do translate this.
	/// English String: "Confirm Subscription Update"
	/// </summary>
	public override string SwitchPlanTitle => "Abonnementaktualisierung bestätigen";

	public PremiumResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBought()
	{
		return "Gekauft";
	}

	protected override string _GetTemplateForActionBuyNow()
	{
		return "Jetzt kaufen!";
	}

	protected override string _GetTemplateForActionBuyRobux()
	{
		return "Robux kaufen";
	}

	/// <summary>
	/// Key: "Description.BuyMoreRobuxSubtitle"
	/// English String: "Buy Robux to purchase upgrades for your avatar or special abilities in games.{lineBreak} Subscribe to Roblox Premium and get even more Robux each month, as well as bonus features. Premium is billed every month until cancelled. {learnMoreLinkStart}Learn more here.{learnMoreLinkEnd}"
	/// </summary>
	public override string DescriptionBuyMoreRobuxSubtitle(string lineBreak, string learnMoreLinkStart, string learnMoreLinkEnd)
	{
		return $"Kauf Robux, um Verbesserungen für deinen Avatar oder besondere Fähigkeiten in Spielen zu kaufen.{lineBreak} Kaufe Roblox-Premium, um mehr Robux jeden Monat sowie Bonusfunktionen zu erhalten. Roblox-Premium wird dir bis auf Widerruf jeden Monat in Rechnung gestellt. {learnMoreLinkStart}Hier erfährst du mehr{learnMoreLinkEnd}";
	}

	protected override string _GetTemplateForDescriptionBuyMoreRobuxSubtitle()
	{
		return "Kauf Robux, um Verbesserungen für deinen Avatar oder besondere Fähigkeiten in Spielen zu kaufen.{lineBreak} Kaufe Roblox-Premium, um mehr Robux jeden Monat sowie Bonusfunktionen zu erhalten. Roblox-Premium wird dir bis auf Widerruf jeden Monat in Rechnung gestellt. {learnMoreLinkStart}Hier erfährst du mehr{learnMoreLinkEnd}";
	}

	/// <summary>
	/// Key: "Description.BuyRobuxSubtitle"
	/// English String: "Get Robux to purchase upgrades for your avatar or buy special abilities in games. For more information on how to earn Robux, visit our {helpLinkStart}Robux Help page{helpLinkEnd}.{paragraphBreaker}Purchase Roblox Premium to get more Robux for the same price. Roblox Premium is billed every month until cancelled. {learnMoreLinkStart}Learn more here{learnMoreLinkEnd}."
	/// </summary>
	public override string DescriptionBuyRobuxSubtitle(string helpLinkStart, string helpLinkEnd, string paragraphBreaker, string learnMoreLinkStart, string learnMoreLinkEnd)
	{
		return $"Hol dir Robux, um Verbesserungen für deinen Avatar oder besondere Fähigkeiten in Spielen zu kaufen. Wie du Robux verdienst, erfährst du auf unserer {helpLinkStart}Robux-Hilfeseite{helpLinkEnd}.{paragraphBreaker}Kaufe Roblox Premium, um mehr Robux für denselben Preis zu erhalten. Roblox Premium wird dir bis auf Widerruf jeden Monat in Rechnung gestellt. {learnMoreLinkStart}Hier erfährst du mehr{learnMoreLinkEnd}.";
	}

	protected override string _GetTemplateForDescriptionBuyRobuxSubtitle()
	{
		return "Hol dir Robux, um Verbesserungen für deinen Avatar oder besondere Fähigkeiten in Spielen zu kaufen. Wie du Robux verdienst, erfährst du auf unserer {helpLinkStart}Robux-Hilfeseite{helpLinkEnd}.{paragraphBreaker}Kaufe Roblox Premium, um mehr Robux für denselben Preis zu erhalten. Roblox Premium wird dir bis auf Widerruf jeden Monat in Rechnung gestellt. {learnMoreLinkStart}Hier erfährst du mehr{learnMoreLinkEnd}.";
	}

	protected override string _GetTemplateForDescriptionGetMoreRobux()
	{
		return "Erhalte 10\u00a0% mehr beim Kauf von Robux";
	}

	protected override string _GetTemplateForDescriptionGooglePlayMonthlySubscriptionDisclosure()
	{
		return "Roblox-Premium ist ein monatliches Abonnement, das deinem Google Play-Konto bei Bestätigung des Kaufs belastet wird. Roblox-Premium verlängert sich automatisch, sofern die automatische Verlängerung nicht mindestens 24 Stunden vor dem Ende des aktuellen Zeitraums deaktiviert wird. Dein Konto wird innerhalb von 24 Stunden vor dem Ende des aktuellen Zeitraums mit der Verlängerung belastet. Abonnements können verwaltet und die automatische Verlängerung kann in den Einstellungen deines Google Play-Kontos deaktiviert werden. Wenn du jünger als 18 Jahre bist, vergewissere dich, dass du die Erlaubnis deiner Eltern oder Erziehungsberechtigten haben, bevor Sie einen Kauf tätigst. Ein Kauf ohne Erlaubnis kann dazu führen, dass dein Konto gelöscht wird.";
	}

	/// <summary>
	/// Key: "Description.IosMonthlySubscriptionDisclosure"
	/// English String: "Roblox Premium is a monthly subscription that costs {costPrice}. Payment will be charged to the iTunes Account at confirmation of purchase. Roblox Premium will automatically renew unless auto-renewal is turned off at least 24-hours before the end of the current period. Your account will be charged {renewalPrice} for renewal within 24-hours prior to the end of the current period. Subscriptions may be managed and auto-renewal may be turned off by going to your Account Settings. If you're under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted."
	/// </summary>
	public override string DescriptionIosMonthlySubscriptionDisclosure(string costPrice, string renewalPrice)
	{
		return $"Roblox-Premium ist ein monatliches Abonnement, das {costPrice} kostet. Die Zahlung wird dem iTunes-Konto bei Bestätigung des Kaufs belastet. Roblox Premium verlängert sich automatisch, sofern die automatische Verlängerung nicht mindestens 24 Stunden vor dem Ende des aktuellen Zeitraums deaktiviert wird. Dein Konto wird innerhalb von 24 Stunden vor dem Ende des aktuellen Zeitraums mit {renewalPrice} für die Verlängerung belastet. Abonnements können verwaltet und die automatische Verlängerung kann in den Kontoeinstellungen deaktiviert werden. Wenn du unter 18 Jahre alt bist, stell sicher, dass du die Erlaubnis deiner Eltern oder Erziehungsberechtigten hast, bevor du einen Kauf tätigst. Ein Kauf ohne Erlaubnis kann dazu führen, dass dein Konto gelöscht wird.";
	}

	protected override string _GetTemplateForDescriptionIosMonthlySubscriptionDisclosure()
	{
		return "Roblox-Premium ist ein monatliches Abonnement, das {costPrice} kostet. Die Zahlung wird dem iTunes-Konto bei Bestätigung des Kaufs belastet. Roblox Premium verlängert sich automatisch, sofern die automatische Verlängerung nicht mindestens 24 Stunden vor dem Ende des aktuellen Zeitraums deaktiviert wird. Dein Konto wird innerhalb von 24 Stunden vor dem Ende des aktuellen Zeitraums mit {renewalPrice} für die Verlängerung belastet. Abonnements können verwaltet und die automatische Verlängerung kann in den Kontoeinstellungen deaktiviert werden. Wenn du unter 18 Jahre alt bist, stell sicher, dass du die Erlaubnis deiner Eltern oder Erziehungsberechtigten hast, bevor du einen Kauf tätigst. Ein Kauf ohne Erlaubnis kann dazu führen, dass dein Konto gelöscht wird.";
	}

	/// <summary>
	/// Key: "Description.IosSubscriptionDisclosure"
	/// English String: "Roblox Premium is a {durationType} subscription that costs {costPrice}. Payment will be charged to the iTunes Account at confirmation of purchase. Roblox Premium will automatically renew unless auto-renewal is turned off at least 24-hours before the end of the current period. Your account will be charged {renewalPrice} for renewal within 24-hours prior to the end of the current period. Subscriptions may be managed and auto-renewal may be turned off by going to your Account Settings."
	/// </summary>
	public override string DescriptionIosSubscriptionDisclosure(string durationType, string costPrice, string renewalPrice)
	{
		return $"Roblox-Premium ist ein {durationType}-Abonnement, das {costPrice} kostet. Die Zahlung wird dem iTunes-Konto bei Bestätigung des Kaufs belastet. Roblox Premium verlängert sich automatisch, sofern die automatische Verlängerung nicht mindestens 24 Stunden vor dem Ende des aktuellen Zeitraums deaktiviert wird. Dein Konto wird innerhalb von 24 Stunden vor dem Ende des aktuellen Zeitraums mit {renewalPrice} für die Verlängerung belastet. Abonnements können verwaltet und die automatische Verlängerung kann in den Kontoeinstellungen deaktiviert werden.";
	}

	protected override string _GetTemplateForDescriptionIosSubscriptionDisclosure()
	{
		return "Roblox-Premium ist ein {durationType}-Abonnement, das {costPrice} kostet. Die Zahlung wird dem iTunes-Konto bei Bestätigung des Kaufs belastet. Roblox Premium verlängert sich automatisch, sofern die automatische Verlängerung nicht mindestens 24 Stunden vor dem Ende des aktuellen Zeitraums deaktiviert wird. Dein Konto wird innerhalb von 24 Stunden vor dem Ende des aktuellen Zeitraums mit {renewalPrice} für die Verlängerung belastet. Abonnements können verwaltet und die automatische Verlängerung kann in den Kontoeinstellungen deaktiviert werden.";
	}

	/// <summary>
	/// Key: "Description.legalDisclosuresPremiumRobuxPage"
	/// English String: "When you buy Robux, you receive only a limited, non-refundable, non-transferable, revocable license to use Robux, which have no value in real currency. See {termsLinkStart}Terms of Use{termsLinkEnd} for other limitations.  If you're under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted."
	/// </summary>
	public override string DescriptionlegalDisclosuresPremiumRobuxPage(string termsLinkStart, string termsLinkEnd)
	{
		return $"Wenn du Robux kaufst, erhältst du nur eine eingeschränkte, nicht rückerstattbare, nicht übertragbare, widerrufbare Lizenz zur Nutzung von Robux, die keinen Wert in realer Währung hat. Weitere Einschränkungen findest du unter {termsLinkStart}Nutzungsbedingungen{termsLinkEnd}. Wenn du unter 18 Jahre bist, stell sicher, dass du die Erlaubnis deiner Eltern oder Erziehungsberechtigten hast, bevor du einen Kauf tätigst. Ein Kauf ohne Erlaubnis kann dazu führen, dass dein Konto gelöscht wird.";
	}

	protected override string _GetTemplateForDescriptionlegalDisclosuresPremiumRobuxPage()
	{
		return "Wenn du Robux kaufst, erhältst du nur eine eingeschränkte, nicht rückerstattbare, nicht übertragbare, widerrufbare Lizenz zur Nutzung von Robux, die keinen Wert in realer Währung hat. Weitere Einschränkungen findest du unter {termsLinkStart}Nutzungsbedingungen{termsLinkEnd}. Wenn du unter 18 Jahre bist, stell sicher, dass du die Erlaubnis deiner Eltern oder Erziehungsberechtigten hast, bevor du einen Kauf tätigst. Ein Kauf ohne Erlaubnis kann dazu führen, dass dein Konto gelöscht wird.";
	}

	/// <summary>
	/// Key: "Description.legalDisclosuresPremiumUpgradePage"
	/// English String: "If you are under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted.  By clicking “Submit Order” (1) you authorize us to charge your account every month until you cancel the subscription, and (2) you represent that you understand and agree to the {termsLinkStart}Terms of Use{termsLinkEnd} and {privacyLinkStart}Privacy Policy{privatyLinkEnd}. You can cancel at any time by clicking “Cancel membership” on the {billingLinkStart}billing tab{billingLinkEnd}  of the setting page. If you cancel, you will still be charged for the current billing period."
	/// </summary>
	public override string DescriptionlegalDisclosuresPremiumUpgradePage(string termsLinkStart, string termsLinkEnd, string privacyLinkStart, string privatyLinkEnd, string billingLinkStart, string billingLinkEnd)
	{
		return $"Wenn du unter 18 Jahre alt bist, stell sicher, dass du die Erlaubnis deiner Eltern oder Erziehungsberechtigten hast, bevor du einen Kauf tätigst. Ein Kauf ohne Erlaubnis kann dazu führen, dass dein Konto gelöscht wird. Durch Klicken auf „Bestellung abschicken“ (1) ermächtigst du uns, dein Konto jeden Monat zu belasten, bis du das Abonnement kündigst und (1) bestätigst, dass du die {termsLinkStart}Nutzungsbedingungen{termsLinkEnd} und die {privacyLinkStart}Datenschutzrichtlinie{privatyLinkEnd} verstehst und diesen zustimmst. Du kannst die Mitgliedschaft jederzeit kündigen, indem du auf der Einstellungsseite auf der {billingLinkStart}Registerkarte {billingLinkEnd}der Registerkarte auf „Mitgliedschaft kündigen“ klickst. Wenn du stornierst, wird dir weiterhin der aktuelle Abrechnungszeitraum in Rechnung gestellt.";
	}

	protected override string _GetTemplateForDescriptionlegalDisclosuresPremiumUpgradePage()
	{
		return "Wenn du unter 18 Jahre alt bist, stell sicher, dass du die Erlaubnis deiner Eltern oder Erziehungsberechtigten hast, bevor du einen Kauf tätigst. Ein Kauf ohne Erlaubnis kann dazu führen, dass dein Konto gelöscht wird. Durch Klicken auf „Bestellung abschicken“ (1) ermächtigst du uns, dein Konto jeden Monat zu belasten, bis du das Abonnement kündigst und (1) bestätigst, dass du die {termsLinkStart}Nutzungsbedingungen{termsLinkEnd} und die {privacyLinkStart}Datenschutzrichtlinie{privatyLinkEnd} verstehst und diesen zustimmst. Du kannst die Mitgliedschaft jederzeit kündigen, indem du auf der Einstellungsseite auf der {billingLinkStart}Registerkarte {billingLinkEnd}der Registerkarte auf „Mitgliedschaft kündigen“ klickst. Wenn du stornierst, wird dir weiterhin der aktuelle Abrechnungszeitraum in Rechnung gestellt.";
	}

	/// <summary>
	/// Key: "Description.PremiumSubscriptionDisclosure"
	/// Duplicated
	/// English String: "If you're under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted.  By clicking “Submit Order” (1) you authorize us to charge your account every month until you cancel the subscription, and (2) you represent that you understand and agree to the {teamOfUseLinkStart}Terms of Use{teamOfUseLinkEnd} and {privacyPolicyLinkStart}Privacy Policy{privacyPolicyLinkEnd}. You can cancel at any time by clicking “Cancel membership” on the {billingTabLinkStart}billing tab{billingTabLinkEnd} of the setting page. If you cancel, you will still be charged for the current billing period."
	/// </summary>
	public override string DescriptionPremiumSubscriptionDisclosure(string teamOfUseLinkStart, string teamOfUseLinkEnd, string privacyPolicyLinkStart, string privacyPolicyLinkEnd, string billingTabLinkStart, string billingTabLinkEnd)
	{
		return $"Wenn du unter 18 Jahre alt bist, stell sicher, dass du die Erlaubnis deiner Eltern oder Erziehungsberechtigten hast, bevor du einen Kauf tätigst. Ein Kauf ohne Erlaubnis kann dazu führen, dass dein Konto gelöscht wird. Durch Klicken auf „Bestellung abschicken“ (1) ermächtigst du uns, dein Konto monatlich zu belasten, bis du das Abonnement kündigst, und (2) du erklärst dich mit den {teamOfUseLinkStart}Nutzungsbedingungen{teamOfUseLinkEnd} und {privacyPolicyLinkStart}Datenschutzerklärung{privacyPolicyLinkEnd} einverstanden. Du kannst jederzeit kündigen, indem du auf der Einstellungsseite auf der {billingTabLinkStart}Registerkarte{billingTabLinkEnd} auf „Mitgliedschaft kündigen“ klickst. Wenn du stornierst, wird dir weiterhin der aktuelle Abrechnungszeitraum in Rechnung gestellt.";
	}

	protected override string _GetTemplateForDescriptionPremiumSubscriptionDisclosure()
	{
		return "Wenn du unter 18 Jahre alt bist, stell sicher, dass du die Erlaubnis deiner Eltern oder Erziehungsberechtigten hast, bevor du einen Kauf tätigst. Ein Kauf ohne Erlaubnis kann dazu führen, dass dein Konto gelöscht wird. Durch Klicken auf „Bestellung abschicken“ (1) ermächtigst du uns, dein Konto monatlich zu belasten, bis du das Abonnement kündigst, und (2) du erklärst dich mit den {teamOfUseLinkStart}Nutzungsbedingungen{teamOfUseLinkEnd} und {privacyPolicyLinkStart}Datenschutzerklärung{privacyPolicyLinkEnd} einverstanden. Du kannst jederzeit kündigen, indem du auf der Einstellungsseite auf der {billingTabLinkStart}Registerkarte{billingTabLinkEnd} auf „Mitgliedschaft kündigen“ klickst. Wenn du stornierst, wird dir weiterhin der aktuelle Abrechnungszeitraum in Rechnung gestellt.";
	}

	protected override string _GetTemplateForDescriptionRobloxPremiumSubtitle()
	{
		return "Wenn du Roblox Premium beitrittst, erhältst du monatlich eine gewisse Menge an Robux sowie einen Bonus von 10\u00a0% beim Kauf von Robux. Zudem erhältst du Zugang zu den wirtschaftlichen Features von Roblox (unter anderem kannst du Artikel kaufen, verkaufen und mit ihnen handeln). Und du erhältst einen größeren Umsatzanteil für alle in deinen Spielen getätigten Verkäufe.";
	}

	protected override string _GetTemplateForDescriptionSellMoreItems()
	{
		return "Verkaufe Artikel weiter und erhalte mehr Robux für den Verkauf deiner Schöpfungen";
	}

	protected override string _GetTemplateForDescriptionTrade()
	{
		return "Handle mit anderen Premium-Mitgliedern um Artikel";
	}

	protected override string _GetTemplateForHeadingBuyRobux()
	{
		return "Robux kaufen";
	}

	protected override string _GetTemplateForHeadingConfirmCancellation()
	{
		return "Kündigung bestätigen";
	}

	protected override string _GetTemplateForHeadingEvenMoreFeatures()
	{
		return "Noch mehr Features";
	}

	protected override string _GetTemplateForHeadingGeneralError()
	{
		return "Fehler";
	}

	protected override string _GetTemplateForHeadingPremiumRobuxDiscounts()
	{
		return "Als Premium-Mitglied erhältst du Rabatte auf Robux!";
	}

	protected override string _GetTemplateForHeadingRobloxPremium()
	{
		return "Roblox Premium";
	}

	protected override string _GetTemplateForHeadingServerError()
	{
		return "Serverfehler";
	}

	protected override string _GetTemplateForHeadingSubscriptionUnavailable()
	{
		return "Abonnement nicht verfügbar";
	}

	protected override string _GetTemplateForHeadingSwitchPlanModal()
	{
		return "Abonnementaktualisierung bestätigen";
	}

	protected override string _GetTemplateForHeadingUnableToFindBc()
	{
		return "Builders Club kann nicht gefunden werden";
	}

	protected override string _GetTemplateForHeadingUpgradeToPremium()
	{
		return "Auf Roblox-Premium aufwerten";
	}

	protected override string _GetTemplateForHeadingUpgradeUnavailable()
	{
		return "Aufwertung nicht verfügbar";
	}

	protected override string _GetTemplateForLabel10PercentMoreRobux()
	{
		return "Du erhältst 10% mehr Robux";
	}

	protected override string _GetTemplateForLabelAndGetMore()
	{
		return "und mehr erhalten!";
	}

	protected override string _GetTemplateForLabelBecauseYouSubscribed()
	{
		return "Weil du ein Abo abgeschlossen hast!";
	}

	protected override string _GetTemplateForLabelBuyOnce()
	{
		return "Einmal kaufen";
	}

	protected override string _GetTemplateForLabelBuyRobux()
	{
		return "Robux kaufen";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "Abbrechen";
	}

	protected override string _GetTemplateForLabelConfirm()
	{
		return "Bestätigen";
	}

	protected override string _GetTemplateForLabelCurrentPlan()
	{
		return "Dein aktuelles Abo";
	}

	protected override string _GetTemplateForLabelGet10PercentOffRobux()
	{
		return "Erhalte 10% Rabatt auf Robux";
	}

	protected override string _GetTemplateForLabelGetMoreRobux()
	{
		return "Mehr Robux holen";
	}

	protected override string _GetTemplateForLabelMembershipManagementRecurring()
	{
		return "Um dein Premium-Abonnement zu verwalten, ruf die Abrechnungseinstellungen über einen Browser auf.";
	}

	/// <summary>
	/// Key: "Label.MembershipStatus"
	/// English String: "Your current plan is {premiumSubscription}. It will expire on {expirationDate}."
	/// </summary>
	public override string LabelMembershipStatus(string premiumSubscription, string expirationDate)
	{
		return $"Dein aktueller Plan ist {premiumSubscription}. Er wird am {expirationDate} verlängert.";
	}

	protected override string _GetTemplateForLabelMembershipStatus()
	{
		return "Dein aktueller Plan ist {premiumSubscription}. Er wird am {expirationDate} verlängert.";
	}

	/// <summary>
	/// Key: "Label.MembershipStatusExpiration"
	/// English String: "Your current plan is {premiumSubscription}. It will expire on {expirationDate}. You can repurchase or buy a new plan once your membership expires. "
	/// </summary>
	public override string LabelMembershipStatusExpiration(string premiumSubscription, string expirationDate)
	{
		return $"Dein aktueller Plan lautet {premiumSubscription} und läuft am {expirationDate} ab. Du kannst einen neuen Plan kaufen oder zurückkaufen, sobald deine Mitgliedschaft abgelaufen ist. ";
	}

	protected override string _GetTemplateForLabelMembershipStatusExpiration()
	{
		return "Dein aktueller Plan lautet {premiumSubscription} und läuft am {expirationDate} ab. Du kannst einen neuen Plan kaufen oder zurückkaufen, sobald deine Mitgliedschaft abgelaufen ist. ";
	}

	/// <summary>
	/// Key: "Label.MembershipStatusRecurring"
	/// English String: "Your current plan is {premiumSubscription}. It will renew on {renewal}."
	/// </summary>
	public override string LabelMembershipStatusRecurring(string premiumSubscription, string renewal)
	{
		return $"Dein aktueller Plan ist {premiumSubscription}. Er wird am {renewal} verlängert.";
	}

	protected override string _GetTemplateForLabelMembershipStatusRecurring()
	{
		return "Dein aktueller Plan ist {premiumSubscription}. Er wird am {renewal} verlängert.";
	}

	protected override string _GetTemplateForLabelNo()
	{
		return "Nein";
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
		return $"{robux}{subTextStart}/Monat{subTextEnd}";
	}

	protected override string _GetTemplateForLabelPriceMonth()
	{
		return "{robux}{subTextStart}/Monat{subTextEnd}";
	}

	/// <summary>
	/// Key: "Label.PricePerMonth"
	/// Please don't translate this one. This should be removed.
	/// English String: "{robuxAmount}/month"
	/// </summary>
	public override string LabelPricePerMonth(string robuxAmount)
	{
		return $"{robuxAmount}/Monat";
	}

	protected override string _GetTemplateForLabelPricePerMonth()
	{
		return "{robuxAmount}/Monat";
	}

	protected override string _GetTemplateForLabelRobloxPremium()
	{
		return "Roblox-Premium";
	}

	protected override string _GetTemplateForLabelRobloxPremium1000()
	{
		return "Roblox Premium 1000";
	}

	protected override string _GetTemplateForLabelRobloxPremium1000OneMonth()
	{
		return "Roblox Premiun 1000 Ein Monat";
	}

	protected override string _GetTemplateForLabelRobloxPremium2200()
	{
		return "Roblox Premium 2200";
	}

	protected override string _GetTemplateForLabelRobloxPremium2200OneMonth()
	{
		return "Roblox Premiun 2200 Ein Monat";
	}

	protected override string _GetTemplateForLabelRobloxPremium450()
	{
		return "Roblox Premium 450";
	}

	protected override string _GetTemplateForLabelRobloxPremium450OneMonth()
	{
		return "Roblox Premium 450 ein Monag";
	}

	protected override string _GetTemplateForLabelSellMore()
	{
		return "Mehr verkaufen";
	}

	protected override string _GetTemplateForLabelSinceYouSubscribed()
	{
		return "da du abonniert hast";
	}

	protected override string _GetTemplateForLabelSubscribe()
	{
		return "Abonnieren";
	}

	/// <summary>
	/// Key: "Label.SubscribeUpsell"
	/// English String: "Subscribe {upsellLinkStart}and get more!{upsellLinkEnd}"
	/// </summary>
	public override string LabelSubscribeUpsell(string upsellLinkStart, string upsellLinkEnd)
	{
		return $"Abonniere {upsellLinkStart} und erhalte mehr! {upsellLinkEnd}";
	}

	protected override string _GetTemplateForLabelSubscribeUpsell()
	{
		return "Abonniere {upsellLinkStart} und erhalte mehr! {upsellLinkEnd}";
	}

	protected override string _GetTemplateForLabelTrade()
	{
		return "Handeln";
	}

	protected override string _GetTemplateForLabelValuePacks()
	{
		return "Vorteilspakete";
	}

	protected override string _GetTemplateForLabelWantMoreRobux()
	{
		return "Du brauchst mehr Robux?";
	}

	protected override string _GetTemplateForLabelYes()
	{
		return "Ja";
	}

	/// <summary>
	/// Key: "Message.ConfirmCancellationModal"
	/// English String: "By clicking \"Confirm\" will end your Builders Club membership so you can subscribe to Roblox Premium.{newLine} You will receive a one-time payout of {robuxAmount}"
	/// </summary>
	public override string MessageConfirmCancellationModal(string newLine, string robuxAmount)
	{
		return $"Wenn du auf „Bestätigen“ klickst, beendest du deine „Builders Club“-Mitgliedschaft, damit du dich bei Roblox Premium anmelden kannst.{newLine}Du erhältst eine einmalige Auszahlung von {robuxAmount}.";
	}

	protected override string _GetTemplateForMessageConfirmCancellationModal()
	{
		return "Wenn du auf „Bestätigen“ klickst, beendest du deine „Builders Club“-Mitgliedschaft, damit du dich bei Roblox Premium anmelden kannst.{newLine}Du erhältst eine einmalige Auszahlung von {robuxAmount}.";
	}

	protected override string _GetTemplateForMessageGeneralError()
	{
		return "Bei der Aktualisierung deines Abonnements ist ein Fehler aufgetreten. Bitte versuche es später erneut.";
	}

	protected override string _GetTemplateForMessageNoDataError()
	{
		return "Keine Informationen zu Abonnements.";
	}

	protected override string _GetTemplateForMessageServerError()
	{
		return "Bei der Aktualisierung deines Abonnements ist ein Serverfehler aufgetreten. Bitte versuche es später erneut.";
	}

	/// <summary>
	/// Key: "Message.SubscriptionUnavailableModal"
	/// English String: "We are sorry, you cannot subscribe until your current cancelled plan has expired. Please re-subscribe on {expiredDate}."
	/// </summary>
	public override string MessageSubscriptionUnavailableModal(string expiredDate)
	{
		return $"Es tut uns leid, du kannst erst wieder ein Abonnement abschließen, wenn dein aktuell gekündigtes abgelaufen ist. Bitte schließe am {expiredDate} wieder ein Abonnement ab.";
	}

	protected override string _GetTemplateForMessageSubscriptionUnavailableModal()
	{
		return "Es tut uns leid, du kannst erst wieder ein Abonnement abschließen, wenn dein aktuell gekündigtes abgelaufen ist. Bitte schließe am {expiredDate} wieder ein Abonnement ab.";
	}

	/// <summary>
	/// Key: "Message.SwitchPlanBody"
	/// English String: "By clicking \"Confirm\" you authorize us to charge you {price} each month until you cancel or switch subscriptions effective {renewalDate}"
	/// </summary>
	public override string MessageSwitchPlanBody(string price, string renewalDate)
	{
		return $"Wenn du auf „Bestätigen“ klickst, erlaubst du uns, dir jeden Monat {price} zu berechnen, bis du kündigst oder mit Wirkung zum {renewalDate} das Abonnement änderst.";
	}

	protected override string _GetTemplateForMessageSwitchPlanBody()
	{
		return "Wenn du auf „Bestätigen“ klickst, erlaubst du uns, dir jeden Monat {price} zu berechnen, bis du kündigst oder mit Wirkung zum {renewalDate} das Abonnement änderst.";
	}

	protected override string _GetTemplateForMessageUnableToFindBc()
	{
		return "Informationen zum Builders Club dieses Benutzers können nicht gefunden werden.";
	}

	protected override string _GetTemplateForMessageUpgradeUnavailableModal()
	{
		return "Es tut uns leid, wir können dein Abonnement nicht ändern, weil es momentan kein gleichwertiges Paket zum Builders Club auf Lebenszeit gibt.";
	}

	protected override string _GetTemplateForSwitchPlanTitle()
	{
		return "Abonnementaktualisierung bestätigen";
	}
}
