namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides PromotedProductResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PromotedProductResources_zh_cjv : PromotedProductResources_en_us, IPromotedProductResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.GearForThisGame"
	/// English String: "Gear for this game"
	/// </summary>
	public override string HeadingGearForThisGame => "æ­¤æ¸¸æˆçš„è£…å¤‡";

	/// <summary>
	/// Key: "Label.AddGear"
	/// English String: "Add Gear"
	/// </summary>
	public override string LabelAddGear => "æ·»åŠ è£…å¤‡";

	/// <summary>
	/// Key: "Label.Buy"
	/// English String: "Buy"
	/// </summary>
	public override string LabelBuy => "è´­ä¹°";

	/// <summary>
	/// Key: "Label.Error"
	/// English String: "Error"
	/// </summary>
	public override string LabelError => "é”™è¯¯";

	/// <summary>
	/// Key: "Label.ErrorOccurred"
	/// English String: "An error occurred, please try again."
	/// </summary>
	public override string LabelErrorOccurred => "å‘ç”Ÿé”™è¯¯ï¼Œè¯·é‡è¯•ã€‚";

	/// <summary>
	/// Key: "Label.NotForSale"
	/// English String: "This item is not for sale."
	/// </summary>
	public override string LabelNotForSale => "æ­¤é“å…·ä¸ºéžå–å“ã€‚";

	/// <summary>
	/// Key: "Label.NotForSaleShort"
	/// A shorter way to say an item is not for sale
	/// English String: "Not for sale"
	/// </summary>
	public override string LabelNotForSaleShort => "éžå–å“";

	/// <summary>
	/// Key: "Label.Ok"
	/// English String: "OK"
	/// </summary>
	public override string LabelOk => "å¥½";

	/// <summary>
	/// Key: "Label.Owned"
	/// English String: "Owned"
	/// </summary>
	public override string LabelOwned => "å·²æ‹¥æœ‰";

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
	public override string LabelSorry => "æŠ±æ­‰ï¼Œæˆ‘ä»¬æ— æ³•ä»Žä½ çš„æ¸¸æˆä¸­ç§»é™¤æ­¤é“å…·ã€‚è¯·é‡è¯•ã€‚";

	/// <summary>
	/// Key: "Label.Success"
	/// English String: "Success!"
	/// </summary>
	public override string LabelSuccess => "æˆåŠŸï¼";

	public PromotedProductResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingGearForThisGame()
	{
		return "æ­¤æ¸¸æˆçš„è£…å¤‡";
	}

	protected override string _GetTemplateForLabelAddGear()
	{
		return "æ·»åŠ è£…å¤‡";
	}

	protected override string _GetTemplateForLabelBuy()
	{
		return "è´­ä¹°";
	}

	protected override string _GetTemplateForLabelError()
	{
		return "é”™è¯¯";
	}

	protected override string _GetTemplateForLabelErrorOccurred()
	{
		return "å‘ç”Ÿé”™è¯¯ï¼Œè¯·é‡è¯•ã€‚";
	}

	/// <summary>
	/// Key: "Label.ItemAddedToGame"
	/// English String: "You have added {item} to your game."
	/// </summary>
	public override string LabelItemAddedToGame(string item)
	{
		return $"ä½ å·²å°†â€œ{item}â€æ·»åŠ è‡³ä½ çš„æ¸¸æˆã€‚";
	}

	protected override string _GetTemplateForLabelItemAddedToGame()
	{
		return "ä½ å·²å°†â€œ{item}â€æ·»åŠ è‡³ä½ çš„æ¸¸æˆã€‚";
	}

	/// <summary>
	/// Key: "Label.ItemRemovedFromGame"
	/// English String: "You have removed {item} from your game."
	/// </summary>
	public override string LabelItemRemovedFromGame(string item)
	{
		return $"ä½ å·²ä»Žæ¸¸æˆä¸­ç§»é™¤â€œ{item}â€ã€‚";
	}

	protected override string _GetTemplateForLabelItemRemovedFromGame()
	{
		return "ä½ å·²ä»Žæ¸¸æˆä¸­ç§»é™¤â€œ{item}â€ã€‚";
	}

	protected override string _GetTemplateForLabelNotForSale()
	{
		return "æ­¤é“å…·ä¸ºéžå–å“ã€‚";
	}

	protected override string _GetTemplateForLabelNotForSaleShort()
	{
		return "éžå–å“";
	}

	protected override string _GetTemplateForLabelOk()
	{
		return "å¥½";
	}

	protected override string _GetTemplateForLabelOwned()
	{
		return "å·²æ‹¥æœ‰";
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
		return "æŠ±æ­‰ï¼Œæˆ‘ä»¬æ— æ³•ä»Žä½ çš„æ¸¸æˆä¸­ç§»é™¤æ­¤é“å…·ã€‚è¯·é‡è¯•ã€‚";
	}

	protected override string _GetTemplateForLabelSuccess()
	{
		return "æˆåŠŸï¼";
	}
}


}
