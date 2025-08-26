namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string LabelAddToGame => "æ·»åŠ è‡³æ¸¸æˆ";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "å–æ¶ˆ";

	/// <summary>
	/// Key: "Label.Error"
	/// English String: "Error"
	/// </summary>
	public override string LabelError => "é”™è¯¯";

	/// <summary>
	/// Key: "Label.ErrorOccured"
	/// English String: "An error occurred, please try again."
	/// </summary>
	public override string LabelErrorOccured => "å‘ç”Ÿé”™è¯¯ï¼Œè¯·é‡è¯•ã€‚";

	/// <summary>
	/// Key: "Label.NotForSale"
	/// English String: "This item is not for sale."
	/// </summary>
	public override string LabelNotForSale => "æ­¤ç‰©å“ä¸ºéžå–å“ã€‚";

	/// <summary>
	/// Key: "Label.Ok"
	/// English String: "OK"
	/// </summary>
	public override string LabelOk => "å¥½";

	/// <summary>
	/// Key: "Label.PromoteOnYourGame"
	/// English String: "Promote on your Game"
	/// </summary>
	public override string LabelPromoteOnYourGame => "åœ¨ä½ çš„æ¸¸æˆä¸ŠæŽ¨å¹¿";

	/// <summary>
	/// Key: "Label.Rent"
	/// English String: "Rent"
	/// </summary>
	public override string LabelRent => "ç§Ÿç”¨";

	/// <summary>
	/// Key: "Label.SelectGroup"
	/// English String: "Select Group"
	/// </summary>
	public override string LabelSelectGroup => "é€‰æ‹©ç¾¤ç»„";

	/// <summary>
	/// Key: "Label.SelectNone"
	/// English String: "None"
	/// </summary>
	public override string LabelSelectNone => "æ— ";

	/// <summary>
	/// Key: "Label.SelectYourGame"
	/// English String: "Select Your Game"
	/// </summary>
	public override string LabelSelectYourGame => "é€‰æ‹©ä½ çš„æ¸¸æˆ";

	/// <summary>
	/// Key: "Label.SelectYourGameSemicolon"
	/// English String: "Select Your Game:"
	/// </summary>
	public override string LabelSelectYourGameSemicolon => "é€‰æ‹©ä½ çš„æ¸¸æˆï¼š";

	/// <summary>
	/// Key: "Label.SorryWeCouldnt"
	/// English String: "Sorry, we couldn't remove the item from your game. Please try again."
	/// </summary>
	public override string LabelSorryWeCouldnt => "æŠ±æ­‰ï¼Œæˆ‘ä»¬æ— æ³•ä»Žä½ çš„æ¸¸æˆä¸­ç§»é™¤æ­¤ç‰©å“ã€‚è¯·é‡è¯•ã€‚";

	/// <summary>
	/// Key: "Label.Success"
	/// English String: "Success!"
	/// </summary>
	public override string LabelSuccess => "æˆåŠŸï¼";

	public CreatePlaceProductPromotionResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelAddToGame()
	{
		return "æ·»åŠ è‡³æ¸¸æˆ";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "å–æ¶ˆ";
	}

	protected override string _GetTemplateForLabelError()
	{
		return "é”™è¯¯";
	}

	protected override string _GetTemplateForLabelErrorOccured()
	{
		return "å‘ç”Ÿé”™è¯¯ï¼Œè¯·é‡è¯•ã€‚";
	}

	protected override string _GetTemplateForLabelNotForSale()
	{
		return "æ­¤ç‰©å“ä¸ºéžå–å“ã€‚";
	}

	protected override string _GetTemplateForLabelOk()
	{
		return "å¥½";
	}

	protected override string _GetTemplateForLabelPromoteOnYourGame()
	{
		return "åœ¨ä½ çš„æ¸¸æˆä¸ŠæŽ¨å¹¿";
	}

	protected override string _GetTemplateForLabelRent()
	{
		return "ç§Ÿç”¨";
	}

	protected override string _GetTemplateForLabelSelectGroup()
	{
		return "é€‰æ‹©ç¾¤ç»„";
	}

	protected override string _GetTemplateForLabelSelectNone()
	{
		return "æ— ";
	}

	protected override string _GetTemplateForLabelSelectYourGame()
	{
		return "é€‰æ‹©ä½ çš„æ¸¸æˆ";
	}

	protected override string _GetTemplateForLabelSelectYourGameSemicolon()
	{
		return "é€‰æ‹©ä½ çš„æ¸¸æˆï¼š";
	}

	protected override string _GetTemplateForLabelSorryWeCouldnt()
	{
		return "æŠ±æ­‰ï¼Œæˆ‘ä»¬æ— æ³•ä»Žä½ çš„æ¸¸æˆä¸­ç§»é™¤æ­¤ç‰©å“ã€‚è¯·é‡è¯•ã€‚";
	}

	protected override string _GetTemplateForLabelSuccess()
	{
		return "æˆåŠŸï¼";
	}

	/// <summary>
	/// Key: "Message.WhatIsAddingGear"
	/// English String: "What is adding gear to a game? This item is displayed on your game page, and automatically allowed in your game. If someone buys this item from your game page, you'll earn {affiliateSaleTotal} Robux!"
	/// </summary>
	public override string MessageWhatIsAddingGear(string affiliateSaleTotal)
	{
		return $"åœ¨æ¸¸æˆä¸­æ·»åŠ è£…å¤‡ä¼šæ€Žä¹ˆæ ·ï¼Ÿè¯¥ç‰©å“å°†æ˜¾ç¤ºåœ¨ä½ çš„æ¸¸æˆé¡µé¢ï¼Œå¹¶è‡ªåŠ¨å…è®¸åœ¨æ¸¸æˆä¸­ä½¿ç”¨ã€‚å¦‚æžœæœ‰äººä»Žä½ çš„æ¸¸æˆé¡µé¢è´­ä¹°æ­¤ç‰©å“ï¼Œä½ å°±èƒ½èµšå– {affiliateSaleTotal} Robuxï¼";
	}

	protected override string _GetTemplateForMessageWhatIsAddingGear()
	{
		return "åœ¨æ¸¸æˆä¸­æ·»åŠ è£…å¤‡ä¼šæ€Žä¹ˆæ ·ï¼Ÿè¯¥ç‰©å“å°†æ˜¾ç¤ºåœ¨ä½ çš„æ¸¸æˆé¡µé¢ï¼Œå¹¶è‡ªåŠ¨å…è®¸åœ¨æ¸¸æˆä¸­ä½¿ç”¨ã€‚å¦‚æžœæœ‰äººä»Žä½ çš„æ¸¸æˆé¡µé¢è´­ä¹°æ­¤ç‰©å“ï¼Œä½ å°±èƒ½èµšå– {affiliateSaleTotal} Robuxï¼";
	}
}


}
