namespace Roblox.TranslationResources.Feature;

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
	public override string ActionAddToFavorites => "お気に入りに追加";

	/// <summary>
	/// Key: "ActionCancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "キャンセル";

	/// <summary>
	/// Key: "ActionLogin"
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "ログイン";

	/// <summary>
	/// Key: "ActionRemoveFromFavorites"
	/// English String: "Remove from Favorites"
	/// </summary>
	public override string ActionRemoveFromFavorites => "お気に入りから削除";

	/// <summary>
	/// Key: "DescriptionLoginRequired"
	/// English String: "You must be logged in to add this to your favorites. Please Login or Register to continue"
	/// </summary>
	public override string DescriptionLoginRequired => "お気に入りに追加するにはログインする必要があります。ログインまたは新規登録してください。";

	/// <summary>
	/// Key: "Heading.Favorites"
	/// This is the button that users will click on the navigation menu to go to the Favorites page, which contains items and assets that the user has favorited.
	/// English String: "Favorites"
	/// </summary>
	public override string HeadingFavorites => "お気に入り";

	/// <summary>
	/// Key: "Heading.MyFavorites"
	/// This is the page title referring to your own favorites. This page contains the user's favorite items and assets.
	/// English String: "My Favorites"
	/// </summary>
	public override string HeadingMyFavorites => "あなたのお気に入り";

	/// <summary>
	/// Key: "Label.AddToFavorites"
	/// English String: "Add to Favorites"
	/// </summary>
	public override string LabelAddToFavorites => "お気に入りに追加";

	/// <summary>
	/// Key: "Label.Bundles"
	/// English String: "Bundles"
	/// </summary>
	public override string LabelBundles => "バンドル";

	/// <summary>
	/// Key: "Label.Favorite"
	/// Label for button to add game to favorites
	/// English String: "Favorite"
	/// </summary>
	public override string LabelFavorite => "お気に入り";

	/// <summary>
	/// Key: "Label.Favorited"
	/// Label for button to remove game from favorites
	/// English String: "Favorited"
	/// </summary>
	public override string LabelFavorited => "お気に入りに登録済み";

	/// <summary>
	/// Key: "LabelLoginRequired"
	/// English String: "Login Required"
	/// </summary>
	public override string LabelLoginRequired => "ログインが必要です";

	/// <summary>
	/// Key: "MessageAssetNotFoundError"
	/// English String: "The asset you are trying to favorite cannot be found."
	/// </summary>
	public override string MessageAssetNotFoundError => "お気に入りに追加しようとしているアセットが見つかりません。";

	public FavoritesResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddToFavorites()
	{
		return "お気に入りに追加";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "キャンセル";
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "ログイン";
	}

	protected override string _GetTemplateForActionRemoveFromFavorites()
	{
		return "お気に入りから削除";
	}

	protected override string _GetTemplateForDescriptionLoginRequired()
	{
		return "お気に入りに追加するにはログインする必要があります。ログインまたは新規登録してください。";
	}

	protected override string _GetTemplateForHeadingFavorites()
	{
		return "お気に入り";
	}

	protected override string _GetTemplateForHeadingMyFavorites()
	{
		return "あなたのお気に入り";
	}

	/// <summary>
	/// Key: "Heading.UserFavorites"
	/// This is the page title referring to another user's favorites. This page contains another user's favorite items and assets.
	/// English String: "{username}'s Favorites"
	/// </summary>
	public override string HeadingUserFavorites(string username)
	{
		return $"{username} さんのお気に入り";
	}

	protected override string _GetTemplateForHeadingUserFavorites()
	{
		return "{username} さんのお気に入り";
	}

	protected override string _GetTemplateForLabelAddToFavorites()
	{
		return "お気に入りに追加";
	}

	protected override string _GetTemplateForLabelBundles()
	{
		return "バンドル";
	}

	protected override string _GetTemplateForLabelFavorite()
	{
		return "お気に入り";
	}

	protected override string _GetTemplateForLabelFavorited()
	{
		return "お気に入りに登録済み";
	}

	protected override string _GetTemplateForLabelLoginRequired()
	{
		return "ログインが必要です";
	}

	protected override string _GetTemplateForMessageAssetNotFoundError()
	{
		return "お気に入りに追加しようとしているアセットが見つかりません。";
	}
}
