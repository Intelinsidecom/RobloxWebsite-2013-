namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides LandingResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class LandingResources_zh_tw : LandingResources_en_us, ILandingResources, ITranslationResources
{
	/// <summary>
	/// Key: "Description.RobloxOnDeviceParagraphOne"
	/// first paragraph under Roblox on your device heading on landing page
	/// English String: "You can access Roblox on all modern smartphones, desktops, Xbox One, Oculus Rift, and soon on Daydream and Cardboard. Roblox adventures are accessible from any device, so players can imagine with their friends regardless of where they are."
	/// </summary>
	public override string DescriptionRobloxOnDeviceParagraphOne => "Roblox å¯ä»¥é€éŽæ‰€æœ‰ç¾ä»£æ™ºæ…§åž‹æ‰‹æ©Ÿã€é›»è…¦ã€Xbox One åŠ Oculus Rift éŠçŽ©ï¼Œæœªä¾†ä¹Ÿå°‡æ”¯æ´ Daydream å’Œ Cardboardã€‚æ‚¨å¯ä»¥å¾žä»¥ä¸Šè£ç½®é–‹å§‹æ‚¨çš„ Roblox æ—…ç¨‹ï¼ŒçŽ©å®¶éš¨æ™‚éš¨åœ°éƒ½å¯ä»¥å’Œå¥½å‹ç™¼æ®æƒ³åƒåŠ›ã€‚";

	/// <summary>
	/// Key: "Description.RobloxOnDeviceParagraphTwo"
	/// second paragraph under Roblox on Your Device on landing page
	/// English String: "You can access Roblox on PC, Mac, iOS, Android, Amazon Devices, and Xbox One. Roblox adventures are accessible from any device, so players can imagine with their friends regardless of where they are."
	/// </summary>
	public override string DescriptionRobloxOnDeviceParagraphTwo => "Roblox å¯ä»¥é€éŽé€éŽ PCã€Macã€iOSã€Androidã€Amazon è£ç½®åŠ Xbox One éŠçŽ©ã€‚æ‚¨å¯ä»¥å¾žä»¥ä¸Šè£ç½®é–‹å§‹æ‚¨çš„ Roblox æ—…ç¨‹ï¼ŒçŽ©å®¶éš¨æ™‚éš¨åœ°éƒ½å¯ä»¥å’Œå¥½å‹ç™¼æ®æƒ³åƒåŠ›ã€‚";

	/// <summary>
	/// Key: "Description.WhatIsRobloxParagraphOne"
	/// first paragraph under what's Roblox heading on landing page
	/// English String: "Roblox helps power the imagination of people around the world. As the largest growing social platform for play, over 44 million players come to Roblox every month to create adventures, play games, roleplay, and learn with friends. We call it the â€˜Imagination Platformâ€™ and believe everyone should have the right to play on it."
	/// </summary>
	public override string DescriptionWhatIsRobloxParagraphOne => "Roblox å¯ä»¥æ¿€ç™¼å…¨ä¸–ç•Œçš„äººçš„æƒ³åƒåŠ›ã€‚ä½œç‚ºæœ€é¾å¤§ä¸”æŒçºŒæˆé•·çš„ç¤¾äº¤å¹³å°ï¼Œæ¯å€‹æœˆæœ‰è¶…éŽ 4400 è¬åçŽ©å®¶åœ¨ Roblox ä¸€èµ·å‰µä½œã€éŠæ¨‚èˆ‡å­¸ç¿’ã€‚æˆ‘å€‘ç¨±ä¹‹ç‚ºã€Œæƒ³åƒåŠ›å¹³å°ã€ï¼Œä¸¦å …ä¿¡æ¯å€‹äººéƒ½æ‡‰è©²ä¾†æ­¤éŠçŽ©ã€‚";

	/// <summary>
	/// Key: "Heading.RobloxOnDevice"
	/// heading Roblox on your device
	/// English String: "Roblox on your Device"
	/// </summary>
	public override string HeadingRobloxOnDevice => "åœ¨æ‚¨çš„è£ç½®çŽ© Roblox";

	/// <summary>
	/// Key: "Heading.WhatIsRoblox"
	/// heading for what is Roblox section on the landing page
	/// English String: "What is Roblox?"
	/// </summary>
	public override string HeadingWhatIsRoblox => "Roblox æ˜¯ä»€éº¼ï¼Ÿ";

	/// <summary>
	/// Key: "Heading.WhatIsRobloxParagraphTwo"
	/// second paragraph under what's Roblox on the landing page
	/// English String: "Roblox is the best place to Imagine with Friends. With the largest user-generated online gaming platform, and over 15 million games created by users, Roblox is the #1 gaming site for kids and teens (comScore). Every day, virtual explorers come to Roblox to create adventures, play games, role play, and learn with their friends in a family-friendly, immersive, 3D environment."
	/// </summary>
	public override string HeadingWhatIsRobloxParagraphTwo => "Roblox æ˜¯èˆ‡æœ‹å‹ç™¼æ®æƒ³åƒåŠ›çš„æœ€ä½³å ´æ‰€ã€‚ä½œç‚ºæœ€å¤§çš„ä½¿ç”¨è€…å‰µä½œç·šä¸ŠéŠæˆ²å¹³å°ï¼ŒRoblox æ“æœ‰è¶…éŽ 1500 è¬æ¬¾å…¨ç”±ä½¿ç”¨è€…å‰µä½œçš„éŠæˆ²ï¼Œé€™ä¹Ÿä½¿å¾—ç¾Žåœ‹å…¬å¸ comScore èªè­‰ Roblox ç‚ºå…’ç«¥åŠé’å°‘å¹´éŠæˆ²ç¶²ç«™çš„é¦–é¸ã€‚æ¯å¤©éƒ½æœ‰è™›æ“¬æŽ¢éšªå®¶å‰å¾€ Roblox è€å°‘å’¸å®œã€èº«æ­·å…¶å¢ƒçš„ 3D ç’°å¢ƒä¸€èµ·å‰µä½œã€éŠæ¨‚èˆ‡å­¸ç¿’ã€‚";

	/// <summary>
	/// Key: "Label.About"
	/// about link on top left
	/// English String: "About"
	/// </summary>
	public override string LabelAbout => "ä»‹ç´¹";

	/// <summary>
	/// Key: "Label.GetOnGooglePlay"
	/// Google play icon title
	/// English String: "Get it on Google Play"
	/// </summary>
	public override string LabelGetOnGooglePlay => "å¾ž Google Play å–å¾—";

	/// <summary>
	/// Key: "Label.Platforms"
	/// platform link on top left
	/// English String: "Platforms"
	/// </summary>
	public override string LabelPlatforms => "å¹³å°";

	/// <summary>
	/// Key: "Label.Play"
	/// play link on top left
	/// English String: "Play"
	/// </summary>
	public override string LabelPlay => "éŠæˆ²";

	/// <summary>
	/// Key: "Label.RobloxAmazonStore"
	/// title for Amazon store icon
	/// English String: "Roblox on Amazon Store"
	/// </summary>
	public override string LabelRobloxAmazonStore => "Amazon å•†åº—ä¸Šçš„ Roblox";

	/// <summary>
	/// Key: "Label.RobloxAppStore"
	/// the title for app store icon
	/// English String: "Roblox on App Store"
	/// </summary>
	public override string LabelRobloxAppStore => "App Store ä¸Šçš„ Roblox";

	/// <summary>
	/// Key: "Label.RobloxOnXbox"
	/// title for Xbox icon
	/// English String: "Roblox on Xbox Store"
	/// </summary>
	public override string LabelRobloxOnXbox => "Xbox Store ä¸Šçš„ Roblox";

	/// <summary>
	/// Key: "Label.RobloxWindowsStore"
	/// title for windows store icon
	/// English String: "Roblox on Windows Store"
	/// </summary>
	public override string LabelRobloxWindowsStore => "Windows Store ä¸Šçš„ Roblox";

	public LandingResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForDescriptionRobloxOnDeviceParagraphOne()
	{
		return "Roblox å¯ä»¥é€éŽæ‰€æœ‰ç¾ä»£æ™ºæ…§åž‹æ‰‹æ©Ÿã€é›»è…¦ã€Xbox One åŠ Oculus Rift éŠçŽ©ï¼Œæœªä¾†ä¹Ÿå°‡æ”¯æ´ Daydream å’Œ Cardboardã€‚æ‚¨å¯ä»¥å¾žä»¥ä¸Šè£ç½®é–‹å§‹æ‚¨çš„ Roblox æ—…ç¨‹ï¼ŒçŽ©å®¶éš¨æ™‚éš¨åœ°éƒ½å¯ä»¥å’Œå¥½å‹ç™¼æ®æƒ³åƒåŠ›ã€‚";
	}

	protected override string _GetTemplateForDescriptionRobloxOnDeviceParagraphTwo()
	{
		return "Roblox å¯ä»¥é€éŽé€éŽ PCã€Macã€iOSã€Androidã€Amazon è£ç½®åŠ Xbox One éŠçŽ©ã€‚æ‚¨å¯ä»¥å¾žä»¥ä¸Šè£ç½®é–‹å§‹æ‚¨çš„ Roblox æ—…ç¨‹ï¼ŒçŽ©å®¶éš¨æ™‚éš¨åœ°éƒ½å¯ä»¥å’Œå¥½å‹ç™¼æ®æƒ³åƒåŠ›ã€‚";
	}

	protected override string _GetTemplateForDescriptionWhatIsRobloxParagraphOne()
	{
		return "Roblox å¯ä»¥æ¿€ç™¼å…¨ä¸–ç•Œçš„äººçš„æƒ³åƒåŠ›ã€‚ä½œç‚ºæœ€é¾å¤§ä¸”æŒçºŒæˆé•·çš„ç¤¾äº¤å¹³å°ï¼Œæ¯å€‹æœˆæœ‰è¶…éŽ 4400 è¬åçŽ©å®¶åœ¨ Roblox ä¸€èµ·å‰µä½œã€éŠæ¨‚èˆ‡å­¸ç¿’ã€‚æˆ‘å€‘ç¨±ä¹‹ç‚ºã€Œæƒ³åƒåŠ›å¹³å°ã€ï¼Œä¸¦å …ä¿¡æ¯å€‹äººéƒ½æ‡‰è©²ä¾†æ­¤éŠçŽ©ã€‚";
	}

	protected override string _GetTemplateForHeadingRobloxOnDevice()
	{
		return "åœ¨æ‚¨çš„è£ç½®çŽ© Roblox";
	}

	protected override string _GetTemplateForHeadingWhatIsRoblox()
	{
		return "Roblox æ˜¯ä»€éº¼ï¼Ÿ";
	}

	protected override string _GetTemplateForHeadingWhatIsRobloxParagraphTwo()
	{
		return "Roblox æ˜¯èˆ‡æœ‹å‹ç™¼æ®æƒ³åƒåŠ›çš„æœ€ä½³å ´æ‰€ã€‚ä½œç‚ºæœ€å¤§çš„ä½¿ç”¨è€…å‰µä½œç·šä¸ŠéŠæˆ²å¹³å°ï¼ŒRoblox æ“æœ‰è¶…éŽ 1500 è¬æ¬¾å…¨ç”±ä½¿ç”¨è€…å‰µä½œçš„éŠæˆ²ï¼Œé€™ä¹Ÿä½¿å¾—ç¾Žåœ‹å…¬å¸ comScore èªè­‰ Roblox ç‚ºå…’ç«¥åŠé’å°‘å¹´éŠæˆ²ç¶²ç«™çš„é¦–é¸ã€‚æ¯å¤©éƒ½æœ‰è™›æ“¬æŽ¢éšªå®¶å‰å¾€ Roblox è€å°‘å’¸å®œã€èº«æ­·å…¶å¢ƒçš„ 3D ç’°å¢ƒä¸€èµ·å‰µä½œã€éŠæ¨‚èˆ‡å­¸ç¿’ã€‚";
	}

	protected override string _GetTemplateForLabelAbout()
	{
		return "ä»‹ç´¹";
	}

	protected override string _GetTemplateForLabelGetOnGooglePlay()
	{
		return "å¾ž Google Play å–å¾—";
	}

	protected override string _GetTemplateForLabelPlatforms()
	{
		return "å¹³å°";
	}

	protected override string _GetTemplateForLabelPlay()
	{
		return "éŠæˆ²";
	}

	protected override string _GetTemplateForLabelRobloxAmazonStore()
	{
		return "Amazon å•†åº—ä¸Šçš„ Roblox";
	}

	protected override string _GetTemplateForLabelRobloxAppStore()
	{
		return "App Store ä¸Šçš„ Roblox";
	}

	protected override string _GetTemplateForLabelRobloxOnXbox()
	{
		return "Xbox Store ä¸Šçš„ Roblox";
	}

	protected override string _GetTemplateForLabelRobloxWindowsStore()
	{
		return "Windows Store ä¸Šçš„ Roblox";
	}
}


}
