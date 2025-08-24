using System;
using Roblox.Permissions.Client;
using Roblox.Platform.Authentication;
using Roblox.Platform.Demographics;
using Roblox.Platform.Groups;
using Roblox.Platform.Localization.Accounts;
using Roblox.Platform.Membership;
using Roblox.Platform.Permissions.Core;
using Roblox.Platform.Permissions.Properties;
using Roblox.Platform.Social;

namespace Roblox.Platform.Permissions;

internal class UserPermissionTestFactory : IUserPermissionTestFactory
{
	private readonly ISettings _Settings;

	private readonly IPermissionsClient _PermissionsClient;

	private readonly IFriendshipFactory _FriendshipFactory;

	private readonly IXboxLiveAccountDataAccessor _XboxLiveAccountDataAccessor;

	private readonly IUserFactory _UserFactory;

	private readonly GroupDomainFactories _GroupDomainFactories;

	private readonly IAgeChecker _AgeChecker;

	private readonly ICountryFactory _CountryFactory;

	private readonly IAccountCountryAccessor _AccountCountryAccessor;

	private readonly IGeolocationProvider _GeolocationProvider;

	public UserPermissionTestFactory(ISettings settings, IPermissionsClient permissionsClient, IFriendshipFactory friendshipFactory, IXboxLiveAccountDataAccessor xboxLiveAccountDataAccessor, GroupDomainFactories groupDomainFactories, IUserFactory userFactory, IAgeChecker ageChecker, ICountryFactory countryFactory, IAccountCountryAccessor accountCountryAccessor, IGeolocationProvider geolocationProvider)
	{
		_Settings = settings ?? throw new ArgumentNullException("settings");
		_PermissionsClient = permissionsClient ?? throw new ArgumentNullException("permissionsClient");
		_FriendshipFactory = friendshipFactory ?? throw new ArgumentNullException("friendshipFactory");
		_XboxLiveAccountDataAccessor = xboxLiveAccountDataAccessor ?? throw new ArgumentNullException("xboxLiveAccountDataAccessor");
		_GroupDomainFactories = groupDomainFactories ?? throw new ArgumentNullException("groupDomainFactories");
		_UserFactory = userFactory ?? throw new ArgumentNullException("userFactory");
		_AgeChecker = ageChecker ?? throw new ArgumentNullException("ageChecker");
		_CountryFactory = countryFactory ?? throw new ArgumentNullException("countryFactory");
		_AccountCountryAccessor = accountCountryAccessor ?? throw new ArgumentNullException("accountCountryAccessor");
		_GeolocationProvider = geolocationProvider;
	}

	private EmailIsVerifiedPermissionTest GetEmailIsVerifiedPermissionTest(long? authenticatedUserId = null)
	{
		return new EmailIsVerifiedPermissionTest(authenticatedUserId);
	}

	private AccountAgeOverOneDayPermissionTest GetAccountAgeOverOneDayPermissionTest(long? authenticatedUserId = null)
	{
		return new AccountAgeOverOneDayPermissionTest(authenticatedUserId);
	}

	private IsInGroupRoleSetPermissionTest GetIsInGroupRoleSetPermissionTest(long? authenticatedUserId, long? targetId)
	{
		return new IsInGroupRoleSetPermissionTest(authenticatedUserId, targetId, _GroupDomainFactories, _UserFactory);
	}

	private IsInGroupPermissionTest GetIsInGroupPermissionTest(long? authenticatedUserId, long? targetId)
	{
		return new IsInGroupPermissionTest(authenticatedUserId, targetId, _UserFactory, _GroupDomainFactories.GroupFactory);
	}

	private IsFriendPermissionTest GetIsFriendPermissionTest(long? authenticatedUserId, long? targetId)
	{
		return new IsFriendPermissionTest(authenticatedUserId, targetId, _FriendshipFactory);
	}

	private IsFollowerPermissionTest GetIsFollowerPermissionTest(long? authenticatedUserId, long? targetId)
	{
		return new IsFollowerPermissionTest(authenticatedUserId, targetId, _FriendshipFactory);
	}

	private IsFollowedByPermissionTest GetIsFollowedByPermissionTest(long? authenticatedUserId, long? targetId)
	{
		return new IsFollowedByPermissionTest(authenticatedUserId, targetId, _FriendshipFactory);
	}

	private IsInListPermissionTest GetIsInListPermissionTest(long? authenticatedUserId, long? targetId)
	{
		return new IsInListPermissionTest(_PermissionsClient, authenticatedUserId, targetId);
	}

