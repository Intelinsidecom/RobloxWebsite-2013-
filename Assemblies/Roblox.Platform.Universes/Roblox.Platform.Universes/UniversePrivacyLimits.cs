using System;
using Roblox.Platform.Groups;
using Roblox.Platform.Membership;
using Roblox.PremiumFeatures;
using Roblox.Properties;

namespace Roblox.Platform.Universes;

/// <summary>
/// Provides limits on the number of public universes.
/// </summary>
public sealed class UniversePrivacyLimits : IUniversePrivacyLimits
{
	/// <inheritdoc cref="M:Roblox.Platform.Universes.IUniversePrivacyLimits.GetMaxPublicUniverses(Roblox.Platform.Membership.IUser)" />
	public int GetMaxPublicUniverses(IUser user)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		if (Settings.Default.IsIncreasedActiveUniverseLimitEnabled)
		{
			return Settings.Default.MaxActiveUniversesCount;
		}
		return AccountFeatureSet.GetOrCreate(user.AccountId).ShowcaseAllotment;
	}

	/// <inheritdoc cref="M:Roblox.Platform.Universes.IUniversePrivacyLimits.GetMaxPublicUniverses(Roblox.Platform.Groups.IGroup)" />
	public int GetMaxPublicUniverses(IGroup group)
	{
		if (group == null)
		{
			throw new ArgumentNullException("group");
		}
		return Settings.Default.MaxActiveUniversesCountForGroups;
	}
}
