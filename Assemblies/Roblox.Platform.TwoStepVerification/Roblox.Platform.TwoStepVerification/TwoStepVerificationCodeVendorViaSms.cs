using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Common;
using Roblox.Configuration;
using Roblox.EventLog;
using Roblox.Platform.Core;
using Roblox.Platform.Demographics;
using Roblox.Platform.IpAddresses;
using Roblox.Platform.Membership;
using Roblox.Sms.Client;

namespace Roblox.Platform.TwoStepVerification;

/// <summary>
/// Implementation of <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationCodeSender" /> that sends codes via SMS.
/// </summary>
internal class TwoStepVerificationCodeVendorViaSms : ITwoStepVerificationCodeVendor
{
	private readonly IAccountPhoneNumberFactory _AccountPhoneNumberFactory;

	private readonly ILogger _Logger;

	private readonly string _ApplicationName;

	private readonly Func<bool> _IsTwoStepVerificationLoggingEnabled;

	private readonly ISmsClient _SmsClient;

	/// <summary>
	/// Constructs a new <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationCodeVendorViaSms" />
	/// </summary>
	/// <param name="accountPhoneNumberFactory">An <see cref="T:Roblox.Platform.Demographics.IAccountPhoneNumberFactory" /></param>
	/// <param name="logger">An <see cref="T:Roblox.EventLog.ILogger" /></param>
	/// <param name="applicationName">Name of the application.</param>
	/// <param name="isTwoStepVerificationLoggingEnabled">A <see cref="!:Func&lt;bool&gt;" /> that returns <c>True</c> if logging enabled, <c>False</c> otherwise.</param>
	/// <param name="smsClient">An <see cref="T:Roblox.Sms.Client.SmsClient" /></param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="accountPhoneNumberFactory" />, <paramref name="logger" />, or <paramref name="isTwoStepVerificationLoggingEnabled" /> is null.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="applicationName" /> is null or empty.</exception>
	internal TwoStepVerificationCodeVendorViaSms(IAccountPhoneNumberFactory accountPhoneNumberFactory, ISmsClient smsClient, ILogger logger, string applicationName, Func<bool> isTwoStepVerificationLoggingEnabled)
	{
		if (string.IsNullOrEmpty(applicationName))
		{
			throw new PlatformArgumentException("applicationName");
		}
		_AccountPhoneNumberFactory = accountPhoneNumberFactory ?? throw new PlatformArgumentNullException("accountPhoneNumberFactory");
		_Logger = logger ?? throw new PlatformArgumentNullException("logger");
		_ApplicationName = applicationName ?? throw new PlatformArgumentNullException("applicationName");
		_IsTwoStepVerificationLoggingEnabled = isTwoStepVerificationLoggingEnabled ?? throw new PlatformArgumentNullException("isTwoStepVerificationLoggingEnabled");
		_SmsClient = smsClient ?? throw new PlatformArgumentNullException("smsClient");
	}

	/// <inheritdoc cref="M:Roblox.Platform.TwoStepVerification.ITwoStepVerificationCodeVendor.Send(Roblox.Platform.TwoStepVerification.ITwoStepVerificationChallenge,Roblox.Platform.Membership.IUser,Roblox.Platform.IpAddresses.IIpLocation)" />
	public void Send(ITwoStepVerificationChallenge challenge, IUser user, IIpLocation ipLocation)
	{
		if (challenge == null)
		{
			throw new PlatformArgumentNullException("challenge");
		}
		if (user == null)
		{
			throw new PlatformArgumentNullException("user");
		}
		IAccountPhoneNumber accountPhoneNumber = _AccountPhoneNumberFactory.GetVerifiedForUser(user);
		if (accountPhoneNumber == null)
		{
			throw new TwoStepVerificationUnverifiedMediaTypeException(TwoStepVerificationMediaType.SMS);
		}
		try
		{
			string message = $"{challenge.Passcode} is your ROBLOX security code.";
			if (_IsTwoStepVerificationLoggingEnabled())
			{
				string loginInfo = GetLogInfo(challenge, user);
				message = message + " " + loginInfo;
				_Logger.Info(loginInfo);
			}
			SendSMS(accountPhoneNumber.FullPhoneNumber, message);
		}
		catch (Exception e)
		{
			throw new PlatformOperationUnavailableException("Failed to send SMS to user", e);
		}
	}

	[ExcludeFromCodeCoverage]
	protected virtual void SendSMS(string fullPhoneNumber, string message)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		Sms sms = new Sms(fullPhoneNumber, message);
		_SmsClient.Send(sms);
	}

	[ExcludeFromCodeCoverage]
	protected virtual string GetLogInfo(ITwoStepVerificationChallenge challenge, IUser user)
	{
		return $"{user.Name} is attempting {challenge.ActionType.ToDescription()} from {RobloxEnvironment.Abbreviation}-{_ApplicationName} at {DateTime.Now}";
	}
}
