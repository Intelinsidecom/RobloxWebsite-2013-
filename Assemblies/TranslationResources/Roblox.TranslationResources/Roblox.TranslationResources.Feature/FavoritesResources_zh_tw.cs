namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides FavoritesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class FavoritesResources_zh_tw : FavoritesResources_en_us, IFavoritesResources, ITranslationResources
{
	/// <summary>
	/// Key: "ActionAddToFavorites"
	/// English String: "Add to Favorites"
	/// </summary>
	public override string ActionAddToFavorites => "設為最愛";

	/// <summary>
	/// Key: "ActionCancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "取消";

	/// <summary>
	/// Key: "ActionLogin"
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "登入";

	/// <summary>
	/// Key: "ActionRemoveFromFavorites"
	/// English String: "Remove from Favorites"
	/// </summary>
	public override string ActionRemoveFromFavorites => "從最愛移除";

	/// <summary>
	/// Key: "DescriptionLoginRequired"
	/// English String: "You must be logged in to add this to your favorites. Please Login or Register to continue"
	/// </summary>
	public override string DescriptionLoginRequired => "若要將此設為最愛，請先登入或註冊";

	/// <summary>
	/// Key: "Heading.Favorites"
	/// This is the button that users will click on the navigation menu to go to the Favorites page, which contains items and assets that the user has favorited.
	/// English String: "Favorites"
	/// </summary>
	public override string HeadingFavorites => "最愛";

	/// <summary>
	/// Key: "Heading.MyFavorites"
	/// This is the page title referring to your own favorites. This page contains the user's favorite items and assets.
	/// English String: "My Favorites"
	/// </summary>
	public override string HeadingMyFavorites => "我的最愛";

	/// <summary>
	/// Key: "Label.AddToFavorites"
	/// English String: "Add to Favorites"
	/// </summary>
	public override string LabelAddToFavorites => "設為最愛";

	/// <summary>
	/// Key: "Label.Bundles"
	/// English String: "Bundles"
	/// </summary>
	public override string LabelBundles => "組合";

	/// <summary>
	/// Key: "Label.Favorite"
	/// Label for button to add game to favorites
	/// English String: "Favorite"
	/// </summary>
	public override string LabelFavorite => "設為最愛";

	/// <summary>
	/// Key: "Label.Favorited"
	/// Label for button to remove game from favorites
	/// English String: "Favorited"
	/// </summary>
	public override string LabelFavorited => "從最愛移除";

	/// <summary>
	/// Key: "LabelLoginRequired"
	/// English String: "Login Required"
	/// </summary>
	public override string LabelLoginRequired => "需要登入";

	/// <summary>
	/// Key: "MessageAssetNotFoundError"
	/// English String: "The asset you are trying to favorite cannot be found."
	/// </summary>
	public override string MessageAssetNotFoundError => "找不到您想設為最愛的素材。";

	public FavoritesResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddToFavorites()
	{
		return "設為最愛";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "取消";
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "登入";
	}

	protected override string _GetTemplateForActionRemoveFromFavorites()
	{
		return "從最愛移除";
	}

	protected override string _GetTemplateForDescriptionLoginRequired()
	{
		return "若要將此設為最愛，請先登入或註冊";
	}

	protected override string _GetTemplateForHeadingFavorites()
	{
		return "最愛";
	}

	protected override string _GetTemplateForHeadingMyFavorites()
	{
		return "我的最愛";
	}

	/// <summary>
	/// Key: "Heading.UserFavorites"
	/// This is the page title referring to another user's favorites. This page contains another user's favorite items and assets.
	/// English String: "{username}'s Favorites"
	/// </summary>
	public override string HeadingUserFavorites(string username)
	{
		return $"{username} 的最愛";
	}

	protected override string _GetTemplateForHeadingUserFavorites()
	{
		return "{username} 的最愛";
	}

	protected override string _GetTemplateForLabelAddToFavorites()
	{
		return "設為最愛";
	}

	protected override string _GetTemplateForLabelBundles()
	{
		return "組合";
	}

	protected override string _GetTemplateForLabelFavorite()
	{
		return "設為最愛";
	}

	protected override string _GetTemplateForLabelFavorited()
	{
		return "從最愛移除";
	}

	protected override string _GetTemplateForLabelLoginRequired()
	{
		return "需要登入";
	}

	protected override string _GetTemplateForMessageAssetNotFoundError()
	{
		return "找不到您想設為最愛的素材。";
	}
}
