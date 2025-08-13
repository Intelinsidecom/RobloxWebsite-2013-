using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class ServerListResources_en_us : TranslationResourcesBase, IServerListResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.ConfigureServer"
	/// Configure server
	/// English String: "Configure"
	/// </summary>
	public virtual string ActionConfigureServer => "Configure";

	/// <summary>
	/// Key: "Action.LoadMore"
	/// English String: "Load More"
	/// </summary>
	public virtual string ActionLoadMore => "Load More";

	/// <summary>
	/// Key: "Heading.OtherServers"
	/// English String: "Other Servers"
	/// </summary>
	public virtual string HeadingOtherServers => "Other Servers";

	/// <summary>
	/// Key: "Heading.RunningServers"
	/// English String: "All Running Servers"
	/// </summary>
	public virtual string HeadingRunningServers => "All Running Servers";

	/// <summary>
	/// Key: "Heading.ServersMyFriendsAreIn"
	/// English String: "Servers My Friends Are In"
	/// </summary>
	public virtual string HeadingServersMyFriendsAreIn => "Servers My Friends Are In";

	/// <summary>
	/// Key: "Label.Inactive"
	/// English String: "Inactive."
	/// </summary>
	public virtual string LabelInactive => "Inactive.";

	/// <summary>
	/// Key: "Label.InsufficientFunds"
	/// English String: "This Server has been deactivated. We were not able to process the recurring payment due to insufficient funds in your account."
	/// </summary>
	public virtual string LabelInsufficientFunds => "This Server has been deactivated. We were not able to process the recurring payment due to insufficient funds in your account.";

	/// <summary>
	/// Key: "Label.MyVipServer"
	/// English String: "My VIP Server"
	/// </summary>
	public virtual string LabelMyVipServer => "My VIP Server";

	/// <summary>
	/// Key: "Label.NoServersFound"
	/// No Servers Found.
	/// English String: "No Servers Found."
	/// </summary>
	public virtual string LabelNoServersFound => "No Servers Found.";

	/// <summary>
	/// Key: "Label.NoVipServers"
	/// No VIP Server Instances Found.
	/// English String: "No VIP Server Instances Found."
	/// </summary>
	public virtual string LabelNoVipServers => "No VIP Server Instances Found.";

	/// <summary>
	/// Key: "Label.PaymentCancelled"
	/// English String: "Payment Cancelled"
	/// </summary>
	public virtual string LabelPaymentCancelled => "Payment Cancelled";

	/// <summary>
	/// Key: "Label.PlacesNotLoading"
	/// The list of places failed to load for some unknown reason.
	/// English String: "Sorry, something went wrong loading places."
	/// </summary>
	public virtual string LabelPlacesNotLoading => "Sorry, something went wrong loading places.";

	/// <summary>
	/// Key: "Label.ServerListJoin"
	/// English String: "Join"
	/// </summary>
	public virtual string LabelServerListJoin => "Join";

	/// <summary>
	/// Key: "Label.ServerListRenew"
	/// English String: "Renew"
	/// </summary>
	public virtual string LabelServerListRenew => "Renew";

	/// <summary>
	/// Key: "Label.ShutDownServer"
	/// User chooses to close their game server.
	/// English String: "Shut Down This Server"
	/// </summary>
	public virtual string LabelShutDownServer => "Shut Down This Server";

	/// <summary>
	/// Key: "Label.SlowGame"
	/// English String: "Slow Game"
	/// </summary>
	public virtual string LabelSlowGame => "Slow Game";

	public ServerListResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.ConfigureServer",
				_GetTemplateForActionConfigureServer()
			},
			{
				"Action.LoadMore",
				_GetTemplateForActionLoadMore()
			},
			{
				"Heading.OtherServers",
				_GetTemplateForHeadingOtherServers()
			},
			{
				"Heading.RunningServers",
				_GetTemplateForHeadingRunningServers()
			},
			{
				"Heading.ServersMyFriendsAreIn",
				_GetTemplateForHeadingServersMyFriendsAreIn()
			},
			{
				"Label.CurrentPlayerCount",
				_GetTemplateForLabelCurrentPlayerCount()
			},
			{
				"Label.Inactive",
				_GetTemplateForLabelInactive()
			},
			{
				"Label.InsufficientFunds",
				_GetTemplateForLabelInsufficientFunds()
			},
			{
				"Label.MyVipServer",
				_GetTemplateForLabelMyVipServer()
			},
			{
				"Label.NoServersFound",
				_GetTemplateForLabelNoServersFound()
			},
			{
				"Label.NoVipServers",
				_GetTemplateForLabelNoVipServers()
			},
			{
				"Label.PaymentCancelled",
				_GetTemplateForLabelPaymentCancelled()
			},
			{
				"Label.PlacesNotLoading",
				_GetTemplateForLabelPlacesNotLoading()
			},
			{
				"Label.ServerListJoin",
				_GetTemplateForLabelServerListJoin()
			},
			{
				"Label.ServerListRenew",
				_GetTemplateForLabelServerListRenew()
			},
			{
				"Label.ShutDownServer",
				_GetTemplateForLabelShutDownServer()
			},
			{
				"Label.SlowGame",
				_GetTemplateForLabelSlowGame()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.ServerList";
	}

	protected virtual string _GetTemplateForActionConfigureServer()
	{
		return "Configure";
	}

	protected virtual string _GetTemplateForActionLoadMore()
	{
		return "Load More";
	}

	protected virtual string _GetTemplateForHeadingOtherServers()
	{
		return "Other Servers";
	}

	protected virtual string _GetTemplateForHeadingRunningServers()
	{
		return "All Running Servers";
	}

	protected virtual string _GetTemplateForHeadingServersMyFriendsAreIn()
	{
		return "Servers My Friends Are In";
	}

	/// <summary>
	/// Key: "Label.CurrentPlayerCount"
	/// English String: "{currentPlayers} of {maximumAllowedPlayers} players max"
	/// </summary>
	public virtual string LabelCurrentPlayerCount(string currentPlayers, string maximumAllowedPlayers)
	{
		return $"{currentPlayers} of {maximumAllowedPlayers} players max";
	}

	protected virtual string _GetTemplateForLabelCurrentPlayerCount()
	{
		return "{currentPlayers} of {maximumAllowedPlayers} players max";
	}

	protected virtual string _GetTemplateForLabelInactive()
	{
		return "Inactive.";
	}

	protected virtual string _GetTemplateForLabelInsufficientFunds()
	{
		return "This Server has been deactivated. We were not able to process the recurring payment due to insufficient funds in your account.";
	}

	protected virtual string _GetTemplateForLabelMyVipServer()
	{
		return "My VIP Server";
	}

	protected virtual string _GetTemplateForLabelNoServersFound()
	{
		return "No Servers Found.";
	}

	protected virtual string _GetTemplateForLabelNoVipServers()
	{
		return "No VIP Server Instances Found.";
	}

	protected virtual string _GetTemplateForLabelPaymentCancelled()
	{
		return "Payment Cancelled";
	}

	protected virtual string _GetTemplateForLabelPlacesNotLoading()
	{
		return "Sorry, something went wrong loading places.";
	}

	protected virtual string _GetTemplateForLabelServerListJoin()
	{
		return "Join";
	}

	protected virtual string _GetTemplateForLabelServerListRenew()
	{
		return "Renew";
	}

	protected virtual string _GetTemplateForLabelShutDownServer()
	{
		return "Shut Down This Server";
	}

	protected virtual string _GetTemplateForLabelSlowGame()
	{
		return "Slow Game";
	}
}
