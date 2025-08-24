namespace Roblox.TranslationResources.Feature;

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
	public override string HeadingGearForThisGame => "裝備";

	/// <summary>
	/// Key: "Label.AddGear"
	/// English String: "Add Gear"
	/// </summary>
	public override string LabelAddGear => "新增裝備";

	/// <summary>
	/// Key: "Label.Buy"
	/// English String: "Buy"
	/// </summary>
	public override string LabelBuy => "購買";

	/// <summary>
	/// Key: "Label.Error"
	/// English String: "Error"
	/// </summary>
	public override string LabelError => "錯誤";

	/// <summary>
	/// Key: "Label.ErrorOccurred"
	/// English String: "An error occurred, please try again."
	/// </summary>
	public override string LabelErrorOccurred => "發生錯誤，請重新嘗試。";

	/// <summary>
	/// Key: "Label.NotForSale"
	/// English String: "This item is not for sale."
	/// </summary>
	public override string LabelNotForSale => "此道具為非賣品。";

	/// <summary>
	/// Key: "Label.Ok"
	/// English String: "OK"
	/// </summary>
	public override string LabelOk => "確定";

	/// <summary>
	/// Key: "Label.Owned"
	/// English String: "Owned"
	/// </summary>
	public override string LabelOwned => "已擁有";

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
	public override string LabelSorry => "對不起，無法從您的遊戲移除此道具。請重新嘗試。";

	/// <summary>
	/// Key: "Label.Success"
	/// English String: "Success!"
	/// </summary>
	public override string LabelSuccess => "成功！";

	public GameGearResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingGearForThisGame()
	{
		return "裝備";
	}

	protected override string _GetTemplateForLabelAddGear()
	{
		return "新增裝備";
	}

	protected override string _GetTemplateForLabelBuy()
	{
		return "購買";
	}

	protected override string _GetTemplateForLabelError()
	{
		return "錯誤";
	}

	protected override string _GetTemplateForLabelErrorOccurred()
	{
		return "發生錯誤，請重新嘗試。";
	}

	/// <summary>
	/// Key: "Label.ItemAddedToGame"
	/// English String: "You have added {item} to your game."
	/// </summary>
	public override string LabelItemAddedToGame(string item)
	{
		return $"您已將 {item} 加到您的遊戲";
	}

	protected override string _GetTemplateForLabelItemAddedToGame()
	{
		return "您已將 {item} 加到您的遊戲";
	}

	/// <summary>
	/// Key: "Label.ItemRemovedFromGame"
	/// English String: "You have removed {item} from your game."
	/// </summary>
	public override string LabelItemRemovedFromGame(string item)
	{
		return $"您已從您的遊戲移除 {item}。";
	}

	protected override string _GetTemplateForLabelItemRemovedFromGame()
	{
		return "您已從您的遊戲移除 {item}。";
	}

	protected override string _GetTemplateForLabelNotForSale()
	{
		return "此道具為非賣品。";
	}

	protected override string _GetTemplateForLabelOk()
	{
		return "確定";
	}

	protected override string _GetTemplateForLabelOwned()
	{
		return "已擁有";
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
		return "對不起，無法從您的遊戲移除此道具。請重新嘗試。";
	}

	protected override string _GetTemplateForLabelSuccess()
	{
		return "成功！";
	}
}
