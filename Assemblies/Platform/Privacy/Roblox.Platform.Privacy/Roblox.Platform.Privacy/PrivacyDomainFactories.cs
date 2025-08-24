using Roblox.Caching.Shared;
using Roblox.EventLog;
using Roblox.Locking;
using Roblox.Permissions.Client;
using Roblox.Platform.Core;
using Roblox.Platform.Permissions.Core;
using Roblox.Platform.Privacy.Properties;

namespace Roblox.Platform.Privacy;

/// <summary>
/// Factories for managing a user's privacy settings
/// </summary>
public class PrivacyDomainFactories
{
	/// <summary>
	/// See <see cref="T:Roblox.Platform.Privacy.IUserPrivacyAccessor" />
	/// </summary>
	public virtual IUserPrivacyAccessor UserPrivacyAccessor { get; private set; }

	/// <summary>
	/// See <see cref="T:Roblox.Platform.Privacy.IChatPrivacySettingAccessor" /> 
	/// </summary>
	public virtual IChatPrivacySettingAccessor ChatPrivacyAccessor { get; private set; }

	/// <summary>
	/// See <see cref="T:Roblox.Platform.Privacy.IPhoneDiscoveryPrivacyAccessor" /> 
	/// </summary>
	public virtual IPhoneDiscoveryPrivacyAccessor PhoneDiscoveryPrivacyAccessor { get; private set; }

	/// <summary>
	/// See <see cref="T:Roblox.Platform.Privacy.IDisplayInventoryPrivacyAccessor" /> 
	/// </summary>
	public virtual IDisplayInventoryPrivacyAccessor DisplayInventoryPrivacyAccessor { get; private set; }

	/// <exception>Throws <see cref="T:Roblox.Platform.Core.PlatformArgumentNullException" /> Thrown if any of the parameters are null</exception>
	public PrivacyDomainFactories(IPermissionGroupFactory permissionGroupFactory, IPermissionsClient permissionsClient, ILogger logger, ISharedCacheClient cacheClient, ILeasedLockFactory leasedLockFactory)
	{
		if (permissionGroupFactory == null)
		{
			throw new PlatformArgumentNullException("permissionGroupFactory");
		}
		if (permissionsClient == null)
		{
			throw new PlatformArgumentNullException("permissionsClient");
		}
		if (cacheClient == null)
		{
			throw new PlatformArgumentNullException("cacheClient");
		}
		if (logger == null)
		{
			throw new PlatformArgumentNullException("logger");
		}
		if (leasedLockFactory == null)
		{
			throw new PlatformArgumentNullException("leasedLockFactory");
		}
		UserPrivacyAccessor = new UserPrivacyAccessor(permissionGroupFactory, permissionsClient, logger, Settings.Default, leasedLockFactory);
		UserPrivacySettingCALAccessor userPrivacyCAL = new UserPrivacySettingCALAccessor(UserPrivacyAccessor, cacheClient, logger);
		ChatPrivacyAccessor = new ChatPrivacySettingAccessor(userPrivacyCAL);
		PhoneDiscoveryPrivacyAccessor = new PhoneDiscoveryPrivacyAccessor(userPrivacyCAL);
		DisplayInventoryPrivacyAccessor = new DisplayInventoryPrivacyAccessor(userPrivacyCAL);
	}
}
