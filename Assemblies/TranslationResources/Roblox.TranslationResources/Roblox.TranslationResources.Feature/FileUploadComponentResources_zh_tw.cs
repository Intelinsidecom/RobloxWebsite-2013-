namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides FileUploadComponentResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class FileUploadComponentResources_zh_tw : FileUploadComponentResources_en_us, IFileUploadComponentResources, ITranslationResources
{
	/// <summary>
	/// Key: "Label.DragFile"
	/// English String: "Drag a file here"
	/// </summary>
	public override string LabelDragFile => "拖曳檔案到此處";

	/// <summary>
	/// Key: "Label.DragImage"
	/// English String: "Drag an image here"
	/// </summary>
	public override string LabelDragImage => "拖曳圖像到此處";

	/// <summary>
	/// Key: "Label.DragImageOr"
	/// English String: "Drag an image here or select a file to upload"
	/// </summary>
	public override string LabelDragImageOr => "將圖像拖曳到此處或選擇檔案上傳";

	/// <summary>
	/// Key: "Label.NoFileChosen"
	/// English String: "No File Chosen"
	/// </summary>
	public override string LabelNoFileChosen => "未選擇檔案";

	/// <summary>
	/// Key: "Label.Or"
	/// label
	/// English String: "Or"
	/// </summary>
	public override string LabelOr => "或";

	/// <summary>
	/// Key: "Label.SelectFile"
	/// English String: "Select a file"
	/// </summary>
	public override string LabelSelectFile => "選擇檔案";

	/// <summary>
	/// Key: "Label.SelectFromComputer"
	/// label
	/// English String: "Select an image from your computer"
	/// </summary>
	public override string LabelSelectFromComputer => "從您的電腦選擇圖像";

	/// <summary>
	/// Key: "Label.SelectFromDevice"
	/// label
	/// English String: "Select an image from your device"
	/// </summary>
	public override string LabelSelectFromDevice => "從您的裝置選擇圖像";

	/// <summary>
	/// Key: "Label.Upload"
	/// English String: "Upload"
	/// </summary>
	public override string LabelUpload => "上傳";

	public FileUploadComponentResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelDragFile()
	{
		return "拖曳檔案到此處";
	}

	protected override string _GetTemplateForLabelDragImage()
	{
		return "拖曳圖像到此處";
	}

	protected override string _GetTemplateForLabelDragImageOr()
	{
		return "將圖像拖曳到此處或選擇檔案上傳";
	}

	protected override string _GetTemplateForLabelNoFileChosen()
	{
		return "未選擇檔案";
	}

	protected override string _GetTemplateForLabelOr()
	{
		return "或";
	}

	protected override string _GetTemplateForLabelSelectFile()
	{
		return "選擇檔案";
	}

	protected override string _GetTemplateForLabelSelectFromComputer()
	{
		return "從您的電腦選擇圖像";
	}

	protected override string _GetTemplateForLabelSelectFromDevice()
	{
		return "從您的裝置選擇圖像";
	}

	/// <summary>
	/// Key: "Label.SelectImage"
	/// English String: "Select an image from your {deviceType}"
	/// </summary>
	public override string LabelSelectImage(string deviceType)
	{
		return $"從您的{deviceType}選擇圖像";
	}

	protected override string _GetTemplateForLabelSelectImage()
	{
		return "從您的{deviceType}選擇圖像";
	}

	protected override string _GetTemplateForLabelUpload()
	{
		return "上傳";
	}

	/// <summary>
	/// Key: "Message.InvalidFile"
	/// English String: "Invalid file type. Must be a {fileTypes} file."
	/// </summary>
	public override string MessageInvalidFile(string fileTypes)
	{
		return $"檔案類型無效，必須為 {fileTypes} 檔案。";
	}

	protected override string _GetTemplateForMessageInvalidFile()
	{
		return "檔案類型無效，必須為 {fileTypes} 檔案。";
	}
}
