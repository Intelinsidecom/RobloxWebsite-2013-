using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class GamePassResources_en_us : TranslationResourcesBase, IGamePassResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.AddPass"
	/// English String: "Add Pass"
	/// </summary>
	public virtual string ActionAddPass => "Add Pass";

	/// <summary>
	/// Key: "Heading.PassesForThisGame"
	/// English String: "Passes"
	/// </summary>
	public virtual string HeadingPassesForThisGame => "Passes";

	/// <summary>
	/// Key: "Label.Buy"
	/// English String: "Buy"
	/// </summary>
	public virtual string LabelBuy => "Buy";

	/// <summary>
	/// Key: "Label.Owned"
	/// English String: "Owned"
	/// </summary>
	public virtual string LabelOwned => "Owned";

	public GamePassResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.AddPass",
				_GetTemplateForActionAddPass()
			},
			{
				"Heading.PassesForThisGame",
				_GetTemplateForHeadingPassesForThisGame()
			},
			{
				"Label.Buy",
				_GetTemplateForLabelBuy()
			},
			{
				"Label.Owned",
				_GetTemplateForLabelOwned()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.GamePass";
	}

	protected virtual string _GetTemplateForActionAddPass()
	{
		return "Add Pass";
	}

	protected virtual string _GetTemplateForHeadingPassesForThisGame()
	{
		return "Passes";
	}

	protected virtual string _GetTemplateForLabelBuy()
	{
		return "Buy";
	}

	protected virtual string _GetTemplateForLabelOwned()
	{
		return "Owned";
	}
}
