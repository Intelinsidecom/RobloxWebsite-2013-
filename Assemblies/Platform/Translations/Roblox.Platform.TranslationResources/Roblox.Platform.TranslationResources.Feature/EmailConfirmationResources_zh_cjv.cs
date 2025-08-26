namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides EmailConfirmationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class EmailConfirmationResources_zh_cjv : EmailConfirmationResources_en_us, IEmailConfirmationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Done"
	/// button label
	/// English String: "Done"
	/// </summary>
	public override string ActionDone => "å®Œæˆ";

	/// <summary>
	/// Key: "Action.ViewItem"
	/// button which takes user to item details page
	/// English String: "View Item"
	/// </summary>
	public override string ActionViewItem => "æŸ¥çœ‹ç‰©å“";

	/// <summary>
	/// Key: "Heading.ThankYou"
	/// heading
	/// English String: "Thank You!"
	/// </summary>
	public override string HeadingThankYou => "è°¢è°¢ï¼";

	/// <summary>
	/// Key: "Message.EmailVerified"
	/// success message confirmation
	/// English String: "Your email has been verified"
	/// </summary>
	public override string MessageEmailVerified => "ä½ çš„ç”µå­é‚®ä»¶å·²å®ŒæˆéªŒè¯";

	/// <summary>
	/// Key: "Message.EmailVerifiedEnjoyFreeHat"
	/// success message confirmation notifying user they have verified their email and have received a free hat
	/// English String: "Your email has been verified. Enjoy the free hat!"
	/// </summary>
	public override string MessageEmailVerifiedEnjoyFreeHat => "ä½ çš„ç”µå­é‚®ä»¶å·²å®ŒæˆéªŒè¯ã€‚æ­å–œä½ èŽ·å¾—è¿™é¡¶å…è´¹çš„å¸½å­ï¼";

	public EmailConfirmationResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDone()
	{
		return "å®Œæˆ";
	}

	protected override string _GetTemplateForActionViewItem()
	{
		return "æŸ¥çœ‹ç‰©å“";
	}

	protected override string _GetTemplateForHeadingThankYou()
	{
		return "è°¢è°¢ï¼";
	}

	protected override string _GetTemplateForMessageEmailVerified()
	{
		return "ä½ çš„ç”µå­é‚®ä»¶å·²å®ŒæˆéªŒè¯";
	}

	protected override string _GetTemplateForMessageEmailVerifiedEnjoyFreeHat()
	{
		return "ä½ çš„ç”µå­é‚®ä»¶å·²å®ŒæˆéªŒè¯ã€‚æ­å–œä½ èŽ·å¾—è¿™é¡¶å…è´¹çš„å¸½å­ï¼";
	}
}


}
