using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities;
using Roblox.Platform.Membership.UserDataAuditCore;

namespace Roblox.Platform.Demographics.Entities.Audit;

[ExcludeFromCodeCoverage]
internal class AccountPhoneNumbersAuditMetadataCachedMssqlEntity : IAccountPhoneNumbersAuditMetadataEntity, IEntity<long>, IAuditMetadata
{
	public long Id { get; set; }

	public Guid AccountPhoneNumbersAuditEntriesPublicId { get; set; }

	public long UserId { get; set; }

	public long? ActorUserId { get; set; }

	public byte AccountPhoneNumbersChangeTypeId { get; set; }

	public bool IsLegacyValue { get; set; }

	public DateTime Created { get; set; }

	public Guid ForeignPublicId => AccountPhoneNumbersAuditEntriesPublicId;

	public void Delete()
	{
		(AccountPhoneNumbersAuditMetadata.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}

	public long? GetActorUserId()
	{
		if (!ActorUserId.HasValue)
		{
			return null;
		}
		try
		{
			return ActorUserId;
		}
		catch (Exception)
		{
			return null;
		}
	}
}
