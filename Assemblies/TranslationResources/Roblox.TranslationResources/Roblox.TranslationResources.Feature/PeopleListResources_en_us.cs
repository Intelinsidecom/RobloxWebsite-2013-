using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class PeopleListResources_en_us : TranslationResourcesBase, IPeopleListResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.Buy"
	/// Purchase game and play
	/// English String: "Buy to Play"
	/// </summary>
	public virtual string ActionBuy => "Buy to Play";

	/// <summary>
	/// Key: "Action.Join"
	/// Join game with friends
	/// English String: "Join"
	/// </summary>
	public virtual string ActionJoin => "Join";

	/// <summary>
	/// Key: "Action.ViewDetails"
	/// View game details page
	/// English String: "View Details"
	/// </summary>
	public virtual string ActionViewDetails => "View Details";

	/// <summary>
	/// Key: "Heading.Friends"
	/// English String: "Friends"
	/// </summary>
	public virtual string HeadingFriends => "Friends";

	/// <summary>
	/// Key: "Heading.SeeAll"
	/// English String: "See All"
	/// </summary>
	public virtual string HeadingSeeAll => "See All";

	/// <summary>
	/// Key: "Label.ViewProfile"
	/// Go to Profile page and view
	/// English String: "View Profile"
	/// </summary>
	public virtual string LabelViewProfile => "View Profile";

	public PeopleListResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.Buy",
				_GetTemplateForActionBuy()
			},
			{
				"Action.Join",
				_GetTemplateForActionJoin()
			},
			{
				"Action.ViewDetails",
				_GetTemplateForActionViewDetails()
			},
			{
				"Heading.Friends",
				_GetTemplateForHeadingFriends()
			},
			{
				"Heading.SeeAll",
				_GetTemplateForHeadingSeeAll()
			},
			{
				"Label.Chat",
				_GetTemplateForLabelChat()
			},
			{
				"Label.ViewProfile",
				_GetTemplateForLabelViewProfile()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.PeopleList";
	}

	protected virtual string _GetTemplateForActionBuy()
	{
		return "Buy to Play";
	}

	protected virtual string _GetTemplateForActionJoin()
	{
		return "Join";
	}

	protected virtual string _GetTemplateForActionViewDetails()
	{
		return "View Details";
	}

	protected virtual string _GetTemplateForHeadingFriends()
	{
		return "Friends";
	}

	protected virtual string _GetTemplateForHeadingSeeAll()
	{
		return "See All";
	}

	/// <summary>
	/// Key: "Label.Chat"
	/// Chat with friends
	/// English String: "Chat with {username}"
	/// </summary>
	public virtual string LabelChat(string username)
	{
		return $"Chat with {username}";
	}

	protected virtual string _GetTemplateForLabelChat()
	{
		return "Chat with {username}";
	}

	protected virtual string _GetTemplateForLabelViewProfile()
	{
		return "View Profile";
	}
}
