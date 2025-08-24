namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides LandingResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class LandingResources_pt_br : LandingResources_en_us, ILandingResources, ITranslationResources
{
	/// <summary>
	/// Key: "Description.RobloxOnDeviceParagraphOne"
	/// first paragraph under Roblox on your device heading on landing page
	/// English String: "You can access Roblox on all modern smartphones, desktops, Xbox One, Oculus Rift, and soon on Daydream and Cardboard. Roblox adventures are accessible from any device, so players can imagine with their friends regardless of where they are."
	/// </summary>
	public override string DescriptionRobloxOnDeviceParagraphOne => "Você pode acessar Roblox em todos os smartphones modernos, desktops, Xbox One, Oculus Rift e em breve em Daydream e Cardboard. As aventuras do Roblox podem ser jogadas em qualquer dispositivo, ou seja, você pode imaginar com seus amigos onde quer que estejam.";

	/// <summary>
	/// Key: "Description.RobloxOnDeviceParagraphTwo"
	/// second paragraph under Roblox on Your Device on landing page
	/// English String: "You can access Roblox on PC, Mac, iOS, Android, Amazon Devices, and Xbox One. Roblox adventures are accessible from any device, so players can imagine with their friends regardless of where they are."
	/// </summary>
	public override string DescriptionRobloxOnDeviceParagraphTwo => "Você pode acessar Roblox em PC, Mac, iOS, Android, dispositivos Amazon e Xbox One. As aventuras do Roblox podem ser jogadas em qualquer dispositivo, ou seja, você pode imaginar com seus amigos onde quer que estejam.";

	/// <summary>
	/// Key: "Description.WhatIsRobloxParagraphOne"
	/// first paragraph under what's Roblox heading on landing page
	/// English String: "Roblox helps power the imagination of people around the world. As the largest growing social platform for play, over 44 million players come to Roblox every month to create adventures, play games, roleplay, and learn with friends. We call it the ‘Imagination Platform’ and believe everyone should have the right to play on it."
	/// </summary>
	public override string DescriptionWhatIsRobloxParagraphOne => "Roblox dá asas à imaginação de pessoas no mundo todo. Como a plataforma social para jogo que mais cresce, Roblox conta com mais de 44 milhões de jogadores que se conectam todo mês para criar, jogar, brincar e aprender com os amigos. Chamamos nosso app de uma ‘plataforma de imaginação’ e acreditamos que todos devem ter o direito de jogar nele.";

	/// <summary>
	/// Key: "Heading.RobloxOnDevice"
	/// heading Roblox on your device
	/// English String: "Roblox on your Device"
	/// </summary>
	public override string HeadingRobloxOnDevice => "Roblox no seu dispositivo";

	/// <summary>
	/// Key: "Heading.WhatIsRoblox"
	/// heading for what is Roblox section on the landing page
	/// English String: "What is Roblox?"
	/// </summary>
	public override string HeadingWhatIsRoblox => "O que é Roblox?";

	/// <summary>
	/// Key: "Heading.WhatIsRobloxParagraphTwo"
	/// second paragraph under what's Roblox on the landing page
	/// English String: "Roblox is the best place to Imagine with Friends. With the largest user-generated online gaming platform, and over 15 million games created by users, Roblox is the #1 gaming site for kids and teens (comScore). Every day, virtual explorers come to Roblox to create adventures, play games, role play, and learn with their friends in a family-friendly, immersive, 3D environment."
	/// </summary>
	public override string HeadingWhatIsRobloxParagraphTwo => "Roblox é o melhor lugar para imaginar com seus amigos. Com a maior plataforma de jogo online gerado por usuários e mais de 15 milhões de jogos criados, Roblox é o site nº 1 para crianças e adolescentes (comScore). Todo dia, exploradores virtuais se conectam ao Roblox para criar aventuras, jogar, imaginar e aprender com seus amigos em um ambiente 3D familiar e imersivo.";

	/// <summary>
	/// Key: "Label.About"
	/// about link on top left
	/// English String: "About"
	/// </summary>
	public override string LabelAbout => "Sobre";

	/// <summary>
	/// Key: "Label.GetOnGooglePlay"
	/// Google play icon title
	/// English String: "Get it on Google Play"
	/// </summary>
	public override string LabelGetOnGooglePlay => "Baixe no Google Play";

	/// <summary>
	/// Key: "Label.Platforms"
	/// platform link on top left
	/// English String: "Platforms"
	/// </summary>
	public override string LabelPlatforms => "Plataformas";

	/// <summary>
	/// Key: "Label.Play"
	/// play link on top left
	/// English String: "Play"
	/// </summary>
	public override string LabelPlay => "Jogar";

	/// <summary>
	/// Key: "Label.RobloxAmazonStore"
	/// title for Amazon store icon
	/// English String: "Roblox on Amazon Store"
	/// </summary>
	public override string LabelRobloxAmazonStore => "Roblox na Amazon Store";

	/// <summary>
	/// Key: "Label.RobloxAppStore"
	/// the title for app store icon
	/// English String: "Roblox on App Store"
	/// </summary>
	public override string LabelRobloxAppStore => "Roblox na App Store";

	/// <summary>
	/// Key: "Label.RobloxOnXbox"
	/// title for Xbox icon
	/// English String: "Roblox on Xbox Store"
	/// </summary>
	public override string LabelRobloxOnXbox => "Roblox na Xbox Store";

	/// <summary>
	/// Key: "Label.RobloxWindowsStore"
	/// title for windows store icon
	/// English String: "Roblox on Windows Store"
	/// </summary>
	public override string LabelRobloxWindowsStore => "Roblox na Windows Store";

	public LandingResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForDescriptionRobloxOnDeviceParagraphOne()
	{
		return "Você pode acessar Roblox em todos os smartphones modernos, desktops, Xbox One, Oculus Rift e em breve em Daydream e Cardboard. As aventuras do Roblox podem ser jogadas em qualquer dispositivo, ou seja, você pode imaginar com seus amigos onde quer que estejam.";
	}

	protected override string _GetTemplateForDescriptionRobloxOnDeviceParagraphTwo()
	{
		return "Você pode acessar Roblox em PC, Mac, iOS, Android, dispositivos Amazon e Xbox One. As aventuras do Roblox podem ser jogadas em qualquer dispositivo, ou seja, você pode imaginar com seus amigos onde quer que estejam.";
	}

	protected override string _GetTemplateForDescriptionWhatIsRobloxParagraphOne()
	{
		return "Roblox dá asas à imaginação de pessoas no mundo todo. Como a plataforma social para jogo que mais cresce, Roblox conta com mais de 44 milhões de jogadores que se conectam todo mês para criar, jogar, brincar e aprender com os amigos. Chamamos nosso app de uma ‘plataforma de imaginação’ e acreditamos que todos devem ter o direito de jogar nele.";
	}

	protected override string _GetTemplateForHeadingRobloxOnDevice()
	{
		return "Roblox no seu dispositivo";
	}

	protected override string _GetTemplateForHeadingWhatIsRoblox()
	{
		return "O que é Roblox?";
	}

	protected override string _GetTemplateForHeadingWhatIsRobloxParagraphTwo()
	{
		return "Roblox é o melhor lugar para imaginar com seus amigos. Com a maior plataforma de jogo online gerado por usuários e mais de 15 milhões de jogos criados, Roblox é o site nº 1 para crianças e adolescentes (comScore). Todo dia, exploradores virtuais se conectam ao Roblox para criar aventuras, jogar, imaginar e aprender com seus amigos em um ambiente 3D familiar e imersivo.";
	}

	protected override string _GetTemplateForLabelAbout()
	{
		return "Sobre";
	}

	protected override string _GetTemplateForLabelGetOnGooglePlay()
	{
		return "Baixe no Google Play";
	}

	protected override string _GetTemplateForLabelPlatforms()
	{
		return "Plataformas";
	}

	protected override string _GetTemplateForLabelPlay()
	{
		return "Jogar";
	}

	protected override string _GetTemplateForLabelRobloxAmazonStore()
	{
		return "Roblox na Amazon Store";
	}

	protected override string _GetTemplateForLabelRobloxAppStore()
	{
		return "Roblox na App Store";
	}

	protected override string _GetTemplateForLabelRobloxOnXbox()
	{
		return "Roblox na Xbox Store";
	}

	protected override string _GetTemplateForLabelRobloxWindowsStore()
	{
		return "Roblox na Windows Store";
	}
}
