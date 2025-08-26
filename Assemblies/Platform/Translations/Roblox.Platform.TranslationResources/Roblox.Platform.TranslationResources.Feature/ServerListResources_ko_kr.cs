namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides ServerListResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ServerListResources_ko_kr : ServerListResources_en_us, IServerListResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.ConfigureServer"
	/// Configure server
	/// English String: "Configure"
	/// </summary>
	public override string ActionConfigureServer => "êµ¬ì„±";

	/// <summary>
	/// Key: "Action.LoadMore"
	/// English String: "Load More"
	/// </summary>
	public override string ActionLoadMore => "ë” ë¶ˆëŸ¬ì˜¤ê¸°";

	/// <summary>
	/// Key: "Heading.OtherServers"
	/// English String: "Other Servers"
	/// </summary>
	public override string HeadingOtherServers => "ê¸°íƒ€ ì„œë²„";

	/// <summary>
	/// Key: "Heading.RunningServers"
	/// English String: "All Running Servers"
	/// </summary>
	public override string HeadingRunningServers => "ê°€ë™ ì¤‘ì¸ ëª¨ë“  ì„œë²„";

	/// <summary>
	/// Key: "Heading.ServersMyFriendsAreIn"
	/// English String: "Servers My Friends Are In"
	/// </summary>
	public override string HeadingServersMyFriendsAreIn => "ë‚´ ì¹œêµ¬ê°€ ìžˆëŠ” ì„œë²„";

	/// <summary>
	/// Key: "Label.Inactive"
	/// English String: "Inactive."
	/// </summary>
	public override string LabelInactive => "ë¹„í™œì„±.";

	/// <summary>
	/// Key: "Label.InsufficientFunds"
	/// English String: "This Server has been deactivated. We were not able to process the recurring payment due to insufficient funds in your account."
	/// </summary>
	public override string LabelInsufficientFunds => "ì„œë²„ê°€ ë¹„í™œì„±í™”ë˜ì—ˆìŠµë‹ˆë‹¤. íšŒì›ë‹˜ ê³„ì •ì˜ ìž”ê³ ê°€ ë¶€ì¡±í•˜ì—¬ ìžë™ ì´ì²´ë¥¼ í•˜ì§€ ëª»í–ˆìŠµë‹ˆë‹¤. ";

	/// <summary>
	/// Key: "Label.MyVipServer"
	/// English String: "My VIP Server"
	/// </summary>
	public override string LabelMyVipServer => "ë‚´ VIP ì„œë²„";

	/// <summary>
	/// Key: "Label.NoServersFound"
	/// No Servers Found.
	/// English String: "No Servers Found."
	/// </summary>
	public override string LabelNoServersFound => "ì„œë²„ë¥¼ ì°¾ì„ ìˆ˜ ì—†ìŒ.";

	/// <summary>
	/// Key: "Label.NoVipServers"
	/// No VIP Server Instances Found.
	/// English String: "No VIP Server Instances Found."
	/// </summary>
	public override string LabelNoVipServers => "VIP ì„œë²„ ì¸ìŠ¤í„´ìŠ¤ë¥¼ ì°¾ì„ ìˆ˜ ì—†ìŒ.";

	/// <summary>
	/// Key: "Label.PaymentCancelled"
	/// English String: "Payment Cancelled"
	/// </summary>
	public override string LabelPaymentCancelled => "ê²°ì œ ì·¨ì†Œë¨";

	/// <summary>
	/// Key: "Label.PlacesNotLoading"
	/// The list of places failed to load for some unknown reason.
	/// English String: "Sorry, something went wrong loading places."
	/// </summary>
	public override string LabelPlacesNotLoading => "ì£„ì†¡í•©ë‹ˆë‹¤. ìž¥ì†Œë¥¼ ë¶ˆëŸ¬ì˜¤ëŠ” ì¤‘ì— ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”.";

	/// <summary>
	/// Key: "Label.ServerListJoin"
	/// English String: "Join"
	/// </summary>
	public override string LabelServerListJoin => "ì°¸ê°€";

	/// <summary>
	/// Key: "Label.ServerListRenew"
	/// English String: "Renew"
	/// </summary>
	public override string LabelServerListRenew => "ê°±ì‹ ";

	/// <summary>
	/// Key: "Label.ShutDownServer"
	/// User chooses to close their game server.
	/// English String: "Shut Down This Server"
	/// </summary>
	public override string LabelShutDownServer => "ì„œë²„ ì¢…ë£Œ";

	/// <summary>
	/// Key: "Label.SlowGame"
	/// English String: "Slow Game"
	/// </summary>
	public override string LabelSlowGame => "ì„œë²„ ëŠë¦¼";

	public ServerListResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionConfigureServer()
	{
		return "êµ¬ì„±";
	}

	protected override string _GetTemplateForActionLoadMore()
	{
		return "ë” ë¶ˆëŸ¬ì˜¤ê¸°";
	}

	protected override string _GetTemplateForHeadingOtherServers()
	{
		return "ê¸°íƒ€ ì„œë²„";
	}

	protected override string _GetTemplateForHeadingRunningServers()
	{
		return "ê°€ë™ ì¤‘ì¸ ëª¨ë“  ì„œë²„";
	}

	protected override string _GetTemplateForHeadingServersMyFriendsAreIn()
	{
		return "ë‚´ ì¹œêµ¬ê°€ ìžˆëŠ” ì„œë²„";
	}

	/// <summary>
	/// Key: "Label.CurrentPlayerCount"
	/// English String: "{currentPlayers} of {maximumAllowedPlayers} players max"
	/// </summary>
	public override string LabelCurrentPlayerCount(string currentPlayers, string maximumAllowedPlayers)
	{
		return $"{currentPlayers} / {maximumAllowedPlayers}ëª… (ìµœëŒ€)";
	}

	protected override string _GetTemplateForLabelCurrentPlayerCount()
	{
		return "{currentPlayers} / {maximumAllowedPlayers}ëª… (ìµœëŒ€)";
	}

	protected override string _GetTemplateForLabelInactive()
	{
		return "ë¹„í™œì„±.";
	}

	protected override string _GetTemplateForLabelInsufficientFunds()
	{
		return "ì„œë²„ê°€ ë¹„í™œì„±í™”ë˜ì—ˆìŠµë‹ˆë‹¤. íšŒì›ë‹˜ ê³„ì •ì˜ ìž”ê³ ê°€ ë¶€ì¡±í•˜ì—¬ ìžë™ ì´ì²´ë¥¼ í•˜ì§€ ëª»í–ˆìŠµë‹ˆë‹¤. ";
	}

	protected override string _GetTemplateForLabelMyVipServer()
	{
		return "ë‚´ VIP ì„œë²„";
	}

	protected override string _GetTemplateForLabelNoServersFound()
	{
		return "ì„œë²„ë¥¼ ì°¾ì„ ìˆ˜ ì—†ìŒ.";
	}

	protected override string _GetTemplateForLabelNoVipServers()
	{
		return "VIP ì„œë²„ ì¸ìŠ¤í„´ìŠ¤ë¥¼ ì°¾ì„ ìˆ˜ ì—†ìŒ.";
	}

	protected override string _GetTemplateForLabelPaymentCancelled()
	{
		return "ê²°ì œ ì·¨ì†Œë¨";
	}

	protected override string _GetTemplateForLabelPlacesNotLoading()
	{
		return "ì£„ì†¡í•©ë‹ˆë‹¤. ìž¥ì†Œë¥¼ ë¶ˆëŸ¬ì˜¤ëŠ” ì¤‘ì— ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”.";
	}

	protected override string _GetTemplateForLabelServerListJoin()
	{
		return "ì°¸ê°€";
	}

	protected override string _GetTemplateForLabelServerListRenew()
	{
		return "ê°±ì‹ ";
	}

	protected override string _GetTemplateForLabelShutDownServer()
	{
		return "ì„œë²„ ì¢…ë£Œ";
	}

	protected override string _GetTemplateForLabelSlowGame()
	{
		return "ì„œë²„ ëŠë¦¼";
	}
}


}
