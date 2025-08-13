namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides ItemConfigurationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ItemConfigurationResources_de_de : ItemConfigurationResources_en_us, IItemConfigurationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Description.AllowCopying"
	/// English String: "By switching on, you are granting every other user of Roblox the right to use (in various ways) the content you are now sharing. If you do not want to grant this right, please do not check this box. For more information about sharing content, please review the Roblox Terms of Use."
	/// </summary>
	public override string DescriptionAllowCopying => "Wenn du dieses Kontrollkästchen aktivierst, gewährst du allen anderen Roblox-Benutzern das Recht, die Inhalte, die du gerade teilst, auf unterschiedliche Art und Weise zu verwenden. Wenn du dieses Recht nicht gewähren möchtest, aktiviere dieses Kontrollkästchen bitte nicht. Weitere Informationen zum Teilen von Inhalten findest du in den Nutzungsbedingungen von Roblox.";

	/// <summary>
	/// Key: "Description.ArchiveWarning"
	/// English String: "Archiving this asset will prevent it from being used in game. Archived assets can be restored."
	/// </summary>
	public override string DescriptionArchiveWarning => "Das Archivieren dieses Assets verhindert, dass es im Spiel verwendet wird. Archivierte Assets können wiederhergestellt werden.";

	/// <summary>
	/// Key: "Description.ClickToAddTag"
	/// Hover text on the button that adds a tag to an item
	/// English String: "Click to add tag"
	/// </summary>
	public override string DescriptionClickToAddTag => "Klicke hier, um Tag hinzufügen";

	/// <summary>
	/// Key: "Description.ModeratorFileReview"
	/// English String: "* Uploaded file will be reviewed by moderators before being made visible to other users"
	/// </summary>
	public override string DescriptionModeratorFileReview => "* Die hochgeladene Datei wird von unseren Moderatoren überprüft, bevor sie für andere Benutzer angezeigt wird";

	/// <summary>
	/// Key: "Description.ModeratorReview"
	/// English String: "* Uploaded image will be reviewed by moderators before being made visible to other users"
	/// </summary>
	public override string DescriptionModeratorReview => "* Das hochgeladene Bild wird von unseren Moderatoren überprüft, bevor es für andere Benutzer angezeigt wird.";

	/// <summary>
	/// Key: "Heading.Archive"
	/// header text for section about archiving assets
	/// English String: "Archive"
	/// </summary>
	public override string HeadingArchive => "Archivieren";

	/// <summary>
	/// Key: "Heading.Configure"
	/// English String: "Configure"
	/// </summary>
	public override string HeadingConfigure => "Konfigurieren";

	/// <summary>
	/// Key: "Heading.ConfigureItemTags"
	/// Heading on Configure Tags modal
	/// English String: "Configure Tags"
	/// </summary>
	public override string HeadingConfigureItemTags => "Tags konfigurieren";

	/// <summary>
	/// Key: "Heading.Create"
	/// English String: "Create"
	/// </summary>
	public override string HeadingCreate => "Erstellen";

	/// <summary>
	/// Key: "Heading.Settings"
	/// English String: "Settings"
	/// </summary>
	public override string HeadingSettings => "Einstellungen";

	/// <summary>
	/// Key: "Label.AllowCopying"
	/// English String: "Allow Copying"
	/// </summary>
	public override string LabelAllowCopying => "Kopieren erlauben";

	/// <summary>
	/// Key: "Label.Archive"
	/// Text on button for archiving an asset. Part of speech: verb
	/// English String: "Archive"
	/// </summary>
	public override string LabelArchive => "Archivieren";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "Abbrechen";

	/// <summary>
	/// Key: "Label.Computer"
	/// computer term
	/// English String: "Computer"
	/// </summary>
	public override string LabelComputer => "Computer";

	/// <summary>
	/// Key: "Label.Created"
	/// English String: "Created"
	/// </summary>
	public override string LabelCreated => "Erstellt";

	/// <summary>
	/// Key: "Label.Current"
	/// English String: "Current"
	/// </summary>
	public override string LabelCurrent => "Aktuell";

	/// <summary>
	/// Key: "Label.CurrentPublishedVersion"
	/// English String: "Current published version"
	/// </summary>
	public override string LabelCurrentPublishedVersion => "Aktuelle veröffentlichte Version";

	/// <summary>
	/// Key: "Label.Description"
	/// English String: "Description"
	/// </summary>
	public override string LabelDescription => "Beschreibung";

	/// <summary>
	/// Key: "Label.Device"
	/// device term
	/// English String: "Device"
	/// </summary>
	public override string LabelDevice => "Gerät";

	/// <summary>
	/// Key: "Label.EnterItemTag"
	/// Placeholder for input field
	/// English String: "Enter tag here..."
	/// </summary>
	public override string LabelEnterItemTag => "Tag hier eingeben ...";

	/// <summary>
	/// Key: "Label.Game"
	/// English String: "Game"
	/// </summary>
	public override string LabelGame => "Spiel";

	/// <summary>
	/// Key: "Label.GamePass"
	/// label
	/// English String: "Game Pass"
	/// </summary>
	public override string LabelGamePass => "Spielpass";

	/// <summary>
	/// Key: "Label.General"
	/// English String: "General"
	/// </summary>
	public override string LabelGeneral => "Allgemein";

	/// <summary>
	/// Key: "Label.GoToDetails"
	/// Link to the item details page from the configure page
	/// English String: "Go to Details"
	/// </summary>
	public override string LabelGoToDetails => "Zu Infos gehen";

	/// <summary>
	/// Key: "Label.ItemActive"
	/// English String: "Item is Active"
	/// </summary>
	public override string LabelItemActive => "Artikel ist aktiv";

	/// <summary>
	/// Key: "Label.ItemForSale"
	/// English String: "Item for Sale"
	/// </summary>
	public override string LabelItemForSale => "Artikel im Angebot";

	/// <summary>
	/// Key: "Label.LastUpdated"
	/// English String: "Last Updated"
	/// </summary>
	public override string LabelLastUpdated => "Zuletzt aktualisiert";

	/// <summary>
	/// Key: "Label.LearnMore"
	/// English String: "Learn more"
	/// </summary>
	public override string LabelLearnMore => "Mehr erfahren";

	/// <summary>
	/// Key: "Label.MarketplaceFee"
	/// English String: "Marketplace Fee"
	/// </summary>
	public override string LabelMarketplaceFee => "Marktplatzgebühr";

	/// <summary>
	/// Key: "Label.Name"
	/// English String: "Name"
	/// </summary>
	public override string LabelName => "Name";

	/// <summary>
	/// Key: "Label.OpenForComments"
	/// English String: "Open for Comments"
	/// </summary>
	public override string LabelOpenForComments => "Kommentare willkommen";

	/// <summary>
	/// Key: "Label.Preview"
	/// English String: "Preview"
	/// </summary>
	public override string LabelPreview => "Vorschau";

	/// <summary>
	/// Key: "Label.Price"
	/// English String: "Price"
	/// </summary>
	public override string LabelPrice => "Preis";

	/// <summary>
	/// Key: "Label.Profit"
	/// English String: "You Earn"
	/// </summary>
	public override string LabelProfit => "Du verdienst";

	/// <summary>
	/// Key: "Label.Restore"
	/// English String: "Restore"
	/// </summary>
	public override string LabelRestore => "Wiederherstellen";

	/// <summary>
	/// Key: "Label.RevertVersion"
	/// English String: "Revert to this version"
	/// </summary>
	public override string LabelRevertVersion => "Diese Version wiederherstellen";

	/// <summary>
	/// Key: "Label.Sales"
	/// English String: "Sales"
	/// </summary>
	public override string LabelSales => "Angebot";

	/// <summary>
	/// Key: "Label.Save"
	/// English String: "Save"
	/// </summary>
	public override string LabelSave => "Speichern";

	/// <summary>
	/// Key: "Label.SelectType"
	/// Placeholder for dropdown in create asset page. Options are image, mesh, hair accessory, etc
	/// English String: "Select a type"
	/// </summary>
	public override string LabelSelectType => "Wähle eine Art aus";

	/// <summary>
	/// Key: "Label.Tags"
	/// The label next to a list of item tags in the item configuration page
	/// English String: "Tags"
	/// </summary>
	public override string LabelTags => "Tags";

	/// <summary>
	/// Key: "Label.Type"
	/// English String: "Type"
	/// </summary>
	public override string LabelType => "Art";

	/// <summary>
	/// Key: "Label.Updated"
	/// English String: "Updated"
	/// </summary>
	public override string LabelUpdated => "Aktualisiert";

	/// <summary>
	/// Key: "Label.Version"
	/// English String: "Version"
	/// </summary>
	public override string LabelVersion => "Version";

	/// <summary>
	/// Key: "Label.Versions"
	/// English String: "Versions"
	/// </summary>
	public override string LabelVersions => "Versionen";

	/// <summary>
	/// Key: "Message.ArchiveError"
	/// English String: "Failed to archive"
	/// </summary>
	public override string MessageArchiveError => "Archivierung fehlgeschlagen";

	/// <summary>
	/// Key: "Message.ArchiveSuccess"
	/// English String: "Successfully archived"
	/// </summary>
	public override string MessageArchiveSuccess => "Erfolgreich archiviert";

	/// <summary>
	/// Key: "Message.DescriptionFieldEmptyError"
	/// English String: "Description cannot be empty"
	/// </summary>
	public override string MessageDescriptionFieldEmptyError => "Beschreibung kann nicht leer sein";

	/// <summary>
	/// Key: "Message.DescriptionTooLongError"
	/// error message
	/// English String: "The description is too long."
	/// </summary>
	public override string MessageDescriptionTooLongError => "Die Beschreibung ist zu lang.";

	/// <summary>
	/// Key: "Message.FilteringServiceUnavailableError"
	/// error message
	/// English String: "Text filtering service is unavailable at this time."
	/// </summary>
	public override string MessageFilteringServiceUnavailableError => "Der Textfilterdienst ist derzeit nicht verfügbar.";

	/// <summary>
	/// Key: "Message.GamePassConfigDisabledError"
	/// error message
	/// English String: "Game Pass configuration is not enabled yet."
	/// </summary>
	public override string MessageGamePassConfigDisabledError => "Die Spielpasskonfiguration wurde noch nicht aktiviert.";

	/// <summary>
	/// Key: "Message.GamePassNotFoundError"
	/// errormessage
	/// English String: "The Game Pass does not exist."
	/// </summary>
	public override string MessageGamePassNotFoundError => "Der Spielpass existiert nicht.";

	/// <summary>
	/// Key: "Message.IconUpdateFailed"
	/// error message
	/// English String: "Failed to update icon."
	/// </summary>
	public override string MessageIconUpdateFailed => "Symbol konnte nicht aktualisiert werden.";

	/// <summary>
	/// Key: "Message.ImageSavingFailedError"
	/// error message
	/// English String: "Failed to save image. Please try again later."
	/// </summary>
	public override string MessageImageSavingFailedError => "Speichern des Bilds fehlgeschlagen. Bitte versuche es später erneut.";

	/// <summary>
	/// Key: "Message.InappropriateTextError"
	/// error message
	/// English String: "The name or description contains inappropriate text."
	/// </summary>
	public override string MessageInappropriateTextError => "Der Name oder die Beschreibung enthalten unangemessenen Text.";

	/// <summary>
	/// Key: "Message.NameFieldEmpty"
	/// English String: "Name cannot be empty"
	/// </summary>
	public override string MessageNameFieldEmpty => "Name darf nicht leer sein";

	/// <summary>
	/// Key: "Message.NameRequiredError"
	/// error message
	/// English String: "The name cannot be empty."
	/// </summary>
	public override string MessageNameRequiredError => "Der Name darf nicht leer sein.";

	/// <summary>
	/// Key: "Message.NoTagsFound"
	/// English String: "No tags found"
	/// </summary>
	public override string MessageNoTagsFound => "Keine Tags gefunden";

	/// <summary>
	/// Key: "Message.RestoreError"
	/// English String: "Failed to restore"
	/// </summary>
	public override string MessageRestoreError => "Wiederherstellung fehlgeschlagen";

	/// <summary>
	/// Key: "Message.RestoreSuccess"
	/// English String: "Successfully restored"
	/// </summary>
	public override string MessageRestoreSuccess => "Erfolgreich wiederhergestellt";

	/// <summary>
	/// Key: "Message.SaveError"
	/// English String: "Something failed. Please try again later"
	/// </summary>
	public override string MessageSaveError => "Etwas ist schiefgelaufen. Bitte versuche es später erneut.";

	/// <summary>
	/// Key: "Message.TooManyUploads"
	/// error message
	/// English String: "You are uploading too much. Please try again later."
	/// </summary>
	public override string MessageTooManyUploads => "Du lädst zu viel hoch. Bitte versuche es später erneut.";

	/// <summary>
	/// Key: "Message.UpdatePriceError"
	/// English String: "Failed to update price"
	/// </summary>
	public override string MessageUpdatePriceError => "Preis-Aktualisierung fehlgeschlagen";

	/// <summary>
	/// Key: "Message.UpdatePriceSuccess"
	/// English String: "Successfully updated price"
	/// </summary>
	public override string MessageUpdatePriceSuccess => "Preis erfolgreich aktualisiert";

	/// <summary>
	/// Key: "Message.UpdateSuccess"
	/// English String: "Successfully updated"
	/// </summary>
	public override string MessageUpdateSuccess => "Erfolgreich aktualisiert";

	public ItemConfigurationResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	/// <summary>
	/// Key: "Description.AcceptableFileFormats"
	/// English String: "* Acceptable file formats: {fileExtensions}"
	/// </summary>
	public override string DescriptionAcceptableFileFormats(string fileExtensions)
	{
		return $"* Zulässige Dateiformate: {fileExtensions}";
	}

	protected override string _GetTemplateForDescriptionAcceptableFileFormats()
	{
		return "* Zulässige Dateiformate: {fileExtensions}";
	}

	/// <summary>
	/// Key: "Description.AcceptableFiles"
	/// English String: "* Acceptable files{lineBreak}Format: {fileExtensions}   |   Size: {fileSizes}"
	/// </summary>
	public override string DescriptionAcceptableFiles(string lineBreak, string fileExtensions, string fileSizes)
	{
		return $"* Zulässige Dateien{lineBreak}Format: {fileExtensions}   |   Größe: {fileSizes}";
	}

	protected override string _GetTemplateForDescriptionAcceptableFiles()
	{
		return "* Zulässige Dateien{lineBreak}Format: {fileExtensions}   |   Größe: {fileSizes}";
	}

	protected override string _GetTemplateForDescriptionAllowCopying()
	{
		return "Wenn du dieses Kontrollkästchen aktivierst, gewährst du allen anderen Roblox-Benutzern das Recht, die Inhalte, die du gerade teilst, auf unterschiedliche Art und Weise zu verwenden. Wenn du dieses Recht nicht gewähren möchtest, aktiviere dieses Kontrollkästchen bitte nicht. Weitere Informationen zum Teilen von Inhalten findest du in den Nutzungsbedingungen von Roblox.";
	}

	/// <summary>
	/// Key: "Description.AllowCopyingWarning"
	/// English String: "By switching on, you are granting every other user of Roblox the right to use (in various ways) the content you are now sharing. If you do not want to grant this right, please do not check this box. For more information about sharing content, please review the Roblox {linkStart}Terms of Use{linkEnd}."
	/// </summary>
	public override string DescriptionAllowCopyingWarning(string linkStart, string linkEnd)
	{
		return $"Wenn du dieses Kontrollkästchen aktivierst, gewährst du allen anderen Roblox-Benutzern das Recht, die Inhalte, die du gerade teilst, auf unterschiedliche Art und Weise zu verwenden. Wenn du dieses Recht nicht gewähren möchtest, aktiviere dieses Kontrollkästchen bitte nicht. Weitere Informationen zum Teilen von Inhalten findest du in den {linkStart}Roblox-Nutzungsbedingungen{linkEnd}.";
	}

	protected override string _GetTemplateForDescriptionAllowCopyingWarning()
	{
		return "Wenn du dieses Kontrollkästchen aktivierst, gewährst du allen anderen Roblox-Benutzern das Recht, die Inhalte, die du gerade teilst, auf unterschiedliche Art und Weise zu verwenden. Wenn du dieses Recht nicht gewähren möchtest, aktiviere dieses Kontrollkästchen bitte nicht. Weitere Informationen zum Teilen von Inhalten findest du in den {linkStart}Roblox-Nutzungsbedingungen{linkEnd}.";
	}

	protected override string _GetTemplateForDescriptionArchiveWarning()
	{
		return "Das Archivieren dieses Assets verhindert, dass es im Spiel verwendet wird. Archivierte Assets können wiederhergestellt werden.";
	}

	protected override string _GetTemplateForDescriptionClickToAddTag()
	{
		return "Klicke hier, um Tag hinzufügen";
	}

	/// <summary>
	/// Key: "Description.MarketplaceExplanation"
	/// English String: "(Roblox takes {marketplaceFeePercentage}%, minimum {minimumPrice})"
	/// </summary>
	public override string DescriptionMarketplaceExplanation(string marketplaceFeePercentage, string minimumPrice)
	{
		return $"(Roblox behält {marketplaceFeePercentage}\u00a0% ein, mindestens jedoch {minimumPrice})";
	}

	protected override string _GetTemplateForDescriptionMarketplaceExplanation()
	{
		return "(Roblox behält {marketplaceFeePercentage}\u00a0% ein, mindestens jedoch {minimumPrice})";
	}

	protected override string _GetTemplateForDescriptionModeratorFileReview()
	{
		return "* Die hochgeladene Datei wird von unseren Moderatoren überprüft, bevor sie für andere Benutzer angezeigt wird";
	}

	protected override string _GetTemplateForDescriptionModeratorReview()
	{
		return "* Das hochgeladene Bild wird von unseren Moderatoren überprüft, bevor es für andere Benutzer angezeigt wird.";
	}

	/// <summary>
	/// Key: "Description.SelectItemTags"
	/// itemTagLimit is the number of item tags allowed
	/// English String: "Select up to {itemTagLimit} tags."
	/// </summary>
	public override string DescriptionSelectItemTags(string itemTagLimit)
	{
		return $"Wähle bis zu {itemTagLimit} Tags aus.";
	}

	protected override string _GetTemplateForDescriptionSelectItemTags()
	{
		return "Wähle bis zu {itemTagLimit} Tags aus.";
	}

	public override string DescriptionVerifiedCreatorEmail(string linkStart, string linkEnd)
	{
		return $"Um Inhalte auf dem Markt zu teilen, musst du deinem Konto eine E-Mail-Adresse hinzufügen und diese bestätigen. Dies kann in den {linkStart}Kontoeinstellungen{linkEnd} vorgenommen werden.";
	}

	protected override string _GetTemplateForDescriptionVerifiedCreatorEmail()
	{
		return "Um Inhalte auf dem Markt zu teilen, musst du deinem Konto eine E-Mail-Adresse hinzufügen und diese bestätigen. Dies kann in den {linkStart}Kontoeinstellungen{linkEnd} vorgenommen werden.";
	}

	protected override string _GetTemplateForHeadingArchive()
	{
		return "Archivieren";
	}

	protected override string _GetTemplateForHeadingConfigure()
	{
		return "Konfigurieren";
	}

	/// <summary>
	/// Key: "Heading.ConfigureItem"
	/// English String: "Configure {itemType}"
	/// </summary>
	public override string HeadingConfigureItem(string itemType)
	{
		return $"{itemType} konfigurieren";
	}

	protected override string _GetTemplateForHeadingConfigureItem()
	{
		return "{itemType} konfigurieren";
	}

	protected override string _GetTemplateForHeadingConfigureItemTags()
	{
		return "Tags konfigurieren";
	}

	protected override string _GetTemplateForHeadingCreate()
	{
		return "Erstellen";
	}

	protected override string _GetTemplateForHeadingSettings()
	{
		return "Einstellungen";
	}

	protected override string _GetTemplateForLabelAllowCopying()
	{
		return "Kopieren erlauben";
	}

	protected override string _GetTemplateForLabelArchive()
	{
		return "Archivieren";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "Abbrechen";
	}

	protected override string _GetTemplateForLabelComputer()
	{
		return "Computer";
	}

	protected override string _GetTemplateForLabelCreated()
	{
		return "Erstellt";
	}

	protected override string _GetTemplateForLabelCurrent()
	{
		return "Aktuell";
	}

	protected override string _GetTemplateForLabelCurrentPublishedVersion()
	{
		return "Aktuelle veröffentlichte Version";
	}

	protected override string _GetTemplateForLabelDescription()
	{
		return "Beschreibung";
	}

	protected override string _GetTemplateForLabelDevice()
	{
		return "Gerät";
	}

	protected override string _GetTemplateForLabelEnterItemTag()
	{
		return "Tag hier eingeben ...";
	}

	/// <summary>
	/// Key: "Label.ForItem"
	/// English String: "For {itemType}"
	/// </summary>
	public override string LabelForItem(string itemType)
	{
		return $"Für {itemType}";
	}

	protected override string _GetTemplateForLabelForItem()
	{
		return "Für {itemType}";
	}

	protected override string _GetTemplateForLabelGame()
	{
		return "Spiel";
	}

	protected override string _GetTemplateForLabelGamePass()
	{
		return "Spielpass";
	}

	protected override string _GetTemplateForLabelGeneral()
	{
		return "Allgemein";
	}

	protected override string _GetTemplateForLabelGoToDetails()
	{
		return "Zu Infos gehen";
	}

	protected override string _GetTemplateForLabelItemActive()
	{
		return "Artikel ist aktiv";
	}

	protected override string _GetTemplateForLabelItemForSale()
	{
		return "Artikel im Angebot";
	}

	protected override string _GetTemplateForLabelLastUpdated()
	{
		return "Zuletzt aktualisiert";
	}

	protected override string _GetTemplateForLabelLearnMore()
	{
		return "Mehr erfahren";
	}

	protected override string _GetTemplateForLabelMarketplaceFee()
	{
		return "Marktplatzgebühr";
	}

	protected override string _GetTemplateForLabelName()
	{
		return "Name";
	}

	protected override string _GetTemplateForLabelOpenForComments()
	{
		return "Kommentare willkommen";
	}

	protected override string _GetTemplateForLabelPreview()
	{
		return "Vorschau";
	}

	protected override string _GetTemplateForLabelPrice()
	{
		return "Preis";
	}

	protected override string _GetTemplateForLabelProfit()
	{
		return "Du verdienst";
	}

	protected override string _GetTemplateForLabelRestore()
	{
		return "Wiederherstellen";
	}

	protected override string _GetTemplateForLabelRevertVersion()
	{
		return "Diese Version wiederherstellen";
	}

	protected override string _GetTemplateForLabelSales()
	{
		return "Angebot";
	}

	protected override string _GetTemplateForLabelSave()
	{
		return "Speichern";
	}

	protected override string _GetTemplateForLabelSelectType()
	{
		return "Wähle eine Art aus";
	}

	protected override string _GetTemplateForLabelTags()
	{
		return "Tags";
	}

	protected override string _GetTemplateForLabelType()
	{
		return "Art";
	}

	protected override string _GetTemplateForLabelUpdated()
	{
		return "Aktualisiert";
	}

	protected override string _GetTemplateForLabelVersion()
	{
		return "Version";
	}

	protected override string _GetTemplateForLabelVersions()
	{
		return "Versionen";
	}

	protected override string _GetTemplateForMessageArchiveError()
	{
		return "Archivierung fehlgeschlagen";
	}

	protected override string _GetTemplateForMessageArchiveSuccess()
	{
		return "Erfolgreich archiviert";
	}

	/// <summary>
	/// Key: "Message.DescriptionFieldEmpty"
	/// English String: "{maxDescriptionLength} character limit"
	/// </summary>
	public override string MessageDescriptionFieldEmpty(string maxDescriptionLength)
	{
		return $"Maximal {maxDescriptionLength} Zeichen";
	}

	protected override string _GetTemplateForMessageDescriptionFieldEmpty()
	{
		return "Maximal {maxDescriptionLength} Zeichen";
	}

	protected override string _GetTemplateForMessageDescriptionFieldEmptyError()
	{
		return "Beschreibung kann nicht leer sein";
	}

	/// <summary>
	/// Key: "Message.DescriptionFieldPopulated"
	/// English String: "{descriptionLength}/{maxDescriptionLength} characters"
	/// </summary>
	public override string MessageDescriptionFieldPopulated(string descriptionLength, string maxDescriptionLength)
	{
		return $"{descriptionLength}/{maxDescriptionLength} Zeichen";
	}

	protected override string _GetTemplateForMessageDescriptionFieldPopulated()
	{
		return "{descriptionLength}/{maxDescriptionLength} Zeichen";
	}

	protected override string _GetTemplateForMessageDescriptionTooLongError()
	{
		return "Die Beschreibung ist zu lang.";
	}

	protected override string _GetTemplateForMessageFilteringServiceUnavailableError()
	{
		return "Der Textfilterdienst ist derzeit nicht verfügbar.";
	}

	protected override string _GetTemplateForMessageGamePassConfigDisabledError()
	{
		return "Die Spielpasskonfiguration wurde noch nicht aktiviert.";
	}

	protected override string _GetTemplateForMessageGamePassNotFoundError()
	{
		return "Der Spielpass existiert nicht.";
	}

	protected override string _GetTemplateForMessageIconUpdateFailed()
	{
		return "Symbol konnte nicht aktualisiert werden.";
	}

	protected override string _GetTemplateForMessageImageSavingFailedError()
	{
		return "Speichern des Bilds fehlgeschlagen. Bitte versuche es später erneut.";
	}

	protected override string _GetTemplateForMessageInappropriateTextError()
	{
		return "Der Name oder die Beschreibung enthalten unangemessenen Text.";
	}

	/// <summary>
	/// Key: "Message.MinimumPrice"
	/// English String: "You cannot set a price below the minimum price of {minimumPrice}"
	/// </summary>
	public override string MessageMinimumPrice(string minimumPrice)
	{
		return $"Du kannst den Preis nicht unter den Mindestpreis von {minimumPrice} senken.";
	}

	protected override string _GetTemplateForMessageMinimumPrice()
	{
		return "Du kannst den Preis nicht unter den Mindestpreis von {minimumPrice} senken.";
	}

	protected override string _GetTemplateForMessageNameFieldEmpty()
	{
		return "Name darf nicht leer sein";
	}

	/// <summary>
	/// Key: "Message.NameFieldPopulated"
	/// English String: "{nameLength}/{maxNameLength} characters"
	/// </summary>
	public override string MessageNameFieldPopulated(string nameLength, string maxNameLength)
	{
		return $"{nameLength}/{maxNameLength} Zeichen";
	}

	protected override string _GetTemplateForMessageNameFieldPopulated()
	{
		return "{nameLength}/{maxNameLength} Zeichen";
	}

	protected override string _GetTemplateForMessageNameRequiredError()
	{
		return "Der Name darf nicht leer sein.";
	}

	protected override string _GetTemplateForMessageNoTagsFound()
	{
		return "Keine Tags gefunden";
	}

	protected override string _GetTemplateForMessageRestoreError()
	{
		return "Wiederherstellung fehlgeschlagen";
	}

	protected override string _GetTemplateForMessageRestoreSuccess()
	{
		return "Erfolgreich wiederhergestellt";
	}

	/// <summary>
	/// Key: "Message.RevertError"
	/// English String: "Failed to revert to version {versionNumber}"
	/// </summary>
	public override string MessageRevertError(string versionNumber)
	{
		return $"Version {versionNumber} konnte nicht wiederhergestellt werden";
	}

	protected override string _GetTemplateForMessageRevertError()
	{
		return "Version {versionNumber} konnte nicht wiederhergestellt werden";
	}

	/// <summary>
	/// Key: "Message.RevertSuccess"
	/// English String: "Successfully reverted to version {versionNumber}"
	/// </summary>
	public override string MessageRevertSuccess(string versionNumber)
	{
		return $"Version {versionNumber} wurde erfolgreich wiederhergestellt";
	}

	protected override string _GetTemplateForMessageRevertSuccess()
	{
		return "Version {versionNumber} wurde erfolgreich wiederhergestellt";
	}

	protected override string _GetTemplateForMessageSaveError()
	{
		return "Etwas ist schiefgelaufen. Bitte versuche es später erneut.";
	}

	protected override string _GetTemplateForMessageTooManyUploads()
	{
		return "Du lädst zu viel hoch. Bitte versuche es später erneut.";
	}

	protected override string _GetTemplateForMessageUpdatePriceError()
	{
		return "Preis-Aktualisierung fehlgeschlagen";
	}

	protected override string _GetTemplateForMessageUpdatePriceSuccess()
	{
		return "Preis erfolgreich aktualisiert";
	}

	protected override string _GetTemplateForMessageUpdateSuccess()
	{
		return "Erfolgreich aktualisiert";
	}
}
