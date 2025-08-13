using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.EventLog;
using Roblox.Games.Client;
using Roblox.Marketplace.Client;
using Roblox.Platform.GameInstances;
using Roblox.Platform.Games.Entities;
using Roblox.Platform.Games.Properties;
using Roblox.Platform.Membership;
using Roblox.Platform.Universes;
using Roblox.Platform.VirtualCurrency;

namespace Roblox.Platform.Games.PrivateServer;

public class PrivateServerProcessorFactory : IPrivateServerProcessorFactory
{
	private readonly GamesAuthority _GamesAuthority;

	private readonly IUniverseFactory _UniverseFactory;

	private readonly PrivateServerSaleManager _PrivateServerSaleManager;

	private readonly PrivateServerGameManager _PrivateServerGameManager;

	private readonly IUserFactory _UserFactory;

	private readonly ILogger _Logger;

	public PrivateServerProcessorFactory(GamesAuthority gamesAuthority, IUniverseFactory universeFactory, IRecurringTransactionFactory recurringTransactionFactory, MarketplaceAuthority marketplaceAuthority, GameInstanceFactory gameInstanceFactory, ILogger logger, IUserFactory userFactory)
	{
		_GamesAuthority = gamesAuthority;
		_UniverseFactory = universeFactory;
		_Logger = logger;
		_UserFactory = userFactory ?? throw new ArgumentNullException("userFactory");
		_PrivateServerSaleManager = new PrivateServerSaleManager(marketplaceAuthority, recurringTransactionFactory, logger);
		_PrivateServerGameManager = new PrivateServerGameManager(gameInstanceFactory, gamesAuthority, universeFactory);
	}

	public IPrivateServer GetPrivateServer(long privateServerId)
	{
		if (privateServerId <= 0)
		{
			return null;
		}
		return Roblox.Platform.Games.Entities.PrivateServer.Get(privateServerId).Translate();
	}

	public IPrivateServer GetPrivateServerBySaleId(long saleId)
	{
		if (saleId <= 0)
		{
			return null;
		}
		Roblox.Platform.Games.Entities.PrivateServerSale privateServerSale = Roblox.Platform.Games.Entities.PrivateServerSale.GetBySaleID(saleId);
		if (privateServerSale != null)
		{
			return Roblox.Platform.Games.Entities.PrivateServer.Get(privateServerSale.PrivateServerID).Translate();
		}
		return null;
	}

	public IReadOnlyCollection<IPrivateServer> GetPrivateServersForUniverse(long universeId, int startIndex, int maxRows)
	{
		return (from privateServerEntity in Roblox.Platform.Games.Entities.PrivateServer.GetPrivateServersByUniverseIdPaged(universeId, startIndex, maxRows)
			select privateServerEntity.Translate()).ToList();
	}

	public IReadOnlyCollection<IPrivateServer> GetPrivateServersByOwnerUserId(long ownerUserId, int startIndex, int maxRows)
	{
		return (from s in Roblox.Platform.Games.Entities.PrivateServer.GetPrivateServersByOwnerUserIdPaged(ownerUserId, startIndex, maxRows)
			select s.Translate()).ToList();
	}

	public long GetTotalNumberOfPrivateServersByOwnerUserId(long ownerUserId)
	{
		return Roblox.Platform.Games.Entities.PrivateServer.GetTotalNumberOfPrivateServersByOwnerUserId(ownerUserId);
	}

	public void SavePrivateServer(IPrivateServer privateServer)
	{
		if (privateServer != null)
		{
			Roblox.Platform.Games.Entities.PrivateServer existingPrivateServer = Roblox.Platform.Games.Entities.PrivateServer.Get(privateServer.Id);
			if (existingPrivateServer != null)
			{
				existingPrivateServer.AccessCode = privateServer.AccessCode;
				existingPrivateServer.ExpirationDate = privateServer.ExpirationDate;
				existingPrivateServer.Name = privateServer.Name;
				existingPrivateServer.PrivateServerStatusTypeID = (byte)privateServer.StatusType;
				existingPrivateServer.OwnerUserID = privateServer.OwnerUserId;
				existingPrivateServer.UniverseID = privateServer.UniverseId;
				existingPrivateServer.LinkCode = privateServer.LinkCode;
				existingPrivateServer.Save();
			}
		}
	}

