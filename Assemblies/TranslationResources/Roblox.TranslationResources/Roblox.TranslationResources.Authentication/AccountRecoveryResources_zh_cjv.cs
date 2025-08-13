namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides AccountRecoveryResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class AccountRecoveryResources_zh_cjv : AccountRecoveryResources_en_us, IAccountRecoveryResources, ITranslationResources
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
	public override string DescriptionResetFollowing => "这样将重置下列设置：";

	/// <summary>
	/// Key: "DescriptionRevertAccount"
	/// English String: "You are about to revert your account to a past state.\nTo revert your account you must set a new password."
	/// </summary>
	public override string DescriptionRevertAccount => "你即将把帐户还原成之前的状态。\n若要还原你的帐户，请先设置一个新的密码。";

	/// <summary>
	/// Key: "HeadingAccountRecovery"
	/// English String: "Reset Password"
	/// </summary>
	public override string HeadingAccountRecovery => "重置密码";

	/// <summary>
	/// Key: "HeadingChooseAccount"
	/// English String: "Choose an Account"
	/// </summary>
	public override string HeadingChooseAccount => "选择帐户";

	/// <summary>
	/// Key: "HeadingRevertAccount"
	/// English String: "Revert Account"
	/// </summary>
	public override string HeadingRevertAccount => "还原帐户";

	/// <summary>
	/// Key: "LabelConfirmNewPassword"
	/// English String: "Confirm New Password"
	/// </summary>
	public override string LabelConfirmNewPassword => "确认新密码";

	/// <summary>
	/// Key: "LabelEmail"
	/// English String: "Email"
	/// </summary>
	public override string LabelEmail => "电子邮件";

	/// <summary>
	/// Key: "LabelNewPassword"
	/// English String: "New Password"
	/// </summary>
	public override string LabelNewPassword => "新密码";

	/// <summary>
	/// Key: "LabelPassword"
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "密码";

	/// <summary>
	/// Key: "LabelTwoStepVerification"
	/// English String: "Two Step Verification"
	/// </summary>
	public override string LabelTwoStepVerification => "两步验证";

	/// <summary>
	/// Key: "MessageDisableTwoStepVerification"
	/// English String: "This will disable two step verification."
	/// </summary>
	public override string MessageDisableTwoStepVerification => "这样做将停用两步验证。";

	/// <summary>
	/// Key: "MessageRevertToUnverifiedEmail"
	/// English String: "You are reverting your email to an unverified email."
	/// </summary>
	public override string MessageRevertToUnverifiedEmail => "你即将把电子邮件还原成未验证的电子邮件。";

	public AccountRecoveryResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "提交";
	}

	protected override string _GetTemplateForDescriptionResetFollowing()
	{
		return "这样将重置下列设置：";
	}

	protected override string _GetTemplateForDescriptionRevertAccount()
	{
		return "你即将把帐户还原成之前的状态。\n若要还原你的帐户，请先设置一个新的密码。";
	}

	protected override string _GetTemplateForHeadingAccountRecovery()
	{
		return "重置密码";
	}

	protected override string _GetTemplateForHeadingChooseAccount()
	{
		return "选择帐户";
	}

	protected override string _GetTemplateForHeadingRevertAccount()
	{
		return "还原帐户";
	}

	protected override string _GetTemplateForLabelConfirmNewPassword()
	{
		return "确认新密码";
	}

	protected override string _GetTemplateForLabelEmail()
	{
		return "电子邮件";
	}

	protected override string _GetTemplateForLabelNewPassword()
	{
		return "新密码";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "密码";
	}

	protected override string _GetTemplateForLabelTwoStepVerification()
	{
		return "两步验证";
	}

	/// <summary>
	/// Key: "MessageCreateNewPasswordDontUseOldPassword"
	/// English String: "Create a new password. Do {styleFront}not{styleEnd} use your old password."
	/// </summary>
	public override string MessageCreateNewPasswordDontUseOldPassword(string styleFront, string styleEnd)
	{
		return $"创建一个新密码。请{styleFront}勿{styleEnd}使用旧密码。";
	}

	protected override string _GetTemplateForMessageCreateNewPasswordDontUseOldPassword()
	{
		return "创建一个新密码。请{styleFront}勿{styleEnd}使用旧密码。";
	}

	protected override string _GetTemplateForMessageDisableTwoStepVerification()
	{
		return "这样做将停用两步验证。";
	}

	/// <summary>
	/// Key: "MessageDontUseOldPassword"
	/// English String: "Do {styleFront}not{styleEnd} use your old password."
	/// </summary>
	public override string MessageDontUseOldPassword(string styleFront, string styleEnd)
	{
		return $"请{styleFront}勿{styleEnd}使用旧密码。";
	}

	protected override string _GetTemplateForMessageDontUseOldPassword()
	{
		return "请{styleFront}勿{styleEnd}使用旧密码。";
	}

	protected override string _GetTemplateForMessageRevertToUnverifiedEmail()
	{
		return "你即将把电子邮件还原成未验证的电子邮件。";
	}
}
