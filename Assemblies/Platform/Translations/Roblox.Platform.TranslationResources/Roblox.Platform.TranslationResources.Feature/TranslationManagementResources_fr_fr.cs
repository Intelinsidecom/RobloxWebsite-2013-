namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides TranslationManagementResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TranslationManagementResources_fr_fr : TranslationManagementResources_en_us, ITranslationManagementResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.PleaseReload"
	/// A clickable text which allows user to reload the image and see if it is available.
	/// English String: "Please reload."
	/// </summary>
	public override string ActionPleaseReload => "Recharger.";

	/// <summary>
	/// Key: "Description.AcceptableFilesForIcon"
	/// Tell the developer what types of files their images should be for upload.
	/// English String: "Acceptable files: jpg, jpeg, png"
	/// </summary>
	public override string DescriptionAcceptableFilesForIcon => "Formats acceptés : jpg, jpeg, png";

	/// <summary>
	/// Key: "Description.AcceptableFilesForThumbnail"
	/// English String: "Acceptable files: jpg, jpeg, png"
	/// </summary>
	public override string DescriptionAcceptableFilesForThumbnail => "Formats acceptés : jpg, jpeg, png";

	/// <summary>
	/// Key: "Description.EnterTranslationHere"
	/// Placeholder text for the input text area of name/description
	/// English String: "Enter translation here"
	/// </summary>
	public override string DescriptionEnterTranslationHere => "Saisir la traduction ici";

	/// <summary>
	/// Key: "Description.IconWillBeReviewed"
	/// Tell developers that their game icon image needs to be reviewed by moderators before the public can see it
	/// English String: "Image will be reviewed by moderators before being made visible to other users"
	/// </summary>
	public override string DescriptionIconWillBeReviewed => "* L'image sera examinée par les modérateurs avant d'être visible par les autres joueurs.";

	/// <summary>
	/// Key: "Description.ImageNotAvailable"
	/// Message that tells the user their image is still being prepared
	/// English String: "Image not available."
	/// </summary>
	public override string DescriptionImageNotAvailable => "Image non disponible.";

	/// <summary>
	/// Key: "Description.MaximumSizeForIcon"
	/// The maximum file size for the icon
	/// English String: "Maximum file size: 4 MB"
	/// </summary>
	public override string DescriptionMaximumSizeForIcon => "Taille maximale de fichier : 4MB";

	/// <summary>
	/// Key: "Description.MaximumSizeForThumbnail"
	/// English String: "Maximum file size: 4 MB"
	/// </summary>
	public override string DescriptionMaximumSizeForThumbnail => "Taille maximale de fichier : 4MB";

	/// <summary>
	/// Key: "Description.NoGameProducts"
	/// English String: "No game products found for this game"
	/// </summary>
	public override string DescriptionNoGameProducts => "Aucun produit de jeu trouvé pour ce jeu";

	/// <summary>
	/// Key: "Description.RecommendedResolution"
	/// The recommended resolution for icon image
	/// English String: "Recommended resolution: 512 x 512"
	/// </summary>
	public override string DescriptionRecommendedResolution => "Résolution recommandée : 512 x 512";

	/// <summary>
	/// Key: "Description.RecommendedResolutionForIcon"
	/// English String: "Recommended resolution: 512 x 512"
	/// </summary>
	public override string DescriptionRecommendedResolutionForIcon => "Résolution recommandée : 512 x 512";

	/// <summary>
	/// Key: "Description.RecommendedResolutionForThumbnail"
	/// English String: "Recommended resolution: 1920 x 1080"
	/// </summary>
	public override string DescriptionRecommendedResolutionForThumbnail => "Résolution recommandée : 1920 x 1080";

	/// <summary>
	/// Key: "Description.ScreenshotsLimitForThumbnail"
	/// English String: "You can set up to 10 screenshots"
	/// </summary>
	public override string DescriptionScreenshotsLimitForThumbnail => "Tu peux mettre jusqu'à 10 captures d'écran";

	/// <summary>
	/// Key: "Description.UnsavedChanges"
	/// The body of the modal that asks the user to confirm discarding unsaved changes
	/// English String: "Unsaved changes will be discarded. Are you sure?"
	/// </summary>
	public override string DescriptionUnsavedChanges => "Les modifications non sauvegardées seront annulées. Continuer ?";

	/// <summary>
	/// Key: "Heading.BadgeDescription"
	/// Badge Description localization tool heading
	/// English String: "Badge Description"
	/// </summary>
	public override string HeadingBadgeDescription => "Description de badge";

	/// <summary>
	/// Key: "Heading.BadgeName"
	/// Badge Name localization tool heading
	/// English String: "Badge Name"
	/// </summary>
	public override string HeadingBadgeName => "Nom de badge";

	/// <summary>
	/// Key: "Heading.GameDescription"
	/// Game Description localization tool heading
	/// English String: "Game Description"
	/// </summary>
	public override string HeadingGameDescription => "Description du jeu";

	/// <summary>
	/// Key: "Heading.GameIcon"
	/// Game Icon localization tool heading
	/// English String: "Game Icon"
	/// </summary>
	public override string HeadingGameIcon => "Icône de jeu";

	/// <summary>
	/// Key: "Heading.GameName"
	/// Game Name localization tool heading
	/// English String: "Game Name"
	/// </summary>
	public override string HeadingGameName => "Nom du jeu";

	/// <summary>
	/// Key: "Heading.GameThumbnails"
	/// Game Thumbnails localization tool heading
	/// English String: "Game Thumbnails"
	/// </summary>
	public override string HeadingGameThumbnails => "Vignettes de jeu";

	/// <summary>
	/// Key: "Heading.ManageTranslations"
	/// heading of the manage translations page. Please reuse same translation as crowdsource localization page. We are still working on consolidating these two pages.
	/// English String: "Manage Translations"
	/// </summary>
	public override string HeadingManageTranslations => "Gérer les traductions\u00a0";

	/// <summary>
	/// Key: "Heading.NoContent"
	/// English String: "No Content"
	/// </summary>
	public override string HeadingNoContent => "Aucun contenu";

	/// <summary>
	/// Key: "Heading.Thumbnails"
	/// Title for configuring Game Thumbnails which are shown to user in Game Details page to showcase the game's experiences, aesthetics, marketing, and gameplay.
	/// English String: "Thumbnails"
	/// </summary>
	public override string HeadingThumbnails => "Miniatures";

	/// <summary>
	/// Key: "Heading.TranslationHistory"
	/// Heading for the translation history section of name/description
	/// English String: "Translation History"
	/// </summary>
	public override string HeadingTranslationHistory => "Historique de traduction";

	/// <summary>
	/// Key: "Heading.TranslationManagement"
	/// The title of the translation management page
	/// English String: "Translation Management"
	/// </summary>
	public override string HeadingTranslationManagement => "Gérer les traductions";

	/// <summary>
	/// Key: "Heading.UnsavedChanges"
	/// The heading of the modal that asks the user to confirm discarding unsaved changes
	/// English String: "Unsaved Changes"
	/// </summary>
	public override string HeadingUnsavedChanges => "Modifications non sauvegardées";

	/// <summary>
	/// Key: "Label.Description"
	/// The label for Description I18n sub navigation tab
	/// English String: "Description"
	/// </summary>
	public override string LabelDescription => "Description";

	/// <summary>
	/// Key: "Label.GameInformation"
	/// The label for Game Information I18n navigation tab
	/// English String: "Game Information"
	/// </summary>
	public override string LabelGameInformation => "Informations de jeu";

	/// <summary>
	/// Key: "Label.GameProducts"
	/// The label for Game Products I18n navigation tab
	/// English String: "Game Products"
	/// </summary>
	public override string LabelGameProducts => "Produits de jeu";

	/// <summary>
	/// Key: "Label.GameStrings"
	/// The label for Game Strings I18n navigation tab
	/// English String: "Game Strings"
	/// </summary>
	public override string LabelGameStrings => "Chaîne de jeux";

	/// <summary>
	/// Key: "Label.Icon"
	/// The label for Icon I18n sub navigation tab
	/// English String: "Icon"
	/// </summary>
	public override string LabelIcon => "Icône";

	/// <summary>
	/// Key: "Label.ImageHoverText"
	/// User is hovering over a localized image. Describes screen for user with accessibility settings.
	/// English String: "Localized Image"
	/// </summary>
	public override string LabelImageHoverText => "Image localisée";

	/// <summary>
	/// Key: "Label.Name"
	/// The label for Name I18n sub navigation tab
	/// English String: "Name"
	/// </summary>
	public override string LabelName => "Nom";

	/// <summary>
	/// Key: "Label.TextToTranslate"
	/// Label for the source name/description text
	/// English String: "Text to translate"
	/// </summary>
	public override string LabelTextToTranslate => "Texte à traduire";

	/// <summary>
	/// Key: "Label.Thumbnails"
	/// The label for Thumbnails I18n sub navigation tab
	/// English String: "Thumbnails"
	/// </summary>
	public override string LabelThumbnails => "Miniature";

	/// <summary>
	/// Key: "Response.AccessDenied"
	/// Message if user does not have permission to access the UI
	/// English String: "You don't have permission to access this page"
	/// </summary>
	public override string ResponseAccessDenied => "Tu n'as pas l'autorisation d'accéder à cette page";

	/// <summary>
	/// Key: "Response.ContentModerationError"
	/// The error text when user's input does not pass the text filter
	/// English String: "Could not save. Please check content for moderation and try again."
	/// </summary>
	public override string ResponseContentModerationError => "Erreur\u00a0: enregistrement impossible. Veuillez consulter les signalements avant de réessayer.";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// Message for general errors
	/// English String: "An error has occurred. Please try again later."
	/// </summary>
	public override string ResponseGeneralError => "Une erreur s'est produite, réessaye plus tard\u00a0.";

	/// <summary>
	/// Key: "Response.IncorrectFormatOrSize"
	/// Response shows to user when their icon image fails to save due to incorrect format or size too large
	/// English String: "Could not save. Please make sure files are the correct size and format."
	/// </summary>
	public override string ResponseIncorrectFormatOrSize => "Impossible de sauvegarder. Vérifie que les fichiers sont au format et à la taille corrects.";

	/// <summary>
	/// Key: "Response.NoTranslationLanguageAvailable"
	/// The feedback when user trying to access the Translation Management page without adding a language other than their source language first
	/// English String: "Translated content does not exist. Add a translation language in Configure Localization to translate game content."
	/// </summary>
	public override string ResponseNoTranslationLanguageAvailable => "Contenu traduit inexistant. Ajoutez une langue de traduction dans la section Configurer la localisation pour traduire du contenu.";

	/// <summary>
	/// Key: "Response.SaveFailure"
	/// Feedback message if a change cannot be saved
	/// English String: "Could not save. Please try again."
	/// </summary>
	public override string ResponseSaveFailure => "Sauvegarde impossible. Réessaie.";

	/// <summary>
	/// Key: "Response.TooManyFiles"
	/// English String: "Too many files. Please upload up to 10 files only."
	/// </summary>
	public override string ResponseTooManyFiles => "Trop de fichiers. Merci de ne télécharger que 10 fichiers à la fois.";

	public TranslationManagementResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionPleaseReload()
	{
		return "Recharger.";
	}

	protected override string _GetTemplateForDescriptionAcceptableFilesForIcon()
	{
		return "Formats acceptés : jpg, jpeg, png";
	}

	protected override string _GetTemplateForDescriptionAcceptableFilesForThumbnail()
	{
		return "Formats acceptés : jpg, jpeg, png";
	}

	/// <summary>
	/// Key: "Description.CharacterLimit"
	/// Description for character limit of name/description
	/// English String: "{limitNumber} Characters"
	/// </summary>
	public override string DescriptionCharacterLimit(string limitNumber)
	{
		return $"{limitNumber}\u00a0caractères";
	}

	protected override string _GetTemplateForDescriptionCharacterLimit()
	{
		return "{limitNumber}\u00a0caractères";
	}

	protected override string _GetTemplateForDescriptionEnterTranslationHere()
	{
		return "Saisir la traduction ici";
	}

	protected override string _GetTemplateForDescriptionIconWillBeReviewed()
	{
		return "* L'image sera examinée par les modérateurs avant d'être visible par les autres joueurs.";
	}

	protected override string _GetTemplateForDescriptionImageNotAvailable()
	{
		return "Image non disponible.";
	}

	protected override string _GetTemplateForDescriptionMaximumSizeForIcon()
	{
		return "Taille maximale de fichier : 4MB";
	}

	protected override string _GetTemplateForDescriptionMaximumSizeForThumbnail()
	{
		return "Taille maximale de fichier : 4MB";
	}

	protected override string _GetTemplateForDescriptionNoGameProducts()
	{
		return "Aucun produit de jeu trouvé pour ce jeu";
	}

	protected override string _GetTemplateForDescriptionRecommendedResolution()
	{
		return "Résolution recommandée : 512 x 512";
	}

	protected override string _GetTemplateForDescriptionRecommendedResolutionForIcon()
	{
		return "Résolution recommandée : 512 x 512";
	}

	protected override string _GetTemplateForDescriptionRecommendedResolutionForThumbnail()
	{
		return "Résolution recommandée : 1920 x 1080";
	}

	protected override string _GetTemplateForDescriptionScreenshotsLimitForThumbnail()
	{
		return "Tu peux mettre jusqu'à 10 captures d'écran";
	}

	protected override string _GetTemplateForDescriptionUnsavedChanges()
	{
		return "Les modifications non sauvegardées seront annulées. Continuer ?";
	}

	protected override string _GetTemplateForHeadingBadgeDescription()
	{
		return "Description de badge";
	}

	protected override string _GetTemplateForHeadingBadgeName()
	{
		return "Nom de badge";
	}

	protected override string _GetTemplateForHeadingGameDescription()
	{
		return "Description du jeu";
	}

	protected override string _GetTemplateForHeadingGameIcon()
	{
		return "Icône de jeu";
	}

	protected override string _GetTemplateForHeadingGameName()
	{
		return "Nom du jeu";
	}

	protected override string _GetTemplateForHeadingGameThumbnails()
	{
		return "Vignettes de jeu";
	}

	protected override string _GetTemplateForHeadingManageTranslations()
	{
		return "Gérer les traductions\u00a0";
	}

	protected override string _GetTemplateForHeadingNoContent()
	{
		return "Aucun contenu";
	}

	protected override string _GetTemplateForHeadingThumbnails()
	{
		return "Miniatures";
	}

	protected override string _GetTemplateForHeadingTranslationHistory()
	{
		return "Historique de traduction";
	}

	protected override string _GetTemplateForHeadingTranslationManagement()
	{
		return "Gérer les traductions";
	}

	protected override string _GetTemplateForHeadingUnsavedChanges()
	{
		return "Modifications non sauvegardées";
	}

	protected override string _GetTemplateForLabelDescription()
	{
		return "Description";
	}

	protected override string _GetTemplateForLabelGameInformation()
	{
		return "Informations de jeu";
	}

	protected override string _GetTemplateForLabelGameProducts()
	{
		return "Produits de jeu";
	}

	protected override string _GetTemplateForLabelGameStrings()
	{
		return "Chaîne de jeux";
	}

	protected override string _GetTemplateForLabelIcon()
	{
		return "Icône";
	}

	protected override string _GetTemplateForLabelImageHoverText()
	{
		return "Image localisée";
	}

	protected override string _GetTemplateForLabelName()
	{
		return "Nom";
	}

	protected override string _GetTemplateForLabelTextToTranslate()
	{
		return "Texte à traduire";
	}

	protected override string _GetTemplateForLabelThumbnails()
	{
		return "Miniature";
	}

	protected override string _GetTemplateForResponseAccessDenied()
	{
		return "Tu n'as pas l'autorisation d'accéder à cette page";
	}

	protected override string _GetTemplateForResponseContentModerationError()
	{
		return "Erreur\u00a0: enregistrement impossible. Veuillez consulter les signalements avant de réessayer.";
	}

	protected override string _GetTemplateForResponseGeneralError()
	{
		return "Une erreur s'est produite, réessaye plus tard\u00a0.";
	}

	protected override string _GetTemplateForResponseIncorrectFormatOrSize()
	{
		return "Impossible de sauvegarder. Vérifie que les fichiers sont au format et à la taille corrects.";
	}

	protected override string _GetTemplateForResponseNoTranslationLanguageAvailable()
	{
		return "Contenu traduit inexistant. Ajoutez une langue de traduction dans la section Configurer la localisation pour traduire du contenu.";
	}

	protected override string _GetTemplateForResponseSaveFailure()
	{
		return "Sauvegarde impossible. Réessaie.";
	}

	protected override string _GetTemplateForResponseTooManyFiles()
	{
		return "Trop de fichiers. Merci de ne télécharger que 10 fichiers à la fois.";
	}
}
