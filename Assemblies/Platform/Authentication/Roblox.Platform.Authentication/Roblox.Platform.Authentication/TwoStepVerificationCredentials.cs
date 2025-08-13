using Roblox.Platform.Core;
using Roblox.Platform.Membership;
using Roblox.Platform.TwoStepVerification;

namespace Roblox.Platform.Authentication;

/// <summary>
/// Implementation of <see cref="T:Roblox.Platform.Authentication.ITwoStepVerificationCredentials" />.
/// </summary>
public class TwoStepVerificationCredentials : CredentialsBase, ITwoStepVerificationCredentials, ICredentials
{
	private readonly ITwoStepVerificationCodeValidator _TwoStepVerificationCodeValidator;

	public TwoStepVerificationChallengeDTO Challenge { get; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Authentication.TwoStepVerificationCredentials" /> class.
	/// </summary>
	/// <param name="twoStepVerificationCodeValidator">The <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationCodeValidator" />.</param>
	/// <param name="userFactory">An <see cref="T:Roblox.Platform.Membership.IUserFactory" /></param>
	/// <param name="challenge">An <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationChallengeDTO" /></param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="twoStepVerificationCodeValidator" />, <paramref name="userFactory" />, or <paramref name="challenge" /> is null</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="challenge.ActionType.ActionType" /> is not <see cref="F:Roblox.Platform.TwoStepVerification.TwoStepVerificationActionType.Login" /></exception>
	public TwoStepVerificationCredentials(ITwoStepVerificationCodeValidator twoStepVerificationCodeValidator, IUserFactory userFactory, TwoStepVerificationChallengeDTO challenge)
		: base(userFactory)
	{
		_TwoStepVerificationCodeValidator = twoStepVerificationCodeValidator.AssignOrThrowIfNull("twoStepVerificationCodeValidator");
		Challenge = challenge.AssignOrThrowIfNull("challenge");
		if (challenge.ActionType != TwoStepVerificationActionType.Login)
		{
			throw new PlatformArgumentException("challenge");
		}
	}

	protected override IUser DoAuthentication()
	{
		if (_TwoStepVerificationCodeValidator.IsCodeValid(Challenge))
		{
			return base.UserFactory.GetUser(Challenge.UserIdentifier.Id);
		}
		return null;
	}
}
