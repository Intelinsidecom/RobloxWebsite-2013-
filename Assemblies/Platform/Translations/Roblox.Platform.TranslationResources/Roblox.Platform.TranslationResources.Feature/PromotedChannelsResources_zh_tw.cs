namespace Roblox.TranslationResources.Feature;

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
	public override string ActionAddLink => "新增連結";

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
	public override string ActionSave => "儲存";

	/// <summary>
	/// Key: "HeadingSocialLinks"
	/// The heading of the social links panel on the game details page
	/// English String: "Social Links"
	/// </summary>
	public override string HeadingSocialLinks => "社交連結";

	/// <summary>
	/// Key: "HeadingSocialMedia"
	/// The heading of the social media panel on the game details page
	/// English String: "Social Media"
	/// </summary>
	public override string HeadingSocialMedia => "社交媒體";

	/// <summary>
	/// Key: "Label.Title"
	/// Placeholder text for inputting a title for a social link.
	/// English String: "Title"
	/// </summary>
	public override string LabelTitle => "標題";

	/// <summary>
	/// Key: "Label.Url"
	/// Placeholder text for inputting a url for a social link.
	/// English String: "Url"
	/// </summary>
	public override string LabelUrl => "網址";

	/// <summary>
	/// Key: "Message.NoGroupPermission"
	/// The error message displayed when the user does not have permission to the group they are trying to add.
	/// English String: "You do not have permission to configure this group."
	/// </summary>
	public override string MessageNoGroupPermission => "您沒有設定此群組的權限。";

	/// <summary>
	/// Key: "Message.SocialLinkInvalidError"
	/// The error message displayed when a social link attempts to be saved but no longer exists.
	/// English String: "The social link no longer exists."
	/// </summary>
	public override string MessageSocialLinkInvalidError => "此社交連結已不存在。";

	/// <summary>
	/// Key: "Message.SocialLinkRemoved"
	/// The message displayed when the social link has been removed.
	/// English String: "The social media link has been deleted."
	/// </summary>
	public override string MessageSocialLinkRemoved => "社交媒體連結已刪除。";

	/// <summary>
	/// Key: "Message.SocialLinksEditDisabledError"
	/// The error message displayed when the social links feature is disabled and attempt to be edited.
	/// English String: "Social links may not be edited at this time."
	/// </summary>
	public override string MessageSocialLinksEditDisabledError => "目前無法編輯社交連結。";

	/// <summary>
	/// Key: "Message.TitleEmptyError"
	/// The error message displayed when the title input is empty.
	/// English String: "The title cannot be empty."
	/// </summary>
	public override string MessageTitleEmptyError => "標題不可空白。";

	/// <summary>
	/// Key: "Message.TitleModeratedError"
	/// The error message displayed when a title is moderated while being edited.
	/// English String: "The title has been moderated, please try something else."
	/// </summary>
	public override string MessageTitleModeratedError => "標題遭到過濾，請嘗試其它標題。";

	/// <summary>
	/// Key: "Message.UnauthorizedError"
	/// The error message displayed when an action is attempted against a social link but the user does not have permission to edit social links.
	/// English String: "You do not have permission to update social links."
	/// </summary>
	public override string MessageUnauthorizedError => "您沒有更新社交連結的權限。";

	/// <summary>
	/// Key: "Message.UnknownError"
	/// The error message displayed when something unknown goes wrong trying to manage a social link.
	/// English String: "Something went wrong, please try again."
	/// </summary>
	public override string MessageUnknownError => "發生錯誤，請重新嘗試。";

	/// <summary>
	/// Key: "Message.UrlEmptyError"
	/// The error message displayed when the url input is empty.
	/// English String: "The url cannot be empty."
	/// </summary>
	public override string MessageUrlEmptyError => "網址不可空白。";

	/// <summary>
	/// Key: "Message.UrlSocialMediaTypeMismatchError"
	/// The error message displayed when the url input is not a valid url for the social media type selected.
	/// English String: "The url must match the social media type."
	/// </summary>
	public override string MessageUrlSocialMediaTypeMismatchError => "網址必須符合社交媒體類型。";

	public PromotedChannelsResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddLink()
	{
		return "新增連結";
	}

	protected override string _GetTemplateForActionRemove()
	{
		return "移除";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "儲存";
	}

	protected override string _GetTemplateForHeadingSocialLinks()
	{
		return "社交連結";
	}

	protected override string _GetTemplateForHeadingSocialMedia()
	{
		return "社交媒體";
	}

	/// <summary>
	/// Key: "Label.Limits"
	/// The limitation notice when configuring social links.
	/// English String: "You can add up to {socialLinkLimit} social links."
	/// </summary>
	public override string LabelLimits(string socialLinkLimit)
	{
		return $"您最多可以新增 {socialLinkLimit} 個社交連結。";
	}

	protected override string _GetTemplateForLabelLimits()
	{
		return "您最多可以新增 {socialLinkLimit} 個社交連結。";
	}

	protected override string _GetTemplateForLabelTitle()
	{
		return "標題";
	}

	protected override string _GetTemplateForLabelUrl()
	{
		return "網址";
	}

	protected override string _GetTemplateForMessageNoGroupPermission()
	{
		return "您沒有設定此群組的權限。";
	}

	protected override string _GetTemplateForMessageSocialLinkInvalidError()
	{
		return "此社交連結已不存在。";
	}

	protected override string _GetTemplateForMessageSocialLinkRemoved()
	{
		return "社交媒體連結已刪除。";
	}

	/// <summary>
	/// Key: "Message.SocialLinkSaved"
	/// The message displayed when a social link is saved successfully.
	/// English String: "{title} has been saved."
	/// </summary>
	public override string MessageSocialLinkSaved(string title)
	{
		return $"{title}已儲存。";
	}

	protected override string _GetTemplateForMessageSocialLinkSaved()
	{
		return "{title}已儲存。";
	}

	protected override string _GetTemplateForMessageSocialLinksEditDisabledError()
	{
		return "目前無法編輯社交連結。";
	}

	/// <summary>
	/// Key: "Message.SocialLinkTypeLimitError"
	/// The error message that gets displayed when configuring social links and there are multiple links with the same social media type.
	/// English String: "Cannot have more than one {socialMediaType} social media links."
	/// </summary>
	public override string MessageSocialLinkTypeLimitError(string socialMediaType)
	{
		return $"只能擁有一個 {socialMediaType} 社交媒體連結。";
	}

	protected override string _GetTemplateForMessageSocialLinkTypeLimitError()
	{
		return "只能擁有一個 {socialMediaType} 社交媒體連結。";
	}

	protected override string _GetTemplateForMessageTitleEmptyError()
	{
		return "標題不可空白。";
	}

	protected override string _GetTemplateForMessageTitleModeratedError()
	{
		return "標題遭到過濾，請嘗試其它標題。";
	}

	protected override string _GetTemplateForMessageUnauthorizedError()
	{
		return "您沒有更新社交連結的權限。";
	}

	protected override string _GetTemplateForMessageUnknownError()
	{
		return "發生錯誤，請重新嘗試。";
	}

	protected override string _GetTemplateForMessageUrlEmptyError()
	{
		return "網址不可空白。";
	}

	protected override string _GetTemplateForMessageUrlSocialMediaTypeMismatchError()
	{
		return "網址必須符合社交媒體類型。";
	}
}
