namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides TranslationManagementResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TranslationManagementResources_es_es : TranslationManagementResources_en_us, ITranslationManagementResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.PleaseReload"
	/// A clickable text which allows user to reload the image and see if it is available.
	/// English String: "Please reload."
	/// </summary>
	public override string ActionPleaseReload => "Volver a cargar";

	/// <summary>
	/// Key: "Description.AcceptableFilesForIcon"
	/// Tell the developer what types of files their images should be for upload.
	/// English String: "Acceptable files: jpg, jpeg, png"
	/// </summary>
	public override string DescriptionAcceptableFilesForIcon => "Archivos aceptados: jpg, jpeg, png";

	/// <summary>
	/// Key: "Description.AcceptableFilesForThumbnail"
	/// English String: "Acceptable files: jpg, jpeg, png"
	/// </summary>
	public override string DescriptionAcceptableFilesForThumbnail => "Archivos aceptados: jpg, jpeg, png";

	/// <summary>
	/// Key: "Description.EnterTranslationHere"
	/// Placeholder text for the input text area of name/description
	/// English String: "Enter translation here"
	/// </summary>
	public override string DescriptionEnterTranslationHere => "Escribe la traducción aquí";

	/// <summary>
	/// Key: "Description.IconWillBeReviewed"
	/// Tell developers that their game icon image needs to be reviewed by moderators before the public can see it
	/// English String: "Image will be reviewed by moderators before being made visible to other users"
	/// </summary>
	public override string DescriptionIconWillBeReviewed => "La imagen subida será revisada por los moderadores antes de que sea visible para otros usuarios";

	/// <summary>
	/// Key: "Description.ImageNotAvailable"
	/// Message that tells the user their image is still being prepared
	/// English String: "Image not available."
	/// </summary>
	public override string DescriptionImageNotAvailable => "Imagen no disponible.";

	/// <summary>
	/// Key: "Description.MaximumSizeForIcon"
	/// The maximum file size for the icon
	/// English String: "Maximum file size: 4 MB"
	/// </summary>
	public override string DescriptionMaximumSizeForIcon => "Tamaño máximo del archivo: 4MB";

	/// <summary>
	/// Key: "Description.MaximumSizeForThumbnail"
	/// English String: "Maximum file size: 4 MB"
	/// </summary>
	public override string DescriptionMaximumSizeForThumbnail => "Tamaño máximo del archivo: 4MB";

	/// <summary>
	/// Key: "Description.NoGameProducts"
	/// English String: "No game products found for this game"
	/// </summary>
	public override string DescriptionNoGameProducts => "No se han encontrado productos para este juego";

	/// <summary>
	/// Key: "Description.RecommendedResolution"
	/// The recommended resolution for icon image
	/// English String: "Recommended resolution: 512 x 512"
	/// </summary>
	public override string DescriptionRecommendedResolution => "Resolución recomendada: 512x512";

	/// <summary>
	/// Key: "Description.RecommendedResolutionForIcon"
	/// English String: "Recommended resolution: 512 x 512"
	/// </summary>
	public override string DescriptionRecommendedResolutionForIcon => "Resolución recomendada: 512x512";

	/// <summary>
	/// Key: "Description.RecommendedResolutionForThumbnail"
	/// English String: "Recommended resolution: 1920 x 1080"
	/// </summary>
	public override string DescriptionRecommendedResolutionForThumbnail => "Resolución recomendada: 1920x1080";

	/// <summary>
	/// Key: "Description.ScreenshotsLimitForThumbnail"
	/// English String: "You can set up to 10 screenshots"
	/// </summary>
	public override string DescriptionScreenshotsLimitForThumbnail => "Puedes cargar hasta 10 capturas de pantalla";

	/// <summary>
	/// Key: "Description.UnsavedChanges"
	/// The body of the modal that asks the user to confirm discarding unsaved changes
	/// English String: "Unsaved changes will be discarded. Are you sure?"
	/// </summary>
	public override string DescriptionUnsavedChanges => "Se eliminarán los cambios sin guardar. ¿Estás seguro de que quieres continuar?";

	/// <summary>
	/// Key: "Heading.BadgeDescription"
	/// Badge Description localization tool heading
	/// English String: "Badge Description"
	/// </summary>
	public override string HeadingBadgeDescription => "Descripción del emblema";

	/// <summary>
	/// Key: "Heading.BadgeName"
	/// Badge Name localization tool heading
	/// English String: "Badge Name"
	/// </summary>
	public override string HeadingBadgeName => "Nombre del emblema";

	/// <summary>
	/// Key: "Heading.GameDescription"
	/// Game Description localization tool heading
	/// English String: "Game Description"
	/// </summary>
	public override string HeadingGameDescription => "Descripción del juego";

	/// <summary>
	/// Key: "Heading.GameIcon"
	/// Game Icon localization tool heading
	/// English String: "Game Icon"
	/// </summary>
	public override string HeadingGameIcon => "Icono del juego";

	/// <summary>
	/// Key: "Heading.GameName"
	/// Game Name localization tool heading
	/// English String: "Game Name"
	/// </summary>
	public override string HeadingGameName => "Nombre del juego";

	/// <summary>
	/// Key: "Heading.GameThumbnails"
	/// Game Thumbnails localization tool heading
	/// English String: "Game Thumbnails"
	/// </summary>
	public override string HeadingGameThumbnails => "Miniaturas del juego";

	/// <summary>
	/// Key: "Heading.ManageTranslations"
	/// heading of the manage translations page. Please reuse same translation as crowdsource localization page. We are still working on consolidating these two pages.
	/// English String: "Manage Translations"
	/// </summary>
	public override string HeadingManageTranslations => "Gestionar traducciones";

	/// <summary>
	/// Key: "Heading.NoContent"
	/// English String: "No Content"
	/// </summary>
	public override string HeadingNoContent => "Sin contenido";

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
	public override string HeadingTranslationHistory => "Historial de traducción";

	/// <summary>
	/// Key: "Heading.TranslationManagement"
	/// The title of the translation management page
	/// English String: "Translation Management"
	/// </summary>
	public override string HeadingTranslationManagement => "Gestionar traducciones";

	/// <summary>
	/// Key: "Heading.UnsavedChanges"
	/// The heading of the modal that asks the user to confirm discarding unsaved changes
	/// English String: "Unsaved Changes"
	/// </summary>
	public override string HeadingUnsavedChanges => "Cambios sin guardar";

	/// <summary>
	/// Key: "Label.Description"
	/// The label for Description I18n sub navigation tab
	/// English String: "Description"
	/// </summary>
	public override string LabelDescription => "Descripción";

	/// <summary>
	/// Key: "Label.GameInformation"
	/// The label for Game Information I18n navigation tab
	/// English String: "Game Information"
	/// </summary>
	public override string LabelGameInformation => "Información del juego";

	/// <summary>
	/// Key: "Label.GameProducts"
	/// The label for Game Products I18n navigation tab
	/// English String: "Game Products"
	/// </summary>
	public override string LabelGameProducts => "Productos del juego";

	/// <summary>
	/// Key: "Label.GameStrings"
	/// The label for Game Strings I18n navigation tab
	/// English String: "Game Strings"
	/// </summary>
	public override string LabelGameStrings => "Cadenas del juego";

	/// <summary>
	/// Key: "Label.Icon"
	/// The label for Icon I18n sub navigation tab
	/// English String: "Icon"
	/// </summary>
	public override string LabelIcon => "Icono";

	/// <summary>
	/// Key: "Label.ImageHoverText"
	/// User is hovering over a localized image. Describes screen for user with accessibility settings.
	/// English String: "Localized Image"
	/// </summary>
	public override string LabelImageHoverText => "Imagen localizada";

	/// <summary>
	/// Key: "Label.Name"
	/// The label for Name I18n sub navigation tab
	/// English String: "Name"
	/// </summary>
	public override string LabelName => "Nombre";

	/// <summary>
	/// Key: "Label.TextToTranslate"
	/// Label for the source name/description text
	/// English String: "Text to translate"
	/// </summary>
	public override string LabelTextToTranslate => "Texto a traducir";

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
	public override string ResponseAccessDenied => "No tienes permiso para acceder a esta página";

	/// <summary>
	/// Key: "Response.ContentModerationError"
	/// The error text when user's input does not pass the text filter
	/// English String: "Could not save. Please check content for moderation and try again."
	/// </summary>
	public override string ResponseContentModerationError => "No se ha podido guardar. Asegúrate de que pase por el proceso de moderación e inténtalo de nuevo.";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// Message for general errors
	/// English String: "An error has occurred. Please try again later."
	/// </summary>
	public override string ResponseGeneralError => "Se ha producido un error. Inténtalo de nuevo más tarde.";

	/// <summary>
	/// Key: "Response.IncorrectFormatOrSize"
	/// Response shows to user when their icon image fails to save due to incorrect format or size too large
	/// English String: "Could not save. Please make sure files are the correct size and format."
	/// </summary>
	public override string ResponseIncorrectFormatOrSize => "No se ha podido guardar. Asegúrate de que el tamaño y formato de los archivos sean correctos.";

	/// <summary>
	/// Key: "Response.NoTranslationLanguageAvailable"
	/// The feedback when user trying to access the Translation Management page without adding a language other than their source language first
	/// English String: "Translated content does not exist. Add a translation language in Configure Localization to translate game content."
	/// </summary>
	public override string ResponseNoTranslationLanguageAvailable => "No hay contenido traducido. Añade un idioma en Configurar localización para traducir el juego.";

	/// <summary>
	/// Key: "Response.SaveFailure"
	/// Feedback message if a change cannot be saved
	/// English String: "Could not save. Please try again."
	/// </summary>
	public override string ResponseSaveFailure => "No se ha podido guardar. Inténtalo de nuevo.";

	/// <summary>
	/// Key: "Response.TooManyFiles"
	/// English String: "Too many files. Please upload up to 10 files only."
	/// </summary>
	public override string ResponseTooManyFiles => "Demasiados archivos. Puedes cargar hasta 10 archivos.";

	public TranslationManagementResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionPleaseReload()
	{
		return "Volver a cargar";
	}

	protected override string _GetTemplateForDescriptionAcceptableFilesForIcon()
	{
		return "Archivos aceptados: jpg, jpeg, png";
	}

	protected override string _GetTemplateForDescriptionAcceptableFilesForThumbnail()
	{
		return "Archivos aceptados: jpg, jpeg, png";
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
		return "Escribe la traducción aquí";
	}

	protected override string _GetTemplateForDescriptionIconWillBeReviewed()
	{
		return "La imagen subida será revisada por los moderadores antes de que sea visible para otros usuarios";
	}

	protected override string _GetTemplateForDescriptionImageNotAvailable()
	{
		return "Imagen no disponible.";
	}

	protected override string _GetTemplateForDescriptionMaximumSizeForIcon()
	{
		return "Tamaño máximo del archivo: 4MB";
	}

	protected override string _GetTemplateForDescriptionMaximumSizeForThumbnail()
	{
		return "Tamaño máximo del archivo: 4MB";
	}

	protected override string _GetTemplateForDescriptionNoGameProducts()
	{
		return "No se han encontrado productos para este juego";
	}

	protected override string _GetTemplateForDescriptionRecommendedResolution()
	{
		return "Resolución recomendada: 512x512";
	}

	protected override string _GetTemplateForDescriptionRecommendedResolutionForIcon()
	{
		return "Resolución recomendada: 512x512";
	}

	protected override string _GetTemplateForDescriptionRecommendedResolutionForThumbnail()
	{
		return "Resolución recomendada: 1920x1080";
	}

	protected override string _GetTemplateForDescriptionScreenshotsLimitForThumbnail()
	{
		return "Puedes cargar hasta 10 capturas de pantalla";
	}

	protected override string _GetTemplateForDescriptionUnsavedChanges()
	{
		return "Se eliminarán los cambios sin guardar. ¿Estás seguro de que quieres continuar?";
	}

	protected override string _GetTemplateForHeadingBadgeDescription()
	{
		return "Descripción del emblema";
	}

	protected override string _GetTemplateForHeadingBadgeName()
	{
		return "Nombre del emblema";
	}

	protected override string _GetTemplateForHeadingGameDescription()
	{
		return "Descripción del juego";
	}

	protected override string _GetTemplateForHeadingGameIcon()
	{
		return "Icono del juego";
	}

	protected override string _GetTemplateForHeadingGameName()
	{
		return "Nombre del juego";
	}

	protected override string _GetTemplateForHeadingGameThumbnails()
	{
		return "Miniaturas del juego";
	}

	protected override string _GetTemplateForHeadingManageTranslations()
	{
		return "Gestionar traducciones";
	}

	protected override string _GetTemplateForHeadingNoContent()
	{
		return "Sin contenido";
	}

	protected override string _GetTemplateForHeadingThumbnails()
	{
		return "Miniaturas";
	}

	protected override string _GetTemplateForHeadingTranslationHistory()
	{
		return "Historial de traducción";
	}

	protected override string _GetTemplateForHeadingTranslationManagement()
	{
		return "Gestionar traducciones";
	}

	protected override string _GetTemplateForHeadingUnsavedChanges()
	{
		return "Cambios sin guardar";
	}

	protected override string _GetTemplateForLabelDescription()
	{
		return "Descripción";
	}

	protected override string _GetTemplateForLabelGameInformation()
	{
		return "Información del juego";
	}

	protected override string _GetTemplateForLabelGameProducts()
	{
		return "Productos del juego";
	}

	protected override string _GetTemplateForLabelGameStrings()
	{
		return "Cadenas del juego";
	}

	protected override string _GetTemplateForLabelIcon()
	{
		return "Icono";
	}

	protected override string _GetTemplateForLabelImageHoverText()
	{
		return "Imagen localizada";
	}

	protected override string _GetTemplateForLabelName()
	{
		return "Nombre";
	}

	protected override string _GetTemplateForLabelTextToTranslate()
	{
		return "Texto a traducir";
	}

	protected override string _GetTemplateForLabelThumbnails()
	{
		return "Miniaturas";
	}

	protected override string _GetTemplateForResponseAccessDenied()
	{
		return "No tienes permiso para acceder a esta página";
	}

	protected override string _GetTemplateForResponseContentModerationError()
	{
		return "No se ha podido guardar. Asegúrate de que pase por el proceso de moderación e inténtalo de nuevo.";
	}

	protected override string _GetTemplateForResponseGeneralError()
	{
		return "Se ha producido un error. Inténtalo de nuevo más tarde.";
	}

	protected override string _GetTemplateForResponseIncorrectFormatOrSize()
	{
		return "No se ha podido guardar. Asegúrate de que el tamaño y formato de los archivos sean correctos.";
	}

	protected override string _GetTemplateForResponseNoTranslationLanguageAvailable()
	{
		return "No hay contenido traducido. Añade un idioma en Configurar localización para traducir el juego.";
	}

	protected override string _GetTemplateForResponseSaveFailure()
	{
		return "No se ha podido guardar. Inténtalo de nuevo.";
	}

	protected override string _GetTemplateForResponseTooManyFiles()
	{
		return "Demasiados archivos. Puedes cargar hasta 10 archivos.";
	}
}
