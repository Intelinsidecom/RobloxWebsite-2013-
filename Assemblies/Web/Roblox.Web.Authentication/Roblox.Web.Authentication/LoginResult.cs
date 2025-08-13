using Roblox.Platform.Membership;

namespace Roblox.Web.Authentication;

/// <summary>
/// A class for a login result.
/// </summary>
internal class LoginResult : ILoginResult
{
	/// <inheritdoc />
	public IUser User { get; }

	/// <inheritdoc />
	public ITwoStepVerificationData TwoStepVerificationData { get; }

	/// <inheritdoc />
	public LoginFailureStatus? FailedStatus { get; }

	/// <summary>
	/// Initializes a new instance of <see cref="T:Roblox.Web.Authentication.LoginResult" />.
	/// </summary>
	/// <param name="loginStatus">The <see cref="T:Roblox.Web.Authentication.LoginFailureStatus" /></param>
	public LoginResult(LoginFailureStatus loginStatus)
	{
		FailedStatus = loginStatus;
	}

	/// <summary>
	/// Initializes a new instance of <see cref="T:Roblox.Web.Authentication.LoginResult" />.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" /></param>
	public LoginResult(IUser user)
	{
		User = user;
		TwoStepVerificationData = null;
	}

	/// <summary>
	/// Initializes a new instance of <see cref="T:Roblox.Web.Authentication.LoginResult" />.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" />.</param>
	/// <param name="twoStepVerificationData">The <see cref="T:Roblox.Web.Authentication.ITwoStepVerificationData" />.</param>
	public LoginResult(IUser user, ITwoStepVerificationData twoStepVerificationData)
	{
		User = user;
		TwoStepVerificationData = twoStepVerificationData;
	}
}
