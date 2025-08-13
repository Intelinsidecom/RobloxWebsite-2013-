namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides FavoritesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class FavoritesResources_de_de : FavoritesResources_en_us, IFavoritesResources, ITranslationResources
{
	/// <summary>
	/// Key: "ActionAddToFavorites"
	/// English String: "Add to Favorites"
	/// </summary>
	public override string ActionAddToFavorites => "Zu Favoriten hinzufügen";

	/// <summary>
	/// Key: "ActionCancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Abbrechen";

	/// <summary>
	/// Key: "ActionLogin"
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "Anmelden";

	/// <summary>
	/// Key: "ActionRemoveFromFavorites"
	/// English String: "Remove from Favorites"
	/// </summary>
	public override string ActionRemoveFromFavorites => "Aus Favoriten entfernen";

	/// <summary>
	/// Key: "DescriptionLoginRequired"
	/// English String: "You must be logged in to add this to your favorites. Please Login or Register to continue"
	/// </summary>
	public override string DescriptionLoginRequired => "Du musst angemeldet sein, um das zu deinen Favoriten hinzufügen zu können. Bitte melde dich an oder registriere dich, um fortzufahren.";

	/// <summary>
	/// Key: "Heading.Favorites"
	/// This is the button that users will click on the navigation menu to go to the Favorites page, which contains items and assets that the user has favorited.
	/// English String: "Favorites"
	/// </summary>
	public override string HeadingFavorites => "Favoriten";

	/// <summary>
	/// Key: "Heading.MyFavorites"
	/// This is the page title referring to your own favorites. This page contains the user's favorite items and assets.
	/// English String: "My Favorites"
	/// </summary>
	public override string HeadingMyFavorites => "Meine Favoriten";

	/// <summary>
	/// Key: "Label.AddToFavorites"
	/// English String: "Add to Favorites"
	/// </summary>
	public override string LabelAddToFavorites => "Zu Favoriten hinzufügen";

	/// <summary>
	/// Key: "Label.Bundles"
	/// English String: "Bundles"
	/// </summary>
	public override string LabelBundles => "Pakete";

	/// <summary>
	/// Key: "Label.Favorite"
	/// Label for button to add game to favorites
	/// English String: "Favorite"
	/// </summary>
	public override string LabelFavorite => "Favorit";

	/// <summary>
	/// Key: "Label.Favorited"
	/// Label for button to remove game from favorites
	/// English String: "Favorited"
	/// </summary>
	public override string LabelFavorited => "Favorit";

	/// <summary>
	/// Key: "LabelLoginRequired"
	/// English String: "Login Required"
	/// </summary>
	public override string LabelLoginRequired => "Anmeldung erforderlich";

	/// <summary>
	/// Key: "MessageAssetNotFoundError"
	/// English String: "The asset you are trying to favorite cannot be found."
	/// </summary>
	public override string MessageAssetNotFoundError => "Das Objekt, das du zu deinen Favoriten hinzufügen möchtest, kann nicht gefunden werden.";

	public FavoritesResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddToFavorites()
	{
		return "Zu Favoriten hinzufügen";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Abbrechen";
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "Anmelden";
	}

	protected override string _GetTemplateForActionRemoveFromFavorites()
	{
		return "Aus Favoriten entfernen";
	}

	protected override string _GetTemplateForDescriptionLoginRequired()
	{
		return "Du musst angemeldet sein, um das zu deinen Favoriten hinzufügen zu können. Bitte melde dich an oder registriere dich, um fortzufahren.";
	}

	protected override string _GetTemplateForHeadingFavorites()
	{
		return "Favoriten";
	}

	protected override string _GetTemplateForHeadingMyFavorites()
	{
		return "Meine Favoriten";
	}

	/// <summary>
	/// Key: "Heading.UserFavorites"
	/// This is the page title referring to another user's favorites. This page contains another user's favorite items and assets.
	/// English String: "{username}'s Favorites"
	/// </summary>
	public override string HeadingUserFavorites(string username)
	{
		return $"Favoriten von {username}";
	}

	protected override string _GetTemplateForHeadingUserFavorites()
	{
		return "Favoriten von {username}";
	}

	protected override string _GetTemplateForLabelAddToFavorites()
	{
		return "Zu Favoriten hinzufügen";
	}

	protected override string _GetTemplateForLabelBundles()
	{
		return "Pakete";
	}

	protected override string _GetTemplateForLabelFavorite()
	{
		return "Favorit";
	}

	protected override string _GetTemplateForLabelFavorited()
	{
		return "Favorit";
	}

	protected override string _GetTemplateForLabelLoginRequired()
	{
		return "Anmeldung erforderlich";
	}

	protected override string _GetTemplateForMessageAssetNotFoundError()
	{
		return "Das Objekt, das du zu deinen Favoriten hinzufügen möchtest, kann nicht gefunden werden.";
	}
}
