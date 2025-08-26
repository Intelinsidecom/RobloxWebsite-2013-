namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides FileUploadComponentResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class FileUploadComponentResources_zh_cjv : FileUploadComponentResources_en_us, IFileUploadComponentResources, ITranslationResources
{
	/// <summary>
	/// Key: "Label.DragFile"
	/// English String: "Drag a file here"
	/// </summary>
	public override string LabelDragFile => "æ‹–æ‹½æ–‡ä»¶è‡³æ­¤å¤„";

	/// <summary>
	/// Key: "Label.DragImage"
	/// English String: "Drag an image here"
	/// </summary>
	public override string LabelDragImage => "æ‹–æ‹½å›¾åƒè‡³æ­¤å¤„";

	/// <summary>
	/// Key: "Label.DragImageOr"
	/// English String: "Drag an image here or select a file to upload"
	/// </summary>
	public override string LabelDragImageOr => "æ‹–æ‹½å›¾åƒè‡³æ­¤å¤„ï¼Œæˆ–é€‰æ‹©æ–‡ä»¶ä¸Šä¼ ã€‚";

	/// <summary>
	/// Key: "Label.NoFileChosen"
	/// English String: "No File Chosen"
	/// </summary>
	public override string LabelNoFileChosen => "æœªé€‰æ‹©æ–‡ä»¶";

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
	public override string LabelSelectFile => "é€‰æ‹©ä¸€ä¸ªæ–‡ä»¶";

	/// <summary>
	/// Key: "Label.SelectFromComputer"
	/// label
	/// English String: "Select an image from your computer"
	/// </summary>
	public override string LabelSelectFromComputer => "ä»Žä½ çš„ç”µè„‘é€‰æ‹©å›¾åƒ";

	/// <summary>
	/// Key: "Label.SelectFromDevice"
	/// label
	/// English String: "Select an image from your device"
	/// </summary>
	public override string LabelSelectFromDevice => "ä»Žä½ çš„è®¾å¤‡é€‰æ‹©å›¾åƒ";

	/// <summary>
	/// Key: "Label.Upload"
	/// English String: "Upload"
	/// </summary>
	public override string LabelUpload => "ä¸Šä¼ ";

	public FileUploadComponentResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelDragFile()
	{
		return "æ‹–æ‹½æ–‡ä»¶è‡³æ­¤å¤„";
	}

	protected override string _GetTemplateForLabelDragImage()
	{
		return "æ‹–æ‹½å›¾åƒè‡³æ­¤å¤„";
	}

	protected override string _GetTemplateForLabelDragImageOr()
	{
		return "æ‹–æ‹½å›¾åƒè‡³æ­¤å¤„ï¼Œæˆ–é€‰æ‹©æ–‡ä»¶ä¸Šä¼ ã€‚";
	}

	protected override string _GetTemplateForLabelNoFileChosen()
	{
		return "æœªé€‰æ‹©æ–‡ä»¶";
	}

	protected override string _GetTemplateForLabelOr()
	{
		return "æˆ–";
	}

	protected override string _GetTemplateForLabelSelectFile()
	{
		return "é€‰æ‹©ä¸€ä¸ªæ–‡ä»¶";
	}

	protected override string _GetTemplateForLabelSelectFromComputer()
	{
		return "ä»Žä½ çš„ç”µè„‘é€‰æ‹©å›¾åƒ";
	}

	protected override string _GetTemplateForLabelSelectFromDevice()
	{
		return "ä»Žä½ çš„è®¾å¤‡é€‰æ‹©å›¾åƒ";
	}

	/// <summary>
	/// Key: "Label.SelectImage"
	/// English String: "Select an image from your {deviceType}"
	/// </summary>
	public override string LabelSelectImage(string deviceType)
	{
		return $"ä»Žä½ çš„ {deviceType} é€‰æ‹©å›¾åƒ";
	}

	protected override string _GetTemplateForLabelSelectImage()
	{
		return "ä»Žä½ çš„ {deviceType} é€‰æ‹©å›¾åƒ";
	}

	protected override string _GetTemplateForLabelUpload()
	{
		return "ä¸Šä¼ ";
	}

	/// <summary>
	/// Key: "Message.InvalidFile"
	/// English String: "Invalid file type. Must be a {fileTypes} file."
	/// </summary>
	public override string MessageInvalidFile(string fileTypes)
	{
		return $"æ— æ•ˆæ–‡ä»¶ç±»åž‹ã€‚å¿…é¡»æ˜¯ {fileTypes} æ–‡ä»¶ã€‚";
	}

	protected override string _GetTemplateForMessageInvalidFile()
	{
		return "æ— æ•ˆæ–‡ä»¶ç±»åž‹ã€‚å¿…é¡»æ˜¯ {fileTypes} æ–‡ä»¶ã€‚";
	}
}


}
