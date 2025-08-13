using System;
using Roblox.PremiumFeatures;

namespace Roblox;

public class PremiumFeatureHelper
{
	public static readonly Guid WorkerID = Guid.NewGuid();

	public static DateTime CalculateBaseExpiration(DateTime startDate, DurationType durationType, bool isRenewal)
	{
		if (!isRenewal)
		{
			return startDate.Add(durationType.AmountTimeSpan);
		}
		return durationType.Value switch
		{
			"None" => throw new ArgumentException("Cannot calculate expiration for DurationType: None."), 
			"1 Month" => startDate.AddMonths(1), 
			"6 Months" => startDate.AddMonths(6), 
			"12 Months" => startDate.AddMonths(12), 
			"Lifetime" => startDate.AddYears(100), 
			_ => throw new ArgumentException($"Unknown DurationType: {durationType.Value}."), 
		};
	}

	public static DateTime CalculateGracePeriodAwareUnpaddedExpiration(DateTime expiration, bool isRenewal)
	{
		if (!isRenewal)
		{
			return expiration;
		}
		return expiration.AddDays(-3.0);
	}

	public static DateTime? CalculateRenewal(DateTime baseExpiration, bool isRenewal)
	{
		if (!isRenewal)
		{
			return null;
		}
		return baseExpiration;
	}

	public static bool IsAnyBuildersClubMember(long accountId)
	{
		AccountAddOn accountAddOn = AccountAddOn.GetBuildersClubMembershipAccountAddOn(accountId);
		if (accountAddOn == null)
		{
			return false;
		}
		if (accountAddOn.Expiration <= DateTime.Now)
		{
			return false;
		}
		return PremiumFeature.Get(accountAddOn.PremiumFeatureID).IsAnyBuildersClub;
	}

	public static bool IsBuildersClubMember(long accountId)
	{
		AccountAddOn accountAddOn = AccountAddOn.GetBuildersClubMembershipAccountAddOn(accountId);
		if (accountAddOn == null)
		{
			return false;
		}
		if (accountAddOn.Expiration <= DateTime.Now)
		{
			return false;
		}
		return PremiumFeature.Get(accountAddOn.PremiumFeatureID).IsBuildersClub;
	}

	public static bool IsTurboBuildersClubMember(long accountId)
	{
		AccountAddOn accountAddOn = AccountAddOn.GetBuildersClubMembershipAccountAddOn(accountId);
		if (accountAddOn == null)
		{
			return false;
		}
		if (accountAddOn.Expiration <= DateTime.Now)
		{
			return false;
		}
		return PremiumFeature.Get(accountAddOn.PremiumFeatureID).IsTurboBuildersClub;
	}

	public static bool IsOutrageousBuildersClubMember(long accountId)
	{
		AccountAddOn accountAddOn = AccountAddOn.GetBuildersClubMembershipAccountAddOn(accountId);
		if (accountAddOn == null)
		{
			return false;
		}
		if (accountAddOn.Expiration <= DateTime.Now)
		{
			return false;
		}
		return PremiumFeature.Get(accountAddOn.PremiumFeatureID).IsOutrageousBuildersClub;
	}

	public static bool IsExBuildersClubMember(long accountId)
	{
		AccountAddOn accountAddOn = AccountAddOn.GetBuildersClubMembershipAccountAddOn(accountId);
		if (accountAddOn == null)
		{
			return false;
		}
		if (accountAddOn.Expiration <= DateTime.Now)
		{
			return PremiumFeature.Get(accountAddOn.PremiumFeatureID).IsAnyBuildersClub;
		}
		return false;
	}

	public static string GetExBuildersClubMembership(long accountId)
	{
		AccountAddOn accountAddOn = AccountAddOn.GetBuildersClubMembershipAccountAddOn(accountId);
		if (accountAddOn == null)
		{
			return "";
		}
		if (accountAddOn.Expiration <= DateTime.Now)
		{
			PremiumFeature premiumFeature = PremiumFeature.Get(accountAddOn.PremiumFeatureID);
			if (premiumFeature.IsBuildersClub)
			{
				return "Builders Club";
			}
			if (premiumFeature.IsTurboBuildersClub)
			{
				return "Turbo Builders Club";
			}
			if (premiumFeature.IsOutrageousBuildersClub)
			{
				return "Outrageous Builders Club";
			}
			return "Builders Club";
		}
		return "";
	}

	public static long GetCurrentOrFormerBuildersClubStipend(long accountId)
	{
		return AccountAddOn.GetBuildersClubMembershipAccountAddOn(accountId)?.GetStipendAmount() ?? 0;
	}
}
