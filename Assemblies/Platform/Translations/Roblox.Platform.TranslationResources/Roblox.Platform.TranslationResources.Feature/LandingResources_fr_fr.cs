namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides LandingResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class LandingResources_fr_fr : LandingResources_en_us, ILandingResources, ITranslationResources
{
	/// <summary>
	/// Key: "Description.RobloxOnDeviceParagraphOne"
	/// first paragraph under Roblox on your device heading on landing page
	/// English String: "You can access Roblox on all modern smartphones, desktops, Xbox One, Oculus Rift, and soon on Daydream and Cardboard. Roblox adventures are accessible from any device, so players can imagine with their friends regardless of where they are."
	/// </summary>
	public override string DescriptionRobloxOnDeviceParagraphOne => "Roblox est disponible sur smartphone, ordinateur, Xbox\u00a0One, Oculus\u00a0Rift, et bientôt sur Daydream et Cardboard. Les aventures Roblox sont accessibles sur n'importe quel appareil, ce qui permet aux joueurs de s'amuser avec leurs amis où qu'ils soient.";

	/// <summary>
	/// Key: "Description.RobloxOnDeviceParagraphTwo"
	/// second paragraph under Roblox on Your Device on landing page
	/// English String: "You can access Roblox on PC, Mac, iOS, Android, Amazon Devices, and Xbox One. Roblox adventures are accessible from any device, so players can imagine with their friends regardless of where they are."
	/// </summary>
	public override string DescriptionRobloxOnDeviceParagraphTwo => "Roblox est disponible sur PC, Mac, iOS, Android, Xbox\u00a0One et les appareils Amazon. Les aventures Roblox sont accessibles sur n'importe quel appareil, ce qui permet aux joueurs de s'amuser avec leurs amis où qu'ils soient.";

	/// <summary>
	/// Key: "Description.WhatIsRobloxParagraphOne"
	/// first paragraph under what's Roblox heading on landing page
	/// English String: "Roblox helps power the imagination of people around the world. As the largest growing social platform for play, over 44 million players come to Roblox every month to create adventures, play games, roleplay, and learn with friends. We call it the ‘Imagination Platform’ and believe everyone should have the right to play on it."
	/// </summary>
	public override string DescriptionWhatIsRobloxParagraphOne => "Roblox aide des joueurs du monde entier à développer leur imagination. En tant que plateforme de jeu multijoueur à la plus forte croissance, Roblox est fréquenté tous les mois par plus de 44\u00a0millions d'utilisateurs, qui viennent créer des d'aventures, s'amuser, faire du jeu de rôle et apprendre avec leurs amis. Nous appelons cet espace la «\u00a0plateforme de l'imagination\u00a0» et tout le monde y est le bienvenu.";

	/// <summary>
	/// Key: "Heading.RobloxOnDevice"
	/// heading Roblox on your device
	/// English String: "Roblox on your Device"
	/// </summary>
	public override string HeadingRobloxOnDevice => "Roblox sur ton appareil";

	/// <summary>
	/// Key: "Heading.WhatIsRoblox"
	/// heading for what is Roblox section on the landing page
	/// English String: "What is Roblox?"
	/// </summary>
	public override string HeadingWhatIsRoblox => "Qu'est-ce que Roblox\u00a0?";

	/// <summary>
	/// Key: "Heading.WhatIsRobloxParagraphTwo"
	/// second paragraph under what's Roblox on the landing page
	/// English String: "Roblox is the best place to Imagine with Friends. With the largest user-generated online gaming platform, and over 15 million games created by users, Roblox is the #1 gaming site for kids and teens (comScore). Every day, virtual explorers come to Roblox to create adventures, play games, role play, and learn with their friends in a family-friendly, immersive, 3D environment."
	/// </summary>
	public override string HeadingWhatIsRobloxParagraphTwo => "Roblox est l'endroit idéal pour laisser libre cours à son imagination avec ses amis. Doté de la plus grande plateforme multijoueur de jeux en ligne créés par les utilisateurs et fort de plus de 15\u00a0millions de titres, Roblox s'impose comme le premier site de jeux vidéo pour les enfants et les adolescents (source\u00a0: comScore). Chaque jour, des explorateurs virtuels se connectent à Roblox pour créer leurs aventures, s'amuser, faire du jeu de rôle et apprendre avec leurs amis dans un environnement en 3D immersif et adapté à toute la famille.";

	/// <summary>
	/// Key: "Label.About"
	/// about link on top left
	/// English String: "About"
	/// </summary>
	public override string LabelAbout => "À propos";

	/// <summary>
	/// Key: "Label.GetOnGooglePlay"
	/// Google play icon title
	/// English String: "Get it on Google Play"
	/// </summary>
	public override string LabelGetOnGooglePlay => "Télécharger sur Google Play";

	/// <summary>
	/// Key: "Label.Platforms"
	/// platform link on top left
	/// English String: "Platforms"
	/// </summary>
	public override string LabelPlatforms => "Plateformes";

	/// <summary>
	/// Key: "Label.Play"
	/// play link on top left
	/// English String: "Play"
	/// </summary>
	public override string LabelPlay => "Jouer";

	/// <summary>
	/// Key: "Label.RobloxAmazonStore"
	/// title for Amazon store icon
	/// English String: "Roblox on Amazon Store"
	/// </summary>
	public override string LabelRobloxAmazonStore => "Roblox sur l'Amazon Store";

	/// <summary>
	/// Key: "Label.RobloxAppStore"
	/// the title for app store icon
	/// English String: "Roblox on App Store"
	/// </summary>
	public override string LabelRobloxAppStore => "Roblox sur l'App Store";

	/// <summary>
	/// Key: "Label.RobloxOnXbox"
	/// title for Xbox icon
	/// English String: "Roblox on Xbox Store"
	/// </summary>
	public override string LabelRobloxOnXbox => "Roblox sur le Xbox Store";

	/// <summary>
	/// Key: "Label.RobloxWindowsStore"
	/// title for windows store icon
	/// English String: "Roblox on Windows Store"
	/// </summary>
	public override string LabelRobloxWindowsStore => "Roblox sur le Windows Store";

	public LandingResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForDescriptionRobloxOnDeviceParagraphOne()
	{
		return "Roblox est disponible sur smartphone, ordinateur, Xbox\u00a0One, Oculus\u00a0Rift, et bientôt sur Daydream et Cardboard. Les aventures Roblox sont accessibles sur n'importe quel appareil, ce qui permet aux joueurs de s'amuser avec leurs amis où qu'ils soient.";
	}

	protected override string _GetTemplateForDescriptionRobloxOnDeviceParagraphTwo()
	{
		return "Roblox est disponible sur PC, Mac, iOS, Android, Xbox\u00a0One et les appareils Amazon. Les aventures Roblox sont accessibles sur n'importe quel appareil, ce qui permet aux joueurs de s'amuser avec leurs amis où qu'ils soient.";
	}

	protected override string _GetTemplateForDescriptionWhatIsRobloxParagraphOne()
	{
		return "Roblox aide des joueurs du monde entier à développer leur imagination. En tant que plateforme de jeu multijoueur à la plus forte croissance, Roblox est fréquenté tous les mois par plus de 44\u00a0millions d'utilisateurs, qui viennent créer des d'aventures, s'amuser, faire du jeu de rôle et apprendre avec leurs amis. Nous appelons cet espace la «\u00a0plateforme de l'imagination\u00a0» et tout le monde y est le bienvenu.";
	}

	protected override string _GetTemplateForHeadingRobloxOnDevice()
	{
		return "Roblox sur ton appareil";
	}

	protected override string _GetTemplateForHeadingWhatIsRoblox()
	{
		return "Qu'est-ce que Roblox\u00a0?";
	}

	protected override string _GetTemplateForHeadingWhatIsRobloxParagraphTwo()
	{
		return "Roblox est l'endroit idéal pour laisser libre cours à son imagination avec ses amis. Doté de la plus grande plateforme multijoueur de jeux en ligne créés par les utilisateurs et fort de plus de 15\u00a0millions de titres, Roblox s'impose comme le premier site de jeux vidéo pour les enfants et les adolescents (source\u00a0: comScore). Chaque jour, des explorateurs virtuels se connectent à Roblox pour créer leurs aventures, s'amuser, faire du jeu de rôle et apprendre avec leurs amis dans un environnement en 3D immersif et adapté à toute la famille.";
	}

	protected override string _GetTemplateForLabelAbout()
	{
		return "À propos";
	}

	protected override string _GetTemplateForLabelGetOnGooglePlay()
	{
		return "Télécharger sur Google Play";
	}

	protected override string _GetTemplateForLabelPlatforms()
	{
		return "Plateformes";
	}

	protected override string _GetTemplateForLabelPlay()
	{
		return "Jouer";
	}

	protected override string _GetTemplateForLabelRobloxAmazonStore()
	{
		return "Roblox sur l'Amazon Store";
	}

	protected override string _GetTemplateForLabelRobloxAppStore()
	{
		return "Roblox sur l'App Store";
	}

	protected override string _GetTemplateForLabelRobloxOnXbox()
	{
		return "Roblox sur le Xbox Store";
	}

	protected override string _GetTemplateForLabelRobloxWindowsStore()
	{
		return "Roblox sur le Windows Store";
	}
}
