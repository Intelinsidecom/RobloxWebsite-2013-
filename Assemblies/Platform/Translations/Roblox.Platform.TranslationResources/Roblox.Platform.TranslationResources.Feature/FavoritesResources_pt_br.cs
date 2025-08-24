namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides FavoritesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class FavoritesResources_pt_br : FavoritesResources_en_us, IFavoritesResources, ITranslationResources
{
	/// <summary>
	/// Key: "ActionAddToFavorites"
	/// English String: "Add to Favorites"
	/// </summary>
	public override string ActionAddToFavorites => "Adicionar aos favoritos";

	/// <summary>
	/// Key: "ActionCancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Cancelar";

	/// <summary>
	/// Key: "ActionLogin"
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "Conectar-se";

	/// <summary>
	/// Key: "ActionRemoveFromFavorites"
	/// English String: "Remove from Favorites"
	/// </summary>
	public override string ActionRemoveFromFavorites => "Remover dos favoritos";

	/// <summary>
	/// Key: "DescriptionLoginRequired"
	/// English String: "You must be logged in to add this to your favorites. Please Login or Register to continue"
	/// </summary>
	public override string DescriptionLoginRequired => "Você precisa estar conectado para adicionar isto aos seus favoritos. Conecte-se ou cadastre-se para continuar.";

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
	public override string HeadingMyFavorites => "Meus favoritos";

	/// <summary>
	/// Key: "Label.AddToFavorites"
	/// English String: "Add to Favorites"
	/// </summary>
	public override string LabelAddToFavorites => "Adicionar aos favoritos";

	/// <summary>
	/// Key: "Label.Bundles"
	/// English String: "Bundles"
	/// </summary>
	public override string LabelBundles => "Pacotes";

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
	public override string LabelLoginRequired => "Conexão obrigatória";

	/// <summary>
	/// Key: "MessageAssetNotFoundError"
	/// English String: "The asset you are trying to favorite cannot be found."
	/// </summary>
	public override string MessageAssetNotFoundError => "O elemento que você está tentando selecionar como favorito não pode ser encontrado.";

	public FavoritesResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAddToFavorites()
	{
		return "Adicionar aos favoritos";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Cancelar";
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "Conectar-se";
	}

	protected override string _GetTemplateForActionRemoveFromFavorites()
	{
		return "Remover dos favoritos";
	}

	protected override string _GetTemplateForDescriptionLoginRequired()
	{
		return "Você precisa estar conectado para adicionar isto aos seus favoritos. Conecte-se ou cadastre-se para continuar.";
	}

	protected override string _GetTemplateForHeadingFavorites()
	{
		return "Favoritos";
	}

	protected override string _GetTemplateForHeadingMyFavorites()
	{
		return "Meus favoritos";
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
		return "Adicionar aos favoritos";
	}

	protected override string _GetTemplateForLabelBundles()
	{
		return "Pacotes";
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
		return "Conexão obrigatória";
	}

	protected override string _GetTemplateForMessageAssetNotFoundError()
	{
		return "O elemento que você está tentando selecionar como favorito não pode ser encontrado.";
	}
}
