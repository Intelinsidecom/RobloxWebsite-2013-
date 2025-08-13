namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides SocialMetaTagsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SocialMetaTagsResources_fr_fr : SocialMetaTagsResources_en_us, ISocialMetaTagsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Description.DevelopLanding"
	/// description shown on Facebook or Twitter when shared
	/// English String: "Create anything you can imagine with Roblox's free and immersive creation engine. Start creating games today!"
	/// </summary>
	public override string DescriptionDevelopLanding => "Donne vie à ton imagination grâce au moteur de création gratuit et immersif proposé par Roblox. Commence à créer des jeux dès aujourd'hui\u00a0!";

	/// <summary>
	/// Key: "Description.GamesPage"
	/// description shown when Games page is shared on Facebook or Twitter
	/// English String: "Play millions of free games on your smartphone, tablet, computer, Xbox One, Oculus Rift, and more."
	/// </summary>
	public override string DescriptionGamesPage => "Jouez gratuitement à des millions de jeux sur smartphone, tablette, ordinateur, Xbox\u00a0One, Oculus\u00a0Rift et bien plus.";

	/// <summary>
	/// Key: "Description.Roblox"
	/// description shown on Facebook or Twitter when Roblox landing page is shared
	/// English String: "Roblox is ushering in the next generation of entertainment. Imagine, create, and play together with millions of players across an infinite variety of immersive, user-generated 3D worlds."
	/// </summary>
	public override string DescriptionRoblox => "Roblox marque le début de la prochaine génération du divertissement. Imaginez, créez et jouez avec des millions de joueurs dans une infinité de mondes en\u00a03D immersifs générés par la communauté.";

	/// <summary>
	/// Key: "Label.CatalogPage"
	/// Description shown when the catalog page is shared on Facebook or Twitter
	/// English String: "Customize your avatar with a never-ending variety of clothing options, accessories, gear, and more!"
	/// </summary>
	public override string LabelCatalogPage => "Personnalise ton avatar avec une gamme illimitée d'options vestimentaires, d'accessoires, d'équipement et plus encore\u00a0!";

	/// <summary>
	/// Key: "Label.CatalogPageTItle"
	/// title
	/// English String: "Roblox Catalog"
	/// </summary>
	public override string LabelCatalogPageTItle => "Catalogue Roblox";

	/// <summary>
	/// Key: "Label.GamesPageTitle"
	/// title for social meta tag fro games page
	/// English String: "Roblox Games"
	/// </summary>
	public override string LabelGamesPageTitle => "Jeux Roblox";

	public SocialMetaTagsResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForDescriptionDevelopLanding()
	{
		return "Donne vie à ton imagination grâce au moteur de création gratuit et immersif proposé par Roblox. Commence à créer des jeux dès aujourd'hui\u00a0!";
	}

	/// <summary>
	/// Key: "Description.FavoritesPage"
	/// social meta tag
	/// English String: "Visit {userName}’s Favorites and see what they like. Browse through their favorite places, accessories, and a lot more. Also, find the favorite gear they use in games and get one for yourself!"
	/// </summary>
	public override string DescriptionFavoritesPage(string userName)
	{
		return $"Consultez les favoris de {userName} pour découvrir ses goûts en termes d'emplacements, d'accessoires et bien plus encore. Voyez quel est son équipement préféré et obtenez-le pour vous\u00a0!";
	}

	protected override string _GetTemplateForDescriptionFavoritesPage()
	{
		return "Consultez les favoris de {userName} pour découvrir ses goûts en termes d'emplacements, d'accessoires et bien plus encore. Voyez quel est son équipement préféré et obtenez-le pour vous\u00a0!";
	}

	/// <summary>
	/// Key: "Description.GamePage"
	/// The game description which shows on social media, when shared
	/// English String: "Check out {gameName}. It’s one of the millions of unique, user-generated 3D experiences created on Roblox. {gameDescription}"
	/// </summary>
	public override string DescriptionGamePage(string gameName, string gameDescription)
	{
		return $"Jetez un œil à {gameName}. Ce n'est qu'un exemple des millions de contenus en 3D uniques créés par les utilisateurs dans Roblox. {gameDescription}";
	}

	protected override string _GetTemplateForDescriptionGamePage()
	{
		return "Jetez un œil à {gameName}. Ce n'est qu'un exemple des millions de contenus en 3D uniques créés par les utilisateurs dans Roblox. {gameDescription}";
	}

	protected override string _GetTemplateForDescriptionGamesPage()
	{
		return "Jouez gratuitement à des millions de jeux sur smartphone, tablette, ordinateur, Xbox\u00a0One, Oculus\u00a0Rift et bien plus.";
	}

	/// <summary>
	/// Key: "Description.InventoryPage"
	/// social meta tag
	/// English String: "Visit {userName1}’s Inventory and see the cool items they have collected. Look out for their game passes and get one for yourself! Browse through {userName2}’s collection of hats, shirts, gear, and more."
	/// </summary>
	public override string DescriptionInventoryPage(string userName1, string userName2)
	{
		return $"Consultez l'inventaire de {userName1} et découvrez tous les objets sympa qui s'y trouvent. Repérez ses passes de jeu et obtenez-en un pour vous\u00a0! Naviguez dans la collection de {userName2}, qui regorge de chapeaux, de chemises, d'équipements et d'autres objets.";
	}

	protected override string _GetTemplateForDescriptionInventoryPage()
	{
		return "Consultez l'inventaire de {userName1} et découvrez tous les objets sympa qui s'y trouvent. Repérez ses passes de jeu et obtenez-en un pour vous\u00a0! Naviguez dans la collection de {userName2}, qui regorge de chapeaux, de chemises, d'équipements et d'autres objets.";
	}

	protected override string _GetTemplateForDescriptionRoblox()
	{
		return "Roblox marque le début de la prochaine génération du divertissement. Imaginez, créez et jouez avec des millions de joueurs dans une infinité de mondes en\u00a03D immersifs générés par la communauté.";
	}

	/// <summary>
	/// Key: "Description.UserProfilePage"
	/// message when a user profile is shared on Social Media
	/// English String: "{userName1} is one of the millions playing, creating and exploring the endless possibilities of Roblox. Join {userName2} on Roblox and explore together!"
	/// </summary>
	public override string DescriptionUserProfilePage(string userName1, string userName2)
	{
		return $"{userName1} est l'un des millions d'utilisateurs qui jouent, créent et explorent les possibilités infinies de Roblox. Rejoignez {userName2} sur Roblox et amusez-vous ensemble\u00a0!";
	}

	protected override string _GetTemplateForDescriptionUserProfilePage()
	{
		return "{userName1} est l'un des millions d'utilisateurs qui jouent, créent et explorent les possibilités infinies de Roblox. Rejoignez {userName2} sur Roblox et amusez-vous ensemble\u00a0!";
	}

	protected override string _GetTemplateForLabelCatalogPage()
	{
		return "Personnalise ton avatar avec une gamme illimitée d'options vestimentaires, d'accessoires, d'équipement et plus encore\u00a0!";
	}

	protected override string _GetTemplateForLabelCatalogPageTItle()
	{
		return "Catalogue Roblox";
	}

	protected override string _GetTemplateForLabelGamesPageTitle()
	{
		return "Jeux Roblox";
	}

	/// <summary>
	/// Key: "Label.UserProfile"
	/// title of the social meta tag
	/// English String: "{userName}'s Profile"
	/// </summary>
	public override string LabelUserProfile(string userName)
	{
		return $"Profil de {userName}";
	}

	protected override string _GetTemplateForLabelUserProfile()
	{
		return "Profil de {userName}";
	}
}
