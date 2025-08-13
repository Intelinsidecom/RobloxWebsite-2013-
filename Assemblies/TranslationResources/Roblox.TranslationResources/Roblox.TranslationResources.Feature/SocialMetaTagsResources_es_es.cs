namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides SocialMetaTagsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SocialMetaTagsResources_es_es : SocialMetaTagsResources_en_us, ISocialMetaTagsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Description.DevelopLanding"
	/// description shown on Facebook or Twitter when shared
	/// English String: "Create anything you can imagine with Roblox's free and immersive creation engine. Start creating games today!"
	/// </summary>
	public override string DescriptionDevelopLanding => "Crea cualquier cosa que llegues imaginar con el motor de creación gratuito e inmersivo de Roblox. ¡Empieza a crear juegos hoy!";

	/// <summary>
	/// Key: "Description.GamesPage"
	/// description shown when Games page is shared on Facebook or Twitter
	/// English String: "Play millions of free games on your smartphone, tablet, computer, Xbox One, Oculus Rift, and more."
	/// </summary>
	public override string DescriptionGamesPage => "Prueba millones de juegos gratuitos en tu teléfono inteligente, tablet, ordenador, Xbox One, Oculus Rift y más.";

	/// <summary>
	/// Key: "Description.Roblox"
	/// description shown on Facebook or Twitter when Roblox landing page is shared
	/// English String: "Roblox is ushering in the next generation of entertainment. Imagine, create, and play together with millions of players across an infinite variety of immersive, user-generated 3D worlds."
	/// </summary>
	public override string DescriptionRoblox => "Roblox está marcando el comienzo de la próxima generación de entretenimiento. Imagina, crea y juega junto con millones de jugadores a una variedad infinita de mundos 3D inmersivos generados por los usuarios.";

	/// <summary>
	/// Key: "Label.CatalogPage"
	/// Description shown when the catalog page is shared on Facebook or Twitter
	/// English String: "Customize your avatar with a never-ending variety of clothing options, accessories, gear, and more!"
	/// </summary>
	public override string LabelCatalogPage => "¡Personaliza tu avatar con la interminable variedad de ropa, accesorios, equipamiento y más!";

	/// <summary>
	/// Key: "Label.CatalogPageTItle"
	/// title
	/// English String: "Roblox Catalog"
	/// </summary>
	public override string LabelCatalogPageTItle => "Catálogo de Roblox";

	/// <summary>
	/// Key: "Label.GamesPageTitle"
	/// title for social meta tag fro games page
	/// English String: "Roblox Games"
	/// </summary>
	public override string LabelGamesPageTitle => "Juegos de Roblox";

	public SocialMetaTagsResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForDescriptionDevelopLanding()
	{
		return "Crea cualquier cosa que llegues imaginar con el motor de creación gratuito e inmersivo de Roblox. ¡Empieza a crear juegos hoy!";
	}

	/// <summary>
	/// Key: "Description.FavoritesPage"
	/// social meta tag
	/// English String: "Visit {userName}’s Favorites and see what they like. Browse through their favorite places, accessories, and a lot more. Also, find the favorite gear they use in games and get one for yourself!"
	/// </summary>
	public override string DescriptionFavoritesPage(string userName)
	{
		return $"Echa un vistazo a la categoría Favoritos de {userName} para ver lo que le gusta. Mira sus lugares preferidos, accesorios y mucho más. También podrás encontrar su equipamiento favorito usado en los juegos y conseguirte uno.";
	}

	protected override string _GetTemplateForDescriptionFavoritesPage()
	{
		return "Echa un vistazo a la categoría Favoritos de {userName} para ver lo que le gusta. Mira sus lugares preferidos, accesorios y mucho más. También podrás encontrar su equipamiento favorito usado en los juegos y conseguirte uno.";
	}

	/// <summary>
	/// Key: "Description.GamePage"
	/// The game description which shows on social media, when shared
	/// English String: "Check out {gameName}. It’s one of the millions of unique, user-generated 3D experiences created on Roblox. {gameDescription}"
	/// </summary>
	public override string DescriptionGamePage(string gameName, string gameDescription)
	{
		return $"Echa un vistazo a {gameName}. Es una de las millones de experiencias únicas en 3D generadas por los usuarios en Roblox. {gameDescription}";
	}

	protected override string _GetTemplateForDescriptionGamePage()
	{
		return "Echa un vistazo a {gameName}. Es una de las millones de experiencias únicas en 3D generadas por los usuarios en Roblox. {gameDescription}";
	}

	protected override string _GetTemplateForDescriptionGamesPage()
	{
		return "Prueba millones de juegos gratuitos en tu teléfono inteligente, tablet, ordenador, Xbox One, Oculus Rift y más.";
	}

	/// <summary>
	/// Key: "Description.InventoryPage"
	/// social meta tag
	/// English String: "Visit {userName1}’s Inventory and see the cool items they have collected. Look out for their game passes and get one for yourself! Browse through {userName2}’s collection of hats, shirts, gear, and more."
	/// </summary>
	public override string DescriptionInventoryPage(string userName1, string userName2)
	{
		return $"Visita el inventario de {userName1} para ver los objetos geniales que ha coleccionado. ¡Mira sus pases de juego y consíguete unos! Echa un vistazo a las colecciones de sombreros, camisetas, equipamiento y más de {userName2}.";
	}

	protected override string _GetTemplateForDescriptionInventoryPage()
	{
		return "Visita el inventario de {userName1} para ver los objetos geniales que ha coleccionado. ¡Mira sus pases de juego y consíguete unos! Echa un vistazo a las colecciones de sombreros, camisetas, equipamiento y más de {userName2}.";
	}

	protected override string _GetTemplateForDescriptionRoblox()
	{
		return "Roblox está marcando el comienzo de la próxima generación de entretenimiento. Imagina, crea y juega junto con millones de jugadores a una variedad infinita de mundos 3D inmersivos generados por los usuarios.";
	}

	/// <summary>
	/// Key: "Description.UserProfilePage"
	/// message when a user profile is shared on Social Media
	/// English String: "{userName1} is one of the millions playing, creating and exploring the endless possibilities of Roblox. Join {userName2} on Roblox and explore together!"
	/// </summary>
	public override string DescriptionUserProfilePage(string userName1, string userName2)
	{
		return $"{userName1} es uno de los millones de jugadores que juega, crea y descubre las infinitas posibilidades de Roblox. ¡Únete a {userName2} en la plataforma para explorar juntos!";
	}

	protected override string _GetTemplateForDescriptionUserProfilePage()
	{
		return "{userName1} es uno de los millones de jugadores que juega, crea y descubre las infinitas posibilidades de Roblox. ¡Únete a {userName2} en la plataforma para explorar juntos!";
	}

	protected override string _GetTemplateForLabelCatalogPage()
	{
		return "¡Personaliza tu avatar con la interminable variedad de ropa, accesorios, equipamiento y más!";
	}

	protected override string _GetTemplateForLabelCatalogPageTItle()
	{
		return "Catálogo de Roblox";
	}

	protected override string _GetTemplateForLabelGamesPageTitle()
	{
		return "Juegos de Roblox";
	}

	/// <summary>
	/// Key: "Label.UserProfile"
	/// title of the social meta tag
	/// English String: "{userName}'s Profile"
	/// </summary>
	public override string LabelUserProfile(string userName)
	{
		return $"Perfil de {userName}";
	}

	protected override string _GetTemplateForLabelUserProfile()
	{
		return "Perfil de {userName}";
	}
}
