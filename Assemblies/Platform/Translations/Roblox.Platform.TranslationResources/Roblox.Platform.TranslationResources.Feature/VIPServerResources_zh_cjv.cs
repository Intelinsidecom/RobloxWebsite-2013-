using System;
using System.Collections.Generic;
namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides VIPServerResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class VIPServerResources_zh_cjv : VIPServerResources_en_us, IVIPServerResources, ITranslationResources
{

    public IReadOnlyDictionary<string, string> GetAllKeys()
    {
        return base.GetAllKeys();
    }

    public string GetFullContentNamespaceName()
    {
        return "Feature.VIPServer";
    }

	/// <summary>
	/// Key: "Action.Add"
	/// English String: "Add"
	/// </summary>
	public override string ActionAdd => "Ã¦Â·Â»Ã¥Å Â ";

	/// <summary>
	/// Key: "Action.AddPlayers"
	/// English String: "Add Players"
	/// </summary>
	public override string ActionAddPlayers => "Ã¦Â·Â»Ã¥Å Â Ã§Å½Â©Ã¥Â®Â¶";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Ã¥Ââ€“Ã¦Â¶Ë†";

	/// <summary>
	/// Key: "Action.CancelPayments"
	/// English String: "Cancel Payments"
	/// </summary>
	public override string ActionCancelPayments => "Ã¥Ââ€“Ã¦Â¶Ë†Ã¤Â»ËœÃ¦Â¬Â¾";

	/// <summary>
	/// Key: "Action.ChangeName"
	/// English String: "Change Name"
	/// </summary>
	public override string ActionChangeName => "Ã¦â€ºÂ´Ã¦â€Â¹Ã¥ÂÂÃ§Â§Â°";

	/// <summary>
	/// Key: "Action.GoBack"
	/// English String: "Go Back"
	/// </summary>
	public override string ActionGoBack => "Ã¨Â¿â€Ã¥â€ºÅ¾";

	/// <summary>
	/// Key: "Action.RegenerateJoinLink"
	/// English String: "Regenerate"
	/// </summary>
	public override string ActionRegenerateJoinLink => "Ã¥â€ ÂÃ§â€Å¸";

	/// <summary>
	/// Key: "Action.Remove"
	/// English String: "Remove"
	/// </summary>
	public override string ActionRemove => "Ã§Â§Â»Ã©â„¢Â¤";

	/// <summary>
	/// Key: "Action.RenewVipServer"
	/// English String: "Renew VIP Server"
	/// </summary>
	public override string ActionRenewVipServer => "Ã§Â»Â­Ã¨Â®Â¢ VIP Ã¦Å“ÂÃ¥Å Â¡Ã¥â„¢Â¨";

	/// <summary>
	/// Key: "Action.SeeAll"
	/// English String: "See All"
	/// </summary>
	public override string ActionSeeAll => "Ã¦Å¸Â¥Ã§Å“â€¹Ã¥â€¦Â¨Ã©Æ’Â¨";

	/// <summary>
	/// Key: "Heading.CancelPayments"
	/// English String: "Cancel Payments"
	/// </summary>
	public override string HeadingCancelPayments => "Ã¥Ââ€“Ã¦Â¶Ë†Ã¤Â»ËœÃ¦Â¬Â¾";

	/// <summary>
	/// Key: "Heading.ChangeName"
	/// English String: "Change VIP Server Name"
	/// </summary>
	public override string HeadingChangeName => "Ã¦â€ºÂ´Ã¦â€Â¹ VIP Ã¦Å“ÂÃ¥Å Â¡Ã¥â„¢Â¨Ã¥ÂÂÃ§Â§Â°";

	/// <summary>
	/// Key: "Heading.ConfigureVipServer"
	/// English String: "Configure VIP Server"
	/// </summary>
	public override string HeadingConfigureVipServer => "Ã©â€¦ÂÃ§Â½Â® VIP Ã¦Å“ÂÃ¥Å Â¡Ã¥â„¢Â¨";

	/// <summary>
	/// Key: "Heading.RemovePlayer"
	/// English String: "Remove Player"
	/// </summary>
	public override string HeadingRemovePlayer => "Ã§Â§Â»Ã©â„¢Â¤Ã§Å½Â©Ã¥Â®Â¶";

	/// <summary>
	/// Key: "Heading.RenewVipServer"
	/// English String: "Renew VIP Server"
	/// </summary>
	public override string HeadingRenewVipServer => "Ã§Â»Â­Ã¨Â®Â¢ VIP Ã¦Å“ÂÃ¥Å Â¡Ã¥â„¢Â¨";

	/// <summary>
	/// Key: "Label.ChangeNamePlaceholder"
	/// English String: "VIP Server Name (1-50 Characters)"
	/// </summary>
	public override string LabelChangeNamePlaceholder => "VIP Ã¦Å“ÂÃ¥Å Â¡Ã¥â„¢Â¨Ã¥ÂÂÃ§Â§Â°Ã¯Â¼Ë†1-50 Ã¤Â¸ÂªÃ¥Â­â€”Ã§Â¬Â¦Ã¯Â¼â€°";

	/// <summary>
	/// Key: "Label.ClanAccess"
	/// English String: "Clan Access"
	/// </summary>
	public override string LabelClanAccess => "Ã©Æ’Â¨Ã¨ÂÂ½Ã©â‚¬Å¡Ã¨Â¡Å’Ã¨Â¯Â";

	/// <summary>
	/// Key: "Label.FriendsAllowed"
	/// English String: "Friends Allowed"
	/// </summary>
	public override string LabelFriendsAllowed => "Ã¥â€¦ÂÃ¨Â®Â¸Ã¥Â¥Â½Ã¥Ââ€¹";

	/// <summary>
	/// Key: "Label.GameName"
	/// English String: "Game Name"
	/// </summary>
	public override string LabelGameName => "Ã¦Â¸Â¸Ã¦Ë†ÂÃ¥ÂÂÃ§Â§Â°";

	/// <summary>
	/// Key: "Label.JoinGameLink"
	/// English String: "Join Game Link..."
	/// </summary>
	public override string LabelJoinGameLink => "Ã¥Å Â Ã¥â€¦Â¥Ã¦Â¸Â¸Ã¦Ë†ÂÃ©â€œÂ¾Ã¦Å½Â¥...";

	/// <summary>
	/// Key: "Label.None"
	/// English String: "None"
	/// </summary>
	public override string LabelNone => "Ã¦â€”Â ";

	/// <summary>
	/// Key: "Label.Off"
	/// English String: "Off"
	/// </summary>
	public override string LabelOff => "Ã¥â€¦Â³Ã©â€”Â­";

	/// <summary>
	/// Key: "Label.On"
	/// English String: "On"
	/// </summary>
	public override string LabelOn => "Ã¥Â¼â‚¬Ã¥ÂÂ¯";

	/// <summary>
	/// Key: "Label.PickEnemyClan"
	/// English String: "Pick Enemy Clan"
	/// </summary>
	public override string LabelPickEnemyClan => "Ã¦Å’â€˜Ã©â‚¬â€°Ã¦â€¢Å’Ã¤ÂºÂºÃ©Æ’Â¨Ã¨ÂÂ½";

	/// <summary>
	/// Key: "Label.SearchForPlayers"
	/// English String: "Search for Players"
	/// </summary>
	public override string LabelSearchForPlayers => "Ã¦ÂÅ“Ã§Â´Â¢Ã§Å½Â©Ã¥Â®Â¶";

	/// <summary>
	/// Key: "Label.Server"
	/// English String: "Server"
	/// </summary>
	public override string LabelServer => "Ã¦Å“ÂÃ¥Å Â¡Ã¥â„¢Â¨";

	/// <summary>
	/// Key: "Label.ServerMembers"
	/// English String: "Server Members"
	/// </summary>
	public override string LabelServerMembers => "Ã¦Å“ÂÃ¥Å Â¡Ã¥â„¢Â¨Ã¦Ë†ÂÃ¥â€˜Ëœ";

	/// <summary>
	/// Key: "Label.SubscriptionStatus"
	/// English String: "Subscription Status"
	/// </summary>
	public override string LabelSubscriptionStatus => "Ã¨Â®Â¢Ã©Ëœâ€¦Ã§Å Â¶Ã¦â‚¬Â";

	/// <summary>
	/// Key: "Label.VIPServerLink"
	/// English String: "VIP Server Link"
	/// </summary>
	public override string LabelVIPServerLink => "VIP Ã¦Å“ÂÃ¥Å Â¡Ã¥â„¢Â¨Ã©â€œÂ¾Ã¦Å½Â¥";

	/// <summary>
	/// Key: "Label.VIPServerStatus"
	/// English String: "VIP Server Status"
	/// </summary>
	public override string LabelVIPServerStatus => "VIP Ã¦Å“ÂÃ¥Å Â¡Ã¥â„¢Â¨Ã§Å Â¶Ã¦â‚¬Â";

	/// <summary>
	/// Key: "Label.YourClan"
	/// English String: "Your Clan"
	/// </summary>
	public override string LabelYourClan => "Ã¤Â½Â Ã§Å¡â€žÃ©Æ’Â¨Ã¨ÂÂ½";

	public VIPServerResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAdd()
	{
		return "Ã¦Â·Â»Ã¥Å Â ";
	}

	protected override string _GetTemplateForActionAddPlayers()
	{
		return "Ã¦Â·Â»Ã¥Å Â Ã§Å½Â©Ã¥Â®Â¶";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Ã¥Ââ€“Ã¦Â¶Ë†";
	}

	protected override string _GetTemplateForActionCancelPayments()
	{
		return "Ã¥Ââ€“Ã¦Â¶Ë†Ã¤Â»ËœÃ¦Â¬Â¾";
	}

	protected override string _GetTemplateForActionChangeName()
	{
		return "Ã¦â€ºÂ´Ã¦â€Â¹Ã¥ÂÂÃ§Â§Â°";
	}

	protected override string _GetTemplateForActionGoBack()
	{
		return "Ã¨Â¿â€Ã¥â€ºÅ¾";
	}

	protected override string _GetTemplateForActionRegenerateJoinLink()
	{
		return "Ã¥â€ ÂÃ§â€Å¸";
	}

	protected override string _GetTemplateForActionRemove()
	{
		return "Ã§Â§Â»Ã©â„¢Â¤";
	}

	protected override string _GetTemplateForActionRenewVipServer()
	{
		return "Ã§Â»Â­Ã¨Â®Â¢ VIP Ã¦Å“ÂÃ¥Å Â¡Ã¥â„¢Â¨";
	}

	protected override string _GetTemplateForActionSeeAll()
	{
		return "Ã¦Å¸Â¥Ã§Å“â€¹Ã¥â€¦Â¨Ã©Æ’Â¨";
	}

	protected override string _GetTemplateForHeadingCancelPayments()
	{
		return "Ã¥Ââ€“Ã¦Â¶Ë†Ã¤Â»ËœÃ¦Â¬Â¾";
	}

	protected override string _GetTemplateForHeadingChangeName()
	{
		return "Ã¦â€ºÂ´Ã¦â€Â¹ VIP Ã¦Å“ÂÃ¥Å Â¡Ã¥â„¢Â¨Ã¥ÂÂÃ§Â§Â°";
	}

	protected override string _GetTemplateForHeadingConfigureVipServer()
	{
		return "Ã©â€¦ÂÃ§Â½Â® VIP Ã¦Å“ÂÃ¥Å Â¡Ã¥â„¢Â¨";
	}

	protected override string _GetTemplateForHeadingRemovePlayer()
	{
		return "Ã§Â§Â»Ã©â„¢Â¤Ã§Å½Â©Ã¥Â®Â¶";
	}

	protected override string _GetTemplateForHeadingRenewVipServer()
	{
		return "Ã§Â»Â­Ã¨Â®Â¢ VIP Ã¦Å“ÂÃ¥Å Â¡Ã¥â„¢Â¨";
	}

	/// <summary>
	/// Key: "Label.ChangeNameBodyMessage"
	/// English String: "Are you sure you want to cancel future payments for your VIP Server of {name} by {creator}? If you cancel, your VIP Server will be deactivated on {date}."
	/// </summary>
	public override string LabelChangeNameBodyMessage(string name, string creator, string date)
	{
		return $"Ã¦ËœÂ¯Ã¥ÂÂ¦Ã§Â¡Â®Ã¥Â®Å¡Ã¨Â¦ÂÃ¥Ââ€“Ã¦Â¶Ë†Ã¢â‚¬Å“{creator}Ã¢â‚¬ÂÃ¦â€°â‚¬Ã¥Ë†â€ºÃ¤Â½Å“Ã§Å¡â€žÃ¢â‚¬Å“{name}Ã¢â‚¬ÂÃ§Â§ÂÃ¤ÂºÂº VIP Ã¦Å“ÂÃ¥Å Â¡Ã¥â„¢Â¨Ã§Å¡â€žÃ©Â¢â€žÃ¤Â»ËœÃ¦Â¬Â¾Ã¯Â¼Å¸Ã¥Â¦â€šÃ¦Å¾Å“Ã¥Ââ€“Ã¦Â¶Ë†Ã¯Â¼Å’Ã¤Â½Â Ã§Å¡â€ž VIP Ã¦Å“ÂÃ¥Å Â¡Ã¥â„¢Â¨Ã¥Â°â€ Ã¤ÂºÅ½ {date} Ã¥Â¤Â±Ã¦â€¢Ë†Ã£â‚¬â€š";
	}

	protected override string _GetTemplateForLabelChangeNameBodyMessage()
	{
		return "Ã¦ËœÂ¯Ã¥ÂÂ¦Ã§Â¡Â®Ã¥Â®Å¡Ã¨Â¦ÂÃ¥Ââ€“Ã¦Â¶Ë†Ã¢â‚¬Å“{creator}Ã¢â‚¬ÂÃ¦â€°â‚¬Ã¥Ë†â€ºÃ¤Â½Å“Ã§Å¡â€žÃ¢â‚¬Å“{name}Ã¢â‚¬ÂÃ§Â§ÂÃ¤ÂºÂº VIP Ã¦Å“ÂÃ¥Å Â¡Ã¥â„¢Â¨Ã§Å¡â€žÃ©Â¢â€žÃ¤Â»ËœÃ¦Â¬Â¾Ã¯Â¼Å¸Ã¥Â¦â€šÃ¦Å¾Å“Ã¥Ââ€“Ã¦Â¶Ë†Ã¯Â¼Å’Ã¤Â½Â Ã§Å¡â€ž VIP Ã¦Å“ÂÃ¥Å Â¡Ã¥â„¢Â¨Ã¥Â°â€ Ã¤ÂºÅ½ {date} Ã¥Â¤Â±Ã¦â€¢Ë†Ã£â‚¬â€š";
	}

	protected override string _GetTemplateForLabelChangeNamePlaceholder()
	{
		return "VIP Ã¦Å“ÂÃ¥Å Â¡Ã¥â„¢Â¨Ã¥ÂÂÃ§Â§Â°Ã¯Â¼Ë†1-50 Ã¤Â¸ÂªÃ¥Â­â€”Ã§Â¬Â¦Ã¯Â¼â€°";
	}

	protected override string _GetTemplateForLabelClanAccess()
	{
		return "Ã©Æ’Â¨Ã¨ÂÂ½Ã©â‚¬Å¡Ã¨Â¡Å’Ã¨Â¯Â";
	}

	protected override string _GetTemplateForLabelFriendsAllowed()
	{
		return "Ã¥â€¦ÂÃ¨Â®Â¸Ã¥Â¥Â½Ã¥Ââ€¹";
	}

	protected override string _GetTemplateForLabelGameName()
	{
		return "Ã¦Â¸Â¸Ã¦Ë†ÂÃ¥ÂÂÃ§Â§Â°";
	}

	protected override string _GetTemplateForLabelJoinGameLink()
	{
		return "Ã¥Å Â Ã¥â€¦Â¥Ã¦Â¸Â¸Ã¦Ë†ÂÃ©â€œÂ¾Ã¦Å½Â¥...";
	}

	protected override string _GetTemplateForLabelNone()
	{
		return "Ã¦â€”Â ";
	}

	protected override string _GetTemplateForLabelOff()
	{
		return "Ã¥â€¦Â³Ã©â€”Â­";
	}

	protected override string _GetTemplateForLabelOn()
	{
		return "Ã¥Â¼â‚¬Ã¥ÂÂ¯";
	}

	protected override string _GetTemplateForLabelPickEnemyClan()
	{
		return "Ã¦Å’â€˜Ã©â‚¬â€°Ã¦â€¢Å’Ã¤ÂºÂºÃ©Æ’Â¨Ã¨ÂÂ½";
	}

	/// <summary>
	/// Key: "Label.RemovePlayerBodyMessage"
	/// English String: "Are you sure you want to remove {name} from your VIP Server? They will no longer be able to join your VIP Server."
	/// </summary>
	public override string LabelRemovePlayerBodyMessage(string name)
	{
		return $"Ã¦ËœÂ¯Ã¥ÂÂ¦Ã§Â¡Â®Ã¥Â®Å¡Ã¨Â¦ÂÃ¤Â»Å½Ã¤Â½Â Ã§Å¡â€ž VIP Ã¦Å“ÂÃ¥Å Â¡Ã¥â„¢Â¨Ã§Â§Â»Ã©â„¢Â¤ {name}Ã¯Â¼Å¸Ã¥Â¯Â¹Ã¦â€“Â¹Ã¥Â°â€ Ã¦â€”Â Ã¦Â³â€¢Ã¥â€ ÂÃ¥Å Â Ã¥â€¦Â¥Ã¤Â½Â Ã§Å¡â€ž VIP Ã¦Å“ÂÃ¥Å Â¡Ã¥â„¢Â¨Ã£â‚¬â€š";
	}

	protected override string _GetTemplateForLabelRemovePlayerBodyMessage()
	{
		return "Ã¦ËœÂ¯Ã¥ÂÂ¦Ã§Â¡Â®Ã¥Â®Å¡Ã¨Â¦ÂÃ¤Â»Å½Ã¤Â½Â Ã§Å¡â€ž VIP Ã¦Å“ÂÃ¥Å Â¡Ã¥â„¢Â¨Ã§Â§Â»Ã©â„¢Â¤ {name}Ã¯Â¼Å¸Ã¥Â¯Â¹Ã¦â€“Â¹Ã¥Â°â€ Ã¦â€”Â Ã¦Â³â€¢Ã¥â€ ÂÃ¥Å Â Ã¥â€¦Â¥Ã¤Â½Â Ã§Å¡â€ž VIP Ã¦Å“ÂÃ¥Å Â¡Ã¥â„¢Â¨Ã£â‚¬â€š";
	}

	/// <summary>
	/// Key: "Label.RenewVipServerBodyMessageConfirmation"
	/// English String: "Are you sure you want to enable future payments for your VIP Server of {name} by {creator}?"
	/// </summary>
	public override string LabelRenewVipServerBodyMessageConfirmation(string name, string creator)
	{
		return $"Ã¦ËœÂ¯Ã¥ÂÂ¦Ã§Â¡Â®Ã¥Â®Å¡Ã¤Â¸ÂºÃ¢â‚¬Å“{creator}Ã¢â‚¬ÂÃ¦â€°â‚¬Ã¥Ë†â€ºÃ¤Â½Å“Ã§Å¡â€žÃ¢â‚¬Å“{name}Ã¢â‚¬ÂÃ¥ÂÂ¯Ã§â€Â¨Ã§Â§ÂÃ¤ÂºÂº VIP Ã¦Å“ÂÃ¥Å Â¡Ã¥â„¢Â¨Ã§â€°Ë†Ã¦Å“Â¬Ã©Â¢â€žÃ¤Â»ËœÃ¦Â¬Â¾Ã¯Â¼Å¸";
	}

	protected override string _GetTemplateForLabelRenewVipServerBodyMessageConfirmation()
	{
		return "Ã¦ËœÂ¯Ã¥ÂÂ¦Ã§Â¡Â®Ã¥Â®Å¡Ã¤Â¸ÂºÃ¢â‚¬Å“{creator}Ã¢â‚¬ÂÃ¦â€°â‚¬Ã¥Ë†â€ºÃ¤Â½Å“Ã§Å¡â€žÃ¢â‚¬Å“{name}Ã¢â‚¬ÂÃ¥ÂÂ¯Ã§â€Â¨Ã§Â§ÂÃ¤ÂºÂº VIP Ã¦Å“ÂÃ¥Å Â¡Ã¥â„¢Â¨Ã§â€°Ë†Ã¦Å“Â¬Ã©Â¢â€žÃ¤Â»ËœÃ¦Â¬Â¾Ã¯Â¼Å¸";
	}

	/// <summary>
	/// Key: "Label.RenewVipServerBodyMessageStart"
	/// English String: "This VIP Server will start renewing every month at {date} until you cancel."
	/// </summary>
	public override string LabelRenewVipServerBodyMessageStart(string date)
	{
		return $"Ã¦Â­Â¤ VIP Ã¦Å“ÂÃ¥Å Â¡Ã¥â„¢Â¨Ã¥Â°â€ Ã¤ÂºÅ½Ã¦Â¯ÂÃ¦Å“Ë† {date} Ã§Â»Â­Ã¨Â®Â¢Ã¯Â¼Å’Ã§â€ºÂ´Ã¨â€¡Â³Ã¤Â½Â Ã¥Ââ€“Ã¦Â¶Ë†Ã£â‚¬â€š";
	}

	protected override string _GetTemplateForLabelRenewVipServerBodyMessageStart()
	{
		return "Ã¦Â­Â¤ VIP Ã¦Å“ÂÃ¥Å Â¡Ã¥â„¢Â¨Ã¥Â°â€ Ã¤ÂºÅ½Ã¦Â¯ÂÃ¦Å“Ë† {date} Ã§Â»Â­Ã¨Â®Â¢Ã¯Â¼Å’Ã§â€ºÂ´Ã¨â€¡Â³Ã¤Â½Â Ã¥Ââ€“Ã¦Â¶Ë†Ã£â‚¬â€š";
	}

	protected override string _GetTemplateForLabelSearchForPlayers()
	{
		return "Ã¦ÂÅ“Ã§Â´Â¢Ã§Å½Â©Ã¥Â®Â¶";
	}

	protected override string _GetTemplateForLabelServer()
	{
		return "Ã¦Å“ÂÃ¥Å Â¡Ã¥â„¢Â¨";
	}

	/// <summary>
	/// Key: "Label.ServerExpirationDate"
	/// English String: "Your VIP Server expired on{date}"
	/// </summary>
	public override string LabelServerExpirationDate(string date)
	{
		return $"Ã¤Â½Â  VIP Ã¦Å“ÂÃ¥Å Â¡Ã¥â„¢Â¨Ã§Å¡â€žÃ¥Â¤Â±Ã¦â€¢Ë†Ã¦â€”Â¥Ã¦Å“Å¸Ã¤Â¸Âº {date}";
	}

	protected override string _GetTemplateForLabelServerExpirationDate()
	{
		return "Ã¤Â½Â  VIP Ã¦Å“ÂÃ¥Å Â¡Ã¥â„¢Â¨Ã§Å¡â€žÃ¥Â¤Â±Ã¦â€¢Ë†Ã¦â€”Â¥Ã¦Å“Å¸Ã¤Â¸Âº {date}";
	}

	protected override string _GetTemplateForLabelServerMembers()
	{
		return "Ã¦Å“ÂÃ¥Å Â¡Ã¥â„¢Â¨Ã¦Ë†ÂÃ¥â€˜Ëœ";
	}

	/// <summary>
	/// Key: "Label.SubscriptionChargeDate"
	/// English String: "You will be charged again on {date}"
	/// </summary>
	public override string LabelSubscriptionChargeDate(string date)
	{
		return $"Ã¤Â½Â Ã¥Â°â€ Ã¤ÂºÅ½ {date} Ã¨Â¢Â«Ã¥â€ ÂÃ¦Â¬Â¡Ã¦â€Â¶Ã¨Â´Â¹";
	}

	protected override string _GetTemplateForLabelSubscriptionChargeDate()
	{
		return "Ã¤Â½Â Ã¥Â°â€ Ã¤ÂºÅ½ {date} Ã¨Â¢Â«Ã¥â€ ÂÃ¦Â¬Â¡Ã¦â€Â¶Ã¨Â´Â¹";
	}

	/// <summary>
	/// Key: "Label.SubscriptionMonthlyPaymentDue"
	/// English String: "Your VIP Server monthly payment is {value}"
	/// </summary>
	public override string LabelSubscriptionMonthlyPaymentDue(string value)
	{
		return $"Ã¤Â½Â Ã§Å¡â€ž VIP Ã¦Å“ÂÃ¥Å Â¡Ã¥â„¢Â¨Ã¦Å“Ë†Ã¨Â´Â¹Ã¤Â¸Âº {value}";
	}

	protected override string _GetTemplateForLabelSubscriptionMonthlyPaymentDue()
	{
		return "Ã¤Â½Â Ã§Å¡â€ž VIP Ã¦Å“ÂÃ¥Å Â¡Ã¥â„¢Â¨Ã¦Å“Ë†Ã¨Â´Â¹Ã¤Â¸Âº {value}";
	}

	protected override string _GetTemplateForLabelSubscriptionStatus()
	{
		return "Ã¨Â®Â¢Ã©Ëœâ€¦Ã§Å Â¶Ã¦â‚¬Â";
	}

	protected override string _GetTemplateForLabelVIPServerLink()
	{
		return "VIP Ã¦Å“ÂÃ¥Å Â¡Ã¥â„¢Â¨Ã©â€œÂ¾Ã¦Å½Â¥";
	}

	protected override string _GetTemplateForLabelVIPServerStatus()
	{
		return "VIP Ã¦Å“ÂÃ¥Å Â¡Ã¥â„¢Â¨Ã§Å Â¶Ã¦â‚¬Â";
	}

	protected override string _GetTemplateForLabelYourClan()
	{
		return "Ã¤Â½Â Ã§Å¡â€žÃ©Æ’Â¨Ã¨ÂÂ½";
	}
}


}

