namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides ItemConfigurationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ItemConfigurationResources_ja_jp : ItemConfigurationResources_en_us, IItemConfigurationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Description.AllowCopying"
	/// English String: "By switching on, you are granting every other user of Roblox the right to use (in various ways) the content you are now sharing. If you do not want to grant this right, please do not check this box. For more information about sharing content, please review the Roblox Terms of Use."
	/// </summary>
	public override string DescriptionAllowCopying => "ã‚ªãƒ³ã«ã™ã‚‹ã“ã¨ã§ã€ä»–ã®ã™ã¹ã¦ã®Robloxãƒ¦ãƒ¼ã‚¶ãƒ¼ã«å¯¾ã—ã¦ã€ç¾åœ¨ã‚·ã‚§ã‚¢ã—ã¦ã„ã‚‹ã‚³ãƒ³ãƒ†ãƒ³ãƒ„ã‚’ï¼ˆã•ã¾ã–ã¾ãªæ–¹æ³•ã§ï¼‰ä½¿ç”¨ã™ã‚‹æ¨©åˆ©ã‚’ä¸Žãˆã‚‹ã“ã¨ã«åŒæ„ã—ãŸã‚‚ã®ã¨ã¿ãªã•ã‚Œã¾ã™ã€‚æ¨©åˆ©ã‚’ä¸Žãˆã‚‹ã“ã¨ã«åŒæ„ã—ãªã„å ´åˆã€ã“ã®ãƒœãƒƒã‚¯ã‚¹ã®ãƒã‚§ãƒƒã‚¯ã‚’å¤–ã—ã¦ãã ã•ã„ã€‚ã‚³ãƒ³ãƒ†ãƒ³ãƒ„ã®ã‚·ã‚§ã‚¢ã«ã¤ã„ã¦ã®è©³ç´°ã¯ã€Robloxã®åˆ©ç”¨è¦ç´„ã‚’ç¢ºèªã—ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Description.ArchiveWarning"
	/// English String: "Archiving this asset will prevent it from being used in game. Archived assets can be restored."
	/// </summary>
	public override string DescriptionArchiveWarning => "ã‚¢ã‚»ãƒƒãƒˆã‚’ã‚¢ãƒ¼ã‚«ã‚¤ãƒ–ã™ã‚‹ã¨ã‚²ãƒ¼ãƒ ãŒãƒ—ãƒ¬ã‚¤ã§ããªããªã‚Šã¾ã™ã€‚ã‚¢ãƒ¼ã‚«ã‚¤ãƒ–æ¸ˆã¿ã®ã‚¢ã‚»ãƒƒãƒˆã¯å¾©å…ƒã§ãã¾ã™ã€‚";

	/// <summary>
	/// Key: "Description.ClickToAddTag"
	/// Hover text on the button that adds a tag to an item
	/// English String: "Click to add tag"
	/// </summary>
	public override string DescriptionClickToAddTag => "ã‚¯ãƒªãƒƒã‚¯ã—ã¦ã‚¿ã‚°ã‚’è¿½åŠ ";

	/// <summary>
	/// Key: "Description.ModeratorFileReview"
	/// English String: "* Uploaded file will be reviewed by moderators before being made visible to other users"
	/// </summary>
	public override string DescriptionModeratorFileReview => "* ã‚¢ãƒƒãƒ—ãƒ­ãƒ¼ãƒ‰ã—ãŸç”»åƒã¯ã€ãƒ¢ãƒ‡ãƒ¬ãƒ¼ã‚¿ã«ã‚ˆã‚‹ãƒ¬ãƒ“ãƒ¥ãƒ¼å¾Œã€ä»–ã®ãƒ¦ãƒ¼ã‚¶ãƒ¼ã«å…¬é–‹ã•ã‚Œã¾ã™";

	/// <summary>
	/// Key: "Description.ModeratorReview"
	/// English String: "* Uploaded image will be reviewed by moderators before being made visible to other users"
	/// </summary>
	public override string DescriptionModeratorReview => "* ã‚¢ãƒƒãƒ—ãƒ­ãƒ¼ãƒ‰ã—ãŸç”»åƒã¯ã€ãƒ¢ãƒ‡ãƒ¬ãƒ¼ã‚¿ã«ã‚ˆã‚‹ãƒ¬ãƒ“ãƒ¥ãƒ¼å¾Œã€ä»–ã®ãƒ¦ãƒ¼ã‚¶ãƒ¼ã«å…¬é–‹ã•ã‚Œã¾ã™";

	/// <summary>
	/// Key: "Heading.Archive"
	/// header text for section about archiving assets
	/// English String: "Archive"
	/// </summary>
	public override string HeadingArchive => "ã‚¢ãƒ¼ã‚«ã‚¤ãƒ–";

	/// <summary>
	/// Key: "Heading.Configure"
	/// English String: "Configure"
	/// </summary>
	public override string HeadingConfigure => "ç’°å¢ƒè¨­å®šã™ã‚‹";

	/// <summary>
	/// Key: "Heading.ConfigureItemTags"
	/// Heading on Configure Tags modal
	/// English String: "Configure Tags"
	/// </summary>
	public override string HeadingConfigureItemTags => "ã‚¿ã‚°ã‚’ç’°å¢ƒè¨­å®šã™ã‚‹";

	/// <summary>
	/// Key: "Heading.Create"
	/// English String: "Create"
	/// </summary>
	public override string HeadingCreate => "ä½œæˆ";

	/// <summary>
	/// Key: "Heading.Settings"
	/// English String: "Settings"
	/// </summary>
	public override string HeadingSettings => "è¨­å®š";

	/// <summary>
	/// Key: "Label.AllowCopying"
	/// English String: "Allow Copying"
	/// </summary>
	public override string LabelAllowCopying => "ã‚³ãƒ”ãƒ¼ã‚’è¨±å¯";

	/// <summary>
	/// Key: "Label.Archive"
	/// Text on button for archiving an asset. Part of speech: verb
	/// English String: "Archive"
	/// </summary>
	public override string LabelArchive => "ã‚¢ãƒ¼ã‚«ã‚¤ãƒ–";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "ã‚­ãƒ£ãƒ³ã‚»ãƒ«";

	/// <summary>
	/// Key: "Label.Computer"
	/// computer term
	/// English String: "Computer"
	/// </summary>
	public override string LabelComputer => "ãƒ‘ã‚½ã‚³ãƒ³";

	/// <summary>
	/// Key: "Label.Created"
	/// English String: "Created"
	/// </summary>
	public override string LabelCreated => "ä½œæˆã—ã¾ã—ãŸ";

	/// <summary>
	/// Key: "Label.Current"
	/// English String: "Current"
	/// </summary>
	public override string LabelCurrent => "ç¾åœ¨ã®ã‚‚ã®";

	/// <summary>
	/// Key: "Label.CurrentPublishedVersion"
	/// English String: "Current published version"
	/// </summary>
	public override string LabelCurrentPublishedVersion => "ç¾åœ¨å…¬é–‹æ¸ˆã¿ã®ãƒãƒ¼ã‚¸ãƒ§ãƒ³";

	/// <summary>
	/// Key: "Label.Description"
	/// English String: "Description"
	/// </summary>
	public override string LabelDescription => "è©³ç´°";

	/// <summary>
	/// Key: "Label.Device"
	/// device term
	/// English String: "Device"
	/// </summary>
	public override string LabelDevice => "ãƒ‡ãƒã‚¤ã‚¹";

	/// <summary>
	/// Key: "Label.EnterItemTag"
	/// Placeholder for input field
	/// English String: "Enter tag here..."
	/// </summary>
	public override string LabelEnterItemTag => "ã“ã“ã«ã‚¿ã‚°ã‚’å…¥åŠ›...";

	/// <summary>
	/// Key: "Label.Game"
	/// English String: "Game"
	/// </summary>
	public override string LabelGame => "ã‚²ãƒ¼ãƒ ";

	/// <summary>
	/// Key: "Label.GamePass"
	/// label
	/// English String: "Game Pass"
	/// </summary>
	public override string LabelGamePass => "ã‚²ãƒ¼ãƒ ãƒ‘ã‚¹";

	/// <summary>
	/// Key: "Label.General"
	/// English String: "General"
	/// </summary>
	public override string LabelGeneral => "ä¸€èˆ¬";

	/// <summary>
	/// Key: "Label.GoToDetails"
	/// Link to the item details page from the configure page
	/// English String: "Go to Details"
	/// </summary>
	public override string LabelGoToDetails => "è©³ç´°ã¸";

	/// <summary>
	/// Key: "Label.ItemActive"
	/// English String: "Item is Active"
	/// </summary>
	public override string LabelItemActive => "ã“ã®ã‚¢ã‚¤ãƒ†ãƒ ã¯ã‚¢ã‚¯ãƒ†ã‚£ãƒ–ã§ã™";

	/// <summary>
	/// Key: "Label.ItemForSale"
	/// English String: "Item for Sale"
	/// </summary>
	public override string LabelItemForSale => "è²©å£²ç”¨ã‚¢ã‚¤ãƒ†ãƒ ";

	/// <summary>
	/// Key: "Label.LastUpdated"
	/// English String: "Last Updated"
	/// </summary>
	public override string LabelLastUpdated => "æœ€çµ‚ã‚¢ãƒƒãƒ—ãƒ‡ãƒ¼ãƒˆ";

	/// <summary>
	/// Key: "Label.LearnMore"
	/// English String: "Learn more"
	/// </summary>
	public override string LabelLearnMore => "ã‚‚ã£ã¨è©³ã—ã";

	/// <summary>
	/// Key: "Label.MarketplaceFee"
	/// English String: "Marketplace Fee"
	/// </summary>
	public override string LabelMarketplaceFee => "ãƒžãƒ¼ã‚±ãƒƒãƒˆãƒ—ãƒ¬ãƒ¼ã‚¹ä½¿ç”¨æ–™";

	/// <summary>
	/// Key: "Label.Name"
	/// English String: "Name"
	/// </summary>
	public override string LabelName => "åå‰";

	/// <summary>
	/// Key: "Label.OpenForComments"
	/// English String: "Open for Comments"
	/// </summary>
	public override string LabelOpenForComments => "ã‚³ãƒ¡ãƒ³ãƒˆå¯èƒ½";

	/// <summary>
	/// Key: "Label.Preview"
	/// English String: "Preview"
	/// </summary>
	public override string LabelPreview => "ãƒ—ãƒ¬ãƒ“ãƒ¥ãƒ¼";

	/// <summary>
	/// Key: "Label.Price"
	/// English String: "Price"
	/// </summary>
	public override string LabelPrice => "ä¾¡æ ¼";

	/// <summary>
	/// Key: "Label.Profit"
	/// English String: "You Earn"
	/// </summary>
	public override string LabelProfit => "ç²å¾—:";

	/// <summary>
	/// Key: "Label.Restore"
	/// English String: "Restore"
	/// </summary>
	public override string LabelRestore => "å¾©å…ƒ";

	/// <summary>
	/// Key: "Label.RevertVersion"
	/// English String: "Revert to this version"
	/// </summary>
	public override string LabelRevertVersion => "ã“ã®ãƒãƒ¼ã‚¸ãƒ§ãƒ³ã«æˆ»ã™";

	/// <summary>
	/// Key: "Label.Sales"
	/// English String: "Sales"
	/// </summary>
	public override string LabelSales => "ã‚»ãƒ¼ãƒ«";

	/// <summary>
	/// Key: "Label.Save"
	/// English String: "Save"
	/// </summary>
	public override string LabelSave => "ä¿å­˜";

	/// <summary>
	/// Key: "Label.SelectType"
	/// Placeholder for dropdown in create asset page. Options are image, mesh, hair accessory, etc
	/// English String: "Select a type"
	/// </summary>
	public override string LabelSelectType => "ã‚¿ã‚¤ãƒ—ã‚’é¸æŠž";

	/// <summary>
	/// Key: "Label.Tags"
	/// The label next to a list of item tags in the item configuration page
	/// English String: "Tags"
	/// </summary>
	public override string LabelTags => "ã‚¿ã‚°";

	/// <summary>
	/// Key: "Label.Type"
	/// English String: "Type"
	/// </summary>
	public override string LabelType => "ã‚¿ã‚¤ãƒ—";

	/// <summary>
	/// Key: "Label.Updated"
	/// English String: "Updated"
	/// </summary>
	public override string LabelUpdated => "ã‚¢ãƒƒãƒ—ãƒ‡ãƒ¼ãƒˆæ¸ˆã¿";

	/// <summary>
	/// Key: "Label.Version"
	/// English String: "Version"
	/// </summary>
	public override string LabelVersion => "ãƒãƒ¼ã‚¸ãƒ§ãƒ³";

	/// <summary>
	/// Key: "Label.Versions"
	/// English String: "Versions"
	/// </summary>
	public override string LabelVersions => "ãƒãƒ¼ã‚¸ãƒ§ãƒ³";

	/// <summary>
	/// Key: "Message.ArchiveError"
	/// English String: "Failed to archive"
	/// </summary>
	public override string MessageArchiveError => "ã‚¢ãƒ¼ã‚«ã‚¤ãƒ–ã§ãã¾ã›ã‚“ã§ã—ãŸ";

	/// <summary>
	/// Key: "Message.ArchiveSuccess"
	/// English String: "Successfully archived"
	/// </summary>
	public override string MessageArchiveSuccess => "ã‚¢ãƒ¼ã‚«ã‚¤ãƒ–ã§ãã¾ã—ãŸ";

	/// <summary>
	/// Key: "Message.DescriptionFieldEmptyError"
	/// English String: "Description cannot be empty"
	/// </summary>
	public override string MessageDescriptionFieldEmptyError => "è©³ç´°ã¯ç©ºç™½ã«ã§ãã¾ã›ã‚“";

	/// <summary>
	/// Key: "Message.DescriptionTooLongError"
	/// error message
	/// English String: "The description is too long."
	/// </summary>
	public override string MessageDescriptionTooLongError => "è©³ç´°ãŒé•·ã™ãŽã¾ã™ã€‚";

	/// <summary>
	/// Key: "Message.FilteringServiceUnavailableError"
	/// error message
	/// English String: "Text filtering service is unavailable at this time."
	/// </summary>
	public override string MessageFilteringServiceUnavailableError => "ç¾åœ¨ãƒ•ã‚£ãƒ«ã‚¿ã‚µãƒ¼ãƒ“ã‚¹ã¯åˆ©ç”¨ã§ãã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Message.GamePassConfigDisabledError"
	/// error message
	/// English String: "Game Pass configuration is not enabled yet."
	/// </summary>
	public override string MessageGamePassConfigDisabledError => "ã‚²ãƒ¼ãƒ ãƒ‘ã‚¹ã®è¨­å®šãŒæœ‰åŠ¹ã«ãªã£ã¦ã„ã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Message.GamePassNotFoundError"
	/// errormessage
	/// English String: "The Game Pass does not exist."
	/// </summary>
	public override string MessageGamePassNotFoundError => "ã‚²ãƒ¼ãƒ ãƒ‘ã‚¹ãŒå­˜åœ¨ã—ã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Message.IconUpdateFailed"
	/// error message
	/// English String: "Failed to update icon."
	/// </summary>
	public override string MessageIconUpdateFailed => "ã‚¢ã‚¤ã‚³ãƒ³ã‚’ã‚¢ãƒƒãƒ—ãƒ‡ãƒ¼ãƒˆã§ãã¾ã›ã‚“ã§ã—ãŸã€‚";

	/// <summary>
	/// Key: "Message.ImageSavingFailedError"
	/// error message
	/// English String: "Failed to save image. Please try again later."
	/// </summary>
	public override string MessageImageSavingFailedError => "ç”»åƒã‚’ä¿å­˜ã§ãã¾ã›ã‚“ã€‚å¾Œã§ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Message.InappropriateTextError"
	/// error message
	/// English String: "The name or description contains inappropriate text."
	/// </summary>
	public override string MessageInappropriateTextError => "åå‰ã¾ãŸã¯è©³ç´°ã«ä¸é©åˆ‡ãªãƒ†ã‚­ã‚¹ãƒˆãŒå«ã¾ã‚Œã¦ã„ã¾ã™ã€‚";

	/// <summary>
	/// Key: "Message.NameFieldEmpty"
	/// English String: "Name cannot be empty"
	/// </summary>
	public override string MessageNameFieldEmpty => "åå‰ã¯ç©ºç™½ã«ã§ãã¾ã›ã‚“";

	/// <summary>
	/// Key: "Message.NameRequiredError"
	/// error message
	/// English String: "The name cannot be empty."
	/// </summary>
	public override string MessageNameRequiredError => "åå‰ã¯ç©ºç™½ã«ã§ãã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Message.NoTagsFound"
	/// English String: "No tags found"
	/// </summary>
	public override string MessageNoTagsFound => "ã‚¿ã‚°ãŒè¦‹ã¤ã‹ã‚Šã¾ã›ã‚“";

	/// <summary>
	/// Key: "Message.RestoreError"
	/// English String: "Failed to restore"
	/// </summary>
	public override string MessageRestoreError => "å¾©å…ƒã§ãã¾ã›ã‚“ã§ã—ãŸ";

	/// <summary>
	/// Key: "Message.RestoreSuccess"
	/// English String: "Successfully restored"
	/// </summary>
	public override string MessageRestoreSuccess => "å¾©å…ƒã§ãã¾ã—ãŸ";

	/// <summary>
	/// Key: "Message.SaveError"
	/// English String: "Something failed. Please try again later"
	/// </summary>
	public override string MessageSaveError => "å•é¡ŒãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚å¾Œã§ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Message.TooManyUploads"
	/// error message
	/// English String: "You are uploading too much. Please try again later."
	/// </summary>
	public override string MessageTooManyUploads => "ã‚¢ãƒƒãƒ—ãƒ­ãƒ¼ãƒ‰å›žæ•°ãŒå¤šã™ãŽã¾ã™ã€‚å¾Œã§ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Message.UpdatePriceError"
	/// English String: "Failed to update price"
	/// </summary>
	public override string MessageUpdatePriceError => "ä¾¡æ ¼ã‚’ã‚¢ãƒƒãƒ—ãƒ‡ãƒ¼ãƒˆã§ãã¾ã›ã‚“ã§ã—ãŸ";

	/// <summary>
	/// Key: "Message.UpdatePriceSuccess"
	/// English String: "Successfully updated price"
	/// </summary>
	public override string MessageUpdatePriceSuccess => "ä¾¡æ ¼ã‚’ã‚¢ãƒƒãƒ—ãƒ‡ãƒ¼ãƒˆã§ãã¾ã—ãŸ";

	/// <summary>
	/// Key: "Message.UpdateSuccess"
	/// English String: "Successfully updated"
	/// </summary>
	public override string MessageUpdateSuccess => "ã‚¢ãƒƒãƒ—ãƒ‡ãƒ¼ãƒˆã§ãã¾ã—ãŸ";

	public ItemConfigurationResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	/// <summary>
	/// Key: "Description.AcceptableFileFormats"
	/// English String: "* Acceptable file formats: {fileExtensions}"
	/// </summary>
	public override string DescriptionAcceptableFileFormats(string fileExtensions)
	{
		return $"* ä½¿ç”¨ã§ãã‚‹ãƒ•ã‚¡ã‚¤ãƒ«å½¢å¼: {fileExtensions}";
	}

	protected override string _GetTemplateForDescriptionAcceptableFileFormats()
	{
		return "* ä½¿ç”¨ã§ãã‚‹ãƒ•ã‚¡ã‚¤ãƒ«å½¢å¼: {fileExtensions}";
	}

	/// <summary>
	/// Key: "Description.AcceptableFiles"
	/// English String: "* Acceptable files{lineBreak}Format: {fileExtensions}   |   Size: {fileSizes}"
	/// </summary>
	public override string DescriptionAcceptableFiles(string lineBreak, string fileExtensions, string fileSizes)
	{
		return $"* ä½¿ç”¨å¯èƒ½ãªãƒ•ã‚¡ã‚¤ãƒ«{lineBreak}å½¢å¼: {fileExtensions}   |   ã‚µã‚¤ã‚º: {fileSizes}";
	}

	protected override string _GetTemplateForDescriptionAcceptableFiles()
	{
		return "* ä½¿ç”¨å¯èƒ½ãªãƒ•ã‚¡ã‚¤ãƒ«{lineBreak}å½¢å¼: {fileExtensions}   |   ã‚µã‚¤ã‚º: {fileSizes}";
	}

	protected override string _GetTemplateForDescriptionAllowCopying()
	{
		return "ã‚ªãƒ³ã«ã™ã‚‹ã“ã¨ã§ã€ä»–ã®ã™ã¹ã¦ã®Robloxãƒ¦ãƒ¼ã‚¶ãƒ¼ã«å¯¾ã—ã¦ã€ç¾åœ¨ã‚·ã‚§ã‚¢ã—ã¦ã„ã‚‹ã‚³ãƒ³ãƒ†ãƒ³ãƒ„ã‚’ï¼ˆã•ã¾ã–ã¾ãªæ–¹æ³•ã§ï¼‰ä½¿ç”¨ã™ã‚‹æ¨©åˆ©ã‚’ä¸Žãˆã‚‹ã“ã¨ã«åŒæ„ã—ãŸã‚‚ã®ã¨ã¿ãªã•ã‚Œã¾ã™ã€‚æ¨©åˆ©ã‚’ä¸Žãˆã‚‹ã“ã¨ã«åŒæ„ã—ãªã„å ´åˆã€ã“ã®ãƒœãƒƒã‚¯ã‚¹ã®ãƒã‚§ãƒƒã‚¯ã‚’å¤–ã—ã¦ãã ã•ã„ã€‚ã‚³ãƒ³ãƒ†ãƒ³ãƒ„ã®ã‚·ã‚§ã‚¢ã«ã¤ã„ã¦ã®è©³ç´°ã¯ã€Robloxã®åˆ©ç”¨è¦ç´„ã‚’ç¢ºèªã—ã¦ãã ã•ã„ã€‚";
	}

	/// <summary>
	/// Key: "Description.AllowCopyingWarning"
	/// English String: "By switching on, you are granting every other user of Roblox the right to use (in various ways) the content you are now sharing. If you do not want to grant this right, please do not check this box. For more information about sharing content, please review the Roblox {linkStart}Terms of Use{linkEnd}."
	/// </summary>
	public override string DescriptionAllowCopyingWarning(string linkStart, string linkEnd)
	{
		return $"ã‚ªãƒ³ã«ã™ã‚‹ã“ã¨ã§ã€ä»–ã®ã™ã¹ã¦ã®Robloxãƒ¦ãƒ¼ã‚¶ãƒ¼ã«å¯¾ã—ã¦ã€ç¾åœ¨ã‚·ã‚§ã‚¢ã—ã¦ã„ã‚‹ã‚³ãƒ³ãƒ†ãƒ³ãƒ„ã‚’ï¼ˆã•ã¾ã–ã¾ãªæ–¹æ³•ã§ï¼‰ä½¿ç”¨ã™ã‚‹æ¨©åˆ©ã‚’ä¸Žãˆã‚‹ã“ã¨ã«åŒæ„ã—ãŸã‚‚ã®ã¨ã¿ãªã•ã‚Œã¾ã™ã€‚æ¨©åˆ©ã‚’ä¸Žãˆã‚‹ã“ã¨ã«åŒæ„ã—ãªã„å ´åˆã€ã“ã®ãƒœãƒƒã‚¯ã‚¹ã®ãƒã‚§ãƒƒã‚¯ã‚’å¤–ã—ã¦ãã ã•ã„ã€‚ã‚³ãƒ³ãƒ†ãƒ³ãƒ„ã®ã‚·ã‚§ã‚¢ã«ã¤ã„ã¦ã®è©³ç´°ã¯ã€Robloxã® {linkStart}åˆ©ç”¨è¦ç´„{linkEnd}ã‚’ç¢ºèªã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForDescriptionAllowCopyingWarning()
	{
		return "ã‚ªãƒ³ã«ã™ã‚‹ã“ã¨ã§ã€ä»–ã®ã™ã¹ã¦ã®Robloxãƒ¦ãƒ¼ã‚¶ãƒ¼ã«å¯¾ã—ã¦ã€ç¾åœ¨ã‚·ã‚§ã‚¢ã—ã¦ã„ã‚‹ã‚³ãƒ³ãƒ†ãƒ³ãƒ„ã‚’ï¼ˆã•ã¾ã–ã¾ãªæ–¹æ³•ã§ï¼‰ä½¿ç”¨ã™ã‚‹æ¨©åˆ©ã‚’ä¸Žãˆã‚‹ã“ã¨ã«åŒæ„ã—ãŸã‚‚ã®ã¨ã¿ãªã•ã‚Œã¾ã™ã€‚æ¨©åˆ©ã‚’ä¸Žãˆã‚‹ã“ã¨ã«åŒæ„ã—ãªã„å ´åˆã€ã“ã®ãƒœãƒƒã‚¯ã‚¹ã®ãƒã‚§ãƒƒã‚¯ã‚’å¤–ã—ã¦ãã ã•ã„ã€‚ã‚³ãƒ³ãƒ†ãƒ³ãƒ„ã®ã‚·ã‚§ã‚¢ã«ã¤ã„ã¦ã®è©³ç´°ã¯ã€Robloxã® {linkStart}åˆ©ç”¨è¦ç´„{linkEnd}ã‚’ç¢ºèªã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForDescriptionArchiveWarning()
	{
		return "ã‚¢ã‚»ãƒƒãƒˆã‚’ã‚¢ãƒ¼ã‚«ã‚¤ãƒ–ã™ã‚‹ã¨ã‚²ãƒ¼ãƒ ãŒãƒ—ãƒ¬ã‚¤ã§ããªããªã‚Šã¾ã™ã€‚ã‚¢ãƒ¼ã‚«ã‚¤ãƒ–æ¸ˆã¿ã®ã‚¢ã‚»ãƒƒãƒˆã¯å¾©å…ƒã§ãã¾ã™ã€‚";
	}

	protected override string _GetTemplateForDescriptionClickToAddTag()
	{
		return "ã‚¯ãƒªãƒƒã‚¯ã—ã¦ã‚¿ã‚°ã‚’è¿½åŠ ";
	}

	/// <summary>
	/// Key: "Description.MarketplaceExplanation"
	/// English String: "(Roblox takes {marketplaceFeePercentage}%, minimum {minimumPrice})"
	/// </summary>
	public override string DescriptionMarketplaceExplanation(string marketplaceFeePercentage, string minimumPrice)
	{
		return $"ï¼ˆRobloxã®æ‰‹æ•°æ–™{marketplaceFeePercentage}%ã€æœ€ä½Ž{minimumPrice}ï¼‰";
	}

	protected override string _GetTemplateForDescriptionMarketplaceExplanation()
	{
		return "ï¼ˆRobloxã®æ‰‹æ•°æ–™{marketplaceFeePercentage}%ã€æœ€ä½Ž{minimumPrice}ï¼‰";
	}

	protected override string _GetTemplateForDescriptionModeratorFileReview()
	{
		return "* ã‚¢ãƒƒãƒ—ãƒ­ãƒ¼ãƒ‰ã—ãŸç”»åƒã¯ã€ãƒ¢ãƒ‡ãƒ¬ãƒ¼ã‚¿ã«ã‚ˆã‚‹ãƒ¬ãƒ“ãƒ¥ãƒ¼å¾Œã€ä»–ã®ãƒ¦ãƒ¼ã‚¶ãƒ¼ã«å…¬é–‹ã•ã‚Œã¾ã™";
	}

	protected override string _GetTemplateForDescriptionModeratorReview()
	{
		return "* ã‚¢ãƒƒãƒ—ãƒ­ãƒ¼ãƒ‰ã—ãŸç”»åƒã¯ã€ãƒ¢ãƒ‡ãƒ¬ãƒ¼ã‚¿ã«ã‚ˆã‚‹ãƒ¬ãƒ“ãƒ¥ãƒ¼å¾Œã€ä»–ã®ãƒ¦ãƒ¼ã‚¶ãƒ¼ã«å…¬é–‹ã•ã‚Œã¾ã™";
	}

	/// <summary>
	/// Key: "Description.SelectItemTags"
	/// itemTagLimit is the number of item tags allowed
	/// English String: "Select up to {itemTagLimit} tags."
	/// </summary>
	public override string DescriptionSelectItemTags(string itemTagLimit)
	{
		return $"{itemTagLimit} ä»¶ã¾ã§ã®ã‚¿ã‚°ã‚’é¸æŠž";
	}

	protected override string _GetTemplateForDescriptionSelectItemTags()
	{
		return "{itemTagLimit} ä»¶ã¾ã§ã®ã‚¿ã‚°ã‚’é¸æŠž";
	}

	public override string DescriptionVerifiedCreatorEmail(string linkStart, string linkEnd)
	{
		return $"ãƒžãƒ¼ã‚±ãƒƒãƒˆãƒ—ãƒ¬ãƒ¼ã‚¹ã§ã‚³ãƒ³ãƒ†ãƒ³ãƒ„ã‚’ã‚·ã‚§ã‚¢ã™ã‚‹ã«ã¯ã€ãŠæŒã¡ã®ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’è¿½åŠ ã—ã¦èªè¨¼ã™ã‚‹å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚ã“ã¡ã‚‰ã® {linkStart}ã‚¢ã‚«ã‚¦ãƒ³ãƒˆè¨­å®š{linkEnd} ã§ã§ãã¾ã™ã€‚";
	}

	protected override string _GetTemplateForDescriptionVerifiedCreatorEmail()
	{
		return "ãƒžãƒ¼ã‚±ãƒƒãƒˆãƒ—ãƒ¬ãƒ¼ã‚¹ã§ã‚³ãƒ³ãƒ†ãƒ³ãƒ„ã‚’ã‚·ã‚§ã‚¢ã™ã‚‹ã«ã¯ã€ãŠæŒã¡ã®ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’è¿½åŠ ã—ã¦èªè¨¼ã™ã‚‹å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚ã“ã¡ã‚‰ã® {linkStart}ã‚¢ã‚«ã‚¦ãƒ³ãƒˆè¨­å®š{linkEnd} ã§ã§ãã¾ã™ã€‚";
	}

	protected override string _GetTemplateForHeadingArchive()
	{
		return "ã‚¢ãƒ¼ã‚«ã‚¤ãƒ–";
	}

	protected override string _GetTemplateForHeadingConfigure()
	{
		return "ç’°å¢ƒè¨­å®šã™ã‚‹";
	}

	/// <summary>
	/// Key: "Heading.ConfigureItem"
	/// English String: "Configure {itemType}"
	/// </summary>
	public override string HeadingConfigureItem(string itemType)
	{
		return $"{itemType} ã‚’ç’°å¢ƒè¨­å®šã™ã‚‹";
	}

	protected override string _GetTemplateForHeadingConfigureItem()
	{
		return "{itemType} ã‚’ç’°å¢ƒè¨­å®šã™ã‚‹";
	}

	protected override string _GetTemplateForHeadingConfigureItemTags()
	{
		return "ã‚¿ã‚°ã‚’ç’°å¢ƒè¨­å®šã™ã‚‹";
	}

	protected override string _GetTemplateForHeadingCreate()
	{
		return "ä½œæˆ";
	}

	protected override string _GetTemplateForHeadingSettings()
	{
		return "è¨­å®š";
	}

	protected override string _GetTemplateForLabelAllowCopying()
	{
		return "ã‚³ãƒ”ãƒ¼ã‚’è¨±å¯";
	}

	protected override string _GetTemplateForLabelArchive()
	{
		return "ã‚¢ãƒ¼ã‚«ã‚¤ãƒ–";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "ã‚­ãƒ£ãƒ³ã‚»ãƒ«";
	}

	protected override string _GetTemplateForLabelComputer()
	{
		return "ãƒ‘ã‚½ã‚³ãƒ³";
	}

	protected override string _GetTemplateForLabelCreated()
	{
		return "ä½œæˆã—ã¾ã—ãŸ";
	}

	protected override string _GetTemplateForLabelCurrent()
	{
		return "ç¾åœ¨ã®ã‚‚ã®";
	}

	protected override string _GetTemplateForLabelCurrentPublishedVersion()
	{
		return "ç¾åœ¨å…¬é–‹æ¸ˆã¿ã®ãƒãƒ¼ã‚¸ãƒ§ãƒ³";
	}

	protected override string _GetTemplateForLabelDescription()
	{
		return "è©³ç´°";
	}

	protected override string _GetTemplateForLabelDevice()
	{
		return "ãƒ‡ãƒã‚¤ã‚¹";
	}

	protected override string _GetTemplateForLabelEnterItemTag()
	{
		return "ã“ã“ã«ã‚¿ã‚°ã‚’å…¥åŠ›...";
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
		return "ã‚²ãƒ¼ãƒ ";
	}

	protected override string _GetTemplateForLabelGamePass()
	{
		return "ã‚²ãƒ¼ãƒ ãƒ‘ã‚¹";
	}

	protected override string _GetTemplateForLabelGeneral()
	{
		return "ä¸€èˆ¬";
	}

	protected override string _GetTemplateForLabelGoToDetails()
	{
		return "è©³ç´°ã¸";
	}

	protected override string _GetTemplateForLabelItemActive()
	{
		return "ã“ã®ã‚¢ã‚¤ãƒ†ãƒ ã¯ã‚¢ã‚¯ãƒ†ã‚£ãƒ–ã§ã™";
	}

	protected override string _GetTemplateForLabelItemForSale()
	{
		return "è²©å£²ç”¨ã‚¢ã‚¤ãƒ†ãƒ ";
	}

	protected override string _GetTemplateForLabelLastUpdated()
	{
		return "æœ€çµ‚ã‚¢ãƒƒãƒ—ãƒ‡ãƒ¼ãƒˆ";
	}

	protected override string _GetTemplateForLabelLearnMore()
	{
		return "ã‚‚ã£ã¨è©³ã—ã";
	}

	protected override string _GetTemplateForLabelMarketplaceFee()
	{
		return "ãƒžãƒ¼ã‚±ãƒƒãƒˆãƒ—ãƒ¬ãƒ¼ã‚¹ä½¿ç”¨æ–™";
	}

	protected override string _GetTemplateForLabelName()
	{
		return "åå‰";
	}

	protected override string _GetTemplateForLabelOpenForComments()
	{
		return "ã‚³ãƒ¡ãƒ³ãƒˆå¯èƒ½";
	}

	protected override string _GetTemplateForLabelPreview()
	{
		return "ãƒ—ãƒ¬ãƒ“ãƒ¥ãƒ¼";
	}

	protected override string _GetTemplateForLabelPrice()
	{
		return "ä¾¡æ ¼";
	}

	protected override string _GetTemplateForLabelProfit()
	{
		return "ç²å¾—:";
	}

	protected override string _GetTemplateForLabelRestore()
	{
		return "å¾©å…ƒ";
	}

	protected override string _GetTemplateForLabelRevertVersion()
	{
		return "ã“ã®ãƒãƒ¼ã‚¸ãƒ§ãƒ³ã«æˆ»ã™";
	}

	protected override string _GetTemplateForLabelSales()
	{
		return "ã‚»ãƒ¼ãƒ«";
	}

	protected override string _GetTemplateForLabelSave()
	{
		return "ä¿å­˜";
	}

	protected override string _GetTemplateForLabelSelectType()
	{
		return "ã‚¿ã‚¤ãƒ—ã‚’é¸æŠž";
	}

	protected override string _GetTemplateForLabelTags()
	{
		return "ã‚¿ã‚°";
	}

	protected override string _GetTemplateForLabelType()
	{
		return "ã‚¿ã‚¤ãƒ—";
	}

	protected override string _GetTemplateForLabelUpdated()
	{
		return "ã‚¢ãƒƒãƒ—ãƒ‡ãƒ¼ãƒˆæ¸ˆã¿";
	}

	protected override string _GetTemplateForLabelVersion()
	{
		return "ãƒãƒ¼ã‚¸ãƒ§ãƒ³";
	}

	protected override string _GetTemplateForLabelVersions()
	{
		return "ãƒãƒ¼ã‚¸ãƒ§ãƒ³";
	}

	protected override string _GetTemplateForMessageArchiveError()
	{
		return "ã‚¢ãƒ¼ã‚«ã‚¤ãƒ–ã§ãã¾ã›ã‚“ã§ã—ãŸ";
	}

	protected override string _GetTemplateForMessageArchiveSuccess()
	{
		return "ã‚¢ãƒ¼ã‚«ã‚¤ãƒ–ã§ãã¾ã—ãŸ";
	}

	/// <summary>
	/// Key: "Message.DescriptionFieldEmpty"
	/// English String: "{maxDescriptionLength} character limit"
	/// </summary>
	public override string MessageDescriptionFieldEmpty(string maxDescriptionLength)
	{
		return $"æ–‡å­—æ•°åˆ¶é™ã¯ {maxDescriptionLength} æ–‡å­—ã¾ã§";
	}

	protected override string _GetTemplateForMessageDescriptionFieldEmpty()
	{
		return "æ–‡å­—æ•°åˆ¶é™ã¯ {maxDescriptionLength} æ–‡å­—ã¾ã§";
	}

	protected override string _GetTemplateForMessageDescriptionFieldEmptyError()
	{
		return "è©³ç´°ã¯ç©ºç™½ã«ã§ãã¾ã›ã‚“";
	}

	/// <summary>
	/// Key: "Message.DescriptionFieldPopulated"
	/// English String: "{descriptionLength}/{maxDescriptionLength} characters"
	/// </summary>
	public override string MessageDescriptionFieldPopulated(string descriptionLength, string maxDescriptionLength)
	{
		return $"{descriptionLength}/{maxDescriptionLength} æ–‡å­—";
	}

	protected override string _GetTemplateForMessageDescriptionFieldPopulated()
	{
		return "{descriptionLength}/{maxDescriptionLength} æ–‡å­—";
	}

	protected override string _GetTemplateForMessageDescriptionTooLongError()
	{
		return "è©³ç´°ãŒé•·ã™ãŽã¾ã™ã€‚";
	}

	protected override string _GetTemplateForMessageFilteringServiceUnavailableError()
	{
		return "ç¾åœ¨ãƒ•ã‚£ãƒ«ã‚¿ã‚µãƒ¼ãƒ“ã‚¹ã¯åˆ©ç”¨ã§ãã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForMessageGamePassConfigDisabledError()
	{
		return "ã‚²ãƒ¼ãƒ ãƒ‘ã‚¹ã®è¨­å®šãŒæœ‰åŠ¹ã«ãªã£ã¦ã„ã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForMessageGamePassNotFoundError()
	{
		return "ã‚²ãƒ¼ãƒ ãƒ‘ã‚¹ãŒå­˜åœ¨ã—ã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForMessageIconUpdateFailed()
	{
		return "ã‚¢ã‚¤ã‚³ãƒ³ã‚’ã‚¢ãƒƒãƒ—ãƒ‡ãƒ¼ãƒˆã§ãã¾ã›ã‚“ã§ã—ãŸã€‚";
	}

	protected override string _GetTemplateForMessageImageSavingFailedError()
	{
		return "ç”»åƒã‚’ä¿å­˜ã§ãã¾ã›ã‚“ã€‚å¾Œã§ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForMessageInappropriateTextError()
	{
		return "åå‰ã¾ãŸã¯è©³ç´°ã«ä¸é©åˆ‡ãªãƒ†ã‚­ã‚¹ãƒˆãŒå«ã¾ã‚Œã¦ã„ã¾ã™ã€‚";
	}

	/// <summary>
	/// Key: "Message.MinimumPrice"
	/// English String: "You cannot set a price below the minimum price of {minimumPrice}"
	/// </summary>
	public override string MessageMinimumPrice(string minimumPrice)
	{
		return $"{minimumPrice}ã®æœ€ä½Žä¾¡æ ¼æœªæº€ã®ä¾¡æ ¼ã‚’è¨­å®šã™ã‚‹ã“ã¨ã¯ã§ãã¾ã›ã‚“";
	}

	protected override string _GetTemplateForMessageMinimumPrice()
	{
		return "{minimumPrice}ã®æœ€ä½Žä¾¡æ ¼æœªæº€ã®ä¾¡æ ¼ã‚’è¨­å®šã™ã‚‹ã“ã¨ã¯ã§ãã¾ã›ã‚“";
	}

	protected override string _GetTemplateForMessageNameFieldEmpty()
	{
		return "åå‰ã¯ç©ºç™½ã«ã§ãã¾ã›ã‚“";
	}

	/// <summary>
	/// Key: "Message.NameFieldPopulated"
	/// English String: "{nameLength}/{maxNameLength} characters"
	/// </summary>
	public override string MessageNameFieldPopulated(string nameLength, string maxNameLength)
	{
		return $"{nameLength}/{maxNameLength}æ–‡å­—";
	}

	protected override string _GetTemplateForMessageNameFieldPopulated()
	{
		return "{nameLength}/{maxNameLength}æ–‡å­—";
	}

	protected override string _GetTemplateForMessageNameRequiredError()
	{
		return "åå‰ã¯ç©ºç™½ã«ã§ãã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForMessageNoTagsFound()
	{
		return "ã‚¿ã‚°ãŒè¦‹ã¤ã‹ã‚Šã¾ã›ã‚“";
	}

	protected override string _GetTemplateForMessageRestoreError()
	{
		return "å¾©å…ƒã§ãã¾ã›ã‚“ã§ã—ãŸ";
	}

	protected override string _GetTemplateForMessageRestoreSuccess()
	{
		return "å¾©å…ƒã§ãã¾ã—ãŸ";
	}

	/// <summary>
	/// Key: "Message.RevertError"
	/// English String: "Failed to revert to version {versionNumber}"
	/// </summary>
	public override string MessageRevertError(string versionNumber)
	{
		return $"{versionNumber} ãƒãƒ¼ã‚¸ãƒ§ãƒ³ã«æˆ»ã›ã¾ã›ã‚“ã§ã—ãŸ";
	}

	protected override string _GetTemplateForMessageRevertError()
	{
		return "{versionNumber} ãƒãƒ¼ã‚¸ãƒ§ãƒ³ã«æˆ»ã›ã¾ã›ã‚“ã§ã—ãŸ";
	}

	/// <summary>
	/// Key: "Message.RevertSuccess"
	/// English String: "Successfully reverted to version {versionNumber}"
	/// </summary>
	public override string MessageRevertSuccess(string versionNumber)
	{
		return $"{versionNumber} ãƒãƒ¼ã‚¸ãƒ§ãƒ³ã«æˆ»ã—ã¾ã—ãŸ";
	}

	protected override string _GetTemplateForMessageRevertSuccess()
	{
		return "{versionNumber} ãƒãƒ¼ã‚¸ãƒ§ãƒ³ã«æˆ»ã—ã¾ã—ãŸ";
	}

	protected override string _GetTemplateForMessageSaveError()
	{
		return "å•é¡ŒãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚å¾Œã§ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForMessageTooManyUploads()
	{
		return "ã‚¢ãƒƒãƒ—ãƒ­ãƒ¼ãƒ‰å›žæ•°ãŒå¤šã™ãŽã¾ã™ã€‚å¾Œã§ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForMessageUpdatePriceError()
	{
		return "ä¾¡æ ¼ã‚’ã‚¢ãƒƒãƒ—ãƒ‡ãƒ¼ãƒˆã§ãã¾ã›ã‚“ã§ã—ãŸ";
	}

	protected override string _GetTemplateForMessageUpdatePriceSuccess()
	{
		return "ä¾¡æ ¼ã‚’ã‚¢ãƒƒãƒ—ãƒ‡ãƒ¼ãƒˆã§ãã¾ã—ãŸ";
	}

	protected override string _GetTemplateForMessageUpdateSuccess()
	{
		return "ã‚¢ãƒƒãƒ—ãƒ‡ãƒ¼ãƒˆã§ãã¾ã—ãŸ";
	}
}


}
