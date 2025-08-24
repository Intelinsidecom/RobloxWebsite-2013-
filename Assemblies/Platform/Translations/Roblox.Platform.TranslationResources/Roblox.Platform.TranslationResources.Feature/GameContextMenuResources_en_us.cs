using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class GameContextMenuResources_en_us : TranslationResourcesBase, IGameContextMenuResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "ActionDialogAccept"
	/// English String: "Yes"
	/// </summary>
	public virtual string ActionDialogAccept => "Yes";

	/// <summary>
	/// Key: "ActionDialogDecline"
	/// English String: "No"
	/// </summary>
	public virtual string ActionDialogDecline => "No";

	/// <summary>
	/// Key: "ActionDialogOk"
	/// English String: "OK"
	/// </summary>
	public virtual string ActionDialogOk => "OK";

	/// <summary>
	/// Key: "Label.ConfigureLocalization"
	/// The label in context menu that will direct game owner to configure localization page
	/// English String: "Configure Localization"
	/// </summary>
	public virtual string LabelConfigureLocalization => "Configure Localization";

	/// <summary>
	/// Key: "Label.TranslateThisGame"
	/// The label in context menu that will direct translators for a game to crowdsource translation page
	/// English String: "Translate this Game"
	/// </summary>
	public virtual string LabelTranslateThisGame => "Translate this Game";

	/// <summary>
	/// Key: "LabelAddToProfile"
	/// English String: "Add to profile"
	/// </summary>
	public virtual string LabelAddToProfile => "Add to profile";

	/// <summary>
	/// Key: "LabelConfigureGame"
	/// English String: "Configure this Game"
	/// </summary>
	public virtual string LabelConfigureGame => "Configure this Game";

	/// <summary>
	/// Key: "LabelConfigurePlace"
	/// English String: "Configure this Place"
	/// </summary>
	public virtual string LabelConfigurePlace => "Configure this Place";

	/// <summary>
	/// Key: "LabelDeveloperStats"
	/// English String: "Developer Stats"
	/// </summary>
	public virtual string LabelDeveloperStats => "Developer Stats";

	/// <summary>
	/// Key: "LabelEdit"
	/// English String: "Edit"
	/// </summary>
	public virtual string LabelEdit => "Edit";

	/// <summary>
	/// Key: "LabelRemoveFromProfile"
	/// English String: "Remove from Profile"
	/// </summary>
	public virtual string LabelRemoveFromProfile => "Remove from Profile";

	/// <summary>
	/// Key: "LabelServerError"
	/// English String: "An Error Occured"
	/// </summary>
	public virtual string LabelServerError => "An Error Occured";

	/// <summary>
	/// Key: "LabelShutDownAllServers"
	/// English String: "Shut Down All Servers"
	/// </summary>
	public virtual string LabelShutDownAllServers => "Shut Down All Servers";

	/// <summary>
	/// Key: "LabelShutDownServersWarning"
	/// English String: "Are you sure you want to shut down all servers for this place?"
	/// </summary>
	public virtual string LabelShutDownServersWarning => "Are you sure you want to shut down all servers for this place?";

	/// <summary>
	/// Key: "MessageServerShutDownError"
	/// English String: "Could not shut down servers."
	/// </summary>
	public virtual string MessageServerShutDownError => "Could not shut down servers.";

	public GameContextMenuResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"ActionDialogAccept",
				_GetTemplateForActionDialogAccept()
			},
			{
				"ActionDialogDecline",
				_GetTemplateForActionDialogDecline()
			},
			{
				"ActionDialogOk",
				_GetTemplateForActionDialogOk()
			},
			{
				"Label.ConfigureLocalization",
				_GetTemplateForLabelConfigureLocalization()
			},
			{
				"Label.TranslateThisGame",
				_GetTemplateForLabelTranslateThisGame()
			},
			{
				"LabelAddToProfile",
				_GetTemplateForLabelAddToProfile()
			},
			{
				"LabelConfigureGame",
				_GetTemplateForLabelConfigureGame()
			},
			{
				"LabelConfigurePlace",
				_GetTemplateForLabelConfigurePlace()
			},
			{
				"LabelDeveloperStats",
				_GetTemplateForLabelDeveloperStats()
			},
			{
				"LabelEdit",
				_GetTemplateForLabelEdit()
			},
			{
				"LabelRemoveFromProfile",
				_GetTemplateForLabelRemoveFromProfile()
			},
			{
				"LabelServerError",
				_GetTemplateForLabelServerError()
			},
			{
				"LabelShutDownAllServers",
				_GetTemplateForLabelShutDownAllServers()
			},
			{
				"LabelShutDownServersWarning",
				_GetTemplateForLabelShutDownServersWarning()
			},
			{
				"MessageServerShutDownError",
				_GetTemplateForMessageServerShutDownError()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.GameContextMenu";
	}

	protected virtual string _GetTemplateForActionDialogAccept()
	{
		return "Yes";
	}

	protected virtual string _GetTemplateForActionDialogDecline()
	{
		return "No";
	}

	protected virtual string _GetTemplateForActionDialogOk()
	{
		return "OK";
	}

	protected virtual string _GetTemplateForLabelConfigureLocalization()
	{
		return "Configure Localization";
	}

	protected virtual string _GetTemplateForLabelTranslateThisGame()
	{
		return "Translate this Game";
	}

	protected virtual string _GetTemplateForLabelAddToProfile()
	{
		return "Add to profile";
	}

	protected virtual string _GetTemplateForLabelConfigureGame()
	{
		return "Configure this Game";
	}

	protected virtual string _GetTemplateForLabelConfigurePlace()
	{
		return "Configure this Place";
	}

	protected virtual string _GetTemplateForLabelDeveloperStats()
	{
		return "Developer Stats";
	}

	protected virtual string _GetTemplateForLabelEdit()
	{
		return "Edit";
	}

	protected virtual string _GetTemplateForLabelRemoveFromProfile()
	{
		return "Remove from Profile";
	}

	protected virtual string _GetTemplateForLabelServerError()
	{
		return "An Error Occured";
	}

	protected virtual string _GetTemplateForLabelShutDownAllServers()
	{
		return "Shut Down All Servers";
	}

	protected virtual string _GetTemplateForLabelShutDownServersWarning()
	{
		return "Are you sure you want to shut down all servers for this place?";
	}

	protected virtual string _GetTemplateForMessageServerShutDownError()
	{
		return "Could not shut down servers.";
	}
}
