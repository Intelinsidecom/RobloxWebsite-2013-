namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides AccountRecoveryResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class AccountRecoveryResources_fr_fr : AccountRecoveryResources_en_us, IAccountRecoveryResources, ITranslationResources
{
	/// <summary>
	/// Key: "ActionSubmit"
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "Envoyer";

	/// <summary>
	/// Key: "DescriptionResetFollowing"
	/// English String: "This will reset the following settings:"
	/// </summary>
	public override string DescriptionResetFollowing => "Les paramètres suivants seront réinitialisés\u00a0:";

	/// <summary>
	/// Key: "DescriptionRevertAccount"
	/// English String: "You are about to revert your account to a past state.\nTo revert your account you must set a new password."
	/// </summary>
	public override string DescriptionRevertAccount => "Tu es sur le point de rétablir ton compte à un état antérieur.\nPour continuer, tu dois définir un nouveau mot de passe.";

	/// <summary>
	/// Key: "HeadingAccountRecovery"
	/// English String: "Reset Password"
	/// </summary>
	public override string HeadingAccountRecovery => "Réinitialiser le mot de passe";

	/// <summary>
	/// Key: "HeadingChooseAccount"
	/// English String: "Choose an Account"
	/// </summary>
	public override string HeadingChooseAccount => "Choisir un compte";

	/// <summary>
	/// Key: "HeadingRevertAccount"
	/// English String: "Revert Account"
	/// </summary>
	public override string HeadingRevertAccount => "Rétablir le compte";

	/// <summary>
	/// Key: "LabelConfirmNewPassword"
	/// English String: "Confirm New Password"
	/// </summary>
	public override string LabelConfirmNewPassword => "Confirmer le nouveau mot de passe";

	/// <summary>
	/// Key: "LabelEmail"
	/// English String: "Email"
	/// </summary>
	public override string LabelEmail => "Adresse e-mail";

	/// <summary>
	/// Key: "LabelNewPassword"
	/// English String: "New Password"
	/// </summary>
	public override string LabelNewPassword => "Nouveau mot de passe";

	/// <summary>
	/// Key: "LabelPassword"
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "Mot de passe";

	/// <summary>
	/// Key: "LabelTwoStepVerification"
	/// English String: "Two Step Verification"
	/// </summary>
	public override string LabelTwoStepVerification => "Vérification en 2\u00a0étapes";

	/// <summary>
	/// Key: "MessageDisableTwoStepVerification"
	/// English String: "This will disable two step verification."
	/// </summary>
	public override string MessageDisableTwoStepVerification => "La vérification en 2\u00a0étapes sera par conséquent désactivée.";

	/// <summary>
	/// Key: "MessageRevertToUnverifiedEmail"
	/// English String: "You are reverting your email to an unverified email."
	/// </summary>
	public override string MessageRevertToUnverifiedEmail => "Ton adresse e-mail va être remplacée par une adresse non vérifiée.";

	public AccountRecoveryResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "Envoyer";
	}

	protected override string _GetTemplateForDescriptionResetFollowing()
	{
		return "Les paramètres suivants seront réinitialisés\u00a0:";
	}

	protected override string _GetTemplateForDescriptionRevertAccount()
	{
		return "Tu es sur le point de rétablir ton compte à un état antérieur.\nPour continuer, tu dois définir un nouveau mot de passe.";
	}

	protected override string _GetTemplateForHeadingAccountRecovery()
	{
		return "Réinitialiser le mot de passe";
	}

	protected override string _GetTemplateForHeadingChooseAccount()
	{
		return "Choisir un compte";
	}

	protected override string _GetTemplateForHeadingRevertAccount()
	{
		return "Rétablir le compte";
	}

	protected override string _GetTemplateForLabelConfirmNewPassword()
	{
		return "Confirmer le nouveau mot de passe";
	}

	protected override string _GetTemplateForLabelEmail()
	{
		return "Adresse e-mail";
	}

	protected override string _GetTemplateForLabelNewPassword()
	{
		return "Nouveau mot de passe";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "Mot de passe";
	}

	protected override string _GetTemplateForLabelTwoStepVerification()
	{
		return "Vérification en 2\u00a0étapes";
	}

	/// <summary>
	/// Key: "MessageCreateNewPasswordDontUseOldPassword"
	/// English String: "Create a new password. Do {styleFront}not{styleEnd} use your old password."
	/// </summary>
	public override string MessageCreateNewPasswordDontUseOldPassword(string styleFront, string styleEnd)
	{
		return $"Choisissez un nouveau mot de passe. Il ne doit {styleFront}pas{styleEnd} être identique à l'ancien.";
	}

	protected override string _GetTemplateForMessageCreateNewPasswordDontUseOldPassword()
	{
		return "Choisissez un nouveau mot de passe. Il ne doit {styleFront}pas{styleEnd} être identique à l'ancien.";
	}

	protected override string _GetTemplateForMessageDisableTwoStepVerification()
	{
		return "La vérification en 2\u00a0étapes sera par conséquent désactivée.";
	}

	/// <summary>
	/// Key: "MessageDontUseOldPassword"
	/// English String: "Do {styleFront}not{styleEnd} use your old password."
	/// </summary>
	public override string MessageDontUseOldPassword(string styleFront, string styleEnd)
	{
		return $"N'utilise {styleFront}pas{styleEnd} ton ancien mot de passe.";
	}

	protected override string _GetTemplateForMessageDontUseOldPassword()
	{
		return "N'utilise {styleFront}pas{styleEnd} ton ancien mot de passe.";
	}

	protected override string _GetTemplateForMessageRevertToUnverifiedEmail()
	{
		return "Ton adresse e-mail va être remplacée par une adresse non vérifiée.";
	}
}
