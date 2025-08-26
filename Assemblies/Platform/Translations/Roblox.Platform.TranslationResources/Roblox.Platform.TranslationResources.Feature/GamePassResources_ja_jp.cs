namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string ActionAddPass => "ãƒ‘ã‚¹ã‚’è¿½åŠ ";

	/// <summary>
	/// Key: "Heading.PassesForThisGame"
	/// English String: "Passes"
	/// </summary>
	public override string HeadingPassesForThisGame => "ãƒ‘ã‚¹";

	/// <summary>
	/// Key: "Label.Buy"
	/// English String: "Buy"
	/// </summary>
	public override string LabelBuy => "è²·ã†";

	/// <summary>
	/// Key: "Label.Owned"
	/// English String: "Owned"
	/// </summary>
	public override string LabelOwned => "æ‰€æœ‰ã—ã¦ã„ã¾ã™";

	public GamePassResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddPass()
	{
		return "ãƒ‘ã‚¹ã‚’è¿½åŠ ";
	}

	protected override string _GetTemplateForHeadingPassesForThisGame()
	{
		return "ãƒ‘ã‚¹";
	}

	protected override string _GetTemplateForLabelBuy()
	{
		return "è²·ã†";
	}

	protected override string _GetTemplateForLabelOwned()
	{
		return "æ‰€æœ‰ã—ã¦ã„ã¾ã™";
	}
}


}
