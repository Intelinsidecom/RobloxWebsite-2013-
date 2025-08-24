using System;
using System.Collections.Generic;
using Roblox.Marketplace.Client;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Games.PrivateServer;

public interface IPrivateServerFactory
{
	int PrivateServerNameMaxLength { get; }

	string PrivateServerNameErrorText { get; }

	bool ArePrivateServerLinksEnabled { get; }

	bool ArePrivateServerLinksEnabledForSoothsayers { get; }

	IPrivateServer PurchasePrivateServer(long universeId, long ownerUserId, string serverName, long expectedPrice, byte platformTypeId, IPrivateServerPermissionsFactory privateServerPermissionsFactory, out TransactionStatus transactionStatus);

	IPrivateServer GetPrivateServer(long privateServerId);

	IPrivateServer GetPrivateServerByAccessCode(Guid accessCode);

	void UpdatePrivateServerName(long ownerUserId, long privateServerId, string serverName);

	void UpdatePrivateServerFriendsAccess(long ownerUserId, long privateServerId, bool allowFriends, IPrivateServerPermissionsFactory privateServerPermissionsFactory);

	IReadOnlyCollection<long> UpdatePrivateServerClanAccess(long ownerUserId, long privateServerId, IReadOnlyCollection<long> allowedClanIds, IPrivateServerPermissionsFactory privateServerPermissionsFactory);

	void UpdatePrivateServerFriendsList(long ownerUserId, long privateServerId, IReadOnlyCollection<IUser> usersToAddToWhitelist, IReadOnlyCollection<IUser> usersToRemoveFromWhitelist, IPrivateServerPermissionsFactory privateServerPermissionsFactory);

	void UpdatePrivateServer(long ownerUserId, long privateServerId, string name, bool? allowFriends, IReadOnlyCollection<IUser> usersToAddToWhitelist, IReadOnlyCollection<IUser> usersToRemoveFromWhitelist, IPrivateServerPermissionsFactory privateServerPermissionsFactory, IReadOnlyCollection<long> allowedClanIds);

	void UpdatePrivateServerStatus(IUser ownerUser, long privateServerId, PrivateServerStatusType newStatusType);

	void CancelPrivateServerUserInitiated(long privateServerId);

	bool CancelRecurringPrivateServer(long ownerUserId, long privateServerId);

	bool RenewRecurringPrivateServer(long ownerUserId, long privateServerId, byte platformTypeId, long expectedPrice);

	bool IsPrivateServerRecurrenceActive(long privateServerId);

	long GetPrivateServerDefaultPrice();

	long GetPrivateServerMinPrice();

	PrivateServerStatusChangeReasonType? GetMostRecentStatusChangeReasonType(long privateServerId);

	string GetRecurringProfileIdForPrivateServer(long privateServerId);

	bool DoesPrivateServerHaveRecurringProfile(long privateServerId);

	bool HasPrivateServerPriceChanged(long privateServerId, long universeId);

	long GetTotalNumberOfActivePrivateServerSubscriptionsByUniverseId(long universeId);

	bool ValidateLinkCodeConstraints(string linkCode);

	IPrivateServer GetPrivateServerForLinkCode(string linkCode, long universeId);

	IReadOnlyCollection<IPrivateServer> GetPrivateServersByOwnerUserID(long ownerUserId, int startIndex, int maxRows);

	long GetTotalNumberOfPrivateServersByOwnerUserID(long ownerUserId);

	IReadOnlyCollection<IPrivateServer> GetPrivateServersByOwnerUserIDAndUniverseID(long ownerUserId, long universeId, int startIndex, int maxRows);

	long GetTotalNumberOfPrivateServersByOwnerUserIDAndUniverseID(long ownerUserId, long universeId);

	IReadOnlyCollection<IPrivateServer> GetPrivateServersUserHasAccessTo(long userId, int startIndex, int maxRows);

	long GetTotalNumberOfPrivateServersUserHasAccessTo(long userId);

	IReadOnlyCollection<IPrivateServer> GetPrivateServersUserHasAccessToByUniverseID(long userId, long universeId, int startIndex, int maxRows);

	long GetTotalNumberOfPrivateServersUserHasAccessToByUniverseID(long userId, long universeId);
}
