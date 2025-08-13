using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class GameFollowsResources_en_us : TranslationResourcesBase, IGameFollowsResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "ActionCancel"
	/// Login dialog cancel label
	/// English String: "Cancel"
	/// </summary>
	public virtual string ActionCancel => "Cancel";

	/// <summary>
	/// Key: "ActionLogin"
	/// Login button label
	/// English String: "Login"
	/// </summary>
	public virtual string ActionLogin => "Login";

	/// <summary>
	/// Key: "DescriptionLoginRequired"
	/// Login dialog text for guest user
	/// English String: "You must be logged in to follow this game. Please Login or Register to continue."
	/// </summary>
	public virtual string DescriptionLoginRequired => "You must be logged in to follow this game. Please Login or Register to continue.";

	/// <summary>
	/// Key: "LabelFollow"
	/// Label for follow game button
	/// English String: "Follow"
	/// </summary>
	public virtual string LabelFollow => "Follow";

	/// <summary>
	/// Key: "LabelFollowing"
	/// Label for follow game button
	/// English String: "Following"
	/// </summary>
	public virtual string LabelFollowing => "Following";

	/// <summary>
	/// Key: "LabelLoginRequired"
	/// Text for dialog for guest user to redirect to login
	/// English String: "Login Required"
	/// </summary>
	public virtual string LabelLoginRequired => "Login Required";

	/// <summary>
	/// Key: "TooltipFollowGame"
	/// Tooltip for follow game button
	/// English String: "Follow Game"
	/// </summary>
	public virtual string TooltipFollowGame => "Follow Game";

	/// <summary>
	/// Key: "TooltipFollowLimitReached"
	/// Tooltip for follow game button
	/// English String: "Limit reached. Please unfollow other games to follow this one."
	/// </summary>
	public virtual string TooltipFollowLimitReached => "Limit reached. Please unfollow other games to follow this one.";

	/// <summary>
	/// Key: "TooltipUnfollowGame"
	/// Tooltip for follow game button
	/// English String: "Unfollow Game"
	/// </summary>
	public virtual string TooltipUnfollowGame => "Unfollow Game";

	public GameFollowsResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"ActionCancel",
				_GetTemplateForActionCancel()
			},
			{
				"ActionLogin",
				_GetTemplateForActionLogin()
			},
			{
				"DescriptionLoginRequired",
				_GetTemplateForDescriptionLoginRequired()
			},
			{
				"LabelFollow",
				_GetTemplateForLabelFollow()
			},
			{
				"LabelFollowing",
				_GetTemplateForLabelFollowing()
			},
			{
				"LabelLoginRequired",
				_GetTemplateForLabelLoginRequired()
			},
			{
				"TooltipFollowGame",
				_GetTemplateForTooltipFollowGame()
			},
			{
				"TooltipFollowLimitReached",
				_GetTemplateForTooltipFollowLimitReached()
			},
			{
				"TooltipUnfollowGame",
				_GetTemplateForTooltipUnfollowGame()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.GameFollows";
	}

	protected virtual string _GetTemplateForActionCancel()
	{
		return "Cancel";
	}

	protected virtual string _GetTemplateForActionLogin()
	{
		return "Login";
	}

	protected virtual string _GetTemplateForDescriptionLoginRequired()
	{
		return "You must be logged in to follow this game. Please Login or Register to continue.";
	}

	protected virtual string _GetTemplateForLabelFollow()
	{
		return "Follow";
	}

	protected virtual string _GetTemplateForLabelFollowing()
	{
		return "Following";
	}

	protected virtual string _GetTemplateForLabelLoginRequired()
	{
		return "Login Required";
	}

	protected virtual string _GetTemplateForTooltipFollowGame()
	{
		return "Follow Game";
	}

	protected virtual string _GetTemplateForTooltipFollowLimitReached()
	{
		return "Limit reached. Please unfollow other games to follow this one.";
	}

	protected virtual string _GetTemplateForTooltipUnfollowGame()
	{
		return "Unfollow Game";
	}
}
