namespace Roblox.Platform.TranslationResources.Authentication {
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
	public override string ActionSubmit => "ì €ìž¥";

	/// <summary>
	/// Key: "DescriptionResetFollowing"
	/// English String: "This will reset the following settings:"
	/// </summary>
	public override string DescriptionResetFollowing => "ê³„ì •ì„ ë³µêµ¬í•˜ë©´ ë‹¤ìŒ ì„¤ì •ì´ ì´ˆê¸°í™”ë©ë‹ˆë‹¤:";

	/// <summary>
	/// Key: "DescriptionRevertAccount"
	/// English String: "You are about to revert your account to a past state.\nTo revert your account you must set a new password."
	/// </summary>
	public override string DescriptionRevertAccount => "ê³„ì •ì„ ì´ì „ ìƒíƒœë¡œ ë³µêµ¬í•©ë‹ˆë‹¤.\nê³„ì •ì„ ë³µêµ¬í•˜ë ¤ë©´ ìƒˆë¡œìš´ ë¹„ë°€ë²ˆí˜¸ë¥¼ ì„¤ì •í•´ì•¼ í•©ë‹ˆë‹¤.";

	/// <summary>
	/// Key: "HeadingAccountRecovery"
	/// English String: "Reset Password"
	/// </summary>
	public override string HeadingAccountRecovery => "ë¹„ë°€ë²ˆí˜¸ ìž¬ì„¤ì •";

	/// <summary>
	/// Key: "HeadingChooseAccount"
	/// English String: "Choose an Account"
	/// </summary>
	public override string HeadingChooseAccount => "ê³„ì •ì„ ì„ íƒí•˜ì„¸ìš”";

	/// <summary>
	/// Key: "HeadingRevertAccount"
	/// English String: "Revert Account"
	/// </summary>
	public override string HeadingRevertAccount => "ê³„ì • ë³µêµ¬";

	/// <summary>
	/// Key: "LabelConfirmNewPassword"
	/// English String: "Confirm New Password"
	/// </summary>
	public override string LabelConfirmNewPassword => "ìƒˆ ë¹„ë°€ë²ˆí˜¸ í™•ì¸";

	/// <summary>
	/// Key: "LabelEmail"
	/// English String: "Email"
	/// </summary>
	public override string LabelEmail => "ì´ë©”ì¼";

	/// <summary>
	/// Key: "LabelNewPassword"
	/// English String: "New Password"
	/// </summary>
	public override string LabelNewPassword => "ìƒˆ ë¹„ë°€ë²ˆí˜¸";

	/// <summary>
	/// Key: "LabelPassword"
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "ë¹„ë°€ë²ˆí˜¸";

	/// <summary>
	/// Key: "LabelTwoStepVerification"
	/// English String: "Two Step Verification"
	/// </summary>
	public override string LabelTwoStepVerification => "2ë‹¨ê³„ ì¸ì¦";

	/// <summary>
	/// Key: "MessageDisableTwoStepVerification"
	/// English String: "This will disable two step verification."
	/// </summary>
	public override string MessageDisableTwoStepVerification => "2ë‹¨ê³„ ì¸ì¦ì´ ë¹„í™œì„±í™”ë©ë‹ˆë‹¤.";

	/// <summary>
	/// Key: "MessageRevertToUnverifiedEmail"
	/// English String: "You are reverting your email to an unverified email."
	/// </summary>
	public override string MessageRevertToUnverifiedEmail => "ì´ë©”ì¼ì´ ë¯¸ì¸ì¦ ìƒíƒœë¡œ ë‹¤ì‹œ ì „í™˜ë©ë‹ˆë‹¤.";

