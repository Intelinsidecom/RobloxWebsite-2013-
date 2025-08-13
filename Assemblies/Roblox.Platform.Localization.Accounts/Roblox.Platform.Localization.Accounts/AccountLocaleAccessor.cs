using Roblox.Platform.Core;
using Roblox.Platform.Localization.Accounts.Implementations;
using Roblox.Platform.Localization.Core;
using Roblox.Platform.Membership;
using Roblox.TranslationResources;

namespace Roblox.Platform.Localization.Accounts;

internal class AccountLocaleAccessor : IAccountLocaleAccessor
{
	private readonly IAccountLocaleEntityFactory _AccountLocaleEntityFactory;

	private readonly ISupportedLocaleAndLanguageMapper _SupportedLocaleAndLanguageMapper;

	public AccountLocaleAccessor(IAccountLocaleEntityFactory accountLocaleEntityFactory, ISupportedLocaleAndLanguageMapper supportedLocaleAndLanguageMapper)
	{
		_AccountLocaleEntityFactory = accountLocaleEntityFactory ?? throw new PlatformArgumentNullException("accountLocaleEntityFactory");
		_SupportedLocaleAndLanguageMapper = supportedLocaleAndLanguageMapper ?? throw new PlatformArgumentNullException("supportedLocaleAndLanguageMapper");
	}

	public IAccountLocale GetAccountLocale(long accountId)
	{
		IAccountLocaleEntity accountLocaleEntity = _AccountLocaleEntityFactory.GetByAccountId(accountId);
		if (accountLocaleEntity == null)
		{
			return null;
		}
		ISupportedLocale supportedLocale = _SupportedLocaleAndLanguageMapper.MapSupportedLocale(accountLocaleEntity);
		ILanguageFamily language = _SupportedLocaleAndLanguageMapper.MapLangauge(accountLocaleEntity);
		return new Roblox.Platform.Localization.Accounts.Implementations.AccountLocale
		{
			AccountId = accountLocaleEntity.AccountId,
			NativeLanguage = language,
			SupportedLocale = supportedLocale
		};
	}

	public bool IsPreferredLocaleExplicitlySet(IUser user)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("user");
		}
		return _AccountLocaleEntityFactory.GetByAccountId(user.AccountId)?.SupportedLocaleId.HasValue ?? false;
	}

	public TranslationResourceState GetTranslationResourcesState(IUser user)
	{
		return TranslationResourceState.Standard;
	}
}
