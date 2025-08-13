using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities;

namespace Roblox.Platform.Membership.Commands.Audit;

[ExcludeFromCodeCoverage]
internal class AccountsAuditMetadataCachedMssqlEntity : IAccountsAuditMetadataEntity, IEntity<long>
{
	public long Id { get; set; }

	public Guid AccountsAuditEntriesPublicId { get; set; }

	public byte AccountsChangeTypeId { get; set; }

	public long? ActorUserId { get; set; }

	public long UserId { get; set; }

	public DateTime Created { get; set; }

	public void Delete()
	{
		(AccountsAuditMetadataCAL.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}
}
