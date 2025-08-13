using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class TranslationRolesResources_en_us : TranslationResourcesBase, ITranslationRolesResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Description.Modal.DeleteTranslator"
	/// English String: "Are you sure you want to delete this translator?"
	/// </summary>
	public virtual string DescriptionModalDeleteTranslator => "Are you sure you want to delete this translator?";

	/// <summary>
	/// Key: "Description.TranslatorTooltip"
	/// English String: "Add translators by username or user ID. You can also add a specific role set from a Group you own as translators. Users with translator access will be able to view game content and provide translations."
	/// </summary>
	public virtual string DescriptionTranslatorTooltip => "Add translators by username or user ID. You can also add a specific role set from a Group you own as translators. Users with translator access will be able to view game content and provide translations.";

	/// <summary>
	/// Key: "Heading.Modal.DeleteTranslator"
	/// English String: "Delete Translator"
	/// </summary>
	public virtual string HeadingModalDeleteTranslator => "Delete Translator";

	/// <summary>
	/// Key: "Heading.Translators"
	/// English String: "Translators"
	/// </summary>
	public virtual string HeadingTranslators => "Translators";

	/// <summary>
	/// Key: "Label.AddUser"
	/// English String: "Click to add translator"
	/// </summary>
	public virtual string LabelAddUser => "Click to add translator";

	/// <summary>
	/// Key: "Label.EnterGroupIdPlaceholder"
	/// English String: "Enter Translator Group ID"
	/// </summary>
	public virtual string LabelEnterGroupIdPlaceholder => "Enter Translator Group ID";

	/// <summary>
	/// Key: "Label.EnterUserIdPlaceholder"
	/// English String: "Enter Translator's UserID"
	/// </summary>
	public virtual string LabelEnterUserIdPlaceholder => "Enter Translator's UserID";

	/// <summary>
	/// Key: "Label.EnterUsernamePlaceholder"
	/// English String: "Enter Translator's Username"
	/// </summary>
	public virtual string LabelEnterUsernamePlaceholder => "Enter Translator's Username";

	/// <summary>
	/// Key: "Label.EntireGroup"
	/// English String: "Entire Group"
	/// </summary>
	public virtual string LabelEntireGroup => "Entire Group";

	/// <summary>
	/// Key: "Label.GroupId"
	/// English String: "Group ID"
	/// </summary>
	public virtual string LabelGroupId => "Group ID";

	/// <summary>
	/// Key: "Label.Groups"
	/// English String: "Groups"
	/// </summary>
	public virtual string LabelGroups => "Groups";

	/// <summary>
	/// Key: "Label.PrivateGroup"
	/// English String: "Private Group"
	/// </summary>
	public virtual string LabelPrivateGroup => "Private Group";

	/// <summary>
	/// Key: "Label.PublicGroup"
	/// English String: "Public Group"
	/// </summary>
	public virtual string LabelPublicGroup => "Public Group";

	/// <summary>
	/// Key: "Label.RemoveUser"
	/// English String: "Click to remove translator"
	/// </summary>
	public virtual string LabelRemoveUser => "Click to remove translator";

	/// <summary>
	/// Key: "Label.SelectGroupRole"
	/// English String: "Select Group Role"
	/// </summary>
	public virtual string LabelSelectGroupRole => "Select Group Role";

	/// <summary>
	/// Key: "Label.TranslatorsTooltip"
	/// English String: "Users and groups with translator access will be able to view game content and provide translations."
	/// </summary>
	public virtual string LabelTranslatorsTooltip => "Users and groups with translator access will be able to view game content and provide translations.";

	/// <summary>
	/// Key: "Label.UserId"
	/// English String: "User ID"
	/// </summary>
	public virtual string LabelUserId => "User ID";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public virtual string LabelUsername => "Username";

	/// <summary>
	/// Key: "Label.Users"
	/// English String: "Users"
	/// </summary>
	public virtual string LabelUsers => "Users";

	/// <summary>
	/// Key: "Message.EnterTranslatorGroupID"
	/// English String: "Please enter Group ID of the group you like to add as translator"
	/// </summary>
	public virtual string MessageEnterTranslatorGroupID => "Please enter Group ID of the group you like to add as translator";

	/// <summary>
	/// Key: "Message.EnterTranslatorUserId"
	/// English String: "Please enter a translator's User ID"
	/// </summary>
	public virtual string MessageEnterTranslatorUserId => "Please enter a translator's User ID";

	/// <summary>
	/// Key: "Message.EnterTranslatorUsername"
	/// English String: "Please enter a translator's username"
	/// </summary>
	public virtual string MessageEnterTranslatorUsername => "Please enter a translator's username";

	/// <summary>
	/// Key: "Message.GroupAlreadyAdded"
	/// English String: "The group is already added."
	/// </summary>
	public virtual string MessageGroupAlreadyAdded => "The group is already added.";

	/// <summary>
	/// Key: "Message.GroupAlreadyAddedWithRoleset"
	/// English String: "Group with specified role set is already added. "
	/// </summary>
	public virtual string MessageGroupAlreadyAddedWithRoleset => "Group with specified role set is already added. ";

	/// <summary>
	/// Key: "Message.InvalidGroup"
	/// English String: "Group not found. Please check Group ID entered."
	/// </summary>
	public virtual string MessageInvalidGroup => "Group not found. Please check Group ID entered.";

	/// <summary>
	/// Key: "Message.RolesServerError"
	/// This error message is shown when we are unable to show information to the user. We ask them to refresh or try again later because our services might be down.
	/// English String: "Unable to retrieve data. Please refresh or try again later."
	/// </summary>
	public virtual string MessageRolesServerError => "Unable to retrieve data. Please refresh or try again later.";

	/// <summary>
	/// Key: "Message.UserAlreadyAdded"
	/// English String: "This user is already added"
	/// </summary>
	public virtual string MessageUserAlreadyAdded => "This user is already added";

	/// <summary>
	/// Key: "Message.UserNotFound"
	/// English String: "User not found. Please check Username or User ID entered."
	/// </summary>
	public virtual string MessageUserNotFound => "User not found. Please check Username or User ID entered.";

	public TranslationRolesResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Description.Modal.DeleteTranslator",
				_GetTemplateForDescriptionModalDeleteTranslator()
			},
			{
				"Description.TranslatorTooltip",
				_GetTemplateForDescriptionTranslatorTooltip()
			},
			{
				"Heading.Modal.DeleteTranslator",
				_GetTemplateForHeadingModalDeleteTranslator()
			},
			{
				"Heading.Translators",
				_GetTemplateForHeadingTranslators()
			},
			{
				"Label.AddUser",
				_GetTemplateForLabelAddUser()
			},
			{
				"Label.EnterGroupIdPlaceholder",
				_GetTemplateForLabelEnterGroupIdPlaceholder()
			},
			{
				"Label.EnterUserIdPlaceholder",
				_GetTemplateForLabelEnterUserIdPlaceholder()
			},
			{
				"Label.EnterUsernamePlaceholder",
				_GetTemplateForLabelEnterUsernamePlaceholder()
			},
			{
				"Label.EntireGroup",
				_GetTemplateForLabelEntireGroup()
			},
			{
				"Label.GroupId",
				_GetTemplateForLabelGroupId()
			},
			{
				"Label.Groups",
				_GetTemplateForLabelGroups()
			},
			{
				"Label.PrivateGroup",
				_GetTemplateForLabelPrivateGroup()
			},
			{
				"Label.PublicGroup",
				_GetTemplateForLabelPublicGroup()
			},
			{
				"Label.RemoveUser",
				_GetTemplateForLabelRemoveUser()
			},
			{
				"Label.RolesetName",
				_GetTemplateForLabelRolesetName()
			},
			{
				"Label.SelectGroupRole",
				_GetTemplateForLabelSelectGroupRole()
			},
			{
				"Label.TranslatorsTooltip",
				_GetTemplateForLabelTranslatorsTooltip()
			},
			{
				"Label.UserId",
				_GetTemplateForLabelUserId()
			},
			{
				"Label.Username",
				_GetTemplateForLabelUsername()
			},
			{
				"Label.Users",
				_GetTemplateForLabelUsers()
			},
			{
				"Message.EnterTranslatorGroupID",
				_GetTemplateForMessageEnterTranslatorGroupID()
			},
			{
				"Message.EnterTranslatorUserId",
				_GetTemplateForMessageEnterTranslatorUserId()
			},
			{
				"Message.EnterTranslatorUsername",
				_GetTemplateForMessageEnterTranslatorUsername()
			},
			{
				"Message.GroupAlreadyAdded",
				_GetTemplateForMessageGroupAlreadyAdded()
			},
			{
				"Message.GroupAlreadyAddedWithRoleset",
				_GetTemplateForMessageGroupAlreadyAddedWithRoleset()
			},
			{
				"Message.InvalidGroup",
				_GetTemplateForMessageInvalidGroup()
			},
			{
				"Message.RolesServerError",
				_GetTemplateForMessageRolesServerError()
			},
			{
				"Message.UserAlreadyAdded",
				_GetTemplateForMessageUserAlreadyAdded()
			},
			{
				"Message.UserNotFound",
				_GetTemplateForMessageUserNotFound()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.TranslationRoles";
	}

	protected virtual string _GetTemplateForDescriptionModalDeleteTranslator()
	{
		return "Are you sure you want to delete this translator?";
	}

	protected virtual string _GetTemplateForDescriptionTranslatorTooltip()
	{
		return "Add translators by username or user ID. You can also add a specific role set from a Group you own as translators. Users with translator access will be able to view game content and provide translations.";
	}

	protected virtual string _GetTemplateForHeadingModalDeleteTranslator()
	{
		return "Delete Translator";
	}

	protected virtual string _GetTemplateForHeadingTranslators()
	{
		return "Translators";
	}

	protected virtual string _GetTemplateForLabelAddUser()
	{
		return "Click to add translator";
	}

	protected virtual string _GetTemplateForLabelEnterGroupIdPlaceholder()
	{
		return "Enter Translator Group ID";
	}

	protected virtual string _GetTemplateForLabelEnterUserIdPlaceholder()
	{
		return "Enter Translator's UserID";
	}

	protected virtual string _GetTemplateForLabelEnterUsernamePlaceholder()
	{
		return "Enter Translator's Username";
	}

	protected virtual string _GetTemplateForLabelEntireGroup()
	{
		return "Entire Group";
	}

	protected virtual string _GetTemplateForLabelGroupId()
	{
		return "Group ID";
	}

	protected virtual string _GetTemplateForLabelGroups()
	{
		return "Groups";
	}

	protected virtual string _GetTemplateForLabelPrivateGroup()
	{
		return "Private Group";
	}

	protected virtual string _GetTemplateForLabelPublicGroup()
	{
		return "Public Group";
	}

	protected virtual string _GetTemplateForLabelRemoveUser()
	{
		return "Click to remove translator";
	}

	/// <summary>
	/// Key: "Label.RolesetName"
	/// English String: "Role: {rolesetName}"
	/// </summary>
	public virtual string LabelRolesetName(string rolesetName)
	{
		return $"Role: {rolesetName}";
	}

	protected virtual string _GetTemplateForLabelRolesetName()
	{
		return "Role: {rolesetName}";
	}

	protected virtual string _GetTemplateForLabelSelectGroupRole()
	{
		return "Select Group Role";
	}

	protected virtual string _GetTemplateForLabelTranslatorsTooltip()
	{
		return "Users and groups with translator access will be able to view game content and provide translations.";
	}

	protected virtual string _GetTemplateForLabelUserId()
	{
		return "User ID";
	}

	protected virtual string _GetTemplateForLabelUsername()
	{
		return "Username";
	}

	protected virtual string _GetTemplateForLabelUsers()
	{
		return "Users";
	}

	protected virtual string _GetTemplateForMessageEnterTranslatorGroupID()
	{
		return "Please enter Group ID of the group you like to add as translator";
	}

	protected virtual string _GetTemplateForMessageEnterTranslatorUserId()
	{
		return "Please enter a translator's User ID";
	}

	protected virtual string _GetTemplateForMessageEnterTranslatorUsername()
	{
		return "Please enter a translator's username";
	}

	protected virtual string _GetTemplateForMessageGroupAlreadyAdded()
	{
		return "The group is already added.";
	}

	protected virtual string _GetTemplateForMessageGroupAlreadyAddedWithRoleset()
	{
		return "Group with specified role set is already added. ";
	}

	protected virtual string _GetTemplateForMessageInvalidGroup()
	{
		return "Group not found. Please check Group ID entered.";
	}

	protected virtual string _GetTemplateForMessageRolesServerError()
	{
		return "Unable to retrieve data. Please refresh or try again later.";
	}

	protected virtual string _GetTemplateForMessageUserAlreadyAdded()
	{
		return "This user is already added";
	}

	protected virtual string _GetTemplateForMessageUserNotFound()
	{
		return "User not found. Please check Username or User ID entered.";
	}
}
