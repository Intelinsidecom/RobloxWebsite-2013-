namespace Roblox.PremiumFeatures.Models.Interfaces;

/// <summary>
/// SubscriptionType Factory
/// </summary>
public interface ISubscriptionTypeFactory
{
	/// <summary>
	/// Get SubscriptionType Name
	/// </summary>
	/// <param name="name">PremiumFeature Name</param>
	/// <param name="accountAddOnTypeName">AccountAddOnType Name</param>
	/// <returns>SubscriptionType Name</returns>
	string GetSubscriptionTypeName(string name, string accountAddOnTypeName);

	/// <summary>
	/// Get IsBuildersClubType
	/// </summary>
	/// <param name="name">Product name</param>
	/// <returns>If product is Builders Club type</returns>
	bool IsBuildersClubType(string name);
}
