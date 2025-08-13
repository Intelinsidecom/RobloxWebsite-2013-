using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.EventLog;
using Roblox.FloodCheckers.Core;
using Roblox.MaxMind.GeoIP2;
using Roblox.Platform.Core;
using Roblox.Platform.IpAddresses;
using Roblox.Platform.Membership;
using Roblox.Platform.TwoStepVerification.FloodCheckers;

namespace Roblox.Platform.TwoStepVerification;

/// <summary>
/// Implementation of <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationCodeSender" />
/// </summary>
internal class TwoStepVerificationCodeSender : ITwoStepVerificationCodeSender
{
	private readonly ITwoStepVerificationChallengeFactory _TwoStepVerificationChallengeFactory;

	private readonly ITwoStepVerificationCodeVendorFactory _TwoStepVerificationCodeVendorFactory;

	private readonly ITwoStepVerificationConfigurationProvider _TwoStepVerificationConfigurationProvider;

	private readonly IUserFactory _UserFactory;

	private readonly ILogger _Logger;

	private readonly IIpLocationFactory _IpLocationFactory;

	/// <summary>
	/// Constructs a new <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationCodeSender" />
	/// </summary>
	/// <param name="challengeFactory">An <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationChallengeFactory" /></param>
	/// <param name="codeVendorFactory">An <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationCodeVendorFactory" /></param>
	/// <param name="configurationProvider">An <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationConfigurationProvider" /></param>
	/// <param name="userFactory">An <see cref="T:Roblox.Platform.Membership.IUserFactory" /></param>
	/// <param name="logger">An <see cref="T:Roblox.EventLog.ILogger" /></param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="challengeFactory" />, <paramref name="codeVendorFactory" />, <paramref name="configurationProvider" />, <paramref name="userFactory" />, or <paramref name="logger" /> is null.</exception>
	internal TwoStepVerificationCodeSender(ITwoStepVerificationChallengeFactory challengeFactory, ITwoStepVerificationCodeVendorFactory codeVendorFactory, ITwoStepVerificationConfigurationProvider configurationProvider, IUserFactory userFactory, ILogger logger)
	{
		_TwoStepVerificationChallengeFactory = challengeFactory.AssignOrThrowIfNull("challengeFactory");
		_TwoStepVerificationCodeVendorFactory = codeVendorFactory.AssignOrThrowIfNull("codeVendorFactory");
		_TwoStepVerificationConfigurationProvider = configurationProvider.AssignOrThrowIfNull("configurationProvider");
		_UserFactory = userFactory.AssignOrThrowIfNull("userFactory");
		_Logger = logger.AssignOrThrowIfNull("logger");
		_IpLocationFactory = new IpLocationFactory(new MaxmindClient("MaxMind"));
	}

	/// <inheritdoc cref="M:Roblox.Platform.TwoStepVerification.ITwoStepVerificationCodeSender.GenerateChallengeAndSendCode(Roblox.Platform.Membership.IUser,Roblox.Platform.TwoStepVerification.TwoStepVerificationActionType,System.String)" />
	public TwoStepVerificationChallengeDTO GenerateChallengeAndSendCode(IUser user, TwoStepVerificationActionType actionType, string ipAddress)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("user");
		}
		if (string.IsNullOrEmpty(ipAddress))
		{
			throw new PlatformArgumentNullException("ipAddress");
		}
		try
		{
			ITwoStepVerificationChallenge challenge = _TwoStepVerificationChallengeFactory.GenerateChallenge(user, actionType);
			TwoStepVerificationMediaType mediaType = _TwoStepVerificationConfigurationProvider.GetTwoStepSettingForUser(user).MediaType;
			ITwoStepVerificationCodeVendor codeVendor = _TwoStepVerificationCodeVendorFactory.GetCodeVendor(mediaType);
			IIpLocation ipLocation = _IpLocationFactory.GetByIpAddress(ipAddress);
			codeVendor.Send(challenge, user, ipLocation);
			return challenge.ToDTO();
		}
		catch (PlatformOperationUnavailableException e)
		{
			_Logger.Error(e);
			throw new PlatformOperationUnavailableException("Error in sending the code to user", e);
		}
	}

	/// <inheritdoc cref="M:Roblox.Platform.TwoStepVerification.ITwoStepVerificationCodeSender.ResendCodeForChallenge(Roblox.Platform.TwoStepVerification.TwoStepVerificationChallengeDTO,System.String)" />
	public void ResendCodeForChallenge(TwoStepVerificationChallengeDTO challengeDto, string ipAddress)
	{
		if (challengeDto == null)
		{
			throw new PlatformArgumentNullException("challengeDto");
		}
		if (challengeDto.UserIdentifier == null)
		{
			throw new PlatformArgumentNullException("UserIdentifier");
		}
		if (challengeDto.Id == Guid.Empty)
		{
			throw new PlatformArgumentException("Id");
		}
		if (string.IsNullOrEmpty(ipAddress))
		{
			throw new PlatformArgumentNullException("ipAddress");
		}
		ITwoStepVerificationChallenge existingChallenge = _TwoStepVerificationChallengeFactory.GetByUserAndActionType(challengeDto.UserIdentifier, challengeDto.ActionType);
		if (existingChallenge?.Id != challengeDto.Id)
		{
			throw new PlatformInvalidOperationException("Specified TwoStepVerificationChallenge does not exist.");
		}
		IUser user = _UserFactory.GetUser(existingChallenge.UserIdentifier.Id);
		IFloodChecker floodChecker = GetResendCodeFloodChecker(user);
		if (floodChecker.IsFlooded())
		{
			throw new PlatformFloodedException("TwoStepVerificationResendCodeFloodChecker");
		}
		TwoStepVerificationMediaType mediaType = _TwoStepVerificationConfigurationProvider.GetTwoStepSettingForUser(user).MediaType;
		try
		{
			ITwoStepVerificationCodeVendor codeVendor = _TwoStepVerificationCodeVendorFactory.GetCodeVendor(mediaType);
			IIpLocation ipLocation = _IpLocationFactory.GetByIpAddress(ipAddress);
			codeVendor.Send(existingChallenge, user, ipLocation);
			floodChecker.UpdateCount();
		}
		catch (PlatformOperationUnavailableException e)
		{
			_Logger.Error(e);
			throw new PlatformOperationUnavailableException("Error in sending the code to user", e);
		}
	}

	[ExcludeFromCodeCoverage]
	internal virtual IFloodChecker GetResendCodeFloodChecker(IUser user)
	{
		return new TwoStepVerificationResendCodeFloodChecker(user);
	}
}
