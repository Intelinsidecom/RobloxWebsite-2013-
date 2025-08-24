using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class FeedResources_en_us : TranslationResourcesBase, IFeedResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "HeadingBuildSomething"
	/// English String: "Build Something"
	/// </summary>
	public virtual string HeadingBuildSomething => "Build Something";

	/// <summary>
	/// Key: "HeadingCustomizeAvatar"
	/// English String: "Customize Your Avatar"
	/// </summary>
	public virtual string HeadingCustomizeAvatar => "Customize Your Avatar";

	/// <summary>
	/// Key: "HeadingForumHelp"
	/// English String: "Roblox forums for help"
	/// </summary>
	public virtual string HeadingForumHelp => "Roblox forums for help";

	/// <summary>
	/// Key: "HeadingMakeFriends"
	/// English String: "Make Friends"
	/// </summary>
	public virtual string HeadingMakeFriends => "Make Friends";

	/// <summary>
	/// Key: "HeadingPlayGames"
	/// English String: "Play Games"
	/// </summary>
	public virtual string HeadingPlayGames => "Play Games";

	/// <summary>
	/// Key: "LabelNoFeedLink"
	/// English String: "make some best friends now."
	/// </summary>
	public virtual string LabelNoFeedLink => "make some best friends now.";

	/// <summary>
	/// Key: "LabelNoFeedText"
	/// English String: "No news about your best friends... want to know what your best friends are up to?"
	/// </summary>
	public virtual string LabelNoFeedText => "No news about your best friends... want to know what your best friends are up to?";

	/// <summary>
	/// Key: "LabelPlayGames"
	/// English String: "Nearly all Roblox games are built by players like you. Here are some of our favorites:"
	/// </summary>
	public virtual string LabelPlayGames => "Nearly all Roblox games are built by players like you. Here are some of our favorites:";

	public FeedResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"HeadingBuildSomething",
				_GetTemplateForHeadingBuildSomething()
			},
			{
				"HeadingCustomizeAvatar",
				_GetTemplateForHeadingCustomizeAvatar()
			},
			{
				"HeadingForumHelp",
				_GetTemplateForHeadingForumHelp()
			},
			{
				"HeadingMakeFriends",
				_GetTemplateForHeadingMakeFriends()
			},
			{
				"HeadingPlayGames",
				_GetTemplateForHeadingPlayGames()
			},
			{
				"LabelBuildSomething",
				_GetTemplateForLabelBuildSomething()
			},
			{
				"LabelCustomizeAvatarDesktop",
				_GetTemplateForLabelCustomizeAvatarDesktop()
			},
			{
				"LabelCustomizeAvatarPhone",
				_GetTemplateForLabelCustomizeAvatarPhone()
			},
			{
				"LabelForumHelp",
				_GetTemplateForLabelForumHelp()
			},
			{
				"LabelMakeFriends",
				_GetTemplateForLabelMakeFriends()
			},
			{
				"LabelNoFeedLink",
				_GetTemplateForLabelNoFeedLink()
			},
			{
				"LabelNoFeedText",
				_GetTemplateForLabelNoFeedText()
			},
			{
				"LabelPlayGames",
				_GetTemplateForLabelPlayGames()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.Feed";
	}

	protected virtual string _GetTemplateForHeadingBuildSomething()
	{
		return "Build Something";
	}

	protected virtual string _GetTemplateForHeadingCustomizeAvatar()
	{
		return "Customize Your Avatar";
	}

	protected virtual string _GetTemplateForHeadingForumHelp()
	{
		return "Roblox forums for help";
	}

	protected virtual string _GetTemplateForHeadingMakeFriends()
	{
		return "Make Friends";
	}

	protected virtual string _GetTemplateForHeadingPlayGames()
	{
		return "Play Games";
	}

	/// <summary>
	/// Key: "LabelBuildSomething"
	/// English String: "Builders will enjoy playing our multiplayer building game. Professional builders will want to check out Roblox Studio, our game development environment on your {linkStart}Develop page{linkEnd}."
	/// </summary>
	public virtual string LabelBuildSomething(string linkStart, string linkEnd)
	{
		return $"Builders will enjoy playing our multiplayer building game. Professional builders will want to check out Roblox Studio, our game development environment on your {linkStart}Develop page{linkEnd}.";
	}

	protected virtual string _GetTemplateForLabelBuildSomething()
	{
		return "Builders will enjoy playing our multiplayer building game. Professional builders will want to check out Roblox Studio, our game development environment on your {linkStart}Develop page{linkEnd}.";
	}

	/// <summary>
	/// Key: "LabelCustomizeAvatarDesktop"
	/// English String: "Visit the {avatarLinkStart} Avatar page {avatarLinkEnd} to customize your avatar. Get new clothing in the {catalogLinkStart}catalog{catalogLinkEnd}."
	/// </summary>
	public virtual string LabelCustomizeAvatarDesktop(string avatarLinkStart, string avatarLinkEnd, string catalogLinkStart, string catalogLinkEnd)
	{
		return $"Visit the {avatarLinkStart} Avatar page {avatarLinkEnd} to customize your avatar. Get new clothing in the {catalogLinkStart}catalog{catalogLinkEnd}.";
	}

	protected virtual string _GetTemplateForLabelCustomizeAvatarDesktop()
	{
		return "Visit the {avatarLinkStart} Avatar page {avatarLinkEnd} to customize your avatar. Get new clothing in the {catalogLinkStart}catalog{catalogLinkEnd}.";
	}

	/// <summary>
	/// Key: "LabelCustomizeAvatarPhone"
	/// English String: "Get new clothing in the {linkStart} catalog {linkEnd} and customize your avatar."
	/// </summary>
	public virtual string LabelCustomizeAvatarPhone(string linkStart, string linkEnd)
	{
		return $"Get new clothing in the {linkStart} catalog {linkEnd} and customize your avatar.";
	}

	protected virtual string _GetTemplateForLabelCustomizeAvatarPhone()
	{
		return "Get new clothing in the {linkStart} catalog {linkEnd} and customize your avatar.";
	}

	/// <summary>
	/// Key: "LabelForumHelp"
	/// English String: "No matter what you're looking for, if it's Roblox related, there are people talking about it {linkStart}here{linkEnd}."
	/// </summary>
	public virtual string LabelForumHelp(string linkStart, string linkEnd)
	{
		return $"No matter what you're looking for, if it's Roblox related, there are people talking about it {linkStart}here{linkEnd}.";
	}

	protected virtual string _GetTemplateForLabelForumHelp()
	{
		return "No matter what you're looking for, if it's Roblox related, there are people talking about it {linkStart}here{linkEnd}.";
	}

	/// <summary>
	/// Key: "LabelMakeFriends"
	/// English String: "Meet other players in-game and send them a friend request. If you miss your opportunity you can always send a request later by {linkStart}searching{linkEnd} for their user profile."
	/// </summary>
	public virtual string LabelMakeFriends(string linkStart, string linkEnd)
	{
		return $"Meet other players in-game and send them a friend request. If you miss your opportunity you can always send a request later by {linkStart}searching{linkEnd} for their user profile.";
	}

	protected virtual string _GetTemplateForLabelMakeFriends()
	{
		return "Meet other players in-game and send them a friend request. If you miss your opportunity you can always send a request later by {linkStart}searching{linkEnd} for their user profile.";
	}

	protected virtual string _GetTemplateForLabelNoFeedLink()
	{
		return "make some best friends now.";
	}

	protected virtual string _GetTemplateForLabelNoFeedText()
	{
		return "No news about your best friends... want to know what your best friends are up to?";
	}

	protected virtual string _GetTemplateForLabelPlayGames()
	{
		return "Nearly all Roblox games are built by players like you. Here are some of our favorites:";
	}
}
