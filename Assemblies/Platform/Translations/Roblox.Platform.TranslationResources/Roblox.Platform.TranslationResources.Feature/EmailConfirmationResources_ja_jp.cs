namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides EmailConfirmationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class EmailConfirmationResources_ja_jp : EmailConfirmationResources_en_us, IEmailConfirmationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Done"
	/// button label
	/// English String: "Done"
	/// </summary>
	public override string ActionDone => "å®Œäº†";

	/// <summary>
	/// Key: "Action.ViewItem"
	/// button which takes user to item details page
	/// English String: "View Item"
	/// </summary>
	public override string ActionViewItem => "ã‚¢ã‚¤ãƒ†ãƒ ã‚’è¡¨ç¤º";

	/// <summary>
	/// Key: "Heading.ThankYou"
	/// heading
	/// English String: "Thank You!"
	/// </summary>
	public override string HeadingThankYou => "ã‚ã‚ŠãŒã¨ã†ã”ã–ã„ã¾ã™ï¼";

	/// <summary>
	/// Key: "Message.EmailVerified"
	/// success message confirmation
	/// English String: "Your email has been verified"
	/// </summary>
	public override string MessageEmailVerified => "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’èªè¨¼ã—ã¾ã—ãŸ";

	/// <summary>
	/// Key: "Message.EmailVerifiedEnjoyFreeHat"
	/// success message confirmation notifying user they have verified their email and have received a free hat
	/// English String: "Your email has been verified. Enjoy the free hat!"
	/// </summary>
	public override string MessageEmailVerifiedEnjoyFreeHat => "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’èªè¨¼ã—ã¾ã—ãŸã€‚ç„¡æ–™ã®å¸½å­ã‚’å—ã‘å–ã£ã¦ãã ã•ã„ï¼";

	public EmailConfirmationResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDone()
	{
		return "å®Œäº†";
	}

	protected override string _GetTemplateForActionViewItem()
	{
		return "ã‚¢ã‚¤ãƒ†ãƒ ã‚’è¡¨ç¤º";
	}

	protected override string _GetTemplateForHeadingThankYou()
	{
		return "ã‚ã‚ŠãŒã¨ã†ã”ã–ã„ã¾ã™ï¼";
	}

	protected override string _GetTemplateForMessageEmailVerified()
	{
		return "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’èªè¨¼ã—ã¾ã—ãŸ";
	}

	protected override string _GetTemplateForMessageEmailVerifiedEnjoyFreeHat()
	{
		return "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’èªè¨¼ã—ã¾ã—ãŸã€‚ç„¡æ–™ã®å¸½å­ã‚’å—ã‘å–ã£ã¦ãã ã•ã„ï¼";
	}
}


}
