using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class FavoritesResources_en_us : TranslationResourcesBase, IFavoritesResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "ActionAddToFavorites"
	/// English String: "Add to Favorites"
	/// </summary>
	public virtual string ActionAddToFavorites => "Add to Favorites";

	/// <summary>
	/// Key: "ActionCancel"
	/// English String: "Cancel"
	/// </summary>
	public virtual string ActionCancel => "Cancel";

	/// <summary>
	/// Key: "ActionLogin"
	/// English String: "Login"
	/// </summary>
	public virtual string ActionLogin => "Login";

	/// <summary>
	/// Key: "ActionRemoveFromFavorites"
	/// English String: "Remove from Favorites"
	/// </summary>
	public virtual string ActionRemoveFromFavorites => "Remove from Favorites";

	/// <summary>
	/// Key: "DescriptionLoginRequired"
	/// English String: "You must be logged in to add this to your favorites. Please Login or Register to continue"
	/// </summary>
	public virtual string DescriptionLoginRequired => "You must be logged in to add this to your favorites. Please Login or Register to continue";

	/// <summary>
	/// Key: "Heading.Favorites"
	/// This is the button that users will click on the navigation menu to go to the Favorites page, which contains items and assets that the user has favorited.
	/// English String: "Favorites"
	/// </summary>
	public virtual string HeadingFavorites => "Favorites";

	/// <summary>
	/// Key: "Heading.MyFavorites"
	/// This is the page title referring to your own favorites. This page contains the user's favorite items and assets.
	/// English String: "My Favorites"
	/// </summary>
	public virtual string HeadingMyFavorites => "My Favorites";

	/// <summary>
	/// Key: "Label.AddToFavorites"
	/// English String: "Add to Favorites"
	/// </summary>
	public virtual string LabelAddToFavorites => "Add to Favorites";

	/// <summary>
	/// Key: "Label.Bundles"
	/// English String: "Bundles"
	/// </summary>
	public virtual string LabelBundles => "Bundles";

	/// <summary>
	/// Key: "Label.Favorite"
	/// Label for button to add game to favorites
	/// English String: "Favorite"
	/// </summary>
	public virtual string LabelFavorite => "Favorite";

	/// <summary>
	/// Key: "Label.Favorited"
	/// Label for button to remove game from favorites
	/// English String: "Favorited"
	/// </summary>
	public virtual string LabelFavorited => "Favorited";

	/// <summary>
	/// Key: "LabelLoginRequired"
	/// English String: "Login Required"
	/// </summary>
	public virtual string LabelLoginRequired => "Login Required";

	/// <summary>
	/// Key: "MessageAssetNotFoundError"
	/// English String: "The asset you are trying to favorite cannot be found."
	/// </summary>
	public virtual string MessageAssetNotFoundError => "The asset you are trying to favorite cannot be found.";

	public FavoritesResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"ActionAddToFavorites",
				_GetTemplateForActionAddToFavorites()
			},
			{
				"ActionCancel",
				_GetTemplateForActionCancel()
			},
			{
				"ActionLogin",
				_GetTemplateForActionLogin()
			},
			{
				"ActionRemoveFromFavorites",
				_GetTemplateForActionRemoveFromFavorites()
			},
			{
				"DescriptionLoginRequired",
				_GetTemplateForDescriptionLoginRequired()
			},
			{
				"Heading.Favorites",
				_GetTemplateForHeadingFavorites()
			},
			{
				"Heading.MyFavorites",
				_GetTemplateForHeadingMyFavorites()
			},
			{
				"Heading.UserFavorites",
				_GetTemplateForHeadingUserFavorites()
			},
			{
				"Label.AddToFavorites",
				_GetTemplateForLabelAddToFavorites()
			},
			{
				"Label.Bundles",
				_GetTemplateForLabelBundles()
			},
			{
				"Label.Favorite",
				_GetTemplateForLabelFavorite()
			},
			{
				"Label.Favorited",
				_GetTemplateForLabelFavorited()
			},
			{
				"LabelLoginRequired",
				_GetTemplateForLabelLoginRequired()
			},
			{
				"MessageAssetNotFoundError",
				_GetTemplateForMessageAssetNotFoundError()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.Favorites";
	}

	protected virtual string _GetTemplateForActionAddToFavorites()
	{
		return "Add to Favorites";
	}

	protected virtual string _GetTemplateForActionCancel()
	{
		return "Cancel";
	}

	protected virtual string _GetTemplateForActionLogin()
	{
		return "Login";
	}

	protected virtual string _GetTemplateForActionRemoveFromFavorites()
	{
		return "Remove from Favorites";
	}

	protected virtual string _GetTemplateForDescriptionLoginRequired()
	{
		return "You must be logged in to add this to your favorites. Please Login or Register to continue";
	}

	protected virtual string _GetTemplateForHeadingFavorites()
	{
		return "Favorites";
	}

	protected virtual string _GetTemplateForHeadingMyFavorites()
	{
		return "My Favorites";
	}

	/// <summary>
	/// Key: "Heading.UserFavorites"
	/// This is the page title referring to another user's favorites. This page contains another user's favorite items and assets.
	/// English String: "{username}'s Favorites"
	/// </summary>
	public virtual string HeadingUserFavorites(string username)
	{
		return $"{username}'s Favorites";
	}

	protected virtual string _GetTemplateForHeadingUserFavorites()
	{
		return "{username}'s Favorites";
	}

	protected virtual string _GetTemplateForLabelAddToFavorites()
	{
		return "Add to Favorites";
	}

	protected virtual string _GetTemplateForLabelBundles()
	{
		return "Bundles";
	}

	protected virtual string _GetTemplateForLabelFavorite()
	{
		return "Favorite";
	}

	protected virtual string _GetTemplateForLabelFavorited()
	{
		return "Favorited";
	}

	protected virtual string _GetTemplateForLabelLoginRequired()
	{
		return "Login Required";
	}

	protected virtual string _GetTemplateForMessageAssetNotFoundError()
	{
		return "The asset you are trying to favorite cannot be found.";
	}
}
