namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides FavoritesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class FavoritesResources_ja_jp : FavoritesResources_en_us, IFavoritesResources, ITranslationResources
{
	/// <summary>
	/// Key: "ActionAddToFavorites"
	/// English String: "Add to Favorites"
	/// </summary>
	public override string ActionAddToFavorites => "ãŠæ°—ã«å…¥ã‚Šã«è¿½åŠ ";

	/// <summary>
	/// Key: "ActionCancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "ã‚­ãƒ£ãƒ³ã‚»ãƒ«";

	/// <summary>
	/// Key: "ActionLogin"
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "ãƒ­ã‚°ã‚¤ãƒ³";

	/// <summary>
	/// Key: "ActionRemoveFromFavorites"
	/// English String: "Remove from Favorites"
	/// </summary>
	public override string ActionRemoveFromFavorites => "ãŠæ°—ã«å…¥ã‚Šã‹ã‚‰å‰Šé™¤";

	/// <summary>
	/// Key: "DescriptionLoginRequired"
	/// English String: "You must be logged in to add this to your favorites. Please Login or Register to continue"
	/// </summary>
	public override string DescriptionLoginRequired => "ãŠæ°—ã«å…¥ã‚Šã«è¿½åŠ ã™ã‚‹ã«ã¯ãƒ­ã‚°ã‚¤ãƒ³ã™ã‚‹å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚ãƒ­ã‚°ã‚¤ãƒ³ã¾ãŸã¯æ–°è¦ç™»éŒ²ã—ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Heading.Favorites"
	/// This is the button that users will click on the navigation menu to go to the Favorites page, which contains items and assets that the user has favorited.
	/// English String: "Favorites"
	/// </summary>
	public override string HeadingFavorites => "ãŠæ°—ã«å…¥ã‚Š";

	/// <summary>
	/// Key: "Heading.MyFavorites"
	/// This is the page title referring to your own favorites. This page contains the user's favorite items and assets.
	/// English String: "My Favorites"
	/// </summary>
	public override string HeadingMyFavorites => "ã‚ãªãŸã®ãŠæ°—ã«å…¥ã‚Š";

	/// <summary>
	/// Key: "Label.AddToFavorites"
	/// English String: "Add to Favorites"
	/// </summary>
	public override string LabelAddToFavorites => "ãŠæ°—ã«å…¥ã‚Šã«è¿½åŠ ";

	/// <summary>
	/// Key: "Label.Bundles"
	/// English String: "Bundles"
	/// </summary>
	public override string LabelBundles => "ãƒãƒ³ãƒ‰ãƒ«";

	/// <summary>
	/// Key: "Label.Favorite"
	/// Label for button to add game to favorites
	/// English String: "Favorite"
	/// </summary>
	public override string LabelFavorite => "ãŠæ°—ã«å…¥ã‚Š";

	/// <summary>
	/// Key: "Label.Favorited"
	/// Label for button to remove game from favorites
	/// English String: "Favorited"
	/// </summary>
	public override string LabelFavorited => "ãŠæ°—ã«å…¥ã‚Šã«ç™»éŒ²æ¸ˆã¿";

	/// <summary>
	/// Key: "LabelLoginRequired"
	/// English String: "Login Required"
	/// </summary>
	public override string LabelLoginRequired => "ãƒ­ã‚°ã‚¤ãƒ³ãŒå¿…è¦ã§ã™";

	/// <summary>
	/// Key: "MessageAssetNotFoundError"
	/// English String: "The asset you are trying to favorite cannot be found."
	/// </summary>
	public override string MessageAssetNotFoundError => "ãŠæ°—ã«å…¥ã‚Šã«è¿½åŠ ã—ã‚ˆã†ã¨ã—ã¦ã„ã‚‹ã‚¢ã‚»ãƒƒãƒˆãŒè¦‹ã¤ã‹ã‚Šã¾ã›ã‚“ã€‚";

	public FavoritesResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddToFavorites()
	{
		return "ãŠæ°—ã«å…¥ã‚Šã«è¿½åŠ ";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "ã‚­ãƒ£ãƒ³ã‚»ãƒ«";
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "ãƒ­ã‚°ã‚¤ãƒ³";
	}

	protected override string _GetTemplateForActionRemoveFromFavorites()
	{
		return "ãŠæ°—ã«å…¥ã‚Šã‹ã‚‰å‰Šé™¤";
	}

	protected override string _GetTemplateForDescriptionLoginRequired()
	{
		return "ãŠæ°—ã«å…¥ã‚Šã«è¿½åŠ ã™ã‚‹ã«ã¯ãƒ­ã‚°ã‚¤ãƒ³ã™ã‚‹å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚ãƒ­ã‚°ã‚¤ãƒ³ã¾ãŸã¯æ–°è¦ç™»éŒ²ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForHeadingFavorites()
	{
		return "ãŠæ°—ã«å…¥ã‚Š";
	}

	protected override string _GetTemplateForHeadingMyFavorites()
	{
		return "ã‚ãªãŸã®ãŠæ°—ã«å…¥ã‚Š";
	}

	/// <summary>
	/// Key: "Heading.UserFavorites"
	/// This is the page title referring to another user's favorites. This page contains another user's favorite items and assets.
	/// English String: "{username}'s Favorites"
	/// </summary>
	public override string HeadingUserFavorites(string username)
	{
		return $"{username} ã•ã‚“ã®ãŠæ°—ã«å…¥ã‚Š";
	}

	protected override string _GetTemplateForHeadingUserFavorites()
	{
		return "{username} ã•ã‚“ã®ãŠæ°—ã«å…¥ã‚Š";
	}

	protected override string _GetTemplateForLabelAddToFavorites()
	{
		return "ãŠæ°—ã«å…¥ã‚Šã«è¿½åŠ ";
	}

	protected override string _GetTemplateForLabelBundles()
	{
		return "ãƒãƒ³ãƒ‰ãƒ«";
	}

	protected override string _GetTemplateForLabelFavorite()
	{
		return "ãŠæ°—ã«å…¥ã‚Š";
	}

	protected override string _GetTemplateForLabelFavorited()
	{
		return "ãŠæ°—ã«å…¥ã‚Šã«ç™»éŒ²æ¸ˆã¿";
	}

	protected override string _GetTemplateForLabelLoginRequired()
	{
		return "ãƒ­ã‚°ã‚¤ãƒ³ãŒå¿…è¦ã§ã™";
	}

	protected override string _GetTemplateForMessageAssetNotFoundError()
	{
		return "ãŠæ°—ã«å…¥ã‚Šã«è¿½åŠ ã—ã‚ˆã†ã¨ã—ã¦ã„ã‚‹ã‚¢ã‚»ãƒƒãƒˆãŒè¦‹ã¤ã‹ã‚Šã¾ã›ã‚“ã€‚";
	}
}


}
