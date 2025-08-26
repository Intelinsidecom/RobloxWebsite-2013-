namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string LabelDragFile => "ì—¬ê¸°ë¡œ íŒŒì¼ ëŒì–´ì˜¤ê¸°";

	/// <summary>
	/// Key: "Label.DragImage"
	/// English String: "Drag an image here"
	/// </summary>
	public override string LabelDragImage => "ì—¬ê¸°ë¡œ ì´ë¯¸ì§€ ëŒì–´ì˜¤ê¸°";

	/// <summary>
	/// Key: "Label.DragImageOr"
	/// English String: "Drag an image here or select a file to upload"
	/// </summary>
	public override string LabelDragImageOr => "ì—¬ê¸°ë¡œ ì´ë¯¸ì§€ë¥¼ ëŒì–´ì˜¤ê±°ë‚˜ ì—…ë¡œë“œí•  íŒŒì¼ì„ ì„ íƒí•˜ì„¸ìš”";

	/// <summary>
	/// Key: "Label.NoFileChosen"
	/// English String: "No File Chosen"
	/// </summary>
	public override string LabelNoFileChosen => "ì„ íƒí•œ íŒŒì¼ ì—†ìŒ";

	/// <summary>
	/// Key: "Label.Or"
	/// label
	/// English String: "Or"
	/// </summary>
	public override string LabelOr => "ë˜ëŠ”";

	/// <summary>
	/// Key: "Label.SelectFile"
	/// English String: "Select a file"
	/// </summary>
	public override string LabelSelectFile => "íŒŒì¼ ì„ íƒí•˜ê¸°";

	/// <summary>
	/// Key: "Label.SelectFromComputer"
	/// label
	/// English String: "Select an image from your computer"
	/// </summary>
	public override string LabelSelectFromComputer => "ì»´í“¨í„°ì—ì„œ ì´ë¯¸ì§€ ì„ íƒ";

	/// <summary>
	/// Key: "Label.SelectFromDevice"
	/// label
	/// English String: "Select an image from your device"
	/// </summary>
	public override string LabelSelectFromDevice => "ê¸°ê¸°ì—ì„œ ì´ë¯¸ì§€ ì„ íƒ";

	/// <summary>
	/// Key: "Label.Upload"
	/// English String: "Upload"
	/// </summary>
	public override string LabelUpload => "ì—…ë¡œë“œí•˜ê¸°";

	public FileUploadComponentResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelDragFile()
	{
		return "ì—¬ê¸°ë¡œ íŒŒì¼ ëŒì–´ì˜¤ê¸°";
	}

	protected override string _GetTemplateForLabelDragImage()
	{
		return "ì—¬ê¸°ë¡œ ì´ë¯¸ì§€ ëŒì–´ì˜¤ê¸°";
	}

	protected override string _GetTemplateForLabelDragImageOr()
	{
		return "ì—¬ê¸°ë¡œ ì´ë¯¸ì§€ë¥¼ ëŒì–´ì˜¤ê±°ë‚˜ ì—…ë¡œë“œí•  íŒŒì¼ì„ ì„ íƒí•˜ì„¸ìš”";
	}

	protected override string _GetTemplateForLabelNoFileChosen()
	{
		return "ì„ íƒí•œ íŒŒì¼ ì—†ìŒ";
	}

	protected override string _GetTemplateForLabelOr()
	{
		return "ë˜ëŠ”";
	}

	protected override string _GetTemplateForLabelSelectFile()
	{
		return "íŒŒì¼ ì„ íƒí•˜ê¸°";
	}

	protected override string _GetTemplateForLabelSelectFromComputer()
	{
		return "ì»´í“¨í„°ì—ì„œ ì´ë¯¸ì§€ ì„ íƒ";
	}

	protected override string _GetTemplateForLabelSelectFromDevice()
	{
		return "ê¸°ê¸°ì—ì„œ ì´ë¯¸ì§€ ì„ íƒ";
	}

	/// <summary>
	/// Key: "Label.SelectImage"
	/// English String: "Select an image from your {deviceType}"
	/// </summary>
	public override string LabelSelectImage(string deviceType)
	{
		return $"{deviceType}ì—ì„œ ì´ë¯¸ì§€ ì„ íƒ";
	}

	protected override string _GetTemplateForLabelSelectImage()
	{
		return "{deviceType}ì—ì„œ ì´ë¯¸ì§€ ì„ íƒ";
	}

	protected override string _GetTemplateForLabelUpload()
	{
		return "ì—…ë¡œë“œí•˜ê¸°";
	}

	/// <summary>
	/// Key: "Message.InvalidFile"
	/// English String: "Invalid file type. Must be a {fileTypes} file."
	/// </summary>
	public override string MessageInvalidFile(string fileTypes)
	{
		return $"ìœ íš¨í•˜ì§€ ì•Šì€ íŒŒì¼ ìœ í˜•. {fileTypes} íŒŒì¼ ì¢…ë¥˜ë§Œ ì—…ë¡œë“œ ê°€ëŠ¥. ";
	}

	protected override string _GetTemplateForMessageInvalidFile()
	{
		return "ìœ íš¨í•˜ì§€ ì•Šì€ íŒŒì¼ ìœ í˜•. {fileTypes} íŒŒì¼ ì¢…ë¥˜ë§Œ ì—…ë¡œë“œ ê°€ëŠ¥. ";
	}
}


}
