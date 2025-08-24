using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class PromotedChannelsResources_en_us : TranslationResourcesBase, IPromotedChannelsResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.AddLink"
	/// The button text for adding an additional social link.
	/// English String: "Add Link"
	/// </summary>
	public virtual string ActionAddLink => "Add Link";

	/// <summary>
	/// Key: "Action.Remove"
	/// The remove button text for configuring social links.
	/// English String: "Remove"
	/// </summary>
	public virtual string ActionRemove => "Remove";

	/// <summary>
	/// Key: "Action.Save"
	/// The save button text for updating a social link.
	/// English String: "Save"
	/// </summary>
	public virtual string ActionSave => "Save";

	/// <summary>
	/// Key: "HeadingSocialLinks"
	/// The heading of the social links panel on the game details page
	/// English String: "Social Links"
	/// </summary>
	public virtual string HeadingSocialLinks => "Social Links";

	/// <summary>
	/// Key: "HeadingSocialMedia"
	/// The heading of the social media panel on the game details page
	/// English String: "Social Media"
	/// </summary>
	public virtual string HeadingSocialMedia => "Social Media";

	/// <summary>
	/// Key: "Label.Title"
	/// Placeholder text for inputting a title for a social link.
	/// English String: "Title"
	/// </summary>
	public virtual string LabelTitle => "Title";

	/// <summary>
	/// Key: "Label.Url"
	/// Placeholder text for inputting a url for a social link.
	/// English String: "Url"
	/// </summary>
	public virtual string LabelUrl => "Url";

	/// <summary>
	/// Key: "Message.NoGroupPermission"
	/// The error message displayed when the user does not have permission to the group they are trying to add.
	/// English String: "You do not have permission to configure this group."
	/// </summary>
	public virtual string MessageNoGroupPermission => "You do not have permission to configure this group.";

	/// <summary>
	/// Key: "Message.SocialLinkInvalidError"
	/// The error message displayed when a social link attempts to be saved but no longer exists.
	/// English String: "The social link no longer exists."
	/// </summary>
	public virtual string MessageSocialLinkInvalidError => "The social link no longer exists.";

	/// <summary>
	/// Key: "Message.SocialLinkRemoved"
	/// The message displayed when the social link has been removed.
	/// English String: "The social media link has been deleted."
	/// </summary>
	public virtual string MessageSocialLinkRemoved => "The social media link has been deleted.";

	/// <summary>
	/// Key: "Message.SocialLinksEditDisabledError"
	/// The error message displayed when the social links feature is disabled and attempt to be edited.
	/// English String: "Social links may not be edited at this time."
	/// </summary>
	public virtual string MessageSocialLinksEditDisabledError => "Social links may not be edited at this time.";

	/// <summary>
	/// Key: "Message.TitleEmptyError"
	/// The error message displayed when the title input is empty.
	/// English String: "The title cannot be empty."
	/// </summary>
	public virtual string MessageTitleEmptyError => "The title cannot be empty.";

	/// <summary>
	/// Key: "Message.TitleModeratedError"
	/// The error message displayed when a title is moderated while being edited.
	/// English String: "The title has been moderated, please try something else."
	/// </summary>
	public virtual string MessageTitleModeratedError => "The title has been moderated, please try something else.";

	/// <summary>
	/// Key: "Message.UnauthorizedError"
	/// The error message displayed when an action is attempted against a social link but the user does not have permission to edit social links.
	/// English String: "You do not have permission to update social links."
	/// </summary>
	public virtual string MessageUnauthorizedError => "You do not have permission to update social links.";

	/// <summary>
	/// Key: "Message.UnknownError"
	/// The error message displayed when something unknown goes wrong trying to manage a social link.
	/// English String: "Something went wrong, please try again."
	/// </summary>
	public virtual string MessageUnknownError => "Something went wrong, please try again.";

	/// <summary>
	/// Key: "Message.UrlEmptyError"
	/// The error message displayed when the url input is empty.
	/// English String: "The url cannot be empty."
	/// </summary>
	public virtual string MessageUrlEmptyError => "The url cannot be empty.";

	/// <summary>
	/// Key: "Message.UrlSocialMediaTypeMismatchError"
	/// The error message displayed when the url input is not a valid url for the social media type selected.
	/// English String: "The url must match the social media type."
	/// </summary>
	public virtual string MessageUrlSocialMediaTypeMismatchError => "The url must match the social media type.";

	public PromotedChannelsResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.AddLink",
				_GetTemplateForActionAddLink()
			},
			{
				"Action.Remove",
				_GetTemplateForActionRemove()
			},
			{
				"Action.Save",
				_GetTemplateForActionSave()
			},
			{
				"HeadingSocialLinks",
				_GetTemplateForHeadingSocialLinks()
			},
			{
				"HeadingSocialMedia",
				_GetTemplateForHeadingSocialMedia()
			},
			{
				"Label.Limits",
				_GetTemplateForLabelLimits()
			},
			{
				"Label.Title",
				_GetTemplateForLabelTitle()
			},
			{
				"Label.Url",
				_GetTemplateForLabelUrl()
			},
			{
				"Message.NoGroupPermission",
				_GetTemplateForMessageNoGroupPermission()
			},
			{
				"Message.SocialLinkInvalidError",
				_GetTemplateForMessageSocialLinkInvalidError()
			},
			{
				"Message.SocialLinkRemoved",
				_GetTemplateForMessageSocialLinkRemoved()
			},
			{
				"Message.SocialLinkSaved",
				_GetTemplateForMessageSocialLinkSaved()
			},
			{
				"Message.SocialLinksEditDisabledError",
				_GetTemplateForMessageSocialLinksEditDisabledError()
			},
			{
				"Message.SocialLinkTypeLimitError",
				_GetTemplateForMessageSocialLinkTypeLimitError()
			},
			{
				"Message.TitleEmptyError",
				_GetTemplateForMessageTitleEmptyError()
			},
			{
				"Message.TitleModeratedError",
				_GetTemplateForMessageTitleModeratedError()
			},
			{
				"Message.UnauthorizedError",
				_GetTemplateForMessageUnauthorizedError()
			},
			{
				"Message.UnknownError",
				_GetTemplateForMessageUnknownError()
			},
			{
				"Message.UrlEmptyError",
				_GetTemplateForMessageUrlEmptyError()
			},
			{
				"Message.UrlSocialMediaTypeMismatchError",
				_GetTemplateForMessageUrlSocialMediaTypeMismatchError()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.PromotedChannels";
	}

	protected virtual string _GetTemplateForActionAddLink()
	{
		return "Add Link";
	}

	protected virtual string _GetTemplateForActionRemove()
	{
		return "Remove";
	}

	protected virtual string _GetTemplateForActionSave()
	{
		return "Save";
	}

	protected virtual string _GetTemplateForHeadingSocialLinks()
	{
		return "Social Links";
	}

	protected virtual string _GetTemplateForHeadingSocialMedia()
	{
		return "Social Media";
	}

	/// <summary>
	/// Key: "Label.Limits"
	/// The limitation notice when configuring social links.
	/// English String: "You can add up to {socialLinkLimit} social links."
	/// </summary>
	public virtual string LabelLimits(string socialLinkLimit)
	{
		return $"You can add up to {socialLinkLimit} social links.";
	}

	protected virtual string _GetTemplateForLabelLimits()
	{
		return "You can add up to {socialLinkLimit} social links.";
	}

	protected virtual string _GetTemplateForLabelTitle()
	{
		return "Title";
	}

	protected virtual string _GetTemplateForLabelUrl()
	{
		return "Url";
	}

	protected virtual string _GetTemplateForMessageNoGroupPermission()
	{
		return "You do not have permission to configure this group.";
	}

	protected virtual string _GetTemplateForMessageSocialLinkInvalidError()
	{
		return "The social link no longer exists.";
	}

	protected virtual string _GetTemplateForMessageSocialLinkRemoved()
	{
		return "The social media link has been deleted.";
	}

	/// <summary>
	/// Key: "Message.SocialLinkSaved"
	/// The message displayed when a social link is saved successfully.
	/// English String: "{title} has been saved."
	/// </summary>
	public virtual string MessageSocialLinkSaved(string title)
	{
		return $"{title} has been saved.";
	}

	protected virtual string _GetTemplateForMessageSocialLinkSaved()
	{
		return "{title} has been saved.";
	}

	protected virtual string _GetTemplateForMessageSocialLinksEditDisabledError()
	{
		return "Social links may not be edited at this time.";
	}

	/// <summary>
	/// Key: "Message.SocialLinkTypeLimitError"
	/// The error message that gets displayed when configuring social links and there are multiple links with the same social media type.
	/// English String: "Cannot have more than one {socialMediaType} social media links."
	/// </summary>
	public virtual string MessageSocialLinkTypeLimitError(string socialMediaType)
	{
		return $"Cannot have more than one {socialMediaType} social media links.";
	}

	protected virtual string _GetTemplateForMessageSocialLinkTypeLimitError()
	{
		return "Cannot have more than one {socialMediaType} social media links.";
	}

	protected virtual string _GetTemplateForMessageTitleEmptyError()
	{
		return "The title cannot be empty.";
	}

	protected virtual string _GetTemplateForMessageTitleModeratedError()
	{
		return "The title has been moderated, please try something else.";
	}

	protected virtual string _GetTemplateForMessageUnauthorizedError()
	{
		return "You do not have permission to update social links.";
	}

	protected virtual string _GetTemplateForMessageUnknownError()
	{
		return "Something went wrong, please try again.";
	}

	protected virtual string _GetTemplateForMessageUrlEmptyError()
	{
		return "The url cannot be empty.";
	}

	protected virtual string _GetTemplateForMessageUrlSocialMediaTypeMismatchError()
	{
		return "The url must match the social media type.";
	}
}
