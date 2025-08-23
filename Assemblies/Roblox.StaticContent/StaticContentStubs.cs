using System;
using System.Collections.Generic;

namespace Roblox.Platform.StaticContent.Properties
{
    public interface ISettings
    {
        TimeSpan StaticContentCacheExpiry { get; }
        TimeSpan StaticContentDurableCacheExpiry { get; }
        string ComponentSuffix { get; set; }
        TimeSpan ComponentSuffixMaxAge { get; }
    }
}

namespace Roblox.Web.StaticContent.Properties
{
    public interface IStaticContentSettings { }
}

namespace Roblox.StaticContent.Client
{
    public interface IStaticContentClient
    {
        IEnumerable<ContentPackInfo> GetContentPacks(string componentName, string filter, string search, object sortOrder, string continuationToken, int? pageSize);
    }

    public class ContentPackInfo
    {
        public string Name { get; set; }
    }

    // Minimal stub of the concrete client used by Program.cs
    public class StaticContentClient : IStaticContentClient
    {
        public StaticContentClient(object httpClientBuilder, object settings)
        {
        }

        public IEnumerable<ContentPackInfo> GetContentPacks(string componentName, string filter, string search, object sortOrder, string continuationToken, int? pageSize)
        {
            return Array.Empty<ContentPackInfo>();
        }
    }
}

namespace Roblox.Web.StaticContent
{
    using Roblox.Platform.StaticContent.Properties;
    using Roblox.StaticContent.Client;
    using Roblox.Web.StaticContent.Properties;

    public enum StaticContentComponent
    {
        Unknown = 0,
        CoreScripts = 1,
        WebApp = 2,
        Site = 3
    }

    public enum StaticContentContentType
    {
        Css = 0,
        JavaScript = 1
    }

    public class StaticContentBundles
    {
        public HashSet<string> CssFileNames { get; } = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        public HashSet<string> JavaScriptFileNames { get; } = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        public HashSet<string> TranslationResourceNamespaces { get; } = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
    }

    // Provide a simple settings singleton referenced as Roblox.Web.StaticContent.Properties.Settings.Default
    namespace Properties
    {
        public class Settings : IStaticContentSettings
        {
            public static Settings Default { get; } = new Settings();
            private Settings() { }
        }
    }

    public interface IStaticContentUploader
    {
        void RegisterBundles(StaticContentComponent component, string contentPackName, StaticContentBundles bundles, ISet<string> componentDependencies);
        void RegisterImages(ISet<string> imageFileNames);
        void RegisterSourceMaps(ISet<string> sourceMapFileNames);
    }

    public class StaticContentUploader : IStaticContentUploader
    {
        protected readonly IStaticContentClient StaticContentClient;
        protected readonly IStaticContentSettings WebSettings;
        protected readonly ISettings PlatformSettings;
        protected readonly object Logger;

        public StaticContentUploader(IStaticContentClient staticContentClient, IStaticContentSettings webSettings, ISettings platformSettings, object logger)
        {
            StaticContentClient = staticContentClient;
            WebSettings = webSettings;
            PlatformSettings = platformSettings;
            Logger = logger;
        }

        public virtual void RegisterBundles(StaticContentComponent component, string contentPackName, StaticContentBundles bundles, ISet<string> componentDependencies)
        {
            // Stub: no-op
        }

        public virtual void RegisterImages(ISet<string> imageFileNames)
        {
            // Stub: no-op
        }

        public virtual void RegisterSourceMaps(ISet<string> sourceMapFileNames)
        {
            // Stub: no-op
        }

        protected virtual string BundleCss(string bundleName, ICollection<string> fileNames)
        {
            return string.Empty;
        }

        protected virtual string BundleJavaScript(string bundleName, ICollection<string> fileNames)
        {
            return string.Empty;
        }
    }
}
