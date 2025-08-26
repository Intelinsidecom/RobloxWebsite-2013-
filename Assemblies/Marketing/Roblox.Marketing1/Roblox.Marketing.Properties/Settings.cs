namespace extern {
    alias ConfMan;

using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using ConfMan::System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Roblox.Caching;
using Roblox.Configuration;

namespace Roblox.Marketing.Properties;

/// <summary>
/// Configuration that uses Roblox.Configuration.Provider
/// </summary>
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
[ConfMan::System.Configuration.SettingsProvider(typeof(Provider))]
public sealed class Settings : ConfMan::System.Configuration.ApplicationSettingsBase
{
    private static Settings defaultInstance = (Settings)ConfMan::System.Configuration.SettingsBase.Synchronized(new Settings());

    private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

    public static Settings Default => defaultInstance;

    [ConfMan::System.Configuration.ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [ConfMan::System.Configuration.DefaultSettingValue("True")]
    public bool TrackingBrowserIdentityEnabled => (bool)this["TrackingBrowserIdentityEnabled"];

    [ConfMan::System.Configuration.ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [ConfMan::System.Configuration.SpecialSetting(ConfMan::System.Configuration.SpecialSetting.ConnectionString)]
    public string RobloxMarketing => (string)this["RobloxMarketing"];

    [ConfMan::System.Configuration.ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [ConfMan::System.Configuration.DefaultSettingValue("")]
    public string TrafficRoutingFreeURL => (string)this["TrafficRoutingFreeURL"];

    [ConfMan::System.Configuration.ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [ConfMan::System.Configuration.DefaultSettingValue("")]
    public string TrafficRoutingPaidGoogleURL => (string)this["TrafficRoutingPaidGoogleURL"];

    [ConfMan::System.Configuration.ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [ConfMan::System.Configuration.DefaultSettingValue("")]
    public string TrafficRoutingPaidAddictingGamesURL => (string)this["TrafficRoutingPaidAddictingGamesURL"];

    [ConfMan::System.Configuration.ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [ConfMan::System.Configuration.DefaultSettingValue("")]
    public string TrafficRoutingPaidShizmooURL => (string)this["TrafficRoutingPaidShizmooURL"];

    [ConfMan::System.Configuration.ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [ConfMan::System.Configuration.DefaultSettingValue("")]
    public string TrafficRoutingPaidDefaultURL => (string)this["TrafficRoutingPaidDefaultURL"];

    [ConfMan::System.Configuration.ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [ConfMan::System.Configuration.DefaultSettingValue("False")]
    public bool TrafficRoutingEnabled => (bool)this["TrafficRoutingEnabled"];

    [ConfMan::System.Configuration.ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [ConfMan::System.Configuration.DefaultSettingValue("False")]
    public bool UseCrawlerRegex => (bool)this["UseCrawlerRegex"];

    [ConfMan::System.Configuration.ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [ConfMan::System.Configuration.DefaultSettingValue("")]
    public string TrafficRoutingPaidSeccoURL => (string)this["TrafficRoutingPaidSeccoURL"];

    [ConfMan::System.Configuration.ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [ConfMan::System.Configuration.DefaultSettingValue("roblox.com")]
    public string BrowserTrackerCookie_DomainSuffix => (string)this["BrowserTrackerCookie_DomainSuffix"];

    [ConfMan::System.Configuration.ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [ConfMan::System.Configuration.DefaultSettingValue("False")]
    public bool UseSourceCookieForRBXSource => (bool)this["UseSourceCookieForRBXSource"];

    [ConfMan::System.Configuration.ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [ConfMan::System.Configuration.DefaultSettingValue("False")]
    public bool RBXMarketingCookieSetsDomain => (bool)this["RBXMarketingCookieSetsDomain"];

    [ConfMan::System.Configuration.ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [ConfMan::System.Configuration.DefaultSettingValue("0")]
    public float BrowserTrackerDebugDumpingPercentage => (float)this["BrowserTrackerDebugDumpingPercentage"];

    [ConfMan::System.Configuration.ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [ConfMan::System.Configuration.DefaultSettingValue("0")]
    public int DeleteBrowserTrackerV1Percentage => (int)this["DeleteBrowserTrackerV1Percentage"];

    [ConfMan::System.Configuration.ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [ConfMan::System.Configuration.DefaultSettingValue("")]
    public string MemcachedGroupName => (string)this["MemcachedGroupName"];

    [ConfMan::System.Configuration.ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [ConfMan::System.Configuration.DefaultSettingValue("")]
    public string MemcachedMigrationGroupName => (string)this["MemcachedMigrationGroupName"];

    [ConfMan::System.Configuration.ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [ConfMan::System.Configuration.DefaultSettingValue("NoMigration,NoMigration,0")]
    public MigrationStateChange MemcachedMigrationState => (MigrationStateChange)this["MemcachedMigrationState"];

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

    internal Settings()
    {
        base.PropertyChanged += delegate(object sender, PropertyChangedEventArgs propertyChangeEvent)
        {
            _Properties.TryRemove(propertyChangeEvent.PropertyName, out var _);
        };
    }

    protected override void OnSettingsLoaded(object sender, ConfMan::System.Configuration.SettingsLoadedEventArgs e)
    {
        base.OnSettingsLoaded(sender, e);
        Provider.RegisterSettings(e, this);
    }

    private void UpdateProperty(object sender, PropertyChangedEventArgs propertyChangeEvent)
    {
        _Properties.TryRemove(propertyChangeEvent.PropertyName, out var _);
    }
}


