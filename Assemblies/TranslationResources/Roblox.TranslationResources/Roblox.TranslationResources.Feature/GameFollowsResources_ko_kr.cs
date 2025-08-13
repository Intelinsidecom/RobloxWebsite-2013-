namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GameFollowsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameFollowsResources_ko_kr : GameFollowsResources_en_us, IGameFollowsResources, ITranslationResources
{
	/// <summary>
	/// Key: "ActionCancel"
	/// Login dialog cancel label
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "취소";

	/// <summary>
	/// Key: "ActionLogin"
	/// Login button label
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "로그인";

	/// <summary>
	/// Key: "DescriptionLoginRequired"
	/// Login dialog text for guest user
	/// English String: "You must be logged in to follow this game. Please Login or Register to continue."
	/// </summary>
	public override string DescriptionLoginRequired => "본 게임을 팔로우하려면 로그인해야 합니다. 계속하려면 로그인 또는 가입하세요.";

	/// <summary>
	/// Key: "LabelFollow"
	/// Label for follow game button
	/// English String: "Follow"
	/// </summary>
	public override string LabelFollow => "팔로우";

	/// <summary>
	/// Key: "LabelFollowing"
	/// Label for follow game button
	/// English String: "Following"
	/// </summary>
	public override string LabelFollowing => "팔로잉";

	/// <summary>
	/// Key: "LabelLoginRequired"
	/// Text for dialog for guest user to redirect to login
	/// English String: "Login Required"
	/// </summary>
	public override string LabelLoginRequired => "로그인 필요";

	/// <summary>
	/// Key: "TooltipFollowGame"
	/// Tooltip for follow game button
	/// English String: "Follow Game"
	/// </summary>
	public override string TooltipFollowGame => "게임 팔로우";

	/// <summary>
	/// Key: "TooltipFollowLimitReached"
	/// Tooltip for follow game button
	/// English String: "Limit reached. Please unfollow other games to follow this one."
	/// </summary>
	public override string TooltipFollowLimitReached => "팔로우한 게임 수가 한도에 도달했어요. 다른 게임을 팔로우 취소하셔야 본 게임을 팔로우하실 수 있습니다.";

	/// <summary>
	/// Key: "TooltipUnfollowGame"
	/// Tooltip for follow game button
	/// English String: "Unfollow Game"
	/// </summary>
	public override string TooltipUnfollowGame => "게임 팔로우 취소";

	public GameFollowsResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "취소";
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "로그인";
	}

	protected override string _GetTemplateForDescriptionLoginRequired()
	{
		return "본 게임을 팔로우하려면 로그인해야 합니다. 계속하려면 로그인 또는 가입하세요.";
	}

	protected override string _GetTemplateForLabelFollow()
	{
		return "팔로우";
	}

	protected override string _GetTemplateForLabelFollowing()
	{
		return "팔로잉";
	}

	protected override string _GetTemplateForLabelLoginRequired()
	{
		return "로그인 필요";
	}

	protected override string _GetTemplateForTooltipFollowGame()
	{
		return "게임 팔로우";
	}

	protected override string _GetTemplateForTooltipFollowLimitReached()
	{
		return "팔로우한 게임 수가 한도에 도달했어요. 다른 게임을 팔로우 취소하셔야 본 게임을 팔로우하실 수 있습니다.";
	}

	protected override string _GetTemplateForTooltipUnfollowGame()
	{
		return "게임 팔로우 취소";
	}
}