	private NoOnePermissionTest GetNoOnePermissionTest(long? authenticatedUserId = null)
	{
		return new NoOnePermissionTest(authenticatedUserId);
	}

	private UserIsAuthenticatedPermissionTest GetUserIsAuthenticatedPermissionTest(long? authenticatedUserId = null)
	{
		return new UserIsAuthenticatedPermissionTest(authenticatedUserId);
	}

	private AllUsersPermissionTest GetAllUsersPermissionTest(long? authenticatedUserId = null)
	{
		return new AllUsersPermissionTest(authenticatedUserId);
	}

	private IsAssetCreatorPermissionTest GetIsAssetCreatorPermissionTest(long? authenticatedUserId, long? actionTargetId)
	{
		return new IsAssetCreatorPermissionTest(authenticatedUserId, actionTargetId);
	}

	private IsInClanPermissionTest GetIsInClanPermissionTest(long? authenticatedUserId, long? targetId)
	{
		return new IsInClanPermissionTest(authenticatedUserId, targetId, _GroupDomainFactories, _UserFactory);
	}

	private IsXboxUserPermissionTest GetIsXboxUserPermissionTest(long? authenticatedUserId)
	{
		return new IsXboxUserPermissionTest(authenticatedUserId, _XboxLiveAccountDataAccessor, _UserFactory);
	}

	public IUserPermissionTest GetIsCoppaAdultAndNotGdprChildTest(IUser user)
	{
		return new IsCoppaAdultAndNotGdprChildTest(_Settings, user, _AgeChecker, _CountryFactory, _AccountCountryAccessor);
	}

	public IUserPermissionTest GetIsInGdprJurisdictionTest(IUser user)
	{
		return new IsInGdprJurisdictionTest(_Settings, user, _CountryFactory, _AccountCountryAccessor);
	}

	private IUserPermissionTest DoGetPermissionTest(IPermission permissionDefinition, IUser user, long? actionTargetId = null)
	{
		long? userId = user?.Id;
		if (!Enum.TryParse<PermissionType>(permissionDefinition.PermissionType, out var permissionType))
		{
			return null;
		}
		return permissionType switch
		{
			PermissionType.NoOne => GetNoOnePermissionTest(userId), 
			PermissionType.UserIsAuthenticated => GetUserIsAuthenticatedPermissionTest(userId), 
			PermissionType.AllUsers => GetAllUsersPermissionTest(userId), 
			PermissionType.EmailIsVerified => GetEmailIsVerifiedPermissionTest(userId), 
			PermissionType.AccountAgeOverOneDay => GetAccountAgeOverOneDayPermissionTest(userId), 
			PermissionType.IsAssetCreator => GetIsAssetCreatorPermissionTest(userId, actionTargetId), 
			PermissionType.IsFriend => GetIsFriendPermissionTest(userId, permissionDefinition.PermissionTypeTargetId), 
			PermissionType.IsBestFriend => GetIsFriendPermissionTest(userId, permissionDefinition.PermissionTypeTargetId), 
			PermissionType.IsFollower => GetIsFollowerPermissionTest(userId, permissionDefinition.PermissionTypeTargetId), 
			PermissionType.IsFollowedBy => GetIsFollowedByPermissionTest(userId, permissionDefinition.PermissionTypeTargetId), 
			PermissionType.IsInGroup => GetIsInGroupPermissionTest(userId, permissionDefinition.PermissionTypeTargetId), 
			PermissionType.IsInGroupRoleSet => GetIsInGroupRoleSetPermissionTest(userId, permissionDefinition.PermissionTypeTargetId), 
			PermissionType.IsInList => GetIsInListPermissionTest(userId, permissionDefinition.PermissionTypeTargetId), 
			PermissionType.IsInClan => GetIsInClanPermissionTest(userId, permissionDefinition.PermissionTypeTargetId), 
			PermissionType.IsXboxUser => GetIsXboxUserPermissionTest(userId), 
			PermissionType.IsCoppaAdultAndNotGdprChild => GetIsCoppaAdultAndNotGdprChildTest(user), 
			PermissionType.IsInGdprJurisdiction => GetIsInGdprJurisdictionTest(user), 
			_ => null, 
		};
	}

	public IUserPermissionTest GetPermissionTest(IPermission permissionDefinition, IUser user, long? actionTargetId = null)
	{
		return DoGetPermissionTest(permissionDefinition, user, actionTargetId);
	}
}
