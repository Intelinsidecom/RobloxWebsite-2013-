namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides SocialMetaTagsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SocialMetaTagsResources_pt_br : SocialMetaTagsResources_en_us, ISocialMetaTagsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Description.DevelopLanding"
	/// description shown on Facebook or Twitter when shared
	/// English String: "Create anything you can imagine with Roblox's free and immersive creation engine. Start creating games today!"
	/// </summary>
	public override string DescriptionDevelopLanding => "Crie qualquer coisa que imaginar com o sistema de criação imersivo e livre do Roblox. Comece a criar jogos hoje mesmo!";

	/// <summary>
	/// Key: "Description.GamesPage"
	/// description shown when Games page is shared on Facebook or Twitter
	/// English String: "Play millions of free games on your smartphone, tablet, computer, Xbox One, Oculus Rift, and more."
	/// </summary>
	public override string DescriptionGamesPage => "Jogue milhões de jogos gratuitos em seu smartphone, tablet, computador, Xbox One, Oculus Rift e muito mais.";

	/// <summary>
	/// Key: "Description.Roblox"
	/// description shown on Facebook or Twitter when Roblox landing page is shared
	/// English String: "Roblox is ushering in the next generation of entertainment. Imagine, create, and play together with millions of players across an infinite variety of immersive, user-generated 3D worlds."
	/// </summary>
	public override string DescriptionRoblox => "Roblox anuncia o começo de uma nova geração de entretenimento. Imagine, crie e jogue com milhões de jogadores em uma infinita variedade de mundos 3D imersivos gerados por usuários.";

	/// <summary>
	/// Key: "Label.CatalogPage"
	/// Description shown when the catalog page is shared on Facebook or Twitter
	/// English String: "Customize your avatar with a never-ending variety of clothing options, accessories, gear, and more!"
	/// </summary>
	public override string LabelCatalogPage => "Personalize seu avatar com uma variedade sem fim de opções, acessórios, equipamentos e muito mais!";

	/// <summary>
	/// Key: "Label.CatalogPageTItle"
	/// title
	/// English String: "Roblox Catalog"
	/// </summary>
	public override string LabelCatalogPageTItle => "Catálogo do Roblox";

	/// <summary>
	/// Key: "Label.GamesPageTitle"
	/// title for social meta tag fro games page
	/// English String: "Roblox Games"
	/// </summary>
	public override string LabelGamesPageTitle => "Jogos do Roblox";

	public SocialMetaTagsResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForDescriptionDevelopLanding()
	{
		return "Crie qualquer coisa que imaginar com o sistema de criação imersivo e livre do Roblox. Comece a criar jogos hoje mesmo!";
	}

	/// <summary>
	/// Key: "Description.FavoritesPage"
	/// social meta tag
	/// English String: "Visit {userName}’s Favorites and see what they like. Browse through their favorite places, accessories, and a lot more. Also, find the favorite gear they use in games and get one for yourself!"
	/// </summary>
	public override string DescriptionFavoritesPage(string userName)
	{
		return $"Visite os favoritos de {userName} e confira suas preferências no Roblox. Descubra seus locais, acessórios e outras coisas favoritas. Veja também os equipamentos mais usados por esta pessoa em jogo e adquira um para você!";
	}

	protected override string _GetTemplateForDescriptionFavoritesPage()
	{
		return "Visite os favoritos de {userName} e confira suas preferências no Roblox. Descubra seus locais, acessórios e outras coisas favoritas. Veja também os equipamentos mais usados por esta pessoa em jogo e adquira um para você!";
	}

	/// <summary>
	/// Key: "Description.GamePage"
	/// The game description which shows on social media, when shared
	/// English String: "Check out {gameName}. It’s one of the millions of unique, user-generated 3D experiences created on Roblox. {gameDescription}"
	/// </summary>
	public override string DescriptionGamePage(string gameName, string gameDescription)
	{
		return $"Confira {gameName}. Este jogo é uma das milhões de experiências 3D imersivas únicas criadas por jogadores no Roblox. {gameDescription}";
	}

	protected override string _GetTemplateForDescriptionGamePage()
	{
		return "Confira {gameName}. Este jogo é uma das milhões de experiências 3D imersivas únicas criadas por jogadores no Roblox. {gameDescription}";
	}

	protected override string _GetTemplateForDescriptionGamesPage()
	{
		return "Jogue milhões de jogos gratuitos em seu smartphone, tablet, computador, Xbox One, Oculus Rift e muito mais.";
	}

	/// <summary>
	/// Key: "Description.InventoryPage"
	/// social meta tag
	/// English String: "Visit {userName1}’s Inventory and see the cool items they have collected. Look out for their game passes and get one for yourself! Browse through {userName2}’s collection of hats, shirts, gear, and more."
	/// </summary>
	public override string DescriptionInventoryPage(string userName1, string userName2)
	{
		return $"Visite o inventário de {userName1} para ver os itens legais que conseguiu. Dê uma olhada em seus passes de jogo e consiga um para você! Confira a coleção de chapéus, camisas, equipamento e outros itens de {userName2}.";
	}

	protected override string _GetTemplateForDescriptionInventoryPage()
	{
		return "Visite o inventário de {userName1} para ver os itens legais que conseguiu. Dê uma olhada em seus passes de jogo e consiga um para você! Confira a coleção de chapéus, camisas, equipamento e outros itens de {userName2}.";
	}

	protected override string _GetTemplateForDescriptionRoblox()
	{
		return "Roblox anuncia o começo de uma nova geração de entretenimento. Imagine, crie e jogue com milhões de jogadores em uma infinita variedade de mundos 3D imersivos gerados por usuários.";
	}

	/// <summary>
	/// Key: "Description.UserProfilePage"
	/// message when a user profile is shared on Social Media
	/// English String: "{userName1} is one of the millions playing, creating and exploring the endless possibilities of Roblox. Join {userName2} on Roblox and explore together!"
	/// </summary>
	public override string DescriptionUserProfilePage(string userName1, string userName2)
	{
		return $"{userName1} é um dos milhões de usuários jogando, criando e explorando as possibilidades infinitas do Roblox. Junte-se a {userName2} no Roblox e explorem juntos!";
	}

	protected override string _GetTemplateForDescriptionUserProfilePage()
	{
		return "{userName1} é um dos milhões de usuários jogando, criando e explorando as possibilidades infinitas do Roblox. Junte-se a {userName2} no Roblox e explorem juntos!";
	}

	protected override string _GetTemplateForLabelCatalogPage()
	{
		return "Personalize seu avatar com uma variedade sem fim de opções, acessórios, equipamentos e muito mais!";
	}

	protected override string _GetTemplateForLabelCatalogPageTItle()
	{
		return "Catálogo do Roblox";
	}

	protected override string _GetTemplateForLabelGamesPageTitle()
	{
		return "Jogos do Roblox";
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
