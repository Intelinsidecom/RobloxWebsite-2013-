namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PromotedChannelsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PromotedChannelsResources_de_de : PromotedChannelsResources_en_us, IPromotedChannelsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AddLink"
	/// The button text for adding an additional social link.
	/// English String: "Add Link"
	/// </summary>
	public override string ActionAddLink => "Link hinzufügen";

	/// <summary>
	/// Key: "Action.Remove"
	/// The remove button text for configuring social links.
	/// English String: "Remove"
	/// </summary>
	public override string ActionRemove => "Entfernen";

	/// <summary>
	/// Key: "Action.Save"
	/// The save button text for updating a social link.
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "Speichern";

	/// <summary>
	/// Key: "HeadingSocialLinks"
	/// The heading of the social links panel on the game details page
	/// English String: "Social Links"
	/// </summary>
	public override string HeadingSocialLinks => "Links zu sozialen Netzwerken";

	/// <summary>
	/// Key: "HeadingSocialMedia"
	/// The heading of the social media panel on the game details page
	/// English String: "Social Media"
	/// </summary>
	public override string HeadingSocialMedia => "Soziale Medien";

	/// <summary>
	/// Key: "Label.Title"
	/// Placeholder text for inputting a title for a social link.
	/// English String: "Title"
	/// </summary>
	public override string LabelTitle => "Titel";

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
	public override string MessageNoGroupPermission => "Du hast keine Berechtigung zum Konfigurieren dieser Gruppe.";

	/// <summary>
	/// Key: "Message.SocialLinkInvalidError"
	/// The error message displayed when a social link attempts to be saved but no longer exists.
	/// English String: "The social link no longer exists."
	/// </summary>
	public override string MessageSocialLinkInvalidError => "Der Link zum sozialen Netzwerk existiert nicht mehr.";

	/// <summary>
	/// Key: "Message.SocialLinkRemoved"
	/// The message displayed when the social link has been removed.
	/// English String: "The social media link has been deleted."
	/// </summary>
	public override string MessageSocialLinkRemoved => "Der Link zum sozialen Netzwerk wurde gelöscht.";

	/// <summary>
	/// Key: "Message.SocialLinksEditDisabledError"
	/// The error message displayed when the social links feature is disabled and attempt to be edited.
	/// English String: "Social links may not be edited at this time."
	/// </summary>
	public override string MessageSocialLinksEditDisabledError => "Links zu sozialen Netzwerken können derzeit nicht bearbeitet werden.";

	/// <summary>
	/// Key: "Message.TitleEmptyError"
	/// The error message displayed when the title input is empty.
	/// English String: "The title cannot be empty."
	/// </summary>
	public override string MessageTitleEmptyError => "Der Titel darf nicht leer sein.";

	/// <summary>
	/// Key: "Message.TitleModeratedError"
	/// The error message displayed when a title is moderated while being edited.
	/// English String: "The title has been moderated, please try something else."
	/// </summary>
	public override string MessageTitleModeratedError => "Der Titel wurde moderiert, bitte benutze einen anderen.";

	/// <summary>
	/// Key: "Message.UnauthorizedError"
	/// The error message displayed when an action is attempted against a social link but the user does not have permission to edit social links.
	/// English String: "You do not have permission to update social links."
	/// </summary>
	public override string MessageUnauthorizedError => "Du hast keine Berechtigung zum Aktualisieren von Links zu sozialen Netzwerken.";

	/// <summary>
	/// Key: "Message.UnknownError"
	/// The error message displayed when something unknown goes wrong trying to manage a social link.
	/// English String: "Something went wrong, please try again."
	/// </summary>
	public override string MessageUnknownError => "Etwas ist schiefgelaufen, bitte versuche es erneut.";

	/// <summary>
	/// Key: "Message.UrlEmptyError"
	/// The error message displayed when the url input is empty.
	/// English String: "The url cannot be empty."
	/// </summary>
	public override string MessageUrlEmptyError => "Die URL darf nicht leer sein.";

	/// <summary>
	/// Key: "Message.UrlSocialMediaTypeMismatchError"
	/// The error message displayed when the url input is not a valid url for the social media type selected.
	/// English String: "The url must match the social media type."
	/// </summary>
	public override string MessageUrlSocialMediaTypeMismatchError => "Die URL muss zur Art des sozialen Netzwerks passen.";

	public PromotedChannelsResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddLink()
	{
		return "Link hinzufügen";
	}

	protected override string _GetTemplateForActionRemove()
	{
		return "Entfernen";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "Speichern";
	}

	protected override string _GetTemplateForHeadingSocialLinks()
	{
		return "Links zu sozialen Netzwerken";
	}

	protected override string _GetTemplateForHeadingSocialMedia()
	{
		return "Soziale Medien";
	}

	/// <summary>
	/// Key: "Label.Limits"
	/// The limitation notice when configuring social links.
	/// English String: "You can add up to {socialLinkLimit} social links."
	/// </summary>
	public override string LabelLimits(string socialLinkLimit)
	{
		return $"Du kannst bis zu {socialLinkLimit} Links zu sozialen Netzwerken hinzufügen.";
	}

	protected override string _GetTemplateForLabelLimits()
	{
		return "Du kannst bis zu {socialLinkLimit} Links zu sozialen Netzwerken hinzufügen.";
	}

	protected override string _GetTemplateForLabelTitle()
	{
		return "Titel";
	}

	protected override string _GetTemplateForLabelUrl()
	{
		return "URL";
	}

	protected override string _GetTemplateForMessageNoGroupPermission()
	{
		return "Du hast keine Berechtigung zum Konfigurieren dieser Gruppe.";
	}

	protected override string _GetTemplateForMessageSocialLinkInvalidError()
	{
		return "Der Link zum sozialen Netzwerk existiert nicht mehr.";
	}

	protected override string _GetTemplateForMessageSocialLinkRemoved()
	{
		return "Der Link zum sozialen Netzwerk wurde gelöscht.";
	}

	/// <summary>
	/// Key: "Message.SocialLinkSaved"
	/// The message displayed when a social link is saved successfully.
	/// English String: "{title} has been saved."
	/// </summary>
	public override string MessageSocialLinkSaved(string title)
	{
		return $"{title} wurde gespeichert.";
	}

	protected override string _GetTemplateForMessageSocialLinkSaved()
	{
		return "{title} wurde gespeichert.";
	}

	protected override string _GetTemplateForMessageSocialLinksEditDisabledError()
	{
		return "Links zu sozialen Netzwerken können derzeit nicht bearbeitet werden.";
	}

	/// <summary>
	/// Key: "Message.SocialLinkTypeLimitError"
	/// The error message that gets displayed when configuring social links and there are multiple links with the same social media type.
	/// English String: "Cannot have more than one {socialMediaType} social media links."
	/// </summary>
	public override string MessageSocialLinkTypeLimitError(string socialMediaType)
	{
		return $"Du kannst höchstens einen Link zum sozialen Netzwerk „{socialMediaType}“ haben.";
	}

	protected override string _GetTemplateForMessageSocialLinkTypeLimitError()
	{
		return "Du kannst höchstens einen Link zum sozialen Netzwerk „{socialMediaType}“ haben.";
	}

	protected override string _GetTemplateForMessageTitleEmptyError()
	{
		return "Der Titel darf nicht leer sein.";
	}

	protected override string _GetTemplateForMessageTitleModeratedError()
	{
		return "Der Titel wurde moderiert, bitte benutze einen anderen.";
	}

	protected override string _GetTemplateForMessageUnauthorizedError()
	{
		return "Du hast keine Berechtigung zum Aktualisieren von Links zu sozialen Netzwerken.";
	}

	protected override string _GetTemplateForMessageUnknownError()
	{
		return "Etwas ist schiefgelaufen, bitte versuche es erneut.";
	}

	protected override string _GetTemplateForMessageUrlEmptyError()
	{
		return "Die URL darf nicht leer sein.";
	}

	protected override string _GetTemplateForMessageUrlSocialMediaTypeMismatchError()
	{
		return "Die URL muss zur Art des sozialen Netzwerks passen.";
	}
}
