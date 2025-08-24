using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class PlayerSearchResultsResources_en_us : TranslationResourcesBase, IPlayerSearchResultsResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.AcceptRequest"
	/// English String: "Accept Request"
	/// </summary>
	public virtual string ActionAcceptRequest => "Accept Request";

	/// <summary>
	/// Key: "Action.AddFriend"
	/// English String: "Add Friend"
	/// </summary>
	public virtual string ActionAddFriend => "Add Friend";

	/// <summary>
	/// Key: "Action.Chat"
	/// English String: "Chat"
	/// </summary>
	public virtual string ActionChat => "Chat";

	/// <summary>
	/// Key: "Action.JoinGame"
	/// English String: "Join Game"
	/// </summary>
	public virtual string ActionJoinGame => "Join Game";

	/// <summary>
	/// Key: "Action.RequestSent"
	/// English String: "Request Sent"
	/// </summary>
	public virtual string ActionRequestSent => "Request Sent";

	/// <summary>
	/// Key: "Label.AlsoKnownAsAbbreviation"
	/// English String: "aka."
	/// </summary>
	public virtual string LabelAlsoKnownAsAbbreviation => "aka.";

	/// <summary>
	/// Key: "Label.Offline"
	/// English String: "Offline"
	/// </summary>
	public virtual string LabelOffline => "Offline";

	/// <summary>
	/// Key: "Label.Online"
	/// English String: "Online"
	/// </summary>
	public virtual string LabelOnline => "Online";

	/// <summary>
	/// Key: "Label.Search"
	/// English String: "Search"
	/// </summary>
	public virtual string LabelSearch => "Search";

	/// <summary>
	/// Key: "Label.ThisIsYou"
	/// English String: "This is you"
	/// </summary>
	public virtual string LabelThisIsYou => "This is you";

	/// <summary>
	/// Key: "Label.UnsafeInput"
	/// English String: "You have entered unsafe input. Please try your search again."
	/// </summary>
	public virtual string LabelUnsafeInput => "You have entered unsafe input. Please try your search again.";

	/// <summary>
	/// Key: "Label.YouAreFollowing"
	/// English String: "You are following"
	/// </summary>
	public virtual string LabelYouAreFollowing => "You are following";

	/// <summary>
	/// Key: "Label.YouAreFriends"
	/// English String: "You are friends"
	/// </summary>
	public virtual string LabelYouAreFriends => "You are friends";

	public PlayerSearchResultsResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.AcceptRequest",
				_GetTemplateForActionAcceptRequest()
			},
			{
				"Action.AddFriend",
				_GetTemplateForActionAddFriend()
			},
			{
				"Action.Chat",
				_GetTemplateForActionChat()
			},
			{
				"Action.JoinGame",
				_GetTemplateForActionJoinGame()
			},
			{
				"Action.RequestSent",
				_GetTemplateForActionRequestSent()
			},
			{
				"Heading.PlayerResultsFor",
				_GetTemplateForHeadingPlayerResultsFor()
			},
			{
				"Label.AlsoKnownAsAbbreviation",
				_GetTemplateForLabelAlsoKnownAsAbbreviation()
			},
			{
				"Label.EnterMinCharacters",
				_GetTemplateForLabelEnterMinCharacters()
			},
			{
				"Label.NoMatchesAvailable",
				_GetTemplateForLabelNoMatchesAvailable()
			},
			{
				"Label.Offline",
				_GetTemplateForLabelOffline()
			},
			{
				"Label.Online",
				_GetTemplateForLabelOnline()
			},
			{
				"Label.Search",
				_GetTemplateForLabelSearch()
			},
			{
				"Label.ShowingCountOfResults",
				_GetTemplateForLabelShowingCountOfResults()
			},
			{
				"Label.ThisIsYou",
				_GetTemplateForLabelThisIsYou()
			},
			{
				"Label.UnsafeInput",
				_GetTemplateForLabelUnsafeInput()
			},
			{
				"Label.YouAreFollowing",
				_GetTemplateForLabelYouAreFollowing()
			},
			{
				"Label.YouAreFriends",
				_GetTemplateForLabelYouAreFriends()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.PlayerSearchResults";
	}

	protected virtual string _GetTemplateForActionAcceptRequest()
	{
		return "Accept Request";
	}

	protected virtual string _GetTemplateForActionAddFriend()
	{
		return "Add Friend";
	}

	protected virtual string _GetTemplateForActionChat()
	{
		return "Chat";
	}

	protected virtual string _GetTemplateForActionJoinGame()
	{
		return "Join Game";
	}

	protected virtual string _GetTemplateForActionRequestSent()
	{
		return "Request Sent";
	}

	/// <summary>
	/// Key: "Heading.PlayerResultsFor"
	/// English String: "Player Results for {startSpan}{keyword}{endSpan}"
	/// </summary>
	public virtual string HeadingPlayerResultsFor(string startSpan, string keyword, string endSpan)
	{
		return $"Player Results for {startSpan}{keyword}{endSpan}";
	}

	protected virtual string _GetTemplateForHeadingPlayerResultsFor()
	{
		return "Player Results for {startSpan}{keyword}{endSpan}";
	}

	protected virtual string _GetTemplateForLabelAlsoKnownAsAbbreviation()
	{
		return "aka.";
	}

	/// <summary>
	/// Key: "Label.EnterMinCharacters"
	/// English String: "Please enter at least {keywordMinLength} characters."
	/// </summary>
	public virtual string LabelEnterMinCharacters(string keywordMinLength)
	{
		return $"Please enter at least {keywordMinLength} characters.";
	}

	protected virtual string _GetTemplateForLabelEnterMinCharacters()
	{
		return "Please enter at least {keywordMinLength} characters.";
	}

	/// <summary>
	/// Key: "Label.NoMatchesAvailable"
	/// English String: "There are no matches available for \"{keyword}\""
	/// </summary>
	public virtual string LabelNoMatchesAvailable(string keyword)
	{
		return $"There are no matches available for \"{keyword}\"";
	}

	protected virtual string _GetTemplateForLabelNoMatchesAvailable()
	{
		return "There are no matches available for \"{keyword}\"";
	}

	protected virtual string _GetTemplateForLabelOffline()
	{
		return "Offline";
	}

	protected virtual string _GetTemplateForLabelOnline()
	{
		return "Online";
	}

	protected virtual string _GetTemplateForLabelSearch()
	{
		return "Search";
	}

	/// <summary>
	/// Key: "Label.ShowingCountOfResults"
	/// English String: "{countStartSpan}{resultsStart} - {resultsInPage} of {countEndSpan}{totalStartSpan}{totalResults}{totalEndSpan}"
	/// </summary>
	public virtual string LabelShowingCountOfResults(string countStartSpan, string resultsStart, string resultsInPage, string countEndSpan, string totalStartSpan, string totalResults, string totalEndSpan)
	{
		return $"{countStartSpan}{resultsStart} - {resultsInPage} of {countEndSpan}{totalStartSpan}{totalResults}{totalEndSpan}";
	}

	protected virtual string _GetTemplateForLabelShowingCountOfResults()
	{
		return "{countStartSpan}{resultsStart} - {resultsInPage} of {countEndSpan}{totalStartSpan}{totalResults}{totalEndSpan}";
	}

	protected virtual string _GetTemplateForLabelThisIsYou()
	{
		return "This is you";
	}

	protected virtual string _GetTemplateForLabelUnsafeInput()
	{
		return "You have entered unsafe input. Please try your search again.";
	}

	protected virtual string _GetTemplateForLabelYouAreFollowing()
	{
		return "You are following";
	}

	protected virtual string _GetTemplateForLabelYouAreFriends()
	{
		return "You are friends";
	}
}
