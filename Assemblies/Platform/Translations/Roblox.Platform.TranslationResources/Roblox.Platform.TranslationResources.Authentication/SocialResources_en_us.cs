using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Authentication;

internal class SocialResources_en_us : TranslationResourcesBase, ISocialResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public virtual string ActionCancel => "Cancel";

	/// <summary>
	/// Key: "Action.Unlink"
	/// English String: "Unlink"
	/// </summary>
	public virtual string ActionUnlink => "Unlink";

	/// <summary>
	/// Key: "Description.ConnectedAccounts"
	/// English String: "Disconnect your connected accounts here. Unlinking an account will log you out of Roblox."
	/// </summary>
	public virtual string DescriptionConnectedAccounts => "Disconnect your connected accounts here. Unlinking an account will log you out of Roblox.";

	/// <summary>
	/// Key: "Description.UnlinkLogOutWarning"
	/// English String: "Unlinking this account will log you out of Roblox. You will have to link your account again to log back in."
	/// </summary>
	public virtual string DescriptionUnlinkLogOutWarning => "Unlinking this account will log you out of Roblox. You will have to link your account again to log back in.";

	/// <summary>
	/// Key: "Heading.ConnectedAccounts"
	/// English String: "Connected Accounts"
	/// </summary>
	public virtual string HeadingConnectedAccounts => "Connected Accounts";

	/// <summary>
	/// Key: "Placeholder.Password"
	/// English String: "Password"
	/// </summary>
	public virtual string PlaceholderPassword => "Password";

	/// <summary>
	/// Key: "Response.InvalidPassword"
	/// English String: "Invalid Password."
	/// </summary>
	public virtual string ResponseInvalidPassword => "Invalid Password.";

	public SocialResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.Cancel",
				_GetTemplateForActionCancel()
			},
			{
				"Action.Unlink",
				_GetTemplateForActionUnlink()
			},
			{
				"Description.ConnectedAccounts",
				_GetTemplateForDescriptionConnectedAccounts()
			},
			{
				"Description.UnlinkLogOutWarning",
				_GetTemplateForDescriptionUnlinkLogOutWarning()
			},
			{
				"Heading.ConnectedAccounts",
				_GetTemplateForHeadingConnectedAccounts()
			},
			{
				"Heading.Unlink",
				_GetTemplateForHeadingUnlink()
			},
			{
				"Placeholder.Password",
				_GetTemplateForPlaceholderPassword()
			},
			{
				"Response.InvalidPassword",
				_GetTemplateForResponseInvalidPassword()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Authentication.Social";
	}

	protected virtual string _GetTemplateForActionCancel()
	{
		return "Cancel";
	}

	protected virtual string _GetTemplateForActionUnlink()
	{
		return "Unlink";
	}

	protected virtual string _GetTemplateForDescriptionConnectedAccounts()
	{
		return "Disconnect your connected accounts here. Unlinking an account will log you out of Roblox.";
	}

	protected virtual string _GetTemplateForDescriptionUnlinkLogOutWarning()
	{
		return "Unlinking this account will log you out of Roblox. You will have to link your account again to log back in.";
	}

	protected virtual string _GetTemplateForHeadingConnectedAccounts()
	{
		return "Connected Accounts";
	}

	/// <summary>
	/// Key: "Heading.Unlink"
	/// English String: "Unlink {provider}"
	/// </summary>
	public virtual string HeadingUnlink(string provider)
	{
		return $"Unlink {provider}";
	}

	protected virtual string _GetTemplateForHeadingUnlink()
	{
		return "Unlink {provider}";
	}

	protected virtual string _GetTemplateForPlaceholderPassword()
	{
		return "Password";
	}

	protected virtual string _GetTemplateForResponseInvalidPassword()
	{
		return "Invalid Password.";
	}
}
