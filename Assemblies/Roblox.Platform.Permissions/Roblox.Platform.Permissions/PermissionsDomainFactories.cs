using System;
using Roblox.EventLog;
using Roblox.Permissions.Client;
using Roblox.Platform.Authentication;
using Roblox.Platform.Demographics;
using Roblox.Platform.Groups;
using Roblox.Platform.Localization.Accounts;
using Roblox.Platform.Membership;
using Roblox.Platform.Permissions.Core.Properties;
using Roblox.Platform.Permissions.Properties;
using Roblox.Platform.Social;

namespace Roblox.Platform.Permissions;

/// <summary>
/// The domain factories for Permissions.
/// </summary>
public class PermissionsDomainFactories
{
	internal virtual Roblox.Platform.Permissions.Core.Properties.ISettings CoreSettings => Roblox.Platform.Permissions.Core.Properties.Settings.Default;

	internal virtual Roblox.Platform.Permissions.Properties.ISettings Settings => Roblox.Platform.Permissions.Properties.Settings.Default;

	/// <summary>
	/// The <see cref="T:Roblox.Platform.Permissions.IUserPermissionsChecker" />
	/// </summary>
	public virtual IUserPermissionsChecker UserPermissionsChecker { get; }

	public PermissionsDomainFactories(ILogger logger, IPermissionsClient permissionsClient, IAgeChecker ageChecker, ICountryFactory countryFactory, IUserFactory userFactory, IAccountCountryAccessor accountCountryAccessor, GroupDomainFactories groupDomainFactories, IFriendshipFactory friendshipFactory, IXboxLiveAccountDataAccessor xboxLiveAccountDataAccessor)
		: this(logger, permissionsClient, ageChecker, countryFactory, userFactory, accountCountryAccessor, groupDomainFactories, friendshipFactory, xboxLiveAccountDataAccessor, null)
	{
	}

	public PermissionsDomainFactories(ILogger logger, IPermissionsClient permissionsClient, IAgeChecker ageChecker, ICountryFactory countryFactory, IUserFactory userFactory, IAccountCountryAccessor accountCountryAccessor, GroupDomainFactories groupDomainFactories, IFriendshipFactory friendshipFactory, IXboxLiveAccountDataAccessor xboxLiveAccountDataAccessor, IGeolocationProvider geolocationProvider)
	{
		if (logger == null)
		{
			throw new ArgumentNullException("logger");
		}
		if (permissionsClient == null)
		{
			throw new ArgumentNullException("permissionsClient");
		}
		if (ageChecker == null)
		{
			throw new ArgumentNullException("ageChecker");
		}
		if (countryFactory == null)
		{
			throw new ArgumentNullException("countryFactory");
		}
		if (userFactory == null)
		{
			throw new ArgumentNullException("userFactory");
		}
		if (accountCountryAccessor == null)
		{
			throw new ArgumentNullException("accountCountryAccessor");
		}
		if (groupDomainFactories == null)
		{
			throw new ArgumentNullException("groupDomainFactories");
		}
		if (friendshipFactory == null)
		{
			throw new ArgumentNullException("friendshipFactory");
		}
		if (xboxLiveAccountDataAccessor == null)
		{
			throw new ArgumentNullException("xboxLiveAccountDataAccessor");
		}
		Roblox.Platform.Permissions.Core.Properties.ISettings coreSettings = CoreSettings;
		UserPermissionTestFactory userPermissionTestFactory = new UserPermissionTestFactory(Settings, permissionsClient, friendshipFactory, xboxLiveAccountDataAccessor, groupDomainFactories, userFactory, ageChecker, countryFactory, accountCountryAccessor, geolocationProvider);
		UserPermissionsChecker = new UserPermissionsChecker(permissionsClient, userPermissionTestFactory, logger, coreSettings);
	}
}
