using System;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using Roblox.FloodCheckers.Core;
using Roblox.Platform.Core;
using Roblox.Platform.MembershipCore;
using Roblox.Platform.TwoStepVerification.Properties;

namespace Roblox.Platform.TwoStepVerification;

/// <summary>
/// Implementation of <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationChallengeFactory" />
/// </summary>
internal class TwoStepVerificationChallengeFactory : ITwoStepVerificationChallengeFactory
{
	private readonly ITwoStepVerificationChallengePersister _ChallengePersister;

	[ExcludeFromCodeCoverage]
	private int _CodeLength => Settings.Default.TwoStepVerificationCodeLength;

	[ExcludeFromCodeCoverage]
	private string _CodeCharacters => Settings.Default.TwoStepVerificationCodeCharacters;

	[ExcludeFromCodeCoverage]
	protected virtual TimeSpan _DefaultExpiration => Settings.Default.TwoStepVerificationCodeExpiration;

	/// <summary>
	/// Constructs a new <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationChallengeFactory" />
	/// </summary>
	/// <param name="challengePersister">An <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationChallengePersister" /></param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="challengePersister" /> is null.</exception>
	public TwoStepVerificationChallengeFactory(ITwoStepVerificationChallengePersister challengePersister)
	{
		_ChallengePersister = challengePersister.AssignOrThrowIfNull("challengePersister");
	}

	/// <inheritdoc cref="M:Roblox.Platform.TwoStepVerification.ITwoStepVerificationChallengeFactory.GetByUserAndActionType(Roblox.Platform.MembershipCore.IUserIdentifier,Roblox.Platform.TwoStepVerification.TwoStepVerificationActionType)" />
	public ITwoStepVerificationChallenge GetByUserAndActionType(IUserIdentifier userIdentifier, TwoStepVerificationActionType actionType)
	{
		if (userIdentifier == null)
		{
			throw new PlatformArgumentNullException("userIdentifier");
		}
		TwoStepVerificationCode cacheableChallenge = _ChallengePersister.GetByUserAndActionType(userIdentifier, actionType);
		if (cacheableChallenge == null)
		{
			return null;
		}
		ITwoStepVerificationChallenge challenge = Translate(cacheableChallenge);
		if (cacheableChallenge.Created + _DefaultExpiration < DateTime.Now)
		{
			challenge.Revoke();
			return null;
		}
		return challenge;
	}

	/// <inheritdoc cref="M:Roblox.Platform.TwoStepVerification.ITwoStepVerificationChallengeFactory.GenerateChallenge(Roblox.Platform.MembershipCore.IUserIdentifier,Roblox.Platform.TwoStepVerification.TwoStepVerificationActionType)" />
	public ITwoStepVerificationChallenge GenerateChallenge(IUserIdentifier userIdentifier, TwoStepVerificationActionType actionType)
	{
		if (userIdentifier == null)
		{
			throw new PlatformArgumentNullException("userIdentifier");
		}
		IFloodChecker twoStepVerificationCodeGenerationFloodChecker = GetTwoStepVerificationCodeGenerationFloodChecker(userIdentifier, actionType);
		if (twoStepVerificationCodeGenerationFloodChecker.IsFlooded())
		{
			throw new PlatformFloodedException("TwoStepVerificationCodeGenerationFloodChecker");
		}
		twoStepVerificationCodeGenerationFloodChecker.UpdateCount();
		TwoStepVerificationCode existingCacheableChallenge = _ChallengePersister.GetByUserAndActionType(userIdentifier, actionType);
		if (existingCacheableChallenge != null)
		{
			Translate(existingCacheableChallenge).Revoke();
		}
		TwoStepVerificationCode newCacheableChallenge = new TwoStepVerificationCode
		{
			Nonce = Guid.NewGuid(),
			UserId = userIdentifier.Id,
			Code = GenerateCode(),
			TwoStepVerificationActionType = actionType,
			Created = DateTime.Now
		};
		if (_ChallengePersister.Persist(newCacheableChallenge))
		{
			return Translate(newCacheableChallenge);
		}
		throw new PlatformOperationUnavailableException("Failed to persist 2SV challenge.");
	}

	[ExcludeFromCodeCoverage]
	protected virtual ITwoStepVerificationChallenge Translate(TwoStepVerificationCode cacheableChallenge)
	{
		return new TwoStepVerificationChallenge(_ChallengePersister, cacheableChallenge);
	}

	[ExcludeFromCodeCoverage]
	protected virtual IFloodChecker GetTwoStepVerificationCodeGenerationFloodChecker(IUserIdentifier user, TwoStepVerificationActionType actionType)
	{
		return new TwoStepVerificationCodeGenerationFloodChecker(user, actionType);
	}

	private string GenerateCode()
	{
		Random random = new Random();
		StringBuilder codeBuilder = new StringBuilder();
		for (int i = 0; i < _CodeLength; i++)
		{
			codeBuilder.Append(_CodeCharacters[random.Next(_CodeCharacters.Length)]);
		}
		return codeBuilder.ToString();
	}
}
