namespace Roblox.Platform.TranslationResources.Authentication {
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
	public override string ActionSubmit => "æäº¤";

	/// <summary>
	/// Key: "DescriptionResetFollowing"
	/// English String: "This will reset the following settings:"
	/// </summary>
	public override string DescriptionResetFollowing => "è¿™æ ·å°†é‡ç½®ä¸‹åˆ—è®¾ç½®ï¼š";

	/// <summary>
	/// Key: "DescriptionRevertAccount"
	/// English String: "You are about to revert your account to a past state.\nTo revert your account you must set a new password."
	/// </summary>
	public override string DescriptionRevertAccount => "ä½ å³å°†æŠŠå¸æˆ·è¿˜åŽŸæˆä¹‹å‰çš„çŠ¶æ€ã€‚\nè‹¥è¦è¿˜åŽŸä½ çš„å¸æˆ·ï¼Œè¯·å…ˆè®¾ç½®ä¸€ä¸ªæ–°çš„å¯†ç ã€‚";

	/// <summary>
	/// Key: "HeadingAccountRecovery"
	/// English String: "Reset Password"
	/// </summary>
	public override string HeadingAccountRecovery => "é‡ç½®å¯†ç ";

	/// <summary>
	/// Key: "HeadingChooseAccount"
	/// English String: "Choose an Account"
	/// </summary>
	public override string HeadingChooseAccount => "é€‰æ‹©å¸æˆ·";

	/// <summary>
	/// Key: "HeadingRevertAccount"
	/// English String: "Revert Account"
	/// </summary>
	public override string HeadingRevertAccount => "è¿˜åŽŸå¸æˆ·";

	/// <summary>
	/// Key: "LabelConfirmNewPassword"
	/// English String: "Confirm New Password"
	/// </summary>
	public override string LabelConfirmNewPassword => "ç¡®è®¤æ–°å¯†ç ";

	/// <summary>
	/// Key: "LabelEmail"
	/// English String: "Email"
	/// </summary>
	public override string LabelEmail => "ç”µå­é‚®ä»¶";

	/// <summary>
	/// Key: "LabelNewPassword"
	/// English String: "New Password"
	/// </summary>
	public override string LabelNewPassword => "æ–°å¯†ç ";

	/// <summary>
	/// Key: "LabelPassword"
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "å¯†ç ";

	/// <summary>
	/// Key: "LabelTwoStepVerification"
	/// English String: "Two Step Verification"
	/// </summary>
	public override string LabelTwoStepVerification => "ä¸¤æ­¥éªŒè¯";

	/// <summary>
	/// Key: "MessageDisableTwoStepVerification"
	/// English String: "This will disable two step verification."
	/// </summary>
	public override string MessageDisableTwoStepVerification => "è¿™æ ·åšå°†åœç”¨ä¸¤æ­¥éªŒè¯ã€‚";

	/// <summary>
	/// Key: "MessageRevertToUnverifiedEmail"
	/// English String: "You are reverting your email to an unverified email."
	/// </summary>
	public override string MessageRevertToUnverifiedEmail => "ä½ å³å°†æŠŠç”µå­é‚®ä»¶è¿˜åŽŸæˆæœªéªŒè¯çš„ç”µå­é‚®ä»¶ã€‚";

	public AccountRecoveryResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "æäº¤";
	}

	protected override string _GetTemplateForDescriptionResetFollowing()
	{
		return "è¿™æ ·å°†é‡ç½®ä¸‹åˆ—è®¾ç½®ï¼š";
	}

	protected override string _GetTemplateForDescriptionRevertAccount()
	{
		return "ä½ å³å°†æŠŠå¸æˆ·è¿˜åŽŸæˆä¹‹å‰çš„çŠ¶æ€ã€‚\nè‹¥è¦è¿˜åŽŸä½ çš„å¸æˆ·ï¼Œè¯·å…ˆè®¾ç½®ä¸€ä¸ªæ–°çš„å¯†ç ã€‚";
	}

	protected override string _GetTemplateForHeadingAccountRecovery()
	{
		return "é‡ç½®å¯†ç ";
	}

	protected override string _GetTemplateForHeadingChooseAccount()
	{
		return "é€‰æ‹©å¸æˆ·";
	}

	protected override string _GetTemplateForHeadingRevertAccount()
	{
		return "è¿˜åŽŸå¸æˆ·";
	}

	protected override string _GetTemplateForLabelConfirmNewPassword()
	{
		return "ç¡®è®¤æ–°å¯†ç ";
	}

	protected override string _GetTemplateForLabelEmail()
	{
		return "ç”µå­é‚®ä»¶";
	}

	protected override string _GetTemplateForLabelNewPassword()
	{
		return "æ–°å¯†ç ";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "å¯†ç ";
	}

	protected override string _GetTemplateForLabelTwoStepVerification()
	{
		return "ä¸¤æ­¥éªŒè¯";
	}

	/// <summary>
	/// Key: "MessageCreateNewPasswordDontUseOldPassword"
	/// English String: "Create a new password. Do {styleFront}not{styleEnd} use your old password."
	/// </summary>
	public override string MessageCreateNewPasswordDontUseOldPassword(string styleFront, string styleEnd)
	{
		return $"åˆ›å»ºä¸€ä¸ªæ–°å¯†ç ã€‚è¯·{styleFront}å‹¿{styleEnd}ä½¿ç”¨æ—§å¯†ç ã€‚";
	}

	protected override string _GetTemplateForMessageCreateNewPasswordDontUseOldPassword()
	{
		return "åˆ›å»ºä¸€ä¸ªæ–°å¯†ç ã€‚è¯·{styleFront}å‹¿{styleEnd}ä½¿ç”¨æ—§å¯†ç ã€‚";
	}

	protected override string _GetTemplateForMessageDisableTwoStepVerification()
	{
		return "è¿™æ ·åšå°†åœç”¨ä¸¤æ­¥éªŒè¯ã€‚";
	}

	/// <summary>
	/// Key: "MessageDontUseOldPassword"
	/// English String: "Do {styleFront}not{styleEnd} use your old password."
	/// </summary>
	public override string MessageDontUseOldPassword(string styleFront, string styleEnd)
	{
		return $"è¯·{styleFront}å‹¿{styleEnd}ä½¿ç”¨æ—§å¯†ç ã€‚";
	}

	protected override string _GetTemplateForMessageDontUseOldPassword()
	{
		return "è¯·{styleFront}å‹¿{styleEnd}ä½¿ç”¨æ—§å¯†ç ã€‚";
	}

	protected override string _GetTemplateForMessageRevertToUnverifiedEmail()
	{
		return "ä½ å³å°†æŠŠç”µå­é‚®ä»¶è¿˜åŽŸæˆæœªéªŒè¯çš„ç”µå­é‚®ä»¶ã€‚";
	}
}


}
