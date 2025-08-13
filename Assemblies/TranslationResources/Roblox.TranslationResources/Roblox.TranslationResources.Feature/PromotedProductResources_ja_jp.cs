namespace Roblox.TranslationResources.Feature;

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
	public override string HeadingGearForThisGame => "このゲームのギア";

	/// <summary>
	/// Key: "Label.AddGear"
	/// English String: "Add Gear"
	/// </summary>
	public override string LabelAddGear => "ギアを追加";

	/// <summary>
	/// Key: "Label.Buy"
	/// English String: "Buy"
	/// </summary>
	public override string LabelBuy => "買う";

	/// <summary>
	/// Key: "Label.Error"
	/// English String: "Error"
	/// </summary>
	public override string LabelError => "エラー";

	/// <summary>
	/// Key: "Label.ErrorOccurred"
	/// English String: "An error occurred, please try again."
	/// </summary>
	public override string LabelErrorOccurred => "エラーが発生しました。もう一度お試しください。";

	/// <summary>
	/// Key: "Label.NotForSale"
	/// English String: "This item is not for sale."
	/// </summary>
	public override string LabelNotForSale => "このアイテムは売られていません。";

	/// <summary>
	/// Key: "Label.NotForSaleShort"
	/// A shorter way to say an item is not for sale
	/// English String: "Not for sale"
	/// </summary>
	public override string LabelNotForSaleShort => "非売品";

	/// <summary>
	/// Key: "Label.Ok"
	/// English String: "OK"
	/// </summary>
	public override string LabelOk => "OK";

	/// <summary>
	/// Key: "Label.Owned"
	/// English String: "Owned"
	/// </summary>
	public override string LabelOwned => "所有しています";

	/// <summary>
	/// Key: "Label.Rent"
	/// English String: "Rent"
	/// </summary>
	public override string LabelRent => "レンタル";

	/// <summary>
	/// Key: "Label.ResourceRent"
	/// English String: "Rent"
	/// </summary>
	public override string LabelResourceRent => "レンタル";

	/// <summary>
	/// Key: "Label.Sorry"
	/// English String: "Sorry, we couldn't remove the item from your game. Please try again."
	/// </summary>
	public override string LabelSorry => "申し訳ありませんが、ゲームからアイテムを削除できませんでした。もう一度お試しください。";

	/// <summary>
	/// Key: "Label.Success"
	/// English String: "Success!"
	/// </summary>
	public override string LabelSuccess => "成功！";

	public PromotedProductResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingGearForThisGame()
	{
		return "このゲームのギア";
	}

	protected override string _GetTemplateForLabelAddGear()
	{
		return "ギアを追加";
	}

	protected override string _GetTemplateForLabelBuy()
	{
		return "買う";
	}

	protected override string _GetTemplateForLabelError()
	{
		return "エラー";
	}

	protected override string _GetTemplateForLabelErrorOccurred()
	{
		return "エラーが発生しました。もう一度お試しください。";
	}

	/// <summary>
	/// Key: "Label.ItemAddedToGame"
	/// English String: "You have added {item} to your game."
	/// </summary>
	public override string LabelItemAddedToGame(string item)
	{
		return $"ゲームに{item}を追加しました。";
	}

	protected override string _GetTemplateForLabelItemAddedToGame()
	{
		return "ゲームに{item}を追加しました。";
	}

	/// <summary>
	/// Key: "Label.ItemRemovedFromGame"
	/// English String: "You have removed {item} from your game."
	/// </summary>
	public override string LabelItemRemovedFromGame(string item)
	{
		return $"ゲームから{item}を削除しました。";
	}

	protected override string _GetTemplateForLabelItemRemovedFromGame()
	{
		return "ゲームから{item}を削除しました。";
	}

	protected override string _GetTemplateForLabelNotForSale()
	{
		return "このアイテムは売られていません。";
	}

	protected override string _GetTemplateForLabelNotForSaleShort()
	{
		return "非売品";
	}

	protected override string _GetTemplateForLabelOk()
	{
		return "OK";
	}

	protected override string _GetTemplateForLabelOwned()
	{
		return "所有しています";
	}

	protected override string _GetTemplateForLabelRent()
	{
		return "レンタル";
	}

	protected override string _GetTemplateForLabelResourceRent()
	{
		return "レンタル";
	}

	protected override string _GetTemplateForLabelSorry()
	{
		return "申し訳ありませんが、ゲームからアイテムを削除できませんでした。もう一度お試しください。";
	}

	protected override string _GetTemplateForLabelSuccess()
	{
		return "成功！";
	}
}
