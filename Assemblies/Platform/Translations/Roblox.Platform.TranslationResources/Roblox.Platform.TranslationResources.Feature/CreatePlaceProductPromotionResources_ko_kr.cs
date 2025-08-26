namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides CreatePlaceProductPromotionResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CreatePlaceProductPromotionResources_ko_kr : CreatePlaceProductPromotionResources_en_us, ICreatePlaceProductPromotionResources, ITranslationResources
{
	/// <summary>
	/// Key: "Label.AddToGame"
	/// English String: "Add to Game"
	/// </summary>
	public override string LabelAddToGame => "ê²Œìž„ì— ì¶”ê°€";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "ì·¨ì†Œ";

	/// <summary>
	/// Key: "Label.Error"
	/// English String: "Error"
	/// </summary>
	public override string LabelError => "ì˜¤ë¥˜";

	/// <summary>
	/// Key: "Label.ErrorOccured"
	/// English String: "An error occurred, please try again."
	/// </summary>
	public override string LabelErrorOccured => "ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”. ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Label.NotForSale"
	/// English String: "This item is not for sale."
	/// </summary>
	public override string LabelNotForSale => "íŒë§¤ ì¤‘ì¸ ì•„ì´í…œì´ ì•„ë‹™ë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Label.Ok"
	/// English String: "OK"
	/// </summary>
	public override string LabelOk => "í™•ì¸";

	/// <summary>
	/// Key: "Label.PromoteOnYourGame"
	/// English String: "Promote on your Game"
	/// </summary>
	public override string LabelPromoteOnYourGame => "íšŒì›ë‹˜ì˜ ê²Œìž„ì—ì„œ í™ë³´í•˜ê¸°";

	/// <summary>
	/// Key: "Label.Rent"
	/// English String: "Rent"
	/// </summary>
	public override string LabelRent => "ë¹Œë¦¬ê¸°";

	/// <summary>
	/// Key: "Label.SelectGroup"
	/// English String: "Select Group"
	/// </summary>
	public override string LabelSelectGroup => "ê·¸ë£¹ ì„ íƒ";

	/// <summary>
	/// Key: "Label.SelectNone"
	/// English String: "None"
	/// </summary>
	public override string LabelSelectNone => "ì—†ìŒ";

	/// <summary>
	/// Key: "Label.SelectYourGame"
	/// English String: "Select Your Game"
	/// </summary>
	public override string LabelSelectYourGame => "ê²Œìž„ ì„ íƒ";

	/// <summary>
	/// Key: "Label.SelectYourGameSemicolon"
	/// English String: "Select Your Game:"
	/// </summary>
	public override string LabelSelectYourGameSemicolon => "ê²Œìž„ ì„ íƒ:";

	/// <summary>
	/// Key: "Label.SorryWeCouldnt"
	/// English String: "Sorry, we couldn't remove the item from your game. Please try again."
	/// </summary>
	public override string LabelSorryWeCouldnt => "ì£„ì†¡í•©ë‹ˆë‹¤. í•´ë‹¹ ì•„ì´í…œì„ ê²Œìž„ì—ì„œ ì‚­ì œí•  ìˆ˜ ì—†ì–´ìš”. ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Label.Success"
	/// English String: "Success!"
	/// </summary>
	public override string LabelSuccess => "ì™„ë£Œ!";

	public CreatePlaceProductPromotionResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelAddToGame()
	{
		return "ê²Œìž„ì— ì¶”ê°€";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "ì·¨ì†Œ";
	}

	protected override string _GetTemplateForLabelError()
	{
		return "ì˜¤ë¥˜";
	}

	protected override string _GetTemplateForLabelErrorOccured()
	{
		return "ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”. ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForLabelNotForSale()
	{
		return "íŒë§¤ ì¤‘ì¸ ì•„ì´í…œì´ ì•„ë‹™ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForLabelOk()
	{
		return "í™•ì¸";
	}

	protected override string _GetTemplateForLabelPromoteOnYourGame()
	{
		return "íšŒì›ë‹˜ì˜ ê²Œìž„ì—ì„œ í™ë³´í•˜ê¸°";
	}

	protected override string _GetTemplateForLabelRent()
	{
		return "ë¹Œë¦¬ê¸°";
	}

	protected override string _GetTemplateForLabelSelectGroup()
	{
		return "ê·¸ë£¹ ì„ íƒ";
	}

	protected override string _GetTemplateForLabelSelectNone()
	{
		return "ì—†ìŒ";
	}

	protected override string _GetTemplateForLabelSelectYourGame()
	{
		return "ê²Œìž„ ì„ íƒ";
	}

	protected override string _GetTemplateForLabelSelectYourGameSemicolon()
	{
		return "ê²Œìž„ ì„ íƒ:";
	}

	protected override string _GetTemplateForLabelSorryWeCouldnt()
	{
		return "ì£„ì†¡í•©ë‹ˆë‹¤. í•´ë‹¹ ì•„ì´í…œì„ ê²Œìž„ì—ì„œ ì‚­ì œí•  ìˆ˜ ì—†ì–´ìš”. ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForLabelSuccess()
	{
		return "ì™„ë£Œ!";
	}

	/// <summary>
	/// Key: "Message.WhatIsAddingGear"
	/// English String: "What is adding gear to a game? This item is displayed on your game page, and automatically allowed in your game. If someone buys this item from your game page, you'll earn {affiliateSaleTotal} Robux!"
	/// </summary>
	public override string MessageWhatIsAddingGear(string affiliateSaleTotal)
	{
		return $"ê²Œìž„ì— ìž¥ë¹„ë¥¼ ì¶”ê°€í•˜ë©´, ì¶”ê°€í•œ ìž¥ë¹„ëŠ” ê²Œìž„ íŽ˜ì´ì§€ì— í‘œì‹œë˜ê³  ìžë™ì ìœ¼ë¡œ ê²Œìž„ì—ì„œ ì‚¬ìš©í•  ìˆ˜ ìžˆìŠµë‹ˆë‹¤. ëˆ„êµ°ê°€ íšŒì›ë‹˜ì˜ ê²Œìž„ íŽ˜ì´ì§€ì—ì„œ ë³¸ ìž¥ë¹„ë¥¼ êµ¬ìž…í•˜ë©´ íšŒì›ë‹˜ì€ {affiliateSaleTotal} Robuxë¥¼ íšë“í•  ìˆ˜ ìžˆì–´ìš”!";
	}

	protected override string _GetTemplateForMessageWhatIsAddingGear()
	{
		return "ê²Œìž„ì— ìž¥ë¹„ë¥¼ ì¶”ê°€í•˜ë©´, ì¶”ê°€í•œ ìž¥ë¹„ëŠ” ê²Œìž„ íŽ˜ì´ì§€ì— í‘œì‹œë˜ê³  ìžë™ì ìœ¼ë¡œ ê²Œìž„ì—ì„œ ì‚¬ìš©í•  ìˆ˜ ìžˆìŠµë‹ˆë‹¤. ëˆ„êµ°ê°€ íšŒì›ë‹˜ì˜ ê²Œìž„ íŽ˜ì´ì§€ì—ì„œ ë³¸ ìž¥ë¹„ë¥¼ êµ¬ìž…í•˜ë©´ íšŒì›ë‹˜ì€ {affiliateSaleTotal} Robuxë¥¼ íšë“í•  ìˆ˜ ìžˆì–´ìš”!";
	}
}


}
