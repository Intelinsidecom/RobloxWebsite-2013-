using System;
using System.Collections.Generic;
namespace Roblox.Platform.AssetInstances.Client {

    public sealed class AssetInstanceModel
    {
        public long Id { get; set; }
        public long AssetId { get; set; }
        public DateTime Created { get; set; }
    }

    // Minimal client with in-memory behavior used by OwnershipV2UserAssetFactory
    public sealed class AssetInstancesClient
    {
        private readonly Func<string> _apiKeyGetter;
        private readonly Func<string> _endpointGetter;
        private readonly object _gate = new object();
        private readonly Dictionary<long, AssetInstanceModel> _instances = new Dictionary<long, AssetInstanceModel>();
        private long _nextId = 1;
        public AssetInstancesClient(Func<string> apiKeyGetter, Func<string> endpointGetter)
        {
            _apiKeyGetter = apiKeyGetter ?? throw new ArgumentNullException(nameof(apiKeyGetter));
            _endpointGetter = endpointGetter ?? throw new ArgumentNullException(nameof(endpointGetter));
        }

        public string GetEndpoint() => _endpointGetter();
        public string GetApiKey() => _apiKeyGetter();

        public AssetInstanceModel Create(long assetId)
        {
            lock (_gate)
            {
                var id = _nextId++;
                var model = new AssetInstanceModel { Id = id, AssetId = assetId, Created = DateTime.UtcNow };
                _instances[id] = model;
                return model;
            }
        }

        public AssetInstanceModel CreateWithId(long assetId, long assetInstanceId)
        {
            lock (_gate)
            {
                if (_instances.TryGetValue(assetInstanceId, out var existing)) return existing;
                var model = new AssetInstanceModel { Id = assetInstanceId, AssetId = assetId, Created = DateTime.UtcNow };
                _instances[assetInstanceId] = model;
                if (assetInstanceId >= _nextId) _nextId = assetInstanceId + 1;
                return model;
            }
        }

        public AssetInstanceModel Get(long assetInstanceId)
        {
            lock (_gate)
            {
                return _instances.TryGetValue(assetInstanceId, out var model) ? model : null;
            }
        }
    }
}
