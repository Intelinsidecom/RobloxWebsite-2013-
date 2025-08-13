using Roblox.Platform.Authentication;
using Roblox.Platform.Marketing;

namespace Roblox.Web.Authentication;

/// <summary>
/// Represents an object to perform session related authentication.
/// </summary>
public interface IWebAuthenticatorV2
{
	/// <summary>
	/// Signs in a user using the provided <see cref="T:Roblox.Platform.Authentication.IRobloxUserCredentials" />.
	/// <remarks>
	///     Performs the following main steps to authenticate from <see cref="T:Roblox.Platform.Authentication.IRobloxUserCredentials" />
	///     1) Checks captcha 
	///     2) Verifies provided <see cref="T:Roblox.Platform.Authentication.IRobloxUserCredentials" />.
	///     3) Checks if password reset is required for <see cref="T:Roblox.Platform.Membership.IUser" /> obtained from <see cref="T:Roblox.Platform.Authentication.IRobloxUserCredentials" />
	///     4) Checks if two step verification is required and if it is generates the challenge, sends the code and returns the <see cref="P:Roblox.Web.Authentication.ILoginResult.TwoStepVerificationData" />.
	///     5) Authenticates the <see cref="T:Roblox.Platform.Membership.IUser" />.
	/// </remarks>
	/// </summary>
	/// <param name="credentials">The <see cref="T:Roblox.Platform.Authentication.IRobloxUserCredentials" />.</param>
	/// <param name="browserTracker">The <see cref="T:Roblox.Platform.Marketing.IBrowserTracker" />.</param>
	/// <returns>A <see cref="T:Roblox.Web.Authentication.ILoginResult" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///     Throws if <paramref name="credentials" /> is null.
	/// </exception>
	/// <exception cref="T:System.ArgumentException">
	///     Throws if <paramref name="credentials.Value.Value" /> is null or whitespace.
	/// </exception>
	ILoginResult SignInWithUserCredentials(IRobloxUserCredentials credentials, IBrowserTracker browserTracker, ICaptchaParameter captchaParameter);
}
