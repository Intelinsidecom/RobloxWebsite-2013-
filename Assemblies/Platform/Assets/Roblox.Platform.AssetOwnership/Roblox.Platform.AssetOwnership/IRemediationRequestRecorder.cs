using System.Collections.Generic;

namespace Roblox.Platform.AssetOwnership;

public interface IRemediationRequestRecorder
{
	void RecordUserAssetIdForRemediation(long userAssetId, string message);

	HashSet<RemediationRequest> GetRemediationRequests();
}
