namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides AccountRecoveryResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class AccountRecoveryResources_es_es : AccountRecoveryResources_en_us, IAccountRecoveryResources, ITranslationResources
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
	public override string DescriptionResetFollowing => "Esto restablecerá las configuraciones siguientes:";

	/// <summary>
	/// Key: "DescriptionRevertAccount"
	/// English String: "You are about to revert your account to a past state.\nTo revert your account you must set a new password."
	/// </summary>
	public override string DescriptionRevertAccount => "Vas a revertir tu cuenta a un estado anterior.\nPara revertir tu cuenta debes fijar una nueva contraseña.";

	/// <summary>
	/// Key: "HeadingAccountRecovery"
	/// English String: "Reset Password"
	/// </summary>
	public override string HeadingAccountRecovery => "Restablecer contraseña";

	/// <summary>
	/// Key: "HeadingChooseAccount"
	/// English String: "Choose an Account"
	/// </summary>
	public override string HeadingChooseAccount => "Elige una cuenta";

	/// <summary>
	/// Key: "HeadingRevertAccount"
	/// English String: "Revert Account"
	/// </summary>
	public override string HeadingRevertAccount => "Revertir cuenta";

	/// <summary>
	/// Key: "LabelConfirmNewPassword"
	/// English String: "Confirm New Password"
	/// </summary>
	public override string LabelConfirmNewPassword => "Confirmar contraseña nueva";

	/// <summary>
	/// Key: "LabelEmail"
	/// English String: "Email"
	/// </summary>
	public override string LabelEmail => "Correo electrónico";

	/// <summary>
	/// Key: "LabelNewPassword"
	/// English String: "New Password"
	/// </summary>
	public override string LabelNewPassword => "Contraseña nueva";

	/// <summary>
	/// Key: "LabelPassword"
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "Contraseña";

	/// <summary>
	/// Key: "LabelTwoStepVerification"
	/// English String: "Two Step Verification"
	/// </summary>
	public override string LabelTwoStepVerification => "Verificación en dos pasos";

	/// <summary>
	/// Key: "MessageDisableTwoStepVerification"
	/// English String: "This will disable two step verification."
	/// </summary>
	public override string MessageDisableTwoStepVerification => "Esto desactivará la verificación en dos pasos.";

	/// <summary>
	/// Key: "MessageRevertToUnverifiedEmail"
	/// English String: "You are reverting your email to an unverified email."
	/// </summary>
	public override string MessageRevertToUnverifiedEmail => "Vas a revertir tu correo electrónico a un correo electrónico no verificado.";

	public AccountRecoveryResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "Enviar";
	}

	protected override string _GetTemplateForDescriptionResetFollowing()
	{
		return "Esto restablecerá las configuraciones siguientes:";
	}

	protected override string _GetTemplateForDescriptionRevertAccount()
	{
		return "Vas a revertir tu cuenta a un estado anterior.\nPara revertir tu cuenta debes fijar una nueva contraseña.";
	}

	protected override string _GetTemplateForHeadingAccountRecovery()
	{
		return "Restablecer contraseña";
	}

	protected override string _GetTemplateForHeadingChooseAccount()
	{
		return "Elige una cuenta";
	}

	protected override string _GetTemplateForHeadingRevertAccount()
	{
		return "Revertir cuenta";
	}

	protected override string _GetTemplateForLabelConfirmNewPassword()
	{
		return "Confirmar contraseña nueva";
	}

	protected override string _GetTemplateForLabelEmail()
	{
		return "Correo electrónico";
	}

	protected override string _GetTemplateForLabelNewPassword()
	{
		return "Contraseña nueva";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "Contraseña";
	}

	protected override string _GetTemplateForLabelTwoStepVerification()
	{
		return "Verificación en dos pasos";
	}

	/// <summary>
	/// Key: "MessageCreateNewPasswordDontUseOldPassword"
	/// English String: "Create a new password. Do {styleFront}not{styleEnd} use your old password."
	/// </summary>
	public override string MessageCreateNewPasswordDontUseOldPassword(string styleFront, string styleEnd)
	{
		return $"Crea una contraseña nueva. {styleFront}No{styleEnd} uses tu contraseña anterior.";
	}

	protected override string _GetTemplateForMessageCreateNewPasswordDontUseOldPassword()
	{
		return "Crea una contraseña nueva. {styleFront}No{styleEnd} uses tu contraseña anterior.";
	}

	protected override string _GetTemplateForMessageDisableTwoStepVerification()
	{
		return "Esto desactivará la verificación en dos pasos.";
	}

	/// <summary>
	/// Key: "MessageDontUseOldPassword"
	/// English String: "Do {styleFront}not{styleEnd} use your old password."
	/// </summary>
	public override string MessageDontUseOldPassword(string styleFront, string styleEnd)
	{
		return $"{styleFront}No{styleEnd} uses tu contraseña anterior.";
	}

	protected override string _GetTemplateForMessageDontUseOldPassword()
	{
		return "{styleFront}No{styleEnd} uses tu contraseña anterior.";
	}

	protected override string _GetTemplateForMessageRevertToUnverifiedEmail()
	{
		return "Vas a revertir tu correo electrónico a un correo electrónico no verificado.";
	}
}
