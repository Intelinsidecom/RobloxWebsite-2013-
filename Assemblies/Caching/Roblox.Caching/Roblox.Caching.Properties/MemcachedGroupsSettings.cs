using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.Caching.Properties;

[SettingsProvider(typeof(Provider))]
[ExcludeFromCodeCoverage]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.3.0.0")]
internal sealed class MemcachedGroupsSettings : ApplicationSettingsBase
{
	private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

	private static MemcachedGroupsSettings defaultInstance = (MemcachedGroupsSettings)(object)SettingsBase.Synchronized((SettingsBase)(object)new MemcachedGroupsSettings());

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

	public static MemcachedGroupsSettings Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string FriendsGroup => (string)((SettingsBase)this)["FriendsGroup"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string UniversesServiceCacheGroup => (string)((SettingsBase)this)["UniversesServiceCacheGroup"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string UniversesClientReadCacheGroup => (string)((SettingsBase)this)["UniversesClientReadCacheGroup"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string PresenceServiceCacheGroup => (string)((SettingsBase)this)["PresenceServiceCacheGroup"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string ThumbnailsMcrouterGroup => (string)((SettingsBase)this)["ThumbnailsMcrouterGroup"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string OwnershipServiceMcrouterCacheGroup => (string)((SettingsBase)this)["OwnershipServiceMcrouterCacheGroup"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string FriendsMcrouterGroup => (string)((SettingsBase)this)["FriendsMcrouterGroup"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string GroupsServiceMcrouterCacheGroup => (string)((SettingsBase)this)["GroupsServiceMcrouterCacheGroup"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string UniversesClientReadMcrouterCacheGroup => (string)((SettingsBase)this)["UniversesClientReadMcrouterCacheGroup"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string UniversesServiceMcrouterCacheGroup => (string)((SettingsBase)this)["UniversesServiceMcrouterCacheGroup"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MemcachedWebMcrouterCacheGroup => (string)((SettingsBase)this)["MemcachedWebMcrouterCacheGroup"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MemcachedObjectMcrouterCacheGroup => (string)((SettingsBase)this)["MemcachedObjectMcrouterCacheGroup"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string UserMcrouterCacheGroup => (string)((SettingsBase)this)["UserMcrouterCacheGroup"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string ThumbnailsExperimentalGroup => (string)((SettingsBase)this)["ThumbnailsExperimentalGroup"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string DemographicsMcrouterGroup => (string)((SettingsBase)this)["DemographicsMcrouterGroup"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MarketingMcrouterGroup => (string)((SettingsBase)this)["MarketingMcrouterGroup"];

	internal MemcachedGroupsSettings()
	{
		((ApplicationSettingsBase)this).PropertyChanged += delegate(object sender, PropertyChangedEventArgs args)
		{
			_Properties.TryRemove(args.PropertyName, out var _);
		};
	}

	protected override void OnSettingsLoaded(object sender, SettingsLoadedEventArgs e)
	{
		((ApplicationSettingsBase)this).OnSettingsLoaded(sender, e);
		Provider.RegisterSettings(e, (ApplicationSettingsBase)(object)this);
	}
}
