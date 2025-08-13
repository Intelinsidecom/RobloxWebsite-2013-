namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides FileUploadComponentResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class FileUploadComponentResources_ko_kr : FileUploadComponentResources_en_us, IFileUploadComponentResources, ITranslationResources
{
	/// <summary>
	/// Key: "Label.DragFile"
	/// English String: "Drag a file here"
	/// </summary>
	public override string LabelDragFile => "여기로 파일 끌어오기";

	/// <summary>
	/// Key: "Label.DragImage"
	/// English String: "Drag an image here"
	/// </summary>
	public override string LabelDragImage => "여기로 이미지 끌어오기";

	/// <summary>
	/// Key: "Label.DragImageOr"
	/// English String: "Drag an image here or select a file to upload"
	/// </summary>
	public override string LabelDragImageOr => "여기로 이미지를 끌어오거나 업로드할 파일을 선택하세요";

	/// <summary>
	/// Key: "Label.NoFileChosen"
	/// English String: "No File Chosen"
	/// </summary>
	public override string LabelNoFileChosen => "선택한 파일 없음";

	/// <summary>
	/// Key: "Label.Or"
	/// label
	/// English String: "Or"
	/// </summary>
	public override string LabelOr => "또는";

	/// <summary>
	/// Key: "Label.SelectFile"
	/// English String: "Select a file"
	/// </summary>
	public override string LabelSelectFile => "파일 선택하기";

	/// <summary>
	/// Key: "Label.SelectFromComputer"
	/// label
	/// English String: "Select an image from your computer"
	/// </summary>
	public override string LabelSelectFromComputer => "컴퓨터에서 이미지 선택";

	/// <summary>
	/// Key: "Label.SelectFromDevice"
	/// label
	/// English String: "Select an image from your device"
	/// </summary>
	public override string LabelSelectFromDevice => "기기에서 이미지 선택";

	/// <summary>
	/// Key: "Label.Upload"
	/// English String: "Upload"
	/// </summary>
	public override string LabelUpload => "업로드하기";

	public FileUploadComponentResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelDragFile()
	{
		return "여기로 파일 끌어오기";
	}

	protected override string _GetTemplateForLabelDragImage()
	{
		return "여기로 이미지 끌어오기";
	}

	protected override string _GetTemplateForLabelDragImageOr()
	{
		return "여기로 이미지를 끌어오거나 업로드할 파일을 선택하세요";
	}

	protected override string _GetTemplateForLabelNoFileChosen()
	{
		return "선택한 파일 없음";
	}

	protected override string _GetTemplateForLabelOr()
	{
		return "또는";
	}

	protected override string _GetTemplateForLabelSelectFile()
	{
		return "파일 선택하기";
	}

	protected override string _GetTemplateForLabelSelectFromComputer()
	{
		return "컴퓨터에서 이미지 선택";
	}

	protected override string _GetTemplateForLabelSelectFromDevice()
	{
		return "기기에서 이미지 선택";
	}

	/// <summary>
	/// Key: "Label.SelectImage"
	/// English String: "Select an image from your {deviceType}"
	/// </summary>
	public override string LabelSelectImage(string deviceType)
	{
		return $"{deviceType}에서 이미지 선택";
	}

	protected override string _GetTemplateForLabelSelectImage()
	{
		return "{deviceType}에서 이미지 선택";
	}

	protected override string _GetTemplateForLabelUpload()
	{
		return "업로드하기";
	}

	/// <summary>
	/// Key: "Message.InvalidFile"
	/// English String: "Invalid file type. Must be a {fileTypes} file."
	/// </summary>
	public override string MessageInvalidFile(string fileTypes)
	{
		return $"유효하지 않은 파일 유형. {fileTypes} 파일 종류만 업로드 가능. ";
	}

	protected override string _GetTemplateForMessageInvalidFile()
	{
		return "유효하지 않은 파일 유형. {fileTypes} 파일 종류만 업로드 가능. ";
	}
}
