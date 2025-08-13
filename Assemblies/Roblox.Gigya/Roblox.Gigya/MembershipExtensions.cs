using Roblox.Platform.Membership;

namespace Roblox.Gigya;

public static class MembershipExtensions
{
	/// <summary>
	/// Constructs an <see cref="T:Roblox.Gigya.IGigyaSignatureTimestamp" /> for a given <see cref="T:Roblox.Platform.Membership.IUser" />.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" /> for which the Signature and Timestamp are needed.</param>
	/// <returns><see cref="T:Roblox.Gigya.IGigyaSignatureTimestamp" /> which contains the Signature and Timestamp.</returns>
	public static IGigyaSignatureTimestamp GetGigyaSignatureTimestamp(this IUser user)
	{
		return new GigyaSignatureTimestamp(GigyaClient.ConstructGigyaUid(user.Id));
	}

	public static string ConstructGigyaUid(this IUser user)
	{
		return GigyaClient.ConstructGigyaUid(user.Id);
	}
}
