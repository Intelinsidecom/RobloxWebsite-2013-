using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class ItemConfigurationResources_en_us : TranslationResourcesBase, IItemConfigurationResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Description.AllowCopying"
	/// English String: "By switching on, you are granting every other user of Roblox the right to use (in various ways) the content you are now sharing. If you do not want to grant this right, please do not check this box. For more information about sharing content, please review the Roblox Terms of Use."
	/// </summary>
	public virtual string DescriptionAllowCopying => "By switching on, you are granting every other user of Roblox the right to use (in various ways) the content you are now sharing. If you do not want to grant this right, please do not check this box. For more information about sharing content, please review the Roblox Terms of Use.";

	/// <summary>
	/// Key: "Description.ArchiveWarning"
	/// English String: "Archiving this asset will prevent it from being used in game. Archived assets can be restored."
	/// </summary>
	public virtual string DescriptionArchiveWarning => "Archiving this asset will prevent it from being used in game. Archived assets can be restored.";

	/// <summary>
	/// Key: "Description.ClickToAddTag"
	/// Hover text on the button that adds a tag to an item
	/// English String: "Click to add tag"
	/// </summary>
	public virtual string DescriptionClickToAddTag => "Click to add tag";

	/// <summary>
	/// Key: "Description.ModeratorFileReview"
	/// English String: "* Uploaded file will be reviewed by moderators before being made visible to other users"
	/// </summary>
	public virtual string DescriptionModeratorFileReview => "* Uploaded file will be reviewed by moderators before being made visible to other users";

	/// <summary>
	/// Key: "Description.ModeratorReview"
	/// English String: "* Uploaded image will be reviewed by moderators before being made visible to other users"
	/// </summary>
	public virtual string DescriptionModeratorReview => "* Uploaded image will be reviewed by moderators before being made visible to other users";

	/// <summary>
	/// Key: "Heading.Archive"
	/// header text for section about archiving assets
	/// English String: "Archive"
	/// </summary>
	public virtual string HeadingArchive => "Archive";

	/// <summary>
	/// Key: "Heading.Configure"
	/// English String: "Configure"
	/// </summary>
	public virtual string HeadingConfigure => "Configure";

	/// <summary>
	/// Key: "Heading.ConfigureItemTags"
	/// Heading on Configure Tags modal
	/// English String: "Configure Tags"
	/// </summary>
	public virtual string HeadingConfigureItemTags => "Configure Tags";

	/// <summary>
	/// Key: "Heading.Create"
	/// English String: "Create"
	/// </summary>
	public virtual string HeadingCreate => "Create";

	/// <summary>
	/// Key: "Heading.Settings"
	/// English String: "Settings"
	/// </summary>
	public virtual string HeadingSettings => "Settings";

	/// <summary>
	/// Key: "Label.AllowCopying"
	/// English String: "Allow Copying"
	/// </summary>
	public virtual string LabelAllowCopying => "Allow Copying";

	/// <summary>
	/// Key: "Label.Archive"
	/// Text on button for archiving an asset. Part of speech: verb
	/// English String: "Archive"
	/// </summary>
	public virtual string LabelArchive => "Archive";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public virtual string LabelCancel => "Cancel";

	/// <summary>
	/// Key: "Label.Computer"
	/// computer term
	/// English String: "Computer"
	/// </summary>
	public virtual string LabelComputer => "Computer";

	/// <summary>
	/// Key: "Label.Created"
	/// English String: "Created"
	/// </summary>
	public virtual string LabelCreated => "Created";

	/// <summary>
	/// Key: "Label.Current"
	/// English String: "Current"
	/// </summary>
	public virtual string LabelCurrent => "Current";

	/// <summary>
	/// Key: "Label.CurrentPublishedVersion"
	/// English String: "Current published version"
	/// </summary>
	public virtual string LabelCurrentPublishedVersion => "Current published version";

	/// <summary>
	/// Key: "Label.Description"
	/// English String: "Description"
	/// </summary>
	public virtual string LabelDescription => "Description";

	/// <summary>
	/// Key: "Label.Device"
	/// device term
	/// English String: "Device"
	/// </summary>
	public virtual string LabelDevice => "Device";

	/// <summary>
	/// Key: "Label.EnterItemTag"
	/// Placeholder for input field
	/// English String: "Enter tag here..."
	/// </summary>
	public virtual string LabelEnterItemTag => "Enter tag here...";

	/// <summary>
	/// Key: "Label.Game"
	/// English String: "Game"
	/// </summary>
	public virtual string LabelGame => "Game";

	/// <summary>
	/// Key: "Label.GamePass"
	/// label
	/// English String: "Game Pass"
	/// </summary>
	public virtual string LabelGamePass => "Game Pass";

	/// <summary>
	/// Key: "Label.General"
	/// English String: "General"
	/// </summary>
	public virtual string LabelGeneral => "General";

	/// <summary>
	/// Key: "Label.GoToDetails"
	/// Link to the item details page from the configure page
	/// English String: "Go to Details"
	/// </summary>
	public virtual string LabelGoToDetails => "Go to Details";

	/// <summary>
	/// Key: "Label.ItemActive"
	/// English String: "Item is Active"
	/// </summary>
	public virtual string LabelItemActive => "Item is Active";

	/// <summary>
	/// Key: "Label.ItemForSale"
	/// English String: "Item for Sale"
	/// </summary>
	public virtual string LabelItemForSale => "Item for Sale";

	/// <summary>
	/// Key: "Label.LastUpdated"
	/// English String: "Last Updated"
	/// </summary>
	public virtual string LabelLastUpdated => "Last Updated";

	/// <summary>
	/// Key: "Label.LearnMore"
	/// English String: "Learn more"
	/// </summary>
	public virtual string LabelLearnMore => "Learn more";

	/// <summary>
	/// Key: "Label.MarketplaceFee"
	/// English String: "Marketplace Fee"
	/// </summary>
	public virtual string LabelMarketplaceFee => "Marketplace Fee";

	/// <summary>
	/// Key: "Label.Name"
	/// English String: "Name"
	/// </summary>
	public virtual string LabelName => "Name";

	/// <summary>
	/// Key: "Label.OpenForComments"
	/// English String: "Open for Comments"
	/// </summary>
	public virtual string LabelOpenForComments => "Open for Comments";

	/// <summary>
	/// Key: "Label.Preview"
	/// English String: "Preview"
	/// </summary>
	public virtual string LabelPreview => "Preview";

	/// <summary>
	/// Key: "Label.Price"
	/// English String: "Price"
	/// </summary>
	public virtual string LabelPrice => "Price";

	/// <summary>
	/// Key: "Label.Profit"
	/// English String: "You Earn"
	/// </summary>
	public virtual string LabelProfit => "You Earn";

	/// <summary>
	/// Key: "Label.Restore"
	/// English String: "Restore"
	/// </summary>
	public virtual string LabelRestore => "Restore";

	/// <summary>
	/// Key: "Label.RevertVersion"
	/// English String: "Revert to this version"
	/// </summary>
	public virtual string LabelRevertVersion => "Revert to this version";

	/// <summary>
	/// Key: "Label.Sales"
	/// English String: "Sales"
	/// </summary>
	public virtual string LabelSales => "Sales";

	/// <summary>
	/// Key: "Label.Save"
	/// English String: "Save"
	/// </summary>
	public virtual string LabelSave => "Save";

	/// <summary>
	/// Key: "Label.SelectType"
	/// Placeholder for dropdown in create asset page. Options are image, mesh, hair accessory, etc
	/// English String: "Select a type"
	/// </summary>
	public virtual string LabelSelectType => "Select a type";

	/// <summary>
	/// Key: "Label.Tags"
	/// The label next to a list of item tags in the item configuration page
	/// English String: "Tags"
	/// </summary>
	public virtual string LabelTags => "Tags";

	/// <summary>
	/// Key: "Label.Type"
	/// English String: "Type"
	/// </summary>
	public virtual string LabelType => "Type";

	/// <summary>
	/// Key: "Label.Updated"
	/// English String: "Updated"
	/// </summary>
	public virtual string LabelUpdated => "Updated";

	/// <summary>
	/// Key: "Label.Version"
	/// English String: "Version"
	/// </summary>
	public virtual string LabelVersion => "Version";

	/// <summary>
	/// Key: "Label.Versions"
	/// English String: "Versions"
	/// </summary>
	public virtual string LabelVersions => "Versions";

	/// <summary>
	/// Key: "Message.ArchiveError"
	/// English String: "Failed to archive"
	/// </summary>
	public virtual string MessageArchiveError => "Failed to archive";

	/// <summary>
	/// Key: "Message.ArchiveSuccess"
	/// English String: "Successfully archived"
	/// </summary>
	public virtual string MessageArchiveSuccess => "Successfully archived";

	/// <summary>
	/// Key: "Message.DescriptionFieldEmptyError"
	/// English String: "Description cannot be empty"
	/// </summary>
	public virtual string MessageDescriptionFieldEmptyError => "Description cannot be empty";

	/// <summary>
	/// Key: "Message.DescriptionTooLongError"
	/// error message
	/// English String: "The description is too long."
	/// </summary>
	public virtual string MessageDescriptionTooLongError => "The description is too long.";

	/// <summary>
	/// Key: "Message.FilteringServiceUnavailableError"
	/// error message
	/// English String: "Text filtering service is unavailable at this time."
	/// </summary>
	public virtual string MessageFilteringServiceUnavailableError => "Text filtering service is unavailable at this time.";

	/// <summary>
	/// Key: "Message.GamePassConfigDisabledError"
	/// error message
	/// English String: "Game Pass configuration is not enabled yet."
	/// </summary>
	public virtual string MessageGamePassConfigDisabledError => "Game Pass configuration is not enabled yet.";

	/// <summary>
	/// Key: "Message.GamePassNotFoundError"
	/// errormessage
	/// English String: "The Game Pass does not exist."
	/// </summary>
	public virtual string MessageGamePassNotFoundError => "The Game Pass does not exist.";

	/// <summary>
	/// Key: "Message.IconUpdateFailed"
	/// error message
	/// English String: "Failed to update icon."
	/// </summary>
	public virtual string MessageIconUpdateFailed => "Failed to update icon.";

	/// <summary>
	/// Key: "Message.ImageSavingFailedError"
	/// error message
	/// English String: "Failed to save image. Please try again later."
	/// </summary>
	public virtual string MessageImageSavingFailedError => "Failed to save image. Please try again later.";

	/// <summary>
	/// Key: "Message.InappropriateTextError"
	/// error message
	/// English String: "The name or description contains inappropriate text."
	/// </summary>
	public virtual string MessageInappropriateTextError => "The name or description contains inappropriate text.";

	/// <summary>
	/// Key: "Message.NameFieldEmpty"
	/// English String: "Name cannot be empty"
	/// </summary>
	public virtual string MessageNameFieldEmpty => "Name cannot be empty";

	/// <summary>
	/// Key: "Message.NameRequiredError"
	/// error message
	/// English String: "The name cannot be empty."
	/// </summary>
	public virtual string MessageNameRequiredError => "The name cannot be empty.";

	/// <summary>
	/// Key: "Message.NoTagsFound"
	/// English String: "No tags found"
	/// </summary>
	public virtual string MessageNoTagsFound => "No tags found";

	/// <summary>
	/// Key: "Message.RestoreError"
	/// English String: "Failed to restore"
	/// </summary>
	public virtual string MessageRestoreError => "Failed to restore";

	/// <summary>
	/// Key: "Message.RestoreSuccess"
	/// English String: "Successfully restored"
	/// </summary>
	public virtual string MessageRestoreSuccess => "Successfully restored";

	/// <summary>
	/// Key: "Message.SaveError"
	/// English String: "Something failed. Please try again later"
	/// </summary>
	public virtual string MessageSaveError => "Something failed. Please try again later";

	/// <summary>
	/// Key: "Message.TooManyUploads"
	/// error message
	/// English String: "You are uploading too much. Please try again later."
	/// </summary>
	public virtual string MessageTooManyUploads => "You are uploading too much. Please try again later.";

	/// <summary>
	/// Key: "Message.UpdatePriceError"
	/// English String: "Failed to update price"
	/// </summary>
	public virtual string MessageUpdatePriceError => "Failed to update price";

	/// <summary>
	/// Key: "Message.UpdatePriceSuccess"
	/// English String: "Successfully updated price"
	/// </summary>
	public virtual string MessageUpdatePriceSuccess => "Successfully updated price";

	/// <summary>
	/// Key: "Message.UpdateSuccess"
	/// English String: "Successfully updated"
	/// </summary>
	public virtual string MessageUpdateSuccess => "Successfully updated";

	public ItemConfigurationResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Description.AcceptableFileFormats",
				_GetTemplateForDescriptionAcceptableFileFormats()
			},
			{
				"Description.AcceptableFiles",
				_GetTemplateForDescriptionAcceptableFiles()
			},
			{
				"Description.AllowCopying",
				_GetTemplateForDescriptionAllowCopying()
			},
			{
				"Description.AllowCopyingWarning",
				_GetTemplateForDescriptionAllowCopyingWarning()
			},
			{
				"Description.ArchiveWarning",
				_GetTemplateForDescriptionArchiveWarning()
			},
			{
				"Description.ClickToAddTag",
				_GetTemplateForDescriptionClickToAddTag()
			},
			{
				"Description.MarketplaceExplanation",
				_GetTemplateForDescriptionMarketplaceExplanation()
			},
			{
				"Description.ModeratorFileReview",
				_GetTemplateForDescriptionModeratorFileReview()
			},
			{
				"Description.ModeratorReview",
				_GetTemplateForDescriptionModeratorReview()
			},
			{
				"Description.SelectItemTags",
				_GetTemplateForDescriptionSelectItemTags()
			},
			{
				"Description.VerifiedCreatorEmail",
				_GetTemplateForDescriptionVerifiedCreatorEmail()
			},
			{
				"Heading.Archive",
				_GetTemplateForHeadingArchive()
			},
			{
				"Heading.Configure",
				_GetTemplateForHeadingConfigure()
			},
			{
				"Heading.ConfigureItem",
				_GetTemplateForHeadingConfigureItem()
			},
			{
				"Heading.ConfigureItemTags",
				_GetTemplateForHeadingConfigureItemTags()
			},
			{
				"Heading.Create",
				_GetTemplateForHeadingCreate()
			},
			{
				"Heading.Settings",
				_GetTemplateForHeadingSettings()
			},
			{
				"Label.AllowCopying",
				_GetTemplateForLabelAllowCopying()
			},
			{
				"Label.Archive",
				_GetTemplateForLabelArchive()
			},
			{
				"Label.Cancel",
				_GetTemplateForLabelCancel()
			},
			{
				"Label.Computer",
				_GetTemplateForLabelComputer()
			},
			{
				"Label.Created",
				_GetTemplateForLabelCreated()
			},
			{
				"Label.Current",
				_GetTemplateForLabelCurrent()
			},
			{
				"Label.CurrentPublishedVersion",
				_GetTemplateForLabelCurrentPublishedVersion()
			},
			{
				"Label.Description",
				_GetTemplateForLabelDescription()
			},
			{
				"Label.Device",
				_GetTemplateForLabelDevice()
			},
			{
				"Label.EnterItemTag",
				_GetTemplateForLabelEnterItemTag()
			},
			{
				"Label.ForItem",
				_GetTemplateForLabelForItem()
			},
			{
				"Label.Game",
				_GetTemplateForLabelGame()
			},
			{
				"Label.GamePass",
				_GetTemplateForLabelGamePass()
			},
			{
				"Label.General",
				_GetTemplateForLabelGeneral()
			},
			{
				"Label.GoToDetails",
				_GetTemplateForLabelGoToDetails()
			},
			{
				"Label.ItemActive",
				_GetTemplateForLabelItemActive()
			},
			{
				"Label.ItemForSale",
				_GetTemplateForLabelItemForSale()
			},
			{
				"Label.LastUpdated",
				_GetTemplateForLabelLastUpdated()
			},
			{
				"Label.LearnMore",
				_GetTemplateForLabelLearnMore()
			},
			{
				"Label.MarketplaceFee",
				_GetTemplateForLabelMarketplaceFee()
			},
			{
				"Label.Name",
				_GetTemplateForLabelName()
			},
			{
				"Label.OpenForComments",
				_GetTemplateForLabelOpenForComments()
			},
			{
				"Label.Preview",
				_GetTemplateForLabelPreview()
			},
			{
				"Label.Price",
				_GetTemplateForLabelPrice()
			},
			{
				"Label.Profit",
				_GetTemplateForLabelProfit()
			},
			{
				"Label.Restore",
				_GetTemplateForLabelRestore()
			},
			{
				"Label.RevertVersion",
				_GetTemplateForLabelRevertVersion()
			},
			{
				"Label.Sales",
				_GetTemplateForLabelSales()
			},
			{
				"Label.Save",
				_GetTemplateForLabelSave()
			},
			{
				"Label.SelectType",
				_GetTemplateForLabelSelectType()
			},
			{
				"Label.Tags",
				_GetTemplateForLabelTags()
			},
			{
				"Label.Type",
				_GetTemplateForLabelType()
			},
			{
				"Label.Updated",
				_GetTemplateForLabelUpdated()
			},
			{
				"Label.Version",
				_GetTemplateForLabelVersion()
			},
			{
				"Label.Versions",
				_GetTemplateForLabelVersions()
			},
			{
				"Message.ArchiveError",
				_GetTemplateForMessageArchiveError()
			},
			{
				"Message.ArchiveSuccess",
				_GetTemplateForMessageArchiveSuccess()
			},
			{
				"Message.DescriptionFieldEmpty",
				_GetTemplateForMessageDescriptionFieldEmpty()
			},
			{
				"Message.DescriptionFieldEmptyError",
				_GetTemplateForMessageDescriptionFieldEmptyError()
			},
			{
				"Message.DescriptionFieldPopulated",
				_GetTemplateForMessageDescriptionFieldPopulated()
			},
			{
				"Message.DescriptionTooLongError",
				_GetTemplateForMessageDescriptionTooLongError()
			},
			{
				"Message.FilteringServiceUnavailableError",
				_GetTemplateForMessageFilteringServiceUnavailableError()
			},
			{
				"Message.GamePassConfigDisabledError",
				_GetTemplateForMessageGamePassConfigDisabledError()
			},
			{
				"Message.GamePassNotFoundError",
				_GetTemplateForMessageGamePassNotFoundError()
			},
			{
				"Message.IconUpdateFailed",
				_GetTemplateForMessageIconUpdateFailed()
			},
			{
				"Message.ImageSavingFailedError",
				_GetTemplateForMessageImageSavingFailedError()
			},
			{
				"Message.InappropriateTextError",
				_GetTemplateForMessageInappropriateTextError()
			},
			{
				"Message.MinimumPrice",
				_GetTemplateForMessageMinimumPrice()
			},
			{
				"Message.NameFieldEmpty",
				_GetTemplateForMessageNameFieldEmpty()
			},
			{
				"Message.NameFieldPopulated",
				_GetTemplateForMessageNameFieldPopulated()
			},
			{
				"Message.NameRequiredError",
				_GetTemplateForMessageNameRequiredError()
			},
			{
				"Message.NoTagsFound",
				_GetTemplateForMessageNoTagsFound()
			},
			{
				"Message.RestoreError",
				_GetTemplateForMessageRestoreError()
			},
			{
				"Message.RestoreSuccess",
				_GetTemplateForMessageRestoreSuccess()
			},
			{
				"Message.RevertError",
				_GetTemplateForMessageRevertError()
			},
			{
				"Message.RevertSuccess",
				_GetTemplateForMessageRevertSuccess()
			},
			{
				"Message.SaveError",
				_GetTemplateForMessageSaveError()
			},
			{
				"Message.TooManyUploads",
				_GetTemplateForMessageTooManyUploads()
			},
			{
				"Message.UpdatePriceError",
				_GetTemplateForMessageUpdatePriceError()
			},
			{
				"Message.UpdatePriceSuccess",
				_GetTemplateForMessageUpdatePriceSuccess()
			},
			{
				"Message.UpdateSuccess",
				_GetTemplateForMessageUpdateSuccess()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.ItemConfiguration";
	}

	/// <summary>
	/// Key: "Description.AcceptableFileFormats"
	/// English String: "* Acceptable file formats: {fileExtensions}"
	/// </summary>
	public virtual string DescriptionAcceptableFileFormats(string fileExtensions)
	{
		return $"* Acceptable file formats: {fileExtensions}";
	}

	protected virtual string _GetTemplateForDescriptionAcceptableFileFormats()
	{
		return "* Acceptable file formats: {fileExtensions}";
	}

	/// <summary>
	/// Key: "Description.AcceptableFiles"
	/// English String: "* Acceptable files{lineBreak}Format: {fileExtensions}   |   Size: {fileSizes}"
	/// </summary>
	public virtual string DescriptionAcceptableFiles(string lineBreak, string fileExtensions, string fileSizes)
	{
		return $"* Acceptable files{lineBreak}Format: {fileExtensions}   |   Size: {fileSizes}";
	}

	protected virtual string _GetTemplateForDescriptionAcceptableFiles()
	{
		return "* Acceptable files{lineBreak}Format: {fileExtensions}   |   Size: {fileSizes}";
	}

	protected virtual string _GetTemplateForDescriptionAllowCopying()
	{
		return "By switching on, you are granting every other user of Roblox the right to use (in various ways) the content you are now sharing. If you do not want to grant this right, please do not check this box. For more information about sharing content, please review the Roblox Terms of Use.";
	}

	/// <summary>
	/// Key: "Description.AllowCopyingWarning"
	/// English String: "By switching on, you are granting every other user of Roblox the right to use (in various ways) the content you are now sharing. If you do not want to grant this right, please do not check this box. For more information about sharing content, please review the Roblox {linkStart}Terms of Use{linkEnd}."
	/// </summary>
	public virtual string DescriptionAllowCopyingWarning(string linkStart, string linkEnd)
	{
		return $"By switching on, you are granting every other user of Roblox the right to use (in various ways) the content you are now sharing. If you do not want to grant this right, please do not check this box. For more information about sharing content, please review the Roblox {linkStart}Terms of Use{linkEnd}.";
	}

	protected virtual string _GetTemplateForDescriptionAllowCopyingWarning()
	{
		return "By switching on, you are granting every other user of Roblox the right to use (in various ways) the content you are now sharing. If you do not want to grant this right, please do not check this box. For more information about sharing content, please review the Roblox {linkStart}Terms of Use{linkEnd}.";
	}

	protected virtual string _GetTemplateForDescriptionArchiveWarning()
	{
		return "Archiving this asset will prevent it from being used in game. Archived assets can be restored.";
	}

	protected virtual string _GetTemplateForDescriptionClickToAddTag()
	{
		return "Click to add tag";
	}

	/// <summary>
	/// Key: "Description.MarketplaceExplanation"
	/// English String: "(Roblox takes {marketplaceFeePercentage}%, minimum {minimumPrice})"
	/// </summary>
	public virtual string DescriptionMarketplaceExplanation(string marketplaceFeePercentage, string minimumPrice)
	{
		return $"(Roblox takes {marketplaceFeePercentage}%, minimum {minimumPrice})";
	}

	protected virtual string _GetTemplateForDescriptionMarketplaceExplanation()
	{
		return "(Roblox takes {marketplaceFeePercentage}%, minimum {minimumPrice})";
	}

	protected virtual string _GetTemplateForDescriptionModeratorFileReview()
	{
		return "* Uploaded file will be reviewed by moderators before being made visible to other users";
	}

	protected virtual string _GetTemplateForDescriptionModeratorReview()
	{
		return "* Uploaded image will be reviewed by moderators before being made visible to other users";
	}

	/// <summary>
	/// Key: "Description.SelectItemTags"
	/// itemTagLimit is the number of item tags allowed
	/// English String: "Select up to {itemTagLimit} tags."
	/// </summary>
	public virtual string DescriptionSelectItemTags(string itemTagLimit)
	{
		return $"Select up to {itemTagLimit} tags.";
	}

	protected virtual string _GetTemplateForDescriptionSelectItemTags()
	{
		return "Select up to {itemTagLimit} tags.";
	}

	public virtual string DescriptionVerifiedCreatorEmail(string linkStart, string linkEnd)
	{
		return $"In order to share content in Marketplace, you must add & verify an email address to your account. This can be done in {linkStart}Account Settings{linkEnd}.";
	}

	protected virtual string _GetTemplateForDescriptionVerifiedCreatorEmail()
	{
		return "In order to share content in Marketplace, you must add & verify an email address to your account. This can be done in {linkStart}Account Settings{linkEnd}.";
	}

	protected virtual string _GetTemplateForHeadingArchive()
	{
		return "Archive";
	}

	protected virtual string _GetTemplateForHeadingConfigure()
	{
		return "Configure";
	}

	/// <summary>
	/// Key: "Heading.ConfigureItem"
	/// English String: "Configure {itemType}"
	/// </summary>
	public virtual string HeadingConfigureItem(string itemType)
	{
		return $"Configure {itemType}";
	}

	protected virtual string _GetTemplateForHeadingConfigureItem()
	{
		return "Configure {itemType}";
	}

	protected virtual string _GetTemplateForHeadingConfigureItemTags()
	{
		return "Configure Tags";
	}

	protected virtual string _GetTemplateForHeadingCreate()
	{
		return "Create";
	}

	protected virtual string _GetTemplateForHeadingSettings()
	{
		return "Settings";
	}

	protected virtual string _GetTemplateForLabelAllowCopying()
	{
		return "Allow Copying";
	}

	protected virtual string _GetTemplateForLabelArchive()
	{
		return "Archive";
	}

	protected virtual string _GetTemplateForLabelCancel()
	{
		return "Cancel";
	}

	protected virtual string _GetTemplateForLabelComputer()
	{
		return "Computer";
	}

	protected virtual string _GetTemplateForLabelCreated()
	{
		return "Created";
	}

	protected virtual string _GetTemplateForLabelCurrent()
	{
		return "Current";
	}

	protected virtual string _GetTemplateForLabelCurrentPublishedVersion()
	{
		return "Current published version";
	}

	protected virtual string _GetTemplateForLabelDescription()
	{
		return "Description";
	}

	protected virtual string _GetTemplateForLabelDevice()
	{
		return "Device";
	}

	protected virtual string _GetTemplateForLabelEnterItemTag()
	{
		return "Enter tag here...";
	}

	/// <summary>
	/// Key: "Label.ForItem"
	/// English String: "For {itemType}"
	/// </summary>
	public virtual string LabelForItem(string itemType)
	{
		return $"For {itemType}";
	}

	protected virtual string _GetTemplateForLabelForItem()
	{
		return "For {itemType}";
	}

	protected virtual string _GetTemplateForLabelGame()
	{
		return "Game";
	}

	protected virtual string _GetTemplateForLabelGamePass()
	{
		return "Game Pass";
	}

	protected virtual string _GetTemplateForLabelGeneral()
	{
		return "General";
	}

	protected virtual string _GetTemplateForLabelGoToDetails()
	{
		return "Go to Details";
	}

	protected virtual string _GetTemplateForLabelItemActive()
	{
		return "Item is Active";
	}

	protected virtual string _GetTemplateForLabelItemForSale()
	{
		return "Item for Sale";
	}

	protected virtual string _GetTemplateForLabelLastUpdated()
	{
		return "Last Updated";
	}

	protected virtual string _GetTemplateForLabelLearnMore()
	{
		return "Learn more";
	}

	protected virtual string _GetTemplateForLabelMarketplaceFee()
	{
		return "Marketplace Fee";
	}

	protected virtual string _GetTemplateForLabelName()
	{
		return "Name";
	}

	protected virtual string _GetTemplateForLabelOpenForComments()
	{
		return "Open for Comments";
	}

	protected virtual string _GetTemplateForLabelPreview()
	{
		return "Preview";
	}

	protected virtual string _GetTemplateForLabelPrice()
	{
		return "Price";
	}

	protected virtual string _GetTemplateForLabelProfit()
	{
		return "You Earn";
	}

	protected virtual string _GetTemplateForLabelRestore()
	{
		return "Restore";
	}

	protected virtual string _GetTemplateForLabelRevertVersion()
	{
		return "Revert to this version";
	}

	protected virtual string _GetTemplateForLabelSales()
	{
		return "Sales";
	}

	protected virtual string _GetTemplateForLabelSave()
	{
		return "Save";
	}

	protected virtual string _GetTemplateForLabelSelectType()
	{
		return "Select a type";
	}

	protected virtual string _GetTemplateForLabelTags()
	{
		return "Tags";
	}

	protected virtual string _GetTemplateForLabelType()
	{
		return "Type";
	}

	protected virtual string _GetTemplateForLabelUpdated()
	{
		return "Updated";
	}

	protected virtual string _GetTemplateForLabelVersion()
	{
		return "Version";
	}

	protected virtual string _GetTemplateForLabelVersions()
	{
		return "Versions";
	}

	protected virtual string _GetTemplateForMessageArchiveError()
	{
		return "Failed to archive";
	}

	protected virtual string _GetTemplateForMessageArchiveSuccess()
	{
		return "Successfully archived";
	}

	/// <summary>
	/// Key: "Message.DescriptionFieldEmpty"
	/// English String: "{maxDescriptionLength} character limit"
	/// </summary>
	public virtual string MessageDescriptionFieldEmpty(string maxDescriptionLength)
	{
		return $"{maxDescriptionLength} character limit";
	}

	protected virtual string _GetTemplateForMessageDescriptionFieldEmpty()
	{
		return "{maxDescriptionLength} character limit";
	}

	protected virtual string _GetTemplateForMessageDescriptionFieldEmptyError()
	{
		return "Description cannot be empty";
	}

	/// <summary>
	/// Key: "Message.DescriptionFieldPopulated"
	/// English String: "{descriptionLength}/{maxDescriptionLength} characters"
	/// </summary>
	public virtual string MessageDescriptionFieldPopulated(string descriptionLength, string maxDescriptionLength)
	{
		return $"{descriptionLength}/{maxDescriptionLength} characters";
	}

	protected virtual string _GetTemplateForMessageDescriptionFieldPopulated()
	{
		return "{descriptionLength}/{maxDescriptionLength} characters";
	}

	protected virtual string _GetTemplateForMessageDescriptionTooLongError()
	{
		return "The description is too long.";
	}

	protected virtual string _GetTemplateForMessageFilteringServiceUnavailableError()
	{
		return "Text filtering service is unavailable at this time.";
	}

	protected virtual string _GetTemplateForMessageGamePassConfigDisabledError()
	{
		return "Game Pass configuration is not enabled yet.";
	}

	protected virtual string _GetTemplateForMessageGamePassNotFoundError()
	{
		return "The Game Pass does not exist.";
	}

	protected virtual string _GetTemplateForMessageIconUpdateFailed()
	{
		return "Failed to update icon.";
	}

	protected virtual string _GetTemplateForMessageImageSavingFailedError()
	{
		return "Failed to save image. Please try again later.";
	}

	protected virtual string _GetTemplateForMessageInappropriateTextError()
	{
		return "The name or description contains inappropriate text.";
	}

	/// <summary>
	/// Key: "Message.MinimumPrice"
	/// English String: "You cannot set a price below the minimum price of {minimumPrice}"
	/// </summary>
	public virtual string MessageMinimumPrice(string minimumPrice)
	{
		return $"You cannot set a price below the minimum price of {minimumPrice}";
	}

	protected virtual string _GetTemplateForMessageMinimumPrice()
	{
		return "You cannot set a price below the minimum price of {minimumPrice}";
	}

	protected virtual string _GetTemplateForMessageNameFieldEmpty()
	{
		return "Name cannot be empty";
	}

	/// <summary>
	/// Key: "Message.NameFieldPopulated"
	/// English String: "{nameLength}/{maxNameLength} characters"
	/// </summary>
	public virtual string MessageNameFieldPopulated(string nameLength, string maxNameLength)
	{
		return $"{nameLength}/{maxNameLength} characters";
	}

	protected virtual string _GetTemplateForMessageNameFieldPopulated()
	{
		return "{nameLength}/{maxNameLength} characters";
	}

	protected virtual string _GetTemplateForMessageNameRequiredError()
	{
		return "The name cannot be empty.";
	}

	protected virtual string _GetTemplateForMessageNoTagsFound()
	{
		return "No tags found";
	}

	protected virtual string _GetTemplateForMessageRestoreError()
	{
		return "Failed to restore";
	}

	protected virtual string _GetTemplateForMessageRestoreSuccess()
	{
		return "Successfully restored";
	}

	/// <summary>
	/// Key: "Message.RevertError"
	/// English String: "Failed to revert to version {versionNumber}"
	/// </summary>
	public virtual string MessageRevertError(string versionNumber)
	{
		return $"Failed to revert to version {versionNumber}";
	}

	protected virtual string _GetTemplateForMessageRevertError()
	{
		return "Failed to revert to version {versionNumber}";
	}

	/// <summary>
	/// Key: "Message.RevertSuccess"
	/// English String: "Successfully reverted to version {versionNumber}"
	/// </summary>
	public virtual string MessageRevertSuccess(string versionNumber)
	{
		return $"Successfully reverted to version {versionNumber}";
	}

	protected virtual string _GetTemplateForMessageRevertSuccess()
	{
		return "Successfully reverted to version {versionNumber}";
	}

	protected virtual string _GetTemplateForMessageSaveError()
	{
		return "Something failed. Please try again later";
	}

	protected virtual string _GetTemplateForMessageTooManyUploads()
	{
		return "You are uploading too much. Please try again later.";
	}

	protected virtual string _GetTemplateForMessageUpdatePriceError()
	{
		return "Failed to update price";
	}

	protected virtual string _GetTemplateForMessageUpdatePriceSuccess()
	{
		return "Successfully updated price";
	}

	protected virtual string _GetTemplateForMessageUpdateSuccess()
	{
		return "Successfully updated";
	}
}
