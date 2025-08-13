namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides DevexCashOutResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class DevexCashOutResources_pt_br : DevexCashOutResources_en_us, IDevexCashOutResources, ITranslationResources
{
	/// <summary>
	/// Key: "CashOutForm.CashOutSubmit"
	/// English String: "Cash Out"
	/// </summary>
	public override string CashOutFormCashOutSubmit => "Retirada";

	/// <summary>
	/// Key: "CashOutForm.EmailAddressLabel"
	/// English String: "Email Address"
	/// </summary>
	public override string CashOutFormEmailAddressLabel => "Endereço de e-mail";

	/// <summary>
	/// Key: "CashOutForm.ExchangeRateLabel"
	/// English String: "Exchange Rate"
	/// </summary>
	public override string CashOutFormExchangeRateLabel => "Taxa de câmbio";

	/// <summary>
	/// Key: "CashOutForm.FirstNameLabel"
	/// English String: "First Name"
	/// </summary>
	public override string CashOutFormFirstNameLabel => "Nome";

	/// <summary>
	/// Key: "CashOutForm.LastNameLabel"
	/// English String: "Last Name"
	/// </summary>
	public override string CashOutFormLastNameLabel => "Sobrenome";

	/// <summary>
	/// Key: "CashOutForm.Robux"
	/// English String: "Robux"
	/// </summary>
	public override string CashOutFormRobux => "Robux";

	/// <summary>
	/// Key: "CashOutForm.RobuxAmountLabel"
	/// English String: "Robux Amount"
	/// </summary>
	public override string CashOutFormRobuxAmountLabel => "Quantidade de Robux";

	/// <summary>
	/// Key: "CashOutForm.YouGetLabel"
	/// English String: "You get up to:"
	/// </summary>
	public override string CashOutFormYouGetLabel => "Você ganha";

	/// <summary>
	/// Key: "Label.PasswordLabel"
	/// English String: "Password"
	/// </summary>
	public override string LabelPasswordLabel => "Senha";

	/// <summary>
	/// Key: "Label.PasswordPlaceholder"
	/// English String: "Verify Account Password"
	/// </summary>
	public override string LabelPasswordPlaceholder => "Verificar senha da conta";

	/// <summary>
	/// Key: "PageHeader.Description"
	/// English String: "Create games, earn money."
	/// </summary>
	public override string PageHeaderDescription => "Crie jogos, ganhe dinheiro.";

	/// <summary>
	/// Key: "PageHeader.Title"
	/// English String: "Developer Exchange"
	/// </summary>
	public override string PageHeaderTitle => "Central do Desenvolvedor";

	/// <summary>
	/// Key: "Response.CannotLoadExchangeRate"
	/// English String: "Sorry, we were unable to load the current exchange rate. Please try again."
	/// </summary>
	public override string ResponseCannotLoadExchangeRate => "Não foi possível carregar a taxa de câmbio atual. Tente de novo mais tarde.";

	/// <summary>
	/// Key: "Response.CurrencyOperationUnavailable"
	/// English String: "Sorry, something went wrong. Please try again."
	/// </summary>
	public override string ResponseCurrencyOperationUnavailable => "Algo deu errado. Tente de novo.";

	/// <summary>
	/// Key: "Response.FirstNameRequiredErrorMessage"
	/// English String: "Please enter your first name."
	/// </summary>
	public override string ResponseFirstNameRequiredErrorMessage => "Insira seu nome.";

	/// <summary>
	/// Key: "Response.IncorrectCredentials"
	/// English String: "Invalid password."
	/// </summary>
	public override string ResponseIncorrectCredentials => "Senha inválida.";

	/// <summary>
	/// Key: "Response.InsufficientFunds"
	/// English String: "You do not have enough Robux to complete this transaction."
	/// </summary>
	public override string ResponseInsufficientFunds => "Você não tem Robux o bastante para completar esta transação.";

	/// <summary>
	/// Key: "Response.InvalidEmailErrorMessage"
	/// English String: "Please enter a valid email address."
	/// </summary>
	public override string ResponseInvalidEmailErrorMessage => "Insira um endereço de e-mail válido.";

	/// <summary>
	/// Key: "Response.LastNameRequiredErrorMessage"
	/// English String: "Please enter your last name."
	/// </summary>
	public override string ResponseLastNameRequiredErrorMessage => "Insira seu sobrenome.";

	/// <summary>
	/// Key: "Response.RobuxAmountIsBelowMinimumCashoutThreshold"
	/// English String: "Robux amount below minimum cash out threshold."
	/// </summary>
	public override string ResponseRobuxAmountIsBelowMinimumCashoutThreshold => "A quantidade de Robux é inferior ao limite mínimo para retirada.";

	/// <summary>
	/// Key: "Response.UnknownError"
	/// English String: "Sorry, something went wrong. Please try again."
	/// </summary>
	public override string ResponseUnknownError => "Algo deu errado. Tente de novo.";

	/// <summary>
	/// Key: "Response.UserBalanceDoesNotHaveMoreRobuxThanMinimumCashout"
	/// English String: "You cannot cash out for less than the minimum amount."
	/// </summary>
	public override string ResponseUserBalanceDoesNotHaveMoreRobuxThanMinimumCashout => "Você não pode retirar menos do que o valor mínimo.";

	/// <summary>
	/// Key: "Response.UserCannotCashout"
	/// English String: "Sorry, you are not eligible to cash out at this time."
	/// </summary>
	public override string ResponseUserCannotCashout => "Você não está habilitado a fazer uma retirada no momento.";

	/// <summary>
	/// Key: "Response.UserDoesNotHavePremium"
	/// English String: "You need a Roblox Premium subscription to cash out."
	/// </summary>
	public override string ResponseUserDoesNotHavePremium => "Para fazer uma retirada, você precisa ter uma assinatura Roblox Premium.";

	/// <summary>
	/// Key: "Response.UserDoesNotHaveVerifiedEmail"
	/// English String: "You need a verified email address to cash out."
	/// </summary>
	public override string ResponseUserDoesNotHaveVerifiedEmail => "Para fazer uma retirada, você precisa ter um endereço de e-mail verificado.";

	/// <summary>
	/// Key: "Response.UserMustProvideFirstAndLastName"
	/// English String: "You need to provide your first and last name."
	/// </summary>
	public override string ResponseUserMustProvideFirstAndLastName => "Forneça seu nome e sobrenome.";

	/// <summary>
	/// Key: "Response.UserNotEligibleError"
	/// English String: "Sorry, you are not eligible to cash out at this time."
	/// </summary>
	public override string ResponseUserNotEligibleError => "Você não está habilitado a fazer uma retirada no momento.";

	public DevexCashOutResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForCashOutFormCashOutSubmit()
	{
		return "Retirada";
	}

	/// <summary>
	/// Key: "CashOutForm.Description"
	/// English String: "Please complete this form to begin processing your payment. The email address you provide must match the email address on your Roblox DevEx Portal account. If you need assistance with this form, {linkStart}please visit the Help Center.{linkEnd}"
	/// </summary>
	public override string CashOutFormDescription(string linkStart, string linkEnd)
	{
		return $"Preencha este formulário para começar a processar o pagamento. O endereço fornecido abaixo deve corresponder ao endereço da sua conta do Roblox DevEx Portal. Se precisar de ajuda com este formulário, acesse a nossa {linkStart}página de ajuda{linkEnd}.";
	}

	protected override string _GetTemplateForCashOutFormDescription()
	{
		return "Preencha este formulário para começar a processar o pagamento. O endereço fornecido abaixo deve corresponder ao endereço da sua conta do Roblox DevEx Portal. Se precisar de ajuda com este formulário, acesse a nossa {linkStart}página de ajuda{linkEnd}.";
	}

	protected override string _GetTemplateForCashOutFormEmailAddressLabel()
	{
		return "Endereço de e-mail";
	}

	protected override string _GetTemplateForCashOutFormExchangeRateLabel()
	{
		return "Taxa de câmbio";
	}

	protected override string _GetTemplateForCashOutFormFirstNameLabel()
	{
		return "Nome";
	}

	protected override string _GetTemplateForCashOutFormLastNameLabel()
	{
		return "Sobrenome";
	}

	protected override string _GetTemplateForCashOutFormRobux()
	{
		return "Robux";
	}

	protected override string _GetTemplateForCashOutFormRobuxAmountLabel()
	{
		return "Quantidade de Robux";
	}

	/// <summary>
	/// Key: "CashOutForm.TermsOfService"
	/// English String: "I have read and agree to the {linkStart}Terms of Use{linkEnd}"
	/// </summary>
	public override string CashOutFormTermsOfService(string linkStart, string linkEnd)
	{
		return $"Li e aceito os {linkStart}Termos de Uso{linkEnd}";
	}

	protected override string _GetTemplateForCashOutFormTermsOfService()
	{
		return "Li e aceito os {linkStart}Termos de Uso{linkEnd}";
	}

	protected override string _GetTemplateForCashOutFormYouGetLabel()
	{
		return "Você ganha";
	}

	protected override string _GetTemplateForLabelPasswordLabel()
	{
		return "Senha";
	}

	protected override string _GetTemplateForLabelPasswordPlaceholder()
	{
		return "Verificar senha da conta";
	}

	protected override string _GetTemplateForPageHeaderDescription()
	{
		return "Crie jogos, ganhe dinheiro.";
	}

	protected override string _GetTemplateForPageHeaderTitle()
	{
		return "Central do Desenvolvedor";
	}

	protected override string _GetTemplateForResponseCannotLoadExchangeRate()
	{
		return "Não foi possível carregar a taxa de câmbio atual. Tente de novo mais tarde.";
	}

	protected override string _GetTemplateForResponseCurrencyOperationUnavailable()
	{
		return "Algo deu errado. Tente de novo.";
	}

	protected override string _GetTemplateForResponseFirstNameRequiredErrorMessage()
	{
		return "Insira seu nome.";
	}

	protected override string _GetTemplateForResponseIncorrectCredentials()
	{
		return "Senha inválida.";
	}

	protected override string _GetTemplateForResponseInsufficientFunds()
	{
		return "Você não tem Robux o bastante para completar esta transação.";
	}

	protected override string _GetTemplateForResponseInvalidEmailErrorMessage()
	{
		return "Insira um endereço de e-mail válido.";
	}

	protected override string _GetTemplateForResponseLastNameRequiredErrorMessage()
	{
		return "Insira seu sobrenome.";
	}

	protected override string _GetTemplateForResponseRobuxAmountIsBelowMinimumCashoutThreshold()
	{
		return "A quantidade de Robux é inferior ao limite mínimo para retirada.";
	}

	protected override string _GetTemplateForResponseUnknownError()
	{
		return "Algo deu errado. Tente de novo.";
	}

	protected override string _GetTemplateForResponseUserBalanceDoesNotHaveMoreRobuxThanMinimumCashout()
	{
		return "Você não pode retirar menos do que o valor mínimo.";
	}

	protected override string _GetTemplateForResponseUserCannotCashout()
	{
		return "Você não está habilitado a fazer uma retirada no momento.";
	}

	protected override string _GetTemplateForResponseUserDoesNotHavePremium()
	{
		return "Para fazer uma retirada, você precisa ter uma assinatura Roblox Premium.";
	}

	protected override string _GetTemplateForResponseUserDoesNotHaveVerifiedEmail()
	{
		return "Para fazer uma retirada, você precisa ter um endereço de e-mail verificado.";
	}

	protected override string _GetTemplateForResponseUserMustProvideFirstAndLastName()
	{
		return "Forneça seu nome e sobrenome.";
	}

	protected override string _GetTemplateForResponseUserNotEligibleError()
	{
		return "Você não está habilitado a fazer uma retirada no momento.";
	}
}
