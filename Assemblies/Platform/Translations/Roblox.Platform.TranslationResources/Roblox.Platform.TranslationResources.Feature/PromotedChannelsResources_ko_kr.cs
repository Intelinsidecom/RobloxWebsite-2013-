namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides PromotedChannelsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PromotedChannelsResources_ko_kr : PromotedChannelsResources_en_us, IPromotedChannelsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AddLink"
	/// The button text for adding an additional social link.
	/// English String: "Add Link"
	/// </summary>
	public override string ActionAddLink => "ë§í¬ ì¶”ê°€";

	/// <summary>
	/// Key: "Action.Remove"
	/// The remove button text for configuring social links.
	/// English String: "Remove"
	/// </summary>
	public override string ActionRemove => "ì‚­ì œ";

	/// <summary>
	/// Key: "Action.Save"
	/// The save button text for updating a social link.
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "ì €ìž¥";

	/// <summary>
	/// Key: "HeadingSocialLinks"
	/// The heading of the social links panel on the game details page
	/// English String: "Social Links"
	/// </summary>
	public override string HeadingSocialLinks => "ì†Œì…œ ë§í¬";

	/// <summary>
	/// Key: "HeadingSocialMedia"
	/// The heading of the social media panel on the game details page
	/// English String: "Social Media"
	/// </summary>
	public override string HeadingSocialMedia => "ì†Œì…œ ë¯¸ë””ì–´";

	/// <summary>
	/// Key: "Label.Title"
	/// Placeholder text for inputting a title for a social link.
	/// English String: "Title"
	/// </summary>
	public override string LabelTitle => "ì œëª©";

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
	public override string MessageNoGroupPermission => "ë³¸ ê·¸ë£¹ì„ êµ¬ì„±í•  ê¶Œí•œì´ ì—†ìŠµë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Message.SocialLinkInvalidError"
	/// The error message displayed when a social link attempts to be saved but no longer exists.
	/// English String: "The social link no longer exists."
	/// </summary>
	public override string MessageSocialLinkInvalidError => "ì†Œì…œ ë§í¬ê°€ ë” ì´ìƒ ì¡´ìž¬í•˜ì§€ ì•Šë„¤ìš”.";

	/// <summary>
	/// Key: "Message.SocialLinkRemoved"
	/// The message displayed when the social link has been removed.
	/// English String: "The social media link has been deleted."
	/// </summary>
	public override string MessageSocialLinkRemoved => "ì†Œì…œ ë¯¸ë””ì–´ ë§í¬ê°€ ì‚­ì œë˜ì—ˆìŠµë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Message.SocialLinksEditDisabledError"
	/// The error message displayed when the social links feature is disabled and attempt to be edited.
	/// English String: "Social links may not be edited at this time."
	/// </summary>
	public override string MessageSocialLinksEditDisabledError => "ì§€ê¸ˆì€ ì†Œì…œ ë§í¬ë¥¼ ìˆ˜ì •í•  ìˆ˜ ì—†ì–´ìš”.";

	/// <summary>
	/// Key: "Message.TitleEmptyError"
	/// The error message displayed when the title input is empty.
	/// English String: "The title cannot be empty."
	/// </summary>
	public override string MessageTitleEmptyError => "ì œëª©ì„ ìž…ë ¥í•˜ì…”ì•¼ í•©ë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Message.TitleModeratedError"
	/// The error message displayed when a title is moderated while being edited.
	/// English String: "The title has been moderated, please try something else."
	/// </summary>
	public override string MessageTitleModeratedError => "ì œëª©ì´ ê²€ì—´ì„ í†µê³¼í•˜ì§€ ëª»í–ˆìŠµë‹ˆë‹¤. ë‹¤ë¥¸ ì œëª©ìœ¼ë¡œ ì‹œë„í•´ ì£¼ì„¸ìš”.";

	/// <summary>
	/// Key: "Message.UnauthorizedError"
	/// The error message displayed when an action is attempted against a social link but the user does not have permission to edit social links.
	/// English String: "You do not have permission to update social links."
	/// </summary>
	public override string MessageUnauthorizedError => "ì†Œì…œ ë§í¬ë¥¼ ì—…ë°ì´íŠ¸í•  ê¶Œí•œì´ ì—†ìŠµë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Message.UnknownError"
	/// The error message displayed when something unknown goes wrong trying to manage a social link.
	/// English String: "Something went wrong, please try again."
	/// </summary>
	public override string MessageUnknownError => "ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”. ë‹¤ì‹œ ì‹œë„í•´ ì£¼ì„¸ìš”.";

	/// <summary>
	/// Key: "Message.UrlEmptyError"
	/// The error message displayed when the url input is empty.
	/// English String: "The url cannot be empty."
	/// </summary>
	public override string MessageUrlEmptyError => "URLì„ ìž…ë ¥í•˜ì…”ì•¼ í•©ë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Message.UrlSocialMediaTypeMismatchError"
	/// The error message displayed when the url input is not a valid url for the social media type selected.
	/// English String: "The url must match the social media type."
	/// </summary>
	public override string MessageUrlSocialMediaTypeMismatchError => "URLì´ ì†Œì…œ ë¯¸ë””ì–´ ìœ í˜•ê³¼ ì¼ì¹˜í•´ì•¼ í•©ë‹ˆë‹¤.";

	public PromotedChannelsResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddLink()
	{
		return "ë§í¬ ì¶”ê°€";
	}

	protected override string _GetTemplateForActionRemove()
	{
		return "ì‚­ì œ";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "ì €ìž¥";
	}

	protected override string _GetTemplateForHeadingSocialLinks()
	{
		return "ì†Œì…œ ë§í¬";
	}

	protected override string _GetTemplateForHeadingSocialMedia()
	{
		return "ì†Œì…œ ë¯¸ë””ì–´";
	}

	/// <summary>
	/// Key: "Label.Limits"
	/// The limitation notice when configuring social links.
	/// English String: "You can add up to {socialLinkLimit} social links."
	/// </summary>
	public override string LabelLimits(string socialLinkLimit)
	{
		return $"ì†Œì…œ ë¯¸ë””ì–´ ë§í¬ë¥¼ {socialLinkLimit}ê°œê¹Œì§€ ì¶”ê°€í•  ìˆ˜ ìžˆìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForLabelLimits()
	{
		return "ì†Œì…œ ë¯¸ë””ì–´ ë§í¬ë¥¼ {socialLinkLimit}ê°œê¹Œì§€ ì¶”ê°€í•  ìˆ˜ ìžˆìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForLabelTitle()
	{
		return "ì œëª©";
	}

	protected override string _GetTemplateForLabelUrl()
	{
		return "URL";
	}

	protected override string _GetTemplateForMessageNoGroupPermission()
	{
		return "ë³¸ ê·¸ë£¹ì„ êµ¬ì„±í•  ê¶Œí•œì´ ì—†ìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForMessageSocialLinkInvalidError()
	{
		return "ì†Œì…œ ë§í¬ê°€ ë” ì´ìƒ ì¡´ìž¬í•˜ì§€ ì•Šë„¤ìš”.";
	}

	protected override string _GetTemplateForMessageSocialLinkRemoved()
	{
		return "ì†Œì…œ ë¯¸ë””ì–´ ë§í¬ê°€ ì‚­ì œë˜ì—ˆìŠµë‹ˆë‹¤.";
	}

	/// <summary>
	/// Key: "Message.SocialLinkSaved"
	/// The message displayed when a social link is saved successfully.
	/// English String: "{title} has been saved."
	/// </summary>
	public override string MessageSocialLinkSaved(string title)
	{
		return $"{title}ì´(ê°€) ì €ìž¥ë˜ì—ˆìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForMessageSocialLinkSaved()
	{
		return "{title}ì´(ê°€) ì €ìž¥ë˜ì—ˆìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForMessageSocialLinksEditDisabledError()
	{
		return "ì§€ê¸ˆì€ ì†Œì…œ ë§í¬ë¥¼ ìˆ˜ì •í•  ìˆ˜ ì—†ì–´ìš”.";
	}

	/// <summary>
	/// Key: "Message.SocialLinkTypeLimitError"
	/// The error message that gets displayed when configuring social links and there are multiple links with the same social media type.
	/// English String: "Cannot have more than one {socialMediaType} social media links."
	/// </summary>
	public override string MessageSocialLinkTypeLimitError(string socialMediaType)
	{
		return $"1ê°œì˜ {socialMediaType} ì†Œì…œ ë¯¸ë””ì–´ ë§í¬ë§Œ í—ˆìš©ë©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForMessageSocialLinkTypeLimitError()
	{
		return "1ê°œì˜ {socialMediaType} ì†Œì…œ ë¯¸ë””ì–´ ë§í¬ë§Œ í—ˆìš©ë©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForMessageTitleEmptyError()
	{
		return "ì œëª©ì„ ìž…ë ¥í•˜ì…”ì•¼ í•©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForMessageTitleModeratedError()
	{
		return "ì œëª©ì´ ê²€ì—´ì„ í†µê³¼í•˜ì§€ ëª»í–ˆìŠµë‹ˆë‹¤. ë‹¤ë¥¸ ì œëª©ìœ¼ë¡œ ì‹œë„í•´ ì£¼ì„¸ìš”.";
	}

	protected override string _GetTemplateForMessageUnauthorizedError()
	{
		return "ì†Œì…œ ë§í¬ë¥¼ ì—…ë°ì´íŠ¸í•  ê¶Œí•œì´ ì—†ìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForMessageUnknownError()
	{
		return "ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”. ë‹¤ì‹œ ì‹œë„í•´ ì£¼ì„¸ìš”.";
	}

	protected override string _GetTemplateForMessageUrlEmptyError()
	{
		return "URLì„ ìž…ë ¥í•˜ì…”ì•¼ í•©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForMessageUrlSocialMediaTypeMismatchError()
	{
		return "URLì´ ì†Œì…œ ë¯¸ë””ì–´ ìœ í˜•ê³¼ ì¼ì¹˜í•´ì•¼ í•©ë‹ˆë‹¤.";
	}
}


}
