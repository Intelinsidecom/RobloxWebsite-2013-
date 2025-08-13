namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides LandingResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class LandingResources_ja_jp : LandingResources_en_us, ILandingResources, ITranslationResources
{
	/// <summary>
	/// Key: "Description.RobloxOnDeviceParagraphOne"
	/// first paragraph under Roblox on your device heading on landing page
	/// English String: "You can access Roblox on all modern smartphones, desktops, Xbox One, Oculus Rift, and soon on Daydream and Cardboard. Roblox adventures are accessible from any device, so players can imagine with their friends regardless of where they are."
	/// </summary>
	public override string DescriptionRobloxOnDeviceParagraphOne => "Robloxには、最近のスマートフォン、デスクトップ、Xbox One、Oculus Riftなどあらゆる機種から、さらに近日中には、DayDream、CardBoardなどからもアクセスできるようになります。Robloxのアドベンチャーには、あらゆるデバイスからアクセスできるため、どこにいても友達と一緒にイマジネーションを形にすることができるのです。";

	/// <summary>
	/// Key: "Description.RobloxOnDeviceParagraphTwo"
	/// second paragraph under Roblox on Your Device on landing page
	/// English String: "You can access Roblox on PC, Mac, iOS, Android, Amazon Devices, and Xbox One. Roblox adventures are accessible from any device, so players can imagine with their friends regardless of where they are."
	/// </summary>
	public override string DescriptionRobloxOnDeviceParagraphTwo => "Robloxには、PC、Mac、iOS、Android、Amazonデバイス、Xbox Oneからアクセスできます。Robloxのアドベンチャーには、あらゆるデバイスからアクセスできるため、どこにいても友達と一緒にイマジネーションを形にすることができるのです。";

	/// <summary>
	/// Key: "Description.WhatIsRobloxParagraphOne"
	/// first paragraph under what's Roblox heading on landing page
	/// English String: "Roblox helps power the imagination of people around the world. As the largest growing social platform for play, over 44 million players come to Roblox every month to create adventures, play games, roleplay, and learn with friends. We call it the ‘Imagination Platform’ and believe everyone should have the right to play on it."
	/// </summary>
	public override string DescriptionWhatIsRobloxParagraphOne => "Robloxは、世界中の人々のイマジネーションを膨らませる原動力になっています。世界最大のソーシャルプラットフォームとして、4400万人以上のプレイヤーが毎月Robloxにアクセスして、アドベンチャーを制作したり、ゲームをプレイしたり、ロールプレイゲームをしたり、ゲームを通して友達と一緒に学んでいます。まさに「イマジネーションのプラットフォーム」であり、ぜひとも皆さんに体験していただきたいと考えています。";

	/// <summary>
	/// Key: "Heading.RobloxOnDevice"
	/// heading Roblox on your device
	/// English String: "Roblox on your Device"
	/// </summary>
	public override string HeadingRobloxOnDevice => "あなたのデバイスのRoblox";

	/// <summary>
	/// Key: "Heading.WhatIsRoblox"
	/// heading for what is Roblox section on the landing page
	/// English String: "What is Roblox?"
	/// </summary>
	public override string HeadingWhatIsRoblox => "Robloxとは？";

	/// <summary>
	/// Key: "Heading.WhatIsRobloxParagraphTwo"
	/// second paragraph under what's Roblox on the landing page
	/// English String: "Roblox is the best place to Imagine with Friends. With the largest user-generated online gaming platform, and over 15 million games created by users, Roblox is the #1 gaming site for kids and teens (comScore). Every day, virtual explorers come to Roblox to create adventures, play games, role play, and learn with their friends in a family-friendly, immersive, 3D environment."
	/// </summary>
	public override string HeadingWhatIsRobloxParagraphTwo => "Robloxは、友達と一緒にイマジネーションを膨らませるのにベストな場所です。世界最大のユーザーが作り上げたオンラインゲームプラットフォームと、ユーザーの開発した1500万件のゲームラインアップを誇るRobloxは、子供たちにとってナンバーワンのゲームサイトです（comScore社評）。毎日、バーチャルな探検家がRobloxを訪れて、ファミリーフレンドリーで雰囲気抜群の3D環境で、アドベンチャーゲームを制作したり、ゲームをプレイしたり、ロールプレイをしたり、ゲームを通して友達と一緒に学んでいるのです。";

	/// <summary>
	/// Key: "Label.About"
	/// about link on top left
	/// English String: "About"
	/// </summary>
	public override string LabelAbout => "情報";

	/// <summary>
	/// Key: "Label.GetOnGooglePlay"
	/// Google play icon title
	/// English String: "Get it on Google Play"
	/// </summary>
	public override string LabelGetOnGooglePlay => "Google Playでゲット";

	/// <summary>
	/// Key: "Label.Platforms"
	/// platform link on top left
	/// English String: "Platforms"
	/// </summary>
	public override string LabelPlatforms => "プラットフォーム";

	/// <summary>
	/// Key: "Label.Play"
	/// play link on top left
	/// English String: "Play"
	/// </summary>
	public override string LabelPlay => "プレイ";

	/// <summary>
	/// Key: "Label.RobloxAmazonStore"
	/// title for Amazon store icon
	/// English String: "Roblox on Amazon Store"
	/// </summary>
	public override string LabelRobloxAmazonStore => "Amazon StoreのRoblox";

	/// <summary>
	/// Key: "Label.RobloxAppStore"
	/// the title for app store icon
	/// English String: "Roblox on App Store"
	/// </summary>
	public override string LabelRobloxAppStore => "App StoreのRoblox";

	/// <summary>
	/// Key: "Label.RobloxOnXbox"
	/// title for Xbox icon
	/// English String: "Roblox on Xbox Store"
	/// </summary>
	public override string LabelRobloxOnXbox => "Xbox StoreのRoblox";

	/// <summary>
	/// Key: "Label.RobloxWindowsStore"
	/// title for windows store icon
	/// English String: "Roblox on Windows Store"
	/// </summary>
	public override string LabelRobloxWindowsStore => "Windows StoreのRoblox";

	public LandingResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForDescriptionRobloxOnDeviceParagraphOne()
	{
		return "Robloxには、最近のスマートフォン、デスクトップ、Xbox One、Oculus Riftなどあらゆる機種から、さらに近日中には、DayDream、CardBoardなどからもアクセスできるようになります。Robloxのアドベンチャーには、あらゆるデバイスからアクセスできるため、どこにいても友達と一緒にイマジネーションを形にすることができるのです。";
	}

	protected override string _GetTemplateForDescriptionRobloxOnDeviceParagraphTwo()
	{
		return "Robloxには、PC、Mac、iOS、Android、Amazonデバイス、Xbox Oneからアクセスできます。Robloxのアドベンチャーには、あらゆるデバイスからアクセスできるため、どこにいても友達と一緒にイマジネーションを形にすることができるのです。";
	}

	protected override string _GetTemplateForDescriptionWhatIsRobloxParagraphOne()
	{
		return "Robloxは、世界中の人々のイマジネーションを膨らませる原動力になっています。世界最大のソーシャルプラットフォームとして、4400万人以上のプレイヤーが毎月Robloxにアクセスして、アドベンチャーを制作したり、ゲームをプレイしたり、ロールプレイゲームをしたり、ゲームを通して友達と一緒に学んでいます。まさに「イマジネーションのプラットフォーム」であり、ぜひとも皆さんに体験していただきたいと考えています。";
	}

	protected override string _GetTemplateForHeadingRobloxOnDevice()
	{
		return "あなたのデバイスのRoblox";
	}

	protected override string _GetTemplateForHeadingWhatIsRoblox()
	{
		return "Robloxとは？";
	}

	protected override string _GetTemplateForHeadingWhatIsRobloxParagraphTwo()
	{
		return "Robloxは、友達と一緒にイマジネーションを膨らませるのにベストな場所です。世界最大のユーザーが作り上げたオンラインゲームプラットフォームと、ユーザーの開発した1500万件のゲームラインアップを誇るRobloxは、子供たちにとってナンバーワンのゲームサイトです（comScore社評）。毎日、バーチャルな探検家がRobloxを訪れて、ファミリーフレンドリーで雰囲気抜群の3D環境で、アドベンチャーゲームを制作したり、ゲームをプレイしたり、ロールプレイをしたり、ゲームを通して友達と一緒に学んでいるのです。";
	}

	protected override string _GetTemplateForLabelAbout()
	{
		return "情報";
	}

	protected override string _GetTemplateForLabelGetOnGooglePlay()
	{
		return "Google Playでゲット";
	}

	protected override string _GetTemplateForLabelPlatforms()
	{
		return "プラットフォーム";
	}

	protected override string _GetTemplateForLabelPlay()
	{
		return "プレイ";
	}

	protected override string _GetTemplateForLabelRobloxAmazonStore()
	{
		return "Amazon StoreのRoblox";
	}

	protected override string _GetTemplateForLabelRobloxAppStore()
	{
		return "App StoreのRoblox";
	}

	protected override string _GetTemplateForLabelRobloxOnXbox()
	{
		return "Xbox StoreのRoblox";
	}

	protected override string _GetTemplateForLabelRobloxWindowsStore()
	{
		return "Windows StoreのRoblox";
	}
}
