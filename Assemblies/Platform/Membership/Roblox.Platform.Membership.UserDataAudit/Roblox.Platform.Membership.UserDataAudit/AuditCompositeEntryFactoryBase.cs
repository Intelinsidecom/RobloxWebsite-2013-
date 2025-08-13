using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Membership.UserDataAuditCore;

namespace Roblox.Platform.Membership.UserDataAudit;

public abstract class AuditCompositeEntryFactoryBase<TCompositeEntry, TMetadataEntity, TAuditEntryEntity, TAuditEntryEntityFactory> where TCompositeEntry : IAuditCompositeEntry where TMetadataEntity : IAuditMetadata where TAuditEntryEntity : IAuditEntry where TAuditEntryEntityFactory : IAuditEntryEntityFactory<TAuditEntryEntity>
{
	protected readonly TAuditEntryEntityFactory _AuditEntryEntityFactory;

	protected readonly IUserFactory _UserFactory;

	/// <summary>
	/// The base constructor for AuditCompositeEntryFactories.
	/// </summary>
	/// <param name="auditEntryEntityFactory">The <see cref="!:IAuditEntryEntityFactory" /> that produces <see cref="T:Roblox.Platform.Membership.UserDataAuditCore.IAuditEntry">IAuditEntries</see> data</param>.
	/// <param name="userFactory">The <see cref="T:Roblox.Platform.Membership.IUserFactory" /> for name-lookup.  Accepts null if no name lookup is necessary.</param>
	protected AuditCompositeEntryFactoryBase(TAuditEntryEntityFactory auditEntryEntityFactory, IUserFactory userFactory)
	{
		_AuditEntryEntityFactory = auditEntryEntityFactory;
		_UserFactory = userFactory;
	}

	protected abstract TCompositeEntry GetByComposition(TMetadataEntity md, TAuditEntryEntity entry, IUser user);

	protected ICollection<TCompositeEntry> GetCompositeEntriesByMetadata(ICollection<TMetadataEntity> metadata)
	{
		if (metadata != null && !metadata.Any())
		{
			return new TCompositeEntry[0];
		}
		TAuditEntryEntity[] auditEntries = _AuditEntryEntityFactory?.GetByPublicIds(metadata.Select((TMetadataEntity md) => md.ForeignPublicId).Distinct().ToArray()).ToArray();
		if (auditEntries != null && !auditEntries.Any())
		{
			return new TCompositeEntry[0];
		}
		return (from composite in Enumerable.GroupJoin(inner: (_UserFactory == null) ? new IUser[0] : _UserFactory.GetUsers((from md in metadata
				where md.ActorUserId.HasValue
				select md.ActorUserId.Value).Distinct().ToArray()).ToArray(), outer: from mData in metadata
				join aEntry in auditEntries on mData.ForeignPublicId equals aEntry?.PublicId into aEntries
				select new
				{
					mData = mData,
					aEntry = aEntries.SingleOrDefault()
				}, outerKeySelector: pair => pair.mData.ActorUserId, innerKeySelector: (IUser actorUser) => actorUser.Id, resultSelector: (pair, IEnumerable<IUser> u) => GetByComposition(pair.mData, pair.aEntry, u.SingleOrDefault()))
			orderby composite.Id descending
			select composite).ToArray();
	}
}
