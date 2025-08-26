namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides GameFollowsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameFollowsResources_zh_tw : GameFollowsResources_en_us, IGameFollowsResources, ITranslationResources
{
	/// <summary>
	/// Key: "ActionCancel"
	/// Login dialog cancel label
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "å–æ¶ˆ";

	/// <summary>
	/// Key: "ActionLogin"
	/// Login button label
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "ç™»å…¥";

	/// <summary>
	/// Key: "DescriptionLoginRequired"
	/// Login dialog text for guest user
	/// English String: "You must be logged in to follow this game. Please Login or Register to continue."
	/// </summary>
	public override string DescriptionLoginRequired => "è‹¥è¦è¿½è¹¤æ­¤éŠæˆ²ï¼Œè«‹å…ˆç™»å…¥æˆ–è¨»å†Šã€‚";

	/// <summary>
	/// Key: "LabelFollow"
	/// Label for follow game button
	/// English String: "Follow"
	/// </summary>
	public override string LabelFollow => "è¿½è¹¤";

	/// <summary>
	/// Key: "LabelFollowing"
	/// Label for follow game button
	/// English String: "Following"
	/// </summary>
	public override string LabelFollowing => "è¿½è¹¤ä¸­";

	/// <summary>
	/// Key: "LabelLoginRequired"
	/// Text for dialog for guest user to redirect to login
	/// English String: "Login Required"
	/// </summary>
	public override string LabelLoginRequired => "éœ€è¦ç™»å…¥";

	/// <summary>
	/// Key: "TooltipFollowGame"
	/// Tooltip for follow game button
	/// English String: "Follow Game"
	/// </summary>
	public override string TooltipFollowGame => "è¿½è¹¤éŠæˆ²";

	/// <summary>
	/// Key: "TooltipFollowLimitReached"
	/// Tooltip for follow game button
	/// English String: "Limit reached. Please unfollow other games to follow this one."
	/// </summary>
	public override string TooltipFollowLimitReached => "å·²é”ä¸Šé™ã€‚è‹¥è¦è¿½è¹¤æ­¤éŠæˆ²ï¼Œè«‹å…ˆå–æ¶ˆè¿½è¹¤å…¶å®ƒéŠæˆ²ã€‚";

	/// <summary>
	/// Key: "TooltipUnfollowGame"
	/// Tooltip for follow game button
	/// English String: "Unfollow Game"
	/// </summary>
	public override string TooltipUnfollowGame => "å–æ¶ˆè¿½è¹¤éŠæˆ²";

	public GameFollowsResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "å–æ¶ˆ";
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "ç™»å…¥";
	}

	protected override string _GetTemplateForDescriptionLoginRequired()
	{
		return "è‹¥è¦è¿½è¹¤æ­¤éŠæˆ²ï¼Œè«‹å…ˆç™»å…¥æˆ–è¨»å†Šã€‚";
	}

	protected override string _GetTemplateForLabelFollow()
	{
		return "è¿½è¹¤";
	}

	protected override string _GetTemplateForLabelFollowing()
	{
		return "è¿½è¹¤ä¸­";
	}

	protected override string _GetTemplateForLabelLoginRequired()
	{
		return "éœ€è¦ç™»å…¥";
	}

	protected override string _GetTemplateForTooltipFollowGame()
	{
		return "è¿½è¹¤éŠæˆ²";
	}

	protected override string _GetTemplateForTooltipFollowLimitReached()
	{
		return "å·²é”ä¸Šé™ã€‚è‹¥è¦è¿½è¹¤æ­¤éŠæˆ²ï¼Œè«‹å…ˆå–æ¶ˆè¿½è¹¤å…¶å®ƒéŠæˆ²ã€‚";
	}

	protected override string _GetTemplateForTooltipUnfollowGame()
	{
		return "å–æ¶ˆè¿½è¹¤éŠæˆ²";
	}
}


}
