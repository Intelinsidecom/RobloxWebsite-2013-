using Roblox.Platform.Membership;

namespace Roblox.Web.Authentication;

/// <summary>
/// Represents a login result.
/// </summary>
public interface ILoginResult
{
	/// <summary>
	/// The error status if the login operation resulted in an error. <see cref="T:Roblox.Web.Authentication.LoginFailureStatus" />.
	/// </summary>
	LoginFailureStatus? FailedStatus { get; }

	/// <summary>
	/// The authenticated <see cref="T:Roblox.Platform.Membership.IUser" />.
	/// </summary>
	IUser User { get; }

	/// <summary>
	/// The <see cref="T:Roblox.Web.Authentication.ITwoStepVerificationData" /> if two step verification is required.
	/// Null if no need to check two step verification.
	/// </summary>
	ITwoStepVerificationData TwoStepVerificationData { get; }
}
