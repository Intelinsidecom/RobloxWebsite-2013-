using System.Collections.Generic;
using System.Linq;
using Roblox.InGameContentTables.Client;
using Roblox.Platform.Core;
using Roblox.Platform.Groups;
using Roblox.Platform.Universes;

namespace Roblox.Platform.GameLocalization.Authorization;

public class GameLocalizationAuthorizationManager : IGameLocalizationAuthorizer
{
	private readonly List<IGameLocalizationAuthorizer> _AuthorizerList;

	public GameLocalizationAuthorizationManager(List<IGameLocalizationAuthorizer> authorizers)
	{
		_AuthorizerList = authorizers ?? throw new PlatformArgumentNullException("authorizers");
	}

	public bool IsAuthorizedToEdit(Table table, IActor actor)
	{
		return _AuthorizerList.Any((IGameLocalizationAuthorizer authorizer) => authorizer.IsAuthorizedToEdit(table, actor));
	}

	public bool IsAuthorizedToEditGroupTables(IGroup group, IActor actor)
	{
		return _AuthorizerList.Any((IGameLocalizationAuthorizer authorizer) => authorizer.IsAuthorizedToEditGroupTables(group, actor));
	}

	public bool IsAuthorizedToViewAutoLocalizationInformation(IUniverse universe, IActor actor)
	{
		return _AuthorizerList.Any((IGameLocalizationAuthorizer authorizer) => authorizer.IsAuthorizedToViewAutoLocalizationInformation(universe, actor));
	}

	public bool IsAuthorizedToEditAutoLocalizationInformation(IUniverse universe, IActor actor)
	{
		return _AuthorizerList.Any((IGameLocalizationAuthorizer authorizer) => authorizer.IsAuthorizedToEditAutoLocalizationInformation(universe, actor));
	}

	public bool IsAuthorizedToView(Table table, IActor actor)
	{
		return _AuthorizerList.Any((IGameLocalizationAuthorizer authorizer) => authorizer.IsAuthorizedToView(table, actor));
	}

	public bool IsAuthorizedToViewGroupTables(IGroup group, IActor actor)
	{
		return _AuthorizerList.Any((IGameLocalizationAuthorizer authorizer) => authorizer.IsAuthorizedToViewGroupTables(group, actor));
	}

	public bool IsAuthorizedToViewGameLocalizationRoles(IUniverse universe, IActor actor)
	{
		return _AuthorizerList.Any((IGameLocalizationAuthorizer authorizer) => authorizer.IsAuthorizedToViewGameLocalizationRoles(universe, actor));
	}

	public bool IsAuthorizedToEditGameLocalizationRoles(IUniverse universe, IActor actor)
	{
		return _AuthorizerList.Any((IGameLocalizationAuthorizer authorizer) => authorizer.IsAuthorizedToEditGameLocalizationRoles(universe, actor));
	}

	public bool IsActorInTranslatorRoleToViewTable(long universeId, Table table, IActor actor)
	{
		return _AuthorizerList.Any((IGameLocalizationAuthorizer authorizer) => authorizer.IsActorInTranslatorRoleToViewTable(universeId, table, actor));
	}

	public bool IsActorInTranslatorRoleToEditTable(long universeId, Table table, IActor actor)
	{
		return _AuthorizerList.Any((IGameLocalizationAuthorizer authorizer) => authorizer.IsActorInTranslatorRoleToEditTable(universeId, table, actor));
	}

	public bool CanActorManageGame(long universeId, Table table, IActor actor)
	{
		return _AuthorizerList.Any((IGameLocalizationAuthorizer authorizer) => authorizer.CanActorManageGame(universeId, table, actor));
	}

	public bool IsAuthorizedToEditSupportedLanguages(long universeId, IActor actor)
	{
		return _AuthorizerList.Any((IGameLocalizationAuthorizer authorizer) => authorizer.IsAuthorizedToEditSupportedLanguages(universeId, actor));
	}

	public bool IsAuthorizedToManageTranslations(IUniverse universe, IActor actor)
	{
		return _AuthorizerList.Any((IGameLocalizationAuthorizer authorizer) => authorizer.IsAuthorizedToManageTranslations(universe, actor));
	}

	public bool IsAuthorizedToFlushGameAutoLocalizationTable(IUniverse universe, IActor actor)
	{
		return _AuthorizerList.Any((IGameLocalizationAuthorizer authorizer) => authorizer.IsAuthorizedToFlushGameAutoLocalizationTable(universe, actor));
	}

	public bool IsAuthorizedToTriggerAutoLocalizationTableAssetGeneration(IUniverse universe, IActor actor)
	{
		return _AuthorizerList.Any((IGameLocalizationAuthorizer authorizer) => authorizer.IsAuthorizedToTriggerAutoLocalizationTableAssetGeneration(universe, actor));
	}
}
