namespace Roblox.Platform.Notifications.Push;

public enum PushDeliveryResult
{
	Success = 1,
	InvalidReceiverDestination,
	DeliveryNotAllowed,
	AttemptNotAllowed,
	UnknownError
}
