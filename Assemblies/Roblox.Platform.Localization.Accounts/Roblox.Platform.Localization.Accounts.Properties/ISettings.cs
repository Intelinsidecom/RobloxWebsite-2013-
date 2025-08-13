using System;

namespace Roblox.Platform.Localization.Accounts.Properties;

internal interface ISettings
{
	int AccountLocaleUpdateUserIdFloodCheckerLimit { get; }

	TimeSpan AccountLocaleUpdateUserIdFloodCheckerExpiry { get; }

	bool IsCountryChangedEventEnabled { get; }

	bool IsSupportedLocaleChangedEventEnabled { get; }

	int AccountLocaleUpdateForObservedLocaleFloodCheckerLimit { get; }

	TimeSpan AccountLocaleUpdateForObservedLocaleFloodCheckerExpiry { get; }

	byte AccountCountriesAuditCompositeEntryCountLimit { get; }

	bool IsAccountCountriesTableAuditingEnabled { get; }

	bool IsAccountLocalesTableAuditingEnabled { get; }

	byte AccountLocalesAuditCompositeEntryCountLimit { get; }

	bool IsRemoveUnneededLocaleMappingLogicEnabled { get; }

	int AccountCountryUpdateForUserFloodCheckerLimit { get; }

	TimeSpan AccountCountryUpdateForUserFloodCheckerExpiry { get; }
}
