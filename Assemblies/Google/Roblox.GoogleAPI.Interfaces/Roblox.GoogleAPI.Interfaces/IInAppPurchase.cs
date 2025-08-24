namespace Roblox.GoogleAPI.Interfaces;

public interface IInAppPurchase
{
	int? ConsumptionState { get; set; }

	string DeveloperPayload { get; set; }

	string ETag { get; set; }

	string Kind { get; set; }

	int? PurchaseState { get; set; }

	long? PurchaseTime { get; set; }

	string OrderID { get; set; }
}
