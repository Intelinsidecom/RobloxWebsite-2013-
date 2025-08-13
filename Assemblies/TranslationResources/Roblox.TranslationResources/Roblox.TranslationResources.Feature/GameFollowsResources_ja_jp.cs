namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GameFollowsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameFollowsResources_ja_jp : GameFollowsResources_en_us, IGameFollowsResources, ITranslationResources
{
	/// <summary>
	/// Key: "ActionCancel"
	/// Login dialog cancel label
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "キャンセル";

	/// <summary>
	/// Key: "ActionLogin"
	/// Login button label
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "ログイン";

	/// <summary>
	/// Key: "DescriptionLoginRequired"
	/// Login dialog text for guest user
	/// English String: "You must be logged in to follow this game. Please Login or Register to continue."
	/// </summary>
	public override string DescriptionLoginRequired => "このゲームをフォローするにはログインする必要があります。ログインまたは新規登録してください。";

	/// <summary>
	/// Key: "LabelFollow"
	/// Label for follow game button
	/// English String: "Follow"
	/// </summary>
	public override string LabelFollow => "フォロー";

	/// <summary>
	/// Key: "LabelFollowing"
	/// Label for follow game button
	/// English String: "Following"
	/// </summary>
	public override string LabelFollowing => "フォロー中";

	/// <summary>
	/// Key: "LabelLoginRequired"
	/// Text for dialog for guest user to redirect to login
	/// English String: "Login Required"
	/// </summary>
	public override string LabelLoginRequired => "ログインが必要です";

	/// <summary>
	/// Key: "TooltipFollowGame"
	/// Tooltip for follow game button
	/// English String: "Follow Game"
	/// </summary>
	public override string TooltipFollowGame => "ゲームのフォロー";

	/// <summary>
	/// Key: "TooltipFollowLimitReached"
	/// Tooltip for follow game button
	/// English String: "Limit reached. Please unfollow other games to follow this one."
	/// </summary>
	public override string TooltipFollowLimitReached => "上限に到達しました。ほかのゲームのフォローをやめてからフォローしてください。";

	/// <summary>
	/// Key: "TooltipUnfollowGame"
	/// Tooltip for follow game button
	/// English String: "Unfollow Game"
	/// </summary>
	public override string TooltipUnfollowGame => "ゲームのフォローをやめる";

	public GameFollowsResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "キャンセル";
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "ログイン";
	}

	protected override string _GetTemplateForDescriptionLoginRequired()
	{
		return "このゲームをフォローするにはログインする必要があります。ログインまたは新規登録してください。";
	}

	protected override string _GetTemplateForLabelFollow()
	{
		return "フォロー";
	}

	protected override string _GetTemplateForLabelFollowing()
	{
		return "フォロー中";
	}

	protected override string _GetTemplateForLabelLoginRequired()
	{
		return "ログインが必要です";
	}

	protected override string _GetTemplateForTooltipFollowGame()
	{
		return "ゲームのフォロー";
	}

	protected override string _GetTemplateForTooltipFollowLimitReached()
	{
		return "上限に到達しました。ほかのゲームのフォローをやめてからフォローしてください。";
	}

	protected override string _GetTemplateForTooltipUnfollowGame()
	{
		return "ゲームのフォローをやめる";
	}
}
