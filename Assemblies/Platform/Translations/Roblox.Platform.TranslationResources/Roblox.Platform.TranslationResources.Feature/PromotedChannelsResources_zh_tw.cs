namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides PromotedChannelsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PromotedChannelsResources_zh_tw : PromotedChannelsResources_en_us, IPromotedChannelsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AddLink"
	/// The button text for adding an additional social link.
	/// English String: "Add Link"
	/// </summary>
	public override string ActionAddLink => "æ–°å¢žé€£çµ";

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
	public override string ActionSave => "å„²å­˜";

	/// <summary>
	/// Key: "HeadingSocialLinks"
	/// The heading of the social links panel on the game details page
	/// English String: "Social Links"
	/// </summary>
	public override string HeadingSocialLinks => "ç¤¾äº¤é€£çµ";

	/// <summary>
	/// Key: "HeadingSocialMedia"
	/// The heading of the social media panel on the game details page
	/// English String: "Social Media"
	/// </summary>
	public override string HeadingSocialMedia => "ç¤¾äº¤åª’é«”";

	/// <summary>
	/// Key: "Label.Title"
	/// Placeholder text for inputting a title for a social link.
	/// English String: "Title"
	/// </summary>
	public override string LabelTitle => "æ¨™é¡Œ";

	/// <summary>
	/// Key: "Label.Url"
	/// Placeholder text for inputting a url for a social link.
	/// English String: "Url"
	/// </summary>
	public override string LabelUrl => "ç¶²å€";

	/// <summary>
	/// Key: "Message.NoGroupPermission"
	/// The error message displayed when the user does not have permission to the group they are trying to add.
	/// English String: "You do not have permission to configure this group."
	/// </summary>
	public override string MessageNoGroupPermission => "æ‚¨æ²’æœ‰è¨­å®šæ­¤ç¾¤çµ„çš„æ¬Šé™ã€‚";

	/// <summary>
	/// Key: "Message.SocialLinkInvalidError"
	/// The error message displayed when a social link attempts to be saved but no longer exists.
	/// English String: "The social link no longer exists."
	/// </summary>
	public override string MessageSocialLinkInvalidError => "æ­¤ç¤¾äº¤é€£çµå·²ä¸å­˜åœ¨ã€‚";

	/// <summary>
	/// Key: "Message.SocialLinkRemoved"
	/// The message displayed when the social link has been removed.
	/// English String: "The social media link has been deleted."
	/// </summary>
	public override string MessageSocialLinkRemoved => "ç¤¾äº¤åª’é«”é€£çµå·²åˆªé™¤ã€‚";

	/// <summary>
	/// Key: "Message.SocialLinksEditDisabledError"
	/// The error message displayed when the social links feature is disabled and attempt to be edited.
	/// English String: "Social links may not be edited at this time."
	/// </summary>
	public override string MessageSocialLinksEditDisabledError => "ç›®å‰ç„¡æ³•ç·¨è¼¯ç¤¾äº¤é€£çµã€‚";

	/// <summary>
	/// Key: "Message.TitleEmptyError"
	/// The error message displayed when the title input is empty.
	/// English String: "The title cannot be empty."
	/// </summary>
	public override string MessageTitleEmptyError => "æ¨™é¡Œä¸å¯ç©ºç™½ã€‚";

	/// <summary>
	/// Key: "Message.TitleModeratedError"
	/// The error message displayed when a title is moderated while being edited.
	/// English String: "The title has been moderated, please try something else."
	/// </summary>
	public override string MessageTitleModeratedError => "æ¨™é¡Œé­åˆ°éŽæ¿¾ï¼Œè«‹å˜—è©¦å…¶å®ƒæ¨™é¡Œã€‚";

	/// <summary>
	/// Key: "Message.UnauthorizedError"
	/// The error message displayed when an action is attempted against a social link but the user does not have permission to edit social links.
	/// English String: "You do not have permission to update social links."
	/// </summary>
	public override string MessageUnauthorizedError => "æ‚¨æ²’æœ‰æ›´æ–°ç¤¾äº¤é€£çµçš„æ¬Šé™ã€‚";

	/// <summary>
	/// Key: "Message.UnknownError"
	/// The error message displayed when something unknown goes wrong trying to manage a social link.
	/// English String: "Something went wrong, please try again."
	/// </summary>
	public override string MessageUnknownError => "ç™¼ç”ŸéŒ¯èª¤ï¼Œè«‹é‡æ–°å˜—è©¦ã€‚";

	/// <summary>
	/// Key: "Message.UrlEmptyError"
	/// The error message displayed when the url input is empty.
	/// English String: "The url cannot be empty."
	/// </summary>
	public override string MessageUrlEmptyError => "ç¶²å€ä¸å¯ç©ºç™½ã€‚";

	/// <summary>
	/// Key: "Message.UrlSocialMediaTypeMismatchError"
	/// The error message displayed when the url input is not a valid url for the social media type selected.
	/// English String: "The url must match the social media type."
	/// </summary>
	public override string MessageUrlSocialMediaTypeMismatchError => "ç¶²å€å¿…é ˆç¬¦åˆç¤¾äº¤åª’é«”é¡žåž‹ã€‚";

	public PromotedChannelsResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddLink()
	{
		return "æ–°å¢žé€£çµ";
	}

	protected override string _GetTemplateForActionRemove()
	{
		return "ç§»é™¤";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "å„²å­˜";
	}

	protected override string _GetTemplateForHeadingSocialLinks()
	{
		return "ç¤¾äº¤é€£çµ";
	}

	protected override string _GetTemplateForHeadingSocialMedia()
	{
		return "ç¤¾äº¤åª’é«”";
	}

	/// <summary>
	/// Key: "Label.Limits"
	/// The limitation notice when configuring social links.
	/// English String: "You can add up to {socialLinkLimit} social links."
	/// </summary>
	public override string LabelLimits(string socialLinkLimit)
	{
		return $"æ‚¨æœ€å¤šå¯ä»¥æ–°å¢ž {socialLinkLimit} å€‹ç¤¾äº¤é€£çµã€‚";
	}

	protected override string _GetTemplateForLabelLimits()
	{
		return "æ‚¨æœ€å¤šå¯ä»¥æ–°å¢ž {socialLinkLimit} å€‹ç¤¾äº¤é€£çµã€‚";
	}

	protected override string _GetTemplateForLabelTitle()
	{
		return "æ¨™é¡Œ";
	}

	protected override string _GetTemplateForLabelUrl()
	{
		return "ç¶²å€";
	}

	protected override string _GetTemplateForMessageNoGroupPermission()
	{
		return "æ‚¨æ²’æœ‰è¨­å®šæ­¤ç¾¤çµ„çš„æ¬Šé™ã€‚";
	}

	protected override string _GetTemplateForMessageSocialLinkInvalidError()
	{
		return "æ­¤ç¤¾äº¤é€£çµå·²ä¸å­˜åœ¨ã€‚";
	}

	protected override string _GetTemplateForMessageSocialLinkRemoved()
	{
		return "ç¤¾äº¤åª’é«”é€£çµå·²åˆªé™¤ã€‚";
	}

	/// <summary>
	/// Key: "Message.SocialLinkSaved"
	/// The message displayed when a social link is saved successfully.
	/// English String: "{title} has been saved."
	/// </summary>
	public override string MessageSocialLinkSaved(string title)
	{
		return $"{title}å·²å„²å­˜ã€‚";
	}

	protected override string _GetTemplateForMessageSocialLinkSaved()
	{
		return "{title}å·²å„²å­˜ã€‚";
	}

	protected override string _GetTemplateForMessageSocialLinksEditDisabledError()
	{
		return "ç›®å‰ç„¡æ³•ç·¨è¼¯ç¤¾äº¤é€£çµã€‚";
	}

	/// <summary>
	/// Key: "Message.SocialLinkTypeLimitError"
	/// The error message that gets displayed when configuring social links and there are multiple links with the same social media type.
	/// English String: "Cannot have more than one {socialMediaType} social media links."
	/// </summary>
	public override string MessageSocialLinkTypeLimitError(string socialMediaType)
	{
		return $"åªèƒ½æ“æœ‰ä¸€å€‹ {socialMediaType} ç¤¾äº¤åª’é«”é€£çµã€‚";
	}

	protected override string _GetTemplateForMessageSocialLinkTypeLimitError()
	{
		return "åªèƒ½æ“æœ‰ä¸€å€‹ {socialMediaType} ç¤¾äº¤åª’é«”é€£çµã€‚";
	}

	protected override string _GetTemplateForMessageTitleEmptyError()
	{
		return "æ¨™é¡Œä¸å¯ç©ºç™½ã€‚";
	}

	protected override string _GetTemplateForMessageTitleModeratedError()
	{
		return "æ¨™é¡Œé­åˆ°éŽæ¿¾ï¼Œè«‹å˜—è©¦å…¶å®ƒæ¨™é¡Œã€‚";
	}

	protected override string _GetTemplateForMessageUnauthorizedError()
	{
		return "æ‚¨æ²’æœ‰æ›´æ–°ç¤¾äº¤é€£çµçš„æ¬Šé™ã€‚";
	}

	protected override string _GetTemplateForMessageUnknownError()
	{
		return "ç™¼ç”ŸéŒ¯èª¤ï¼Œè«‹é‡æ–°å˜—è©¦ã€‚";
	}

	protected override string _GetTemplateForMessageUrlEmptyError()
	{
		return "ç¶²å€ä¸å¯ç©ºç™½ã€‚";
	}

	protected override string _GetTemplateForMessageUrlSocialMediaTypeMismatchError()
	{
		return "ç¶²å€å¿…é ˆç¬¦åˆç¤¾äº¤åª’é«”é¡žåž‹ã€‚";
	}
}


}
