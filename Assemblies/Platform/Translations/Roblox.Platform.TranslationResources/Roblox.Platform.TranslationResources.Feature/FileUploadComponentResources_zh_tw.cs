namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string LabelDragFile => "æ‹–æ›³æª”æ¡ˆåˆ°æ­¤è™•";

	/// <summary>
	/// Key: "Label.DragImage"
	/// English String: "Drag an image here"
	/// </summary>
	public override string LabelDragImage => "æ‹–æ›³åœ–åƒåˆ°æ­¤è™•";

	/// <summary>
	/// Key: "Label.DragImageOr"
	/// English String: "Drag an image here or select a file to upload"
	/// </summary>
	public override string LabelDragImageOr => "å°‡åœ–åƒæ‹–æ›³åˆ°æ­¤è™•æˆ–é¸æ“‡æª”æ¡ˆä¸Šå‚³";

	/// <summary>
	/// Key: "Label.NoFileChosen"
	/// English String: "No File Chosen"
	/// </summary>
	public override string LabelNoFileChosen => "æœªé¸æ“‡æª”æ¡ˆ";

	/// <summary>
	/// Key: "Label.Or"
	/// label
	/// English String: "Or"
	/// </summary>
	public override string LabelOr => "æˆ–";

	/// <summary>
	/// Key: "Label.SelectFile"
	/// English String: "Select a file"
	/// </summary>
	public override string LabelSelectFile => "é¸æ“‡æª”æ¡ˆ";

	/// <summary>
	/// Key: "Label.SelectFromComputer"
	/// label
	/// English String: "Select an image from your computer"
	/// </summary>
	public override string LabelSelectFromComputer => "å¾žæ‚¨çš„é›»è…¦é¸æ“‡åœ–åƒ";

	/// <summary>
	/// Key: "Label.SelectFromDevice"
	/// label
	/// English String: "Select an image from your device"
	/// </summary>
	public override string LabelSelectFromDevice => "å¾žæ‚¨çš„è£ç½®é¸æ“‡åœ–åƒ";

	/// <summary>
	/// Key: "Label.Upload"
	/// English String: "Upload"
	/// </summary>
	public override string LabelUpload => "ä¸Šå‚³";

	public FileUploadComponentResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelDragFile()
	{
		return "æ‹–æ›³æª”æ¡ˆåˆ°æ­¤è™•";
	}

	protected override string _GetTemplateForLabelDragImage()
	{
		return "æ‹–æ›³åœ–åƒåˆ°æ­¤è™•";
	}

	protected override string _GetTemplateForLabelDragImageOr()
	{
		return "å°‡åœ–åƒæ‹–æ›³åˆ°æ­¤è™•æˆ–é¸æ“‡æª”æ¡ˆä¸Šå‚³";
	}

	protected override string _GetTemplateForLabelNoFileChosen()
	{
		return "æœªé¸æ“‡æª”æ¡ˆ";
	}

	protected override string _GetTemplateForLabelOr()
	{
		return "æˆ–";
	}

	protected override string _GetTemplateForLabelSelectFile()
	{
		return "é¸æ“‡æª”æ¡ˆ";
	}

	protected override string _GetTemplateForLabelSelectFromComputer()
	{
		return "å¾žæ‚¨çš„é›»è…¦é¸æ“‡åœ–åƒ";
	}

	protected override string _GetTemplateForLabelSelectFromDevice()
	{
		return "å¾žæ‚¨çš„è£ç½®é¸æ“‡åœ–åƒ";
	}

	/// <summary>
	/// Key: "Label.SelectImage"
	/// English String: "Select an image from your {deviceType}"
	/// </summary>
	public override string LabelSelectImage(string deviceType)
	{
		return $"å¾žæ‚¨çš„{deviceType}é¸æ“‡åœ–åƒ";
	}

	protected override string _GetTemplateForLabelSelectImage()
	{
		return "å¾žæ‚¨çš„{deviceType}é¸æ“‡åœ–åƒ";
	}

	protected override string _GetTemplateForLabelUpload()
	{
		return "ä¸Šå‚³";
	}

	/// <summary>
	/// Key: "Message.InvalidFile"
	/// English String: "Invalid file type. Must be a {fileTypes} file."
	/// </summary>
	public override string MessageInvalidFile(string fileTypes)
	{
		return $"æª”æ¡ˆé¡žåž‹ç„¡æ•ˆï¼Œå¿…é ˆç‚º {fileTypes} æª”æ¡ˆã€‚";
	}

	protected override string _GetTemplateForMessageInvalidFile()
	{
		return "æª”æ¡ˆé¡žåž‹ç„¡æ•ˆï¼Œå¿…é ˆç‚º {fileTypes} æª”æ¡ˆã€‚";
	}
}


}