	public IReadOnlyCollection<IUser> GetPrivateServerUserAccesses(long privateServerId, int startIndex, int maxRows)
	{
		List<IUser> whitelistedUsers = new List<IUser>();
		foreach (PrivateServerUserAccess userAccess in PrivateServerUserAccess.GetPrivateServerUserAccessesByPrivateServerIdPaged(privateServerId, startIndex, maxRows))
		{
			whitelistedUsers.Add(_UserFactory.GetUser(userAccess.UserID));
		}
		return whitelistedUsers;
	}

	public bool AddPrivateServerUserAccess(long privateServerId, long userId)
	{
		PrivateServerUserAccess privateServerUserAccessByPrivateServerIDAndUserID = PrivateServerUserAccess.GetPrivateServerUserAccessByPrivateServerIDAndUserID(privateServerId, userId);
		Roblox.Platform.Games.Entities.PrivateServer privateServer = Roblox.Platform.Games.Entities.PrivateServer.Get(privateServerId);
		if (privateServerUserAccessByPrivateServerIDAndUserID == null)
		{
			PrivateServerUserAccess.CreateNew(privateServerId, privateServer.UniverseID, userId);
			return true;
		}
		return false;
	}

	public bool RemovePrivateServerUserAccess(long privateServerId, long userId)
	{
		PrivateServerUserAccess existingUserAccessRecord = PrivateServerUserAccess.GetPrivateServerUserAccessByPrivateServerIDAndUserID(privateServerId, userId);
		if (existingUserAccessRecord != null)
		{
			existingUserAccessRecord.Delete();
			return true;
		}
		return false;
	}

	public void CloseRunningGamesForUniverse(long universeId)
	{
		IUniverse universe = _UniverseFactory.GetUniverse(universeId);
		if (universe != null && universe.RootPlaceId.HasValue)
		{
			_GamesAuthority.ClosePrivateServers(universe.RootPlaceId.Value, CloseGameReasonType.Developer);
		}
	}

	public void RecordPrivateServerStatusChange(IPrivateServer privateServer, PrivateServerStatusType oldStatusType, PrivateServerStatusType newStatusType, PrivateServerStatusChangeReasonType statusChangeReasonType)
	{
		if (privateServer != null)
		{
			PrivateServerStatusChange.CreateNew(privateServer.Id, (byte)newStatusType, (byte)oldStatusType, (byte)statusChangeReasonType);
		}
	}

	public void ChangePrivateServerStatus(IPrivateServer privateServer, PrivateServerStatusType newStatus, PrivateServerStatusChangeReasonType statusChangeReason)
	{
		if (privateServer != null)
		{
			PrivateServerStatusType oldStatus = privateServer.StatusType;
			privateServer.StatusType = newStatus;
			if (newStatus != PrivateServerStatusType.Active)
			{
				privateServer.LinkCode = null;
			}
			SavePrivateServer(privateServer);
			RecordPrivateServerStatusChange(privateServer, oldStatus, newStatus, statusChangeReason);
		}
	}

	public void ExtendPrivateServerExpirationDate(IPrivateServer privateServer)
	{
		if (privateServer != null)
		{
			DateTime expirationDate = privateServer.ExpirationDate.AddMonths(Settings.Default.PrivateServerDefaultExpirationMonths);
			privateServer.ExpirationDate = expirationDate;
			if (privateServer.StatusType == PrivateServerStatusType.Canceled)
			{
				privateServer.StatusType = PrivateServerStatusType.Inactive;
				RecordPrivateServerStatusChange(privateServer, PrivateServerStatusType.Canceled, PrivateServerStatusType.Inactive, PrivateServerStatusChangeReasonType.RenewalSuccess);
			}
			SavePrivateServer(privateServer);
		}
	}

