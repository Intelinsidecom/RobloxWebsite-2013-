namespace Roblox.Platform.TranslationResources.Authentication {
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
	public override string ActionSubmit => "é€ä¿¡ã™ã‚‹";

	/// <summary>
	/// Key: "DescriptionResetFollowing"
	/// English String: "This will reset the following settings:"
	/// </summary>
	public override string DescriptionResetFollowing => "ä»¥ä¸‹ã®è¨­å®šãŒãƒªã‚»ãƒƒãƒˆã•ã‚Œã¾ã™:";

	/// <summary>
	/// Key: "DescriptionRevertAccount"
	/// English String: "You are about to revert your account to a past state.\nTo revert your account you must set a new password."
	/// </summary>
	public override string DescriptionRevertAccount => "ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’å…ƒã®çŠ¶æ…‹ã«æˆ»ãã†ã¨ã—ã¦ã„ã¾ã™ã€‚\nã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’å…ƒã«æˆ»ã™ã«ã¯ã€æ–°ã—ã„ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã‚’è¨­å®šã™ã‚‹å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚";

	/// <summary>
	/// Key: "HeadingAccountRecovery"
	/// English String: "Reset Password"
	/// </summary>
	public override string HeadingAccountRecovery => "ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã®ãƒªã‚»ãƒƒãƒˆ";

	/// <summary>
	/// Key: "HeadingChooseAccount"
	/// English String: "Choose an Account"
	/// </summary>
	public override string HeadingChooseAccount => "ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’é¸ã¶";

	/// <summary>
	/// Key: "HeadingRevertAccount"
	/// English String: "Revert Account"
	/// </summary>
	public override string HeadingRevertAccount => "ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’å…ƒã«æˆ»ã™";

	/// <summary>
	/// Key: "LabelConfirmNewPassword"
	/// English String: "Confirm New Password"
	/// </summary>
	public override string LabelConfirmNewPassword => "æ–°ã—ã„ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã‚’ç¢ºèª";

	/// <summary>
	/// Key: "LabelEmail"
	/// English String: "Email"
	/// </summary>
	public override string LabelEmail => "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹";

	/// <summary>
	/// Key: "LabelNewPassword"
	/// English String: "New Password"
	/// </summary>
	public override string LabelNewPassword => "æ–°ã—ã„ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰";

	/// <summary>
	/// Key: "LabelPassword"
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰";

	/// <summary>
	/// Key: "LabelTwoStepVerification"
	/// English String: "Two Step Verification"
	/// </summary>
	public override string LabelTwoStepVerification => "äºŒæ®µéšŽèªè¨¼";

	/// <summary>
	/// Key: "MessageDisableTwoStepVerification"
	/// English String: "This will disable two step verification."
	/// </summary>
	public override string MessageDisableTwoStepVerification => "äºŒæ®µéšŽèªè¨¼ãŒç„¡åŠ¹ã«ãªã‚Šã¾ã™ã€‚";

	/// <summary>
	/// Key: "MessageRevertToUnverifiedEmail"
	/// English String: "You are reverting your email to an unverified email."
	/// </summary>
	public override string MessageRevertToUnverifiedEmail => "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’ã€èªè¨¼ã•ã‚Œã¦ã„ãªã„ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã«æˆ»ãã†ã¨ã—ã¦ã„ã¾ã™ã€‚";

	public AccountRecoveryResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "é€ä¿¡ã™ã‚‹";
	}

	protected override string _GetTemplateForDescriptionResetFollowing()
	{
		return "ä»¥ä¸‹ã®è¨­å®šãŒãƒªã‚»ãƒƒãƒˆã•ã‚Œã¾ã™:";
	}

	protected override string _GetTemplateForDescriptionRevertAccount()
	{
		return "ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’å…ƒã®çŠ¶æ…‹ã«æˆ»ãã†ã¨ã—ã¦ã„ã¾ã™ã€‚\nã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’å…ƒã«æˆ»ã™ã«ã¯ã€æ–°ã—ã„ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã‚’è¨­å®šã™ã‚‹å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚";
	}

	protected override string _GetTemplateForHeadingAccountRecovery()
	{
		return "ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã®ãƒªã‚»ãƒƒãƒˆ";
	}

	protected override string _GetTemplateForHeadingChooseAccount()
	{
		return "ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’é¸ã¶";
	}

	protected override string _GetTemplateForHeadingRevertAccount()
	{
		return "ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’å…ƒã«æˆ»ã™";
	}

	protected override string _GetTemplateForLabelConfirmNewPassword()
	{
		return "æ–°ã—ã„ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã‚’ç¢ºèª";
	}

	protected override string _GetTemplateForLabelEmail()
	{
		return "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹";
	}

	protected override string _GetTemplateForLabelNewPassword()
	{
		return "æ–°ã—ã„ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰";
	}

	protected override string _GetTemplateForLabelTwoStepVerification()
	{
		return "äºŒæ®µéšŽèªè¨¼";
	}

	/// <summary>
	/// Key: "MessageCreateNewPasswordDontUseOldPassword"
	/// English String: "Create a new password. Do {styleFront}not{styleEnd} use your old password."
	/// </summary>
	public override string MessageCreateNewPasswordDontUseOldPassword(string styleFront, string styleEnd)
	{
		return $"æ–°ã—ã„ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã‚’ä½œã‚Šã¾ã™ã€‚å¤ã„ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã‚’ {styleFront}ä½¿ã‚ãªã„{styleEnd} ã§ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForMessageCreateNewPasswordDontUseOldPassword()
	{
		return "æ–°ã—ã„ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã‚’ä½œã‚Šã¾ã™ã€‚å¤ã„ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã‚’ {styleFront}ä½¿ã‚ãªã„{styleEnd} ã§ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForMessageDisableTwoStepVerification()
	{
		return "äºŒæ®µéšŽèªè¨¼ãŒç„¡åŠ¹ã«ãªã‚Šã¾ã™ã€‚";
	}

	/// <summary>
	/// Key: "MessageDontUseOldPassword"
	/// English String: "Do {styleFront}not{styleEnd} use your old password."
	/// </summary>
	public override string MessageDontUseOldPassword(string styleFront, string styleEnd)
	{
		return $"å¤ã„ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã‚’ {styleFront}ä½¿ã‚ãªã„{styleEnd} ã§ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForMessageDontUseOldPassword()
	{
		return "å¤ã„ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã‚’ {styleFront}ä½¿ã‚ãªã„{styleEnd} ã§ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForMessageRevertToUnverifiedEmail()
	{
		return "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’ã€èªè¨¼ã•ã‚Œã¦ã„ãªã„ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã«æˆ»ãã†ã¨ã—ã¦ã„ã¾ã™ã€‚";
	}
}


}
