using System.Threading;
using System.Threading.Tasks;

namespace Roblox.Assets.Client
{
	public interface IAssetsClient
	{
		Task<GetAssetOptionResponse> GetAssetOptionByAssetIdAsync(long assetId, CancellationToken cancellationToken);
		Task<GetAssetOptionResponse> GetOrCreateAssetOptionAsync(long assetId, CancellationToken cancellationToken);
		Task<GetAssetOptionResponse> UpdateOrCreateAssetOptionAsync(UpdateAssetOptionRequest request, CancellationToken cancellationToken);
		void CreateAssetPublishedVersion(AssetType assetType, string assetId, long versionNumber, string actorTargetId, string actorType);
		
		// New methods for asset published versions
		Task<PaginatedAssetPublishedVersionResult> GetAssetPublishedVersionByAssetIdAndAssetType(AssetType assetType, string assetId, string exclusiveStartKey, int count);
		Task<MultiGetAssetPublishedVersionsResponse> MultiGetAssetPublishedVersionsByAssetIdAndAssetVersionId(System.Collections.Generic.List<MultiGetAssetPublishedVersionsRequestItem> requestItems);
		GetCurrentAssetPublishedVersionResponse GetCurrentAssetPublishedVersion(AssetType assetType, string assetId, System.DateTime? expectedLatestTime);

		// Asset dependencies
		bool CreateAssetDependency(CreateAssetDependencyRequest request);
	}
}
