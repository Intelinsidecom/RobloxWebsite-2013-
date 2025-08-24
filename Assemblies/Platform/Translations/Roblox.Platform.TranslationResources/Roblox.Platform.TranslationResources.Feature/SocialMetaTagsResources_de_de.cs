namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides SocialMetaTagsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SocialMetaTagsResources_de_de : SocialMetaTagsResources_en_us, ISocialMetaTagsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Description.DevelopLanding"
	/// description shown on Facebook or Twitter when shared
	/// English String: "Create anything you can imagine with Roblox's free and immersive creation engine. Start creating games today!"
	/// </summary>
	public override string DescriptionDevelopLanding => "Erstelle mit der kostenlosen und immersiven Entwickler-Engine von Roblox alles, was du dir vorstellen kannst. Entwickle noch heute dein erstes Spiel!";

	/// <summary>
	/// Key: "Description.GamesPage"
	/// description shown when Games page is shared on Facebook or Twitter
	/// English String: "Play millions of free games on your smartphone, tablet, computer, Xbox One, Oculus Rift, and more."
	/// </summary>
	public override string DescriptionGamesPage => "Millionen von kostenlosen Spielen für dein Smartphone, Tablet, deinen Computer, die Xbox One, Oculus Rift und viele andere Geräte warten auf dich.";

	/// <summary>
	/// Key: "Description.Roblox"
	/// description shown on Facebook or Twitter when Roblox landing page is shared
	/// English String: "Roblox is ushering in the next generation of entertainment. Imagine, create, and play together with millions of players across an infinite variety of immersive, user-generated 3D worlds."
	/// </summary>
	public override string DescriptionRoblox => "Roblox läutet die nächste Generation von Unterhaltung ein. Lasse deiner Fantasie freien Lauf und gestalte und spiele mit Millionen von anderen Spielern in einer unendlichen Vielfalt an immersiven, von Benutzern erstellten 3D-Welten.";

	/// <summary>
	/// Key: "Label.CatalogPage"
	/// Description shown when the catalog page is shared on Facebook or Twitter
	/// English String: "Customize your avatar with a never-ending variety of clothing options, accessories, gear, and more!"
	/// </summary>
	public override string LabelCatalogPage => "Passe deinen Avatar mit zahllosen Kleidungsmöglichkeiten, Accessoires, Ausrüstungsgegenständen und mehr an!";

	/// <summary>
	/// Key: "Label.CatalogPageTItle"
	/// title
	/// English String: "Roblox Catalog"
	/// </summary>
	public override string LabelCatalogPageTItle => "Roblox-Katalog";

	/// <summary>
	/// Key: "Label.GamesPageTitle"
	/// title for social meta tag fro games page
	/// English String: "Roblox Games"
	/// </summary>
	public override string LabelGamesPageTitle => "Roblox-Spiele";

	public SocialMetaTagsResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForDescriptionDevelopLanding()
	{
		return "Erstelle mit der kostenlosen und immersiven Entwickler-Engine von Roblox alles, was du dir vorstellen kannst. Entwickle noch heute dein erstes Spiel!";
	}

	/// <summary>
	/// Key: "Description.FavoritesPage"
	/// social meta tag
	/// English String: "Visit {userName}’s Favorites and see what they like. Browse through their favorite places, accessories, and a lot more. Also, find the favorite gear they use in games and get one for yourself!"
	/// </summary>
	public override string DescriptionFavoritesPage(string userName)
	{
		return $"Rufe die Favoriten von {userName} auf und finde heraus, was andere Benutzer mögen. Durchsuche Lieblingsplätze, Accessoires und viel mehr. Außerdem siehst du dort auch die Lieblingsausrüstung für Spiele, dann kannst du dir gleich selbst eine holen!";
	}

	protected override string _GetTemplateForDescriptionFavoritesPage()
	{
		return "Rufe die Favoriten von {userName} auf und finde heraus, was andere Benutzer mögen. Durchsuche Lieblingsplätze, Accessoires und viel mehr. Außerdem siehst du dort auch die Lieblingsausrüstung für Spiele, dann kannst du dir gleich selbst eine holen!";
	}

	/// <summary>
	/// Key: "Description.GamePage"
	/// The game description which shows on social media, when shared
	/// English String: "Check out {gameName}. It’s one of the millions of unique, user-generated 3D experiences created on Roblox. {gameDescription}"
	/// </summary>
	public override string DescriptionGamePage(string gameName, string gameDescription)
	{
		return $"Probiere „{gameName}“ aus. Das ist nur eines von Millionen einzigartiger 3D-Abenteuer, die von anderen Benutzern auf Roblox erstellt wurden. {gameDescription}";
	}

	protected override string _GetTemplateForDescriptionGamePage()
	{
		return "Probiere „{gameName}“ aus. Das ist nur eines von Millionen einzigartiger 3D-Abenteuer, die von anderen Benutzern auf Roblox erstellt wurden. {gameDescription}";
	}

	protected override string _GetTemplateForDescriptionGamesPage()
	{
		return "Millionen von kostenlosen Spielen für dein Smartphone, Tablet, deinen Computer, die Xbox One, Oculus Rift und viele andere Geräte warten auf dich.";
	}

	/// <summary>
	/// Key: "Description.InventoryPage"
	/// social meta tag
	/// English String: "Visit {userName1}’s Inventory and see the cool items they have collected. Look out for their game passes and get one for yourself! Browse through {userName2}’s collection of hats, shirts, gear, and more."
	/// </summary>
	public override string DescriptionInventoryPage(string userName1, string userName2)
	{
		return $"Rufe das Inventar von {userName1} auf und sieh dir die tollen gesammelten Artikel an. Wirf einen Blick auf die Spielpässe und hol dir selbst einen! Durchsuche die Sammlung von {userName2} und bewundere Hüte, Hemden, Ausrüstungsgegenstände und mehr.";
	}

	protected override string _GetTemplateForDescriptionInventoryPage()
	{
		return "Rufe das Inventar von {userName1} auf und sieh dir die tollen gesammelten Artikel an. Wirf einen Blick auf die Spielpässe und hol dir selbst einen! Durchsuche die Sammlung von {userName2} und bewundere Hüte, Hemden, Ausrüstungsgegenstände und mehr.";
	}

	protected override string _GetTemplateForDescriptionRoblox()
	{
		return "Roblox läutet die nächste Generation von Unterhaltung ein. Lasse deiner Fantasie freien Lauf und gestalte und spiele mit Millionen von anderen Spielern in einer unendlichen Vielfalt an immersiven, von Benutzern erstellten 3D-Welten.";
	}

	/// <summary>
	/// Key: "Description.UserProfilePage"
	/// message when a user profile is shared on Social Media
	/// English String: "{userName1} is one of the millions playing, creating and exploring the endless possibilities of Roblox. Join {userName2} on Roblox and explore together!"
	/// </summary>
	public override string DescriptionUserProfilePage(string userName1, string userName2)
	{
		return $"{userName1} ist Teil der Community aus Millionen von Benutzern, die spielen, entwickeln und die endlosen Möglichkeiten von Roblox erkunden. Begib dich gemeinsam mit {userName2} auf Entdeckungsreise!";
	}

	protected override string _GetTemplateForDescriptionUserProfilePage()
	{
		return "{userName1} ist Teil der Community aus Millionen von Benutzern, die spielen, entwickeln und die endlosen Möglichkeiten von Roblox erkunden. Begib dich gemeinsam mit {userName2} auf Entdeckungsreise!";
	}

	protected override string _GetTemplateForLabelCatalogPage()
	{
		return "Passe deinen Avatar mit zahllosen Kleidungsmöglichkeiten, Accessoires, Ausrüstungsgegenständen und mehr an!";
	}

	protected override string _GetTemplateForLabelCatalogPageTItle()
	{
		return "Roblox-Katalog";
	}

	protected override string _GetTemplateForLabelGamesPageTitle()
	{
		return "Roblox-Spiele";
	}

	/// <summary>
	/// Key: "Label.UserProfile"
	/// title of the social meta tag
	/// English String: "{userName}'s Profile"
	/// </summary>
	public override string LabelUserProfile(string userName)
	{
		return $"Profil von {userName}";
	}

	protected override string _GetTemplateForLabelUserProfile()
	{
		return "Profil von {userName}";
	}
}
