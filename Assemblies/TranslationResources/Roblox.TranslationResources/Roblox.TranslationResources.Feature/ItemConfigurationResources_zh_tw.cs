namespace Roblox.TranslationResources.Feature;

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
	public override string DescriptionAllowCopying => "若開啟此選項，您將授權其他 Roblox 使用者授以不同方式使用您現在分享的內容。若您不想進行授權，請勿勾選此方塊。若需更多資訊，請參考 Roblox 使用條款。";

	/// <summary>
	/// Key: "Description.ArchiveWarning"
	/// English String: "Archiving this asset will prevent it from being used in game. Archived assets can be restored."
	/// </summary>
	public override string DescriptionArchiveWarning => "封存素材將無法使用在遊戲裡。封存素材之後可以復原。";

	/// <summary>
	/// Key: "Description.ClickToAddTag"
	/// Hover text on the button that adds a tag to an item
	/// English String: "Click to add tag"
	/// </summary>
	public override string DescriptionClickToAddTag => "按下新增標籤";

	/// <summary>
	/// Key: "Description.ModeratorFileReview"
	/// English String: "* Uploaded file will be reviewed by moderators before being made visible to other users"
	/// </summary>
	public override string DescriptionModeratorFileReview => "＊上傳的檔案將先由管理員審核，才會開放其他使用者檢視";

	/// <summary>
	/// Key: "Description.ModeratorReview"
	/// English String: "* Uploaded image will be reviewed by moderators before being made visible to other users"
	/// </summary>
	public override string DescriptionModeratorReview => "＊上傳的圖像將先由管理員審核，才會開放其他使用者檢視";

	/// <summary>
	/// Key: "Heading.Archive"
	/// header text for section about archiving assets
	/// English String: "Archive"
	/// </summary>
	public override string HeadingArchive => "封存";

	/// <summary>
	/// Key: "Heading.Configure"
	/// English String: "Configure"
	/// </summary>
	public override string HeadingConfigure => "設定";

	/// <summary>
	/// Key: "Heading.ConfigureItemTags"
	/// Heading on Configure Tags modal
	/// English String: "Configure Tags"
	/// </summary>
	public override string HeadingConfigureItemTags => "設定標籤";

	/// <summary>
	/// Key: "Heading.Create"
	/// English String: "Create"
	/// </summary>
	public override string HeadingCreate => "創作";

	/// <summary>
	/// Key: "Heading.Settings"
	/// English String: "Settings"
	/// </summary>
	public override string HeadingSettings => "設定";

	/// <summary>
	/// Key: "Label.AllowCopying"
	/// English String: "Allow Copying"
	/// </summary>
	public override string LabelAllowCopying => "允許複製";

	/// <summary>
	/// Key: "Label.Archive"
	/// Text on button for archiving an asset. Part of speech: verb
	/// English String: "Archive"
	/// </summary>
	public override string LabelArchive => "封存";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "取消";

	/// <summary>
	/// Key: "Label.Computer"
	/// computer term
	/// English String: "Computer"
	/// </summary>
	public override string LabelComputer => "電腦";

	/// <summary>
	/// Key: "Label.Created"
	/// English String: "Created"
	/// </summary>
	public override string LabelCreated => "創作時間";

	/// <summary>
	/// Key: "Label.Current"
	/// English String: "Current"
	/// </summary>
	public override string LabelCurrent => "目前";

	/// <summary>
	/// Key: "Label.CurrentPublishedVersion"
	/// English String: "Current published version"
	/// </summary>
	public override string LabelCurrentPublishedVersion => "目前發佈版本";

	/// <summary>
	/// Key: "Label.Description"
	/// English String: "Description"
	/// </summary>
	public override string LabelDescription => "說明";

	/// <summary>
	/// Key: "Label.Device"
	/// device term
	/// English String: "Device"
	/// </summary>
	public override string LabelDevice => "裝置";

	/// <summary>
	/// Key: "Label.EnterItemTag"
	/// Placeholder for input field
	/// English String: "Enter tag here..."
	/// </summary>
	public override string LabelEnterItemTag => "在此輸入標籤…";

	/// <summary>
	/// Key: "Label.Game"
	/// English String: "Game"
	/// </summary>
	public override string LabelGame => "遊戲";

	/// <summary>
	/// Key: "Label.GamePass"
	/// label
	/// English String: "Game Pass"
	/// </summary>
	public override string LabelGamePass => "遊戲證";

	/// <summary>
	/// Key: "Label.General"
	/// English String: "General"
	/// </summary>
	public override string LabelGeneral => "一般";

	/// <summary>
	/// Key: "Label.GoToDetails"
	/// Link to the item details page from the configure page
	/// English String: "Go to Details"
	/// </summary>
	public override string LabelGoToDetails => "前往詳細資料";

	/// <summary>
	/// Key: "Label.ItemActive"
	/// English String: "Item is Active"
	/// </summary>
	public override string LabelItemActive => "道具已啟用";

	/// <summary>
	/// Key: "Label.ItemForSale"
	/// English String: "Item for Sale"
	/// </summary>
	public override string LabelItemForSale => "道具販賣中";

	/// <summary>
	/// Key: "Label.LastUpdated"
	/// English String: "Last Updated"
	/// </summary>
	public override string LabelLastUpdated => "最後更新";

	/// <summary>
	/// Key: "Label.LearnMore"
	/// English String: "Learn more"
	/// </summary>
	public override string LabelLearnMore => "了解更多";

	/// <summary>
	/// Key: "Label.MarketplaceFee"
	/// English String: "Marketplace Fee"
	/// </summary>
	public override string LabelMarketplaceFee => "市集費";

	/// <summary>
	/// Key: "Label.Name"
	/// English String: "Name"
	/// </summary>
	public override string LabelName => "名稱";

	/// <summary>
	/// Key: "Label.OpenForComments"
	/// English String: "Open for Comments"
	/// </summary>
	public override string LabelOpenForComments => "開放留言";

	/// <summary>
	/// Key: "Label.Preview"
	/// English String: "Preview"
	/// </summary>
	public override string LabelPreview => "預覽";

	/// <summary>
	/// Key: "Label.Price"
	/// English String: "Price"
	/// </summary>
	public override string LabelPrice => "價格";

	/// <summary>
	/// Key: "Label.Profit"
	/// English String: "You Earn"
	/// </summary>
	public override string LabelProfit => "您賺取";

	/// <summary>
	/// Key: "Label.Restore"
	/// English String: "Restore"
	/// </summary>
	public override string LabelRestore => "復原";

	/// <summary>
	/// Key: "Label.RevertVersion"
	/// English String: "Revert to this version"
	/// </summary>
	public override string LabelRevertVersion => "還原到此版本";

	/// <summary>
	/// Key: "Label.Sales"
	/// English String: "Sales"
	/// </summary>
	public override string LabelSales => "買賣";

	/// <summary>
	/// Key: "Label.Save"
	/// English String: "Save"
	/// </summary>
	public override string LabelSave => "儲存";

	/// <summary>
	/// Key: "Label.SelectType"
	/// Placeholder for dropdown in create asset page. Options are image, mesh, hair accessory, etc
	/// English String: "Select a type"
	/// </summary>
	public override string LabelSelectType => "選擇類型";

	/// <summary>
	/// Key: "Label.Tags"
	/// The label next to a list of item tags in the item configuration page
	/// English String: "Tags"
	/// </summary>
	public override string LabelTags => "標籤";

	/// <summary>
	/// Key: "Label.Type"
	/// English String: "Type"
	/// </summary>
	public override string LabelType => "類型";

	/// <summary>
	/// Key: "Label.Updated"
	/// English String: "Updated"
	/// </summary>
	public override string LabelUpdated => "更新時間";

	/// <summary>
	/// Key: "Label.Version"
	/// English String: "Version"
	/// </summary>
	public override string LabelVersion => "版本";

	/// <summary>
	/// Key: "Label.Versions"
	/// English String: "Versions"
	/// </summary>
	public override string LabelVersions => "版本";

	/// <summary>
	/// Key: "Message.ArchiveError"
	/// English String: "Failed to archive"
	/// </summary>
	public override string MessageArchiveError => "封存失敗";

	/// <summary>
	/// Key: "Message.ArchiveSuccess"
	/// English String: "Successfully archived"
	/// </summary>
	public override string MessageArchiveSuccess => "封存成功";

	/// <summary>
	/// Key: "Message.DescriptionFieldEmptyError"
	/// English String: "Description cannot be empty"
	/// </summary>
	public override string MessageDescriptionFieldEmptyError => "說明不可空白";

	/// <summary>
	/// Key: "Message.DescriptionTooLongError"
	/// error message
	/// English String: "The description is too long."
	/// </summary>
	public override string MessageDescriptionTooLongError => "說明過長。";

	/// <summary>
	/// Key: "Message.FilteringServiceUnavailableError"
	/// error message
	/// English String: "Text filtering service is unavailable at this time."
	/// </summary>
	public override string MessageFilteringServiceUnavailableError => "目前無法使用文字過濾服務。";

	/// <summary>
	/// Key: "Message.GamePassConfigDisabledError"
	/// error message
	/// English String: "Game Pass configuration is not enabled yet."
	/// </summary>
	public override string MessageGamePassConfigDisabledError => "遊戲證設定尚未啟用。";

	/// <summary>
	/// Key: "Message.GamePassNotFoundError"
	/// errormessage
	/// English String: "The Game Pass does not exist."
	/// </summary>
	public override string MessageGamePassNotFoundError => "此遊戲證不存在。";

	/// <summary>
	/// Key: "Message.IconUpdateFailed"
	/// error message
	/// English String: "Failed to update icon."
	/// </summary>
	public override string MessageIconUpdateFailed => "無法更新圖示。";

	/// <summary>
	/// Key: "Message.ImageSavingFailedError"
	/// error message
	/// English String: "Failed to save image. Please try again later."
	/// </summary>
	public override string MessageImageSavingFailedError => "無法儲存圖像，請稍後再試。";

	/// <summary>
	/// Key: "Message.InappropriateTextError"
	/// error message
	/// English String: "The name or description contains inappropriate text."
	/// </summary>
	public override string MessageInappropriateTextError => "名稱或說明中含有不當文字。";

	/// <summary>
	/// Key: "Message.NameFieldEmpty"
	/// English String: "Name cannot be empty"
	/// </summary>
	public override string MessageNameFieldEmpty => "名稱不可空白";

	/// <summary>
	/// Key: "Message.NameRequiredError"
	/// error message
	/// English String: "The name cannot be empty."
	/// </summary>
	public override string MessageNameRequiredError => "名稱不可空白。";

	/// <summary>
	/// Key: "Message.NoTagsFound"
	/// English String: "No tags found"
	/// </summary>
	public override string MessageNoTagsFound => "找不到標籤";

	/// <summary>
	/// Key: "Message.RestoreError"
	/// English String: "Failed to restore"
	/// </summary>
	public override string MessageRestoreError => "復原失敗";

	/// <summary>
	/// Key: "Message.RestoreSuccess"
	/// English String: "Successfully restored"
	/// </summary>
	public override string MessageRestoreSuccess => "復原成功";

	/// <summary>
	/// Key: "Message.SaveError"
	/// English String: "Something failed. Please try again later"
	/// </summary>
	public override string MessageSaveError => "發生錯誤，請稍後再試";

	/// <summary>
	/// Key: "Message.TooManyUploads"
	/// error message
	/// English String: "You are uploading too much. Please try again later."
	/// </summary>
	public override string MessageTooManyUploads => "您的上傳次數過多，請稍後再試。";

	/// <summary>
	/// Key: "Message.UpdatePriceError"
	/// English String: "Failed to update price"
	/// </summary>
	public override string MessageUpdatePriceError => "無法更新價格";

	/// <summary>
	/// Key: "Message.UpdatePriceSuccess"
	/// English String: "Successfully updated price"
	/// </summary>
	public override string MessageUpdatePriceSuccess => "成功更新價格";

	/// <summary>
	/// Key: "Message.UpdateSuccess"
	/// English String: "Successfully updated"
	/// </summary>
	public override string MessageUpdateSuccess => "更新成功";

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
		return $"* 可接受檔案類型：{fileExtensions}";
	}

	protected override string _GetTemplateForDescriptionAcceptableFileFormats()
	{
		return "* 可接受檔案類型：{fileExtensions}";
	}

	/// <summary>
	/// Key: "Description.AcceptableFiles"
	/// English String: "* Acceptable files{lineBreak}Format: {fileExtensions}   |   Size: {fileSizes}"
	/// </summary>
	public override string DescriptionAcceptableFiles(string lineBreak, string fileExtensions, string fileSizes)
	{
		return $"* 可接受的檔案{lineBreak}格式：{fileExtensions}\u3000｜\u3000大小：{fileSizes}";
	}

	protected override string _GetTemplateForDescriptionAcceptableFiles()
	{
		return "* 可接受的檔案{lineBreak}格式：{fileExtensions}\u3000｜\u3000大小：{fileSizes}";
	}

	protected override string _GetTemplateForDescriptionAllowCopying()
	{
		return "若開啟此選項，您將授權其他 Roblox 使用者授以不同方式使用您現在分享的內容。若您不想進行授權，請勿勾選此方塊。若需更多資訊，請參考 Roblox 使用條款。";
	}

	/// <summary>
	/// Key: "Description.AllowCopyingWarning"
	/// English String: "By switching on, you are granting every other user of Roblox the right to use (in various ways) the content you are now sharing. If you do not want to grant this right, please do not check this box. For more information about sharing content, please review the Roblox {linkStart}Terms of Use{linkEnd}."
	/// </summary>
	public override string DescriptionAllowCopyingWarning(string linkStart, string linkEnd)
	{
		return $"若開啟此選項，您將授權其他 Roblox 使用者授以不同方式使用您現在分享的內容。若您不想進行授權，請勿勾選此方塊。若需更多資訊，請參考 Roblox {linkStart}使用條款{linkEnd}。";
	}

	protected override string _GetTemplateForDescriptionAllowCopyingWarning()
	{
		return "若開啟此選項，您將授權其他 Roblox 使用者授以不同方式使用您現在分享的內容。若您不想進行授權，請勿勾選此方塊。若需更多資訊，請參考 Roblox {linkStart}使用條款{linkEnd}。";
	}

	protected override string _GetTemplateForDescriptionArchiveWarning()
	{
		return "封存素材將無法使用在遊戲裡。封存素材之後可以復原。";
	}

	protected override string _GetTemplateForDescriptionClickToAddTag()
	{
		return "按下新增標籤";
	}

	/// <summary>
	/// Key: "Description.MarketplaceExplanation"
	/// English String: "(Roblox takes {marketplaceFeePercentage}%, minimum {minimumPrice})"
	/// </summary>
	public override string DescriptionMarketplaceExplanation(string marketplaceFeePercentage, string minimumPrice)
	{
		return $"（Roblox 抽取 {marketplaceFeePercentage}%，最低 {minimumPrice}）";
	}

	protected override string _GetTemplateForDescriptionMarketplaceExplanation()
	{
		return "（Roblox 抽取 {marketplaceFeePercentage}%，最低 {minimumPrice}）";
	}

	protected override string _GetTemplateForDescriptionModeratorFileReview()
	{
		return "＊上傳的檔案將先由管理員審核，才會開放其他使用者檢視";
	}

	protected override string _GetTemplateForDescriptionModeratorReview()
	{
		return "＊上傳的圖像將先由管理員審核，才會開放其他使用者檢視";
	}

	/// <summary>
	/// Key: "Description.SelectItemTags"
	/// itemTagLimit is the number of item tags allowed
	/// English String: "Select up to {itemTagLimit} tags."
	/// </summary>
	public override string DescriptionSelectItemTags(string itemTagLimit)
	{
		return $"最多可選擇 {itemTagLimit} 個標籤。";
	}

	protected override string _GetTemplateForDescriptionSelectItemTags()
	{
		return "最多可選擇 {itemTagLimit} 個標籤。";
	}

	public override string DescriptionVerifiedCreatorEmail(string linkStart, string linkEnd)
	{
		return $"若要在市集分享內容，您必須在帳號新增並驗證一個電子郵件地址。此動作可以在{linkStart}帳號設定{linkEnd}進行。";
	}

	protected override string _GetTemplateForDescriptionVerifiedCreatorEmail()
	{
		return "若要在市集分享內容，您必須在帳號新增並驗證一個電子郵件地址。此動作可以在{linkStart}帳號設定{linkEnd}進行。";
	}

	protected override string _GetTemplateForHeadingArchive()
	{
		return "封存";
	}

	protected override string _GetTemplateForHeadingConfigure()
	{
		return "設定";
	}

	/// <summary>
	/// Key: "Heading.ConfigureItem"
	/// English String: "Configure {itemType}"
	/// </summary>
	public override string HeadingConfigureItem(string itemType)
	{
		return $"{itemType}設定";
	}

	protected override string _GetTemplateForHeadingConfigureItem()
	{
		return "{itemType}設定";
	}

	protected override string _GetTemplateForHeadingConfigureItemTags()
	{
		return "設定標籤";
	}

	protected override string _GetTemplateForHeadingCreate()
	{
		return "創作";
	}

	protected override string _GetTemplateForHeadingSettings()
	{
		return "設定";
	}

	protected override string _GetTemplateForLabelAllowCopying()
	{
		return "允許複製";
	}

	protected override string _GetTemplateForLabelArchive()
	{
		return "封存";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "取消";
	}

	protected override string _GetTemplateForLabelComputer()
	{
		return "電腦";
	}

	protected override string _GetTemplateForLabelCreated()
	{
		return "創作時間";
	}

	protected override string _GetTemplateForLabelCurrent()
	{
		return "目前";
	}

	protected override string _GetTemplateForLabelCurrentPublishedVersion()
	{
		return "目前發佈版本";
	}

	protected override string _GetTemplateForLabelDescription()
	{
		return "說明";
	}

	protected override string _GetTemplateForLabelDevice()
	{
		return "裝置";
	}

	protected override string _GetTemplateForLabelEnterItemTag()
	{
		return "在此輸入標籤…";
	}

	/// <summary>
	/// Key: "Label.ForItem"
	/// English String: "For {itemType}"
	/// </summary>
	public override string LabelForItem(string itemType)
	{
		return $"{itemType}用";
	}

	protected override string _GetTemplateForLabelForItem()
	{
		return "{itemType}用";
	}

	protected override string _GetTemplateForLabelGame()
	{
		return "遊戲";
	}

	protected override string _GetTemplateForLabelGamePass()
	{
		return "遊戲證";
	}

	protected override string _GetTemplateForLabelGeneral()
	{
		return "一般";
	}

	protected override string _GetTemplateForLabelGoToDetails()
	{
		return "前往詳細資料";
	}

	protected override string _GetTemplateForLabelItemActive()
	{
		return "道具已啟用";
	}

	protected override string _GetTemplateForLabelItemForSale()
	{
		return "道具販賣中";
	}

	protected override string _GetTemplateForLabelLastUpdated()
	{
		return "最後更新";
	}

	protected override string _GetTemplateForLabelLearnMore()
	{
		return "了解更多";
	}

	protected override string _GetTemplateForLabelMarketplaceFee()
	{
		return "市集費";
	}

	protected override string _GetTemplateForLabelName()
	{
		return "名稱";
	}

	protected override string _GetTemplateForLabelOpenForComments()
	{
		return "開放留言";
	}

	protected override string _GetTemplateForLabelPreview()
	{
		return "預覽";
	}

	protected override string _GetTemplateForLabelPrice()
	{
		return "價格";
	}

	protected override string _GetTemplateForLabelProfit()
	{
		return "您賺取";
	}

	protected override string _GetTemplateForLabelRestore()
	{
		return "復原";
	}

	protected override string _GetTemplateForLabelRevertVersion()
	{
		return "還原到此版本";
	}

	protected override string _GetTemplateForLabelSales()
	{
		return "買賣";
	}

	protected override string _GetTemplateForLabelSave()
	{
		return "儲存";
	}

	protected override string _GetTemplateForLabelSelectType()
	{
		return "選擇類型";
	}

	protected override string _GetTemplateForLabelTags()
	{
		return "標籤";
	}

	protected override string _GetTemplateForLabelType()
	{
		return "類型";
	}

	protected override string _GetTemplateForLabelUpdated()
	{
		return "更新時間";
	}

	protected override string _GetTemplateForLabelVersion()
	{
		return "版本";
	}

	protected override string _GetTemplateForLabelVersions()
	{
		return "版本";
	}

	protected override string _GetTemplateForMessageArchiveError()
	{
		return "封存失敗";
	}

	protected override string _GetTemplateForMessageArchiveSuccess()
	{
		return "封存成功";
	}

	/// <summary>
	/// Key: "Message.DescriptionFieldEmpty"
	/// English String: "{maxDescriptionLength} character limit"
	/// </summary>
	public override string MessageDescriptionFieldEmpty(string maxDescriptionLength)
	{
		return $"{maxDescriptionLength} 字元上限";
	}

	protected override string _GetTemplateForMessageDescriptionFieldEmpty()
	{
		return "{maxDescriptionLength} 字元上限";
	}

	protected override string _GetTemplateForMessageDescriptionFieldEmptyError()
	{
		return "說明不可空白";
	}

	/// <summary>
	/// Key: "Message.DescriptionFieldPopulated"
	/// English String: "{descriptionLength}/{maxDescriptionLength} characters"
	/// </summary>
	public override string MessageDescriptionFieldPopulated(string descriptionLength, string maxDescriptionLength)
	{
		return $"{descriptionLength}/{maxDescriptionLength} 個字元";
	}

	protected override string _GetTemplateForMessageDescriptionFieldPopulated()
	{
		return "{descriptionLength}/{maxDescriptionLength} 個字元";
	}

	protected override string _GetTemplateForMessageDescriptionTooLongError()
	{
		return "說明過長。";
	}

	protected override string _GetTemplateForMessageFilteringServiceUnavailableError()
	{
		return "目前無法使用文字過濾服務。";
	}

	protected override string _GetTemplateForMessageGamePassConfigDisabledError()
	{
		return "遊戲證設定尚未啟用。";
	}

	protected override string _GetTemplateForMessageGamePassNotFoundError()
	{
		return "此遊戲證不存在。";
	}

	protected override string _GetTemplateForMessageIconUpdateFailed()
	{
		return "無法更新圖示。";
	}

	protected override string _GetTemplateForMessageImageSavingFailedError()
	{
		return "無法儲存圖像，請稍後再試。";
	}

	protected override string _GetTemplateForMessageInappropriateTextError()
	{
		return "名稱或說明中含有不當文字。";
	}

	/// <summary>
	/// Key: "Message.MinimumPrice"
	/// English String: "You cannot set a price below the minimum price of {minimumPrice}"
	/// </summary>
	public override string MessageMinimumPrice(string minimumPrice)
	{
		return $"價格無法低於最低價格 {minimumPrice}";
	}

	protected override string _GetTemplateForMessageMinimumPrice()
	{
		return "價格無法低於最低價格 {minimumPrice}";
	}

	protected override string _GetTemplateForMessageNameFieldEmpty()
	{
		return "名稱不可空白";
	}

	/// <summary>
	/// Key: "Message.NameFieldPopulated"
	/// English String: "{nameLength}/{maxNameLength} characters"
	/// </summary>
	public override string MessageNameFieldPopulated(string nameLength, string maxNameLength)
	{
		return $"{nameLength}/{maxNameLength} 個字元";
	}

	protected override string _GetTemplateForMessageNameFieldPopulated()
	{
		return "{nameLength}/{maxNameLength} 個字元";
	}

	protected override string _GetTemplateForMessageNameRequiredError()
	{
		return "名稱不可空白。";
	}

	protected override string _GetTemplateForMessageNoTagsFound()
	{
		return "找不到標籤";
	}

	protected override string _GetTemplateForMessageRestoreError()
	{
		return "復原失敗";
	}

	protected override string _GetTemplateForMessageRestoreSuccess()
	{
		return "復原成功";
	}

	/// <summary>
	/// Key: "Message.RevertError"
	/// English String: "Failed to revert to version {versionNumber}"
	/// </summary>
	public override string MessageRevertError(string versionNumber)
	{
		return $"無法還原到 {versionNumber}";
	}

	protected override string _GetTemplateForMessageRevertError()
	{
		return "無法還原到 {versionNumber}";
	}

	/// <summary>
	/// Key: "Message.RevertSuccess"
	/// English String: "Successfully reverted to version {versionNumber}"
	/// </summary>
	public override string MessageRevertSuccess(string versionNumber)
	{
		return $"成功還原到 {versionNumber}";
	}

	protected override string _GetTemplateForMessageRevertSuccess()
	{
		return "成功還原到 {versionNumber}";
	}

	protected override string _GetTemplateForMessageSaveError()
	{
		return "發生錯誤，請稍後再試";
	}

	protected override string _GetTemplateForMessageTooManyUploads()
	{
		return "您的上傳次數過多，請稍後再試。";
	}

	protected override string _GetTemplateForMessageUpdatePriceError()
	{
		return "無法更新價格";
	}

	protected override string _GetTemplateForMessageUpdatePriceSuccess()
	{
		return "成功更新價格";
	}

	protected override string _GetTemplateForMessageUpdateSuccess()
	{
		return "更新成功";
	}
}
