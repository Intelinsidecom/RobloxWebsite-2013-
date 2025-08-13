namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides TranslationManagementResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TranslationManagementResources_pt_br : TranslationManagementResources_en_us, ITranslationManagementResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.PleaseReload"
	/// A clickable text which allows user to reload the image and see if it is available.
	/// English String: "Please reload."
	/// </summary>
	public override string ActionPleaseReload => "Recarregue por favor.";

	/// <summary>
	/// Key: "Description.AcceptableFilesForIcon"
	/// Tell the developer what types of files their images should be for upload.
	/// English String: "Acceptable files: jpg, jpeg, png"
	/// </summary>
	public override string DescriptionAcceptableFilesForIcon => "Formatos aceitos: jpg, jpeg, png";

	/// <summary>
	/// Key: "Description.AcceptableFilesForThumbnail"
	/// English String: "Acceptable files: jpg, jpeg, png"
	/// </summary>
	public override string DescriptionAcceptableFilesForThumbnail => "Formatos aceitos: jpg, jpeg, png";

	/// <summary>
	/// Key: "Description.EnterTranslationHere"
	/// Placeholder text for the input text area of name/description
	/// English String: "Enter translation here"
	/// </summary>
	public override string DescriptionEnterTranslationHere => "Insira a tradução aqui";

	/// <summary>
	/// Key: "Description.IconWillBeReviewed"
	/// Tell developers that their game icon image needs to be reviewed by moderators before the public can see it
	/// English String: "Image will be reviewed by moderators before being made visible to other users"
	/// </summary>
	public override string DescriptionIconWillBeReviewed => "A imagem será revisada por moderadores antes de poder ser vista por outros usuários";

	/// <summary>
	/// Key: "Description.ImageNotAvailable"
	/// Message that tells the user their image is still being prepared
	/// English String: "Image not available."
	/// </summary>
	public override string DescriptionImageNotAvailable => "Imagem não disponível.";

	/// <summary>
	/// Key: "Description.MaximumSizeForIcon"
	/// The maximum file size for the icon
	/// English String: "Maximum file size: 4 MB"
	/// </summary>
	public override string DescriptionMaximumSizeForIcon => "Tamanho máximo do arquivo: 4 MB";

	/// <summary>
	/// Key: "Description.MaximumSizeForThumbnail"
	/// English String: "Maximum file size: 4 MB"
	/// </summary>
	public override string DescriptionMaximumSizeForThumbnail => "Tamanho máximo do arquivo: 4 MB";

	/// <summary>
	/// Key: "Description.NoGameProducts"
	/// English String: "No game products found for this game"
	/// </summary>
	public override string DescriptionNoGameProducts => "Não há produtos de jogo encontrados para esse jogo";

	/// <summary>
	/// Key: "Description.RecommendedResolution"
	/// The recommended resolution for icon image
	/// English String: "Recommended resolution: 512 x 512"
	/// </summary>
	public override string DescriptionRecommendedResolution => "Resolução recomendada: 512 x 512";

	/// <summary>
	/// Key: "Description.RecommendedResolutionForIcon"
	/// English String: "Recommended resolution: 512 x 512"
	/// </summary>
	public override string DescriptionRecommendedResolutionForIcon => "Resolução recomendada: 512 x 512";

	/// <summary>
	/// Key: "Description.RecommendedResolutionForThumbnail"
	/// English String: "Recommended resolution: 1920 x 1080"
	/// </summary>
	public override string DescriptionRecommendedResolutionForThumbnail => "Resolução recomendada: 1920 x 1080";

	/// <summary>
	/// Key: "Description.ScreenshotsLimitForThumbnail"
	/// English String: "You can set up to 10 screenshots"
	/// </summary>
	public override string DescriptionScreenshotsLimitForThumbnail => "É possível definir até 10 capturas de tela";

	/// <summary>
	/// Key: "Description.UnsavedChanges"
	/// The body of the modal that asks the user to confirm discarding unsaved changes
	/// English String: "Unsaved changes will be discarded. Are you sure?"
	/// </summary>
	public override string DescriptionUnsavedChanges => "As alterações não salvas serão descartadas. Você tem certeza?";

	/// <summary>
	/// Key: "Heading.BadgeDescription"
	/// Badge Description localization tool heading
	/// English String: "Badge Description"
	/// </summary>
	public override string HeadingBadgeDescription => "Descrição da insígnea";

	/// <summary>
	/// Key: "Heading.BadgeName"
	/// Badge Name localization tool heading
	/// English String: "Badge Name"
	/// </summary>
	public override string HeadingBadgeName => "Nome da insígnea";

	/// <summary>
	/// Key: "Heading.GameDescription"
	/// Game Description localization tool heading
	/// English String: "Game Description"
	/// </summary>
	public override string HeadingGameDescription => "Descrição do jogo";

	/// <summary>
	/// Key: "Heading.GameIcon"
	/// Game Icon localization tool heading
	/// English String: "Game Icon"
	/// </summary>
	public override string HeadingGameIcon => "Ícone do jogo";

	/// <summary>
	/// Key: "Heading.GameName"
	/// Game Name localization tool heading
	/// English String: "Game Name"
	/// </summary>
	public override string HeadingGameName => "Nome do jogo";

	/// <summary>
	/// Key: "Heading.GameThumbnails"
	/// Game Thumbnails localization tool heading
	/// English String: "Game Thumbnails"
	/// </summary>
	public override string HeadingGameThumbnails => "Miniaturas do jogo";

	/// <summary>
	/// Key: "Heading.ManageTranslations"
	/// heading of the manage translations page. Please reuse same translation as crowdsource localization page. We are still working on consolidating these two pages.
	/// English String: "Manage Translations"
	/// </summary>
	public override string HeadingManageTranslations => "Gerenciar traduções";

	/// <summary>
	/// Key: "Heading.NoContent"
	/// English String: "No Content"
	/// </summary>
	public override string HeadingNoContent => "Sem conteúdo";

	/// <summary>
	/// Key: "Heading.Thumbnails"
	/// Title for configuring Game Thumbnails which are shown to user in Game Details page to showcase the game's experiences, aesthetics, marketing, and gameplay.
	/// English String: "Thumbnails"
	/// </summary>
	public override string HeadingThumbnails => "Miniaturas";

	/// <summary>
	/// Key: "Heading.TranslationHistory"
	/// Heading for the translation history section of name/description
	/// English String: "Translation History"
	/// </summary>
	public override string HeadingTranslationHistory => "Histórico de tradução";

	/// <summary>
	/// Key: "Heading.TranslationManagement"
	/// The title of the translation management page
	/// English String: "Translation Management"
	/// </summary>
	public override string HeadingTranslationManagement => "Gerenciamento de tradução";

	/// <summary>
	/// Key: "Heading.UnsavedChanges"
	/// The heading of the modal that asks the user to confirm discarding unsaved changes
	/// English String: "Unsaved Changes"
	/// </summary>
	public override string HeadingUnsavedChanges => "Alterações não salvas";

	/// <summary>
	/// Key: "Label.Description"
	/// The label for Description I18n sub navigation tab
	/// English String: "Description"
	/// </summary>
	public override string LabelDescription => "Descrição";

	/// <summary>
	/// Key: "Label.GameInformation"
	/// The label for Game Information I18n navigation tab
	/// English String: "Game Information"
	/// </summary>
	public override string LabelGameInformation => "Informações do jogo";

	/// <summary>
	/// Key: "Label.GameProducts"
	/// The label for Game Products I18n navigation tab
	/// English String: "Game Products"
	/// </summary>
	public override string LabelGameProducts => "Produtos do jogo";

	/// <summary>
	/// Key: "Label.GameStrings"
	/// The label for Game Strings I18n navigation tab
	/// English String: "Game Strings"
	/// </summary>
	public override string LabelGameStrings => "Textos do jogo";

	/// <summary>
	/// Key: "Label.Icon"
	/// The label for Icon I18n sub navigation tab
	/// English String: "Icon"
	/// </summary>
	public override string LabelIcon => "Ícone";

	/// <summary>
	/// Key: "Label.ImageHoverText"
	/// User is hovering over a localized image. Describes screen for user with accessibility settings.
	/// English String: "Localized Image"
	/// </summary>
	public override string LabelImageHoverText => "Imagem localizada";

	/// <summary>
	/// Key: "Label.Name"
	/// The label for Name I18n sub navigation tab
	/// English String: "Name"
	/// </summary>
	public override string LabelName => "Nome";

	/// <summary>
	/// Key: "Label.TextToTranslate"
	/// Label for the source name/description text
	/// English String: "Text to translate"
	/// </summary>
	public override string LabelTextToTranslate => "Texto a traduzir";

	/// <summary>
	/// Key: "Label.Thumbnails"
	/// The label for Thumbnails I18n sub navigation tab
	/// English String: "Thumbnails"
	/// </summary>
	public override string LabelThumbnails => "Miniaturas";

	/// <summary>
	/// Key: "Response.AccessDenied"
	/// Message if user does not have permission to access the UI
	/// English String: "You don't have permission to access this page"
	/// </summary>
	public override string ResponseAccessDenied => "Você não tem permissão para acessar esta página";

	/// <summary>
	/// Key: "Response.ContentModerationError"
	/// The error text when user's input does not pass the text filter
	/// English String: "Could not save. Please check content for moderation and try again."
	/// </summary>
	public override string ResponseContentModerationError => "Impossível salvar. Certifique-se de que o conteúdo não tem problemas de moderação e tente de novo.";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// Message for general errors
	/// English String: "An error has occurred. Please try again later."
	/// </summary>
	public override string ResponseGeneralError => "Ocorreu um erro. Tente novamente mais tarde.";

	/// <summary>
	/// Key: "Response.IncorrectFormatOrSize"
	/// Response shows to user when their icon image fails to save due to incorrect format or size too large
	/// English String: "Could not save. Please make sure files are the correct size and format."
	/// </summary>
	public override string ResponseIncorrectFormatOrSize => "Impossível salvar. Certifique-se de que os arquivos têm o tamanho e formato corretos.";

	/// <summary>
	/// Key: "Response.NoTranslationLanguageAvailable"
	/// The feedback when user trying to access the Translation Management page without adding a language other than their source language first
	/// English String: "Translated content does not exist. Add a translation language in Configure Localization to translate game content."
	/// </summary>
	public override string ResponseNoTranslationLanguageAvailable => "Não há conteúdo traduzido. Adicione um idioma para tradução em \"Configurar localização\" para traduzir o conteúdo do jogo.";

	/// <summary>
	/// Key: "Response.SaveFailure"
	/// Feedback message if a change cannot be saved
	/// English String: "Could not save. Please try again."
	/// </summary>
	public override string ResponseSaveFailure => "Impossível salvar. Tente novamente.";

	/// <summary>
	/// Key: "Response.TooManyFiles"
	/// English String: "Too many files. Please upload up to 10 files only."
	/// </summary>
	public override string ResponseTooManyFiles => "Há arquivos demais. Carregue até 10 arquivos.";

	public TranslationManagementResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionPleaseReload()
	{
		return "Recarregue por favor.";
	}

	protected override string _GetTemplateForDescriptionAcceptableFilesForIcon()
	{
		return "Formatos aceitos: jpg, jpeg, png";
	}

	protected override string _GetTemplateForDescriptionAcceptableFilesForThumbnail()
	{
		return "Formatos aceitos: jpg, jpeg, png";
	}

	/// <summary>
	/// Key: "Description.CharacterLimit"
	/// Description for character limit of name/description
	/// English String: "{limitNumber} Characters"
	/// </summary>
	public override string DescriptionCharacterLimit(string limitNumber)
	{
		return $"{limitNumber} caracteres";
	}

	protected override string _GetTemplateForDescriptionCharacterLimit()
	{
		return "{limitNumber} caracteres";
	}

	protected override string _GetTemplateForDescriptionEnterTranslationHere()
	{
		return "Insira a tradução aqui";
	}

	protected override string _GetTemplateForDescriptionIconWillBeReviewed()
	{
		return "A imagem será revisada por moderadores antes de poder ser vista por outros usuários";
	}

	protected override string _GetTemplateForDescriptionImageNotAvailable()
	{
		return "Imagem não disponível.";
	}

	protected override string _GetTemplateForDescriptionMaximumSizeForIcon()
	{
		return "Tamanho máximo do arquivo: 4 MB";
	}

	protected override string _GetTemplateForDescriptionMaximumSizeForThumbnail()
	{
		return "Tamanho máximo do arquivo: 4 MB";
	}

	protected override string _GetTemplateForDescriptionNoGameProducts()
	{
		return "Não há produtos de jogo encontrados para esse jogo";
	}

	protected override string _GetTemplateForDescriptionRecommendedResolution()
	{
		return "Resolução recomendada: 512 x 512";
	}

	protected override string _GetTemplateForDescriptionRecommendedResolutionForIcon()
	{
		return "Resolução recomendada: 512 x 512";
	}

	protected override string _GetTemplateForDescriptionRecommendedResolutionForThumbnail()
	{
		return "Resolução recomendada: 1920 x 1080";
	}

	protected override string _GetTemplateForDescriptionScreenshotsLimitForThumbnail()
	{
		return "É possível definir até 10 capturas de tela";
	}

	protected override string _GetTemplateForDescriptionUnsavedChanges()
	{
		return "As alterações não salvas serão descartadas. Você tem certeza?";
	}

	protected override string _GetTemplateForHeadingBadgeDescription()
	{
		return "Descrição da insígnea";
	}

	protected override string _GetTemplateForHeadingBadgeName()
	{
		return "Nome da insígnea";
	}

	protected override string _GetTemplateForHeadingGameDescription()
	{
		return "Descrição do jogo";
	}

	protected override string _GetTemplateForHeadingGameIcon()
	{
		return "Ícone do jogo";
	}

	protected override string _GetTemplateForHeadingGameName()
	{
		return "Nome do jogo";
	}

	protected override string _GetTemplateForHeadingGameThumbnails()
	{
		return "Miniaturas do jogo";
	}

	protected override string _GetTemplateForHeadingManageTranslations()
	{
		return "Gerenciar traduções";
	}

	protected override string _GetTemplateForHeadingNoContent()
	{
		return "Sem conteúdo";
	}

	protected override string _GetTemplateForHeadingThumbnails()
	{
		return "Miniaturas";
	}

	protected override string _GetTemplateForHeadingTranslationHistory()
	{
		return "Histórico de tradução";
	}

	protected override string _GetTemplateForHeadingTranslationManagement()
	{
		return "Gerenciamento de tradução";
	}

	protected override string _GetTemplateForHeadingUnsavedChanges()
	{
		return "Alterações não salvas";
	}

	protected override string _GetTemplateForLabelDescription()
	{
		return "Descrição";
	}

	protected override string _GetTemplateForLabelGameInformation()
	{
		return "Informações do jogo";
	}

	protected override string _GetTemplateForLabelGameProducts()
	{
		return "Produtos do jogo";
	}

	protected override string _GetTemplateForLabelGameStrings()
	{
		return "Textos do jogo";
	}

	protected override string _GetTemplateForLabelIcon()
	{
		return "Ícone";
	}

	protected override string _GetTemplateForLabelImageHoverText()
	{
		return "Imagem localizada";
	}

	protected override string _GetTemplateForLabelName()
	{
		return "Nome";
	}

	protected override string _GetTemplateForLabelTextToTranslate()
	{
		return "Texto a traduzir";
	}

	protected override string _GetTemplateForLabelThumbnails()
	{
		return "Miniaturas";
	}

	protected override string _GetTemplateForResponseAccessDenied()
	{
		return "Você não tem permissão para acessar esta página";
	}

	protected override string _GetTemplateForResponseContentModerationError()
	{
		return "Impossível salvar. Certifique-se de que o conteúdo não tem problemas de moderação e tente de novo.";
	}

	protected override string _GetTemplateForResponseGeneralError()
	{
		return "Ocorreu um erro. Tente novamente mais tarde.";
	}

	protected override string _GetTemplateForResponseIncorrectFormatOrSize()
	{
		return "Impossível salvar. Certifique-se de que os arquivos têm o tamanho e formato corretos.";
	}

	protected override string _GetTemplateForResponseNoTranslationLanguageAvailable()
	{
		return "Não há conteúdo traduzido. Adicione um idioma para tradução em \"Configurar localização\" para traduzir o conteúdo do jogo.";
	}

	protected override string _GetTemplateForResponseSaveFailure()
	{
		return "Impossível salvar. Tente novamente.";
	}

	protected override string _GetTemplateForResponseTooManyFiles()
	{
		return "Há arquivos demais. Carregue até 10 arquivos.";
	}
}
