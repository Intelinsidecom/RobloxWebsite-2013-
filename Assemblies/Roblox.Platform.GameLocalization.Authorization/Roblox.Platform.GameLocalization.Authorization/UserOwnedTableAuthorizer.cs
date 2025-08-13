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

internal class UserOwnedTableAuthorizer : IGameLocalizationAuthorizer
{
	protected readonly ILogger _Logger;

	private readonly IGameLocalizationRolesClient _GameLocalizationRolesClient;

	private readonly IUniverseFactory _UniverseFactory;

	private readonly IAutoLocalizationClient _AutoLocalizationClient;

	private readonly ISettings _Settings;

	public UserOwnedTableAuthorizer(IGameLocalizationRolesClient gameLocalizationRolesClient, IUniverseFactory universeFactory, IAutoLocalizationClient autoLocalizationClient, ISettings settings, ILogger logger)
	{
		_GameLocalizationRolesClient = gameLocalizationRolesClient ?? throw new PlatformArgumentNullException("gameLocalizationRolesClient");
		_Logger = logger ?? throw new PlatformArgumentNullException("logger");
		_UniverseFactory = universeFactory ?? throw new PlatformArgumentNullException("universeFactory");
		_AutoLocalizationClient = autoLocalizationClient ?? throw new PlatformArgumentNullException("autoLocalizationClient");
		_Settings = settings ?? throw new PlatformArgumentNullException("settings");
	}

	public bool IsAuthorizedToEdit(Table table, IActor actor)
	{
		CheckParamsAreValidOrThrow(table, actor);
		return IsTableOwnedByTheUser(table, actor);
	}

	public bool IsAuthorizedToEditGroupTables(IGroup group, IActor actor)
	{
		return false;
	}

	public bool IsAuthorizedToViewAutoLocalizationInformation(IUniverse universe, IActor actor)
	{
		if (!IsUniverseOwnedByTheUser(universe, actor) && !IsActorInTranslatorRole(universe, actor))
		{
			if (_Settings.IsContentCreatorAllowedToViewOrEditAutoLocalizationTables)
			{
				return IsActorContentCreator(actor);
			}
			return false;
		}
		return true;
	}

	public bool IsAuthorizedToEditAutoLocalizationInformation(IUniverse universe, IActor actor)
	{
		if (!IsUniverseOwnedByTheUser(universe, actor))
		{
			if (_Settings.IsContentCreatorAllowedToViewOrEditAutoLocalizationTables)
			{
				return IsActorContentCreator(actor);
			}
			return false;
		}
		return true;
	}

	public bool IsAuthorizedToView(Table table, IActor actor)
	{
		CheckParamsAreValidOrThrow(table, actor);
		return IsTableOwnedByTheUser(table, actor);
	}

	public bool IsAuthorizedToViewGroupTables(IGroup group, IActor actor)
	{
		return false;
	}

	public bool IsAuthorizedToViewGameLocalizationRoles(IUniverse universe, IActor actor)
	{
		return IsUniverseOwnedByTheUser(universe, actor);
	}

	public bool IsAuthorizedToEditGameLocalizationRoles(IUniverse universe, IActor actor)
	{
		return IsUniverseOwnedByTheUser(universe, actor);
	}

	public bool IsActorInGameOwnerRoleToViewTable(long universeId, Table table, IActor actor)
	{
		if (IsTableOwnedByTheUser(table, actor))
		{
			return true;
		}
		try
		{
			IUniverse universe = _UniverseFactory.GetUniverse(universeId);
			return IsUniverseOwnedByTheUser(universe, actor) && IsTableBelongToUniverse(universeId, table);
		}
		catch (Exception e)
		{
			_Logger.Error(e);
			throw;
		}
	}

	public bool CanActorManageGame(long universeId, Table table, IActor actor)
	{
		if (IsTableOwnedByTheUser(table, actor))
		{
			return true;
		}
		try
		{
			IUniverse universe = _UniverseFactory.GetUniverse(universeId);
			return IsUniverseOwnedByTheUser(universe, actor) && IsTableBelongToUniverse(universeId, table);
		}
		catch (Exception e)
		{
			_Logger.Error(e);
			throw;
		}
	}

	public bool IsActorInTranslatorRoleToViewTable(long universeId, Table table, IActor actor)
	{
		return false;
	}

	public bool IsActorInTranslatorRoleToEditTable(long universeId, Table table, IActor actor)
	{
		return false;
	}

	public bool IsAuthorizedToEditSupportedLanguages(long universeId, IActor actor)
	{
		try
		{
			IUniverse universe = _UniverseFactory.GetUniverse(universeId);
			return IsUniverseOwnedByTheUser(universe, actor);
		}
		catch (Exception e)
		{
			_Logger.Error(e);
			throw;
		}
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
		return IsUniverseOwnedByTheUser(universe, actor);
	}

	public bool IsAuthorizedToFlushGameAutoLocalizationTable(IUniverse universe, IActor actor)
	{
		if (!IsUniverseOwnedByTheUser(universe, actor))
		{
			if (_Settings.IsContentCreatorAllowedToFlushAutoLocalizationTables)
			{
				return IsActorContentCreator(actor);
			}
			return false;
		}
		return true;
	}

	public bool IsAuthorizedToTriggerAutoLocalizationTableAssetGeneration(IUniverse universe, IActor actor)
	{
		return IsUniverseOwnedByTheUser(universe, actor);
	}

	private bool IsTableOwnedByTheUser(Table table, IActor actor)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (!(actor.Actor is IUser))
		{
			return false;
		}
		IUser user = actor?.Actor as IUser;
		if ((int)table.OwnerType == 0)
		{
			return table.OwnerTargetId == user.Id;
		}
		return false;
	}

	private bool IsUniverseOwnedByTheUser(IUniverse universe, IActor actor)
	{
		if (universe == null)
		{
			return false;
		}
		if (!(actor.Actor is IUser))
		{
			return false;
		}
		IUser user = actor?.Actor as IUser;
		if (universe.CreatorType.Equals(CreatorType.User.ToString()))
		{
			return universe.CreatorTargetId == user.Id;
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

	private void CheckParamsAreValidOrThrow(Table table, IActor actor)
	{
		if (table == null)
		{
			throw new PlatformArgumentNullException("Table cannot be null");
		}
		if (actor?.Actor == null)
		{
			throw new PlatformArgumentNullException("Actor cannot be null");
		}
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

	internal virtual bool IsActorContentCreator(IActor actor)
	{
		if (actor == null || actor.Type != 0 || !(actor.Actor is IUser))
		{
			return false;
		}
		return (actor.Actor as IUser).IsContentCreator();
	}
}
