using Roblox.Platform.Localization.Core;
namespace Roblox.Localization.Accounts.Implementationsinternal {
    class AccountLocale : IAccountLocale

{
	public long AccountId { get; set; }

	public ISupportedLocale SupportedLocale { get; set; }

	public ILanguageFamily NativeLanguage { get; set; }
}


}
