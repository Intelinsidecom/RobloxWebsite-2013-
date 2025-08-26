using System;
using System.Collections.Generic;
using Roblox.DataV2.Core;
using System.Threading.Tasks;

#if false
// Legacy stubs (disabled): Real implementations now exist in this project under
// namespace Roblox.Platform.StaticContent.Client. These stubs are retained for
// reference only and are excluded from compilation to avoid duplicate types.
namespace Roblox.StaticContent.Client
{
    // Minimal stubs to satisfy Roblox.Platform.StaticContent project

    public enum ContentPackItemType
    {
        Css = 0,
        JavaScript = 1,
        TranslationResourceNamespace = 2
    }

    // Needed by Roblox.Web.StaticContentV2
    public enum StaticContentContentType
    {
        Css = 0,
        JavaScript = 1
    }

    public enum StaticContentResult
    {
        Unknown = 0,
        Created = 1,
        Duplicate = 2
    }

    public class ContentPackItemResult
    {
        public ContentPackItemType Type { get; set; }
        public string Value { get; set; }
    }

    public class ContentPackResult
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool Enabled { get; set; }
        public bool Validated { get; set; }
        public string Component { get; set; }
        public string[] ComponentDependencies { get; set; } = Array.Empty<string>();
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public IList<ContentPackItemResult> Items { get; set; } = new List<ContentPackItemResult>();
    }

    public interface IStaticContentClient
    {
        ICollection<ContentPackResult> GetContentPacks(
            string componentName,
            bool? enabled,
            bool? validated,
            SortOrder sortOrder,
            long? exclusiveStartId,
            int count);

        // Synchronous content pack creation used by web uploader
        StaticContentResult CreateDevelopmentContentPack(
            string componentSuffix,
            string componentName,
            string cssContent,
            string javaScriptContent,
            string[] translationResourceNamespaces,
            string[] componentDependencies);

        StaticContentResult CreateContentPack(
            string name,
            string componentName,
            string cssContent,
            string javaScriptContent,
            string[] translationResourceNamespaces,
            string[] componentDependencies);

        // Async uploads used by web uploader
        Task<StaticContentResult> UploadImage(string fileName, byte[] contents);

        Task<StaticContentResult> UploadSourceMap(string filename, string contents);
    }
}
#endif
