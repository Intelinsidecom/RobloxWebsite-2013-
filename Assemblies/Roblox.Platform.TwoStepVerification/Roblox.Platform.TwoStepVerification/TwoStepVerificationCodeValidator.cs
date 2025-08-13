using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.EphemeralCounters;
using Roblox.EventLog;
using Roblox.FloodCheckers.Core;
using Roblox.Platform.Core;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.TwoStepVerification;

/// <summary>
/// Implementation of <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationCodeValidator" />
/// </summary>
internal class TwoStepVerificationCodeValidator : ITwoStepVerificationCodeValidator
{
	private const string _TwoStepVerificationRedemptionTimeSequenceName = "Roblox.Platform.TwoStepVerification.TwoStepVerificationCodeValidator.RedemptionTimeSequence";

	private readonly ISequence _TwoStepVerificationRedemptionTimeSequence;

	private readonly ITwoStepVerificationChallengeFactory _TwoStepVerificationChallengeFactory;

	private readonly ILogger _Logger;

	/// <summary>
	/// Constructs a new <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationCodeValidator" />
	/// </summary>
	/// <param name="challengeFactory">An <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationChallengeFactory" /></param>
	/// <param name="ephemeralCounterFactory">An <see cref="T:Roblox.EphemeralCounters.IEphemeralCounterFactory" />.</param>
	/// <param name="logger">An <see cref="T:Roblox.EventLog.ILogger" />.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">
	/// - <paramref name="challengeFactory" />
	/// - <paramref name="ephemeralCounterFactory" />
	/// - <paramref name="logger" />
	/// </exception>
	internal TwoStepVerificationCodeValidator(ITwoStepVerificationChallengeFactory challengeFactory, IEphemeralCounterFactory ephemeralCounterFactory, ILogger logger)
	{
		if (ephemeralCounterFactory == null)
		{
			throw new ArgumentNullException("ephemeralCounterFactory");
		}
		_TwoStepVerificationChallengeFactory = challengeFactory ?? throw new ArgumentNullException("challengeFactory");
		_Logger = logger ?? throw new ArgumentNullException("logger");
		_TwoStepVerificationRedemptionTimeSequence = ephemeralCounterFactory.GetSequence("Roblox.Platform.TwoStepVerification.TwoStepVerificationCodeValidator.RedemptionTimeSequence");
	}

	/// <inheritdoc cref="M:Roblox.Platform.TwoStepVerification.ITwoStepVerificationCodeValidator.IsCodeValid(Roblox.Platform.TwoStepVerification.TwoStepVerificationChallengeDTO)" />
	public bool IsCodeValid(TwoStepVerificationChallengeDTO challengeDTO)
	{
		if (challengeDTO == null)
		{
			throw new PlatformArgumentNullException("challengeDTO");
		}
		if (challengeDTO.UserIdentifier == null)
		{
			throw new PlatformArgumentNullException("UserIdentifier");
		}
		if (challengeDTO.Id == Guid.Empty)
		{
			throw new PlatformArgumentException("Id");
		}
		if (string.IsNullOrWhiteSpace(challengeDTO.Passcode))
		{
			throw new PlatformArgumentException("Passcode");
		}
		ITwoStepVerificationChallenge existingChallenge = _TwoStepVerificationChallengeFactory.GetByUserAndActionType(challengeDTO.UserIdentifier, challengeDTO.ActionType);
		if (existingChallenge?.Id != challengeDTO.Id)
		{
			return false;
		}
		IFloodChecker twoStepVerificationCodeInputFloodChecker = GetTwoStepVerificationCodeInputFloodChecker(challengeDTO.UserIdentifier, challengeDTO.ActionType);
		if (twoStepVerificationCodeInputFloodChecker.IsFlooded())
		{
			throw new PlatformFloodedException("TwoStepVerificationCodeInputFloodChecker");
		}
		twoStepVerificationCodeInputFloodChecker.UpdateCount();
		if (existingChallenge.Passcode == challengeDTO.Passcode)
		{
			try
			{
				TimeSpan redemptionTime = DateTime.Now - existingChallenge.IssuedDate;
				_TwoStepVerificationRedemptionTimeSequence.Add(redemptionTime.TotalSeconds);
			}
			catch (Exception e)
			{
				_Logger.Error(e);
			}
			existingChallenge.Revoke();
			return true;
		}
		return false;
	}

	[ExcludeFromCodeCoverage]
	protected virtual IFloodChecker GetTwoStepVerificationCodeInputFloodChecker(IUserIdentifier user, TwoStepVerificationActionType actionType)
	{
		return new TwoStepVerificationCodeInputFloodChecker(user, actionType);
	}
}
