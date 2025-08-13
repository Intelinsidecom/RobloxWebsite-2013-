namespace Roblox.Kickbox;

/// <summary>
/// Defines methods for Kickbox API calls
/// </summary>
public interface IKickboxClient
{
	/// <summary>
	/// Check the given email address against Kickbox
	/// </summary>
	/// <param name="request">The <see cref="T:Roblox.Kickbox.IKickboxVerifyEmailRequest" /> containing the required parameters for Kickbox</param>
	/// <returns>An <see cref="T:Roblox.Kickbox.IKickboxVerifyEmailResult" /> containing the results for the email validity check</returns>
	/// <exception cref="T:Roblox.Kickbox.KickboxException"></exception>
	IKickboxVerifyEmailResult VerifyEmail(IKickboxVerifyEmailRequest request);

	IKickboxVerifyDomainResult VerifyDomain(IKickboxVerifyDomainRequest request);
}
