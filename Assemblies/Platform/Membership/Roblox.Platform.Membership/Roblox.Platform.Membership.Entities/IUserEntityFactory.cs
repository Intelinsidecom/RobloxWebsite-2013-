using System.Collections.Generic;

namespace Roblox.Platform.Membership.Entities;

internal interface IUserEntityFactory
{
	IUserEntity GetUser(long id);

	IUserEntity GetUserByAccountId(long accountId);

	ICollection<IUserEntity> GetUsers(ICollection<long> ids);

	long GetUserIdByAssociatedEntityId(long associatedEntityId);
}
