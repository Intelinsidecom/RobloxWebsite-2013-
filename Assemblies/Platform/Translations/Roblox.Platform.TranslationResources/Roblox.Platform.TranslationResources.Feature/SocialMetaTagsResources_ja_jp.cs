namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides SocialMetaTagsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SocialMetaTagsResources_ja_jp : SocialMetaTagsResources_en_us, ISocialMetaTagsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Description.DevelopLanding"
	/// description shown on Facebook or Twitter when shared
	/// English String: "Create anything you can imagine with Roblox's free and immersive creation engine. Start creating games today!"
	/// </summary>
	public override string DescriptionDevelopLanding => "Robloxの無料の没入型コンテンツ制作エンジンを使って、イマジネーションを形にしましょう。今すぐゲーム制作を始めてみてください！";

	/// <summary>
	/// Key: "Description.GamesPage"
	/// description shown when Games page is shared on Facebook or Twitter
	/// English String: "Play millions of free games on your smartphone, tablet, computer, Xbox One, Oculus Rift, and more."
	/// </summary>
	public override string DescriptionGamesPage => "スマートフォン、タブレット、パソコン、Xbox One、Oculus Riftなどで、数百万種類の無料ゲームをプレイしよう。";

	/// <summary>
	/// Key: "Description.Roblox"
	/// description shown on Facebook or Twitter when Roblox landing page is shared
	/// English String: "Roblox is ushering in the next generation of entertainment. Imagine, create, and play together with millions of players across an infinite variety of immersive, user-generated 3D worlds."
	/// </summary>
	public override string DescriptionRoblox => "Robloxは、次世代のエンターテイメントへと皆さんをご案内します。ユーザーが作った雰囲気抜群の無限の3Dワールドで、数百万人のプレイヤーたちと一緒にイマジネーションを膨らませて、制作やプレイを体験してください。";

	/// <summary>
	/// Key: "Label.CatalogPage"
	/// Description shown when the catalog page is shared on Facebook or Twitter
	/// English String: "Customize your avatar with a never-ending variety of clothing options, accessories, gear, and more!"
	/// </summary>
	public override string LabelCatalogPage => "無限のバリエーションが用意されたコスチューム、アクセサリ、ギアなどでアバターをカスタマイズしよう！";

	/// <summary>
	/// Key: "Label.CatalogPageTItle"
	/// title
	/// English String: "Roblox Catalog"
	/// </summary>
	public override string LabelCatalogPageTItle => "Robloxカタログ";

	/// <summary>
	/// Key: "Label.GamesPageTitle"
	/// title for social meta tag fro games page
	/// English String: "Roblox Games"
	/// </summary>
	public override string LabelGamesPageTitle => "Robloxゲーム";

	public SocialMetaTagsResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForDescriptionDevelopLanding()
	{
		return "Robloxの無料の没入型コンテンツ制作エンジンを使って、イマジネーションを形にしましょう。今すぐゲーム制作を始めてみてください！";
	}

	/// <summary>
	/// Key: "Description.FavoritesPage"
	/// social meta tag
	/// English String: "Visit {userName}’s Favorites and see what they like. Browse through their favorite places, accessories, and a lot more. Also, find the favorite gear they use in games and get one for yourself!"
	/// </summary>
	public override string DescriptionFavoritesPage(string userName)
	{
		return $"{userName}さんのお気に入りにアクセスして、どんな趣味をしているのか見てみましょう。お気に入りのプレースやアクセサリなどもチェックしましょう。もしゲーム内で使っているお気に入りギアが気に入ったら、自分でも手に入れましょう！";
	}

	protected override string _GetTemplateForDescriptionFavoritesPage()
	{
		return "{userName}さんのお気に入りにアクセスして、どんな趣味をしているのか見てみましょう。お気に入りのプレースやアクセサリなどもチェックしましょう。もしゲーム内で使っているお気に入りギアが気に入ったら、自分でも手に入れましょう！";
	}

	/// <summary>
	/// Key: "Description.GamePage"
	/// The game description which shows on social media, when shared
	/// English String: "Check out {gameName}. It’s one of the millions of unique, user-generated 3D experiences created on Roblox. {gameDescription}"
	/// </summary>
	public override string DescriptionGamePage(string gameName, string gameDescription)
	{
		return $"{gameName}をチェックしよう。これは、数百万種類に及ぶ、Robloxでユーザーが作成したユニークな3Dコンテンツの一つです。{gameDescription}";
	}

	protected override string _GetTemplateForDescriptionGamePage()
	{
		return "{gameName}をチェックしよう。これは、数百万種類に及ぶ、Robloxでユーザーが作成したユニークな3Dコンテンツの一つです。{gameDescription}";
	}

	protected override string _GetTemplateForDescriptionGamesPage()
	{
		return "スマートフォン、タブレット、パソコン、Xbox One、Oculus Riftなどで、数百万種類の無料ゲームをプレイしよう。";
	}

	/// <summary>
	/// Key: "Description.InventoryPage"
	/// social meta tag
	/// English String: "Visit {userName1}’s Inventory and see the cool items they have collected. Look out for their game passes and get one for yourself! Browse through {userName2}’s collection of hats, shirts, gear, and more."
	/// </summary>
	public override string DescriptionInventoryPage(string userName1, string userName2)
	{
		return $"{userName1}さんのインベントリにアクセスして、コレクションしているクールなアイテムをチェックしましょう。ゲームパスを確認して、自分でも手に入れましょう！{userName2}さんの帽子、シャツ、ギアなどもチェックしてみてください。";
	}

	protected override string _GetTemplateForDescriptionInventoryPage()
	{
		return "{userName1}さんのインベントリにアクセスして、コレクションしているクールなアイテムをチェックしましょう。ゲームパスを確認して、自分でも手に入れましょう！{userName2}さんの帽子、シャツ、ギアなどもチェックしてみてください。";
	}

	protected override string _GetTemplateForDescriptionRoblox()
	{
		return "Robloxは、次世代のエンターテイメントへと皆さんをご案内します。ユーザーが作った雰囲気抜群の無限の3Dワールドで、数百万人のプレイヤーたちと一緒にイマジネーションを膨らませて、制作やプレイを体験してください。";
	}

	/// <summary>
	/// Key: "Description.UserProfilePage"
	/// message when a user profile is shared on Social Media
	/// English String: "{userName1} is one of the millions playing, creating and exploring the endless possibilities of Roblox. Join {userName2} on Roblox and explore together!"
	/// </summary>
	public override string DescriptionUserProfilePage(string userName1, string userName2)
	{
		return $"{userName1} さんは、Robloxで制作やプレイをしながら無限の可能性を追求している数百万人のうちの一人です。Robloxで {userName2} さんと一緒に可能性を追求しよう！";
	}

	protected override string _GetTemplateForDescriptionUserProfilePage()
	{
		return "{userName1} さんは、Robloxで制作やプレイをしながら無限の可能性を追求している数百万人のうちの一人です。Robloxで {userName2} さんと一緒に可能性を追求しよう！";
	}

	protected override string _GetTemplateForLabelCatalogPage()
	{
		return "無限のバリエーションが用意されたコスチューム、アクセサリ、ギアなどでアバターをカスタマイズしよう！";
	}

	protected override string _GetTemplateForLabelCatalogPageTItle()
	{
		return "Robloxカタログ";
	}

	protected override string _GetTemplateForLabelGamesPageTitle()
	{
		return "Robloxゲーム";
	}

	/// <summary>
	/// Key: "Label.UserProfile"
	/// title of the social meta tag
	/// English String: "{userName}'s Profile"
	/// </summary>
	public override string LabelUserProfile(string userName)
	{
		return $"{userName}さんのプロフィール";
	}

	protected override string _GetTemplateForLabelUserProfile()
	{
		return "{userName}さんのプロフィール";
	}
}
