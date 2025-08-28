using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Membership;
using Roblox.Platform.Membership.UserDataAuditCore;

namespace Roblox.Platform.Assets.UserDataAuditBase;

public abstract class AuditCompositeEntryFactoryBase<TCompositeEntry, TMetadataEntity, TAuditEntryEntity, TAuditEntryEntityFactory>
    where TCompositeEntry : IAuditCompositeEntry
    where TMetadataEntity : IAuditMetadata
    where TAuditEntryEntity : IAuditEntry
    where TAuditEntryEntityFactory : IAuditEntryEntityFactory<TAuditEntryEntity>
{
    protected readonly TAuditEntryEntityFactory _AuditEntryEntityFactory;
    protected readonly IUserFactory _UserFactory;

    protected AuditCompositeEntryFactoryBase(TAuditEntryEntityFactory auditEntryEntityFactory, IUserFactory userFactory)
    {
        _AuditEntryEntityFactory = auditEntryEntityFactory;
        _UserFactory = userFactory;
    }

    protected abstract TCompositeEntry GetByComposition(TMetadataEntity md, TAuditEntryEntity entry, IUser user);

    protected ICollection<TCompositeEntry> GetCompositeEntriesByMetadata(ICollection<TMetadataEntity> metadata)
    {
        if (metadata != null && !metadata.Any())
            return new TCompositeEntry[0];

        var auditEntries = _AuditEntryEntityFactory?
            .GetByPublicIds(metadata.Select(md => md.ForeignPublicId).Distinct().ToArray())
            .ToArray();

        if (auditEntries != null && !auditEntries.Any())
            return new TCompositeEntry[0];

        return (from composite in Enumerable.GroupJoin(
                    outer: from mData in metadata
                           join aEntry in auditEntries on mData.ForeignPublicId equals aEntry?.PublicId into aEntries
                           select new { mData, aEntry = aEntries.SingleOrDefault() },
                    inner: (_UserFactory == null) ? new IUser[0] : _UserFactory
                           .GetUsers(metadata.Where(md => md.ActorUserId.HasValue)
                                             .Select(md => md.ActorUserId.Value)
                                             .Distinct()
                                             .ToArray())
                           .ToArray(),
                    outerKeySelector: pair => pair.mData.ActorUserId,
                    innerKeySelector: (IUser actorUser) => actorUser.Id,
                    resultSelector: (pair, u) => GetByComposition(pair.mData, pair.aEntry, u.SingleOrDefault()))
                orderby composite.Id descending
                select composite).ToArray();
    }
}
