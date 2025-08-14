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
			return _Properties.GetOrAdd(propertyName, (string propName) => base[propertyName]);
		}
		set
		{
			base[propertyName] = value;
		}
	}

	public static MemcachedGroupsSettings Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string FriendsGroup => (string)base["FriendsGroup"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string UniversesServiceCacheGroup => (string)base["UniversesServiceCacheGroup"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string UniversesClientReadCacheGroup => (string)base["UniversesClientReadCacheGroup"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string PresenceServiceCacheGroup => (string)base["PresenceServiceCacheGroup"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string ThumbnailsMcrouterGroup => (string)base["ThumbnailsMcrouterGroup"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string OwnershipServiceMcrouterCacheGroup => (string)base["OwnershipServiceMcrouterCacheGroup"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string FriendsMcrouterGroup => (string)base["FriendsMcrouterGroup"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string GroupsServiceMcrouterCacheGroup => (string)base["GroupsServiceMcrouterCacheGroup"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string UniversesClientReadMcrouterCacheGroup => (string)base["UniversesClientReadMcrouterCacheGroup"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string UniversesServiceMcrouterCacheGroup => (string)base["UniversesServiceMcrouterCacheGroup"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MemcachedWebMcrouterCacheGroup => (string)base["MemcachedWebMcrouterCacheGroup"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MemcachedObjectMcrouterCacheGroup => (string)base["MemcachedObjectMcrouterCacheGroup"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string UserMcrouterCacheGroup => (string)base["UserMcrouterCacheGroup"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string ThumbnailsExperimentalGroup => (string)base["ThumbnailsExperimentalGroup"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string DemographicsMcrouterGroup => (string)base["DemographicsMcrouterGroup"];

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MarketingMcrouterGroup => (string)base["MarketingMcrouterGroup"];

	internal MemcachedGroupsSettings()
	{
		base.PropertyChanged += delegate(object sender, PropertyChangedEventArgs args)
		{
			_Properties.TryRemove(args.PropertyName, out var _);
		};
	}

	protected override void OnSettingsLoaded(object sender, SettingsLoadedEventArgs e)
	{
		base.OnSettingsLoaded(sender, e);
		Provider.RegisterSettings(e, this);
	}
}
