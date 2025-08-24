using System.Collections.Generic;

namespace Roblox.Platform.Assets;

/// <summary>
/// A public interface producing <see cref="T:Roblox.Platform.Assets.IAssetsAuditCompositeEntry">IAssetsAuditCompositeEntries</see>
/// </summary>
public interface IAssetsAuditCompositeEntryFactory
{
	/// <summary>
	/// Obtains audit information on an asset's text changes
	/// </summary>
	ICollection<IAssetsAuditCompositeEntry> GetTextChangeHistory(long assetId, byte count, long? exclusiveStartId = null);
}
