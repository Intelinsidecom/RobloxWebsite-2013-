using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class FeedsResources_en_us : TranslationResourcesBase, IFeedsResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Heading.BuildSomething"
	/// English String: "Build Something"
	/// </summary>
	public virtual string HeadingBuildSomething => "Build Something";

	/// <summary>
	/// Key: "Heading.CustomizeAvatar"
	/// English String: "Customize Your Avatar"
	/// </summary>
	public virtual string HeadingCustomizeAvatar => "Customize Your Avatar";

	/// <summary>
	/// Key: "Heading.ForumHelp"
	/// English String: "Roblox forums for help"
	/// </summary>
	public virtual string HeadingForumHelp => "Roblox forums for help";

	/// <summary>
	/// Key: "Heading.MakeFriends"
	/// English String: "Make Friends"
	/// </summary>
	public virtual string HeadingMakeFriends => "Make Friends";

	/// <summary>
	/// Key: "Heading.PlayGames"
	/// English String: "Play Games"
	/// </summary>
	public virtual string HeadingPlayGames => "Play Games";

	/// <summary>
	/// Key: "Label.NoFeedLink"
	/// English String: "make some best friends now."
	/// </summary>
	public virtual string LabelNoFeedLink => "make some best friends now.";

	/// <summary>
	/// Key: "Label.NoFeedText"
	/// English String: "No news about your best friends... want to know what your best friends are up to?"
	/// </summary>
	public virtual string LabelNoFeedText => "No news about your best friends... want to know what your best friends are up to?";

	/// <summary>
	/// Key: "Label.PlayGames"
	/// English String: "Nearly all Roblox games are built by players like you. Here are some of our favorites:"
	/// </summary>
	public virtual string LabelPlayGames => "Nearly all Roblox games are built by players like you. Here are some of our favorites:";

	public FeedsResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Heading.BuildSomething",
				_GetTemplateForHeadingBuildSomething()
			},
			{
				"Heading.CustomizeAvatar",
				_GetTemplateForHeadingCustomizeAvatar()
			},
			{
				"Heading.ForumHelp",
				_GetTemplateForHeadingForumHelp()
			},
			{
				"Heading.MakeFriends",
				_GetTemplateForHeadingMakeFriends()
			},
			{
				"Heading.PlayGames",
				_GetTemplateForHeadingPlayGames()
			},
			{
				"Label.BuildSomething",
				_GetTemplateForLabelBuildSomething()
			},
			{
				"Label.CustomizeAvatarDesktop",
				_GetTemplateForLabelCustomizeAvatarDesktop()
			},
			{
				"Label.CustomizeAvatarPhone",
				_GetTemplateForLabelCustomizeAvatarPhone()
			},
			{
				"Label.ForumHelp",
				_GetTemplateForLabelForumHelp()
			},
			{
				"Label.MakeFriends",
				_GetTemplateForLabelMakeFriends()
			},
			{
				"Label.NoFeedLink",
				_GetTemplateForLabelNoFeedLink()
			},
			{
				"Label.NoFeedText",
				_GetTemplateForLabelNoFeedText()
			},
			{
				"Label.PlayGames",
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
		return "Feature.Feeds";
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
	/// Key: "Label.BuildSomething"
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
	/// Key: "Label.CustomizeAvatarDesktop"
	/// English String: "Visit the {avatarLinkStart}Avatar Editor{avatarLinkEnd} to customize your character. Shop for clothing items in the {catalogLinkStart}Catalog{catalogLinkEnd}."
	/// </summary>
	public virtual string LabelCustomizeAvatarDesktop(string avatarLinkStart, string avatarLinkEnd, string catalogLinkStart, string catalogLinkEnd)
	{
		return $"Visit the {avatarLinkStart}Avatar Editor{avatarLinkEnd} to customize your character. Shop for clothing items in the {catalogLinkStart}Catalog{catalogLinkEnd}.";
	}

	protected virtual string _GetTemplateForLabelCustomizeAvatarDesktop()
	{
		return "Visit the {avatarLinkStart}Avatar Editor{avatarLinkEnd} to customize your character. Shop for clothing items in the {catalogLinkStart}Catalog{catalogLinkEnd}.";
	}

	/// <summary>
	/// Key: "Label.CustomizeAvatarPhone"
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
	/// Key: "Label.ForumHelp"
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
	/// Key: "Label.MakeFriends"
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
