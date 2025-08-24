using System;
using Roblox.PremiumFeatures.Models.Enums;
using Roblox.PremiumFeatures.Models.Interfaces;

namespace Roblox.PremiumFeatures.Models.Implementations;

/// <summary>
/// GetSubscriptionType
/// </summary>
public class SubscriptionTypeFactory : ISubscriptionTypeFactory
{
	/// <summary>
	/// Get the SubscriptionType Name
	/// </summary>
	/// <param name="name">PremiumFeature name</param>
	/// <param name="accountAddOnTypeName">Account Add On Type Name</param>
	/// <returns>string version of corresponding<see cref="T:Roblox.PremiumFeatures.Models.Enums.SubscriptionType" /></returns>
	public string GetSubscriptionTypeName(string name, string accountAddOnTypeName)
	{
		if (!Enum.TryParse<SubscriptionType>(name.Replace(" ", string.Empty), out var subscriptionType))
		{
			subscriptionType = GetBuildersClubSubscriptionType(accountAddOnTypeName);
		}
		return subscriptionType.ToString();
	}

	public bool IsBuildersClubType(string name)
	{
		return !GetBuildersClubSubscriptionType(name).Equals(SubscriptionType.Unknown);
	}

	private SubscriptionType GetBuildersClubSubscriptionType(string name)
	{
		return name switch
		{
			"Builders Club Membership" => SubscriptionType.BC_ClassicBuildersClub, 
			"Turbo Builders Club Membership" => SubscriptionType.BC_TurboBuildersClub, 
			"Outrageous Builders Club Membership" => SubscriptionType.BC_OutrageousBuildersClub, 
			_ => SubscriptionType.Unknown, 
		};
	}
}
