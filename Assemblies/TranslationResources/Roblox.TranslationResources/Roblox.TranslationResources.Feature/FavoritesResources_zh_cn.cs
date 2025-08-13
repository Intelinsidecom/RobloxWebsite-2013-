namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides FavoritesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class FavoritesResources_zh_cn : FavoritesResources_en_us, IFavoritesResources, ITranslationResources
{
	/// <summary>
	/// Key: "ActionAddToFavorites"
	/// English String: "Add to Favorites"
	/// </summary>
	public override string ActionAddToFavorites => "设为最爱";

	/// <summary>
	/// Key: "ActionCancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "取消";

	/// <summary>
	/// Key: "ActionLogin"
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "登录";

	/// <summary>
	/// Key: "ActionRemoveFromFavorites"
	/// English String: "Remove from Favorites"
	/// </summary>
	public override string ActionRemoveFromFavorites => "从“最爱”移除";

	/// <summary>
	/// Key: "DescriptionLoginRequired"
	/// English String: "You must be logged in to add this to your favorites. Please Login or Register to continue"
	/// </summary>
	public override string DescriptionLoginRequired => "你必须先登录才能将此设为最爱。请登录或注册以继续";

	/// <summary>
	/// Key: "Heading.Favorites"
	/// This is the button that users will click on the navigation menu to go to the Favorites page, which contains items and assets that the user has favorited.
	/// English String: "Favorites"
	/// </summary>
	public override string HeadingFavorites => "最爱";

	/// <summary>
	/// Key: "Heading.MyFavorites"
	/// This is the page title referring to your own favorites. This page contains the user's favorite items and assets.
	/// English String: "My Favorites"
	/// </summary>
	public override string HeadingMyFavorites => "我的最爱";

	/// <summary>
	/// Key: "Label.AddToFavorites"
	/// English String: "Add to Favorites"
	/// </summary>
	public override string LabelAddToFavorites => "设为最爱";

	/// <summary>
	/// Key: "Label.Bundles"
	/// English String: "Bundles"
	/// </summary>
	public override string LabelBundles => "套装";

	/// <summary>
	/// Key: "Label.Favorite"
	/// Label for button to add game to favorites
	/// English String: "Favorite"
	/// </summary>
	public override string LabelFavorite => "设为最爱";

	/// <summary>
	/// Key: "Label.Favorited"
	/// Label for button to remove game from favorites
	/// English String: "Favorited"
	/// </summary>
	public override string LabelFavorited => "从最爱移除";

	/// <summary>
	/// Key: "LabelLoginRequired"
	/// English String: "Login Required"
	/// </summary>
	public override string LabelLoginRequired => "需要登录";

	/// <summary>
	/// Key: "MessageAssetNotFoundError"
	/// English String: "The asset you are trying to favorite cannot be found."
	/// </summary>
	public override string MessageAssetNotFoundError => "找不到你想要设为最爱的素材。";

	public FavoritesResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddToFavorites()
	{
		return "设为最爱";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "取消";
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "登录";
	}

	protected override string _GetTemplateForActionRemoveFromFavorites()
	{
		return "从“最爱”移除";
	}

	protected override string _GetTemplateForDescriptionLoginRequired()
	{
		return "你必须先登录才能将此设为最爱。请登录或注册以继续";
	}

	protected override string _GetTemplateForHeadingFavorites()
	{
		return "最爱";
	}

	protected override string _GetTemplateForHeadingMyFavorites()
	{
		return "我的最爱";
	}

	/// <summary>
	/// Key: "Heading.UserFavorites"
	/// This is the page title referring to another user's favorites. This page contains another user's favorite items and assets.
	/// English String: "{username}'s Favorites"
	/// </summary>
	public override string HeadingUserFavorites(string username)
	{
		return $"“{username}”的最爱";
	}

	protected override string _GetTemplateForHeadingUserFavorites()
	{
		return "“{username}”的最爱";
	}

	protected override string _GetTemplateForLabelAddToFavorites()
	{
		return "设为最爱";
	}

	protected override string _GetTemplateForLabelBundles()
	{
		return "套装";
	}

	protected override string _GetTemplateForLabelFavorite()
	{
		return "设为最爱";
	}

	protected override string _GetTemplateForLabelFavorited()
	{
		return "从最爱移除";
	}

	protected override string _GetTemplateForLabelLoginRequired()
	{
		return "需要登录";
	}

	protected override string _GetTemplateForMessageAssetNotFoundError()
	{
		return "找不到你想要设为最爱的素材。";
	}
}
