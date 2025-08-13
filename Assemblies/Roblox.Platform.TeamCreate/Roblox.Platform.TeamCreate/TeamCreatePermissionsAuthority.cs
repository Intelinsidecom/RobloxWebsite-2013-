using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.ApiClientBase;
using Roblox.Platform.CloudEdit.Permissions;
using Roblox.Platform.CloudEdit.Permissions.Exceptions;
using Roblox.Platform.Core;
using Roblox.Platform.Membership;
using Roblox.Platform.Studio;
using Roblox.Platform.TeamCreate.Events;
using Roblox.Platform.TeamCreate.Notifications;
using Roblox.Platform.TeamCreate.Properties;
using Roblox.Platform.Universes;
using Roblox.TeamCreate.Client;

namespace Roblox.Platform.TeamCreate;

internal class TeamCreatePermissionsAuthority : ITeamCreatePermissionsAuthority
{
	private readonly TeamCreateDomainFactories _DomainFactories;

	private readonly ITeamCreateClient _TeamCreateClient;

	private readonly ITeamCreatePermissionsVerifier _TeamCreatePermissionsVerifier;

	private readonly ICloudEditPermissionManagerFactory _CloudEditPermissionManagerFactory;

	private readonly ITeamCreateEventPublisher _NotificationPublisher;

	private readonly IUniverseCloudEditStatusProvider _UniverseCloudEditStatusProvider;

	[ExcludeFromCodeCoverage]
	internal virtual bool IsTeamCreatePermissionsV1WriteEnabled => Settings.Default.IsTeamCreatePermissionsV1WriteEnabled;

	internal TeamCreatePermissionsAuthority(TeamCreateDomainFactories domainFactories, ITeamCreateClient teamCreateClient, ITeamCreatePermissionsVerifier teamCreatePermissionsVerifier, ICloudEditPermissionManagerFactory cloudEditPermissionManagerFactory, ITeamCreateEventPublisher notificationPublisher, IUniverseCloudEditStatusProvider universeCloudEditStatusProvider)
	{
		_DomainFactories = domainFactories ?? throw new ArgumentNullException("domainFactories");
		_TeamCreateClient = teamCreateClient ?? throw new ArgumentNullException("teamCreateClient");
		_TeamCreatePermissionsVerifier = teamCreatePermissionsVerifier ?? throw new ArgumentNullException("teamCreatePermissionsVerifier");
		_CloudEditPermissionManagerFactory = cloudEditPermissionManagerFactory ?? throw new ArgumentNullException("cloudEditPermissionManagerFactory");
		_NotificationPublisher = notificationPublisher ?? throw new ArgumentNullException("notificationPublisher");
		_UniverseCloudEditStatusProvider = universeCloudEditStatusProvider ?? throw new ArgumentNullException("universeCloudEditStatusProvider");
	}

	/// <inheritdoc cref="M:Roblox.Platform.TeamCreate.ITeamCreatePermissionsAuthority.AddTeamCreateMember(Roblox.Platform.Membership.IUser,Roblox.Platform.Membership.IUser,Roblox.Platform.Universes.IUniverse)" />
	public void AddTeamCreateMember(IUser user, IUser targetUser, IUniverse universe)
	{
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		if (user == null)
		{
			throw new PlatformArgumentNullException("user");
		}
		if (targetUser == null)
		{
			throw new PlatformArgumentNullException("targetUser");
		}
		if (universe == null)
		{
			throw new PlatformArgumentNullException("universe");
		}
		if (!_TeamCreatePermissionsVerifier.CanUserAddTeamCreateMember(user, targetUser, universe))
		{
			throw new PlatformInvalidOperationException(string.Format("{0} is not allowed to add {1}", "targetUser", "user"));
		}
		if (IsTeamCreatePermissionsV1WriteEnabled)
		{
			try
			{
				_CloudEditPermissionManagerFactory.GetPermissionManagerForUniverse(universe.Id).AddUserToEditorsList(targetUser, user);
				_DomainFactories.TeamCreateChangeReporter.EntityChanged(universe.Id, TeamCreateChangeType.MembershipChanged, targetUser.Id);
			}
			catch (CloudEditPermissionsPlatformException e2)
			{
				throw new PlatformOperationUnavailableException("TeamCreate service call failed", e2);
			}
		}
		try
		{
			if ((int)_TeamCreateClient.AddTeamCreateMembership(targetUser.ToMembershipTarget(), universe.ToUniverseIdentifier()).OperationStatus == 0)
			{
				_DomainFactories.TeamCreateChangeReporter.EntityChanged(universe.Id, TeamCreateChangeType.MembershipChanged, targetUser.Id);
				_NotificationPublisher.PublishTeamCreateInvitation(user, targetUser, universe);
			}
		}
		catch (ApiClientException e)
		{
			throw new PlatformOperationUnavailableException("TeamCreate service call failed", e);
		}
	}

