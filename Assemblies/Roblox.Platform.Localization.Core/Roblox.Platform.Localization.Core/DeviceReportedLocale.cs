namespace Roblox.Platform.Localization.Core;

internal class DeviceReportedLocale : IDeviceReportedLocale
{
	public IDeviceReportedLocaleIdentifier DeviceReportedLocaleId { get; set; }

	public string StandardizedLocale { get; set; }

	public ILanguageFamily LanguageFamily { get; set; }

	public ISupportedLocale SupportedLocale { get; set; }
}
