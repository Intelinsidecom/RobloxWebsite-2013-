using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Roblox.Configuration.Properties;

[SettingsProvider(typeof(Provider))]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.8.0.0")]
internal sealed class EnvironmentSettings : ApplicationSettingsBase
{
	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	private static EnvironmentSettings defaultInstance = (EnvironmentSettings)(object)SettingsBase.Synchronized((SettingsBase)(object)new EnvironmentSettings());

	public override object this[string propertyName]
	{
		get
		{
			// Use base[...] to avoid virtual dispatch back into this override which caused a StackOverflowException
			return _Properties.GetOrAdd(propertyName, (string propName) => base[propName]);
		}
		set
		{
			// Set via base to avoid recursive call into this override
			base[propertyName] = value;
		}
	}

	public static EnvironmentSettings Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string EnvironmentAbbreviation => (string)base["EnvironmentAbbreviation"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string EnvironmentName => (string)base["EnvironmentName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	public int EnvironmentId => (int)base["EnvironmentId"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string ApplicationDomain => (string)base["ApplicationDomain"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string InternalServicesProtocol => (string)base["InternalServicesProtocol"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string CdnDomain => (string)base["CdnDomain"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("chat")]
	public string ChatApiPrefix => (string)base["ChatApiPrefix"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("locale")]
	public string LocaleApiPrefix => (string)base["LocaleApiPrefix"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("friendsite")]
	public string FriendsAppSitePrefix => (string)base["FriendsAppSitePrefix"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("translations")]
	public string TranslationsApiSitePrefix => (string)base["TranslationsApiSitePrefix"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("abtesting")]
	public string AbTestingApiPrefix => (string)base["AbTestingApiPrefix"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("authsite")]
	public string AuthAppSitePrefix => (string)base["AuthAppSitePrefix"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("gameinternationalization")]
	public string GameInternationalizationApiSitePrefix => (string)base["GameInternationalizationApiSitePrefix"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string InternalServicesDomain => (string)base["InternalServicesDomain"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string ChinaBaseDomain => (string)base["ChinaBaseDomain"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("translationroles")]
	public string TranslationRolesApiSitePrefix => (string)base["TranslationRolesApiSitePrefix"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("metrics")]
	public string MetricsApiSiteSubdomain => (string)base["MetricsApiSiteSubdomain"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("contacts")]
	public string ContactsApiSitePrefix => (string)base["ContactsApiSitePrefix"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("midas")]
	public string MidasApiPrefix => (string)base["MidasApiPrefix"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("discussions")]
	public string DiscussionsApiPrefix => (string)base["DiscussionsApiPrefix"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("rbxcdn.qq.com")]
	public string ChinaCdnDomain => (string)base["ChinaCdnDomain"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("localizationtables")]
	public string LocalizationTablesApiPrefix => (string)base["LocalizationTablesApiPrefix"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("itemconfiguration")]
	public string ItemConfigurationApiSitePrefix => (string)base["ItemConfigurationApiSitePrefix"];

	internal EnvironmentSettings()
	{
		((ApplicationSettingsBase)this).PropertyChanged += delegate(object sender, PropertyChangedEventArgs propertyChangeEvent)
		{
			_Properties.TryRemove(propertyChangeEvent.PropertyName, out var _);
		};
	}

	protected override void OnSettingsLoaded(object sender, SettingsLoadedEventArgs e)
	{
		base.OnSettingsLoaded(sender, e);
		Provider.RegisterSettings(e, (ApplicationSettingsBase)(object)this);
	}

	private void UpdateProperty(object sender, PropertyChangedEventArgs propertyChangeEvent)
	{
		_Properties.TryRemove(propertyChangeEvent.PropertyName, out var _);
	}
}
