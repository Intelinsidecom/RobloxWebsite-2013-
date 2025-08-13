using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Roblox.ApiClientBase;
using Roblox.DataV2.Core;
using Roblox.Platform.CloudEdit.Permissions;
using Roblox.Platform.CloudEdit.Permissions.Exceptions;
using Roblox.Platform.Core;
using Roblox.Platform.Core.ExclusiveStartPaging;
using Roblox.Platform.Membership;
using Roblox.Platform.Universes;
using Roblox.TeamCreate.Client;

namespace Roblox.Platform.TeamCreate;

internal class TeamCreateMembershipFactory : ITeamCreateMembershipFactory
{
	private readonly TeamCreateDomainFactories _DomainFactories;

	private readonly ITeamCreateClient _TeamCreateClient;

	private readonly ITeamCreatePermissionsVerifier _TeamCreatePermissionsVerifier;

	private readonly IUniverseFactory _UniverseFactory;

	private readonly IUserFactory _UserFactory;

	private readonly ICloudEditPermissionManagerFactory _CloudEditPermissionManagerFactory;

	private readonly TeamCreateMembershipTargetType _TargetType;

	internal TeamCreateMembershipFactory(TeamCreateDomainFactories domainFactories, ITeamCreateClient teamCreateClient, ITeamCreatePermissionsVerifier teamCreatePermissionsVerifier, ICloudEditPermissionManagerFactory cloudEditPermissionManagerFactory, IUniverseFactory universeFactory, IUserFactory userFactory)
	{
		_DomainFactories = domainFactories.AssignOrThrowIfNull("domainFactories");
		_TeamCreateClient = teamCreateClient.AssignOrThrowIfNull<ITeamCreateClient>("teamCreateClient");
		_TeamCreatePermissionsVerifier = teamCreatePermissionsVerifier.AssignOrThrowIfNull("teamCreatePermissionsVerifier");
		_UniverseFactory = universeFactory.AssignOrThrowIfNull("universeFactory");
		_UserFactory = userFactory.AssignOrThrowIfNull("userFactory");
		_CloudEditPermissionManagerFactory = cloudEditPermissionManagerFactory.AssignOrThrowIfNull("cloudEditPermissionManagerFactory");
	}

