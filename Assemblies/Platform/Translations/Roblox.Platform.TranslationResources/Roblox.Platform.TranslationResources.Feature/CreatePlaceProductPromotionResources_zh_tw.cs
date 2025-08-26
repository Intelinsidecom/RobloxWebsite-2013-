namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string LabelAddToGame => "åŠ åˆ°éŠæˆ²";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "å–æ¶ˆ";

	/// <summary>
	/// Key: "Label.Error"
	/// English String: "Error"
	/// </summary>
	public override string LabelError => "éŒ¯èª¤";

	/// <summary>
	/// Key: "Label.ErrorOccured"
	/// English String: "An error occurred, please try again."
	/// </summary>
	public override string LabelErrorOccured => "ç™¼ç”ŸéŒ¯èª¤ï¼Œè«‹é‡æ–°å˜—è©¦ã€‚";

	/// <summary>
	/// Key: "Label.NotForSale"
	/// English String: "This item is not for sale."
	/// </summary>
	public override string LabelNotForSale => "æ­¤é“å…·ç‚ºéžè³£å“ã€‚";

	/// <summary>
	/// Key: "Label.Ok"
	/// English String: "OK"
	/// </summary>
	public override string LabelOk => "ç¢ºå®š";

	/// <summary>
	/// Key: "Label.PromoteOnYourGame"
	/// English String: "Promote on your Game"
	/// </summary>
	public override string LabelPromoteOnYourGame => "åœ¨æ‚¨çš„éŠæˆ²ä¸ŠæŽ¨å»£";

	/// <summary>
	/// Key: "Label.Rent"
	/// English String: "Rent"
	/// </summary>
	public override string LabelRent => "ç§Ÿç”¨";

	/// <summary>
	/// Key: "Label.SelectGroup"
	/// English String: "Select Group"
	/// </summary>
	public override string LabelSelectGroup => "é¸æ“‡ç¾¤çµ„";

	/// <summary>
	/// Key: "Label.SelectNone"
	/// English String: "None"
	/// </summary>
	public override string LabelSelectNone => "ç„¡";

	/// <summary>
	/// Key: "Label.SelectYourGame"
	/// English String: "Select Your Game"
	/// </summary>
	public override string LabelSelectYourGame => "é¸æ“‡æ‚¨çš„éŠæˆ²";

	/// <summary>
	/// Key: "Label.SelectYourGameSemicolon"
	/// English String: "Select Your Game:"
	/// </summary>
	public override string LabelSelectYourGameSemicolon => "é¸æ“‡æ‚¨çš„éŠæˆ²ï¼š";

	/// <summary>
	/// Key: "Label.SorryWeCouldnt"
	/// English String: "Sorry, we couldn't remove the item from your game. Please try again."
	/// </summary>
	public override string LabelSorryWeCouldnt => "å°ä¸èµ·ï¼Œç„¡æ³•å¾žæ‚¨çš„éŠæˆ²ç§»é™¤æ­¤é“å…·ï¼Œè«‹é‡æ–°å˜—è©¦ã€‚";

	/// <summary>
	/// Key: "Label.Success"
	/// English String: "Success!"
	/// </summary>
	public override string LabelSuccess => "æˆåŠŸï¼";

	public CreatePlaceProductPromotionResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelAddToGame()
	{
		return "åŠ åˆ°éŠæˆ²";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "å–æ¶ˆ";
	}

	protected override string _GetTemplateForLabelError()
	{
		return "éŒ¯èª¤";
	}

	protected override string _GetTemplateForLabelErrorOccured()
	{
		return "ç™¼ç”ŸéŒ¯èª¤ï¼Œè«‹é‡æ–°å˜—è©¦ã€‚";
	}

	protected override string _GetTemplateForLabelNotForSale()
	{
		return "æ­¤é“å…·ç‚ºéžè³£å“ã€‚";
	}

	protected override string _GetTemplateForLabelOk()
	{
		return "ç¢ºå®š";
	}

	protected override string _GetTemplateForLabelPromoteOnYourGame()
	{
		return "åœ¨æ‚¨çš„éŠæˆ²ä¸ŠæŽ¨å»£";
	}

	protected override string _GetTemplateForLabelRent()
	{
		return "ç§Ÿç”¨";
	}

	protected override string _GetTemplateForLabelSelectGroup()
	{
		return "é¸æ“‡ç¾¤çµ„";
	}

	protected override string _GetTemplateForLabelSelectNone()
	{
		return "ç„¡";
	}

	protected override string _GetTemplateForLabelSelectYourGame()
	{
		return "é¸æ“‡æ‚¨çš„éŠæˆ²";
	}

	protected override string _GetTemplateForLabelSelectYourGameSemicolon()
	{
		return "é¸æ“‡æ‚¨çš„éŠæˆ²ï¼š";
	}

	protected override string _GetTemplateForLabelSorryWeCouldnt()
	{
		return "å°ä¸èµ·ï¼Œç„¡æ³•å¾žæ‚¨çš„éŠæˆ²ç§»é™¤æ­¤é“å…·ï¼Œè«‹é‡æ–°å˜—è©¦ã€‚";
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
		return $"åœ¨éŠæˆ²è£¡åŠ å…¥è£å‚™æœƒæ€Žéº¼æ¨£ï¼Ÿè©²é“å…·æœƒé¡¯ç¤ºåœ¨æ‚¨çš„éŠæˆ²é é¢ï¼Œä¸¦ä¸”è‡ªå‹•å…è¨±åœ¨éŠæˆ²ä¸­ä½¿ç”¨ã€‚è‹¥æœ‰äººå¾žæ‚¨çš„éŠæˆ²é é¢è³¼è²·æ­¤é“å…·ï¼Œæ‚¨é‚„èƒ½è³ºå– {affiliateSaleTotal} Robuxï¼";
	}

	protected override string _GetTemplateForMessageWhatIsAddingGear()
	{
		return "åœ¨éŠæˆ²è£¡åŠ å…¥è£å‚™æœƒæ€Žéº¼æ¨£ï¼Ÿè©²é“å…·æœƒé¡¯ç¤ºåœ¨æ‚¨çš„éŠæˆ²é é¢ï¼Œä¸¦ä¸”è‡ªå‹•å…è¨±åœ¨éŠæˆ²ä¸­ä½¿ç”¨ã€‚è‹¥æœ‰äººå¾žæ‚¨çš„éŠæˆ²é é¢è³¼è²·æ­¤é“å…·ï¼Œæ‚¨é‚„èƒ½è³ºå– {affiliateSaleTotal} Robuxï¼";
	}
}


}
