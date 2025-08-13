using System.Collections.Generic;
using Roblox.EventLog;
using Roblox.GameLocalization.Client;
using Roblox.Platform.Core;
using Roblox.Platform.GameLocalization.Authorization.Properties;
using Roblox.Platform.Groups;
using Roblox.Platform.Universes;

namespace Roblox.Platform.GameLocalization.Authorization;

public class GameLocalizationAuthorizerFactory
{
	private readonly IGameLocalizationAuthorizer _GameLocalizationAuthorizer;

	private readonly ILogger _Logger;

	public GameLocalizationAuthorizerFactory(ILogger logger, IGroupFactory groupFactory, IGroupMembershipFactory groupMembershipFactory, IGameLocalizationRolesClient gameLocalizationRolesClient, IAutoLocalizationClient autoLocalizationClient, IUniverseFactory universeFactory)
	{
		_Logger = logger.AssignOrThrowIfNull("logger");
		List<IGameLocalizationAuthorizer> authorizerList = new List<IGameLocalizationAuthorizer>
		{
			new UserOwnedTableAuthorizer(gameLocalizationRolesClient, universeFactory, autoLocalizationClient, Settings.Default, _Logger),
			new GroupOwnedTableAuthorizer(groupFactory, groupMembershipFactory, gameLocalizationRolesClient, universeFactory, autoLocalizationClient, Settings.Default, _Logger),
			new RobloxProcessorAuthorizer(_Logger),
			new RCCAuthorizer(_Logger),
			new TranslatorRoleAuthorizer(gameLocalizationRolesClient, autoLocalizationClient, universeFactory, Settings.Default, _Logger),
			new RobloxMigratorAuthorizer(_Logger)
		};
		_GameLocalizationAuthorizer = new GameLocalizationAuthorizationManager(authorizerList);
	}

	public IGameLocalizationAuthorizer GetGameLocalizationAuthorizer()
	{
		return _GameLocalizationAuthorizer;
	}
}
