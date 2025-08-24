using System;
using Roblox.Platform.Core;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.TwoStepVerification;

/// <summary>
/// Implementation of <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationChallenge" />
/// </summary>
internal class TwoStepVerificationChallenge : ITwoStepVerificationChallenge
{
	private readonly ITwoStepVerificationChallengePersister _ChallengePersister;

	/// <inheritdoc cref="P:Roblox.Platform.TwoStepVerification.ITwoStepVerificationChallenge.Id" />
	public Guid Id { get; }

	/// <inheritdoc cref="P:Roblox.Platform.TwoStepVerification.ITwoStepVerificationChallenge.UserIdentifier" />
	public IUserIdentifier UserIdentifier { get; }

	/// <inheritdoc cref="P:Roblox.Platform.TwoStepVerification.ITwoStepVerificationChallenge.Passcode" />
	public string Passcode { get; }

	/// <inheritdoc cref="P:Roblox.Platform.TwoStepVerification.ITwoStepVerificationChallenge.ActionType" />
	public TwoStepVerificationActionType ActionType { get; }

	/// <inheritdoc cref="P:Roblox.Platform.TwoStepVerification.ITwoStepVerificationChallenge.IssuedDate" />
	public DateTime IssuedDate { get; }

	/// <summary>
	/// Constructs a new <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationChallenge" />
	/// </summary>
	/// <param name="challengePersister">An <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationChallengePersister" /></param>
	/// <param name="cacheableChallenge">A <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationCode" /></param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="cacheableChallenge" /> is null.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="cacheableChallenge.Id.Id" /> is empty, <paramref name="cacheableChallenge.Passcode.Passcode" /> is null or empty, or <paramref name="cacheableChallenge.UserId.UserId" /> is a default value.</exception>
	internal TwoStepVerificationChallenge(ITwoStepVerificationChallengePersister challengePersister, TwoStepVerificationCode cacheableChallenge)
	{
		if (cacheableChallenge == null)
		{
			throw new PlatformArgumentNullException("cacheableChallenge");
		}
		if (cacheableChallenge.Nonce == Guid.Empty)
		{
			throw new PlatformArgumentException("Nonce");
		}
		if (string.IsNullOrEmpty(cacheableChallenge.Code))
		{
			throw new PlatformArgumentException("Code");
		}
		if (cacheableChallenge.UserId == 0L)
		{
			throw new PlatformArgumentException("UserId");
		}
		Id = cacheableChallenge.Nonce;
		UserIdentifier = UserIdentifierFactory.GetUserIdentifier(cacheableChallenge.UserId);
		Passcode = cacheableChallenge.Code;
		ActionType = cacheableChallenge.TwoStepVerificationActionType;
		IssuedDate = cacheableChallenge.Created;
		_ChallengePersister = challengePersister.AssignOrThrowIfNull("challengePersister");
	}

	/// <inheritdoc cref="M:Roblox.Platform.TwoStepVerification.ITwoStepVerificationChallenge.Revoke" />
	public void Revoke()
	{
		_ChallengePersister.Delete(UserIdentifier, ActionType);
	}

	/// <inheritdoc cref="M:Roblox.Platform.TwoStepVerification.ITwoStepVerificationChallenge.ToDTO" />
	public TwoStepVerificationChallengeDTO ToDTO()
	{
		return new TwoStepVerificationChallengeDTO
		{
			ActionType = ActionType,
			Id = Id,
			Passcode = Passcode,
			UserIdentifier = UserIdentifier
		};
	}
}
