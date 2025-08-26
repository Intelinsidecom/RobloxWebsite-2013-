namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides ServerListResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ServerListResources_zh_cn : ServerListResources_en_us, IServerListResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.ConfigureServer"
	/// Configure server
	/// English String: "Configure"
	/// </summary>
	public override string ActionConfigureServer => "é…ç½®";

	/// <summary>
	/// Key: "Action.LoadMore"
	/// English String: "Load More"
	/// </summary>
	public override string ActionLoadMore => "åŠ è½½æ›´å¤š";

	/// <summary>
	/// Key: "Heading.OtherServers"
	/// English String: "Other Servers"
	/// </summary>
	public override string HeadingOtherServers => "å…¶ä»–æœåŠ¡å™¨";

	/// <summary>
	/// Key: "Heading.RunningServers"
	/// English String: "All Running Servers"
	/// </summary>
	public override string HeadingRunningServers => "æ‰€æœ‰è¿è¡Œä¸­çš„æœåŠ¡å™¨";

	/// <summary>
	/// Key: "Heading.ServersMyFriendsAreIn"
	/// English String: "Servers My Friends Are In"
	/// </summary>
	public override string HeadingServersMyFriendsAreIn => "æˆ‘å¥½å‹æ‰€åœ¨çš„æœåŠ¡å™¨";

	/// <summary>
	/// Key: "Label.Inactive"
	/// English String: "Inactive."
	/// </summary>
	public override string LabelInactive => "ä¸æ´»è·ƒã€‚";

	/// <summary>
	/// Key: "Label.InsufficientFunds"
	/// English String: "This Server has been deactivated. We were not able to process the recurring payment due to insufficient funds in your account."
	/// </summary>
	public override string LabelInsufficientFunds => "æ­¤æœåŠ¡å™¨å·²åœç”¨ã€‚ç”±äºŽä½ çš„å¸æˆ·èµ„é‡‘ä¸è¶³ï¼Œæˆ‘ä»¬æ— æ³•å¤„ç†å‘¨æœŸæ€§ä»˜æ¬¾ã€‚";

	/// <summary>
	/// Key: "Label.MyVipServer"
	/// English String: "My VIP Server"
	/// </summary>
	public override string LabelMyVipServer => "æˆ‘çš„ VIP æœåŠ¡å™¨";

	/// <summary>
	/// Key: "Label.NoServersFound"
	/// No Servers Found.
	/// English String: "No Servers Found."
	/// </summary>
	public override string LabelNoServersFound => "æœªæ‰¾åˆ°æœåŠ¡å™¨ã€‚";

	/// <summary>
	/// Key: "Label.NoVipServers"
	/// No VIP Server Instances Found.
	/// English String: "No VIP Server Instances Found."
	/// </summary>
	public override string LabelNoVipServers => "æœªæ‰¾åˆ° VIP æœåŠ¡å™¨å®žä¾‹ã€‚";

	/// <summary>
	/// Key: "Label.PaymentCancelled"
	/// English String: "Payment Cancelled"
	/// </summary>
	public override string LabelPaymentCancelled => "ä»˜æ¬¾å·²å–æ¶ˆ";

	/// <summary>
	/// Key: "Label.PlacesNotLoading"
	/// The list of places failed to load for some unknown reason.
	/// English String: "Sorry, something went wrong loading places."
	/// </summary>
	public override string LabelPlacesNotLoading => "æŠ±æ­‰ï¼ŒåŠ è½½åœ°ç‚¹æ—¶å‘ç”Ÿé”™è¯¯ã€‚";

	/// <summary>
	/// Key: "Label.ServerListJoin"
	/// English String: "Join"
	/// </summary>
	public override string LabelServerListJoin => "åŠ å…¥";

	/// <summary>
	/// Key: "Label.ServerListRenew"
	/// English String: "Renew"
	/// </summary>
	public override string LabelServerListRenew => "ç»­è®¢";

	/// <summary>
	/// Key: "Label.ShutDownServer"
	/// User chooses to close their game server.
	/// English String: "Shut Down This Server"
	/// </summary>
	public override string LabelShutDownServer => "å…³é—­æ­¤æœåŠ¡å™¨";

	/// <summary>
	/// Key: "Label.SlowGame"
	/// English String: "Slow Game"
	/// </summary>
	public override string LabelSlowGame => "æ…¢é€Ÿæ¸¸æˆ";

	public ServerListResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionConfigureServer()
	{
		return "é…ç½®";
	}

	protected override string _GetTemplateForActionLoadMore()
	{
		return "åŠ è½½æ›´å¤š";
	}

	protected override string _GetTemplateForHeadingOtherServers()
	{
		return "å…¶ä»–æœåŠ¡å™¨";
	}

	protected override string _GetTemplateForHeadingRunningServers()
	{
		return "æ‰€æœ‰è¿è¡Œä¸­çš„æœåŠ¡å™¨";
	}

	protected override string _GetTemplateForHeadingServersMyFriendsAreIn()
	{
		return "æˆ‘å¥½å‹æ‰€åœ¨çš„æœåŠ¡å™¨";
	}

	/// <summary>
	/// Key: "Label.CurrentPlayerCount"
	/// English String: "{currentPlayers} of {maximumAllowedPlayers} players max"
	/// </summary>
	public override string LabelCurrentPlayerCount(string currentPlayers, string maximumAllowedPlayers)
	{
		return $"{currentPlayers} ä½çŽ©å®¶ï¼Œæœ€å¤š {maximumAllowedPlayers} ä½";
	}

	protected override string _GetTemplateForLabelCurrentPlayerCount()
	{
		return "{currentPlayers} ä½çŽ©å®¶ï¼Œæœ€å¤š {maximumAllowedPlayers} ä½";
	}

	protected override string _GetTemplateForLabelInactive()
	{
		return "ä¸æ´»è·ƒã€‚";
	}

	protected override string _GetTemplateForLabelInsufficientFunds()
	{
		return "æ­¤æœåŠ¡å™¨å·²åœç”¨ã€‚ç”±äºŽä½ çš„å¸æˆ·èµ„é‡‘ä¸è¶³ï¼Œæˆ‘ä»¬æ— æ³•å¤„ç†å‘¨æœŸæ€§ä»˜æ¬¾ã€‚";
	}

	protected override string _GetTemplateForLabelMyVipServer()
	{
		return "æˆ‘çš„ VIP æœåŠ¡å™¨";
	}

	protected override string _GetTemplateForLabelNoServersFound()
	{
		return "æœªæ‰¾åˆ°æœåŠ¡å™¨ã€‚";
	}

	protected override string _GetTemplateForLabelNoVipServers()
	{
		return "æœªæ‰¾åˆ° VIP æœåŠ¡å™¨å®žä¾‹ã€‚";
	}

	protected override string _GetTemplateForLabelPaymentCancelled()
	{
		return "ä»˜æ¬¾å·²å–æ¶ˆ";
	}

	protected override string _GetTemplateForLabelPlacesNotLoading()
	{
		return "æŠ±æ­‰ï¼ŒåŠ è½½åœ°ç‚¹æ—¶å‘ç”Ÿé”™è¯¯ã€‚";
	}

	protected override string _GetTemplateForLabelServerListJoin()
	{
		return "åŠ å…¥";
	}

	protected override string _GetTemplateForLabelServerListRenew()
	{
		return "ç»­è®¢";
	}

	protected override string _GetTemplateForLabelShutDownServer()
	{
		return "å…³é—­æ­¤æœåŠ¡å™¨";
	}

	protected override string _GetTemplateForLabelSlowGame()
	{
		return "æ…¢é€Ÿæ¸¸æˆ";
	}
}


}
