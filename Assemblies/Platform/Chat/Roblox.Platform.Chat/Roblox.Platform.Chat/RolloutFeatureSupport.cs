using Roblox.Platform.Membership;

namespace Roblox.Platform.Chat;

public static class RolloutFeatureSupport
{
	public static bool IsFeatureEnabled(IUser user, bool isFeatureEnabledForSoothsayers, bool isFeatureEnabledForBetatesters, int featureRolloutPercentage)
	{
		if (user == null)
		{
			return false;
		}
		if (IsFeatureEnabledForSoothsayersAndBetatesters(user, isFeatureEnabledForSoothsayers, isFeatureEnabledForBetatesters))
		{
			return true;
		}
		return user.Id % 100 < featureRolloutPercentage;
	}

	public static bool IsFeatureEnabled(IUser user, bool isFeatureEnabledForSoothsayers, bool isFeatureEnabledForBetatesters, int featureInclusiveStartRolloutPercentage, int featureExclusiveEndRolloutPercentage)
	{
		if (user == null)
		{
			return false;
		}
		if (IsFeatureEnabledForSoothsayersAndBetatesters(user, isFeatureEnabledForSoothsayers, isFeatureEnabledForBetatesters))
		{
			return true;
		}
		if (user.Id % 100 >= featureInclusiveStartRolloutPercentage)
		{
			return user.Id % 100 < featureExclusiveEndRolloutPercentage;
		}
		return false;
	}

	private static bool IsFeatureEnabledForSoothsayersAndBetatesters(IUser user, bool isFeatureEnabledForSoothsayers, bool isFeatureEnabledForBetatesters)
	{
		if (isFeatureEnabledForSoothsayers && user.IsSoothSayer())
		{
			return true;
		}
		if (isFeatureEnabledForBetatesters && user.IsBetaTester())
		{
			return true;
		}
		return false;
	}
}
