using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.AccountPins.Entities.Audit;
using Roblox.Platform.Membership;

namespace Roblox.Platform.AccountPins;

internal class AccountPinAuditFactory : IAccountPinAuditFactory
{
	private readonly IUserFactory _UserFactory;

	private readonly IAccountPinHashesAuditMetadataEntityFactory _MetadataEntityFactory;

	public AccountPinAuditFactory(IUserFactory userFactory, IAccountPinHashesAuditMetadataEntityFactory metadataEntityFactory)
	{
		_UserFactory = userFactory ?? throw new ArgumentNullException("userFactory");
		_MetadataEntityFactory = metadataEntityFactory ?? throw new ArgumentNullException("metadataEntityFactory");
	}

	public PagedResponse<IAccountPinHashesAuditMetadata> GetMetadataEntries(IUser owner, int count, int? exclusiveStartId = 0)
	{
		if (owner == null)
		{
			throw new ArgumentNullException("owner");
		}
		List<IAccountPinHashesAuditMetadataEntity> entities = _MetadataEntityFactory.GetByUserIdEnumerative(owner.Id, count + 1, exclusiveStartId).ToList();
		return new PagedResponse<IAccountPinHashesAuditMetadata>
		{
			HasMore = (entities.Count() > count),
			Items = from e in entities.Take(count)
				select Build(e, owner)
		};
	}

	private IAccountPinHashesAuditMetadata Build(IAccountPinHashesAuditMetadataEntity entity, IUser owner)
	{
		if (entity == null)
		{
			return null;
		}
		IUser actor = null;
		if (entity.ActorUserId.HasValue)
		{
			actor = _UserFactory.GetUser(entity.ActorUserId.Value);
		}
		return new AccountPinHashesAuditMetadata(owner, actor, entity);
	}
}
