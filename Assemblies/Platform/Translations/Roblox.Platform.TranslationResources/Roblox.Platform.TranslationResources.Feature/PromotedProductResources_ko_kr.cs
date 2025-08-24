namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PromotedProductResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PromotedProductResources_ko_kr : PromotedProductResources_en_us, IPromotedProductResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.GearForThisGame"
	/// English String: "Gear for this game"
	/// </summary>
	public override string HeadingGearForThisGame => "본 게임을 위한 장비";

	/// <summary>
	/// Key: "Label.AddGear"
	/// English String: "Add Gear"
	/// </summary>
	public override string LabelAddGear => "장비 추가";

	/// <summary>
	/// Key: "Label.Buy"
	/// English String: "Buy"
	/// </summary>
	public override string LabelBuy => "구매";

	/// <summary>
	/// Key: "Label.Error"
	/// English String: "Error"
	/// </summary>
	public override string LabelError => "오류";

	/// <summary>
	/// Key: "Label.ErrorOccurred"
	/// English String: "An error occurred, please try again."
	/// </summary>
	public override string LabelErrorOccurred => "오류가 발생했어요. 다시 시도하세요.";

	/// <summary>
	/// Key: "Label.NotForSale"
	/// English String: "This item is not for sale."
	/// </summary>
	public override string LabelNotForSale => "본 아이템은 판매하지 않습니다.";

	/// <summary>
	/// Key: "Label.NotForSaleShort"
	/// A shorter way to say an item is not for sale
	/// English String: "Not for sale"
	/// </summary>
	public override string LabelNotForSaleShort => "구매 불가 아이템";

	/// <summary>
	/// Key: "Label.Ok"
	/// English String: "OK"
	/// </summary>
	public override string LabelOk => "확인";

	/// <summary>
	/// Key: "Label.Owned"
	/// English String: "Owned"
	/// </summary>
	public override string LabelOwned => "보유함";

	/// <summary>
	/// Key: "Label.Rent"
	/// English String: "Rent"
	/// </summary>
	public override string LabelRent => "빌리기";

	/// <summary>
	/// Key: "Label.ResourceRent"
	/// English String: "Rent"
	/// </summary>
	public override string LabelResourceRent => "빌리기";

	/// <summary>
	/// Key: "Label.Sorry"
	/// English String: "Sorry, we couldn't remove the item from your game. Please try again."
	/// </summary>
	public override string LabelSorry => "죄송합니다. 해당 아이템을 게임에서 삭제할 수 없어요. 다시 시도하세요.";

	/// <summary>
	/// Key: "Label.Success"
	/// English String: "Success!"
	/// </summary>
	public override string LabelSuccess => "성공!";

	public PromotedProductResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingGearForThisGame()
	{
		return "본 게임을 위한 장비";
	}

	protected override string _GetTemplateForLabelAddGear()
	{
		return "장비 추가";
	}

	protected override string _GetTemplateForLabelBuy()
	{
		return "구매";
	}

	protected override string _GetTemplateForLabelError()
	{
		return "오류";
	}

	protected override string _GetTemplateForLabelErrorOccurred()
	{
		return "오류가 발생했어요. 다시 시도하세요.";
	}

	/// <summary>
	/// Key: "Label.ItemAddedToGame"
	/// English String: "You have added {item} to your game."
	/// </summary>
	public override string LabelItemAddedToGame(string item)
	{
		return $"게임에 {item}을(를) 추가했어요.";
	}

	protected override string _GetTemplateForLabelItemAddedToGame()
	{
		return "게임에 {item}을(를) 추가했어요.";
	}

	/// <summary>
	/// Key: "Label.ItemRemovedFromGame"
	/// English String: "You have removed {item} from your game."
	/// </summary>
	public override string LabelItemRemovedFromGame(string item)
	{
		return $"게임에서 {item}을(를) 삭제했어요.";
	}

	protected override string _GetTemplateForLabelItemRemovedFromGame()
	{
		return "게임에서 {item}을(를) 삭제했어요.";
	}

	protected override string _GetTemplateForLabelNotForSale()
	{
		return "본 아이템은 판매하지 않습니다.";
	}

	protected override string _GetTemplateForLabelNotForSaleShort()
	{
		return "구매 불가 아이템";
	}

	protected override string _GetTemplateForLabelOk()
	{
		return "확인";
	}

	protected override string _GetTemplateForLabelOwned()
	{
		return "보유함";
	}

	protected override string _GetTemplateForLabelRent()
	{
		return "빌리기";
	}

	protected override string _GetTemplateForLabelResourceRent()
	{
		return "빌리기";
	}

	protected override string _GetTemplateForLabelSorry()
	{
		return "죄송합니다. 해당 아이템을 게임에서 삭제할 수 없어요. 다시 시도하세요.";
	}

	protected override string _GetTemplateForLabelSuccess()
	{
		return "성공!";
	}
}
