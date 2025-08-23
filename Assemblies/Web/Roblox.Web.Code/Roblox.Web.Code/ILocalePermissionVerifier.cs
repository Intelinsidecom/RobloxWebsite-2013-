using System.Collections.Generic;
using Roblox.Platform.Localization.Core;
using Roblox.Platform.Membership;

namespace Roblox.Web.Code;

internal interface ILocalePermissionVerifier
{
	bool IsUserLocaleEnabledForFullExperience(IUser user, ISupportedLocale supportedLocale, string userAgent);

	bool IsUserLocaleEnabledForSignupAndLogin(ISupportedLocale supportedLocale, string userAgent);

	bool IsUserLocaleEnabledForUgc(IUser user, ISupportedLocale supportedLocale);

	IReadOnlyCollection<ISupportedLocale> WhiteListSupportedLocalesForFullExperience(IUser user, IReadOnlyCollection<ISupportedLocale> supportedLocales, string userAgent);

	IReadOnlyCollection<ISupportedLocaleLocus> ApplyLocusOnSupportedLocales(IUser user, IReadOnlyCollection<ISupportedLocale> allLocales, string userAgent, bool isSortedByFullExperience = false);

	bool IsResetOfSupportedLocaleAllowed();
}
