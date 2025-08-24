using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Authentication;

internal class ReturnToStudioResources_en_us : TranslationResourcesBase, IReturnToStudioResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.Logout"
	/// Logout the current user
	/// English String: "Switch Accounts"
	/// </summary>
	public virtual string ActionLogout => "Switch Accounts";

	/// <summary>
	/// Key: "Action.OpenStudio"
	/// Open studio
	/// English String: "Open Studio"
	/// </summary>
	public virtual string ActionOpenStudio => "Open Studio";

	/// <summary>
	/// Key: "Description.OpeningStudio"
	/// English String: "Opening Roblox Studio now..."
	/// </summary>
	public virtual string DescriptionOpeningStudio => "Opening Roblox Studio now...";

	/// <summary>
	/// Key: "Label.StudioHelp"
	/// English String: "If Studio does not open, click here for help"
	/// </summary>
	public virtual string LabelStudioHelp => "If Studio does not open, click here for help";

	public ReturnToStudioResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.Logout",
				_GetTemplateForActionLogout()
			},
			{
				"Action.OpenStudio",
				_GetTemplateForActionOpenStudio()
			},
			{
				"Description.AttemptedUsername",
				_GetTemplateForDescriptionAttemptedUsername()
			},
			{
				"Description.OpeningStudio",
				_GetTemplateForDescriptionOpeningStudio()
			},
			{
				"Description.OpenStudioSuggestion",
				_GetTemplateForDescriptionOpenStudioSuggestion()
			},
			{
				"Heading.Greeting",
				_GetTemplateForHeadingGreeting()
			},
			{
				"Label.StudioHelp",
				_GetTemplateForLabelStudioHelp()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Authentication.ReturnToStudio";
	}

	protected virtual string _GetTemplateForActionLogout()
	{
		return "Switch Accounts";
	}

	protected virtual string _GetTemplateForActionOpenStudio()
	{
		return "Open Studio";
	}

	/// <summary>
	/// Key: "Description.AttemptedUsername"
	/// The username that the user is using to login to studio
	/// English String: "You were trying to log in to Studio as {username}"
	/// </summary>
	public virtual string DescriptionAttemptedUsername(string username)
	{
		return $"You were trying to log in to Studio as {username}";
	}

	protected virtual string _GetTemplateForDescriptionAttemptedUsername()
	{
		return "You were trying to log in to Studio as {username}";
	}

	protected virtual string _GetTemplateForDescriptionOpeningStudio()
	{
		return "Opening Roblox Studio now...";
	}

	/// <summary>
	/// Key: "Description.OpenStudioSuggestion"
	/// Open studio as current authenticated user.
	/// English String: "Do you want to open Studio as {username}?"
	/// </summary>
	public virtual string DescriptionOpenStudioSuggestion(string username)
	{
		return $"Do you want to open Studio as {username}?";
	}

	protected virtual string _GetTemplateForDescriptionOpenStudioSuggestion()
	{
		return "Do you want to open Studio as {username}?";
	}

	/// <summary>
	/// Key: "Heading.Greeting"
	/// greeting to user
	/// English String: "Hello, {username}!"
	/// </summary>
	public virtual string HeadingGreeting(string username)
	{
		return $"Hello, {username}!";
	}

	protected virtual string _GetTemplateForHeadingGreeting()
	{
		return "Hello, {username}!";
	}

	protected virtual string _GetTemplateForLabelStudioHelp()
	{
		return "If Studio does not open, click here for help";
	}
}
