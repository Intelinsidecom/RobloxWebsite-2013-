using Roblox.EventLog;
using Roblox.Platform.Presence.Events;
using Roblox.RealTimeNotifications;

namespace Roblox.Platform.Presence.Implementation;

public class ClientPresenceNotificationPublisher
{
	private readonly UserNotificationPublisher<ClientPresenceNotificationMessage> _UserNotificationPublisher;

	public ClientPresenceNotificationPublisher(ILogger logger)
	{
		_UserNotificationPublisher = new UserNotificationPublisher<ClientPresenceNotificationMessage>(logger, "ClientPresenceNotifications");
	}

	public bool PublishUserDisconnectNotification(long recipientUserId, long placeId)
	{
		ClientPresenceNotificationMessage message = new ClientPresenceNotificationMessage
		{
			PlaceId = placeId,
			Type = ClientStatusType.Disconnect.ToString()
		};
		return _UserNotificationPublisher.Publish(recipientUserId, message).IsSuccess();
	}
}
