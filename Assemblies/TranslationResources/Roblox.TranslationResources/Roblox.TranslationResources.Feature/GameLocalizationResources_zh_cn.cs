namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GameLocalizationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameLocalizationResources_zh_cn : GameLocalizationResources_en_us, IGameLocalizationResources, ITranslationResources
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
	public override string ActionConfirm => "确认";

	/// <summary>
	/// Key: "Action.Save"
	/// The label for the save button
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "保存";

	/// <summary>
	/// Key: "Description.ContentModerationError"
	/// The error text when user's input does not pass the backend text filter
	/// English String: "Error: Could not save. Please check content for moderation and try again."
	/// </summary>
	public override string DescriptionContentModerationError => "错误：无法保存。请检查内容是否符合审查要求，并重试。";

	/// <summary>
	/// Key: "Description.GeneralError"
	/// The error text for all the other backend error codes
	/// English String: "Error: Could not save."
	/// </summary>
	public override string DescriptionGeneralError => "错误：无法保存。";

	/// <summary>
	/// Key: "Description.NonSourceLanguageForm"
	/// The info shown to user when they are viewing the name and description in the source language
	/// English String: "If no translations are provided, users will see the source language values."
	/// </summary>
	public override string DescriptionNonSourceLanguageForm => "如果没有提供翻译，用户将看到源语言内容。";

	/// <summary>
	/// Key: "Description.Save"
	/// The content for unsaved changes warning modal
	/// English String: "You have unsaved changes. Are you sure you want to switch language?"
	/// </summary>
	public override string DescriptionSave => "你有未保存的更改。是否确定要切换语言？";

	/// <summary>
	/// Key: "Description.SaveSuccess"
	/// The feedback for user when saving has succeeded
	/// English String: "Name and Description saved."
	/// </summary>
	public override string DescriptionSaveSuccess => "已保存名称和描述。";

	/// <summary>
	/// Key: "Description.SourceLanguageForm"
	/// The info shown to user when they are viewing the name and description in the source language
	/// English String: "Source language values are shown as a reference. They can only be viewed here."
	/// </summary>
	public override string DescriptionSourceLanguageForm => "源语言内容显示在此以作参考。只能在此处查看。";

	/// <summary>
	/// Key: "Heading.Clear"
	/// The modal title for clear confirmation modal
	/// English String: "Clear Values"
	/// </summary>
	public override string HeadingClear => "清除内容";

	/// <summary>
	/// Key: "Heading.ConfigureLocalization"
	/// page heading
	/// English String: "Configure Localization"
	/// </summary>
	public override string HeadingConfigureLocalization => "本地化配置";

	/// <summary>
	/// Key: "Heading.GameNameDescriptionTranslations"
	/// The header for the game info section in localization page
	/// English String: "Game Name and Description Translations"
	/// </summary>
	public override string HeadingGameNameDescriptionTranslations => "游戏名称及描述翻译";

	/// <summary>
	/// Key: "Heading.Save"
	/// The content for unsaved changes warning modal
	/// English String: "Unsaved Changes"
	/// </summary>
	public override string HeadingSave => "未保存的更改";

	/// <summary>
	/// Key: "Label.Description"
	/// The label for the game name input field
	/// English String: "Description: "
	/// </summary>
	public override string LabelDescription => "描述：";

	/// <summary>
	/// Key: "Label.GameDescriptionPlaceholder"
	/// The placeholder for the game description input field
	/// English String: "Enter game description here"
	/// </summary>
	public override string LabelGameDescriptionPlaceholder => "请在此输入游戏描述";

	/// <summary>
	/// Key: "Label.GameInfo"
	/// The label for the game info sub tab in localization tab
	/// English String: "Game Info"
	/// </summary>
	public override string LabelGameInfo => "游戏信息";

	/// <summary>
	/// Key: "Label.GameNameDescriptionTranslations"
	/// The label for the game info tab in localization page
	/// English String: "Game Name and Description Translations"
	/// </summary>
	public override string LabelGameNameDescriptionTranslations => "游戏名称及描述翻译";

	/// <summary>
	/// Key: "Label.GameNamePlaceholder"
	/// The placeholder for the game name input field
	/// English String: "Enter game name here (required)"
	/// </summary>
	public override string LabelGameNamePlaceholder => "在此处输入游戏名称 （必填）";

	/// <summary>
	/// Key: "Label.GameTitlePlaceholder"
	/// placeholder text for entering game title in a text input
	/// English String: "Enter game name here"
	/// </summary>
	public override string LabelGameTitlePlaceholder => "请在此输入游戏名称";

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
	public override string LabelName => "名称：";

	/// <summary>
	/// Key: "Label.SupportedLanguages"
	/// The label for the supported languages sub tab in localization tab
	/// English String: "Supported Languages"
	/// </summary>
	public override string LabelSupportedLanguages => "支持语言";

	/// <summary>
	/// Key: "Label.TabGameInfo"
	/// English String: "Game Info"
	/// </summary>
	public override string LabelTabGameInfo => "游戏信息";

	/// <summary>
	/// Key: "Label.TabLanguages"
	/// English String: "Languages"
	/// </summary>
	public override string LabelTabLanguages => "语言";

	/// <summary>
	/// Key: "Label.TabReports"
	/// English String: "Reports"
	/// </summary>
	public override string LabelTabReports => "报告";

	/// <summary>
	/// Key: "Label.TabSettings"
	/// English String: "Settings"
	/// </summary>
	public override string LabelTabSettings => "设置";

	/// <summary>
	/// Key: "Label.TabTranslators"
	/// English String: "Translators"
	/// </summary>
	public override string LabelTabTranslators => "译者";

	/// <summary>
	/// Key: "Label.Title"
	/// Game Title (or Name) field label, corresponding text area editable by game developer
	/// English String: "Title"
	/// </summary>
	public override string LabelTitle => "标题";

	/// <summary>
	/// Key: "Response.ContentModerationError"
	/// The error text when user's input does not pass the backend text filter
	/// English String: "Error: Could not save. Please check content for moderation and try again."
	/// </summary>
	public override string ResponseContentModerationError => "错误：无法保存。请检查内容是否符合审查要求，并重试。";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// The feedback for user when some general error, whose details should not concern the user, has occurred
	/// English String: "Error: An error has occurred. Please try again later."
	/// </summary>
	public override string ResponseGeneralError => "错误：发生错误。请稍后重试。";

	/// <summary>
	/// Key: "Response.GeneralSaveError"
	/// The error text for all the other backend error code during save
	/// English String: "Error: Could not save."
	/// </summary>
	public override string ResponseGeneralSaveError => "错误：无法保存。";

	public GameLocalizationResources_zh_cn(TranslationResourceState state)
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
		return "确认";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "保存";
	}

	/// <summary>
	/// Key: "Description.Clear"
	/// The content for clear confirmation modal
	/// English String: "Are you sure you want to clear the translations for {languageName}? Users will see name and description in the source language of the game."
	/// </summary>
	public override string DescriptionClear(string languageName)
	{
		return $"是否确定要清除{languageName}的翻译？用户将在游戏的源语言中看到名称及描述。";
	}

	protected override string _GetTemplateForDescriptionClear()
	{
		return "是否确定要清除{languageName}的翻译？用户将在游戏的源语言中看到名称及描述。";
	}

	protected override string _GetTemplateForDescriptionContentModerationError()
	{
		return "错误：无法保存。请检查内容是否符合审查要求，并重试。";
	}

	protected override string _GetTemplateForDescriptionGeneralError()
	{
		return "错误：无法保存。";
	}

	protected override string _GetTemplateForDescriptionNonSourceLanguageForm()
	{
		return "如果没有提供翻译，用户将看到源语言内容。";
	}

	protected override string _GetTemplateForDescriptionSave()
	{
		return "你有未保存的更改。是否确定要切换语言？";
	}

	protected override string _GetTemplateForDescriptionSaveSuccess()
	{
		return "已保存名称和描述。";
	}

	protected override string _GetTemplateForDescriptionSourceLanguageForm()
	{
		return "源语言内容显示在此以作参考。只能在此处查看。";
	}

	protected override string _GetTemplateForHeadingClear()
	{
		return "清除内容";
	}

	protected override string _GetTemplateForHeadingConfigureLocalization()
	{
		return "本地化配置";
	}

	protected override string _GetTemplateForHeadingGameNameDescriptionTranslations()
	{
		return "游戏名称及描述翻译";
	}

	protected override string _GetTemplateForHeadingSave()
	{
		return "未保存的更改";
	}

	protected override string _GetTemplateForLabelDescription()
	{
		return "描述：";
	}

	protected override string _GetTemplateForLabelGameDescriptionPlaceholder()
	{
		return "请在此输入游戏描述";
	}

	protected override string _GetTemplateForLabelGameInfo()
	{
		return "游戏信息";
	}

	protected override string _GetTemplateForLabelGameNameDescriptionTranslations()
	{
		return "游戏名称及描述翻译";
	}

	protected override string _GetTemplateForLabelGameNamePlaceholder()
	{
		return "在此处输入游戏名称 （必填）";
	}

	protected override string _GetTemplateForLabelGameTitlePlaceholder()
	{
		return "请在此输入游戏名称";
	}

	protected override string _GetTemplateForLabelLocalization()
	{
		return "本地化";
	}

	protected override string _GetTemplateForLabelName()
	{
		return "名称：";
	}

	protected override string _GetTemplateForLabelSupportedLanguages()
	{
		return "支持语言";
	}

	protected override string _GetTemplateForLabelTabGameInfo()
	{
		return "游戏信息";
	}

	protected override string _GetTemplateForLabelTabLanguages()
	{
		return "语言";
	}

	protected override string _GetTemplateForLabelTabReports()
	{
		return "报告";
	}

	protected override string _GetTemplateForLabelTabSettings()
	{
		return "设置";
	}

	protected override string _GetTemplateForLabelTabTranslators()
	{
		return "译者";
	}

	protected override string _GetTemplateForLabelTitle()
	{
		return "标题";
	}

	protected override string _GetTemplateForResponseContentModerationError()
	{
		return "错误：无法保存。请检查内容是否符合审查要求，并重试。";
	}

	protected override string _GetTemplateForResponseGeneralError()
	{
		return "错误：发生错误。请稍后重试。";
	}

	protected override string _GetTemplateForResponseGeneralSaveError()
	{
		return "错误：无法保存。";
	}
}
