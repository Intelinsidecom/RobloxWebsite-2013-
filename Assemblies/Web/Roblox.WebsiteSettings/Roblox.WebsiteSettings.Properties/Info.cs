using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.WebsiteSettings.Properties;

/// <summary>
/// Configuration that uses Roblox.Configuration.Provider
/// </summary>
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
[SettingsProvider(typeof(Provider))]
public sealed class Info : ApplicationSettingsBase, IInfoSettings
{
	private static Info defaultInstance = (Info)SettingsBase.Synchronized(new Info());

	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	public static Info Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string RedirectTermsToHelpFullUrl => (string)this["RedirectTermsToHelpFullUrl"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsSupportPageEnabled => (bool)this["IsSupportPageEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string RedirectSupportToHelpFullUrl => (string)this["RedirectSupportToHelpFullUrl"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsSupportPageEnabledForSoothsayer => (bool)this["IsSupportPageEnabledForSoothsayer"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string RedirectLatestChangesToHelpFullUrl => (string)this["RedirectLatestChangesToHelpFullUrl"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsLicensingTermsPopupDisabled => (bool)this["IsLicensingTermsPopupDisabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://en.help.roblox.com/hc/en-us")]
	public string ZendeskSupportPageURLEnglish => (string)this["ZendeskSupportPageURLEnglish"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://en.help.roblox.com/hc/es")]
	public string ZendeskSupportPageURLSpanish => (string)this["ZendeskSupportPageURLSpanish"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://en.help.roblox.com/hc/en-us/articles/203552894-General-Roblox-Studio-Issues")]
	public string RobloxStudioHelpUrl => (string)this["RobloxStudioHelpUrl"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://en.help.roblox.com/hc/en-us/articles/212459863")]
	public string ZendeskTwoStepVerificationUrl => (string)this["ZendeskTwoStepVerificationUrl"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://www.amazon.com/roblox?&_encoding=UTF8&tag=r05d13-20&linkCode=ur2&linkId=4ba2e1ad82f781c8e8cc98329b1066d0&camp=1789&creative=9325")]
	public string AmazonStoreUrl => (string)this["AmazonStoreUrl"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://en.help.roblox.com/hc/en-us/articles/115004647846-Roblox-Terms-of-Use")]
	public string TermsHelpPageUrlEnglish => (string)this["TermsHelpPageUrlEnglish"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://en.help.roblox.com/hc/es/articles/115004647846-T%C3%A9rminos-de-uso-de-Roblox")]
	public string TermsHelpPageUrlSpanish => (string)this["TermsHelpPageUrlSpanish"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://en.help.roblox.com/hc/en-us/articles/115004630823-Roblox-Privacy-and-Cookie-Policy-")]
	public string PrivacyHelpPageUrlEnglish => (string)this["PrivacyHelpPageUrlEnglish"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://en.help.roblox.com/hc/es/articles/115004630823-Pol%C3%ADtica-de-privacidad-y-de-cookies-de-Roblox")]
	public string PrivacyHelpPageUrlSpanish => (string)this["PrivacyHelpPageUrlSpanish"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://www.roblox.com/support")]
	public string RobloxSupportPageUrl => (string)this["RobloxSupportPageUrl"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://help.xsolla.com")]
	public string XsollaSupportPageUrl => (string)this["XsollaSupportPageUrl"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("[en_us]https://corp.roblox.com/")]
	public string AboutUsPageUrlMappingCsv => (string)this["AboutUsPageUrlMappingCsv"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://corp.roblox.com/")]
	public string AboutUsPageUrlDefault => (string)this["AboutUsPageUrlDefault"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("[en_us]https://corp.roblox.com/careers/")]
	public string JobsPageUrlMappingCsv => (string)this["JobsPageUrlMappingCsv"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://corp.roblox.com/careers/")]
	public string JobsPageUrlDefault => (string)this["JobsPageUrlDefault"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("[en_us]https://blog.roblox.com/")]
	public string BlogPageUrlMappingCsv => (string)this["BlogPageUrlMappingCsv"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://blog.roblox.com/")]
	public string BlogPageUrlDefault => (string)this["BlogPageUrlDefault"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("[en_us]http://corp.roblox.com/parents")]
	public string ParentsPageUrlMappingCsv => (string)this["ParentsPageUrlMappingCsv"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("http://corp.roblox.com/parents")]
	public string ParentsPageUrlDefault => (string)this["ParentsPageUrlDefault"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("[en_us]https://en.help.roblox.com/hc/en-us")]
	public string HelpPageUrlMappingCsv => (string)this["HelpPageUrlMappingCsv"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://en.help.roblox.com/hc/en-us")]
	public string HelpPageUrlDefault => (string)this["HelpPageUrlDefault"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("[en_us]https://en.help.roblox.com/hc/en-us/articles/115004647846-Roblox-Terms-of-Use")]
	public string TermsPageUrlMappingCsv => (string)this["TermsPageUrlMappingCsv"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://en.help.roblox.com/hc/en-us/articles/115004647846-Roblox-Terms-of-Use")]
	public string TermsPageUrlDefault => (string)this["TermsPageUrlDefault"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("[en_us]https://en.help.roblox.com/hc/en-us/articles/115004630823-Roblox-Privacy-and-Cookie-Policy-")]
	public string PrivacyPageUrlMappingCsv => (string)this["PrivacyPageUrlMappingCsv"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://en.help.roblox.com/hc/en-us/articles/115004630823-Roblox-Privacy-and-Cookie-Policy-")]
	public string PrivacyPageUrlDefault => (string)this["PrivacyPageUrlDefault"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("[en_us]https://en.help.roblox.com/hc/en-us/sections/200866010-Roblox-Rules-and-Guidelines")]
	public string CommunityGuidelinesPageUrlMappingCsv => (string)this["CommunityGuidelinesPageUrlMappingCsv"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://en.help.roblox.com/hc/en-us/sections/200866010-Roblox-Rules-and-Guidelines")]
	public string CommunityGuidelinesPageUrlDefault => (string)this["CommunityGuidelinesPageUrlDefault"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("[en_us]https://en.help.roblox.com/hc/en-us/articles/203313310-Trading-System")]
	public string TradingPageUrlMappingCsv => (string)this["TradingPageUrlMappingCsv"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://en.help.roblox.com/hc/en-us/articles/203313310-Trading-System")]
	public string TradingPageUrlDefault => (string)this["TradingPageUrlDefault"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("[en_us]https://en.help.roblox.com/hc/en-us/articles/203313380-Account-Security-Theft-Keeping-your-Account-Safe-")]
	public string AccountSafetyPageUrlMappingCsv => (string)this["AccountSafetyPageUrlMappingCsv"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://en.help.roblox.com/hc/en-us/articles/203313380-Account-Security-Theft-Keeping-your-Account-Safe-")]
	public string AccountSafetyPageUrlDefault => (string)this["AccountSafetyPageUrlDefault"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("[en_us]https://en.help.roblox.com/hc/en-us/articles/203314070-Places-and-Building-Audio-Files")]
	public string AudioFilesPageUrlMappingCsv => (string)this["AudioFilesPageUrlMappingCsv"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://en.help.roblox.com/hc/en-us/articles/203314070-Places-and-Building-Audio-Files")]
	public string AudioFilesPageUrlDefault => (string)this["AudioFilesPageUrlDefault"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("[en_us]https://en.help.roblox.com/hc/en-us/articles/212459863")]
	public string TwoStepVerificationPageUrlMappingCsv => (string)this["TwoStepVerificationPageUrlMappingCsv"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://en.help.roblox.com/hc/en-us/articles/212459863")]
	public string TwoStepVerificationPageUrlDefault => (string)this["TwoStepVerificationPageUrlDefault"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("[en_us]https://en.help.roblox.com/hc/en-us/articles/205345050-How-do-I-Purchase-and-Configure-VIP-Servers-")]
	public string VIPServerHelpPageUrlMappingCsv => (string)this["VIPServerHelpPageUrlMappingCsv"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("https://en.help.roblox.com/hc/en-us/articles/205345050-How-do-I-Purchase-and-Configure-VIP-Servers-")]
	public string VIPServerHelpPageUrlDefault => (string)this["VIPServerHelpPageUrlDefault"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsInbentaProdSupportEnabled => (bool)this["IsInbentaProdSupportEnabled"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool IsInbentaPreProdSupportEnabled => (bool)this["IsInbentaPreProdSupportEnabled"];

	public override object this[string propertyName]
	{
		get
		{
			return _Properties.GetOrAdd(propertyName, (string propName) => base[propName]);
		}
		set
		{
			base[propertyName] = value;
		}
	}

	internal Info()
	{
		base.PropertyChanged += delegate(object sender, PropertyChangedEventArgs propertyChangeEvent)
		{
			_Properties.TryRemove(propertyChangeEvent.PropertyName, out var _);
		};
	}

	protected override void OnSettingsLoaded(object sender, SettingsLoadedEventArgs e)
	{
		base.OnSettingsLoaded(sender, e);
		Provider.RegisterSettings(e, this);
	}

	private void UpdateProperty(object sender, PropertyChangedEventArgs propertyChangeEvent)
	{
		_Properties.TryRemove(propertyChangeEvent.PropertyName, out var _);
	}
}
