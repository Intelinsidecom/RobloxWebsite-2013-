namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides LandingResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class LandingResources_zh_cjv : LandingResources_en_us, ILandingResources, ITranslationResources
{
	/// <summary>
	/// Key: "Description.RobloxOnDeviceParagraphOne"
	/// first paragraph under Roblox on your device heading on landing page
	/// English String: "You can access Roblox on all modern smartphones, desktops, Xbox One, Oculus Rift, and soon on Daydream and Cardboard. Roblox adventures are accessible from any device, so players can imagine with their friends regardless of where they are."
	/// </summary>
	public override string DescriptionRobloxOnDeviceParagraphOne => "你可以在所有现代智能手机、桌面电脑、Xbox One、Oculus Rift 上访问 Roblox，不久后还将支持 Daydream 和 Cardboard。你可以从任何设备上加入 Roblox 的冒险历程，无论玩家身在何处，都能与好友一起充分发挥想象力。\n\n";

	/// <summary>
	/// Key: "Description.RobloxOnDeviceParagraphTwo"
	/// second paragraph under Roblox on Your Device on landing page
	/// English String: "You can access Roblox on PC, Mac, iOS, Android, Amazon Devices, and Xbox One. Roblox adventures are accessible from any device, so players can imagine with their friends regardless of where they are."
	/// </summary>
	public override string DescriptionRobloxOnDeviceParagraphTwo => "你可以在所有 PC、Mac、iOS、Android、Amazon 设备和 Xbox One 上访问 Roblox。不久后还将支持 Daydream 和 Cardboard。你可以从任何设备上加入 Roblox 的冒险历程，无论玩家身在何处，都能与好友一起充分发挥想象力。";

	/// <summary>
	/// Key: "Description.WhatIsRobloxParagraphOne"
	/// first paragraph under what's Roblox heading on landing page
	/// English String: "Roblox helps power the imagination of people around the world. As the largest growing social platform for play, over 44 million players come to Roblox every month to create adventures, play games, roleplay, and learn with friends. We call it the ‘Imagination Platform’ and believe everyone should have the right to play on it."
	/// </summary>
	public override string DescriptionWhatIsRobloxParagraphOne => "Roblox 让全世界的人们展开想象的翅膀。作为不断壮大的社交性游戏平台，每月有多达 4400 万玩家来到 Roblox。不管是玩游戏、角色扮演，还是与好友一起学习，这个我们称为“想象力平台”的地方欢迎所有人的加入。";

	/// <summary>
	/// Key: "Heading.RobloxOnDevice"
	/// heading Roblox on your device
	/// English String: "Roblox on your Device"
	/// </summary>
	public override string HeadingRobloxOnDevice => "你设备上的 Roblox";

	/// <summary>
	/// Key: "Heading.WhatIsRoblox"
	/// heading for what is Roblox section on the landing page
	/// English String: "What is Roblox?"
	/// </summary>
	public override string HeadingWhatIsRoblox => "Roblox 是什么？";

	/// <summary>
	/// Key: "Heading.WhatIsRobloxParagraphTwo"
	/// second paragraph under what's Roblox on the landing page
	/// English String: "Roblox is the best place to Imagine with Friends. With the largest user-generated online gaming platform, and over 15 million games created by users, Roblox is the #1 gaming site for kids and teens (comScore). Every day, virtual explorers come to Roblox to create adventures, play games, role play, and learn with their friends in a family-friendly, immersive, 3D environment."
	/// </summary>
	public override string HeadingWhatIsRobloxParagraphTwo => "Roblox 让你与好友一起展开想象的翅膀。作为最大的用户创作在线游戏平台，Roblox 拥有超过 1500 万个由用户自主创作的游戏，这也让美国公司 comScore 认证 Roblox 为儿童及青少年游戏网站的首选。每天都有虚拟探险家前往 Roblox 这个老少皆宜、身临其境的 3D 环境和好友一起学习，玩耍，开启属于他们自己的冒险之旅。";

	/// <summary>
	/// Key: "Label.About"
	/// about link on top left
	/// English String: "About"
	/// </summary>
	public override string LabelAbout => "关于";

	/// <summary>
	/// Key: "Label.GetOnGooglePlay"
	/// Google play icon title
	/// English String: "Get it on Google Play"
	/// </summary>
	public override string LabelGetOnGooglePlay => "从 Google Play 上获取";

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
	public override string LabelPlay => "游戏";

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
	public override string LabelRobloxOnXbox => "Xbox 商店上的 Roblox";

	/// <summary>
	/// Key: "Label.RobloxWindowsStore"
	/// title for windows store icon
	/// English String: "Roblox on Windows Store"
	/// </summary>
	public override string LabelRobloxWindowsStore => "Windows 应用商店上的 Roblox";

	public LandingResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForDescriptionRobloxOnDeviceParagraphOne()
	{
		return "你可以在所有现代智能手机、桌面电脑、Xbox One、Oculus Rift 上访问 Roblox，不久后还将支持 Daydream 和 Cardboard。你可以从任何设备上加入 Roblox 的冒险历程，无论玩家身在何处，都能与好友一起充分发挥想象力。\n\n";
	}

	protected override string _GetTemplateForDescriptionRobloxOnDeviceParagraphTwo()
	{
		return "你可以在所有 PC、Mac、iOS、Android、Amazon 设备和 Xbox One 上访问 Roblox。不久后还将支持 Daydream 和 Cardboard。你可以从任何设备上加入 Roblox 的冒险历程，无论玩家身在何处，都能与好友一起充分发挥想象力。";
	}

	protected override string _GetTemplateForDescriptionWhatIsRobloxParagraphOne()
	{
		return "Roblox 让全世界的人们展开想象的翅膀。作为不断壮大的社交性游戏平台，每月有多达 4400 万玩家来到 Roblox。不管是玩游戏、角色扮演，还是与好友一起学习，这个我们称为“想象力平台”的地方欢迎所有人的加入。";
	}

	protected override string _GetTemplateForHeadingRobloxOnDevice()
	{
		return "你设备上的 Roblox";
	}

	protected override string _GetTemplateForHeadingWhatIsRoblox()
	{
		return "Roblox 是什么？";
	}

	protected override string _GetTemplateForHeadingWhatIsRobloxParagraphTwo()
	{
		return "Roblox 让你与好友一起展开想象的翅膀。作为最大的用户创作在线游戏平台，Roblox 拥有超过 1500 万个由用户自主创作的游戏，这也让美国公司 comScore 认证 Roblox 为儿童及青少年游戏网站的首选。每天都有虚拟探险家前往 Roblox 这个老少皆宜、身临其境的 3D 环境和好友一起学习，玩耍，开启属于他们自己的冒险之旅。";
	}

	protected override string _GetTemplateForLabelAbout()
	{
		return "关于";
	}

	protected override string _GetTemplateForLabelGetOnGooglePlay()
	{
		return "从 Google Play 上获取";
	}

	protected override string _GetTemplateForLabelPlatforms()
	{
		return "平台";
	}

	protected override string _GetTemplateForLabelPlay()
	{
		return "游戏";
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
		return "Xbox 商店上的 Roblox";
	}

	protected override string _GetTemplateForLabelRobloxWindowsStore()
	{
		return "Windows 应用商店上的 Roblox";
	}
}
