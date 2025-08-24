namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides ItemConfigurationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ItemConfigurationResources_fr_fr : ItemConfigurationResources_en_us, IItemConfigurationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Description.AllowCopying"
	/// English String: "By switching on, you are granting every other user of Roblox the right to use (in various ways) the content you are now sharing. If you do not want to grant this right, please do not check this box. For more information about sharing content, please review the Roblox Terms of Use."
	/// </summary>
	public override string DescriptionAllowCopying => "En cochant cette case, tu autorises tous les autres utilisateurs de Roblox à utiliser (de plusieurs façons) le contenu que tu rends disponible. Si tu ne souhaites pas leur accorder ce droit, décoche cette case. Pour plus d'informations à propos du partage de contenu, il faut consulter les Conditions d'utilisation de Roblox.";

	/// <summary>
	/// Key: "Description.ArchiveWarning"
	/// English String: "Archiving this asset will prevent it from being used in game. Archived assets can be restored."
	/// </summary>
	public override string DescriptionArchiveWarning => "L'archivage de cet élément empêchera son utilisation en jeu. Les ressources archivées peuvent être restaurées.";

	/// <summary>
	/// Key: "Description.ClickToAddTag"
	/// Hover text on the button that adds a tag to an item
	/// English String: "Click to add tag"
	/// </summary>
	public override string DescriptionClickToAddTag => "Clique pour ajouter un tag";

	/// <summary>
	/// Key: "Description.ModeratorFileReview"
	/// English String: "* Uploaded file will be reviewed by moderators before being made visible to other users"
	/// </summary>
	public override string DescriptionModeratorFileReview => "* Le fichier téléchargé sera examiné par les modérateurs avant d'être visible par les autres joueurs.";

	/// <summary>
	/// Key: "Description.ModeratorReview"
	/// English String: "* Uploaded image will be reviewed by moderators before being made visible to other users"
	/// </summary>
	public override string DescriptionModeratorReview => "* L'image téléchargée sera examinée par les modérateurs avant d'être visible par les autres joueurs.";

	/// <summary>
	/// Key: "Heading.Archive"
	/// header text for section about archiving assets
	/// English String: "Archive"
	/// </summary>
	public override string HeadingArchive => "Archiver";

	/// <summary>
	/// Key: "Heading.Configure"
	/// English String: "Configure"
	/// </summary>
	public override string HeadingConfigure => "Configurer";

	/// <summary>
	/// Key: "Heading.ConfigureItemTags"
	/// Heading on Configure Tags modal
	/// English String: "Configure Tags"
	/// </summary>
	public override string HeadingConfigureItemTags => "Configuration des tags";

	/// <summary>
	/// Key: "Heading.Create"
	/// English String: "Create"
	/// </summary>
	public override string HeadingCreate => "Créer";

	/// <summary>
	/// Key: "Heading.Settings"
	/// English String: "Settings"
	/// </summary>
	public override string HeadingSettings => "Réglages";

	/// <summary>
	/// Key: "Label.AllowCopying"
	/// English String: "Allow Copying"
	/// </summary>
	public override string LabelAllowCopying => "Autoriser la copie";

	/// <summary>
	/// Key: "Label.Archive"
	/// Text on button for archiving an asset. Part of speech: verb
	/// English String: "Archive"
	/// </summary>
	public override string LabelArchive => "Archiver";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "Annuler";

	/// <summary>
	/// Key: "Label.Computer"
	/// computer term
	/// English String: "Computer"
	/// </summary>
	public override string LabelComputer => "Ordinateur";

	/// <summary>
	/// Key: "Label.Created"
	/// English String: "Created"
	/// </summary>
	public override string LabelCreated => "Créé";

	/// <summary>
	/// Key: "Label.Current"
	/// English String: "Current"
	/// </summary>
	public override string LabelCurrent => "Actuel";

	/// <summary>
	/// Key: "Label.CurrentPublishedVersion"
	/// English String: "Current published version"
	/// </summary>
	public override string LabelCurrentPublishedVersion => "Version actuelle ";

	/// <summary>
	/// Key: "Label.Description"
	/// English String: "Description"
	/// </summary>
	public override string LabelDescription => "Description";

	/// <summary>
	/// Key: "Label.Device"
	/// device term
	/// English String: "Device"
	/// </summary>
	public override string LabelDevice => "Appareil";

	/// <summary>
	/// Key: "Label.EnterItemTag"
	/// Placeholder for input field
	/// English String: "Enter tag here..."
	/// </summary>
	public override string LabelEnterItemTag => "Entrer le tag ici...";

	/// <summary>
	/// Key: "Label.Game"
	/// English String: "Game"
	/// </summary>
	public override string LabelGame => "Jeu";

	/// <summary>
	/// Key: "Label.GamePass"
	/// label
	/// English String: "Game Pass"
	/// </summary>
	public override string LabelGamePass => "Passe de jeu";

	/// <summary>
	/// Key: "Label.General"
	/// English String: "General"
	/// </summary>
	public override string LabelGeneral => "Général";

	/// <summary>
	/// Key: "Label.GoToDetails"
	/// Link to the item details page from the configure page
	/// English String: "Go to Details"
	/// </summary>
	public override string LabelGoToDetails => "Aller vers détails";

	/// <summary>
	/// Key: "Label.ItemActive"
	/// English String: "Item is Active"
	/// </summary>
	public override string LabelItemActive => "L'objet est actif";

	/// <summary>
	/// Key: "Label.ItemForSale"
	/// English String: "Item for Sale"
	/// </summary>
	public override string LabelItemForSale => "Objet à vendre";

	/// <summary>
	/// Key: "Label.LastUpdated"
	/// English String: "Last Updated"
	/// </summary>
	public override string LabelLastUpdated => "Dernière mise à jour";

	/// <summary>
	/// Key: "Label.LearnMore"
	/// English String: "Learn more"
	/// </summary>
	public override string LabelLearnMore => "En savoir plus";

	/// <summary>
	/// Key: "Label.MarketplaceFee"
	/// English String: "Marketplace Fee"
	/// </summary>
	public override string LabelMarketplaceFee => "Frais du marché";

	/// <summary>
	/// Key: "Label.Name"
	/// English String: "Name"
	/// </summary>
	public override string LabelName => "Nom";

	/// <summary>
	/// Key: "Label.OpenForComments"
	/// English String: "Open for Comments"
	/// </summary>
	public override string LabelOpenForComments => "Ouvert aux commentaires";

	/// <summary>
	/// Key: "Label.Preview"
	/// English String: "Preview"
	/// </summary>
	public override string LabelPreview => "Aperçu";

	/// <summary>
	/// Key: "Label.Price"
	/// English String: "Price"
	/// </summary>
	public override string LabelPrice => "Prix";

	/// <summary>
	/// Key: "Label.Profit"
	/// English String: "You Earn"
	/// </summary>
	public override string LabelProfit => "Vous obtenez";

	/// <summary>
	/// Key: "Label.Restore"
	/// English String: "Restore"
	/// </summary>
	public override string LabelRestore => "Restaurer";

	/// <summary>
	/// Key: "Label.RevertVersion"
	/// English String: "Revert to this version"
	/// </summary>
	public override string LabelRevertVersion => "Retourner à cette version";

	/// <summary>
	/// Key: "Label.Sales"
	/// English String: "Sales"
	/// </summary>
	public override string LabelSales => "Ventes";

	/// <summary>
	/// Key: "Label.Save"
	/// English String: "Save"
	/// </summary>
	public override string LabelSave => "Enregistrer";

	/// <summary>
	/// Key: "Label.SelectType"
	/// Placeholder for dropdown in create asset page. Options are image, mesh, hair accessory, etc
	/// English String: "Select a type"
	/// </summary>
	public override string LabelSelectType => "Sélectionne un type";

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
	public override string LabelType => "Type";

	/// <summary>
	/// Key: "Label.Updated"
	/// English String: "Updated"
	/// </summary>
	public override string LabelUpdated => "Mis à jour";

	/// <summary>
	/// Key: "Label.Version"
	/// English String: "Version"
	/// </summary>
	public override string LabelVersion => "Version";

	/// <summary>
	/// Key: "Label.Versions"
	/// English String: "Versions"
	/// </summary>
	public override string LabelVersions => "Versions";

	/// <summary>
	/// Key: "Message.ArchiveError"
	/// English String: "Failed to archive"
	/// </summary>
	public override string MessageArchiveError => "Impossible d'archiver";

	/// <summary>
	/// Key: "Message.ArchiveSuccess"
	/// English String: "Successfully archived"
	/// </summary>
	public override string MessageArchiveSuccess => "Archivage réussi";

	/// <summary>
	/// Key: "Message.DescriptionFieldEmptyError"
	/// English String: "Description cannot be empty"
	/// </summary>
	public override string MessageDescriptionFieldEmptyError => "Ce champ doit être rempli";

	/// <summary>
	/// Key: "Message.DescriptionTooLongError"
	/// error message
	/// English String: "The description is too long."
	/// </summary>
	public override string MessageDescriptionTooLongError => "La description est trop longue.";

	/// <summary>
	/// Key: "Message.FilteringServiceUnavailableError"
	/// error message
	/// English String: "Text filtering service is unavailable at this time."
	/// </summary>
	public override string MessageFilteringServiceUnavailableError => "Le filtre de texte n'est pas disponible pour le moment.";

	/// <summary>
	/// Key: "Message.GamePassConfigDisabledError"
	/// error message
	/// English String: "Game Pass configuration is not enabled yet."
	/// </summary>
	public override string MessageGamePassConfigDisabledError => "La configuration de passe de jeu n'est pas encore activée.";

	/// <summary>
	/// Key: "Message.GamePassNotFoundError"
	/// errormessage
	/// English String: "The Game Pass does not exist."
	/// </summary>
	public override string MessageGamePassNotFoundError => "La passe de jeu n'existe pas.";

	/// <summary>
	/// Key: "Message.IconUpdateFailed"
	/// error message
	/// English String: "Failed to update icon."
	/// </summary>
	public override string MessageIconUpdateFailed => "Impossible de mettre à jour l'icône.";

	/// <summary>
	/// Key: "Message.ImageSavingFailedError"
	/// error message
	/// English String: "Failed to save image. Please try again later."
	/// </summary>
	public override string MessageImageSavingFailedError => "Impossible d'enregistrer l'image, veuillez réessayer plus tard.";

	/// <summary>
	/// Key: "Message.InappropriateTextError"
	/// error message
	/// English String: "The name or description contains inappropriate text."
	/// </summary>
	public override string MessageInappropriateTextError => "Le nom ou la description contient des éléments inappropriés.";

	/// <summary>
	/// Key: "Message.NameFieldEmpty"
	/// English String: "Name cannot be empty"
	/// </summary>
	public override string MessageNameFieldEmpty => "Le nom ne peut pas être vide.";

	/// <summary>
	/// Key: "Message.NameRequiredError"
	/// error message
	/// English String: "The name cannot be empty."
	/// </summary>
	public override string MessageNameRequiredError => "Le nom ne peut pas être vide.";

	/// <summary>
	/// Key: "Message.NoTagsFound"
	/// English String: "No tags found"
	/// </summary>
	public override string MessageNoTagsFound => "Aucun tag trouvé";

	/// <summary>
	/// Key: "Message.RestoreError"
	/// English String: "Failed to restore"
	/// </summary>
	public override string MessageRestoreError => "Échec de la restauration";

	/// <summary>
	/// Key: "Message.RestoreSuccess"
	/// English String: "Successfully restored"
	/// </summary>
	public override string MessageRestoreSuccess => "Restauration réussie";

	/// <summary>
	/// Key: "Message.SaveError"
	/// English String: "Something failed. Please try again later"
	/// </summary>
	public override string MessageSaveError => "Une erreur s'est produite. Veuillez réessayer plus tard.";

	/// <summary>
	/// Key: "Message.TooManyUploads"
	/// error message
	/// English String: "You are uploading too much. Please try again later."
	/// </summary>
	public override string MessageTooManyUploads => "Nombre de téléchargements trop élevé. Veuillez réessayer plus tard.";

	/// <summary>
	/// Key: "Message.UpdatePriceError"
	/// English String: "Failed to update price"
	/// </summary>
	public override string MessageUpdatePriceError => "Impossible de mettre à jour le prix";

	/// <summary>
	/// Key: "Message.UpdatePriceSuccess"
	/// English String: "Successfully updated price"
	/// </summary>
	public override string MessageUpdatePriceSuccess => "Prix mis à jour";

	/// <summary>
	/// Key: "Message.UpdateSuccess"
	/// English String: "Successfully updated"
	/// </summary>
	public override string MessageUpdateSuccess => "Mise à jour réussie";

	public ItemConfigurationResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	/// <summary>
	/// Key: "Description.AcceptableFileFormats"
	/// English String: "* Acceptable file formats: {fileExtensions}"
	/// </summary>
	public override string DescriptionAcceptableFileFormats(string fileExtensions)
	{
		return $"* Formats de fichier acceptés : {fileExtensions}";
	}

	protected override string _GetTemplateForDescriptionAcceptableFileFormats()
	{
		return "* Formats de fichier acceptés : {fileExtensions}";
	}

	/// <summary>
	/// Key: "Description.AcceptableFiles"
	/// English String: "* Acceptable files{lineBreak}Format: {fileExtensions}   |   Size: {fileSizes}"
	/// </summary>
	public override string DescriptionAcceptableFiles(string lineBreak, string fileExtensions, string fileSizes)
	{
		return $"* Formats de fichier{lineBreak}acceptés : {fileExtensions} | Taille : {fileSizes}";
	}

	protected override string _GetTemplateForDescriptionAcceptableFiles()
	{
		return "* Formats de fichier{lineBreak}acceptés : {fileExtensions} | Taille : {fileSizes}";
	}

	protected override string _GetTemplateForDescriptionAllowCopying()
	{
		return "En cochant cette case, tu autorises tous les autres utilisateurs de Roblox à utiliser (de plusieurs façons) le contenu que tu rends disponible. Si tu ne souhaites pas leur accorder ce droit, décoche cette case. Pour plus d'informations à propos du partage de contenu, il faut consulter les Conditions d'utilisation de Roblox.";
	}

	/// <summary>
	/// Key: "Description.AllowCopyingWarning"
	/// English String: "By switching on, you are granting every other user of Roblox the right to use (in various ways) the content you are now sharing. If you do not want to grant this right, please do not check this box. For more information about sharing content, please review the Roblox {linkStart}Terms of Use{linkEnd}."
	/// </summary>
	public override string DescriptionAllowCopyingWarning(string linkStart, string linkEnd)
	{
		return $"En cochant cette case, tu autorises tous les autres utilisateurs de Roblox à utiliser (de plusieurs façons) le contenu que tu rends disponible. Si tu ne souhaites pas leur accorder ce droit, décoche cette case. Pour plus d'informations à propos du partage de contenu, il faut consulter les {linkStart}Conditions d'utilisation de Roblox{linkEnd}.";
	}

	protected override string _GetTemplateForDescriptionAllowCopyingWarning()
	{
		return "En cochant cette case, tu autorises tous les autres utilisateurs de Roblox à utiliser (de plusieurs façons) le contenu que tu rends disponible. Si tu ne souhaites pas leur accorder ce droit, décoche cette case. Pour plus d'informations à propos du partage de contenu, il faut consulter les {linkStart}Conditions d'utilisation de Roblox{linkEnd}.";
	}

	protected override string _GetTemplateForDescriptionArchiveWarning()
	{
		return "L'archivage de cet élément empêchera son utilisation en jeu. Les ressources archivées peuvent être restaurées.";
	}

	protected override string _GetTemplateForDescriptionClickToAddTag()
	{
		return "Clique pour ajouter un tag";
	}

	/// <summary>
	/// Key: "Description.MarketplaceExplanation"
	/// English String: "(Roblox takes {marketplaceFeePercentage}%, minimum {minimumPrice})"
	/// </summary>
	public override string DescriptionMarketplaceExplanation(string marketplaceFeePercentage, string minimumPrice)
	{
		return $"(Roblox prélève {marketplaceFeePercentage} %, frais minimum de {minimumPrice})";
	}

	protected override string _GetTemplateForDescriptionMarketplaceExplanation()
	{
		return "(Roblox prélève {marketplaceFeePercentage} %, frais minimum de {minimumPrice})";
	}

	protected override string _GetTemplateForDescriptionModeratorFileReview()
	{
		return "* Le fichier téléchargé sera examiné par les modérateurs avant d'être visible par les autres joueurs.";
	}

	protected override string _GetTemplateForDescriptionModeratorReview()
	{
		return "* L'image téléchargée sera examinée par les modérateurs avant d'être visible par les autres joueurs.";
	}

	/// <summary>
	/// Key: "Description.SelectItemTags"
	/// itemTagLimit is the number of item tags allowed
	/// English String: "Select up to {itemTagLimit} tags."
	/// </summary>
	public override string DescriptionSelectItemTags(string itemTagLimit)
	{
		return $"Sélectionne jusqu'à {itemTagLimit} tags.";
	}

	protected override string _GetTemplateForDescriptionSelectItemTags()
	{
		return "Sélectionne jusqu'à {itemTagLimit} tags.";
	}

	public override string DescriptionVerifiedCreatorEmail(string linkStart, string linkEnd)
	{
		return $"Pour partager du contenu sur Marketplace, tu dois ajouter une adresse e-mail sur ton compte et la vérifier. Rends-toi dans les {linkStart}Paramètres de compte{linkEnd}.";
	}

	protected override string _GetTemplateForDescriptionVerifiedCreatorEmail()
	{
		return "Pour partager du contenu sur Marketplace, tu dois ajouter une adresse e-mail sur ton compte et la vérifier. Rends-toi dans les {linkStart}Paramètres de compte{linkEnd}.";
	}

	protected override string _GetTemplateForHeadingArchive()
	{
		return "Archiver";
	}

	protected override string _GetTemplateForHeadingConfigure()
	{
		return "Configurer";
	}

	/// <summary>
	/// Key: "Heading.ConfigureItem"
	/// English String: "Configure {itemType}"
	/// </summary>
	public override string HeadingConfigureItem(string itemType)
	{
		return $"Configurer {itemType}";
	}

	protected override string _GetTemplateForHeadingConfigureItem()
	{
		return "Configurer {itemType}";
	}

	protected override string _GetTemplateForHeadingConfigureItemTags()
	{
		return "Configuration des tags";
	}

	protected override string _GetTemplateForHeadingCreate()
	{
		return "Créer";
	}

	protected override string _GetTemplateForHeadingSettings()
	{
		return "Réglages";
	}

	protected override string _GetTemplateForLabelAllowCopying()
	{
		return "Autoriser la copie";
	}

	protected override string _GetTemplateForLabelArchive()
	{
		return "Archiver";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "Annuler";
	}

	protected override string _GetTemplateForLabelComputer()
	{
		return "Ordinateur";
	}

	protected override string _GetTemplateForLabelCreated()
	{
		return "Créé";
	}

	protected override string _GetTemplateForLabelCurrent()
	{
		return "Actuel";
	}

	protected override string _GetTemplateForLabelCurrentPublishedVersion()
	{
		return "Version actuelle ";
	}

	protected override string _GetTemplateForLabelDescription()
	{
		return "Description";
	}

	protected override string _GetTemplateForLabelDevice()
	{
		return "Appareil";
	}

	protected override string _GetTemplateForLabelEnterItemTag()
	{
		return "Entrer le tag ici...";
	}

	/// <summary>
	/// Key: "Label.ForItem"
	/// English String: "For {itemType}"
	/// </summary>
	public override string LabelForItem(string itemType)
	{
		return $"Pour {itemType}";
	}

	protected override string _GetTemplateForLabelForItem()
	{
		return "Pour {itemType}";
	}

	protected override string _GetTemplateForLabelGame()
	{
		return "Jeu";
	}

	protected override string _GetTemplateForLabelGamePass()
	{
		return "Passe de jeu";
	}

	protected override string _GetTemplateForLabelGeneral()
	{
		return "Général";
	}

	protected override string _GetTemplateForLabelGoToDetails()
	{
		return "Aller vers détails";
	}

	protected override string _GetTemplateForLabelItemActive()
	{
		return "L'objet est actif";
	}

	protected override string _GetTemplateForLabelItemForSale()
	{
		return "Objet à vendre";
	}

	protected override string _GetTemplateForLabelLastUpdated()
	{
		return "Dernière mise à jour";
	}

	protected override string _GetTemplateForLabelLearnMore()
	{
		return "En savoir plus";
	}

	protected override string _GetTemplateForLabelMarketplaceFee()
	{
		return "Frais du marché";
	}

	protected override string _GetTemplateForLabelName()
	{
		return "Nom";
	}

	protected override string _GetTemplateForLabelOpenForComments()
	{
		return "Ouvert aux commentaires";
	}

	protected override string _GetTemplateForLabelPreview()
	{
		return "Aperçu";
	}

	protected override string _GetTemplateForLabelPrice()
	{
		return "Prix";
	}

	protected override string _GetTemplateForLabelProfit()
	{
		return "Vous obtenez";
	}

	protected override string _GetTemplateForLabelRestore()
	{
		return "Restaurer";
	}

	protected override string _GetTemplateForLabelRevertVersion()
	{
		return "Retourner à cette version";
	}

	protected override string _GetTemplateForLabelSales()
	{
		return "Ventes";
	}

	protected override string _GetTemplateForLabelSave()
	{
		return "Enregistrer";
	}

	protected override string _GetTemplateForLabelSelectType()
	{
		return "Sélectionne un type";
	}

	protected override string _GetTemplateForLabelTags()
	{
		return "Tags";
	}

	protected override string _GetTemplateForLabelType()
	{
		return "Type";
	}

	protected override string _GetTemplateForLabelUpdated()
	{
		return "Mis à jour";
	}

	protected override string _GetTemplateForLabelVersion()
	{
		return "Version";
	}

	protected override string _GetTemplateForLabelVersions()
	{
		return "Versions";
	}

	protected override string _GetTemplateForMessageArchiveError()
	{
		return "Impossible d'archiver";
	}

	protected override string _GetTemplateForMessageArchiveSuccess()
	{
		return "Archivage réussi";
	}

	/// <summary>
	/// Key: "Message.DescriptionFieldEmpty"
	/// English String: "{maxDescriptionLength} character limit"
	/// </summary>
	public override string MessageDescriptionFieldEmpty(string maxDescriptionLength)
	{
		return $"{maxDescriptionLength}\u00a0caractères maximum";
	}

	protected override string _GetTemplateForMessageDescriptionFieldEmpty()
	{
		return "{maxDescriptionLength}\u00a0caractères maximum";
	}

	protected override string _GetTemplateForMessageDescriptionFieldEmptyError()
	{
		return "Ce champ doit être rempli";
	}

	/// <summary>
	/// Key: "Message.DescriptionFieldPopulated"
	/// English String: "{descriptionLength}/{maxDescriptionLength} characters"
	/// </summary>
	public override string MessageDescriptionFieldPopulated(string descriptionLength, string maxDescriptionLength)
	{
		return $"{descriptionLength}/{maxDescriptionLength}\u00a0caractères";
	}

	protected override string _GetTemplateForMessageDescriptionFieldPopulated()
	{
		return "{descriptionLength}/{maxDescriptionLength}\u00a0caractères";
	}

	protected override string _GetTemplateForMessageDescriptionTooLongError()
	{
		return "La description est trop longue.";
	}

	protected override string _GetTemplateForMessageFilteringServiceUnavailableError()
	{
		return "Le filtre de texte n'est pas disponible pour le moment.";
	}

	protected override string _GetTemplateForMessageGamePassConfigDisabledError()
	{
		return "La configuration de passe de jeu n'est pas encore activée.";
	}

	protected override string _GetTemplateForMessageGamePassNotFoundError()
	{
		return "La passe de jeu n'existe pas.";
	}

	protected override string _GetTemplateForMessageIconUpdateFailed()
	{
		return "Impossible de mettre à jour l'icône.";
	}

	protected override string _GetTemplateForMessageImageSavingFailedError()
	{
		return "Impossible d'enregistrer l'image, veuillez réessayer plus tard.";
	}

	protected override string _GetTemplateForMessageInappropriateTextError()
	{
		return "Le nom ou la description contient des éléments inappropriés.";
	}

	/// <summary>
	/// Key: "Message.MinimumPrice"
	/// English String: "You cannot set a price below the minimum price of {minimumPrice}"
	/// </summary>
	public override string MessageMinimumPrice(string minimumPrice)
	{
		return $"Le prix ne peut pas être inférieur à {minimumPrice}.";
	}

	protected override string _GetTemplateForMessageMinimumPrice()
	{
		return "Le prix ne peut pas être inférieur à {minimumPrice}.";
	}

	protected override string _GetTemplateForMessageNameFieldEmpty()
	{
		return "Le nom ne peut pas être vide.";
	}

	/// <summary>
	/// Key: "Message.NameFieldPopulated"
	/// English String: "{nameLength}/{maxNameLength} characters"
	/// </summary>
	public override string MessageNameFieldPopulated(string nameLength, string maxNameLength)
	{
		return $"{nameLength}/{maxNameLength}\u00a0caractères";
	}

	protected override string _GetTemplateForMessageNameFieldPopulated()
	{
		return "{nameLength}/{maxNameLength}\u00a0caractères";
	}

	protected override string _GetTemplateForMessageNameRequiredError()
	{
		return "Le nom ne peut pas être vide.";
	}

	protected override string _GetTemplateForMessageNoTagsFound()
	{
		return "Aucun tag trouvé";
	}

	protected override string _GetTemplateForMessageRestoreError()
	{
		return "Échec de la restauration";
	}

	protected override string _GetTemplateForMessageRestoreSuccess()
	{
		return "Restauration réussie";
	}

	/// <summary>
	/// Key: "Message.RevertSuccess"
	/// English String: "Successfully reverted to version {versionNumber}"
	/// </summary>
	public override string MessageRevertSuccess(string versionNumber)
	{
		return $"Retour à la version {versionNumber}";
	}

	protected override string _GetTemplateForMessageRevertSuccess()
	{
		return "Retour à la version {versionNumber}";
	}

	protected override string _GetTemplateForMessageSaveError()
	{
		return "Une erreur s'est produite. Veuillez réessayer plus tard.";
	}

	protected override string _GetTemplateForMessageTooManyUploads()
	{
		return "Nombre de téléchargements trop élevé. Veuillez réessayer plus tard.";
	}

	protected override string _GetTemplateForMessageUpdatePriceError()
	{
		return "Impossible de mettre à jour le prix";
	}

	protected override string _GetTemplateForMessageUpdatePriceSuccess()
	{
		return "Prix mis à jour";
	}

	protected override string _GetTemplateForMessageUpdateSuccess()
	{
		return "Mise à jour réussie";
	}
}
