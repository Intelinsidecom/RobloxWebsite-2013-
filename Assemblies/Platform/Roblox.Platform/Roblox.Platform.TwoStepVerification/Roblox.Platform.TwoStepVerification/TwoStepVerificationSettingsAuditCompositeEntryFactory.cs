using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Membership;
using Roblox.Platform.Membership.UserDataAudit;
using Roblox.Platform.TwoStepVerification.Entities.Audit;

namespace Roblox.Platform.TwoStepVerification;

internal class TwoStepVerificationSettingsAuditCompositeEntryFactory : AuditCompositeEntryFactoryBase<ITwoStepVerificationSettingsAuditCompositeEntry, ITwoSVSettingsAuditMetadataEntity, ITwoStepVerificationSettingsAuditEntryEntity, ITwoStepVerificationSettingsAuditEntryEntityFactory>, ITwoStepVerificationSettingsAuditCompositeEntryFactory
{
	private readonly TwoStepVerificationDomainProvider _DomainProvider;

	public TwoStepVerificationSettingsAuditCompositeEntryFactory(TwoStepVerificationDomainProvider domainProvider, IUserFactory userFactory)
		: base(domainProvider.SettingsAuditEntryEntityFactory, userFactory)
	{
		_DomainProvider = domainProvider;
	}

	public ICollection<ITwoStepVerificationSettingsAuditCompositeEntry> GetAllHistory(long userId, byte count, long? exclusiveStartId = null)
	{
		ITwoSVSettingsAuditMetadataEntity[] metadata = _DomainProvider.SettingsAuditMetadataEntityFactory.GetByUserIdEnumerative(userId, count, exclusiveStartId).ToArray();
		return GetCompositeEntriesByMetadata(metadata);
	}

	public ICollection<ITwoStepVerificationSettingsAuditCompositeEntry> GetEnableDisableHistory(long userId, byte count, long? exclusiveStartId = 0L)
	{
		byte typeId = 2;
		ITwoSVSettingsAuditMetadataEntity[] metadata = _DomainProvider.SettingsAuditMetadataEntityFactory.GetByUserIdAndTwoStepVerificationChangeTypeIdEnumerative(userId, typeId, count, exclusiveStartId).ToArray();
		return GetCompositeEntriesByMetadata(metadata);
	}

	public ICollection<ITwoStepVerificationSettingsAuditCompositeEntry> GetMediaTypeHistory(long userId, byte count, long? exclusiveStartId = 0L)
	{
		byte typeId = 3;
		ITwoSVSettingsAuditMetadataEntity[] metadata = _DomainProvider.SettingsAuditMetadataEntityFactory.GetByUserIdAndTwoStepVerificationChangeTypeIdEnumerative(userId, typeId, count, exclusiveStartId).ToArray();
		return GetCompositeEntriesByMetadata(metadata);
	}

	protected override ITwoStepVerificationSettingsAuditCompositeEntry GetByComposition(ITwoSVSettingsAuditMetadataEntity md, ITwoStepVerificationSettingsAuditEntryEntity entry, IUser user)
	{
		return new TwoStepVerificationSettingsAuditCompositeEntry(_DomainProvider.TwoStepVerificationMediaTypeFactory, md, entry)
		{
			ActorName = user?.Name
		};
	}
}
