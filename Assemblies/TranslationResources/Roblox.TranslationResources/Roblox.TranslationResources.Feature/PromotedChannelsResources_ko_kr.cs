namespace Roblox.TranslationResources.Feature;

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
	public override string ActionAddLink => "링크 추가";

	/// <summary>
	/// Key: "Action.Remove"
	/// The remove button text for configuring social links.
	/// English String: "Remove"
	/// </summary>
	public override string ActionRemove => "삭제";

	/// <summary>
	/// Key: "Action.Save"
	/// The save button text for updating a social link.
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "저장";

	/// <summary>
	/// Key: "HeadingSocialLinks"
	/// The heading of the social links panel on the game details page
	/// English String: "Social Links"
	/// </summary>
	public override string HeadingSocialLinks => "소셜 링크";

	/// <summary>
	/// Key: "HeadingSocialMedia"
	/// The heading of the social media panel on the game details page
	/// English String: "Social Media"
	/// </summary>
	public override string HeadingSocialMedia => "소셜 미디어";

	/// <summary>
	/// Key: "Label.Title"
	/// Placeholder text for inputting a title for a social link.
	/// English String: "Title"
	/// </summary>
	public override string LabelTitle => "제목";

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
	public override string MessageNoGroupPermission => "본 그룹을 구성할 권한이 없습니다.";

	/// <summary>
	/// Key: "Message.SocialLinkInvalidError"
	/// The error message displayed when a social link attempts to be saved but no longer exists.
	/// English String: "The social link no longer exists."
	/// </summary>
	public override string MessageSocialLinkInvalidError => "소셜 링크가 더 이상 존재하지 않네요.";

	/// <summary>
	/// Key: "Message.SocialLinkRemoved"
	/// The message displayed when the social link has been removed.
	/// English String: "The social media link has been deleted."
	/// </summary>
	public override string MessageSocialLinkRemoved => "소셜 미디어 링크가 삭제되었습니다.";

	/// <summary>
	/// Key: "Message.SocialLinksEditDisabledError"
	/// The error message displayed when the social links feature is disabled and attempt to be edited.
	/// English String: "Social links may not be edited at this time."
	/// </summary>
	public override string MessageSocialLinksEditDisabledError => "지금은 소셜 링크를 수정할 수 없어요.";

	/// <summary>
	/// Key: "Message.TitleEmptyError"
	/// The error message displayed when the title input is empty.
	/// English String: "The title cannot be empty."
	/// </summary>
	public override string MessageTitleEmptyError => "제목을 입력하셔야 합니다.";

	/// <summary>
	/// Key: "Message.TitleModeratedError"
	/// The error message displayed when a title is moderated while being edited.
	/// English String: "The title has been moderated, please try something else."
	/// </summary>
	public override string MessageTitleModeratedError => "제목이 검열을 통과하지 못했습니다. 다른 제목으로 시도해 주세요.";

	/// <summary>
	/// Key: "Message.UnauthorizedError"
	/// The error message displayed when an action is attempted against a social link but the user does not have permission to edit social links.
	/// English String: "You do not have permission to update social links."
	/// </summary>
	public override string MessageUnauthorizedError => "소셜 링크를 업데이트할 권한이 없습니다.";

	/// <summary>
	/// Key: "Message.UnknownError"
	/// The error message displayed when something unknown goes wrong trying to manage a social link.
	/// English String: "Something went wrong, please try again."
	/// </summary>
	public override string MessageUnknownError => "오류가 발생했어요. 다시 시도해 주세요.";

	/// <summary>
	/// Key: "Message.UrlEmptyError"
	/// The error message displayed when the url input is empty.
	/// English String: "The url cannot be empty."
	/// </summary>
	public override string MessageUrlEmptyError => "URL을 입력하셔야 합니다.";

	/// <summary>
	/// Key: "Message.UrlSocialMediaTypeMismatchError"
	/// The error message displayed when the url input is not a valid url for the social media type selected.
	/// English String: "The url must match the social media type."
	/// </summary>
	public override string MessageUrlSocialMediaTypeMismatchError => "URL이 소셜 미디어 유형과 일치해야 합니다.";

	public PromotedChannelsResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddLink()
	{
		return "링크 추가";
	}

	protected override string _GetTemplateForActionRemove()
	{
		return "삭제";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "저장";
	}

	protected override string _GetTemplateForHeadingSocialLinks()
	{
		return "소셜 링크";
	}

	protected override string _GetTemplateForHeadingSocialMedia()
	{
		return "소셜 미디어";
	}

	/// <summary>
	/// Key: "Label.Limits"
	/// The limitation notice when configuring social links.
	/// English String: "You can add up to {socialLinkLimit} social links."
	/// </summary>
	public override string LabelLimits(string socialLinkLimit)
	{
		return $"소셜 미디어 링크를 {socialLinkLimit}개까지 추가할 수 있습니다.";
	}

	protected override string _GetTemplateForLabelLimits()
	{
		return "소셜 미디어 링크를 {socialLinkLimit}개까지 추가할 수 있습니다.";
	}

	protected override string _GetTemplateForLabelTitle()
	{
		return "제목";
	}

	protected override string _GetTemplateForLabelUrl()
	{
		return "URL";
	}

	protected override string _GetTemplateForMessageNoGroupPermission()
	{
		return "본 그룹을 구성할 권한이 없습니다.";
	}

	protected override string _GetTemplateForMessageSocialLinkInvalidError()
	{
		return "소셜 링크가 더 이상 존재하지 않네요.";
	}

	protected override string _GetTemplateForMessageSocialLinkRemoved()
	{
		return "소셜 미디어 링크가 삭제되었습니다.";
	}

	/// <summary>
	/// Key: "Message.SocialLinkSaved"
	/// The message displayed when a social link is saved successfully.
	/// English String: "{title} has been saved."
	/// </summary>
	public override string MessageSocialLinkSaved(string title)
	{
		return $"{title}이(가) 저장되었습니다.";
	}

	protected override string _GetTemplateForMessageSocialLinkSaved()
	{
		return "{title}이(가) 저장되었습니다.";
	}

	protected override string _GetTemplateForMessageSocialLinksEditDisabledError()
	{
		return "지금은 소셜 링크를 수정할 수 없어요.";
	}

	/// <summary>
	/// Key: "Message.SocialLinkTypeLimitError"
	/// The error message that gets displayed when configuring social links and there are multiple links with the same social media type.
	/// English String: "Cannot have more than one {socialMediaType} social media links."
	/// </summary>
	public override string MessageSocialLinkTypeLimitError(string socialMediaType)
	{
		return $"1개의 {socialMediaType} 소셜 미디어 링크만 허용됩니다.";
	}

	protected override string _GetTemplateForMessageSocialLinkTypeLimitError()
	{
		return "1개의 {socialMediaType} 소셜 미디어 링크만 허용됩니다.";
	}

	protected override string _GetTemplateForMessageTitleEmptyError()
	{
		return "제목을 입력하셔야 합니다.";
	}

	protected override string _GetTemplateForMessageTitleModeratedError()
	{
		return "제목이 검열을 통과하지 못했습니다. 다른 제목으로 시도해 주세요.";
	}

	protected override string _GetTemplateForMessageUnauthorizedError()
	{
		return "소셜 링크를 업데이트할 권한이 없습니다.";
	}

	protected override string _GetTemplateForMessageUnknownError()
	{
		return "오류가 발생했어요. 다시 시도해 주세요.";
	}

	protected override string _GetTemplateForMessageUrlEmptyError()
	{
		return "URL을 입력하셔야 합니다.";
	}

	protected override string _GetTemplateForMessageUrlSocialMediaTypeMismatchError()
	{
		return "URL이 소셜 미디어 유형과 일치해야 합니다.";
	}
}
