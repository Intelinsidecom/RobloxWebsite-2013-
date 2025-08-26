namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string LabelDragFile => "ãƒ•ã‚¡ã‚¤ãƒ«ã‚’ã“ã“ã«ãƒ‰ãƒ©ãƒƒã‚°";

	/// <summary>
	/// Key: "Label.DragImage"
	/// English String: "Drag an image here"
	/// </summary>
	public override string LabelDragImage => "ç”»åƒã‚’ã“ã“ã«ãƒ‰ãƒ©ãƒƒã‚°";

	/// <summary>
	/// Key: "Label.DragImageOr"
	/// English String: "Drag an image here or select a file to upload"
	/// </summary>
	public override string LabelDragImageOr => "ã“ã“ã«ç”»åƒã‚’ãƒ‰ãƒ©ãƒƒã‚°ã™ã‚‹ã‹ã‚¢ãƒƒãƒ—ãƒ­ãƒ¼ãƒ‰ã™ã‚‹ãƒ•ã‚¡ã‚¤ãƒ«ã‚’é¸æŠž";

	/// <summary>
	/// Key: "Label.NoFileChosen"
	/// English String: "No File Chosen"
	/// </summary>
	public override string LabelNoFileChosen => "ãƒ•ã‚¡ã‚¤ãƒ«ãŒé¸æŠžã•ã‚Œã¦ã„ã¾ã›ã‚“";

	/// <summary>
	/// Key: "Label.Or"
	/// label
	/// English String: "Or"
	/// </summary>
	public override string LabelOr => "ã¾ãŸã¯";

	/// <summary>
	/// Key: "Label.SelectFile"
	/// English String: "Select a file"
	/// </summary>
	public override string LabelSelectFile => "ãƒ•ã‚¡ã‚¤ãƒ«ã‚’é¸æŠž";

	/// <summary>
	/// Key: "Label.SelectFromComputer"
	/// label
	/// English String: "Select an image from your computer"
	/// </summary>
	public override string LabelSelectFromComputer => "ãƒ‘ã‚½ã‚³ãƒ³ã‹ã‚‰ç”»åƒã‚’é¸æŠžã—ã¦ãã ã•ã„";

	/// <summary>
	/// Key: "Label.SelectFromDevice"
	/// label
	/// English String: "Select an image from your device"
	/// </summary>
	public override string LabelSelectFromDevice => "ãƒ‡ãƒã‚¤ã‚¹ã‹ã‚‰ç”»åƒã‚’é¸æŠžã—ã¦ãã ã•ã„";

	/// <summary>
	/// Key: "Label.Upload"
	/// English String: "Upload"
	/// </summary>
	public override string LabelUpload => "ã‚¢ãƒƒãƒ—ãƒ­ãƒ¼ãƒ‰";

	public FileUploadComponentResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelDragFile()
	{
		return "ãƒ•ã‚¡ã‚¤ãƒ«ã‚’ã“ã“ã«ãƒ‰ãƒ©ãƒƒã‚°";
	}

	protected override string _GetTemplateForLabelDragImage()
	{
		return "ç”»åƒã‚’ã“ã“ã«ãƒ‰ãƒ©ãƒƒã‚°";
	}

	protected override string _GetTemplateForLabelDragImageOr()
	{
		return "ã“ã“ã«ç”»åƒã‚’ãƒ‰ãƒ©ãƒƒã‚°ã™ã‚‹ã‹ã‚¢ãƒƒãƒ—ãƒ­ãƒ¼ãƒ‰ã™ã‚‹ãƒ•ã‚¡ã‚¤ãƒ«ã‚’é¸æŠž";
	}

	protected override string _GetTemplateForLabelNoFileChosen()
	{
		return "ãƒ•ã‚¡ã‚¤ãƒ«ãŒé¸æŠžã•ã‚Œã¦ã„ã¾ã›ã‚“";
	}

	protected override string _GetTemplateForLabelOr()
	{
		return "ã¾ãŸã¯";
	}

	protected override string _GetTemplateForLabelSelectFile()
	{
		return "ãƒ•ã‚¡ã‚¤ãƒ«ã‚’é¸æŠž";
	}

	protected override string _GetTemplateForLabelSelectFromComputer()
	{
		return "ãƒ‘ã‚½ã‚³ãƒ³ã‹ã‚‰ç”»åƒã‚’é¸æŠžã—ã¦ãã ã•ã„";
	}

	protected override string _GetTemplateForLabelSelectFromDevice()
	{
		return "ãƒ‡ãƒã‚¤ã‚¹ã‹ã‚‰ç”»åƒã‚’é¸æŠžã—ã¦ãã ã•ã„";
	}

	/// <summary>
	/// Key: "Label.SelectImage"
	/// English String: "Select an image from your {deviceType}"
	/// </summary>
	public override string LabelSelectImage(string deviceType)
	{
		return $"{deviceType} ã‹ã‚‰ç”»åƒã‚’é¸æŠžã—ã¦ãã ã•ã„";
	}

	protected override string _GetTemplateForLabelSelectImage()
	{
		return "{deviceType} ã‹ã‚‰ç”»åƒã‚’é¸æŠžã—ã¦ãã ã•ã„";
	}

	protected override string _GetTemplateForLabelUpload()
	{
		return "ã‚¢ãƒƒãƒ—ãƒ­ãƒ¼ãƒ‰";
	}

	/// <summary>
	/// Key: "Message.InvalidFile"
	/// English String: "Invalid file type. Must be a {fileTypes} file."
	/// </summary>
	public override string MessageInvalidFile(string fileTypes)
	{
		return $"ç„¡åŠ¹ãªãƒ•ã‚¡ã‚¤ãƒ«ã‚¿ã‚¤ãƒ—ã§ã™ã€‚{fileTypes} ãƒ•ã‚¡ã‚¤ãƒ«ã§ã‚ã‚‹å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚";
	}

	protected override string _GetTemplateForMessageInvalidFile()
	{
		return "ç„¡åŠ¹ãªãƒ•ã‚¡ã‚¤ãƒ«ã‚¿ã‚¤ãƒ—ã§ã™ã€‚{fileTypes} ãƒ•ã‚¡ã‚¤ãƒ«ã§ã‚ã‚‹å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚";
	}
}


}
