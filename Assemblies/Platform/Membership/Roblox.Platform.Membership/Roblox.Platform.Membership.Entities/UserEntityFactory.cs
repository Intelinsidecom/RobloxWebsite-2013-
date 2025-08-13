using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Roblox.Platform.Core;

namespace Roblox.Platform.Membership.Entities;

[ExcludeFromCodeCoverage]
internal class UserEntityFactory : IUserEntityFactory
{
	public IUserEntity GetUser(long id)
	{
		Roblox.User entity = Roblox.User.Get(id);
		if (entity != null)
		{
			return new UserEntity(entity);
		}
		return null;
	}

	public ICollection<IUserEntity> GetUsers(ICollection<long> ids)
	{
		if (ids == null)
		{
			throw new PlatformArgumentNullException("ids");
		}
		return (from u in Roblox.User.MultiGet(ids)
			where u != null
			select new UserEntity(u)).ToArray();
	}

	public IUserEntity GetUserByAccountId(long accountId)
	{
		Roblox.User entity = Roblox.User.GetByAccountID(accountId);
		if (entity != null)
		{
			return new UserEntity(entity);
		}
		return null;
	}

	public long GetUserIdByAssociatedEntityId(long associatedEntityId)
	{
		return Roblox.User.GetUserIDByAgentID(associatedEntityId);
	}
}
