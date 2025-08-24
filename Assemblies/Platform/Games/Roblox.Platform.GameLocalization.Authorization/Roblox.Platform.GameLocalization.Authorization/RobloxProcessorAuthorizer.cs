using Roblox.EventLog;
using Roblox.InGameContentTables.Client;
using Roblox.Platform.Core;
using Roblox.Platform.Groups;
using Roblox.Platform.Universes;

namespace Roblox.Platform.GameLocalization.Authorization;

public class RobloxProcessorAuthorizer : IGameLocalizationAuthorizer
{
	protected readonly ILogger _Logger;

	public RobloxProcessorAuthorizer(ILogger logger)
	{
		_Logger = logger ?? throw new PlatformArgumentNullException("logger");
	}

	public bool IsAuthorizedToEdit(Table table, IActor actor)
	{
		table = table ?? throw new PlatformArgumentNullException("table");
		actor = actor ?? throw new PlatformArgumentNullException("actor");
		return IsValidRobloxProcessor(actor);
	}

	public bool IsAuthorizedToEditGroupTables(IGroup group, IActor actor)
	{
		group = group ?? throw new PlatformArgumentNullException("group");
		actor = actor ?? throw new PlatformArgumentNullException("actor");
		return IsValidRobloxProcessor(actor);
	}

	public bool IsAuthorizedToViewAutoLocalizationInformation(IUniverse universe, IActor actor)
	{
		universe = universe ?? throw new PlatformArgumentNullException("universe");
		actor = actor ?? throw new PlatformArgumentNullException("actor");
		return IsValidRobloxProcessor(actor);
	}

	public bool IsAuthorizedToEditAutoLocalizationInformation(IUniverse universe, IActor actor)
	{
		universe = universe ?? throw new PlatformArgumentNullException("universe");
		actor = actor ?? throw new PlatformArgumentNullException("actor");
		return IsValidRobloxProcessor(actor);
	}

	public bool IsAuthorizedToView(Table table, IActor actor)
	{
		table = table ?? throw new PlatformArgumentNullException("table");
		actor = actor ?? throw new PlatformArgumentNullException("actor");
		return IsValidRobloxProcessor(actor);
	}

	public bool IsAuthorizedToViewGroupTables(IGroup group, IActor actor)
	{
		group = group ?? throw new PlatformArgumentNullException("group");
		actor = actor ?? throw new PlatformArgumentNullException("actor");
		return IsValidRobloxProcessor(actor);
	}

	public bool IsAuthorizedToViewGameLocalizationRoles(IUniverse universe, IActor actor)
	{
		universe = universe ?? throw new PlatformArgumentNullException("universe");
		actor = actor ?? throw new PlatformArgumentNullException("actor");
		return IsValidRobloxProcessor(actor);
	}

	public bool IsAuthorizedToEditGameLocalizationRoles(IUniverse universe, IActor actor)
	{
		universe = universe ?? throw new PlatformArgumentNullException("universe");
		actor = actor ?? throw new PlatformArgumentNullException("actor");
		return IsValidRobloxProcessor(actor);
	}

	public bool CanActorManageGame(long universeId, Table table, IActor actor)
	{
		return false;
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
		actor = actor ?? throw new PlatformArgumentNullException("actor");
		return IsValidRobloxProcessor(actor);
	}

	public bool IsAuthorizedToManageTranslations(IUniverse universe, IActor actor)
	{
		return false;
	}

	public bool IsAuthorizedToFlushGameAutoLocalizationTable(IUniverse universe, IActor actor)
	{
		return false;
	}

	public bool IsAuthorizedToTriggerAutoLocalizationTableAssetGeneration(IUniverse universe, IActor actor)
	{
		universe = universe ?? throw new PlatformArgumentNullException("universe");
		actor = actor ?? throw new PlatformArgumentNullException("actor");
		return IsValidRobloxProcessor(actor);
	}

	private bool IsValidRobloxProcessor(IActor actor)
	{
		return actor?.Actor != null && actor.Type == ActorType.RobloxProcessor && actor?.Actor is RobloxComponent;
	}
}
