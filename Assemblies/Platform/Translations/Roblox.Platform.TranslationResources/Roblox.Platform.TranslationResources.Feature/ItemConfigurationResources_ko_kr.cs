namespace Roblox.TranslationResources.Feature;

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
	public override string DescriptionAllowCopying => "본 확인란을 선택하면 회원님이 지금 공유하려는 콘텐츠를 Roblox의 모든 사용자가 다양한 방식으로 사용할 수 있게 됩니다. 사용을 허락하지 않으려면 확인란을 선택하지 마세요. 콘텐츠 공유에 관한 자세한 정보는 Roblox 이용 약관을 참고하세요.";

	/// <summary>
	/// Key: "Description.ArchiveWarning"
	/// English String: "Archiving this asset will prevent it from being used in game. Archived assets can be restored."
	/// </summary>
	public override string DescriptionArchiveWarning => "애셋을 보관하면 게임에서 사용할 수 없어요. 보관했던 애셋은 나중에 복원 가능해요.";

	/// <summary>
	/// Key: "Description.ClickToAddTag"
	/// Hover text on the button that adds a tag to an item
	/// English String: "Click to add tag"
	/// </summary>
	public override string DescriptionClickToAddTag => "태그를 추가하려면 클릭";

	/// <summary>
	/// Key: "Description.ModeratorFileReview"
	/// English String: "* Uploaded file will be reviewed by moderators before being made visible to other users"
	/// </summary>
	public override string DescriptionModeratorFileReview => "* 업로드한 파일은 검열팀의 검토가 끝난 후에 다른 사용자에게 공개됩니다";

	/// <summary>
	/// Key: "Description.ModeratorReview"
	/// English String: "* Uploaded image will be reviewed by moderators before being made visible to other users"
	/// </summary>
	public override string DescriptionModeratorReview => "* 업로드한 이미지는 검열팀의 검토가 끝난 후에 다른 사용자에게 공개됩니다";

	/// <summary>
	/// Key: "Heading.Archive"
	/// header text for section about archiving assets
	/// English String: "Archive"
	/// </summary>
	public override string HeadingArchive => "보관";

	/// <summary>
	/// Key: "Heading.Configure"
	/// English String: "Configure"
	/// </summary>
	public override string HeadingConfigure => "구성";

	/// <summary>
	/// Key: "Heading.ConfigureItemTags"
	/// Heading on Configure Tags modal
	/// English String: "Configure Tags"
	/// </summary>
	public override string HeadingConfigureItemTags => "태그 구성";

	/// <summary>
	/// Key: "Heading.Create"
	/// English String: "Create"
	/// </summary>
	public override string HeadingCreate => "만들기";

	/// <summary>
	/// Key: "Heading.Settings"
	/// English String: "Settings"
	/// </summary>
	public override string HeadingSettings => "설정";

	/// <summary>
	/// Key: "Label.AllowCopying"
	/// English String: "Allow Copying"
	/// </summary>
	public override string LabelAllowCopying => "복사 허용";

	/// <summary>
	/// Key: "Label.Archive"
	/// Text on button for archiving an asset. Part of speech: verb
	/// English String: "Archive"
	/// </summary>
	public override string LabelArchive => "보관";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "취소";

	/// <summary>
	/// Key: "Label.Computer"
	/// computer term
	/// English String: "Computer"
	/// </summary>
	public override string LabelComputer => "컴퓨터";

	/// <summary>
	/// Key: "Label.Created"
	/// English String: "Created"
	/// </summary>
	public override string LabelCreated => "개발 완료";

	/// <summary>
	/// Key: "Label.Current"
	/// English String: "Current"
	/// </summary>
	public override string LabelCurrent => "현재";

	/// <summary>
	/// Key: "Label.CurrentPublishedVersion"
	/// English String: "Current published version"
	/// </summary>
	public override string LabelCurrentPublishedVersion => "현재 게시 버전";

	/// <summary>
	/// Key: "Label.Description"
	/// English String: "Description"
	/// </summary>
	public override string LabelDescription => "설명";

	/// <summary>
	/// Key: "Label.Device"
	/// device term
	/// English String: "Device"
	/// </summary>
	public override string LabelDevice => "기기";

	/// <summary>
	/// Key: "Label.EnterItemTag"
	/// Placeholder for input field
	/// English String: "Enter tag here..."
	/// </summary>
	public override string LabelEnterItemTag => "여기에 태그를 입력하세요...";

	/// <summary>
	/// Key: "Label.Game"
	/// English String: "Game"
	/// </summary>
	public override string LabelGame => "게임";

	/// <summary>
	/// Key: "Label.GamePass"
	/// label
	/// English String: "Game Pass"
	/// </summary>
	public override string LabelGamePass => "게임패스";

	/// <summary>
	/// Key: "Label.General"
	/// English String: "General"
	/// </summary>
	public override string LabelGeneral => "일반";

	/// <summary>
	/// Key: "Label.GoToDetails"
	/// Link to the item details page from the configure page
	/// English String: "Go to Details"
	/// </summary>
	public override string LabelGoToDetails => "'설명'으로 이동";

	/// <summary>
	/// Key: "Label.ItemActive"
	/// English String: "Item is Active"
	/// </summary>
	public override string LabelItemActive => "아이템이 활성화 상태입니다";

	/// <summary>
	/// Key: "Label.ItemForSale"
	/// English String: "Item for Sale"
	/// </summary>
	public override string LabelItemForSale => "판매 아이템";

	/// <summary>
	/// Key: "Label.LastUpdated"
	/// English String: "Last Updated"
	/// </summary>
	public override string LabelLastUpdated => "최신 업데이트";

	/// <summary>
	/// Key: "Label.LearnMore"
	/// English String: "Learn more"
	/// </summary>
	public override string LabelLearnMore => "더 알아보기";

	/// <summary>
	/// Key: "Label.MarketplaceFee"
	/// English String: "Marketplace Fee"
	/// </summary>
	public override string LabelMarketplaceFee => "장터 수수료";

	/// <summary>
	/// Key: "Label.Name"
	/// English String: "Name"
	/// </summary>
	public override string LabelName => "이름";

	/// <summary>
	/// Key: "Label.OpenForComments"
	/// English String: "Open for Comments"
	/// </summary>
	public override string LabelOpenForComments => "코멘트 열기";

	/// <summary>
	/// Key: "Label.Preview"
	/// English String: "Preview"
	/// </summary>
	public override string LabelPreview => "미리보기";

	/// <summary>
	/// Key: "Label.Price"
	/// English String: "Price"
	/// </summary>
	public override string LabelPrice => "가격";

	/// <summary>
	/// Key: "Label.Profit"
	/// English String: "You Earn"
	/// </summary>
	public override string LabelProfit => "획득:";

	/// <summary>
	/// Key: "Label.Restore"
	/// English String: "Restore"
	/// </summary>
	public override string LabelRestore => "복원";

	/// <summary>
	/// Key: "Label.RevertVersion"
	/// English String: "Revert to this version"
	/// </summary>
	public override string LabelRevertVersion => "이 버전으로 복구";

	/// <summary>
	/// Key: "Label.Sales"
	/// English String: "Sales"
	/// </summary>
	public override string LabelSales => "판매";

	/// <summary>
	/// Key: "Label.Save"
	/// English String: "Save"
	/// </summary>
	public override string LabelSave => "저장";

	/// <summary>
	/// Key: "Label.SelectType"
	/// Placeholder for dropdown in create asset page. Options are image, mesh, hair accessory, etc
	/// English String: "Select a type"
	/// </summary>
	public override string LabelSelectType => "종류 선택하기";

	/// <summary>
	/// Key: "Label.Tags"
	/// The label next to a list of item tags in the item configuration page
	/// English String: "Tags"
	/// </summary>
	public override string LabelTags => "태그";

	/// <summary>
	/// Key: "Label.Type"
	/// English String: "Type"
	/// </summary>
	public override string LabelType => "종류";

	/// <summary>
	/// Key: "Label.Updated"
	/// English String: "Updated"
	/// </summary>
	public override string LabelUpdated => "업데이트 완료";

	/// <summary>
	/// Key: "Label.Version"
	/// English String: "Version"
	/// </summary>
	public override string LabelVersion => "버전";

	/// <summary>
	/// Key: "Label.Versions"
	/// English String: "Versions"
	/// </summary>
	public override string LabelVersions => "버전";

	/// <summary>
	/// Key: "Message.ArchiveError"
	/// English String: "Failed to archive"
	/// </summary>
	public override string MessageArchiveError => "보관 실패";

	/// <summary>
	/// Key: "Message.ArchiveSuccess"
	/// English String: "Successfully archived"
	/// </summary>
	public override string MessageArchiveSuccess => "보관 완료";

	/// <summary>
	/// Key: "Message.DescriptionFieldEmptyError"
	/// English String: "Description cannot be empty"
	/// </summary>
	public override string MessageDescriptionFieldEmptyError => "설명을 입력하셔야 합니다";

	/// <summary>
	/// Key: "Message.DescriptionTooLongError"
	/// error message
	/// English String: "The description is too long."
	/// </summary>
	public override string MessageDescriptionTooLongError => "설명이 너무 길어요.";

	/// <summary>
	/// Key: "Message.FilteringServiceUnavailableError"
	/// error message
	/// English String: "Text filtering service is unavailable at this time."
	/// </summary>
	public override string MessageFilteringServiceUnavailableError => "지금은 텍스트 필터링 서비스를 이용할 수 없습니다.";

	/// <summary>
	/// Key: "Message.GamePassConfigDisabledError"
	/// error message
	/// English String: "Game Pass configuration is not enabled yet."
	/// </summary>
	public override string MessageGamePassConfigDisabledError => "게임패스 구성이 아직 활성화되지 않았어요.";

	/// <summary>
	/// Key: "Message.GamePassNotFoundError"
	/// errormessage
	/// English String: "The Game Pass does not exist."
	/// </summary>
	public override string MessageGamePassNotFoundError => "게임패스가 없어요.";

	/// <summary>
	/// Key: "Message.IconUpdateFailed"
	/// error message
	/// English String: "Failed to update icon."
	/// </summary>
	public override string MessageIconUpdateFailed => "아이콘 업데이트 실패.";

	/// <summary>
	/// Key: "Message.ImageSavingFailedError"
	/// error message
	/// English String: "Failed to save image. Please try again later."
	/// </summary>
	public override string MessageImageSavingFailedError => "이미지 저장 실패. 나중에 다시 시도해 주세요.";

	/// <summary>
	/// Key: "Message.InappropriateTextError"
	/// error message
	/// English String: "The name or description contains inappropriate text."
	/// </summary>
	public override string MessageInappropriateTextError => "이름 또는 설명에 부적절한 텍스트가 포함되어 있어요.";

	/// <summary>
	/// Key: "Message.NameFieldEmpty"
	/// English String: "Name cannot be empty"
	/// </summary>
	public override string MessageNameFieldEmpty => "이름을 입력하셔야 합니다";

	/// <summary>
	/// Key: "Message.NameRequiredError"
	/// error message
	/// English String: "The name cannot be empty."
	/// </summary>
	public override string MessageNameRequiredError => "이름을 입력하셔야 합니다.";

	/// <summary>
	/// Key: "Message.NoTagsFound"
	/// English String: "No tags found"
	/// </summary>
	public override string MessageNoTagsFound => "태그를 찾을 수 없습니다";

	/// <summary>
	/// Key: "Message.RestoreError"
	/// English String: "Failed to restore"
	/// </summary>
	public override string MessageRestoreError => "복원 실패";

	/// <summary>
	/// Key: "Message.RestoreSuccess"
	/// English String: "Successfully restored"
	/// </summary>
	public override string MessageRestoreSuccess => "복원 완료";

	/// <summary>
	/// Key: "Message.SaveError"
	/// English String: "Something failed. Please try again later"
	/// </summary>
	public override string MessageSaveError => "오류가 발생했어요. 나중에 다시 시도하세요";

	/// <summary>
	/// Key: "Message.TooManyUploads"
	/// error message
	/// English String: "You are uploading too much. Please try again later."
	/// </summary>
	public override string MessageTooManyUploads => "업로드가 너무 많아요. 나중에 다시 시도하세요.";

	/// <summary>
	/// Key: "Message.UpdatePriceError"
	/// English String: "Failed to update price"
	/// </summary>
	public override string MessageUpdatePriceError => "가격 업데이트 실패";

	/// <summary>
	/// Key: "Message.UpdatePriceSuccess"
	/// English String: "Successfully updated price"
	/// </summary>
	public override string MessageUpdatePriceSuccess => "가격 업데이트 완료";

	/// <summary>
	/// Key: "Message.UpdateSuccess"
	/// English String: "Successfully updated"
	/// </summary>
	public override string MessageUpdateSuccess => "업데이트 완료";

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
		return $"가능한 파일 형식: {fileExtensions}";
	}

	protected override string _GetTemplateForDescriptionAcceptableFileFormats()
	{
		return "가능한 파일 형식: {fileExtensions}";
	}

	/// <summary>
	/// Key: "Description.AcceptableFiles"
	/// English String: "* Acceptable files{lineBreak}Format: {fileExtensions}   |   Size: {fileSizes}"
	/// </summary>
	public override string DescriptionAcceptableFiles(string lineBreak, string fileExtensions, string fileSizes)
	{
		return $"* 허용되는 파일{lineBreak}형식: {fileExtensions}   |   크기: {fileSizes}";
	}

	protected override string _GetTemplateForDescriptionAcceptableFiles()
	{
		return "* 허용되는 파일{lineBreak}형식: {fileExtensions}   |   크기: {fileSizes}";
	}

	protected override string _GetTemplateForDescriptionAllowCopying()
	{
		return "본 확인란을 선택하면 회원님이 지금 공유하려는 콘텐츠를 Roblox의 모든 사용자가 다양한 방식으로 사용할 수 있게 됩니다. 사용을 허락하지 않으려면 확인란을 선택하지 마세요. 콘텐츠 공유에 관한 자세한 정보는 Roblox 이용 약관을 참고하세요.";
	}

	/// <summary>
	/// Key: "Description.AllowCopyingWarning"
	/// English String: "By switching on, you are granting every other user of Roblox the right to use (in various ways) the content you are now sharing. If you do not want to grant this right, please do not check this box. For more information about sharing content, please review the Roblox {linkStart}Terms of Use{linkEnd}."
	/// </summary>
	public override string DescriptionAllowCopyingWarning(string linkStart, string linkEnd)
	{
		return $"본 확인란을 선택하면 회원님이 지금 공유하려는 콘텐츠를 Roblox의 모든 사용자가 다양한 방식으로 사용할 수 있게 됩니다. 사용을 허락하지 않으려면 확인란을 선택하지 마세요. 콘텐츠 공유에 관한 자세한 정보는 Roblox {linkStart}이용 약관{linkEnd}을 참고하세요.";
	}

	protected override string _GetTemplateForDescriptionAllowCopyingWarning()
	{
		return "본 확인란을 선택하면 회원님이 지금 공유하려는 콘텐츠를 Roblox의 모든 사용자가 다양한 방식으로 사용할 수 있게 됩니다. 사용을 허락하지 않으려면 확인란을 선택하지 마세요. 콘텐츠 공유에 관한 자세한 정보는 Roblox {linkStart}이용 약관{linkEnd}을 참고하세요.";
	}

	protected override string _GetTemplateForDescriptionArchiveWarning()
	{
		return "애셋을 보관하면 게임에서 사용할 수 없어요. 보관했던 애셋은 나중에 복원 가능해요.";
	}

	protected override string _GetTemplateForDescriptionClickToAddTag()
	{
		return "태그를 추가하려면 클릭";
	}

	/// <summary>
	/// Key: "Description.MarketplaceExplanation"
	/// English String: "(Roblox takes {marketplaceFeePercentage}%, minimum {minimumPrice})"
	/// </summary>
	public override string DescriptionMarketplaceExplanation(string marketplaceFeePercentage, string minimumPrice)
	{
		return $"(Roblox 수수료: {marketplaceFeePercentage}%, 기본 가격: {minimumPrice})";
	}

	protected override string _GetTemplateForDescriptionMarketplaceExplanation()
	{
		return "(Roblox 수수료: {marketplaceFeePercentage}%, 기본 가격: {minimumPrice})";
	}

	protected override string _GetTemplateForDescriptionModeratorFileReview()
	{
		return "* 업로드한 파일은 검열팀의 검토가 끝난 후에 다른 사용자에게 공개됩니다";
	}

	protected override string _GetTemplateForDescriptionModeratorReview()
	{
		return "* 업로드한 이미지는 검열팀의 검토가 끝난 후에 다른 사용자에게 공개됩니다";
	}

	/// <summary>
	/// Key: "Description.SelectItemTags"
	/// itemTagLimit is the number of item tags allowed
	/// English String: "Select up to {itemTagLimit} tags."
	/// </summary>
	public override string DescriptionSelectItemTags(string itemTagLimit)
	{
		return $"태그를 {itemTagLimit}개까지 선택하세요.";
	}

	protected override string _GetTemplateForDescriptionSelectItemTags()
	{
		return "태그를 {itemTagLimit}개까지 선택하세요.";
	}

	public override string DescriptionVerifiedCreatorEmail(string linkStart, string linkEnd)
	{
		return $"콘텐츠를 장터에서 공유하려면, 계정에 이메일 주소를 추가하고 인증해야 합니다. {linkStart}계정 설정{linkEnd}에서 가능합니다.";
	}

	protected override string _GetTemplateForDescriptionVerifiedCreatorEmail()
	{
		return "콘텐츠를 장터에서 공유하려면, 계정에 이메일 주소를 추가하고 인증해야 합니다. {linkStart}계정 설정{linkEnd}에서 가능합니다.";
	}

	protected override string _GetTemplateForHeadingArchive()
	{
		return "보관";
	}

	protected override string _GetTemplateForHeadingConfigure()
	{
		return "구성";
	}

	/// <summary>
	/// Key: "Heading.ConfigureItem"
	/// English String: "Configure {itemType}"
	/// </summary>
	public override string HeadingConfigureItem(string itemType)
	{
		return $"{itemType} 구성";
	}

	protected override string _GetTemplateForHeadingConfigureItem()
	{
		return "{itemType} 구성";
	}

	protected override string _GetTemplateForHeadingConfigureItemTags()
	{
		return "태그 구성";
	}

	protected override string _GetTemplateForHeadingCreate()
	{
		return "만들기";
	}

	protected override string _GetTemplateForHeadingSettings()
	{
		return "설정";
	}

	protected override string _GetTemplateForLabelAllowCopying()
	{
		return "복사 허용";
	}

	protected override string _GetTemplateForLabelArchive()
	{
		return "보관";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "취소";
	}

	protected override string _GetTemplateForLabelComputer()
	{
		return "컴퓨터";
	}

	protected override string _GetTemplateForLabelCreated()
	{
		return "개발 완료";
	}

	protected override string _GetTemplateForLabelCurrent()
	{
		return "현재";
	}

	protected override string _GetTemplateForLabelCurrentPublishedVersion()
	{
		return "현재 게시 버전";
	}

	protected override string _GetTemplateForLabelDescription()
	{
		return "설명";
	}

	protected override string _GetTemplateForLabelDevice()
	{
		return "기기";
	}

	protected override string _GetTemplateForLabelEnterItemTag()
	{
		return "여기에 태그를 입력하세요...";
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
		return "게임";
	}

	protected override string _GetTemplateForLabelGamePass()
	{
		return "게임패스";
	}

	protected override string _GetTemplateForLabelGeneral()
	{
		return "일반";
	}

	protected override string _GetTemplateForLabelGoToDetails()
	{
		return "'설명'으로 이동";
	}

	protected override string _GetTemplateForLabelItemActive()
	{
		return "아이템이 활성화 상태입니다";
	}

	protected override string _GetTemplateForLabelItemForSale()
	{
		return "판매 아이템";
	}

	protected override string _GetTemplateForLabelLastUpdated()
	{
		return "최신 업데이트";
	}

	protected override string _GetTemplateForLabelLearnMore()
	{
		return "더 알아보기";
	}

	protected override string _GetTemplateForLabelMarketplaceFee()
	{
		return "장터 수수료";
	}

	protected override string _GetTemplateForLabelName()
	{
		return "이름";
	}

	protected override string _GetTemplateForLabelOpenForComments()
	{
		return "코멘트 열기";
	}

	protected override string _GetTemplateForLabelPreview()
	{
		return "미리보기";
	}

	protected override string _GetTemplateForLabelPrice()
	{
		return "가격";
	}

	protected override string _GetTemplateForLabelProfit()
	{
		return "획득:";
	}

	protected override string _GetTemplateForLabelRestore()
	{
		return "복원";
	}

	protected override string _GetTemplateForLabelRevertVersion()
	{
		return "이 버전으로 복구";
	}

	protected override string _GetTemplateForLabelSales()
	{
		return "판매";
	}

	protected override string _GetTemplateForLabelSave()
	{
		return "저장";
	}

	protected override string _GetTemplateForLabelSelectType()
	{
		return "종류 선택하기";
	}

	protected override string _GetTemplateForLabelTags()
	{
		return "태그";
	}

	protected override string _GetTemplateForLabelType()
	{
		return "종류";
	}

	protected override string _GetTemplateForLabelUpdated()
	{
		return "업데이트 완료";
	}

	protected override string _GetTemplateForLabelVersion()
	{
		return "버전";
	}

	protected override string _GetTemplateForLabelVersions()
	{
		return "버전";
	}

	protected override string _GetTemplateForMessageArchiveError()
	{
		return "보관 실패";
	}

	protected override string _GetTemplateForMessageArchiveSuccess()
	{
		return "보관 완료";
	}

	/// <summary>
	/// Key: "Message.DescriptionFieldEmpty"
	/// English String: "{maxDescriptionLength} character limit"
	/// </summary>
	public override string MessageDescriptionFieldEmpty(string maxDescriptionLength)
	{
		return $"{maxDescriptionLength}자 제한";
	}

	protected override string _GetTemplateForMessageDescriptionFieldEmpty()
	{
		return "{maxDescriptionLength}자 제한";
	}

	protected override string _GetTemplateForMessageDescriptionFieldEmptyError()
	{
		return "설명을 입력하셔야 합니다";
	}

	/// <summary>
	/// Key: "Message.DescriptionFieldPopulated"
	/// English String: "{descriptionLength}/{maxDescriptionLength} characters"
	/// </summary>
	public override string MessageDescriptionFieldPopulated(string descriptionLength, string maxDescriptionLength)
	{
		return $"{descriptionLength}/{maxDescriptionLength}자";
	}

	protected override string _GetTemplateForMessageDescriptionFieldPopulated()
	{
		return "{descriptionLength}/{maxDescriptionLength}자";
	}

	protected override string _GetTemplateForMessageDescriptionTooLongError()
	{
		return "설명이 너무 길어요.";
	}

	protected override string _GetTemplateForMessageFilteringServiceUnavailableError()
	{
		return "지금은 텍스트 필터링 서비스를 이용할 수 없습니다.";
	}

	protected override string _GetTemplateForMessageGamePassConfigDisabledError()
	{
		return "게임패스 구성이 아직 활성화되지 않았어요.";
	}

	protected override string _GetTemplateForMessageGamePassNotFoundError()
	{
		return "게임패스가 없어요.";
	}

	protected override string _GetTemplateForMessageIconUpdateFailed()
	{
		return "아이콘 업데이트 실패.";
	}

	protected override string _GetTemplateForMessageImageSavingFailedError()
	{
		return "이미지 저장 실패. 나중에 다시 시도해 주세요.";
	}

	protected override string _GetTemplateForMessageInappropriateTextError()
	{
		return "이름 또는 설명에 부적절한 텍스트가 포함되어 있어요.";
	}

	/// <summary>
	/// Key: "Message.MinimumPrice"
	/// English String: "You cannot set a price below the minimum price of {minimumPrice}"
	/// </summary>
	public override string MessageMinimumPrice(string minimumPrice)
	{
		return $"최저 가격인 {minimumPrice} 미만으로 가격을 설정할 수 없어요";
	}

	protected override string _GetTemplateForMessageMinimumPrice()
	{
		return "최저 가격인 {minimumPrice} 미만으로 가격을 설정할 수 없어요";
	}

	protected override string _GetTemplateForMessageNameFieldEmpty()
	{
		return "이름을 입력하셔야 합니다";
	}

	/// <summary>
	/// Key: "Message.NameFieldPopulated"
	/// English String: "{nameLength}/{maxNameLength} characters"
	/// </summary>
	public override string MessageNameFieldPopulated(string nameLength, string maxNameLength)
	{
		return $"{nameLength}/{maxNameLength}자";
	}

	protected override string _GetTemplateForMessageNameFieldPopulated()
	{
		return "{nameLength}/{maxNameLength}자";
	}

	protected override string _GetTemplateForMessageNameRequiredError()
	{
		return "이름을 입력하셔야 합니다.";
	}

	protected override string _GetTemplateForMessageNoTagsFound()
	{
		return "태그를 찾을 수 없습니다";
	}

	protected override string _GetTemplateForMessageRestoreError()
	{
		return "복원 실패";
	}

	protected override string _GetTemplateForMessageRestoreSuccess()
	{
		return "복원 완료";
	}

	/// <summary>
	/// Key: "Message.RevertError"
	/// English String: "Failed to revert to version {versionNumber}"
	/// </summary>
	public override string MessageRevertError(string versionNumber)
	{
		return $"버전 {versionNumber}(으)로 복구하는 데 실패했어요";
	}

	protected override string _GetTemplateForMessageRevertError()
	{
		return "버전 {versionNumber}(으)로 복구하는 데 실패했어요";
	}

	/// <summary>
	/// Key: "Message.RevertSuccess"
	/// English String: "Successfully reverted to version {versionNumber}"
	/// </summary>
	public override string MessageRevertSuccess(string versionNumber)
	{
		return $"버전 {versionNumber}(으)로 무사히 복구했어요";
	}

	protected override string _GetTemplateForMessageRevertSuccess()
	{
		return "버전 {versionNumber}(으)로 무사히 복구했어요";
	}

	protected override string _GetTemplateForMessageSaveError()
	{
		return "오류가 발생했어요. 나중에 다시 시도하세요";
	}

	protected override string _GetTemplateForMessageTooManyUploads()
	{
		return "업로드가 너무 많아요. 나중에 다시 시도하세요.";
	}

	protected override string _GetTemplateForMessageUpdatePriceError()
	{
		return "가격 업데이트 실패";
	}

	protected override string _GetTemplateForMessageUpdatePriceSuccess()
	{
		return "가격 업데이트 완료";
	}

	protected override string _GetTemplateForMessageUpdateSuccess()
	{
		return "업데이트 완료";
	}
}
