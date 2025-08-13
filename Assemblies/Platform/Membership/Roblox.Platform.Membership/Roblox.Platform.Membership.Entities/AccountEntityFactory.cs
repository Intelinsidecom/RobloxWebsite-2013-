using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Roblox.Data;
using Roblox.Platform.Core;

namespace Roblox.Platform.Membership.Entities;

[ExcludeFromCodeCoverage]
internal class AccountEntityFactory : IAccountEntityFactory
{
	public IAccountEntity GetAccount(long id)
	{
		Account dbObject = Account.Get(id);
		if (dbObject != null)
		{
			return new AccountEntity(dbObject);
		}
		return null;
	}

	public IAccountEntity GetAccount(string name)
	{
		if (name == null)
		{
			return null;
		}
		Account dbObject = Account.Get(name);
		if (dbObject != null)
		{
			return new AccountEntity(dbObject);
		}
		return null;
	}

	public IAccountEntity MustGetAccount(long id)
	{
		try
		{
			return new AccountEntity(Account.MustGet(id));
		}
		catch (DataIntegrityException e)
		{
			throw new PlatformDataIntegrityException(e.Message, e);
		}
	}

	public ICollection<IAccountEntity> GetAccounts(ICollection<long> ids)
	{
		if (ids == null)
		{
			throw new PlatformArgumentNullException("ids");
		}
		return (from x in Account.MultiGet(ids)
			where x != null
			select new AccountEntity(x)).ToArray();
	}

	public ICollection<IAccountEntity> GetAccounts(ICollection<int> ids)
	{
		List<long> id64s = ((IEnumerable<int>)ids).Select((Func<int, long>)((int id) => id)).ToList();
		return GetAccounts(id64s);
	}
}
