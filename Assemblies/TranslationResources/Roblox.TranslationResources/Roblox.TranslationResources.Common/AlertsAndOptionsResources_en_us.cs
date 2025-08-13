using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Common;

internal class AlertsAndOptionsResources_en_us : TranslationResourcesBase, IAlertsAndOptionsResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Label.sBuyRobux"
	/// English String: "Buy Robux"
	/// </summary>
	public virtual string LabelsBuyRobux => "Buy Robux";

	/// <summary>
	/// Key: "Label.sHelp"
	/// English String: "Help"
	/// </summary>
	public virtual string LabelsHelp => "Help";

	/// <summary>
	/// Key: "Label.sLogout"
	/// English String: "Logout"
	/// </summary>
	public virtual string LabelsLogout => "Logout";

	/// <summary>
	/// Key: "Label.sRobux"
	/// English String: "Robux"
	/// </summary>
	public virtual string LabelsRobux => "Robux";

	/// <summary>
	/// Key: "Label.sSettings"
	/// English String: "Settings"
	/// </summary>
	public virtual string LabelsSettings => "Settings";

	public AlertsAndOptionsResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Label.sBuyRobux",
				_GetTemplateForLabelsBuyRobux()
			},
			{
				"Label.sHelp",
				_GetTemplateForLabelsHelp()
			},
			{
				"Label.sLogout",
				_GetTemplateForLabelsLogout()
			},
			{
				"Label.sRobux",
				_GetTemplateForLabelsRobux()
			},
			{
				"Label.sRobuxMessage",
				_GetTemplateForLabelsRobuxMessage()
			},
			{
				"Label.sSettings",
				_GetTemplateForLabelsSettings()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Common.AlertsAndOptions";
	}

	protected virtual string _GetTemplateForLabelsBuyRobux()
	{
		return "Buy Robux";
	}

	protected virtual string _GetTemplateForLabelsHelp()
	{
		return "Help";
	}

	protected virtual string _GetTemplateForLabelsLogout()
	{
		return "Logout";
	}

	protected virtual string _GetTemplateForLabelsRobux()
	{
		return "Robux";
	}

	/// <summary>
	/// Key: "Label.sRobuxMessage"
	/// English String: "{robuxValue} Robux"
	/// </summary>
	public virtual string LabelsRobuxMessage(string robuxValue)
	{
		return $"{robuxValue}\u00a0Robux";
	}

	protected virtual string _GetTemplateForLabelsRobuxMessage()
	{
		return "{robuxValue}\u00a0Robux";
	}

	protected virtual string _GetTemplateForLabelsSettings()
	{
		return "Settings";
	}
}
