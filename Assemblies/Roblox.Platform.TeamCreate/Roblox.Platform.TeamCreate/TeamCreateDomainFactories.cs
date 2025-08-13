using System.Diagnostics.CodeAnalysis;
using Roblox.EventLog;
using Roblox.Instrumentation;
using Roblox.PermissionResolution.Client;
using Roblox.Permissions.Client;
using Roblox.Platform.Assets;
using Roblox.Platform.CloudEdit.Permissions;
using Roblox.Platform.CloudEdit.Permissions.Factories;
using Roblox.Platform.Core;
using Roblox.Platform.Membership;
using Roblox.Platform.Permissions;
using Roblox.Platform.Social;
using Roblox.Platform.Social.Messages;
using Roblox.Platform.Studio;
using Roblox.Platform.TeamCreate.Events;
using Roblox.Platform.TeamCreate.Notifications;
using Roblox.Platform.Universes;
using Roblox.TeamCreate.Client;

namespace Roblox.Platform.TeamCreate;

/// <summary>
/// The domain factories for Roblox.Platform.TeamCreate
/// </summary>
[ExcludeFromCodeCoverage]
public class TeamCreateDomainFactories : DomainFactoriesBase
{
	/// <summary>
	/// The <see cref="T:Roblox.Platform.TeamCreate.ITeamCreatePermissionsVerifier" />
	/// </summary>
	public virtual ITeamCreatePermissionsVerifier TeamCreatePermissionsVerifier { get; }

	/// <summary>
	/// The <see cref="T:Roblox.Platform.TeamCreate.ITeamCreateMembershipFactory" />
	/// </summary>
	public virtual ITeamCreateMembershipFactory TeamCreateMembershipFactory { get; }

	/// <summary>
	/// The <see cref="T:Roblox.Platform.TeamCreate.ITeamCreatePermissionsAuthority" />
	/// </summary>
	public virtual ITeamCreatePermissionsAuthority TeamCreatePermissionsAuthority { get; }

	/// <summary>
	/// The <see cref="P:Roblox.Platform.TeamCreate.TeamCreateDomainFactories.CloudEditPermissionManagerFactory" /> for team create V1 permissions
	/// </summary>
	internal virtual CloudEditPermissionManagerFactory CloudEditPermissionManagerFactory { get; }

