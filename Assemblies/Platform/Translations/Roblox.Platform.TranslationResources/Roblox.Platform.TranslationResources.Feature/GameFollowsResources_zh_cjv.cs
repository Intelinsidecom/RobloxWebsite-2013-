namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string ActionCancel => "å–æ¶ˆ";

	/// <summary>
	/// Key: "ActionLogin"
	/// Login button label
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "ç™»å½•";

	/// <summary>
	/// Key: "DescriptionLoginRequired"
	/// Login dialog text for guest user
	/// English String: "You must be logged in to follow this game. Please Login or Register to continue."
	/// </summary>
	public override string DescriptionLoginRequired => "ä½ å¿…é¡»ç™»å½•æ‰èƒ½å…³æ³¨æ­¤æ¸¸æˆã€‚è¯·ç™»å½•æˆ–æ³¨å†Œä»¥ç»§ç»­ã€‚";

	/// <summary>
	/// Key: "LabelFollow"
	/// Label for follow game button
	/// English String: "Follow"
	/// </summary>
	public override string LabelFollow => "å…³æ³¨";

	/// <summary>
	/// Key: "LabelFollowing"
	/// Label for follow game button
	/// English String: "Following"
	/// </summary>
	public override string LabelFollowing => "å…³æ³¨ä¸­";

	/// <summary>
	/// Key: "LabelLoginRequired"
	/// Text for dialog for guest user to redirect to login
	/// English String: "Login Required"
	/// </summary>
	public override string LabelLoginRequired => "éœ€è¦ç™»å½•";

	/// <summary>
	/// Key: "TooltipFollowGame"
	/// Tooltip for follow game button
	/// English String: "Follow Game"
	/// </summary>
	public override string TooltipFollowGame => "å…³æ³¨æ¸¸æˆ";

	/// <summary>
	/// Key: "TooltipFollowLimitReached"
	/// Tooltip for follow game button
	/// English String: "Limit reached. Please unfollow other games to follow this one."
	/// </summary>
	public override string TooltipFollowLimitReached => "å·²è¾¾ä¸Šé™ã€‚è‹¥è¦å…³æ³¨æ­¤æ¸¸æˆï¼Œè¯·å…ˆå–æ¶ˆå…³æ³¨å…¶ä»–æ¸¸æˆã€‚";

	/// <summary>
	/// Key: "TooltipUnfollowGame"
	/// Tooltip for follow game button
	/// English String: "Unfollow Game"
	/// </summary>
	public override string TooltipUnfollowGame => "å–æ¶ˆå…³æ³¨æ¸¸æˆ";

	public GameFollowsResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "å–æ¶ˆ";
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "ç™»å½•";
	}

	protected override string _GetTemplateForDescriptionLoginRequired()
	{
		return "ä½ å¿…é¡»ç™»å½•æ‰èƒ½å…³æ³¨æ­¤æ¸¸æˆã€‚è¯·ç™»å½•æˆ–æ³¨å†Œä»¥ç»§ç»­ã€‚";
	}

	protected override string _GetTemplateForLabelFollow()
	{
		return "å…³æ³¨";
	}

	protected override string _GetTemplateForLabelFollowing()
	{
		return "å…³æ³¨ä¸­";
	}

	protected override string _GetTemplateForLabelLoginRequired()
	{
		return "éœ€è¦ç™»å½•";
	}

	protected override string _GetTemplateForTooltipFollowGame()
	{
		return "å…³æ³¨æ¸¸æˆ";
	}

	protected override string _GetTemplateForTooltipFollowLimitReached()
	{
		return "å·²è¾¾ä¸Šé™ã€‚è‹¥è¦å…³æ³¨æ­¤æ¸¸æˆï¼Œè¯·å…ˆå–æ¶ˆå…³æ³¨å…¶ä»–æ¸¸æˆã€‚";
	}

	protected override string _GetTemplateForTooltipUnfollowGame()
	{
		return "å–æ¶ˆå…³æ³¨æ¸¸æˆ";
	}
}


}
