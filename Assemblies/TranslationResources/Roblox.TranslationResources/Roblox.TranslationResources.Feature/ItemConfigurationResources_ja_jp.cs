namespace Roblox.TranslationResources.Feature;

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
	public override string DescriptionAllowCopying => "オンにすることで、他のすべてのRobloxユーザーに対して、現在シェアしているコンテンツを（さまざまな方法で）使用する権利を与えることに同意したものとみなされます。権利を与えることに同意しない場合、このボックスのチェックを外してください。コンテンツのシェアについての詳細は、Robloxの利用規約を確認してください。";

	/// <summary>
	/// Key: "Description.ArchiveWarning"
	/// English String: "Archiving this asset will prevent it from being used in game. Archived assets can be restored."
	/// </summary>
	public override string DescriptionArchiveWarning => "アセットをアーカイブするとゲームがプレイできなくなります。アーカイブ済みのアセットは復元できます。";

	/// <summary>
	/// Key: "Description.ClickToAddTag"
	/// Hover text on the button that adds a tag to an item
	/// English String: "Click to add tag"
	/// </summary>
	public override string DescriptionClickToAddTag => "クリックしてタグを追加";

	/// <summary>
	/// Key: "Description.ModeratorFileReview"
	/// English String: "* Uploaded file will be reviewed by moderators before being made visible to other users"
	/// </summary>
	public override string DescriptionModeratorFileReview => "* アップロードした画像は、モデレータによるレビュー後、他のユーザーに公開されます";

	/// <summary>
	/// Key: "Description.ModeratorReview"
	/// English String: "* Uploaded image will be reviewed by moderators before being made visible to other users"
	/// </summary>
	public override string DescriptionModeratorReview => "* アップロードした画像は、モデレータによるレビュー後、他のユーザーに公開されます";

	/// <summary>
	/// Key: "Heading.Archive"
	/// header text for section about archiving assets
	/// English String: "Archive"
	/// </summary>
	public override string HeadingArchive => "アーカイブ";

	/// <summary>
	/// Key: "Heading.Configure"
	/// English String: "Configure"
	/// </summary>
	public override string HeadingConfigure => "環境設定する";

	/// <summary>
	/// Key: "Heading.ConfigureItemTags"
	/// Heading on Configure Tags modal
	/// English String: "Configure Tags"
	/// </summary>
	public override string HeadingConfigureItemTags => "タグを環境設定する";

	/// <summary>
	/// Key: "Heading.Create"
	/// English String: "Create"
	/// </summary>
	public override string HeadingCreate => "作成";

	/// <summary>
	/// Key: "Heading.Settings"
	/// English String: "Settings"
	/// </summary>
	public override string HeadingSettings => "設定";

	/// <summary>
	/// Key: "Label.AllowCopying"
	/// English String: "Allow Copying"
	/// </summary>
	public override string LabelAllowCopying => "コピーを許可";

	/// <summary>
	/// Key: "Label.Archive"
	/// Text on button for archiving an asset. Part of speech: verb
	/// English String: "Archive"
	/// </summary>
	public override string LabelArchive => "アーカイブ";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "キャンセル";

	/// <summary>
	/// Key: "Label.Computer"
	/// computer term
	/// English String: "Computer"
	/// </summary>
	public override string LabelComputer => "パソコン";

	/// <summary>
	/// Key: "Label.Created"
	/// English String: "Created"
	/// </summary>
	public override string LabelCreated => "作成しました";

	/// <summary>
	/// Key: "Label.Current"
	/// English String: "Current"
	/// </summary>
	public override string LabelCurrent => "現在のもの";

	/// <summary>
	/// Key: "Label.CurrentPublishedVersion"
	/// English String: "Current published version"
	/// </summary>
	public override string LabelCurrentPublishedVersion => "現在公開済みのバージョン";

	/// <summary>
	/// Key: "Label.Description"
	/// English String: "Description"
	/// </summary>
	public override string LabelDescription => "詳細";

	/// <summary>
	/// Key: "Label.Device"
	/// device term
	/// English String: "Device"
	/// </summary>
	public override string LabelDevice => "デバイス";

	/// <summary>
	/// Key: "Label.EnterItemTag"
	/// Placeholder for input field
	/// English String: "Enter tag here..."
	/// </summary>
	public override string LabelEnterItemTag => "ここにタグを入力...";

	/// <summary>
	/// Key: "Label.Game"
	/// English String: "Game"
	/// </summary>
	public override string LabelGame => "ゲーム";

	/// <summary>
	/// Key: "Label.GamePass"
	/// label
	/// English String: "Game Pass"
	/// </summary>
	public override string LabelGamePass => "ゲームパス";

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
	public override string LabelGoToDetails => "詳細へ";

	/// <summary>
	/// Key: "Label.ItemActive"
	/// English String: "Item is Active"
	/// </summary>
	public override string LabelItemActive => "このアイテムはアクティブです";

	/// <summary>
	/// Key: "Label.ItemForSale"
	/// English String: "Item for Sale"
	/// </summary>
	public override string LabelItemForSale => "販売用アイテム";

	/// <summary>
	/// Key: "Label.LastUpdated"
	/// English String: "Last Updated"
	/// </summary>
	public override string LabelLastUpdated => "最終アップデート";

	/// <summary>
	/// Key: "Label.LearnMore"
	/// English String: "Learn more"
	/// </summary>
	public override string LabelLearnMore => "もっと詳しく";

	/// <summary>
	/// Key: "Label.MarketplaceFee"
	/// English String: "Marketplace Fee"
	/// </summary>
	public override string LabelMarketplaceFee => "マーケットプレース使用料";

	/// <summary>
	/// Key: "Label.Name"
	/// English String: "Name"
	/// </summary>
	public override string LabelName => "名前";

	/// <summary>
	/// Key: "Label.OpenForComments"
	/// English String: "Open for Comments"
	/// </summary>
	public override string LabelOpenForComments => "コメント可能";

	/// <summary>
	/// Key: "Label.Preview"
	/// English String: "Preview"
	/// </summary>
	public override string LabelPreview => "プレビュー";

	/// <summary>
	/// Key: "Label.Price"
	/// English String: "Price"
	/// </summary>
	public override string LabelPrice => "価格";

	/// <summary>
	/// Key: "Label.Profit"
	/// English String: "You Earn"
	/// </summary>
	public override string LabelProfit => "獲得:";

	/// <summary>
	/// Key: "Label.Restore"
	/// English String: "Restore"
	/// </summary>
	public override string LabelRestore => "復元";

	/// <summary>
	/// Key: "Label.RevertVersion"
	/// English String: "Revert to this version"
	/// </summary>
	public override string LabelRevertVersion => "このバージョンに戻す";

	/// <summary>
	/// Key: "Label.Sales"
	/// English String: "Sales"
	/// </summary>
	public override string LabelSales => "セール";

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
	public override string LabelSelectType => "タイプを選択";

	/// <summary>
	/// Key: "Label.Tags"
	/// The label next to a list of item tags in the item configuration page
	/// English String: "Tags"
	/// </summary>
	public override string LabelTags => "タグ";

	/// <summary>
	/// Key: "Label.Type"
	/// English String: "Type"
	/// </summary>
	public override string LabelType => "タイプ";

	/// <summary>
	/// Key: "Label.Updated"
	/// English String: "Updated"
	/// </summary>
	public override string LabelUpdated => "アップデート済み";

	/// <summary>
	/// Key: "Label.Version"
	/// English String: "Version"
	/// </summary>
	public override string LabelVersion => "バージョン";

	/// <summary>
	/// Key: "Label.Versions"
	/// English String: "Versions"
	/// </summary>
	public override string LabelVersions => "バージョン";

	/// <summary>
	/// Key: "Message.ArchiveError"
	/// English String: "Failed to archive"
	/// </summary>
	public override string MessageArchiveError => "アーカイブできませんでした";

	/// <summary>
	/// Key: "Message.ArchiveSuccess"
	/// English String: "Successfully archived"
	/// </summary>
	public override string MessageArchiveSuccess => "アーカイブできました";

	/// <summary>
	/// Key: "Message.DescriptionFieldEmptyError"
	/// English String: "Description cannot be empty"
	/// </summary>
	public override string MessageDescriptionFieldEmptyError => "詳細は空白にできません";

	/// <summary>
	/// Key: "Message.DescriptionTooLongError"
	/// error message
	/// English String: "The description is too long."
	/// </summary>
	public override string MessageDescriptionTooLongError => "詳細が長すぎます。";

	/// <summary>
	/// Key: "Message.FilteringServiceUnavailableError"
	/// error message
	/// English String: "Text filtering service is unavailable at this time."
	/// </summary>
	public override string MessageFilteringServiceUnavailableError => "現在フィルタサービスは利用できません。";

	/// <summary>
	/// Key: "Message.GamePassConfigDisabledError"
	/// error message
	/// English String: "Game Pass configuration is not enabled yet."
	/// </summary>
	public override string MessageGamePassConfigDisabledError => "ゲームパスの設定が有効になっていません。";

	/// <summary>
	/// Key: "Message.GamePassNotFoundError"
	/// errormessage
	/// English String: "The Game Pass does not exist."
	/// </summary>
	public override string MessageGamePassNotFoundError => "ゲームパスが存在しません。";

	/// <summary>
	/// Key: "Message.IconUpdateFailed"
	/// error message
	/// English String: "Failed to update icon."
	/// </summary>
	public override string MessageIconUpdateFailed => "アイコンをアップデートできませんでした。";

	/// <summary>
	/// Key: "Message.ImageSavingFailedError"
	/// error message
	/// English String: "Failed to save image. Please try again later."
	/// </summary>
	public override string MessageImageSavingFailedError => "画像を保存できません。後でもう一度お試しください。";

	/// <summary>
	/// Key: "Message.InappropriateTextError"
	/// error message
	/// English String: "The name or description contains inappropriate text."
	/// </summary>
	public override string MessageInappropriateTextError => "名前または詳細に不適切なテキストが含まれています。";

	/// <summary>
	/// Key: "Message.NameFieldEmpty"
	/// English String: "Name cannot be empty"
	/// </summary>
	public override string MessageNameFieldEmpty => "名前は空白にできません";

	/// <summary>
	/// Key: "Message.NameRequiredError"
	/// error message
	/// English String: "The name cannot be empty."
	/// </summary>
	public override string MessageNameRequiredError => "名前は空白にできません。";

	/// <summary>
	/// Key: "Message.NoTagsFound"
	/// English String: "No tags found"
	/// </summary>
	public override string MessageNoTagsFound => "タグが見つかりません";

	/// <summary>
	/// Key: "Message.RestoreError"
	/// English String: "Failed to restore"
	/// </summary>
	public override string MessageRestoreError => "復元できませんでした";

	/// <summary>
	/// Key: "Message.RestoreSuccess"
	/// English String: "Successfully restored"
	/// </summary>
	public override string MessageRestoreSuccess => "復元できました";

	/// <summary>
	/// Key: "Message.SaveError"
	/// English String: "Something failed. Please try again later"
	/// </summary>
	public override string MessageSaveError => "問題が発生しました。後でもう一度お試しください。";

	/// <summary>
	/// Key: "Message.TooManyUploads"
	/// error message
	/// English String: "You are uploading too much. Please try again later."
	/// </summary>
	public override string MessageTooManyUploads => "アップロード回数が多すぎます。後でもう一度お試しください。";

	/// <summary>
	/// Key: "Message.UpdatePriceError"
	/// English String: "Failed to update price"
	/// </summary>
	public override string MessageUpdatePriceError => "価格をアップデートできませんでした";

	/// <summary>
	/// Key: "Message.UpdatePriceSuccess"
	/// English String: "Successfully updated price"
	/// </summary>
	public override string MessageUpdatePriceSuccess => "価格をアップデートできました";

	/// <summary>
	/// Key: "Message.UpdateSuccess"
	/// English String: "Successfully updated"
	/// </summary>
	public override string MessageUpdateSuccess => "アップデートできました";

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
		return $"* 使用できるファイル形式: {fileExtensions}";
	}

	protected override string _GetTemplateForDescriptionAcceptableFileFormats()
	{
		return "* 使用できるファイル形式: {fileExtensions}";
	}

	/// <summary>
	/// Key: "Description.AcceptableFiles"
	/// English String: "* Acceptable files{lineBreak}Format: {fileExtensions}   |   Size: {fileSizes}"
	/// </summary>
	public override string DescriptionAcceptableFiles(string lineBreak, string fileExtensions, string fileSizes)
	{
		return $"* 使用可能なファイル{lineBreak}形式: {fileExtensions}   |   サイズ: {fileSizes}";
	}

	protected override string _GetTemplateForDescriptionAcceptableFiles()
	{
		return "* 使用可能なファイル{lineBreak}形式: {fileExtensions}   |   サイズ: {fileSizes}";
	}

	protected override string _GetTemplateForDescriptionAllowCopying()
	{
		return "オンにすることで、他のすべてのRobloxユーザーに対して、現在シェアしているコンテンツを（さまざまな方法で）使用する権利を与えることに同意したものとみなされます。権利を与えることに同意しない場合、このボックスのチェックを外してください。コンテンツのシェアについての詳細は、Robloxの利用規約を確認してください。";
	}

	/// <summary>
	/// Key: "Description.AllowCopyingWarning"
	/// English String: "By switching on, you are granting every other user of Roblox the right to use (in various ways) the content you are now sharing. If you do not want to grant this right, please do not check this box. For more information about sharing content, please review the Roblox {linkStart}Terms of Use{linkEnd}."
	/// </summary>
	public override string DescriptionAllowCopyingWarning(string linkStart, string linkEnd)
	{
		return $"オンにすることで、他のすべてのRobloxユーザーに対して、現在シェアしているコンテンツを（さまざまな方法で）使用する権利を与えることに同意したものとみなされます。権利を与えることに同意しない場合、このボックスのチェックを外してください。コンテンツのシェアについての詳細は、Robloxの {linkStart}利用規約{linkEnd}を確認してください。";
	}

	protected override string _GetTemplateForDescriptionAllowCopyingWarning()
	{
		return "オンにすることで、他のすべてのRobloxユーザーに対して、現在シェアしているコンテンツを（さまざまな方法で）使用する権利を与えることに同意したものとみなされます。権利を与えることに同意しない場合、このボックスのチェックを外してください。コンテンツのシェアについての詳細は、Robloxの {linkStart}利用規約{linkEnd}を確認してください。";
	}

	protected override string _GetTemplateForDescriptionArchiveWarning()
	{
		return "アセットをアーカイブするとゲームがプレイできなくなります。アーカイブ済みのアセットは復元できます。";
	}

	protected override string _GetTemplateForDescriptionClickToAddTag()
	{
		return "クリックしてタグを追加";
	}

	/// <summary>
	/// Key: "Description.MarketplaceExplanation"
	/// English String: "(Roblox takes {marketplaceFeePercentage}%, minimum {minimumPrice})"
	/// </summary>
	public override string DescriptionMarketplaceExplanation(string marketplaceFeePercentage, string minimumPrice)
	{
		return $"（Robloxの手数料{marketplaceFeePercentage}%、最低{minimumPrice}）";
	}

	protected override string _GetTemplateForDescriptionMarketplaceExplanation()
	{
		return "（Robloxの手数料{marketplaceFeePercentage}%、最低{minimumPrice}）";
	}

	protected override string _GetTemplateForDescriptionModeratorFileReview()
	{
		return "* アップロードした画像は、モデレータによるレビュー後、他のユーザーに公開されます";
	}

	protected override string _GetTemplateForDescriptionModeratorReview()
	{
		return "* アップロードした画像は、モデレータによるレビュー後、他のユーザーに公開されます";
	}

	/// <summary>
	/// Key: "Description.SelectItemTags"
	/// itemTagLimit is the number of item tags allowed
	/// English String: "Select up to {itemTagLimit} tags."
	/// </summary>
	public override string DescriptionSelectItemTags(string itemTagLimit)
	{
		return $"{itemTagLimit} 件までのタグを選択";
	}

	protected override string _GetTemplateForDescriptionSelectItemTags()
	{
		return "{itemTagLimit} 件までのタグを選択";
	}

	public override string DescriptionVerifiedCreatorEmail(string linkStart, string linkEnd)
	{
		return $"マーケットプレースでコンテンツをシェアするには、お持ちのアカウントにメールアドレスを追加して認証する必要があります。こちらの {linkStart}アカウント設定{linkEnd} でできます。";
	}

	protected override string _GetTemplateForDescriptionVerifiedCreatorEmail()
	{
		return "マーケットプレースでコンテンツをシェアするには、お持ちのアカウントにメールアドレスを追加して認証する必要があります。こちらの {linkStart}アカウント設定{linkEnd} でできます。";
	}

	protected override string _GetTemplateForHeadingArchive()
	{
		return "アーカイブ";
	}

	protected override string _GetTemplateForHeadingConfigure()
	{
		return "環境設定する";
	}

	/// <summary>
	/// Key: "Heading.ConfigureItem"
	/// English String: "Configure {itemType}"
	/// </summary>
	public override string HeadingConfigureItem(string itemType)
	{
		return $"{itemType} を環境設定する";
	}

	protected override string _GetTemplateForHeadingConfigureItem()
	{
		return "{itemType} を環境設定する";
	}

	protected override string _GetTemplateForHeadingConfigureItemTags()
	{
		return "タグを環境設定する";
	}

	protected override string _GetTemplateForHeadingCreate()
	{
		return "作成";
	}

	protected override string _GetTemplateForHeadingSettings()
	{
		return "設定";
	}

	protected override string _GetTemplateForLabelAllowCopying()
	{
		return "コピーを許可";
	}

	protected override string _GetTemplateForLabelArchive()
	{
		return "アーカイブ";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "キャンセル";
	}

	protected override string _GetTemplateForLabelComputer()
	{
		return "パソコン";
	}

	protected override string _GetTemplateForLabelCreated()
	{
		return "作成しました";
	}

	protected override string _GetTemplateForLabelCurrent()
	{
		return "現在のもの";
	}

	protected override string _GetTemplateForLabelCurrentPublishedVersion()
	{
		return "現在公開済みのバージョン";
	}

	protected override string _GetTemplateForLabelDescription()
	{
		return "詳細";
	}

	protected override string _GetTemplateForLabelDevice()
	{
		return "デバイス";
	}

	protected override string _GetTemplateForLabelEnterItemTag()
	{
		return "ここにタグを入力...";
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
		return "ゲーム";
	}

	protected override string _GetTemplateForLabelGamePass()
	{
		return "ゲームパス";
	}

	protected override string _GetTemplateForLabelGeneral()
	{
		return "一般";
	}

	protected override string _GetTemplateForLabelGoToDetails()
	{
		return "詳細へ";
	}

	protected override string _GetTemplateForLabelItemActive()
	{
		return "このアイテムはアクティブです";
	}

	protected override string _GetTemplateForLabelItemForSale()
	{
		return "販売用アイテム";
	}

	protected override string _GetTemplateForLabelLastUpdated()
	{
		return "最終アップデート";
	}

	protected override string _GetTemplateForLabelLearnMore()
	{
		return "もっと詳しく";
	}

	protected override string _GetTemplateForLabelMarketplaceFee()
	{
		return "マーケットプレース使用料";
	}

	protected override string _GetTemplateForLabelName()
	{
		return "名前";
	}

	protected override string _GetTemplateForLabelOpenForComments()
	{
		return "コメント可能";
	}

	protected override string _GetTemplateForLabelPreview()
	{
		return "プレビュー";
	}

	protected override string _GetTemplateForLabelPrice()
	{
		return "価格";
	}

	protected override string _GetTemplateForLabelProfit()
	{
		return "獲得:";
	}

	protected override string _GetTemplateForLabelRestore()
	{
		return "復元";
	}

	protected override string _GetTemplateForLabelRevertVersion()
	{
		return "このバージョンに戻す";
	}

	protected override string _GetTemplateForLabelSales()
	{
		return "セール";
	}

	protected override string _GetTemplateForLabelSave()
	{
		return "保存";
	}

	protected override string _GetTemplateForLabelSelectType()
	{
		return "タイプを選択";
	}

	protected override string _GetTemplateForLabelTags()
	{
		return "タグ";
	}

	protected override string _GetTemplateForLabelType()
	{
		return "タイプ";
	}

	protected override string _GetTemplateForLabelUpdated()
	{
		return "アップデート済み";
	}

	protected override string _GetTemplateForLabelVersion()
	{
		return "バージョン";
	}

	protected override string _GetTemplateForLabelVersions()
	{
		return "バージョン";
	}

	protected override string _GetTemplateForMessageArchiveError()
	{
		return "アーカイブできませんでした";
	}

	protected override string _GetTemplateForMessageArchiveSuccess()
	{
		return "アーカイブできました";
	}

	/// <summary>
	/// Key: "Message.DescriptionFieldEmpty"
	/// English String: "{maxDescriptionLength} character limit"
	/// </summary>
	public override string MessageDescriptionFieldEmpty(string maxDescriptionLength)
	{
		return $"文字数制限は {maxDescriptionLength} 文字まで";
	}

	protected override string _GetTemplateForMessageDescriptionFieldEmpty()
	{
		return "文字数制限は {maxDescriptionLength} 文字まで";
	}

	protected override string _GetTemplateForMessageDescriptionFieldEmptyError()
	{
		return "詳細は空白にできません";
	}

	/// <summary>
	/// Key: "Message.DescriptionFieldPopulated"
	/// English String: "{descriptionLength}/{maxDescriptionLength} characters"
	/// </summary>
	public override string MessageDescriptionFieldPopulated(string descriptionLength, string maxDescriptionLength)
	{
		return $"{descriptionLength}/{maxDescriptionLength} 文字";
	}

	protected override string _GetTemplateForMessageDescriptionFieldPopulated()
	{
		return "{descriptionLength}/{maxDescriptionLength} 文字";
	}

	protected override string _GetTemplateForMessageDescriptionTooLongError()
	{
		return "詳細が長すぎます。";
	}

	protected override string _GetTemplateForMessageFilteringServiceUnavailableError()
	{
		return "現在フィルタサービスは利用できません。";
	}

	protected override string _GetTemplateForMessageGamePassConfigDisabledError()
	{
		return "ゲームパスの設定が有効になっていません。";
	}

	protected override string _GetTemplateForMessageGamePassNotFoundError()
	{
		return "ゲームパスが存在しません。";
	}

	protected override string _GetTemplateForMessageIconUpdateFailed()
	{
		return "アイコンをアップデートできませんでした。";
	}

	protected override string _GetTemplateForMessageImageSavingFailedError()
	{
		return "画像を保存できません。後でもう一度お試しください。";
	}

	protected override string _GetTemplateForMessageInappropriateTextError()
	{
		return "名前または詳細に不適切なテキストが含まれています。";
	}

	/// <summary>
	/// Key: "Message.MinimumPrice"
	/// English String: "You cannot set a price below the minimum price of {minimumPrice}"
	/// </summary>
	public override string MessageMinimumPrice(string minimumPrice)
	{
		return $"{minimumPrice}の最低価格未満の価格を設定することはできません";
	}

	protected override string _GetTemplateForMessageMinimumPrice()
	{
		return "{minimumPrice}の最低価格未満の価格を設定することはできません";
	}

	protected override string _GetTemplateForMessageNameFieldEmpty()
	{
		return "名前は空白にできません";
	}

	/// <summary>
	/// Key: "Message.NameFieldPopulated"
	/// English String: "{nameLength}/{maxNameLength} characters"
	/// </summary>
	public override string MessageNameFieldPopulated(string nameLength, string maxNameLength)
	{
		return $"{nameLength}/{maxNameLength}文字";
	}

	protected override string _GetTemplateForMessageNameFieldPopulated()
	{
		return "{nameLength}/{maxNameLength}文字";
	}

	protected override string _GetTemplateForMessageNameRequiredError()
	{
		return "名前は空白にできません。";
	}

	protected override string _GetTemplateForMessageNoTagsFound()
	{
		return "タグが見つかりません";
	}

	protected override string _GetTemplateForMessageRestoreError()
	{
		return "復元できませんでした";
	}

	protected override string _GetTemplateForMessageRestoreSuccess()
	{
		return "復元できました";
	}

	/// <summary>
	/// Key: "Message.RevertError"
	/// English String: "Failed to revert to version {versionNumber}"
	/// </summary>
	public override string MessageRevertError(string versionNumber)
	{
		return $"{versionNumber} バージョンに戻せませんでした";
	}

	protected override string _GetTemplateForMessageRevertError()
	{
		return "{versionNumber} バージョンに戻せませんでした";
	}

	/// <summary>
	/// Key: "Message.RevertSuccess"
	/// English String: "Successfully reverted to version {versionNumber}"
	/// </summary>
	public override string MessageRevertSuccess(string versionNumber)
	{
		return $"{versionNumber} バージョンに戻しました";
	}

	protected override string _GetTemplateForMessageRevertSuccess()
	{
		return "{versionNumber} バージョンに戻しました";
	}

	protected override string _GetTemplateForMessageSaveError()
	{
		return "問題が発生しました。後でもう一度お試しください。";
	}

	protected override string _GetTemplateForMessageTooManyUploads()
	{
		return "アップロード回数が多すぎます。後でもう一度お試しください。";
	}

	protected override string _GetTemplateForMessageUpdatePriceError()
	{
		return "価格をアップデートできませんでした";
	}

	protected override string _GetTemplateForMessageUpdatePriceSuccess()
	{
		return "価格をアップデートできました";
	}

	protected override string _GetTemplateForMessageUpdateSuccess()
	{
		return "アップデートできました";
	}
}
