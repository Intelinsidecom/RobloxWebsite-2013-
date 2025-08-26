namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string ActionCancel => "ì·¨ì†Œ";

	/// <summary>
	/// Key: "ActionLogin"
	/// Login button label
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "ë¡œê·¸ì¸";

	/// <summary>
	/// Key: "DescriptionLoginRequired"
	/// Login dialog text for guest user
	/// English String: "You must be logged in to follow this game. Please Login or Register to continue."
	/// </summary>
	public override string DescriptionLoginRequired => "ë³¸ ê²Œìž„ì„ íŒ”ë¡œìš°í•˜ë ¤ë©´ ë¡œê·¸ì¸í•´ì•¼ í•©ë‹ˆë‹¤. ê³„ì†í•˜ë ¤ë©´ ë¡œê·¸ì¸ ë˜ëŠ” ê°€ìž…í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "LabelFollow"
	/// Label for follow game button
	/// English String: "Follow"
	/// </summary>
	public override string LabelFollow => "íŒ”ë¡œìš°";

	/// <summary>
	/// Key: "LabelFollowing"
	/// Label for follow game button
	/// English String: "Following"
	/// </summary>
	public override string LabelFollowing => "íŒ”ë¡œìž‰";

	/// <summary>
	/// Key: "LabelLoginRequired"
	/// Text for dialog for guest user to redirect to login
	/// English String: "Login Required"
	/// </summary>
	public override string LabelLoginRequired => "ë¡œê·¸ì¸ í•„ìš”";

	/// <summary>
	/// Key: "TooltipFollowGame"
	/// Tooltip for follow game button
	/// English String: "Follow Game"
	/// </summary>
	public override string TooltipFollowGame => "ê²Œìž„ íŒ”ë¡œìš°";

	/// <summary>
	/// Key: "TooltipFollowLimitReached"
	/// Tooltip for follow game button
	/// English String: "Limit reached. Please unfollow other games to follow this one."
	/// </summary>
	public override string TooltipFollowLimitReached => "íŒ”ë¡œìš°í•œ ê²Œìž„ ìˆ˜ê°€ í•œë„ì— ë„ë‹¬í–ˆì–´ìš”. ë‹¤ë¥¸ ê²Œìž„ì„ íŒ”ë¡œìš° ì·¨ì†Œí•˜ì…”ì•¼ ë³¸ ê²Œìž„ì„ íŒ”ë¡œìš°í•˜ì‹¤ ìˆ˜ ìžˆìŠµë‹ˆë‹¤.";

	/// <summary>
	/// Key: "TooltipUnfollowGame"
	/// Tooltip for follow game button
	/// English String: "Unfollow Game"
	/// </summary>
	public override string TooltipUnfollowGame => "ê²Œìž„ íŒ”ë¡œìš° ì·¨ì†Œ";

	public GameFollowsResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "ì·¨ì†Œ";
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "ë¡œê·¸ì¸";
	}

	protected override string _GetTemplateForDescriptionLoginRequired()
	{
		return "ë³¸ ê²Œìž„ì„ íŒ”ë¡œìš°í•˜ë ¤ë©´ ë¡œê·¸ì¸í•´ì•¼ í•©ë‹ˆë‹¤. ê³„ì†í•˜ë ¤ë©´ ë¡œê·¸ì¸ ë˜ëŠ” ê°€ìž…í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForLabelFollow()
	{
		return "íŒ”ë¡œìš°";
	}

	protected override string _GetTemplateForLabelFollowing()
	{
		return "íŒ”ë¡œìž‰";
	}

	protected override string _GetTemplateForLabelLoginRequired()
	{
		return "ë¡œê·¸ì¸ í•„ìš”";
	}

	protected override string _GetTemplateForTooltipFollowGame()
	{
		return "ê²Œìž„ íŒ”ë¡œìš°";
	}

	protected override string _GetTemplateForTooltipFollowLimitReached()
	{
		return "íŒ”ë¡œìš°í•œ ê²Œìž„ ìˆ˜ê°€ í•œë„ì— ë„ë‹¬í–ˆì–´ìš”. ë‹¤ë¥¸ ê²Œìž„ì„ íŒ”ë¡œìš° ì·¨ì†Œí•˜ì…”ì•¼ ë³¸ ê²Œìž„ì„ íŒ”ë¡œìš°í•˜ì‹¤ ìˆ˜ ìžˆìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForTooltipUnfollowGame()
	{
		return "ê²Œìž„ íŒ”ë¡œìš° ì·¨ì†Œ";
	}
}


}
