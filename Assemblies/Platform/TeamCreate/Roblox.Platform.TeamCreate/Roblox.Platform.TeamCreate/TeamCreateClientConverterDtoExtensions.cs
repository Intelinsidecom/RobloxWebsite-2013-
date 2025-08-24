using Roblox.Platform.Membership;
using Roblox.Platform.Universes;
using Roblox.TeamCreate.Client;

namespace Roblox.Platform.TeamCreate;

/// <summary>
/// This class is for converting interfaces for the TeamCreate client in this platform only!
/// Do not make public!
/// </summary>
internal static class TeamCreateClientConverterDtoExtensions
{
	internal static TeamCreateMembershipTarget ToMembershipTarget(this IUser user)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		return new TeamCreateMembershipTarget
		{
			TargetType = (TeamCreateMembershipTargetType)0,
			TargetId = user.Id
		};
	}

	internal static UniverseIdentifier ToUniverseIdentifier(this IUniverse universe)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		return new UniverseIdentifier
		{
			Id = universe.Id
		};
	}
}