	/// <inheritdoc cref="M:Roblox.Platform.TeamCreate.ITeamCreatePermissionsAuthority.RemoveTeamCreateMember(Roblox.Platform.Membership.IUser,Roblox.Platform.Membership.IUser,Roblox.Platform.Universes.IUniverse)" />
	public void RemoveTeamCreateMember(IUser user, IUser targetUser, IUniverse universe)
	{
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		if (user == null)
		{
			throw new PlatformArgumentNullException("user");
		}
		if (targetUser == null)
		{
			throw new PlatformArgumentNullException("targetUser");
		}
		if (universe == null)
		{
			throw new PlatformArgumentNullException("universe");
		}
		if (!_TeamCreatePermissionsVerifier.CanUserRemoveTeamCreateMember(user, targetUser, universe))
		{
			throw new PlatformInvalidOperationException(string.Format("{0} is not allowed to remove {1}", "targetUser", "user"));
		}
		if (IsTeamCreatePermissionsV1WriteEnabled)
		{
			try
			{
				_CloudEditPermissionManagerFactory.GetPermissionManagerForUniverse(universe.Id).RemoveUserFromEditorsList(targetUser);
				_DomainFactories.TeamCreateChangeReporter.EntityChanged(universe.Id, TeamCreateChangeType.MembershipChanged, targetUser.Id);
			}
			catch (CloudEditPermissionsPlatformException e2)
			{
				throw new PlatformOperationUnavailableException("TeamCreate service call failed", e2);
			}
		}
		try
		{
			if ((int)_TeamCreateClient.RemoveTeamCreateMembership(targetUser.ToMembershipTarget(), universe.ToUniverseIdentifier()).OperationStatus == 0)
			{
				_DomainFactories.TeamCreateChangeReporter.EntityChanged(universe.Id, TeamCreateChangeType.MembershipChanged, targetUser.Id);
				_NotificationPublisher.PublishTeamCreateRevokedInvitation(user, targetUser, universe);
			}
		}
		catch (ApiClientException e)
		{
			throw new PlatformOperationUnavailableException("TeamCreate service call failed", e);
		}
	}

	/// <inheritdoc cref="M:Roblox.Platform.TeamCreate.ITeamCreatePermissionsAuthority.EnableTeamCreate(Roblox.Platform.Universes.IUniverse)" />
	public void EnableTeamCreate(IUniverse universe)
	{
		if (universe == null)
		{
			throw new PlatformArgumentNullException("universe");
		}
		try
		{
			_CloudEditPermissionManagerFactory.GetPermissionManagerForUniverse(universe.Id).EnableForCloudEdit();
			_DomainFactories.TeamCreateChangeReporter.EntityChanged(universe.Id, TeamCreateChangeType.StatusChanged, null);
			if (!_TeamCreatePermissionsVerifier.IsTeamCreateEnabled(universe))
			{
				_UniverseCloudEditStatusProvider.UpdateCloudEditStatus(universe.Id, isCloudEditEnabled: true);
			}
		}
		catch (ApiClientException e)
		{
			throw new PlatformOperationUnavailableException("TeamCreate service call failed", e);
		}
	}

	/// <inheritdoc cref="M:Roblox.Platform.TeamCreate.ITeamCreatePermissionsAuthority.DisableTeamCreate(Roblox.Platform.Universes.IUniverse)" />
	public void DisableTeamCreate(IUniverse universe)
	{
		if (universe == null)
		{
			throw new PlatformArgumentNullException("universe");
		}
		try
		{
			_CloudEditPermissionManagerFactory.GetPermissionManagerForUniverse(universe.Id).DisableForCloudEdit();
			_DomainFactories.TeamCreateChangeReporter.EntityChanged(universe.Id, TeamCreateChangeType.StatusChanged, null);
			if (_TeamCreatePermissionsVerifier.IsTeamCreateEnabled(universe))
			{
				_UniverseCloudEditStatusProvider.UpdateCloudEditStatus(universe.Id, isCloudEditEnabled: false);
			}
		}
		catch (ApiClientException e)
		{
			throw new PlatformOperationUnavailableException("TeamCreate service call failed", e);
		}
	}
}
