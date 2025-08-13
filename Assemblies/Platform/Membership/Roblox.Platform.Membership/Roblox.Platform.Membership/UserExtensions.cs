using System;
using System.Text;
using Roblox.Hashing;
using Roblox.Platform.Core;
using Roblox.Platform.MembershipCore;
using Roblox.PremiumFeatures;

namespace Roblox.Platform.Membership;

public static class UserExtensions
{
	public static bool HasVerifiedEmail(this IUser user)
	{
		return AccountEmailAddress.GetCurrent(user.AccountId)?.IsVerified ?? false;
	}

	/// <summary>
	/// Helper method, is the given IUser null or under 13.
	/// </summary>
	/// <param name="user">IUser to evaluate.</param>
	/// <returns></returns>
	public static bool IsUnder13(this IUser user)
	{
		if (user == null)
		{
			return true;
		}
		return user.AgeBracket == AgeBracket.AgeUnder13;
	}

	/// <summary>
	/// Helper method, is the given <see cref="T:Roblox.Platform.Membership.IUser" /> null or in Forgotten status.
	/// </summary>
	/// <param name="user"><see cref="T:Roblox.Platform.Membership.IUser" /> to evaluate.</param>
	/// <returns>True if the user is null or forgotten, False otherwise.</returns>
	public static bool IsForgotten(this IUser user)
	{
		if (user == null)
		{
			return true;
		}
		return user.AccountStatus == AccountStatus.Forgotten;
	}

	public static bool IsModerator(this IUser user)
	{
		return Roblox.User.MustGet(user.Id).TestIsModerator();
	}

	public static bool IsCommunityRepresentative(this IUser user)
	{
		return Roblox.User.MustGet(user.Id).TestIsCommunityRepresentative();
	}

	public static bool IsCommunityManager(this IUser user)
	{
		return Roblox.User.MustGet(user.Id).TestIsCommunityManager();
	}

	public static bool IsRegularUser(this IUser user)
	{
		return Roblox.User.MustGet(user.Id).TestIsRegularUser();
	}

	public static bool IsBursar(this IUser user)
	{
		return Roblox.User.MustGet(user.Id).TestIsBursar();
	}

	public static bool IsCustomerService(this IUser user)
	{
		return Roblox.User.MustGet(user.Id).TestIsCustomerService();
	}

	public static bool IsFinance(this IUser user)
	{
		return Roblox.User.MustGet(user.Id).TestIsFinance();
	}

	public static bool IsTrustedContributor(this IUser user)
	{
		return Roblox.User.MustGet(user.Id).TestIsTrustedContributor();
	}

	public static bool IsSoothSayer(this IUserIdentifier user)
	{
		return Roblox.User.MustGet(user.Id).TestIsSoothsayer();
	}

	public static bool IsSuperAdministrator(this IUser user)
	{
		return Roblox.User.MustGet(user.Id).TestIsSuperAdministrator();
	}

	public static bool IsDeveloper(this IUser user)
	{
		return Roblox.User.MustGet(user.Id).TestIsDeveloper();
	}

	public static bool IsEconomyManager(this IUser user)
	{
		return Roblox.User.MustGet(user.Id).TestIsEconomyManager();
	}

	public static bool IsMarketing(this IUser user)
	{
		return Roblox.User.MustGet(user.Id).TestIsMarketing();
	}

	public static bool IsMarketingManager(this IUser user)
	{
		return Roblox.User.MustGet(user.Id).TestIsMarketingManager();
	}

	public static bool IsAdOps(this IUser user)
	{
		return Roblox.User.MustGet(user.Id).TestIsAdOps();
	}

	public static bool IsAdOpsManager(this IUser user)
	{
		return Roblox.User.MustGet(user.Id).TestIsAdOpsManager();
	}

	public static bool IsContentCreator(this IUser user)
	{
		return Roblox.User.MustGet(user.Id).TestIsContentCreator();
	}

	public static bool IsReleaseEngineer(this IUser user)
	{
		return Roblox.User.MustGet(user.Id).TestIsReleaseEngineer();
	}

	public static bool IsBetaTester(this IUserIdentifier user)
	{
		return Roblox.User.MustGet(user.Id).TestIsBetaTester();
	}

	public static bool IsViewer(this IUserIdentifier user)
	{
		return Roblox.User.MustGet(user.Id).TestIsViewer();
	}

	public static bool IsCommunityChampion(this IUserIdentifier user)
	{
		return Roblox.User.MustGet(user.Id).TestIsCommunityChampion();
	}

	public static bool IsSuperModerator(this IUserIdentifier user)
	{
		return Roblox.User.MustGet(user.Id).TestIsSuperModerator();
	}

	public static bool IsDevRelManager(this IUserIdentifier user)
	{
		return Roblox.User.MustGet(user.Id).TestIsDevRelManager();
	}

	public static bool IsDataAdministrator(this IUserIdentifier user)
	{
		return Roblox.User.MustGet(user.Id).TestIsDataAdministrator();
	}

	public static bool IsEventStreamCreator(this IUserIdentifier user)
	{
		return Roblox.User.MustGet(user.Id).TestIsEventStreamCreator();
	}

	public static bool IsTranslationManager(this IUserIdentifier user)
	{
		return Roblox.User.MustGet(user.Id).TestIsTranslationManager();
	}

