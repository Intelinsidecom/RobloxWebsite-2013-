using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Membership.Audit;

namespace Roblox.Platform.Membership;

public class UsersAuditCompositeEntryFactory : IUsersAuditCompositeEntryFactory
{
	private readonly IUserFactory _UserFactory;

	private readonly IUsersAuditEntriesMetaDataEntityFactory _UsersAuditEntriesMetaDataEntityFactory;

	private readonly IUsersAuditEntryEntityFactory _UsersAuditEntryEntityFactory;

	public UsersAuditCompositeEntryFactory(IUserFactory userFactory)
		: this(userFactory, new UsersAuditEntriesMetaDataEntityFactory(), new UsersAuditEntryEntityFactory())
	{
	}

	internal UsersAuditCompositeEntryFactory(IUserFactory userFactory, IUsersAuditEntriesMetaDataEntityFactory usersAuditEntriesMetaDataEntityFactory, IUsersAuditEntryEntityFactory usersAuditEntryEntityFactory)
	{
		_UserFactory = userFactory;
		_UsersAuditEntriesMetaDataEntityFactory = usersAuditEntriesMetaDataEntityFactory;
		_UsersAuditEntryEntityFactory = usersAuditEntryEntityFactory;
	}

	internal ICollection<IUsersAuditCompositeEntry> GetByUserIdAndUsersAuditEntriesMetaDataTypeIdEnumerative(long userId, UsersAuditEntryMetaDataType metaDataType, byte count, long exclusiveStartId = 0L)
	{
		byte metaDataTypeId = (byte)metaDataType;
		IUsersAuditEntriesMetaDataEntity[] metaData = _UsersAuditEntriesMetaDataEntityFactory.GetByUserIdAndUsersAuditEntriesMetaDataTypeIdEnumerative(userId, metaDataTypeId, count, exclusiveStartId).ToArray();
		if (!metaData.Any())
		{
			return new IUsersAuditCompositeEntry[0];
		}
		IUsersAuditEntryEntity[] auditEntries = _UsersAuditEntryEntityFactory.SingleGetsByPublicIds(metaData.Select((IUsersAuditEntriesMetaDataEntity md) => md.UsersAuditEntriesPublicId).Distinct().ToArray()).ToArray();
		if (!auditEntries.Any())
		{
			return new IUsersAuditCompositeEntry[0];
		}
		IUser[] actorUsers = _UserFactory.GetUsers(metaData.Select((IUsersAuditEntriesMetaDataEntity md) => md.ActorUserId).Distinct().ToArray()).ToArray();
		return (from mData in metaData
			join aEntry in auditEntries on mData.UsersAuditEntriesPublicId equals aEntry.PublicId into aEntries
			select new
			{
				mData = mData,
				aEntry = aEntries.SingleOrDefault()
			} into pair
			join user in actorUsers on pair.mData.ActorUserId equals user.Id into u
			select GetByComposition(pair.mData, pair.aEntry, u.SingleOrDefault()) into composite
			orderby composite.Id descending
			select composite).ToArray();
	}

	internal virtual IUsersAuditCompositeEntry GetByComposition(IUsersAuditEntriesMetaDataEntity md, IUsersAuditEntryEntity entry, IUser user)
	{
		return new UsersAuditCompositeEntry(md, entry)
		{
			ActorName = user?.Name
		};
	}

	public ICollection<IUsersAuditCompositeEntry> GetBirthdateHistory(long userId, byte count, long exclusiveStartId = 0L)
	{
		return GetByUserIdAndUsersAuditEntriesMetaDataTypeIdEnumerative(userId, UsersAuditEntryMetaDataType.BirthDateSetOrChange, count, exclusiveStartId).ToArray();
	}

	public ICollection<IUsersAuditCompositeEntry> GetGenderHistory(long userId, byte count, long exclusiveStartId = 0L)
	{
		return GetByUserIdAndUsersAuditEntriesMetaDataTypeIdEnumerative(userId, UsersAuditEntryMetaDataType.GenderSetOrChange, count, exclusiveStartId).ToArray();
	}
}
