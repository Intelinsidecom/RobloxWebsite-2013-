using System;
using Roblox.EventLog;
using Roblox.GameLocalization.Client;
using Roblox.GameLocalization.Client.AutoLocalization;
using Roblox.GameLocalization.Client.GameLocalizationRoles;
using Roblox.InGameContentTables.Client;
using Roblox.Platform.Core;
using Roblox.Platform.GameLocalization.Authorization.Properties;
using Roblox.Platform.Groups;
using Roblox.Platform.Membership;
using Roblox.Platform.Universes;

namespace Roblox.Platform.GameLocalization.Authorization;

internal class GroupOwnedTableAuthorizer : IGameLocalizationAuthorizer
{
	protected readonly IGroupMembershipFactory GroupMembershipFactory;

	protected readonly IGroupFactory GroupFactory;

	protected readonly ILogger _Logger;

	private readonly IGameLocalizationRolesClient _GameLocalizationRolesClient;

	private readonly IUniverseFactory _UniverseFactory;

	private readonly IAutoLocalizationClient _AutoLocalizationClient;

	private readonly ISettings _Settings;

	public GroupOwnedTableAuthorizer(IGroupFactory groupFactory, IGroupMembershipFactory groupMembershipFactory, IGameLocalizationRolesClient gameLocalizationRolesClient, IUniverseFactory universeFactory, IAutoLocalizationClient autoLocalizationClient, ISettings settings, ILogger logger)
	{
		GroupMembershipFactory = groupMembershipFactory ?? throw new PlatformArgumentNullException("groupMembershipFactory");
		GroupFactory = groupFactory ?? throw new PlatformArgumentNullException("groupFactory");
		_GameLocalizationRolesClient = gameLocalizationRolesClient ?? throw new PlatformArgumentNullException("gameLocalizationRolesClient");
		_UniverseFactory = universeFactory ?? throw new PlatformArgumentNullException("universeFactory");
		_AutoLocalizationClient = autoLocalizationClient ?? throw new PlatformArgumentNullException("autoLocalizationClient");
		_Settings = settings ?? throw new PlatformArgumentNullException("settings");
		_Logger = logger ?? throw new PlatformArgumentNullException("logger");
	}

	public bool IsAuthorizedToEdit(Table table, IActor actor)
	{
		return AuthorizeGroupRequest(table, actor);
	}

	public bool IsAuthorizedToEditGroupTables(IGroup group, IActor actor)
	{
		return IsManageGroupGamesPermissionsEnabled(group, actor);
	}

	public bool IsAuthorizedToViewAutoLocalizationInformation(IUniverse universe, IActor actor)
	{
		if (!AuthorizeUniverseGroupRequest(universe, actor))
		{
			return IsActorInTranslatorRole(universe, actor);
		}
		return true;
	}

	public bool IsAuthorizedToEditAutoLocalizationInformation(IUniverse universe, IActor actor)
	{
		return AuthorizeUniverseGroupRequest(universe, actor);
	}

	public bool IsAuthorizedToView(Table table, IActor actor)
	{
		return AuthorizeGroupRequest(table, actor);
	}

	public bool IsAuthorizedToViewGroupTables(IGroup group, IActor actor)
	{
		return IsManageGroupGamesPermissionsEnabled(group, actor);
	}

	public bool IsAuthorizedToViewGameLocalizationRoles(IUniverse universe, IActor actor)
	{
		return AuthorizeUniverseGroupRequest(universe, actor);
	}

	public bool IsAuthorizedToEditGameLocalizationRoles(IUniverse universe, IActor actor)
	{
		return AuthorizeUniverseGroupRequest(universe, actor);
	}

	public bool IsActorInTranslatorRoleToViewTable(long universeId, Table table, IActor actor)
	{
		return false;
	}

	public bool IsActorInTranslatorRoleToEditTable(long universeId, Table table, IActor actor)
	{
		return false;
	}

	public bool CanActorManageGame(long universeId, Table table, IActor actor)
	{
		IUniverse universe = _UniverseFactory.GetUniverse(universeId);
		if (universe != null && IsTableBelongToUniverse(universeId, table))
		{
			return AuthorizeUniverseGroupRequest(universe, actor);
		}
		return false;
	}

	public bool IsAuthorizedToEditSupportedLanguages(long universeId, IActor actor)
	{
		IUniverse universe = _UniverseFactory.GetUniverse(universeId);
		return AuthorizeUniverseGroupRequest(universe, actor);
	}

