namespace Roblox.CatalogItemChangePublisher;

public class CatalogItemChangeEvent
{
	public long TargetId { get; }

	public CatalogItemType CatalogItemType { get; }

	public CatalogItemChangeEvent(long targetId, CatalogItemType catalogItemType)
	{
		TargetId = targetId;
		CatalogItemType = catalogItemType;
	}
}
