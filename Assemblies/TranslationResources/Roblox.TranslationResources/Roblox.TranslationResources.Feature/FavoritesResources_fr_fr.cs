namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides FavoritesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class FavoritesResources_fr_fr : FavoritesResources_en_us, IFavoritesResources, ITranslationResources
{
	/// <summary>
	/// Key: "ActionAddToFavorites"
	/// English String: "Add to Favorites"
	/// </summary>
	public override string ActionAddToFavorites => "Ajouter aux favoris";

	/// <summary>
	/// Key: "ActionCancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Annuler";

	/// <summary>
	/// Key: "ActionLogin"
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "Connexion";

	/// <summary>
	/// Key: "ActionRemoveFromFavorites"
	/// English String: "Remove from Favorites"
	/// </summary>
	public override string ActionRemoveFromFavorites => "Retirer des favoris";

	/// <summary>
	/// Key: "DescriptionLoginRequired"
	/// English String: "You must be logged in to add this to your favorites. Please Login or Register to continue"
	/// </summary>
	public override string DescriptionLoginRequired => "Vous devez être connecté(e) afin d'ajouter ceci à vos favoris. Veuillez vous connecter ou vous inscrire pour continuer.";

	/// <summary>
	/// Key: "Heading.Favorites"
	/// This is the button that users will click on the navigation menu to go to the Favorites page, which contains items and assets that the user has favorited.
	/// English String: "Favorites"
	/// </summary>
	public override string HeadingFavorites => "Favoris";

	/// <summary>
	/// Key: "Heading.MyFavorites"
	/// This is the page title referring to your own favorites. This page contains the user's favorite items and assets.
	/// English String: "My Favorites"
	/// </summary>
	public override string HeadingMyFavorites => "Mes favoris";

	/// <summary>
	/// Key: "Label.AddToFavorites"
	/// English String: "Add to Favorites"
	/// </summary>
	public override string LabelAddToFavorites => "Ajouter aux favoris";

	/// <summary>
	/// Key: "Label.Bundles"
	/// English String: "Bundles"
	/// </summary>
	public override string LabelBundles => "Ensembles";

	/// <summary>
	/// Key: "Label.Favorite"
	/// Label for button to add game to favorites
	/// English String: "Favorite"
	/// </summary>
	public override string LabelFavorite => "Favoris";

	/// <summary>
	/// Key: "Label.Favorited"
	/// Label for button to remove game from favorites
	/// English String: "Favorited"
	/// </summary>
	public override string LabelFavorited => "En favoris";

	/// <summary>
	/// Key: "LabelLoginRequired"
	/// English String: "Login Required"
	/// </summary>
	public override string LabelLoginRequired => "Connexion requise";

	/// <summary>
	/// Key: "MessageAssetNotFoundError"
	/// English String: "The asset you are trying to favorite cannot be found."
	/// </summary>
	public override string MessageAssetNotFoundError => "L'élément que vous voulez ajouter aux favoris est introuvable.";

	public FavoritesResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddToFavorites()
	{
		return "Ajouter aux favoris";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Annuler";
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "Connexion";
	}

	protected override string _GetTemplateForActionRemoveFromFavorites()
	{
		return "Retirer des favoris";
	}

	protected override string _GetTemplateForDescriptionLoginRequired()
	{
		return "Vous devez être connecté(e) afin d'ajouter ceci à vos favoris. Veuillez vous connecter ou vous inscrire pour continuer.";
	}

	protected override string _GetTemplateForHeadingFavorites()
	{
		return "Favoris";
	}

	protected override string _GetTemplateForHeadingMyFavorites()
	{
		return "Mes favoris";
	}

	/// <summary>
	/// Key: "Heading.UserFavorites"
	/// This is the page title referring to another user's favorites. This page contains another user's favorite items and assets.
	/// English String: "{username}'s Favorites"
	/// </summary>
	public override string HeadingUserFavorites(string username)
	{
		return $"Favoris de {username}";
	}

	protected override string _GetTemplateForHeadingUserFavorites()
	{
		return "Favoris de {username}";
	}

	protected override string _GetTemplateForLabelAddToFavorites()
	{
		return "Ajouter aux favoris";
	}

	protected override string _GetTemplateForLabelBundles()
	{
		return "Ensembles";
	}

	protected override string _GetTemplateForLabelFavorite()
	{
		return "Favoris";
	}

	protected override string _GetTemplateForLabelFavorited()
	{
		return "En favoris";
	}

	protected override string _GetTemplateForLabelLoginRequired()
	{
		return "Connexion requise";
	}

	protected override string _GetTemplateForMessageAssetNotFoundError()
	{
		return "L'élément que vous voulez ajouter aux favoris est introuvable.";
	}
}
