namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides DevexCashOutResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class DevexCashOutResources_es_es : DevexCashOutResources_en_us, IDevexCashOutResources, ITranslationResources
{
	/// <summary>
	/// Key: "CashOutForm.CashOutSubmit"
	/// English String: "Cash Out"
	/// </summary>
	public override string CashOutFormCashOutSubmit => "Convertir en efectivo";

	/// <summary>
	/// Key: "CashOutForm.EmailAddressLabel"
	/// English String: "Email Address"
	/// </summary>
	public override string CashOutFormEmailAddressLabel => "Dirección de correo electrónico";

	/// <summary>
	/// Key: "CashOutForm.ExchangeRateLabel"
	/// English String: "Exchange Rate"
	/// </summary>
	public override string CashOutFormExchangeRateLabel => "Tasa de cambio";

	/// <summary>
	/// Key: "CashOutForm.FirstNameLabel"
	/// English String: "First Name"
	/// </summary>
	public override string CashOutFormFirstNameLabel => "Nombre";

	/// <summary>
	/// Key: "CashOutForm.LastNameLabel"
	/// English String: "Last Name"
	/// </summary>
	public override string CashOutFormLastNameLabel => "Apellido(s)";

	/// <summary>
	/// Key: "CashOutForm.Robux"
	/// English String: "Robux"
	/// </summary>
	public override string CashOutFormRobux => "Robux";

	/// <summary>
	/// Key: "CashOutForm.RobuxAmountLabel"
	/// English String: "Robux Amount"
	/// </summary>
	public override string CashOutFormRobuxAmountLabel => "Cantidad de Robux";

	/// <summary>
	/// Key: "CashOutForm.YouGetLabel"
	/// English String: "You get up to:"
	/// </summary>
	public override string CashOutFormYouGetLabel => "Recibirás hasta:";

	/// <summary>
	/// Key: "Label.PasswordLabel"
	/// English String: "Password"
	/// </summary>
	public override string LabelPasswordLabel => "Contraseña";

	/// <summary>
	/// Key: "Label.PasswordPlaceholder"
	/// English String: "Verify Account Password"
	/// </summary>
	public override string LabelPasswordPlaceholder => "Verificar contraseña de la cuenta";

	/// <summary>
	/// Key: "PageHeader.Description"
	/// English String: "Create games, earn money."
	/// </summary>
	public override string PageHeaderDescription => "Crea juegos, gana dinero.";

	/// <summary>
	/// Key: "PageHeader.Title"
	/// English String: "Developer Exchange"
	/// </summary>
	public override string PageHeaderTitle => "Cambio para desarrolladores";

	/// <summary>
	/// Key: "Response.CannotLoadExchangeRate"
	/// English String: "Sorry, we were unable to load the current exchange rate. Please try again."
	/// </summary>
	public override string ResponseCannotLoadExchangeRate => "Lo sentimos, pero en este momento no podemos cargar la tasa de cambio actual. Inténtalo de nuevo.";

	/// <summary>
	/// Key: "Response.CurrencyOperationUnavailable"
	/// English String: "Sorry, something went wrong. Please try again."
	/// </summary>
	public override string ResponseCurrencyOperationUnavailable => "Algo ha ido mal. Inténtalo de nuevo.";

	/// <summary>
	/// Key: "Response.FirstNameRequiredErrorMessage"
	/// English String: "Please enter your first name."
	/// </summary>
	public override string ResponseFirstNameRequiredErrorMessage => "Introduce tu nombre de pila.";

	/// <summary>
	/// Key: "Response.IncorrectCredentials"
	/// English String: "Invalid password."
	/// </summary>
	public override string ResponseIncorrectCredentials => "Contraseña no válida.";

	/// <summary>
	/// Key: "Response.InsufficientFunds"
	/// English String: "You do not have enough Robux to complete this transaction."
	/// </summary>
	public override string ResponseInsufficientFunds => "No tienes suficientes Robux finalizar esta transacción.";

	/// <summary>
	/// Key: "Response.InvalidEmailErrorMessage"
	/// English String: "Please enter a valid email address."
	/// </summary>
	public override string ResponseInvalidEmailErrorMessage => "Introduce una dirección de correo electrónico válida.";

	/// <summary>
	/// Key: "Response.LastNameRequiredErrorMessage"
	/// English String: "Please enter your last name."
	/// </summary>
	public override string ResponseLastNameRequiredErrorMessage => "Introduce tu apellido.";

	/// <summary>
	/// Key: "Response.RobuxAmountIsBelowMinimumCashoutThreshold"
	/// English String: "Robux amount below minimum cash out threshold."
	/// </summary>
	public override string ResponseRobuxAmountIsBelowMinimumCashoutThreshold => "La cantidad de Robux está por debajo del monto mínimo establecido para convertir en efectivo.";

	/// <summary>
	/// Key: "Response.UnknownError"
	/// English String: "Sorry, something went wrong. Please try again."
	/// </summary>
	public override string ResponseUnknownError => "Algo ha ido mal. Inténtalo de nuevo.";

	/// <summary>
	/// Key: "Response.UserBalanceDoesNotHaveMoreRobuxThanMinimumCashout"
	/// English String: "You cannot cash out for less than the minimum amount."
	/// </summary>
	public override string ResponseUserBalanceDoesNotHaveMoreRobuxThanMinimumCashout => "No puedes convertir en efectivo si tienes una cantidad de Robux menor a la mínima establecida para la conversión.";

	/// <summary>
	/// Key: "Response.UserCannotCashout"
	/// English String: "Sorry, you are not eligible to cash out at this time."
	/// </summary>
	public override string ResponseUserCannotCashout => "Lo sentimos, pero no eres elegible para convertir en efectivo en este momento.";

	/// <summary>
	/// Key: "Response.UserDoesNotHavePremium"
	/// English String: "You need a Roblox Premium subscription to cash out."
	/// </summary>
	public override string ResponseUserDoesNotHavePremium => "Necesitas una suscripción a Roblox Premium para convertir en efectivo.";

	/// <summary>
	/// Key: "Response.UserDoesNotHaveVerifiedEmail"
	/// English String: "You need a verified email address to cash out."
	/// </summary>
	public override string ResponseUserDoesNotHaveVerifiedEmail => "Necesitas una dirección de correo electrónico verificada para convertir en efectivo.";

	/// <summary>
	/// Key: "Response.UserMustProvideFirstAndLastName"
	/// English String: "You need to provide your first and last name."
	/// </summary>
	public override string ResponseUserMustProvideFirstAndLastName => "Necesitas proporcionar tu nombre y apellido.";

	/// <summary>
	/// Key: "Response.UserNotEligibleError"
	/// English String: "Sorry, you are not eligible to cash out at this time."
	/// </summary>
	public override string ResponseUserNotEligibleError => "Lo sentimos, pero no eres elegible para convertir en efectivo en este momento.";

	public DevexCashOutResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForCashOutFormCashOutSubmit()
	{
		return "Convertir en efectivo";
	}

	/// <summary>
	/// Key: "CashOutForm.Description"
	/// English String: "Please complete this form to begin processing your payment. The email address you provide must match the email address on your Roblox DevEx Portal account. If you need assistance with this form, {linkStart}please visit the Help Center.{linkEnd}"
	/// </summary>
	public override string CashOutFormDescription(string linkStart, string linkEnd)
	{
		return $"Llena este formulario para que se empiece a procesar tu pago. La dirección de correo electrónico que ingresas aquí deberá coincidir con aquella que proporcionaste en tu cuenta del Portal de Roblox DevEx. Si necesitas ayuda para llenarlo, {linkStart}visita nuestro Centro de ayuda.{linkEnd}";
	}

	protected override string _GetTemplateForCashOutFormDescription()
	{
		return "Llena este formulario para que se empiece a procesar tu pago. La dirección de correo electrónico que ingresas aquí deberá coincidir con aquella que proporcionaste en tu cuenta del Portal de Roblox DevEx. Si necesitas ayuda para llenarlo, {linkStart}visita nuestro Centro de ayuda.{linkEnd}";
	}

	protected override string _GetTemplateForCashOutFormEmailAddressLabel()
	{
		return "Dirección de correo electrónico";
	}

	protected override string _GetTemplateForCashOutFormExchangeRateLabel()
	{
		return "Tasa de cambio";
	}

	protected override string _GetTemplateForCashOutFormFirstNameLabel()
	{
		return "Nombre";
	}

	protected override string _GetTemplateForCashOutFormLastNameLabel()
	{
		return "Apellido(s)";
	}

	protected override string _GetTemplateForCashOutFormRobux()
	{
		return "Robux";
	}

	protected override string _GetTemplateForCashOutFormRobuxAmountLabel()
	{
		return "Cantidad de Robux";
	}

	/// <summary>
	/// Key: "CashOutForm.TermsOfService"
	/// English String: "I have read and agree to the {linkStart}Terms of Use{linkEnd}"
	/// </summary>
	public override string CashOutFormTermsOfService(string linkStart, string linkEnd)
	{
		return $"He leído y acepto los {linkStart}Términos de uso{linkEnd}";
	}

	protected override string _GetTemplateForCashOutFormTermsOfService()
	{
		return "He leído y acepto los {linkStart}Términos de uso{linkEnd}";
	}

	protected override string _GetTemplateForCashOutFormYouGetLabel()
	{
		return "Recibirás hasta:";
	}

	protected override string _GetTemplateForLabelPasswordLabel()
	{
		return "Contraseña";
	}

	protected override string _GetTemplateForLabelPasswordPlaceholder()
	{
		return "Verificar contraseña de la cuenta";
	}

	protected override string _GetTemplateForPageHeaderDescription()
	{
		return "Crea juegos, gana dinero.";
	}

	protected override string _GetTemplateForPageHeaderTitle()
	{
		return "Cambio para desarrolladores";
	}

	protected override string _GetTemplateForResponseCannotLoadExchangeRate()
	{
		return "Lo sentimos, pero en este momento no podemos cargar la tasa de cambio actual. Inténtalo de nuevo.";
	}

	protected override string _GetTemplateForResponseCurrencyOperationUnavailable()
	{
		return "Algo ha ido mal. Inténtalo de nuevo.";
	}

	protected override string _GetTemplateForResponseFirstNameRequiredErrorMessage()
	{
		return "Introduce tu nombre de pila.";
	}

	protected override string _GetTemplateForResponseIncorrectCredentials()
	{
		return "Contraseña no válida.";
	}

	protected override string _GetTemplateForResponseInsufficientFunds()
	{
		return "No tienes suficientes Robux finalizar esta transacción.";
	}

	protected override string _GetTemplateForResponseInvalidEmailErrorMessage()
	{
		return "Introduce una dirección de correo electrónico válida.";
	}

	protected override string _GetTemplateForResponseLastNameRequiredErrorMessage()
	{
		return "Introduce tu apellido.";
	}

	protected override string _GetTemplateForResponseRobuxAmountIsBelowMinimumCashoutThreshold()
	{
		return "La cantidad de Robux está por debajo del monto mínimo establecido para convertir en efectivo.";
	}

	protected override string _GetTemplateForResponseUnknownError()
	{
		return "Algo ha ido mal. Inténtalo de nuevo.";
	}

	protected override string _GetTemplateForResponseUserBalanceDoesNotHaveMoreRobuxThanMinimumCashout()
	{
		return "No puedes convertir en efectivo si tienes una cantidad de Robux menor a la mínima establecida para la conversión.";
	}

	protected override string _GetTemplateForResponseUserCannotCashout()
	{
		return "Lo sentimos, pero no eres elegible para convertir en efectivo en este momento.";
	}

	protected override string _GetTemplateForResponseUserDoesNotHavePremium()
	{
		return "Necesitas una suscripción a Roblox Premium para convertir en efectivo.";
	}

	protected override string _GetTemplateForResponseUserDoesNotHaveVerifiedEmail()
	{
		return "Necesitas una dirección de correo electrónico verificada para convertir en efectivo.";
	}

	protected override string _GetTemplateForResponseUserMustProvideFirstAndLastName()
	{
		return "Necesitas proporcionar tu nombre y apellido.";
	}

	protected override string _GetTemplateForResponseUserNotEligibleError()
	{
		return "Lo sentimos, pero no eres elegible para convertir en efectivo en este momento.";
	}
}
