using System;
using Roblox.Billing;
using Roblox.FloodCheckers;
using Roblox.Marketing;
using Roblox.Platform.Marketing.Properties;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Marketing;

public static class MembershipExtensions
{
	/// <summary>
	/// Determines whether or not to show preroll to this user
	/// </summary>
	/// <param name="user">The user</param>
	/// <param name="isAdServedFromDfp">Determines whether the specified user will be served an ad from DFP or Adap.tv</param>
	/// <param name="reason">Reason of declining to show preoll</param>
	/// <param name="getHidePrerollAbVariation">A function to get the hide ads preroll variation.</param>
	/// <returns>Whether or not to show preroll to this user</returns>
	public static bool CanShowPreroll(this IUser user, bool isAdServedFromDfp, out PrerollDeclineReasonType reason)
	{
		if (user == null)
		{
			reason = PrerollDeclineReasonType.Guest;
			return false;
		}
		if (user.IsBCMember())
		{
			reason = PrerollDeclineReasonType.BuildersClub;
			return false;
		}
		if (Settings.Default.IsPrerollShownEveryXMinutesEnabled)
		{
			return CanShowPrerollWithFloodCheck(user, out reason);
		}
		return CanShowPrerollWithRandomChance(isAdServedFromDfp, out reason);
	}

	/// <summary>
	/// Determines whether or not a user sees longer preroll.
	/// Users see longer preroll is defined as those whose account age is greater than three months but never purchased anything.
	/// </summary>
	/// <param name="user">The user</param>
	/// <returns>Whether or not a user sees longer preroll</returns>
	public static bool UserSeesLongerPreroll(this IUser user)
	{
		if (user == null)
		{
			return false;
		}
		if (user.Created < DateTime.Now.AddMonths(-3))
		{
			return Sale.GetMostRecentSaleForAccount(Convert.ToInt32(user.AccountId)) == null;
		}
		return false;
	}

	/// <summary>
	/// Whether Roblox has paid a third party for the acquisition of a given user.
	/// </summary>
	/// <param name="user"></param>
	/// <returns>True if they are third-party acquisition. False if they are Direct or WOM traffic.</returns>
	public static bool IsPaidTraffic(this IUser user)
	{
		if (user == null)
		{
			return false;
		}
		UserAcquisition userAcquisitionEntity = UserAcquisition.GetByUserID(user.Id);
		if (userAcquisitionEntity == null)
		{
			return false;
		}
		if (string.IsNullOrWhiteSpace(userAcquisitionEntity.AcquisitionMedium))
		{
			return false;
		}
		if (userAcquisitionEntity.AcquisitionMedium == "Direct")
		{
			return false;
		}
		if (userAcquisitionEntity.AcquisitionMedium == "Social")
		{
			return false;
		}
		if (userAcquisitionEntity.AcquisitionMedium == "Facebook")
		{
			return false;
		}
		return true;
	}

	/// <summary>
	/// Hide preroll for first N days for new user, and throttle preroll to show X minutes after the previous one.
	/// </summary>
	/// <param name="user">The specified user</param>
	/// <param name="reason">Reason of declining to show preoll</param>
	/// <returns>Whether or not to show preroll to the user</returns>
	private static bool CanShowPrerollWithFloodCheck(IUser user, out PrerollDeclineReasonType reason)
	{
		if (user == null)
		{
			reason = PrerollDeclineReasonType.Guest;
			return false;
		}
		if (DateTime.Now - user.Created < TimeSpan.FromDays(Settings.Default.DaysBeforeShowPrerollToNewUser))
		{
			reason = PrerollDeclineReasonType.NewUser;
			return false;
		}
		if (new ShowPrerollFloodChecker(user.Id).IsFlooded())
		{
			reason = PrerollDeclineReasonType.Flooded;
			return false;
		}
		reason = PrerollDeclineReasonType.None;
		return true;
	}

	/// <summary>
	/// Show preroll from the very beginning. Each qualified user gets X % chance to see the preroll.
	/// DFP and Adap.tv has their own specific % chance
	/// </summary>
	/// <param name="isAdServedFromDfp">Whether the specified user will be served an ad from DFP or Adap.tv</param>
	/// <param name="reason">Reason of declining to show preoll</param>
	/// <returns>Whether or not to show preroll to the user</returns>
	private static bool CanShowPrerollWithRandomChance(bool isAdServedFromDfp, out PrerollDeclineReasonType reason)
	{
		PrerollSettingsProvider prerollSettingsProvider = new PrerollSettingsProvider();
		double chanceToGetPreroll = (isAdServedFromDfp ? prerollSettingsProvider.PrerollSimplePercentageChanceForDFP : prerollSettingsProvider.PrerollSimplePercentageChance);
		if (new Random().NextDouble() >= chanceToGetPreroll)
		{
			reason = PrerollDeclineReasonType.RandomChance;
			return false;
		}
		reason = PrerollDeclineReasonType.None;
		return true;
	}
}
