using Roblox.Platform.Localization.Core;

namespace Roblox.Platform.Localization.Accounts;

public interface IAccountLocaleBuilder
{
	/// <summary>
	/// Fires when a user's supported locale is changed.
	/// </summary>
	event SupportedLocaleChangedByUserEventHandler SupportedLocaleChangedByUser;

	/// <summary>
	/// Sets the <see cref="T:Roblox.Platform.Localization.Accounts.IAccountLocale" /> entity's supported locale for given account id. Call this method only when user explicitly sets/chooses supported locale
	/// </summary>
	/// <param name="accountId">Account id of user.</param>
	/// <param name="supportedLocale">Supported locale that needs to be set for given account id. Supported locale id must be in valid list of supported locale ids.</param>
	/// <param name="changeAgent">The <see cref="T:Roblox.Platform.Localization.Accounts.IAccountLocalesChangeAgent" /> changing the supported locale.</param>
	void SetSupportedLocale(long accountId, ISupportedLocale supportedLocale, IAccountLocalesChangeAgent changeAgent);

	/// <summary>
	/// Sets the <see cref="T:Roblox.Platform.Localization.Accounts.IAccountLocale" /> entity's observed locale for given accountId based on passed in <see cref="T:Roblox.Platform.Localization.Core.IDeviceReportedLocaleIdentifier" />.
	/// </summary>
	/// <param name="accountId">The account id.</param>
	/// <param name="deviceReportedLocale">The <see cref="T:Roblox.Platform.Localization.Core.IDeviceReportedLocale" /> retrieved from request object</param>
	/// <param name="changeAgent">The <see cref="T:Roblox.Platform.Localization.Accounts.IAccountLocalesChangeAgent" />.</param>
	void SetObservedLocale(long accountId, IDeviceReportedLocaleIdentifier deviceReportedLocale, IAccountLocalesChangeAgent changeAgent);

	/// <summary>
	/// Creates a new account locale. If entity already presents, throws DuplicateKeyException.
	/// </summary>
	/// <param name="accountId">Account id of user.</param>
	/// <param name="deviceReportedLocale">Locale as reported by the device the user is currently using to access Roblox. Cannot be null.</param>
	/// <param name="supportedLocale">Supported locale associated with account id. Can be null</param>
	/// <param name="changeAgent">The change agent.</param>
	/// <returns>
	///   <see cref="T:Roblox.Platform.Localization.Accounts.IAccountLocale" /> with give account id and supported locale.
	/// </returns>
	IAccountLocale CreateAccountLocale(long accountId, IDeviceReportedLocaleIdentifier deviceReportedLocale, ISupportedLocale supportedLocale, IAccountLocalesChangeAgent changeAgent);
}
