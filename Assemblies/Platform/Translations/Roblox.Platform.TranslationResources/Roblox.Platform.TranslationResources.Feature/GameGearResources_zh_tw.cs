namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides GameGearResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameGearResources_zh_tw : GameGearResources_en_us, IGameGearResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.GearForThisGame"
	/// English String: "Gear"
	/// </summary>
	public override string HeadingGearForThisGame => "è£å‚™";

	/// <summary>
	/// Key: "Label.AddGear"
	/// English String: "Add Gear"
	/// </summary>
	public override string LabelAddGear => "æ–°å¢žè£å‚™";

	/// <summary>
	/// Key: "Label.Buy"
	/// English String: "Buy"
	/// </summary>
	public override string LabelBuy => "è³¼è²·";

	/// <summary>
	/// Key: "Label.Error"
	/// English String: "Error"
	/// </summary>
	public override string LabelError => "éŒ¯èª¤";

	/// <summary>
	/// Key: "Label.ErrorOccurred"
	/// English String: "An error occurred, please try again."
	/// </summary>
	public override string LabelErrorOccurred => "ç™¼ç”ŸéŒ¯èª¤ï¼Œè«‹é‡æ–°å˜—è©¦ã€‚";

	/// <summary>
	/// Key: "Label.NotForSale"
	/// English String: "This item is not for sale."
	/// </summary>
	public override string LabelNotForSale => "æ­¤é“å…·ç‚ºéžè³£å“ã€‚";

	/// <summary>
	/// Key: "Label.Ok"
	/// English String: "OK"
	/// </summary>
	public override string LabelOk => "ç¢ºå®š";

	/// <summary>
	/// Key: "Label.Owned"
	/// English String: "Owned"
	/// </summary>
	public override string LabelOwned => "å·²æ“æœ‰";

	/// <summary>
	/// Key: "Label.Rent"
	/// English String: "Rent"
	/// </summary>
	public override string LabelRent => "ç§Ÿç”¨";

	/// <summary>
	/// Key: "Label.ResourceRent"
	/// English String: "Rent"
	/// </summary>
	public override string LabelResourceRent => "ç§Ÿç”¨";

	/// <summary>
	/// Key: "Label.Sorry"
	/// English String: "Sorry, we couldn't remove the item from your game. Please try again."
	/// </summary>
	public override string LabelSorry => "å°ä¸èµ·ï¼Œç„¡æ³•å¾žæ‚¨çš„éŠæˆ²ç§»é™¤æ­¤é“å…·ã€‚è«‹é‡æ–°å˜—è©¦ã€‚";

	/// <summary>
	/// Key: "Label.Success"
	/// English String: "Success!"
	/// </summary>
	public override string LabelSuccess => "æˆåŠŸï¼";

	public GameGearResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingGearForThisGame()
	{
		return "è£å‚™";
	}

	protected override string _GetTemplateForLabelAddGear()
	{
		return "æ–°å¢žè£å‚™";
	}

	protected override string _GetTemplateForLabelBuy()
	{
		return "è³¼è²·";
	}

	protected override string _GetTemplateForLabelError()
	{
		return "éŒ¯èª¤";
	}

	protected override string _GetTemplateForLabelErrorOccurred()
	{
		return "ç™¼ç”ŸéŒ¯èª¤ï¼Œè«‹é‡æ–°å˜—è©¦ã€‚";
	}

	/// <summary>
	/// Key: "Label.ItemAddedToGame"
	/// English String: "You have added {item} to your game."
	/// </summary>
	public override string LabelItemAddedToGame(string item)
	{
		return $"æ‚¨å·²å°‡ {item} åŠ åˆ°æ‚¨çš„éŠæˆ²";
	}

	protected override string _GetTemplateForLabelItemAddedToGame()
	{
		return "æ‚¨å·²å°‡ {item} åŠ åˆ°æ‚¨çš„éŠæˆ²";
	}

	/// <summary>
	/// Key: "Label.ItemRemovedFromGame"
	/// English String: "You have removed {item} from your game."
	/// </summary>
	public override string LabelItemRemovedFromGame(string item)
	{
		return $"æ‚¨å·²å¾žæ‚¨çš„éŠæˆ²ç§»é™¤ {item}ã€‚";
	}

	protected override string _GetTemplateForLabelItemRemovedFromGame()
	{
		return "æ‚¨å·²å¾žæ‚¨çš„éŠæˆ²ç§»é™¤ {item}ã€‚";
	}

	protected override string _GetTemplateForLabelNotForSale()
	{
		return "æ­¤é“å…·ç‚ºéžè³£å“ã€‚";
	}

	protected override string _GetTemplateForLabelOk()
	{
		return "ç¢ºå®š";
	}

	protected override string _GetTemplateForLabelOwned()
	{
		return "å·²æ“æœ‰";
	}

	protected override string _GetTemplateForLabelRent()
	{
		return "ç§Ÿç”¨";
	}

	protected override string _GetTemplateForLabelResourceRent()
	{
		return "ç§Ÿç”¨";
	}

	protected override string _GetTemplateForLabelSorry()
	{
		return "å°ä¸èµ·ï¼Œç„¡æ³•å¾žæ‚¨çš„éŠæˆ²ç§»é™¤æ­¤é“å…·ã€‚è«‹é‡æ–°å˜—è©¦ã€‚";
	}

	protected override string _GetTemplateForLabelSuccess()
	{
		return "æˆåŠŸï¼";
	}
}


}
