using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class SocialMetaTagsResources_en_us : TranslationResourcesBase, ISocialMetaTagsResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Description.DevelopLanding"
	/// description shown on Facebook or Twitter when shared
	/// English String: "Create anything you can imagine with Roblox's free and immersive creation engine. Start creating games today!"
	/// </summary>
	public virtual string DescriptionDevelopLanding => "Create anything you can imagine with Roblox's free and immersive creation engine. Start creating games today!";

	/// <summary>
	/// Key: "Description.GamesPage"
	/// description shown when Games page is shared on Facebook or Twitter
	/// English String: "Play millions of free games on your smartphone, tablet, computer, Xbox One, Oculus Rift, and more."
	/// </summary>
	public virtual string DescriptionGamesPage => "Play millions of free games on your smartphone, tablet, computer, Xbox One, Oculus Rift, and more.";

	/// <summary>
	/// Key: "Description.Roblox"
	/// description shown on Facebook or Twitter when Roblox landing page is shared
	/// English String: "Roblox is ushering in the next generation of entertainment. Imagine, create, and play together with millions of players across an infinite variety of immersive, user-generated 3D worlds."
	/// </summary>
	public virtual string DescriptionRoblox => "Roblox is ushering in the next generation of entertainment. Imagine, create, and play together with millions of players across an infinite variety of immersive, user-generated 3D worlds.";

	/// <summary>
	/// Key: "Label.CatalogPage"
	/// Description shown when the catalog page is shared on Facebook or Twitter
	/// English String: "Customize your avatar with a never-ending variety of clothing options, accessories, gear, and more!"
	/// </summary>
	public virtual string LabelCatalogPage => "Customize your avatar with a never-ending variety of clothing options, accessories, gear, and more!";

	/// <summary>
	/// Key: "Label.CatalogPageTItle"
	/// title
	/// English String: "Roblox Catalog"
	/// </summary>
	public virtual string LabelCatalogPageTItle => "Roblox Catalog";

	/// <summary>
	/// Key: "Label.GamesPageTitle"
	/// title for social meta tag fro games page
	/// English String: "Roblox Games"
	/// </summary>
	public virtual string LabelGamesPageTitle => "Roblox Games";

	public SocialMetaTagsResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Description.DevelopLanding",
				_GetTemplateForDescriptionDevelopLanding()
			},
			{
				"Description.FavoritesPage",
				_GetTemplateForDescriptionFavoritesPage()
			},
			{
				"Description.GamePage",
				_GetTemplateForDescriptionGamePage()
			},
			{
				"Description.GamesPage",
				_GetTemplateForDescriptionGamesPage()
			},
			{
				"Description.InventoryPage",
				_GetTemplateForDescriptionInventoryPage()
			},
			{
				"Description.Roblox",
				_GetTemplateForDescriptionRoblox()
			},
			{
				"Description.UserProfilePage",
				_GetTemplateForDescriptionUserProfilePage()
			},
			{
				"Label.CatalogPage",
				_GetTemplateForLabelCatalogPage()
			},
			{
				"Label.CatalogPageTItle",
				_GetTemplateForLabelCatalogPageTItle()
			},
			{
				"Label.GamesPageTitle",
				_GetTemplateForLabelGamesPageTitle()
			},
			{
				"Label.UserProfile",
				_GetTemplateForLabelUserProfile()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.SocialMetaTags";
	}

	protected virtual string _GetTemplateForDescriptionDevelopLanding()
	{
		return "Create anything you can imagine with Roblox's free and immersive creation engine. Start creating games today!";
	}

	/// <summary>
	/// Key: "Description.FavoritesPage"
	/// social meta tag
	/// English String: "Visit {userName}’s Favorites and see what they like. Browse through their favorite places, accessories, and a lot more. Also, find the favorite gear they use in games and get one for yourself!"
	/// </summary>
	public virtual string DescriptionFavoritesPage(string userName)
	{
		return $"Visit {userName}’s Favorites and see what they like. Browse through their favorite places, accessories, and a lot more. Also, find the favorite gear they use in games and get one for yourself!";
	}

	protected virtual string _GetTemplateForDescriptionFavoritesPage()
	{
		return "Visit {userName}’s Favorites and see what they like. Browse through their favorite places, accessories, and a lot more. Also, find the favorite gear they use in games and get one for yourself!";
	}

	/// <summary>
	/// Key: "Description.GamePage"
	/// The game description which shows on social media, when shared
	/// English String: "Check out {gameName}. It’s one of the millions of unique, user-generated 3D experiences created on Roblox. {gameDescription}"
	/// </summary>
	public virtual string DescriptionGamePage(string gameName, string gameDescription)
	{
		return $"Check out {gameName}. It’s one of the millions of unique, user-generated 3D experiences created on Roblox. {gameDescription}";
	}

	protected virtual string _GetTemplateForDescriptionGamePage()
	{
		return "Check out {gameName}. It’s one of the millions of unique, user-generated 3D experiences created on Roblox. {gameDescription}";
	}

	protected virtual string _GetTemplateForDescriptionGamesPage()
	{
		return "Play millions of free games on your smartphone, tablet, computer, Xbox One, Oculus Rift, and more.";
	}

	/// <summary>
	/// Key: "Description.InventoryPage"
	/// social meta tag
	/// English String: "Visit {userName1}’s Inventory and see the cool items they have collected. Look out for their game passes and get one for yourself! Browse through {userName2}’s collection of hats, shirts, gear, and more."
	/// </summary>
	public virtual string DescriptionInventoryPage(string userName1, string userName2)
	{
		return $"Visit {userName1}’s Inventory and see the cool items they have collected. Look out for their game passes and get one for yourself! Browse through {userName2}’s collection of hats, shirts, gear, and more.";
	}

	protected virtual string _GetTemplateForDescriptionInventoryPage()
	{
		return "Visit {userName1}’s Inventory and see the cool items they have collected. Look out for their game passes and get one for yourself! Browse through {userName2}’s collection of hats, shirts, gear, and more.";
	}

	protected virtual string _GetTemplateForDescriptionRoblox()
	{
		return "Roblox is ushering in the next generation of entertainment. Imagine, create, and play together with millions of players across an infinite variety of immersive, user-generated 3D worlds.";
	}

	/// <summary>
	/// Key: "Description.UserProfilePage"
	/// message when a user profile is shared on Social Media
	/// English String: "{userName1} is one of the millions playing, creating and exploring the endless possibilities of Roblox. Join {userName2} on Roblox and explore together!"
	/// </summary>
	public virtual string DescriptionUserProfilePage(string userName1, string userName2)
	{
		return $"{userName1} is one of the millions playing, creating and exploring the endless possibilities of Roblox. Join {userName2} on Roblox and explore together!";
	}

	protected virtual string _GetTemplateForDescriptionUserProfilePage()
	{
		return "{userName1} is one of the millions playing, creating and exploring the endless possibilities of Roblox. Join {userName2} on Roblox and explore together!";
	}

	protected virtual string _GetTemplateForLabelCatalogPage()
	{
		return "Customize your avatar with a never-ending variety of clothing options, accessories, gear, and more!";
	}

	protected virtual string _GetTemplateForLabelCatalogPageTItle()
	{
		return "Roblox Catalog";
	}

	protected virtual string _GetTemplateForLabelGamesPageTitle()
	{
		return "Roblox Games";
	}

	/// <summary>
	/// Key: "Label.UserProfile"
	/// title of the social meta tag
	/// English String: "{userName}'s Profile"
	/// </summary>
	public virtual string LabelUserProfile(string userName)
	{
		return $"{userName}'s Profile";
	}

	protected virtual string _GetTemplateForLabelUserProfile()
	{
		return "{userName}'s Profile";
	}
}