	public AccountRecoveryResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "ì €ìž¥";
	}

	protected override string _GetTemplateForDescriptionResetFollowing()
	{
		return "ê³„ì •ì„ ë³µêµ¬í•˜ë©´ ë‹¤ìŒ ì„¤ì •ì´ ì´ˆê¸°í™”ë©ë‹ˆë‹¤:";
	}

	protected override string _GetTemplateForDescriptionRevertAccount()
	{
		return "ê³„ì •ì„ ì´ì „ ìƒíƒœë¡œ ë³µêµ¬í•©ë‹ˆë‹¤.\nê³„ì •ì„ ë³µêµ¬í•˜ë ¤ë©´ ìƒˆë¡œìš´ ë¹„ë°€ë²ˆí˜¸ë¥¼ ì„¤ì •í•´ì•¼ í•©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForHeadingAccountRecovery()
	{
		return "ë¹„ë°€ë²ˆí˜¸ ìž¬ì„¤ì •";
	}

	protected override string _GetTemplateForHeadingChooseAccount()
	{
		return "ê³„ì •ì„ ì„ íƒí•˜ì„¸ìš”";
	}

	protected override string _GetTemplateForHeadingRevertAccount()
	{
		return "ê³„ì • ë³µêµ¬";
	}

	protected override string _GetTemplateForLabelConfirmNewPassword()
	{
		return "ìƒˆ ë¹„ë°€ë²ˆí˜¸ í™•ì¸";
	}

	protected override string _GetTemplateForLabelEmail()
	{
		return "ì´ë©”ì¼";
	}

	protected override string _GetTemplateForLabelNewPassword()
	{
		return "ìƒˆ ë¹„ë°€ë²ˆí˜¸";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "ë¹„ë°€ë²ˆí˜¸";
	}

	protected override string _GetTemplateForLabelTwoStepVerification()
	{
		return "2ë‹¨ê³„ ì¸ì¦";
	}

	/// <summary>
	/// Key: "MessageCreateNewPasswordDontUseOldPassword"
	/// English String: "Create a new password. Do {styleFront}not{styleEnd} use your old password."
	/// </summary>
	public override string MessageCreateNewPasswordDontUseOldPassword(string styleFront, string styleEnd)
	{
		return $"ìƒˆ ë¹„ë°€ë²ˆí˜¸ë¥¼ ì„¤ì •í•˜ì„¸ìš”. ì´ì „ ë¹„ë°€ë²ˆí˜¸ë¥¼ ì‚¬ìš©í•˜ì§€ {styleFront}ë§ˆì„¸ìš”{styleEnd}.";
	}

	protected override string _GetTemplateForMessageCreateNewPasswordDontUseOldPassword()
	{
		return "ìƒˆ ë¹„ë°€ë²ˆí˜¸ë¥¼ ì„¤ì •í•˜ì„¸ìš”. ì´ì „ ë¹„ë°€ë²ˆí˜¸ë¥¼ ì‚¬ìš©í•˜ì§€ {styleFront}ë§ˆì„¸ìš”{styleEnd}.";
	}

	protected override string _GetTemplateForMessageDisableTwoStepVerification()
	{
		return "2ë‹¨ê³„ ì¸ì¦ì´ ë¹„í™œì„±í™”ë©ë‹ˆë‹¤.";
	}

	/// <summary>
	/// Key: "MessageDontUseOldPassword"
	/// English String: "Do {styleFront}not{styleEnd} use your old password."
	/// </summary>
	public override string MessageDontUseOldPassword(string styleFront, string styleEnd)
	{
		return $"ê¸°ì¡´ ë¹„ë°€ë²ˆí˜¸ë¥¼ ì‚¬ìš©í•˜ì§€ {styleFront}ë§ˆì„¸ìš”{styleEnd}.";
	}

	protected override string _GetTemplateForMessageDontUseOldPassword()
	{
		return "ê¸°ì¡´ ë¹„ë°€ë²ˆí˜¸ë¥¼ ì‚¬ìš©í•˜ì§€ {styleFront}ë§ˆì„¸ìš”{styleEnd}.";
	}

	protected override string _GetTemplateForMessageRevertToUnverifiedEmail()
	{
		return "ì´ë©”ì¼ì´ ë¯¸ì¸ì¦ ìƒíƒœë¡œ ë‹¤ì‹œ ì „í™˜ë©ë‹ˆë‹¤.";
	}
}


}
