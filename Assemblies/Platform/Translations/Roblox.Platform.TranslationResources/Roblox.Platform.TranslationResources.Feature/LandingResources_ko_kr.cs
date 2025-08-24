namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides LandingResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class LandingResources_ko_kr : LandingResources_en_us, ILandingResources, ITranslationResources
{
	/// <summary>
	/// Key: "Description.RobloxOnDeviceParagraphOne"
	/// first paragraph under Roblox on your device heading on landing page
	/// English String: "You can access Roblox on all modern smartphones, desktops, Xbox One, Oculus Rift, and soon on Daydream and Cardboard. Roblox adventures are accessible from any device, so players can imagine with their friends regardless of where they are."
	/// </summary>
	public override string DescriptionRobloxOnDeviceParagraphOne => "Roblox는 최신 스마트폰, 데스크톱은 물론 Xbox One과 Oculus Rift에서도 이용할 수 있으며, 곧 Daydream과 Cardboard도 지원할 예정이랍니다. 어떤 기기에서든 즐길 수 있는 만큼 장소에 구애받지 않고 친구들과 상상의 나래를 펼 수 있지요.";

	/// <summary>
	/// Key: "Description.RobloxOnDeviceParagraphTwo"
	/// second paragraph under Roblox on Your Device on landing page
	/// English String: "You can access Roblox on PC, Mac, iOS, Android, Amazon Devices, and Xbox One. Roblox adventures are accessible from any device, so players can imagine with their friends regardless of where they are."
	/// </summary>
	public override string DescriptionRobloxOnDeviceParagraphTwo => "Roblox는 PC와 Mac 외에 iOS 및 Android, Amazon 플랫폼 기반 장치는 물론 Xbox One과 Oculus Rift에서도 이용할 수 있어요. 어떤 기기에서든 즐길 수 있는 만큼 장소에 구애받지 않고 친구들과 상상의 나래를 펼 수 있지요.";

	/// <summary>
	/// Key: "Description.WhatIsRobloxParagraphOne"
	/// first paragraph under what's Roblox heading on landing page
	/// English String: "Roblox helps power the imagination of people around the world. As the largest growing social platform for play, over 44 million players come to Roblox every month to create adventures, play games, roleplay, and learn with friends. We call it the ‘Imagination Platform’ and believe everyone should have the right to play on it."
	/// </summary>
	public override string DescriptionWhatIsRobloxParagraphOne => "상상력을 쑥쑥 키워주는 Roblox는 월 방문자 수 4,400만을 자랑하는 세계 최대의 소셜 게임 플랫폼으로, 지금도 계속 성장하고 있어요. Roblox에서는 사용자가 직접 모험을 창조하고, 게임을 플레이할 수 있죠. 또한, 역할 놀이를 즐기고 친구들과 함께 새로운 것들을 배울 수 있어요. 누구나 참여할 수 있는 '상상 플랫폼'. 그것이 바로 Roblox랍니다.";

	/// <summary>
	/// Key: "Heading.RobloxOnDevice"
	/// heading Roblox on your device
	/// English String: "Roblox on your Device"
	/// </summary>
	public override string HeadingRobloxOnDevice => "어디서든 즐길 수 있어요";

	/// <summary>
	/// Key: "Heading.WhatIsRoblox"
	/// heading for what is Roblox section on the landing page
	/// English String: "What is Roblox?"
	/// </summary>
	public override string HeadingWhatIsRoblox => "Roblox란?";

	/// <summary>
	/// Key: "Heading.WhatIsRobloxParagraphTwo"
	/// second paragraph under what's Roblox on the landing page
	/// English String: "Roblox is the best place to Imagine with Friends. With the largest user-generated online gaming platform, and over 15 million games created by users, Roblox is the #1 gaming site for kids and teens (comScore). Every day, virtual explorers come to Roblox to create adventures, play games, role play, and learn with their friends in a family-friendly, immersive, 3D environment."
	/// </summary>
	public override string HeadingWhatIsRobloxParagraphTwo => "친구들과 함께 상상력을 펼기치엔 Roblox만한 곳도 없죠. Roblox는 사용자가 직접 개발한 1,500만 개 이상의 게임을 자랑하는 세계 최대의 사용자 제작 온라인 게임 플랫폼으로 어린이 및 10대가 즐겨 찾는 1등 게임 웹사이트랍니다(comScore 조사). 매일 많은 이들이 Roblox에 모여 가족 친화적 몰입형 3D 환경에서 모험을 창조하고 게임 및 역할 놀이를 즐기며 친구들과 함께 배워 나가고 있어요.";

	/// <summary>
	/// Key: "Label.About"
	/// about link on top left
	/// English String: "About"
	/// </summary>
	public override string LabelAbout => "소개";

	/// <summary>
	/// Key: "Label.GetOnGooglePlay"
	/// Google play icon title
	/// English String: "Get it on Google Play"
	/// </summary>
	public override string LabelGetOnGooglePlay => "Google Play에서 다운로드";

	/// <summary>
	/// Key: "Label.Platforms"
	/// platform link on top left
	/// English String: "Platforms"
	/// </summary>
	public override string LabelPlatforms => "플랫폼";

	/// <summary>
	/// Key: "Label.Play"
	/// play link on top left
	/// English String: "Play"
	/// </summary>
	public override string LabelPlay => "플레이";

	/// <summary>
	/// Key: "Label.RobloxAmazonStore"
	/// title for Amazon store icon
	/// English String: "Roblox on Amazon Store"
	/// </summary>
	public override string LabelRobloxAmazonStore => "Amazon 스토어용 Roblox";

	/// <summary>
	/// Key: "Label.RobloxAppStore"
	/// the title for app store icon
	/// English String: "Roblox on App Store"
	/// </summary>
	public override string LabelRobloxAppStore => "App Store용 Roblox";

	/// <summary>
	/// Key: "Label.RobloxOnXbox"
	/// title for Xbox icon
	/// English String: "Roblox on Xbox Store"
	/// </summary>
	public override string LabelRobloxOnXbox => "Xbox 스토어용 Roblox";

	/// <summary>
	/// Key: "Label.RobloxWindowsStore"
	/// title for windows store icon
	/// English String: "Roblox on Windows Store"
	/// </summary>
	public override string LabelRobloxWindowsStore => "Windows 스토어용 Roblox";

	public LandingResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForDescriptionRobloxOnDeviceParagraphOne()
	{
		return "Roblox는 최신 스마트폰, 데스크톱은 물론 Xbox One과 Oculus Rift에서도 이용할 수 있으며, 곧 Daydream과 Cardboard도 지원할 예정이랍니다. 어떤 기기에서든 즐길 수 있는 만큼 장소에 구애받지 않고 친구들과 상상의 나래를 펼 수 있지요.";
	}

	protected override string _GetTemplateForDescriptionRobloxOnDeviceParagraphTwo()
	{
		return "Roblox는 PC와 Mac 외에 iOS 및 Android, Amazon 플랫폼 기반 장치는 물론 Xbox One과 Oculus Rift에서도 이용할 수 있어요. 어떤 기기에서든 즐길 수 있는 만큼 장소에 구애받지 않고 친구들과 상상의 나래를 펼 수 있지요.";
	}

	protected override string _GetTemplateForDescriptionWhatIsRobloxParagraphOne()
	{
		return "상상력을 쑥쑥 키워주는 Roblox는 월 방문자 수 4,400만을 자랑하는 세계 최대의 소셜 게임 플랫폼으로, 지금도 계속 성장하고 있어요. Roblox에서는 사용자가 직접 모험을 창조하고, 게임을 플레이할 수 있죠. 또한, 역할 놀이를 즐기고 친구들과 함께 새로운 것들을 배울 수 있어요. 누구나 참여할 수 있는 '상상 플랫폼'. 그것이 바로 Roblox랍니다.";
	}

	protected override string _GetTemplateForHeadingRobloxOnDevice()
	{
		return "어디서든 즐길 수 있어요";
	}

	protected override string _GetTemplateForHeadingWhatIsRoblox()
	{
		return "Roblox란?";
	}

	protected override string _GetTemplateForHeadingWhatIsRobloxParagraphTwo()
	{
		return "친구들과 함께 상상력을 펼기치엔 Roblox만한 곳도 없죠. Roblox는 사용자가 직접 개발한 1,500만 개 이상의 게임을 자랑하는 세계 최대의 사용자 제작 온라인 게임 플랫폼으로 어린이 및 10대가 즐겨 찾는 1등 게임 웹사이트랍니다(comScore 조사). 매일 많은 이들이 Roblox에 모여 가족 친화적 몰입형 3D 환경에서 모험을 창조하고 게임 및 역할 놀이를 즐기며 친구들과 함께 배워 나가고 있어요.";
	}

	protected override string _GetTemplateForLabelAbout()
	{
		return "소개";
	}

	protected override string _GetTemplateForLabelGetOnGooglePlay()
	{
		return "Google Play에서 다운로드";
	}

	protected override string _GetTemplateForLabelPlatforms()
	{
		return "플랫폼";
	}

	protected override string _GetTemplateForLabelPlay()
	{
		return "플레이";
	}

	protected override string _GetTemplateForLabelRobloxAmazonStore()
	{
		return "Amazon 스토어용 Roblox";
	}

	protected override string _GetTemplateForLabelRobloxAppStore()
	{
		return "App Store용 Roblox";
	}

	protected override string _GetTemplateForLabelRobloxOnXbox()
	{
		return "Xbox 스토어용 Roblox";
	}

	protected override string _GetTemplateForLabelRobloxWindowsStore()
	{
		return "Windows 스토어용 Roblox";
	}
}
