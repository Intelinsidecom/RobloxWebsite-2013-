using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class HomeResources_en_us : TranslationResourcesBase, IHomeResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.BackToTop"
	/// English String: "Back To Top"
	/// </summary>
	public virtual string ActionBackToTop => "Back To Top";

	/// <summary>
	/// Key: "ActionLearnMore"
	/// English String: "Learn More"
	/// </summary>
	public virtual string ActionLearnMore => "Learn More";

	/// <summary>
	/// Key: "ActionSeeAll"
	/// English String: "See All"
	/// </summary>
	public virtual string ActionSeeAll => "See All";

	/// <summary>
	/// Key: "ActionSeeMore"
	/// English String: "See More"
	/// </summary>
	public virtual string ActionSeeMore => "See More";

	/// <summary>
	/// Key: "ActionShare"
	/// English String: "Share"
	/// </summary>
	public virtual string ActionShare => "Share";

	/// <summary>
	/// Key: "ActionWhatAreYouUpto"
	/// English String: "What are you up to?"
	/// </summary>
	public virtual string ActionWhatAreYouUpto => "What are you up to?";

	/// <summary>
	/// Key: "HeadingBlogNews"
	/// English String: "Blog News"
	/// </summary>
	public virtual string HeadingBlogNews => "Blog News";

	/// <summary>
	/// Key: "HeadingDeveloperExchange"
	/// English String: "Developer Exchange"
	/// </summary>
	public virtual string HeadingDeveloperExchange => "Developer Exchange";

	/// <summary>
	/// Key: "HeadingFriendActivity"
	/// English String: "Friend Activity"
	/// </summary>
	public virtual string HeadingFriendActivity => "Friend Activity";

	/// <summary>
	/// Key: "HeadingFriendsTitle"
	/// English String: "Friends"
	/// </summary>
	public virtual string HeadingFriendsTitle => "Friends";

	/// <summary>
	/// Key: "HeadingMyFavorites"
	/// English String: "My Favorites"
	/// </summary>
	public virtual string HeadingMyFavorites => "My Favorites";

	/// <summary>
	/// Key: "HeadingMyFeed"
	/// English String: "My Feed"
	/// </summary>
	public virtual string HeadingMyFeed => "My Feed";

	/// <summary>
	/// Key: "HeadingRecentlyPlayed"
	/// English String: "Recently Played"
	/// </summary>
	public virtual string HeadingRecentlyPlayed => "Recently Played";

	/// <summary>
	/// Key: "Label.FindMyFeed"
	/// English String: "Looking for My Feed? It's now on the side menu"
	/// </summary>
	public virtual string LabelFindMyFeed => "Looking for My Feed? It's now on the side menu";

	/// <summary>
	/// Key: "LabelAnnouncement"
	/// English String: "Announcement"
	/// </summary>
	public virtual string LabelAnnouncement => "Announcement";

	/// <summary>
	/// Key: "LabelCreateEarn"
	/// English String: "Create games, earn money"
	/// </summary>
	public virtual string LabelCreateEarn => "Create games, earn money";

	/// <summary>
	/// Key: "LabelSharing"
	/// English String: "Sharing..."
	/// </summary>
	public virtual string LabelSharing => "Sharing...";

	/// <summary>
	/// Key: "LabelStatusUpdateFailed"
	/// English String: "Status update failed."
	/// </summary>
	public virtual string LabelStatusUpdateFailed => "Status update failed.";

	/// <summary>
	/// Key: "ResponseErrorNoBlank"
	/// English String: "Update cannot be blank. Please try again."
	/// </summary>
	public virtual string ResponseErrorNoBlank => "Update cannot be blank. Please try again.";

	/// <summary>
	/// Key: "ResponseErrorNoLogin"
	/// English String: "Please log into your account."
	/// </summary>
	public virtual string ResponseErrorNoLogin => "Please log into your account.";

	/// <summary>
	/// Key: "ResponseErrorOther"
	/// English String: "System issue. Please try again later, then contact Support."
	/// </summary>
	public virtual string ResponseErrorOther => "System issue. Please try again later, then contact Support.";

	/// <summary>
	/// Key: "ResponseErrorTooManyUpdates"
	/// English String: "Too many updates. Please try again later."
	/// </summary>
	public virtual string ResponseErrorTooManyUpdates => "Too many updates. Please try again later.";

	public HomeResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.BackToTop",
				_GetTemplateForActionBackToTop()
			},
			{
				"ActionLearnMore",
				_GetTemplateForActionLearnMore()
			},
			{
				"ActionSeeAll",
				_GetTemplateForActionSeeAll()
			},
			{
				"ActionSeeMore",
				_GetTemplateForActionSeeMore()
			},
			{
				"ActionShare",
				_GetTemplateForActionShare()
			},
			{
				"ActionWhatAreYouUpto",
				_GetTemplateForActionWhatAreYouUpto()
			},
			{
				"HeadingBlogNews",
				_GetTemplateForHeadingBlogNews()
			},
			{
				"HeadingDeveloperExchange",
				_GetTemplateForHeadingDeveloperExchange()
			},
			{
				"HeadingFriendActivity",
				_GetTemplateForHeadingFriendActivity()
			},
			{
				"HeadingFriends",
				_GetTemplateForHeadingFriends()
			},
			{
				"HeadingFriendsTitle",
				_GetTemplateForHeadingFriendsTitle()
			},
			{
				"HeadingMyFavorites",
				_GetTemplateForHeadingMyFavorites()
			},
			{
				"HeadingMyFeed",
				_GetTemplateForHeadingMyFeed()
			},
			{
				"HeadingRecentlyPlayed",
				_GetTemplateForHeadingRecentlyPlayed()
			},
			{
				"Label.FindMyFeed",
				_GetTemplateForLabelFindMyFeed()
			},
			{
				"LabelAnnouncement",
				_GetTemplateForLabelAnnouncement()
			},
			{
				"LabelCreateEarn",
				_GetTemplateForLabelCreateEarn()
			},
			{
				"LabelGreeting",
				_GetTemplateForLabelGreeting()
			},
			{
				"LabelSharing",
				_GetTemplateForLabelSharing()
			},
			{
				"LabelStatusUpdateFailed",
				_GetTemplateForLabelStatusUpdateFailed()
			},
			{
				"ResponseErrorNoBlank",
				_GetTemplateForResponseErrorNoBlank()
			},
			{
				"ResponseErrorNoLogin",
				_GetTemplateForResponseErrorNoLogin()
			},
			{
				"ResponseErrorOther",
				_GetTemplateForResponseErrorOther()
			},
			{
				"ResponseErrorTooManyUpdates",
				_GetTemplateForResponseErrorTooManyUpdates()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.Home";
	}

	protected virtual string _GetTemplateForActionBackToTop()
	{
		return "Back To Top";
	}

	protected virtual string _GetTemplateForActionLearnMore()
	{
		return "Learn More";
	}

	protected virtual string _GetTemplateForActionSeeAll()
	{
		return "See All";
	}

	protected virtual string _GetTemplateForActionSeeMore()
	{
		return "See More";
	}

	protected virtual string _GetTemplateForActionShare()
	{
		return "Share";
	}

	protected virtual string _GetTemplateForActionWhatAreYouUpto()
	{
		return "What are you up to?";
	}

	protected virtual string _GetTemplateForHeadingBlogNews()
	{
		return "Blog News";
	}

	protected virtual string _GetTemplateForHeadingDeveloperExchange()
	{
		return "Developer Exchange";
	}

	protected virtual string _GetTemplateForHeadingFriendActivity()
	{
		return "Friend Activity";
	}

	/// <summary>
	/// Key: "HeadingFriends"
	/// English String: "Friends ({friendCount})"
	/// </summary>
	public virtual string HeadingFriends(string friendCount)
	{
		return $"Friends ({friendCount})";
	}

	protected virtual string _GetTemplateForHeadingFriends()
	{
		return "Friends ({friendCount})";
	}

	protected virtual string _GetTemplateForHeadingFriendsTitle()
	{
		return "Friends";
	}

	protected virtual string _GetTemplateForHeadingMyFavorites()
	{
		return "My Favorites";
	}

	protected virtual string _GetTemplateForHeadingMyFeed()
	{
		return "My Feed";
	}

	protected virtual string _GetTemplateForHeadingRecentlyPlayed()
	{
		return "Recently Played";
	}

	protected virtual string _GetTemplateForLabelFindMyFeed()
	{
		return "Looking for My Feed? It's now on the side menu";
	}

	protected virtual string _GetTemplateForLabelAnnouncement()
	{
		return "Announcement";
	}

	protected virtual string _GetTemplateForLabelCreateEarn()
	{
		return "Create games, earn money";
	}

	/// <summary>
	/// Key: "LabelGreeting"
	/// English String: "Hello, {username}!"
	/// </summary>
	public virtual string LabelGreeting(string username)
	{
		return $"Hello, {username}!";
	}

	protected virtual string _GetTemplateForLabelGreeting()
	{
		return "Hello, {username}!";
	}

	protected virtual string _GetTemplateForLabelSharing()
	{
		return "Sharing...";
	}

	protected virtual string _GetTemplateForLabelStatusUpdateFailed()
	{
		return "Status update failed.";
	}

	protected virtual string _GetTemplateForResponseErrorNoBlank()
	{
		return "Update cannot be blank. Please try again.";
	}

	protected virtual string _GetTemplateForResponseErrorNoLogin()
	{
		return "Please log into your account.";
	}

	protected virtual string _GetTemplateForResponseErrorOther()
	{
		return "System issue. Please try again later, then contact Support.";
	}

	protected virtual string _GetTemplateForResponseErrorTooManyUpdates()
	{
		return "Too many updates. Please try again later.";
	}
}
