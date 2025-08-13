namespace Roblox.Platform.Notifications.Push.Entities;

internal interface IDestinationEntityFactory
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Notifications.Push.Entities.IDestinationEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Notifications.Push.Entities.IDestinationEntity" /> with the given ID, or null if none existed.</returns>
	IDestinationEntity Get(long id);

	IDestinationEntity GetByDestinationTypeIdAndExternalServiceDestinationId(int destinationTypeId, string externalServiceDestinationId);

	IDestinationEntity Create(int destinationTypeId, string externalServiceDestinationId, byte[] externalServiceDestinationIDHash, string notificationDeliveryEndpoint);
}
