using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Roblox.ApiClientBase;
using Roblox.Assets.Client.Properties;

namespace Roblox.Assets.Client
{
	public class AssetsClient : ApiClientBase.ApiClientBase, IAssetsClient
	{
		private readonly Func<string> _ApiKeyGetter;
		
		public AssetsClient(Func<string> apiKeyGetter)
		{
			_ApiKeyGetter = apiKeyGetter ?? throw new ArgumentNullException(nameof(apiKeyGetter));
		}
		
		protected override string ApiKey => _ApiKeyGetter();
		
		protected override string Endpoint => Settings.Default.AssetsServiceEndpoint;
		
		protected override TimeSpan Timeout => TimeSpan.FromMilliseconds(Settings.Default.AssetsServiceTimeoutMs);
		
		public override string Name => "AssetsClient";
		
		protected override void OnRequestStarting()
		{
			// No additional setup needed
		}
		
		public async Task<GetAssetOptionResponse> GetAssetOptionByAssetIdAsync(long assetId, CancellationToken cancellationToken)
		{
			return await GetAsync<GetAssetOptionResponse>($"/v1/asset-options/{assetId}", cancellationToken).ConfigureAwait(false);
		}
		
		public async Task<GetAssetOptionResponse> GetOrCreateAssetOptionAsync(long assetId, CancellationToken cancellationToken)
		{
			return await PostAsync<GetAssetOptionResponse>($"/v1/asset-options/{assetId}/get-or-create", cancellationToken).ConfigureAwait(false);
		}
		
		public async Task<GetAssetOptionResponse> UpdateOrCreateAssetOptionAsync(UpdateAssetOptionRequest request, CancellationToken cancellationToken)
		{
			return await PostObjectJsonAsync<GetAssetOptionResponse>("/v1/asset-options/update-or-create", request, cancellationToken).ConfigureAwait(false);
		}
		
		public void CreateAssetPublishedVersion(AssetType assetType, string assetId, long versionNumber, string actorTargetId, string actorType)
		{
			var requestData = new {
				AssetType = assetType,
				AssetId = assetId,
				VersionNumber = versionNumber,
				ActorTargetId = actorTargetId,
				ActorType = actorType
			};
			
			PostObjectJson("/v1/asset-published-versions", requestData);
		}
		
		// New methods for asset published versions
		public async Task<PaginatedAssetPublishedVersionResult> GetAssetPublishedVersionByAssetIdAndAssetType(AssetType assetType, string assetId, string exclusiveStartKey, int count)
		{
			var queryParameters = new List<KeyValuePair<string, object>>
			{
				new KeyValuePair<string, object>("assetType", assetType.ToString()),
				new KeyValuePair<string, object>("assetId", assetId),
				new KeyValuePair<string, object>("count", count)
			};
			
			if (!string.IsNullOrEmpty(exclusiveStartKey))
			{
				queryParameters.Add(new KeyValuePair<string, object>("exclusiveStartKey", exclusiveStartKey));
			}
			
			return await GetAsync<PaginatedAssetPublishedVersionResult>("/v1/asset-published-versions", CancellationToken.None, queryParameters).ConfigureAwait(false);
		}
		
		public async Task<MultiGetAssetPublishedVersionsResponse> MultiGetAssetPublishedVersionsByAssetIdAndAssetVersionId(System.Collections.Generic.List<MultiGetAssetPublishedVersionsRequestItem> requestItems)
		{
			return await PostObjectJsonAsync<MultiGetAssetPublishedVersionsResponse>("/v1/asset-published-versions/multi-get", requestItems, CancellationToken.None).ConfigureAwait(false);
		}
		
		public GetCurrentAssetPublishedVersionResponse GetCurrentAssetPublishedVersion(AssetType assetType, string assetId, DateTime? expectedLatestTime)
		{
			var requestData = new {
				AssetType = assetType,
				AssetId = assetId,
				ExpectedLatestTime = expectedLatestTime
			};
			
			return PostObjectJson<GetCurrentAssetPublishedVersionResponse>("/v1/asset-published-versions/current", requestData);
		}

		public bool CreateAssetDependency(CreateAssetDependencyRequest request)
		{
			if (request == null) throw new ArgumentNullException(nameof(request));
			// If the call does not throw, consider it a success and return true.
			PostObjectJson("/v1/asset-dependencies", request);
			return true;
		}
	}
}
