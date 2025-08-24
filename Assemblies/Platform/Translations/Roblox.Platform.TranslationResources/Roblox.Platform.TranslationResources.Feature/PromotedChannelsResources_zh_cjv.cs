namespace Roblox.TranslationResources.Feature;

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
	public override string ActionAddLink => "添加链接";

	/// <summary>
	/// Key: "Action.Remove"
	/// The remove button text for configuring social links.
	/// English String: "Remove"
	/// </summary>
	public override string ActionRemove => "移除";

	/// <summary>
	/// Key: "Action.Save"
	/// The save button text for updating a social link.
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "保存";

	/// <summary>
	/// Key: "HeadingSocialLinks"
	/// The heading of the social links panel on the game details page
	/// English String: "Social Links"
	/// </summary>
	public override string HeadingSocialLinks => "社交链接";

	/// <summary>
	/// Key: "HeadingSocialMedia"
	/// The heading of the social media panel on the game details page
	/// English String: "Social Media"
	/// </summary>
	public override string HeadingSocialMedia => "社交媒体";

	/// <summary>
	/// Key: "Label.Title"
	/// Placeholder text for inputting a title for a social link.
	/// English String: "Title"
	/// </summary>
	public override string LabelTitle => "标题";

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
	public override string MessageNoGroupPermission => "你没有配置此群组的权限。";

	/// <summary>
	/// Key: "Message.SocialLinkInvalidError"
	/// The error message displayed when a social link attempts to be saved but no longer exists.
	/// English String: "The social link no longer exists."
	/// </summary>
	public override string MessageSocialLinkInvalidError => "社交链接已不存在。";

	/// <summary>
	/// Key: "Message.SocialLinkRemoved"
	/// The message displayed when the social link has been removed.
	/// English String: "The social media link has been deleted."
	/// </summary>
	public override string MessageSocialLinkRemoved => "社交媒体链接已被删除。";

	/// <summary>
	/// Key: "Message.SocialLinksEditDisabledError"
	/// The error message displayed when the social links feature is disabled and attempt to be edited.
	/// English String: "Social links may not be edited at this time."
	/// </summary>
	public override string MessageSocialLinksEditDisabledError => "目前无法编辑社交链接。";

	/// <summary>
	/// Key: "Message.TitleEmptyError"
	/// The error message displayed when the title input is empty.
	/// English String: "The title cannot be empty."
	/// </summary>
	public override string MessageTitleEmptyError => "标题不能为空。";

	/// <summary>
	/// Key: "Message.TitleModeratedError"
	/// The error message displayed when a title is moderated while being edited.
	/// English String: "The title has been moderated, please try something else."
	/// </summary>
	public override string MessageTitleModeratedError => "标题已被过滤，请尝试其他标题。";

	/// <summary>
	/// Key: "Message.UnauthorizedError"
	/// The error message displayed when an action is attempted against a social link but the user does not have permission to edit social links.
	/// English String: "You do not have permission to update social links."
	/// </summary>
	public override string MessageUnauthorizedError => "你没有更新社交链接的权限。";

	/// <summary>
	/// Key: "Message.UnknownError"
	/// The error message displayed when something unknown goes wrong trying to manage a social link.
	/// English String: "Something went wrong, please try again."
	/// </summary>
	public override string MessageUnknownError => "发生错误，请重试。";

	/// <summary>
	/// Key: "Message.UrlEmptyError"
	/// The error message displayed when the url input is empty.
	/// English String: "The url cannot be empty."
	/// </summary>
	public override string MessageUrlEmptyError => "url 不能为空。";

	/// <summary>
	/// Key: "Message.UrlSocialMediaTypeMismatchError"
	/// The error message displayed when the url input is not a valid url for the social media type selected.
	/// English String: "The url must match the social media type."
	/// </summary>
	public override string MessageUrlSocialMediaTypeMismatchError => "url 必须与社交媒体类型匹配。";

	public PromotedChannelsResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddLink()
	{
		return "添加链接";
	}

	protected override string _GetTemplateForActionRemove()
	{
		return "移除";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "保存";
	}

	protected override string _GetTemplateForHeadingSocialLinks()
	{
		return "社交链接";
	}

	protected override string _GetTemplateForHeadingSocialMedia()
	{
		return "社交媒体";
	}

	/// <summary>
	/// Key: "Label.Limits"
	/// The limitation notice when configuring social links.
	/// English String: "You can add up to {socialLinkLimit} social links."
	/// </summary>
	public override string LabelLimits(string socialLinkLimit)
	{
		return $"你可以最多添加 {socialLinkLimit} 个社交链接。";
	}

	protected override string _GetTemplateForLabelLimits()
	{
		return "你可以最多添加 {socialLinkLimit} 个社交链接。";
	}

	protected override string _GetTemplateForLabelTitle()
	{
		return "标题";
	}

	protected override string _GetTemplateForLabelUrl()
	{
		return "Url";
	}

	protected override string _GetTemplateForMessageNoGroupPermission()
	{
		return "你没有配置此群组的权限。";
	}

	protected override string _GetTemplateForMessageSocialLinkInvalidError()
	{
		return "社交链接已不存在。";
	}

	protected override string _GetTemplateForMessageSocialLinkRemoved()
	{
		return "社交媒体链接已被删除。";
	}

	/// <summary>
	/// Key: "Message.SocialLinkSaved"
	/// The message displayed when a social link is saved successfully.
	/// English String: "{title} has been saved."
	/// </summary>
	public override string MessageSocialLinkSaved(string title)
	{
		return $"“{title}”已保存。";
	}

	protected override string _GetTemplateForMessageSocialLinkSaved()
	{
		return "“{title}”已保存。";
	}

	protected override string _GetTemplateForMessageSocialLinksEditDisabledError()
	{
		return "目前无法编辑社交链接。";
	}

	/// <summary>
	/// Key: "Message.SocialLinkTypeLimitError"
	/// The error message that gets displayed when configuring social links and there are multiple links with the same social media type.
	/// English String: "Cannot have more than one {socialMediaType} social media links."
	/// </summary>
	public override string MessageSocialLinkTypeLimitError(string socialMediaType)
	{
		return $"不能拥有多个{socialMediaType}社交媒体链接。";
	}

	protected override string _GetTemplateForMessageSocialLinkTypeLimitError()
	{
		return "不能拥有多个{socialMediaType}社交媒体链接。";
	}

	protected override string _GetTemplateForMessageTitleEmptyError()
	{
		return "标题不能为空。";
	}

	protected override string _GetTemplateForMessageTitleModeratedError()
	{
		return "标题已被过滤，请尝试其他标题。";
	}

	protected override string _GetTemplateForMessageUnauthorizedError()
	{
		return "你没有更新社交链接的权限。";
	}

	protected override string _GetTemplateForMessageUnknownError()
	{
		return "发生错误，请重试。";
	}

	protected override string _GetTemplateForMessageUrlEmptyError()
	{
		return "url 不能为空。";
	}

	protected override string _GetTemplateForMessageUrlSocialMediaTypeMismatchError()
	{
		return "url 必须与社交媒体类型匹配。";
	}
}
