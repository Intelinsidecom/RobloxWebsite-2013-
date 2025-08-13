namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides FileUploadComponentResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class FileUploadComponentResources_es_es : FileUploadComponentResources_en_us, IFileUploadComponentResources, ITranslationResources
{
	/// <summary>
	/// Key: "Label.DragFile"
	/// English String: "Drag a file here"
	/// </summary>
	public override string LabelDragFile => "Arrastrar una imagen aquí";

	/// <summary>
	/// Key: "Label.DragImage"
	/// English String: "Drag an image here"
	/// </summary>
	public override string LabelDragImage => "Arrastra una imagen aquí";

	/// <summary>
	/// Key: "Label.DragImageOr"
	/// English String: "Drag an image here or select a file to upload"
	/// </summary>
	public override string LabelDragImageOr => "Arrastra una imagen aquí o selecciona un archivo para subirlo";

	/// <summary>
	/// Key: "Label.NoFileChosen"
	/// English String: "No File Chosen"
	/// </summary>
	public override string LabelNoFileChosen => "No se han elegido archivos";

	/// <summary>
	/// Key: "Label.Or"
	/// label
	/// English String: "Or"
	/// </summary>
	public override string LabelOr => "o";

	/// <summary>
	/// Key: "Label.SelectFile"
	/// English String: "Select a file"
	/// </summary>
	public override string LabelSelectFile => "Seleccionar un archivo";

	/// <summary>
	/// Key: "Label.SelectFromComputer"
	/// label
	/// English String: "Select an image from your computer"
	/// </summary>
	public override string LabelSelectFromComputer => "Selecciónala de tu ordenador";

	/// <summary>
	/// Key: "Label.SelectFromDevice"
	/// label
	/// English String: "Select an image from your device"
	/// </summary>
	public override string LabelSelectFromDevice => "Selecciónala de tu dispositivo";

	/// <summary>
	/// Key: "Label.Upload"
	/// English String: "Upload"
	/// </summary>
	public override string LabelUpload => "Súbela";

	public FileUploadComponentResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelDragFile()
	{
		return "Arrastrar una imagen aquí";
	}

	protected override string _GetTemplateForLabelDragImage()
	{
		return "Arrastra una imagen aquí";
	}

	protected override string _GetTemplateForLabelDragImageOr()
	{
		return "Arrastra una imagen aquí o selecciona un archivo para subirlo";
	}

	protected override string _GetTemplateForLabelNoFileChosen()
	{
		return "No se han elegido archivos";
	}

	protected override string _GetTemplateForLabelOr()
	{
		return "o";
	}

	protected override string _GetTemplateForLabelSelectFile()
	{
		return "Seleccionar un archivo";
	}

	protected override string _GetTemplateForLabelSelectFromComputer()
	{
		return "Selecciónala de tu ordenador";
	}

	protected override string _GetTemplateForLabelSelectFromDevice()
	{
		return "Selecciónala de tu dispositivo";
	}

	/// <summary>
	/// Key: "Label.SelectImage"
	/// English String: "Select an image from your {deviceType}"
	/// </summary>
	public override string LabelSelectImage(string deviceType)
	{
		return $"Selecciona una imagen de tu {deviceType}";
	}

	protected override string _GetTemplateForLabelSelectImage()
	{
		return "Selecciona una imagen de tu {deviceType}";
	}

	protected override string _GetTemplateForLabelUpload()
	{
		return "Súbela";
	}

	/// <summary>
	/// Key: "Message.InvalidFile"
	/// English String: "Invalid file type. Must be a {fileTypes} file."
	/// </summary>
	public override string MessageInvalidFile(string fileTypes)
	{
		return $"Tipo de archivo no válido. Debe ser un archivo {fileTypes}.";
	}

	protected override string _GetTemplateForMessageInvalidFile()
	{
		return "Tipo de archivo no válido. Debe ser un archivo {fileTypes}.";
	}
}
