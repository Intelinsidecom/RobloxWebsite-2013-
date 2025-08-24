namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GamePassResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GamePassResources_zh_tw : GamePassResources_en_us, IGamePassResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AddPass"
	/// English String: "Add Pass"
	/// </summary>
	public override string ActionAddPass => "新增遊戲證";

	/// <summary>
	/// Key: "Heading.PassesForThisGame"
	/// English String: "Passes"
	/// </summary>
	public override string HeadingPassesForThisGame => "遊戲證";

	/// <summary>
	/// Key: "Label.Buy"
	/// English String: "Buy"
	/// </summary>
	public override string LabelBuy => "購買";

	/// <summary>
	/// Key: "Label.Owned"
	/// English String: "Owned"
	/// </summary>
	public override string LabelOwned => "已擁有";

	public GamePassResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddPass()
	{
		return "新增遊戲證";
	}

	protected override string _GetTemplateForHeadingPassesForThisGame()
	{
		return "遊戲證";
	}

	protected override string _GetTemplateForLabelBuy()
	{
		return "購買";
	}

	protected override string _GetTemplateForLabelOwned()
	{
		return "已擁有";
	}
}
