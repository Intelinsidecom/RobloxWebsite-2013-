namespace Roblox.BriteVerify;

/// <summary>
/// Defines methods for BriteVerify API calls
/// </summary>
public interface IBriteVerifyClient
{
	/// <summary>
	/// Check the given email address against BriteVerify
	/// </summary>
	/// <param name="request">The <see cref="T:Roblox.BriteVerify.IBriteVerifyEmailRequest" /> containing the required parameters for BriteVerify</param>
	/// <returns>An <see cref="T:Roblox.BriteVerify.IBriteVerifyEmailResult" /> containing the results for the email validity check</returns>
	/// <exception cref="T:Roblox.BriteVerify.BriteVerifyException"></exception>
	IBriteVerifyEmailResult VerifyEmail(IBriteVerifyEmailRequest request);
}
