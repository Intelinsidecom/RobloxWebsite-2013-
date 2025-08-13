using Roblox.Platform.Localization.Accounts;
using Roblox.Platform.Localization.Core;
using Roblox.Platform.Membership;

namespace Roblox.Web.Code;

internal class UserLocale : IUserLocale
{
	public IUser User { get; set; }

	public ISupportedLocale SupportedLocale { get; set; }

	public ILanguageFamily Language { get; set; }

	public UserLocale(IUser user, IAccountLocale accountLocale)
	{
		User = user;
		SupportedLocale = accountLocale.SupportedLocale;
		Language = accountLocale.NativeLanguage;
	}

	public UserLocale(IUser user, IDeviceReportedLocale deviceReportedLocale)
	{
		User = user;
		SupportedLocale = deviceReportedLocale.SupportedLocale;
		Language = deviceReportedLocale.LanguageFamily;
	}

	public UserLocale(IUser user, ISupportedLocale supportedLocale)
	{
		User = user;
		SupportedLocale = supportedLocale;
		Language = supportedLocale.Language;
	}
}
