namespace Roblox.Platform.Localization.Accounts;

/// <summary>
/// The type of automation that contributed to the change of AccountLocale. For use with <see cref="T:Roblox.Platform.Localization.Accounts.AccountLocalesChangeAgent" />.Automation.
/// </summary>
public enum AccountLocalesAutomationType : byte
{
	Backfill,
	DeviceLocaleUpdate,
	LocaleCreation,
	TestApi
}
