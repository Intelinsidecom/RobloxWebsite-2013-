using System;
using System.Collections.Generic;
using Roblox.Platform.Membership;
using Roblox.Platform.Universes;

namespace Roblox.Platform.Games.PrivateServer;

public interface IPrivateServerProcessorFactory
{
	IPrivateServer GetPrivateServer(long privateServerId);

	IPrivateServer GetPrivateServerBySaleId(long saleId);

	IReadOnlyCollection<IPrivateServer> GetPrivateServersByOwnerUserId(long ownerUserId, int startIndex, int maxRows);

	long GetTotalNumberOfPrivateServersByOwnerUserId(long ownerUserId);

	bool RemovePrivateServerUserAccess(long privateServerId, long userId);

	bool AddPrivateServerUserAccess(long privateServerId, long userId);

	IReadOnlyCollection<IUser> GetPrivateServerUserAccesses(long privateServerId, int startIndex, int maxRows);

	IReadOnlyCollection<IPrivateServer> GetPrivateServersForUniverse(long universeId, int startIndex, int maxRows);

	void SavePrivateServer(IPrivateServer privateServer);

	void RecordPrivateServerStatusChange(IPrivateServer privateServer, PrivateServerStatusType oldStatusType, PrivateServerStatusType newStatusType, PrivateServerStatusChangeReasonType statusChangeReasonType);

	void ChangePrivateServerStatus(IPrivateServer privateServer, PrivateServerStatusType newStatus, PrivateServerStatusChangeReasonType statusChangeReason);

	void ExtendPrivateServerExpirationDate(IPrivateServer privateServer);

	void CloseRunningGamesForUniverse(long universeId);

	void CloseRunningPrivateServer(IPrivateServer privateServer);

	bool CancelRecurringSaleForPrivateServer(IPrivateServer privateServer);

	bool CancelAllRecurringSalesForPrivateServer(IPrivateServer privateServer);

	IUniverse GetUniverseForPrivateServer(IPrivateServer privateServer);

	IReadOnlyList<long> LeaseCancellationTasks(Guid workerId, int leaseDurationInMinutes, int maxToLease);

	void ExecutePrivateServerCancellationTask(long cancellationTaskId);
}
