namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides DevexCashOutResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class DevexCashOutResources_de_de : DevexCashOutResources_en_us, IDevexCashOutResources, ITranslationResources
{
	/// <summary>
	/// Key: "CashOutForm.CashOutSubmit"
	/// English String: "Cash Out"
	/// </summary>
	public override string CashOutFormCashOutSubmit => "Auszahlen";

	/// <summary>
	/// Key: "CashOutForm.EmailAddressLabel"
	/// English String: "Email Address"
	/// </summary>
	public override string CashOutFormEmailAddressLabel => "Email-Adresse";

	/// <summary>
	/// Key: "CashOutForm.ExchangeRateLabel"
	/// English String: "Exchange Rate"
	/// </summary>
	public override string CashOutFormExchangeRateLabel => "Wechselkurs";

	/// <summary>
	/// Key: "CashOutForm.FirstNameLabel"
	/// English String: "First Name"
	/// </summary>
	public override string CashOutFormFirstNameLabel => "Vorname";

	/// <summary>
	/// Key: "CashOutForm.LastNameLabel"
	/// English String: "Last Name"
	/// </summary>
	public override string CashOutFormLastNameLabel => "Nachname";

	/// <summary>
	/// Key: "CashOutForm.Robux"
	/// English String: "Robux"
	/// </summary>
	public override string CashOutFormRobux => "Robux";

	/// <summary>
	/// Key: "CashOutForm.RobuxAmountLabel"
	/// English String: "Robux Amount"
	/// </summary>
	public override string CashOutFormRobuxAmountLabel => "Robux-Betrag";

	/// <summary>
	/// Key: "CashOutForm.YouGetLabel"
	/// English String: "You get up to:"
	/// </summary>
	public override string CashOutFormYouGetLabel => "Du erhältst bis zu:";

	/// <summary>
	/// Key: "Label.PasswordLabel"
	/// English String: "Password"
	/// </summary>
	public override string LabelPasswordLabel => "Passwort";

	/// <summary>
	/// Key: "Label.PasswordPlaceholder"
	/// English String: "Verify Account Password"
	/// </summary>
	public override string LabelPasswordPlaceholder => "Kontopasswort verifizieren";

	/// <summary>
	/// Key: "PageHeader.Description"
	/// English String: "Create games, earn money."
	/// </summary>
	public override string PageHeaderDescription => "Erstelle Spiele, verdiene Geld.";

	/// <summary>
	/// Key: "PageHeader.Title"
	/// English String: "Developer Exchange"
	/// </summary>
	public override string PageHeaderTitle => "Developer Exchange";

	/// <summary>
	/// Key: "Response.CannotLoadExchangeRate"
	/// English String: "Sorry, we were unable to load the current exchange rate. Please try again."
	/// </summary>
	public override string ResponseCannotLoadExchangeRate => "Der aktuelle Wechselkurs konnte leider nicht geladen werden. Bitte versuche es erneut.";

	/// <summary>
	/// Key: "Response.CurrencyOperationUnavailable"
	/// English String: "Sorry, something went wrong. Please try again."
	/// </summary>
	public override string ResponseCurrencyOperationUnavailable => "Tut uns leid, etwas ist schiefgelaufen. Bitte versuche es erneut.";

	/// <summary>
	/// Key: "Response.FirstNameRequiredErrorMessage"
	/// English String: "Please enter your first name."
	/// </summary>
	public override string ResponseFirstNameRequiredErrorMessage => "Bitte gib deinen Vornamen ein.";

	/// <summary>
	/// Key: "Response.IncorrectCredentials"
	/// English String: "Invalid password."
	/// </summary>
	public override string ResponseIncorrectCredentials => "Ungültiges Passwort.";

	/// <summary>
	/// Key: "Response.InsufficientFunds"
	/// English String: "You do not have enough Robux to complete this transaction."
	/// </summary>
	public override string ResponseInsufficientFunds => "Du hast nicht genug Robux, um diese Transaktion abzuschließen.";

	/// <summary>
	/// Key: "Response.InvalidEmailErrorMessage"
	/// English String: "Please enter a valid email address."
	/// </summary>
	public override string ResponseInvalidEmailErrorMessage => "Bitte gib eine gültige E-Mail-Adresse ein.";

	/// <summary>
	/// Key: "Response.LastNameRequiredErrorMessage"
	/// English String: "Please enter your last name."
	/// </summary>
	public override string ResponseLastNameRequiredErrorMessage => "Bitte gib deinen Nachnamen ein.";

	/// <summary>
	/// Key: "Response.RobuxAmountIsBelowMinimumCashoutThreshold"
	/// English String: "Robux amount below minimum cash out threshold."
	/// </summary>
	public override string ResponseRobuxAmountIsBelowMinimumCashoutThreshold => "Robux-Betrag unterhalb der Mindestauszahlungsgrenze.";

	/// <summary>
	/// Key: "Response.UnknownError"
	/// English String: "Sorry, something went wrong. Please try again."
	/// </summary>
	public override string ResponseUnknownError => "Tut uns leid, etwas ist schiefgelaufen. Bitte versuche es erneut.";

	/// <summary>
	/// Key: "Response.UserBalanceDoesNotHaveMoreRobuxThanMinimumCashout"
	/// English String: "You cannot cash out for less than the minimum amount."
	/// </summary>
	public override string ResponseUserBalanceDoesNotHaveMoreRobuxThanMinimumCashout => "Du kannst nicht weniger als den Mindestbetrag auszahlen.";

	/// <summary>
	/// Key: "Response.UserCannotCashout"
	/// English String: "Sorry, you are not eligible to cash out at this time."
	/// </summary>
	public override string ResponseUserCannotCashout => "Es tut uns leid, du bist derzeit nicht zur Auszahlung berechtigt.";

	/// <summary>
	/// Key: "Response.UserDoesNotHavePremium"
	/// English String: "You need a Roblox Premium subscription to cash out."
	/// </summary>
	public override string ResponseUserDoesNotHavePremium => "Du benötigst ein Roblox-Premium-Abonnement, um auszahlen zu können.";

	/// <summary>
	/// Key: "Response.UserDoesNotHaveVerifiedEmail"
	/// English String: "You need a verified email address to cash out."
	/// </summary>
	public override string ResponseUserDoesNotHaveVerifiedEmail => "Du benötigst eine bestätigte E-Mail-Adresse, um auszahlen zu können.";

	/// <summary>
	/// Key: "Response.UserMustProvideFirstAndLastName"
	/// English String: "You need to provide your first and last name."
	/// </summary>
	public override string ResponseUserMustProvideFirstAndLastName => "Du musst deinen Vor- und Nachnamen angeben.";

	/// <summary>
	/// Key: "Response.UserNotEligibleError"
	/// English String: "Sorry, you are not eligible to cash out at this time."
	/// </summary>
	public override string ResponseUserNotEligibleError => "Tut uns leid, du bist derzeit nicht zur Auszahlung berechtigt.";

	public DevexCashOutResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForCashOutFormCashOutSubmit()
	{
		return "Auszahlen";
	}

	/// <summary>
	/// Key: "CashOutForm.Description"
	/// English String: "Please complete this form to begin processing your payment. The email address you provide must match the email address on your Roblox DevEx Portal account. If you need assistance with this form, {linkStart}please visit the Help Center.{linkEnd}"
	/// </summary>
	public override string CashOutFormDescription(string linkStart, string linkEnd)
	{
		return $"Bitte füll dieses Formular aus, um mit der Bearbeitung deiner Zahlung zu beginnen. Die unten angegebene Adresse muss mit der Adresse in deinem Roblox DevEx Portal-Konto übereinstimmen. Wenn du Hilfe bei diesem Formular benötigst, {linkStart}, besuche bitte unsere Hilfeseite. {linkEnd}";
	}

	protected override string _GetTemplateForCashOutFormDescription()
	{
		return "Bitte füll dieses Formular aus, um mit der Bearbeitung deiner Zahlung zu beginnen. Die unten angegebene Adresse muss mit der Adresse in deinem Roblox DevEx Portal-Konto übereinstimmen. Wenn du Hilfe bei diesem Formular benötigst, {linkStart}, besuche bitte unsere Hilfeseite. {linkEnd}";
	}

	protected override string _GetTemplateForCashOutFormEmailAddressLabel()
	{
		return "Email-Adresse";
	}

	protected override string _GetTemplateForCashOutFormExchangeRateLabel()
	{
		return "Wechselkurs";
	}

	protected override string _GetTemplateForCashOutFormFirstNameLabel()
	{
		return "Vorname";
	}

	protected override string _GetTemplateForCashOutFormLastNameLabel()
	{
		return "Nachname";
	}

	protected override string _GetTemplateForCashOutFormRobux()
	{
		return "Robux";
	}

	protected override string _GetTemplateForCashOutFormRobuxAmountLabel()
	{
		return "Robux-Betrag";
	}

	/// <summary>
	/// Key: "CashOutForm.TermsOfService"
	/// English String: "I have read and agree to the {linkStart}Terms of Use{linkEnd}"
	/// </summary>
	public override string CashOutFormTermsOfService(string linkStart, string linkEnd)
	{
		return $"Ich habe die {linkStart} Nutzungsbedingungen {linkEnd} gelesen und bin damit einverstanden";
	}

	protected override string _GetTemplateForCashOutFormTermsOfService()
	{
		return "Ich habe die {linkStart} Nutzungsbedingungen {linkEnd} gelesen und bin damit einverstanden";
	}

	protected override string _GetTemplateForCashOutFormYouGetLabel()
	{
		return "Du erhältst bis zu:";
	}

	protected override string _GetTemplateForLabelPasswordLabel()
	{
		return "Passwort";
	}

	protected override string _GetTemplateForLabelPasswordPlaceholder()
	{
		return "Kontopasswort verifizieren";
	}

	protected override string _GetTemplateForPageHeaderDescription()
	{
		return "Erstelle Spiele, verdiene Geld.";
	}

	protected override string _GetTemplateForPageHeaderTitle()
	{
		return "Developer Exchange";
	}

	protected override string _GetTemplateForResponseCannotLoadExchangeRate()
	{
		return "Der aktuelle Wechselkurs konnte leider nicht geladen werden. Bitte versuche es erneut.";
	}

	protected override string _GetTemplateForResponseCurrencyOperationUnavailable()
	{
		return "Tut uns leid, etwas ist schiefgelaufen. Bitte versuche es erneut.";
	}

	protected override string _GetTemplateForResponseFirstNameRequiredErrorMessage()
	{
		return "Bitte gib deinen Vornamen ein.";
	}

	protected override string _GetTemplateForResponseIncorrectCredentials()
	{
		return "Ungültiges Passwort.";
	}

	protected override string _GetTemplateForResponseInsufficientFunds()
	{
		return "Du hast nicht genug Robux, um diese Transaktion abzuschließen.";
	}

	protected override string _GetTemplateForResponseInvalidEmailErrorMessage()
	{
		return "Bitte gib eine gültige E-Mail-Adresse ein.";
	}

	protected override string _GetTemplateForResponseLastNameRequiredErrorMessage()
	{
		return "Bitte gib deinen Nachnamen ein.";
	}

	protected override string _GetTemplateForResponseRobuxAmountIsBelowMinimumCashoutThreshold()
	{
		return "Robux-Betrag unterhalb der Mindestauszahlungsgrenze.";
	}

	protected override string _GetTemplateForResponseUnknownError()
	{
		return "Tut uns leid, etwas ist schiefgelaufen. Bitte versuche es erneut.";
	}

	protected override string _GetTemplateForResponseUserBalanceDoesNotHaveMoreRobuxThanMinimumCashout()
	{
		return "Du kannst nicht weniger als den Mindestbetrag auszahlen.";
	}

	protected override string _GetTemplateForResponseUserCannotCashout()
	{
		return "Es tut uns leid, du bist derzeit nicht zur Auszahlung berechtigt.";
	}

	protected override string _GetTemplateForResponseUserDoesNotHavePremium()
	{
		return "Du benötigst ein Roblox-Premium-Abonnement, um auszahlen zu können.";
	}

	protected override string _GetTemplateForResponseUserDoesNotHaveVerifiedEmail()
	{
		return "Du benötigst eine bestätigte E-Mail-Adresse, um auszahlen zu können.";
	}

	protected override string _GetTemplateForResponseUserMustProvideFirstAndLastName()
	{
		return "Du musst deinen Vor- und Nachnamen angeben.";
	}

	protected override string _GetTemplateForResponseUserNotEligibleError()
	{
		return "Tut uns leid, du bist derzeit nicht zur Auszahlung berechtigt.";
	}
}
