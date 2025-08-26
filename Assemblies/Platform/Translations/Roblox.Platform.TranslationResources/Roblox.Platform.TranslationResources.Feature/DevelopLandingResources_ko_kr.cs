namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides DevelopLandingResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class DevelopLandingResources_ko_kr : DevelopLandingResources_en_us, IDevelopLandingResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.ManageMyGames"
	/// button label
	/// English String: "Manage my games"
	/// </summary>
	public override string ActionManageMyGames => "ë‚´ ê²Œìž„ ê´€ë¦¬";

	/// <summary>
	/// Key: "Action.RobloxDevHub"
	/// English String: "Continue to the Developer Hub"
	/// </summary>
	public override string ActionRobloxDevHub => "ê°œë°œìž í—ˆë¸Œë¡œ ê³„ì†";

	/// <summary>
	/// Key: "Action.RobloxWiki"
	/// button label
	/// English String: "Continue to Roblox Wiki"
	/// </summary>
	public override string ActionRobloxWiki => "Roblox Wikië¡œ ê³„ì†";

	/// <summary>
	/// Key: "Action.StartCreating"
	/// button label
	/// English String: "Start Creating"
	/// </summary>
	public override string ActionStartCreating => "ë§Œë“¤ê¸° ì‹œìž‘";

	/// <summary>
	/// Key: "Description.EarnSeriousCash"
	/// description
	/// English String: "Creators like you are getting paid for what they love to do. Our top developers are earning over $2M a year by providing in-game purchases"
	/// </summary>
	public override string DescriptionEarnSeriousCash => "ì—¬ëŸ¬ë¶„ê³¼ ê°™ì€ ê°œë°œìžë“¤ì´ í•˜ê³  ì‹¶ì€ ì¼ì„ í•˜ë©´ì„œ ìˆ˜ìµë„ ì°½ì¶œí•˜ê³  ìžˆìŠµë‹ˆë‹¤. ê²Œìž„ ë‚´ êµ¬ë§¤ ê¸°ëŠ¥ ì œê³µì„ í†µí•´ ì¼ ë…„ì— 200ë§Œ ë‹¬ëŸ¬ ì´ìƒì˜ ìˆ˜ìµì„ ì˜¬ë¦¬ëŠ” ê°œë°œìžë„ ìžˆë‹µë‹ˆë‹¤. ";

	/// <summary>
	/// Key: "Description.FreeImmersiveCreationEngine"
	/// subtext
	/// English String: "With our FREE and immersive creation engine"
	/// </summary>
	public override string DescriptionFreeImmersiveCreationEngine => "ëª°ìž…í˜• ìƒì„± ì—”ì§„ì„ ë¬´ë£Œë¡œ ì´ìš©í•  ìˆ˜ ìžˆì–´ìš”";

	/// <summary>
	/// Key: "Description.MakeAnything"
	/// text paragraph on page
	/// English String: "Roblox Studio lets you create anything and release with one click to smartphones, tablets, desktops, consoles, and virtual reality devices"
	/// </summary>
	public override string DescriptionMakeAnything => "Roblox Studioë¥¼ ì´ìš©í•´ ë¬´ì—‡ì´ë“  ë§Œë“¤ ìˆ˜ ìžˆì„ ë¿ ì•„ë‹ˆë¼ í´ë¦­ í•œ ë²ˆìœ¼ë¡œ ìŠ¤ë§ˆíŠ¸í°, íƒœë¸”ë¦¿, ë°ìŠ¤í¬í†±, ì½˜ì†” ë° VR ê¸°ê¸°ì— ê³µê°œí•  ìˆ˜ ìžˆìŠµë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Description.ReachMillionsPlayers"
	/// description
	/// English String: "Connect with a massive audience by tapping into an incredibly enthusiastic and international community of over 50 million monthly players"
	/// </summary>
	public override string DescriptionReachMillionsPlayers => "ë§¤ì›” ì „ ì„¸ê³„ 5,000ë§Œ ì´ìƒì˜ í”Œë ˆì´ì–´ë“¤ì´ í™œë°œížˆ ì°¸ì—¬í•˜ê³  ìžˆëŠ” Roblox ì»¤ë®¤ë‹ˆí‹°ì— ì ‘ì†í•´ ìˆ˜ë§Žì€ í”Œë ˆì´ì–´ë“¤ì„ ë§Œë‚˜ë³´ì„¸ìš”   ";

	/// <summary>
	/// Key: "Description.RobloxDevHub"
	/// English String: "The Developer Hub is your one-stop shop for publishing on Roblox. Learn from a wide set of tutorials, connect with other developers, get platform updates, browse our API references, and much more."
	/// </summary>
	public override string DescriptionRobloxDevHub => "ê°œë°œìž í—ˆë¸ŒëŠ” Roblox ê²Œìž„ ê²Œì‹œì— ê´€í•œ ëª¨ë“  ê²ƒì„ í•œê³³ì—ì„œ í•´ê²°í•  ìˆ˜ ìžˆëŠ” ê³µê°„ìž…ë‹ˆë‹¤. ë‹¤ì–‘í•œ íŠœí† ë¦¬ì–¼ì„ í†µí•´ í­ë„“ê²Œ ë°°ìš°ê³ , ë‹¤ë¥¸ ê°œë°œìžë“¤ì„ ë§Œë‚˜ë©°, í”Œëž«í¼ ì—…ë°ì´íŠ¸ë¥¼ ë°›ì•„ë³´ê³ , API ì°¸ì¡°ì„œë¥¼ ë‘˜ëŸ¬ë³´ëŠ” ë“± ë‹¤ì±„ë¡­ê²Œ í™œìš©í•´ ë³´ì„¸ìš”.";

	/// <summary>
	/// Key: "Description.RobloxWiki"
	/// description
	/// English String: "The Roblox Wiki is the ultimate resource for documentation, tutorials, and samples which will help you learn to make games with Roblox Studio"
	/// </summary>
	public override string DescriptionRobloxWiki => "Roblox WikiëŠ” Roblox Studioì—ì„œ ê²Œìž„ì„ ë§Œë“œëŠ” ë° ë„ì›€ì„ ì£¼ëŠ” ë¬¸ì„œ, íŠœí† ë¦¬ì–¼ ë° ìƒ˜í”Œ ë“±ì„ ì œê³µí•˜ëŠ” ìµœê³ ì˜ ë¦¬ì†ŒìŠ¤ìž…ë‹ˆë‹¤";

	/// <summary>
	/// Key: "Description.TestimonialAlexBalfanz"
	/// testimonial
	/// English String: "Roblox was so easy to get into. You can have a whole career on it because itâ€™s such a hot platform and the team there is always providing great resources for developers."
	/// </summary>
	public override string DescriptionTestimonialAlexBalfanz => "RobloxëŠ” ì •ë§ ì‚¬ìš©í•˜ê¸° ì‰¬ìš´ í”Œëž«í¼ì´ì˜ˆìš”. ì¸ê¸°ìžˆì„ ë¿ ì•„ë‹ˆë¼ ì–¸ì œë‚˜ ê°œë°œìžë¥¼ ìœ„í•œ ìœ ìš©í•œ ë¦¬ì†ŒìŠ¤ë¥¼ ì œê³µí•´ì£¼ë‹ˆ ê²½ë ¥ì„ ìŒ“ê¸°ì—ë„ ìµœê³ ì£ .";

	/// <summary>
	/// Key: "Description.TestimonialAndrewBereza"
	/// testimonial text
	/// English String: "Roblox allows me to focus on my game development and potential future career without having to worry about the financial hardships of being a college student."
	/// </summary>
	public override string DescriptionTestimonialAndrewBereza => "Roblox ë•ë¶„ì— ëŒ€í•™ í•™ë¹„ì— ëŒ€í•œ ê±±ì • ì—†ì´ ê²Œìž„ ê°œë°œê³¼ ê²½ë ¥ ìŒ“ê¸°ì— ì§‘ì¤‘í•  ìˆ˜ ìžˆì—ˆì–´ìš”.";

	/// <summary>
	/// Key: "Description.TestimonialJacksonMunsell"
	/// testimonial
	/// English String: "I enjoy creating games on Roblox because itâ€™s social. It takes the socialization of platforms like Facebook to a new level with the games and creativity of the community."
	/// </summary>
	public override string DescriptionTestimonialJacksonMunsell => "Robloxì—ì„œ ê²Œìž„ì„ ë§Œë“œëŠ” ì¼ì´ ì¦ê±°ìš´ ì´ìœ ëŠ” ì´ê³³ì´ ì†Œì…œ í”Œëž«í¼ì´ê¸° ë•Œë¬¸ì´ì£ . Facebookê³¼ ê°™ì€ ì†Œì…œ í”Œëž«í¼ì„ í†µí•´ ìƒˆë¡œìš´ ì°¨ì›ì˜ ê²Œìž„ì„ ê°œë°œí•  ìˆ˜ ìžˆì„ ë¿ ì•„ë‹ˆë¼ ì»¤ë®¤ë‹ˆí‹°ì˜ ì°½ì˜ì„±ì„ ì´ìš©í•  ìˆ˜ ìžˆê²Œ ë„ì™€ì£¼ë‹ˆê¹Œìš”.";

	/// <summary>
	/// Key: "Description.TestimonialOne"
	/// testimonial content
	/// English String: "Roblox allows me to focus on my game development and potential future career without having to worry about the financial hardships of being a college student."
	/// </summary>
	public override string DescriptionTestimonialOne => "Roblox ë•ë¶„ì— ëŒ€í•™ í•™ë¹„ ê±±ì • ì—†ì´ ê²Œìž„ ê°œë°œê³¼ ê²½ë ¥ ìŒ“ê¸°ì— ì§‘ì¤‘í•  ìˆ˜ ìžˆì—ˆì–´ìš”.";

	/// <summary>
	/// Key: "Description.TestimonialThree"
	/// testimonial text
	/// English String: "Roblox was so easy to get into. You can have a whole career on it because itâ€™s such a hot platform and the team there is always providing great resources for developers."
	/// </summary>
	public override string DescriptionTestimonialThree => "RobloxëŠ” ì •ë§ ì‚¬ìš©í•˜ê¸° ì‰¬ìš´ í”Œëž«í¼ì´ì˜ˆìš”. ì¸ê¸°ìžˆì„ ë¿ ì•„ë‹ˆë¼ ì–¸ì œë‚˜ ê°œë°œìžë¥¼ ìœ„í•œ ìœ ìš©í•œ ë¦¬ì†ŒìŠ¤ë¥¼ ì œê³µí•´ì£¼ë‹ˆ ê²½ë ¥ì„ ìŒ“ê¸°ì—ë„ ìµœê³ ì£ .";

	/// <summary>
	/// Key: "Description.TestimonialTwo"
	/// description
	/// English String: "I enjoy creating games on Roblox because itâ€™s social. It takes the socialization of platforms like Facebook to a new level with the games and creativity of the community."
	/// </summary>
	public override string DescriptionTestimonialTwo => "Robloxì—ì„œ ê²Œìž„ì„ ë§Œë“œëŠ” ì¼ì´ ì¦ê±°ìš´ ì´ìœ ëŠ” ì´ê³³ì´ ì†Œì…œ í”Œëž«í¼ì´ê¸° ë•Œë¬¸ì´ì£ . Facebookê³¼ ê°™ì€ ì†Œì…œ í”Œëž«í¼ì„ í†µí•´ ìƒˆë¡œìš´ ì°¨ì›ì˜ ê²Œìž„ì„ ê°œë°œí•  ìˆ˜ ìžˆì„ ë¿ ì•„ë‹ˆë¼ ì»¤ë®¤ë‹ˆí‹°ì˜ ì°½ì˜ì„±ì„ ì´ìš©í•  ìˆ˜ ìžˆê²Œ ë„ì™€ì£¼ë‹ˆê¹Œìš”";

	/// <summary>
	/// Key: "Heading.EarnSeriousCash"
	/// heading
	/// English String: "Earn Serious Cash"
	/// </summary>
	public override string HeadingEarnSeriousCash => "ìƒë‹¹í•œ ìˆ˜ìµê¹Œì§€";

	/// <summary>
	/// Key: "Heading.MakeAnything"
	/// heading
	/// English String: "Make Anything You Can Imagine"
	/// </summary>
	public override string HeadingMakeAnything => "ì—¬ëŸ¬ë¶„ì´ ìƒìƒí•˜ëŠ” ëª¨ë“  ê²ƒ, ì§€ê¸ˆ ë§Œë“¤ì–´ë³´ì„¸ìš”! ";

	/// <summary>
	/// Key: "Heading.MakeAnythingSub"
	/// section heading
	/// English String: "Make Anything"
	/// </summary>
	public override string HeadingMakeAnythingSub => "ìƒìƒì„ í˜„ì‹¤ë¡œ";

	/// <summary>
	/// Key: "Heading.ReachMillionsPlayers"
	/// heading
	/// English String: "Reach Millions of Players"
	/// </summary>
	public override string HeadingReachMillionsPlayers => "ìˆ˜ë§Žì€ í”Œë ˆì´ì–´ì™€ì˜ ì†Œí†µ";

	/// <summary>
	/// Key: "Heading.RobloxDevHub"
	/// English String: "Developer Hub"
	/// </summary>
	public override string HeadingRobloxDevHub => "ê°œë°œìž í—ˆë¸Œ";

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
	public override string HeadingTryFreeRobloxStudioToday => "Roblox StudioëŠ” ë¬´ë£Œìž…ë‹ˆë‹¤! ì§€ê¸ˆ ì´ìš©í•´ë³´ì„¸ìš”!";

	/// <summary>
	/// Key: "Heading.WhatCreatorsSaying"
	/// heading
	/// English String: "What Our Creators Are Saying"
	/// </summary>
	public override string HeadingWhatCreatorsSaying => "Roblox ê°œë°œìžë“¤ì˜ ì´ì•¼ê¸°";

	/// <summary>
	/// Key: "Label.CreateWithFriends"
	/// label
	/// English String: "Create With Friends"
	/// </summary>
	public override string LabelCreateWithFriends => "ì¹œêµ¬ì™€ ë§Œë“¤ê¸°";

	/// <summary>
	/// Key: "Label.GetStarted"
	/// label
	/// English String: "Get Started"
	/// </summary>
	public override string LabelGetStarted => "ì‹œìž‘í•˜ê¸°";

	/// <summary>
	/// Key: "Label.GoToTop"
	/// label
	/// English String: "Go to top"
	/// </summary>
	public override string LabelGoToTop => "ë§¨ ìœ„ë¡œ ì´ë™";

	/// <summary>
	/// Key: "Label.QuotationMark"
	/// image alt text for accessibility
	/// English String: "Quotation Mark"
	/// </summary>
	public override string LabelQuotationMark => "ë”°ì˜´í‘œ";

	/// <summary>
	/// Key: "Label.RobloxStudioOnWindowsAndMac"
	/// label
	/// English String: "Roblox Studio is available on Windows and Mac"
	/// </summary>
	public override string LabelRobloxStudioOnWindowsAndMac => "Roblox StudioëŠ” Windowsì™€ Macì—ì„œ ì´ìš©í•  ìˆ˜ ìžˆìŠµë‹ˆë‹¤";

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

	public DevelopLandingResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionManageMyGames()
	{
		return "ë‚´ ê²Œìž„ ê´€ë¦¬";
	}

	protected override string _GetTemplateForActionRobloxDevHub()
	{
		return "ê°œë°œìž í—ˆë¸Œë¡œ ê³„ì†";
	}

	protected override string _GetTemplateForActionRobloxWiki()
	{
		return "Roblox Wikië¡œ ê³„ì†";
	}

	protected override string _GetTemplateForActionStartCreating()
	{
		return "ë§Œë“¤ê¸° ì‹œìž‘";
	}

	protected override string _GetTemplateForDescriptionEarnSeriousCash()
	{
		return "ì—¬ëŸ¬ë¶„ê³¼ ê°™ì€ ê°œë°œìžë“¤ì´ í•˜ê³  ì‹¶ì€ ì¼ì„ í•˜ë©´ì„œ ìˆ˜ìµë„ ì°½ì¶œí•˜ê³  ìžˆìŠµë‹ˆë‹¤. ê²Œìž„ ë‚´ êµ¬ë§¤ ê¸°ëŠ¥ ì œê³µì„ í†µí•´ ì¼ ë…„ì— 200ë§Œ ë‹¬ëŸ¬ ì´ìƒì˜ ìˆ˜ìµì„ ì˜¬ë¦¬ëŠ” ê°œë°œìžë„ ìžˆë‹µë‹ˆë‹¤. ";
	}

	protected override string _GetTemplateForDescriptionFreeImmersiveCreationEngine()
	{
		return "ëª°ìž…í˜• ìƒì„± ì—”ì§„ì„ ë¬´ë£Œë¡œ ì´ìš©í•  ìˆ˜ ìžˆì–´ìš”";
	}

	protected override string _GetTemplateForDescriptionMakeAnything()
	{
		return "Roblox Studioë¥¼ ì´ìš©í•´ ë¬´ì—‡ì´ë“  ë§Œë“¤ ìˆ˜ ìžˆì„ ë¿ ì•„ë‹ˆë¼ í´ë¦­ í•œ ë²ˆìœ¼ë¡œ ìŠ¤ë§ˆíŠ¸í°, íƒœë¸”ë¦¿, ë°ìŠ¤í¬í†±, ì½˜ì†” ë° VR ê¸°ê¸°ì— ê³µê°œí•  ìˆ˜ ìžˆìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForDescriptionReachMillionsPlayers()
	{
		return "ë§¤ì›” ì „ ì„¸ê³„ 5,000ë§Œ ì´ìƒì˜ í”Œë ˆì´ì–´ë“¤ì´ í™œë°œížˆ ì°¸ì—¬í•˜ê³  ìžˆëŠ” Roblox ì»¤ë®¤ë‹ˆí‹°ì— ì ‘ì†í•´ ìˆ˜ë§Žì€ í”Œë ˆì´ì–´ë“¤ì„ ë§Œë‚˜ë³´ì„¸ìš”   ";
	}

	protected override string _GetTemplateForDescriptionRobloxDevHub()
	{
		return "ê°œë°œìž í—ˆë¸ŒëŠ” Roblox ê²Œìž„ ê²Œì‹œì— ê´€í•œ ëª¨ë“  ê²ƒì„ í•œê³³ì—ì„œ í•´ê²°í•  ìˆ˜ ìžˆëŠ” ê³µê°„ìž…ë‹ˆë‹¤. ë‹¤ì–‘í•œ íŠœí† ë¦¬ì–¼ì„ í†µí•´ í­ë„“ê²Œ ë°°ìš°ê³ , ë‹¤ë¥¸ ê°œë°œìžë“¤ì„ ë§Œë‚˜ë©°, í”Œëž«í¼ ì—…ë°ì´íŠ¸ë¥¼ ë°›ì•„ë³´ê³ , API ì°¸ì¡°ì„œë¥¼ ë‘˜ëŸ¬ë³´ëŠ” ë“± ë‹¤ì±„ë¡­ê²Œ í™œìš©í•´ ë³´ì„¸ìš”.";
	}

	protected override string _GetTemplateForDescriptionRobloxWiki()
	{
		return "Roblox WikiëŠ” Roblox Studioì—ì„œ ê²Œìž„ì„ ë§Œë“œëŠ” ë° ë„ì›€ì„ ì£¼ëŠ” ë¬¸ì„œ, íŠœí† ë¦¬ì–¼ ë° ìƒ˜í”Œ ë“±ì„ ì œê³µí•˜ëŠ” ìµœê³ ì˜ ë¦¬ì†ŒìŠ¤ìž…ë‹ˆë‹¤";
	}

	protected override string _GetTemplateForDescriptionTestimonialAlexBalfanz()
	{
		return "RobloxëŠ” ì •ë§ ì‚¬ìš©í•˜ê¸° ì‰¬ìš´ í”Œëž«í¼ì´ì˜ˆìš”. ì¸ê¸°ìžˆì„ ë¿ ì•„ë‹ˆë¼ ì–¸ì œë‚˜ ê°œë°œìžë¥¼ ìœ„í•œ ìœ ìš©í•œ ë¦¬ì†ŒìŠ¤ë¥¼ ì œê³µí•´ì£¼ë‹ˆ ê²½ë ¥ì„ ìŒ“ê¸°ì—ë„ ìµœê³ ì£ .";
	}

	protected override string _GetTemplateForDescriptionTestimonialAndrewBereza()
	{
		return "Roblox ë•ë¶„ì— ëŒ€í•™ í•™ë¹„ì— ëŒ€í•œ ê±±ì • ì—†ì´ ê²Œìž„ ê°œë°œê³¼ ê²½ë ¥ ìŒ“ê¸°ì— ì§‘ì¤‘í•  ìˆ˜ ìžˆì—ˆì–´ìš”.";
	}

	protected override string _GetTemplateForDescriptionTestimonialJacksonMunsell()
	{
		return "Robloxì—ì„œ ê²Œìž„ì„ ë§Œë“œëŠ” ì¼ì´ ì¦ê±°ìš´ ì´ìœ ëŠ” ì´ê³³ì´ ì†Œì…œ í”Œëž«í¼ì´ê¸° ë•Œë¬¸ì´ì£ . Facebookê³¼ ê°™ì€ ì†Œì…œ í”Œëž«í¼ì„ í†µí•´ ìƒˆë¡œìš´ ì°¨ì›ì˜ ê²Œìž„ì„ ê°œë°œí•  ìˆ˜ ìžˆì„ ë¿ ì•„ë‹ˆë¼ ì»¤ë®¤ë‹ˆí‹°ì˜ ì°½ì˜ì„±ì„ ì´ìš©í•  ìˆ˜ ìžˆê²Œ ë„ì™€ì£¼ë‹ˆê¹Œìš”.";
	}

	protected override string _GetTemplateForDescriptionTestimonialOne()
	{
		return "Roblox ë•ë¶„ì— ëŒ€í•™ í•™ë¹„ ê±±ì • ì—†ì´ ê²Œìž„ ê°œë°œê³¼ ê²½ë ¥ ìŒ“ê¸°ì— ì§‘ì¤‘í•  ìˆ˜ ìžˆì—ˆì–´ìš”.";
	}

	protected override string _GetTemplateForDescriptionTestimonialThree()
	{
		return "RobloxëŠ” ì •ë§ ì‚¬ìš©í•˜ê¸° ì‰¬ìš´ í”Œëž«í¼ì´ì˜ˆìš”. ì¸ê¸°ìžˆì„ ë¿ ì•„ë‹ˆë¼ ì–¸ì œë‚˜ ê°œë°œìžë¥¼ ìœ„í•œ ìœ ìš©í•œ ë¦¬ì†ŒìŠ¤ë¥¼ ì œê³µí•´ì£¼ë‹ˆ ê²½ë ¥ì„ ìŒ“ê¸°ì—ë„ ìµœê³ ì£ .";
	}

	protected override string _GetTemplateForDescriptionTestimonialTwo()
	{
		return "Robloxì—ì„œ ê²Œìž„ì„ ë§Œë“œëŠ” ì¼ì´ ì¦ê±°ìš´ ì´ìœ ëŠ” ì´ê³³ì´ ì†Œì…œ í”Œëž«í¼ì´ê¸° ë•Œë¬¸ì´ì£ . Facebookê³¼ ê°™ì€ ì†Œì…œ í”Œëž«í¼ì„ í†µí•´ ìƒˆë¡œìš´ ì°¨ì›ì˜ ê²Œìž„ì„ ê°œë°œí•  ìˆ˜ ìžˆì„ ë¿ ì•„ë‹ˆë¼ ì»¤ë®¤ë‹ˆí‹°ì˜ ì°½ì˜ì„±ì„ ì´ìš©í•  ìˆ˜ ìžˆê²Œ ë„ì™€ì£¼ë‹ˆê¹Œìš”";
	}

	protected override string _GetTemplateForHeadingEarnSeriousCash()
	{
		return "ìƒë‹¹í•œ ìˆ˜ìµê¹Œì§€";
	}

	protected override string _GetTemplateForHeadingMakeAnything()
	{
		return "ì—¬ëŸ¬ë¶„ì´ ìƒìƒí•˜ëŠ” ëª¨ë“  ê²ƒ, ì§€ê¸ˆ ë§Œë“¤ì–´ë³´ì„¸ìš”! ";
	}

	protected override string _GetTemplateForHeadingMakeAnythingSub()
	{
		return "ìƒìƒì„ í˜„ì‹¤ë¡œ";
	}

	protected override string _GetTemplateForHeadingReachMillionsPlayers()
	{
		return "ìˆ˜ë§Žì€ í”Œë ˆì´ì–´ì™€ì˜ ì†Œí†µ";
	}

	protected override string _GetTemplateForHeadingRobloxDevHub()
	{
		return "ê°œë°œìž í—ˆë¸Œ";
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
		return "Roblox StudioëŠ” ë¬´ë£Œìž…ë‹ˆë‹¤! ì§€ê¸ˆ ì´ìš©í•´ë³´ì„¸ìš”!";
	}

	protected override string _GetTemplateForHeadingWhatCreatorsSaying()
	{
		return "Roblox ê°œë°œìžë“¤ì˜ ì´ì•¼ê¸°";
	}

	protected override string _GetTemplateForLabelCreateWithFriends()
	{
		return "ì¹œêµ¬ì™€ ë§Œë“¤ê¸°";
	}

	protected override string _GetTemplateForLabelGetStarted()
	{
		return "ì‹œìž‘í•˜ê¸°";
	}

	protected override string _GetTemplateForLabelGoToTop()
	{
		return "ë§¨ ìœ„ë¡œ ì´ë™";
	}

	protected override string _GetTemplateForLabelQuotationMark()
	{
		return "ë”°ì˜´í‘œ";
	}

	protected override string _GetTemplateForLabelRobloxStudioOnWindowsAndMac()
	{
		return "Roblox StudioëŠ” Windowsì™€ Macì—ì„œ ì´ìš©í•  ìˆ˜ ìžˆìŠµë‹ˆë‹¤";
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
