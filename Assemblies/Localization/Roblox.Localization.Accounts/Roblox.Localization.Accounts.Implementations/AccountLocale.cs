using Roblox.Platform.Localization.Core;

namespace Roblox.Platform.Localization.Accounts.Implementations;

internal class AccountLocale : IAccountLocale
{
	public long AccountId { get; set; }

	public ISupportedLocale SupportedLocale { get; set; }

	public ILanguageFamily NativeLanguage { get; set; }
}
