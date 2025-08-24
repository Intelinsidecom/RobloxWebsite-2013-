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

internal class TranslatorRoleAuthorizer : IGameLocalizationAuthorizer
{
	private readonly IGameLocalizationRolesClient _GameLocalizationRolesClient;

	private readonly IAutoLocalizationClient _AutoLocalizationClient;

	private readonly ILogger _Logger;

	private readonly IUniverseFactory _UniverseFactory;

	private readonly ISettings _Settings;

	public TranslatorRoleAuthorizer(IGameLocalizationRolesClient gameLocalizationRolesClient, IAutoLocalizationClient autoLocalizationClient, IUniverseFactory universeFactory, ISettings settings, ILogger logger)
	{
		_GameLocalizationRolesClient = gameLocalizationRolesClient ?? throw new PlatformArgumentNullException("gameLocalizationRolesClient");
		_AutoLocalizationClient = autoLocalizationClient ?? throw new PlatformArgumentNullException("autoLocalizationClient");
		_Logger = logger ?? throw new PlatformArgumentNullException("logger");
		_UniverseFactory = universeFactory ?? throw new PlatformArgumentNullException("universeFactory");
		_Settings = settings ?? throw new PlatformArgumentNullException("settings");
	}

	public bool IsActorInTranslatorRoleToViewTable(long universeId, Table table, IActor actor)
	{
		ValidateTable(table);
		ValidateActor(actor);
		IUniverse universe = ValidateAndRetrieveUniverse(universeId);
		if (DoesTableBelongToUniverse(universe.Id, table))
		{
			return CanActorTranslate(universe, actor);
		}
		return false;
	}

	public bool IsActorInTranslatorRoleToEditTable(long universeId, Table table, IActor actor)
	{
		ValidateTable(table);
		ValidateActor(actor);
		IUniverse universe = ValidateAndRetrieveUniverse(universeId);
		if (DoesTableBelongToUniverse(universe.Id, table))
		{
			return CanActorTranslate(universe, actor);
		}
		return false;
	}

	public bool CanActorManageGame(long universeId, Table table, IActor actor)
	{
		return false;
	}

	public bool IsAuthorizedToEdit(Table table, IActor actor)
	{
		return false;
	}

	public bool IsAuthorizedToEditAutoLocalizationInformation(IUniverse universe, IActor actor)
	{
		return false;
	}

	public bool IsAuthorizedToEditGameLocalizationRoles(IUniverse universe, IActor actor)
	{
		return false;
	}

	public bool IsAuthorizedToEditGroupTables(IGroup group, IActor actor)
	{
		return false;
	}

	public bool IsAuthorizedToView(Table table, IActor actor)
	{
		return false;
	}

	public bool IsAuthorizedToViewAutoLocalizationInformation(IUniverse universe, IActor actor)
	{
		return false;
	}

	public bool IsAuthorizedToViewGameLocalizationRoles(IUniverse universe, IActor actor)
	{
		return false;
	}

	public bool IsAuthorizedToViewGroupTables(IGroup group, IActor actor)
	{
		return false;
	}

	public bool IsAuthorizedToEditSupportedLanguages(long universeId, IActor actor)
	{
		ValidateActor(actor);
		return CanActorEditSupportedLanguages(actor);
	}

	public bool IsAuthorizedToManageTranslations(IUniverse universe, IActor actor)
	{
		ValidateActor(actor);
		ValidateUniverse(universe);
		return CanActorTranslate(universe, actor);
	}

	public bool IsAuthorizedToFlushGameAutoLocalizationTable(IUniverse universe, IActor actor)
	{
		return false;
	}

	public bool IsAuthorizedToTriggerAutoLocalizationTableAssetGeneration(IUniverse universe, IActor actor)
	{
		return false;
	}

	private void ValidateUniverse(IUniverse universe)
	{
		if (universe == null)
		{
			throw new PlatformArgumentNullException("universe");
		}
	}

	private bool CanActorTranslate(IUniverse universe, IActor actor)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		if (actor.Type != 0 || !(actor.Actor is IUser))
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
			return false;
		}
	}

	private bool CanActorEditSupportedLanguages(IActor actor)
	{
		if (!_Settings.IsContentCreatorAllowedToEditSupportedLanguages)
		{
			return false;
		}
		if (!(actor.Actor is IUser))
		{
			return false;
		}
		return (actor.Actor as IUser).IsContentCreator();
	}

	private bool DoesTableBelongToUniverse(long universeId, Table table)
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

	private IUniverse ValidateAndRetrieveUniverse(long universeId)
	{
		IUniverse universe = null;
		try
		{
			if (universeId != 0L)
			{
				universe = _UniverseFactory.GetUniverse(universeId);
			}
		}
		catch (Exception e)
		{
			_Logger.Error(e);
			throw;
		}
		if (universe == null)
		{
			throw new PlatformArgumentException("universe");
		}
		return universe;
	}

	private void ValidateActor(IActor actor)
	{
		if (actor == null)
		{
			throw new PlatformArgumentNullException("actor");
		}
	}

	private void ValidateTable(Table table)
	{
		if (table == null)
		{
			throw new PlatformArgumentNullException("table");
		}
		if (table.Id == default(Guid))
		{
			throw new PlatformArgumentException("table");
		}
	}
}
