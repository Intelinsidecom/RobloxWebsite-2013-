using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class PluginsResources_en_us : TranslationResourcesBase, IPluginsResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Label.ErrorBody"
	/// English String: "There was a problem installing this plugin. Please try again later."
	/// </summary>
	public virtual string LabelErrorBody => "There was a problem installing this plugin. Please try again later.";

	/// <summary>
	/// Key: "Label.ErrorTitle"
	/// English String: "Error Installing Plugin"
	/// </summary>
	public virtual string LabelErrorTitle => "Error Installing Plugin";

	/// <summary>
	/// Key: "Label.Ok"
	/// English String: "OK"
	/// </summary>
	public virtual string LabelOk => "OK";

	/// <summary>
	/// Key: "Label.Reinstall"
	/// English String: "Reinstall"
	/// </summary>
	public virtual string LabelReinstall => "Reinstall";

	/// <summary>
	/// Key: "Label.SuccessTitle"
	/// English String: "Plugin Installed"
	/// </summary>
	public virtual string LabelSuccessTitle => "Plugin Installed";

	/// <summary>
	/// Key: "Label.UpdateErrorBody"
	/// English String: "There was a problem updating this plugin. Please try again later."
	/// </summary>
	public virtual string LabelUpdateErrorBody => "There was a problem updating this plugin. Please try again later.";

	/// <summary>
	/// Key: "Label.UpdateErrorTitle"
	/// English String: "Error Updating Plugin"
	/// </summary>
	public virtual string LabelUpdateErrorTitle => "Error Updating Plugin";

	/// <summary>
	/// Key: "Label.UpdateSuccessTitle"
	/// English String: "Plugin Update"
	/// </summary>
	public virtual string LabelUpdateSuccessTitle => "Plugin Update";

	/// <summary>
	/// Key: "Label.UpdateText"
	/// English String: "Update"
	/// </summary>
	public virtual string LabelUpdateText => "Update";

	public PluginsResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Label.ErrorBody",
				_GetTemplateForLabelErrorBody()
			},
			{
				"Label.ErrorTitle",
				_GetTemplateForLabelErrorTitle()
			},
			{
				"Label.Ok",
				_GetTemplateForLabelOk()
			},
			{
				"Label.Reinstall",
				_GetTemplateForLabelReinstall()
			},
			{
				"Label.SuccessBody",
				_GetTemplateForLabelSuccessBody()
			},
			{
				"Label.SuccessTitle",
				_GetTemplateForLabelSuccessTitle()
			},
			{
				"Label.UpdateErrorBody",
				_GetTemplateForLabelUpdateErrorBody()
			},
			{
				"Label.UpdateErrorTitle",
				_GetTemplateForLabelUpdateErrorTitle()
			},
			{
				"Label.UpdateSuccessBody",
				_GetTemplateForLabelUpdateSuccessBody()
			},
			{
				"Label.UpdateSuccessTitle",
				_GetTemplateForLabelUpdateSuccessTitle()
			},
			{
				"Label.UpdateText",
				_GetTemplateForLabelUpdateText()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.Plugins";
	}

	protected virtual string _GetTemplateForLabelErrorBody()
	{
		return "There was a problem installing this plugin. Please try again later.";
	}

	protected virtual string _GetTemplateForLabelErrorTitle()
	{
		return "Error Installing Plugin";
	}

	protected virtual string _GetTemplateForLabelOk()
	{
		return "OK";
	}

	protected virtual string _GetTemplateForLabelReinstall()
	{
		return "Reinstall";
	}

	/// <summary>
	/// Key: "Label.SuccessBody"
	/// English String: "{item} has been successfully installed!"
	/// </summary>
	public virtual string LabelSuccessBody(string item)
	{
		return $"{item} has been successfully installed!";
	}

	protected virtual string _GetTemplateForLabelSuccessBody()
	{
		return "{item} has been successfully installed!";
	}

	protected virtual string _GetTemplateForLabelSuccessTitle()
	{
		return "Plugin Installed";
	}

	protected virtual string _GetTemplateForLabelUpdateErrorBody()
	{
		return "There was a problem updating this plugin. Please try again later.";
	}

	protected virtual string _GetTemplateForLabelUpdateErrorTitle()
	{
		return "Error Updating Plugin";
	}

	/// <summary>
	/// Key: "Label.UpdateSuccessBody"
	/// English String: "{item} has been successfully updated! Please open a new window for the changes to take effect."
	/// </summary>
	public virtual string LabelUpdateSuccessBody(string item)
	{
		return $"{item} has been successfully updated! Please open a new window for the changes to take effect.";
	}

	protected virtual string _GetTemplateForLabelUpdateSuccessBody()
	{
		return "{item} has been successfully updated! Please open a new window for the changes to take effect.";
	}

	protected virtual string _GetTemplateForLabelUpdateSuccessTitle()
	{
		return "Plugin Update";
	}

	protected virtual string _GetTemplateForLabelUpdateText()
	{
		return "Update";
	}
}
