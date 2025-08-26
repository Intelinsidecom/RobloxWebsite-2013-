namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides DevelopLandingResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class DevelopLandingResources_ja_jp : DevelopLandingResources_en_us, IDevelopLandingResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.ManageMyGames"
	/// button label
	/// English String: "Manage my games"
	/// </summary>
	public override string ActionManageMyGames => "ãƒžã‚¤ã‚²ãƒ¼ãƒ ã®ç®¡ç†";

	/// <summary>
	/// Key: "Action.RobloxDevHub"
	/// English String: "Continue to the Developer Hub"
	/// </summary>
	public override string ActionRobloxDevHub => "ãƒ‡ãƒ™ãƒ­ãƒƒãƒ‘ãƒ¼ãƒãƒ–ã¸";

	/// <summary>
	/// Key: "Action.RobloxWiki"
	/// button label
	/// English String: "Continue to Roblox Wiki"
	/// </summary>
	public override string ActionRobloxWiki => "Roblox Wiki ã«ç§»å‹•ã™ã‚‹";

	/// <summary>
	/// Key: "Action.StartCreating"
	/// button label
	/// English String: "Start Creating"
	/// </summary>
	public override string ActionStartCreating => "åˆ¶ä½œã‚’é–‹å§‹";

	/// <summary>
	/// Key: "Description.EarnSeriousCash"
	/// description
	/// English String: "Creators like you are getting paid for what they love to do. Our top developers are earning over $2M a year by providing in-game purchases"
	/// </summary>
	public override string DescriptionEarnSeriousCash => "ã‚ãªãŸã®ã‚ˆã†ãªã‚²ãƒ¼ãƒ ã‚¯ãƒªã‚¨ãƒ¼ã‚¿ãƒ¼ãŒã€è¶£å‘³ã‚’ãŠé‡‘ã«å¤‰ãˆã¦ã„ã¾ã™ã€‚ãƒˆãƒƒãƒ—ã‚¯ãƒ©ã‚¹ã®é–‹ç™ºè€…ã¯ã€ã‚²ãƒ¼ãƒ å†…èª²é‡‘ã«ã‚ˆã£ã¦å¹´é–“$200ä¸‡ä»¥ä¸Šã‚’ç¨¼ã„ã§ã„ã¾ã™";

	/// <summary>
	/// Key: "Description.FreeImmersiveCreationEngine"
	/// subtext
	/// English String: "With our FREE and immersive creation engine"
	/// </summary>
	public override string DescriptionFreeImmersiveCreationEngine => "ç„¡æ–™ã§åˆ©ç”¨ã§ãã‚‹æ²¡å…¥åž‹ã‚²ãƒ¼ãƒ åˆ¶ä½œã‚¨ãƒ³ã‚¸ãƒ³";

	/// <summary>
	/// Key: "Description.MakeAnything"
	/// text paragraph on page
	/// English String: "Roblox Studio lets you create anything and release with one click to smartphones, tablets, desktops, consoles, and virtual reality devices"
	/// </summary>
	public override string DescriptionMakeAnything => "Roblox Studioã‚’ä½¿ãˆã°ä½•ã§ã‚‚åˆ¶ä½œã§ãã¦ã€ãƒ¯ãƒ³ã‚¯ãƒªãƒƒã‚¯ã§ã‚¹ãƒžãƒ¼ãƒˆãƒ•ã‚©ãƒ³ã€ã‚¿ãƒ–ãƒ¬ãƒƒãƒˆã€ã‚²ãƒ¼ãƒ ã‚³ãƒ³ã‚½ãƒ¼ãƒ«ã€VRãƒ‡ãƒã‚¤ã‚¹ã§å…¬é–‹ã™ã‚‹ã“ã¨ãŒã§ãã¾ã™";

	/// <summary>
	/// Key: "Description.ReachMillionsPlayers"
	/// description
	/// English String: "Connect with a massive audience by tapping into an incredibly enthusiastic and international community of over 50 million monthly players"
	/// </summary>
	public override string DescriptionReachMillionsPlayers => "æœˆé–“5000ä¸‡äººä»¥ä¸Šã®ç†±å¿ƒãªãƒ—ãƒ¬ã‚¤ãƒ¤ãƒ¼ãŸã¡ãŒå‚åŠ ã—ã¦ã„ã‚‹ä¸–ç•Œçš„ãªã‚³ãƒŸãƒ¥ãƒ‹ãƒ†ã‚£ã‚’ä½¿ã£ã¦ã€ãŸãã•ã‚“ã®äººã¨ã¤ãªãŒã‚ã†";

	/// <summary>
	/// Key: "Description.RobloxDevHub"
	/// English String: "The Developer Hub is your one-stop shop for publishing on Roblox. Learn from a wide set of tutorials, connect with other developers, get platform updates, browse our API references, and much more."
	/// </summary>
	public override string DescriptionRobloxDevHub => "ãƒ‡ãƒ™ãƒ­ãƒƒãƒ‘ãƒ¼ãƒãƒ–ã¯ã€Robloxã§ä½œå“å…¬é–‹ã™ã‚‹ã®ã«å½¹ç«‹ã¤æ©Ÿèƒ½ãŒä¸€ãƒ¶æ‰€ã«ã™ã¹ã¦é›†ã¾ã£ãŸå ´æ‰€ã§ã™ã€‚åºƒç¯„ãªãƒãƒ¥ãƒ¼ãƒˆãƒªã‚¢ãƒ«ã§å­¦ã‚“ã ã‚Šã€ä»–ã®é–‹ç™ºè€…ã¨äº¤æµã—ãŸã‚Šã€ãƒ—ãƒ©ãƒƒãƒˆãƒ•ã‚©ãƒ¼ãƒ ã®ã‚¢ãƒƒãƒ—ãƒ‡ãƒ¼ãƒˆã‚’ã—ãŸã‚Šã€APIãƒªãƒ•ã‚¡ãƒ¬ãƒ³ã‚¹ã‚’è¦‹ãŸã‚Šã€ä»–ã«ã‚‚ç››ã‚Šã ãã•ã‚“ã§ã™ã€‚";

	/// <summary>
	/// Key: "Description.RobloxWiki"
	/// description
	/// English String: "The Roblox Wiki is the ultimate resource for documentation, tutorials, and samples which will help you learn to make games with Roblox Studio"
	/// </summary>
	public override string DescriptionRobloxWiki => "Roblox Wikiã§ã¯ã€è§£èª¬æ›¸ã€ãƒãƒ¥ãƒ¼ãƒˆãƒªã‚¢ãƒ«ã€ã‚µãƒ³ãƒ—ãƒ«ãªã©ã€ã‚ã‚‰ã‚†ã‚‹ã‚‚ã®ã«ã‚¢ã‚¯ã‚»ã‚¹ã™ã‚‹ã“ã¨ãŒã§ãã¾ã™ã€‚Roblox Studioã«ã‚ˆã‚‹ã‚²ãƒ¼ãƒ é–‹ç™ºã«å½¹ç«‹ã¦ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Description.TestimonialAlexBalfanz"
	/// testimonial
	/// English String: "Roblox was so easy to get into. You can have a whole career on it because itâ€™s such a hot platform and the team there is always providing great resources for developers."
	/// </summary>
	public override string DescriptionTestimonialAlexBalfanz => "Robloxã¯ã€ç°¡å˜ã«ä½¿ã„ã“ãªã™ã“ã¨ãŒã§ãã¾ã—ãŸã€‚æœ€å…ˆç«¯ã®ãƒ—ãƒ©ãƒƒãƒˆãƒ•ã‚©ãƒ¼ãƒ ãªã®ã§ã€ã‚ã‚‰ã‚†ã‚‹çµŒé¨“ã‚’ã¤ãŽè¾¼ã‚€ã“ã¨ãŒã§ãã¾ã™ã€‚ã¾ãŸã€Robloxãƒãƒ¼ãƒ ã¯ã€ã„ã¤ã‚‚ç´ æ™´ã‚‰ã—ã„é–‹ç™ºè€…ç”¨ãƒªã‚½ãƒ¼ã‚¹ã‚’æä¾›ã—ã¦ãã‚Œã¾ã™ã€‚";

	/// <summary>
	/// Key: "Description.TestimonialAndrewBereza"
	/// testimonial text
	/// English String: "Roblox allows me to focus on my game development and potential future career without having to worry about the financial hardships of being a college student."
	/// </summary>
	public override string DescriptionTestimonialAndrewBereza => "Robloxã®ãŠã‹ã’ã§ã€å¤§å­¦ç”Ÿã¨ã—ã¦ã®çµŒæ¸ˆçš„ãªå•é¡Œã‚’å¿ƒé…ã›ãšã«ã€ã‚²ãƒ¼ãƒ é–‹ç™ºã‚„å°†æ¥ã®ã‚­ãƒ£ãƒªã‚¢ã«ã¤ãªãŒã‚‹å¯èƒ½æ€§ãŒã‚ã‚‹ã“ã¨ã«é›†ä¸­ã§ãã¦ã„ã¾ã™ã€‚";

	/// <summary>
	/// Key: "Description.TestimonialJacksonMunsell"
	/// testimonial
	/// English String: "I enjoy creating games on Roblox because itâ€™s social. It takes the socialization of platforms like Facebook to a new level with the games and creativity of the community."
	/// </summary>
	public override string DescriptionTestimonialJacksonMunsell => "Robloxã§ã®ã‚²ãƒ¼ãƒ åˆ¶ä½œãŒæ¥½ã—ã„ã®ã¯ã€äººã¨äº¤æµã—ãªãŒã‚‰ã§ãã‚‹ã‹ã‚‰ã§ã™ã€‚ã‚²ãƒ¼ãƒ ã¨ã‚³ãƒŸãƒ¥ãƒ‹ãƒ†ã‚£ã®å‰µé€ åŠ›ã‚’æ–°ã—ã„å¢ƒåœ°ã«å¼•ãä¸Šã’ã‚‹ã«ã¯ã€Facebookã®ã‚ˆã†ãªãƒ—ãƒ©ãƒƒãƒˆãƒ•ã‚©ãƒ¼ãƒ ã®SNSçš„ãªè¦ç´ ãŒå¿…è¦ã§ã™ã€‚";

	/// <summary>
	/// Key: "Description.TestimonialOne"
	/// testimonial content
	/// English String: "Roblox allows me to focus on my game development and potential future career without having to worry about the financial hardships of being a college student."
	/// </summary>
	public override string DescriptionTestimonialOne => "Robloxã®ãŠã‹ã’ã§ã€å¤§å­¦ç”Ÿã¨ã—ã¦ã®çµŒæ¸ˆçš„ãªå•é¡Œã‚’å¿ƒé…ã›ãšã«ã€ã‚²ãƒ¼ãƒ é–‹ç™ºã‚„å°†æ¥ã®ã‚­ãƒ£ãƒªã‚¢ã«ã¤ãªãŒã‚‹å¯èƒ½æ€§ãŒã‚ã‚‹ã“ã¨ã«é›†ä¸­ã§ãã¦ã„ã¾ã™ã€‚";

	/// <summary>
	/// Key: "Description.TestimonialThree"
	/// testimonial text
	/// English String: "Roblox was so easy to get into. You can have a whole career on it because itâ€™s such a hot platform and the team there is always providing great resources for developers."
	/// </summary>
	public override string DescriptionTestimonialThree => "Robloxã¯ã€ç°¡å˜ã«ä½¿ã„ã“ãªã™ã“ã¨ãŒã§ãã¾ã—ãŸã€‚æœ€å…ˆç«¯ã®ãƒ—ãƒ©ãƒƒãƒˆãƒ•ã‚©ãƒ¼ãƒ ãªã®ã§ã€ã‚ã‚‰ã‚†ã‚‹çµŒé¨“ã‚’ã¤ãŽè¾¼ã‚€ã“ã¨ãŒã§ãã¾ã™ã€‚ã¾ãŸã€Robloxãƒãƒ¼ãƒ ã¯ã€ã„ã¤ã‚‚ç´ æ™´ã‚‰ã—ã„é–‹ç™ºè€…ç”¨ãƒªã‚½ãƒ¼ã‚¹ã‚’æä¾›ã—ã¦ãã‚Œã¾ã™ã€‚";

	/// <summary>
	/// Key: "Description.TestimonialTwo"
	/// description
	/// English String: "I enjoy creating games on Roblox because itâ€™s social. It takes the socialization of platforms like Facebook to a new level with the games and creativity of the community."
	/// </summary>
	public override string DescriptionTestimonialTwo => "Robloxã§ã®ã‚²ãƒ¼ãƒ åˆ¶ä½œãŒæ¥½ã—ã„ã®ã¯ã€äººã¨äº¤æµã—ãªãŒã‚‰ã§ãã‚‹ã‹ã‚‰ã§ã™ã€‚ã‚²ãƒ¼ãƒ ã¨ã‚³ãƒŸãƒ¥ãƒ‹ãƒ†ã‚£ã®å‰µé€ åŠ›ã‚’æ–°ã—ã„å¢ƒåœ°ã«å¼•ãä¸Šã’ã‚‹ã«ã¯ã€Facebookã®ã‚ˆã†ãªãƒ—ãƒ©ãƒƒãƒˆãƒ•ã‚©ãƒ¼ãƒ ã®SNSçš„ãªè¦ç´ ãŒå¿…è¦ã§ã™ã€‚";

	/// <summary>
	/// Key: "Heading.EarnSeriousCash"
	/// heading
	/// English String: "Earn Serious Cash"
	/// </summary>
	public override string HeadingEarnSeriousCash => "å®Ÿéš›ã«ç¾é‡‘ã‚’ç¨¼ã";

	/// <summary>
	/// Key: "Heading.MakeAnything"
	/// heading
	/// English String: "Make Anything You Can Imagine"
	/// </summary>
	public override string HeadingMakeAnything => "æƒ³åƒã§ãã‚‹ã‚‚ã®ã‚’ä½•ã§ã‚‚ä½œã£ã¡ã‚ƒãŠã†";

	/// <summary>
	/// Key: "Heading.MakeAnythingSub"
	/// section heading
	/// English String: "Make Anything"
	/// </summary>
	public override string HeadingMakeAnythingSub => "ä½•ã‹ã‚’ä½œã‚‹";

	/// <summary>
	/// Key: "Heading.ReachMillionsPlayers"
	/// heading
	/// English String: "Reach Millions of Players"
	/// </summary>
	public override string HeadingReachMillionsPlayers => "æ•°ç™¾ä¸‡äººã®ãƒ—ãƒ¬ã‚¤ãƒ¤ãƒ¼ã«ãƒªãƒ¼ãƒ";

	/// <summary>
	/// Key: "Heading.RobloxDevHub"
	/// English String: "Developer Hub"
	/// </summary>
	public override string HeadingRobloxDevHub => "ãƒ‡ãƒ™ãƒ­ãƒƒãƒ‘ãƒ¼ãƒãƒ–";

	/// <summary>
	/// Key: "Heading.RobloxWiki"
	/// heading
	/// English String: "Roblox Wiki"
	/// </summary>
	public override string HeadingRobloxWiki => "Roblox Wiki";

	/// <summary>
	/// Key: "Heading.Studio"
	/// heading
	/// English String: "Studio"
	/// </summary>
	public override string HeadingStudio => "Studio";

	/// <summary>
	/// Key: "Heading.TryFreeRobloxStudioToday"
	/// heading
	/// English String: "Roblox Studio is FREE! Try it out today!"
	/// </summary>
	public override string HeadingTryFreeRobloxStudioToday => "Roblox Studioã¯ç„¡æ–™ã§ã™ï¼ä»Šã™ãä½¿ã£ã¦ã¿ã¾ã—ã‚‡ã†ï¼";

	/// <summary>
	/// Key: "Heading.WhatCreatorsSaying"
	/// heading
	/// English String: "What Our Creators Are Saying"
	/// </summary>
	public override string HeadingWhatCreatorsSaying => "ã‚¯ãƒªã‚¨ãƒ¼ã‚¿ãƒ¼ã‹ã‚‰ã®ã‚³ãƒ¡ãƒ³ãƒˆ";

	/// <summary>
	/// Key: "Label.CreateWithFriends"
	/// label
	/// English String: "Create With Friends"
	/// </summary>
	public override string LabelCreateWithFriends => "å‹é”ã¨ä½œæˆ";

	/// <summary>
	/// Key: "Label.GetStarted"
	/// label
	/// English String: "Get Started"
	/// </summary>
	public override string LabelGetStarted => "å§‹ã‚ã‚ˆã†";

	/// <summary>
	/// Key: "Label.GoToTop"
	/// label
	/// English String: "Go to top"
	/// </summary>
	public override string LabelGoToTop => "ãƒˆãƒƒãƒ—ã«æˆ»ã‚‹";

	/// <summary>
	/// Key: "Label.QuotationMark"
	/// image alt text for accessibility
	/// English String: "Quotation Mark"
	/// </summary>
	public override string LabelQuotationMark => "å¼•ç”¨ç¬¦";

	/// <summary>
	/// Key: "Label.RobloxStudioOnWindowsAndMac"
	/// label
	/// English String: "Roblox Studio is available on Windows and Mac"
	/// </summary>
	public override string LabelRobloxStudioOnWindowsAndMac => "Roblox Studioã¯ã€Windowsã¨Macã§åˆ©ç”¨ã§ãã¾ã™";

	/// <summary>
	/// Key: "Label.TestimonialOneName"
	/// label - no need to translate this
	/// English String: "Andrew Bereza"
	/// </summary>
	public override string LabelTestimonialOneName => "Andrew Bereza";

	/// <summary>
	/// Key: "Label.TestimonialThreeName"
	/// name - please do not translate this
	/// English String: "Alex Balfanz"
	/// </summary>
	public override string LabelTestimonialThreeName => "Alex Balfanz";

	/// <summary>
	/// Key: "Label.TestimonialTwoName"
	/// name - please do not translate this
	/// English String: "Jackson Munsell"
	/// </summary>
	public override string LabelTestimonialTwoName => "Jackson Munsell";

	public DevelopLandingResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionManageMyGames()
	{
		return "ãƒžã‚¤ã‚²ãƒ¼ãƒ ã®ç®¡ç†";
	}

	protected override string _GetTemplateForActionRobloxDevHub()
	{
		return "ãƒ‡ãƒ™ãƒ­ãƒƒãƒ‘ãƒ¼ãƒãƒ–ã¸";
	}

	protected override string _GetTemplateForActionRobloxWiki()
	{
		return "Roblox Wiki ã«ç§»å‹•ã™ã‚‹";
	}

	protected override string _GetTemplateForActionStartCreating()
	{
		return "åˆ¶ä½œã‚’é–‹å§‹";
	}

	protected override string _GetTemplateForDescriptionEarnSeriousCash()
	{
		return "ã‚ãªãŸã®ã‚ˆã†ãªã‚²ãƒ¼ãƒ ã‚¯ãƒªã‚¨ãƒ¼ã‚¿ãƒ¼ãŒã€è¶£å‘³ã‚’ãŠé‡‘ã«å¤‰ãˆã¦ã„ã¾ã™ã€‚ãƒˆãƒƒãƒ—ã‚¯ãƒ©ã‚¹ã®é–‹ç™ºè€…ã¯ã€ã‚²ãƒ¼ãƒ å†…èª²é‡‘ã«ã‚ˆã£ã¦å¹´é–“$200ä¸‡ä»¥ä¸Šã‚’ç¨¼ã„ã§ã„ã¾ã™";
	}

	protected override string _GetTemplateForDescriptionFreeImmersiveCreationEngine()
	{
		return "ç„¡æ–™ã§åˆ©ç”¨ã§ãã‚‹æ²¡å…¥åž‹ã‚²ãƒ¼ãƒ åˆ¶ä½œã‚¨ãƒ³ã‚¸ãƒ³";
	}

	protected override string _GetTemplateForDescriptionMakeAnything()
	{
		return "Roblox Studioã‚’ä½¿ãˆã°ä½•ã§ã‚‚åˆ¶ä½œã§ãã¦ã€ãƒ¯ãƒ³ã‚¯ãƒªãƒƒã‚¯ã§ã‚¹ãƒžãƒ¼ãƒˆãƒ•ã‚©ãƒ³ã€ã‚¿ãƒ–ãƒ¬ãƒƒãƒˆã€ã‚²ãƒ¼ãƒ ã‚³ãƒ³ã‚½ãƒ¼ãƒ«ã€VRãƒ‡ãƒã‚¤ã‚¹ã§å…¬é–‹ã™ã‚‹ã“ã¨ãŒã§ãã¾ã™";
	}

	protected override string _GetTemplateForDescriptionReachMillionsPlayers()
	{
		return "æœˆé–“5000ä¸‡äººä»¥ä¸Šã®ç†±å¿ƒãªãƒ—ãƒ¬ã‚¤ãƒ¤ãƒ¼ãŸã¡ãŒå‚åŠ ã—ã¦ã„ã‚‹ä¸–ç•Œçš„ãªã‚³ãƒŸãƒ¥ãƒ‹ãƒ†ã‚£ã‚’ä½¿ã£ã¦ã€ãŸãã•ã‚“ã®äººã¨ã¤ãªãŒã‚ã†";
	}

	protected override string _GetTemplateForDescriptionRobloxDevHub()
	{
		return "ãƒ‡ãƒ™ãƒ­ãƒƒãƒ‘ãƒ¼ãƒãƒ–ã¯ã€Robloxã§ä½œå“å…¬é–‹ã™ã‚‹ã®ã«å½¹ç«‹ã¤æ©Ÿèƒ½ãŒä¸€ãƒ¶æ‰€ã«ã™ã¹ã¦é›†ã¾ã£ãŸå ´æ‰€ã§ã™ã€‚åºƒç¯„ãªãƒãƒ¥ãƒ¼ãƒˆãƒªã‚¢ãƒ«ã§å­¦ã‚“ã ã‚Šã€ä»–ã®é–‹ç™ºè€…ã¨äº¤æµã—ãŸã‚Šã€ãƒ—ãƒ©ãƒƒãƒˆãƒ•ã‚©ãƒ¼ãƒ ã®ã‚¢ãƒƒãƒ—ãƒ‡ãƒ¼ãƒˆã‚’ã—ãŸã‚Šã€APIãƒªãƒ•ã‚¡ãƒ¬ãƒ³ã‚¹ã‚’è¦‹ãŸã‚Šã€ä»–ã«ã‚‚ç››ã‚Šã ãã•ã‚“ã§ã™ã€‚";
	}

	protected override string _GetTemplateForDescriptionRobloxWiki()
	{
		return "Roblox Wikiã§ã¯ã€è§£èª¬æ›¸ã€ãƒãƒ¥ãƒ¼ãƒˆãƒªã‚¢ãƒ«ã€ã‚µãƒ³ãƒ—ãƒ«ãªã©ã€ã‚ã‚‰ã‚†ã‚‹ã‚‚ã®ã«ã‚¢ã‚¯ã‚»ã‚¹ã™ã‚‹ã“ã¨ãŒã§ãã¾ã™ã€‚Roblox Studioã«ã‚ˆã‚‹ã‚²ãƒ¼ãƒ é–‹ç™ºã«å½¹ç«‹ã¦ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForDescriptionTestimonialAlexBalfanz()
	{
		return "Robloxã¯ã€ç°¡å˜ã«ä½¿ã„ã“ãªã™ã“ã¨ãŒã§ãã¾ã—ãŸã€‚æœ€å…ˆç«¯ã®ãƒ—ãƒ©ãƒƒãƒˆãƒ•ã‚©ãƒ¼ãƒ ãªã®ã§ã€ã‚ã‚‰ã‚†ã‚‹çµŒé¨“ã‚’ã¤ãŽè¾¼ã‚€ã“ã¨ãŒã§ãã¾ã™ã€‚ã¾ãŸã€Robloxãƒãƒ¼ãƒ ã¯ã€ã„ã¤ã‚‚ç´ æ™´ã‚‰ã—ã„é–‹ç™ºè€…ç”¨ãƒªã‚½ãƒ¼ã‚¹ã‚’æä¾›ã—ã¦ãã‚Œã¾ã™ã€‚";
	}

	protected override string _GetTemplateForDescriptionTestimonialAndrewBereza()
	{
		return "Robloxã®ãŠã‹ã’ã§ã€å¤§å­¦ç”Ÿã¨ã—ã¦ã®çµŒæ¸ˆçš„ãªå•é¡Œã‚’å¿ƒé…ã›ãšã«ã€ã‚²ãƒ¼ãƒ é–‹ç™ºã‚„å°†æ¥ã®ã‚­ãƒ£ãƒªã‚¢ã«ã¤ãªãŒã‚‹å¯èƒ½æ€§ãŒã‚ã‚‹ã“ã¨ã«é›†ä¸­ã§ãã¦ã„ã¾ã™ã€‚";
	}

	protected override string _GetTemplateForDescriptionTestimonialJacksonMunsell()
	{
		return "Robloxã§ã®ã‚²ãƒ¼ãƒ åˆ¶ä½œãŒæ¥½ã—ã„ã®ã¯ã€äººã¨äº¤æµã—ãªãŒã‚‰ã§ãã‚‹ã‹ã‚‰ã§ã™ã€‚ã‚²ãƒ¼ãƒ ã¨ã‚³ãƒŸãƒ¥ãƒ‹ãƒ†ã‚£ã®å‰µé€ åŠ›ã‚’æ–°ã—ã„å¢ƒåœ°ã«å¼•ãä¸Šã’ã‚‹ã«ã¯ã€Facebookã®ã‚ˆã†ãªãƒ—ãƒ©ãƒƒãƒˆãƒ•ã‚©ãƒ¼ãƒ ã®SNSçš„ãªè¦ç´ ãŒå¿…è¦ã§ã™ã€‚";
	}

	protected override string _GetTemplateForDescriptionTestimonialOne()
	{
		return "Robloxã®ãŠã‹ã’ã§ã€å¤§å­¦ç”Ÿã¨ã—ã¦ã®çµŒæ¸ˆçš„ãªå•é¡Œã‚’å¿ƒé…ã›ãšã«ã€ã‚²ãƒ¼ãƒ é–‹ç™ºã‚„å°†æ¥ã®ã‚­ãƒ£ãƒªã‚¢ã«ã¤ãªãŒã‚‹å¯èƒ½æ€§ãŒã‚ã‚‹ã“ã¨ã«é›†ä¸­ã§ãã¦ã„ã¾ã™ã€‚";
	}

	protected override string _GetTemplateForDescriptionTestimonialThree()
	{
		return "Robloxã¯ã€ç°¡å˜ã«ä½¿ã„ã“ãªã™ã“ã¨ãŒã§ãã¾ã—ãŸã€‚æœ€å…ˆç«¯ã®ãƒ—ãƒ©ãƒƒãƒˆãƒ•ã‚©ãƒ¼ãƒ ãªã®ã§ã€ã‚ã‚‰ã‚†ã‚‹çµŒé¨“ã‚’ã¤ãŽè¾¼ã‚€ã“ã¨ãŒã§ãã¾ã™ã€‚ã¾ãŸã€Robloxãƒãƒ¼ãƒ ã¯ã€ã„ã¤ã‚‚ç´ æ™´ã‚‰ã—ã„é–‹ç™ºè€…ç”¨ãƒªã‚½ãƒ¼ã‚¹ã‚’æä¾›ã—ã¦ãã‚Œã¾ã™ã€‚";
	}

	protected override string _GetTemplateForDescriptionTestimonialTwo()
	{
		return "Robloxã§ã®ã‚²ãƒ¼ãƒ åˆ¶ä½œãŒæ¥½ã—ã„ã®ã¯ã€äººã¨äº¤æµã—ãªãŒã‚‰ã§ãã‚‹ã‹ã‚‰ã§ã™ã€‚ã‚²ãƒ¼ãƒ ã¨ã‚³ãƒŸãƒ¥ãƒ‹ãƒ†ã‚£ã®å‰µé€ åŠ›ã‚’æ–°ã—ã„å¢ƒåœ°ã«å¼•ãä¸Šã’ã‚‹ã«ã¯ã€Facebookã®ã‚ˆã†ãªãƒ—ãƒ©ãƒƒãƒˆãƒ•ã‚©ãƒ¼ãƒ ã®SNSçš„ãªè¦ç´ ãŒå¿…è¦ã§ã™ã€‚";
	}

	protected override string _GetTemplateForHeadingEarnSeriousCash()
	{
		return "å®Ÿéš›ã«ç¾é‡‘ã‚’ç¨¼ã";
	}

	protected override string _GetTemplateForHeadingMakeAnything()
	{
		return "æƒ³åƒã§ãã‚‹ã‚‚ã®ã‚’ä½•ã§ã‚‚ä½œã£ã¡ã‚ƒãŠã†";
	}

	protected override string _GetTemplateForHeadingMakeAnythingSub()
	{
		return "ä½•ã‹ã‚’ä½œã‚‹";
	}

	protected override string _GetTemplateForHeadingReachMillionsPlayers()
	{
		return "æ•°ç™¾ä¸‡äººã®ãƒ—ãƒ¬ã‚¤ãƒ¤ãƒ¼ã«ãƒªãƒ¼ãƒ";
	}

	protected override string _GetTemplateForHeadingRobloxDevHub()
	{
		return "ãƒ‡ãƒ™ãƒ­ãƒƒãƒ‘ãƒ¼ãƒãƒ–";
	}

	protected override string _GetTemplateForHeadingRobloxWiki()
	{
		return "Roblox Wiki";
	}

	protected override string _GetTemplateForHeadingStudio()
	{
		return "Studio";
	}

	protected override string _GetTemplateForHeadingTryFreeRobloxStudioToday()
	{
		return "Roblox Studioã¯ç„¡æ–™ã§ã™ï¼ä»Šã™ãä½¿ã£ã¦ã¿ã¾ã—ã‚‡ã†ï¼";
	}

	protected override string _GetTemplateForHeadingWhatCreatorsSaying()
	{
		return "ã‚¯ãƒªã‚¨ãƒ¼ã‚¿ãƒ¼ã‹ã‚‰ã®ã‚³ãƒ¡ãƒ³ãƒˆ";
	}

	protected override string _GetTemplateForLabelCreateWithFriends()
	{
		return "å‹é”ã¨ä½œæˆ";
	}

	protected override string _GetTemplateForLabelGetStarted()
	{
		return "å§‹ã‚ã‚ˆã†";
	}

	protected override string _GetTemplateForLabelGoToTop()
	{
		return "ãƒˆãƒƒãƒ—ã«æˆ»ã‚‹";
	}

	protected override string _GetTemplateForLabelQuotationMark()
	{
		return "å¼•ç”¨ç¬¦";
	}

	protected override string _GetTemplateForLabelRobloxStudioOnWindowsAndMac()
	{
		return "Roblox Studioã¯ã€Windowsã¨Macã§åˆ©ç”¨ã§ãã¾ã™";
	}

	protected override string _GetTemplateForLabelTestimonialOneName()
	{
		return "Andrew Bereza";
	}

	protected override string _GetTemplateForLabelTestimonialThreeName()
	{
		return "Alex Balfanz";
	}

	protected override string _GetTemplateForLabelTestimonialTwoName()
	{
		return "Jackson Munsell";
	}
}


}