	public IPlatformPageResponse<ITeamCreateMembership, ITeamCreateMembership> GetUniverseTeamCreateMembers(IUniverse universe, IExclusiveStartKeyInfo<ITeamCreateMembership> exclusiveStartInfo)
	{
		if (universe == null)
		{
			throw new PlatformArgumentNullException("universe");
		}
		if (exclusiveStartInfo == null)
		{
			throw new PlatformArgumentNullException("exclusiveStartInfo");
		}
		exclusiveStartInfo.TryGetExclusiveStartKey(out var exclusiveStartMember);
		IReadOnlyCollection<TeamCreateMembership> memberships;
		try
		{
			memberships = _TeamCreateClient.GetTeamCreateMembershipsByUniverse(universe.ToUniverseIdentifier(), ConvertToDto(exclusiveStartMember), exclusiveStartInfo.Count + 1, ConvertToClientSortOrder(exclusiveStartInfo)).Memberships;
		}
		catch (ApiClientException e)
		{
			throw new PlatformOperationUnavailableException("TeamCreate service request failed", e);
		}
		return new PlatformPageResponse<ITeamCreateMembership, ITeamCreateMembership>(memberships.Where(delegate(TeamCreateMembership tcm)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			TeamCreateMembershipTargetType targetType = tcm.Target.TargetType;
			return ((object)(TeamCreateMembershipTargetType)(ref targetType)).Equals((object)_TargetType);
		}).Select(ConvertFromDto).ToArray(), exclusiveStartInfo, (ITeamCreateMembership tcm) => tcm);
	}

	public IPlatformPageResponse<ITeamCreateMembership, ITeamCreateMembership> GetUserTeamCreateMemberships(IUser user, IExclusiveStartKeyInfo<ITeamCreateMembership> exclusiveStartInfo)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("user");
		}
		if (exclusiveStartInfo == null)
		{
			throw new PlatformArgumentNullException("exclusiveStartInfo");
		}
		exclusiveStartInfo.TryGetExclusiveStartKey(out var exclusiveStartMembership);
		IReadOnlyCollection<TeamCreateMembership> memberships;
		try
		{
			memberships = _TeamCreateClient.GetTeamCreateMembershipsByMembershipTarget(user.ToMembershipTarget(), ConvertToDto(exclusiveStartMembership), exclusiveStartInfo.Count + 1, ConvertToClientSortOrder(exclusiveStartInfo)).Memberships;
		}
		catch (ApiClientException e2)
		{
			throw new PlatformOperationUnavailableException("TeamCreate service request failed", e2);
		}
		IEnumerable<TeamCreateMembership> userMemberships = memberships.Where(delegate(TeamCreateMembership membership)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			TeamCreateMembershipTargetType targetType = membership.Target.TargetType;
			return ((object)(TeamCreateMembershipTargetType)(ref targetType)).Equals((object)_TargetType);
		});
		List<ITeamCreateMembership> cloudEditEnabledMemberships = new List<ITeamCreateMembership>();
		List<long> universeIds = userMemberships.Select((TeamCreateMembership membership) => membership.Universe.Id).ToList();
		try
		{
			IUniverse[] universes = _UniverseFactory.GetUniverses(universeIds).ToArray();
			for (int u = 0; u < universes.Length; u++)
			{
				IUniverse universe = universes[u];
				if (universe != null && _TeamCreatePermissionsVerifier.IsTeamCreateEnabled(universe))
				{
					ITeamCreateMembership membership2 = ConvertFromDto(userMemberships.ElementAt(u));
					cloudEditEnabledMemberships.Add(membership2);
				}
			}
		}
		catch (ApiClientException e)
		{
			throw new PlatformOperationUnavailableException("TeamCreate service request failed", e);
		}
		return new PlatformPageResponse<ITeamCreateMembership, ITeamCreateMembership>(cloudEditEnabledMemberships.ToArray(), exclusiveStartInfo, (ITeamCreateMembership tcm) => tcm);
	}

	/// <summary>
	/// Gets a list of universe team create members paged.
	/// </summary>
	/// <remarks>
	/// Excluded from code coverage because it is just a wrapper for external obsolete functionality.
	/// </remarks>
	/// <param name="universe">The <see cref="T:Roblox.Platform.Universes.IUniverse" />.</param>
	/// <param name="pageNumber">The page number.</param>
	/// <returns><see cref="T:System.Collections.Generic.ICollection`1" /></returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">universe</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">pageNumber</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Permissions service request failed</exception>
	[ExcludeFromCodeCoverage]
	[Obsolete("Use GetUniverseTeamCreateMembers")]
	public ICollection<IUser> GetUniverseTeamCreateMembersPaged(IUniverse universe, int pageNumber)
	{
		if (universe == null)
		{
			throw new PlatformArgumentNullException("universe");
		}
		if (pageNumber <= 0)
		{
			throw new PlatformArgumentException("pageNumber");
		}
		try
		{
			return (from u in _CloudEditPermissionManagerFactory.GetPermissionManagerForUniverse(universe.Id).GetEditorsListPage(pageNumber)
				select _UserFactory.GetUser(u)).ToArray();
		}
		catch (CloudEditPermissionsPlatformException e)
		{
			throw new PlatformOperationUnavailableException("Permissions service request failed", e);
		}
	}

	private static TeamCreateMembership ConvertToDto(ITeamCreateMembership membership)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		if (membership?.User == null || membership.Universe == null)
		{
			return null;
		}
		return new TeamCreateMembership
		{
			Target = membership.User.ToMembershipTarget(),
			Universe = membership.Universe.ToUniverseIdentifier(),
			GrantDateTime = membership.GrantDate
		};
	}

	private static Roblox.ApiClientBase.SortOrder ConvertToClientSortOrder(IExclusiveStartKeyInfo<ITeamCreateMembership> exclusiveStartKeyInfo)
	{
		if (!exclusiveStartKeyInfo.GetDatabaseRequestSortOrder().Equals(Roblox.DataV2.Core.SortOrder.Asc))
		{
			return Roblox.ApiClientBase.SortOrder.Desc;
		}
		return Roblox.ApiClientBase.SortOrder.Asc;
	}

	private ITeamCreateMembership ConvertFromDto(TeamCreateMembership dto)
	{
		return new TeamCreateMembership
		{
			GrantDate = dto.GrantDateTime,
			Universe = _UniverseFactory.GetUniverse(dto.Universe.Id),
			User = _UserFactory.GetUser(dto.Target.TargetId)
		};
	}
}
