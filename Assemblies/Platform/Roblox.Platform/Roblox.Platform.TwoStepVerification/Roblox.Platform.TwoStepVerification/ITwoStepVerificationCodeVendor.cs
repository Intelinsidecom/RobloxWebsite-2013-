using Roblox.Platform.IpAddresses;
using Roblox.Platform.Membership;

namespace Roblox.Platform.TwoStepVerification;

/// <summary>
/// A means of transmitting a <see cref="P:Roblox.Platform.TwoStepVerification.ITwoStepVerificationChallenge.Passcode" /> to an <see cref="T:Roblox.Platform.Membership.IUser" />.
/// </summary>
internal interface ITwoStepVerificationCodeVendor
{
	/// <summary>
	/// Sends the <see cref="P:Roblox.Platform.TwoStepVerification.ITwoStepVerificationChallenge.Passcode" /> to <paramref name="user" /> using a <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationMediaType" />.
	/// </summary>
	/// <param name="challenge">An <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationChallenge" /></param>
	/// <param name="user">An <see cref="T:Roblox.Platform.Membership.IUser" /></param>
	/// <param name="ipLocation">The <see cref="T:Roblox.Platform.IpAddresses.IIpLocation" /> of the original request</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="challenge" /> or <paramref name="user" /> is null.</exception>
	/// <exception cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationUnverifiedMediaTypeException">Thrown if <paramref name="user" /> has not verified their chosen <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationMediaType" />.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Thrown if there was an unexpected failure to send <see cref="P:Roblox.Platform.TwoStepVerification.ITwoStepVerificationChallenge.Passcode" />.</exception>
	void Send(ITwoStepVerificationChallenge challenge, IUser user, IIpLocation ipLocation);
}
