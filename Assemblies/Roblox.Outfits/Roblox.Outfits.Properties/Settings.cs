extern alias ConfMan;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using ConfMan::System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.Outfits.Properties;

/// <summary>
/// Configuration that uses Roblox.Configuration.Provider
/// </summary>
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
[ConfMan::System.Configuration.SettingsProvider(typeof(Provider))]
internal sealed class Settings : ConfMan::System.Configuration.ApplicationSettingsBase
{
    private static Settings defaultInstance = (Settings)ConfMan::System.Configuration.SettingsBase.Synchronized(new Settings());

    private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

    public static Settings Default => defaultInstance;

    [ConfMan::System.Configuration.ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [ConfMan::System.Configuration.SpecialSetting(ConfMan::System.Configuration.SpecialSetting.ConnectionString)]
    public string RobloxOutfits => (string)this["RobloxOutfits"];

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
