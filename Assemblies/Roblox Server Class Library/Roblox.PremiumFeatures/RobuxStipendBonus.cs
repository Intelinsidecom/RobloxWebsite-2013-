using System;
using Roblox.Properties;

namespace Roblox.PremiumFeatures;

/// <summary>
/// This is a prototype class for awarding additional ROBUX for a stipend.
/// Before extending this class consider redesigning it such that there
/// is some database presence.
///
/// Some ideas for future expansion:
///
/// 1.  Add RobuxStipendBonusTypes to DB and use this to determine an appropriate bonus
///
/// 2.  Fully convert this to a data-driven design
///     -Bake in acceptable bonus amounts
///     -Upgrade a user's robux stipend on a monthly basis
/// </summary>
public class RobuxStipendBonus
{
	private static float MaxMultiplier => Settings.Default.RobuxStipendBonusMaxMultiplier;

	private static float MaxDays => Settings.Default.RobuxStipendBonusMaxDays;

	/// <summary>
	/// y = (MaxMultiplier - 1)/MaxDays * x + 1
	///
	/// A linear function from 1 to MaxMultiplier
	/// </summary>
	private static float CalculateLoyaltyMultiplier(int days)
	{
		if ((float)days >= MaxDays)
		{
			return MaxMultiplier;
		}
		return (MaxMultiplier - 1f) / MaxDays * (float)days + 1f;
	}

	/// <summary>
	/// Calculates how much *extra* daily Robux a user should get based
	/// on how long they've been in BC
	/// </summary>
	public static int CalculateLoyaltyBonus(User user, DateTime? lastAwarded, out float multiplier)
	{
		AccountAddOn bcMembership = AccountAddOn.GetBuildersClubMembershipAccountAddOn(user.AccountID);
		if (bcMembership == null || bcMembership.Expiration <= DateTime.Now || !bcMembership.RenewedSince.HasValue || bcMembership.RenewedSince.Value > Settings.Default.RobuxStipendBonusTerminationDate)
		{
			multiplier = 0f;
			return 0;
		}
		int daysLoyal = ((!lastAwarded.HasValue) ? (DateTime.Now - bcMembership.RenewedSince.Value).Days : (lastAwarded.Value.AddDays(1.0) - bcMembership.RenewedSince.Value).Days);
		multiplier = CalculateLoyaltyMultiplier(daysLoyal);
		try
		{
			long stipendAmount = RobuxStipendQuantityType.Get(RobuxStipend.Get(bcMembership.RobuxStipendID).RobuxStipendQuantityTypeID).Amount;
			return (int)((float)stipendAmount * multiplier - (float)stipendAmount);
		}
		catch (Exception ex)
		{
			ExceptionHandler.LogException(ex);
			return 0;
		}
	}

	public static int CalculateLoyaltyBonus(User user, out float multiplier)
	{
		return CalculateLoyaltyBonus(user, null, out multiplier);
	}

	public static int CalculateLoyaltyBonus(User user, DateTime? lastAwarded)
	{
		float i;
		return CalculateLoyaltyBonus(user, lastAwarded, out i);
	}

	public static int CalculateLoyaltyBonus(User user)
	{
		float i;
		return CalculateLoyaltyBonus(user, null, out i);
	}
}
