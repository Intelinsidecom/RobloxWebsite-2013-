namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides AccountRecoveryResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class AccountRecoveryResources_zh_tw : AccountRecoveryResources_en_us, IAccountRecoveryResources, ITranslationResources
{
	/// <summary>
	/// Key: "ActionSubmit"
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "提交";

	/// <summary>
	/// Key: "DescriptionResetFollowing"
	/// English String: "This will reset the following settings:"
	/// </summary>
	public override string DescriptionResetFollowing => "此動作將會重置以下設定：";

	/// <summary>
	/// Key: "DescriptionRevertAccount"
	/// English String: "You are about to revert your account to a past state.\nTo revert your account you must set a new password."
	/// </summary>
	public override string DescriptionRevertAccount => "您即將把帳號還原成之前的狀態。\n若要還原您的帳號，請先設置新的密碼。";

	/// <summary>
	/// Key: "HeadingAccountRecovery"
	/// English String: "Reset Password"
	/// </summary>
	public override string HeadingAccountRecovery => "重置密碼";

	/// <summary>
	/// Key: "HeadingChooseAccount"
	/// English String: "Choose an Account"
	/// </summary>
	public override string HeadingChooseAccount => "選擇帳號";

	/// <summary>
	/// Key: "HeadingRevertAccount"
	/// English String: "Revert Account"
	/// </summary>
	public override string HeadingRevertAccount => "還原帳號";

	/// <summary>
	/// Key: "LabelConfirmNewPassword"
	/// English String: "Confirm New Password"
	/// </summary>
	public override string LabelConfirmNewPassword => "確認新密碼";

	/// <summary>
	/// Key: "LabelEmail"
	/// English String: "Email"
	/// </summary>
	public override string LabelEmail => "電子郵件地址";

	/// <summary>
	/// Key: "LabelNewPassword"
	/// English String: "New Password"
	/// </summary>
	public override string LabelNewPassword => "新密碼";

	/// <summary>
	/// Key: "LabelPassword"
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "密碼";

	/// <summary>
	/// Key: "LabelTwoStepVerification"
	/// English String: "Two Step Verification"
	/// </summary>
	public override string LabelTwoStepVerification => "雙步驟驗證";

	/// <summary>
	/// Key: "MessageDisableTwoStepVerification"
	/// English String: "This will disable two step verification."
	/// </summary>
	public override string MessageDisableTwoStepVerification => "此動作會停用雙步驟驗證。";

	/// <summary>
	/// Key: "MessageRevertToUnverifiedEmail"
	/// English String: "You are reverting your email to an unverified email."
	/// </summary>
	public override string MessageRevertToUnverifiedEmail => "您即將把電子郵件地址還原成未驗證的電子郵件地址。";

	public AccountRecoveryResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "提交";
	}

	protected override string _GetTemplateForDescriptionResetFollowing()
	{
		return "此動作將會重置以下設定：";
	}

	protected override string _GetTemplateForDescriptionRevertAccount()
	{
		return "您即將把帳號還原成之前的狀態。\n若要還原您的帳號，請先設置新的密碼。";
	}

	protected override string _GetTemplateForHeadingAccountRecovery()
	{
		return "重置密碼";
	}

	protected override string _GetTemplateForHeadingChooseAccount()
	{
		return "選擇帳號";
	}

	protected override string _GetTemplateForHeadingRevertAccount()
	{
		return "還原帳號";
	}

	protected override string _GetTemplateForLabelConfirmNewPassword()
	{
		return "確認新密碼";
	}

	protected override string _GetTemplateForLabelEmail()
	{
		return "電子郵件地址";
	}

	protected override string _GetTemplateForLabelNewPassword()
	{
		return "新密碼";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "密碼";
	}

	protected override string _GetTemplateForLabelTwoStepVerification()
	{
		return "雙步驟驗證";
	}

	/// <summary>
	/// Key: "MessageCreateNewPasswordDontUseOldPassword"
	/// English String: "Create a new password. Do {styleFront}not{styleEnd} use your old password."
	/// </summary>
	public override string MessageCreateNewPasswordDontUseOldPassword(string styleFront, string styleEnd)
	{
		return $"請建立新密碼。{styleFront}不可{styleEnd}使用舊密碼。";
	}

	protected override string _GetTemplateForMessageCreateNewPasswordDontUseOldPassword()
	{
		return "請建立新密碼。{styleFront}不可{styleEnd}使用舊密碼。";
	}

	protected override string _GetTemplateForMessageDisableTwoStepVerification()
	{
		return "此動作會停用雙步驟驗證。";
	}

	/// <summary>
	/// Key: "MessageDontUseOldPassword"
	/// English String: "Do {styleFront}not{styleEnd} use your old password."
	/// </summary>
	public override string MessageDontUseOldPassword(string styleFront, string styleEnd)
	{
		return $"請{styleFront}不要{styleEnd}使用舊密碼。";
	}

	protected override string _GetTemplateForMessageDontUseOldPassword()
	{
		return "請{styleFront}不要{styleEnd}使用舊密碼。";
	}

	protected override string _GetTemplateForMessageRevertToUnverifiedEmail()
	{
		return "您即將把電子郵件地址還原成未驗證的電子郵件地址。";
	}
}
