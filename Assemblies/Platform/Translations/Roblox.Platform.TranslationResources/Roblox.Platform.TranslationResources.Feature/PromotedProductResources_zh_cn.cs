namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PromotedProductResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PromotedProductResources_zh_cn : PromotedProductResources_en_us, IPromotedProductResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.GearForThisGame"
	/// English String: "Gear for this game"
	/// </summary>
	public override string HeadingGearForThisGame => "此游戏的装备";

	/// <summary>
	/// Key: "Label.AddGear"
	/// English String: "Add Gear"
	/// </summary>
	public override string LabelAddGear => "添加装备";

	/// <summary>
	/// Key: "Label.Buy"
	/// English String: "Buy"
	/// </summary>
	public override string LabelBuy => "购买";

	/// <summary>
	/// Key: "Label.Error"
	/// English String: "Error"
	/// </summary>
	public override string LabelError => "错误";

	/// <summary>
	/// Key: "Label.ErrorOccurred"
	/// English String: "An error occurred, please try again."
	/// </summary>
	public override string LabelErrorOccurred => "发生错误，请重试。";

	/// <summary>
	/// Key: "Label.NotForSale"
	/// English String: "This item is not for sale."
	/// </summary>
	public override string LabelNotForSale => "此道具为非卖品。";

	/// <summary>
	/// Key: "Label.NotForSaleShort"
	/// A shorter way to say an item is not for sale
	/// English String: "Not for sale"
	/// </summary>
	public override string LabelNotForSaleShort => "非卖品";

	/// <summary>
	/// Key: "Label.Ok"
	/// English String: "OK"
	/// </summary>
	public override string LabelOk => "好";

	/// <summary>
	/// Key: "Label.Owned"
	/// English String: "Owned"
	/// </summary>
	public override string LabelOwned => "已拥有";

	/// <summary>
	/// Key: "Label.Rent"
	/// English String: "Rent"
	/// </summary>
	public override string LabelRent => "租用";

	/// <summary>
	/// Key: "Label.ResourceRent"
	/// English String: "Rent"
	/// </summary>
	public override string LabelResourceRent => "租用";

	/// <summary>
	/// Key: "Label.Sorry"
	/// English String: "Sorry, we couldn't remove the item from your game. Please try again."
	/// </summary>
	public override string LabelSorry => "抱歉，我们无法从你的游戏中移除此道具。请重试。";

	/// <summary>
	/// Key: "Label.Success"
	/// English String: "Success!"
	/// </summary>
	public override string LabelSuccess => "成功！";

	public PromotedProductResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingGearForThisGame()
	{
		return "此游戏的装备";
	}

	protected override string _GetTemplateForLabelAddGear()
	{
		return "添加装备";
	}

	protected override string _GetTemplateForLabelBuy()
	{
		return "购买";
	}

	protected override string _GetTemplateForLabelError()
	{
		return "错误";
	}

	protected override string _GetTemplateForLabelErrorOccurred()
	{
		return "发生错误，请重试。";
	}

	/// <summary>
	/// Key: "Label.ItemAddedToGame"
	/// English String: "You have added {item} to your game."
	/// </summary>
	public override string LabelItemAddedToGame(string item)
	{
		return $"你已将“{item}”添加至你的游戏。";
	}

	protected override string _GetTemplateForLabelItemAddedToGame()
	{
		return "你已将“{item}”添加至你的游戏。";
	}

	/// <summary>
	/// Key: "Label.ItemRemovedFromGame"
	/// English String: "You have removed {item} from your game."
	/// </summary>
	public override string LabelItemRemovedFromGame(string item)
	{
		return $"你已从游戏中移除“{item}”。";
	}

	protected override string _GetTemplateForLabelItemRemovedFromGame()
	{
		return "你已从游戏中移除“{item}”。";
	}

	protected override string _GetTemplateForLabelNotForSale()
	{
		return "此道具为非卖品。";
	}

	protected override string _GetTemplateForLabelNotForSaleShort()
	{
		return "非卖品";
	}

	protected override string _GetTemplateForLabelOk()
	{
		return "好";
	}

	protected override string _GetTemplateForLabelOwned()
	{
		return "已拥有";
	}

	protected override string _GetTemplateForLabelRent()
	{
		return "租用";
	}

	protected override string _GetTemplateForLabelResourceRent()
	{
		return "租用";
	}

	protected override string _GetTemplateForLabelSorry()
	{
		return "抱歉，我们无法从你的游戏中移除此道具。请重试。";
	}

	protected override string _GetTemplateForLabelSuccess()
	{
		return "成功！";
	}
}
