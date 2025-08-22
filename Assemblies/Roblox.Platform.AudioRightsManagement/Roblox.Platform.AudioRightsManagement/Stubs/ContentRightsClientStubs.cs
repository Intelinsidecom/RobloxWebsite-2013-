using System.Collections.Generic;

namespace Roblox.ContentRights.Client
{
    // Minimal stubs to satisfy compile-time references
    public interface IContentRightsClient
    {
        bool AreContentRightsProtected(string contentType, string contentTargetId);
        IEnumerable<ContentIdentifier> AreContentRightsProtected(IEnumerable<ContentIdentifier> identifiers);
        void SetContentRights(string contentType, string contentTargetId, string source, string metadata);
    }

    public struct ContentIdentifier
    {
        public string ContentType { get; set; }
        public string ContentTargetId { get; set; }
    }
}
