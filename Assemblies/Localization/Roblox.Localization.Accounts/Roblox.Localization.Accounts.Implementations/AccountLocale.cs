using Roblox.Localization.Core;
namespace Roblox.Localization.Accounts.Implementations {
    class AccountLocale : IAccountLocale

{
	public long AccountId { get; set; }

	public ISupportedLocale SupportedLocale { get; set; }

	public ILanguageFamily NativeLanguage { get; set; }
}


}
