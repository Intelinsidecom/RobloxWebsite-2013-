using System.Collections.Generic;
using System.Linq;
using System.Text;
using Roblox.Platform.Authentication.Entities;
using Roblox.Platform.Authentication.Properties;
using Roblox.Platform.Core;

namespace Roblox.Platform.Authentication;

public class XboxLiveAccountDataAccessor : IXboxLiveAccountDataAccessor
{
	public IXboxLiveAccount CreateNew(string xboxLivePairwiseId, string xboxLiveGamerTag, long accountId)
	{
		string xboxLiveGamerTagHash = HashXboxLiveGamerTag(xboxLiveGamerTag);
		XboxLiveAccount account = new XboxLiveAccount
		{
			XboxLivePairwiseId = xboxLivePairwiseId,
			AccountId = accountId,
			XboxLiveGamerTagHash = xboxLiveGamerTagHash
		};
		Save(account);
		return account;
	}

	public void Save(IXboxLiveAccount account)
	{
		if (account != null)
		{
			Roblox.Platform.Authentication.Entities.XboxLiveAccount entity = ((account.Id == 0) ? new Roblox.Platform.Authentication.Entities.XboxLiveAccount() : Roblox.Platform.Authentication.Entities.XboxLiveAccount.GetByXboxLivePairwiseID(account.XboxLivePairwiseId));
			entity.AccountID = account.AccountId;
			entity.XboxLivePairwiseID = account.XboxLivePairwiseId;
			entity.XboxLiveGamerTagHash = account.XboxLiveGamerTagHash;
			entity.Save();
		}
	}

	public void Delete(IXboxLiveAccount account)
	{
		if (account != null)
		{
			Roblox.Platform.Authentication.Entities.XboxLiveAccount.Get(account.Id)?.Delete();
		}
	}

	public IXboxLiveAccount Get(int id)
	{
		Roblox.Platform.Authentication.Entities.XboxLiveAccount entity = Roblox.Platform.Authentication.Entities.XboxLiveAccount.Get(id);
		return Translate(entity);
	}

	public IXboxLiveAccount GetByAccountId(long accountId)
	{
		Roblox.Platform.Authentication.Entities.XboxLiveAccount entity = Roblox.Platform.Authentication.Entities.XboxLiveAccount.GetByAccountID(accountId);
		return Translate(entity);
	}

	public IXboxLiveAccount GetByXboxLivePairwiseId(string xboxLivePairwiseId)
	{
		Roblox.Platform.Authentication.Entities.XboxLiveAccount entity = Roblox.Platform.Authentication.Entities.XboxLiveAccount.GetByXboxLivePairwiseID(xboxLivePairwiseId);
		return Translate(entity);
	}

	public IXboxLiveAccount GetByXboxLiveGamerTag(string xboxLiveGamerTag)
	{
		ICollection<Roblox.Platform.Authentication.Entities.XboxLiveAccount> xboxLiveAccountsByXboxLiveGamerTagHash = Roblox.Platform.Authentication.Entities.XboxLiveAccount.GetXboxLiveAccountsByXboxLiveGamerTagHash(HashXboxLiveGamerTag(xboxLiveGamerTag), int.MaxValue, 0);
		Roblox.Platform.Authentication.Entities.XboxLiveAccount selected = xboxLiveAccountsByXboxLiveGamerTagHash.FirstOrDefault();
		foreach (Roblox.Platform.Authentication.Entities.XboxLiveAccount entity in xboxLiveAccountsByXboxLiveGamerTagHash)
		{
			if (entity.Updated > selected.Updated)
			{
				selected = entity;
			}
		}
		return Translate(selected);
	}

	public void LogXboxLiveAccountAction(long accountId, XboxLiveAccountActionType actionType, string xboxLivePairwiseId, string xboxLiveGamerTagHash)
	{
		if (accountId <= 0 || Account.Get(accountId) == null)
		{
			throw new PlatformArgumentException("Invalid Account ID");
		}
		XboxLiveAccountActionLog.CreateNew(accountId, (byte)actionType, xboxLivePairwiseId, xboxLiveGamerTagHash);
	}

	public bool HasSetUsernamePassword(long accountId)
	{
		return XboxLiveAccountActionLog.GetXboxLiveAccountActionLogsByAccountIDAndXboxLiveAccountActionTypeID(accountId, 3, 1, 0L).Count > 0;
	}

	public bool HasHadLinkedAccount(long accountId)
	{
		return XboxLiveAccountActionLog.GetXboxLiveAccountActionLogsByAccountIDAndXboxLiveAccountActionTypeID(accountId, 1, 1, 0L).Count > 0;
	}

	private IXboxLiveAccount Translate(Roblox.Platform.Authentication.Entities.XboxLiveAccount entity)
	{
		if (entity == null)
		{
			return null;
		}
		return new XboxLiveAccount
		{
			Id = entity.ID,
			AccountId = entity.AccountID,
			XboxLivePairwiseId = entity.XboxLivePairwiseID,
			XboxLiveGamerTagHash = entity.XboxLiveGamerTagHash
		};
	}

	private string HashXboxLiveGamerTag(string xboxLiveGamerTag)
	{
		string gamerTagAndSalt = xboxLiveGamerTag + Settings.Default.XboxLiveGamerTagSecretSalt;
		return HashFunctions.ComputeHashString(Encoding.UTF8.GetBytes(gamerTagAndSalt));
	}
}
