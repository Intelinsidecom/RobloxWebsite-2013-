namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides CreatePlaceProductPromotionResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CreatePlaceProductPromotionResources_ja_jp : CreatePlaceProductPromotionResources_en_us, ICreatePlaceProductPromotionResources, ITranslationResources
{
	/// <summary>
	/// Key: "Label.AddToGame"
	/// English String: "Add to Game"
	/// </summary>
	public override string LabelAddToGame => "ã‚²ãƒ¼ãƒ ã«è¿½åŠ ";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "ã‚­ãƒ£ãƒ³ã‚»ãƒ«";

	/// <summary>
	/// Key: "Label.Error"
	/// English String: "Error"
	/// </summary>
	public override string LabelError => "ã‚¨ãƒ©ãƒ¼";

	/// <summary>
	/// Key: "Label.ErrorOccured"
	/// English String: "An error occurred, please try again."
	/// </summary>
	public override string LabelErrorOccured => "ã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Label.NotForSale"
	/// English String: "This item is not for sale."
	/// </summary>
	public override string LabelNotForSale => "ã“ã®ã‚¢ã‚¤ãƒ†ãƒ ã¯å£²ã‚‰ã‚Œã¦ã„ã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Label.Ok"
	/// English String: "OK"
	/// </summary>
	public override string LabelOk => "OK";

	/// <summary>
	/// Key: "Label.PromoteOnYourGame"
	/// English String: "Promote on your Game"
	/// </summary>
	public override string LabelPromoteOnYourGame => "ã‚²ãƒ¼ãƒ ã‚’å®£ä¼ã™ã‚‹";

	/// <summary>
	/// Key: "Label.Rent"
	/// English String: "Rent"
	/// </summary>
	public override string LabelRent => "ãƒ¬ãƒ³ã‚¿ãƒ«";

	/// <summary>
	/// Key: "Label.SelectGroup"
	/// English String: "Select Group"
	/// </summary>
	public override string LabelSelectGroup => "ã‚°ãƒ«ãƒ¼ãƒ—ã‚’é¸æŠž";

	/// <summary>
	/// Key: "Label.SelectNone"
	/// English String: "None"
	/// </summary>
	public override string LabelSelectNone => "ãªã—";

	/// <summary>
	/// Key: "Label.SelectYourGame"
	/// English String: "Select Your Game"
	/// </summary>
	public override string LabelSelectYourGame => "ã‚²ãƒ¼ãƒ ã‚’é¸æŠžã™ã‚‹";

	/// <summary>
	/// Key: "Label.SelectYourGameSemicolon"
	/// English String: "Select Your Game:"
	/// </summary>
	public override string LabelSelectYourGameSemicolon => "ã‚²ãƒ¼ãƒ ã‚’é¸æŠž:";

	/// <summary>
	/// Key: "Label.SorryWeCouldnt"
	/// English String: "Sorry, we couldn't remove the item from your game. Please try again."
	/// </summary>
	public override string LabelSorryWeCouldnt => "ç”³ã—è¨³ã‚ã‚Šã¾ã›ã‚“ãŒã€ã‚²ãƒ¼ãƒ ã‹ã‚‰ã‚¢ã‚¤ãƒ†ãƒ ã‚’å‰Šé™¤ã§ãã¾ã›ã‚“ã§ã—ãŸã€‚ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Label.Success"
	/// English String: "Success!"
	/// </summary>
	public override string LabelSuccess => "æˆåŠŸï¼";

	public CreatePlaceProductPromotionResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelAddToGame()
	{
		return "ã‚²ãƒ¼ãƒ ã«è¿½åŠ ";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "ã‚­ãƒ£ãƒ³ã‚»ãƒ«";
	}

	protected override string _GetTemplateForLabelError()
	{
		return "ã‚¨ãƒ©ãƒ¼";
	}

	protected override string _GetTemplateForLabelErrorOccured()
	{
		return "ã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForLabelNotForSale()
	{
		return "ã“ã®ã‚¢ã‚¤ãƒ†ãƒ ã¯å£²ã‚‰ã‚Œã¦ã„ã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForLabelOk()
	{
		return "OK";
	}

	protected override string _GetTemplateForLabelPromoteOnYourGame()
	{
		return "ã‚²ãƒ¼ãƒ ã‚’å®£ä¼ã™ã‚‹";
	}

	protected override string _GetTemplateForLabelRent()
	{
		return "ãƒ¬ãƒ³ã‚¿ãƒ«";
	}

	protected override string _GetTemplateForLabelSelectGroup()
	{
		return "ã‚°ãƒ«ãƒ¼ãƒ—ã‚’é¸æŠž";
	}

	protected override string _GetTemplateForLabelSelectNone()
	{
		return "ãªã—";
	}

	protected override string _GetTemplateForLabelSelectYourGame()
	{
		return "ã‚²ãƒ¼ãƒ ã‚’é¸æŠžã™ã‚‹";
	}

	protected override string _GetTemplateForLabelSelectYourGameSemicolon()
	{
		return "ã‚²ãƒ¼ãƒ ã‚’é¸æŠž:";
	}

	protected override string _GetTemplateForLabelSorryWeCouldnt()
	{
		return "ç”³ã—è¨³ã‚ã‚Šã¾ã›ã‚“ãŒã€ã‚²ãƒ¼ãƒ ã‹ã‚‰ã‚¢ã‚¤ãƒ†ãƒ ã‚’å‰Šé™¤ã§ãã¾ã›ã‚“ã§ã—ãŸã€‚ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";
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
		return $"ã‚²ãƒ¼ãƒ ã«è¿½åŠ ã§ãã‚‹ã‚®ã‚¢ã‚’è¨­å®šã—ã¾ã™ã€‚ã“ã®ã‚¢ã‚¤ãƒ†ãƒ ã¯ã‚²ãƒ¼ãƒ ãƒšãƒ¼ã‚¸ã«è¡¨ç¤ºã•ã‚Œã€ã‚²ãƒ¼ãƒ å†…ã§è‡ªå‹•çš„ã«è¨±å¯ã•ã‚Œã¾ã™ã€‚èª°ã‹ãŒã‚²ãƒ¼ãƒ ãƒšãƒ¼ã‚¸ã§ã“ã®ã‚¢ã‚¤ãƒ†ãƒ ã‚’è²·ã†ã¨ã€{affiliateSaleTotal} RobuxãŒã‚‚ã‚‰ãˆã¾ã™ï¼";
	}

	protected override string _GetTemplateForMessageWhatIsAddingGear()
	{
		return "ã‚²ãƒ¼ãƒ ã«è¿½åŠ ã§ãã‚‹ã‚®ã‚¢ã‚’è¨­å®šã—ã¾ã™ã€‚ã“ã®ã‚¢ã‚¤ãƒ†ãƒ ã¯ã‚²ãƒ¼ãƒ ãƒšãƒ¼ã‚¸ã«è¡¨ç¤ºã•ã‚Œã€ã‚²ãƒ¼ãƒ å†…ã§è‡ªå‹•çš„ã«è¨±å¯ã•ã‚Œã¾ã™ã€‚èª°ã‹ãŒã‚²ãƒ¼ãƒ ãƒšãƒ¼ã‚¸ã§ã“ã®ã‚¢ã‚¤ãƒ†ãƒ ã‚’è²·ã†ã¨ã€{affiliateSaleTotal} RobuxãŒã‚‚ã‚‰ãˆã¾ã™ï¼";
	}
}


}
