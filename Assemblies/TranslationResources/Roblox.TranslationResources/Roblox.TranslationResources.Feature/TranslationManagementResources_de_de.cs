namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides TranslationManagementResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TranslationManagementResources_de_de : TranslationManagementResources_en_us, ITranslationManagementResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.PleaseReload"
	/// A clickable text which allows user to reload the image and see if it is available.
	/// English String: "Please reload."
	/// </summary>
	public override string ActionPleaseReload => "Bitte erneut laden.";

	/// <summary>
	/// Key: "Description.AcceptableFilesForIcon"
	/// Tell the developer what types of files their images should be for upload.
	/// English String: "Acceptable files: jpg, jpeg, png"
	/// </summary>
	public override string DescriptionAcceptableFilesForIcon => "Zulässige Dateien: jpg, jpeg, png";

	/// <summary>
	/// Key: "Description.AcceptableFilesForThumbnail"
	/// English String: "Acceptable files: jpg, jpeg, png"
	/// </summary>
	public override string DescriptionAcceptableFilesForThumbnail => "Zulässige Dateien: jpg, jpeg, png";

	/// <summary>
	/// Key: "Description.EnterTranslationHere"
	/// Placeholder text for the input text area of name/description
	/// English String: "Enter translation here"
	/// </summary>
	public override string DescriptionEnterTranslationHere => "Übersetzung hier eingeben";

	/// <summary>
	/// Key: "Description.IconWillBeReviewed"
	/// Tell developers that their game icon image needs to be reviewed by moderators before the public can see it
	/// English String: "Image will be reviewed by moderators before being made visible to other users"
	/// </summary>
	public override string DescriptionIconWillBeReviewed => "Datei wird von unseren Moderatoren überprüft, bevor sie für andere Benutzer angezeigt wird";

	/// <summary>
	/// Key: "Description.ImageNotAvailable"
	/// Message that tells the user their image is still being prepared
	/// English String: "Image not available."
	/// </summary>
	public override string DescriptionImageNotAvailable => "Bild nicht verfügbar.";

	/// <summary>
	/// Key: "Description.MaximumSizeForIcon"
	/// The maximum file size for the icon
	/// English String: "Maximum file size: 4 MB"
	/// </summary>
	public override string DescriptionMaximumSizeForIcon => "Maximale Dateigröße: 4 MB";

	/// <summary>
	/// Key: "Description.MaximumSizeForThumbnail"
	/// English String: "Maximum file size: 4 MB"
	/// </summary>
	public override string DescriptionMaximumSizeForThumbnail => "Maximale Dateigröße: 4 MB";

	/// <summary>
	/// Key: "Description.NoGameProducts"
	/// English String: "No game products found for this game"
	/// </summary>
	public override string DescriptionNoGameProducts => "Keine Spielartikel für dieses Spiel gefunden";

	/// <summary>
	/// Key: "Description.RecommendedResolution"
	/// The recommended resolution for icon image
	/// English String: "Recommended resolution: 512 x 512"
	/// </summary>
	public override string DescriptionRecommendedResolution => "Empfohlene Auflösung: 512 x 512";

	/// <summary>
	/// Key: "Description.RecommendedResolutionForIcon"
	/// English String: "Recommended resolution: 512 x 512"
	/// </summary>
	public override string DescriptionRecommendedResolutionForIcon => "Empfohlene Auflösung: 512 x 512";

	/// <summary>
	/// Key: "Description.RecommendedResolutionForThumbnail"
	/// English String: "Recommended resolution: 1920 x 1080"
	/// </summary>
	public override string DescriptionRecommendedResolutionForThumbnail => "Empfohlene Auflösung: 1920 x 1080";

	/// <summary>
	/// Key: "Description.ScreenshotsLimitForThumbnail"
	/// English String: "You can set up to 10 screenshots"
	/// </summary>
	public override string DescriptionScreenshotsLimitForThumbnail => "Du kannst bis zu 10 Screenshots erstellen";

	/// <summary>
	/// Key: "Description.UnsavedChanges"
	/// The body of the modal that asks the user to confirm discarding unsaved changes
	/// English String: "Unsaved changes will be discarded. Are you sure?"
	/// </summary>
	public override string DescriptionUnsavedChanges => "Nicht gespeicherte Änderungen gehen verloren. Bist du dir sicher?";

	/// <summary>
	/// Key: "Heading.BadgeDescription"
	/// Badge Description localization tool heading
	/// English String: "Badge Description"
	/// </summary>
	public override string HeadingBadgeDescription => "Abzeichen-Beschreibung";

	/// <summary>
	/// Key: "Heading.BadgeName"
	/// Badge Name localization tool heading
	/// English String: "Badge Name"
	/// </summary>
	public override string HeadingBadgeName => "Abzeichen-Name";

	/// <summary>
	/// Key: "Heading.GameDescription"
	/// Game Description localization tool heading
	/// English String: "Game Description"
	/// </summary>
	public override string HeadingGameDescription => "Spielbeschreibung";

	/// <summary>
	/// Key: "Heading.GameIcon"
	/// Game Icon localization tool heading
	/// English String: "Game Icon"
	/// </summary>
	public override string HeadingGameIcon => "Spielsymbol";

	/// <summary>
	/// Key: "Heading.GameName"
	/// Game Name localization tool heading
	/// English String: "Game Name"
	/// </summary>
	public override string HeadingGameName => "Spielname";

	/// <summary>
	/// Key: "Heading.GameThumbnails"
	/// Game Thumbnails localization tool heading
	/// English String: "Game Thumbnails"
	/// </summary>
	public override string HeadingGameThumbnails => "Spielminiaturansichten";

	/// <summary>
	/// Key: "Heading.ManageTranslations"
	/// heading of the manage translations page. Please reuse same translation as crowdsource localization page. We are still working on consolidating these two pages.
	/// English String: "Manage Translations"
	/// </summary>
	public override string HeadingManageTranslations => "Übersetzungen verwalten";

	/// <summary>
	/// Key: "Heading.NoContent"
	/// English String: "No Content"
	/// </summary>
	public override string HeadingNoContent => "Kein Inhalt";

	/// <summary>
	/// Key: "Heading.Thumbnails"
	/// Title for configuring Game Thumbnails which are shown to user in Game Details page to showcase the game's experiences, aesthetics, marketing, and gameplay.
	/// English String: "Thumbnails"
	/// </summary>
	public override string HeadingThumbnails => "Miniaturansichten";

	/// <summary>
	/// Key: "Heading.TranslationHistory"
	/// Heading for the translation history section of name/description
	/// English String: "Translation History"
	/// </summary>
	public override string HeadingTranslationHistory => "Übersetzungsverlauf";

	/// <summary>
	/// Key: "Heading.TranslationManagement"
	/// The title of the translation management page
	/// English String: "Translation Management"
	/// </summary>
	public override string HeadingTranslationManagement => "Übersetzungsverwaltung";

	/// <summary>
	/// Key: "Heading.UnsavedChanges"
	/// The heading of the modal that asks the user to confirm discarding unsaved changes
	/// English String: "Unsaved Changes"
	/// </summary>
	public override string HeadingUnsavedChanges => "Nicht gespeicherte Änderungen";

	/// <summary>
	/// Key: "Label.Description"
	/// The label for Description I18n sub navigation tab
	/// English String: "Description"
	/// </summary>
	public override string LabelDescription => "Beschreibung";

	/// <summary>
	/// Key: "Label.GameInformation"
	/// The label for Game Information I18n navigation tab
	/// English String: "Game Information"
	/// </summary>
	public override string LabelGameInformation => "Spielinfos";

	/// <summary>
	/// Key: "Label.GameProducts"
	/// The label for Game Products I18n navigation tab
	/// English String: "Game Products"
	/// </summary>
	public override string LabelGameProducts => "Spielprodukte";

	/// <summary>
	/// Key: "Label.GameStrings"
	/// The label for Game Strings I18n navigation tab
	/// English String: "Game Strings"
	/// </summary>
	public override string LabelGameStrings => "Spiele-Strings";

	/// <summary>
	/// Key: "Label.Icon"
	/// The label for Icon I18n sub navigation tab
	/// English String: "Icon"
	/// </summary>
	public override string LabelIcon => "Symbol";

	/// <summary>
	/// Key: "Label.ImageHoverText"
	/// User is hovering over a localized image. Describes screen for user with accessibility settings.
	/// English String: "Localized Image"
	/// </summary>
	public override string LabelImageHoverText => "Lokalisiertes Bild";

	/// <summary>
	/// Key: "Label.Name"
	/// The label for Name I18n sub navigation tab
	/// English String: "Name"
	/// </summary>
	public override string LabelName => "Name";

	/// <summary>
	/// Key: "Label.TextToTranslate"
	/// Label for the source name/description text
	/// English String: "Text to translate"
	/// </summary>
	public override string LabelTextToTranslate => "Text zum Übersetzen";

	/// <summary>
	/// Key: "Label.Thumbnails"
	/// The label for Thumbnails I18n sub navigation tab
	/// English String: "Thumbnails"
	/// </summary>
	public override string LabelThumbnails => "Miniaturansichten";

	/// <summary>
	/// Key: "Response.AccessDenied"
	/// Message if user does not have permission to access the UI
	/// English String: "You don't have permission to access this page"
	/// </summary>
	public override string ResponseAccessDenied => "Du hast nicht die nötigen Rechte, um diese Seite aufzurufen";

	/// <summary>
	/// Key: "Response.ContentModerationError"
	/// The error text when user's input does not pass the text filter
	/// English String: "Could not save. Please check content for moderation and try again."
	/// </summary>
	public override string ResponseContentModerationError => "Konnte nicht speichern. Bitte überprüfe den Inhalt auf Moderation und versuche es erneut.";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// Message for general errors
	/// English String: "An error has occurred. Please try again later."
	/// </summary>
	public override string ResponseGeneralError => "Ein Fehler ist aufgetreten. Bitte versuche es später erneut.";

	/// <summary>
	/// Key: "Response.IncorrectFormatOrSize"
	/// Response shows to user when their icon image fails to save due to incorrect format or size too large
	/// English String: "Could not save. Please make sure files are the correct size and format."
	/// </summary>
	public override string ResponseIncorrectFormatOrSize => "Konnte nicht gespeichert werden. Bitte stell sicher, dass die Dateien die richtige Größe und das richtige Format haben.";

	/// <summary>
	/// Key: "Response.NoTranslationLanguageAvailable"
	/// The feedback when user trying to access the Translation Management page without adding a language other than their source language first
	/// English String: "Translated content does not exist. Add a translation language in Configure Localization to translate game content."
	/// </summary>
	public override string ResponseNoTranslationLanguageAvailable => "Der übersetzte Inhalt existiert nicht. Füge in „Lokalisierung konfigurieren“ eine Übersetzungssprache hinzu, um Spielinhalte zu übersetzen.";

	/// <summary>
	/// Key: "Response.SaveFailure"
	/// Feedback message if a change cannot be saved
	/// English String: "Could not save. Please try again."
	/// </summary>
	public override string ResponseSaveFailure => "Konnte nicht gespeichert werden. Bitte versuche es erneut.";

	/// <summary>
	/// Key: "Response.TooManyFiles"
	/// English String: "Too many files. Please upload up to 10 files only."
	/// </summary>
	public override string ResponseTooManyFiles => "Zu viele Dateien. Bitte nur bis zu 10 Dateien hochladen.";

	public TranslationManagementResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionPleaseReload()
	{
		return "Bitte erneut laden.";
	}

	protected override string _GetTemplateForDescriptionAcceptableFilesForIcon()
	{
		return "Zulässige Dateien: jpg, jpeg, png";
	}

	protected override string _GetTemplateForDescriptionAcceptableFilesForThumbnail()
	{
		return "Zulässige Dateien: jpg, jpeg, png";
	}

	/// <summary>
	/// Key: "Description.CharacterLimit"
	/// Description for character limit of name/description
	/// English String: "{limitNumber} Characters"
	/// </summary>
	public override string DescriptionCharacterLimit(string limitNumber)
	{
		return $"{limitNumber} Zeichen";
	}

	protected override string _GetTemplateForDescriptionCharacterLimit()
	{
		return "{limitNumber} Zeichen";
	}

	protected override string _GetTemplateForDescriptionEnterTranslationHere()
	{
		return "Übersetzung hier eingeben";
	}

	protected override string _GetTemplateForDescriptionIconWillBeReviewed()
	{
		return "Datei wird von unseren Moderatoren überprüft, bevor sie für andere Benutzer angezeigt wird";
	}

	protected override string _GetTemplateForDescriptionImageNotAvailable()
	{
		return "Bild nicht verfügbar.";
	}

	protected override string _GetTemplateForDescriptionMaximumSizeForIcon()
	{
		return "Maximale Dateigröße: 4 MB";
	}

	protected override string _GetTemplateForDescriptionMaximumSizeForThumbnail()
	{
		return "Maximale Dateigröße: 4 MB";
	}

	protected override string _GetTemplateForDescriptionNoGameProducts()
	{
		return "Keine Spielartikel für dieses Spiel gefunden";
	}

	protected override string _GetTemplateForDescriptionRecommendedResolution()
	{
		return "Empfohlene Auflösung: 512 x 512";
	}

	protected override string _GetTemplateForDescriptionRecommendedResolutionForIcon()
	{
		return "Empfohlene Auflösung: 512 x 512";
	}

	protected override string _GetTemplateForDescriptionRecommendedResolutionForThumbnail()
	{
		return "Empfohlene Auflösung: 1920 x 1080";
	}

	protected override string _GetTemplateForDescriptionScreenshotsLimitForThumbnail()
	{
		return "Du kannst bis zu 10 Screenshots erstellen";
	}

	protected override string _GetTemplateForDescriptionUnsavedChanges()
	{
		return "Nicht gespeicherte Änderungen gehen verloren. Bist du dir sicher?";
	}

	protected override string _GetTemplateForHeadingBadgeDescription()
	{
		return "Abzeichen-Beschreibung";
	}

	protected override string _GetTemplateForHeadingBadgeName()
	{
		return "Abzeichen-Name";
	}

	protected override string _GetTemplateForHeadingGameDescription()
	{
		return "Spielbeschreibung";
	}

	protected override string _GetTemplateForHeadingGameIcon()
	{
		return "Spielsymbol";
	}

	protected override string _GetTemplateForHeadingGameName()
	{
		return "Spielname";
	}

	protected override string _GetTemplateForHeadingGameThumbnails()
	{
		return "Spielminiaturansichten";
	}

	protected override string _GetTemplateForHeadingManageTranslations()
	{
		return "Übersetzungen verwalten";
	}

	protected override string _GetTemplateForHeadingNoContent()
	{
		return "Kein Inhalt";
	}

	protected override string _GetTemplateForHeadingThumbnails()
	{
		return "Miniaturansichten";
	}

	protected override string _GetTemplateForHeadingTranslationHistory()
	{
		return "Übersetzungsverlauf";
	}

	protected override string _GetTemplateForHeadingTranslationManagement()
	{
		return "Übersetzungsverwaltung";
	}

	protected override string _GetTemplateForHeadingUnsavedChanges()
	{
		return "Nicht gespeicherte Änderungen";
	}

	protected override string _GetTemplateForLabelDescription()
	{
		return "Beschreibung";
	}

	protected override string _GetTemplateForLabelGameInformation()
	{
		return "Spielinfos";
	}

	protected override string _GetTemplateForLabelGameProducts()
	{
		return "Spielprodukte";
	}

	protected override string _GetTemplateForLabelGameStrings()
	{
		return "Spiele-Strings";
	}

	protected override string _GetTemplateForLabelIcon()
	{
		return "Symbol";
	}

	protected override string _GetTemplateForLabelImageHoverText()
	{
		return "Lokalisiertes Bild";
	}

	protected override string _GetTemplateForLabelName()
	{
		return "Name";
	}

	protected override string _GetTemplateForLabelTextToTranslate()
	{
		return "Text zum Übersetzen";
	}

	protected override string _GetTemplateForLabelThumbnails()
	{
		return "Miniaturansichten";
	}

	protected override string _GetTemplateForResponseAccessDenied()
	{
		return "Du hast nicht die nötigen Rechte, um diese Seite aufzurufen";
	}

	protected override string _GetTemplateForResponseContentModerationError()
	{
		return "Konnte nicht speichern. Bitte überprüfe den Inhalt auf Moderation und versuche es erneut.";
	}

	protected override string _GetTemplateForResponseGeneralError()
	{
		return "Ein Fehler ist aufgetreten. Bitte versuche es später erneut.";
	}

	protected override string _GetTemplateForResponseIncorrectFormatOrSize()
	{
		return "Konnte nicht gespeichert werden. Bitte stell sicher, dass die Dateien die richtige Größe und das richtige Format haben.";
	}

	protected override string _GetTemplateForResponseNoTranslationLanguageAvailable()
	{
		return "Der übersetzte Inhalt existiert nicht. Füge in „Lokalisierung konfigurieren“ eine Übersetzungssprache hinzu, um Spielinhalte zu übersetzen.";
	}

	protected override string _GetTemplateForResponseSaveFailure()
	{
		return "Konnte nicht gespeichert werden. Bitte versuche es erneut.";
	}

	protected override string _GetTemplateForResponseTooManyFiles()
	{
		return "Zu viele Dateien. Bitte nur bis zu 10 Dateien hochladen.";
	}
}
