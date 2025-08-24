using System;
using Roblox.Platform.AccountPins.Entities.Audit;
using Roblox.Platform.Membership;

namespace Roblox.Platform.AccountPins;

internal class AccountPinHashesAuditMetadata : IAccountPinHashesAuditMetadata
{
	public long Id { get; }

	public IUser Owner { get; }

	public IUser Actor { get; }

	public AccountPinChangeType ChangeType { get; }

	public DateTime Created { get; }

	public AccountPinHashesAuditMetadata(IUser owner, IUser actor, IAccountPinHashesAuditMetadataEntity entity)
	{
		if (entity == null)
		{
			throw new ArgumentNullException("entity");
		}
		Owner = owner ?? throw new ArgumentNullException("owner");
		Actor = actor;
		Id = entity.Id;
		ChangeType = (AccountPinChangeType)entity.AccountPinChangeTypeId;
		Created = entity.Created;
	}
}
