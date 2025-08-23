using Roblox.Platform.Core;

namespace Roblox.Web.Code;

internal class LocalizationLocusUserLocales : ILocalizationLocusUserLocales
{
	public IUserLocale GeneralExperienceLocale { get; }

	public IUserLocale SignupAndLoginLocale { get; }

	public IUserLocale UgcLocale { get; }

	public LocalizationLocusUserLocales(IUserLocale generalExperienceLocale, IUserLocale signupAndLoginLocale, IUserLocale ugcLocale)
	{
		GeneralExperienceLocale = generalExperienceLocale.AssignOrThrowIfNull("generalExperienceLocale");
		SignupAndLoginLocale = signupAndLoginLocale.AssignOrThrowIfNull("signupAndLoginLocale");
		UgcLocale = ugcLocale.AssignOrThrowIfNull("ugcLocale");
	}
}
