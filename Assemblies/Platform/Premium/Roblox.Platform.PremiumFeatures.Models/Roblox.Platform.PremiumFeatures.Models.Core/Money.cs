using System.Runtime.Serialization;

namespace Roblox.PremiumFeatures.Models.Core;

/// <summary>
/// Represents a monetary value.
/// </summary>
[DataContract]
public struct Money
{
	/// <summary>
	/// The amount of money.
	/// </summary>
	[DataMember(Name = "amount")]
	public decimal Amount;

	/// <summary>
	/// Optional field for amount in USD, and should only be populated when the currency is not USD.  
	/// This is primarily here to be used for fraud detection.
	/// </summary>
	[DataMember(Name = "usdAmount")]
	public decimal USDAmount;

	/// <summary>
	/// The currency of the money.
	/// </summary>
	[DataMember(Name = "currency")]
	public Currency Currency;
}
