using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities;
using Roblox.Platform.Membership.UserDataAuditCore;

namespace Roblox.Platform.AccountPins.Entities.Audit;

[ExcludeFromCodeCoverage]
internal class AccountPinHashesAuditMetadataCachedMssqlEntity : IAccountPinHashesAuditMetadataEntity, IEntity<long>, IAuditMetadata
{
	public long Id { get; set; }

	public Guid AccountPinHashesAuditPublicId { get; set; }

	public long UserId { get; set; }

	public long? ActorUserId { get; set; }

	public byte AccountPinChangeTypeId { get; set; }

	public DateTime Created { get; set; }

	public Guid ForeignPublicId => AccountPinHashesAuditPublicId;

	public void Delete()
	{
		(AccountPinHashesAuditMetadataCAL.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}
}
