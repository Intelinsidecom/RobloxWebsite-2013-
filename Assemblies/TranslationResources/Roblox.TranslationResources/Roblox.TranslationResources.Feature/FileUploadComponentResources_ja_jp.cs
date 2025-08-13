namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides FileUploadComponentResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class FileUploadComponentResources_ja_jp : FileUploadComponentResources_en_us, IFileUploadComponentResources, ITranslationResources
{
	/// <summary>
	/// Key: "Label.DragFile"
	/// English String: "Drag a file here"
	/// </summary>
	public override string LabelDragFile => "ファイルをここにドラッグ";

	/// <summary>
	/// Key: "Label.DragImage"
	/// English String: "Drag an image here"
	/// </summary>
	public override string LabelDragImage => "画像をここにドラッグ";

	/// <summary>
	/// Key: "Label.DragImageOr"
	/// English String: "Drag an image here or select a file to upload"
	/// </summary>
	public override string LabelDragImageOr => "ここに画像をドラッグするかアップロードするファイルを選択";

	/// <summary>
	/// Key: "Label.NoFileChosen"
	/// English String: "No File Chosen"
	/// </summary>
	public override string LabelNoFileChosen => "ファイルが選択されていません";

	/// <summary>
	/// Key: "Label.Or"
	/// label
	/// English String: "Or"
	/// </summary>
	public override string LabelOr => "または";

	/// <summary>
	/// Key: "Label.SelectFile"
	/// English String: "Select a file"
	/// </summary>
	public override string LabelSelectFile => "ファイルを選択";

	/// <summary>
	/// Key: "Label.SelectFromComputer"
	/// label
	/// English String: "Select an image from your computer"
	/// </summary>
	public override string LabelSelectFromComputer => "パソコンから画像を選択してください";

	/// <summary>
	/// Key: "Label.SelectFromDevice"
	/// label
	/// English String: "Select an image from your device"
	/// </summary>
	public override string LabelSelectFromDevice => "デバイスから画像を選択してください";

	/// <summary>
	/// Key: "Label.Upload"
	/// English String: "Upload"
	/// </summary>
	public override string LabelUpload => "アップロード";

	public FileUploadComponentResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelDragFile()
	{
		return "ファイルをここにドラッグ";
	}

	protected override string _GetTemplateForLabelDragImage()
	{
		return "画像をここにドラッグ";
	}

	protected override string _GetTemplateForLabelDragImageOr()
	{
		return "ここに画像をドラッグするかアップロードするファイルを選択";
	}

	protected override string _GetTemplateForLabelNoFileChosen()
	{
		return "ファイルが選択されていません";
	}

	protected override string _GetTemplateForLabelOr()
	{
		return "または";
	}

	protected override string _GetTemplateForLabelSelectFile()
	{
		return "ファイルを選択";
	}

	protected override string _GetTemplateForLabelSelectFromComputer()
	{
		return "パソコンから画像を選択してください";
	}

	protected override string _GetTemplateForLabelSelectFromDevice()
	{
		return "デバイスから画像を選択してください";
	}

	/// <summary>
	/// Key: "Label.SelectImage"
	/// English String: "Select an image from your {deviceType}"
	/// </summary>
	public override string LabelSelectImage(string deviceType)
	{
		return $"{deviceType} から画像を選択してください";
	}

	protected override string _GetTemplateForLabelSelectImage()
	{
		return "{deviceType} から画像を選択してください";
	}

	protected override string _GetTemplateForLabelUpload()
	{
		return "アップロード";
	}

	/// <summary>
	/// Key: "Message.InvalidFile"
	/// English String: "Invalid file type. Must be a {fileTypes} file."
	/// </summary>
	public override string MessageInvalidFile(string fileTypes)
	{
		return $"無効なファイルタイプです。{fileTypes} ファイルである必要があります。";
	}

	protected override string _GetTemplateForMessageInvalidFile()
	{
		return "無効なファイルタイプです。{fileTypes} ファイルである必要があります。";
	}
}
