using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Roblox.Configuration;

namespace Roblox.FloodCheckers.Properties
{
    /// <summary>
    /// Configuration that uses Roblox.Configuration.Provider
    /// </summary>
    [SettingsProvider(typeof(Provider))]
    [CompilerGenerated]
    [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed class Settings : ApplicationSettingsBase
    {
        private readonly ConcurrentDictionary<string, object> _Properties = new ConcurrentDictionary<string, object>();

        private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());

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

        public static Settings Default => defaultInstance;

        [ApplicationScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("False")]
        public bool AccountCreationWithIpDiscretionFloodCheckerEnabled 
        { 
            get { return (bool)this["AccountCreationWithIpDiscretionFloodCheckerEnabled"]; } 
            set { this["AccountCreationWithIpDiscretionFloodCheckerEnabled"] = value; } 
        }

        internal Settings()
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
    }
}
