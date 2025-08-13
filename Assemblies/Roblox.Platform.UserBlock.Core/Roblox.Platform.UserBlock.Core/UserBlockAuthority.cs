using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Caching.Shared;
using Roblox.Permissions.Client;
using Roblox.Platform.Membership;
using Roblox.Platform.Permissions.Core;
using Roblox.Platform.UserBlock.Core.Properties;

namespace Roblox.Platform.UserBlock.Core;

public class UserBlockAuthority : IUserBlockAuthority
{
	private const string _PermissionGroupKey = "Blocked users";

	private const string _BlockeeFacingMessage = "That user has blocked this form of contact.";

	private const string _BlockerFacingMessage = "You previously blocked that user. To unblock them, go to their profile page.";

	private const string _GenericErrorMessage = "There was an error performing the action.";

	private static readonly IEnumerable<long> _EmptyBlockedUsersList = new List<long>(0);

	private static readonly PageResult<long, long> _EmptyPageResult = new PageResult<long, long>();

	private readonly IPermissionsClient _PermissionsClient;

	private readonly ISharedCacheClient _CacheClient;

	private readonly IUserFactory _UserFactory;

	public string PermissionGroupKey => "Blocked users";

	private string CacheKeyForIsUserBlocked(long blockerId, long blockeeId)
	{
		return $"UserBlock_Blocker:{blockerId}_Blockee:{blockeeId}";
	}

	[Obsolete("Deprecated.  Use UserBlockAuthority(IPermissionsClient permissionsClient, ISharedCacheClient cacheClient, IUserFactory userFactory) instead.")]
	public UserBlockAuthority(IPermissionsClient permissionsClient, ISharedCacheClient cacheClient)
		: this(permissionsClient, cacheClient, new UserFactory())
	{
	}

	public UserBlockAuthority(IPermissionsClient permissionsClient, ISharedCacheClient cacheClient, IUserFactory userFactory)
	{
		_PermissionsClient = permissionsClient;
		_CacheClient = cacheClient;
		_UserFactory = userFactory;
	}

	public PageResult<long, long> GetBlockedUsersPaged(IUser blocker, int page)
	{
		if (Settings.Default.UserBlockingEnabled && blocker != null)
		{
			ICustomList listElement = blocker.GetCustomLists(_PermissionsClient).FirstOrDefault((ICustomList l) => "Blocked users".Equals(l.Name));
			if (listElement != null)
			{
				return _PermissionsClient.GetListMembers(listElement.Id, (int?)page);
			}
		}
		return _EmptyPageResult;
	}

	public IEnumerable<long> GetAllBlockedUsers(IUser blocker)
	{
		if (!Settings.Default.UserBlockingEnabled || blocker == null)
		{
			return _EmptyBlockedUsersList;
		}
		ICustomList BlockedUsersPagedList = blocker.GetCustomLists(_PermissionsClient).FirstOrDefault((ICustomList l) => "Blocked users".Equals(l.Name));
		if (BlockedUsersPagedList == null)
		{
			return _EmptyBlockedUsersList;
		}
		int page = 1;
		List<long> allBlockedUsersList = new List<long>();
		PageResult<long, long> pageResult;
		do
		{
			pageResult = _PermissionsClient.GetListMembers(BlockedUsersPagedList.Id, (int?)page);
			page++;
			if (pageResult?.PageItems == null || !pageResult.PageItems.Any())
			{
				break;
			}
			allBlockedUsersList.AddRange(pageResult.PageItems);
		}
		while (allBlockedUsersList.Count < pageResult.Count);
		return allBlockedUsersList;
	}

	public bool IsBlocked(IUser blocker, long blockeeId)
	{
		if (!Settings.Default.UserBlockingEnabled || blocker == null || _UserFactory.GetUser(blockeeId) == null)
		{
			return false;
		}
		string cacheKey = CacheKeyForIsUserBlocked(blocker.Id, blockeeId);
		if (Settings.Default.IsUserBlockCachingEnabled && _CacheClient.Query(cacheKey, out bool cachedResult))
		{
			return cachedResult;
		}
		ICustomList listElement = blocker.GetCustomLists(_PermissionsClient).FirstOrDefault((ICustomList l) => "Blocked users".Equals(l.Name));
		bool result = listElement != null && _PermissionsClient.IsListMember(listElement.Id, blockeeId);
		if (Settings.Default.IsUserBlockCachingEnabled)
		{
			_CacheClient.Set(cacheKey, result, Settings.Default.UserBlockCacheExpiration);
		}
		return result;
	}

	public bool CheckReciprocalBlock(IUser viewer, IUser viewee, out string msg)
	{
		if (!Settings.Default.UserBlockingEnabled || viewer == null || viewee == null)
		{
			msg = "There was an error performing the action.";
			return false;
		}
		if (Badge.GetUserBadgesByUserID(viewer.Id).Any((Badge b) => b.BadgeTypeID == BadgeType.AdministratorID) || !_UserFactory.GetUser(viewer.Id).IsRegularUser())
		{
			msg = "";
			return false;
		}
		if (IsBlocked(viewee, viewer.Id))
		{
			msg = "That user has blocked this form of contact.";
			return true;
		}
		if (IsBlocked(viewer, viewee.Id))
		{
			msg = "You previously blocked that user. To unblock them, go to their profile page.";
			return true;
		}
		msg = "";
		return false;
	}

	public bool CheckReciprocalBlock(IUser viewer, IUser viewee)
	{
		string dummy;
		return CheckReciprocalBlock(viewer, viewee, out dummy);
	}

	public void SetBlockStatusInCache(IUser blocker, long blockeeId, bool isBlocked)
	{
		if (Settings.Default.IsUserBlockCachingEnabled)
		{
			_CacheClient.Set(CacheKeyForIsUserBlocked(blocker.Id, blockeeId), isBlocked, Settings.Default.UserBlockCacheExpiration);
		}
	}
}
