namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides FavoritesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class FavoritesResources_ko_kr : FavoritesResources_en_us, IFavoritesResources, ITranslationResources
{
	/// <summary>
	/// Key: "ActionAddToFavorites"
	/// English String: "Add to Favorites"
	/// </summary>
	public override string ActionAddToFavorites => "ì¦ê²¨ì°¾ê¸°ì— ì¶”ê°€";

	/// <summary>
	/// Key: "ActionCancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "ì·¨ì†Œ";

	/// <summary>
	/// Key: "ActionLogin"
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "ë¡œê·¸ì¸";

	/// <summary>
	/// Key: "ActionRemoveFromFavorites"
	/// English String: "Remove from Favorites"
	/// </summary>
	public override string ActionRemoveFromFavorites => "ì¦ê²¨ì°¾ê¸° ì‚­ì œ";

	/// <summary>
	/// Key: "DescriptionLoginRequired"
	/// English String: "You must be logged in to add this to your favorites. Please Login or Register to continue"
	/// </summary>
	public override string DescriptionLoginRequired => "ë¡œê·¸ì¸í•˜ì…”ì•¼ ë³¸ í•­ëª©ì„ ì¦ê²¨ì°¾ê¸°ì— ì¶”ê°€í•  ìˆ˜ ìžˆìŠµë‹ˆë‹¤. ê³„ì†í•˜ë ¤ë©´ ë¡œê·¸ì¸ ë˜ëŠ” ê°€ìž…í•˜ì„¸ìš”";

	/// <summary>
	/// Key: "Heading.Favorites"
	/// This is the button that users will click on the navigation menu to go to the Favorites page, which contains items and assets that the user has favorited.
	/// English String: "Favorites"
	/// </summary>
	public override string HeadingFavorites => "ì¦ê²¨ì°¾ê¸°";

	/// <summary>
	/// Key: "Heading.MyFavorites"
	/// This is the page title referring to your own favorites. This page contains the user's favorite items and assets.
	/// English String: "My Favorites"
	/// </summary>
	public override string HeadingMyFavorites => "ë‚´ ì¦ê²¨ì°¾ê¸°";

	/// <summary>
	/// Key: "Label.AddToFavorites"
	/// English String: "Add to Favorites"
	/// </summary>
	public override string LabelAddToFavorites => "ì¦ê²¨ì°¾ê¸° ì¶”ê°€";

	/// <summary>
	/// Key: "Label.Bundles"
	/// English String: "Bundles"
	/// </summary>
	public override string LabelBundles => "ë²ˆë“¤";

	/// <summary>
	/// Key: "Label.Favorite"
	/// Label for button to add game to favorites
	/// English String: "Favorite"
	/// </summary>
	public override string LabelFavorite => "ì¦ê²¨ì°¾ê¸°";

	/// <summary>
	/// Key: "Label.Favorited"
	/// Label for button to remove game from favorites
	/// English String: "Favorited"
	/// </summary>
	public override string LabelFavorited => "ì¦ê²¨ì°¾ê¸° ì™„ë£Œ";

	/// <summary>
	/// Key: "LabelLoginRequired"
	/// English String: "Login Required"
	/// </summary>
	public override string LabelLoginRequired => "ë¡œê·¸ì¸ í•„ìš”";

	/// <summary>
	/// Key: "MessageAssetNotFoundError"
	/// English String: "The asset you are trying to favorite cannot be found."
	/// </summary>
	public override string MessageAssetNotFoundError => "ì¦ê²¨ì°¾ê¸°ì— ì¶”ê°€í•˜ë ¤ëŠ” ì• ì…‹ì„ ì°¾ì„ ìˆ˜ ì—†ì–´ìš”.";

	public FavoritesResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddToFavorites()
	{
		return "ì¦ê²¨ì°¾ê¸°ì— ì¶”ê°€";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "ì·¨ì†Œ";
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "ë¡œê·¸ì¸";
	}

	protected override string _GetTemplateForActionRemoveFromFavorites()
	{
		return "ì¦ê²¨ì°¾ê¸° ì‚­ì œ";
	}

	protected override string _GetTemplateForDescriptionLoginRequired()
	{
		return "ë¡œê·¸ì¸í•˜ì…”ì•¼ ë³¸ í•­ëª©ì„ ì¦ê²¨ì°¾ê¸°ì— ì¶”ê°€í•  ìˆ˜ ìžˆìŠµë‹ˆë‹¤. ê³„ì†í•˜ë ¤ë©´ ë¡œê·¸ì¸ ë˜ëŠ” ê°€ìž…í•˜ì„¸ìš”";
	}

	protected override string _GetTemplateForHeadingFavorites()
	{
		return "ì¦ê²¨ì°¾ê¸°";
	}

	protected override string _GetTemplateForHeadingMyFavorites()
	{
		return "ë‚´ ì¦ê²¨ì°¾ê¸°";
	}

	/// <summary>
	/// Key: "Heading.UserFavorites"
	/// This is the page title referring to another user's favorites. This page contains another user's favorite items and assets.
	/// English String: "{username}'s Favorites"
	/// </summary>
	public override string HeadingUserFavorites(string username)
	{
		return $"{username}ë‹˜ì˜ ì¦ê²¨ì°¾ê¸°";
	}

	protected override string _GetTemplateForHeadingUserFavorites()
	{
		return "{username}ë‹˜ì˜ ì¦ê²¨ì°¾ê¸°";
	}

	protected override string _GetTemplateForLabelAddToFavorites()
	{
		return "ì¦ê²¨ì°¾ê¸° ì¶”ê°€";
	}

	protected override string _GetTemplateForLabelBundles()
	{
		return "ë²ˆë“¤";
	}

	protected override string _GetTemplateForLabelFavorite()
	{
		return "ì¦ê²¨ì°¾ê¸°";
	}

	protected override string _GetTemplateForLabelFavorited()
	{
		return "ì¦ê²¨ì°¾ê¸° ì™„ë£Œ";
	}

	protected override string _GetTemplateForLabelLoginRequired()
	{
		return "ë¡œê·¸ì¸ í•„ìš”";
	}

	protected override string _GetTemplateForMessageAssetNotFoundError()
	{
		return "ì¦ê²¨ì°¾ê¸°ì— ì¶”ê°€í•˜ë ¤ëŠ” ì• ì…‹ì„ ì°¾ì„ ìˆ˜ ì—†ì–´ìš”.";
	}
}


}
