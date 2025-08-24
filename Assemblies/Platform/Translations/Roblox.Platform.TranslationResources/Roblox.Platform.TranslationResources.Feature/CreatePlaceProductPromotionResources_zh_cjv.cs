namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides CreatePlaceProductPromotionResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CreatePlaceProductPromotionResources_zh_cjv : CreatePlaceProductPromotionResources_en_us, ICreatePlaceProductPromotionResources, ITranslationResources
{
	/// <summary>
	/// Key: "Label.AddToGame"
	/// English String: "Add to Game"
	/// </summary>
	public override string LabelAddToGame => "添加至游戏";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "取消";

	/// <summary>
	/// Key: "Label.Error"
	/// English String: "Error"
	/// </summary>
	public override string LabelError => "错误";

	/// <summary>
	/// Key: "Label.ErrorOccured"
	/// English String: "An error occurred, please try again."
	/// </summary>
	public override string LabelErrorOccured => "发生错误，请重试。";

	/// <summary>
	/// Key: "Label.NotForSale"
	/// English String: "This item is not for sale."
	/// </summary>
	public override string LabelNotForSale => "此物品为非卖品。";

	/// <summary>
	/// Key: "Label.Ok"
	/// English String: "OK"
	/// </summary>
	public override string LabelOk => "好";

	/// <summary>
	/// Key: "Label.PromoteOnYourGame"
	/// English String: "Promote on your Game"
	/// </summary>
	public override string LabelPromoteOnYourGame => "在你的游戏上推广";

	/// <summary>
	/// Key: "Label.Rent"
	/// English String: "Rent"
	/// </summary>
	public override string LabelRent => "租用";

	/// <summary>
	/// Key: "Label.SelectGroup"
	/// English String: "Select Group"
	/// </summary>
	public override string LabelSelectGroup => "选择群组";

	/// <summary>
	/// Key: "Label.SelectNone"
	/// English String: "None"
	/// </summary>
	public override string LabelSelectNone => "无";

	/// <summary>
	/// Key: "Label.SelectYourGame"
	/// English String: "Select Your Game"
	/// </summary>
	public override string LabelSelectYourGame => "选择你的游戏";

	/// <summary>
	/// Key: "Label.SelectYourGameSemicolon"
	/// English String: "Select Your Game:"
	/// </summary>
	public override string LabelSelectYourGameSemicolon => "选择你的游戏：";

	/// <summary>
	/// Key: "Label.SorryWeCouldnt"
	/// English String: "Sorry, we couldn't remove the item from your game. Please try again."
	/// </summary>
	public override string LabelSorryWeCouldnt => "抱歉，我们无法从你的游戏中移除此物品。请重试。";

	/// <summary>
	/// Key: "Label.Success"
	/// English String: "Success!"
	/// </summary>
	public override string LabelSuccess => "成功！";

	public CreatePlaceProductPromotionResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelAddToGame()
	{
		return "添加至游戏";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "取消";
	}

	protected override string _GetTemplateForLabelError()
	{
		return "错误";
	}

	protected override string _GetTemplateForLabelErrorOccured()
	{
		return "发生错误，请重试。";
	}

	protected override string _GetTemplateForLabelNotForSale()
	{
		return "此物品为非卖品。";
	}

	protected override string _GetTemplateForLabelOk()
	{
		return "好";
	}

	protected override string _GetTemplateForLabelPromoteOnYourGame()
	{
		return "在你的游戏上推广";
	}

	protected override string _GetTemplateForLabelRent()
	{
		return "租用";
	}

	protected override string _GetTemplateForLabelSelectGroup()
	{
		return "选择群组";
	}

	protected override string _GetTemplateForLabelSelectNone()
	{
		return "无";
	}

	protected override string _GetTemplateForLabelSelectYourGame()
	{
		return "选择你的游戏";
	}

	protected override string _GetTemplateForLabelSelectYourGameSemicolon()
	{
		return "选择你的游戏：";
	}

	protected override string _GetTemplateForLabelSorryWeCouldnt()
	{
		return "抱歉，我们无法从你的游戏中移除此物品。请重试。";
	}

	protected override string _GetTemplateForLabelSuccess()
	{
		return "成功！";
	}

	/// <summary>
	/// Key: "Message.WhatIsAddingGear"
	/// English String: "What is adding gear to a game? This item is displayed on your game page, and automatically allowed in your game. If someone buys this item from your game page, you'll earn {affiliateSaleTotal} Robux!"
	/// </summary>
	public override string MessageWhatIsAddingGear(string affiliateSaleTotal)
	{
		return $"在游戏中添加装备会怎么样？该物品将显示在你的游戏页面，并自动允许在游戏中使用。如果有人从你的游戏页面购买此物品，你就能赚取 {affiliateSaleTotal} Robux！";
	}

	protected override string _GetTemplateForMessageWhatIsAddingGear()
	{
		return "在游戏中添加装备会怎么样？该物品将显示在你的游戏页面，并自动允许在游戏中使用。如果有人从你的游戏页面购买此物品，你就能赚取 {affiliateSaleTotal} Robux！";
	}
}
