namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides CreatePlaceProductPromotionResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CreatePlaceProductPromotionResources_zh_tw : CreatePlaceProductPromotionResources_en_us, ICreatePlaceProductPromotionResources, ITranslationResources
{
	/// <summary>
	/// Key: "Label.AddToGame"
	/// English String: "Add to Game"
	/// </summary>
	public override string LabelAddToGame => "加到遊戲";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "取消";

	/// <summary>
	/// Key: "Label.Error"
	/// English String: "Error"
	/// </summary>
	public override string LabelError => "錯誤";

	/// <summary>
	/// Key: "Label.ErrorOccured"
	/// English String: "An error occurred, please try again."
	/// </summary>
	public override string LabelErrorOccured => "發生錯誤，請重新嘗試。";

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
	/// Key: "Label.PromoteOnYourGame"
	/// English String: "Promote on your Game"
	/// </summary>
	public override string LabelPromoteOnYourGame => "在您的遊戲上推廣";

	/// <summary>
	/// Key: "Label.Rent"
	/// English String: "Rent"
	/// </summary>
	public override string LabelRent => "租用";

	/// <summary>
	/// Key: "Label.SelectGroup"
	/// English String: "Select Group"
	/// </summary>
	public override string LabelSelectGroup => "選擇群組";

	/// <summary>
	/// Key: "Label.SelectNone"
	/// English String: "None"
	/// </summary>
	public override string LabelSelectNone => "無";

	/// <summary>
	/// Key: "Label.SelectYourGame"
	/// English String: "Select Your Game"
	/// </summary>
	public override string LabelSelectYourGame => "選擇您的遊戲";

	/// <summary>
	/// Key: "Label.SelectYourGameSemicolon"
	/// English String: "Select Your Game:"
	/// </summary>
	public override string LabelSelectYourGameSemicolon => "選擇您的遊戲：";

	/// <summary>
	/// Key: "Label.SorryWeCouldnt"
	/// English String: "Sorry, we couldn't remove the item from your game. Please try again."
	/// </summary>
	public override string LabelSorryWeCouldnt => "對不起，無法從您的遊戲移除此道具，請重新嘗試。";

	/// <summary>
	/// Key: "Label.Success"
	/// English String: "Success!"
	/// </summary>
	public override string LabelSuccess => "成功！";

	public CreatePlaceProductPromotionResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelAddToGame()
	{
		return "加到遊戲";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "取消";
	}

	protected override string _GetTemplateForLabelError()
	{
		return "錯誤";
	}

	protected override string _GetTemplateForLabelErrorOccured()
	{
		return "發生錯誤，請重新嘗試。";
	}

	protected override string _GetTemplateForLabelNotForSale()
	{
		return "此道具為非賣品。";
	}

	protected override string _GetTemplateForLabelOk()
	{
		return "確定";
	}

	protected override string _GetTemplateForLabelPromoteOnYourGame()
	{
		return "在您的遊戲上推廣";
	}

	protected override string _GetTemplateForLabelRent()
	{
		return "租用";
	}

	protected override string _GetTemplateForLabelSelectGroup()
	{
		return "選擇群組";
	}

	protected override string _GetTemplateForLabelSelectNone()
	{
		return "無";
	}

	protected override string _GetTemplateForLabelSelectYourGame()
	{
		return "選擇您的遊戲";
	}

	protected override string _GetTemplateForLabelSelectYourGameSemicolon()
	{
		return "選擇您的遊戲：";
	}

	protected override string _GetTemplateForLabelSorryWeCouldnt()
	{
		return "對不起，無法從您的遊戲移除此道具，請重新嘗試。";
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
		return $"在遊戲裡加入裝備會怎麼樣？該道具會顯示在您的遊戲頁面，並且自動允許在遊戲中使用。若有人從您的遊戲頁面購買此道具，您還能賺取 {affiliateSaleTotal} Robux！";
	}

	protected override string _GetTemplateForMessageWhatIsAddingGear()
	{
		return "在遊戲裡加入裝備會怎麼樣？該道具會顯示在您的遊戲頁面，並且自動允許在遊戲中使用。若有人從您的遊戲頁面購買此道具，您還能賺取 {affiliateSaleTotal} Robux！";
	}
}
