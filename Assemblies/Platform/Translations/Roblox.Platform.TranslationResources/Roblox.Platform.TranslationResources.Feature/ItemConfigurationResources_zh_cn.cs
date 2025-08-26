namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides ItemConfigurationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ItemConfigurationResources_zh_cn : ItemConfigurationResources_en_us, IItemConfigurationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Description.AllowCopying"
	/// English String: "By switching on, you are granting every other user of Roblox the right to use (in various ways) the content you are now sharing. If you do not want to grant this right, please do not check this box. For more information about sharing content, please review the Roblox Terms of Use."
	/// </summary>
	public override string DescriptionAllowCopying => "å¦‚æžœå¼€å¯æ­¤é€‰é¡¹ï¼Œå³è¡¨ç¤ºä½ åŒæ„æŽˆæƒå…¶ä»– Roblox ç”¨æˆ· ï¼ˆä»¥å„ç§æ–¹å¼ï¼‰ä½¿ç”¨ä½ çŽ°åœ¨åˆ†äº«çš„å†…å®¹ã€‚å¦‚æžœä½ ä¸æƒ³è¿›è¡Œæ­¤é¡¹æŽˆæƒï¼Œè¯·å‹¿é€‰ä¸­æ­¤æ¡†ã€‚å¦‚éœ€æ›´å¤šå…³äºŽåˆ†äº«å†…å®¹çš„ä¿¡æ¯ï¼Œè¯·å‚é˜… Roblox ä½¿ç”¨æ¡æ¬¾ã€‚";

	/// <summary>
	/// Key: "Description.ArchiveWarning"
	/// English String: "Archiving this asset will prevent it from being used in game. Archived assets can be restored."
	/// </summary>
	public override string DescriptionArchiveWarning => "å­˜æ¡£æ­¤ç´ æåŽå°†æ— æ³•åœ¨æ¸¸æˆä¸­ä½¿ç”¨ã€‚å­˜æ¡£ç´ æåŽå¯ä»¥å¤åŽŸã€‚";

	/// <summary>
	/// Key: "Description.ClickToAddTag"
	/// Hover text on the button that adds a tag to an item
	/// English String: "Click to add tag"
	/// </summary>
	public override string DescriptionClickToAddTag => "ç‚¹æŒ‰ä»¥æ·»åŠ æ ‡ç­¾";

	/// <summary>
	/// Key: "Description.ModeratorFileReview"
	/// English String: "* Uploaded file will be reviewed by moderators before being made visible to other users"
	/// </summary>
	public override string DescriptionModeratorFileReview => "* å·²ä¸Šä¼ çš„æ–‡ä»¶å°†ç”±ç®¡ç†å‘˜å®¡é˜…ï¼Œé€šè¿‡åŽå³å¯å¯¹å…¶ä»–ç”¨æˆ·å¯è§";

	/// <summary>
	/// Key: "Description.ModeratorReview"
	/// English String: "* Uploaded image will be reviewed by moderators before being made visible to other users"
	/// </summary>
	public override string DescriptionModeratorReview => "* å·²ä¸Šä¼ çš„å›¾åƒå°†ç”±ç®¡ç†å‘˜å®¡é˜…ï¼Œé€šè¿‡åŽå³å¯å¯¹å…¶ä»–ç”¨æˆ·å¯è§";

	/// <summary>
	/// Key: "Heading.Archive"
	/// header text for section about archiving assets
	/// English String: "Archive"
	/// </summary>
	public override string HeadingArchive => "å½’æ¡£";

	/// <summary>
	/// Key: "Heading.Configure"
	/// English String: "Configure"
	/// </summary>
	public override string HeadingConfigure => "é…ç½®";

	/// <summary>
	/// Key: "Heading.ConfigureItemTags"
	/// Heading on Configure Tags modal
	/// English String: "Configure Tags"
	/// </summary>
	public override string HeadingConfigureItemTags => "é…ç½®æ ‡ç­¾";

	/// <summary>
	/// Key: "Heading.Create"
	/// English String: "Create"
	/// </summary>
	public override string HeadingCreate => "åˆ›å»º";

	/// <summary>
	/// Key: "Heading.Settings"
	/// English String: "Settings"
	/// </summary>
	public override string HeadingSettings => "è®¾ç½®";

	/// <summary>
	/// Key: "Label.AllowCopying"
	/// English String: "Allow Copying"
	/// </summary>
	public override string LabelAllowCopying => "å…è®¸å¤åˆ¶";

	/// <summary>
	/// Key: "Label.Archive"
	/// Text on button for archiving an asset. Part of speech: verb
	/// English String: "Archive"
	/// </summary>
	public override string LabelArchive => "å½’æ¡£";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "å–æ¶ˆ";

	/// <summary>
	/// Key: "Label.Computer"
	/// computer term
	/// English String: "Computer"
	/// </summary>
	public override string LabelComputer => "ç”µè„‘";

	/// <summary>
	/// Key: "Label.Created"
	/// English String: "Created"
	/// </summary>
	public override string LabelCreated => "åˆ›å»ºæ—¶é—´";

	/// <summary>
	/// Key: "Label.Current"
	/// English String: "Current"
	/// </summary>
	public override string LabelCurrent => "å½“å‰";

	/// <summary>
	/// Key: "Label.CurrentPublishedVersion"
	/// English String: "Current published version"
	/// </summary>
	public override string LabelCurrentPublishedVersion => "å½“å‰å‘å¸ƒç‰ˆæœ¬";

	/// <summary>
	/// Key: "Label.Description"
	/// English String: "Description"
	/// </summary>
	public override string LabelDescription => "æè¿°";

	/// <summary>
	/// Key: "Label.Device"
	/// device term
	/// English String: "Device"
	/// </summary>
	public override string LabelDevice => "è®¾å¤‡";

	/// <summary>
	/// Key: "Label.EnterItemTag"
	/// Placeholder for input field
	/// English String: "Enter tag here..."
	/// </summary>
	public override string LabelEnterItemTag => "åœ¨æ­¤å¤„è¾“å…¥æ ‡ç­¾...";

	/// <summary>
	/// Key: "Label.Game"
	/// English String: "Game"
	/// </summary>
	public override string LabelGame => "æ¸¸æˆ";

	/// <summary>
	/// Key: "Label.GamePass"
	/// label
	/// English String: "Game Pass"
	/// </summary>
	public override string LabelGamePass => "æ¸¸æˆé€šè¡Œè¯";

	/// <summary>
	/// Key: "Label.General"
	/// English String: "General"
	/// </summary>
	public override string LabelGeneral => "é€šç”¨";

	/// <summary>
	/// Key: "Label.GoToDetails"
	/// Link to the item details page from the configure page
	/// English String: "Go to Details"
	/// </summary>
	public override string LabelGoToDetails => "å‰å¾€è¯¦æƒ…";

	/// <summary>
	/// Key: "Label.ItemActive"
	/// English String: "Item is Active"
	/// </summary>
	public override string LabelItemActive => "ç‰©å“å·²å¯ç”¨";

	/// <summary>
	/// Key: "Label.ItemForSale"
	/// English String: "Item for Sale"
	/// </summary>
	public override string LabelItemForSale => "å¾…å”®ç‰©å“";

	/// <summary>
	/// Key: "Label.LastUpdated"
	/// English String: "Last Updated"
	/// </summary>
	public override string LabelLastUpdated => "ä¸Šæ¬¡æ›´æ–°";

	/// <summary>
	/// Key: "Label.LearnMore"
	/// English String: "Learn more"
	/// </summary>
	public override string LabelLearnMore => "äº†è§£æ›´å¤š";

	/// <summary>
	/// Key: "Label.MarketplaceFee"
	/// English String: "Marketplace Fee"
	/// </summary>
	public override string LabelMarketplaceFee => "å¸‚é›†è´¹";

	/// <summary>
	/// Key: "Label.Name"
	/// English String: "Name"
	/// </summary>
	public override string LabelName => "åç§°";

	/// <summary>
	/// Key: "Label.OpenForComments"
	/// English String: "Open for Comments"
	/// </summary>
	public override string LabelOpenForComments => "å¼€æ”¾è¯„è®º";

	/// <summary>
	/// Key: "Label.Preview"
	/// English String: "Preview"
	/// </summary>
	public override string LabelPreview => "é¢„è§ˆ";

	/// <summary>
	/// Key: "Label.Price"
	/// English String: "Price"
	/// </summary>
	public override string LabelPrice => "ä»·æ ¼";

	/// <summary>
	/// Key: "Label.Profit"
	/// English String: "You Earn"
	/// </summary>
	public override string LabelProfit => "ä½ èµšå–";

	/// <summary>
	/// Key: "Label.Restore"
	/// English String: "Restore"
	/// </summary>
	public override string LabelRestore => "å¤åŽŸ";

	/// <summary>
	/// Key: "Label.RevertVersion"
	/// English String: "Revert to this version"
	/// </summary>
	public override string LabelRevertVersion => "è¿˜åŽŸåˆ°æ­¤ç‰ˆæœ¬";

	/// <summary>
	/// Key: "Label.Sales"
	/// English String: "Sales"
	/// </summary>
	public override string LabelSales => "ä¹°å–";

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
	public override string LabelSelectType => "é€‰æ‹©ç±»åž‹";

	/// <summary>
	/// Key: "Label.Tags"
	/// The label next to a list of item tags in the item configuration page
	/// English String: "Tags"
	/// </summary>
	public override string LabelTags => "æ ‡ç­¾";

	/// <summary>
	/// Key: "Label.Type"
	/// English String: "Type"
	/// </summary>
	public override string LabelType => "ç±»åž‹";

	/// <summary>
	/// Key: "Label.Updated"
	/// English String: "Updated"
	/// </summary>
	public override string LabelUpdated => "æ›´æ–°æ—¶é—´";

	/// <summary>
	/// Key: "Label.Version"
	/// English String: "Version"
	/// </summary>
	public override string LabelVersion => "ç‰ˆæœ¬";

	/// <summary>
	/// Key: "Label.Versions"
	/// English String: "Versions"
	/// </summary>
	public override string LabelVersions => "ç‰ˆæœ¬";

	/// <summary>
	/// Key: "Message.ArchiveError"
	/// English String: "Failed to archive"
	/// </summary>
	public override string MessageArchiveError => "æ— æ³•å½’æ¡£";

	/// <summary>
	/// Key: "Message.ArchiveSuccess"
	/// English String: "Successfully archived"
	/// </summary>
	public override string MessageArchiveSuccess => "å½’æ¡£æˆåŠŸ";

	/// <summary>
	/// Key: "Message.DescriptionFieldEmptyError"
	/// English String: "Description cannot be empty"
	/// </summary>
	public override string MessageDescriptionFieldEmptyError => "è¯´æ˜Žä¸å¯ä¸ºç©º";

	/// <summary>
	/// Key: "Message.DescriptionTooLongError"
	/// error message
	/// English String: "The description is too long."
	/// </summary>
	public override string MessageDescriptionTooLongError => "æè¿°è¿‡é•¿ã€‚";

	/// <summary>
	/// Key: "Message.FilteringServiceUnavailableError"
	/// error message
	/// English String: "Text filtering service is unavailable at this time."
	/// </summary>
	public override string MessageFilteringServiceUnavailableError => "ç›®å‰æ— æ³•ä½¿ç”¨æ–‡æœ¬è¿‡æ»¤æœåŠ¡ã€‚";

	/// <summary>
	/// Key: "Message.GamePassConfigDisabledError"
	/// error message
	/// English String: "Game Pass configuration is not enabled yet."
	/// </summary>
	public override string MessageGamePassConfigDisabledError => "æ¸¸æˆé€šè¡Œè¯é…ç½®å°šæœªå¯ç”¨ã€‚";

	/// <summary>
	/// Key: "Message.GamePassNotFoundError"
	/// errormessage
	/// English String: "The Game Pass does not exist."
	/// </summary>
	public override string MessageGamePassNotFoundError => "æ¸¸æˆé€šè¡Œè¯ä¸å­˜åœ¨ã€‚";

	/// <summary>
	/// Key: "Message.IconUpdateFailed"
	/// error message
	/// English String: "Failed to update icon."
	/// </summary>
	public override string MessageIconUpdateFailed => "æ›´æ–°å›¾æ ‡å¤±è´¥ã€‚";

	/// <summary>
	/// Key: "Message.ImageSavingFailedError"
	/// error message
	/// English String: "Failed to save image. Please try again later."
	/// </summary>
	public override string MessageImageSavingFailedError => "ä¿å­˜å›¾åƒå¤±è´¥ã€‚è¯·ç¨åŽé‡è¯•ã€‚";

	/// <summary>
	/// Key: "Message.InappropriateTextError"
	/// error message
	/// English String: "The name or description contains inappropriate text."
	/// </summary>
	public override string MessageInappropriateTextError => "åç§°æˆ–æè¿°åŒ…å«ä¸å½“æ–‡å­—ã€‚";

	/// <summary>
	/// Key: "Message.NameFieldEmpty"
	/// English String: "Name cannot be empty"
	/// </summary>
	public override string MessageNameFieldEmpty => "åç§°ä¸èƒ½ä¸ºç©º";

	/// <summary>
	/// Key: "Message.NameRequiredError"
	/// error message
	/// English String: "The name cannot be empty."
	/// </summary>
	public override string MessageNameRequiredError => "åç§°ä¸èƒ½ä¸ºç©ºã€‚";

	/// <summary>
	/// Key: "Message.NoTagsFound"
	/// English String: "No tags found"
	/// </summary>
	public override string MessageNoTagsFound => "æœªæ‰¾åˆ°æ ‡ç­¾";

	/// <summary>
	/// Key: "Message.RestoreError"
	/// English String: "Failed to restore"
	/// </summary>
	public override string MessageRestoreError => "æ— æ³•å¤åŽŸ";

	/// <summary>
	/// Key: "Message.RestoreSuccess"
	/// English String: "Successfully restored"
	/// </summary>
	public override string MessageRestoreSuccess => "å¤åŽŸæˆåŠŸ";

	/// <summary>
	/// Key: "Message.SaveError"
	/// English String: "Something failed. Please try again later"
	/// </summary>
	public override string MessageSaveError => "æœ‰åœ°æ–¹å‡ºé”™ã€‚è¯·ç¨åŽé‡è¯•ã€‚";

	/// <summary>
	/// Key: "Message.TooManyUploads"
	/// error message
	/// English String: "You are uploading too much. Please try again later."
	/// </summary>
	public override string MessageTooManyUploads => "ä½ å·²ä¸Šä¼ è¿‡å¤šæ–‡ä»¶ã€‚è¯·ç¨å€™é‡è¯•ã€‚";

	/// <summary>
	/// Key: "Message.UpdatePriceError"
	/// English String: "Failed to update price"
	/// </summary>
	public override string MessageUpdatePriceError => "æ— æ³•æ›´æ–°ä»·æ ¼";

	/// <summary>
	/// Key: "Message.UpdatePriceSuccess"
	/// English String: "Successfully updated price"
	/// </summary>
	public override string MessageUpdatePriceSuccess => "å·²æˆåŠŸæ›´æ–°ä»·æ ¼";

	/// <summary>
	/// Key: "Message.UpdateSuccess"
	/// English String: "Successfully updated"
	/// </summary>
	public override string MessageUpdateSuccess => "å·²æˆåŠŸæ›´æ–°";

	public ItemConfigurationResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	/// <summary>
	/// Key: "Description.AcceptableFileFormats"
	/// English String: "* Acceptable file formats: {fileExtensions}"
	/// </summary>
	public override string DescriptionAcceptableFileFormats(string fileExtensions)
	{
		return $"* å¯æŽ¥å—çš„æ–‡ä»¶æ ¼å¼ï¼š{fileExtensions}";
	}

	protected override string _GetTemplateForDescriptionAcceptableFileFormats()
	{
		return "* å¯æŽ¥å—çš„æ–‡ä»¶æ ¼å¼ï¼š{fileExtensions}";
	}

	/// <summary>
	/// Key: "Description.AcceptableFiles"
	/// English String: "* Acceptable files{lineBreak}Format: {fileExtensions}   |   Size: {fileSizes}"
	/// </summary>
	public override string DescriptionAcceptableFiles(string lineBreak, string fileExtensions, string fileSizes)
	{
		return $"* å¯æŽ¥å—çš„æ–‡ä»¶{lineBreak}æ ¼å¼ï¼š{fileExtensions}   |   å¤§å°ï¼š{fileSizes}";
	}

	protected override string _GetTemplateForDescriptionAcceptableFiles()
	{
		return "* å¯æŽ¥å—çš„æ–‡ä»¶{lineBreak}æ ¼å¼ï¼š{fileExtensions}   |   å¤§å°ï¼š{fileSizes}";
	}

	protected override string _GetTemplateForDescriptionAllowCopying()
	{
		return "å¦‚æžœå¼€å¯æ­¤é€‰é¡¹ï¼Œå³è¡¨ç¤ºä½ åŒæ„æŽˆæƒå…¶ä»– Roblox ç”¨æˆ· ï¼ˆä»¥å„ç§æ–¹å¼ï¼‰ä½¿ç”¨ä½ çŽ°åœ¨åˆ†äº«çš„å†…å®¹ã€‚å¦‚æžœä½ ä¸æƒ³è¿›è¡Œæ­¤é¡¹æŽˆæƒï¼Œè¯·å‹¿é€‰ä¸­æ­¤æ¡†ã€‚å¦‚éœ€æ›´å¤šå…³äºŽåˆ†äº«å†…å®¹çš„ä¿¡æ¯ï¼Œè¯·å‚é˜… Roblox ä½¿ç”¨æ¡æ¬¾ã€‚";
	}

	/// <summary>
	/// Key: "Description.AllowCopyingWarning"
	/// English String: "By switching on, you are granting every other user of Roblox the right to use (in various ways) the content you are now sharing. If you do not want to grant this right, please do not check this box. For more information about sharing content, please review the Roblox {linkStart}Terms of Use{linkEnd}."
	/// </summary>
	public override string DescriptionAllowCopyingWarning(string linkStart, string linkEnd)
	{
		return $"å¦‚æžœå¼€å¯æ­¤é€‰é¡¹ï¼Œå³è¡¨ç¤ºä½ åŒæ„æŽˆæƒå…¶ä»– Roblox ç”¨æˆ· ï¼ˆä»¥å„ç§æ–¹å¼ï¼‰ä½¿ç”¨ä½ çŽ°åœ¨åˆ†äº«çš„å†…å®¹ã€‚å¦‚æžœä½ ä¸æƒ³è¿›è¡Œæ­¤é¡¹æŽˆæƒï¼Œè¯·å‹¿é€‰ä¸­æ­¤æ¡†ã€‚å¦‚éœ€æ›´å¤šå…³äºŽåˆ†äº«å†…å®¹çš„ä¿¡æ¯ï¼Œè¯·å‚é˜… Roblox {linkStart}ä½¿ç”¨æ¡æ¬¾{linkEnd}ã€‚";
	}

	protected override string _GetTemplateForDescriptionAllowCopyingWarning()
	{
		return "å¦‚æžœå¼€å¯æ­¤é€‰é¡¹ï¼Œå³è¡¨ç¤ºä½ åŒæ„æŽˆæƒå…¶ä»– Roblox ç”¨æˆ· ï¼ˆä»¥å„ç§æ–¹å¼ï¼‰ä½¿ç”¨ä½ çŽ°åœ¨åˆ†äº«çš„å†…å®¹ã€‚å¦‚æžœä½ ä¸æƒ³è¿›è¡Œæ­¤é¡¹æŽˆæƒï¼Œè¯·å‹¿é€‰ä¸­æ­¤æ¡†ã€‚å¦‚éœ€æ›´å¤šå…³äºŽåˆ†äº«å†…å®¹çš„ä¿¡æ¯ï¼Œè¯·å‚é˜… Roblox {linkStart}ä½¿ç”¨æ¡æ¬¾{linkEnd}ã€‚";
	}

	protected override string _GetTemplateForDescriptionArchiveWarning()
	{
		return "å­˜æ¡£æ­¤ç´ æåŽå°†æ— æ³•åœ¨æ¸¸æˆä¸­ä½¿ç”¨ã€‚å­˜æ¡£ç´ æåŽå¯ä»¥å¤åŽŸã€‚";
	}

	protected override string _GetTemplateForDescriptionClickToAddTag()
	{
		return "ç‚¹æŒ‰ä»¥æ·»åŠ æ ‡ç­¾";
	}

	/// <summary>
	/// Key: "Description.MarketplaceExplanation"
	/// English String: "(Roblox takes {marketplaceFeePercentage}%, minimum {minimumPrice})"
	/// </summary>
	public override string DescriptionMarketplaceExplanation(string marketplaceFeePercentage, string minimumPrice)
	{
		return $"ï¼ˆRoblox æ”¶å– {marketplaceFeePercentage}%ï¼Œæœ€ä½Ž {minimumPrice}ï¼‰";
	}

	protected override string _GetTemplateForDescriptionMarketplaceExplanation()
	{
		return "ï¼ˆRoblox æ”¶å– {marketplaceFeePercentage}%ï¼Œæœ€ä½Ž {minimumPrice}ï¼‰";
	}

	protected override string _GetTemplateForDescriptionModeratorFileReview()
	{
		return "* å·²ä¸Šä¼ çš„æ–‡ä»¶å°†ç”±ç®¡ç†å‘˜å®¡é˜…ï¼Œé€šè¿‡åŽå³å¯å¯¹å…¶ä»–ç”¨æˆ·å¯è§";
	}

	protected override string _GetTemplateForDescriptionModeratorReview()
	{
		return "* å·²ä¸Šä¼ çš„å›¾åƒå°†ç”±ç®¡ç†å‘˜å®¡é˜…ï¼Œé€šè¿‡åŽå³å¯å¯¹å…¶ä»–ç”¨æˆ·å¯è§";
	}

	/// <summary>
	/// Key: "Description.SelectItemTags"
	/// itemTagLimit is the number of item tags allowed
	/// English String: "Select up to {itemTagLimit} tags."
	/// </summary>
	public override string DescriptionSelectItemTags(string itemTagLimit)
	{
		return $"æœ€å¤šå¯é€‰æ‹© {itemTagLimit} ä¸ªæ ‡ç­¾ã€‚";
	}

	protected override string _GetTemplateForDescriptionSelectItemTags()
	{
		return "æœ€å¤šå¯é€‰æ‹© {itemTagLimit} ä¸ªæ ‡ç­¾ã€‚";
	}

	public override string DescriptionVerifiedCreatorEmail(string linkStart, string linkEnd)
	{
		return $"è‹¥è¦åœ¨å¸‚é›†åˆ†äº«å†…å®¹ï¼Œä½ å¿…é¡»åœ¨å¸æˆ·æ·»åŠ å¹¶éªŒè¯ä¸€ä¸ªç”µå­é‚®ä»¶åœ°å€ã€‚æ­¤åŠ¨ä½œå¯ä»¥åœ¨{linkStart}å¸æˆ·è®¾ç½®{linkEnd}è¿›è¡Œã€‚";
	}

	protected override string _GetTemplateForDescriptionVerifiedCreatorEmail()
	{
		return "è‹¥è¦åœ¨å¸‚é›†åˆ†äº«å†…å®¹ï¼Œä½ å¿…é¡»åœ¨å¸æˆ·æ·»åŠ å¹¶éªŒè¯ä¸€ä¸ªç”µå­é‚®ä»¶åœ°å€ã€‚æ­¤åŠ¨ä½œå¯ä»¥åœ¨{linkStart}å¸æˆ·è®¾ç½®{linkEnd}è¿›è¡Œã€‚";
	}

	protected override string _GetTemplateForHeadingArchive()
	{
		return "å½’æ¡£";
	}

	protected override string _GetTemplateForHeadingConfigure()
	{
		return "é…ç½®";
	}

	/// <summary>
	/// Key: "Heading.ConfigureItem"
	/// English String: "Configure {itemType}"
	/// </summary>
	public override string HeadingConfigureItem(string itemType)
	{
		return $"é…ç½®\"{itemType}\"";
	}

	protected override string _GetTemplateForHeadingConfigureItem()
	{
		return "é…ç½®\"{itemType}\"";
	}

	protected override string _GetTemplateForHeadingConfigureItemTags()
	{
		return "é…ç½®æ ‡ç­¾";
	}

	protected override string _GetTemplateForHeadingCreate()
	{
		return "åˆ›å»º";
	}

	protected override string _GetTemplateForHeadingSettings()
	{
		return "è®¾ç½®";
	}

	protected override string _GetTemplateForLabelAllowCopying()
	{
		return "å…è®¸å¤åˆ¶";
	}

	protected override string _GetTemplateForLabelArchive()
	{
		return "å½’æ¡£";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "å–æ¶ˆ";
	}

	protected override string _GetTemplateForLabelComputer()
	{
		return "ç”µè„‘";
	}

	protected override string _GetTemplateForLabelCreated()
	{
		return "åˆ›å»ºæ—¶é—´";
	}

	protected override string _GetTemplateForLabelCurrent()
	{
		return "å½“å‰";
	}

	protected override string _GetTemplateForLabelCurrentPublishedVersion()
	{
		return "å½“å‰å‘å¸ƒç‰ˆæœ¬";
	}

	protected override string _GetTemplateForLabelDescription()
	{
		return "æè¿°";
	}

	protected override string _GetTemplateForLabelDevice()
	{
		return "è®¾å¤‡";
	}

	protected override string _GetTemplateForLabelEnterItemTag()
	{
		return "åœ¨æ­¤å¤„è¾“å…¥æ ‡ç­¾...";
	}

	/// <summary>
	/// Key: "Label.ForItem"
	/// English String: "For {itemType}"
	/// </summary>
	public override string LabelForItem(string itemType)
	{
		return $"ä¸º\"{itemType}\"";
	}

	protected override string _GetTemplateForLabelForItem()
	{
		return "ä¸º\"{itemType}\"";
	}

	protected override string _GetTemplateForLabelGame()
	{
		return "æ¸¸æˆ";
	}

	protected override string _GetTemplateForLabelGamePass()
	{
		return "æ¸¸æˆé€šè¡Œè¯";
	}

	protected override string _GetTemplateForLabelGeneral()
	{
		return "é€šç”¨";
	}

	protected override string _GetTemplateForLabelGoToDetails()
	{
		return "å‰å¾€è¯¦æƒ…";
	}

	protected override string _GetTemplateForLabelItemActive()
	{
		return "ç‰©å“å·²å¯ç”¨";
	}

	protected override string _GetTemplateForLabelItemForSale()
	{
		return "å¾…å”®ç‰©å“";
	}

	protected override string _GetTemplateForLabelLastUpdated()
	{
		return "ä¸Šæ¬¡æ›´æ–°";
	}

	protected override string _GetTemplateForLabelLearnMore()
	{
		return "äº†è§£æ›´å¤š";
	}

	protected override string _GetTemplateForLabelMarketplaceFee()
	{
		return "å¸‚é›†è´¹";
	}

	protected override string _GetTemplateForLabelName()
	{
		return "åç§°";
	}

	protected override string _GetTemplateForLabelOpenForComments()
	{
		return "å¼€æ”¾è¯„è®º";
	}

	protected override string _GetTemplateForLabelPreview()
	{
		return "é¢„è§ˆ";
	}

	protected override string _GetTemplateForLabelPrice()
	{
		return "ä»·æ ¼";
	}

	protected override string _GetTemplateForLabelProfit()
	{
		return "ä½ èµšå–";
	}

	protected override string _GetTemplateForLabelRestore()
	{
		return "å¤åŽŸ";
	}

	protected override string _GetTemplateForLabelRevertVersion()
	{
		return "è¿˜åŽŸåˆ°æ­¤ç‰ˆæœ¬";
	}

	protected override string _GetTemplateForLabelSales()
	{
		return "ä¹°å–";
	}

	protected override string _GetTemplateForLabelSave()
	{
		return "ä¿å­˜";
	}

	protected override string _GetTemplateForLabelSelectType()
	{
		return "é€‰æ‹©ç±»åž‹";
	}

	protected override string _GetTemplateForLabelTags()
	{
		return "æ ‡ç­¾";
	}

	protected override string _GetTemplateForLabelType()
	{
		return "ç±»åž‹";
	}

	protected override string _GetTemplateForLabelUpdated()
	{
		return "æ›´æ–°æ—¶é—´";
	}

	protected override string _GetTemplateForLabelVersion()
	{
		return "ç‰ˆæœ¬";
	}

	protected override string _GetTemplateForLabelVersions()
	{
		return "ç‰ˆæœ¬";
	}

	protected override string _GetTemplateForMessageArchiveError()
	{
		return "æ— æ³•å½’æ¡£";
	}

	protected override string _GetTemplateForMessageArchiveSuccess()
	{
		return "å½’æ¡£æˆåŠŸ";
	}

	/// <summary>
	/// Key: "Message.DescriptionFieldEmpty"
	/// English String: "{maxDescriptionLength} character limit"
	/// </summary>
	public override string MessageDescriptionFieldEmpty(string maxDescriptionLength)
	{
		return $"{maxDescriptionLength} å­—ç¬¦ä¸Šé™";
	}

	protected override string _GetTemplateForMessageDescriptionFieldEmpty()
	{
		return "{maxDescriptionLength} å­—ç¬¦ä¸Šé™";
	}

	protected override string _GetTemplateForMessageDescriptionFieldEmptyError()
	{
		return "è¯´æ˜Žä¸å¯ä¸ºç©º";
	}

	/// <summary>
	/// Key: "Message.DescriptionFieldPopulated"
	/// English String: "{descriptionLength}/{maxDescriptionLength} characters"
	/// </summary>
	public override string MessageDescriptionFieldPopulated(string descriptionLength, string maxDescriptionLength)
	{
		return $"{descriptionLength}/{maxDescriptionLength} ä¸ªå­—ç¬¦";
	}

	protected override string _GetTemplateForMessageDescriptionFieldPopulated()
	{
		return "{descriptionLength}/{maxDescriptionLength} ä¸ªå­—ç¬¦";
	}

	protected override string _GetTemplateForMessageDescriptionTooLongError()
	{
		return "æè¿°è¿‡é•¿ã€‚";
	}

	protected override string _GetTemplateForMessageFilteringServiceUnavailableError()
	{
		return "ç›®å‰æ— æ³•ä½¿ç”¨æ–‡æœ¬è¿‡æ»¤æœåŠ¡ã€‚";
	}

	protected override string _GetTemplateForMessageGamePassConfigDisabledError()
	{
		return "æ¸¸æˆé€šè¡Œè¯é…ç½®å°šæœªå¯ç”¨ã€‚";
	}

	protected override string _GetTemplateForMessageGamePassNotFoundError()
	{
		return "æ¸¸æˆé€šè¡Œè¯ä¸å­˜åœ¨ã€‚";
	}

	protected override string _GetTemplateForMessageIconUpdateFailed()
	{
		return "æ›´æ–°å›¾æ ‡å¤±è´¥ã€‚";
	}

	protected override string _GetTemplateForMessageImageSavingFailedError()
	{
		return "ä¿å­˜å›¾åƒå¤±è´¥ã€‚è¯·ç¨åŽé‡è¯•ã€‚";
	}

	protected override string _GetTemplateForMessageInappropriateTextError()
	{
		return "åç§°æˆ–æè¿°åŒ…å«ä¸å½“æ–‡å­—ã€‚";
	}

	/// <summary>
	/// Key: "Message.MinimumPrice"
	/// English String: "You cannot set a price below the minimum price of {minimumPrice}"
	/// </summary>
	public override string MessageMinimumPrice(string minimumPrice)
	{
		return $"ä½ æ— æ³•å°†ä»·æ ¼è®¾ç½®ä¸ºä½ŽäºŽæœ€ä½Žä»·æ ¼ {minimumPrice}";
	}

	protected override string _GetTemplateForMessageMinimumPrice()
	{
		return "ä½ æ— æ³•å°†ä»·æ ¼è®¾ç½®ä¸ºä½ŽäºŽæœ€ä½Žä»·æ ¼ {minimumPrice}";
	}

	protected override string _GetTemplateForMessageNameFieldEmpty()
	{
		return "åç§°ä¸èƒ½ä¸ºç©º";
	}

	/// <summary>
	/// Key: "Message.NameFieldPopulated"
	/// English String: "{nameLength}/{maxNameLength} characters"
	/// </summary>
	public override string MessageNameFieldPopulated(string nameLength, string maxNameLength)
	{
		return $"{nameLength}/{maxNameLength} ä¸ªå­—ç¬¦";
	}

	protected override string _GetTemplateForMessageNameFieldPopulated()
	{
		return "{nameLength}/{maxNameLength} ä¸ªå­—ç¬¦";
	}

	protected override string _GetTemplateForMessageNameRequiredError()
	{
		return "åç§°ä¸èƒ½ä¸ºç©ºã€‚";
	}

	protected override string _GetTemplateForMessageNoTagsFound()
	{
		return "æœªæ‰¾åˆ°æ ‡ç­¾";
	}

	protected override string _GetTemplateForMessageRestoreError()
	{
		return "æ— æ³•å¤åŽŸ";
	}

	protected override string _GetTemplateForMessageRestoreSuccess()
	{
		return "å¤åŽŸæˆåŠŸ";
	}

	/// <summary>
	/// Key: "Message.RevertError"
	/// English String: "Failed to revert to version {versionNumber}"
	/// </summary>
	public override string MessageRevertError(string versionNumber)
	{
		return $"æ— æ³•è¿˜åŽŸåˆ°ç‰ˆæœ¬ {versionNumber}";
	}

	protected override string _GetTemplateForMessageRevertError()
	{
		return "æ— æ³•è¿˜åŽŸåˆ°ç‰ˆæœ¬ {versionNumber}";
	}

	/// <summary>
	/// Key: "Message.RevertSuccess"
	/// English String: "Successfully reverted to version {versionNumber}"
	/// </summary>
	public override string MessageRevertSuccess(string versionNumber)
	{
		return $"æˆåŠŸè¿˜åŽŸåˆ°ç‰ˆæœ¬ {versionNumber}";
	}

	protected override string _GetTemplateForMessageRevertSuccess()
	{
		return "æˆåŠŸè¿˜åŽŸåˆ°ç‰ˆæœ¬ {versionNumber}";
	}

	protected override string _GetTemplateForMessageSaveError()
	{
		return "æœ‰åœ°æ–¹å‡ºé”™ã€‚è¯·ç¨åŽé‡è¯•ã€‚";
	}

	protected override string _GetTemplateForMessageTooManyUploads()
	{
		return "ä½ å·²ä¸Šä¼ è¿‡å¤šæ–‡ä»¶ã€‚è¯·ç¨å€™é‡è¯•ã€‚";
	}

	protected override string _GetTemplateForMessageUpdatePriceError()
	{
		return "æ— æ³•æ›´æ–°ä»·æ ¼";
	}

	protected override string _GetTemplateForMessageUpdatePriceSuccess()
	{
		return "å·²æˆåŠŸæ›´æ–°ä»·æ ¼";
	}

	protected override string _GetTemplateForMessageUpdateSuccess()
	{
		return "å·²æˆåŠŸæ›´æ–°";
	}
}


}
