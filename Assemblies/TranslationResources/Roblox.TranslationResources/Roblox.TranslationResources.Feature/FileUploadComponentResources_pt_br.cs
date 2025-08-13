namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides FileUploadComponentResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class FileUploadComponentResources_pt_br : FileUploadComponentResources_en_us, IFileUploadComponentResources, ITranslationResources
{
	/// <summary>
	/// Key: "Label.DragFile"
	/// English String: "Drag a file here"
	/// </summary>
	public override string LabelDragFile => "Arraste um arquivo para cá";

	/// <summary>
	/// Key: "Label.DragImage"
	/// English String: "Drag an image here"
	/// </summary>
	public override string LabelDragImage => "Arraste uma imagem para cá";

	/// <summary>
	/// Key: "Label.DragImageOr"
	/// English String: "Drag an image here or select a file to upload"
	/// </summary>
	public override string LabelDragImageOr => "Arraste uma imagem para cá ou selecione um arquivo para fazer upload";

	/// <summary>
	/// Key: "Label.NoFileChosen"
	/// English String: "No File Chosen"
	/// </summary>
	public override string LabelNoFileChosen => "Nenhum arquivo selecionado";

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
	public override string LabelSelectFile => "Selecione um arquivo";

	/// <summary>
	/// Key: "Label.SelectFromComputer"
	/// label
	/// English String: "Select an image from your computer"
	/// </summary>
	public override string LabelSelectFromComputer => "Selecione uma imagem do seu computador";

	/// <summary>
	/// Key: "Label.SelectFromDevice"
	/// label
	/// English String: "Select an image from your device"
	/// </summary>
	public override string LabelSelectFromDevice => "Selecione uma imagem do seu dispositivo";

	/// <summary>
	/// Key: "Label.Upload"
	/// English String: "Upload"
	/// </summary>
	public override string LabelUpload => "Fazer upload";

	public FileUploadComponentResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelDragFile()
	{
		return "Arraste um arquivo para cá";
	}

	protected override string _GetTemplateForLabelDragImage()
	{
		return "Arraste uma imagem para cá";
	}

	protected override string _GetTemplateForLabelDragImageOr()
	{
		return "Arraste uma imagem para cá ou selecione um arquivo para fazer upload";
	}

	protected override string _GetTemplateForLabelNoFileChosen()
	{
		return "Nenhum arquivo selecionado";
	}

	protected override string _GetTemplateForLabelOr()
	{
		return "Ou";
	}

	protected override string _GetTemplateForLabelSelectFile()
	{
		return "Selecione um arquivo";
	}

	protected override string _GetTemplateForLabelSelectFromComputer()
	{
		return "Selecione uma imagem do seu computador";
	}

	protected override string _GetTemplateForLabelSelectFromDevice()
	{
		return "Selecione uma imagem do seu dispositivo";
	}

	/// <summary>
	/// Key: "Label.SelectImage"
	/// English String: "Select an image from your {deviceType}"
	/// </summary>
	public override string LabelSelectImage(string deviceType)
	{
		return $"Selecione uma imagem do seu dispositivo {deviceType}";
	}

	protected override string _GetTemplateForLabelSelectImage()
	{
		return "Selecione uma imagem do seu dispositivo {deviceType}";
	}

	protected override string _GetTemplateForLabelUpload()
	{
		return "Fazer upload";
	}

	/// <summary>
	/// Key: "Message.InvalidFile"
	/// English String: "Invalid file type. Must be a {fileTypes} file."
	/// </summary>
	public override string MessageInvalidFile(string fileTypes)
	{
		return $"Tipo de arquivo inválido. Deve ser um arquivo {fileTypes}.";
	}

	protected override string _GetTemplateForMessageInvalidFile()
	{
		return "Tipo de arquivo inválido. Deve ser um arquivo {fileTypes}.";
	}
}
