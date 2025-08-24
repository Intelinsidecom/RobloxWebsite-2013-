namespace Roblox.Platform.Email.Delivery;

/// <summary>
/// An interface for publishing an <see cref="T:Roblox.Platform.Email.Delivery.EmailDeliveryEvent" /> to SNS.
/// </summary>
internal interface IEmailDeliveryEventsPublisher
{
	/// <summary>
	/// Publishes the provided <see cref="T:Roblox.Platform.Email.Delivery.EmailDeliveryEvent" /> to SNS.
	/// </summary>
	/// <param name="emailDeliveryEvent">The <see cref="T:Roblox.Platform.Email.Delivery.EmailDeliveryEvent" />.</param>
	void Publish(EmailDeliveryEvent emailDeliveryEvent);
}
