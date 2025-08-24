namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides AccountRecoveryResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class AccountRecoveryResources_pt_br : AccountRecoveryResources_en_us, IAccountRecoveryResources, ITranslationResources
{
	/// <summary>
	/// Key: "ActionSubmit"
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "Enviar";

	/// <summary>
	/// Key: "DescriptionResetFollowing"
	/// English String: "This will reset the following settings:"
	/// </summary>
	public override string DescriptionResetFollowing => "Isto reiniciará as seguintes configurações:";

	/// <summary>
	/// Key: "DescriptionRevertAccount"
	/// English String: "You are about to revert your account to a past state.\nTo revert your account you must set a new password."
	/// </summary>
	public override string DescriptionRevertAccount => "Você está prestes a reverter sua conta para um estado anterior.\nPara reverter sua conta você precisa enviar uma nova senha.";

	/// <summary>
	/// Key: "HeadingAccountRecovery"
	/// English String: "Reset Password"
	/// </summary>
	public override string HeadingAccountRecovery => "Redefinir senha";

	/// <summary>
	/// Key: "HeadingChooseAccount"
	/// English String: "Choose an Account"
	/// </summary>
	public override string HeadingChooseAccount => "Escolha uma conta";

	/// <summary>
	/// Key: "HeadingRevertAccount"
	/// English String: "Revert Account"
	/// </summary>
	public override string HeadingRevertAccount => "Reverter conta";

	/// <summary>
	/// Key: "LabelConfirmNewPassword"
	/// English String: "Confirm New Password"
	/// </summary>
	public override string LabelConfirmNewPassword => "Confirmar nova senha";

	/// <summary>
	/// Key: "LabelEmail"
	/// English String: "Email"
	/// </summary>
	public override string LabelEmail => "E-mail";

	/// <summary>
	/// Key: "LabelNewPassword"
	/// English String: "New Password"
	/// </summary>
	public override string LabelNewPassword => "Nova senha";

	/// <summary>
	/// Key: "LabelPassword"
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "Senha";

	/// <summary>
	/// Key: "LabelTwoStepVerification"
	/// English String: "Two Step Verification"
	/// </summary>
	public override string LabelTwoStepVerification => "Verificação de 2 passos";

	/// <summary>
	/// Key: "MessageDisableTwoStepVerification"
	/// English String: "This will disable two step verification."
	/// </summary>
	public override string MessageDisableTwoStepVerification => "Isto desabilitará a verificação de 2 passos.";

	/// <summary>
	/// Key: "MessageRevertToUnverifiedEmail"
	/// English String: "You are reverting your email to an unverified email."
	/// </summary>
	public override string MessageRevertToUnverifiedEmail => "Você está revertendo seu e-mail para um e-mail não verificado.";

	public AccountRecoveryResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "Enviar";
	}

	protected override string _GetTemplateForDescriptionResetFollowing()
	{
		return "Isto reiniciará as seguintes configurações:";
	}

	protected override string _GetTemplateForDescriptionRevertAccount()
	{
		return "Você está prestes a reverter sua conta para um estado anterior.\nPara reverter sua conta você precisa enviar uma nova senha.";
	}

	protected override string _GetTemplateForHeadingAccountRecovery()
	{
		return "Redefinir senha";
	}

	protected override string _GetTemplateForHeadingChooseAccount()
	{
		return "Escolha uma conta";
	}

	protected override string _GetTemplateForHeadingRevertAccount()
	{
		return "Reverter conta";
	}

	protected override string _GetTemplateForLabelConfirmNewPassword()
	{
		return "Confirmar nova senha";
	}

	protected override string _GetTemplateForLabelEmail()
	{
		return "E-mail";
	}

	protected override string _GetTemplateForLabelNewPassword()
	{
		return "Nova senha";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "Senha";
	}

	protected override string _GetTemplateForLabelTwoStepVerification()
	{
		return "Verificação de 2 passos";
	}

	/// <summary>
	/// Key: "MessageCreateNewPasswordDontUseOldPassword"
	/// English String: "Create a new password. Do {styleFront}not{styleEnd} use your old password."
	/// </summary>
	public override string MessageCreateNewPasswordDontUseOldPassword(string styleFront, string styleEnd)
	{
		return $"Crie uma nova senha. {styleFront}Não{styleEnd} use a sua senha anterior.";
	}

	protected override string _GetTemplateForMessageCreateNewPasswordDontUseOldPassword()
	{
		return "Crie uma nova senha. {styleFront}Não{styleEnd} use a sua senha anterior.";
	}

	protected override string _GetTemplateForMessageDisableTwoStepVerification()
	{
		return "Isto desabilitará a verificação de 2 passos.";
	}

	/// <summary>
	/// Key: "MessageDontUseOldPassword"
	/// English String: "Do {styleFront}not{styleEnd} use your old password."
	/// </summary>
	public override string MessageDontUseOldPassword(string styleFront, string styleEnd)
	{
		return $"{styleFront}Não{styleEnd} use a sua senha anterior.";
	}

	protected override string _GetTemplateForMessageDontUseOldPassword()
	{
		return "{styleFront}Não{styleEnd} use a sua senha anterior.";
	}

	protected override string _GetTemplateForMessageRevertToUnverifiedEmail()
	{
		return "Você está revertendo seu e-mail para um e-mail não verificado.";
	}
}
