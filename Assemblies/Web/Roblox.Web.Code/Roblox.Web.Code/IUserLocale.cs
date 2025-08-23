using Roblox.Platform.Localization.Core;
using Roblox.Platform.Membership;

namespace Roblox.Web.Code;

public interface IUserLocale
{
	/// <summary>
	/// User can be null. If null, ISupportedLocale &amp; ILanguage will retrieved from http request object
	/// </summary>
	IUser User { get; set; }

	/// <summary>
	/// Supported locale
	/// </summary>
	ISupportedLocale SupportedLocale { get; set; }

	/// <summary>
	/// Native Language
	/// </summary>
	ILanguageFamily Language { get; set; }
}
