using System.Collections.Generic;
using Roblox.ApiClientBase;
using Roblox.Permissions.Client;
using Roblox.Platform.CloudEdit.Permissions.Exceptions;
using Roblox.Platform.CloudEdit.Permissions.Implementation;
using Roblox.Platform.CloudEdit.Permissions.Properties;
using Roblox.Platform.Core;
using Roblox.Platform.Permissions;
using Roblox.Platform.Permissions.Core;
using Roblox.Platform.Studio;
using Roblox.Platform.Universes;

namespace Roblox.Platform.CloudEdit.Permissions.Factories;

/// <summary>
/// Factory for ICloudEditPermissionManager
/// </summary>
public class CloudEditPermissionManagerFactory : ICloudEditPermissionManagerFactory
{
	private readonly IUniverseFactory _UniverseFactory;

	private readonly IPermissionsClient _PermissionsClient;

	private readonly IPermissionGroupFactory _PermissionGroupFactory;

	private readonly ICustomListFactory _CustomListFactory;

	private readonly IUserPermissionsChecker _UserPermissionsChecker;

	private readonly IUniverseCloudEditStatusProvider _UniverseCloudEditStatusProvider;

	private readonly ICloudEditEventHandlerRegistrar _CloudEditEventHandlerRegistrar;

	private readonly IUniversePermissionsVerifier _UniversePermissionsVerifier;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.CloudEdit.Permissions.Factories.CloudEditPermissionManagerFactory" /> class.
	/// </summary>
	/// <param name="universeFactory">The <see cref="T:Roblox.Platform.Universes.IUniverseFactory" />.</param>
	/// <param name="permissionsClient">The <see cref="T:Roblox.Permissions.Client.IPermissionsClient" />.</param>
	/// <param name="universeCloudEditStatusProvider">The <see cref="T:Roblox.Platform.Studio.IUniverseCloudEditStatusProvider" />.</param>
	/// <param name="userPermissionsChecker">The <see cref="T:Roblox.Platform.Permissions.IUserPermissionsChecker" />.</param>
	/// <param name="universePermissionsVerifier">The <see cref="T:Roblox.Platform.Universes.IUniversePermissionsVerifier" />.</param>
	/// <param name="cloudEditEventHandlerRegistrar">The <see cref="T:Roblox.Platform.CloudEdit.Permissions.ICloudEditEventHandlerRegistrar" />. (nullable)</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Any arguments are null.</exception>
	public CloudEditPermissionManagerFactory(IUniverseFactory universeFactory, IPermissionsClient permissionsClient, IUniverseCloudEditStatusProvider universeCloudEditStatusProvider, IUserPermissionsChecker userPermissionsChecker, IUniversePermissionsVerifier universePermissionsVerifier, ICloudEditEventHandlerRegistrar cloudEditEventHandlerRegistrar = null)
	{
		_UniverseFactory = universeFactory.AssignOrThrowIfNull("universeFactory");
		_PermissionsClient = permissionsClient.AssignOrThrowIfNull<IPermissionsClient>("permissionsClient");
		_PermissionGroupFactory = new PermissionGroupFactory(permissionsClient);
		_CustomListFactory = new CustomListFactory(permissionsClient);
		_UniverseCloudEditStatusProvider = universeCloudEditStatusProvider.AssignOrThrowIfNull("universeCloudEditStatusProvider");
		_UserPermissionsChecker = userPermissionsChecker.AssignOrThrowIfNull("userPermissionsChecker");
		_UniversePermissionsVerifier = universePermissionsVerifier.AssignOrThrowIfNull("universePermissionsVerifier");
		_CloudEditEventHandlerRegistrar = cloudEditEventHandlerRegistrar;
	}

	/// <summary>
	/// Returns if no users should be able to access the feature
	/// </summary>
	public static bool FeatureDisabledForAll()
	{
		if (!Settings.Default.PublicBetaEnabled)
		{
			return !Settings.Default.GlobalEnabled;
		}
		return false;
	}

	/// <inheritdoc />
	public ICloudEditPermissionManager GetPermissionManagerForUniverse(long universeId)
	{
		try
		{
			CloudEditPermissionManager cloudEditPermissionManager = new CloudEditPermissionManager(_UniverseFactory.GetUniverse(universeId) ?? throw new CloudEditPermissionsPlatformException("Unknown universe"), _PermissionsClient, _PermissionGroupFactory, _CustomListFactory, _UserPermissionsChecker, _UniverseCloudEditStatusProvider, _UniversePermissionsVerifier);
			cloudEditPermissionManager.UserAddedToCloudEdit += _CloudEditEventHandlerRegistrar.OnUserAddedToCloudEdit;
			return cloudEditPermissionManager;
		}
		catch (ApiClientException e)
		{
			throw new CloudEditPermissionsPlatformException(e);
		}
	}

	public ICollection<ICloudEditPermissionManager> MultiGetPermissionManagersForUniverses(ICollection<long> universeIds)
	{
		try
		{
			IEnumerable<IUniverse> universes = _UniverseFactory.GetUniverses(universeIds);
			List<ICloudEditPermissionManager> cloudEditPermissionManagers = new List<ICloudEditPermissionManager>();
			foreach (IUniverse universe in universes)
			{
				if (universe != null)
				{
					CloudEditPermissionManager cloudEditPermissionManager = new CloudEditPermissionManager(universe, _PermissionsClient, _PermissionGroupFactory, _CustomListFactory, _UserPermissionsChecker, _UniverseCloudEditStatusProvider, _UniversePermissionsVerifier);
					cloudEditPermissionManager.UserAddedToCloudEdit += _CloudEditEventHandlerRegistrar.OnUserAddedToCloudEdit;
					cloudEditPermissionManagers.Add(cloudEditPermissionManager);
				}
			}
			return cloudEditPermissionManagers;
		}
		catch (ApiClientException e)
		{
			throw new CloudEditPermissionsPlatformException(e);
		}
	}
}
