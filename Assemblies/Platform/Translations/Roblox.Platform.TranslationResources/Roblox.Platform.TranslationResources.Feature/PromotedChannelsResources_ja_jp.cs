namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides PromotedChannelsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PromotedChannelsResources_ja_jp : PromotedChannelsResources_en_us, IPromotedChannelsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AddLink"
	/// The button text for adding an additional social link.
	/// English String: "Add Link"
	/// </summary>
	public override string ActionAddLink => "ãƒªãƒ³ã‚¯ã‚’è¿½åŠ ";

	/// <summary>
	/// Key: "Action.Remove"
	/// The remove button text for configuring social links.
	/// English String: "Remove"
	/// </summary>
	public override string ActionRemove => "å‰Šé™¤";

	/// <summary>
	/// Key: "Action.Save"
	/// The save button text for updating a social link.
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "ä¿å­˜";

	/// <summary>
	/// Key: "HeadingSocialLinks"
	/// The heading of the social links panel on the game details page
	/// English String: "Social Links"
	/// </summary>
	public override string HeadingSocialLinks => "SNSãƒªãƒ³ã‚¯";

	/// <summary>
	/// Key: "HeadingSocialMedia"
	/// The heading of the social media panel on the game details page
	/// English String: "Social Media"
	/// </summary>
	public override string HeadingSocialMedia => "ã‚½ãƒ¼ã‚·ãƒ£ãƒ«ãƒ¡ãƒ‡ã‚£ã‚¢";

	/// <summary>
	/// Key: "Label.Title"
	/// Placeholder text for inputting a title for a social link.
	/// English String: "Title"
	/// </summary>
	public override string LabelTitle => "ã‚¿ã‚¤ãƒˆãƒ«";

	/// <summary>
	/// Key: "Label.Url"
	/// Placeholder text for inputting a url for a social link.
	/// English String: "Url"
	/// </summary>
	public override string LabelUrl => "URL";

	/// <summary>
	/// Key: "Message.NoGroupPermission"
	/// The error message displayed when the user does not have permission to the group they are trying to add.
	/// English String: "You do not have permission to configure this group."
	/// </summary>
	public override string MessageNoGroupPermission => "ã“ã®ã‚°ãƒ«ãƒ¼ãƒ—ã®ç’°å¢ƒè¨­å®šã‚’ã™ã‚‹æ¨©é™ãŒã‚ã‚Šã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Message.SocialLinkInvalidError"
	/// The error message displayed when a social link attempts to be saved but no longer exists.
	/// English String: "The social link no longer exists."
	/// </summary>
	public override string MessageSocialLinkInvalidError => "ãã®SNSãƒªãƒ³ã‚¯ã¯ç¾åœ¨ã¯ã‚ã‚Šã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Message.SocialLinkRemoved"
	/// The message displayed when the social link has been removed.
	/// English String: "The social media link has been deleted."
	/// </summary>
	public override string MessageSocialLinkRemoved => "ã‚½ãƒ¼ã‚·ãƒ£ãƒ«ãƒ¡ãƒ‡ã‚£ã‚¢ãƒªãƒ³ã‚¯ãŒå‰Šé™¤ã•ã‚Œã¾ã—ãŸã€‚";

	/// <summary>
	/// Key: "Message.SocialLinksEditDisabledError"
	/// The error message displayed when the social links feature is disabled and attempt to be edited.
	/// English String: "Social links may not be edited at this time."
	/// </summary>
	public override string MessageSocialLinksEditDisabledError => "ç¾åœ¨ã€SNSãƒªãƒ³ã‚¯ã¯ç·¨é›†ã§ããªã„å¯èƒ½æ€§ãŒã‚ã‚Šã¾ã™ã€‚";

	/// <summary>
	/// Key: "Message.TitleEmptyError"
	/// The error message displayed when the title input is empty.
	/// English String: "The title cannot be empty."
	/// </summary>
	public override string MessageTitleEmptyError => "ã‚¿ã‚¤ãƒˆãƒ«ã¯ç©ºç™½ã«ã§ãã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Message.TitleModeratedError"
	/// The error message displayed when a title is moderated while being edited.
	/// English String: "The title has been moderated, please try something else."
	/// </summary>
	public override string MessageTitleModeratedError => "ã‚¿ã‚¤ãƒˆãƒ«ãŒè¦åˆ¶å¯¾è±¡ã§ã™ã€‚ä»–ã®ã‚¿ã‚¤ãƒˆãƒ«ã‚’ãŠè©¦ã—ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Message.UnauthorizedError"
	/// The error message displayed when an action is attempted against a social link but the user does not have permission to edit social links.
	/// English String: "You do not have permission to update social links."
	/// </summary>
	public override string MessageUnauthorizedError => "SNSãƒªãƒ³ã‚¯ã®ã‚¢ãƒƒãƒ—ãƒ‡ãƒ¼ãƒˆã¯è¨±å¯ã•ã‚Œã¦ã„ã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Message.UnknownError"
	/// The error message displayed when something unknown goes wrong trying to manage a social link.
	/// English String: "Something went wrong, please try again."
	/// </summary>
	public override string MessageUnknownError => "å•é¡ŒãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Message.UrlEmptyError"
	/// The error message displayed when the url input is empty.
	/// English String: "The url cannot be empty."
	/// </summary>
	public override string MessageUrlEmptyError => "URLã¯ç©ºç™½ã«ã§ãã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Message.UrlSocialMediaTypeMismatchError"
	/// The error message displayed when the url input is not a valid url for the social media type selected.
	/// English String: "The url must match the social media type."
	/// </summary>
	public override string MessageUrlSocialMediaTypeMismatchError => "URLã¯ã‚½ãƒ¼ã‚·ãƒ£ãƒ«ãƒ¡ãƒ‡ã‚£ã‚¢ã‚¿ã‚¤ãƒ—ã¨ä¸€è‡´ã—ã¦ã„ã‚‹å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚";

	public PromotedChannelsResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddLink()
	{
		return "ãƒªãƒ³ã‚¯ã‚’è¿½åŠ ";
	}

	protected override string _GetTemplateForActionRemove()
	{
		return "å‰Šé™¤";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "ä¿å­˜";
	}

	protected override string _GetTemplateForHeadingSocialLinks()
	{
		return "SNSãƒªãƒ³ã‚¯";
	}

	protected override string _GetTemplateForHeadingSocialMedia()
	{
		return "ã‚½ãƒ¼ã‚·ãƒ£ãƒ«ãƒ¡ãƒ‡ã‚£ã‚¢";
	}

	/// <summary>
	/// Key: "Label.Limits"
	/// The limitation notice when configuring social links.
	/// English String: "You can add up to {socialLinkLimit} social links."
	/// </summary>
	public override string LabelLimits(string socialLinkLimit)
	{
		return $"ã‚½ãƒ¼ã‚·ãƒ£ãƒ«ãƒªãƒ³ã‚¯ã¯{socialLinkLimit}å€‹ã¾ã§è¿½åŠ ã§ãã¾ã™ã€‚";
	}

	protected override string _GetTemplateForLabelLimits()
	{
		return "ã‚½ãƒ¼ã‚·ãƒ£ãƒ«ãƒªãƒ³ã‚¯ã¯{socialLinkLimit}å€‹ã¾ã§è¿½åŠ ã§ãã¾ã™ã€‚";
	}

	protected override string _GetTemplateForLabelTitle()
	{
		return "ã‚¿ã‚¤ãƒˆãƒ«";
	}

	protected override string _GetTemplateForLabelUrl()
	{
		return "URL";
	}

	protected override string _GetTemplateForMessageNoGroupPermission()
	{
		return "ã“ã®ã‚°ãƒ«ãƒ¼ãƒ—ã®ç’°å¢ƒè¨­å®šã‚’ã™ã‚‹æ¨©é™ãŒã‚ã‚Šã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForMessageSocialLinkInvalidError()
	{
		return "ãã®SNSãƒªãƒ³ã‚¯ã¯ç¾åœ¨ã¯ã‚ã‚Šã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForMessageSocialLinkRemoved()
	{
		return "ã‚½ãƒ¼ã‚·ãƒ£ãƒ«ãƒ¡ãƒ‡ã‚£ã‚¢ãƒªãƒ³ã‚¯ãŒå‰Šé™¤ã•ã‚Œã¾ã—ãŸã€‚";
	}

	/// <summary>
	/// Key: "Message.SocialLinkSaved"
	/// The message displayed when a social link is saved successfully.
	/// English String: "{title} has been saved."
	/// </summary>
	public override string MessageSocialLinkSaved(string title)
	{
		return $"{title}ã‚’ä¿å­˜ã—ã¾ã—ãŸã€‚";
	}

	protected override string _GetTemplateForMessageSocialLinkSaved()
	{
		return "{title}ã‚’ä¿å­˜ã—ã¾ã—ãŸã€‚";
	}

	protected override string _GetTemplateForMessageSocialLinksEditDisabledError()
	{
		return "ç¾åœ¨ã€SNSãƒªãƒ³ã‚¯ã¯ç·¨é›†ã§ããªã„å¯èƒ½æ€§ãŒã‚ã‚Šã¾ã™ã€‚";
	}

	/// <summary>
	/// Key: "Message.SocialLinkTypeLimitError"
	/// The error message that gets displayed when configuring social links and there are multiple links with the same social media type.
	/// English String: "Cannot have more than one {socialMediaType} social media links."
	/// </summary>
	public override string MessageSocialLinkTypeLimitError(string socialMediaType)
	{
		return $"{socialMediaType}ã®ã‚½ãƒ¼ã‚·ãƒ£ãƒ«ãƒ¡ãƒ‡ã‚£ã‚¢ãƒªãƒ³ã‚¯ã¯ã€1ã¤ã—ã‹ç™»éŒ²ã§ãã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForMessageSocialLinkTypeLimitError()
	{
		return "{socialMediaType}ã®ã‚½ãƒ¼ã‚·ãƒ£ãƒ«ãƒ¡ãƒ‡ã‚£ã‚¢ãƒªãƒ³ã‚¯ã¯ã€1ã¤ã—ã‹ç™»éŒ²ã§ãã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForMessageTitleEmptyError()
	{
		return "ã‚¿ã‚¤ãƒˆãƒ«ã¯ç©ºç™½ã«ã§ãã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForMessageTitleModeratedError()
	{
		return "ã‚¿ã‚¤ãƒˆãƒ«ãŒè¦åˆ¶å¯¾è±¡ã§ã™ã€‚ä»–ã®ã‚¿ã‚¤ãƒˆãƒ«ã‚’ãŠè©¦ã—ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForMessageUnauthorizedError()
	{
		return "SNSãƒªãƒ³ã‚¯ã®ã‚¢ãƒƒãƒ—ãƒ‡ãƒ¼ãƒˆã¯è¨±å¯ã•ã‚Œã¦ã„ã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForMessageUnknownError()
	{
		return "å•é¡ŒãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForMessageUrlEmptyError()
	{
		return "URLã¯ç©ºç™½ã«ã§ãã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForMessageUrlSocialMediaTypeMismatchError()
	{
		return "URLã¯ã‚½ãƒ¼ã‚·ãƒ£ãƒ«ãƒ¡ãƒ‡ã‚£ã‚¢ã‚¿ã‚¤ãƒ—ã¨ä¸€è‡´ã—ã¦ã„ã‚‹å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚";
	}
}


}
