using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class GamePageResources_en_us : TranslationResourcesBase, IGamePageResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "abelFilterDefault"
	/// English String: "Default"
	/// </summary>
	public virtual string abelFilterDefault => "Default";

	/// <summary>
	/// Key: "ActionDisableExperimentalMode"
	/// English String: "Disable"
	/// </summary>
	public virtual string ActionDisableExperimentalMode => "Disable";

	/// <summary>
	/// Key: "ActionSeeAll"
	/// English String: "See All"
	/// </summary>
	public virtual string ActionSeeAll => "See All";

	/// <summary>
	/// Key: "HeadingExperimentalMode"
	/// English String: "Experimental Mode Games"
	/// </summary>
	public virtual string HeadingExperimentalMode => "Experimental Mode Games";

	/// <summary>
	/// Key: "Label.FilterExperimental"
	/// English String: "Recommended"
	/// </summary>
	public virtual string LabelFilterExperimental => "Recommended";

	/// <summary>
	/// Key: "Label.MoreResults"
	/// English String: "more results"
	/// </summary>
	public virtual string LabelMoreResults => "more results";

	/// <summary>
	/// Key: "Label.MoreResultsFor"
	/// English String: "More Results For"
	/// </summary>
	public virtual string LabelMoreResultsFor => "More Results For";

	/// <summary>
	/// Key: "Label.SponsoredAd"
	/// text for label of sponsored game cards
	/// English String: "Sponsored Ad"
	/// </summary>
	public virtual string LabelSponsoredAd => "Sponsored Ad";

	/// <summary>
	/// Key: "Label.TopResult"
	/// English String: "Top Result"
	/// </summary>
	public virtual string LabelTopResult => "Top Result";

	/// <summary>
	/// Key: "LabelCancelField"
	/// English String: "Cancel"
	/// </summary>
	public virtual string LabelCancelField => "Cancel";

	/// <summary>
	/// Key: "LabelExperimental"
	/// English String: "Experimental"
	/// </summary>
	public virtual string LabelExperimental => "Experimental";

	/// <summary>
	/// Key: "LabelExperimentalHelpText"
	/// English String: "What's this?"
	/// </summary>
	public virtual string LabelExperimentalHelpText => "What's this?";

	/// <summary>
	/// Key: "LabelExperimentalMode"
	/// English String: "Experimental Mode"
	/// </summary>
	public virtual string LabelExperimentalMode => "Experimental Mode";

	/// <summary>
	/// Key: "LabelExperimentalResults"
	/// English String: "These results contain Experimental Mode games."
	/// </summary>
	public virtual string LabelExperimentalResults => "These results contain Experimental Mode games.";

	/// <summary>
	/// Key: "LabelFilterAllTime"
	/// English String: "All Time"
	/// </summary>
	public virtual string LabelFilterAllTime => "All Time";

	/// <summary>
	/// Key: "LabelFilterBuildersClub"
	/// English String: "Builders Club"
	/// </summary>
	public virtual string LabelFilterBuildersClub => "Builders Club";

	/// <summary>
	/// Key: "LabelFilterBy"
	/// English String: "Filter By"
	/// </summary>
	public virtual string LabelFilterBy => "Filter By";

	/// <summary>
	/// Key: "LabelFilterContest"
	/// English String: "Contest"
	/// </summary>
	public virtual string LabelFilterContest => "Contest";

	/// <summary>
	/// Key: "LabelFilterDefault"
	/// English String: "Default"
	/// </summary>
	public virtual string LabelFilterDefault => "Default";

	/// <summary>
	/// Key: "LabelFilterFeatured"
	/// English String: "Featured"
	/// </summary>
	public virtual string LabelFilterFeatured => "Featured";

	/// <summary>
	/// Key: "LabelFilterFriendActivity"
	/// English String: "Friend Activity"
	/// </summary>
	public virtual string LabelFilterFriendActivity => "Friend Activity";

	/// <summary>
	/// Key: "LabelFilterGenre"
	/// English String: "Genre"
	/// </summary>
	public virtual string LabelFilterGenre => "Genre";

	/// <summary>
	/// Key: "LabelFilterMyFavorite"
	/// English String: "My Favorite"
	/// </summary>
	public virtual string LabelFilterMyFavorite => "My Favorite";

	/// <summary>
	/// Key: "LabelFilterMyFavorites"
	/// English String: "My Favorites"
	/// </summary>
	public virtual string LabelFilterMyFavorites => "My Favorites";

	/// <summary>
	/// Key: "LabelFilterMyRecent"
	/// English String: "My Recent"
	/// </summary>
	public virtual string LabelFilterMyRecent => "My Recent";

	/// <summary>
	/// Key: "LabelFilterNow"
	/// English String: "Now"
	/// </summary>
	public virtual string LabelFilterNow => "Now";

	/// <summary>
	/// Key: "LabelFilterPastDay"
	/// English String: "Past Day"
	/// </summary>
	public virtual string LabelFilterPastDay => "Past Day";

	/// <summary>
	/// Key: "LabelFilterPastWeek"
	/// English String: "Past Week"
	/// </summary>
	public virtual string LabelFilterPastWeek => "Past Week";

	/// <summary>
	/// Key: "LabelFilterPersonalizedByLiked"
	/// English String: "Because You Liked"
	/// </summary>
	public virtual string LabelFilterPersonalizedByLiked => "Because You Liked";

	/// <summary>
	/// Key: "LabelFilterPersonalServer"
	/// English String: "Personal Server"
	/// </summary>
	public virtual string LabelFilterPersonalServer => "Personal Server";

	/// <summary>
	/// Key: "LabelFilterPopular"
	/// English String: "Popular"
	/// </summary>
	public virtual string LabelFilterPopular => "Popular";

	/// <summary>
	/// Key: "LabelFilterPopularInVr"
	/// English String: "Popular in VR"
	/// </summary>
	public virtual string LabelFilterPopularInVr => "Popular in VR";

	/// <summary>
	/// Key: "LabelFilterPopularNearYou"
	/// English String: "Popular Near You"
	/// </summary>
	public virtual string LabelFilterPopularNearYou => "Popular Near You";

	/// <summary>
	/// Key: "LabelFilterPopularWorldwide"
	/// English String: "Popular Worldwide"
	/// </summary>
	public virtual string LabelFilterPopularWorldwide => "Popular Worldwide";

	/// <summary>
	/// Key: "LabelFilterPurchased"
	/// English String: "Purchased"
	/// </summary>
	public virtual string LabelFilterPurchased => "Purchased";

	/// <summary>
	/// Key: "LabelFilterRecentlyPlayed "
	/// English String: "Recently Played"
	/// </summary>
	public virtual string LabelFilterRecentlyPlayed => "Recently Played";

	/// <summary>
	/// Key: "LabelFilterTime"
	/// English String: "Time"
	/// </summary>
	public virtual string LabelFilterTime => "Time";

	/// <summary>
	/// Key: "LabelFilterTopFavorite"
	/// English String: "Top Favorite"
	/// </summary>
	public virtual string LabelFilterTopFavorite => "Top Favorite";

	/// <summary>
	/// Key: "LabelFilterTopGrossing"
	/// English String: "Top Earning"
	/// </summary>
	public virtual string LabelFilterTopGrossing => "Top Earning";

	/// <summary>
	/// Key: "LabelFilterTopPaid"
	/// English String: "Top Paid"
	/// </summary>
	public virtual string LabelFilterTopPaid => "Top Paid";

	/// <summary>
	/// Key: "LabelFilterTopRated"
	/// English String: "Top Rated"
	/// </summary>
	public virtual string LabelFilterTopRated => "Top Rated";

	/// <summary>
	/// Key: "LabelFilterTopRetaining"
	/// English String: "Recommended"
	/// </summary>
	public virtual string LabelFilterTopRetaining => "Recommended";

	/// <summary>
	/// Key: "LabelNoSearchResults"
	/// English String: "No Search Results Found"
	/// </summary>
	public virtual string LabelNoSearchResults => "No Search Results Found";

	/// <summary>
	/// Key: "LabelSearchField"
	/// English String: "Search"
	/// </summary>
	public virtual string LabelSearchField => "Search";

	/// <summary>
	/// Key: "LabelSearchInsteadFor"
	/// English String: "Search instead for"
	/// </summary>
	public virtual string LabelSearchInsteadFor => "Search instead for";

	/// <summary>
	/// Key: "LabelSearchYouMightMean"
	/// English String: "Did you mean:"
	/// </summary>
	public virtual string LabelSearchYouMightMean => "Did you mean:";

	/// <summary>
	/// Key: "LabelShowingResultsFor"
	/// English String: "Showing results for"
	/// </summary>
	public virtual string LabelShowingResultsFor => "Showing results for";

	public GamePageResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"abelFilterDefault",
				_GetTemplateForabelFilterDefault()
			},
			{
				"ActionDisableExperimentalMode",
				_GetTemplateForActionDisableExperimentalMode()
			},
			{
				"ActionSeeAll",
				_GetTemplateForActionSeeAll()
			},
			{
				"HeadingExperimentalMode",
				_GetTemplateForHeadingExperimentalMode()
			},
			{
				"Label.FilterExperimental",
				_GetTemplateForLabelFilterExperimental()
			},
			{
				"Label.MoreResults",
				_GetTemplateForLabelMoreResults()
			},
			{
				"Label.MoreResultsFor",
				_GetTemplateForLabelMoreResultsFor()
			},
			{
				"Label.SponsoredAd",
				_GetTemplateForLabelSponsoredAd()
			},
			{
				"Label.TopResult",
				_GetTemplateForLabelTopResult()
			},
			{
				"LabelCancelField",
				_GetTemplateForLabelCancelField()
			},
			{
				"LabelCreatorBy",
				_GetTemplateForLabelCreatorBy()
			},
			{
				"LabelExperimental",
				_GetTemplateForLabelExperimental()
			},
			{
				"LabelExperimentalHelpText",
				_GetTemplateForLabelExperimentalHelpText()
			},
			{
				"LabelExperimentalMode",
				_GetTemplateForLabelExperimentalMode()
			},
			{
				"LabelExperimentalResults",
				_GetTemplateForLabelExperimentalResults()
			},
			{
				"LabelFilterAllTime",
				_GetTemplateForLabelFilterAllTime()
			},
			{
				"LabelFilterBecauseYouLiked",
				_GetTemplateForLabelFilterBecauseYouLiked()
			},
			{
				"LabelFilterBuildersClub",
				_GetTemplateForLabelFilterBuildersClub()
			},
			{
				"LabelFilterBy",
				_GetTemplateForLabelFilterBy()
			},
			{
				"LabelFilterContest",
				_GetTemplateForLabelFilterContest()
			},
			{
				"LabelFilterDefault",
				_GetTemplateForLabelFilterDefault()
			},
			{
				"LabelFilterFeatured",
				_GetTemplateForLabelFilterFeatured()
			},
			{
				"LabelFilterFriendActivity",
				_GetTemplateForLabelFilterFriendActivity()
			},
			{
				"LabelFilterGenre",
				_GetTemplateForLabelFilterGenre()
			},
			{
				"LabelFilterMyFavorite",
				_GetTemplateForLabelFilterMyFavorite()
			},
			{
				"LabelFilterMyFavorites",
				_GetTemplateForLabelFilterMyFavorites()
			},
			{
				"LabelFilterMyRecent",
				_GetTemplateForLabelFilterMyRecent()
			},
			{
				"LabelFilterNow",
				_GetTemplateForLabelFilterNow()
			},
			{
				"LabelFilterPastDay",
				_GetTemplateForLabelFilterPastDay()
			},
			{
				"LabelFilterPastWeek",
				_GetTemplateForLabelFilterPastWeek()
			},
			{
				"LabelFilterPersonalizedByLiked",
				_GetTemplateForLabelFilterPersonalizedByLiked()
			},
			{
				"LabelFilterPersonalServer",
				_GetTemplateForLabelFilterPersonalServer()
			},
			{
				"LabelFilterPopular",
				_GetTemplateForLabelFilterPopular()
			},
			{
				"LabelFilterPopularByCountry",
				_GetTemplateForLabelFilterPopularByCountry()
			},
			{
				"LabelFilterPopularInVr",
				_GetTemplateForLabelFilterPopularInVr()
			},
			{
				"LabelFilterPopularNearYou",
				_GetTemplateForLabelFilterPopularNearYou()
			},
			{
				"LabelFilterPopularWorldwide",
				_GetTemplateForLabelFilterPopularWorldwide()
			},
			{
				"LabelFilterPurchased",
				_GetTemplateForLabelFilterPurchased()
			},
			{
				"LabelFilterRecentlyPlayed ",
				_GetTemplateForLabelFilterRecentlyPlayed()
			},
			{
				"LabelFilterTime",
				_GetTemplateForLabelFilterTime()
			},
			{
				"LabelFilterTopFavorite",
				_GetTemplateForLabelFilterTopFavorite()
			},
			{
				"LabelFilterTopGrossing",
				_GetTemplateForLabelFilterTopGrossing()
			},
			{
				"LabelFilterTopPaid",
				_GetTemplateForLabelFilterTopPaid()
			},
			{
				"LabelFilterTopRated",
				_GetTemplateForLabelFilterTopRated()
			},
			{
				"LabelFilterTopRetaining",
				_GetTemplateForLabelFilterTopRetaining()
			},
			{
				"LabelNoSearchResults",
				_GetTemplateForLabelNoSearchResults()
			},
			{
				"LabelPlayingPhrase",
				_GetTemplateForLabelPlayingPhrase()
			},
			{
				"LabelSearchField",
				_GetTemplateForLabelSearchField()
			},
			{
				"LabelSearchInsteadFor",
				_GetTemplateForLabelSearchInsteadFor()
			},
			{
				"LabelSearchYouMightMean",
				_GetTemplateForLabelSearchYouMightMean()
			},
			{
				"LabelShowingResultsFor",
				_GetTemplateForLabelShowingResultsFor()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.GamePage";
	}

	protected virtual string _GetTemplateForabelFilterDefault()
	{
		return "Default";
	}

	protected virtual string _GetTemplateForActionDisableExperimentalMode()
	{
		return "Disable";
	}

	protected virtual string _GetTemplateForActionSeeAll()
	{
		return "See All";
	}

	protected virtual string _GetTemplateForHeadingExperimentalMode()
	{
		return "Experimental Mode Games";
	}

	protected virtual string _GetTemplateForLabelFilterExperimental()
	{
		return "Recommended";
	}

	protected virtual string _GetTemplateForLabelMoreResults()
	{
		return "more results";
	}

	protected virtual string _GetTemplateForLabelMoreResultsFor()
	{
		return "More Results For";
	}

	protected virtual string _GetTemplateForLabelSponsoredAd()
	{
		return "Sponsored Ad";
	}

	protected virtual string _GetTemplateForLabelTopResult()
	{
		return "Top Result";
	}

	protected virtual string _GetTemplateForLabelCancelField()
	{
		return "Cancel";
	}

	/// <summary>
	/// Key: "LabelCreatorBy"
	/// English String: "By {creatorLink}"
	/// </summary>
	public virtual string LabelCreatorBy(string creatorLink)
	{
		return $"By {creatorLink}";
	}

	protected virtual string _GetTemplateForLabelCreatorBy()
	{
		return "By {creatorLink}";
	}

	protected virtual string _GetTemplateForLabelExperimental()
	{
		return "Experimental";
	}

	protected virtual string _GetTemplateForLabelExperimentalHelpText()
	{
		return "What's this?";
	}

	protected virtual string _GetTemplateForLabelExperimentalMode()
	{
		return "Experimental Mode";
	}

	protected virtual string _GetTemplateForLabelExperimentalResults()
	{
		return "These results contain Experimental Mode games.";
	}

	protected virtual string _GetTemplateForLabelFilterAllTime()
	{
		return "All Time";
	}

	/// <summary>
	/// Key: "LabelFilterBecauseYouLiked"
	/// English String: "Because You Liked {gameName}"
	/// </summary>
	public virtual string LabelFilterBecauseYouLiked(string gameName)
	{
		return $"Because You Liked {gameName}";
	}

	protected virtual string _GetTemplateForLabelFilterBecauseYouLiked()
	{
		return "Because You Liked {gameName}";
	}

	protected virtual string _GetTemplateForLabelFilterBuildersClub()
	{
		return "Builders Club";
	}

	protected virtual string _GetTemplateForLabelFilterBy()
	{
		return "Filter By";
	}

	protected virtual string _GetTemplateForLabelFilterContest()
	{
		return "Contest";
	}

	protected virtual string _GetTemplateForLabelFilterDefault()
	{
		return "Default";
	}

	protected virtual string _GetTemplateForLabelFilterFeatured()
	{
		return "Featured";
	}

	protected virtual string _GetTemplateForLabelFilterFriendActivity()
	{
		return "Friend Activity";
	}

	protected virtual string _GetTemplateForLabelFilterGenre()
	{
		return "Genre";
	}

	protected virtual string _GetTemplateForLabelFilterMyFavorite()
	{
		return "My Favorite";
	}

	protected virtual string _GetTemplateForLabelFilterMyFavorites()
	{
		return "My Favorites";
	}

	protected virtual string _GetTemplateForLabelFilterMyRecent()
	{
		return "My Recent";
	}

	protected virtual string _GetTemplateForLabelFilterNow()
	{
		return "Now";
	}

	protected virtual string _GetTemplateForLabelFilterPastDay()
	{
		return "Past Day";
	}

	protected virtual string _GetTemplateForLabelFilterPastWeek()
	{
		return "Past Week";
	}

	protected virtual string _GetTemplateForLabelFilterPersonalizedByLiked()
	{
		return "Because You Liked";
	}

	protected virtual string _GetTemplateForLabelFilterPersonalServer()
	{
		return "Personal Server";
	}

	protected virtual string _GetTemplateForLabelFilterPopular()
	{
		return "Popular";
	}

	/// <summary>
	/// Key: "LabelFilterPopularByCountry"
	/// English String: "Popular in {CountryName}"
	/// </summary>
	public virtual string LabelFilterPopularByCountry(string CountryName)
	{
		return $"Popular in {CountryName}";
	}

	protected virtual string _GetTemplateForLabelFilterPopularByCountry()
	{
		return "Popular in {CountryName}";
	}

	protected virtual string _GetTemplateForLabelFilterPopularInVr()
	{
		return "Popular in VR";
	}

	protected virtual string _GetTemplateForLabelFilterPopularNearYou()
	{
		return "Popular Near You";
	}

	protected virtual string _GetTemplateForLabelFilterPopularWorldwide()
	{
		return "Popular Worldwide";
	}

	protected virtual string _GetTemplateForLabelFilterPurchased()
	{
		return "Purchased";
	}

	protected virtual string _GetTemplateForLabelFilterRecentlyPlayed()
	{
		return "Recently Played";
	}

	protected virtual string _GetTemplateForLabelFilterTime()
	{
		return "Time";
	}

	protected virtual string _GetTemplateForLabelFilterTopFavorite()
	{
		return "Top Favorite";
	}

	protected virtual string _GetTemplateForLabelFilterTopGrossing()
	{
		return "Top Earning";
	}

	protected virtual string _GetTemplateForLabelFilterTopPaid()
	{
		return "Top Paid";
	}

	protected virtual string _GetTemplateForLabelFilterTopRated()
	{
		return "Top Rated";
	}

	protected virtual string _GetTemplateForLabelFilterTopRetaining()
	{
		return "Recommended";
	}

	protected virtual string _GetTemplateForLabelNoSearchResults()
	{
		return "No Search Results Found";
	}

	/// <summary>
	/// Key: "LabelPlayingPhrase"
	/// English String: "{playerCount} Playing"
	/// </summary>
	public virtual string LabelPlayingPhrase(string playerCount)
	{
		return $"{playerCount} Playing";
	}

	protected virtual string _GetTemplateForLabelPlayingPhrase()
	{
		return "{playerCount} Playing";
	}

	protected virtual string _GetTemplateForLabelSearchField()
	{
		return "Search";
	}

	protected virtual string _GetTemplateForLabelSearchInsteadFor()
	{
		return "Search instead for";
	}

	protected virtual string _GetTemplateForLabelSearchYouMightMean()
	{
		return "Did you mean:";
	}

	protected virtual string _GetTemplateForLabelShowingResultsFor()
	{
		return "Showing results for";
	}
}