	public bool CancelRecurringSaleForPrivateServer(IPrivateServer privateServer)
	{
		if (Settings.Default.IsCancellingAllPreviousRecurringTransactionProfilesEnabled)
		{
			return _PrivateServerSaleManager.CancelAllRecurringSalesForPrivateServer(privateServer);
		}
		return _PrivateServerSaleManager.CancelRecurringSaleForPrivateServer(privateServer);
	}

	public bool CancelAllRecurringSalesForPrivateServer(IPrivateServer privateServer)
	{
		return _PrivateServerSaleManager.CancelAllRecurringSalesForPrivateServer(privateServer);
	}

	public IUniverse GetUniverseForPrivateServer(IPrivateServer privateServer)
	{
		if (privateServer != null)
		{
			return _UniverseFactory.GetUniverse(privateServer.UniverseId);
		}
		return null;
	}

	public void CloseRunningPrivateServer(IPrivateServer privateServer)
	{
		_PrivateServerGameManager.CloseRunningGameForPrivateServer(privateServer, CloseGameReasonType.Roblox);
	}

	public IReadOnlyList<long> LeaseCancellationTasks(Guid workerId, int leaseDurationInMinutes, int maxToLease)
	{
		return (from a in PrivateServerCancellationTask.LeaseTasks(workerId, leaseDurationInMinutes, maxToLease)
			select a.ID).ToList();
	}

	public void ExecutePrivateServerCancellationTask(long cancellationTaskId)
	{
		try
		{
			PrivateServerCancellationTask cancellationTask = PrivateServerCancellationTask.Get(cancellationTaskId);
			IPrivateServer privateServer = GetPrivateServer(cancellationTask.PrivateServerID);
			if (privateServer.ExpirationDate > DateTime.Now && !_PrivateServerSaleManager.GetOutOfSyncSalesWithRecurrencyTransactionProfile(privateServer).Any())
			{
				MarkCancellationTaskComplete(cancellationTask, PrivateServerCancellationStatusType.NoChangeRequired);
				PrivateServerCancellationTask.CreateNew(privateServer.Id, privateServer.ExpirationDate.AddDays(1.0));
			}
			else if (CancelAllRecurringSalesForPrivateServer(privateServer))
			{
				MarkCancellationTaskComplete(cancellationTask, PrivateServerCancellationStatusType.Cancelled);
			}
			else
			{
				MarkCancellationTaskComplete(cancellationTask, PrivateServerCancellationStatusType.Error, "Cancellation failed");
			}
		}
		catch (Exception e)
		{
			MarkCancellationTaskComplete(cancellationTaskId, PrivateServerCancellationStatusType.Error, e.Message);
			_Logger.Error(e);
		}
	}

	private void MarkCancellationTaskComplete(PrivateServerCancellationTask cancellationTask, PrivateServerCancellationStatusType statusType, string reason = null)
	{
		cancellationTask.Completed = DateTime.Now;
		cancellationTask.Save();
		PrivateServerCancellationTaskStatusType cancellationTaskStatusType = PrivateServerCancellationTaskStatusType.GetOrCreate(statusType.ToString());
		PrivateServerCancellationTaskStatus.CreateNew(cancellationTask.ID, cancellationTaskStatusType.ID, reason);
		if (statusType == PrivateServerCancellationStatusType.Error)
		{
			PrivateServerCancellationTask.CreateNew(cancellationTask.PrivateServerID, DateTime.Now.AddDays(1.0));
		}
	}

	private void MarkCancellationTaskComplete(long cancellationTaskId, PrivateServerCancellationStatusType statusType, string reason = null)
	{
		PrivateServerCancellationTask cancellationTask = PrivateServerCancellationTask.Get(cancellationTaskId);
		MarkCancellationTaskComplete(cancellationTask, statusType, reason);
	}
}
