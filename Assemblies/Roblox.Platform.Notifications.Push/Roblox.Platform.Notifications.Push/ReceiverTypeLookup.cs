using Roblox.Platform.Notifications.Push.Entities;

namespace Roblox.Platform.Notifications.Push;

internal class ReceiverTypeLookup
{
	private const string _UserReceiverTypeValue = "User";

	public IReceiverTypeEntity User { get; }

	public ReceiverTypeLookup(IReceiverTypeEntityFactory receiverTypeEntityFactory)
	{
		User = receiverTypeEntityFactory.GetOrCreate("User");
	}
}
