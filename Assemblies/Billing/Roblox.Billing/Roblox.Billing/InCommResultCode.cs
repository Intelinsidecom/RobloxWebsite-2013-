namespace Roblox.Billing;

public enum InCommResultCode
{
	Success = 0,
	UnrecognizedMerchant = -1,
	UnrecognizedResponse = -2,
	UnknownError = -3,
	/// <summary>
	/// There is a system error such as connectivity issues, database crash or system shutdown, from InComm.
	/// </summary>
	InCommSystemError = 29,
	/// <summary>
	/// The request sent by vendor is invalid. It might be missing some mandatory field values or might have an invalid format.
	/// </summary>
	InvalidRequest = 32,
	/// <summary>
	/// The card value has been redeemed by the vendor and cannot be redeemed anymore.
	/// </summary>
	CardAlreadyRedeemed = 38,
	/// <summary>
	/// The card is invalid (it is not an InComm card), or the card does not belong to Vendor.
	/// </summary>
	InvalidCard = 43,
	/// <summary>
	/// The card is in deactive status and cannot be redeemed/reversed by vendor. This is the original status of the card when shipped to the merchant.
	/// </summary>
	CardDeactivated = 46,
	/// <summary>
	/// The card is not redeemed yet hence reversal is not supported.
	/// </summary>
	CardActive = 52,
	/// <summary>
	/// The card is suspended in InComm’s systems. This could be due to suspected fraud or maybe lost in transit.
	/// </summary>
	CardActionsSuspended = 109
}
