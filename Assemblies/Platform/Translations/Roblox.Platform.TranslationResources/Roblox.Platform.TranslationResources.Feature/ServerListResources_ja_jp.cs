namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides ServerListResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ServerListResources_ja_jp : ServerListResources_en_us, IServerListResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.ConfigureServer"
	/// Configure server
	/// English String: "Configure"
	/// </summary>
	public override string ActionConfigureServer => "ç’°å¢ƒè¨­å®šã™ã‚‹";

	/// <summary>
	/// Key: "Action.LoadMore"
	/// English String: "Load More"
	/// </summary>
	public override string ActionLoadMore => "ã•ã‚‰ã«èª­ã¿è¾¼ã‚€";

	/// <summary>
	/// Key: "Heading.OtherServers"
	/// English String: "Other Servers"
	/// </summary>
	public override string HeadingOtherServers => "ãã®ä»–ã®ã‚µãƒ¼ãƒãƒ¼";

	/// <summary>
	/// Key: "Heading.RunningServers"
	/// English String: "All Running Servers"
	/// </summary>
	public override string HeadingRunningServers => "ã™ã¹ã¦ã®å®Ÿè¡Œä¸­ã‚µãƒ¼ãƒãƒ¼";

	/// <summary>
	/// Key: "Heading.ServersMyFriendsAreIn"
	/// English String: "Servers My Friends Are In"
	/// </summary>
	public override string HeadingServersMyFriendsAreIn => "å‹é”ã®ã„ã‚‹ã‚µãƒ¼ãƒãƒ¼";

	/// <summary>
	/// Key: "Label.Inactive"
	/// English String: "Inactive."
	/// </summary>
	public override string LabelInactive => "åœæ­¢ã€‚";

	/// <summary>
	/// Key: "Label.InsufficientFunds"
	/// English String: "This Server has been deactivated. We were not able to process the recurring payment due to insufficient funds in your account."
	/// </summary>
	public override string LabelInsufficientFunds => "ã“ã®ã‚µãƒ¼ãƒãƒ¼ã¯è§£é™¤ã•ã‚Œã¾ã—ãŸã€‚ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã®è³‡é‡‘ãŒä¸è¶³ã—ã¦ã„ã‚‹ãŸã‚ã€æ”¯æ‰•ã„å‡¦ç†ãŒã§ãã¾ã›ã‚“ã§ã—ãŸã€‚";

	/// <summary>
	/// Key: "Label.MyVipServer"
	/// English String: "My VIP Server"
	/// </summary>
	public override string LabelMyVipServer => "ã‚ãªãŸã®VIPã‚µãƒ¼ãƒãƒ¼";

	/// <summary>
	/// Key: "Label.NoServersFound"
	/// No Servers Found.
	/// English String: "No Servers Found."
	/// </summary>
	public override string LabelNoServersFound => "ã‚µãƒ¼ãƒãƒ¼ãŒè¦‹ã¤ã‹ã‚Šã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Label.NoVipServers"
	/// No VIP Server Instances Found.
	/// English String: "No VIP Server Instances Found."
	/// </summary>
	public override string LabelNoVipServers => "VIPã‚µãƒ¼ãƒãƒ¼ã®ã‚¤ãƒ³ã‚¹ã‚¿ãƒ³ã‚¹ãŒè¦‹ã¤ã‹ã‚Šã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Label.PaymentCancelled"
	/// English String: "Payment Cancelled"
	/// </summary>
	public override string LabelPaymentCancelled => "æ”¯æ‰•ã„ãŒã‚­ãƒ£ãƒ³ã‚»ãƒ«ã•ã‚Œã¾ã—ãŸ";

	/// <summary>
	/// Key: "Label.PlacesNotLoading"
	/// The list of places failed to load for some unknown reason.
	/// English String: "Sorry, something went wrong loading places."
	/// </summary>
	public override string LabelPlacesNotLoading => "ç”³ã—è¨³ã‚ã‚Šã¾ã›ã‚“ã€‚ãƒ—ãƒ¬ãƒ¼ã‚¹ã®èª­ã¿è¾¼ã¿ä¸­ã«å•é¡ŒãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚";

	/// <summary>
	/// Key: "Label.ServerListJoin"
	/// English String: "Join"
	/// </summary>
	public override string LabelServerListJoin => "å‚åŠ ";

	/// <summary>
	/// Key: "Label.ServerListRenew"
	/// English String: "Renew"
	/// </summary>
	public override string LabelServerListRenew => "æ›´æ–°";

	/// <summary>
	/// Key: "Label.ShutDownServer"
	/// User chooses to close their game server.
	/// English String: "Shut Down This Server"
	/// </summary>
	public override string LabelShutDownServer => "ã“ã®ã‚µãƒ¼ãƒãƒ¼ã‚’ã‚·ãƒ£ãƒƒãƒˆãƒ€ã‚¦ãƒ³ã™ã‚‹";

	/// <summary>
	/// Key: "Label.SlowGame"
	/// English String: "Slow Game"
	/// </summary>
	public override string LabelSlowGame => "é…ã„ã‚²ãƒ¼ãƒ ";

	public ServerListResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionConfigureServer()
	{
		return "ç’°å¢ƒè¨­å®šã™ã‚‹";
	}

	protected override string _GetTemplateForActionLoadMore()
	{
		return "ã•ã‚‰ã«èª­ã¿è¾¼ã‚€";
	}

	protected override string _GetTemplateForHeadingOtherServers()
	{
		return "ãã®ä»–ã®ã‚µãƒ¼ãƒãƒ¼";
	}

	protected override string _GetTemplateForHeadingRunningServers()
	{
		return "ã™ã¹ã¦ã®å®Ÿè¡Œä¸­ã‚µãƒ¼ãƒãƒ¼";
	}

	protected override string _GetTemplateForHeadingServersMyFriendsAreIn()
	{
		return "å‹é”ã®ã„ã‚‹ã‚µãƒ¼ãƒãƒ¼";
	}

	/// <summary>
	/// Key: "Label.CurrentPlayerCount"
	/// English String: "{currentPlayers} of {maximumAllowedPlayers} players max"
	/// </summary>
	public override string LabelCurrentPlayerCount(string currentPlayers, string maximumAllowedPlayers)
	{
		return $"æœ€å¤§{maximumAllowedPlayers}äººä¸­{currentPlayers}äººã®ãƒ—ãƒ¬ã‚¤ãƒ¤ãƒ¼";
	}

	protected override string _GetTemplateForLabelCurrentPlayerCount()
	{
		return "æœ€å¤§{maximumAllowedPlayers}äººä¸­{currentPlayers}äººã®ãƒ—ãƒ¬ã‚¤ãƒ¤ãƒ¼";
	}

	protected override string _GetTemplateForLabelInactive()
	{
		return "åœæ­¢ã€‚";
	}

	protected override string _GetTemplateForLabelInsufficientFunds()
	{
		return "ã“ã®ã‚µãƒ¼ãƒãƒ¼ã¯è§£é™¤ã•ã‚Œã¾ã—ãŸã€‚ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã®è³‡é‡‘ãŒä¸è¶³ã—ã¦ã„ã‚‹ãŸã‚ã€æ”¯æ‰•ã„å‡¦ç†ãŒã§ãã¾ã›ã‚“ã§ã—ãŸã€‚";
	}

	protected override string _GetTemplateForLabelMyVipServer()
	{
		return "ã‚ãªãŸã®VIPã‚µãƒ¼ãƒãƒ¼";
	}

	protected override string _GetTemplateForLabelNoServersFound()
	{
		return "ã‚µãƒ¼ãƒãƒ¼ãŒè¦‹ã¤ã‹ã‚Šã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForLabelNoVipServers()
	{
		return "VIPã‚µãƒ¼ãƒãƒ¼ã®ã‚¤ãƒ³ã‚¹ã‚¿ãƒ³ã‚¹ãŒè¦‹ã¤ã‹ã‚Šã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForLabelPaymentCancelled()
	{
		return "æ”¯æ‰•ã„ãŒã‚­ãƒ£ãƒ³ã‚»ãƒ«ã•ã‚Œã¾ã—ãŸ";
	}

	protected override string _GetTemplateForLabelPlacesNotLoading()
	{
		return "ç”³ã—è¨³ã‚ã‚Šã¾ã›ã‚“ã€‚ãƒ—ãƒ¬ãƒ¼ã‚¹ã®èª­ã¿è¾¼ã¿ä¸­ã«å•é¡ŒãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚";
	}

	protected override string _GetTemplateForLabelServerListJoin()
	{
		return "å‚åŠ ";
	}

	protected override string _GetTemplateForLabelServerListRenew()
	{
		return "æ›´æ–°";
	}

	protected override string _GetTemplateForLabelShutDownServer()
	{
		return "ã“ã®ã‚µãƒ¼ãƒãƒ¼ã‚’ã‚·ãƒ£ãƒƒãƒˆãƒ€ã‚¦ãƒ³ã™ã‚‹";
	}

	protected override string _GetTemplateForLabelSlowGame()
	{
		return "é…ã„ã‚²ãƒ¼ãƒ ";
	}
}


}
