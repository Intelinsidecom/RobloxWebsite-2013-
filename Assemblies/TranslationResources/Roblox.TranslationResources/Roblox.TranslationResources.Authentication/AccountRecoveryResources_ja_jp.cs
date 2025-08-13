namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides AccountRecoveryResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class AccountRecoveryResources_ja_jp : AccountRecoveryResources_en_us, IAccountRecoveryResources, ITranslationResources
{
	/// <summary>
	/// Key: "ActionSubmit"
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "送信する";

	/// <summary>
	/// Key: "DescriptionResetFollowing"
	/// English String: "This will reset the following settings:"
	/// </summary>
	public override string DescriptionResetFollowing => "以下の設定がリセットされます:";

	/// <summary>
	/// Key: "DescriptionRevertAccount"
	/// English String: "You are about to revert your account to a past state.\nTo revert your account you must set a new password."
	/// </summary>
	public override string DescriptionRevertAccount => "アカウントを元の状態に戻そうとしています。\nアカウントを元に戻すには、新しいパスワードを設定する必要があります。";

	/// <summary>
	/// Key: "HeadingAccountRecovery"
	/// English String: "Reset Password"
	/// </summary>
	public override string HeadingAccountRecovery => "パスワードのリセット";

	/// <summary>
	/// Key: "HeadingChooseAccount"
	/// English String: "Choose an Account"
	/// </summary>
	public override string HeadingChooseAccount => "アカウントを選ぶ";

	/// <summary>
	/// Key: "HeadingRevertAccount"
	/// English String: "Revert Account"
	/// </summary>
	public override string HeadingRevertAccount => "アカウントを元に戻す";

	/// <summary>
	/// Key: "LabelConfirmNewPassword"
	/// English String: "Confirm New Password"
	/// </summary>
	public override string LabelConfirmNewPassword => "新しいパスワードを確認";

	/// <summary>
	/// Key: "LabelEmail"
	/// English String: "Email"
	/// </summary>
	public override string LabelEmail => "メールアドレス";

	/// <summary>
	/// Key: "LabelNewPassword"
	/// English String: "New Password"
	/// </summary>
	public override string LabelNewPassword => "新しいパスワード";

	/// <summary>
	/// Key: "LabelPassword"
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "パスワード";

	/// <summary>
	/// Key: "LabelTwoStepVerification"
	/// English String: "Two Step Verification"
	/// </summary>
	public override string LabelTwoStepVerification => "二段階認証";

	/// <summary>
	/// Key: "MessageDisableTwoStepVerification"
	/// English String: "This will disable two step verification."
	/// </summary>
	public override string MessageDisableTwoStepVerification => "二段階認証が無効になります。";

	/// <summary>
	/// Key: "MessageRevertToUnverifiedEmail"
	/// English String: "You are reverting your email to an unverified email."
	/// </summary>
	public override string MessageRevertToUnverifiedEmail => "メールアドレスを、認証されていないメールアドレスに戻そうとしています。";

	public AccountRecoveryResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "送信する";
	}

	protected override string _GetTemplateForDescriptionResetFollowing()
	{
		return "以下の設定がリセットされます:";
	}

	protected override string _GetTemplateForDescriptionRevertAccount()
	{
		return "アカウントを元の状態に戻そうとしています。\nアカウントを元に戻すには、新しいパスワードを設定する必要があります。";
	}

	protected override string _GetTemplateForHeadingAccountRecovery()
	{
		return "パスワードのリセット";
	}

	protected override string _GetTemplateForHeadingChooseAccount()
	{
		return "アカウントを選ぶ";
	}

	protected override string _GetTemplateForHeadingRevertAccount()
	{
		return "アカウントを元に戻す";
	}

	protected override string _GetTemplateForLabelConfirmNewPassword()
	{
		return "新しいパスワードを確認";
	}

	protected override string _GetTemplateForLabelEmail()
	{
		return "メールアドレス";
	}

	protected override string _GetTemplateForLabelNewPassword()
	{
		return "新しいパスワード";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "パスワード";
	}

	protected override string _GetTemplateForLabelTwoStepVerification()
	{
		return "二段階認証";
	}

	/// <summary>
	/// Key: "MessageCreateNewPasswordDontUseOldPassword"
	/// English String: "Create a new password. Do {styleFront}not{styleEnd} use your old password."
	/// </summary>
	public override string MessageCreateNewPasswordDontUseOldPassword(string styleFront, string styleEnd)
	{
		return $"新しいパスワードを作ります。古いパスワードを {styleFront}使わない{styleEnd} でください。";
	}

	protected override string _GetTemplateForMessageCreateNewPasswordDontUseOldPassword()
	{
		return "新しいパスワードを作ります。古いパスワードを {styleFront}使わない{styleEnd} でください。";
	}

	protected override string _GetTemplateForMessageDisableTwoStepVerification()
	{
		return "二段階認証が無効になります。";
	}

	/// <summary>
	/// Key: "MessageDontUseOldPassword"
	/// English String: "Do {styleFront}not{styleEnd} use your old password."
	/// </summary>
	public override string MessageDontUseOldPassword(string styleFront, string styleEnd)
	{
		return $"古いパスワードを {styleFront}使わない{styleEnd} でください。";
	}

	protected override string _GetTemplateForMessageDontUseOldPassword()
	{
		return "古いパスワードを {styleFront}使わない{styleEnd} でください。";
	}

	protected override string _GetTemplateForMessageRevertToUnverifiedEmail()
	{
		return "メールアドレスを、認証されていないメールアドレスに戻そうとしています。";
	}
}
