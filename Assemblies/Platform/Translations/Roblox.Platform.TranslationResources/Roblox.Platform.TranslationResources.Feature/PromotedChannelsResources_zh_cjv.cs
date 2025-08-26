namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides PromotedChannelsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PromotedChannelsResources_zh_cjv : PromotedChannelsResources_en_us, IPromotedChannelsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AddLink"
	/// The button text for adding an additional social link.
	/// English String: "Add Link"
	/// </summary>
	public override string ActionAddLink => "æ·»åŠ é“¾æŽ¥";

	/// <summary>
	/// Key: "Action.Remove"
	/// The remove button text for configuring social links.
	/// English String: "Remove"
	/// </summary>
	public override string ActionRemove => "ç§»é™¤";

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
	public override string HeadingSocialLinks => "ç¤¾äº¤é“¾æŽ¥";

	/// <summary>
	/// Key: "HeadingSocialMedia"
	/// The heading of the social media panel on the game details page
	/// English String: "Social Media"
	/// </summary>
	public override string HeadingSocialMedia => "ç¤¾äº¤åª’ä½“";

	/// <summary>
	/// Key: "Label.Title"
	/// Placeholder text for inputting a title for a social link.
	/// English String: "Title"
	/// </summary>
	public override string LabelTitle => "æ ‡é¢˜";

	/// <summary>
	/// Key: "Label.Url"
	/// Placeholder text for inputting a url for a social link.
	/// English String: "Url"
	/// </summary>
	public override string LabelUrl => "Url";

	/// <summary>
	/// Key: "Message.NoGroupPermission"
	/// The error message displayed when the user does not have permission to the group they are trying to add.
	/// English String: "You do not have permission to configure this group."
	/// </summary>
	public override string MessageNoGroupPermission => "ä½ æ²¡æœ‰é…ç½®æ­¤ç¾¤ç»„çš„æƒé™ã€‚";

	/// <summary>
	/// Key: "Message.SocialLinkInvalidError"
	/// The error message displayed when a social link attempts to be saved but no longer exists.
	/// English String: "The social link no longer exists."
	/// </summary>
	public override string MessageSocialLinkInvalidError => "ç¤¾äº¤é“¾æŽ¥å·²ä¸å­˜åœ¨ã€‚";

	/// <summary>
	/// Key: "Message.SocialLinkRemoved"
	/// The message displayed when the social link has been removed.
	/// English String: "The social media link has been deleted."
	/// </summary>
	public override string MessageSocialLinkRemoved => "ç¤¾äº¤åª’ä½“é“¾æŽ¥å·²è¢«åˆ é™¤ã€‚";

	/// <summary>
	/// Key: "Message.SocialLinksEditDisabledError"
	/// The error message displayed when the social links feature is disabled and attempt to be edited.
	/// English String: "Social links may not be edited at this time."
	/// </summary>
	public override string MessageSocialLinksEditDisabledError => "ç›®å‰æ— æ³•ç¼–è¾‘ç¤¾äº¤é“¾æŽ¥ã€‚";

	/// <summary>
	/// Key: "Message.TitleEmptyError"
	/// The error message displayed when the title input is empty.
	/// English String: "The title cannot be empty."
	/// </summary>
	public override string MessageTitleEmptyError => "æ ‡é¢˜ä¸èƒ½ä¸ºç©ºã€‚";

	/// <summary>
	/// Key: "Message.TitleModeratedError"
	/// The error message displayed when a title is moderated while being edited.
	/// English String: "The title has been moderated, please try something else."
	/// </summary>
	public override string MessageTitleModeratedError => "æ ‡é¢˜å·²è¢«è¿‡æ»¤ï¼Œè¯·å°è¯•å…¶ä»–æ ‡é¢˜ã€‚";

	/// <summary>
	/// Key: "Message.UnauthorizedError"
	/// The error message displayed when an action is attempted against a social link but the user does not have permission to edit social links.
	/// English String: "You do not have permission to update social links."
	/// </summary>
	public override string MessageUnauthorizedError => "ä½ æ²¡æœ‰æ›´æ–°ç¤¾äº¤é“¾æŽ¥çš„æƒé™ã€‚";

	/// <summary>
	/// Key: "Message.UnknownError"
	/// The error message displayed when something unknown goes wrong trying to manage a social link.
	/// English String: "Something went wrong, please try again."
	/// </summary>
	public override string MessageUnknownError => "å‘ç”Ÿé”™è¯¯ï¼Œè¯·é‡è¯•ã€‚";

	/// <summary>
	/// Key: "Message.UrlEmptyError"
	/// The error message displayed when the url input is empty.
	/// English String: "The url cannot be empty."
	/// </summary>
	public override string MessageUrlEmptyError => "url ä¸èƒ½ä¸ºç©ºã€‚";

	/// <summary>
	/// Key: "Message.UrlSocialMediaTypeMismatchError"
	/// The error message displayed when the url input is not a valid url for the social media type selected.
	/// English String: "The url must match the social media type."
	/// </summary>
	public override string MessageUrlSocialMediaTypeMismatchError => "url å¿…é¡»ä¸Žç¤¾äº¤åª’ä½“ç±»åž‹åŒ¹é…ã€‚";

	public PromotedChannelsResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddLink()
	{
		return "æ·»åŠ é“¾æŽ¥";
	}

	protected override string _GetTemplateForActionRemove()
	{
		return "ç§»é™¤";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "ä¿å­˜";
	}

	protected override string _GetTemplateForHeadingSocialLinks()
	{
		return "ç¤¾äº¤é“¾æŽ¥";
	}

	protected override string _GetTemplateForHeadingSocialMedia()
	{
		return "ç¤¾äº¤åª’ä½“";
	}

	/// <summary>
	/// Key: "Label.Limits"
	/// The limitation notice when configuring social links.
	/// English String: "You can add up to {socialLinkLimit} social links."
	/// </summary>
	public override string LabelLimits(string socialLinkLimit)
	{
		return $"ä½ å¯ä»¥æœ€å¤šæ·»åŠ  {socialLinkLimit} ä¸ªç¤¾äº¤é“¾æŽ¥ã€‚";
	}

	protected override string _GetTemplateForLabelLimits()
	{
		return "ä½ å¯ä»¥æœ€å¤šæ·»åŠ  {socialLinkLimit} ä¸ªç¤¾äº¤é“¾æŽ¥ã€‚";
	}

	protected override string _GetTemplateForLabelTitle()
	{
		return "æ ‡é¢˜";
	}

	protected override string _GetTemplateForLabelUrl()
	{
		return "Url";
	}

	protected override string _GetTemplateForMessageNoGroupPermission()
	{
		return "ä½ æ²¡æœ‰é…ç½®æ­¤ç¾¤ç»„çš„æƒé™ã€‚";
	}

	protected override string _GetTemplateForMessageSocialLinkInvalidError()
	{
		return "ç¤¾äº¤é“¾æŽ¥å·²ä¸å­˜åœ¨ã€‚";
	}

	protected override string _GetTemplateForMessageSocialLinkRemoved()
	{
		return "ç¤¾äº¤åª’ä½“é“¾æŽ¥å·²è¢«åˆ é™¤ã€‚";
	}

	/// <summary>
	/// Key: "Message.SocialLinkSaved"
	/// The message displayed when a social link is saved successfully.
	/// English String: "{title} has been saved."
	/// </summary>
	public override string MessageSocialLinkSaved(string title)
	{
		return $"â€œ{title}â€å·²ä¿å­˜ã€‚";
	}

	protected override string _GetTemplateForMessageSocialLinkSaved()
	{
		return "â€œ{title}â€å·²ä¿å­˜ã€‚";
	}

	protected override string _GetTemplateForMessageSocialLinksEditDisabledError()
	{
		return "ç›®å‰æ— æ³•ç¼–è¾‘ç¤¾äº¤é“¾æŽ¥ã€‚";
	}

	/// <summary>
	/// Key: "Message.SocialLinkTypeLimitError"
	/// The error message that gets displayed when configuring social links and there are multiple links with the same social media type.
	/// English String: "Cannot have more than one {socialMediaType} social media links."
	/// </summary>
	public override string MessageSocialLinkTypeLimitError(string socialMediaType)
	{
		return $"ä¸èƒ½æ‹¥æœ‰å¤šä¸ª{socialMediaType}ç¤¾äº¤åª’ä½“é“¾æŽ¥ã€‚";
	}

	protected override string _GetTemplateForMessageSocialLinkTypeLimitError()
	{
		return "ä¸èƒ½æ‹¥æœ‰å¤šä¸ª{socialMediaType}ç¤¾äº¤åª’ä½“é“¾æŽ¥ã€‚";
	}

	protected override string _GetTemplateForMessageTitleEmptyError()
	{
		return "æ ‡é¢˜ä¸èƒ½ä¸ºç©ºã€‚";
	}

	protected override string _GetTemplateForMessageTitleModeratedError()
	{
		return "æ ‡é¢˜å·²è¢«è¿‡æ»¤ï¼Œè¯·å°è¯•å…¶ä»–æ ‡é¢˜ã€‚";
	}

	protected override string _GetTemplateForMessageUnauthorizedError()
	{
		return "ä½ æ²¡æœ‰æ›´æ–°ç¤¾äº¤é“¾æŽ¥çš„æƒé™ã€‚";
	}

	protected override string _GetTemplateForMessageUnknownError()
	{
		return "å‘ç”Ÿé”™è¯¯ï¼Œè¯·é‡è¯•ã€‚";
	}

	protected override string _GetTemplateForMessageUrlEmptyError()
	{
		return "url ä¸èƒ½ä¸ºç©ºã€‚";
	}

	protected override string _GetTemplateForMessageUrlSocialMediaTypeMismatchError()
	{
		return "url å¿…é¡»ä¸Žç¤¾äº¤åª’ä½“ç±»åž‹åŒ¹é…ã€‚";
	}
}


}
