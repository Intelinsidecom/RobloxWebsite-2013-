using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Demographics.Entities.Audit;
using Roblox.Platform.Membership;
using Roblox.Platform.Membership.UserDataAudit;

namespace Roblox.Platform.Demographics;

internal class AccountPhoneNumberAuditCompositeEntryFactory : AuditCompositeEntryFactoryBase<IAccountPhoneNumberAuditCompositeEntry, IAccountPhoneNumbersAuditMetadataEntity, IAccountPhoneNumbersAuditEntryEntity, IAccountPhoneNumbersAuditEntryEntityFactory>, IAccountPhoneNumberAuditCompositeEntryFactory
{
	private readonly DemographicsDomainFactories _DomainFactories;

	public AccountPhoneNumberAuditCompositeEntryFactory(DemographicsDomainFactories domainFactories, IUserFactory userFactory)
		: base(domainFactories.AccountPhoneNumbersAuditEntryEntityFactory, userFactory)
	{
		_DomainFactories = domainFactories;
	}

	private ICollection<IAccountPhoneNumberAuditCompositeEntry> GetByUserAndChangeTypeEnumerative(long userId, byte count, long? exclusiveStartId = null)
	{
		IAccountPhoneNumbersAuditMetadataEntity[] metadata = _DomainFactories.AccountPhoneNumbersAuditMetadataEntityFactory.GetByUserIdEnumerative(userId, count, exclusiveStartId).ToArray();
		return GetCompositeEntriesByMetadata(metadata);
	}

	private ICollection<IAccountPhoneNumberAuditCompositeEntry> GetByUserAndChangeTypeEnumerative(long userId, AccountPhoneNumberChangeTypes changeType, byte count, long? exclusiveStartId = null)
	{
		byte changeTypeTypeId = (byte)changeType;
		IAccountPhoneNumbersAuditMetadataEntity[] metadata = _DomainFactories.AccountPhoneNumbersAuditMetadataEntityFactory.GetByUserIdAndAccountPhoneNumbersChangeTypeIdEnumerative(userId, changeTypeTypeId, count, exclusiveStartId).ToArray();
		return GetCompositeEntriesByMetadata(metadata);
	}

	private new ICollection<IAccountPhoneNumberAuditCompositeEntry> GetCompositeEntriesByMetadata(ICollection<IAccountPhoneNumbersAuditMetadataEntity> metadata)
	{
		ICollection<IAccountPhoneNumberAuditCompositeEntry> entries = base.GetCompositeEntriesByMetadata(metadata);
		int[] phoneNumberIds = (from x in entries
			where x.PhoneNumberId.HasValue
			select x.PhoneNumberId.Value).Distinct().ToArray();
		ICollection<IPhoneNumber> phoneNumbers = _DomainFactories.PhoneNumberFactory.GetPhoneNumbers(phoneNumberIds);
		IEnumerable<IAccountPhoneNumberAuditCompositeEntry> first = entries.Where((IAccountPhoneNumberAuditCompositeEntry e) => e.PhoneNumberId.HasValue).Join(phoneNumbers, (IAccountPhoneNumberAuditCompositeEntry e) => e.PhoneNumberId.Value, (IPhoneNumber p) => p.Id, delegate(IAccountPhoneNumberAuditCompositeEntry e, IPhoneNumber p)
		{
			e.PhoneNumber = p;
			return e;
		});
		IEnumerable<IAccountPhoneNumberAuditCompositeEntry> entriesWithoutPhoneNumbers = entries.Where((IAccountPhoneNumberAuditCompositeEntry e) => !e.PhoneNumberId.HasValue);
		return first.Concat(entriesWithoutPhoneNumbers).ToArray();
	}

	protected override IAccountPhoneNumberAuditCompositeEntry GetByComposition(IAccountPhoneNumbersAuditMetadataEntity md, IAccountPhoneNumbersAuditEntryEntity entry, IUser user)
	{
		return new AccountPhoneNumberAuditCompositeEntry(md, entry)
		{
			ActorName = user?.Name
		};
	}

	public ICollection<IAccountPhoneNumberAuditCompositeEntry> GetFullPhoneNumberHistory(long userId, byte count, long? exclusiveStartId = null)
	{
		return GetByUserAndChangeTypeEnumerative(userId, count, exclusiveStartId);
	}

	public ICollection<IAccountPhoneNumberAuditCompositeEntry> GetAddingUnverifiedUserPhoneNumbersHistory(long userId, byte count, long? exclusiveStartId = null)
	{
		return GetByUserAndChangeTypeEnumerative(userId, AccountPhoneNumberChangeTypes.UnverifiedPhoneNumberEntered, count, exclusiveStartId);
	}

	public ICollection<IAccountPhoneNumberAuditCompositeEntry> GetVerifiedUserPhoneNumbersHistory(long userId, byte count, long? exclusiveStartId = null)
	{
		return GetByUserAndChangeTypeEnumerative(userId, AccountPhoneNumberChangeTypes.PhoneNumberVerified, count, exclusiveStartId);
	}
}
