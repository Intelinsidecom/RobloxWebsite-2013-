using Roblox.Platform.Notifications.Push.Entities;

namespace Roblox.Platform.Notifications.Push;

internal interface IPushServiceClient
{
	/// <summary>
	/// Given a destination type and a notification registration token, this will provide a unique endpoint 
	/// at the push service that can be used to deliver notificaitons to that device
	/// </summary>
	/// <param name="destinationType"></param>
	/// <param name="deviceToken"></param>
	/// <returns></returns>
	string GetDevicePushPublishEndpoint(IDestinationTypeEntity destinationType, string deviceToken, string nativeEndpoint);

	/// <summary>
	/// Publishes a notification to the destination device
	/// </summary>
	/// <param name="endpoint">The endpoint to deliver the message to</param>
	/// <param name="jsonMessage">The JSON formatted message contianing the PushNotificationID GUID. This 
	/// should be formatted appropriately for the destination platform</param>
	/// <returns>Returns a receipt ID for the push attempt from the push service</returns>
	PublishNotificationResult PublishNotificationToDestination(string endpoint, string jsonMessage);
}
