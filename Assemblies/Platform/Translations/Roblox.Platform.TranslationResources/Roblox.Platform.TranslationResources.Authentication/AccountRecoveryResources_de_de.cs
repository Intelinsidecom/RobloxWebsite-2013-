namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides AccountRecoveryResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class AccountRecoveryResources_de_de : AccountRecoveryResources_en_us, IAccountRecoveryResources, ITranslationResources
{
	/// <summary>
	/// Key: "ActionSubmit"
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "Senden";

	/// <summary>
	/// Key: "DescriptionResetFollowing"
	/// English String: "This will reset the following settings:"
	/// </summary>
	public override string DescriptionResetFollowing => "Dadurch werden folgende Einstellungen zurückgesetzt:";

	/// <summary>
	/// Key: "DescriptionRevertAccount"
	/// English String: "You are about to revert your account to a past state.\nTo revert your account you must set a new password."
	/// </summary>
	public override string DescriptionRevertAccount => "Du bist dabei, dein Konto auf einen früheren Stand zurückzusetzen.\nDazu musst du ein neues Passwort festlegen.";

	/// <summary>
	/// Key: "HeadingAccountRecovery"
	/// English String: "Reset Password"
	/// </summary>
	public override string HeadingAccountRecovery => "Passwort zurücksetzen";

	/// <summary>
	/// Key: "HeadingChooseAccount"
	/// English String: "Choose an Account"
	/// </summary>
	public override string HeadingChooseAccount => "Wähle ein Konto";

	/// <summary>
	/// Key: "HeadingRevertAccount"
	/// English String: "Revert Account"
	/// </summary>
	public override string HeadingRevertAccount => "Konto zurücksetzen";

	/// <summary>
	/// Key: "LabelConfirmNewPassword"
	/// English String: "Confirm New Password"
	/// </summary>
	public override string LabelConfirmNewPassword => "Neues Passwort bestätigen";

	/// <summary>
	/// Key: "LabelEmail"
	/// English String: "Email"
	/// </summary>
	public override string LabelEmail => "E-Mail-Adresse";

	/// <summary>
	/// Key: "LabelNewPassword"
	/// English String: "New Password"
	/// </summary>
	public override string LabelNewPassword => "Neues Passwort";

	/// <summary>
	/// Key: "LabelPassword"
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "Passwort";

	/// <summary>
	/// Key: "LabelTwoStepVerification"
	/// English String: "Two Step Verification"
	/// </summary>
	public override string LabelTwoStepVerification => "Verifizierung in 2 Schritten";

	/// <summary>
	/// Key: "MessageDisableTwoStepVerification"
	/// English String: "This will disable two step verification."
	/// </summary>
	public override string MessageDisableTwoStepVerification => "Dadurch wird die Verifizierung in 2 Schritten deaktiviert.";

	/// <summary>
	/// Key: "MessageRevertToUnverifiedEmail"
	/// English String: "You are reverting your email to an unverified email."
	/// </summary>
	public override string MessageRevertToUnverifiedEmail => "Du setzt deine E-Mail-Adresse auf eine nicht verifizierte E-Mail-Adresse zurück.";

	public AccountRecoveryResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "Senden";
	}

	protected override string _GetTemplateForDescriptionResetFollowing()
	{
		return "Dadurch werden folgende Einstellungen zurückgesetzt:";
	}

	protected override string _GetTemplateForDescriptionRevertAccount()
	{
		return "Du bist dabei, dein Konto auf einen früheren Stand zurückzusetzen.\nDazu musst du ein neues Passwort festlegen.";
	}

	protected override string _GetTemplateForHeadingAccountRecovery()
	{
		return "Passwort zurücksetzen";
	}

	protected override string _GetTemplateForHeadingChooseAccount()
	{
		return "Wähle ein Konto";
	}

	protected override string _GetTemplateForHeadingRevertAccount()
	{
		return "Konto zurücksetzen";
	}

	protected override string _GetTemplateForLabelConfirmNewPassword()
	{
		return "Neues Passwort bestätigen";
	}

	protected override string _GetTemplateForLabelEmail()
	{
		return "E-Mail-Adresse";
	}

	protected override string _GetTemplateForLabelNewPassword()
	{
		return "Neues Passwort";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "Passwort";
	}

	protected override string _GetTemplateForLabelTwoStepVerification()
	{
		return "Verifizierung in 2 Schritten";
	}

	/// <summary>
	/// Key: "MessageCreateNewPasswordDontUseOldPassword"
	/// English String: "Create a new password. Do {styleFront}not{styleEnd} use your old password."
	/// </summary>
	public override string MessageCreateNewPasswordDontUseOldPassword(string styleFront, string styleEnd)
	{
		return $"Erstelle ein neues Passwort. Verwende {styleFront}nicht{styleEnd} dein altes Passwort.";
	}

	protected override string _GetTemplateForMessageCreateNewPasswordDontUseOldPassword()
	{
		return "Erstelle ein neues Passwort. Verwende {styleFront}nicht{styleEnd} dein altes Passwort.";
	}

	protected override string _GetTemplateForMessageDisableTwoStepVerification()
	{
		return "Dadurch wird die Verifizierung in 2 Schritten deaktiviert.";
	}

	/// <summary>
	/// Key: "MessageDontUseOldPassword"
	/// English String: "Do {styleFront}not{styleEnd} use your old password."
	/// </summary>
	public override string MessageDontUseOldPassword(string styleFront, string styleEnd)
	{
		return $"Verwende {styleFront}nicht{styleEnd} dein altes Passwort.";
	}

	protected override string _GetTemplateForMessageDontUseOldPassword()
	{
		return "Verwende {styleFront}nicht{styleEnd} dein altes Passwort.";
	}

	protected override string _GetTemplateForMessageRevertToUnverifiedEmail()
	{
		return "Du setzt deine E-Mail-Adresse auf eine nicht verifizierte E-Mail-Adresse zurück.";
	}
}
