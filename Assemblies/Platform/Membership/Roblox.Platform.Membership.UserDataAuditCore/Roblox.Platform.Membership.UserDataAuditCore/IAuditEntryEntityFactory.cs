using System;
using System.Collections.Generic;

namespace Roblox.Platform.Membership.UserDataAuditCore;

public interface IAuditEntryEntityFactory<TAuditEntryEntity> where TAuditEntryEntity : IAuditEntry
{
	ICollection<TAuditEntryEntity> GetByPublicIds(ICollection<Guid> publicIds);
}
