namespace Roblox.TranslationResources.Feature;

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
	public override string ActionAddToFavorites => "즐겨찾기에 추가";

	/// <summary>
	/// Key: "ActionCancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "취소";

	/// <summary>
	/// Key: "ActionLogin"
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "로그인";

	/// <summary>
	/// Key: "ActionRemoveFromFavorites"
	/// English String: "Remove from Favorites"
	/// </summary>
	public override string ActionRemoveFromFavorites => "즐겨찾기 삭제";

	/// <summary>
	/// Key: "DescriptionLoginRequired"
	/// English String: "You must be logged in to add this to your favorites. Please Login or Register to continue"
	/// </summary>
	public override string DescriptionLoginRequired => "로그인하셔야 본 항목을 즐겨찾기에 추가할 수 있습니다. 계속하려면 로그인 또는 가입하세요";

	/// <summary>
	/// Key: "Heading.Favorites"
	/// This is the button that users will click on the navigation menu to go to the Favorites page, which contains items and assets that the user has favorited.
	/// English String: "Favorites"
	/// </summary>
	public override string HeadingFavorites => "즐겨찾기";

	/// <summary>
	/// Key: "Heading.MyFavorites"
	/// This is the page title referring to your own favorites. This page contains the user's favorite items and assets.
	/// English String: "My Favorites"
	/// </summary>
	public override string HeadingMyFavorites => "내 즐겨찾기";

	/// <summary>
	/// Key: "Label.AddToFavorites"
	/// English String: "Add to Favorites"
	/// </summary>
	public override string LabelAddToFavorites => "즐겨찾기 추가";

	/// <summary>
	/// Key: "Label.Bundles"
	/// English String: "Bundles"
	/// </summary>
	public override string LabelBundles => "번들";

	/// <summary>
	/// Key: "Label.Favorite"
	/// Label for button to add game to favorites
	/// English String: "Favorite"
	/// </summary>
	public override string LabelFavorite => "즐겨찾기";

	/// <summary>
	/// Key: "Label.Favorited"
	/// Label for button to remove game from favorites
	/// English String: "Favorited"
	/// </summary>
	public override string LabelFavorited => "즐겨찾기 완료";

	/// <summary>
	/// Key: "LabelLoginRequired"
	/// English String: "Login Required"
	/// </summary>
	public override string LabelLoginRequired => "로그인 필요";

	/// <summary>
	/// Key: "MessageAssetNotFoundError"
	/// English String: "The asset you are trying to favorite cannot be found."
	/// </summary>
	public override string MessageAssetNotFoundError => "즐겨찾기에 추가하려는 애셋을 찾을 수 없어요.";

	public FavoritesResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddToFavorites()
	{
		return "즐겨찾기에 추가";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "취소";
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "로그인";
	}

	protected override string _GetTemplateForActionRemoveFromFavorites()
	{
		return "즐겨찾기 삭제";
	}

	protected override string _GetTemplateForDescriptionLoginRequired()
	{
		return "로그인하셔야 본 항목을 즐겨찾기에 추가할 수 있습니다. 계속하려면 로그인 또는 가입하세요";
	}

	protected override string _GetTemplateForHeadingFavorites()
	{
		return "즐겨찾기";
	}

	protected override string _GetTemplateForHeadingMyFavorites()
	{
		return "내 즐겨찾기";
	}

	/// <summary>
	/// Key: "Heading.UserFavorites"
	/// This is the page title referring to another user's favorites. This page contains another user's favorite items and assets.
	/// English String: "{username}'s Favorites"
	/// </summary>
	public override string HeadingUserFavorites(string username)
	{
		return $"{username}님의 즐겨찾기";
	}

	protected override string _GetTemplateForHeadingUserFavorites()
	{
		return "{username}님의 즐겨찾기";
	}

	protected override string _GetTemplateForLabelAddToFavorites()
	{
		return "즐겨찾기 추가";
	}

	protected override string _GetTemplateForLabelBundles()
	{
		return "번들";
	}

	protected override string _GetTemplateForLabelFavorite()
	{
		return "즐겨찾기";
	}

	protected override string _GetTemplateForLabelFavorited()
	{
		return "즐겨찾기 완료";
	}

	protected override string _GetTemplateForLabelLoginRequired()
	{
		return "로그인 필요";
	}

	protected override string _GetTemplateForMessageAssetNotFoundError()
	{
		return "즐겨찾기에 추가하려는 애셋을 찾을 수 없어요.";
	}
}
