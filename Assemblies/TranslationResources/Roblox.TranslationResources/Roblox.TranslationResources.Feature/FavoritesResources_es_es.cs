namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides FavoritesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class FavoritesResources_es_es : FavoritesResources_en_us, IFavoritesResources, ITranslationResources
{
	/// <summary>
	/// Key: "ActionAddToFavorites"
	/// English String: "Add to Favorites"
	/// </summary>
	public override string ActionAddToFavorites => "Añadir a favoritos";

	/// <summary>
	/// Key: "ActionCancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Cancelar";

	/// <summary>
	/// Key: "ActionLogin"
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "Iniciar sesión";

	/// <summary>
	/// Key: "ActionRemoveFromFavorites"
	/// English String: "Remove from Favorites"
	/// </summary>
	public override string ActionRemoveFromFavorites => "Quitar de favoritos";

	/// <summary>
	/// Key: "DescriptionLoginRequired"
	/// English String: "You must be logged in to add this to your favorites. Please Login or Register to continue"
	/// </summary>
	public override string DescriptionLoginRequired => "Para añadir esto a favoritos tienes que iniciar sesión o registrarte.";

	/// <summary>
	/// Key: "Heading.Favorites"
	/// This is the button that users will click on the navigation menu to go to the Favorites page, which contains items and assets that the user has favorited.
	/// English String: "Favorites"
	/// </summary>
	public override string HeadingFavorites => "Favoritos";

	/// <summary>
	/// Key: "Heading.MyFavorites"
	/// This is the page title referring to your own favorites. This page contains the user's favorite items and assets.
	/// English String: "My Favorites"
	/// </summary>
	public override string HeadingMyFavorites => "Mis favoritos";

	/// <summary>
	/// Key: "Label.AddToFavorites"
	/// English String: "Add to Favorites"
	/// </summary>
	public override string LabelAddToFavorites => "Añadir a favoritos";

	/// <summary>
	/// Key: "Label.Bundles"
	/// English String: "Bundles"
	/// </summary>
	public override string LabelBundles => "Paquetes";

	/// <summary>
	/// Key: "Label.Favorite"
	/// Label for button to add game to favorites
	/// English String: "Favorite"
	/// </summary>
	public override string LabelFavorite => "Favorito";

	/// <summary>
	/// Key: "Label.Favorited"
	/// Label for button to remove game from favorites
	/// English String: "Favorited"
	/// </summary>
	public override string LabelFavorited => "Favorito";

	/// <summary>
	/// Key: "LabelLoginRequired"
	/// English String: "Login Required"
	/// </summary>
	public override string LabelLoginRequired => "Inicio de sesión obligatorio";

	/// <summary>
	/// Key: "MessageAssetNotFoundError"
	/// English String: "The asset you are trying to favorite cannot be found."
	/// </summary>
	public override string MessageAssetNotFoundError => "No se ha encontrado el recurso que quieres marcar como favorito.";

	public FavoritesResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddToFavorites()
	{
		return "Añadir a favoritos";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Cancelar";
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "Iniciar sesión";
	}

	protected override string _GetTemplateForActionRemoveFromFavorites()
	{
		return "Quitar de favoritos";
	}

	protected override string _GetTemplateForDescriptionLoginRequired()
	{
		return "Para añadir esto a favoritos tienes que iniciar sesión o registrarte.";
	}

	protected override string _GetTemplateForHeadingFavorites()
	{
		return "Favoritos";
	}

	protected override string _GetTemplateForHeadingMyFavorites()
	{
		return "Mis favoritos";
	}

	/// <summary>
	/// Key: "Heading.UserFavorites"
	/// This is the page title referring to another user's favorites. This page contains another user's favorite items and assets.
	/// English String: "{username}'s Favorites"
	/// </summary>
	public override string HeadingUserFavorites(string username)
	{
		return $"Favoritos de {username}";
	}

	protected override string _GetTemplateForHeadingUserFavorites()
	{
		return "Favoritos de {username}";
	}

	protected override string _GetTemplateForLabelAddToFavorites()
	{
		return "Añadir a favoritos";
	}

	protected override string _GetTemplateForLabelBundles()
	{
		return "Paquetes";
	}

	protected override string _GetTemplateForLabelFavorite()
	{
		return "Favorito";
	}

	protected override string _GetTemplateForLabelFavorited()
	{
		return "Favorito";
	}

	protected override string _GetTemplateForLabelLoginRequired()
	{
		return "Inicio de sesión obligatorio";
	}

	protected override string _GetTemplateForMessageAssetNotFoundError()
	{
		return "No se ha encontrado el recurso que quieres marcar como favorito.";
	}
}
