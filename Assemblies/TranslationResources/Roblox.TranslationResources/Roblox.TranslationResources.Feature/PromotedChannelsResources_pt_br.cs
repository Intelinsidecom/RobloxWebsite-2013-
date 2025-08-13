namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PromotedChannelsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PromotedChannelsResources_pt_br : PromotedChannelsResources_en_us, IPromotedChannelsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AddLink"
	/// The button text for adding an additional social link.
	/// English String: "Add Link"
	/// </summary>
	public override string ActionAddLink => "Adicionar link";

	/// <summary>
	/// Key: "Action.Remove"
	/// The remove button text for configuring social links.
	/// English String: "Remove"
	/// </summary>
	public override string ActionRemove => "Remover";

	/// <summary>
	/// Key: "Action.Save"
	/// The save button text for updating a social link.
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "Salvar";

	/// <summary>
	/// Key: "HeadingSocialLinks"
	/// The heading of the social links panel on the game details page
	/// English String: "Social Links"
	/// </summary>
	public override string HeadingSocialLinks => "Links sociais";

	/// <summary>
	/// Key: "HeadingSocialMedia"
	/// The heading of the social media panel on the game details page
	/// English String: "Social Media"
	/// </summary>
	public override string HeadingSocialMedia => "Mídia social";

	/// <summary>
	/// Key: "Label.Title"
	/// Placeholder text for inputting a title for a social link.
	/// English String: "Title"
	/// </summary>
	public override string LabelTitle => "Título";

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
	public override string MessageNoGroupPermission => "Você não tem permissão para configurar este grupo.";

	/// <summary>
	/// Key: "Message.SocialLinkInvalidError"
	/// The error message displayed when a social link attempts to be saved but no longer exists.
	/// English String: "The social link no longer exists."
	/// </summary>
	public override string MessageSocialLinkInvalidError => "O link social não existe mais.";

	/// <summary>
	/// Key: "Message.SocialLinkRemoved"
	/// The message displayed when the social link has been removed.
	/// English String: "The social media link has been deleted."
	/// </summary>
	public override string MessageSocialLinkRemoved => "O link de mídia social foi excluído.";

	/// <summary>
	/// Key: "Message.SocialLinksEditDisabledError"
	/// The error message displayed when the social links feature is disabled and attempt to be edited.
	/// English String: "Social links may not be edited at this time."
	/// </summary>
	public override string MessageSocialLinksEditDisabledError => "Links sociais não podem ser editados no momento.";

	/// <summary>
	/// Key: "Message.TitleEmptyError"
	/// The error message displayed when the title input is empty.
	/// English String: "The title cannot be empty."
	/// </summary>
	public override string MessageTitleEmptyError => "O título não pode ficar vazio.";

	/// <summary>
	/// Key: "Message.TitleModeratedError"
	/// The error message displayed when a title is moderated while being edited.
	/// English String: "The title has been moderated, please try something else."
	/// </summary>
	public override string MessageTitleModeratedError => "O título foi moderado. Tente algo diferente.";

	/// <summary>
	/// Key: "Message.UnauthorizedError"
	/// The error message displayed when an action is attempted against a social link but the user does not have permission to edit social links.
	/// English String: "You do not have permission to update social links."
	/// </summary>
	public override string MessageUnauthorizedError => "Você não tem permissão para atualizar links sociais.";

	/// <summary>
	/// Key: "Message.UnknownError"
	/// The error message displayed when something unknown goes wrong trying to manage a social link.
	/// English String: "Something went wrong, please try again."
	/// </summary>
	public override string MessageUnknownError => "Algo deu errado. Tente de novo.";

	/// <summary>
	/// Key: "Message.UrlEmptyError"
	/// The error message displayed when the url input is empty.
	/// English String: "The url cannot be empty."
	/// </summary>
	public override string MessageUrlEmptyError => "A url não pode ficar vazia.";

	/// <summary>
	/// Key: "Message.UrlSocialMediaTypeMismatchError"
	/// The error message displayed when the url input is not a valid url for the social media type selected.
	/// English String: "The url must match the social media type."
	/// </summary>
	public override string MessageUrlSocialMediaTypeMismatchError => "A url deve conferir com o tipo de mídia social.";

	public PromotedChannelsResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddLink()
	{
		return "Adicionar link";
	}

	protected override string _GetTemplateForActionRemove()
	{
		return "Remover";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "Salvar";
	}

	protected override string _GetTemplateForHeadingSocialLinks()
	{
		return "Links sociais";
	}

	protected override string _GetTemplateForHeadingSocialMedia()
	{
		return "Mídia social";
	}

	/// <summary>
	/// Key: "Label.Limits"
	/// The limitation notice when configuring social links.
	/// English String: "You can add up to {socialLinkLimit} social links."
	/// </summary>
	public override string LabelLimits(string socialLinkLimit)
	{
		return $"Você pode adicionar até {socialLinkLimit} links sociais.";
	}

	protected override string _GetTemplateForLabelLimits()
	{
		return "Você pode adicionar até {socialLinkLimit} links sociais.";
	}

	protected override string _GetTemplateForLabelTitle()
	{
		return "Título";
	}

	protected override string _GetTemplateForLabelUrl()
	{
		return "Url";
	}

	protected override string _GetTemplateForMessageNoGroupPermission()
	{
		return "Você não tem permissão para configurar este grupo.";
	}

	protected override string _GetTemplateForMessageSocialLinkInvalidError()
	{
		return "O link social não existe mais.";
	}

	protected override string _GetTemplateForMessageSocialLinkRemoved()
	{
		return "O link de mídia social foi excluído.";
	}

	/// <summary>
	/// Key: "Message.SocialLinkSaved"
	/// The message displayed when a social link is saved successfully.
	/// English String: "{title} has been saved."
	/// </summary>
	public override string MessageSocialLinkSaved(string title)
	{
		return $"{title} foi salvo.";
	}

	protected override string _GetTemplateForMessageSocialLinkSaved()
	{
		return "{title} foi salvo.";
	}

	protected override string _GetTemplateForMessageSocialLinksEditDisabledError()
	{
		return "Links sociais não podem ser editados no momento.";
	}

	/// <summary>
	/// Key: "Message.SocialLinkTypeLimitError"
	/// The error message that gets displayed when configuring social links and there are multiple links with the same social media type.
	/// English String: "Cannot have more than one {socialMediaType} social media links."
	/// </summary>
	public override string MessageSocialLinkTypeLimitError(string socialMediaType)
	{
		return $"Impossível ter mais de um link de mídia social do {socialMediaType}.";
	}

	protected override string _GetTemplateForMessageSocialLinkTypeLimitError()
	{
		return "Impossível ter mais de um link de mídia social do {socialMediaType}.";
	}

	protected override string _GetTemplateForMessageTitleEmptyError()
	{
		return "O título não pode ficar vazio.";
	}

	protected override string _GetTemplateForMessageTitleModeratedError()
	{
		return "O título foi moderado. Tente algo diferente.";
	}

	protected override string _GetTemplateForMessageUnauthorizedError()
	{
		return "Você não tem permissão para atualizar links sociais.";
	}

	protected override string _GetTemplateForMessageUnknownError()
	{
		return "Algo deu errado. Tente de novo.";
	}

	protected override string _GetTemplateForMessageUrlEmptyError()
	{
		return "A url não pode ficar vazia.";
	}

	protected override string _GetTemplateForMessageUrlSocialMediaTypeMismatchError()
	{
		return "A url deve conferir com o tipo de mídia social.";
	}
}
