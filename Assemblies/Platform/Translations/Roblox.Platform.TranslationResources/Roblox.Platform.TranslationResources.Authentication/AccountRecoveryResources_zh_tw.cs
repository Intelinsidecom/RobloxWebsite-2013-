namespace Roblox.Platform.TranslationResources.Authentication {
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
	public override string ActionSubmit => "æäº¤";

	/// <summary>
	/// Key: "DescriptionResetFollowing"
	/// English String: "This will reset the following settings:"
	/// </summary>
	public override string DescriptionResetFollowing => "æ­¤å‹•ä½œå°‡æœƒé‡ç½®ä»¥ä¸‹è¨­å®šï¼š";

	/// <summary>
	/// Key: "DescriptionRevertAccount"
	/// English String: "You are about to revert your account to a past state.\nTo revert your account you must set a new password."
	/// </summary>
	public override string DescriptionRevertAccount => "æ‚¨å³å°‡æŠŠå¸³è™Ÿé‚„åŽŸæˆä¹‹å‰çš„ç‹€æ…‹ã€‚\nè‹¥è¦é‚„åŽŸæ‚¨çš„å¸³è™Ÿï¼Œè«‹å…ˆè¨­ç½®æ–°çš„å¯†ç¢¼ã€‚";

	/// <summary>
	/// Key: "HeadingAccountRecovery"
	/// English String: "Reset Password"
	/// </summary>
	public override string HeadingAccountRecovery => "é‡ç½®å¯†ç¢¼";

	/// <summary>
	/// Key: "HeadingChooseAccount"
	/// English String: "Choose an Account"
	/// </summary>
	public override string HeadingChooseAccount => "é¸æ“‡å¸³è™Ÿ";

	/// <summary>
	/// Key: "HeadingRevertAccount"
	/// English String: "Revert Account"
	/// </summary>
	public override string HeadingRevertAccount => "é‚„åŽŸå¸³è™Ÿ";

	/// <summary>
	/// Key: "LabelConfirmNewPassword"
	/// English String: "Confirm New Password"
	/// </summary>
	public override string LabelConfirmNewPassword => "ç¢ºèªæ–°å¯†ç¢¼";

	/// <summary>
	/// Key: "LabelEmail"
	/// English String: "Email"
	/// </summary>
	public override string LabelEmail => "é›»å­éƒµä»¶åœ°å€";

	/// <summary>
	/// Key: "LabelNewPassword"
	/// English String: "New Password"
	/// </summary>
	public override string LabelNewPassword => "æ–°å¯†ç¢¼";

	/// <summary>
	/// Key: "LabelPassword"
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "å¯†ç¢¼";

	/// <summary>
	/// Key: "LabelTwoStepVerification"
	/// English String: "Two Step Verification"
	/// </summary>
	public override string LabelTwoStepVerification => "é›™æ­¥é©Ÿé©—è­‰";

	/// <summary>
	/// Key: "MessageDisableTwoStepVerification"
	/// English String: "This will disable two step verification."
	/// </summary>
	public override string MessageDisableTwoStepVerification => "æ­¤å‹•ä½œæœƒåœç”¨é›™æ­¥é©Ÿé©—è­‰ã€‚";

	/// <summary>
	/// Key: "MessageRevertToUnverifiedEmail"
	/// English String: "You are reverting your email to an unverified email."
	/// </summary>
	public override string MessageRevertToUnverifiedEmail => "æ‚¨å³å°‡æŠŠé›»å­éƒµä»¶åœ°å€é‚„åŽŸæˆæœªé©—è­‰çš„é›»å­éƒµä»¶åœ°å€ã€‚";

	public AccountRecoveryResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "æäº¤";
	}

	protected override string _GetTemplateForDescriptionResetFollowing()
	{
		return "æ­¤å‹•ä½œå°‡æœƒé‡ç½®ä»¥ä¸‹è¨­å®šï¼š";
	}

	protected override string _GetTemplateForDescriptionRevertAccount()
	{
		return "æ‚¨å³å°‡æŠŠå¸³è™Ÿé‚„åŽŸæˆä¹‹å‰çš„ç‹€æ…‹ã€‚\nè‹¥è¦é‚„åŽŸæ‚¨çš„å¸³è™Ÿï¼Œè«‹å…ˆè¨­ç½®æ–°çš„å¯†ç¢¼ã€‚";
	}

	protected override string _GetTemplateForHeadingAccountRecovery()
	{
		return "é‡ç½®å¯†ç¢¼";
	}

	protected override string _GetTemplateForHeadingChooseAccount()
	{
		return "é¸æ“‡å¸³è™Ÿ";
	}

	protected override string _GetTemplateForHeadingRevertAccount()
	{
		return "é‚„åŽŸå¸³è™Ÿ";
	}

	protected override string _GetTemplateForLabelConfirmNewPassword()
	{
		return "ç¢ºèªæ–°å¯†ç¢¼";
	}

	protected override string _GetTemplateForLabelEmail()
	{
		return "é›»å­éƒµä»¶åœ°å€";
	}

	protected override string _GetTemplateForLabelNewPassword()
	{
		return "æ–°å¯†ç¢¼";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "å¯†ç¢¼";
	}

	protected override string _GetTemplateForLabelTwoStepVerification()
	{
		return "é›™æ­¥é©Ÿé©—è­‰";
	}

	/// <summary>
	/// Key: "MessageCreateNewPasswordDontUseOldPassword"
	/// English String: "Create a new password. Do {styleFront}not{styleEnd} use your old password."
	/// </summary>
	public override string MessageCreateNewPasswordDontUseOldPassword(string styleFront, string styleEnd)
	{
		return $"è«‹å»ºç«‹æ–°å¯†ç¢¼ã€‚{styleFront}ä¸å¯{styleEnd}ä½¿ç”¨èˆŠå¯†ç¢¼ã€‚";
	}

	protected override string _GetTemplateForMessageCreateNewPasswordDontUseOldPassword()
	{
		return "è«‹å»ºç«‹æ–°å¯†ç¢¼ã€‚{styleFront}ä¸å¯{styleEnd}ä½¿ç”¨èˆŠå¯†ç¢¼ã€‚";
	}

	protected override string _GetTemplateForMessageDisableTwoStepVerification()
	{
		return "æ­¤å‹•ä½œæœƒåœç”¨é›™æ­¥é©Ÿé©—è­‰ã€‚";
	}

	/// <summary>
	/// Key: "MessageDontUseOldPassword"
	/// English String: "Do {styleFront}not{styleEnd} use your old password."
	/// </summary>
	public override string MessageDontUseOldPassword(string styleFront, string styleEnd)
	{
		return $"è«‹{styleFront}ä¸è¦{styleEnd}ä½¿ç”¨èˆŠå¯†ç¢¼ã€‚";
	}

	protected override string _GetTemplateForMessageDontUseOldPassword()
	{
		return "è«‹{styleFront}ä¸è¦{styleEnd}ä½¿ç”¨èˆŠå¯†ç¢¼ã€‚";
	}

	protected override string _GetTemplateForMessageRevertToUnverifiedEmail()
	{
		return "æ‚¨å³å°‡æŠŠé›»å­éƒµä»¶åœ°å€é‚„åŽŸæˆæœªé©—è­‰çš„é›»å­éƒµä»¶åœ°å€ã€‚";
	}
}


}
