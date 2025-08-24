namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GamePassResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GamePassResources_ja_jp : GamePassResources_en_us, IGamePassResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AddPass"
	/// English String: "Add Pass"
	/// </summary>
	public override string ActionAddPass => "パスを追加";

	/// <summary>
	/// Key: "Heading.PassesForThisGame"
	/// English String: "Passes"
	/// </summary>
	public override string HeadingPassesForThisGame => "パス";

	/// <summary>
	/// Key: "Label.Buy"
	/// English String: "Buy"
	/// </summary>
	public override string LabelBuy => "買う";

	/// <summary>
	/// Key: "Label.Owned"
	/// English String: "Owned"
	/// </summary>
	public override string LabelOwned => "所有しています";

	public GamePassResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddPass()
	{
		return "パスを追加";
	}

	protected override string _GetTemplateForHeadingPassesForThisGame()
	{
		return "パス";
	}

	protected override string _GetTemplateForLabelBuy()
	{
		return "買う";
	}

	protected override string _GetTemplateForLabelOwned()
	{
		return "所有しています";
	}
}
