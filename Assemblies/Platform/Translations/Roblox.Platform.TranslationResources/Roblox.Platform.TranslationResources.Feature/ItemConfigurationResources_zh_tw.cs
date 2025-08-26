namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides ItemConfigurationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ItemConfigurationResources_zh_tw : ItemConfigurationResources_en_us, IItemConfigurationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Description.AllowCopying"
	/// English String: "By switching on, you are granting every other user of Roblox the right to use (in various ways) the content you are now sharing. If you do not want to grant this right, please do not check this box. For more information about sharing content, please review the Roblox Terms of Use."
	/// </summary>
	public override string DescriptionAllowCopying => "è‹¥é–‹å•Ÿæ­¤é¸é …ï¼Œæ‚¨å°‡æŽˆæ¬Šå…¶ä»– Roblox ä½¿ç”¨è€…æŽˆä»¥ä¸åŒæ–¹å¼ä½¿ç”¨æ‚¨ç¾åœ¨åˆ†äº«çš„å…§å®¹ã€‚è‹¥æ‚¨ä¸æƒ³é€²è¡ŒæŽˆæ¬Šï¼Œè«‹å‹¿å‹¾é¸æ­¤æ–¹å¡Šã€‚è‹¥éœ€æ›´å¤šè³‡è¨Šï¼Œè«‹åƒè€ƒ Roblox ä½¿ç”¨æ¢æ¬¾ã€‚";

	/// <summary>
	/// Key: "Description.ArchiveWarning"
	/// English String: "Archiving this asset will prevent it from being used in game. Archived assets can be restored."
	/// </summary>
	public override string DescriptionArchiveWarning => "å°å­˜ç´ æå°‡ç„¡æ³•ä½¿ç”¨åœ¨éŠæˆ²è£¡ã€‚å°å­˜ç´ æä¹‹å¾Œå¯ä»¥å¾©åŽŸã€‚";

	/// <summary>
	/// Key: "Description.ClickToAddTag"
	/// Hover text on the button that adds a tag to an item
	/// English String: "Click to add tag"
	/// </summary>
	public override string DescriptionClickToAddTag => "æŒ‰ä¸‹æ–°å¢žæ¨™ç±¤";

	/// <summary>
	/// Key: "Description.ModeratorFileReview"
	/// English String: "* Uploaded file will be reviewed by moderators before being made visible to other users"
	/// </summary>
	public override string DescriptionModeratorFileReview => "ï¼Šä¸Šå‚³çš„æª”æ¡ˆå°‡å…ˆç”±ç®¡ç†å“¡å¯©æ ¸ï¼Œæ‰æœƒé–‹æ”¾å…¶ä»–ä½¿ç”¨è€…æª¢è¦–";

	/// <summary>
	/// Key: "Description.ModeratorReview"
	/// English String: "* Uploaded image will be reviewed by moderators before being made visible to other users"
	/// </summary>
	public override string DescriptionModeratorReview => "ï¼Šä¸Šå‚³çš„åœ–åƒå°‡å…ˆç”±ç®¡ç†å“¡å¯©æ ¸ï¼Œæ‰æœƒé–‹æ”¾å…¶ä»–ä½¿ç”¨è€…æª¢è¦–";

	/// <summary>
	/// Key: "Heading.Archive"
	/// header text for section about archiving assets
	/// English String: "Archive"
	/// </summary>
	public override string HeadingArchive => "å°å­˜";

	/// <summary>
	/// Key: "Heading.Configure"
	/// English String: "Configure"
	/// </summary>
	public override string HeadingConfigure => "è¨­å®š";

	/// <summary>
	/// Key: "Heading.ConfigureItemTags"
	/// Heading on Configure Tags modal
	/// English String: "Configure Tags"
	/// </summary>
	public override string HeadingConfigureItemTags => "è¨­å®šæ¨™ç±¤";

	/// <summary>
	/// Key: "Heading.Create"
	/// English String: "Create"
	/// </summary>
	public override string HeadingCreate => "å‰µä½œ";

	/// <summary>
	/// Key: "Heading.Settings"
	/// English String: "Settings"
	/// </summary>
	public override string HeadingSettings => "è¨­å®š";

	/// <summary>
	/// Key: "Label.AllowCopying"
	/// English String: "Allow Copying"
	/// </summary>
	public override string LabelAllowCopying => "å…è¨±è¤‡è£½";

	/// <summary>
	/// Key: "Label.Archive"
	/// Text on button for archiving an asset. Part of speech: verb
	/// English String: "Archive"
	/// </summary>
	public override string LabelArchive => "å°å­˜";

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
	public override string LabelComputer => "é›»è…¦";

	/// <summary>
	/// Key: "Label.Created"
	/// English String: "Created"
	/// </summary>
	public override string LabelCreated => "å‰µä½œæ™‚é–“";

	/// <summary>
	/// Key: "Label.Current"
	/// English String: "Current"
	/// </summary>
	public override string LabelCurrent => "ç›®å‰";

	/// <summary>
	/// Key: "Label.CurrentPublishedVersion"
	/// English String: "Current published version"
	/// </summary>
	public override string LabelCurrentPublishedVersion => "ç›®å‰ç™¼ä½ˆç‰ˆæœ¬";

	/// <summary>
	/// Key: "Label.Description"
	/// English String: "Description"
	/// </summary>
	public override string LabelDescription => "èªªæ˜Ž";

	/// <summary>
	/// Key: "Label.Device"
	/// device term
	/// English String: "Device"
	/// </summary>
	public override string LabelDevice => "è£ç½®";

	/// <summary>
	/// Key: "Label.EnterItemTag"
	/// Placeholder for input field
	/// English String: "Enter tag here..."
	/// </summary>
	public override string LabelEnterItemTag => "åœ¨æ­¤è¼¸å…¥æ¨™ç±¤â€¦";

	/// <summary>
	/// Key: "Label.Game"
	/// English String: "Game"
	/// </summary>
	public override string LabelGame => "éŠæˆ²";

	/// <summary>
	/// Key: "Label.GamePass"
	/// label
	/// English String: "Game Pass"
	/// </summary>
	public override string LabelGamePass => "éŠæˆ²è­‰";

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
	public override string LabelGoToDetails => "å‰å¾€è©³ç´°è³‡æ–™";

	/// <summary>
	/// Key: "Label.ItemActive"
	/// English String: "Item is Active"
	/// </summary>
	public override string LabelItemActive => "é“å…·å·²å•Ÿç”¨";

	/// <summary>
	/// Key: "Label.ItemForSale"
	/// English String: "Item for Sale"
	/// </summary>
	public override string LabelItemForSale => "é“å…·è²©è³£ä¸­";

	/// <summary>
	/// Key: "Label.LastUpdated"
	/// English String: "Last Updated"
	/// </summary>
	public override string LabelLastUpdated => "æœ€å¾Œæ›´æ–°";

	/// <summary>
	/// Key: "Label.LearnMore"
	/// English String: "Learn more"
	/// </summary>
	public override string LabelLearnMore => "äº†è§£æ›´å¤š";

	/// <summary>
	/// Key: "Label.MarketplaceFee"
	/// English String: "Marketplace Fee"
	/// </summary>
	public override string LabelMarketplaceFee => "å¸‚é›†è²»";

	/// <summary>
	/// Key: "Label.Name"
	/// English String: "Name"
	/// </summary>
	public override string LabelName => "åç¨±";

	/// <summary>
	/// Key: "Label.OpenForComments"
	/// English String: "Open for Comments"
	/// </summary>
	public override string LabelOpenForComments => "é–‹æ”¾ç•™è¨€";

	/// <summary>
	/// Key: "Label.Preview"
	/// English String: "Preview"
	/// </summary>
	public override string LabelPreview => "é è¦½";

	/// <summary>
	/// Key: "Label.Price"
	/// English String: "Price"
	/// </summary>
	public override string LabelPrice => "åƒ¹æ ¼";

	/// <summary>
	/// Key: "Label.Profit"
	/// English String: "You Earn"
	/// </summary>
	public override string LabelProfit => "æ‚¨è³ºå–";

	/// <summary>
	/// Key: "Label.Restore"
	/// English String: "Restore"
	/// </summary>
	public override string LabelRestore => "å¾©åŽŸ";

	/// <summary>
	/// Key: "Label.RevertVersion"
	/// English String: "Revert to this version"
	/// </summary>
	public override string LabelRevertVersion => "é‚„åŽŸåˆ°æ­¤ç‰ˆæœ¬";

	/// <summary>
	/// Key: "Label.Sales"
	/// English String: "Sales"
	/// </summary>
	public override string LabelSales => "è²·è³£";

	/// <summary>
	/// Key: "Label.Save"
	/// English String: "Save"
	/// </summary>
	public override string LabelSave => "å„²å­˜";

	/// <summary>
	/// Key: "Label.SelectType"
	/// Placeholder for dropdown in create asset page. Options are image, mesh, hair accessory, etc
	/// English String: "Select a type"
	/// </summary>
	public override string LabelSelectType => "é¸æ“‡é¡žåž‹";

	/// <summary>
	/// Key: "Label.Tags"
	/// The label next to a list of item tags in the item configuration page
	/// English String: "Tags"
	/// </summary>
	public override string LabelTags => "æ¨™ç±¤";

	/// <summary>
	/// Key: "Label.Type"
	/// English String: "Type"
	/// </summary>
	public override string LabelType => "é¡žåž‹";

	/// <summary>
	/// Key: "Label.Updated"
	/// English String: "Updated"
	/// </summary>
	public override string LabelUpdated => "æ›´æ–°æ™‚é–“";

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
	public override string MessageArchiveError => "å°å­˜å¤±æ•—";

	/// <summary>
	/// Key: "Message.ArchiveSuccess"
	/// English String: "Successfully archived"
	/// </summary>
	public override string MessageArchiveSuccess => "å°å­˜æˆåŠŸ";

	/// <summary>
	/// Key: "Message.DescriptionFieldEmptyError"
	/// English String: "Description cannot be empty"
	/// </summary>
	public override string MessageDescriptionFieldEmptyError => "èªªæ˜Žä¸å¯ç©ºç™½";

	/// <summary>
	/// Key: "Message.DescriptionTooLongError"
	/// error message
	/// English String: "The description is too long."
	/// </summary>
	public override string MessageDescriptionTooLongError => "èªªæ˜ŽéŽé•·ã€‚";

	/// <summary>
	/// Key: "Message.FilteringServiceUnavailableError"
	/// error message
	/// English String: "Text filtering service is unavailable at this time."
	/// </summary>
	public override string MessageFilteringServiceUnavailableError => "ç›®å‰ç„¡æ³•ä½¿ç”¨æ–‡å­—éŽæ¿¾æœå‹™ã€‚";

	/// <summary>
	/// Key: "Message.GamePassConfigDisabledError"
	/// error message
	/// English String: "Game Pass configuration is not enabled yet."
	/// </summary>
	public override string MessageGamePassConfigDisabledError => "éŠæˆ²è­‰è¨­å®šå°šæœªå•Ÿç”¨ã€‚";

	/// <summary>
	/// Key: "Message.GamePassNotFoundError"
	/// errormessage
	/// English String: "The Game Pass does not exist."
	/// </summary>
	public override string MessageGamePassNotFoundError => "æ­¤éŠæˆ²è­‰ä¸å­˜åœ¨ã€‚";

	/// <summary>
	/// Key: "Message.IconUpdateFailed"
	/// error message
	/// English String: "Failed to update icon."
	/// </summary>
	public override string MessageIconUpdateFailed => "ç„¡æ³•æ›´æ–°åœ–ç¤ºã€‚";

	/// <summary>
	/// Key: "Message.ImageSavingFailedError"
	/// error message
	/// English String: "Failed to save image. Please try again later."
	/// </summary>
	public override string MessageImageSavingFailedError => "ç„¡æ³•å„²å­˜åœ–åƒï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";

	/// <summary>
	/// Key: "Message.InappropriateTextError"
	/// error message
	/// English String: "The name or description contains inappropriate text."
	/// </summary>
	public override string MessageInappropriateTextError => "åç¨±æˆ–èªªæ˜Žä¸­å«æœ‰ä¸ç•¶æ–‡å­—ã€‚";

	/// <summary>
	/// Key: "Message.NameFieldEmpty"
	/// English String: "Name cannot be empty"
	/// </summary>
	public override string MessageNameFieldEmpty => "åç¨±ä¸å¯ç©ºç™½";

	/// <summary>
	/// Key: "Message.NameRequiredError"
	/// error message
	/// English String: "The name cannot be empty."
	/// </summary>
	public override string MessageNameRequiredError => "åç¨±ä¸å¯ç©ºç™½ã€‚";

	/// <summary>
	/// Key: "Message.NoTagsFound"
	/// English String: "No tags found"
	/// </summary>
	public override string MessageNoTagsFound => "æ‰¾ä¸åˆ°æ¨™ç±¤";

	/// <summary>
	/// Key: "Message.RestoreError"
	/// English String: "Failed to restore"
	/// </summary>
	public override string MessageRestoreError => "å¾©åŽŸå¤±æ•—";

	/// <summary>
	/// Key: "Message.RestoreSuccess"
	/// English String: "Successfully restored"
	/// </summary>
	public override string MessageRestoreSuccess => "å¾©åŽŸæˆåŠŸ";

	/// <summary>
	/// Key: "Message.SaveError"
	/// English String: "Something failed. Please try again later"
	/// </summary>
	public override string MessageSaveError => "ç™¼ç”ŸéŒ¯èª¤ï¼Œè«‹ç¨å¾Œå†è©¦";

	/// <summary>
	/// Key: "Message.TooManyUploads"
	/// error message
	/// English String: "You are uploading too much. Please try again later."
	/// </summary>
	public override string MessageTooManyUploads => "æ‚¨çš„ä¸Šå‚³æ¬¡æ•¸éŽå¤šï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";

	/// <summary>
	/// Key: "Message.UpdatePriceError"
	/// English String: "Failed to update price"
	/// </summary>
	public override string MessageUpdatePriceError => "ç„¡æ³•æ›´æ–°åƒ¹æ ¼";

	/// <summary>
	/// Key: "Message.UpdatePriceSuccess"
	/// English String: "Successfully updated price"
	/// </summary>
	public override string MessageUpdatePriceSuccess => "æˆåŠŸæ›´æ–°åƒ¹æ ¼";

	/// <summary>
	/// Key: "Message.UpdateSuccess"
	/// English String: "Successfully updated"
	/// </summary>
	public override string MessageUpdateSuccess => "æ›´æ–°æˆåŠŸ";

	public ItemConfigurationResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	/// <summary>
	/// Key: "Description.AcceptableFileFormats"
	/// English String: "* Acceptable file formats: {fileExtensions}"
	/// </summary>
	public override string DescriptionAcceptableFileFormats(string fileExtensions)
	{
		return $"* å¯æŽ¥å—æª”æ¡ˆé¡žåž‹ï¼š{fileExtensions}";
	}

	protected override string _GetTemplateForDescriptionAcceptableFileFormats()
	{
		return "* å¯æŽ¥å—æª”æ¡ˆé¡žåž‹ï¼š{fileExtensions}";
	}

	/// <summary>
	/// Key: "Description.AcceptableFiles"
	/// English String: "* Acceptable files{lineBreak}Format: {fileExtensions}   |   Size: {fileSizes}"
	/// </summary>
	public override string DescriptionAcceptableFiles(string lineBreak, string fileExtensions, string fileSizes)
	{
		return $"* å¯æŽ¥å—çš„æª”æ¡ˆ{lineBreak}æ ¼å¼ï¼š{fileExtensions}\u3000ï½œ\u3000å¤§å°ï¼š{fileSizes}";
	}

	protected override string _GetTemplateForDescriptionAcceptableFiles()
	{
		return "* å¯æŽ¥å—çš„æª”æ¡ˆ{lineBreak}æ ¼å¼ï¼š{fileExtensions}\u3000ï½œ\u3000å¤§å°ï¼š{fileSizes}";
	}

	protected override string _GetTemplateForDescriptionAllowCopying()
	{
		return "è‹¥é–‹å•Ÿæ­¤é¸é …ï¼Œæ‚¨å°‡æŽˆæ¬Šå…¶ä»– Roblox ä½¿ç”¨è€…æŽˆä»¥ä¸åŒæ–¹å¼ä½¿ç”¨æ‚¨ç¾åœ¨åˆ†äº«çš„å…§å®¹ã€‚è‹¥æ‚¨ä¸æƒ³é€²è¡ŒæŽˆæ¬Šï¼Œè«‹å‹¿å‹¾é¸æ­¤æ–¹å¡Šã€‚è‹¥éœ€æ›´å¤šè³‡è¨Šï¼Œè«‹åƒè€ƒ Roblox ä½¿ç”¨æ¢æ¬¾ã€‚";
	}

	/// <summary>
	/// Key: "Description.AllowCopyingWarning"
	/// English String: "By switching on, you are granting every other user of Roblox the right to use (in various ways) the content you are now sharing. If you do not want to grant this right, please do not check this box. For more information about sharing content, please review the Roblox {linkStart}Terms of Use{linkEnd}."
	/// </summary>
	public override string DescriptionAllowCopyingWarning(string linkStart, string linkEnd)
	{
		return $"è‹¥é–‹å•Ÿæ­¤é¸é …ï¼Œæ‚¨å°‡æŽˆæ¬Šå…¶ä»– Roblox ä½¿ç”¨è€…æŽˆä»¥ä¸åŒæ–¹å¼ä½¿ç”¨æ‚¨ç¾åœ¨åˆ†äº«çš„å…§å®¹ã€‚è‹¥æ‚¨ä¸æƒ³é€²è¡ŒæŽˆæ¬Šï¼Œè«‹å‹¿å‹¾é¸æ­¤æ–¹å¡Šã€‚è‹¥éœ€æ›´å¤šè³‡è¨Šï¼Œè«‹åƒè€ƒ Roblox {linkStart}ä½¿ç”¨æ¢æ¬¾{linkEnd}ã€‚";
	}

	protected override string _GetTemplateForDescriptionAllowCopyingWarning()
	{
		return "è‹¥é–‹å•Ÿæ­¤é¸é …ï¼Œæ‚¨å°‡æŽˆæ¬Šå…¶ä»– Roblox ä½¿ç”¨è€…æŽˆä»¥ä¸åŒæ–¹å¼ä½¿ç”¨æ‚¨ç¾åœ¨åˆ†äº«çš„å…§å®¹ã€‚è‹¥æ‚¨ä¸æƒ³é€²è¡ŒæŽˆæ¬Šï¼Œè«‹å‹¿å‹¾é¸æ­¤æ–¹å¡Šã€‚è‹¥éœ€æ›´å¤šè³‡è¨Šï¼Œè«‹åƒè€ƒ Roblox {linkStart}ä½¿ç”¨æ¢æ¬¾{linkEnd}ã€‚";
	}

	protected override string _GetTemplateForDescriptionArchiveWarning()
	{
		return "å°å­˜ç´ æå°‡ç„¡æ³•ä½¿ç”¨åœ¨éŠæˆ²è£¡ã€‚å°å­˜ç´ æä¹‹å¾Œå¯ä»¥å¾©åŽŸã€‚";
	}

	protected override string _GetTemplateForDescriptionClickToAddTag()
	{
		return "æŒ‰ä¸‹æ–°å¢žæ¨™ç±¤";
	}

	/// <summary>
	/// Key: "Description.MarketplaceExplanation"
	/// English String: "(Roblox takes {marketplaceFeePercentage}%, minimum {minimumPrice})"
	/// </summary>
	public override string DescriptionMarketplaceExplanation(string marketplaceFeePercentage, string minimumPrice)
	{
		return $"ï¼ˆRoblox æŠ½å– {marketplaceFeePercentage}%ï¼Œæœ€ä½Ž {minimumPrice}ï¼‰";
	}

	protected override string _GetTemplateForDescriptionMarketplaceExplanation()
	{
		return "ï¼ˆRoblox æŠ½å– {marketplaceFeePercentage}%ï¼Œæœ€ä½Ž {minimumPrice}ï¼‰";
	}

	protected override string _GetTemplateForDescriptionModeratorFileReview()
	{
		return "ï¼Šä¸Šå‚³çš„æª”æ¡ˆå°‡å…ˆç”±ç®¡ç†å“¡å¯©æ ¸ï¼Œæ‰æœƒé–‹æ”¾å…¶ä»–ä½¿ç”¨è€…æª¢è¦–";
	}

	protected override string _GetTemplateForDescriptionModeratorReview()
	{
		return "ï¼Šä¸Šå‚³çš„åœ–åƒå°‡å…ˆç”±ç®¡ç†å“¡å¯©æ ¸ï¼Œæ‰æœƒé–‹æ”¾å…¶ä»–ä½¿ç”¨è€…æª¢è¦–";
	}

	/// <summary>
	/// Key: "Description.SelectItemTags"
	/// itemTagLimit is the number of item tags allowed
	/// English String: "Select up to {itemTagLimit} tags."
	/// </summary>
	public override string DescriptionSelectItemTags(string itemTagLimit)
	{
		return $"æœ€å¤šå¯é¸æ“‡ {itemTagLimit} å€‹æ¨™ç±¤ã€‚";
	}

	protected override string _GetTemplateForDescriptionSelectItemTags()
	{
		return "æœ€å¤šå¯é¸æ“‡ {itemTagLimit} å€‹æ¨™ç±¤ã€‚";
	}

	public override string DescriptionVerifiedCreatorEmail(string linkStart, string linkEnd)
	{
		return $"è‹¥è¦åœ¨å¸‚é›†åˆ†äº«å…§å®¹ï¼Œæ‚¨å¿…é ˆåœ¨å¸³è™Ÿæ–°å¢žä¸¦é©—è­‰ä¸€å€‹é›»å­éƒµä»¶åœ°å€ã€‚æ­¤å‹•ä½œå¯ä»¥åœ¨{linkStart}å¸³è™Ÿè¨­å®š{linkEnd}é€²è¡Œã€‚";
	}

	protected override string _GetTemplateForDescriptionVerifiedCreatorEmail()
	{
		return "è‹¥è¦åœ¨å¸‚é›†åˆ†äº«å…§å®¹ï¼Œæ‚¨å¿…é ˆåœ¨å¸³è™Ÿæ–°å¢žä¸¦é©—è­‰ä¸€å€‹é›»å­éƒµä»¶åœ°å€ã€‚æ­¤å‹•ä½œå¯ä»¥åœ¨{linkStart}å¸³è™Ÿè¨­å®š{linkEnd}é€²è¡Œã€‚";
	}

	protected override string _GetTemplateForHeadingArchive()
	{
		return "å°å­˜";
	}

	protected override string _GetTemplateForHeadingConfigure()
	{
		return "è¨­å®š";
	}

	/// <summary>
	/// Key: "Heading.ConfigureItem"
	/// English String: "Configure {itemType}"
	/// </summary>
	public override string HeadingConfigureItem(string itemType)
	{
		return $"{itemType}è¨­å®š";
	}

	protected override string _GetTemplateForHeadingConfigureItem()
	{
		return "{itemType}è¨­å®š";
	}

	protected override string _GetTemplateForHeadingConfigureItemTags()
	{
		return "è¨­å®šæ¨™ç±¤";
	}

	protected override string _GetTemplateForHeadingCreate()
	{
		return "å‰µä½œ";
	}

	protected override string _GetTemplateForHeadingSettings()
	{
		return "è¨­å®š";
	}

	protected override string _GetTemplateForLabelAllowCopying()
	{
		return "å…è¨±è¤‡è£½";
	}

	protected override string _GetTemplateForLabelArchive()
	{
		return "å°å­˜";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "å–æ¶ˆ";
	}

	protected override string _GetTemplateForLabelComputer()
	{
		return "é›»è…¦";
	}

	protected override string _GetTemplateForLabelCreated()
	{
		return "å‰µä½œæ™‚é–“";
	}

	protected override string _GetTemplateForLabelCurrent()
	{
		return "ç›®å‰";
	}

	protected override string _GetTemplateForLabelCurrentPublishedVersion()
	{
		return "ç›®å‰ç™¼ä½ˆç‰ˆæœ¬";
	}

	protected override string _GetTemplateForLabelDescription()
	{
		return "èªªæ˜Ž";
	}

	protected override string _GetTemplateForLabelDevice()
	{
		return "è£ç½®";
	}

	protected override string _GetTemplateForLabelEnterItemTag()
	{
		return "åœ¨æ­¤è¼¸å…¥æ¨™ç±¤â€¦";
	}

	/// <summary>
	/// Key: "Label.ForItem"
	/// English String: "For {itemType}"
	/// </summary>
	public override string LabelForItem(string itemType)
	{
		return $"{itemType}ç”¨";
	}

	protected override string _GetTemplateForLabelForItem()
	{
		return "{itemType}ç”¨";
	}

	protected override string _GetTemplateForLabelGame()
	{
		return "éŠæˆ²";
	}

	protected override string _GetTemplateForLabelGamePass()
	{
		return "éŠæˆ²è­‰";
	}

	protected override string _GetTemplateForLabelGeneral()
	{
		return "ä¸€èˆ¬";
	}

	protected override string _GetTemplateForLabelGoToDetails()
	{
		return "å‰å¾€è©³ç´°è³‡æ–™";
	}

	protected override string _GetTemplateForLabelItemActive()
	{
		return "é“å…·å·²å•Ÿç”¨";
	}

	protected override string _GetTemplateForLabelItemForSale()
	{
		return "é“å…·è²©è³£ä¸­";
	}

	protected override string _GetTemplateForLabelLastUpdated()
	{
		return "æœ€å¾Œæ›´æ–°";
	}

	protected override string _GetTemplateForLabelLearnMore()
	{
		return "äº†è§£æ›´å¤š";
	}

	protected override string _GetTemplateForLabelMarketplaceFee()
	{
		return "å¸‚é›†è²»";
	}

	protected override string _GetTemplateForLabelName()
	{
		return "åç¨±";
	}

	protected override string _GetTemplateForLabelOpenForComments()
	{
		return "é–‹æ”¾ç•™è¨€";
	}

	protected override string _GetTemplateForLabelPreview()
	{
		return "é è¦½";
	}

	protected override string _GetTemplateForLabelPrice()
	{
		return "åƒ¹æ ¼";
	}

	protected override string _GetTemplateForLabelProfit()
	{
		return "æ‚¨è³ºå–";
	}

	protected override string _GetTemplateForLabelRestore()
	{
		return "å¾©åŽŸ";
	}

	protected override string _GetTemplateForLabelRevertVersion()
	{
		return "é‚„åŽŸåˆ°æ­¤ç‰ˆæœ¬";
	}

	protected override string _GetTemplateForLabelSales()
	{
		return "è²·è³£";
	}

	protected override string _GetTemplateForLabelSave()
	{
		return "å„²å­˜";
	}

	protected override string _GetTemplateForLabelSelectType()
	{
		return "é¸æ“‡é¡žåž‹";
	}

	protected override string _GetTemplateForLabelTags()
	{
		return "æ¨™ç±¤";
	}

	protected override string _GetTemplateForLabelType()
	{
		return "é¡žåž‹";
	}

	protected override string _GetTemplateForLabelUpdated()
	{
		return "æ›´æ–°æ™‚é–“";
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
		return "å°å­˜å¤±æ•—";
	}

	protected override string _GetTemplateForMessageArchiveSuccess()
	{
		return "å°å­˜æˆåŠŸ";
	}

	/// <summary>
	/// Key: "Message.DescriptionFieldEmpty"
	/// English String: "{maxDescriptionLength} character limit"
	/// </summary>
	public override string MessageDescriptionFieldEmpty(string maxDescriptionLength)
	{
		return $"{maxDescriptionLength} å­—å…ƒä¸Šé™";
	}

	protected override string _GetTemplateForMessageDescriptionFieldEmpty()
	{
		return "{maxDescriptionLength} å­—å…ƒä¸Šé™";
	}

	protected override string _GetTemplateForMessageDescriptionFieldEmptyError()
	{
		return "èªªæ˜Žä¸å¯ç©ºç™½";
	}

	/// <summary>
	/// Key: "Message.DescriptionFieldPopulated"
	/// English String: "{descriptionLength}/{maxDescriptionLength} characters"
	/// </summary>
	public override string MessageDescriptionFieldPopulated(string descriptionLength, string maxDescriptionLength)
	{
		return $"{descriptionLength}/{maxDescriptionLength} å€‹å­—å…ƒ";
	}

	protected override string _GetTemplateForMessageDescriptionFieldPopulated()
	{
		return "{descriptionLength}/{maxDescriptionLength} å€‹å­—å…ƒ";
	}

	protected override string _GetTemplateForMessageDescriptionTooLongError()
	{
		return "èªªæ˜ŽéŽé•·ã€‚";
	}

	protected override string _GetTemplateForMessageFilteringServiceUnavailableError()
	{
		return "ç›®å‰ç„¡æ³•ä½¿ç”¨æ–‡å­—éŽæ¿¾æœå‹™ã€‚";
	}

	protected override string _GetTemplateForMessageGamePassConfigDisabledError()
	{
		return "éŠæˆ²è­‰è¨­å®šå°šæœªå•Ÿç”¨ã€‚";
	}

	protected override string _GetTemplateForMessageGamePassNotFoundError()
	{
		return "æ­¤éŠæˆ²è­‰ä¸å­˜åœ¨ã€‚";
	}

	protected override string _GetTemplateForMessageIconUpdateFailed()
	{
		return "ç„¡æ³•æ›´æ–°åœ–ç¤ºã€‚";
	}

	protected override string _GetTemplateForMessageImageSavingFailedError()
	{
		return "ç„¡æ³•å„²å­˜åœ–åƒï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";
	}

	protected override string _GetTemplateForMessageInappropriateTextError()
	{
		return "åç¨±æˆ–èªªæ˜Žä¸­å«æœ‰ä¸ç•¶æ–‡å­—ã€‚";
	}

	/// <summary>
	/// Key: "Message.MinimumPrice"
	/// English String: "You cannot set a price below the minimum price of {minimumPrice}"
	/// </summary>
	public override string MessageMinimumPrice(string minimumPrice)
	{
		return $"åƒ¹æ ¼ç„¡æ³•ä½Žæ–¼æœ€ä½Žåƒ¹æ ¼ {minimumPrice}";
	}

	protected override string _GetTemplateForMessageMinimumPrice()
	{
		return "åƒ¹æ ¼ç„¡æ³•ä½Žæ–¼æœ€ä½Žåƒ¹æ ¼ {minimumPrice}";
	}

	protected override string _GetTemplateForMessageNameFieldEmpty()
	{
		return "åç¨±ä¸å¯ç©ºç™½";
	}

	/// <summary>
	/// Key: "Message.NameFieldPopulated"
	/// English String: "{nameLength}/{maxNameLength} characters"
	/// </summary>
	public override string MessageNameFieldPopulated(string nameLength, string maxNameLength)
	{
		return $"{nameLength}/{maxNameLength} å€‹å­—å…ƒ";
	}

	protected override string _GetTemplateForMessageNameFieldPopulated()
	{
		return "{nameLength}/{maxNameLength} å€‹å­—å…ƒ";
	}

	protected override string _GetTemplateForMessageNameRequiredError()
	{
		return "åç¨±ä¸å¯ç©ºç™½ã€‚";
	}

	protected override string _GetTemplateForMessageNoTagsFound()
	{
		return "æ‰¾ä¸åˆ°æ¨™ç±¤";
	}

	protected override string _GetTemplateForMessageRestoreError()
	{
		return "å¾©åŽŸå¤±æ•—";
	}

	protected override string _GetTemplateForMessageRestoreSuccess()
	{
		return "å¾©åŽŸæˆåŠŸ";
	}

	/// <summary>
	/// Key: "Message.RevertError"
	/// English String: "Failed to revert to version {versionNumber}"
	/// </summary>
	public override string MessageRevertError(string versionNumber)
	{
		return $"ç„¡æ³•é‚„åŽŸåˆ° {versionNumber}";
	}

	protected override string _GetTemplateForMessageRevertError()
	{
		return "ç„¡æ³•é‚„åŽŸåˆ° {versionNumber}";
	}

	/// <summary>
	/// Key: "Message.RevertSuccess"
	/// English String: "Successfully reverted to version {versionNumber}"
	/// </summary>
	public override string MessageRevertSuccess(string versionNumber)
	{
		return $"æˆåŠŸé‚„åŽŸåˆ° {versionNumber}";
	}

	protected override string _GetTemplateForMessageRevertSuccess()
	{
		return "æˆåŠŸé‚„åŽŸåˆ° {versionNumber}";
	}

	protected override string _GetTemplateForMessageSaveError()
	{
		return "ç™¼ç”ŸéŒ¯èª¤ï¼Œè«‹ç¨å¾Œå†è©¦";
	}

	protected override string _GetTemplateForMessageTooManyUploads()
	{
		return "æ‚¨çš„ä¸Šå‚³æ¬¡æ•¸éŽå¤šï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";
	}

	protected override string _GetTemplateForMessageUpdatePriceError()
	{
		return "ç„¡æ³•æ›´æ–°åƒ¹æ ¼";
	}

	protected override string _GetTemplateForMessageUpdatePriceSuccess()
	{
		return "æˆåŠŸæ›´æ–°åƒ¹æ ¼";
	}

	protected override string _GetTemplateForMessageUpdateSuccess()
	{
		return "æ›´æ–°æˆåŠŸ";
	}
}


}
