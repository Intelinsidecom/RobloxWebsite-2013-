namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GameLocalizationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameLocalizationResources_zh_tw : GameLocalizationResources_en_us, IGameLocalizationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// The label for the cancel button
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "取消";

	/// <summary>
	/// Key: "Action.Clear"
	/// The label for the clear button
	/// English String: "Clear"
	/// </summary>
	public override string ActionClear => "清除";

	/// <summary>
	/// Key: "Action.Confirm"
	/// The label for the confirm button
	/// English String: "Confirm"
	/// </summary>
	public override string ActionConfirm => "確認";

	/// <summary>
	/// Key: "Action.Save"
	/// The label for the save button
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "儲存";

	/// <summary>
	/// Key: "Description.ContentModerationError"
	/// The error text when user's input does not pass the backend text filter
	/// English String: "Error: Could not save. Please check content for moderation and try again."
	/// </summary>
	public override string DescriptionContentModerationError => "錯誤：無法儲存。請檢查內容是否遭到過濾，然後重新嘗試。";

	/// <summary>
	/// Key: "Description.GeneralError"
	/// The error text for all the other backend error codes
	/// English String: "Error: Could not save."
	/// </summary>
	public override string DescriptionGeneralError => "錯誤：無法儲存。";

	/// <summary>
	/// Key: "Description.NonSourceLanguageForm"
	/// The info shown to user when they are viewing the name and description in the source language
	/// English String: "If no translations are provided, users will see the source language values."
	/// </summary>
	public override string DescriptionNonSourceLanguageForm => "若未提供翻譯，使用者將會看見源語言值。";

	/// <summary>
	/// Key: "Description.Save"
	/// The content for unsaved changes warning modal
	/// English String: "You have unsaved changes. Are you sure you want to switch language?"
	/// </summary>
	public override string DescriptionSave => "您有未儲存的變更。確定切換語言？";

	/// <summary>
	/// Key: "Description.SaveSuccess"
	/// The feedback for user when saving has succeeded
	/// English String: "Name and Description saved."
	/// </summary>
	public override string DescriptionSaveSuccess => "名稱與說明已儲存。";

	/// <summary>
	/// Key: "Description.SourceLanguageForm"
	/// The info shown to user when they are viewing the name and description in the source language
	/// English String: "Source language values are shown as a reference. They can only be viewed here."
	/// </summary>
	public override string DescriptionSourceLanguageForm => "顯示的源語言值為參考用，只可以在此處檢視。";

	/// <summary>
	/// Key: "Heading.Clear"
	/// The modal title for clear confirmation modal
	/// English String: "Clear Values"
	/// </summary>
	public override string HeadingClear => "清除值";

	/// <summary>
	/// Key: "Heading.ConfigureLocalization"
	/// page heading
	/// English String: "Configure Localization"
	/// </summary>
	public override string HeadingConfigureLocalization => "本地化設定";

	/// <summary>
	/// Key: "Heading.GameNameDescriptionTranslations"
	/// The header for the game info section in localization page
	/// English String: "Game Name and Description Translations"
	/// </summary>
	public override string HeadingGameNameDescriptionTranslations => "遊戲名稱與說明翻譯";

	/// <summary>
	/// Key: "Heading.Save"
	/// The content for unsaved changes warning modal
	/// English String: "Unsaved Changes"
	/// </summary>
	public override string HeadingSave => "未儲存變更";

	/// <summary>
	/// Key: "Label.Description"
	/// The label for the game name input field
	/// English String: "Description: "
	/// </summary>
	public override string LabelDescription => "說明：";

	/// <summary>
	/// Key: "Label.GameDescriptionPlaceholder"
	/// The placeholder for the game description input field
	/// English String: "Enter game description here"
	/// </summary>
	public override string LabelGameDescriptionPlaceholder => "於此處輸入遊戲說明";

	/// <summary>
	/// Key: "Label.GameInfo"
	/// The label for the game info sub tab in localization tab
	/// English String: "Game Info"
	/// </summary>
	public override string LabelGameInfo => "遊戲資訊";

	/// <summary>
	/// Key: "Label.GameNameDescriptionTranslations"
	/// The label for the game info tab in localization page
	/// English String: "Game Name and Description Translations"
	/// </summary>
	public override string LabelGameNameDescriptionTranslations => "遊戲名稱與說明翻譯";

	/// <summary>
	/// Key: "Label.GameNamePlaceholder"
	/// The placeholder for the game name input field
	/// English String: "Enter game name here (required)"
	/// </summary>
	public override string LabelGameNamePlaceholder => "於此處輸入遊戲名稱（必填）";

	/// <summary>
	/// Key: "Label.GameTitlePlaceholder"
	/// placeholder text for entering game title in a text input
	/// English String: "Enter game name here"
	/// </summary>
	public override string LabelGameTitlePlaceholder => "於此處輸入遊戲名稱";

	/// <summary>
	/// Key: "Label.Localization"
	/// The label for localization tab and its header in configure game page
	/// English String: "Localization"
	/// </summary>
	public override string LabelLocalization => "本地化";

	/// <summary>
	/// Key: "Label.Name"
	/// The label for the game name input field
	/// English String: "Name: "
	/// </summary>
	public override string LabelName => "名稱： ";

	/// <summary>
	/// Key: "Label.SupportedLanguages"
	/// The label for the supported languages sub tab in localization tab
	/// English String: "Supported Languages"
	/// </summary>
	public override string LabelSupportedLanguages => "支援語言";

	/// <summary>
	/// Key: "Label.TabGameInfo"
	/// English String: "Game Info"
	/// </summary>
	public override string LabelTabGameInfo => "遊戲資訊";

	/// <summary>
	/// Key: "Label.TabLanguages"
	/// English String: "Languages"
	/// </summary>
	public override string LabelTabLanguages => "語言";

	/// <summary>
	/// Key: "Label.TabReports"
	/// English String: "Reports"
	/// </summary>
	public override string LabelTabReports => "舉報";

	/// <summary>
	/// Key: "Label.TabSettings"
	/// English String: "Settings"
	/// </summary>
	public override string LabelTabSettings => "設定";

	/// <summary>
	/// Key: "Label.TabTranslators"
	/// English String: "Translators"
	/// </summary>
	public override string LabelTabTranslators => "譯者";

	/// <summary>
	/// Key: "Label.Title"
	/// Game Title (or Name) field label, corresponding text area editable by game developer
	/// English String: "Title"
	/// </summary>
	public override string LabelTitle => "標題";

	/// <summary>
	/// Key: "Response.ContentModerationError"
	/// The error text when user's input does not pass the backend text filter
	/// English String: "Error: Could not save. Please check content for moderation and try again."
	/// </summary>
	public override string ResponseContentModerationError => "錯誤：無法儲存。請檢查內容是否遭到過濾，然後重新嘗試。";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// The feedback for user when some general error, whose details should not concern the user, has occurred
	/// English String: "Error: An error has occurred. Please try again later."
	/// </summary>
	public override string ResponseGeneralError => "錯誤：發生錯誤，請稍後再試。";

	/// <summary>
	/// Key: "Response.GeneralSaveError"
	/// The error text for all the other backend error code during save
	/// English String: "Error: Could not save."
	/// </summary>
	public override string ResponseGeneralSaveError => "錯誤：無法儲存。";

	public GameLocalizationResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "取消";
	}

	protected override string _GetTemplateForActionClear()
	{
		return "清除";
	}

	protected override string _GetTemplateForActionConfirm()
	{
		return "確認";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "儲存";
	}

	/// <summary>
	/// Key: "Description.Clear"
	/// The content for clear confirmation modal
	/// English String: "Are you sure you want to clear the translations for {languageName}? Users will see name and description in the source language of the game."
	/// </summary>
	public override string DescriptionClear(string languageName)
	{
		return $"確定清除{languageName}翻譯？使用者將會看到遊戲源語言的名稱和說明。";
	}

	protected override string _GetTemplateForDescriptionClear()
	{
		return "確定清除{languageName}翻譯？使用者將會看到遊戲源語言的名稱和說明。";
	}

	protected override string _GetTemplateForDescriptionContentModerationError()
	{
		return "錯誤：無法儲存。請檢查內容是否遭到過濾，然後重新嘗試。";
	}

	protected override string _GetTemplateForDescriptionGeneralError()
	{
		return "錯誤：無法儲存。";
	}

	protected override string _GetTemplateForDescriptionNonSourceLanguageForm()
	{
		return "若未提供翻譯，使用者將會看見源語言值。";
	}

	protected override string _GetTemplateForDescriptionSave()
	{
		return "您有未儲存的變更。確定切換語言？";
	}

	protected override string _GetTemplateForDescriptionSaveSuccess()
	{
		return "名稱與說明已儲存。";
	}

	protected override string _GetTemplateForDescriptionSourceLanguageForm()
	{
		return "顯示的源語言值為參考用，只可以在此處檢視。";
	}

	protected override string _GetTemplateForHeadingClear()
	{
		return "清除值";
	}

	protected override string _GetTemplateForHeadingConfigureLocalization()
	{
		return "本地化設定";
	}

	protected override string _GetTemplateForHeadingGameNameDescriptionTranslations()
	{
		return "遊戲名稱與說明翻譯";
	}

	protected override string _GetTemplateForHeadingSave()
	{
		return "未儲存變更";
	}

	protected override string _GetTemplateForLabelDescription()
	{
		return "說明：";
	}

	protected override string _GetTemplateForLabelGameDescriptionPlaceholder()
	{
		return "於此處輸入遊戲說明";
	}

	protected override string _GetTemplateForLabelGameInfo()
	{
		return "遊戲資訊";
	}

	protected override string _GetTemplateForLabelGameNameDescriptionTranslations()
	{
		return "遊戲名稱與說明翻譯";
	}

	protected override string _GetTemplateForLabelGameNamePlaceholder()
	{
		return "於此處輸入遊戲名稱（必填）";
	}

	protected override string _GetTemplateForLabelGameTitlePlaceholder()
	{
		return "於此處輸入遊戲名稱";
	}

	protected override string _GetTemplateForLabelLocalization()
	{
		return "本地化";
	}

	protected override string _GetTemplateForLabelName()
	{
		return "名稱： ";
	}

	protected override string _GetTemplateForLabelSupportedLanguages()
	{
		return "支援語言";
	}

	protected override string _GetTemplateForLabelTabGameInfo()
	{
		return "遊戲資訊";
	}

	protected override string _GetTemplateForLabelTabLanguages()
	{
		return "語言";
	}

	protected override string _GetTemplateForLabelTabReports()
	{
		return "舉報";
	}

	protected override string _GetTemplateForLabelTabSettings()
	{
		return "設定";
	}

	protected override string _GetTemplateForLabelTabTranslators()
	{
		return "譯者";
	}

	protected override string _GetTemplateForLabelTitle()
	{
		return "標題";
	}

	protected override string _GetTemplateForResponseContentModerationError()
	{
		return "錯誤：無法儲存。請檢查內容是否遭到過濾，然後重新嘗試。";
	}

	protected override string _GetTemplateForResponseGeneralError()
	{
		return "錯誤：發生錯誤，請稍後再試。";
	}

	protected override string _GetTemplateForResponseGeneralSaveError()
	{
		return "錯誤：無法儲存。";
	}
}
