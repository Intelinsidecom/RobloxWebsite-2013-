namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GameFollowsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameFollowsResources_zh_cjv : GameFollowsResources_en_us, IGameFollowsResources, ITranslationResources
{
	/// <summary>
	/// Key: "ActionCancel"
	/// Login dialog cancel label
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "取消";

	/// <summary>
	/// Key: "ActionLogin"
	/// Login button label
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "登录";

	/// <summary>
	/// Key: "DescriptionLoginRequired"
	/// Login dialog text for guest user
	/// English String: "You must be logged in to follow this game. Please Login or Register to continue."
	/// </summary>
	public override string DescriptionLoginRequired => "你必须登录才能关注此游戏。请登录或注册以继续。";

	/// <summary>
	/// Key: "LabelFollow"
	/// Label for follow game button
	/// English String: "Follow"
	/// </summary>
	public override string LabelFollow => "关注";

	/// <summary>
	/// Key: "LabelFollowing"
	/// Label for follow game button
	/// English String: "Following"
	/// </summary>
	public override string LabelFollowing => "关注中";

	/// <summary>
	/// Key: "LabelLoginRequired"
	/// Text for dialog for guest user to redirect to login
	/// English String: "Login Required"
	/// </summary>
	public override string LabelLoginRequired => "需要登录";

	/// <summary>
	/// Key: "TooltipFollowGame"
	/// Tooltip for follow game button
	/// English String: "Follow Game"
	/// </summary>
	public override string TooltipFollowGame => "关注游戏";

	/// <summary>
	/// Key: "TooltipFollowLimitReached"
	/// Tooltip for follow game button
	/// English String: "Limit reached. Please unfollow other games to follow this one."
	/// </summary>
	public override string TooltipFollowLimitReached => "已达上限。若要关注此游戏，请先取消关注其他游戏。";

	/// <summary>
	/// Key: "TooltipUnfollowGame"
	/// Tooltip for follow game button
	/// English String: "Unfollow Game"
	/// </summary>
	public override string TooltipUnfollowGame => "取消关注游戏";

	public GameFollowsResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "取消";
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "登录";
	}

	protected override string _GetTemplateForDescriptionLoginRequired()
	{
		return "你必须登录才能关注此游戏。请登录或注册以继续。";
	}

	protected override string _GetTemplateForLabelFollow()
	{
		return "关注";
	}

	protected override string _GetTemplateForLabelFollowing()
	{
		return "关注中";
	}

	protected override string _GetTemplateForLabelLoginRequired()
	{
		return "需要登录";
	}

	protected override string _GetTemplateForTooltipFollowGame()
	{
		return "关注游戏";
	}

	protected override string _GetTemplateForTooltipFollowLimitReached()
	{
		return "已达上限。若要关注此游戏，请先取消关注其他游戏。";
	}

	protected override string _GetTemplateForTooltipUnfollowGame()
	{
		return "取消关注游戏";
	}
}
