namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides AccountRecoveryResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class AccountRecoveryResources_ko_kr : AccountRecoveryResources_en_us, IAccountRecoveryResources, ITranslationResources
{
	/// <summary>
	/// Key: "ActionSubmit"
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "저장";

	/// <summary>
	/// Key: "DescriptionResetFollowing"
	/// English String: "This will reset the following settings:"
	/// </summary>
	public override string DescriptionResetFollowing => "계정을 복구하면 다음 설정이 초기화됩니다:";

	/// <summary>
	/// Key: "DescriptionRevertAccount"
	/// English String: "You are about to revert your account to a past state.\nTo revert your account you must set a new password."
	/// </summary>
	public override string DescriptionRevertAccount => "계정을 이전 상태로 복구합니다.\n계정을 복구하려면 새로운 비밀번호를 설정해야 합니다.";

	/// <summary>
	/// Key: "HeadingAccountRecovery"
	/// English String: "Reset Password"
	/// </summary>
	public override string HeadingAccountRecovery => "비밀번호 재설정";

	/// <summary>
	/// Key: "HeadingChooseAccount"
	/// English String: "Choose an Account"
	/// </summary>
	public override string HeadingChooseAccount => "계정을 선택하세요";

	/// <summary>
	/// Key: "HeadingRevertAccount"
	/// English String: "Revert Account"
	/// </summary>
	public override string HeadingRevertAccount => "계정 복구";

	/// <summary>
	/// Key: "LabelConfirmNewPassword"
	/// English String: "Confirm New Password"
	/// </summary>
	public override string LabelConfirmNewPassword => "새 비밀번호 확인";

	/// <summary>
	/// Key: "LabelEmail"
	/// English String: "Email"
	/// </summary>
	public override string LabelEmail => "이메일";

	/// <summary>
	/// Key: "LabelNewPassword"
	/// English String: "New Password"
	/// </summary>
	public override string LabelNewPassword => "새 비밀번호";

	/// <summary>
	/// Key: "LabelPassword"
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "비밀번호";

	/// <summary>
	/// Key: "LabelTwoStepVerification"
	/// English String: "Two Step Verification"
	/// </summary>
	public override string LabelTwoStepVerification => "2단계 인증";

	/// <summary>
	/// Key: "MessageDisableTwoStepVerification"
	/// English String: "This will disable two step verification."
	/// </summary>
	public override string MessageDisableTwoStepVerification => "2단계 인증이 비활성화됩니다.";

	/// <summary>
	/// Key: "MessageRevertToUnverifiedEmail"
	/// English String: "You are reverting your email to an unverified email."
	/// </summary>
	public override string MessageRevertToUnverifiedEmail => "이메일이 미인증 상태로 다시 전환됩니다.";

	public AccountRecoveryResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "저장";
	}

	protected override string _GetTemplateForDescriptionResetFollowing()
	{
		return "계정을 복구하면 다음 설정이 초기화됩니다:";
	}

	protected override string _GetTemplateForDescriptionRevertAccount()
	{
		return "계정을 이전 상태로 복구합니다.\n계정을 복구하려면 새로운 비밀번호를 설정해야 합니다.";
	}

	protected override string _GetTemplateForHeadingAccountRecovery()
	{
		return "비밀번호 재설정";
	}

	protected override string _GetTemplateForHeadingChooseAccount()
	{
		return "계정을 선택하세요";
	}

	protected override string _GetTemplateForHeadingRevertAccount()
	{
		return "계정 복구";
	}

	protected override string _GetTemplateForLabelConfirmNewPassword()
	{
		return "새 비밀번호 확인";
	}

	protected override string _GetTemplateForLabelEmail()
	{
		return "이메일";
	}

	protected override string _GetTemplateForLabelNewPassword()
	{
		return "새 비밀번호";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "비밀번호";
	}

	protected override string _GetTemplateForLabelTwoStepVerification()
	{
		return "2단계 인증";
	}

	/// <summary>
	/// Key: "MessageCreateNewPasswordDontUseOldPassword"
	/// English String: "Create a new password. Do {styleFront}not{styleEnd} use your old password."
	/// </summary>
	public override string MessageCreateNewPasswordDontUseOldPassword(string styleFront, string styleEnd)
	{
		return $"새 비밀번호를 설정하세요. 이전 비밀번호를 사용하지 {styleFront}마세요{styleEnd}.";
	}

	protected override string _GetTemplateForMessageCreateNewPasswordDontUseOldPassword()
	{
		return "새 비밀번호를 설정하세요. 이전 비밀번호를 사용하지 {styleFront}마세요{styleEnd}.";
	}

	protected override string _GetTemplateForMessageDisableTwoStepVerification()
	{
		return "2단계 인증이 비활성화됩니다.";
	}

	/// <summary>
	/// Key: "MessageDontUseOldPassword"
	/// English String: "Do {styleFront}not{styleEnd} use your old password."
	/// </summary>
	public override string MessageDontUseOldPassword(string styleFront, string styleEnd)
	{
		return $"기존 비밀번호를 사용하지 {styleFront}마세요{styleEnd}.";
	}

	protected override string _GetTemplateForMessageDontUseOldPassword()
	{
		return "기존 비밀번호를 사용하지 {styleFront}마세요{styleEnd}.";
	}

	protected override string _GetTemplateForMessageRevertToUnverifiedEmail()
	{
		return "이메일이 미인증 상태로 다시 전환됩니다.";
	}
}
