namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides ItemConfigurationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ItemConfigurationResources_es_es : ItemConfigurationResources_en_us, IItemConfigurationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Description.AllowCopying"
	/// English String: "By switching on, you are granting every other user of Roblox the right to use (in various ways) the content you are now sharing. If you do not want to grant this right, please do not check this box. For more information about sharing content, please review the Roblox Terms of Use."
	/// </summary>
	public override string DescriptionAllowCopying => "Al activar esta casilla, otorgarás a todos los usuarios de Roblox el derecho a utilizar (de varias maneras) el contenido que compartes. Si no quieres otorgarlo, no la actives. Para obtener más información sobre cómo se comparte el contenido, revisa los Términos de uso de Roblox.";

	/// <summary>
	/// Key: "Description.ArchiveWarning"
	/// English String: "Archiving this asset will prevent it from being used in game. Archived assets can be restored."
	/// </summary>
	public override string DescriptionArchiveWarning => "Si archivas este recurso, no lo podrás usar en el juego. Los recursos archivados se pueden restaurar.";

	/// <summary>
	/// Key: "Description.ClickToAddTag"
	/// Hover text on the button that adds a tag to an item
	/// English String: "Click to add tag"
	/// </summary>
	public override string DescriptionClickToAddTag => "Haz clic para añadir una etiqueta";

	/// <summary>
	/// Key: "Description.ModeratorFileReview"
	/// English String: "* Uploaded file will be reviewed by moderators before being made visible to other users"
	/// </summary>
	public override string DescriptionModeratorFileReview => "* El archivo subido será revisado por los moderadores antes de que sea visible para otros usuarios";

	/// <summary>
	/// Key: "Description.ModeratorReview"
	/// English String: "* Uploaded image will be reviewed by moderators before being made visible to other users"
	/// </summary>
	public override string DescriptionModeratorReview => "* La imagen subida será revisada por los moderadores antes de que sea visible para otros usuarios";

	/// <summary>
	/// Key: "Heading.Archive"
	/// header text for section about archiving assets
	/// English String: "Archive"
	/// </summary>
	public override string HeadingArchive => "Archivar";

	/// <summary>
	/// Key: "Heading.Configure"
	/// English String: "Configure"
	/// </summary>
	public override string HeadingConfigure => "Configurar";

	/// <summary>
	/// Key: "Heading.ConfigureItemTags"
	/// Heading on Configure Tags modal
	/// English String: "Configure Tags"
	/// </summary>
	public override string HeadingConfigureItemTags => "Configurar etiquetas";

	/// <summary>
	/// Key: "Heading.Create"
	/// English String: "Create"
	/// </summary>
	public override string HeadingCreate => "Crear";

	/// <summary>
	/// Key: "Heading.Settings"
	/// English String: "Settings"
	/// </summary>
	public override string HeadingSettings => "Configuración";

	/// <summary>
	/// Key: "Label.AllowCopying"
	/// English String: "Allow Copying"
	/// </summary>
	public override string LabelAllowCopying => "Permitir hacer una copia";

	/// <summary>
	/// Key: "Label.Archive"
	/// Text on button for archiving an asset. Part of speech: verb
	/// English String: "Archive"
	/// </summary>
	public override string LabelArchive => "Archivar";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "Cancelar";

	/// <summary>
	/// Key: "Label.Computer"
	/// computer term
	/// English String: "Computer"
	/// </summary>
	public override string LabelComputer => "Ordenador";

	/// <summary>
	/// Key: "Label.Created"
	/// English String: "Created"
	/// </summary>
	public override string LabelCreated => "Creado";

	/// <summary>
	/// Key: "Label.Current"
	/// English String: "Current"
	/// </summary>
	public override string LabelCurrent => "Actual";

	/// <summary>
	/// Key: "Label.CurrentPublishedVersion"
	/// English String: "Current published version"
	/// </summary>
	public override string LabelCurrentPublishedVersion => "Versión actual publicada";

	/// <summary>
	/// Key: "Label.Description"
	/// English String: "Description"
	/// </summary>
	public override string LabelDescription => "Descripción";

	/// <summary>
	/// Key: "Label.Device"
	/// device term
	/// English String: "Device"
	/// </summary>
	public override string LabelDevice => "Dispositivo";

	/// <summary>
	/// Key: "Label.EnterItemTag"
	/// Placeholder for input field
	/// English String: "Enter tag here..."
	/// </summary>
	public override string LabelEnterItemTag => "Introduce una etiqueta aquí...";

	/// <summary>
	/// Key: "Label.Game"
	/// English String: "Game"
	/// </summary>
	public override string LabelGame => "Juego";

	/// <summary>
	/// Key: "Label.GamePass"
	/// label
	/// English String: "Game Pass"
	/// </summary>
	public override string LabelGamePass => "Pase del juego";

	/// <summary>
	/// Key: "Label.General"
	/// English String: "General"
	/// </summary>
	public override string LabelGeneral => "General";

	/// <summary>
	/// Key: "Label.GoToDetails"
	/// Link to the item details page from the configure page
	/// English String: "Go to Details"
	/// </summary>
	public override string LabelGoToDetails => "Ir a Detalles";

	/// <summary>
	/// Key: "Label.ItemActive"
	/// English String: "Item is Active"
	/// </summary>
	public override string LabelItemActive => "El objeto es activo.";

	/// <summary>
	/// Key: "Label.ItemForSale"
	/// English String: "Item for Sale"
	/// </summary>
	public override string LabelItemForSale => "Objeto a la venta";

	/// <summary>
	/// Key: "Label.LastUpdated"
	/// English String: "Last Updated"
	/// </summary>
	public override string LabelLastUpdated => "Última actualización";

	/// <summary>
	/// Key: "Label.LearnMore"
	/// English String: "Learn more"
	/// </summary>
	public override string LabelLearnMore => "Más información";

	/// <summary>
	/// Key: "Label.MarketplaceFee"
	/// English String: "Marketplace Fee"
	/// </summary>
	public override string LabelMarketplaceFee => "Cuota de mercado";

	/// <summary>
	/// Key: "Label.Name"
	/// English String: "Name"
	/// </summary>
	public override string LabelName => "Nombre";

	/// <summary>
	/// Key: "Label.OpenForComments"
	/// English String: "Open for Comments"
	/// </summary>
	public override string LabelOpenForComments => "Abierto a comentarios";

	/// <summary>
	/// Key: "Label.Preview"
	/// English String: "Preview"
	/// </summary>
	public override string LabelPreview => "Vista previa";

	/// <summary>
	/// Key: "Label.Price"
	/// English String: "Price"
	/// </summary>
	public override string LabelPrice => "Precio";

	/// <summary>
	/// Key: "Label.Profit"
	/// English String: "You Earn"
	/// </summary>
	public override string LabelProfit => "Tú ganas";

	/// <summary>
	/// Key: "Label.Restore"
	/// English String: "Restore"
	/// </summary>
	public override string LabelRestore => "Restaurar";

	/// <summary>
	/// Key: "Label.RevertVersion"
	/// English String: "Revert to this version"
	/// </summary>
	public override string LabelRevertVersion => "Volver a esta versión";

	/// <summary>
	/// Key: "Label.Sales"
	/// English String: "Sales"
	/// </summary>
	public override string LabelSales => "Ventas";

	/// <summary>
	/// Key: "Label.Save"
	/// English String: "Save"
	/// </summary>
	public override string LabelSave => "Guardar";

	/// <summary>
	/// Key: "Label.SelectType"
	/// Placeholder for dropdown in create asset page. Options are image, mesh, hair accessory, etc
	/// English String: "Select a type"
	/// </summary>
	public override string LabelSelectType => "Seleccionar un tipo";

	/// <summary>
	/// Key: "Label.Tags"
	/// The label next to a list of item tags in the item configuration page
	/// English String: "Tags"
	/// </summary>
	public override string LabelTags => "Etiquetas";

	/// <summary>
	/// Key: "Label.Type"
	/// English String: "Type"
	/// </summary>
	public override string LabelType => "Tipo";

	/// <summary>
	/// Key: "Label.Updated"
	/// English String: "Updated"
	/// </summary>
	public override string LabelUpdated => "Actualizado";

	/// <summary>
	/// Key: "Label.Version"
	/// English String: "Version"
	/// </summary>
	public override string LabelVersion => "Versión";

	/// <summary>
	/// Key: "Label.Versions"
	/// English String: "Versions"
	/// </summary>
	public override string LabelVersions => "Versiones";

	/// <summary>
	/// Key: "Message.ArchiveError"
	/// English String: "Failed to archive"
	/// </summary>
	public override string MessageArchiveError => "Error al archivar";

	/// <summary>
	/// Key: "Message.ArchiveSuccess"
	/// English String: "Successfully archived"
	/// </summary>
	public override string MessageArchiveSuccess => "Archivado correctamente";

	/// <summary>
	/// Key: "Message.DescriptionFieldEmptyError"
	/// English String: "Description cannot be empty"
	/// </summary>
	public override string MessageDescriptionFieldEmptyError => "La descripción no puede estar vacía.";

	/// <summary>
	/// Key: "Message.DescriptionTooLongError"
	/// error message
	/// English String: "The description is too long."
	/// </summary>
	public override string MessageDescriptionTooLongError => "La descripción es demasiado larga.";

	/// <summary>
	/// Key: "Message.FilteringServiceUnavailableError"
	/// error message
	/// English String: "Text filtering service is unavailable at this time."
	/// </summary>
	public override string MessageFilteringServiceUnavailableError => "El servicio de filtrado de texto no está disponible en este momento.";

	/// <summary>
	/// Key: "Message.GamePassConfigDisabledError"
	/// error message
	/// English String: "Game Pass configuration is not enabled yet."
	/// </summary>
	public override string MessageGamePassConfigDisabledError => "La configuración del pase del juego no está activada todavía.";

	/// <summary>
	/// Key: "Message.GamePassNotFoundError"
	/// errormessage
	/// English String: "The Game Pass does not exist."
	/// </summary>
	public override string MessageGamePassNotFoundError => "El pase del juego no existe.";

	/// <summary>
	/// Key: "Message.IconUpdateFailed"
	/// error message
	/// English String: "Failed to update icon."
	/// </summary>
	public override string MessageIconUpdateFailed => "Error al actualizar el icono";

	/// <summary>
	/// Key: "Message.ImageSavingFailedError"
	/// error message
	/// English String: "Failed to save image. Please try again later."
	/// </summary>
	public override string MessageImageSavingFailedError => "Error al guardar la imagen. Inténtalo de nuevo más tarde.";

	/// <summary>
	/// Key: "Message.InappropriateTextError"
	/// error message
	/// English String: "The name or description contains inappropriate text."
	/// </summary>
	public override string MessageInappropriateTextError => "El nombre o la descripción contienen texto inadecuado.";

	/// <summary>
	/// Key: "Message.NameFieldEmpty"
	/// English String: "Name cannot be empty"
	/// </summary>
	public override string MessageNameFieldEmpty => "El nombre no puede estar vacío.";

	/// <summary>
	/// Key: "Message.NameRequiredError"
	/// error message
	/// English String: "The name cannot be empty."
	/// </summary>
	public override string MessageNameRequiredError => "El nombre no puede estar vacío.";

	/// <summary>
	/// Key: "Message.NoTagsFound"
	/// English String: "No tags found"
	/// </summary>
	public override string MessageNoTagsFound => "Etiquetas no encontradas";

	/// <summary>
	/// Key: "Message.RestoreError"
	/// English String: "Failed to restore"
	/// </summary>
	public override string MessageRestoreError => "Error al restaurar";

	/// <summary>
	/// Key: "Message.RestoreSuccess"
	/// English String: "Successfully restored"
	/// </summary>
	public override string MessageRestoreSuccess => "Restaurado correctamente";

	/// <summary>
	/// Key: "Message.SaveError"
	/// English String: "Something failed. Please try again later"
	/// </summary>
	public override string MessageSaveError => "Algo ha ido mal. Inténtalo de nuevo más tarde.";

	/// <summary>
	/// Key: "Message.TooManyUploads"
	/// error message
	/// English String: "You are uploading too much. Please try again later."
	/// </summary>
	public override string MessageTooManyUploads => "Estás subiendo demasiados archivos. Inténtalo de nuevo más tarde.";

	/// <summary>
	/// Key: "Message.UpdatePriceError"
	/// English String: "Failed to update price"
	/// </summary>
	public override string MessageUpdatePriceError => "Error al actualizar el precio";

	/// <summary>
	/// Key: "Message.UpdatePriceSuccess"
	/// English String: "Successfully updated price"
	/// </summary>
	public override string MessageUpdatePriceSuccess => "Precio actualizado correctamente";

	/// <summary>
	/// Key: "Message.UpdateSuccess"
	/// English String: "Successfully updated"
	/// </summary>
	public override string MessageUpdateSuccess => "Actualizado correctamente";

	public ItemConfigurationResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	/// <summary>
	/// Key: "Description.AcceptableFileFormats"
	/// English String: "* Acceptable file formats: {fileExtensions}"
	/// </summary>
	public override string DescriptionAcceptableFileFormats(string fileExtensions)
	{
		return $"* Formatos de archivos aceptables: {fileExtensions}";
	}

	protected override string _GetTemplateForDescriptionAcceptableFileFormats()
	{
		return "* Formatos de archivos aceptables: {fileExtensions}";
	}

	/// <summary>
	/// Key: "Description.AcceptableFiles"
	/// English String: "* Acceptable files{lineBreak}Format: {fileExtensions}   |   Size: {fileSizes}"
	/// </summary>
	public override string DescriptionAcceptableFiles(string lineBreak, string fileExtensions, string fileSizes)
	{
		return $"* Archivos aceptados{lineBreak}Formato: {fileExtensions}   |   Tamaño: {fileSizes}";
	}

	protected override string _GetTemplateForDescriptionAcceptableFiles()
	{
		return "* Archivos aceptados{lineBreak}Formato: {fileExtensions}   |   Tamaño: {fileSizes}";
	}

	protected override string _GetTemplateForDescriptionAllowCopying()
	{
		return "Al activar esta casilla, otorgarás a todos los usuarios de Roblox el derecho a utilizar (de varias maneras) el contenido que compartes. Si no quieres otorgarlo, no la actives. Para obtener más información sobre cómo se comparte el contenido, revisa los Términos de uso de Roblox.";
	}

	/// <summary>
	/// Key: "Description.AllowCopyingWarning"
	/// English String: "By switching on, you are granting every other user of Roblox the right to use (in various ways) the content you are now sharing. If you do not want to grant this right, please do not check this box. For more information about sharing content, please review the Roblox {linkStart}Terms of Use{linkEnd}."
	/// </summary>
	public override string DescriptionAllowCopyingWarning(string linkStart, string linkEnd)
	{
		return $"Al activar esta casilla, otorgarás a todos los usuarios de Roblox el derecho a utilizar (de varias maneras) el contenido que compartes. Si no quieres otorgarlo, no la actives. Para obtener más información sobre cómo se comparte el contenido, revisa los {linkStart}Términos de uso{linkEnd} de Roblox.";
	}

	protected override string _GetTemplateForDescriptionAllowCopyingWarning()
	{
		return "Al activar esta casilla, otorgarás a todos los usuarios de Roblox el derecho a utilizar (de varias maneras) el contenido que compartes. Si no quieres otorgarlo, no la actives. Para obtener más información sobre cómo se comparte el contenido, revisa los {linkStart}Términos de uso{linkEnd} de Roblox.";
	}

	protected override string _GetTemplateForDescriptionArchiveWarning()
	{
		return "Si archivas este recurso, no lo podrás usar en el juego. Los recursos archivados se pueden restaurar.";
	}

	protected override string _GetTemplateForDescriptionClickToAddTag()
	{
		return "Haz clic para añadir una etiqueta";
	}

	/// <summary>
	/// Key: "Description.MarketplaceExplanation"
	/// English String: "(Roblox takes {marketplaceFeePercentage}%, minimum {minimumPrice})"
	/// </summary>
	public override string DescriptionMarketplaceExplanation(string marketplaceFeePercentage, string minimumPrice)
	{
		return $"(Roblox recibe el {marketplaceFeePercentage} %, {minimumPrice} mínimo)";
	}

	protected override string _GetTemplateForDescriptionMarketplaceExplanation()
	{
		return "(Roblox recibe el {marketplaceFeePercentage} %, {minimumPrice} mínimo)";
	}

	protected override string _GetTemplateForDescriptionModeratorFileReview()
	{
		return "* El archivo subido será revisado por los moderadores antes de que sea visible para otros usuarios";
	}

	protected override string _GetTemplateForDescriptionModeratorReview()
	{
		return "* La imagen subida será revisada por los moderadores antes de que sea visible para otros usuarios";
	}

	/// <summary>
	/// Key: "Description.SelectItemTags"
	/// itemTagLimit is the number of item tags allowed
	/// English String: "Select up to {itemTagLimit} tags."
	/// </summary>
	public override string DescriptionSelectItemTags(string itemTagLimit)
	{
		return $"Selecciona hasta {itemTagLimit} etiquetas.";
	}

	protected override string _GetTemplateForDescriptionSelectItemTags()
	{
		return "Selecciona hasta {itemTagLimit} etiquetas.";
	}

	public override string DescriptionVerifiedCreatorEmail(string linkStart, string linkEnd)
	{
		return $"Para compartir el contenido en el Mercado, debes añadir un correo electrónico y verificarlo en tu cuenta. Esto se puede hacer en {linkStart}Configuración de la cuenta{linkEnd}.";
	}

	protected override string _GetTemplateForDescriptionVerifiedCreatorEmail()
	{
		return "Para compartir el contenido en el Mercado, debes añadir un correo electrónico y verificarlo en tu cuenta. Esto se puede hacer en {linkStart}Configuración de la cuenta{linkEnd}.";
	}

	protected override string _GetTemplateForHeadingArchive()
	{
		return "Archivar";
	}

	protected override string _GetTemplateForHeadingConfigure()
	{
		return "Configurar";
	}

	/// <summary>
	/// Key: "Heading.ConfigureItem"
	/// English String: "Configure {itemType}"
	/// </summary>
	public override string HeadingConfigureItem(string itemType)
	{
		return $"Configurar {itemType}";
	}

	protected override string _GetTemplateForHeadingConfigureItem()
	{
		return "Configurar {itemType}";
	}

	protected override string _GetTemplateForHeadingConfigureItemTags()
	{
		return "Configurar etiquetas";
	}

	protected override string _GetTemplateForHeadingCreate()
	{
		return "Crear";
	}

	protected override string _GetTemplateForHeadingSettings()
	{
		return "Configuración";
	}

	protected override string _GetTemplateForLabelAllowCopying()
	{
		return "Permitir hacer una copia";
	}

	protected override string _GetTemplateForLabelArchive()
	{
		return "Archivar";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "Cancelar";
	}

	protected override string _GetTemplateForLabelComputer()
	{
		return "Ordenador";
	}

	protected override string _GetTemplateForLabelCreated()
	{
		return "Creado";
	}

	protected override string _GetTemplateForLabelCurrent()
	{
		return "Actual";
	}

	protected override string _GetTemplateForLabelCurrentPublishedVersion()
	{
		return "Versión actual publicada";
	}

	protected override string _GetTemplateForLabelDescription()
	{
		return "Descripción";
	}

	protected override string _GetTemplateForLabelDevice()
	{
		return "Dispositivo";
	}

	protected override string _GetTemplateForLabelEnterItemTag()
	{
		return "Introduce una etiqueta aquí...";
	}

	/// <summary>
	/// Key: "Label.ForItem"
	/// English String: "For {itemType}"
	/// </summary>
	public override string LabelForItem(string itemType)
	{
		return $"Por {itemType}";
	}

	protected override string _GetTemplateForLabelForItem()
	{
		return "Por {itemType}";
	}

	protected override string _GetTemplateForLabelGame()
	{
		return "Juego";
	}

	protected override string _GetTemplateForLabelGamePass()
	{
		return "Pase del juego";
	}

	protected override string _GetTemplateForLabelGeneral()
	{
		return "General";
	}

	protected override string _GetTemplateForLabelGoToDetails()
	{
		return "Ir a Detalles";
	}

	protected override string _GetTemplateForLabelItemActive()
	{
		return "El objeto es activo.";
	}

	protected override string _GetTemplateForLabelItemForSale()
	{
		return "Objeto a la venta";
	}

	protected override string _GetTemplateForLabelLastUpdated()
	{
		return "Última actualización";
	}

	protected override string _GetTemplateForLabelLearnMore()
	{
		return "Más información";
	}

	protected override string _GetTemplateForLabelMarketplaceFee()
	{
		return "Cuota de mercado";
	}

	protected override string _GetTemplateForLabelName()
	{
		return "Nombre";
	}

	protected override string _GetTemplateForLabelOpenForComments()
	{
		return "Abierto a comentarios";
	}

	protected override string _GetTemplateForLabelPreview()
	{
		return "Vista previa";
	}

	protected override string _GetTemplateForLabelPrice()
	{
		return "Precio";
	}

	protected override string _GetTemplateForLabelProfit()
	{
		return "Tú ganas";
	}

	protected override string _GetTemplateForLabelRestore()
	{
		return "Restaurar";
	}

	protected override string _GetTemplateForLabelRevertVersion()
	{
		return "Volver a esta versión";
	}

	protected override string _GetTemplateForLabelSales()
	{
		return "Ventas";
	}

	protected override string _GetTemplateForLabelSave()
	{
		return "Guardar";
	}

	protected override string _GetTemplateForLabelSelectType()
	{
		return "Seleccionar un tipo";
	}

	protected override string _GetTemplateForLabelTags()
	{
		return "Etiquetas";
	}

	protected override string _GetTemplateForLabelType()
	{
		return "Tipo";
	}

	protected override string _GetTemplateForLabelUpdated()
	{
		return "Actualizado";
	}

	protected override string _GetTemplateForLabelVersion()
	{
		return "Versión";
	}

	protected override string _GetTemplateForLabelVersions()
	{
		return "Versiones";
	}

	protected override string _GetTemplateForMessageArchiveError()
	{
		return "Error al archivar";
	}

	protected override string _GetTemplateForMessageArchiveSuccess()
	{
		return "Archivado correctamente";
	}

	/// <summary>
	/// Key: "Message.DescriptionFieldEmpty"
	/// English String: "{maxDescriptionLength} character limit"
	/// </summary>
	public override string MessageDescriptionFieldEmpty(string maxDescriptionLength)
	{
		return $"Número límite de caracteres {maxDescriptionLength}";
	}

	protected override string _GetTemplateForMessageDescriptionFieldEmpty()
	{
		return "Número límite de caracteres {maxDescriptionLength}";
	}

	protected override string _GetTemplateForMessageDescriptionFieldEmptyError()
	{
		return "La descripción no puede estar vacía.";
	}

	/// <summary>
	/// Key: "Message.DescriptionFieldPopulated"
	/// English String: "{descriptionLength}/{maxDescriptionLength} characters"
	/// </summary>
	public override string MessageDescriptionFieldPopulated(string descriptionLength, string maxDescriptionLength)
	{
		return $"{descriptionLength}/{maxDescriptionLength} caracteres";
	}

	protected override string _GetTemplateForMessageDescriptionFieldPopulated()
	{
		return "{descriptionLength}/{maxDescriptionLength} caracteres";
	}

	protected override string _GetTemplateForMessageDescriptionTooLongError()
	{
		return "La descripción es demasiado larga.";
	}

	protected override string _GetTemplateForMessageFilteringServiceUnavailableError()
	{
		return "El servicio de filtrado de texto no está disponible en este momento.";
	}

	protected override string _GetTemplateForMessageGamePassConfigDisabledError()
	{
		return "La configuración del pase del juego no está activada todavía.";
	}

	protected override string _GetTemplateForMessageGamePassNotFoundError()
	{
		return "El pase del juego no existe.";
	}

	protected override string _GetTemplateForMessageIconUpdateFailed()
	{
		return "Error al actualizar el icono";
	}

	protected override string _GetTemplateForMessageImageSavingFailedError()
	{
		return "Error al guardar la imagen. Inténtalo de nuevo más tarde.";
	}

	protected override string _GetTemplateForMessageInappropriateTextError()
	{
		return "El nombre o la descripción contienen texto inadecuado.";
	}

	/// <summary>
	/// Key: "Message.MinimumPrice"
	/// English String: "You cannot set a price below the minimum price of {minimumPrice}"
	/// </summary>
	public override string MessageMinimumPrice(string minimumPrice)
	{
		return $"No puedes fijar un precio inferior a {minimumPrice}";
	}

	protected override string _GetTemplateForMessageMinimumPrice()
	{
		return "No puedes fijar un precio inferior a {minimumPrice}";
	}

	protected override string _GetTemplateForMessageNameFieldEmpty()
	{
		return "El nombre no puede estar vacío.";
	}

	/// <summary>
	/// Key: "Message.NameFieldPopulated"
	/// English String: "{nameLength}/{maxNameLength} characters"
	/// </summary>
	public override string MessageNameFieldPopulated(string nameLength, string maxNameLength)
	{
		return $"{nameLength}/{maxNameLength} caracteres";
	}

	protected override string _GetTemplateForMessageNameFieldPopulated()
	{
		return "{nameLength}/{maxNameLength} caracteres";
	}

	protected override string _GetTemplateForMessageNameRequiredError()
	{
		return "El nombre no puede estar vacío.";
	}

	protected override string _GetTemplateForMessageNoTagsFound()
	{
		return "Etiquetas no encontradas";
	}

	protected override string _GetTemplateForMessageRestoreError()
	{
		return "Error al restaurar";
	}

	protected override string _GetTemplateForMessageRestoreSuccess()
	{
		return "Restaurado correctamente";
	}

	/// <summary>
	/// Key: "Message.RevertError"
	/// English String: "Failed to revert to version {versionNumber}"
	/// </summary>
	public override string MessageRevertError(string versionNumber)
	{
		return $"Error al volver a la versión {versionNumber}";
	}

	protected override string _GetTemplateForMessageRevertError()
	{
		return "Error al volver a la versión {versionNumber}";
	}

	/// <summary>
	/// Key: "Message.RevertSuccess"
	/// English String: "Successfully reverted to version {versionNumber}"
	/// </summary>
	public override string MessageRevertSuccess(string versionNumber)
	{
		return $"Se ha vuelto correctamente a la versión {versionNumber}";
	}

	protected override string _GetTemplateForMessageRevertSuccess()
	{
		return "Se ha vuelto correctamente a la versión {versionNumber}";
	}

	protected override string _GetTemplateForMessageSaveError()
	{
		return "Algo ha ido mal. Inténtalo de nuevo más tarde.";
	}

	protected override string _GetTemplateForMessageTooManyUploads()
	{
		return "Estás subiendo demasiados archivos. Inténtalo de nuevo más tarde.";
	}

	protected override string _GetTemplateForMessageUpdatePriceError()
	{
		return "Error al actualizar el precio";
	}

	protected override string _GetTemplateForMessageUpdatePriceSuccess()
	{
		return "Precio actualizado correctamente";
	}

	protected override string _GetTemplateForMessageUpdateSuccess()
	{
		return "Actualizado correctamente";
	}
}
