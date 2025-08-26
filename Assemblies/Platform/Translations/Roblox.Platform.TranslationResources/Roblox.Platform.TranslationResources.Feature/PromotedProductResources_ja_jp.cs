namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides PromotedProductResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PromotedProductResources_ja_jp : PromotedProductResources_en_us, IPromotedProductResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.GearForThisGame"
	/// English String: "Gear for this game"
	/// </summary>
	public override string HeadingGearForThisGame => "ã“ã®ã‚²ãƒ¼ãƒ ã®ã‚®ã‚¢";

	/// <summary>
	/// Key: "Label.AddGear"
	/// English String: "Add Gear"
	/// </summary>
	public override string LabelAddGear => "ã‚®ã‚¢ã‚’è¿½åŠ ";

	/// <summary>
	/// Key: "Label.Buy"
	/// English String: "Buy"
	/// </summary>
	public override string LabelBuy => "è²·ã†";

	/// <summary>
	/// Key: "Label.Error"
	/// English String: "Error"
	/// </summary>
	public override string LabelError => "ã‚¨ãƒ©ãƒ¼";

	/// <summary>
	/// Key: "Label.ErrorOccurred"
	/// English String: "An error occurred, please try again."
	/// </summary>
	public override string LabelErrorOccurred => "ã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Label.NotForSale"
	/// English String: "This item is not for sale."
	/// </summary>
	public override string LabelNotForSale => "ã“ã®ã‚¢ã‚¤ãƒ†ãƒ ã¯å£²ã‚‰ã‚Œã¦ã„ã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Label.NotForSaleShort"
	/// A shorter way to say an item is not for sale
	/// English String: "Not for sale"
	/// </summary>
	public override string LabelNotForSaleShort => "éžå£²å“";

	/// <summary>
	/// Key: "Label.Ok"
	/// English String: "OK"
	/// </summary>
	public override string LabelOk => "OK";

	/// <summary>
	/// Key: "Label.Owned"
	/// English String: "Owned"
	/// </summary>
	public override string LabelOwned => "æ‰€æœ‰ã—ã¦ã„ã¾ã™";

	/// <summary>
	/// Key: "Label.Rent"
	/// English String: "Rent"
	/// </summary>
	public override string LabelRent => "ãƒ¬ãƒ³ã‚¿ãƒ«";

	/// <summary>
	/// Key: "Label.ResourceRent"
	/// English String: "Rent"
	/// </summary>
	public override string LabelResourceRent => "ãƒ¬ãƒ³ã‚¿ãƒ«";

	/// <summary>
	/// Key: "Label.Sorry"
	/// English String: "Sorry, we couldn't remove the item from your game. Please try again."
	/// </summary>
	public override string LabelSorry => "ç”³ã—è¨³ã‚ã‚Šã¾ã›ã‚“ãŒã€ã‚²ãƒ¼ãƒ ã‹ã‚‰ã‚¢ã‚¤ãƒ†ãƒ ã‚’å‰Šé™¤ã§ãã¾ã›ã‚“ã§ã—ãŸã€‚ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Label.Success"
	/// English String: "Success!"
	/// </summary>
	public override string LabelSuccess => "æˆåŠŸï¼";

	public PromotedProductResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingGearForThisGame()
	{
		return "ã“ã®ã‚²ãƒ¼ãƒ ã®ã‚®ã‚¢";
	}

	protected override string _GetTemplateForLabelAddGear()
	{
		return "ã‚®ã‚¢ã‚’è¿½åŠ ";
	}

	protected override string _GetTemplateForLabelBuy()
	{
		return "è²·ã†";
	}

	protected override string _GetTemplateForLabelError()
	{
		return "ã‚¨ãƒ©ãƒ¼";
	}

	protected override string _GetTemplateForLabelErrorOccurred()
	{
		return "ã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";
	}

	/// <summary>
	/// Key: "Label.ItemAddedToGame"
	/// English String: "You have added {item} to your game."
	/// </summary>
	public override string LabelItemAddedToGame(string item)
	{
		return $"ã‚²ãƒ¼ãƒ ã«{item}ã‚’è¿½åŠ ã—ã¾ã—ãŸã€‚";
	}

	protected override string _GetTemplateForLabelItemAddedToGame()
	{
		return "ã‚²ãƒ¼ãƒ ã«{item}ã‚’è¿½åŠ ã—ã¾ã—ãŸã€‚";
	}

	/// <summary>
	/// Key: "Label.ItemRemovedFromGame"
	/// English String: "You have removed {item} from your game."
	/// </summary>
	public override string LabelItemRemovedFromGame(string item)
	{
		return $"ã‚²ãƒ¼ãƒ ã‹ã‚‰{item}ã‚’å‰Šé™¤ã—ã¾ã—ãŸã€‚";
	}

	protected override string _GetTemplateForLabelItemRemovedFromGame()
	{
		return "ã‚²ãƒ¼ãƒ ã‹ã‚‰{item}ã‚’å‰Šé™¤ã—ã¾ã—ãŸã€‚";
	}

	protected override string _GetTemplateForLabelNotForSale()
	{
		return "ã“ã®ã‚¢ã‚¤ãƒ†ãƒ ã¯å£²ã‚‰ã‚Œã¦ã„ã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForLabelNotForSaleShort()
	{
		return "éžå£²å“";
	}

	protected override string _GetTemplateForLabelOk()
	{
		return "OK";
	}

	protected override string _GetTemplateForLabelOwned()
	{
		return "æ‰€æœ‰ã—ã¦ã„ã¾ã™";
	}

	protected override string _GetTemplateForLabelRent()
	{
		return "ãƒ¬ãƒ³ã‚¿ãƒ«";
	}

	protected override string _GetTemplateForLabelResourceRent()
	{
		return "ãƒ¬ãƒ³ã‚¿ãƒ«";
	}

	protected override string _GetTemplateForLabelSorry()
	{
		return "ç”³ã—è¨³ã‚ã‚Šã¾ã›ã‚“ãŒã€ã‚²ãƒ¼ãƒ ã‹ã‚‰ã‚¢ã‚¤ãƒ†ãƒ ã‚’å‰Šé™¤ã§ãã¾ã›ã‚“ã§ã—ãŸã€‚ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForLabelSuccess()
	{
		return "æˆåŠŸï¼";
	}
}


}
