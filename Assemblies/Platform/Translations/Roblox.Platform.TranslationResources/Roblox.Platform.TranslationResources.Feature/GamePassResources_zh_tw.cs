namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string ActionAddPass => "æ–°å¢žéŠæˆ²è­‰";

	/// <summary>
	/// Key: "Heading.PassesForThisGame"
	/// English String: "Passes"
	/// </summary>
	public override string HeadingPassesForThisGame => "éŠæˆ²è­‰";

	/// <summary>
	/// Key: "Label.Buy"
	/// English String: "Buy"
	/// </summary>
	public override string LabelBuy => "è³¼è²·";

	/// <summary>
	/// Key: "Label.Owned"
	/// English String: "Owned"
	/// </summary>
	public override string LabelOwned => "å·²æ“æœ‰";

	public GamePassResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddPass()
	{
		return "æ–°å¢žéŠæˆ²è­‰";
	}

	protected override string _GetTemplateForHeadingPassesForThisGame()
	{
		return "éŠæˆ²è­‰";
	}

	protected override string _GetTemplateForLabelBuy()
	{
		return "è³¼è²·";
	}

	protected override string _GetTemplateForLabelOwned()
	{
		return "å·²æ“æœ‰";
	}
}


}
