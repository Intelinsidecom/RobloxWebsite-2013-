using Roblox.EventLog;
using Roblox.Platform.Party.Entities;
using Roblox.RealTimeNotifications;

namespace Roblox.Platform.Party;

public class PartyUserNotificationPublisher
{
	private readonly UserNotificationPublisher<PartyUpdateNotificationMessage> _UserNotificationPublisher;

	public PartyUserNotificationPublisher(ILogger logger)
	{
		_UserNotificationPublisher = new UserNotificationPublisher<PartyUpdateNotificationMessage>(logger, "PartyNotifications");
	}

	public void NotifyPartyMembersAndPendingUsers(Roblox.Platform.Party.Entities.Party party, PartyUpdateNotificationType type, long? excludedUserId = null)
	{
		PartyUpdateNotificationMessage notification = new PartyUpdateNotificationMessage(party.Id, party.WalledGarden, type);
		long[] memberUserIds = party.MemberUserIds;
		foreach (long userId in memberUserIds)
		{
			if (!excludedUserId.HasValue || excludedUserId.Value != userId)
			{
				_UserNotificationPublisher.Publish(userId, notification);
			}
		}
		memberUserIds = party.PendingUserIds;
		foreach (long userId2 in memberUserIds)
		{
			if (!excludedUserId.HasValue || excludedUserId.Value != userId2)
			{
				_UserNotificationPublisher.Publish(userId2, notification);
			}
		}
	}

	public void NotifyPartyMember(Roblox.Platform.Party.Entities.Party party, long userId, PartyUpdateNotificationType type)
	{
		PartyUpdateNotificationMessage notification = new PartyUpdateNotificationMessage(party.Id, party.WalledGarden, type);
		_UserNotificationPublisher.Publish(userId, notification);
	}
}
