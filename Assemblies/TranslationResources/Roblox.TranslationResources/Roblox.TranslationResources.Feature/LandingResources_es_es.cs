namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides LandingResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class LandingResources_es_es : LandingResources_en_us, ILandingResources, ITranslationResources
{
	/// <summary>
	/// Key: "Description.RobloxOnDeviceParagraphOne"
	/// first paragraph under Roblox on your device heading on landing page
	/// English String: "You can access Roblox on all modern smartphones, desktops, Xbox One, Oculus Rift, and soon on Daydream and Cardboard. Roblox adventures are accessible from any device, so players can imagine with their friends regardless of where they are."
	/// </summary>
	public override string DescriptionRobloxOnDeviceParagraphOne => "Puedes acceder a Roblox desde cualquier teléfono inteligente, ordenador de sobremesa, Xbox One, Oculus Rift, y pronto Daydream y Cardboard. Las aventuras de Roblox están disponibles en todos los dispositivos para que los jugadores puedan imaginar con sus amigos sin importar donde estén.";

	/// <summary>
	/// Key: "Description.RobloxOnDeviceParagraphTwo"
	/// second paragraph under Roblox on Your Device on landing page
	/// English String: "You can access Roblox on PC, Mac, iOS, Android, Amazon Devices, and Xbox One. Roblox adventures are accessible from any device, so players can imagine with their friends regardless of where they are."
	/// </summary>
	public override string DescriptionRobloxOnDeviceParagraphTwo => "Puedes acceder a Roblox en tu PC, Mac, iOS, Android, dispositivos Amazon y Xbox One. Las aventuras de Roblox son accesibles desde cualquier dispositivo para que los jugadores puedan imaginar con sus amigos sin importar donde estén.";

	/// <summary>
	/// Key: "Description.WhatIsRobloxParagraphOne"
	/// first paragraph under what's Roblox heading on landing page
	/// English String: "Roblox helps power the imagination of people around the world. As the largest growing social platform for play, over 44 million players come to Roblox every month to create adventures, play games, roleplay, and learn with friends. We call it the ‘Imagination Platform’ and believe everyone should have the right to play on it."
	/// </summary>
	public override string DescriptionWhatIsRobloxParagraphOne => "Roblox potencia la imaginación de la gente de todo el mundo. Cada mes, más de 44 millones de jugadores visitan Roblox para crear aventuras, jugar, participar en juegos de rol y aprender con amigos, en la plataforma social para jugar de mayor crecimiento. La llamamos «la plataforma de la imaginación» y queremos que todos puedan acceder a ella.";

	/// <summary>
	/// Key: "Heading.RobloxOnDevice"
	/// heading Roblox on your device
	/// English String: "Roblox on your Device"
	/// </summary>
	public override string HeadingRobloxOnDevice => "Roblox en tu dispositivo";

	/// <summary>
	/// Key: "Heading.WhatIsRoblox"
	/// heading for what is Roblox section on the landing page
	/// English String: "What is Roblox?"
	/// </summary>
	public override string HeadingWhatIsRoblox => "¿Qué es Roblox?";

	/// <summary>
	/// Key: "Heading.WhatIsRobloxParagraphTwo"
	/// second paragraph under what's Roblox on the landing page
	/// English String: "Roblox is the best place to Imagine with Friends. With the largest user-generated online gaming platform, and over 15 million games created by users, Roblox is the #1 gaming site for kids and teens (comScore). Every day, virtual explorers come to Roblox to create adventures, play games, role play, and learn with their friends in a family-friendly, immersive, 3D environment."
	/// </summary>
	public override string HeadingWhatIsRobloxParagraphTwo => "Roblox es el mejor lugar para imaginar con amigos. Con la mayor plataforma de juegos en línea generados por usuarios y más de 15 millones de creaciones, Roblox ocupa el primer puesto entre los sitios de juegos para niños y adolescentes (comScore). Cada día, exploradores virtuales nos visitan para crear aventuras, jugar, participar en juegos de rol y aprender con amigos, en un entorno 3D inmersivo y apto para toda la familia.";

	/// <summary>
	/// Key: "Label.About"
	/// about link on top left
	/// English String: "About"
	/// </summary>
	public override string LabelAbout => "Acerca de Roblox";

	/// <summary>
	/// Key: "Label.GetOnGooglePlay"
	/// Google play icon title
	/// English String: "Get it on Google Play"
	/// </summary>
	public override string LabelGetOnGooglePlay => "Consíguelo en Google Play";

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
	public override string LabelPlay => "Jugar";

	/// <summary>
	/// Key: "Label.RobloxAmazonStore"
	/// title for Amazon store icon
	/// English String: "Roblox on Amazon Store"
	/// </summary>
	public override string LabelRobloxAmazonStore => "Roblox en Amazon Store";

	/// <summary>
	/// Key: "Label.RobloxAppStore"
	/// the title for app store icon
	/// English String: "Roblox on App Store"
	/// </summary>
	public override string LabelRobloxAppStore => "Roblox en el App Store";

	/// <summary>
	/// Key: "Label.RobloxOnXbox"
	/// title for Xbox icon
	/// English String: "Roblox on Xbox Store"
	/// </summary>
	public override string LabelRobloxOnXbox => "Roblox en Xbox Store";

	/// <summary>
	/// Key: "Label.RobloxWindowsStore"
	/// title for windows store icon
	/// English String: "Roblox on Windows Store"
	/// </summary>
	public override string LabelRobloxWindowsStore => "Roblox en Windows Store";

	public LandingResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForDescriptionRobloxOnDeviceParagraphOne()
	{
		return "Puedes acceder a Roblox desde cualquier teléfono inteligente, ordenador de sobremesa, Xbox One, Oculus Rift, y pronto Daydream y Cardboard. Las aventuras de Roblox están disponibles en todos los dispositivos para que los jugadores puedan imaginar con sus amigos sin importar donde estén.";
	}

	protected override string _GetTemplateForDescriptionRobloxOnDeviceParagraphTwo()
	{
		return "Puedes acceder a Roblox en tu PC, Mac, iOS, Android, dispositivos Amazon y Xbox One. Las aventuras de Roblox son accesibles desde cualquier dispositivo para que los jugadores puedan imaginar con sus amigos sin importar donde estén.";
	}

	protected override string _GetTemplateForDescriptionWhatIsRobloxParagraphOne()
	{
		return "Roblox potencia la imaginación de la gente de todo el mundo. Cada mes, más de 44 millones de jugadores visitan Roblox para crear aventuras, jugar, participar en juegos de rol y aprender con amigos, en la plataforma social para jugar de mayor crecimiento. La llamamos «la plataforma de la imaginación» y queremos que todos puedan acceder a ella.";
	}

	protected override string _GetTemplateForHeadingRobloxOnDevice()
	{
		return "Roblox en tu dispositivo";
	}

	protected override string _GetTemplateForHeadingWhatIsRoblox()
	{
		return "¿Qué es Roblox?";
	}

	protected override string _GetTemplateForHeadingWhatIsRobloxParagraphTwo()
	{
		return "Roblox es el mejor lugar para imaginar con amigos. Con la mayor plataforma de juegos en línea generados por usuarios y más de 15 millones de creaciones, Roblox ocupa el primer puesto entre los sitios de juegos para niños y adolescentes (comScore). Cada día, exploradores virtuales nos visitan para crear aventuras, jugar, participar en juegos de rol y aprender con amigos, en un entorno 3D inmersivo y apto para toda la familia.";
	}

	protected override string _GetTemplateForLabelAbout()
	{
		return "Acerca de Roblox";
	}

	protected override string _GetTemplateForLabelGetOnGooglePlay()
	{
		return "Consíguelo en Google Play";
	}

	protected override string _GetTemplateForLabelPlatforms()
	{
		return "Plataformas";
	}

	protected override string _GetTemplateForLabelPlay()
	{
		return "Jugar";
	}

	protected override string _GetTemplateForLabelRobloxAmazonStore()
	{
		return "Roblox en Amazon Store";
	}

	protected override string _GetTemplateForLabelRobloxAppStore()
	{
		return "Roblox en el App Store";
	}

	protected override string _GetTemplateForLabelRobloxOnXbox()
	{
		return "Roblox en Xbox Store";
	}

	protected override string _GetTemplateForLabelRobloxWindowsStore()
	{
		return "Roblox en Windows Store";
	}
}
