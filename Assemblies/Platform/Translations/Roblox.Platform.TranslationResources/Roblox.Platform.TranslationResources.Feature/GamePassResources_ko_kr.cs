namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string ActionAddPass => "íŒ¨ìŠ¤ ì¶”ê°€";

	/// <summary>
	/// Key: "Heading.PassesForThisGame"
	/// English String: "Passes"
	/// </summary>
	public override string HeadingPassesForThisGame => "ê²Œìž„íŒ¨ìŠ¤";

	/// <summary>
	/// Key: "Label.Buy"
	/// English String: "Buy"
	/// </summary>
	public override string LabelBuy => "êµ¬ë§¤";

	/// <summary>
	/// Key: "Label.Owned"
	/// English String: "Owned"
	/// </summary>
	public override string LabelOwned => "ë³´ìœ í•¨";

	public GamePassResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddPass()
	{
		return "íŒ¨ìŠ¤ ì¶”ê°€";
	}

	protected override string _GetTemplateForHeadingPassesForThisGame()
	{
		return "ê²Œìž„íŒ¨ìŠ¤";
	}

	protected override string _GetTemplateForLabelBuy()
	{
		return "êµ¬ë§¤";
	}

	protected override string _GetTemplateForLabelOwned()
	{
		return "ë³´ìœ í•¨";
	}
}


}
