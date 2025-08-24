using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class FileUploadComponentResources_en_us : TranslationResourcesBase, IFileUploadComponentResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Label.DragFile"
	/// English String: "Drag a file here"
	/// </summary>
	public virtual string LabelDragFile => "Drag a file here";

	/// <summary>
	/// Key: "Label.DragImage"
	/// English String: "Drag an image here"
	/// </summary>
	public virtual string LabelDragImage => "Drag an image here";

	/// <summary>
	/// Key: "Label.DragImageOr"
	/// English String: "Drag an image here or select a file to upload"
	/// </summary>
	public virtual string LabelDragImageOr => "Drag an image here or select a file to upload";

	/// <summary>
	/// Key: "Label.NoFileChosen"
	/// English String: "No File Chosen"
	/// </summary>
	public virtual string LabelNoFileChosen => "No File Chosen";

	/// <summary>
	/// Key: "Label.Or"
	/// label
	/// English String: "Or"
	/// </summary>
	public virtual string LabelOr => "Or";

	/// <summary>
	/// Key: "Label.SelectFile"
	/// English String: "Select a file"
	/// </summary>
	public virtual string LabelSelectFile => "Select a file";

	/// <summary>
	/// Key: "Label.SelectFromComputer"
	/// label
	/// English String: "Select an image from your computer"
	/// </summary>
	public virtual string LabelSelectFromComputer => "Select an image from your computer";

	/// <summary>
	/// Key: "Label.SelectFromDevice"
	/// label
	/// English String: "Select an image from your device"
	/// </summary>
	public virtual string LabelSelectFromDevice => "Select an image from your device";

	/// <summary>
	/// Key: "Label.Upload"
	/// English String: "Upload"
	/// </summary>
	public virtual string LabelUpload => "Upload";

	public FileUploadComponentResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Label.DragFile",
				_GetTemplateForLabelDragFile()
			},
			{
				"Label.DragImage",
				_GetTemplateForLabelDragImage()
			},
			{
				"Label.DragImageOr",
				_GetTemplateForLabelDragImageOr()
			},
			{
				"Label.NoFileChosen",
				_GetTemplateForLabelNoFileChosen()
			},
			{
				"Label.Or",
				_GetTemplateForLabelOr()
			},
			{
				"Label.SelectFile",
				_GetTemplateForLabelSelectFile()
			},
			{
				"Label.SelectFromComputer",
				_GetTemplateForLabelSelectFromComputer()
			},
			{
				"Label.SelectFromDevice",
				_GetTemplateForLabelSelectFromDevice()
			},
			{
				"Label.SelectImage",
				_GetTemplateForLabelSelectImage()
			},
			{
				"Label.Upload",
				_GetTemplateForLabelUpload()
			},
			{
				"Message.InvalidFile",
				_GetTemplateForMessageInvalidFile()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.FileUploadComponent";
	}

	protected virtual string _GetTemplateForLabelDragFile()
	{
		return "Drag a file here";
	}

	protected virtual string _GetTemplateForLabelDragImage()
	{
		return "Drag an image here";
	}

	protected virtual string _GetTemplateForLabelDragImageOr()
	{
		return "Drag an image here or select a file to upload";
	}

	protected virtual string _GetTemplateForLabelNoFileChosen()
	{
		return "No File Chosen";
	}

	protected virtual string _GetTemplateForLabelOr()
	{
		return "Or";
	}

	protected virtual string _GetTemplateForLabelSelectFile()
	{
		return "Select a file";
	}

	protected virtual string _GetTemplateForLabelSelectFromComputer()
	{
		return "Select an image from your computer";
	}

	protected virtual string _GetTemplateForLabelSelectFromDevice()
	{
		return "Select an image from your device";
	}

	/// <summary>
	/// Key: "Label.SelectImage"
	/// English String: "Select an image from your {deviceType}"
	/// </summary>
	public virtual string LabelSelectImage(string deviceType)
	{
		return $"Select an image from your {deviceType}";
	}

	protected virtual string _GetTemplateForLabelSelectImage()
	{
		return "Select an image from your {deviceType}";
	}

	protected virtual string _GetTemplateForLabelUpload()
	{
		return "Upload";
	}

	/// <summary>
	/// Key: "Message.InvalidFile"
	/// English String: "Invalid file type. Must be a {fileTypes} file."
	/// </summary>
	public virtual string MessageInvalidFile(string fileTypes)
	{
		return $"Invalid file type. Must be a {fileTypes} file.";
	}

	protected virtual string _GetTemplateForMessageInvalidFile()
	{
		return "Invalid file type. Must be a {fileTypes} file.";
	}
}
