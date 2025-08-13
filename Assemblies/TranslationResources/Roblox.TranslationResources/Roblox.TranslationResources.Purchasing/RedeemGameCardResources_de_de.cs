namespace Roblox.TranslationResources.Purchasing;

/// <summary>
/// This class overrides RedeemGameCardResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class RedeemGameCardResources_de_de : RedeemGameCardResources_en_us, IRedeemGameCardResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Dialog.Close"
	/// button text
	/// English String: "Close"
	/// </summary>
	public override string ActionDialogClose => "Schließen";

	/// <summary>
	/// Key: "Action.Dialog.Login"
	/// button text
	/// English String: "Login"
	/// </summary>
	public override string ActionDialogLogin => "Anmelden";

	/// <summary>
	/// Key: "Action.Dialog.SignUp"
	/// button text
	/// English String: "Sign Up"
	/// </summary>
	public override string ActionDialogSignUp => "Registrieren";

	/// <summary>
	/// Key: "Action.PurchaseCard"
	/// link text
	/// English String: "Purchase Card"
	/// </summary>
	public override string ActionPurchaseCard => "Karte kaufen";

	/// <summary>
	/// Key: "Action.Redeem"
	/// button text
	/// English String: "Redeem"
	/// </summary>
	public override string ActionRedeem => "Einlösen";

	/// <summary>
	/// Key: "Description.CombineCards"
	/// bullet point in a list
	/// English String: "Combine cards for more Roblox credit."
	/// </summary>
	public override string DescriptionCombineCards => "Kombiniere Karten, um mehr Roblox-Guthaben zu erhalten.";

	/// <summary>
	/// Key: "Description.Dialog.RobloxRedeemCard"
	/// diglog main text
	/// English String: "You must be logged in to your Roblox account to redeem your Game Card!"
	/// </summary>
	public override string DescriptionDialogRobloxRedeemCard => "Du musst bei deinem Roblox-Konto angemeldet sein, um deine Spielkarte einlösen zu können!";

	/// <summary>
	/// Key: "Description.LegalDisclaimer"
	/// descrption text
	/// English String: "Purchases can be made with only one form of payment. Game card credits cannot be combined with other forms of payment."
	/// </summary>
	public override string DescriptionLegalDisclaimer => "Jeder Kauf kann nur mit je einer Bezahlmethode durchgeführt werden. Spielkartenguthaben können nicht mit anderen Bezahlmethoden kombiniert werden.";

	/// <summary>
	/// Key: "Description.RetailersInfo"
	/// bullet point of a list
	/// English String: "Buy a Roblox game card at one of the participating retailers or receive a Roblox gift card from someone."
	/// </summary>
	public override string DescriptionRetailersInfo => "Kaufe eine Roblox-Spielkarte bei einem teilnehmenden Händler. Vielleicht hast du auch einen Roblox-Geschenkgutschein von jemandem erhalten.";

	/// <summary>
	/// Key: "Description.SpendRobloxCredit"
	/// bullet point of a list
	/// English String: "Spend your Roblox credit on Robux and Builders Club!"
	/// </summary>
	public override string DescriptionSpendRobloxCredit => "Gib dein Roblox-Guthaben für Robux und Builders Club aus!";

	/// <summary>
	/// Key: "Description.TypeCardPin"
	/// bullet point in a list
	/// English String: "Type in your card PIN in the redeem section."
	/// </summary>
	public override string DescriptionTypeCardPin => "Gib deine Karten-PIN im Einlösebereich ein.";

	/// <summary>
	/// Key: "Heading.EnterPin"
	/// section heading  - please keep PIN capitalized if the languiage supports it
	/// English String: "Enter PIN"
	/// </summary>
	public override string HeadingEnterPin => "PIN eingeben";

	/// <summary>
	/// Key: "Heading.GetRobloxCreditFor"
	/// section heading
	/// English String: "Get Roblox credit for"
	/// </summary>
	public override string HeadingGetRobloxCreditFor => "Hol dir Roblox-Guthaben für";

	/// <summary>
	/// Key: "Heading.HowToRedeem"
	/// modal(dialog box) heading
	/// English String: "How to Redeem"
	/// </summary>
	public override string HeadingHowToRedeem => "So funktioniert das Einlösen";

	/// <summary>
	/// Key: "Heading.HowToUse"
	/// section heading
	/// English String: "How to Use"
	/// </summary>
	public override string HeadingHowToUse => "So funktioniert’s";

	/// <summary>
	/// Key: "Heading.RedeemRobloxCards"
	/// page heading
	/// English String: "Redeem Roblox cards"
	/// </summary>
	public override string HeadingRedeemRobloxCards => "Roblox-Karten einlösen";

	/// <summary>
	/// Key: "Label.Dialog.RedeemGameCard"
	/// dialog title
	/// English String: "Redeem Roblox Game Card"
	/// </summary>
	public override string LabelDialogRedeemGameCard => "Roblox-Spielkarte einlösen";

	/// <summary>
	/// Key: "Label.NeedGameCard"
	/// label
	/// English String: "Need a Roblox game card?"
	/// </summary>
	public override string LabelNeedGameCard => "Du brauchst eine Roblox-Spielkarte?";

	/// <summary>
	/// Key: "Label.PinCode"
	/// please keep PIN capitalized if language supports capitalization
	/// English String: "PIN Code"
	/// </summary>
	public override string LabelPinCode => "PIN-Code";

	/// <summary>
	/// Key: "Label.RobuxRedeemed"
	/// English String: "Robux Redeemed:"
	/// </summary>
	public override string LabelRobuxRedeemed => "Eingelöste Robux:";

	/// <summary>
	/// Key: "Label.YourBalance"
	/// label
	/// English String: "Your Credit Balance:"
	/// </summary>
	public override string LabelYourBalance => "Dein Credits-Guthaben:";

	/// <summary>
	/// Key: "Response.AlreadyRedeemedError"
	/// error message
	/// English String: "This gift card has already been redeemed."
	/// </summary>
	public override string ResponseAlreadyRedeemedError => "Dieser Geschenkgutschein wurde bereits eingelöst.";

	/// <summary>
	/// Key: "Response.BonusPreview"
	/// success message upsell text
	/// English String: "Redeem one more Roblox card from GameStop to receive your bonus Robux."
	/// </summary>
	public override string ResponseBonusPreview => "Löse eine weitere Roblox-Karte von GameStop ein, um deine Bonus-Robux zu erhalten.";

	/// <summary>
	/// Key: "Response.BuildersClubExtended"
	/// success message
	/// English String: "Your Builders Club Membership has successfully been extended!"
	/// </summary>
	public override string ResponseBuildersClubExtended => "Deine „Builders Club“-Mitgliedschaft wurde verlängert!";

	/// <summary>
	/// Key: "Response.BuildersClubExtendedSubText"
	/// sub text on success message
	/// English String: "Please allow up to 5 minutes for the changes to take effect."
	/// </summary>
	public override string ResponseBuildersClubExtendedSubText => "Es kann bis zu 5 Minuten dauern, bis die Änderungen wirksam werden.";

	/// <summary>
	/// Key: "Response.BuildersClubRedeemed"
	/// success message
	/// English String: "Your Builders Club Membership has successfully been redeemed!"
	/// </summary>
	public override string ResponseBuildersClubRedeemed => "Deine „Builders Club“-Mitgliedschaft wurde eingelöst!";

	/// <summary>
	/// Key: "Response.CodeNotFoundError"
	/// error message
	/// English String: "No matching code found."
	/// </summary>
	public override string ResponseCodeNotFoundError => "Kein übereinstimmender Code gefunden.";

	/// <summary>
	/// Key: "Response.CouldNotFindObject"
	/// error message
	/// English String: "Could not find requested object."
	/// </summary>
	public override string ResponseCouldNotFindObject => "Angefordertes Objekt wurde nicht gefunden.";

	/// <summary>
	/// Key: "Response.FeatureDisabledError"
	/// error message
	/// English String: "This feature is currently disabled."
	/// </summary>
	public override string ResponseFeatureDisabledError => "Dieses Feature ist derzeit deaktiviert.";

	/// <summary>
	/// Key: "Response.GenericError"
	/// error message
	/// English String: "Something went wrong, please try again later."
	/// </summary>
	public override string ResponseGenericError => "Etwas ist schiefgelaufen. Bitte versuche es später erneut.";

	/// <summary>
	/// Key: "Response.InvalidPIN"
	/// error message
	/// English String: "Invalid PIN"
	/// </summary>
	public override string ResponseInvalidPIN => "Ungültige PIN";

	/// <summary>
	/// Key: "Response.LoginRequiredError"
	/// error message
	/// English String: "You must be logged in to perform this action."
	/// </summary>
	public override string ResponseLoginRequiredError => "Du musst angemeldet sein, um diese Aktion durchführen zu können.";

	/// <summary>
	/// Key: "Response.ObjectNotFoundError"
	/// error message
	/// English String: "Could not find the requested object. Please try your request again and contact customer service if this problem persists."
	/// </summary>
	public override string ResponseObjectNotFoundError => "Das angeforderte Objekt konnte nicht gefunden werden. Bitte stelle eine neue Anfrage und wende dich an den Kundenservice, falls das Problem weiterhin bestehen sollte.";

	/// <summary>
	/// Key: "Response.RedeemSuccess"
	/// success message
	/// English String: "You have successfully redeemed your card!"
	/// </summary>
	public override string ResponseRedeemSuccess => "Du hast deine Karte eingelöst!";

	/// <summary>
	/// Key: "Response.TooManyCodesRedeemedError"
	/// error message
	/// English String: "Too many codes redeemed. Try your request again later."
	/// </summary>
	public override string ResponseTooManyCodesRedeemedError => "Zu viele Codes eingelöst. Bitte versuche es später mit einer neuen Anfrage.";

	/// <summary>
	/// Key: "Response.TooManyRequestsError"
	/// error messages
	/// English String: "Too many failed request attempts. Try your request again later."
	/// </summary>
	public override string ResponseTooManyRequestsError => "Zu viele gescheiterte Anfragen. Bitte versuche es später mit einer neuen Anfrage.";

	public RedeemGameCardResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDialogClose()
	{
		return "Schließen";
	}

	protected override string _GetTemplateForActionDialogLogin()
	{
		return "Anmelden";
	}

	protected override string _GetTemplateForActionDialogSignUp()
	{
		return "Registrieren";
	}

	protected override string _GetTemplateForActionPurchaseCard()
	{
		return "Karte kaufen";
	}

	protected override string _GetTemplateForActionRedeem()
	{
		return "Einlösen";
	}

	protected override string _GetTemplateForDescriptionCombineCards()
	{
		return "Kombiniere Karten, um mehr Roblox-Guthaben zu erhalten.";
	}

	protected override string _GetTemplateForDescriptionDialogRobloxRedeemCard()
	{
		return "Du musst bei deinem Roblox-Konto angemeldet sein, um deine Spielkarte einlösen zu können!";
	}

	protected override string _GetTemplateForDescriptionLegalDisclaimer()
	{
		return "Jeder Kauf kann nur mit je einer Bezahlmethode durchgeführt werden. Spielkartenguthaben können nicht mit anderen Bezahlmethoden kombiniert werden.";
	}

	/// <summary>
	/// Key: "Description.RetailerLink"
	/// bullet point in a list
	/// English String: "Buy a Roblox game card at one of the {retailerLinkStart}participating retailers{retailerLinkEnd} or receive a Roblox gift card from someone. "
	/// </summary>
	public override string DescriptionRetailerLink(string retailerLinkStart, string retailerLinkEnd)
	{
		return $"Kaufe eine Roblox-Spielkarte bei einem {retailerLinkStart}teilnehmenden Händler{retailerLinkEnd}. Vielleicht hast du auch einen Roblox-Geschenkgutschein von jemandem erhalten. ";
	}

	protected override string _GetTemplateForDescriptionRetailerLink()
	{
		return "Kaufe eine Roblox-Spielkarte bei einem {retailerLinkStart}teilnehmenden Händler{retailerLinkEnd}. Vielleicht hast du auch einen Roblox-Geschenkgutschein von jemandem erhalten. ";
	}

	protected override string _GetTemplateForDescriptionRetailersInfo()
	{
		return "Kaufe eine Roblox-Spielkarte bei einem teilnehmenden Händler. Vielleicht hast du auch einen Roblox-Geschenkgutschein von jemandem erhalten.";
	}

	protected override string _GetTemplateForDescriptionSpendRobloxCredit()
	{
		return "Gib dein Roblox-Guthaben für Robux und Builders Club aus!";
	}

	protected override string _GetTemplateForDescriptionTypeCardPin()
	{
		return "Gib deine Karten-PIN im Einlösebereich ein.";
	}

	protected override string _GetTemplateForHeadingEnterPin()
	{
		return "PIN eingeben";
	}

	protected override string _GetTemplateForHeadingGetRobloxCreditFor()
	{
		return "Hol dir Roblox-Guthaben für";
	}

	protected override string _GetTemplateForHeadingHowToRedeem()
	{
		return "So funktioniert das Einlösen";
	}

	protected override string _GetTemplateForHeadingHowToUse()
	{
		return "So funktioniert’s";
	}

	protected override string _GetTemplateForHeadingRedeemRobloxCards()
	{
		return "Roblox-Karten einlösen";
	}

	protected override string _GetTemplateForLabelDialogRedeemGameCard()
	{
		return "Roblox-Spielkarte einlösen";
	}

	protected override string _GetTemplateForLabelNeedGameCard()
	{
		return "Du brauchst eine Roblox-Spielkarte?";
	}

	protected override string _GetTemplateForLabelPinCode()
	{
		return "PIN-Code";
	}

	protected override string _GetTemplateForLabelRobuxRedeemed()
	{
		return "Eingelöste Robux:";
	}

	protected override string _GetTemplateForLabelYourBalance()
	{
		return "Dein Credits-Guthaben:";
	}

	protected override string _GetTemplateForResponseAlreadyRedeemedError()
	{
		return "Dieser Geschenkgutschein wurde bereits eingelöst.";
	}

	protected override string _GetTemplateForResponseBonusPreview()
	{
		return "Löse eine weitere Roblox-Karte von GameStop ein, um deine Bonus-Robux zu erhalten.";
	}

	protected override string _GetTemplateForResponseBuildersClubExtended()
	{
		return "Deine „Builders Club“-Mitgliedschaft wurde verlängert!";
	}

	protected override string _GetTemplateForResponseBuildersClubExtendedSubText()
	{
		return "Es kann bis zu 5 Minuten dauern, bis die Änderungen wirksam werden.";
	}

	protected override string _GetTemplateForResponseBuildersClubRedeemed()
	{
		return "Deine „Builders Club“-Mitgliedschaft wurde eingelöst!";
	}

	protected override string _GetTemplateForResponseCodeNotFoundError()
	{
		return "Kein übereinstimmender Code gefunden.";
	}

	protected override string _GetTemplateForResponseCouldNotFindObject()
	{
		return "Angefordertes Objekt wurde nicht gefunden.";
	}

	protected override string _GetTemplateForResponseFeatureDisabledError()
	{
		return "Dieses Feature ist derzeit deaktiviert.";
	}

	protected override string _GetTemplateForResponseGenericError()
	{
		return "Etwas ist schiefgelaufen. Bitte versuche es später erneut.";
	}

	protected override string _GetTemplateForResponseInvalidPIN()
	{
		return "Ungültige PIN";
	}

	protected override string _GetTemplateForResponseLoginRequiredError()
	{
		return "Du musst angemeldet sein, um diese Aktion durchführen zu können.";
	}

	/// <summary>
	/// Key: "Response.MerchantNotFoundError"
	/// error message
	/// English String: "User tried to redeem Pin but the merchant does not exist. UserId: {authenticatedUserId} Pin Number: {cardPin}"
	/// </summary>
	public override string ResponseMerchantNotFoundError(string authenticatedUserId, string cardPin)
	{
		return $"Benutzer hat versucht, die PIN einzulösen, doch der Händler existiert nicht. Benutzer-ID: {authenticatedUserId} PIN: {cardPin}";
	}

	protected override string _GetTemplateForResponseMerchantNotFoundError()
	{
		return "Benutzer hat versucht, die PIN einzulösen, doch der Händler existiert nicht. Benutzer-ID: {authenticatedUserId} PIN: {cardPin}";
	}

	protected override string _GetTemplateForResponseObjectNotFoundError()
	{
		return "Das angeforderte Objekt konnte nicht gefunden werden. Bitte stelle eine neue Anfrage und wende dich an den Kundenservice, falls das Problem weiterhin bestehen sollte.";
	}

	protected override string _GetTemplateForResponseRedeemSuccess()
	{
		return "Du hast deine Karte eingelöst!";
	}

	/// <summary>
	/// Key: "Response.RedeemSuccessForProduct"
	/// success message
	/// English String: "You have successfully redeemed your card for {productName}"
	/// </summary>
	public override string ResponseRedeemSuccessForProduct(string productName)
	{
		return $"Du hast deine Karte für „{productName}“ eingelöst.";
	}

	protected override string _GetTemplateForResponseRedeemSuccessForProduct()
	{
		return "Du hast deine Karte für „{productName}“ eingelöst.";
	}

	protected override string _GetTemplateForResponseTooManyCodesRedeemedError()
	{
		return "Zu viele Codes eingelöst. Bitte versuche es später mit einer neuen Anfrage.";
	}

	protected override string _GetTemplateForResponseTooManyRequestsError()
	{
		return "Zu viele gescheiterte Anfragen. Bitte versuche es später mit einer neuen Anfrage.";
	}

	/// <summary>
	/// Key: "Response.TwoCardsBonus"
	/// success message
	/// English String: "Thanks for redeeming two Roblox cards from GameStop. {robuxCount} Robux have been added to your account."
	/// </summary>
	public override string ResponseTwoCardsBonus(string robuxCount)
	{
		return $"Danke, dass du zwei Roblox-Karten von GameStop eingelöst hast. Deinem Konto wurden {robuxCount} Robux gutgeschrieben.";
	}

	protected override string _GetTemplateForResponseTwoCardsBonus()
	{
		return "Danke, dass du zwei Roblox-Karten von GameStop eingelöst hast. Deinem Konto wurden {robuxCount} Robux gutgeschrieben.";
	}

	/// <summary>
	/// Key: "Response.WalmartRewardUpsell"
	/// upsell message
	/// English String: "Redeem one more Roblox card from Walmart to receive {rewardName}."
	/// </summary>
	public override string ResponseWalmartRewardUpsell(string rewardName)
	{
		return $"Löse eine weitere Roblox-Karte von Walmart ein, um „{rewardName}“ zu erhalten.";
	}

	protected override string _GetTemplateForResponseWalmartRewardUpsell()
	{
		return "Löse eine weitere Roblox-Karte von Walmart ein, um „{rewardName}“ zu erhalten.";
	}
}
