using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Authentication.Entities;
using Roblox.Platform.Core;

namespace Roblox.Platform.Authentication;

internal class FacebookAccountDataAccessor : IFacebookAccountDataAccessor
{
	public void Save(IFacebookAccount facebookAccount)
	{
		if (facebookAccount == null)
		{
			throw new PlatformArgumentNullException("facebookAccount");
		}
		Roblox.Platform.Authentication.Entities.FacebookAccount entity = Roblox.Platform.Authentication.Entities.FacebookAccount.Get(facebookAccount.Id);
		if (entity == null)
		{
			entity = new Roblox.Platform.Authentication.Entities.FacebookAccount();
			entity.IsValid = true;
		}
		entity.AccountID = facebookAccount.AccountId;
		entity.FacebookID = facebookAccount.FacebookId;
		entity.Save();
	}

	public void Invalidate(IFacebookAccount facebookAccount)
	{
		if (facebookAccount == null)
		{
			throw new PlatformArgumentNullException("facebookAccount");
		}
		Roblox.Platform.Authentication.Entities.FacebookAccount entity = Roblox.Platform.Authentication.Entities.FacebookAccount.Get(facebookAccount.Id);
		if (entity != null)
		{
			entity.IsValid = false;
			entity.Save();
		}
	}

	public IFacebookAccount Get(int id)
	{
		Roblox.Platform.Authentication.Entities.FacebookAccount entity = Roblox.Platform.Authentication.Entities.FacebookAccount.Get(id);
		return Translate(entity);
	}

	public IFacebookAccount GetByAccountId(long accountId)
	{
		Roblox.Platform.Authentication.Entities.FacebookAccount entity = Roblox.Platform.Authentication.Entities.FacebookAccount.GetFacebookAccountsByAccountIDAndIsValid(accountId, isValid: true, 1, 0).FirstOrDefault();
		return Translate(entity);
	}

	public IFacebookAccount GetByFacebookId(ulong facebookId)
	{
		Roblox.Platform.Authentication.Entities.FacebookAccount entity = Roblox.Platform.Authentication.Entities.FacebookAccount.GetByFacebookIDAndIsValid(facebookId, isValid: true);
		return Translate(entity);
	}

	private IFacebookAccount Translate(Roblox.Platform.Authentication.Entities.FacebookAccount entity)
	{
		if (entity == null)
		{
			return null;
		}
		return new FacebookAccount
		{
			Id = entity.ID,
			AccountId = entity.AccountID,
			FacebookId = entity.FacebookID,
			Created = entity.Created
		};
	}

	private ICollection<Roblox.Platform.Authentication.Entities.FacebookAccount> GetAllInvalidAccounts(long accountId)
	{
		int startId = 0;
		IEnumerable<Roblox.Platform.Authentication.Entities.FacebookAccount> invalidAccounts = new List<Roblox.Platform.Authentication.Entities.FacebookAccount>();
		while (true)
		{
			ICollection<Roblox.Platform.Authentication.Entities.FacebookAccount> entities = Roblox.Platform.Authentication.Entities.FacebookAccount.GetFacebookAccountsByAccountIDAndIsValid(accountId, isValid: false, 100, startId);
			if (entities.Count == 0)
			{
				break;
			}
			startId = entities.Last().ID;
			invalidAccounts = invalidAccounts.Concat(entities);
		}
		return invalidAccounts.ToArray();
	}

	public void Forget(long accountId)
	{
		if (accountId == 0L)
		{
			throw new ArgumentNullException("accountId");
		}
		IFacebookAccount validAccount = GetByAccountId(accountId);
		if (validAccount != null)
		{
			Roblox.Platform.Authentication.Entities.FacebookAccount.Get(validAccount.Id)?.Delete();
		}
		foreach (Roblox.Platform.Authentication.Entities.FacebookAccount allInvalidAccount in GetAllInvalidAccounts(accountId))
		{
			allInvalidAccount?.Delete();
		}
	}
}