	public bool IsAuthorizedToManageTranslations(IUniverse universe, IActor actor)
	{
		if (universe == null)
		{
			throw new PlatformArgumentNullException("universe");
		}
		if (actor == null)
		{
			throw new PlatformArgumentNullException("actor");
		}
		return AuthorizeUniverseGroupRequest(universe, actor);
	}

	public bool IsAuthorizedToFlushGameAutoLocalizationTable(IUniverse universe, IActor actor)
	{
		return AuthorizeUniverseGroupRequest(universe, actor);
	}

	public bool IsAuthorizedToTriggerAutoLocalizationTableAssetGeneration(IUniverse universe, IActor actor)
	{
		return AuthorizeUniverseGroupRequest(universe, actor);
	}

	private bool IsTableBelongToUniverse(long universeId, Table table)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		GetAutoLocalizationSettingsRequest request = new GetAutoLocalizationSettingsRequest
		{
			UniverseId = universeId
		};
		try
		{
			AutoLocalizationSettingsResponse autoLocalizationSettings = _AutoLocalizationClient.GetAutoLocalizationSettings(request);
			return ((autoLocalizationSettings != null) ? autoLocalizationSettings.AutoLocalizationDestinationTableId : null) == table.Id;
		}
		catch (Exception e)
		{
			_Logger.Error(e);
			throw;
		}
	}

	protected bool AuthorizeGroupRequest(Table table, IActor actor)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Invalid comparison between Unknown and I4
		if (table == null)
		{
			throw new PlatformArgumentNullException("Table cannot be null");
		}
		if ((int)table.OwnerType != 1)
		{
			return false;
		}
		try
		{
			IGroup group = GroupFactory.GetById(table.OwnerTargetId);
			return group != null && IsManageGroupGamesPermissionsEnabled(group, actor);
		}
		catch (Exception e)
		{
			_Logger.Error(e);
			throw new PlatformOperationUnavailableException("Unable to get the group associated with the table.");
		}
	}

	protected bool AuthorizeUniverseGroupRequest(IUniverse universe, IActor actor)
	{
		if (!universe.CreatorType.Equals(CreatorType.Group.ToString()))
		{
			return false;
		}
		try
		{
			IGroup group = GroupFactory.GetById(universe.CreatorTargetId);
			return group != null && IsManageGroupGamesPermissionsEnabled(group, actor);
		}
		catch (Exception e)
		{
			_Logger.Error(e);
			throw new PlatformOperationUnavailableException("Unable to get the group associated with the table.");
		}
	}

	private bool IsManageGroupGamesPermissionsEnabled(IGroup group, IActor actor)
	{
		if (group == null)
		{
			throw new PlatformArgumentNullException("Group cannot be null");
		}
		bool flag = actor == null;
		if (flag || ((flag | (actor.Actor == null)) ? true : false))
		{
			return false;
		}
		if (actor.Type != 0 || !(actor.Actor is IUser))
		{
			return false;
		}
		try
		{
			IUser user = actor.Actor as IUser;
			if (group.GetGroupRoleSetByUserId(user).HasPermission(GroupRoleSetPermissionType.CanManageGroupGames))
			{
				return true;
			}
		}
		catch (Exception e)
		{
			_Logger.Error(e);
		}
		return false;
	}

	private bool IsActorInTranslatorRole(IUniverse universe, IActor actor)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		universe.AssignOrThrowIfNull("universe");
		actor.AssignOrThrowIfNull("actor");
		if (!(actor.Actor is IUser))
		{
			return false;
		}
		IUser user = actor.Actor as IUser;
		IsAssignedForRoleRequest request = new IsAssignedForRoleRequest
		{
			AssigneeTargetId = user.Id,
			AssigneeType = (RoleAssigneeType)0,
			UniverseId = universe.Id
		};
		try
		{
			IsAssignedForRoleResponse obj = _GameLocalizationRolesClient.IsAssignedForRole(request);
			bool isContentCreator = false;
			if (_Settings.IsContentCreatorAllowedToTranslate)
			{
				isContentCreator = user.IsContentCreator();
			}
			return obj.IsAssigned || isContentCreator;
		}
		catch (Exception e)
		{
			_Logger.Error(e);
			throw;
		}
	}
}
