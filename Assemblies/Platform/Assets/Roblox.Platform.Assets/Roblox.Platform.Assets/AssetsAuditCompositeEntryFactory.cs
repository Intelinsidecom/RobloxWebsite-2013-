using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Assets.Entities.Audit;
using Roblox.Platform.Assets.Implementation;
using Roblox.Platform.Membership;
using Roblox.Platform.Membership.UserDataAudit;

namespace Roblox.Platform.Assets;

internal class AssetsAuditCompositeEntryFactory : AuditCompositeEntryFactoryBase<IAssetsAuditCompositeEntry, IAssetsAuditMetadataEntity, IAssetsAuditEntryEntity, IAssetsAuditEntryEntityFactory>, IAssetsAuditCompositeEntryFactory
{
	private readonly AssetDomainFactories _DomainFactories;

	public AssetsAuditCompositeEntryFactory(AssetDomainFactories domainFactory, IUserFactory userFactory)
		: base(domainFactory.AssetsAuditEntriesEntityFactory, userFactory)
	{
		_DomainFactories = domainFactory;
	}

	protected override IAssetsAuditCompositeEntry GetByComposition(IAssetsAuditMetadataEntity md, IAssetsAuditEntryEntity entry, IUser user)
	{
		return new AssetsAuditCompositeEntry(md, entry)
		{
			ActorName = user?.Name
		};
	}

	public ICollection<IAssetsAuditCompositeEntry> GetTextChangeHistory(long assetId, byte count, long? exclusiveStartId = null)
	{
		IAssetsAuditMetadataEntity[] metadata = _DomainFactories.AssetsAuditMetadataEntityFactory.GetByAssetIdAndAssetChangeTypeIdEnumerative(assetId, 1, count, exclusiveStartId).ToArray();
		return GetCompositeEntriesByMetadata(metadata);
	}
}
