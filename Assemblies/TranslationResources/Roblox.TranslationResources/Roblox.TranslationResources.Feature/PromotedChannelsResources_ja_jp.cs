namespace Roblox.TranslationResources.Feature;

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
	public override string ActionAddLink => "リンクを追加";

	/// <summary>
	/// Key: "Action.Remove"
	/// The remove button text for configuring social links.
	/// English String: "Remove"
	/// </summary>
	public override string ActionRemove => "削除";

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
	public override string HeadingSocialLinks => "SNSリンク";

	/// <summary>
	/// Key: "HeadingSocialMedia"
	/// The heading of the social media panel on the game details page
	/// English String: "Social Media"
	/// </summary>
	public override string HeadingSocialMedia => "ソーシャルメディア";

	/// <summary>
	/// Key: "Label.Title"
	/// Placeholder text for inputting a title for a social link.
	/// English String: "Title"
	/// </summary>
	public override string LabelTitle => "タイトル";

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
	public override string MessageNoGroupPermission => "このグループの環境設定をする権限がありません。";

	/// <summary>
	/// Key: "Message.SocialLinkInvalidError"
	/// The error message displayed when a social link attempts to be saved but no longer exists.
	/// English String: "The social link no longer exists."
	/// </summary>
	public override string MessageSocialLinkInvalidError => "そのSNSリンクは現在はありません。";

	/// <summary>
	/// Key: "Message.SocialLinkRemoved"
	/// The message displayed when the social link has been removed.
	/// English String: "The social media link has been deleted."
	/// </summary>
	public override string MessageSocialLinkRemoved => "ソーシャルメディアリンクが削除されました。";

	/// <summary>
	/// Key: "Message.SocialLinksEditDisabledError"
	/// The error message displayed when the social links feature is disabled and attempt to be edited.
	/// English String: "Social links may not be edited at this time."
	/// </summary>
	public override string MessageSocialLinksEditDisabledError => "現在、SNSリンクは編集できない可能性があります。";

	/// <summary>
	/// Key: "Message.TitleEmptyError"
	/// The error message displayed when the title input is empty.
	/// English String: "The title cannot be empty."
	/// </summary>
	public override string MessageTitleEmptyError => "タイトルは空白にできません。";

	/// <summary>
	/// Key: "Message.TitleModeratedError"
	/// The error message displayed when a title is moderated while being edited.
	/// English String: "The title has been moderated, please try something else."
	/// </summary>
	public override string MessageTitleModeratedError => "タイトルが規制対象です。他のタイトルをお試しください。";

	/// <summary>
	/// Key: "Message.UnauthorizedError"
	/// The error message displayed when an action is attempted against a social link but the user does not have permission to edit social links.
	/// English String: "You do not have permission to update social links."
	/// </summary>
	public override string MessageUnauthorizedError => "SNSリンクのアップデートは許可されていません。";

	/// <summary>
	/// Key: "Message.UnknownError"
	/// The error message displayed when something unknown goes wrong trying to manage a social link.
	/// English String: "Something went wrong, please try again."
	/// </summary>
	public override string MessageUnknownError => "問題が発生しました。もう一度お試しください。";

	/// <summary>
	/// Key: "Message.UrlEmptyError"
	/// The error message displayed when the url input is empty.
	/// English String: "The url cannot be empty."
	/// </summary>
	public override string MessageUrlEmptyError => "URLは空白にできません。";

	/// <summary>
	/// Key: "Message.UrlSocialMediaTypeMismatchError"
	/// The error message displayed when the url input is not a valid url for the social media type selected.
	/// English String: "The url must match the social media type."
	/// </summary>
	public override string MessageUrlSocialMediaTypeMismatchError => "URLはソーシャルメディアタイプと一致している必要があります。";

	public PromotedChannelsResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddLink()
	{
		return "リンクを追加";
	}

	protected override string _GetTemplateForActionRemove()
	{
		return "削除";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "保存";
	}

	protected override string _GetTemplateForHeadingSocialLinks()
	{
		return "SNSリンク";
	}

	protected override string _GetTemplateForHeadingSocialMedia()
	{
		return "ソーシャルメディア";
	}

	/// <summary>
	/// Key: "Label.Limits"
	/// The limitation notice when configuring social links.
	/// English String: "You can add up to {socialLinkLimit} social links."
	/// </summary>
	public override string LabelLimits(string socialLinkLimit)
	{
		return $"ソーシャルリンクは{socialLinkLimit}個まで追加できます。";
	}

	protected override string _GetTemplateForLabelLimits()
	{
		return "ソーシャルリンクは{socialLinkLimit}個まで追加できます。";
	}

	protected override string _GetTemplateForLabelTitle()
	{
		return "タイトル";
	}

	protected override string _GetTemplateForLabelUrl()
	{
		return "URL";
	}

	protected override string _GetTemplateForMessageNoGroupPermission()
	{
		return "このグループの環境設定をする権限がありません。";
	}

	protected override string _GetTemplateForMessageSocialLinkInvalidError()
	{
		return "そのSNSリンクは現在はありません。";
	}

	protected override string _GetTemplateForMessageSocialLinkRemoved()
	{
		return "ソーシャルメディアリンクが削除されました。";
	}

	/// <summary>
	/// Key: "Message.SocialLinkSaved"
	/// The message displayed when a social link is saved successfully.
	/// English String: "{title} has been saved."
	/// </summary>
	public override string MessageSocialLinkSaved(string title)
	{
		return $"{title}を保存しました。";
	}

	protected override string _GetTemplateForMessageSocialLinkSaved()
	{
		return "{title}を保存しました。";
	}

	protected override string _GetTemplateForMessageSocialLinksEditDisabledError()
	{
		return "現在、SNSリンクは編集できない可能性があります。";
	}

	/// <summary>
	/// Key: "Message.SocialLinkTypeLimitError"
	/// The error message that gets displayed when configuring social links and there are multiple links with the same social media type.
	/// English String: "Cannot have more than one {socialMediaType} social media links."
	/// </summary>
	public override string MessageSocialLinkTypeLimitError(string socialMediaType)
	{
		return $"{socialMediaType}のソーシャルメディアリンクは、1つしか登録できません。";
	}

	protected override string _GetTemplateForMessageSocialLinkTypeLimitError()
	{
		return "{socialMediaType}のソーシャルメディアリンクは、1つしか登録できません。";
	}

	protected override string _GetTemplateForMessageTitleEmptyError()
	{
		return "タイトルは空白にできません。";
	}

	protected override string _GetTemplateForMessageTitleModeratedError()
	{
		return "タイトルが規制対象です。他のタイトルをお試しください。";
	}

	protected override string _GetTemplateForMessageUnauthorizedError()
	{
		return "SNSリンクのアップデートは許可されていません。";
	}

	protected override string _GetTemplateForMessageUnknownError()
	{
		return "問題が発生しました。もう一度お試しください。";
	}

	protected override string _GetTemplateForMessageUrlEmptyError()
	{
		return "URLは空白にできません。";
	}

	protected override string _GetTemplateForMessageUrlSocialMediaTypeMismatchError()
	{
		return "URLはソーシャルメディアタイプと一致している必要があります。";
	}
}
