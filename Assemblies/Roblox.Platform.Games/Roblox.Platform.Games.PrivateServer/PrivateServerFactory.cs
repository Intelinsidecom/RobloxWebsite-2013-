using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Roblox.ApiClientBase;
using Roblox.Economy;
using Roblox.Economy.Common;
using Roblox.EventLog;
using Roblox.FloodCheckers;
using Roblox.FloodCheckers.Core;
using Roblox.Games.Client;
using Roblox.Instrumentation;
using Roblox.Marketplace.Client;
using Roblox.Platform.Events;
using Roblox.Platform.Floodcheckers;
using Roblox.Platform.GameInstances;
using Roblox.Platform.Games.Entities;
using Roblox.Platform.Games.Events;
using Roblox.Platform.Games.Properties;
using Roblox.Platform.Groups;
using Roblox.Platform.Membership;
using Roblox.Platform.Permissions;
using Roblox.Platform.Permissions.Core;
using Roblox.Platform.Universes;
using Roblox.Platform.VirtualCurrency;

namespace Roblox.Platform.Games.PrivateServer;

public class PrivateServerFactory : IPrivateServerFactory
{
	private const int _MaxPrivateServerNameLength = 50;

	private const string _PrivateServerNameErrorText = "The name of a VIP Server cannot be blank and can be no more than {0} characters.";

	private readonly MarketplaceAuthority _MarketplaceAuthority;

	private readonly IUserPermissionsChecker _UserPermissionsChecker;

	private readonly IUniverseFactory _UniverseFactory;

	private readonly IGroupFactory _GroupFactory;

	private readonly GlobalEventsPublisher _GlobalEventsPublisher;

	private readonly PrivateServerSaleManager _PrivateServerSaleManager;

	private readonly PrivateServerGameManager _PrivateServerGameManager;

	private readonly Regex _LinkCodeRegex;

	private readonly IUniversePrivateServersSettingsManager _UniversePrivateServersSettingsManager;

	private readonly IPrivateServerBuilder _PrivateServerBuilder;

	private readonly PrivateServerConfigurationActionCounters _PrivateServerConfigurationActionCounters;

	private readonly ILogger _Logger;

	private readonly IUserFactory _UserFactory;

	public int PrivateServerNameMaxLength => 50;

	public string PrivateServerNameErrorText => "The name of a VIP Server cannot be blank and can be no more than {0} characters.";

	public bool ArePrivateServerLinksEnabled => Settings.Default.PrivateServerLinksEnabled;

	public bool ArePrivateServerLinksEnabledForSoothsayers => Settings.Default.PrivateServerLinksEnabledForSoothsayers;

	private PrivateServerEntities ValidatePrivateServerAccess(long ownerUserId, long privateServerId)
	{
		FloodChecker floodChecker = GetPrivateServerUpdateRecurringFloodChecker(privateServerId);
		Roblox.Platform.Games.Entities.PrivateServer privateServer = GetAndValidatePrivateServerForUpdate(ownerUserId, privateServerId, floodChecker, ignoreCancelledState: true);
		IUniverse universe = _UniverseFactory.GetUniverse(privateServer.UniverseID);
		_UniversePrivateServersSettingsManager.VerifyPrivateServerConfigurePermissions(universe);
		return new PrivateServerEntities
		{
			FloodChecker = floodChecker,
			PrivateServer = privateServer,
			Universe = universe
		};
	}

	public PrivateServerFactory(MarketplaceAuthority marketplaceAuthority, GamesAuthority gamesAuthority, IUserPermissionsChecker userPermissionsChecker, IUniverseFactory universeFactory, GameInstanceFactory gameInstanceFactory, IGroupFactory groupFactory, IUniversePrivateServersSettingsManager universePrivateServersSettingsManager, PrivateServerConfigurationActionCounters privateServerConfigurationActionCounters, IRecurringTransactionFactory recurringTransactionFactory, ILogger logger, IUserFactory userFactory, ICounterRegistry counterRegistry)
	{
		_MarketplaceAuthority = marketplaceAuthority;
		_UserPermissionsChecker = userPermissionsChecker;
		_UniverseFactory = universeFactory;
		_GroupFactory = groupFactory;
		_UserFactory = userFactory ?? throw new ArgumentNullException("userFactory");
		_GlobalEventsPublisher = new GlobalEventsPublisher(logger, counterRegistry);
		_PrivateServerSaleManager = new PrivateServerSaleManager(_MarketplaceAuthority, recurringTransactionFactory, _Logger);
		_PrivateServerGameManager = new PrivateServerGameManager(gameInstanceFactory, gamesAuthority, _UniverseFactory);
		_LinkCodeRegex = new Regex("^[A-Za-z0-9_-]{" + (byte)32 + "}$");
		_UniversePrivateServersSettingsManager = universePrivateServersSettingsManager;
		_PrivateServerBuilder = new PrivateServerBuilder();
		_PrivateServerConfigurationActionCounters = privateServerConfigurationActionCounters;
		_Logger = logger;
	}

