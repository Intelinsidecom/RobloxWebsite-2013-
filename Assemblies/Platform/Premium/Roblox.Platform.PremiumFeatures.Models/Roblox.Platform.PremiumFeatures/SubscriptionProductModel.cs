using System;
using System.Runtime.Serialization;

namespace Roblox.PremiumFeatures;

/// <summary>
/// User's subscription product
/// </summary>
[DataContract]
public class SubscriptionProductModel
{
	/// <summary>
	/// PremiumFeature Id
	/// </summary>
	[DataMember(Name = "premiumFeatureId")]
	public int PremiumFeatureId { get; set; }

	/// <summary>
	/// Subscription Type
	/// </summary>
	[DataMember(Name = "subscriptionTypeName")]
	public string SubscriptionTypeName { get; set; }

	/// <summary>
	/// Robux Stipend Amount
	/// </summary>
	[DataMember(Name = "robuxStipendAmount")]
	public long RobuxStipendAmount { get; set; }

	/// <summary>
	/// Is Lifetime
	/// </summary>
	[DataMember(Name = "isLifetime")]
	public bool IsLifetime { get; set; }

	/// <summary>
	/// Expiration date
	/// </summary>
	[DataMember(Name = "expiration")]
	public DateTime Expiration { get; set; }

	/// <summary>
	/// Renewal Date
	/// </summary>
	[DataMember(Name = "renewal")]
	public DateTime? Renewal { get; set; }

	/// <summary>
	/// Created Date
	/// </summary>
	[DataMember(Name = "created")]
	public DateTime Created { get; set; }

	/// <summary>
	/// Platform where Subscription was purchased
	/// </summary>
	[DataMember(Name = "purchasePlatform")]
	public string PurchasePlatform { get; set; }
}
