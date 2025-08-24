using Roblox.InGameContentTables.Client;
using Roblox.Platform.Groups;
using Roblox.Platform.Universes;

namespace Roblox.Platform.GameLocalization.Authorization;

public interface IGameLocalizationAuthorizer
{
	bool IsAuthorizedToView(Table table, IActor actor);

	bool IsAuthorizedToViewGroupTables(IGroup group, IActor actor);

	bool IsAuthorizedToEdit(Table table, IActor actor);

	bool IsAuthorizedToEditGroupTables(IGroup group, IActor actor);

	bool IsAuthorizedToViewAutoLocalizationInformation(IUniverse universe, IActor actor);

	bool IsAuthorizedToEditAutoLocalizationInformation(IUniverse universe, IActor actor);

	bool IsAuthorizedToViewGameLocalizationRoles(IUniverse universe, IActor actor);

	bool IsAuthorizedToEditGameLocalizationRoles(IUniverse universe, IActor actor);

	bool CanActorManageGame(long universeId, Table table, IActor actor);

	bool IsActorInTranslatorRoleToViewTable(long universeId, Table table, IActor actor);

	bool IsActorInTranslatorRoleToEditTable(long universeId, Table table, IActor actor);

	bool IsAuthorizedToEditSupportedLanguages(long universeId, IActor actor);

	bool IsAuthorizedToManageTranslations(IUniverse universe, IActor actor);

	bool IsAuthorizedToFlushGameAutoLocalizationTable(IUniverse universe, IActor actor);

	bool IsAuthorizedToTriggerAutoLocalizationTableAssetGeneration(IUniverse universe, IActor actor);
}
