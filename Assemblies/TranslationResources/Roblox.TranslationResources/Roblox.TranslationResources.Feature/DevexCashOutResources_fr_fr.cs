namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides DevexCashOutResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class DevexCashOutResources_fr_fr : DevexCashOutResources_en_us, IDevexCashOutResources, ITranslationResources
{
	/// <summary>
	/// Key: "CashOutForm.CashOutSubmit"
	/// English String: "Cash Out"
	/// </summary>
	public override string CashOutFormCashOutSubmit => "Encaisser";

	/// <summary>
	/// Key: "CashOutForm.EmailAddressLabel"
	/// English String: "Email Address"
	/// </summary>
	public override string CashOutFormEmailAddressLabel => "Adresse e-mail";

	/// <summary>
	/// Key: "CashOutForm.ExchangeRateLabel"
	/// English String: "Exchange Rate"
	/// </summary>
	public override string CashOutFormExchangeRateLabel => "Taux de change";

	/// <summary>
	/// Key: "CashOutForm.FirstNameLabel"
	/// English String: "First Name"
	/// </summary>
	public override string CashOutFormFirstNameLabel => "Prénom";

	/// <summary>
	/// Key: "CashOutForm.LastNameLabel"
	/// English String: "Last Name"
	/// </summary>
	public override string CashOutFormLastNameLabel => "Nom de famille";

	/// <summary>
	/// Key: "CashOutForm.Robux"
	/// English String: "Robux"
	/// </summary>
	public override string CashOutFormRobux => "Robux";

	/// <summary>
	/// Key: "CashOutForm.RobuxAmountLabel"
	/// English String: "Robux Amount"
	/// </summary>
	public override string CashOutFormRobuxAmountLabel => "Montant de Robux";

	/// <summary>
	/// Key: "CashOutForm.YouGetLabel"
	/// English String: "You get up to:"
	/// </summary>
	public override string CashOutFormYouGetLabel => "Vous obtenez";

	/// <summary>
	/// Key: "Label.PasswordLabel"
	/// English String: "Password"
	/// </summary>
	public override string LabelPasswordLabel => "Mot de passe";

	/// <summary>
	/// Key: "Label.PasswordPlaceholder"
	/// English String: "Verify Account Password"
	/// </summary>
	public override string LabelPasswordPlaceholder => "Vérifier le mot de passe du compte";

	/// <summary>
	/// Key: "PageHeader.Description"
	/// English String: "Create games, earn money."
	/// </summary>
	public override string PageHeaderDescription => "Crée des jeux, gagne de l'argent.";

	/// <summary>
	/// Key: "PageHeader.Title"
	/// English String: "Developer Exchange"
	/// </summary>
	public override string PageHeaderTitle => "Developer Exchange";

	/// <summary>
	/// Key: "Response.CannotLoadExchangeRate"
	/// English String: "Sorry, we were unable to load the current exchange rate. Please try again."
	/// </summary>
	public override string ResponseCannotLoadExchangeRate => "Désolé, nous n'avons pas pu charger le taux de change actuel. Veuillez réessayer plus tard.";

	/// <summary>
	/// Key: "Response.CurrencyOperationUnavailable"
	/// English String: "Sorry, something went wrong. Please try again."
	/// </summary>
	public override string ResponseCurrencyOperationUnavailable => "Désolé, un problème est survenu. Veuillez réessayer.";

	/// <summary>
	/// Key: "Response.FirstNameRequiredErrorMessage"
	/// English String: "Please enter your first name."
	/// </summary>
	public override string ResponseFirstNameRequiredErrorMessage => "Veuillez saisir votre prénom.";

	/// <summary>
	/// Key: "Response.IncorrectCredentials"
	/// English String: "Invalid password."
	/// </summary>
	public override string ResponseIncorrectCredentials => "Mot de passe invalide.";

	/// <summary>
	/// Key: "Response.InsufficientFunds"
	/// English String: "You do not have enough Robux to complete this transaction."
	/// </summary>
	public override string ResponseInsufficientFunds => "Vous n'avez pas assez de Robux pour finaliser cette transaction.";

	/// <summary>
	/// Key: "Response.InvalidEmailErrorMessage"
	/// English String: "Please enter a valid email address."
	/// </summary>
	public override string ResponseInvalidEmailErrorMessage => "Veuillez saisir une adresse e-mail valide.";

	/// <summary>
	/// Key: "Response.LastNameRequiredErrorMessage"
	/// English String: "Please enter your last name."
	/// </summary>
	public override string ResponseLastNameRequiredErrorMessage => "Veuillez saisir votre nom.";

	/// <summary>
	/// Key: "Response.RobuxAmountIsBelowMinimumCashoutThreshold"
	/// English String: "Robux amount below minimum cash out threshold."
	/// </summary>
	public override string ResponseRobuxAmountIsBelowMinimumCashoutThreshold => "Montant de Robux inférieur au seuil minimum de retrait.";

	/// <summary>
	/// Key: "Response.UnknownError"
	/// English String: "Sorry, something went wrong. Please try again."
	/// </summary>
	public override string ResponseUnknownError => "Désolé, un problème est survenu. Veuillez réessayer.";

	/// <summary>
	/// Key: "Response.UserBalanceDoesNotHaveMoreRobuxThanMinimumCashout"
	/// English String: "You cannot cash out for less than the minimum amount."
	/// </summary>
	public override string ResponseUserBalanceDoesNotHaveMoreRobuxThanMinimumCashout => "Vous ne pouvez pas effectuer de retrait inférieur au montant minimum.";

	/// <summary>
	/// Key: "Response.UserCannotCashout"
	/// English String: "Sorry, you are not eligible to cash out at this time."
	/// </summary>
	public override string ResponseUserCannotCashout => "Vous n'êtes pas admissible pour effectuer un retrait pour le moment.";

	/// <summary>
	/// Key: "Response.UserDoesNotHavePremium"
	/// English String: "You need a Roblox Premium subscription to cash out."
	/// </summary>
	public override string ResponseUserDoesNotHavePremium => "Vous devez disposer d'un abonnement à Roblox Premium pour effectuer des retraits.";

	/// <summary>
	/// Key: "Response.UserDoesNotHaveVerifiedEmail"
	/// English String: "You need a verified email address to cash out."
	/// </summary>
	public override string ResponseUserDoesNotHaveVerifiedEmail => "Vous devez avoir une adresse e-mail vérifiée afin d'effectuer des retraits.";

	/// <summary>
	/// Key: "Response.UserMustProvideFirstAndLastName"
	/// English String: "You need to provide your first and last name."
	/// </summary>
	public override string ResponseUserMustProvideFirstAndLastName => "Vous devez indiquer vos nom et prénom.";

	/// <summary>
	/// Key: "Response.UserNotEligibleError"
	/// English String: "Sorry, you are not eligible to cash out at this time."
	/// </summary>
	public override string ResponseUserNotEligibleError => "Vous n'êtes pas admissible pour effectuer un retrait pour le moment.";

	public DevexCashOutResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForCashOutFormCashOutSubmit()
	{
		return "Encaisser";
	}

	/// <summary>
	/// Key: "CashOutForm.Description"
	/// English String: "Please complete this form to begin processing your payment. The email address you provide must match the email address on your Roblox DevEx Portal account. If you need assistance with this form, {linkStart}please visit the Help Center.{linkEnd}"
	/// </summary>
	public override string CashOutFormDescription(string linkStart, string linkEnd)
	{
		return $"Veuillez remplir ce formulaire pour lancer le traitement de votre paiement. L'adresse indiquée ci-dessous doit correspondre à celle de votre compte du portail DevEx de Roblox. Si vous avez besoin d'aide pour remplir le formulaire, {linkStart}consultez notre page dédiée.{linkEnd}";
	}

	protected override string _GetTemplateForCashOutFormDescription()
	{
		return "Veuillez remplir ce formulaire pour lancer le traitement de votre paiement. L'adresse indiquée ci-dessous doit correspondre à celle de votre compte du portail DevEx de Roblox. Si vous avez besoin d'aide pour remplir le formulaire, {linkStart}consultez notre page dédiée.{linkEnd}";
	}

	protected override string _GetTemplateForCashOutFormEmailAddressLabel()
	{
		return "Adresse e-mail";
	}

	protected override string _GetTemplateForCashOutFormExchangeRateLabel()
	{
		return "Taux de change";
	}

	protected override string _GetTemplateForCashOutFormFirstNameLabel()
	{
		return "Prénom";
	}

	protected override string _GetTemplateForCashOutFormLastNameLabel()
	{
		return "Nom de famille";
	}

	protected override string _GetTemplateForCashOutFormRobux()
	{
		return "Robux";
	}

	protected override string _GetTemplateForCashOutFormRobuxAmountLabel()
	{
		return "Montant de Robux";
	}

	/// <summary>
	/// Key: "CashOutForm.TermsOfService"
	/// English String: "I have read and agree to the {linkStart}Terms of Use{linkEnd}"
	/// </summary>
	public override string CashOutFormTermsOfService(string linkStart, string linkEnd)
	{
		return $"J'ai lu et j'accepte les {linkStart}Conditions d'utilisation{linkEnd}";
	}

	protected override string _GetTemplateForCashOutFormTermsOfService()
	{
		return "J'ai lu et j'accepte les {linkStart}Conditions d'utilisation{linkEnd}";
	}

	protected override string _GetTemplateForCashOutFormYouGetLabel()
	{
		return "Vous obtenez";
	}

	protected override string _GetTemplateForLabelPasswordLabel()
	{
		return "Mot de passe";
	}

	protected override string _GetTemplateForLabelPasswordPlaceholder()
	{
		return "Vérifier le mot de passe du compte";
	}

	protected override string _GetTemplateForPageHeaderDescription()
	{
		return "Crée des jeux, gagne de l'argent.";
	}

	protected override string _GetTemplateForPageHeaderTitle()
	{
		return "Developer Exchange";
	}

	protected override string _GetTemplateForResponseCannotLoadExchangeRate()
	{
		return "Désolé, nous n'avons pas pu charger le taux de change actuel. Veuillez réessayer plus tard.";
	}

	protected override string _GetTemplateForResponseCurrencyOperationUnavailable()
	{
		return "Désolé, un problème est survenu. Veuillez réessayer.";
	}

	protected override string _GetTemplateForResponseFirstNameRequiredErrorMessage()
	{
		return "Veuillez saisir votre prénom.";
	}

	protected override string _GetTemplateForResponseIncorrectCredentials()
	{
		return "Mot de passe invalide.";
	}

	protected override string _GetTemplateForResponseInsufficientFunds()
	{
		return "Vous n'avez pas assez de Robux pour finaliser cette transaction.";
	}

	protected override string _GetTemplateForResponseInvalidEmailErrorMessage()
	{
		return "Veuillez saisir une adresse e-mail valide.";
	}

	protected override string _GetTemplateForResponseLastNameRequiredErrorMessage()
	{
		return "Veuillez saisir votre nom.";
	}

	protected override string _GetTemplateForResponseRobuxAmountIsBelowMinimumCashoutThreshold()
	{
		return "Montant de Robux inférieur au seuil minimum de retrait.";
	}

	protected override string _GetTemplateForResponseUnknownError()
	{
		return "Désolé, un problème est survenu. Veuillez réessayer.";
	}

	protected override string _GetTemplateForResponseUserBalanceDoesNotHaveMoreRobuxThanMinimumCashout()
	{
		return "Vous ne pouvez pas effectuer de retrait inférieur au montant minimum.";
	}

	protected override string _GetTemplateForResponseUserCannotCashout()
	{
		return "Vous n'êtes pas admissible pour effectuer un retrait pour le moment.";
	}

	protected override string _GetTemplateForResponseUserDoesNotHavePremium()
	{
		return "Vous devez disposer d'un abonnement à Roblox Premium pour effectuer des retraits.";
	}

	protected override string _GetTemplateForResponseUserDoesNotHaveVerifiedEmail()
	{
		return "Vous devez avoir une adresse e-mail vérifiée afin d'effectuer des retraits.";
	}

	protected override string _GetTemplateForResponseUserMustProvideFirstAndLastName()
	{
		return "Vous devez indiquer vos nom et prénom.";
	}

	protected override string _GetTemplateForResponseUserNotEligibleError()
	{
		return "Vous n'êtes pas admissible pour effectuer un retrait pour le moment.";
	}
}
