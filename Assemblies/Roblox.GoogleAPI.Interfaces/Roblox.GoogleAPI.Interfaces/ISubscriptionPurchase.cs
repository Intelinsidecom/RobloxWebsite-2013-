namespace Roblox.GoogleAPI.Interfaces;

public interface ISubscriptionPurchase
{
	bool? AutoRenewing { get; set; }

	string ETag { get; set; }

	long? InitiationTimestampMsec { get; set; }

	string Kind { get; set; }

	long? ValidUntilTimestampMsec { get; set; }
}