	public IReadOnlyCollection<IPrivateServer> GetPrivateServersByOwnerUserID(long ownerUserId, int startIndex, int maxRows)
	{
		return (from s in Roblox.Platform.Games.Entities.PrivateServer.GetPrivateServersByOwnerUserIdPaged(ownerUserId, startIndex, maxRows)
			select s.Translate()).ToList();
	}

	public long GetTotalNumberOfPrivateServersByOwnerUserID(long ownerUserId)
	{
		return Roblox.Platform.Games.Entities.PrivateServer.GetTotalNumberOfPrivateServersByOwnerUserId(ownerUserId);
	}

	public IReadOnlyCollection<IPrivateServer> GetPrivateServersByOwnerUserIDAndUniverseID(long ownerUserId, long universeId, int startIndex, int maxRows)
	{
		return (from s in Roblox.Platform.Games.Entities.PrivateServer.GetPrivateServersByOwnerUserIdAndUniverseIdPaged(ownerUserId, universeId, startIndex, maxRows)
			select s.Translate()).ToList();
	}

	public long GetTotalNumberOfPrivateServersByOwnerUserIDAndUniverseID(long ownerUserId, long universeId)
	{
		return Roblox.Platform.Games.Entities.PrivateServer.GetTotalNumberOfPrivateServersByOwnerUserIdAndUniverseId(ownerUserId, universeId);
	}

	public long GetTotalNumberOfActivePrivateServerSubscriptionsByUniverseId(long universeId)
	{
		int startIndex = 0;
		int activeCount = 0;
		ICollection<Roblox.Platform.Games.Entities.PrivateServer> privateServers = Roblox.Platform.Games.Entities.PrivateServer.GetPrivateServersByUniverseIdPaged(universeId, startIndex, 100);
		while (privateServers.Any())
		{
			foreach (Roblox.Platform.Games.Entities.PrivateServer privateServer in privateServers)
			{
				try
				{
					if (_PrivateServerSaleManager.GetActivePrivateServerSale(privateServer.Translate(), out var _) != null)
					{
						activeCount++;
					}
					startIndex++;
				}
				catch (Exception exception)
				{
					_Logger.Error(exception);
				}
			}
			privateServers = Roblox.Platform.Games.Entities.PrivateServer.GetPrivateServersByUniverseIdPaged(universeId, startIndex, 100);
		}
		return activeCount;
	}

	public bool ValidateLinkCodeConstraints(string linkCode)
	{
		if (string.IsNullOrEmpty(linkCode))
		{
			return false;
		}
		return _LinkCodeRegex.Match(linkCode).Success;
	}

	public IPrivateServer GetPrivateServerForLinkCode(string linkCode, long universeId)
	{
		if (string.IsNullOrEmpty(linkCode))
		{
			throw new PrivateServerArgumentException("Null or empty linkCode provided.");
		}
		IPrivateServer privateServer = Roblox.Platform.Games.Entities.PrivateServer.GetPrivateServersByLinkCodePaged(linkCode, 0, 1).FirstOrDefault().Translate();
		if (privateServer == null || privateServer.StatusType != PrivateServerStatusType.Active || privateServer.UniverseId != universeId)
		{
			return null;
		}
		return privateServer;
	}

	public IReadOnlyCollection<IPrivateServer> GetPrivateServersUserHasAccessTo(long userId, int startIndex, int maxRows)
	{
		return GetPrivateServers(from a in PrivateServerUserAccess.GetPrivateServerUserAccessesByUserIdPaged(userId, startIndex, maxRows)
			select a.PrivateServerID);
	}

	public long GetTotalNumberOfPrivateServersUserHasAccessTo(long userId)
	{
		return PrivateServerUserAccess.GetTotalNumberOfPrivateServerUserAccessesByUserId(userId);
	}

	public IReadOnlyCollection<IPrivateServer> GetPrivateServersUserHasAccessToByUniverseID(long userId, long universeId, int startIndex, int maxRows)
	{
		return GetPrivateServers(from a in PrivateServerUserAccess.GetPrivateServerUserAccessesByUserIdUniverseIdPaged(userId, universeId, startIndex, maxRows)
			select a.PrivateServerID);
	}

	public long GetTotalNumberOfPrivateServersUserHasAccessToByUniverseID(long userId, long universeId)
	{
		return PrivateServerUserAccess.GetTotalNumberOfPrivateServerUserAccessesByUserIdAndUniverseId(userId, universeId);
	}

