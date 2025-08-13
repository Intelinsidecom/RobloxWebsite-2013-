using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Common;

internal class GameSortsResources_en_us : TranslationResourcesBase, IGameSortsResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Label.Adventure"
	/// English String: "Adventure"
	/// </summary>
	public virtual string LabelAdventure => "Adventure";

	/// <summary>
	/// Key: "Label.BuildersClub"
	/// English String: "Builders Club"
	/// </summary>
	public virtual string LabelBuildersClub => "Builders Club";

	/// <summary>
	/// Key: "Label.Contest"
	/// English String: "Contest"
	/// </summary>
	public virtual string LabelContest => "Contest";

	/// <summary>
	/// Key: "Label.ContinuePlaying"
	/// English String: "Continue Playing"
	/// </summary>
	public virtual string LabelContinuePlaying => "Continue Playing";

	/// <summary>
	/// Key: "Label.Experimental"
	/// English String: "Recommended"
	/// </summary>
	public virtual string LabelExperimental => "Recommended";

	/// <summary>
	/// Key: "Label.Favorites"
	/// English String: "Favorites"
	/// </summary>
	public virtual string LabelFavorites => "Favorites";

	/// <summary>
	/// Key: "Label.Featured"
	/// English String: "Featured Rthro"
	/// </summary>
	public virtual string LabelFeatured => "Featured Rthro";

	/// <summary>
	/// Key: "Label.Fighting"
	/// English String: "Fighting"
	/// </summary>
	public virtual string LabelFighting => "Fighting";

	/// <summary>
	/// Key: "Label.FriendActivity"
	/// English String: "Friend Activity"
	/// </summary>
	public virtual string LabelFriendActivity => "Friend Activity";

	/// <summary>
	/// Key: "Label.FriendsPlaying"
	/// English String: "Friends Playing"
	/// </summary>
	public virtual string LabelFriendsPlaying => "Friends Playing";

	/// <summary>
	/// Key: "Label.GamesForYou"
	/// English String: "Games for You"
	/// </summary>
	public virtual string LabelGamesForYou => "Games for You";

	/// <summary>
	/// Key: "Label.MoreResultsFor"
	/// English String: "More Results for"
	/// </summary>
	public virtual string LabelMoreResultsFor => "More Results for";

	/// <summary>
	/// Key: "Label.MostEngaging"
	/// English String: "Most Engaging"
	/// </summary>
	public virtual string LabelMostEngaging => "Most Engaging";

	/// <summary>
	/// Key: "Label.MyFavorite"
	/// English String: "My Favorite"
	/// </summary>
	public virtual string LabelMyFavorite => "My Favorite";

	/// <summary>
	/// Key: "Label.MyFavorites"
	/// English String: "My Favorites"
	/// </summary>
	public virtual string LabelMyFavorites => "My Favorites";

	/// <summary>
	/// Key: "Label.MyRecent"
	/// English String: "My Recent"
	/// </summary>
	public virtual string LabelMyRecent => "My Recent";

	/// <summary>
	/// Key: "Label.Obby"
	/// English String: "Obby"
	/// </summary>
	public virtual string LabelObby => "Obby";

	/// <summary>
	/// Key: "Label.PersonalizedByLiked"
	/// English String: "Because You Liked"
	/// </summary>
	public virtual string LabelPersonalizedByLiked => "Because You Liked";

	/// <summary>
	/// Key: "Label.PersonalServer"
	/// English String: "Personal Server"
	/// </summary>
	public virtual string LabelPersonalServer => "Personal Server";

	/// <summary>
	/// Key: "Label.PlayersLove"
	/// English String: "Players Love"
	/// </summary>
	public virtual string LabelPlayersLove => "Players Love";

	/// <summary>
	/// Key: "Label.Popular"
	/// English String: "Popular"
	/// </summary>
	public virtual string LabelPopular => "Popular";

	/// <summary>
	/// Key: "Label.PopularInVr"
	/// English String: "Popular in VR"
	/// </summary>
	public virtual string LabelPopularInVr => "Popular in VR";

	/// <summary>
	/// Key: "Label.PopularNearYou"
	/// English String: "Popular Near You"
	/// </summary>
	public virtual string LabelPopularNearYou => "Popular Near You";

	/// <summary>
	/// Key: "Label.PopularWorldwide"
	/// English String: "Popular Worldwide"
	/// </summary>
	public virtual string LabelPopularWorldwide => "Popular Worldwide";

	/// <summary>
	/// Key: "Label.Purchased"
	/// English String: "Purchased"
	/// </summary>
	public virtual string LabelPurchased => "Purchased";

	/// <summary>
	/// Key: "Label.Roleplay"
	/// English String: "Roleplay"
	/// </summary>
	public virtual string LabelRoleplay => "Roleplay";

	/// <summary>
	/// Key: "Label.Simulator"
	/// English String: "Simulator"
	/// </summary>
	public virtual string LabelSimulator => "Simulator";

	/// <summary>
	/// Key: "Label.SuggestedGames"
	/// English String: "Suggested Games"
	/// </summary>
	public virtual string LabelSuggestedGames => "Suggested Games";

	/// <summary>
	/// Key: "Label.TopFavorite"
	/// English String: "Top Favorite"
	/// </summary>
	public virtual string LabelTopFavorite => "Top Favorite";

	/// <summary>
	/// Key: "Label.TopGrossing"
	/// English String: "Top Earning"
	/// </summary>
	public virtual string LabelTopGrossing => "Top Earning";

	/// <summary>
	/// Key: "Label.TopPaid"
	/// English String: "Top Paid"
	/// </summary>
	public virtual string LabelTopPaid => "Top Paid";

	/// <summary>
	/// Key: "Label.TopRated"
	/// English String: "Top Rated"
	/// </summary>
	public virtual string LabelTopRated => "Top Rated";

	/// <summary>
	/// Key: "Label.TopResult"
	/// English String: "Top Result"
	/// </summary>
	public virtual string LabelTopResult => "Top Result";

	/// <summary>
	/// Key: "Label.TopRetaining"
	/// English String: "Recommended"
	/// </summary>
	public virtual string LabelTopRetaining => "Recommended";

	/// <summary>
	/// Key: "Label.Tycoon"
	/// English String: "Tycoon"
	/// </summary>
	public virtual string LabelTycoon => "Tycoon";

	/// <summary>
	/// Key: "Label.UpAndComing"
	/// English String: "Up-and-Coming"
	/// </summary>
	public virtual string LabelUpAndComing => "Up-and-Coming";

	/// <summary>
	/// Key: "MoreResultsFor"
	/// English String: "More Results for"
	/// </summary>
	public virtual string MoreResultsFor => "More Results for";

	public GameSortsResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Label.Adventure",
				_GetTemplateForLabelAdventure()
			},
			{
				"Label.BuildersClub",
				_GetTemplateForLabelBuildersClub()
			},
			{
				"Label.Contest",
				_GetTemplateForLabelContest()
			},
			{
				"Label.ContinuePlaying",
				_GetTemplateForLabelContinuePlaying()
			},
			{
				"Label.Experimental",
				_GetTemplateForLabelExperimental()
			},
			{
				"Label.Favorites",
				_GetTemplateForLabelFavorites()
			},
			{
				"Label.Featured",
				_GetTemplateForLabelFeatured()
			},
			{
				"Label.Fighting",
				_GetTemplateForLabelFighting()
			},
			{
				"Label.FriendActivity",
				_GetTemplateForLabelFriendActivity()
			},
			{
				"Label.FriendsPlaying",
				_GetTemplateForLabelFriendsPlaying()
			},
			{
				"Label.GamesForYou",
				_GetTemplateForLabelGamesForYou()
			},
			{
				"Label.MoreResultsFor",
				_GetTemplateForLabelMoreResultsFor()
			},
			{
				"Label.MostEngaging",
				_GetTemplateForLabelMostEngaging()
			},
			{
				"Label.MyFavorite",
				_GetTemplateForLabelMyFavorite()
			},
			{
				"Label.MyFavorites",
				_GetTemplateForLabelMyFavorites()
			},
			{
				"Label.MyRecent",
				_GetTemplateForLabelMyRecent()
			},
			{
				"Label.Obby",
				_GetTemplateForLabelObby()
			},
			{
				"Label.PersonalizedByLiked",
				_GetTemplateForLabelPersonalizedByLiked()
			},
			{
				"Label.PersonalServer",
				_GetTemplateForLabelPersonalServer()
			},
			{
				"Label.PlayersLove",
				_GetTemplateForLabelPlayersLove()
			},
			{
				"Label.Popular",
				_GetTemplateForLabelPopular()
			},
			{
				"Label.PopularInCountry",
				_GetTemplateForLabelPopularInCountry()
			},
			{
				"Label.PopularInVr",
				_GetTemplateForLabelPopularInVr()
			},
			{
				"Label.PopularNearYou",
				_GetTemplateForLabelPopularNearYou()
			},
			{
				"Label.PopularWorldwide",
				_GetTemplateForLabelPopularWorldwide()
			},
			{
				"Label.Purchased",
				_GetTemplateForLabelPurchased()
			},
			{
				"Label.Roleplay",
				_GetTemplateForLabelRoleplay()
			},
			{
				"Label.Simulator",
				_GetTemplateForLabelSimulator()
			},
			{
				"Label.SuggestedGames",
				_GetTemplateForLabelSuggestedGames()
			},
			{
				"Label.TopFavorite",
				_GetTemplateForLabelTopFavorite()
			},
			{
				"Label.TopGrossing",
				_GetTemplateForLabelTopGrossing()
			},
			{
				"Label.TopPaid",
				_GetTemplateForLabelTopPaid()
			},
			{
				"Label.TopRated",
				_GetTemplateForLabelTopRated()
			},
			{
				"Label.TopResult",
				_GetTemplateForLabelTopResult()
			},
			{
				"Label.TopRetaining",
				_GetTemplateForLabelTopRetaining()
			},
			{
				"Label.Tycoon",
				_GetTemplateForLabelTycoon()
			},
			{
				"Label.UpAndComing",
				_GetTemplateForLabelUpAndComing()
			},
			{
				"MoreResultsFor",
				_GetTemplateForMoreResultsFor()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Common.GameSorts";
	}

	protected virtual string _GetTemplateForLabelAdventure()
	{
		return "Adventure";
	}

	protected virtual string _GetTemplateForLabelBuildersClub()
	{
		return "Builders Club";
	}

	protected virtual string _GetTemplateForLabelContest()
	{
		return "Contest";
	}

	protected virtual string _GetTemplateForLabelContinuePlaying()
	{
		return "Continue Playing";
	}

	protected virtual string _GetTemplateForLabelExperimental()
	{
		return "Recommended";
	}

	protected virtual string _GetTemplateForLabelFavorites()
	{
		return "Favorites";
	}

	protected virtual string _GetTemplateForLabelFeatured()
	{
		return "Featured Rthro";
	}

	protected virtual string _GetTemplateForLabelFighting()
	{
		return "Fighting";
	}

	protected virtual string _GetTemplateForLabelFriendActivity()
	{
		return "Friend Activity";
	}

	protected virtual string _GetTemplateForLabelFriendsPlaying()
	{
		return "Friends Playing";
	}

	protected virtual string _GetTemplateForLabelGamesForYou()
	{
		return "Games for You";
	}

	protected virtual string _GetTemplateForLabelMoreResultsFor()
	{
		return "More Results for";
	}

	protected virtual string _GetTemplateForLabelMostEngaging()
	{
		return "Most Engaging";
	}

	protected virtual string _GetTemplateForLabelMyFavorite()
	{
		return "My Favorite";
	}

	protected virtual string _GetTemplateForLabelMyFavorites()
	{
		return "My Favorites";
	}

	protected virtual string _GetTemplateForLabelMyRecent()
	{
		return "My Recent";
	}

	protected virtual string _GetTemplateForLabelObby()
	{
		return "Obby";
	}

	protected virtual string _GetTemplateForLabelPersonalizedByLiked()
	{
		return "Because You Liked";
	}

	protected virtual string _GetTemplateForLabelPersonalServer()
	{
		return "Personal Server";
	}

	protected virtual string _GetTemplateForLabelPlayersLove()
	{
		return "Players Love";
	}

	protected virtual string _GetTemplateForLabelPopular()
	{
		return "Popular";
	}

	/// <summary>
	/// Key: "Label.PopularInCountry"
	/// English String: "Popular in {CountryName}"
	/// </summary>
	public virtual string LabelPopularInCountry(string CountryName)
	{
		return $"Popular in {CountryName}";
	}

	protected virtual string _GetTemplateForLabelPopularInCountry()
	{
		return "Popular in {CountryName}";
	}

	protected virtual string _GetTemplateForLabelPopularInVr()
	{
		return "Popular in VR";
	}

	protected virtual string _GetTemplateForLabelPopularNearYou()
	{
		return "Popular Near You";
	}

	protected virtual string _GetTemplateForLabelPopularWorldwide()
	{
		return "Popular Worldwide";
	}

	protected virtual string _GetTemplateForLabelPurchased()
	{
		return "Purchased";
	}

	protected virtual string _GetTemplateForLabelRoleplay()
	{
		return "Roleplay";
	}

	protected virtual string _GetTemplateForLabelSimulator()
	{
		return "Simulator";
	}

	protected virtual string _GetTemplateForLabelSuggestedGames()
	{
		return "Suggested Games";
	}

	protected virtual string _GetTemplateForLabelTopFavorite()
	{
		return "Top Favorite";
	}

	protected virtual string _GetTemplateForLabelTopGrossing()
	{
		return "Top Earning";
	}

	protected virtual string _GetTemplateForLabelTopPaid()
	{
		return "Top Paid";
	}

	protected virtual string _GetTemplateForLabelTopRated()
	{
		return "Top Rated";
	}

	protected virtual string _GetTemplateForLabelTopResult()
	{
		return "Top Result";
	}

	protected virtual string _GetTemplateForLabelTopRetaining()
	{
		return "Recommended";
	}

	protected virtual string _GetTemplateForLabelTycoon()
	{
		return "Tycoon";
	}

	protected virtual string _GetTemplateForLabelUpAndComing()
	{
		return "Up-and-Coming";
	}

	protected virtual string _GetTemplateForMoreResultsFor()
	{
		return "More Results for";
	}
}
