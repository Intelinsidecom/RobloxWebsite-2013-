namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GamePassResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GamePassResources_ko_kr : GamePassResources_en_us, IGamePassResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AddPass"
	/// English String: "Add Pass"
	/// </summary>
	public override string ActionAddPass => "패스 추가";

	/// <summary>
	/// Key: "Heading.PassesForThisGame"
	/// English String: "Passes"
	/// </summary>
	public override string HeadingPassesForThisGame => "게임패스";

	/// <summary>
	/// Key: "Label.Buy"
	/// English String: "Buy"
	/// </summary>
	public override string LabelBuy => "구매";

	/// <summary>
	/// Key: "Label.Owned"
	/// English String: "Owned"
	/// </summary>
	public override string LabelOwned => "보유함";

	public GamePassResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddPass()
	{
		return "패스 추가";
	}

	protected override string _GetTemplateForHeadingPassesForThisGame()
	{
		return "게임패스";
	}

	protected override string _GetTemplateForLabelBuy()
	{
		return "구매";
	}

	protected override string _GetTemplateForLabelOwned()
	{
		return "보유함";
	}
}