	public static bool IsTranslationContributor(this IUserIdentifier user)
	{
		return Roblox.User.MustGet(user.Id).TestIsTranslationContributor();
	}

	public static bool IsPIIManager(this IUserIdentifier user)
	{
		return Roblox.User.MustGet(user.Id).TestIsPIIManager();
	}

	public static bool IsIT(this IUserIdentifier user)
	{
		return Roblox.User.MustGet(user.Id).TestIsIT();
	}

	public static bool IsCSAgentAdmin(this IUserIdentifier user)
	{
		return Roblox.User.MustGet(user.Id).TestIsCSAgentAdmin();
	}

	public static bool IsFastTrackMember(this IUserIdentifier user)
	{
		return Roblox.User.MustGet(user.Id).TestIsFastTrackMember();
	}

	public static bool IsFastTrackModerator(this IUserIdentifier user)
	{
		return Roblox.User.MustGet(user.Id).TestIsFastTrackModerator();
	}

	public static bool IsFastTrackAdmin(this IUserIdentifier user)
	{
		return Roblox.User.MustGet(user.Id).TestIsFastTrackAdmin();
	}

	public static bool IsChinaLicenseUser(this IUserIdentifier user)
	{
		return Roblox.User.MustGet(user.Id).TestIsChinaLicenseUser();
	}

	public static bool IsItemManager(this IUserIdentifier user)
	{
		return Roblox.User.MustGet(user.Id).TestIsItemManager();
	}

	public static bool IsCatalogItemCreator(this IUserIdentifier user)
	{
		return Roblox.User.MustGet(user.Id).TestIsCatalogItemCreator();
	}

	public static bool IsRccReleaseTesterManager(this IUser user)
	{
		return Roblox.User.MustGet(user.Id).TestIsRccReleaseTesterManager();
	}

	public static bool IsTemporarilyBanned(this IUser user)
	{
		return user.AccountStatus.Equals(AccountStatus.Suppressed);
	}

	public static bool IsBanned(this IUser user)
	{
		if (!user.IsTemporarilyBanned())
		{
			return user.IsPermanentlyBanned();
		}
		return true;
	}

	public static bool IsPermanentlyBanned(this IUser user)
	{
		if (!user.AccountStatus.Equals(AccountStatus.Deleted))
		{
			return user.AccountStatus.Equals(AccountStatus.Poisoned);
		}
		return true;
	}

	/// <summary>
	/// We need to generate a rollout order per setting which is unique and stable.
	/// Otherwise prior rollouts may have selectively affected the first X% of users, 
	/// and later rollouts will have discontinuities when they cross X%.
	/// Instead, compare to this value.
	/// </summary>
	public static int GetStableRolloutPercentageForUser(this IUser user, string key)
	{
		if (string.IsNullOrEmpty(key))
		{
			throw new PlatformException("GetStableRolloutPercentageForUser must have a real key");
		}
		string input = user.Id + key;
		return (int)(MurmurHash2.Hash(Encoding.ASCII.GetBytes(input)) % 100u);
	}

	/// <summary>
	/// <inheritdoc cref="M:Roblox.Platform.Membership.IAgeChecker.UserMeetsMinimumAgeRequirement(Roblox.Platform.Membership.IUser,System.Int32)" />.
	/// </summary>
	[Obsolete("Please explicitly inject an IAgeChecker")]
	public static bool MeetsMinimumAgeRequirement(this IUser nullableUser, byte minAgeInYears)
	{
		return AgeChecker.GetSingleton().UserMeetsMinimumAgeRequirement(nullableUser, minAgeInYears);
	}

	/// <summary>
	/// <inheritdoc cref="M:Roblox.Platform.Membership.IAgeChecker.UserMeetsMinimumAgeRequirement(Roblox.Platform.Membership.IUser,System.Int32)" />.
	/// </summary>
	public static bool MeetsMinimumAgeRequirement(this IUser nullableUser, byte minAgeInYears, IAgeChecker ageChecker)
	{
		return ageChecker.UserMeetsMinimumAgeRequirement(nullableUser, minAgeInYears);
	}

	/// <summary>
	/// <inheritdoc cref="M:Roblox.Platform.Membership.IAgeChecker.ApproximateAgeInDoubleYears(Roblox.Platform.Membership.IUser)" />.
	/// </summary>
	public static double? ApproximateAgeInDoubleYears(this IUser user)
	{
		return AgeChecker.GetSingleton().ApproximateAgeInDoubleYears(user);
	}

	public static BuildersClubMembershipType GetBuildersClubMembershipType(this IUser user)
	{
		if (user == null)
		{
			return BuildersClubMembershipType.None;
		}
		AccountAddOn accountAddOn = AccountAddOn.GetBuildersClubMembershipAccountAddOn(user.AccountId);
		if (accountAddOn == null || accountAddOn.Expiration <= DateTime.Now)
		{
			return BuildersClubMembershipType.None;
		}
		PremiumFeature premiumFeature = PremiumFeature.Get(accountAddOn.PremiumFeatureID);
		if (premiumFeature.IsOutrageousBuildersClub)
		{
			return BuildersClubMembershipType.OBC;
		}
		if (premiumFeature.IsTurboBuildersClub)
		{
			return BuildersClubMembershipType.TBC;
		}
		if (premiumFeature.IsBuildersClub)
		{
			return BuildersClubMembershipType.BC;
		}
		return BuildersClubMembershipType.None;
	}
}
