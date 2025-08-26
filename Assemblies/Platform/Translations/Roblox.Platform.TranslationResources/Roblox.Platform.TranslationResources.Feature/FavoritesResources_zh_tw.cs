namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string ActionAddToFavorites => "è¨­ç‚ºæœ€æ„›";

	/// <summary>
	/// Key: "ActionCancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "å–æ¶ˆ";

	/// <summary>
	/// Key: "ActionLogin"
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "ç™»å…¥";

	/// <summary>
	/// Key: "ActionRemoveFromFavorites"
	/// English String: "Remove from Favorites"
	/// </summary>
	public override string ActionRemoveFromFavorites => "å¾žæœ€æ„›ç§»é™¤";

	/// <summary>
	/// Key: "DescriptionLoginRequired"
	/// English String: "You must be logged in to add this to your favorites. Please Login or Register to continue"
	/// </summary>
	public override string DescriptionLoginRequired => "è‹¥è¦å°‡æ­¤è¨­ç‚ºæœ€æ„›ï¼Œè«‹å…ˆç™»å…¥æˆ–è¨»å†Š";

	/// <summary>
	/// Key: "Heading.Favorites"
	/// This is the button that users will click on the navigation menu to go to the Favorites page, which contains items and assets that the user has favorited.
	/// English String: "Favorites"
	/// </summary>
	public override string HeadingFavorites => "æœ€æ„›";

	/// <summary>
	/// Key: "Heading.MyFavorites"
	/// This is the page title referring to your own favorites. This page contains the user's favorite items and assets.
	/// English String: "My Favorites"
	/// </summary>
	public override string HeadingMyFavorites => "æˆ‘çš„æœ€æ„›";

	/// <summary>
	/// Key: "Label.AddToFavorites"
	/// English String: "Add to Favorites"
	/// </summary>
	public override string LabelAddToFavorites => "è¨­ç‚ºæœ€æ„›";

	/// <summary>
	/// Key: "Label.Bundles"
	/// English String: "Bundles"
	/// </summary>
	public override string LabelBundles => "çµ„åˆ";

	/// <summary>
	/// Key: "Label.Favorite"
	/// Label for button to add game to favorites
	/// English String: "Favorite"
	/// </summary>
	public override string LabelFavorite => "è¨­ç‚ºæœ€æ„›";

	/// <summary>
	/// Key: "Label.Favorited"
	/// Label for button to remove game from favorites
	/// English String: "Favorited"
	/// </summary>
	public override string LabelFavorited => "å¾žæœ€æ„›ç§»é™¤";

	/// <summary>
	/// Key: "LabelLoginRequired"
	/// English String: "Login Required"
	/// </summary>
	public override string LabelLoginRequired => "éœ€è¦ç™»å…¥";

	/// <summary>
	/// Key: "MessageAssetNotFoundError"
	/// English String: "The asset you are trying to favorite cannot be found."
	/// </summary>
	public override string MessageAssetNotFoundError => "æ‰¾ä¸åˆ°æ‚¨æƒ³è¨­ç‚ºæœ€æ„›çš„ç´ æã€‚";

	public FavoritesResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddToFavorites()
	{
		return "è¨­ç‚ºæœ€æ„›";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "å–æ¶ˆ";
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "ç™»å…¥";
	}

	protected override string _GetTemplateForActionRemoveFromFavorites()
	{
		return "å¾žæœ€æ„›ç§»é™¤";
	}

	protected override string _GetTemplateForDescriptionLoginRequired()
	{
		return "è‹¥è¦å°‡æ­¤è¨­ç‚ºæœ€æ„›ï¼Œè«‹å…ˆç™»å…¥æˆ–è¨»å†Š";
	}

	protected override string _GetTemplateForHeadingFavorites()
	{
		return "æœ€æ„›";
	}

	protected override string _GetTemplateForHeadingMyFavorites()
	{
		return "æˆ‘çš„æœ€æ„›";
	}

	/// <summary>
	/// Key: "Heading.UserFavorites"
	/// This is the page title referring to another user's favorites. This page contains another user's favorite items and assets.
	/// English String: "{username}'s Favorites"
	/// </summary>
	public override string HeadingUserFavorites(string username)
	{
		return $"{username} çš„æœ€æ„›";
	}

	protected override string _GetTemplateForHeadingUserFavorites()
	{
		return "{username} çš„æœ€æ„›";
	}

	protected override string _GetTemplateForLabelAddToFavorites()
	{
		return "è¨­ç‚ºæœ€æ„›";
	}

	protected override string _GetTemplateForLabelBundles()
	{
		return "çµ„åˆ";
	}

	protected override string _GetTemplateForLabelFavorite()
	{
		return "è¨­ç‚ºæœ€æ„›";
	}

	protected override string _GetTemplateForLabelFavorited()
	{
		return "å¾žæœ€æ„›ç§»é™¤";
	}

	protected override string _GetTemplateForLabelLoginRequired()
	{
		return "éœ€è¦ç™»å…¥";
	}

	protected override string _GetTemplateForMessageAssetNotFoundError()
	{
		return "æ‰¾ä¸åˆ°æ‚¨æƒ³è¨­ç‚ºæœ€æ„›çš„ç´ æã€‚";
	}
}


}
