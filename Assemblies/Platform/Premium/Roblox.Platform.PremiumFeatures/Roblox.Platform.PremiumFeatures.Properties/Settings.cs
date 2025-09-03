using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Roblox.Configuration;
using System;
namespace Roblox.Platform.PremiumFeatures.Properties
{
    [SettingsProvider(typeof(Provider))]
    [ExcludeFromCodeCoverage]
    [CompilerGenerated]
    [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
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
        public bool IsPremiumCheckEnabled => (bool)this["IsPremiumCheckEnabled"];

        [ApplicationScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("False")]
        public bool IsMembershipMigrationStatusEntityRemoteCacheEnabled => (bool)this["IsMembershipMigrationStatusEntityRemoteCacheEnabled"];

        // ---- Added stubs to satisfy references in PremiumFeatures code ----
        public DateTime RobuxStipendBonusTerminationDate => DateTime.MaxValue;
        public string RobloxPremiumFeaturesTest => string.Empty;
        public string AccountManagementConnectionStringForTesting => string.Empty;
        public bool RenewalCalculationStartDateEqualOrLargerThanCurrentTimeEnabled => false;
        public float OBCtoTBCDurationConversionFactor => 1.0f;
        public float TBCtoBCDurationConversionFactor => 1.0f;
        public float OBCtoBCDurationConversionFactor => 1.0f;
        public int AccountAddOnActivationLeaseDurationInMilliseconds => 30000;
        public bool ExpiredBCActiveSlotsEnabled => false;
        public byte ExpiredBCActiveSlots => 1;
        public bool IsAccountAddonsByAccountIDRemoteCacheEnabled => false;
        public int AccountAddOnMaxCacheSize => 1000;
        public TimeSpan AccountAddOnCacheExpiration => TimeSpan.FromMinutes(10);
        public bool IsAccountAddonSmartMultigetEnabled => false;
        public float RobuxStipendBonusMaxMultiplier => 1.0f;
        public float RobuxStipendBonusMaxDays => 0.0f;
        public int AccountAddOnCommandTimeoutInSeconds => 30;
        public bool IsPremiumFeatureApplicationIntentEnabled => false;

        internal Settings()
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
}
