namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GamePassResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GamePassResources_de_de : GamePassResources_en_us, IGamePassResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AddPass"
	/// English String: "Add Pass"
	/// </summary>
	public override string ActionAddPass => "Pass hinzufügen";

	/// <summary>
	/// Key: "Heading.PassesForThisGame"
	/// English String: "Passes"
	/// </summary>
	public override string HeadingPassesForThisGame => "Pässe";

	/// <summary>
	/// Key: "Label.Buy"
	/// English String: "Buy"
	/// </summary>
	public override string LabelBuy => "Kaufen";

	/// <summary>
	/// Key: "Label.Owned"
	/// English String: "Owned"
	/// </summary>
	public override string LabelOwned => "In Besitz";

	public GamePassResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddPass()
	{
		return "Pass hinzufügen";
	}

	protected override string _GetTemplateForHeadingPassesForThisGame()
	{
		return "Pässe";
	}

	protected override string _GetTemplateForLabelBuy()
	{
		return "Kaufen";
	}

	protected override string _GetTemplateForLabelOwned()
	{
		return "In Besitz";
	}
}
