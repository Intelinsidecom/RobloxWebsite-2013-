namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides ServerListResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ServerListResources_zh_tw : ServerListResources_en_us, IServerListResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.ConfigureServer"
	/// Configure server
	/// English String: "Configure"
	/// </summary>
	public override string ActionConfigureServer => "è¨­å®š";

	/// <summary>
	/// Key: "Action.LoadMore"
	/// English String: "Load More"
	/// </summary>
	public override string ActionLoadMore => "è¼‰å…¥æ›´å¤š";

	/// <summary>
	/// Key: "Heading.OtherServers"
	/// English String: "Other Servers"
	/// </summary>
	public override string HeadingOtherServers => "å…¶å®ƒä¼ºæœå™¨";

	/// <summary>
	/// Key: "Heading.RunningServers"
	/// English String: "All Running Servers"
	/// </summary>
	public override string HeadingRunningServers => "æ‰€æœ‰æ­£åœ¨é‹ä½œçš„ä¼ºæœå™¨";

	/// <summary>
	/// Key: "Heading.ServersMyFriendsAreIn"
	/// English String: "Servers My Friends Are In"
	/// </summary>
	public override string HeadingServersMyFriendsAreIn => "æˆ‘çš„å¥½å‹æ‰€åœ¨çš„ä¼ºæœå™¨";

	/// <summary>
	/// Key: "Label.Inactive"
	/// English String: "Inactive."
	/// </summary>
	public override string LabelInactive => "æœªå•Ÿç”¨ã€‚";

	/// <summary>
	/// Key: "Label.InsufficientFunds"
	/// English String: "This Server has been deactivated. We were not able to process the recurring payment due to insufficient funds in your account."
	/// </summary>
	public override string LabelInsufficientFunds => "æ­¤ä¼ºæœå™¨å·²é—œé–‰ã€‚ç”±æ–¼æ‚¨çš„å¸³è™Ÿè³‡é‡‘ä¸è¶³ï¼Œç„¡æ³•ç‚ºæ‚¨é€²è¡Œå®šæœŸä»˜æ¬¾ã€‚";

	/// <summary>
	/// Key: "Label.MyVipServer"
	/// English String: "My VIP Server"
	/// </summary>
	public override string LabelMyVipServer => "æˆ‘çš„ VIP ä¼ºæœå™¨";

	/// <summary>
	/// Key: "Label.NoServersFound"
	/// No Servers Found.
	/// English String: "No Servers Found."
	/// </summary>
	public override string LabelNoServersFound => "æ‰¾ä¸åˆ°ä¼ºæœå™¨ã€‚";

	/// <summary>
	/// Key: "Label.NoVipServers"
	/// No VIP Server Instances Found.
	/// English String: "No VIP Server Instances Found."
	/// </summary>
	public override string LabelNoVipServers => "æ‰¾ä¸åˆ° VIP ä¼ºæœå™¨ã€‚";

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
	public override string LabelPlacesNotLoading => "å°ä¸èµ·ï¼Œè¼‰å…¥ç©ºé–“æ™‚ç™¼ç”ŸéŒ¯èª¤ã€‚";

	/// <summary>
	/// Key: "Label.ServerListJoin"
	/// English String: "Join"
	/// </summary>
	public override string LabelServerListJoin => "åŠ å…¥";

	/// <summary>
	/// Key: "Label.ServerListRenew"
	/// English String: "Renew"
	/// </summary>
	public override string LabelServerListRenew => "çºŒè¨‚";

	/// <summary>
	/// Key: "Label.ShutDownServer"
	/// User chooses to close their game server.
	/// English String: "Shut Down This Server"
	/// </summary>
	public override string LabelShutDownServer => "é—œé–‰æ­¤ä¼ºæœå™¨";

	/// <summary>
	/// Key: "Label.SlowGame"
	/// English String: "Slow Game"
	/// </summary>
	public override string LabelSlowGame => "é‹ä½œç·©æ…¢";

	public ServerListResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionConfigureServer()
	{
		return "è¨­å®š";
	}

	protected override string _GetTemplateForActionLoadMore()
	{
		return "è¼‰å…¥æ›´å¤š";
	}

	protected override string _GetTemplateForHeadingOtherServers()
	{
		return "å…¶å®ƒä¼ºæœå™¨";
	}

	protected override string _GetTemplateForHeadingRunningServers()
	{
		return "æ‰€æœ‰æ­£åœ¨é‹ä½œçš„ä¼ºæœå™¨";
	}

	protected override string _GetTemplateForHeadingServersMyFriendsAreIn()
	{
		return "æˆ‘çš„å¥½å‹æ‰€åœ¨çš„ä¼ºæœå™¨";
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
		return "æœªå•Ÿç”¨ã€‚";
	}

	protected override string _GetTemplateForLabelInsufficientFunds()
	{
		return "æ­¤ä¼ºæœå™¨å·²é—œé–‰ã€‚ç”±æ–¼æ‚¨çš„å¸³è™Ÿè³‡é‡‘ä¸è¶³ï¼Œç„¡æ³•ç‚ºæ‚¨é€²è¡Œå®šæœŸä»˜æ¬¾ã€‚";
	}

	protected override string _GetTemplateForLabelMyVipServer()
	{
		return "æˆ‘çš„ VIP ä¼ºæœå™¨";
	}

	protected override string _GetTemplateForLabelNoServersFound()
	{
		return "æ‰¾ä¸åˆ°ä¼ºæœå™¨ã€‚";
	}

	protected override string _GetTemplateForLabelNoVipServers()
	{
		return "æ‰¾ä¸åˆ° VIP ä¼ºæœå™¨ã€‚";
	}

	protected override string _GetTemplateForLabelPaymentCancelled()
	{
		return "ä»˜æ¬¾å·²å–æ¶ˆ";
	}

	protected override string _GetTemplateForLabelPlacesNotLoading()
	{
		return "å°ä¸èµ·ï¼Œè¼‰å…¥ç©ºé–“æ™‚ç™¼ç”ŸéŒ¯èª¤ã€‚";
	}

	protected override string _GetTemplateForLabelServerListJoin()
	{
		return "åŠ å…¥";
	}

	protected override string _GetTemplateForLabelServerListRenew()
	{
		return "çºŒè¨‚";
	}

	protected override string _GetTemplateForLabelShutDownServer()
	{
		return "é—œé–‰æ­¤ä¼ºæœå™¨";
	}

	protected override string _GetTemplateForLabelSlowGame()
	{
		return "é‹ä½œç·©æ…¢";
	}
}


}
