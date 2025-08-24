namespace Roblox.Platform.Localization.Accounts;

/// <summary>
/// An enum for describing the contents that were changed in an AccountLocale audit log.
/// </summary>
public enum AccountLocalesAuditEntryMetadataType : byte
{
	ObservedLocaleSetOrChanged,
	SupportedLocaleSetOrChanged
}
