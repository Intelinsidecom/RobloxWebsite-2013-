namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string ActionCancel => "ã‚­ãƒ£ãƒ³ã‚»ãƒ«";

	/// <summary>
	/// Key: "ActionLogin"
	/// Login button label
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "ãƒ­ã‚°ã‚¤ãƒ³";

	/// <summary>
	/// Key: "DescriptionLoginRequired"
	/// Login dialog text for guest user
	/// English String: "You must be logged in to follow this game. Please Login or Register to continue."
	/// </summary>
	public override string DescriptionLoginRequired => "ã“ã®ã‚²ãƒ¼ãƒ ã‚’ãƒ•ã‚©ãƒ­ãƒ¼ã™ã‚‹ã«ã¯ãƒ­ã‚°ã‚¤ãƒ³ã™ã‚‹å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚ãƒ­ã‚°ã‚¤ãƒ³ã¾ãŸã¯æ–°è¦ç™»éŒ²ã—ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "LabelFollow"
	/// Label for follow game button
	/// English String: "Follow"
	/// </summary>
	public override string LabelFollow => "ãƒ•ã‚©ãƒ­ãƒ¼";

	/// <summary>
	/// Key: "LabelFollowing"
	/// Label for follow game button
	/// English String: "Following"
	/// </summary>
	public override string LabelFollowing => "ãƒ•ã‚©ãƒ­ãƒ¼ä¸­";

	/// <summary>
	/// Key: "LabelLoginRequired"
	/// Text for dialog for guest user to redirect to login
	/// English String: "Login Required"
	/// </summary>
	public override string LabelLoginRequired => "ãƒ­ã‚°ã‚¤ãƒ³ãŒå¿…è¦ã§ã™";

	/// <summary>
	/// Key: "TooltipFollowGame"
	/// Tooltip for follow game button
	/// English String: "Follow Game"
	/// </summary>
	public override string TooltipFollowGame => "ã‚²ãƒ¼ãƒ ã®ãƒ•ã‚©ãƒ­ãƒ¼";

	/// <summary>
	/// Key: "TooltipFollowLimitReached"
	/// Tooltip for follow game button
	/// English String: "Limit reached. Please unfollow other games to follow this one."
	/// </summary>
	public override string TooltipFollowLimitReached => "ä¸Šé™ã«åˆ°é”ã—ã¾ã—ãŸã€‚ã»ã‹ã®ã‚²ãƒ¼ãƒ ã®ãƒ•ã‚©ãƒ­ãƒ¼ã‚’ã‚„ã‚ã¦ã‹ã‚‰ãƒ•ã‚©ãƒ­ãƒ¼ã—ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "TooltipUnfollowGame"
	/// Tooltip for follow game button
	/// English String: "Unfollow Game"
	/// </summary>
	public override string TooltipUnfollowGame => "ã‚²ãƒ¼ãƒ ã®ãƒ•ã‚©ãƒ­ãƒ¼ã‚’ã‚„ã‚ã‚‹";

	public GameFollowsResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "ã‚­ãƒ£ãƒ³ã‚»ãƒ«";
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "ãƒ­ã‚°ã‚¤ãƒ³";
	}

	protected override string _GetTemplateForDescriptionLoginRequired()
	{
		return "ã“ã®ã‚²ãƒ¼ãƒ ã‚’ãƒ•ã‚©ãƒ­ãƒ¼ã™ã‚‹ã«ã¯ãƒ­ã‚°ã‚¤ãƒ³ã™ã‚‹å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚ãƒ­ã‚°ã‚¤ãƒ³ã¾ãŸã¯æ–°è¦ç™»éŒ²ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForLabelFollow()
	{
		return "ãƒ•ã‚©ãƒ­ãƒ¼";
	}

	protected override string _GetTemplateForLabelFollowing()
	{
		return "ãƒ•ã‚©ãƒ­ãƒ¼ä¸­";
	}

	protected override string _GetTemplateForLabelLoginRequired()
	{
		return "ãƒ­ã‚°ã‚¤ãƒ³ãŒå¿…è¦ã§ã™";
	}

	protected override string _GetTemplateForTooltipFollowGame()
	{
		return "ã‚²ãƒ¼ãƒ ã®ãƒ•ã‚©ãƒ­ãƒ¼";
	}

	protected override string _GetTemplateForTooltipFollowLimitReached()
	{
		return "ä¸Šé™ã«åˆ°é”ã—ã¾ã—ãŸã€‚ã»ã‹ã®ã‚²ãƒ¼ãƒ ã®ãƒ•ã‚©ãƒ­ãƒ¼ã‚’ã‚„ã‚ã¦ã‹ã‚‰ãƒ•ã‚©ãƒ­ãƒ¼ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForTooltipUnfollowGame()
	{
		return "ã‚²ãƒ¼ãƒ ã®ãƒ•ã‚©ãƒ­ãƒ¼ã‚’ã‚„ã‚ã‚‹";
	}
}


}
