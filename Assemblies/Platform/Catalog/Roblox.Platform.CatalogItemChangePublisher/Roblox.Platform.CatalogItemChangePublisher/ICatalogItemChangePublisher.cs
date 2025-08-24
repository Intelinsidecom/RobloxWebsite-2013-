namespace Roblox.CatalogItemChangePublisher;

public interface ICatalogItemChangePublisher
{
	void Publish(long assetId, bool useDelay = false);

	void Publish(long targetId, CatalogItemType catalogItemType, bool useDelay = false);
}
