using System;
using Roblox.EphemeralCounters;
using Roblox.Platform.Authentication;
using Roblox.Platform.Email.User;

namespace Roblox.Web.Authentication.Verification;

/// <summary>
/// A factory that builds <see cref="T:Roblox.Web.Authentication.Verification.ICredentialsVerifier" />.
/// </summary>
public class CredentialsVerifierFactory : ICredentialsVerifierFactory
{
	private readonly IUserEmailVerifier _UserEmailVerifier;

	private readonly IEphemeralCounterFactory _EphemeralCounterFactory;

	/// <summary>
	/// Creates an instance of <see cref="T:Roblox.Web.Authentication.Verification.CredentialsVerifierFactory" />.
	/// </summary>
	/// <param name="userEmailVerifier">The <see cref="T:Roblox.Platform.Email.User.IUserEmailVerifier" />.</param>
	/// <param name="ephemeralCounterFactory">The <see cref="T:Roblox.EphemeralCounters.IEphemeralCounterFactory" />.</param>
	/// <exception cref="T:System.ArgumentNullException">Thrown if <paramref name="userEmailVerifier" /> or <paramref name="ephemeralCounterFactory" /> is null.</exception>
	public CredentialsVerifierFactory(IUserEmailVerifier userEmailVerifier, IEphemeralCounterFactory ephemeralCounterFactory)
	{
		_UserEmailVerifier = userEmailVerifier ?? throw new ArgumentNullException("userEmailVerifier");
		_EphemeralCounterFactory = ephemeralCounterFactory ?? throw new ArgumentNullException("ephemeralCounterFactory");
	}

	/// <inheritdoc />
	public ICredentialsVerifier BuildCredentialsVerifier(CredentialsType credentialsType)
	{
		if (credentialsType == CredentialsType.Email)
		{
			return new EmailCredentialsVerifier(_UserEmailVerifier, _EphemeralCounterFactory);
		}
		throw new ArgumentException($"Unsupported credential type: {credentialsType}");
	}
}
