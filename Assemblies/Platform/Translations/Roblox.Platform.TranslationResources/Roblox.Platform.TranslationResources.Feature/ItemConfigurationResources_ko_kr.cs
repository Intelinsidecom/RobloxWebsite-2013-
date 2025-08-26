namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides ItemConfigurationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ItemConfigurationResources_ko_kr : ItemConfigurationResources_en_us, IItemConfigurationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Description.AllowCopying"
	/// English String: "By switching on, you are granting every other user of Roblox the right to use (in various ways) the content you are now sharing. If you do not want to grant this right, please do not check this box. For more information about sharing content, please review the Roblox Terms of Use."
	/// </summary>
	public override string DescriptionAllowCopying => "ë³¸ í™•ì¸ëž€ì„ ì„ íƒí•˜ë©´ íšŒì›ë‹˜ì´ ì§€ê¸ˆ ê³µìœ í•˜ë ¤ëŠ” ì½˜í…ì¸ ë¥¼ Robloxì˜ ëª¨ë“  ì‚¬ìš©ìžê°€ ë‹¤ì–‘í•œ ë°©ì‹ìœ¼ë¡œ ì‚¬ìš©í•  ìˆ˜ ìžˆê²Œ ë©ë‹ˆë‹¤. ì‚¬ìš©ì„ í—ˆë½í•˜ì§€ ì•Šìœ¼ë ¤ë©´ í™•ì¸ëž€ì„ ì„ íƒí•˜ì§€ ë§ˆì„¸ìš”. ì½˜í…ì¸  ê³µìœ ì— ê´€í•œ ìžì„¸í•œ ì •ë³´ëŠ” Roblox ì´ìš© ì•½ê´€ì„ ì°¸ê³ í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Description.ArchiveWarning"
	/// English String: "Archiving this asset will prevent it from being used in game. Archived assets can be restored."
	/// </summary>
	public override string DescriptionArchiveWarning => "ì• ì…‹ì„ ë³´ê´€í•˜ë©´ ê²Œìž„ì—ì„œ ì‚¬ìš©í•  ìˆ˜ ì—†ì–´ìš”. ë³´ê´€í–ˆë˜ ì• ì…‹ì€ ë‚˜ì¤‘ì— ë³µì› ê°€ëŠ¥í•´ìš”.";

	/// <summary>
	/// Key: "Description.ClickToAddTag"
	/// Hover text on the button that adds a tag to an item
	/// English String: "Click to add tag"
	/// </summary>
	public override string DescriptionClickToAddTag => "íƒœê·¸ë¥¼ ì¶”ê°€í•˜ë ¤ë©´ í´ë¦­";

	/// <summary>
	/// Key: "Description.ModeratorFileReview"
	/// English String: "* Uploaded file will be reviewed by moderators before being made visible to other users"
	/// </summary>
	public override string DescriptionModeratorFileReview => "* ì—…ë¡œë“œí•œ íŒŒì¼ì€ ê²€ì—´íŒ€ì˜ ê²€í† ê°€ ëë‚œ í›„ì— ë‹¤ë¥¸ ì‚¬ìš©ìžì—ê²Œ ê³µê°œë©ë‹ˆë‹¤";

	/// <summary>
	/// Key: "Description.ModeratorReview"
	/// English String: "* Uploaded image will be reviewed by moderators before being made visible to other users"
	/// </summary>
	public override string DescriptionModeratorReview => "* ì—…ë¡œë“œí•œ ì´ë¯¸ì§€ëŠ” ê²€ì—´íŒ€ì˜ ê²€í† ê°€ ëë‚œ í›„ì— ë‹¤ë¥¸ ì‚¬ìš©ìžì—ê²Œ ê³µê°œë©ë‹ˆë‹¤";

	/// <summary>
	/// Key: "Heading.Archive"
	/// header text for section about archiving assets
	/// English String: "Archive"
	/// </summary>
	public override string HeadingArchive => "ë³´ê´€";

	/// <summary>
	/// Key: "Heading.Configure"
	/// English String: "Configure"
	/// </summary>
	public override string HeadingConfigure => "êµ¬ì„±";

	/// <summary>
	/// Key: "Heading.ConfigureItemTags"
	/// Heading on Configure Tags modal
	/// English String: "Configure Tags"
	/// </summary>
	public override string HeadingConfigureItemTags => "íƒœê·¸ êµ¬ì„±";

	/// <summary>
	/// Key: "Heading.Create"
	/// English String: "Create"
	/// </summary>
	public override string HeadingCreate => "ë§Œë“¤ê¸°";

	/// <summary>
	/// Key: "Heading.Settings"
	/// English String: "Settings"
	/// </summary>
	public override string HeadingSettings => "ì„¤ì •";

	/// <summary>
	/// Key: "Label.AllowCopying"
	/// English String: "Allow Copying"
	/// </summary>
	public override string LabelAllowCopying => "ë³µì‚¬ í—ˆìš©";

	/// <summary>
	/// Key: "Label.Archive"
	/// Text on button for archiving an asset. Part of speech: verb
	/// English String: "Archive"
	/// </summary>
	public override string LabelArchive => "ë³´ê´€";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "ì·¨ì†Œ";

	/// <summary>
	/// Key: "Label.Computer"
	/// computer term
	/// English String: "Computer"
	/// </summary>
	public override string LabelComputer => "ì»´í“¨í„°";

	/// <summary>
	/// Key: "Label.Created"
	/// English String: "Created"
	/// </summary>
	public override string LabelCreated => "ê°œë°œ ì™„ë£Œ";

	/// <summary>
	/// Key: "Label.Current"
	/// English String: "Current"
	/// </summary>
	public override string LabelCurrent => "í˜„ìž¬";

	/// <summary>
	/// Key: "Label.CurrentPublishedVersion"
	/// English String: "Current published version"
	/// </summary>
	public override string LabelCurrentPublishedVersion => "í˜„ìž¬ ê²Œì‹œ ë²„ì „";

	/// <summary>
	/// Key: "Label.Description"
	/// English String: "Description"
	/// </summary>
	public override string LabelDescription => "ì„¤ëª…";

	/// <summary>
	/// Key: "Label.Device"
	/// device term
	/// English String: "Device"
	/// </summary>
	public override string LabelDevice => "ê¸°ê¸°";

	/// <summary>
	/// Key: "Label.EnterItemTag"
	/// Placeholder for input field
	/// English String: "Enter tag here..."
	/// </summary>
	public override string LabelEnterItemTag => "ì—¬ê¸°ì— íƒœê·¸ë¥¼ ìž…ë ¥í•˜ì„¸ìš”...";

	/// <summary>
	/// Key: "Label.Game"
	/// English String: "Game"
	/// </summary>
	public override string LabelGame => "ê²Œìž„";

	/// <summary>
	/// Key: "Label.GamePass"
	/// label
	/// English String: "Game Pass"
	/// </summary>
	public override string LabelGamePass => "ê²Œìž„íŒ¨ìŠ¤";

	/// <summary>
	/// Key: "Label.General"
	/// English String: "General"
	/// </summary>
	public override string LabelGeneral => "ì¼ë°˜";

	/// <summary>
	/// Key: "Label.GoToDetails"
	/// Link to the item details page from the configure page
	/// English String: "Go to Details"
	/// </summary>
	public override string LabelGoToDetails => "'ì„¤ëª…'ìœ¼ë¡œ ì´ë™";

	/// <summary>
	/// Key: "Label.ItemActive"
	/// English String: "Item is Active"
	/// </summary>
	public override string LabelItemActive => "ì•„ì´í…œì´ í™œì„±í™” ìƒíƒœìž…ë‹ˆë‹¤";

	/// <summary>
	/// Key: "Label.ItemForSale"
	/// English String: "Item for Sale"
	/// </summary>
	public override string LabelItemForSale => "íŒë§¤ ì•„ì´í…œ";

	/// <summary>
	/// Key: "Label.LastUpdated"
	/// English String: "Last Updated"
	/// </summary>
	public override string LabelLastUpdated => "ìµœì‹  ì—…ë°ì´íŠ¸";

	/// <summary>
	/// Key: "Label.LearnMore"
	/// English String: "Learn more"
	/// </summary>
	public override string LabelLearnMore => "ë” ì•Œì•„ë³´ê¸°";

	/// <summary>
	/// Key: "Label.MarketplaceFee"
	/// English String: "Marketplace Fee"
	/// </summary>
	public override string LabelMarketplaceFee => "ìž¥í„° ìˆ˜ìˆ˜ë£Œ";

	/// <summary>
	/// Key: "Label.Name"
	/// English String: "Name"
	/// </summary>
	public override string LabelName => "ì´ë¦„";

	/// <summary>
	/// Key: "Label.OpenForComments"
	/// English String: "Open for Comments"
	/// </summary>
	public override string LabelOpenForComments => "ì½”ë©˜íŠ¸ ì—´ê¸°";

	/// <summary>
	/// Key: "Label.Preview"
	/// English String: "Preview"
	/// </summary>
	public override string LabelPreview => "ë¯¸ë¦¬ë³´ê¸°";

	/// <summary>
	/// Key: "Label.Price"
	/// English String: "Price"
	/// </summary>
	public override string LabelPrice => "ê°€ê²©";

	/// <summary>
	/// Key: "Label.Profit"
	/// English String: "You Earn"
	/// </summary>
	public override string LabelProfit => "íšë“:";

	/// <summary>
	/// Key: "Label.Restore"
	/// English String: "Restore"
	/// </summary>
	public override string LabelRestore => "ë³µì›";

	/// <summary>
	/// Key: "Label.RevertVersion"
	/// English String: "Revert to this version"
	/// </summary>
	public override string LabelRevertVersion => "ì´ ë²„ì „ìœ¼ë¡œ ë³µêµ¬";

	/// <summary>
	/// Key: "Label.Sales"
	/// English String: "Sales"
	/// </summary>
	public override string LabelSales => "íŒë§¤";

	/// <summary>
	/// Key: "Label.Save"
	/// English String: "Save"
	/// </summary>
	public override string LabelSave => "ì €ìž¥";

	/// <summary>
	/// Key: "Label.SelectType"
	/// Placeholder for dropdown in create asset page. Options are image, mesh, hair accessory, etc
	/// English String: "Select a type"
	/// </summary>
	public override string LabelSelectType => "ì¢…ë¥˜ ì„ íƒí•˜ê¸°";

	/// <summary>
	/// Key: "Label.Tags"
	/// The label next to a list of item tags in the item configuration page
	/// English String: "Tags"
	/// </summary>
	public override string LabelTags => "íƒœê·¸";

	/// <summary>
	/// Key: "Label.Type"
	/// English String: "Type"
	/// </summary>
	public override string LabelType => "ì¢…ë¥˜";

	/// <summary>
	/// Key: "Label.Updated"
	/// English String: "Updated"
	/// </summary>
	public override string LabelUpdated => "ì—…ë°ì´íŠ¸ ì™„ë£Œ";

	/// <summary>
	/// Key: "Label.Version"
	/// English String: "Version"
	/// </summary>
	public override string LabelVersion => "ë²„ì „";

	/// <summary>
	/// Key: "Label.Versions"
	/// English String: "Versions"
	/// </summary>
	public override string LabelVersions => "ë²„ì „";

	/// <summary>
	/// Key: "Message.ArchiveError"
	/// English String: "Failed to archive"
	/// </summary>
	public override string MessageArchiveError => "ë³´ê´€ ì‹¤íŒ¨";

	/// <summary>
	/// Key: "Message.ArchiveSuccess"
	/// English String: "Successfully archived"
	/// </summary>
	public override string MessageArchiveSuccess => "ë³´ê´€ ì™„ë£Œ";

	/// <summary>
	/// Key: "Message.DescriptionFieldEmptyError"
	/// English String: "Description cannot be empty"
	/// </summary>
	public override string MessageDescriptionFieldEmptyError => "ì„¤ëª…ì„ ìž…ë ¥í•˜ì…”ì•¼ í•©ë‹ˆë‹¤";

	/// <summary>
	/// Key: "Message.DescriptionTooLongError"
	/// error message
	/// English String: "The description is too long."
	/// </summary>
	public override string MessageDescriptionTooLongError => "ì„¤ëª…ì´ ë„ˆë¬´ ê¸¸ì–´ìš”.";

	/// <summary>
	/// Key: "Message.FilteringServiceUnavailableError"
	/// error message
	/// English String: "Text filtering service is unavailable at this time."
	/// </summary>
	public override string MessageFilteringServiceUnavailableError => "ì§€ê¸ˆì€ í…ìŠ¤íŠ¸ í•„í„°ë§ ì„œë¹„ìŠ¤ë¥¼ ì´ìš©í•  ìˆ˜ ì—†ìŠµë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Message.GamePassConfigDisabledError"
	/// error message
	/// English String: "Game Pass configuration is not enabled yet."
	/// </summary>
	public override string MessageGamePassConfigDisabledError => "ê²Œìž„íŒ¨ìŠ¤ êµ¬ì„±ì´ ì•„ì§ í™œì„±í™”ë˜ì§€ ì•Šì•˜ì–´ìš”.";

	/// <summary>
	/// Key: "Message.GamePassNotFoundError"
	/// errormessage
	/// English String: "The Game Pass does not exist."
	/// </summary>
	public override string MessageGamePassNotFoundError => "ê²Œìž„íŒ¨ìŠ¤ê°€ ì—†ì–´ìš”.";

	/// <summary>
	/// Key: "Message.IconUpdateFailed"
	/// error message
	/// English String: "Failed to update icon."
	/// </summary>
	public override string MessageIconUpdateFailed => "ì•„ì´ì½˜ ì—…ë°ì´íŠ¸ ì‹¤íŒ¨.";

	/// <summary>
	/// Key: "Message.ImageSavingFailedError"
	/// error message
	/// English String: "Failed to save image. Please try again later."
	/// </summary>
	public override string MessageImageSavingFailedError => "ì´ë¯¸ì§€ ì €ìž¥ ì‹¤íŒ¨. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•´ ì£¼ì„¸ìš”.";

	/// <summary>
	/// Key: "Message.InappropriateTextError"
	/// error message
	/// English String: "The name or description contains inappropriate text."
	/// </summary>
	public override string MessageInappropriateTextError => "ì´ë¦„ ë˜ëŠ” ì„¤ëª…ì— ë¶€ì ì ˆí•œ í…ìŠ¤íŠ¸ê°€ í¬í•¨ë˜ì–´ ìžˆì–´ìš”.";

	/// <summary>
	/// Key: "Message.NameFieldEmpty"
	/// English String: "Name cannot be empty"
	/// </summary>
	public override string MessageNameFieldEmpty => "ì´ë¦„ì„ ìž…ë ¥í•˜ì…”ì•¼ í•©ë‹ˆë‹¤";

	/// <summary>
	/// Key: "Message.NameRequiredError"
	/// error message
	/// English String: "The name cannot be empty."
	/// </summary>
	public override string MessageNameRequiredError => "ì´ë¦„ì„ ìž…ë ¥í•˜ì…”ì•¼ í•©ë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Message.NoTagsFound"
	/// English String: "No tags found"
	/// </summary>
	public override string MessageNoTagsFound => "íƒœê·¸ë¥¼ ì°¾ì„ ìˆ˜ ì—†ìŠµë‹ˆë‹¤";

	/// <summary>
	/// Key: "Message.RestoreError"
	/// English String: "Failed to restore"
	/// </summary>
	public override string MessageRestoreError => "ë³µì› ì‹¤íŒ¨";

	/// <summary>
	/// Key: "Message.RestoreSuccess"
	/// English String: "Successfully restored"
	/// </summary>
	public override string MessageRestoreSuccess => "ë³µì› ì™„ë£Œ";

	/// <summary>
	/// Key: "Message.SaveError"
	/// English String: "Something failed. Please try again later"
	/// </summary>
	public override string MessageSaveError => "ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”";

	/// <summary>
	/// Key: "Message.TooManyUploads"
	/// error message
	/// English String: "You are uploading too much. Please try again later."
	/// </summary>
	public override string MessageTooManyUploads => "ì—…ë¡œë“œê°€ ë„ˆë¬´ ë§Žì•„ìš”. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Message.UpdatePriceError"
	/// English String: "Failed to update price"
	/// </summary>
	public override string MessageUpdatePriceError => "ê°€ê²© ì—…ë°ì´íŠ¸ ì‹¤íŒ¨";

	/// <summary>
	/// Key: "Message.UpdatePriceSuccess"
	/// English String: "Successfully updated price"
	/// </summary>
	public override string MessageUpdatePriceSuccess => "ê°€ê²© ì—…ë°ì´íŠ¸ ì™„ë£Œ";

	/// <summary>
	/// Key: "Message.UpdateSuccess"
	/// English String: "Successfully updated"
	/// </summary>
	public override string MessageUpdateSuccess => "ì—…ë°ì´íŠ¸ ì™„ë£Œ";

	public ItemConfigurationResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	/// <summary>
	/// Key: "Description.AcceptableFileFormats"
	/// English String: "* Acceptable file formats: {fileExtensions}"
	/// </summary>
	public override string DescriptionAcceptableFileFormats(string fileExtensions)
	{
		return $"ê°€ëŠ¥í•œ íŒŒì¼ í˜•ì‹: {fileExtensions}";
	}

	protected override string _GetTemplateForDescriptionAcceptableFileFormats()
	{
		return "ê°€ëŠ¥í•œ íŒŒì¼ í˜•ì‹: {fileExtensions}";
	}

	/// <summary>
	/// Key: "Description.AcceptableFiles"
	/// English String: "* Acceptable files{lineBreak}Format: {fileExtensions}   |   Size: {fileSizes}"
	/// </summary>
	public override string DescriptionAcceptableFiles(string lineBreak, string fileExtensions, string fileSizes)
	{
		return $"* í—ˆìš©ë˜ëŠ” íŒŒì¼{lineBreak}í˜•ì‹: {fileExtensions}   |   í¬ê¸°: {fileSizes}";
	}

	protected override string _GetTemplateForDescriptionAcceptableFiles()
	{
		return "* í—ˆìš©ë˜ëŠ” íŒŒì¼{lineBreak}í˜•ì‹: {fileExtensions}   |   í¬ê¸°: {fileSizes}";
	}

	protected override string _GetTemplateForDescriptionAllowCopying()
	{
		return "ë³¸ í™•ì¸ëž€ì„ ì„ íƒí•˜ë©´ íšŒì›ë‹˜ì´ ì§€ê¸ˆ ê³µìœ í•˜ë ¤ëŠ” ì½˜í…ì¸ ë¥¼ Robloxì˜ ëª¨ë“  ì‚¬ìš©ìžê°€ ë‹¤ì–‘í•œ ë°©ì‹ìœ¼ë¡œ ì‚¬ìš©í•  ìˆ˜ ìžˆê²Œ ë©ë‹ˆë‹¤. ì‚¬ìš©ì„ í—ˆë½í•˜ì§€ ì•Šìœ¼ë ¤ë©´ í™•ì¸ëž€ì„ ì„ íƒí•˜ì§€ ë§ˆì„¸ìš”. ì½˜í…ì¸  ê³µìœ ì— ê´€í•œ ìžì„¸í•œ ì •ë³´ëŠ” Roblox ì´ìš© ì•½ê´€ì„ ì°¸ê³ í•˜ì„¸ìš”.";
	}

	/// <summary>
	/// Key: "Description.AllowCopyingWarning"
	/// English String: "By switching on, you are granting every other user of Roblox the right to use (in various ways) the content you are now sharing. If you do not want to grant this right, please do not check this box. For more information about sharing content, please review the Roblox {linkStart}Terms of Use{linkEnd}."
	/// </summary>
	public override string DescriptionAllowCopyingWarning(string linkStart, string linkEnd)
	{
		return $"ë³¸ í™•ì¸ëž€ì„ ì„ íƒí•˜ë©´ íšŒì›ë‹˜ì´ ì§€ê¸ˆ ê³µìœ í•˜ë ¤ëŠ” ì½˜í…ì¸ ë¥¼ Robloxì˜ ëª¨ë“  ì‚¬ìš©ìžê°€ ë‹¤ì–‘í•œ ë°©ì‹ìœ¼ë¡œ ì‚¬ìš©í•  ìˆ˜ ìžˆê²Œ ë©ë‹ˆë‹¤. ì‚¬ìš©ì„ í—ˆë½í•˜ì§€ ì•Šìœ¼ë ¤ë©´ í™•ì¸ëž€ì„ ì„ íƒí•˜ì§€ ë§ˆì„¸ìš”. ì½˜í…ì¸  ê³µìœ ì— ê´€í•œ ìžì„¸í•œ ì •ë³´ëŠ” Roblox {linkStart}ì´ìš© ì•½ê´€{linkEnd}ì„ ì°¸ê³ í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForDescriptionAllowCopyingWarning()
	{
		return "ë³¸ í™•ì¸ëž€ì„ ì„ íƒí•˜ë©´ íšŒì›ë‹˜ì´ ì§€ê¸ˆ ê³µìœ í•˜ë ¤ëŠ” ì½˜í…ì¸ ë¥¼ Robloxì˜ ëª¨ë“  ì‚¬ìš©ìžê°€ ë‹¤ì–‘í•œ ë°©ì‹ìœ¼ë¡œ ì‚¬ìš©í•  ìˆ˜ ìžˆê²Œ ë©ë‹ˆë‹¤. ì‚¬ìš©ì„ í—ˆë½í•˜ì§€ ì•Šìœ¼ë ¤ë©´ í™•ì¸ëž€ì„ ì„ íƒí•˜ì§€ ë§ˆì„¸ìš”. ì½˜í…ì¸  ê³µìœ ì— ê´€í•œ ìžì„¸í•œ ì •ë³´ëŠ” Roblox {linkStart}ì´ìš© ì•½ê´€{linkEnd}ì„ ì°¸ê³ í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForDescriptionArchiveWarning()
	{
		return "ì• ì…‹ì„ ë³´ê´€í•˜ë©´ ê²Œìž„ì—ì„œ ì‚¬ìš©í•  ìˆ˜ ì—†ì–´ìš”. ë³´ê´€í–ˆë˜ ì• ì…‹ì€ ë‚˜ì¤‘ì— ë³µì› ê°€ëŠ¥í•´ìš”.";
	}

	protected override string _GetTemplateForDescriptionClickToAddTag()
	{
		return "íƒœê·¸ë¥¼ ì¶”ê°€í•˜ë ¤ë©´ í´ë¦­";
	}

	/// <summary>
	/// Key: "Description.MarketplaceExplanation"
	/// English String: "(Roblox takes {marketplaceFeePercentage}%, minimum {minimumPrice})"
	/// </summary>
	public override string DescriptionMarketplaceExplanation(string marketplaceFeePercentage, string minimumPrice)
	{
		return $"(Roblox ìˆ˜ìˆ˜ë£Œ: {marketplaceFeePercentage}%, ê¸°ë³¸ ê°€ê²©: {minimumPrice})";
	}

	protected override string _GetTemplateForDescriptionMarketplaceExplanation()
	{
		return "(Roblox ìˆ˜ìˆ˜ë£Œ: {marketplaceFeePercentage}%, ê¸°ë³¸ ê°€ê²©: {minimumPrice})";
	}

	protected override string _GetTemplateForDescriptionModeratorFileReview()
	{
		return "* ì—…ë¡œë“œí•œ íŒŒì¼ì€ ê²€ì—´íŒ€ì˜ ê²€í† ê°€ ëë‚œ í›„ì— ë‹¤ë¥¸ ì‚¬ìš©ìžì—ê²Œ ê³µê°œë©ë‹ˆë‹¤";
	}

	protected override string _GetTemplateForDescriptionModeratorReview()
	{
		return "* ì—…ë¡œë“œí•œ ì´ë¯¸ì§€ëŠ” ê²€ì—´íŒ€ì˜ ê²€í† ê°€ ëë‚œ í›„ì— ë‹¤ë¥¸ ì‚¬ìš©ìžì—ê²Œ ê³µê°œë©ë‹ˆë‹¤";
	}

	/// <summary>
	/// Key: "Description.SelectItemTags"
	/// itemTagLimit is the number of item tags allowed
	/// English String: "Select up to {itemTagLimit} tags."
	/// </summary>
	public override string DescriptionSelectItemTags(string itemTagLimit)
	{
		return $"íƒœê·¸ë¥¼ {itemTagLimit}ê°œê¹Œì§€ ì„ íƒí•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForDescriptionSelectItemTags()
	{
		return "íƒœê·¸ë¥¼ {itemTagLimit}ê°œê¹Œì§€ ì„ íƒí•˜ì„¸ìš”.";
	}

	public override string DescriptionVerifiedCreatorEmail(string linkStart, string linkEnd)
	{
		return $"ì½˜í…ì¸ ë¥¼ ìž¥í„°ì—ì„œ ê³µìœ í•˜ë ¤ë©´, ê³„ì •ì— ì´ë©”ì¼ ì£¼ì†Œë¥¼ ì¶”ê°€í•˜ê³  ì¸ì¦í•´ì•¼ í•©ë‹ˆë‹¤. {linkStart}ê³„ì • ì„¤ì •{linkEnd}ì—ì„œ ê°€ëŠ¥í•©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForDescriptionVerifiedCreatorEmail()
	{
		return "ì½˜í…ì¸ ë¥¼ ìž¥í„°ì—ì„œ ê³µìœ í•˜ë ¤ë©´, ê³„ì •ì— ì´ë©”ì¼ ì£¼ì†Œë¥¼ ì¶”ê°€í•˜ê³  ì¸ì¦í•´ì•¼ í•©ë‹ˆë‹¤. {linkStart}ê³„ì • ì„¤ì •{linkEnd}ì—ì„œ ê°€ëŠ¥í•©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForHeadingArchive()
	{
		return "ë³´ê´€";
	}

	protected override string _GetTemplateForHeadingConfigure()
	{
		return "êµ¬ì„±";
	}

	/// <summary>
	/// Key: "Heading.ConfigureItem"
	/// English String: "Configure {itemType}"
	/// </summary>
	public override string HeadingConfigureItem(string itemType)
	{
		return $"{itemType} êµ¬ì„±";
	}

	protected override string _GetTemplateForHeadingConfigureItem()
	{
		return "{itemType} êµ¬ì„±";
	}

	protected override string _GetTemplateForHeadingConfigureItemTags()
	{
		return "íƒœê·¸ êµ¬ì„±";
	}

	protected override string _GetTemplateForHeadingCreate()
	{
		return "ë§Œë“¤ê¸°";
	}

	protected override string _GetTemplateForHeadingSettings()
	{
		return "ì„¤ì •";
	}

	protected override string _GetTemplateForLabelAllowCopying()
	{
		return "ë³µì‚¬ í—ˆìš©";
	}

	protected override string _GetTemplateForLabelArchive()
	{
		return "ë³´ê´€";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "ì·¨ì†Œ";
	}

	protected override string _GetTemplateForLabelComputer()
	{
		return "ì»´í“¨í„°";
	}

	protected override string _GetTemplateForLabelCreated()
	{
		return "ê°œë°œ ì™„ë£Œ";
	}

	protected override string _GetTemplateForLabelCurrent()
	{
		return "í˜„ìž¬";
	}

	protected override string _GetTemplateForLabelCurrentPublishedVersion()
	{
		return "í˜„ìž¬ ê²Œì‹œ ë²„ì „";
	}

	protected override string _GetTemplateForLabelDescription()
	{
		return "ì„¤ëª…";
	}

	protected override string _GetTemplateForLabelDevice()
	{
		return "ê¸°ê¸°";
	}

	protected override string _GetTemplateForLabelEnterItemTag()
	{
		return "ì—¬ê¸°ì— íƒœê·¸ë¥¼ ìž…ë ¥í•˜ì„¸ìš”...";
	}

	/// <summary>
	/// Key: "Label.ForItem"
	/// English String: "For {itemType}"
	/// </summary>
	public override string LabelForItem(string itemType)
	{
		return $"{itemType}";
	}

	protected override string _GetTemplateForLabelForItem()
	{
		return "{itemType}";
	}

	protected override string _GetTemplateForLabelGame()
	{
		return "ê²Œìž„";
	}

	protected override string _GetTemplateForLabelGamePass()
	{
		return "ê²Œìž„íŒ¨ìŠ¤";
	}

	protected override string _GetTemplateForLabelGeneral()
	{
		return "ì¼ë°˜";
	}

	protected override string _GetTemplateForLabelGoToDetails()
	{
		return "'ì„¤ëª…'ìœ¼ë¡œ ì´ë™";
	}

	protected override string _GetTemplateForLabelItemActive()
	{
		return "ì•„ì´í…œì´ í™œì„±í™” ìƒíƒœìž…ë‹ˆë‹¤";
	}

	protected override string _GetTemplateForLabelItemForSale()
	{
		return "íŒë§¤ ì•„ì´í…œ";
	}

	protected override string _GetTemplateForLabelLastUpdated()
	{
		return "ìµœì‹  ì—…ë°ì´íŠ¸";
	}

	protected override string _GetTemplateForLabelLearnMore()
	{
		return "ë” ì•Œì•„ë³´ê¸°";
	}

	protected override string _GetTemplateForLabelMarketplaceFee()
	{
		return "ìž¥í„° ìˆ˜ìˆ˜ë£Œ";
	}

	protected override string _GetTemplateForLabelName()
	{
		return "ì´ë¦„";
	}

	protected override string _GetTemplateForLabelOpenForComments()
	{
		return "ì½”ë©˜íŠ¸ ì—´ê¸°";
	}

	protected override string _GetTemplateForLabelPreview()
	{
		return "ë¯¸ë¦¬ë³´ê¸°";
	}

	protected override string _GetTemplateForLabelPrice()
	{
		return "ê°€ê²©";
	}

	protected override string _GetTemplateForLabelProfit()
	{
		return "íšë“:";
	}

	protected override string _GetTemplateForLabelRestore()
	{
		return "ë³µì›";
	}

	protected override string _GetTemplateForLabelRevertVersion()
	{
		return "ì´ ë²„ì „ìœ¼ë¡œ ë³µêµ¬";
	}

	protected override string _GetTemplateForLabelSales()
	{
		return "íŒë§¤";
	}

	protected override string _GetTemplateForLabelSave()
	{
		return "ì €ìž¥";
	}

	protected override string _GetTemplateForLabelSelectType()
	{
		return "ì¢…ë¥˜ ì„ íƒí•˜ê¸°";
	}

	protected override string _GetTemplateForLabelTags()
	{
		return "íƒœê·¸";
	}

	protected override string _GetTemplateForLabelType()
	{
		return "ì¢…ë¥˜";
	}

	protected override string _GetTemplateForLabelUpdated()
	{
		return "ì—…ë°ì´íŠ¸ ì™„ë£Œ";
	}

	protected override string _GetTemplateForLabelVersion()
	{
		return "ë²„ì „";
	}

	protected override string _GetTemplateForLabelVersions()
	{
		return "ë²„ì „";
	}

	protected override string _GetTemplateForMessageArchiveError()
	{
		return "ë³´ê´€ ì‹¤íŒ¨";
	}

	protected override string _GetTemplateForMessageArchiveSuccess()
	{
		return "ë³´ê´€ ì™„ë£Œ";
	}

	/// <summary>
	/// Key: "Message.DescriptionFieldEmpty"
	/// English String: "{maxDescriptionLength} character limit"
	/// </summary>
	public override string MessageDescriptionFieldEmpty(string maxDescriptionLength)
	{
		return $"{maxDescriptionLength}ìž ì œí•œ";
	}

	protected override string _GetTemplateForMessageDescriptionFieldEmpty()
	{
		return "{maxDescriptionLength}ìž ì œí•œ";
	}

	protected override string _GetTemplateForMessageDescriptionFieldEmptyError()
	{
		return "ì„¤ëª…ì„ ìž…ë ¥í•˜ì…”ì•¼ í•©ë‹ˆë‹¤";
	}

	/// <summary>
	/// Key: "Message.DescriptionFieldPopulated"
	/// English String: "{descriptionLength}/{maxDescriptionLength} characters"
	/// </summary>
	public override string MessageDescriptionFieldPopulated(string descriptionLength, string maxDescriptionLength)
	{
		return $"{descriptionLength}/{maxDescriptionLength}ìž";
	}

	protected override string _GetTemplateForMessageDescriptionFieldPopulated()
	{
		return "{descriptionLength}/{maxDescriptionLength}ìž";
	}

	protected override string _GetTemplateForMessageDescriptionTooLongError()
	{
		return "ì„¤ëª…ì´ ë„ˆë¬´ ê¸¸ì–´ìš”.";
	}

	protected override string _GetTemplateForMessageFilteringServiceUnavailableError()
	{
		return "ì§€ê¸ˆì€ í…ìŠ¤íŠ¸ í•„í„°ë§ ì„œë¹„ìŠ¤ë¥¼ ì´ìš©í•  ìˆ˜ ì—†ìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForMessageGamePassConfigDisabledError()
	{
		return "ê²Œìž„íŒ¨ìŠ¤ êµ¬ì„±ì´ ì•„ì§ í™œì„±í™”ë˜ì§€ ì•Šì•˜ì–´ìš”.";
	}

	protected override string _GetTemplateForMessageGamePassNotFoundError()
	{
		return "ê²Œìž„íŒ¨ìŠ¤ê°€ ì—†ì–´ìš”.";
	}

	protected override string _GetTemplateForMessageIconUpdateFailed()
	{
		return "ì•„ì´ì½˜ ì—…ë°ì´íŠ¸ ì‹¤íŒ¨.";
	}

	protected override string _GetTemplateForMessageImageSavingFailedError()
	{
		return "ì´ë¯¸ì§€ ì €ìž¥ ì‹¤íŒ¨. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•´ ì£¼ì„¸ìš”.";
	}

	protected override string _GetTemplateForMessageInappropriateTextError()
	{
		return "ì´ë¦„ ë˜ëŠ” ì„¤ëª…ì— ë¶€ì ì ˆí•œ í…ìŠ¤íŠ¸ê°€ í¬í•¨ë˜ì–´ ìžˆì–´ìš”.";
	}

	/// <summary>
	/// Key: "Message.MinimumPrice"
	/// English String: "You cannot set a price below the minimum price of {minimumPrice}"
	/// </summary>
	public override string MessageMinimumPrice(string minimumPrice)
	{
		return $"ìµœì € ê°€ê²©ì¸ {minimumPrice} ë¯¸ë§Œìœ¼ë¡œ ê°€ê²©ì„ ì„¤ì •í•  ìˆ˜ ì—†ì–´ìš”";
	}

	protected override string _GetTemplateForMessageMinimumPrice()
	{
		return "ìµœì € ê°€ê²©ì¸ {minimumPrice} ë¯¸ë§Œìœ¼ë¡œ ê°€ê²©ì„ ì„¤ì •í•  ìˆ˜ ì—†ì–´ìš”";
	}

	protected override string _GetTemplateForMessageNameFieldEmpty()
	{
		return "ì´ë¦„ì„ ìž…ë ¥í•˜ì…”ì•¼ í•©ë‹ˆë‹¤";
	}

	/// <summary>
	/// Key: "Message.NameFieldPopulated"
	/// English String: "{nameLength}/{maxNameLength} characters"
	/// </summary>
	public override string MessageNameFieldPopulated(string nameLength, string maxNameLength)
	{
		return $"{nameLength}/{maxNameLength}ìž";
	}

	protected override string _GetTemplateForMessageNameFieldPopulated()
	{
		return "{nameLength}/{maxNameLength}ìž";
	}

	protected override string _GetTemplateForMessageNameRequiredError()
	{
		return "ì´ë¦„ì„ ìž…ë ¥í•˜ì…”ì•¼ í•©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForMessageNoTagsFound()
	{
		return "íƒœê·¸ë¥¼ ì°¾ì„ ìˆ˜ ì—†ìŠµë‹ˆë‹¤";
	}

	protected override string _GetTemplateForMessageRestoreError()
	{
		return "ë³µì› ì‹¤íŒ¨";
	}

	protected override string _GetTemplateForMessageRestoreSuccess()
	{
		return "ë³µì› ì™„ë£Œ";
	}

	/// <summary>
	/// Key: "Message.RevertError"
	/// English String: "Failed to revert to version {versionNumber}"
	/// </summary>
	public override string MessageRevertError(string versionNumber)
	{
		return $"ë²„ì „ {versionNumber}(ìœ¼)ë¡œ ë³µêµ¬í•˜ëŠ” ë° ì‹¤íŒ¨í–ˆì–´ìš”";
	}

	protected override string _GetTemplateForMessageRevertError()
	{
		return "ë²„ì „ {versionNumber}(ìœ¼)ë¡œ ë³µêµ¬í•˜ëŠ” ë° ì‹¤íŒ¨í–ˆì–´ìš”";
	}

	/// <summary>
	/// Key: "Message.RevertSuccess"
	/// English String: "Successfully reverted to version {versionNumber}"
	/// </summary>
	public override string MessageRevertSuccess(string versionNumber)
	{
		return $"ë²„ì „ {versionNumber}(ìœ¼)ë¡œ ë¬´ì‚¬ížˆ ë³µêµ¬í–ˆì–´ìš”";
	}

	protected override string _GetTemplateForMessageRevertSuccess()
	{
		return "ë²„ì „ {versionNumber}(ìœ¼)ë¡œ ë¬´ì‚¬ížˆ ë³µêµ¬í–ˆì–´ìš”";
	}

	protected override string _GetTemplateForMessageSaveError()
	{
		return "ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”";
	}

	protected override string _GetTemplateForMessageTooManyUploads()
	{
		return "ì—…ë¡œë“œê°€ ë„ˆë¬´ ë§Žì•„ìš”. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForMessageUpdatePriceError()
	{
		return "ê°€ê²© ì—…ë°ì´íŠ¸ ì‹¤íŒ¨";
	}

	protected override string _GetTemplateForMessageUpdatePriceSuccess()
	{
		return "ê°€ê²© ì—…ë°ì´íŠ¸ ì™„ë£Œ";
	}

	protected override string _GetTemplateForMessageUpdateSuccess()
	{
		return "ì—…ë°ì´íŠ¸ ì™„ë£Œ";
	}
}


}
