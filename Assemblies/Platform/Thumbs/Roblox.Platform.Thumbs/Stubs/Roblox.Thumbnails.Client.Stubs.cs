using System;
using Roblox.EventLog;
using Roblox.Instrumentation;

namespace Roblox.Thumbnails.Client
{
    public enum SubstitutionType
    {
        None = 0,
        Unavailable = 1,
        Moderated = 2,
    }

    public sealed class ThumbnailHashRequest
    {
        public long AssetHashId { get; set; }
        public string ThumbnailTypeName { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string FormatType { get; set; }
    }

    public sealed class ThumbnailHashResult
    {
        public long AssetHashId { get; set; }
        public string Hash { get; set; }
        public string Url { get; set; }
        public SubstitutionType SubstitutionType { get; set; }
    }

    public interface IThumbnailsClient
    {
        ThumbnailHashResult GetThumbnailHash(long assetHashId, string thumbnailTypeName, int width, int height, string formatType, long? universeId);
        ThumbnailHashResult[] MultiGetThumbnailHash(ThumbnailHashRequest[] requests);
        void InvalidateThumbnails(params long[] assetHashIds);
    }

    public sealed class ThumbnailsClient : IThumbnailsClient
    {
        private readonly ILogger _logger;
        private readonly ICounterRegistry _counters;
        private readonly Func<string> _getApiKey;

        public ThumbnailsClient(ILogger logger, ICounterRegistry counters, Func<string> getApiKey)
        {
            _logger = logger;
            _counters = counters;
            _getApiKey = getApiKey;
        }

        public ThumbnailHashResult GetThumbnailHash(long assetHashId, string thumbnailTypeName, int width, int height, string formatType, long? universeId)
        {
            // Stub: return placeholder indicating unavailable to keep existing control flow working
            return new ThumbnailHashResult { AssetHashId = assetHashId, Hash = string.Empty, Url = null, SubstitutionType = SubstitutionType.Unavailable };
        }

        public ThumbnailHashResult[] MultiGetThumbnailHash(ThumbnailHashRequest[] requests)
        {
            if (requests == null) return Array.Empty<ThumbnailHashResult>();
            var results = new ThumbnailHashResult[requests.Length];
            for (int i = 0; i < requests.Length; i++)
            {
                var r = requests[i];
                results[i] = new ThumbnailHashResult { AssetHashId = r.AssetHashId, Hash = string.Empty, Url = null, SubstitutionType = SubstitutionType.Unavailable };
            }
            return results;
        }

        public void InvalidateThumbnails(params long[] assetHashIds)
        {
            // no-op stub
        }
    }
}
