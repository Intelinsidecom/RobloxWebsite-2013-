using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Common;
using Roblox.Configuration;
using Roblox.Properties;
using Roblox.Roles.Client;

namespace Roblox;

public class AccountRoleSet
{
	private static bool _AllAccountsRoleSetsLazyInitialized;

	private static DateTime _AccountRoleSetsLastModified;

	private static readonly Lazy<IRefreshAhead<IReadOnlyCollection<AccountRoleSet>>> _AllAccountRoleSetsRefreshAheadLazy;

	private static IReadOnlyCollection<AccountRoleSet> AllAccountRoleSets => _AllAccountRoleSetsRefreshAheadLazy.Value.Value;

	public int ID { get; private set; }

	public long AccountID { get; private set; }

	public int RoleSetID { get; private set; }

	public DateTime Created { get; private set; }

	public DateTime Updated { get; private set; }

	static AccountRoleSet()
	{
		_AllAccountsRoleSetsLazyInitialized = false;
		_AccountRoleSetsLastModified = DateTime.MinValue;
		_AllAccountRoleSetsRefreshAheadLazy = new Lazy<IRefreshAhead<IReadOnlyCollection<AccountRoleSet>>>(AllAccountRoleSetsRefreshAheadFactory);
		Settings.Default.MonitorChanges((Settings s) => s.LoadAccountRoleSetsRefreshInterval, delegate(TimeSpan newInterval)
		{
			if (_AllAccountsRoleSetsLazyInitialized)
			{
				_AllAccountRoleSetsRefreshAheadLazy.Value.SetRefreshInterval(newInterval);
			}
		});
	}

	public void Delete()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		RoleSet roleSet = RoleSet.Get(RoleSetID);
		RoleSet.RolesClient.RemoveAccountRoleSet(AccountID, roleSet.Name);
		RefreshAccountRoleSets();
	}

	public static void CreateNew(long accountid, int rolesetid)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		RoleSet roleSet = RoleSet.Get(rolesetid);
		RoleSet.RolesClient.AddAccountRoleSet(accountid, roleSet.Name);
		RefreshAccountRoleSets();
	}

	public static AccountRoleSet GetByAccountIDAndRoleSetID(long accountId, int roleSetId)
	{
		return AllAccountRoleSets.FirstOrDefault((AccountRoleSet a) => a.AccountID == accountId && a.RoleSetID == roleSetId);
	}

	public static ICollection<AccountRoleSet> GetAccountRoleSetsByAccountIDPaged(long accountId, int startRowIndex, int maximumRows)
	{
		return AllAccountRoleSets.Where((AccountRoleSet a) => a.AccountID == accountId).Skip(startRowIndex).Take(maximumRows)
			.ToArray();
	}

	public static ICollection<AccountRoleSet> GetAllAccountRoleSetsByRoleSetID(int roleSetId, int maximumTotalRows)
	{
		return AllAccountRoleSets.Where((AccountRoleSet a) => a.RoleSetID == roleSetId).Take(maximumTotalRows).ToArray();
	}

	internal static IReadOnlyCollection<AccountRoleSet> GetAllAccountRoleSets()
	{
		return AllAccountRoleSets;
	}

	private static IReadOnlyCollection<AccountRoleSet> LoadAllAccountRoleSets(IReadOnlyCollection<AccountRoleSet> existingAccountRoleSets)
	{
		bool shouldReload = true;
		DateTime originalLastModifiedDate = _AccountRoleSetsLastModified;
		try
		{
			DateTime lastModified = RoleSet.RolesClient.GetAccountRoleSetLastModifiedDate();
			shouldReload = _AccountRoleSetsLastModified < lastModified;
			_AccountRoleSetsLastModified = lastModified;
		}
		catch (Exception ex)
		{
			ExceptionHandler.LogException(ex);
		}
		if (shouldReload)
		{
			try
			{
				return (IReadOnlyCollection<AccountRoleSet>)(object)(from a in RoleSet.RolesClient.GetAllAccountRoleSets().Select(TranslateAccountRoleSet)
					where a != null
					select a).ToArray();
			}
			catch (Exception ex2)
			{
				_AccountRoleSetsLastModified = originalLastModifiedDate;
				ExceptionHandler.LogException(ex2);
			}
		}
		return existingAccountRoleSets;
	}

	private static AccountRoleSet TranslateAccountRoleSet(AccountRoleSetResult accountRoleSetResult)
	{
		RoleSet roleSet = RoleSet.GetByName(accountRoleSetResult.RoleSetName);
		if (roleSet == null)
		{
			return null;
		}
		return new AccountRoleSet
		{
			ID = Convert.ToInt32(accountRoleSetResult.Id),
			AccountID = accountRoleSetResult.AccountId,
			RoleSetID = roleSet.ID,
			Created = accountRoleSetResult.Created,
			Updated = accountRoleSetResult.Created
		};
	}

	private static RefreshAhead<IReadOnlyCollection<AccountRoleSet>> AllAccountRoleSetsRefreshAheadFactory()
	{
		RefreshAhead<IReadOnlyCollection<AccountRoleSet>> refreshAhead = new RefreshAhead<IReadOnlyCollection<AccountRoleSet>>((IReadOnlyCollection<AccountRoleSet>)(object)new AccountRoleSet[0], Settings.Default.LoadAccountRoleSetsRefreshInterval, LoadAllAccountRoleSets);
		refreshAhead.Refresh();
		_AllAccountsRoleSetsLazyInitialized = true;
		return refreshAhead;
	}

	private static void RefreshAccountRoleSets()
	{
		if (_AllAccountsRoleSetsLazyInitialized)
		{
			_AccountRoleSetsLastModified = DateTime.MinValue;
			_AllAccountRoleSetsRefreshAheadLazy.Value.Refresh();
		}
	}
}
