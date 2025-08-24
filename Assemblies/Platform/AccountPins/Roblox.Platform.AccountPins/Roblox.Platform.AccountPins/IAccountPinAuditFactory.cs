using Roblox.Platform.Membership;

namespace Roblox.Platform.AccountPins;

/// <summary>
/// Factory for getting account pin audit-related information
/// </summary>
public interface IAccountPinAuditFactory
{
	/// <param name="owner">Owner of the account pin</param>
	PagedResponse<IAccountPinHashesAuditMetadata> GetMetadataEntries(IUser owner, int count, int? exclusiveStartId = 0);
}
