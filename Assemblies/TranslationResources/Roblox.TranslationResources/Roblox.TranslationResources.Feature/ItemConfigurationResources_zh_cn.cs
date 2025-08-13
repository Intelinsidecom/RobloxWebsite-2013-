namespace Roblox.TranslationResources.Feature;

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
	public override string DescriptionAllowCopying => "如果开启此选项，即表示你同意授权其他 Roblox 用户 （以各种方式）使用你现在分享的内容。如果你不想进行此项授权，请勿选中此框。如需更多关于分享内容的信息，请参阅 Roblox 使用条款。";

	/// <summary>
	/// Key: "Description.ArchiveWarning"
	/// English String: "Archiving this asset will prevent it from being used in game. Archived assets can be restored."
	/// </summary>
	public override string DescriptionArchiveWarning => "存档此素材后将无法在游戏中使用。存档素材后可以复原。";

	/// <summary>
	/// Key: "Description.ClickToAddTag"
	/// Hover text on the button that adds a tag to an item
	/// English String: "Click to add tag"
	/// </summary>
	public override string DescriptionClickToAddTag => "点按以添加标签";

	/// <summary>
	/// Key: "Description.ModeratorFileReview"
	/// English String: "* Uploaded file will be reviewed by moderators before being made visible to other users"
	/// </summary>
	public override string DescriptionModeratorFileReview => "* 已上传的文件将由管理员审阅，通过后即可对其他用户可见";

	/// <summary>
	/// Key: "Description.ModeratorReview"
	/// English String: "* Uploaded image will be reviewed by moderators before being made visible to other users"
	/// </summary>
	public override string DescriptionModeratorReview => "* 已上传的图像将由管理员审阅，通过后即可对其他用户可见";

	/// <summary>
	/// Key: "Heading.Archive"
	/// header text for section about archiving assets
	/// English String: "Archive"
	/// </summary>
	public override string HeadingArchive => "归档";

	/// <summary>
	/// Key: "Heading.Configure"
	/// English String: "Configure"
	/// </summary>
	public override string HeadingConfigure => "配置";

	/// <summary>
	/// Key: "Heading.ConfigureItemTags"
	/// Heading on Configure Tags modal
	/// English String: "Configure Tags"
	/// </summary>
	public override string HeadingConfigureItemTags => "配置标签";

	/// <summary>
	/// Key: "Heading.Create"
	/// English String: "Create"
	/// </summary>
	public override string HeadingCreate => "创建";

	/// <summary>
	/// Key: "Heading.Settings"
	/// English String: "Settings"
	/// </summary>
	public override string HeadingSettings => "设置";

	/// <summary>
	/// Key: "Label.AllowCopying"
	/// English String: "Allow Copying"
	/// </summary>
	public override string LabelAllowCopying => "允许复制";

	/// <summary>
	/// Key: "Label.Archive"
	/// Text on button for archiving an asset. Part of speech: verb
	/// English String: "Archive"
	/// </summary>
	public override string LabelArchive => "归档";

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
	public override string LabelComputer => "电脑";

	/// <summary>
	/// Key: "Label.Created"
	/// English String: "Created"
	/// </summary>
	public override string LabelCreated => "创建时间";

	/// <summary>
	/// Key: "Label.Current"
	/// English String: "Current"
	/// </summary>
	public override string LabelCurrent => "当前";

	/// <summary>
	/// Key: "Label.CurrentPublishedVersion"
	/// English String: "Current published version"
	/// </summary>
	public override string LabelCurrentPublishedVersion => "当前发布版本";

	/// <summary>
	/// Key: "Label.Description"
	/// English String: "Description"
	/// </summary>
	public override string LabelDescription => "描述";

	/// <summary>
	/// Key: "Label.Device"
	/// device term
	/// English String: "Device"
	/// </summary>
	public override string LabelDevice => "设备";

	/// <summary>
	/// Key: "Label.EnterItemTag"
	/// Placeholder for input field
	/// English String: "Enter tag here..."
	/// </summary>
	public override string LabelEnterItemTag => "在此处输入标签...";

	/// <summary>
	/// Key: "Label.Game"
	/// English String: "Game"
	/// </summary>
	public override string LabelGame => "游戏";

	/// <summary>
	/// Key: "Label.GamePass"
	/// label
	/// English String: "Game Pass"
	/// </summary>
	public override string LabelGamePass => "游戏通行证";

	/// <summary>
	/// Key: "Label.General"
	/// English String: "General"
	/// </summary>
	public override string LabelGeneral => "通用";

	/// <summary>
	/// Key: "Label.GoToDetails"
	/// Link to the item details page from the configure page
	/// English String: "Go to Details"
	/// </summary>
	public override string LabelGoToDetails => "前往详情";

	/// <summary>
	/// Key: "Label.ItemActive"
	/// English String: "Item is Active"
	/// </summary>
	public override string LabelItemActive => "物品已启用";

	/// <summary>
	/// Key: "Label.ItemForSale"
	/// English String: "Item for Sale"
	/// </summary>
	public override string LabelItemForSale => "待售物品";

	/// <summary>
	/// Key: "Label.LastUpdated"
	/// English String: "Last Updated"
	/// </summary>
	public override string LabelLastUpdated => "上次更新";

	/// <summary>
	/// Key: "Label.LearnMore"
	/// English String: "Learn more"
	/// </summary>
	public override string LabelLearnMore => "了解更多";

	/// <summary>
	/// Key: "Label.MarketplaceFee"
	/// English String: "Marketplace Fee"
	/// </summary>
	public override string LabelMarketplaceFee => "市集费";

	/// <summary>
	/// Key: "Label.Name"
	/// English String: "Name"
	/// </summary>
	public override string LabelName => "名称";

	/// <summary>
	/// Key: "Label.OpenForComments"
	/// English String: "Open for Comments"
	/// </summary>
	public override string LabelOpenForComments => "开放评论";

	/// <summary>
	/// Key: "Label.Preview"
	/// English String: "Preview"
	/// </summary>
	public override string LabelPreview => "预览";

	/// <summary>
	/// Key: "Label.Price"
	/// English String: "Price"
	/// </summary>
	public override string LabelPrice => "价格";

	/// <summary>
	/// Key: "Label.Profit"
	/// English String: "You Earn"
	/// </summary>
	public override string LabelProfit => "你赚取";

	/// <summary>
	/// Key: "Label.Restore"
	/// English String: "Restore"
	/// </summary>
	public override string LabelRestore => "复原";

	/// <summary>
	/// Key: "Label.RevertVersion"
	/// English String: "Revert to this version"
	/// </summary>
	public override string LabelRevertVersion => "还原到此版本";

	/// <summary>
	/// Key: "Label.Sales"
	/// English String: "Sales"
	/// </summary>
	public override string LabelSales => "买卖";

	/// <summary>
	/// Key: "Label.Save"
	/// English String: "Save"
	/// </summary>
	public override string LabelSave => "保存";

	/// <summary>
	/// Key: "Label.SelectType"
	/// Placeholder for dropdown in create asset page. Options are image, mesh, hair accessory, etc
	/// English String: "Select a type"
	/// </summary>
	public override string LabelSelectType => "选择类型";

	/// <summary>
	/// Key: "Label.Tags"
	/// The label next to a list of item tags in the item configuration page
	/// English String: "Tags"
	/// </summary>
	public override string LabelTags => "标签";

	/// <summary>
	/// Key: "Label.Type"
	/// English String: "Type"
	/// </summary>
	public override string LabelType => "类型";

	/// <summary>
	/// Key: "Label.Updated"
	/// English String: "Updated"
	/// </summary>
	public override string LabelUpdated => "更新时间";

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
	public override string MessageArchiveError => "无法归档";

	/// <summary>
	/// Key: "Message.ArchiveSuccess"
	/// English String: "Successfully archived"
	/// </summary>
	public override string MessageArchiveSuccess => "归档成功";

	/// <summary>
	/// Key: "Message.DescriptionFieldEmptyError"
	/// English String: "Description cannot be empty"
	/// </summary>
	public override string MessageDescriptionFieldEmptyError => "说明不可为空";

	/// <summary>
	/// Key: "Message.DescriptionTooLongError"
	/// error message
	/// English String: "The description is too long."
	/// </summary>
	public override string MessageDescriptionTooLongError => "描述过长。";

	/// <summary>
	/// Key: "Message.FilteringServiceUnavailableError"
	/// error message
	/// English String: "Text filtering service is unavailable at this time."
	/// </summary>
	public override string MessageFilteringServiceUnavailableError => "目前无法使用文本过滤服务。";

	/// <summary>
	/// Key: "Message.GamePassConfigDisabledError"
	/// error message
	/// English String: "Game Pass configuration is not enabled yet."
	/// </summary>
	public override string MessageGamePassConfigDisabledError => "游戏通行证配置尚未启用。";

	/// <summary>
	/// Key: "Message.GamePassNotFoundError"
	/// errormessage
	/// English String: "The Game Pass does not exist."
	/// </summary>
	public override string MessageGamePassNotFoundError => "游戏通行证不存在。";

	/// <summary>
	/// Key: "Message.IconUpdateFailed"
	/// error message
	/// English String: "Failed to update icon."
	/// </summary>
	public override string MessageIconUpdateFailed => "更新图标失败。";

	/// <summary>
	/// Key: "Message.ImageSavingFailedError"
	/// error message
	/// English String: "Failed to save image. Please try again later."
	/// </summary>
	public override string MessageImageSavingFailedError => "保存图像失败。请稍后重试。";

	/// <summary>
	/// Key: "Message.InappropriateTextError"
	/// error message
	/// English String: "The name or description contains inappropriate text."
	/// </summary>
	public override string MessageInappropriateTextError => "名称或描述包含不当文字。";

	/// <summary>
	/// Key: "Message.NameFieldEmpty"
	/// English String: "Name cannot be empty"
	/// </summary>
	public override string MessageNameFieldEmpty => "名称不能为空";

	/// <summary>
	/// Key: "Message.NameRequiredError"
	/// error message
	/// English String: "The name cannot be empty."
	/// </summary>
	public override string MessageNameRequiredError => "名称不能为空。";

	/// <summary>
	/// Key: "Message.NoTagsFound"
	/// English String: "No tags found"
	/// </summary>
	public override string MessageNoTagsFound => "未找到标签";

	/// <summary>
	/// Key: "Message.RestoreError"
	/// English String: "Failed to restore"
	/// </summary>
	public override string MessageRestoreError => "无法复原";

	/// <summary>
	/// Key: "Message.RestoreSuccess"
	/// English String: "Successfully restored"
	/// </summary>
	public override string MessageRestoreSuccess => "复原成功";

	/// <summary>
	/// Key: "Message.SaveError"
	/// English String: "Something failed. Please try again later"
	/// </summary>
	public override string MessageSaveError => "有地方出错。请稍后重试。";

	/// <summary>
	/// Key: "Message.TooManyUploads"
	/// error message
	/// English String: "You are uploading too much. Please try again later."
	/// </summary>
	public override string MessageTooManyUploads => "你已上传过多文件。请稍候重试。";

	/// <summary>
	/// Key: "Message.UpdatePriceError"
	/// English String: "Failed to update price"
	/// </summary>
	public override string MessageUpdatePriceError => "无法更新价格";

	/// <summary>
	/// Key: "Message.UpdatePriceSuccess"
	/// English String: "Successfully updated price"
	/// </summary>
	public override string MessageUpdatePriceSuccess => "已成功更新价格";

	/// <summary>
	/// Key: "Message.UpdateSuccess"
	/// English String: "Successfully updated"
	/// </summary>
	public override string MessageUpdateSuccess => "已成功更新";

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
		return $"* 可接受的文件格式：{fileExtensions}";
	}

	protected override string _GetTemplateForDescriptionAcceptableFileFormats()
	{
		return "* 可接受的文件格式：{fileExtensions}";
	}

	/// <summary>
	/// Key: "Description.AcceptableFiles"
	/// English String: "* Acceptable files{lineBreak}Format: {fileExtensions}   |   Size: {fileSizes}"
	/// </summary>
	public override string DescriptionAcceptableFiles(string lineBreak, string fileExtensions, string fileSizes)
	{
		return $"* 可接受的文件{lineBreak}格式：{fileExtensions}   |   大小：{fileSizes}";
	}

	protected override string _GetTemplateForDescriptionAcceptableFiles()
	{
		return "* 可接受的文件{lineBreak}格式：{fileExtensions}   |   大小：{fileSizes}";
	}

	protected override string _GetTemplateForDescriptionAllowCopying()
	{
		return "如果开启此选项，即表示你同意授权其他 Roblox 用户 （以各种方式）使用你现在分享的内容。如果你不想进行此项授权，请勿选中此框。如需更多关于分享内容的信息，请参阅 Roblox 使用条款。";
	}

	/// <summary>
	/// Key: "Description.AllowCopyingWarning"
	/// English String: "By switching on, you are granting every other user of Roblox the right to use (in various ways) the content you are now sharing. If you do not want to grant this right, please do not check this box. For more information about sharing content, please review the Roblox {linkStart}Terms of Use{linkEnd}."
	/// </summary>
	public override string DescriptionAllowCopyingWarning(string linkStart, string linkEnd)
	{
		return $"如果开启此选项，即表示你同意授权其他 Roblox 用户 （以各种方式）使用你现在分享的内容。如果你不想进行此项授权，请勿选中此框。如需更多关于分享内容的信息，请参阅 Roblox {linkStart}使用条款{linkEnd}。";
	}

	protected override string _GetTemplateForDescriptionAllowCopyingWarning()
	{
		return "如果开启此选项，即表示你同意授权其他 Roblox 用户 （以各种方式）使用你现在分享的内容。如果你不想进行此项授权，请勿选中此框。如需更多关于分享内容的信息，请参阅 Roblox {linkStart}使用条款{linkEnd}。";
	}

	protected override string _GetTemplateForDescriptionArchiveWarning()
	{
		return "存档此素材后将无法在游戏中使用。存档素材后可以复原。";
	}

	protected override string _GetTemplateForDescriptionClickToAddTag()
	{
		return "点按以添加标签";
	}

	/// <summary>
	/// Key: "Description.MarketplaceExplanation"
	/// English String: "(Roblox takes {marketplaceFeePercentage}%, minimum {minimumPrice})"
	/// </summary>
	public override string DescriptionMarketplaceExplanation(string marketplaceFeePercentage, string minimumPrice)
	{
		return $"（Roblox 收取 {marketplaceFeePercentage}%，最低 {minimumPrice}）";
	}

	protected override string _GetTemplateForDescriptionMarketplaceExplanation()
	{
		return "（Roblox 收取 {marketplaceFeePercentage}%，最低 {minimumPrice}）";
	}

	protected override string _GetTemplateForDescriptionModeratorFileReview()
	{
		return "* 已上传的文件将由管理员审阅，通过后即可对其他用户可见";
	}

	protected override string _GetTemplateForDescriptionModeratorReview()
	{
		return "* 已上传的图像将由管理员审阅，通过后即可对其他用户可见";
	}

	/// <summary>
	/// Key: "Description.SelectItemTags"
	/// itemTagLimit is the number of item tags allowed
	/// English String: "Select up to {itemTagLimit} tags."
	/// </summary>
	public override string DescriptionSelectItemTags(string itemTagLimit)
	{
		return $"最多可选择 {itemTagLimit} 个标签。";
	}

	protected override string _GetTemplateForDescriptionSelectItemTags()
	{
		return "最多可选择 {itemTagLimit} 个标签。";
	}

	public override string DescriptionVerifiedCreatorEmail(string linkStart, string linkEnd)
	{
		return $"若要在市集分享内容，你必须在帐户添加并验证一个电子邮件地址。此动作可以在{linkStart}帐户设置{linkEnd}进行。";
	}

	protected override string _GetTemplateForDescriptionVerifiedCreatorEmail()
	{
		return "若要在市集分享内容，你必须在帐户添加并验证一个电子邮件地址。此动作可以在{linkStart}帐户设置{linkEnd}进行。";
	}

	protected override string _GetTemplateForHeadingArchive()
	{
		return "归档";
	}

	protected override string _GetTemplateForHeadingConfigure()
	{
		return "配置";
	}

	/// <summary>
	/// Key: "Heading.ConfigureItem"
	/// English String: "Configure {itemType}"
	/// </summary>
	public override string HeadingConfigureItem(string itemType)
	{
		return $"配置\"{itemType}\"";
	}

	protected override string _GetTemplateForHeadingConfigureItem()
	{
		return "配置\"{itemType}\"";
	}

	protected override string _GetTemplateForHeadingConfigureItemTags()
	{
		return "配置标签";
	}

	protected override string _GetTemplateForHeadingCreate()
	{
		return "创建";
	}

	protected override string _GetTemplateForHeadingSettings()
	{
		return "设置";
	}

	protected override string _GetTemplateForLabelAllowCopying()
	{
		return "允许复制";
	}

	protected override string _GetTemplateForLabelArchive()
	{
		return "归档";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "取消";
	}

	protected override string _GetTemplateForLabelComputer()
	{
		return "电脑";
	}

	protected override string _GetTemplateForLabelCreated()
	{
		return "创建时间";
	}

	protected override string _GetTemplateForLabelCurrent()
	{
		return "当前";
	}

	protected override string _GetTemplateForLabelCurrentPublishedVersion()
	{
		return "当前发布版本";
	}

	protected override string _GetTemplateForLabelDescription()
	{
		return "描述";
	}

	protected override string _GetTemplateForLabelDevice()
	{
		return "设备";
	}

	protected override string _GetTemplateForLabelEnterItemTag()
	{
		return "在此处输入标签...";
	}

	/// <summary>
	/// Key: "Label.ForItem"
	/// English String: "For {itemType}"
	/// </summary>
	public override string LabelForItem(string itemType)
	{
		return $"为\"{itemType}\"";
	}

	protected override string _GetTemplateForLabelForItem()
	{
		return "为\"{itemType}\"";
	}

	protected override string _GetTemplateForLabelGame()
	{
		return "游戏";
	}

	protected override string _GetTemplateForLabelGamePass()
	{
		return "游戏通行证";
	}

	protected override string _GetTemplateForLabelGeneral()
	{
		return "通用";
	}

	protected override string _GetTemplateForLabelGoToDetails()
	{
		return "前往详情";
	}

	protected override string _GetTemplateForLabelItemActive()
	{
		return "物品已启用";
	}

	protected override string _GetTemplateForLabelItemForSale()
	{
		return "待售物品";
	}

	protected override string _GetTemplateForLabelLastUpdated()
	{
		return "上次更新";
	}

	protected override string _GetTemplateForLabelLearnMore()
	{
		return "了解更多";
	}

	protected override string _GetTemplateForLabelMarketplaceFee()
	{
		return "市集费";
	}

	protected override string _GetTemplateForLabelName()
	{
		return "名称";
	}

	protected override string _GetTemplateForLabelOpenForComments()
	{
		return "开放评论";
	}

	protected override string _GetTemplateForLabelPreview()
	{
		return "预览";
	}

	protected override string _GetTemplateForLabelPrice()
	{
		return "价格";
	}

	protected override string _GetTemplateForLabelProfit()
	{
		return "你赚取";
	}

	protected override string _GetTemplateForLabelRestore()
	{
		return "复原";
	}

	protected override string _GetTemplateForLabelRevertVersion()
	{
		return "还原到此版本";
	}

	protected override string _GetTemplateForLabelSales()
	{
		return "买卖";
	}

	protected override string _GetTemplateForLabelSave()
	{
		return "保存";
	}

	protected override string _GetTemplateForLabelSelectType()
	{
		return "选择类型";
	}

	protected override string _GetTemplateForLabelTags()
	{
		return "标签";
	}

	protected override string _GetTemplateForLabelType()
	{
		return "类型";
	}

	protected override string _GetTemplateForLabelUpdated()
	{
		return "更新时间";
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
		return "无法归档";
	}

	protected override string _GetTemplateForMessageArchiveSuccess()
	{
		return "归档成功";
	}

	/// <summary>
	/// Key: "Message.DescriptionFieldEmpty"
	/// English String: "{maxDescriptionLength} character limit"
	/// </summary>
	public override string MessageDescriptionFieldEmpty(string maxDescriptionLength)
	{
		return $"{maxDescriptionLength} 字符上限";
	}

	protected override string _GetTemplateForMessageDescriptionFieldEmpty()
	{
		return "{maxDescriptionLength} 字符上限";
	}

	protected override string _GetTemplateForMessageDescriptionFieldEmptyError()
	{
		return "说明不可为空";
	}

	/// <summary>
	/// Key: "Message.DescriptionFieldPopulated"
	/// English String: "{descriptionLength}/{maxDescriptionLength} characters"
	/// </summary>
	public override string MessageDescriptionFieldPopulated(string descriptionLength, string maxDescriptionLength)
	{
		return $"{descriptionLength}/{maxDescriptionLength} 个字符";
	}

	protected override string _GetTemplateForMessageDescriptionFieldPopulated()
	{
		return "{descriptionLength}/{maxDescriptionLength} 个字符";
	}

	protected override string _GetTemplateForMessageDescriptionTooLongError()
	{
		return "描述过长。";
	}

	protected override string _GetTemplateForMessageFilteringServiceUnavailableError()
	{
		return "目前无法使用文本过滤服务。";
	}

	protected override string _GetTemplateForMessageGamePassConfigDisabledError()
	{
		return "游戏通行证配置尚未启用。";
	}

	protected override string _GetTemplateForMessageGamePassNotFoundError()
	{
		return "游戏通行证不存在。";
	}

	protected override string _GetTemplateForMessageIconUpdateFailed()
	{
		return "更新图标失败。";
	}

	protected override string _GetTemplateForMessageImageSavingFailedError()
	{
		return "保存图像失败。请稍后重试。";
	}

	protected override string _GetTemplateForMessageInappropriateTextError()
	{
		return "名称或描述包含不当文字。";
	}

	/// <summary>
	/// Key: "Message.MinimumPrice"
	/// English String: "You cannot set a price below the minimum price of {minimumPrice}"
	/// </summary>
	public override string MessageMinimumPrice(string minimumPrice)
	{
		return $"你无法将价格设置为低于最低价格 {minimumPrice}";
	}

	protected override string _GetTemplateForMessageMinimumPrice()
	{
		return "你无法将价格设置为低于最低价格 {minimumPrice}";
	}

	protected override string _GetTemplateForMessageNameFieldEmpty()
	{
		return "名称不能为空";
	}

	/// <summary>
	/// Key: "Message.NameFieldPopulated"
	/// English String: "{nameLength}/{maxNameLength} characters"
	/// </summary>
	public override string MessageNameFieldPopulated(string nameLength, string maxNameLength)
	{
		return $"{nameLength}/{maxNameLength} 个字符";
	}

	protected override string _GetTemplateForMessageNameFieldPopulated()
	{
		return "{nameLength}/{maxNameLength} 个字符";
	}

	protected override string _GetTemplateForMessageNameRequiredError()
	{
		return "名称不能为空。";
	}

	protected override string _GetTemplateForMessageNoTagsFound()
	{
		return "未找到标签";
	}

	protected override string _GetTemplateForMessageRestoreError()
	{
		return "无法复原";
	}

	protected override string _GetTemplateForMessageRestoreSuccess()
	{
		return "复原成功";
	}

	/// <summary>
	/// Key: "Message.RevertError"
	/// English String: "Failed to revert to version {versionNumber}"
	/// </summary>
	public override string MessageRevertError(string versionNumber)
	{
		return $"无法还原到版本 {versionNumber}";
	}

	protected override string _GetTemplateForMessageRevertError()
	{
		return "无法还原到版本 {versionNumber}";
	}

	/// <summary>
	/// Key: "Message.RevertSuccess"
	/// English String: "Successfully reverted to version {versionNumber}"
	/// </summary>
	public override string MessageRevertSuccess(string versionNumber)
	{
		return $"成功还原到版本 {versionNumber}";
	}

	protected override string _GetTemplateForMessageRevertSuccess()
	{
		return "成功还原到版本 {versionNumber}";
	}

	protected override string _GetTemplateForMessageSaveError()
	{
		return "有地方出错。请稍后重试。";
	}

	protected override string _GetTemplateForMessageTooManyUploads()
	{
		return "你已上传过多文件。请稍候重试。";
	}

	protected override string _GetTemplateForMessageUpdatePriceError()
	{
		return "无法更新价格";
	}

	protected override string _GetTemplateForMessageUpdatePriceSuccess()
	{
		return "已成功更新价格";
	}

	protected override string _GetTemplateForMessageUpdateSuccess()
	{
		return "已成功更新";
	}
}
