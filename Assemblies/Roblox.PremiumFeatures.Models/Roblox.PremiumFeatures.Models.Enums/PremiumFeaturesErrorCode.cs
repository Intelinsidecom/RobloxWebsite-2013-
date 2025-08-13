namespace Roblox.PremiumFeatures.Models.Enums;

/// <summary>
/// Error code getting responses back from the PremiumFeatures Service
/// </summary>
public enum PremiumFeaturesErrorCode
{
	/// <summary>
	/// No error
	/// </summary>
	NoError = 0,
	/// <summary>
	/// User not found
	/// </summary>
	UserNotFound = 10,
	/// <summary>
	/// Unable to find user's subscription
	/// </summary>
	UserSubscriptionNotFound = 15,
	/// <summary>
	/// Subscription product not found
	/// </summary>
	SubscriptionProductNotFound = 20,
	/// <summary>
	/// Product price not found
	/// </summary>
	ProductPriceNotFound = 30,
	/// <summary>
	/// Invalid input
	/// </summary>
	InvalidInput = 40,
	/// <summary>
	/// Not Confirmed
	/// </summary>
	NotConfirmed = 41,
	/// <summary>
	/// Unable to calculate robux grant
	/// </summary>
	UnableToCalculateRobuxGrant = 50,
	/// <summary>
	/// Exceeds the max robux grant amount
	/// </summary>
	ExceedsMaxRobuxGrantAmount = 51,
	/// <summary>
	/// Generic server error, currently only used for leased lock errors
	/// </summary>
	ServerError = 60,
	/// <summary>
	/// Unable to update subscription
	/// </summary>
	UnableToUpdateSubscription = 70,
	/// <summary>
	/// Unknown
	/// </summary>
	Unknown = int.MaxValue
}