	private void DoPurchasePrivateServer(long ownerUserId, long expectedPrice, IUniverse universe, byte platformTypeId, out TransactionStatus transactionStatus, out PurchaseProductResult purchaseResult, IPrivateServer existingPrivateServer = null)
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		Product product = _UniversePrivateServersSettingsManager.GetPrivateServerProduct(universe);
		byte currencyType = CurrencyType.RobuxID;
		if (!Enum.TryParse<PeriodType>(Settings.Default.PrivateServerRecurrencePeriodType, out PeriodType periodType))
		{
			throw new ArgumentException($"unhandled period type '{Settings.Default.PrivateServerRecurrencePeriodType}'");
		}
		long callbackUrlId = _GlobalEventsPublisher.GetOrCreateEventDestination(EventDestinationType.AmazonSqs, Settings.Default.PurchaseCallbackSQSValue);
		try
		{
			purchaseResult = _MarketplaceAuthority.RecurringPurchaseProduct((long)Convert.ToInt32(ownerUserId), product.ID, (int)currencyType, expectedPrice, true, Settings.Default.PrivateServerRecurrencePeriodMagnitude, periodType, (long?)callbackUrlId, (DateTime?)null, 0L, platformTypeId, (SaleLocationType)0, (long?)null, existingPrivateServer?.Id);
		}
		catch (ApiClientException)
		{
			throw new PrivateServersOperationUnavailableException("We are having a problem completing your purchase. Please try again in a few minutes.");
		}
		transactionStatus = (TransactionStatus)purchaseResult.Status;
	}

	public IPrivateServer PurchasePrivateServer(long universeId, long ownerUserId, string serverName, long expectedPrice, byte platformTypeId, IPrivateServerPermissionsFactory privateServerPermissionsFactory, out TransactionStatus transactionStatus)
	{
		IUniverse universe = _UniverseFactory.GetUniverse(universeId);
		_UniversePrivateServersSettingsManager.VerifyPrivateServerConfigurePermissions(universe);
		VerifyPrivateServerName(serverName);
		DoPurchasePrivateServer(ownerUserId, expectedPrice, universe, platformTypeId, out transactionStatus, out var purchaseResult);
		if (transactionStatus)
		{
			return null;
		}
		if (!purchaseResult.SaleId.HasValue)
		{
			return null;
		}
		Roblox.Platform.Games.Entities.PrivateServer privateServer = Roblox.Platform.Games.Entities.PrivateServer.Get(Roblox.Platform.Games.Entities.PrivateServerSale.GetBySaleID(purchaseResult.SaleId.Value).PrivateServerID);
		privateServer.Name = serverName;
		_PrivateServerConfigurationActionCounters.IncrementCounterAsync(PrivateServerConfigurationActionCounter.Purchase);
		try
		{
			privateServer.Save();
			PrivateServerCancellationTask.CreateNew(privateServer.ID, privateServer.ExpirationDate.AddDays(1.0));
		}
		catch (Exception e)
		{
			_Logger.Error(e);
		}
		return privateServer.Translate();
	}

	public IPrivateServer GetPrivateServerByAccessCode(Guid accessCode)
	{
		if (accessCode == Guid.Empty)
		{
			return null;
		}
		return Roblox.Platform.Games.Entities.PrivateServer.GetPrivateServerByAccessCode(accessCode).Translate();
	}

	public IPrivateServer GetPrivateServer(long privateServerId)
	{
		if (privateServerId <= 0)
		{
			return null;
		}
		return Roblox.Platform.Games.Entities.PrivateServer.Get(privateServerId).Translate();
	}

	public void CancelPrivateServerUserInitiated(long privateServerId)
	{
		Roblox.Platform.Games.Entities.PrivateServer privateServerEntity = Roblox.Platform.Games.Entities.PrivateServer.Get(privateServerId);
		if (privateServerEntity != null && privateServerEntity.PrivateServerStatusTypeID != 3)
		{
			byte oldStatusType = privateServerEntity.PrivateServerStatusTypeID;
			privateServerEntity.PrivateServerStatusTypeID = 3;
			privateServerEntity.Save();
			if (Settings.Default.IsOwnerCancelEventPublishingEnabled)
			{
				PrivateServerConfigureEventPublisher.PublishOwnerCancelEvent(privateServerId);
			}
			else
			{
				PrivateServerConfigureEventPublisher.PublishOwnerDeactivateEvent(privateServerId);
			}
			_PrivateServerGameManager.CloseRunningGameForPrivateServer(privateServerEntity.Translate(), CloseGameReasonType.Developer);
			PrivateServerStatusChange.CreateNew(privateServerEntity.ID, 3, oldStatusType, Roblox.Platform.Games.Entities.PrivateServerStatusChangeReasonType.UserInitiated.ID);
			_PrivateServerConfigurationActionCounters.IncrementCounterAsync(PrivateServerConfigurationActionCounter.Cancel);
		}
	}

	public void UpdatePrivateServerStatus(IUser ownerUser, long privateServerId, PrivateServerStatusType newStatusType)
	{
		FloodChecker floodChecker = GetPrivateServerUpdateFloodChecker(privateServerId);
		Roblox.Platform.Games.Entities.PrivateServer privateServerEntity = GetAndValidatePrivateServerForUpdate(ownerUser.Id, privateServerId, floodChecker);
		if (newStatusType == PrivateServerStatusType.Active && privateServerEntity.PrivateServerStatusTypeID == 3)
		{
			throw new InvalidPrivateServerStateException(privateServerEntity.Translate(), "You cannot activate a cancelled VIP Server.");
		}
		IUniverse universe = _UniverseFactory.GetUniverse(privateServerEntity.UniverseID);
		_UniversePrivateServersSettingsManager.VerifyPrivateServerConfigurePermissions(universe);
		if (privateServerEntity.PrivateServerStatusTypeID != (byte)newStatusType)
		{
			if (newStatusType == PrivateServerStatusType.Active)
			{
				PrivateServerConfigureEventPublisher.PublishOwnerActivateEvent(privateServerId);
				_PrivateServerConfigurationActionCounters.IncrementCounterAsync(PrivateServerConfigurationActionCounter.Activate);
			}
			if (newStatusType == PrivateServerStatusType.Inactive)
			{
				PrivateServerConfigureEventPublisher.PublishOwnerDeactivateEvent(privateServerId);
				_PrivateServerGameManager.CloseRunningGameForPrivateServer(privateServerEntity.Translate(), CloseGameReasonType.Developer);
				PrivateServerLinkFactory.RemoveLinkCode(privateServerId, ownerUser);
				_PrivateServerConfigurationActionCounters.IncrementCounterAsync(PrivateServerConfigurationActionCounter.Deactivate);
			}
			byte oldStatusType = privateServerEntity.PrivateServerStatusTypeID;
			privateServerEntity.PrivateServerStatusTypeID = (byte)newStatusType;
			privateServerEntity.Save();
			PrivateServerStatusChange.CreateNew(privateServerEntity.ID, (byte)newStatusType, oldStatusType, Roblox.Platform.Games.Entities.PrivateServerStatusChangeReasonType.UserInitiated.ID);
			floodChecker.UpdateCount();
		}
	}

	public bool IsPrivateServerRecurrenceActive(long privateServerId)
	{
		Roblox.Platform.Games.Entities.PrivateServer privateServerEntity = Roblox.Platform.Games.Entities.PrivateServer.Get(privateServerId);
		if (privateServerEntity == null)
		{
			throw new UnknownPrivateServerException(privateServerId);
		}
		Roblox.Platform.Games.Entities.PrivateServerSale newestPrivateServerSale;
		return _PrivateServerSaleManager.GetActivePrivateServerSale(privateServerEntity.Translate(), out newestPrivateServerSale) != null;
	}

	public string GetRecurringProfileIdForPrivateServer(long privateServerId)
	{
		Roblox.Platform.Games.Entities.PrivateServer privateServerEntity = Roblox.Platform.Games.Entities.PrivateServer.Get(privateServerId);
		if (privateServerEntity == null)
		{
			throw new UnknownPrivateServerException(privateServerId);
		}
		SaleMetadata bySaleID = SaleMetadata.GetBySaleID((_PrivateServerSaleManager.GetNewestPrivateServerSale(privateServerEntity.Translate()) ?? throw new UnknownPrivateServerException(privateServerId)).SaleID);
		if (!bySaleID.RecurringTransactionIsActive.HasValue)
		{
			throw new UnknownPrivateServerException(privateServerId);
		}
		return bySaleID.RecurringTransactionProfileID;
	}

	public bool DoesPrivateServerHaveRecurringProfile(long privateServerId)
	{
		Roblox.Platform.Games.Entities.PrivateServer privateServerEntity = Roblox.Platform.Games.Entities.PrivateServer.Get(privateServerId);
		if (privateServerEntity == null)
		{
			throw new UnknownPrivateServerException(privateServerId);
		}
		Roblox.Platform.Games.Entities.PrivateServerSale newestPrivateServerSale = _PrivateServerSaleManager.GetNewestPrivateServerSale(privateServerEntity.Translate());
		if (newestPrivateServerSale != null)
		{
			return SaleMetadata.GetBySaleID(newestPrivateServerSale.SaleID).RecurringTransactionIsActive.HasValue;
		}
		return false;
	}

	public bool HasPrivateServerPriceChanged(long privateServerId, long universeId)
	{
		IPrivateServer privateServer = (Roblox.Platform.Games.Entities.PrivateServer.Get(privateServerId) ?? throw new UnknownPrivateServerException(privateServerId)).Translate();
		Roblox.Platform.Games.Entities.PrivateServerSale newestPrivateServerSale = _PrivateServerSaleManager.GetNewestPrivateServerSale(privateServer);
		if (newestPrivateServerSale == null)
		{
			throw new InvalidPrivateServerStateException(privateServer, "There is a problem with your VIP Server's sale information, please contact info@roblox.com for assistance.");
		}
		SaleMetadata saleMetadata = SaleMetadata.GetBySaleID(newestPrivateServerSale.SaleID);
		if (saleMetadata == null || !saleMetadata.RecurringTransactionIsActive.HasValue)
		{
			return true;
		}
		try
		{
			long recurringAmount = _MarketplaceAuthority.GetRecurringSale(newestPrivateServerSale.SaleID).RecurringAmount;
			IUniverse universe = _UniverseFactory.GetUniverse(universeId);
			long? privateServerProductPrice = _UniversePrivateServersSettingsManager.GetPrivateServerProduct(universe).PriceInRobux;
			if (!privateServerProductPrice.HasValue)
			{
				throw new InvalidPrivateServerStateException(privateServer, "There is a problem with your VIP Server's product information, please contact info@roblox.com for assistance.");
			}
			if (privateServerProductPrice.Value != recurringAmount)
			{
				return true;
			}
			return false;
		}
		catch (ApiClientException)
		{
			throw new PrivateServersOperationUnavailableException("There was an error fetching your VIP Server sale details. Please try again in a few minutes. If the problem persists, please contact info@roblox.com for assistance.");
		}
	}

	public bool CancelRecurringPrivateServer(long ownerUserId, long privateServerId)
	{
		FloodChecker floodChecker = GetPrivateServerUpdateRecurringFloodChecker(privateServerId);
		Roblox.Platform.Games.Entities.PrivateServer privateServerEntity = GetAndValidatePrivateServerForUpdate(ownerUserId, privateServerId, floodChecker, ignoreCancelledState: true);
		bool result = _PrivateServerSaleManager.CancelRecurringSaleForPrivateServer(privateServerEntity.Translate());
		floodChecker.UpdateCount();
		_PrivateServerConfigurationActionCounters.IncrementCounterAsync(PrivateServerConfigurationActionCounter.Cancel);
		return result;
	}

	public bool RenewRecurringPrivateServer(long ownerUserId, long privateServerId, byte platformTypeId, long expectedPrice)
	{
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		FloodChecker floodChecker = GetPrivateServerUpdateRecurringFloodChecker(privateServerId);
		IPrivateServer privateServer = GetAndValidatePrivateServerForUpdate(ownerUserId, privateServerId, floodChecker, ignoreCancelledState: true).Translate();
		IUniverse universe = _UniverseFactory.GetUniverse(privateServer.UniverseId);
		_UniversePrivateServersSettingsManager.VerifyPrivateServerConfigurePermissions(universe);
		if (_PrivateServerSaleManager.GetActivePrivateServerSale(privateServer, out var newestPrivateServerSale) != null)
		{
			throw new InvalidPrivateServerStateException(privateServer, "The subscription to this VIP Server is already active. There is no need to renew.");
		}
		Product product = _UniversePrivateServersSettingsManager.GetPrivateServerProduct(universe);
		if (product.PriceInRobux.Value != expectedPrice)
		{
			throw new InvalidPrivateServerStateException(privateServer, "The price for renewing this VIP Server has changed. Please refresh the page and try again.");
		}
		SaleMetadata saleMetadata = SaleMetadata.GetBySaleID(newestPrivateServerSale.SaleID);
		bool hasPriceChanged = true;
		bool num = privateServer.ExpirationDate < DateTime.Now;
		if (saleMetadata.RecurringTransactionIsActive.HasValue)
		{
			hasPriceChanged = HasPrivateServerPriceChanged(privateServerId, privateServer.UniverseId);
		}
		if (num)
		{
			long price = product.PriceInRobux ?? 0;
			if (saleMetadata.RecurringTransactionIsActive.HasValue && saleMetadata.RecurringTransactionIsActive.Value)
			{
				_MarketplaceAuthority.CancelRecurringSale(saleMetadata.SaleID);
			}
			DoPurchasePrivateServer(ownerUserId, price, universe, platformTypeId, out var transactionStatus, out var _, privateServer);
			if ((int)transactionStatus != 0)
			{
				return false;
			}
			floodChecker.UpdateCount();
			_PrivateServerConfigurationActionCounters.IncrementCounterAsync(PrivateServerConfigurationActionCounter.Renew);
			return true;
		}
		if (saleMetadata.RecurringTransactionIsActive.HasValue && !hasPriceChanged)
		{
			bool success = true;
			if (!saleMetadata.RecurringTransactionIsActive.Value)
			{
				success = _MarketplaceAuthority.ActivateRecurringSale(newestPrivateServerSale.SaleID, privateServer.ExpirationDate.AddHours(Settings.Default.PrivateServerRecurringBufferHours * -1), (DateTime?)null);
			}
			floodChecker.UpdateCount();
			_PrivateServerConfigurationActionCounters.IncrementCounterAsync(PrivateServerConfigurationActionCounter.Renew);
			return success;
		}
		if (hasPriceChanged)
		{
			throw new InvalidPrivateServerStateException(privateServer, "The price for this VIP Server has been changed by the developer, you may renew your subscription after the VIP Server expires.");
		}
		return false;
	}

	public void UpdatePrivateServerName(long ownerUserId, long privateServerId, string serverName)
	{
		PrivateServerEntities privateServerEntities = ValidatePrivateServerAccess(ownerUserId, privateServerId);
		VerifyPrivateServerName(serverName);
		privateServerEntities.PrivateServer.Name = serverName;
		privateServerEntities.PrivateServer.Save();
		privateServerEntities.FloodChecker.UpdateCount();
		_PrivateServerConfigurationActionCounters.IncrementCounterAsync(PrivateServerConfigurationActionCounter.Configure);
	}

	public void UpdatePrivateServerFriendsAccess(long ownerUserId, long privateServerId, bool allowFriends, IPrivateServerPermissionsFactory privateServerPermissionsFactory)
	{
		PrivateServerEntities privateServerEntities = ValidatePrivateServerAccess(ownerUserId, privateServerId);
		List<ServerConfigurationEventType> publishEvents = new List<ServerConfigurationEventType>();
		bool currentlyAllowsFriends = privateServerPermissionsFactory.DoesPrivateServerAllowFriends(privateServerId);
		if (allowFriends && !currentlyAllowsFriends)
		{
			privateServerPermissionsFactory.AddPrivateServerFriendsAccess(privateServerId, ownerUserId);
			publishEvents.Add(ServerConfigurationEventType.OwnerAllowFriends);
		}
		else if (!allowFriends && currentlyAllowsFriends)
		{
			privateServerPermissionsFactory.RemovePrivateServerFriendsAccess(privateServerId, ownerUserId);
			publishEvents.Add(ServerConfigurationEventType.OwnerDisallowFriends);
		}
		if (publishEvents.Any())
		{
			PrivateServerConfigureEventPublisher.PublishEvents(publishEvents, privateServerId);
		}
		privateServerEntities.FloodChecker.UpdateCount();
		_PrivateServerConfigurationActionCounters.IncrementCounterAsync(PrivateServerConfigurationActionCounter.Configure);
	}

	public IReadOnlyCollection<long> UpdatePrivateServerClanAccess(long ownerUserId, long privateServerId, IReadOnlyCollection<long> allowedClanIds, IPrivateServerPermissionsFactory privateServerPermissionsFactory)
	{
		PrivateServerEntities privateServerEntities = ValidatePrivateServerAccess(ownerUserId, privateServerId);
		List<ServerConfigurationEventType> publishEvents = new List<ServerConfigurationEventType>();
		List<long> validatedAllowedClanIds = (from id in allowedClanIds
			select _GroupFactory.GetById(id) into g
			where g?.HasClan ?? false
			select g.Id).ToList();
		if (privateServerPermissionsFactory.SetPrivateServerClanAccess(privateServerId, validatedAllowedClanIds))
		{
			publishEvents.Add(ServerConfigurationEventType.OwnerChangeAllowedClans);
			PrivateServerConfigureEventPublisher.PublishEvents(publishEvents, privateServerId);
		}
		privateServerEntities.FloodChecker.UpdateCount();
		_PrivateServerConfigurationActionCounters.IncrementCounterAsync(PrivateServerConfigurationActionCounter.Configure);
		return validatedAllowedClanIds;
	}

	public void UpdatePrivateServerFriendsList(long ownerUserId, long privateServerId, IReadOnlyCollection<IUser> usersToAddToWhitelist, IReadOnlyCollection<IUser> usersToRemoveFromWhitelist, IPrivateServerPermissionsFactory privateServerPermissionsFactory)
	{
		PrivateServerEntities privateServerEntities = ValidatePrivateServerAccess(ownerUserId, privateServerId);
		List<ServerConfigurationEventType> publishEvents = new List<ServerConfigurationEventType>();
		if (privateServerEntities.PrivateServer.PrivateServerStatusTypeID == 1)
		{
			ICustomList currentWhitelistCustomList = privateServerPermissionsFactory.GetPrivateServerWhitelist(privateServerId);
			currentWhitelistCustomList.GetMembers(1, out var currentWhitelistCount);
			long newWhitelistCount = currentWhitelistCount - usersToRemoveFromWhitelist.Count + usersToAddToWhitelist.Count;
			IUser ownerUser = _UserFactory.GetUser(ownerUserId);
			if (newWhitelistCount > Settings.Default.PrivateServersWhitelistMaxCount)
			{
				throw new WhitelistCountExceededException(newWhitelistCount, "You may only add " + Settings.Default.PrivateServersWhitelistMaxCount + " players to your VIP Server's invite list.");
			}
			foreach (IUser user2 in usersToRemoveFromWhitelist)
			{
				if (user2 == null)
				{
					throw new PrivateServersPlatformException("You may only remove players who exist from your VIP Server's invite list.");
				}
				currentWhitelistCustomList.RemoveMember(user2.Id);
			}
			foreach (IUser user in usersToAddToWhitelist)
			{
				if (user == null)
				{
					throw new PrivateServersPlatformException("You may only add players who exist to your VIP Server's invite list.");
				}
				if (user.Id != ownerUserId && privateServerPermissionsFactory.DoesUserHavePermissionToInviteUserToPrivateServer(_UserPermissionsChecker, ownerUser, user))
				{
					currentWhitelistCustomList.AddMember(user.Id);
				}
			}
			if (usersToAddToWhitelist.Count > 0 || usersToRemoveFromWhitelist.Count > 0)
			{
				publishEvents.Add(ServerConfigurationEventType.ModifyWhiteList);
			}
			if (publishEvents.Any())
			{
				PrivateServerConfigureEventPublisher.PublishEvents(publishEvents, privateServerId);
			}
			privateServerEntities.FloodChecker.UpdateCount();
			_PrivateServerConfigurationActionCounters.IncrementCounterAsync(PrivateServerConfigurationActionCounter.Configure);
			return;
		}
		throw new PrivateServersPlatformException("You may only add or remove players when your VIP server is active.");
	}

	public void UpdatePrivateServer(long ownerUserId, long privateServerId, string name, bool? allowFriends, IReadOnlyCollection<IUser> usersToAddToWhitelist, IReadOnlyCollection<IUser> usersToRemoveFromWhitelist, IPrivateServerPermissionsFactory privateServerPermissionsFactory, IReadOnlyCollection<long> allowedClanIds)
	{
		FloodChecker floodChecker = GetPrivateServerUpdateFloodChecker(privateServerId);
		Roblox.Platform.Games.Entities.PrivateServer privateServerEntity = GetAndValidatePrivateServerForUpdate(ownerUserId, privateServerId, floodChecker);
		IUniverse universe = _UniverseFactory.GetUniverse(privateServerEntity.UniverseID);
		_UniversePrivateServersSettingsManager.VerifyPrivateServerConfigurePermissions(universe);
		VerifyPrivateServerName(name);
		IUser ownerUser = _UserFactory.GetUser(ownerUserId);
		privateServerEntity.Name = name;
		List<ServerConfigurationEventType> publishEvents = new List<ServerConfigurationEventType>();
		if (allowFriends.HasValue)
		{
			bool currentlyAllowsFriends = privateServerPermissionsFactory.DoesPrivateServerAllowFriends(privateServerId);
			if (allowFriends.Value && !currentlyAllowsFriends)
			{
				privateServerPermissionsFactory.AddPrivateServerFriendsAccess(privateServerId, ownerUserId);
				publishEvents.Add(ServerConfigurationEventType.OwnerAllowFriends);
			}
			else if (!allowFriends.Value && currentlyAllowsFriends)
			{
				privateServerPermissionsFactory.RemovePrivateServerFriendsAccess(privateServerId, ownerUserId);
				publishEvents.Add(ServerConfigurationEventType.OwnerDisallowFriends);
			}
		}
		long[] validatedAllowedClanIds = (from g in allowedClanIds?.Select((long id) => _GroupFactory.GetById(id))
			where g?.HasClan ?? false
			select g.Id).ToArray();
		if (privateServerPermissionsFactory.SetPrivateServerClanAccess(privateServerId, (IReadOnlyCollection<long>)(object)validatedAllowedClanIds))
		{
			publishEvents.Add(ServerConfigurationEventType.OwnerChangeAllowedClans);
		}
		if (privateServerEntity.PrivateServerStatusTypeID == 1)
		{
			ICustomList currentWhitelistCustomList = privateServerPermissionsFactory.GetPrivateServerWhitelist(privateServerId);
			currentWhitelistCustomList.GetMembers(1, out var currentWhitelistCount);
			long newWhitelistCount = currentWhitelistCount - usersToRemoveFromWhitelist.Count + usersToAddToWhitelist.Count;
			if (newWhitelistCount > Settings.Default.PrivateServersWhitelistMaxCount)
			{
				throw new WhitelistCountExceededException(newWhitelistCount, "You may only add " + Settings.Default.PrivateServersWhitelistMaxCount + " players to your VIP Server's invite list.");
			}
			foreach (IUser user2 in usersToRemoveFromWhitelist)
			{
				if (user2 == null)
				{
					throw new PrivateServersPlatformException("You may only remove players who exist from your VIP Server's invite list.");
				}
				currentWhitelistCustomList.RemoveMember(user2.Id);
			}
			foreach (IUser user in usersToAddToWhitelist)
			{
				if (user == null)
				{
					throw new PrivateServersPlatformException("You may only add players who exist to your VIP Server's invite list.");
				}
				if (user.Id != ownerUserId && privateServerPermissionsFactory.DoesUserHavePermissionToInviteUserToPrivateServer(_UserPermissionsChecker, ownerUser, user))
				{
					currentWhitelistCustomList.AddMember(user.Id);
				}
			}
			if (usersToAddToWhitelist.Count > 0 || usersToRemoveFromWhitelist.Count > 0)
			{
				publishEvents.Add(ServerConfigurationEventType.ModifyWhiteList);
			}
		}
		if (publishEvents.Any())
		{
			PrivateServerConfigureEventPublisher.PublishEvents(publishEvents, privateServerId);
		}
		privateServerEntity.Save();
		floodChecker.UpdateCount();
		_PrivateServerConfigurationActionCounters.IncrementCounterAsync(PrivateServerConfigurationActionCounter.Configure);
	}

	public PrivateServerStatusChangeReasonType? GetMostRecentStatusChangeReasonType(long privateServerId)
	{
		return (PrivateServerStatusChangeReasonType?)PrivateServerStatusChange.GetPrivateServerStatusChangesByPrivateServerIDPaged(privateServerId, 0L, 1L).FirstOrDefault()?.PrivateServerStatusChangeReasonTypeID;
	}

	public long GetPrivateServerDefaultPrice()
	{
		return Settings.Default.PrivateServerDefaultPrice;
	}

	public long GetPrivateServerMinPrice()
	{
		return Settings.Default.PrivateServerMinPrice;
	}

	private FloodChecker GetPrivateServerUpdateFloodChecker(long privateServerId)
	{
		string floodCheckerKey = "PrivateServerFactory:UpdatePrivateServer_PrivateServerId:" + privateServerId;
		return new FloodChecker("PrivateServerFactory.UpdatePrivateServer", floodCheckerKey, Settings.Default.PrivateServersConfigureFloodCheckerLimit);
	}

	private FloodChecker GetPrivateServerUpdateRecurringFloodChecker(long privateServerId)
	{
		string floodCheckerKey = "PrivateServerFactory:UpdateRecurringPrivateServer_PrivateServerId:" + privateServerId;
		return new FloodChecker("PrivateServerFactory.UpdateRecurringPrivateServer", floodCheckerKey, Settings.Default.PrivateServersConfigureRecurringFloodCheckerLimit);
	}

	private void VerifyPrivateServerName(string serverName)
	{
		if (string.IsNullOrEmpty(serverName) || serverName.Length > 50)
		{
			throw new PrivateServersPlatformException(string.Format(PrivateServerNameErrorText, 50));
		}
	}

	private Roblox.Platform.Games.Entities.PrivateServer GetAndValidatePrivateServerForUpdate(long ownerUserId, long privateServerId, IFloodChecker floodChecker, bool ignoreCancelledState = false)
	{
		if (floodChecker.IsFlooded())
		{
			throw new FloodCheckerFloodedException("Please wait a few minutes before configuring your VIP Server again.");
		}
		Roblox.Platform.Games.Entities.PrivateServer privateServerEntity = Roblox.Platform.Games.Entities.PrivateServer.Get(privateServerId);
		if (privateServerEntity == null)
		{
			throw new UnknownPrivateServerException(privateServerId);
		}
		if (ownerUserId != privateServerEntity.OwnerUserID)
		{
			throw new InvalidOwnerException(privateServerEntity.Translate(), ownerUserId, "You are not the owner of this VIP Server.");
		}
		if (!ignoreCancelledState && privateServerEntity.PrivateServerStatusTypeID == 3)
		{
			throw new InvalidPrivateServerStateException(privateServerEntity.Translate(), "You may not configure a cancelled VIP Server. Please renew your subscription before configuring.");
		}
		return privateServerEntity;
	}

	private static IReadOnlyCollection<IPrivateServer> GetPrivateServers(IEnumerable<long> privateServerIds)
	{
		return privateServerIds.Select((long id) => Roblox.Platform.Games.Entities.PrivateServer.Get(id).Translate()).ToList();
	}
}