	internal virtual TeamCreateChangeReporter TeamCreateChangeReporter { get; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.TeamCreate.TeamCreateDomainFactories" /> class.
	/// </summary>
	/// <param name="teamCreateClient">The <see cref="T:Roblox.TeamCreate.Client.ITeamCreateClient" />.</param>
	/// <param name="universeFactory">The <see cref="T:Roblox.Platform.Universes.IUniverseFactory" />.</param>
	/// <param name="userFactory">The <see cref="T:Roblox.Platform.Membership.IUserFactory" />.</param>
	/// <param name="universePermissionsVerifier">The <see cref="T:Roblox.Platform.Universes.IUniversePermissionsVerifier" />.</param>
	/// <param name="friendshipFactory">The <see cref="T:Roblox.Platform.Social.IFriendshipFactory" />.</param>
	/// <param name="userPermissionsChecker">The <see cref="T:Roblox.Platform.Permissions.IUserPermissionsChecker" />.</param>
	/// <param name="permissionsClient">The <see cref="T:Roblox.Permissions.Client.IPermissionsClient" />.</param>
	/// <param name="systemMessageSender">The <see cref="T:Roblox.Platform.Social.Messages.ISystemMessageSender" />.</param>
	/// <param name="placeFactory">The <see cref="T:Roblox.Platform.Assets.IPlaceFactory" />.</param>
	/// <param name="permissionResolutionClient">The <see cref="T:Roblox.PermissionResolution.Client.IPermissionResolutionClient" />.</param>
	/// <param name="logger">The <see cref="T:Roblox.EventLog.ILogger" />.</param>
	/// <param name="counterRegistry">the counter registry (used by the <see cref="T:Roblox.Instrumentation.ICounterReporter" /> for telemetry)</param>
	public TeamCreateDomainFactories(ITeamCreateClient teamCreateClient, IUniverseFactory universeFactory, IUserFactory userFactory, IUniversePermissionsVerifier universePermissionsVerifier, IFriendshipFactory friendshipFactory, IUserPermissionsChecker userPermissionsChecker, IPermissionsClient permissionsClient, ISystemMessageSender systemMessageSender, IPlaceFactory placeFactory, IPermissionResolutionClient permissionResolutionClient, ILogger logger, ICounterRegistry counterRegistry)
		: this(teamCreateClient, universeFactory, userFactory, universePermissionsVerifier, friendshipFactory, userPermissionsChecker, permissionsClient, systemMessageSender, placeFactory, new TeamCreateEventsPublisher(logger, counterRegistry), permissionResolutionClient, logger, counterRegistry)
	{
	}

	/// <summary>
	/// Special use constructor. Only use for testing and when there's a well understood need.
	/// </summary>
	/// <param name="teamCreateClient">The <see cref="T:Roblox.TeamCreate.Client.ITeamCreateClient" />.</param>
	/// <param name="universeFactory">The <see cref="T:Roblox.Platform.Universes.IUniverseFactory" />.</param>
	/// <param name="userFactory">The <see cref="T:Roblox.Platform.Membership.IUserFactory" />.</param>
	/// <param name="universePermissionsVerifier">The <see cref="T:Roblox.Platform.Universes.IUniversePermissionsVerifier" />.</param>
	/// <param name="friendshipFactory">The <see cref="T:Roblox.Platform.Social.IFriendshipFactory" />.</param>
	/// <param name="userPermissionsChecker">The <see cref="T:Roblox.Platform.Permissions.IUserPermissionsChecker" />.</param>
	/// <param name="permissionsClient">The <see cref="T:Roblox.Permissions.Client.IPermissionsClient" />.</param>
	/// <param name="systemMessageSender">The <see cref="T:Roblox.Platform.Social.Messages.ISystemMessageSender" />.</param>
	/// <param name="placeFactory">The <see cref="T:Roblox.Platform.Assets.IPlaceFactory" />.</param>
	/// <param name="teamCreateEventsObserver">The <see cref="T:Roblox.Platform.TeamCreate.Events.ITeamCreateEventsObserver" />.</param>
	/// <param name="permissionResolutionClient">The <see cref="T:Roblox.PermissionResolution.Client.IPermissionResolutionClient" />.</param>
	/// <param name="logger">The <see cref="T:Roblox.EventLog.ILogger" />.</param>
	/// <param name="counterRegistry">the counter registry (used by the <see cref="T:Roblox.Instrumentation.ICounterReporter" /> for telemetry)</param>
	public TeamCreateDomainFactories(ITeamCreateClient teamCreateClient, IUniverseFactory universeFactory, IUserFactory userFactory, IUniversePermissionsVerifier universePermissionsVerifier, IFriendshipFactory friendshipFactory, IUserPermissionsChecker userPermissionsChecker, IPermissionsClient permissionsClient, ISystemMessageSender systemMessageSender, IPlaceFactory placeFactory, ITeamCreateEventsObserver teamCreateEventsObserver, IPermissionResolutionClient permissionResolutionClient, ILogger logger, ICounterRegistry counterRegistry)
	{
		if (teamCreateClient == null)
		{
			throw new PlatformArgumentNullException("teamCreateClient");
		}
		if (universeFactory == null)
		{
			throw new PlatformArgumentNullException("universeFactory");
		}
		if (userFactory == null)
		{
			throw new PlatformArgumentNullException("userFactory");
		}
		if (universePermissionsVerifier == null)
		{
			throw new PlatformArgumentNullException("universePermissionsVerifier");
		}
		if (friendshipFactory == null)
		{
			throw new PlatformArgumentNullException("friendshipFactory");
		}
		if (userPermissionsChecker == null)
		{
			throw new PlatformArgumentNullException("userPermissionsChecker");
		}
		if (permissionsClient == null)
		{
			throw new PlatformArgumentNullException("permissionsClient");
		}
		if (systemMessageSender == null)
		{
			throw new PlatformArgumentNullException("systemMessageSender");
		}
		if (placeFactory == null)
		{
			throw new PlatformArgumentNullException("placeFactory");
		}
		if (teamCreateEventsObserver == null)
		{
			throw new PlatformArgumentNullException("teamCreateEventsObserver");
		}
		if (permissionResolutionClient == null)
		{
			throw new PlatformArgumentNullException("permissionResolutionClient");
		}
		UniverseCloudEditStatusProvider universeCloudEditStatusProvider = new UniverseCloudEditStatusProvider(universeFactory);
		CloudEditEventHandlerRegistrar cloudEditEventHandlerRegistrar = new CloudEditEventHandlerRegistrar(systemMessageSender, universeFactory, placeFactory, logger);
		CloudEditPermissionManagerFactory cloudEditPermissionManagerFactory = (CloudEditPermissionManagerFactory = new CloudEditPermissionManagerFactory(universeFactory, permissionsClient, universeCloudEditStatusProvider, userPermissionsChecker, universePermissionsVerifier, cloudEditEventHandlerRegistrar));
		TeamCreatePermissionsVerifier teamCreatePermissionsVerifier = (TeamCreatePermissionsVerifier)(TeamCreatePermissionsVerifier = new TeamCreatePermissionsVerifier(teamCreateClient, universePermissionsVerifier, friendshipFactory, universeCloudEditStatusProvider, permissionResolutionClient));
		TeamCreateMembershipFactory = new TeamCreateMembershipFactory(this, teamCreateClient, teamCreatePermissionsVerifier, cloudEditPermissionManagerFactory, universeFactory, userFactory);
		TeamCreateEventPublisher teamCreateNotificationPublisher = new TeamCreateEventPublisher(counterRegistry);
		TeamCreatePermissionsAuthority teamCreatePermissionsAuthority = new TeamCreatePermissionsAuthority(this, teamCreateClient, teamCreatePermissionsVerifier, cloudEditPermissionManagerFactory, teamCreateNotificationPublisher, universeCloudEditStatusProvider);
		TeamCreatePermissionsAuthority = teamCreatePermissionsAuthority;
		teamCreateEventsObserver.Subscribe(TeamCreateChangeReporter = new TeamCreateChangeReporter());
	}
}
