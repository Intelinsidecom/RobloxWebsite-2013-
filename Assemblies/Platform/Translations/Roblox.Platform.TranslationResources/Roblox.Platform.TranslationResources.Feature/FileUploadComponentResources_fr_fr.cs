namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides FileUploadComponentResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class FileUploadComponentResources_fr_fr : FileUploadComponentResources_en_us, IFileUploadComponentResources, ITranslationResources
{
	/// <summary>
	/// Key: "Label.DragFile"
	/// English String: "Drag a file here"
	/// </summary>
	public override string LabelDragFile => "Fais glisser une image ici";

	/// <summary>
	/// Key: "Label.DragImage"
	/// English String: "Drag an image here"
	/// </summary>
	public override string LabelDragImage => "Fais glisser une image ici";

	/// <summary>
	/// Key: "Label.DragImageOr"
	/// English String: "Drag an image here or select a file to upload"
	/// </summary>
	public override string LabelDragImageOr => "Fais glisser une image ici ou sÃ©lectionne un fichier Ã  tÃ©lÃ©charger";

	/// <summary>
	/// Key: "Label.NoFileChosen"
	/// English String: "No File Chosen"
	/// </summary>
	public override string LabelNoFileChosen => "Aucun fichier sÃ©lectionnÃ©";

	/// <summary>
	/// Key: "Label.Or"
	/// label
	/// English String: "Or"
	/// </summary>
	public override string LabelOr => "Ou";

	/// <summary>
	/// Key: "Label.SelectFile"
	/// English String: "Select a file"
	/// </summary>
	public override string LabelSelectFile => "SÃ©lectionne un fichier";

	/// <summary>
	/// Key: "Label.SelectFromComputer"
	/// label
	/// English String: "Select an image from your computer"
	/// </summary>
	public override string LabelSelectFromComputer => "SÃ©lectionne une image depuis ton ordinateur";

	/// <summary>
	/// Key: "Label.SelectFromDevice"
	/// label
	/// English String: "Select an image from your device"
	/// </summary>
	public override string LabelSelectFromDevice => "SÃ©lectionne une image depuis ton appareil";

	/// <summary>
	/// Key: "Label.Upload"
	/// English String: "Upload"
	/// </summary>
	public override string LabelUpload => "TÃ©lÃ©verser";

	public FileUploadComponentResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelDragFile()
	{
		return "Fais glisser une image ici";
	}

	protected override string _GetTemplateForLabelDragImage()
	{
		return "Fais glisser une image ici";
	}

	protected override string _GetTemplateForLabelDragImageOr()
	{
		return "Fais glisser une image ici ou sÃ©lectionne un fichier Ã  tÃ©lÃ©charger";
	}

	protected override string _GetTemplateForLabelNoFileChosen()
	{
		return "Aucun fichier sÃ©lectionnÃ©";
	}

	protected override string _GetTemplateForLabelOr()
	{
		return "Ou";
	}

	protected override string _GetTemplateForLabelSelectFile()
	{
		return "SÃ©lectionne un fichier";
	}

	protected override string _GetTemplateForLabelSelectFromComputer()
	{
		return "SÃ©lectionne une image depuis ton ordinateur";
	}

	protected override string _GetTemplateForLabelSelectFromDevice()
	{
		return "SÃ©lectionne une image depuis ton appareil";
	}

	/// <summary>
	/// Key: "Label.SelectImage"
	/// English String: "Select an image from your {deviceType}"
	/// </summary>
	public override string LabelSelectImage(string deviceType)
	{
		return $"SÃ©lectionne une image depuis ton {deviceType}";
	}

	protected override string _GetTemplateForLabelSelectImage()
	{
		return "SÃ©lectionne une image depuis ton {deviceType}";
	}

	protected override string _GetTemplateForLabelUpload()
	{
		return "TÃ©lÃ©verser";
	}

	/// <summary>
	/// Key: "Message.InvalidFile"
	/// English String: "Invalid file type. Must be a {fileTypes} file."
	/// </summary>
	public override string MessageInvalidFile(string fileTypes)
	{
		return $"Type de fichier invalide. Le fichier doit Ãªtre au format {fileTypes}.";
	}

	protected override string _GetTemplateForMessageInvalidFile()
	{
		return "Type de fichier invalide. Le fichier doit Ãªtre au format {fileTypes}.";
	}
}


}
