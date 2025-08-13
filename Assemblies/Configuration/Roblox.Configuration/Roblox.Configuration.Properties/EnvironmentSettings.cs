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
			return _Properties.GetOrAdd(propertyName, (string propName) => ((ApplicationSettingsBase)this)[propName]);
		}
		set
		{
			((ApplicationSettingsBase)this)[propertyName] = value;
		}
	}

	public static EnvironmentSettings Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string EnvironmentAbbreviation => (string)((SettingsBase)this)["EnvironmentAbbreviation"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string EnvironmentName => (string)((SettingsBase)this)["EnvironmentName"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	public int EnvironmentId => (int)((SettingsBase)this)["EnvironmentId"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string ApplicationDomain => (string)((SettingsBase)this)["ApplicationDomain"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string InternalServicesProtocol => (string)((SettingsBase)this)["InternalServicesProtocol"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string CdnDomain => (string)((SettingsBase)this)["CdnDomain"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("chat")]
	public string ChatApiPrefix => (string)((SettingsBase)this)["ChatApiPrefix"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("locale")]
	public string LocaleApiPrefix => (string)((SettingsBase)this)["LocaleApiPrefix"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("friendsite")]
	public string FriendsAppSitePrefix => (string)((SettingsBase)this)["FriendsAppSitePrefix"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("translations")]
	public string TranslationsApiSitePrefix => (string)((SettingsBase)this)["TranslationsApiSitePrefix"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("abtesting")]
	public string AbTestingApiPrefix => (string)((SettingsBase)this)["AbTestingApiPrefix"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("authsite")]
	public string AuthAppSitePrefix => (string)((SettingsBase)this)["AuthAppSitePrefix"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("gameinternationalization")]
	public string GameInternationalizationApiSitePrefix => (string)((SettingsBase)this)["GameInternationalizationApiSitePrefix"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string InternalServicesDomain => (string)((SettingsBase)this)["InternalServicesDomain"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string ChinaBaseDomain => (string)((SettingsBase)this)["ChinaBaseDomain"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("translationroles")]
	public string TranslationRolesApiSitePrefix => (string)((SettingsBase)this)["TranslationRolesApiSitePrefix"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("metrics")]
	public string MetricsApiSiteSubdomain => (string)((SettingsBase)this)["MetricsApiSiteSubdomain"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("contacts")]
	public string ContactsApiSitePrefix => (string)((SettingsBase)this)["ContactsApiSitePrefix"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("midas")]
	public string MidasApiPrefix => (string)((SettingsBase)this)["MidasApiPrefix"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("discussions")]
	public string DiscussionsApiPrefix => (string)((SettingsBase)this)["DiscussionsApiPrefix"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("rbxcdn.qq.com")]
	public string ChinaCdnDomain => (string)((SettingsBase)this)["ChinaCdnDomain"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("localizationtables")]
	public string LocalizationTablesApiPrefix => (string)((SettingsBase)this)["LocalizationTablesApiPrefix"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("itemconfiguration")]
	public string ItemConfigurationApiSitePrefix => (string)((SettingsBase)this)["ItemConfigurationApiSitePrefix"];

	internal EnvironmentSettings()
	{
		((ApplicationSettingsBase)this).PropertyChanged += delegate(object sender, PropertyChangedEventArgs propertyChangeEvent)
		{
			_Properties.TryRemove(propertyChangeEvent.PropertyName, out var _);
		};
	}

	protected override void OnSettingsLoaded(object sender, SettingsLoadedEventArgs e)
	{
		((ApplicationSettingsBase)this).OnSettingsLoaded(sender, e);
		Provider.RegisterSettings(e, (ApplicationSettingsBase)(object)this);
	}

	private void UpdateProperty(object sender, PropertyChangedEventArgs propertyChangeEvent)
	{
		_Properties.TryRemove(propertyChangeEvent.PropertyName, out var _);
	}
}
