using Roblox.Platform.Localization.Core;

namespace Roblox.Platform.Localization.Accounts;

public interface IAccountLocale
{
	/// <summary>
	/// Account id of a user
	/// </summary>
	long AccountId { get; }

	/// <summary>
	/// Supported Locale associated with an account.
	/// </summary>
	ISupportedLocale SupportedLocale { get; }

	/// <summary>
	/// Native language associated with an account. Can be null.
	/// </summary>
	ILanguageFamily NativeLanguage { get; }
}
