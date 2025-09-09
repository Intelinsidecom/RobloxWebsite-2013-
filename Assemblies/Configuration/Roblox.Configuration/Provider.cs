using System;
using System.Collections.Specialized;
using System.Configuration;

namespace Roblox.Configuration
{
    // Minimal, safe SettingsProvider to satisfy [SettingsProvider(typeof(Provider))] attributes
    // in Roblox.WebsiteSettings.* without depending on external services.
    public class Provider : SettingsProvider
    {
        public override string ApplicationName { get; set; } = "Roblox.Website";

        public override void Initialize(string name, NameValueCollection config)
        {
            // Ensure base initialization; fall back to a default name if not provided
            base.Initialize(string.IsNullOrWhiteSpace(name) ? nameof(Provider) : name, config ?? new NameValueCollection());
            if (string.IsNullOrWhiteSpace(ApplicationName))
            {
                ApplicationName = AppDomain.CurrentDomain.FriendlyName ?? "Roblox.Website";
            }
        }

        public override SettingsPropertyValueCollection GetPropertyValues(SettingsContext context, SettingsPropertyCollection collection)
        {
            var values = new SettingsPropertyValueCollection();
            foreach (SettingsProperty prop in collection)
            {
                var spv = new SettingsPropertyValue(prop)
                {
                    // Use DefaultSettingValueAttribute when available; otherwise null
                    PropertyValue = prop.DefaultValue
                };
                values.Add(spv);
            }
            return values;
        }

        public override void SetPropertyValues(SettingsContext context, SettingsPropertyValueCollection collection)
        {
            // No-op (database/file persistence disabled in this local environment)
        }
    }
}
