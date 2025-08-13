using System;
using System.Collections.Generic;
using Roblox.Marketplace.Client;
using Roblox.Platform.Games;
using Roblox.Platform.Games.PrivateServer;
using Roblox.Platform.Membership;
using Roblox.Platform.Membership.Extensions;
using Roblox.Platform.Universes;
using Roblox.Platform.UserSetting;
using Roblox.TextFilter.Client;
using Roblox.Web.Devices;

namespace Roblox.Web.Code;

public class PrivateServerHelper
{
	private readonly IPrivateServerFactory _PrivateServerFactory;

	private readonly UserSettingDomainFactories _UserSettingDomainFactories;

	private readonly GamesDomainFactories _GamesDomainFactories;

	private readonly ITextFilterClientV2 _TextFilterClientV2;

	private readonly IClientDeviceIdentifier _ClientDeviceIdentifier;

	private readonly IPrivateServerPermissionsFactory _PrivateServerPermissionsFactory;

	public PrivateServerHelper(IPrivateServerFactory privateServerFactory, UserSettingDomainFactories userSettingDomainFactories, GamesDomainFactories gamesDomainFactories, ITextFilterClientV2 textFilterClientV2, IClientDeviceIdentifier clientDeviceIdentifier, IPrivateServerPermissionsFactory privateServerPermissionsFactory)
	{
		_PrivateServerFactory = privateServerFactory ?? throw new ArgumentNullException("privateServerFactory");
		_UserSettingDomainFactories = userSettingDomainFactories ?? throw new ArgumentNullException("userSettingDomainFactories");
		_GamesDomainFactories = gamesDomainFactories ?? throw new ArgumentNullException("gamesDomainFactories");
		_TextFilterClientV2 = textFilterClientV2 ?? throw new ArgumentNullException("textFilterClientV2");
		_ClientDeviceIdentifier = clientDeviceIdentifier ?? throw new ArgumentNullException("clientDeviceIdentifier");
		_PrivateServerPermissionsFactory = privateServerPermissionsFactory ?? throw new ArgumentNullException("privateServerPermissionsFactory");
	}

	public ICollection<IPrivateServer> GetPrivateServers(IUser user, long universeId, int startIndex, int count)
	{
		long totalServersOwned = user.GetTotalNumberOfPrivateServersOwnedByUniverseId(_PrivateServerFactory, universeId);
		long totalServersHaveAccessTo = user.GetTotalNumberOfPrivateServersUserHasAccessToByUniverseID(_PrivateServerFactory, universeId);
		int numberOfServersOwnedToTake = 0;
		List<IPrivateServer> serversList = new List<IPrivateServer>();
		if (startIndex < totalServersOwned)
		{
			numberOfServersOwnedToTake = (int)Math.Min(count, totalServersOwned - startIndex);
			IReadOnlyCollection<IPrivateServer> serversOwned = user.GetPrivateServersOwnedByUniverseId(_PrivateServerFactory, universeId, startIndex, numberOfServersOwnedToTake);
			serversList.AddRange(serversOwned);
		}
		int serversAccessStartIndex = (int)(startIndex - totalServersOwned);
		serversAccessStartIndex = ((serversAccessStartIndex >= 0) ? serversAccessStartIndex : 0);
		int numberOfServersAccessToTake = (int)Math.Min(count - numberOfServersOwnedToTake, totalServersHaveAccessTo - serversAccessStartIndex);
		if (numberOfServersAccessToTake > 0)
		{
			IReadOnlyCollection<IPrivateServer> serversHasAccessTo = user.GetPrivateServersUserHasAccessToByUniverseID(_PrivateServerFactory, universeId, serversAccessStartIndex, numberOfServersAccessToTake);
			serversList.AddRange(serversHasAccessTo);
		}
		return serversList;
	}

	public IPrivateServer PurchasePrivateServer(IUser user, string userAgent, IUniverse universe, string privateServerName, long expectedPrice)
	{
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		if (_UserSettingDomainFactories.UserSettingsValidator.IsUserConfiguredForCuratedContentOnly(user))
		{
			IGameAttributes gameAttributes = _GamesDomainFactories.GameAttributesFactory.GetGameAttributes(universe);
			if (gameAttributes == null || !gameAttributes.IsSecure || gameAttributes == null || !gameAttributes.IsTrusted)
			{
				throw new PurchasePrivateServerAccountRestrictionsException();
			}
		}
		string filteredPrivateServerName = _TextFilterClientV2.FilterText(privateServerName, user.ToClientTextAuthor(), "PrivateServer", "", false).FilteredText;
		TransactionStatus transactionStatus;
		return _PrivateServerFactory.PurchasePrivateServer(universe.Id, user.Id, filteredPrivateServerName, expectedPrice, _ClientDeviceIdentifier.GetPlatformTypeIdByUserAgent(userAgent), _PrivateServerPermissionsFactory, out transactionStatus) ?? throw new PurchasePrivateServerTransactionfailedException(transactionStatus);
	}
}
