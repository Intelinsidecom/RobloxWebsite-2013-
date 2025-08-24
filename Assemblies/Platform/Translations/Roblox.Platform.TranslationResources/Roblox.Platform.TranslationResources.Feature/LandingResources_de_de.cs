namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides LandingResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class LandingResources_de_de : LandingResources_en_us, ILandingResources, ITranslationResources
{
	/// <summary>
	/// Key: "Description.RobloxOnDeviceParagraphOne"
	/// first paragraph under Roblox on your device heading on landing page
	/// English String: "You can access Roblox on all modern smartphones, desktops, Xbox One, Oculus Rift, and soon on Daydream and Cardboard. Roblox adventures are accessible from any device, so players can imagine with their friends regardless of where they are."
	/// </summary>
	public override string DescriptionRobloxOnDeviceParagraphOne => "Du kannst Roblox auf allen modernen Smartphones, Computern sowie auf Xbox One, mit Oculus Rift und bald auch mit Daydream und Cardboard nutzen. Roblox-Abenteuer können über alle Geräte gespielt werden, sodass Spieler gemeinsam mit Freunden ihrer Vorstellungskraft freien Lauf lassen können, ganz egal, wo sie sich gerade befinden.";

	/// <summary>
	/// Key: "Description.RobloxOnDeviceParagraphTwo"
	/// second paragraph under Roblox on Your Device on landing page
	/// English String: "You can access Roblox on PC, Mac, iOS, Android, Amazon Devices, and Xbox One. Roblox adventures are accessible from any device, so players can imagine with their friends regardless of where they are."
	/// </summary>
	public override string DescriptionRobloxOnDeviceParagraphTwo => "Du kannst Roblox auf PC, Mac, iOS, Android, Amazon-Geräten und Xbox One nutzen. Roblox-Abenteuer können über alle Geräte gespielt werden, sodass Spieler gemeinsam mit Freunden ihrer Vorstellungskraft freien Lauf lassen können, ganz egal, wo sie sich gerade befinden.";

	/// <summary>
	/// Key: "Description.WhatIsRobloxParagraphOne"
	/// first paragraph under what's Roblox heading on landing page
	/// English String: "Roblox helps power the imagination of people around the world. As the largest growing social platform for play, over 44 million players come to Roblox every month to create adventures, play games, roleplay, and learn with friends. We call it the ‘Imagination Platform’ and believe everyone should have the right to play on it."
	/// </summary>
	public override string DescriptionWhatIsRobloxParagraphOne => "Roblox ermöglicht es Leuten aus aller Welt, ihrer Fantasie freien Lauf zu lassen. Roblox ist mit monatlich über 44 Millionen Spielern die größte, wachsende soziale Plattform für Spiele und erlaubt es allen Benutzern, Abenteuer zu erstellen, Spiele zu spielen, im Rollenspiel aufzugehen und gemeinsam mit Freunden zu lernen. Wir nennen es die „Plattform der Vorstellungskraft“ und finden, dass jeder das Recht haben sollte, darauf zu spielen.";

	/// <summary>
	/// Key: "Heading.RobloxOnDevice"
	/// heading Roblox on your device
	/// English String: "Roblox on your Device"
	/// </summary>
	public override string HeadingRobloxOnDevice => "Roblox auf deinem Gerät";

	/// <summary>
	/// Key: "Heading.WhatIsRoblox"
	/// heading for what is Roblox section on the landing page
	/// English String: "What is Roblox?"
	/// </summary>
	public override string HeadingWhatIsRoblox => "Was ist Roblox?";

	/// <summary>
	/// Key: "Heading.WhatIsRobloxParagraphTwo"
	/// second paragraph under what's Roblox on the landing page
	/// English String: "Roblox is the best place to Imagine with Friends. With the largest user-generated online gaming platform, and over 15 million games created by users, Roblox is the #1 gaming site for kids and teens (comScore). Every day, virtual explorers come to Roblox to create adventures, play games, role play, and learn with their friends in a family-friendly, immersive, 3D environment."
	/// </summary>
	public override string HeadingWhatIsRobloxParagraphTwo => "Roblox ist der ideale Ort, um gemeinsam mit Freunden die Vorstellungskraft spielen zu lassen. Mit der größten von Benutzern erschaffenen Online-Spieleplattform und über 15 Millionen von Spielern entwickelten Spielen ist Roblox die Spieleseite Nummer 1 für Kinder und Teenager (comScore). Roblox wird jeden Tag von virtuellen Erkundern besucht, die Abenteuer erstellen, Spiele spielen, im Rollenspiel aufgehen oder gemeinsam mit Freunden lernen, und das alles in einer familienfreundlichen, fesselnden 3D-Umgebung.";

	/// <summary>
	/// Key: "Label.About"
	/// about link on top left
	/// English String: "About"
	/// </summary>
	public override string LabelAbout => "Info";

	/// <summary>
	/// Key: "Label.GetOnGooglePlay"
	/// Google play icon title
	/// English String: "Get it on Google Play"
	/// </summary>
	public override string LabelGetOnGooglePlay => "Hol es dir auf Google Play";

	/// <summary>
	/// Key: "Label.Platforms"
	/// platform link on top left
	/// English String: "Platforms"
	/// </summary>
	public override string LabelPlatforms => "Plattformen";

	/// <summary>
	/// Key: "Label.Play"
	/// play link on top left
	/// English String: "Play"
	/// </summary>
	public override string LabelPlay => "Spielen";

	/// <summary>
	/// Key: "Label.RobloxAmazonStore"
	/// title for Amazon store icon
	/// English String: "Roblox on Amazon Store"
	/// </summary>
	public override string LabelRobloxAmazonStore => "Roblox im Amazon Store";

	/// <summary>
	/// Key: "Label.RobloxAppStore"
	/// the title for app store icon
	/// English String: "Roblox on App Store"
	/// </summary>
	public override string LabelRobloxAppStore => "Roblox im App Store";

	/// <summary>
	/// Key: "Label.RobloxOnXbox"
	/// title for Xbox icon
	/// English String: "Roblox on Xbox Store"
	/// </summary>
	public override string LabelRobloxOnXbox => "Roblox im Xbox Store";

	/// <summary>
	/// Key: "Label.RobloxWindowsStore"
	/// title for windows store icon
	/// English String: "Roblox on Windows Store"
	/// </summary>
	public override string LabelRobloxWindowsStore => "Roblox im Windows Store";

	public LandingResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForDescriptionRobloxOnDeviceParagraphOne()
	{
		return "Du kannst Roblox auf allen modernen Smartphones, Computern sowie auf Xbox One, mit Oculus Rift und bald auch mit Daydream und Cardboard nutzen. Roblox-Abenteuer können über alle Geräte gespielt werden, sodass Spieler gemeinsam mit Freunden ihrer Vorstellungskraft freien Lauf lassen können, ganz egal, wo sie sich gerade befinden.";
	}

	protected override string _GetTemplateForDescriptionRobloxOnDeviceParagraphTwo()
	{
		return "Du kannst Roblox auf PC, Mac, iOS, Android, Amazon-Geräten und Xbox One nutzen. Roblox-Abenteuer können über alle Geräte gespielt werden, sodass Spieler gemeinsam mit Freunden ihrer Vorstellungskraft freien Lauf lassen können, ganz egal, wo sie sich gerade befinden.";
	}

	protected override string _GetTemplateForDescriptionWhatIsRobloxParagraphOne()
	{
		return "Roblox ermöglicht es Leuten aus aller Welt, ihrer Fantasie freien Lauf zu lassen. Roblox ist mit monatlich über 44 Millionen Spielern die größte, wachsende soziale Plattform für Spiele und erlaubt es allen Benutzern, Abenteuer zu erstellen, Spiele zu spielen, im Rollenspiel aufzugehen und gemeinsam mit Freunden zu lernen. Wir nennen es die „Plattform der Vorstellungskraft“ und finden, dass jeder das Recht haben sollte, darauf zu spielen.";
	}

	protected override string _GetTemplateForHeadingRobloxOnDevice()
	{
		return "Roblox auf deinem Gerät";
	}

	protected override string _GetTemplateForHeadingWhatIsRoblox()
	{
		return "Was ist Roblox?";
	}

	protected override string _GetTemplateForHeadingWhatIsRobloxParagraphTwo()
	{
		return "Roblox ist der ideale Ort, um gemeinsam mit Freunden die Vorstellungskraft spielen zu lassen. Mit der größten von Benutzern erschaffenen Online-Spieleplattform und über 15 Millionen von Spielern entwickelten Spielen ist Roblox die Spieleseite Nummer 1 für Kinder und Teenager (comScore). Roblox wird jeden Tag von virtuellen Erkundern besucht, die Abenteuer erstellen, Spiele spielen, im Rollenspiel aufgehen oder gemeinsam mit Freunden lernen, und das alles in einer familienfreundlichen, fesselnden 3D-Umgebung.";
	}

	protected override string _GetTemplateForLabelAbout()
	{
		return "Info";
	}

	protected override string _GetTemplateForLabelGetOnGooglePlay()
	{
		return "Hol es dir auf Google Play";
	}

	protected override string _GetTemplateForLabelPlatforms()
	{
		return "Plattformen";
	}

	protected override string _GetTemplateForLabelPlay()
	{
		return "Spielen";
	}

	protected override string _GetTemplateForLabelRobloxAmazonStore()
	{
		return "Roblox im Amazon Store";
	}

	protected override string _GetTemplateForLabelRobloxAppStore()
	{
		return "Roblox im App Store";
	}

	protected override string _GetTemplateForLabelRobloxOnXbox()
	{
		return "Roblox im Xbox Store";
	}

	protected override string _GetTemplateForLabelRobloxWindowsStore()
	{
		return "Roblox im Windows Store";
	}
}
