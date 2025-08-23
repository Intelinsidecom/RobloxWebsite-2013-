using System;
using System.Collections.Generic;
using Roblox.Platform.Core.ExclusiveStartPaging;

namespace Roblox.StaticContent.Client
{
    // Minimal stubs to satisfy Roblox.Platform.StaticContent project

    public enum ContentPackItemType
    {
        Css = 0,
        JavaScript = 1,
        TranslationResourceNamespace = 2
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
    }
}
