namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides GameGearResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameGearResources_ko_kr : GameGearResources_en_us, IGameGearResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.GearForThisGame"
	/// English String: "Gear"
	/// </summary>
	public override string HeadingGearForThisGame => "ìž¥ë¹„";

	/// <summary>
	/// Key: "Label.AddGear"
	/// English String: "Add Gear"
	/// </summary>
	public override string LabelAddGear => "ìž¥ë¹„ ì¶”ê°€";

	/// <summary>
	/// Key: "Label.Buy"
	/// English String: "Buy"
	/// </summary>
	public override string LabelBuy => "êµ¬ë§¤";

	/// <summary>
	/// Key: "Label.Error"
	/// English String: "Error"
	/// </summary>
	public override string LabelError => "ì˜¤ë¥˜";

	/// <summary>
	/// Key: "Label.ErrorOccurred"
	/// English String: "An error occurred, please try again."
	/// </summary>
	public override string LabelErrorOccurred => "ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”. ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Label.NotForSale"
	/// English String: "This item is not for sale."
	/// </summary>
	public override string LabelNotForSale => "ë³¸ ì•„ì´í…œì€ íŒë§¤í•˜ì§€ ì•ŠìŠµë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Label.Ok"
	/// English String: "OK"
	/// </summary>
	public override string LabelOk => "í™•ì¸";

	/// <summary>
	/// Key: "Label.Owned"
	/// English String: "Owned"
	/// </summary>
	public override string LabelOwned => "ë³´ìœ í•¨";

	/// <summary>
	/// Key: "Label.Rent"
	/// English String: "Rent"
	/// </summary>
	public override string LabelRent => "ë¹Œë¦¬ê¸°";

	/// <summary>
	/// Key: "Label.ResourceRent"
	/// English String: "Rent"
	/// </summary>
	public override string LabelResourceRent => "ë¹Œë¦¬ê¸°";

	/// <summary>
	/// Key: "Label.Sorry"
	/// English String: "Sorry, we couldn't remove the item from your game. Please try again."
	/// </summary>
	public override string LabelSorry => "ì£„ì†¡í•©ë‹ˆë‹¤. í•´ë‹¹ ì•„ì´í…œì„ ê²Œìž„ì—ì„œ ì‚­ì œí•  ìˆ˜ ì—†ì–´ìš”. ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Label.Success"
	/// English String: "Success!"
	/// </summary>
	public override string LabelSuccess => "ì„±ê³µ!";

	public GameGearResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingGearForThisGame()
	{
		return "ìž¥ë¹„";
	}

	protected override string _GetTemplateForLabelAddGear()
	{
		return "ìž¥ë¹„ ì¶”ê°€";
	}

	protected override string _GetTemplateForLabelBuy()
	{
		return "êµ¬ë§¤";
	}

	protected override string _GetTemplateForLabelError()
	{
		return "ì˜¤ë¥˜";
	}

	protected override string _GetTemplateForLabelErrorOccurred()
	{
		return "ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”. ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";
	}

	/// <summary>
	/// Key: "Label.ItemAddedToGame"
	/// English String: "You have added {item} to your game."
	/// </summary>
	public override string LabelItemAddedToGame(string item)
	{
		return $"ê²Œìž„ì— {item}ì„(ë¥¼) ì¶”ê°€í–ˆì–´ìš”.";
	}

	protected override string _GetTemplateForLabelItemAddedToGame()
	{
		return "ê²Œìž„ì— {item}ì„(ë¥¼) ì¶”ê°€í–ˆì–´ìš”.";
	}

	/// <summary>
	/// Key: "Label.ItemRemovedFromGame"
	/// English String: "You have removed {item} from your game."
	/// </summary>
	public override string LabelItemRemovedFromGame(string item)
	{
		return $"ê²Œìž„ì—ì„œ {item}ì„(ë¥¼) ì‚­ì œí–ˆì–´ìš”.";
	}

	protected override string _GetTemplateForLabelItemRemovedFromGame()
	{
		return "ê²Œìž„ì—ì„œ {item}ì„(ë¥¼) ì‚­ì œí–ˆì–´ìš”.";
	}

	protected override string _GetTemplateForLabelNotForSale()
	{
		return "ë³¸ ì•„ì´í…œì€ íŒë§¤í•˜ì§€ ì•ŠìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForLabelOk()
	{
		return "í™•ì¸";
	}

	protected override string _GetTemplateForLabelOwned()
	{
		return "ë³´ìœ í•¨";
	}

	protected override string _GetTemplateForLabelRent()
	{
		return "ë¹Œë¦¬ê¸°";
	}

	protected override string _GetTemplateForLabelResourceRent()
	{
		return "ë¹Œë¦¬ê¸°";
	}

	protected override string _GetTemplateForLabelSorry()
	{
		return "ì£„ì†¡í•©ë‹ˆë‹¤. í•´ë‹¹ ì•„ì´í…œì„ ê²Œìž„ì—ì„œ ì‚­ì œí•  ìˆ˜ ì—†ì–´ìš”. ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForLabelSuccess()
	{
		return "ì„±ê³µ!";
	}
}


}
