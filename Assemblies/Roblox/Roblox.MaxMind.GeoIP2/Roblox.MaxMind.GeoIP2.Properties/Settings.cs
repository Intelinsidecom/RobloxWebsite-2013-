extern alias ConfMan;
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using ConfMan::System.Configuration;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.MaxMind.GeoIP2.Properties;

/// <summary>
/// Configuration that uses Roblox.Configuration.Provider
/// </summary>
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.6.0.0")]
[ConfMan::System.Configuration.SettingsProvider(typeof(Provider))]
[ExcludeFromCodeCoverage]
internal sealed class Settings : ConfMan::System.Configuration.ApplicationSettingsBase, IMaxMindSettings
{
    private static Settings defaultInstance = (Settings)ConfMan::System.Configuration.SettingsBase.Synchronized(new Settings());

    private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

    public static Settings Default => defaultInstance;

    [ConfMan::System.Configuration.ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [ConfMan::System.Configuration.DefaultSettingValue("https://geoip.maxmind.com/geoip/v2.0")]
    public string GeoIP2ServiceEndpoint => (string)this["GeoIP2ServiceEndpoint"];

    [ConfMan::System.Configuration.ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [ConfMan::System.Configuration.DefaultSettingValue("00:00:05")]
    public TimeSpan GeoIP2WebClientTimeout => (TimeSpan)this["GeoIP2WebClientTimeout"];

    [ConfMan::System.Configuration.ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [ConfMan::System.Configuration.DefaultSettingValue("86444")]
    public string GeoIP2Username => (string)this["GeoIP2Username"];

    [ConfMan::System.Configuration.ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [ConfMan::System.Configuration.DefaultSettingValue("KHnYEfOonxSV")]
    public string GeoIP2Password => (string)this["GeoIP2Password"];

    [ConfMan::System.Configuration.ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [ConfMan::System.Configuration.DefaultSettingValue("00:00:02")]
    public TimeSpan GeoIP2CircuitBreakerRetryInterval => (TimeSpan)this["GeoIP2CircuitBreakerRetryInterval"];

    [ConfMan::System.Configuration.ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [ConfMan::System.Configuration.DefaultSettingValue("False")]
    public bool EnableDetailedErrorLogging => (bool)this["EnableDetailedErrorLogging"];

    [ConfMan::System.Configuration.ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [ConfMan::System.Configuration.DefaultSettingValue("False")]
    public bool UseDirectHttpBasicAuthHeader => (bool)this["UseDirectHttpBasicAuthHeader"];

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
        base.PropertyChanged += delegate(object sender, PropertyChangedEventArgs args)
        {
            _Properties.TryRemove(args.PropertyName, out var _);
        };
    }

    protected override void OnSettingsLoaded(object sender, ConfMan::System.Configuration.SettingsLoadedEventArgs e)
    {
        base.OnSettingsLoaded(sender, e);
        Provider.RegisterSettings(e, this);
    }
}
