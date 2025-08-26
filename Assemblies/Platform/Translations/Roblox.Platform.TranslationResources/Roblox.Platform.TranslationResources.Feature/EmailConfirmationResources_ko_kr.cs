namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides EmailConfirmationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class EmailConfirmationResources_ko_kr : EmailConfirmationResources_en_us, IEmailConfirmationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Done"
	/// button label
	/// English String: "Done"
	/// </summary>
	public override string ActionDone => "ì™„ë£Œ";

	/// <summary>
	/// Key: "Action.ViewItem"
	/// button which takes user to item details page
	/// English String: "View Item"
	/// </summary>
	public override string ActionViewItem => "ì•„ì´í…œ ë³´ê¸°";

	/// <summary>
	/// Key: "Heading.ThankYou"
	/// heading
	/// English String: "Thank You!"
	/// </summary>
	public override string HeadingThankYou => "ê°ì‚¬í•©ë‹ˆë‹¤!";

	/// <summary>
	/// Key: "Message.EmailVerified"
	/// success message confirmation
	/// English String: "Your email has been verified"
	/// </summary>
	public override string MessageEmailVerified => "ì´ë©”ì¼ì´ ì¸ì¦ë˜ì—ˆìŠµë‹ˆë‹¤";

	/// <summary>
	/// Key: "Message.EmailVerifiedEnjoyFreeHat"
	/// success message confirmation notifying user they have verified their email and have received a free hat
	/// English String: "Your email has been verified. Enjoy the free hat!"
	/// </summary>
	public override string MessageEmailVerifiedEnjoyFreeHat => "ì´ë©”ì¼ ì¸ì¦ë˜ì—ˆìŠµë‹ˆë‹¤. ë¬´ë£Œ ëª¨ìžë¥¼ ì°©ìš©í•  ìˆ˜ ìžˆì–´ìš”!";

	public EmailConfirmationResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDone()
	{
		return "ì™„ë£Œ";
	}

	protected override string _GetTemplateForActionViewItem()
	{
		return "ì•„ì´í…œ ë³´ê¸°";
	}

	protected override string _GetTemplateForHeadingThankYou()
	{
		return "ê°ì‚¬í•©ë‹ˆë‹¤!";
	}

	protected override string _GetTemplateForMessageEmailVerified()
	{
		return "ì´ë©”ì¼ì´ ì¸ì¦ë˜ì—ˆìŠµë‹ˆë‹¤";
	}

	protected override string _GetTemplateForMessageEmailVerifiedEnjoyFreeHat()
	{
		return "ì´ë©”ì¼ ì¸ì¦ë˜ì—ˆìŠµë‹ˆë‹¤. ë¬´ë£Œ ëª¨ìžë¥¼ ì°©ìš©í•  ìˆ˜ ìžˆì–´ìš”!";
	}
}


}
