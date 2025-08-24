using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class BuildersClubResources_en_us : TranslationResourcesBase, IBuildersClubResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.BuidlersClubOnlyCancel"
	/// English String: "Cancel"
	/// </summary>
	public virtual string ActionBuidlersClubOnlyCancel => "Cancel";

	/// <summary>
	/// Key: "Action.BuidlersClubOnlyUpgradeNow"
	/// English String: "Upgrade Now"
	/// </summary>
	public virtual string ActionBuidlersClubOnlyUpgradeNow => "Upgrade Now";

	/// <summary>
	/// Key: "Heading.BuildersClubOnly"
	/// English String: "Builders Club Only"
	/// </summary>
	public virtual string HeadingBuildersClubOnly => "Builders Club Only";

	/// <summary>
	/// Key: "Label.BuidlersClubOnlyClose"
	/// English String: "Close"
	/// </summary>
	public virtual string LabelBuidlersClubOnlyClose => "Close";

	public BuildersClubResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.BuidlersClubOnlyCancel",
				_GetTemplateForActionBuidlersClubOnlyCancel()
			},
			{
				"Action.BuidlersClubOnlyUpgradeNow",
				_GetTemplateForActionBuidlersClubOnlyUpgradeNow()
			},
			{
				"DescriptionBuildersClubOnlyModel",
				_GetTemplateForDescriptionBuildersClubOnlyModel()
			},
			{
				"Heading.BuildersClubOnly",
				_GetTemplateForHeadingBuildersClubOnly()
			},
			{
				"Label.BuidlersClubOnlyClose",
				_GetTemplateForLabelBuidlersClubOnlyClose()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.BuildersClub";
	}

	protected virtual string _GetTemplateForActionBuidlersClubOnlyCancel()
	{
		return "Cancel";
	}

	protected virtual string _GetTemplateForActionBuidlersClubOnlyUpgradeNow()
	{
		return "Upgrade Now";
	}

	/// <summary>
	/// Key: "DescriptionBuildersClubOnlyModel"
	/// English String: "This is a premium item only available to our {bcRequirementName} members."
	/// </summary>
	public virtual string DescriptionBuildersClubOnlyModel(string bcRequirementName)
	{
		return $"This is a premium item only available to our {bcRequirementName} members.";
	}

	protected virtual string _GetTemplateForDescriptionBuildersClubOnlyModel()
	{
		return "This is a premium item only available to our {bcRequirementName} members.";
	}

	protected virtual string _GetTemplateForHeadingBuildersClubOnly()
	{
		return "Builders Club Only";
	}

	protected virtual string _GetTemplateForLabelBuidlersClubOnlyClose()
	{
		return "Close";
	}
}
