using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Resources;
using System.Globalization;
using System.Reflection;

namespace Roblox.Website
{
    public class RobloxResourceSet
    {
        private ResourceSet _Resources;
        private ResourceManager _ResourceManager;

        public string ResourceName { get; }

        public string this[string name]
        {
            get { return GetString(name); }
        }

        public string GetString(string name)
        {
            return _Resources.GetString(name);
        }

        public RobloxResourceSet(string name, CultureInfo cultureInfo = null)
        {
            ResourceName = name;
            var typePrefix = "Resources.";
            var type = Type.GetType(typePrefix + name);

            _ResourceManager = (ResourceManager)(
                type.GetProperty(
                    "ResourceManager",
                    BindingFlags.Static | BindingFlags.NonPublic
                ).GetValue(new object())
            );
            _Resources = _ResourceManager.GetResourceSet(
                cultureInfo != null ? cultureInfo : CultureInfo.CurrentUICulture,
                true,
                true
            );
        }
    }
}