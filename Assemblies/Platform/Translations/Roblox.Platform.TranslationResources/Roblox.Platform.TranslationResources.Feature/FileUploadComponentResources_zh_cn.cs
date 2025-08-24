namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides FileUploadComponentResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class FileUploadComponentResources_zh_cn : FileUploadComponentResources_en_us, IFileUploadComponentResources, ITranslationResources
{
	/// <summary>
	/// Key: "Label.DragFile"
	/// English String: "Drag a file here"
	/// </summary>
	public override string LabelDragFile => "拖拽文件至此处";

	/// <summary>
	/// Key: "Label.DragImage"
	/// English String: "Drag an image here"
	/// </summary>
	public override string LabelDragImage => "拖拽图像至此处";

	/// <summary>
	/// Key: "Label.DragImageOr"
	/// English String: "Drag an image here or select a file to upload"
	/// </summary>
	public override string LabelDragImageOr => "拖拽图像至此处，或选择文件上传。";

	/// <summary>
	/// Key: "Label.NoFileChosen"
	/// English String: "No File Chosen"
	/// </summary>
	public override string LabelNoFileChosen => "未选择文件";

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
	public override string LabelSelectFile => "选择一个文件";

	/// <summary>
	/// Key: "Label.SelectFromComputer"
	/// label
	/// English String: "Select an image from your computer"
	/// </summary>
	public override string LabelSelectFromComputer => "从你的电脑选择图像";

	/// <summary>
	/// Key: "Label.SelectFromDevice"
	/// label
	/// English String: "Select an image from your device"
	/// </summary>
	public override string LabelSelectFromDevice => "从你的设备选择图像";

	/// <summary>
	/// Key: "Label.Upload"
	/// English String: "Upload"
	/// </summary>
	public override string LabelUpload => "上传";

	public FileUploadComponentResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelDragFile()
	{
		return "拖拽文件至此处";
	}

	protected override string _GetTemplateForLabelDragImage()
	{
		return "拖拽图像至此处";
	}

	protected override string _GetTemplateForLabelDragImageOr()
	{
		return "拖拽图像至此处，或选择文件上传。";
	}

	protected override string _GetTemplateForLabelNoFileChosen()
	{
		return "未选择文件";
	}

	protected override string _GetTemplateForLabelOr()
	{
		return "或";
	}

	protected override string _GetTemplateForLabelSelectFile()
	{
		return "选择一个文件";
	}

	protected override string _GetTemplateForLabelSelectFromComputer()
	{
		return "从你的电脑选择图像";
	}

	protected override string _GetTemplateForLabelSelectFromDevice()
	{
		return "从你的设备选择图像";
	}

	/// <summary>
	/// Key: "Label.SelectImage"
	/// English String: "Select an image from your {deviceType}"
	/// </summary>
	public override string LabelSelectImage(string deviceType)
	{
		return $"从你的 {deviceType} 选择图像";
	}

	protected override string _GetTemplateForLabelSelectImage()
	{
		return "从你的 {deviceType} 选择图像";
	}

	protected override string _GetTemplateForLabelUpload()
	{
		return "上传";
	}

	/// <summary>
	/// Key: "Message.InvalidFile"
	/// English String: "Invalid file type. Must be a {fileTypes} file."
	/// </summary>
	public override string MessageInvalidFile(string fileTypes)
	{
		return $"无效文件类型。必须是 {fileTypes} 文件。";
	}

	protected override string _GetTemplateForMessageInvalidFile()
	{
		return "无效文件类型。必须是 {fileTypes} 文件。";
	}
}
