namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PromotedChannelsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PromotedChannelsResources_fr_fr : PromotedChannelsResources_en_us, IPromotedChannelsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AddLink"
	/// The button text for adding an additional social link.
	/// English String: "Add Link"
	/// </summary>
	public override string ActionAddLink => "Ajouter un lien";

	/// <summary>
	/// Key: "Action.Remove"
	/// The remove button text for configuring social links.
	/// English String: "Remove"
	/// </summary>
	public override string ActionRemove => "Retirer";

	/// <summary>
	/// Key: "Action.Save"
	/// The save button text for updating a social link.
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "Enregistrer";

	/// <summary>
	/// Key: "HeadingSocialLinks"
	/// The heading of the social links panel on the game details page
	/// English String: "Social Links"
	/// </summary>
	public override string HeadingSocialLinks => "Liens sociaux";

	/// <summary>
	/// Key: "HeadingSocialMedia"
	/// The heading of the social media panel on the game details page
	/// English String: "Social Media"
	/// </summary>
	public override string HeadingSocialMedia => "Réseaux sociaux";

	/// <summary>
	/// Key: "Label.Title"
	/// Placeholder text for inputting a title for a social link.
	/// English String: "Title"
	/// </summary>
	public override string LabelTitle => "Titre";

	/// <summary>
	/// Key: "Label.Url"
	/// Placeholder text for inputting a url for a social link.
	/// English String: "Url"
	/// </summary>
	public override string LabelUrl => "Adresse URL";

	/// <summary>
	/// Key: "Message.NoGroupPermission"
	/// The error message displayed when the user does not have permission to the group they are trying to add.
	/// English String: "You do not have permission to configure this group."
	/// </summary>
	public override string MessageNoGroupPermission => "Vous n'avez pas la permission de configurer ce groupe.";

	/// <summary>
	/// Key: "Message.SocialLinkInvalidError"
	/// The error message displayed when a social link attempts to be saved but no longer exists.
	/// English String: "The social link no longer exists."
	/// </summary>
	public override string MessageSocialLinkInvalidError => "Le lien social n'existe plus.";

	/// <summary>
	/// Key: "Message.SocialLinkRemoved"
	/// The message displayed when the social link has been removed.
	/// English String: "The social media link has been deleted."
	/// </summary>
	public override string MessageSocialLinkRemoved => "Le lien vers les réseaux sociaux a été effacé.";

	/// <summary>
	/// Key: "Message.SocialLinksEditDisabledError"
	/// The error message displayed when the social links feature is disabled and attempt to be edited.
	/// English String: "Social links may not be edited at this time."
	/// </summary>
	public override string MessageSocialLinksEditDisabledError => "Les liens sociaux ne peuvent être modifiés pour le moment.";

	/// <summary>
	/// Key: "Message.TitleEmptyError"
	/// The error message displayed when the title input is empty.
	/// English String: "The title cannot be empty."
	/// </summary>
	public override string MessageTitleEmptyError => "Le titre ne peut pas être vide.";

	/// <summary>
	/// Key: "Message.TitleModeratedError"
	/// The error message displayed when a title is moderated while being edited.
	/// English String: "The title has been moderated, please try something else."
	/// </summary>
	public override string MessageTitleModeratedError => "Le titre a été modéré, veuillez en essayer un autre.";

	/// <summary>
	/// Key: "Message.UnauthorizedError"
	/// The error message displayed when an action is attempted against a social link but the user does not have permission to edit social links.
	/// English String: "You do not have permission to update social links."
	/// </summary>
	public override string MessageUnauthorizedError => "Vous n'avez pas la permission de mettre à jour les liens sociaux.";

	/// <summary>
	/// Key: "Message.UnknownError"
	/// The error message displayed when something unknown goes wrong trying to manage a social link.
	/// English String: "Something went wrong, please try again."
	/// </summary>
	public override string MessageUnknownError => "Un problème est survenu, veuillez réessayer.";

	/// <summary>
	/// Key: "Message.UrlEmptyError"
	/// The error message displayed when the url input is empty.
	/// English String: "The url cannot be empty."
	/// </summary>
	public override string MessageUrlEmptyError => "L'URL ne peut être vide.";

	/// <summary>
	/// Key: "Message.UrlSocialMediaTypeMismatchError"
	/// The error message displayed when the url input is not a valid url for the social media type selected.
	/// English String: "The url must match the social media type."
	/// </summary>
	public override string MessageUrlSocialMediaTypeMismatchError => "L'URL doit correspondre au type de réseau social.";

	public PromotedChannelsResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddLink()
	{
		return "Ajouter un lien";
	}

	protected override string _GetTemplateForActionRemove()
	{
		return "Retirer";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "Enregistrer";
	}

	protected override string _GetTemplateForHeadingSocialLinks()
	{
		return "Liens sociaux";
	}

	protected override string _GetTemplateForHeadingSocialMedia()
	{
		return "Réseaux sociaux";
	}

	/// <summary>
	/// Key: "Label.Limits"
	/// The limitation notice when configuring social links.
	/// English String: "You can add up to {socialLinkLimit} social links."
	/// </summary>
	public override string LabelLimits(string socialLinkLimit)
	{
		return $"Vous pouvez ajouter jusqu'à {socialLinkLimit} liens sociaux.";
	}

	protected override string _GetTemplateForLabelLimits()
	{
		return "Vous pouvez ajouter jusqu'à {socialLinkLimit} liens sociaux.";
	}

	protected override string _GetTemplateForLabelTitle()
	{
		return "Titre";
	}

	protected override string _GetTemplateForLabelUrl()
	{
		return "Adresse URL";
	}

	protected override string _GetTemplateForMessageNoGroupPermission()
	{
		return "Vous n'avez pas la permission de configurer ce groupe.";
	}

	protected override string _GetTemplateForMessageSocialLinkInvalidError()
	{
		return "Le lien social n'existe plus.";
	}

	protected override string _GetTemplateForMessageSocialLinkRemoved()
	{
		return "Le lien vers les réseaux sociaux a été effacé.";
	}

	/// <summary>
	/// Key: "Message.SocialLinkSaved"
	/// The message displayed when a social link is saved successfully.
	/// English String: "{title} has been saved."
	/// </summary>
	public override string MessageSocialLinkSaved(string title)
	{
		return $"{title} a été sauvegardé.";
	}

	protected override string _GetTemplateForMessageSocialLinkSaved()
	{
		return "{title} a été sauvegardé.";
	}

	protected override string _GetTemplateForMessageSocialLinksEditDisabledError()
	{
		return "Les liens sociaux ne peuvent être modifiés pour le moment.";
	}

	/// <summary>
	/// Key: "Message.SocialLinkTypeLimitError"
	/// The error message that gets displayed when configuring social links and there are multiple links with the same social media type.
	/// English String: "Cannot have more than one {socialMediaType} social media links."
	/// </summary>
	public override string MessageSocialLinkTypeLimitError(string socialMediaType)
	{
		return $"Impossible d'avoir plus d'un lien pour le réseau social {socialMediaType}.";
	}

	protected override string _GetTemplateForMessageSocialLinkTypeLimitError()
	{
		return "Impossible d'avoir plus d'un lien pour le réseau social {socialMediaType}.";
	}

	protected override string _GetTemplateForMessageTitleEmptyError()
	{
		return "Le titre ne peut pas être vide.";
	}

	protected override string _GetTemplateForMessageTitleModeratedError()
	{
		return "Le titre a été modéré, veuillez en essayer un autre.";
	}

	protected override string _GetTemplateForMessageUnauthorizedError()
	{
		return "Vous n'avez pas la permission de mettre à jour les liens sociaux.";
	}

	protected override string _GetTemplateForMessageUnknownError()
	{
		return "Un problème est survenu, veuillez réessayer.";
	}

	protected override string _GetTemplateForMessageUrlEmptyError()
	{
		return "L'URL ne peut être vide.";
	}

	protected override string _GetTemplateForMessageUrlSocialMediaTypeMismatchError()
	{
		return "L'URL doit correspondre au type de réseau social.";
	}
}
