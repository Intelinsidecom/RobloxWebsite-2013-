namespace Roblox.TranslationResources.Feature;

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
	public override string DescriptionRobloxOnDeviceParagraphOne => "Roblox 可以透過所有現代智慧型手機、電腦、Xbox One 及 Oculus Rift 遊玩，未來也將支援 Daydream 和 Cardboard。您可以從以上裝置開始您的 Roblox 旅程，玩家隨時隨地都可以和好友發揮想像力。";

	/// <summary>
	/// Key: "Description.RobloxOnDeviceParagraphTwo"
	/// second paragraph under Roblox on Your Device on landing page
	/// English String: "You can access Roblox on PC, Mac, iOS, Android, Amazon Devices, and Xbox One. Roblox adventures are accessible from any device, so players can imagine with their friends regardless of where they are."
	/// </summary>
	public override string DescriptionRobloxOnDeviceParagraphTwo => "Roblox 可以透過透過 PC、Mac、iOS、Android、Amazon 裝置及 Xbox One 遊玩。您可以從以上裝置開始您的 Roblox 旅程，玩家隨時隨地都可以和好友發揮想像力。";

	/// <summary>
	/// Key: "Description.WhatIsRobloxParagraphOne"
	/// first paragraph under what's Roblox heading on landing page
	/// English String: "Roblox helps power the imagination of people around the world. As the largest growing social platform for play, over 44 million players come to Roblox every month to create adventures, play games, roleplay, and learn with friends. We call it the ‘Imagination Platform’ and believe everyone should have the right to play on it."
	/// </summary>
	public override string DescriptionWhatIsRobloxParagraphOne => "Roblox 可以激發全世界的人的想像力。作為最龐大且持續成長的社交平台，每個月有超過 4400 萬名玩家在 Roblox 一起創作、遊樂與學習。我們稱之為「想像力平台」，並堅信每個人都應該來此遊玩。";

	/// <summary>
	/// Key: "Heading.RobloxOnDevice"
	/// heading Roblox on your device
	/// English String: "Roblox on your Device"
	/// </summary>
	public override string HeadingRobloxOnDevice => "在您的裝置玩 Roblox";

	/// <summary>
	/// Key: "Heading.WhatIsRoblox"
	/// heading for what is Roblox section on the landing page
	/// English String: "What is Roblox?"
	/// </summary>
	public override string HeadingWhatIsRoblox => "Roblox 是什麼？";

	/// <summary>
	/// Key: "Heading.WhatIsRobloxParagraphTwo"
	/// second paragraph under what's Roblox on the landing page
	/// English String: "Roblox is the best place to Imagine with Friends. With the largest user-generated online gaming platform, and over 15 million games created by users, Roblox is the #1 gaming site for kids and teens (comScore). Every day, virtual explorers come to Roblox to create adventures, play games, role play, and learn with their friends in a family-friendly, immersive, 3D environment."
	/// </summary>
	public override string HeadingWhatIsRobloxParagraphTwo => "Roblox 是與朋友發揮想像力的最佳場所。作為最大的使用者創作線上遊戲平台，Roblox 擁有超過 1500 萬款全由使用者創作的遊戲，這也使得美國公司 comScore 認證 Roblox 為兒童及青少年遊戲網站的首選。每天都有虛擬探險家前往 Roblox 老少咸宜、身歷其境的 3D 環境一起創作、遊樂與學習。";

	/// <summary>
	/// Key: "Label.About"
	/// about link on top left
	/// English String: "About"
	/// </summary>
	public override string LabelAbout => "介紹";

	/// <summary>
	/// Key: "Label.GetOnGooglePlay"
	/// Google play icon title
	/// English String: "Get it on Google Play"
	/// </summary>
	public override string LabelGetOnGooglePlay => "從 Google Play 取得";

	/// <summary>
	/// Key: "Label.Platforms"
	/// platform link on top left
	/// English String: "Platforms"
	/// </summary>
	public override string LabelPlatforms => "平台";

	/// <summary>
	/// Key: "Label.Play"
	/// play link on top left
	/// English String: "Play"
	/// </summary>
	public override string LabelPlay => "遊戲";

	/// <summary>
	/// Key: "Label.RobloxAmazonStore"
	/// title for Amazon store icon
	/// English String: "Roblox on Amazon Store"
	/// </summary>
	public override string LabelRobloxAmazonStore => "Amazon 商店上的 Roblox";

	/// <summary>
	/// Key: "Label.RobloxAppStore"
	/// the title for app store icon
	/// English String: "Roblox on App Store"
	/// </summary>
	public override string LabelRobloxAppStore => "App Store 上的 Roblox";

	/// <summary>
	/// Key: "Label.RobloxOnXbox"
	/// title for Xbox icon
	/// English String: "Roblox on Xbox Store"
	/// </summary>
	public override string LabelRobloxOnXbox => "Xbox Store 上的 Roblox";

	/// <summary>
	/// Key: "Label.RobloxWindowsStore"
	/// title for windows store icon
	/// English String: "Roblox on Windows Store"
	/// </summary>
	public override string LabelRobloxWindowsStore => "Windows Store 上的 Roblox";

	public LandingResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForDescriptionRobloxOnDeviceParagraphOne()
	{
		return "Roblox 可以透過所有現代智慧型手機、電腦、Xbox One 及 Oculus Rift 遊玩，未來也將支援 Daydream 和 Cardboard。您可以從以上裝置開始您的 Roblox 旅程，玩家隨時隨地都可以和好友發揮想像力。";
	}

	protected override string _GetTemplateForDescriptionRobloxOnDeviceParagraphTwo()
	{
		return "Roblox 可以透過透過 PC、Mac、iOS、Android、Amazon 裝置及 Xbox One 遊玩。您可以從以上裝置開始您的 Roblox 旅程，玩家隨時隨地都可以和好友發揮想像力。";
	}

	protected override string _GetTemplateForDescriptionWhatIsRobloxParagraphOne()
	{
		return "Roblox 可以激發全世界的人的想像力。作為最龐大且持續成長的社交平台，每個月有超過 4400 萬名玩家在 Roblox 一起創作、遊樂與學習。我們稱之為「想像力平台」，並堅信每個人都應該來此遊玩。";
	}

	protected override string _GetTemplateForHeadingRobloxOnDevice()
	{
		return "在您的裝置玩 Roblox";
	}

	protected override string _GetTemplateForHeadingWhatIsRoblox()
	{
		return "Roblox 是什麼？";
	}

	protected override string _GetTemplateForHeadingWhatIsRobloxParagraphTwo()
	{
		return "Roblox 是與朋友發揮想像力的最佳場所。作為最大的使用者創作線上遊戲平台，Roblox 擁有超過 1500 萬款全由使用者創作的遊戲，這也使得美國公司 comScore 認證 Roblox 為兒童及青少年遊戲網站的首選。每天都有虛擬探險家前往 Roblox 老少咸宜、身歷其境的 3D 環境一起創作、遊樂與學習。";
	}

	protected override string _GetTemplateForLabelAbout()
	{
		return "介紹";
	}

	protected override string _GetTemplateForLabelGetOnGooglePlay()
	{
		return "從 Google Play 取得";
	}

	protected override string _GetTemplateForLabelPlatforms()
	{
		return "平台";
	}

	protected override string _GetTemplateForLabelPlay()
	{
		return "遊戲";
	}

	protected override string _GetTemplateForLabelRobloxAmazonStore()
	{
		return "Amazon 商店上的 Roblox";
	}

	protected override string _GetTemplateForLabelRobloxAppStore()
	{
		return "App Store 上的 Roblox";
	}

	protected override string _GetTemplateForLabelRobloxOnXbox()
	{
		return "Xbox Store 上的 Roblox";
	}

	protected override string _GetTemplateForLabelRobloxWindowsStore()
	{
		return "Windows Store 上的 Roblox";
	}
}
