namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides FileUploadComponentResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class FileUploadComponentResources_de_de : FileUploadComponentResources_en_us, IFileUploadComponentResources, ITranslationResources
{
	/// <summary>
	/// Key: "Label.DragFile"
	/// English String: "Drag a file here"
	/// </summary>
	public override string LabelDragFile => "Ziehe eine Datei hierher";

	/// <summary>
	/// Key: "Label.DragImage"
	/// English String: "Drag an image here"
	/// </summary>
	public override string LabelDragImage => "Ziehe ein Bild hierher";

	/// <summary>
	/// Key: "Label.DragImageOr"
	/// English String: "Drag an image here or select a file to upload"
	/// </summary>
	public override string LabelDragImageOr => "Ziehe eine Datei hierher oder wähle eine Datei zum Hochladen aus";

	/// <summary>
	/// Key: "Label.NoFileChosen"
	/// English String: "No File Chosen"
	/// </summary>
	public override string LabelNoFileChosen => "Keine Datei gewählt";

	/// <summary>
	/// Key: "Label.Or"
	/// label
	/// English String: "Or"
	/// </summary>
	public override string LabelOr => "Oder";

	/// <summary>
	/// Key: "Label.SelectFile"
	/// English String: "Select a file"
	/// </summary>
	public override string LabelSelectFile => "Wähle eine Datei aus";

	/// <summary>
	/// Key: "Label.SelectFromComputer"
	/// label
	/// English String: "Select an image from your computer"
	/// </summary>
	public override string LabelSelectFromComputer => "Wähle ein Bild von deinem Computer.";

	/// <summary>
	/// Key: "Label.SelectFromDevice"
	/// label
	/// English String: "Select an image from your device"
	/// </summary>
	public override string LabelSelectFromDevice => "Wähle ein Bild von deinem Gerät.";

	/// <summary>
	/// Key: "Label.Upload"
	/// English String: "Upload"
	/// </summary>
	public override string LabelUpload => "Hochladen";

	public FileUploadComponentResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelDragFile()
	{
		return "Ziehe eine Datei hierher";
	}

	protected override string _GetTemplateForLabelDragImage()
	{
		return "Ziehe ein Bild hierher";
	}

	protected override string _GetTemplateForLabelDragImageOr()
	{
		return "Ziehe eine Datei hierher oder wähle eine Datei zum Hochladen aus";
	}

	protected override string _GetTemplateForLabelNoFileChosen()
	{
		return "Keine Datei gewählt";
	}

	protected override string _GetTemplateForLabelOr()
	{
		return "Oder";
	}

	protected override string _GetTemplateForLabelSelectFile()
	{
		return "Wähle eine Datei aus";
	}

	protected override string _GetTemplateForLabelSelectFromComputer()
	{
		return "Wähle ein Bild von deinem Computer.";
	}

	protected override string _GetTemplateForLabelSelectFromDevice()
	{
		return "Wähle ein Bild von deinem Gerät.";
	}

	/// <summary>
	/// Key: "Label.SelectImage"
	/// English String: "Select an image from your {deviceType}"
	/// </summary>
	public override string LabelSelectImage(string deviceType)
	{
		return $"Wähle ein Bild von deinem/deiner {deviceType}.";
	}

	protected override string _GetTemplateForLabelSelectImage()
	{
		return "Wähle ein Bild von deinem/deiner {deviceType}.";
	}

	protected override string _GetTemplateForLabelUpload()
	{
		return "Hochladen";
	}

	/// <summary>
	/// Key: "Message.InvalidFile"
	/// English String: "Invalid file type. Must be a {fileTypes} file."
	/// </summary>
	public override string MessageInvalidFile(string fileTypes)
	{
		return $"Ungültiger Dateityp. Unterstützte Dateitypen: {fileTypes}.";
	}

	protected override string _GetTemplateForMessageInvalidFile()
	{
		return "Ungültiger Dateityp. Unterstützte Dateitypen: {fileTypes}.";
	}
}
