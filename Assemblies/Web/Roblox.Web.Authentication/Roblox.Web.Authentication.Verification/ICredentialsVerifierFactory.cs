using Roblox.Platform.Authentication;

namespace Roblox.Web.Authentication.Verification;

/// <summary>
/// Represents a factory that creates <see cref="T:Roblox.Web.Authentication.Verification.ICredentialsVerifier" />.
/// </summary>
public interface ICredentialsVerifierFactory
{
	/// <summary>
	/// Builds a <see cref="T:Roblox.Web.Authentication.Verification.ICredentialsVerifier" /> from a credential type.
	/// </summary>
	/// <param name="credentialsType">The <see cref="T:Roblox.Platform.Authentication.CredentialsType" />.</param>
	/// <exception cref="T:System.ArgumentException">If no authority is supported for the <paramref name="credentialsType" />.</exception>
	/// <returns>The <see cref="T:Roblox.Web.Authentication.Verification.ICredentialsVerifier" />.</returns>
	ICredentialsVerifier BuildCredentialsVerifier(CredentialsType credentialsType);
}
