using System;
using Roblox.EphemeralCounters;
using Roblox.EventLog;
using Roblox.FloodCheckers.Core;
using Roblox.Platform.Core;
using Roblox.Platform.Demographics;
using Roblox.Platform.Membership;
using Roblox.Sms.Client;
using Roblox.Web.Authentication.PhoneNumbers;
using Roblox.Web.Authentication.Properties;
using Roblox.Web.Authentication.Recovery;

namespace Roblox.Web.Authentication.Usernames;

public class UsernameRecoveryAuthority : IUsernameRecoveryAuthority
{
	private readonly IAccountPhoneNumberFactory _AccountPhoneNumberFactory;

	private readonly IPhoneNumberFloodCheckerFactory _PhoneNumberFloodCheckerFactory;

	private readonly IUserFactory _UserFactory;

	private readonly ISmsClient _SmsClient;

	private readonly ILogger _Logger;

	private readonly IEphemeralCounterFactory _EphemeralCounterFactory;

	private readonly IFloodCheckerFactory<IFloodChecker> _FloodCheckerFactory;

	private readonly IFloodCheckerSettings _FloodCheckerSettings;

	private const string _UsernameRecoverySMSText = "Your Roblox username is: {0}.";

	private const string _Operation = "SendUsernameSms";

	private const string _UsernameSMSAttempt = "ForgotUsernameSms_Attempt";

	private const string _UsernameSMSInvalidPhone = "ForgotUsernameSms_InvalidPhone";

	private const string _UsernameSMSPhoneNotFound = "ForgotUsernameSms_PhoneNotFound";

	private const string _UsernameSMSErrorSending = "ForgotUsernameSms_ErrorSending";

	private const string _UsernameSMSSuccess = "ForgotUsernameSms_Success";

	private const string _UsernameSMSFailure = "ForgotUsernameSms_Failure";

	private const string _UsernameSMSFloodchecked = "ForgotUsernameSms_FloodChecked";

	private const string _UsernameSMSInvalidUser = "ForgotUsernameSms_InvalidUser";

	public UsernameRecoveryAuthority(ILogger logger, ISmsClient smsClient, IUserFactory userFactory, IAccountPhoneNumberFactory accountPhoneNumberFactory, IPhoneNumberFloodCheckerFactory phoneNumberFloodCheckerFactory, IEphemeralCounterFactory ephemeralCounterFactory, IFloodCheckerFactory<IFloodChecker> floodCheckerFactory, IFloodCheckerSettings settings)
	{
		_Logger = logger ?? throw new ArgumentNullException("logger");
		_SmsClient = smsClient ?? throw new ArgumentNullException("smsClient");
		_UserFactory = userFactory ?? throw new ArgumentNullException("userFactory");
		_AccountPhoneNumberFactory = accountPhoneNumberFactory ?? throw new ArgumentNullException("accountPhoneNumberFactory");
		_PhoneNumberFloodCheckerFactory = phoneNumberFloodCheckerFactory ?? throw new ArgumentNullException("phoneNumberFloodCheckerFactory");
		_EphemeralCounterFactory = ephemeralCounterFactory ?? throw new ArgumentNullException("ephemeralCounterFactory");
		_FloodCheckerFactory = floodCheckerFactory ?? throw new ArgumentNullException("floodCheckerFactory");
		_FloodCheckerSettings = settings ?? throw new ArgumentNullException("settings");
	}

	public IRecoverUsernameResult RecoverUsernameByPhone(string ip, string target)
	{
		IncrementCounter("ForgotUsernameSms_Attempt");
		if (string.IsNullOrWhiteSpace(ip))
		{
			_Logger.Error("No IP provided in username recovery request");
			return new RecoverUsernameResult(UsernameResponseCodes.Unknown);
		}
		IAccountPhoneNumber accountPhoneNumber;
		try
		{
			accountPhoneNumber = _AccountPhoneNumberFactory.GetByPhoneNumber(target);
			if (accountPhoneNumber == null)
			{
				IncrementCounter("ForgotUsernameSms_PhoneNotFound");
				return new RecoverUsernameResult(UsernameResponseCodes.UnknownPhoneNumber);
			}
			IPhoneNumberFloodChecker phoneNumberFloodChecker = _PhoneNumberFloodCheckerFactory.GetPhoneNumberFloodChecker(accountPhoneNumber, "SendUsernameSms", _FloodCheckerSettings.ForgotUsernameSMSPhoneFloodCheckerLimit, _FloodCheckerSettings.ForgotUsernameSMSPhoneFloodCheckerExpiry);
			if (RecoverUsernameByPhoneIsFloodChecked(ip, phoneNumberFloodChecker))
			{
				return new RecoverUsernameResult(UsernameResponseCodes.Flooded);
			}
		}
		catch (Exception ex) when (ex is PlatformArgumentNullException || ex is PlatformInvalidPhoneNumberException)
		{
			IncrementCounter("ForgotUsernameSms_InvalidPhone");
			return new RecoverUsernameResult(UsernameResponseCodes.InvalidPhoneNumber);
		}
		catch (Exception e)
		{
			_Logger.Error($"Error sending forgot username Sms: {e.Message}");
			IncrementCounter("ForgotUsernameSms_Failure");
			return new RecoverUsernameResult(UsernameResponseCodes.Unknown);
		}
		IUser user = _UserFactory.GetUserByAccountId(accountPhoneNumber.AccountId);
		if (user == null || user.IsUnder13() || user.AccountStatus == Roblox.Platform.Membership.AccountStatus.Forgotten)
		{
			IncrementCounter("ForgotUsernameSms_InvalidUser");
			return new RecoverUsernameResult(UsernameResponseCodes.UnknownPhoneNumber);
		}
		return SendUsernameSms(accountPhoneNumber.E164PhoneNumber, user.Name);
	}

	private bool RecoverUsernameByPhoneIsFloodChecked(string ip, IPhoneNumberFloodChecker phoneNumberFloodChecker)
	{
		IFloodChecker ipFloodchecker = GetIpFloodChecker(ip);
		if (ipFloodchecker.IsFlooded())
		{
			IncrementCounter("ForgotUsernameSms_FloodChecked");
			return true;
		}
		ipFloodchecker.UpdateCount();
		if (phoneNumberFloodChecker.IsFlooded())
		{
			IncrementCounter("ForgotUsernameSms_FloodChecked");
			return true;
		}
		return false;
	}

	private IRecoverUsernameResult SendUsernameSms(string phone, string username)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		try
		{
			Sms sms = new Sms(phone, $"Your Roblox username is: {username}.");
			_SmsClient.Send(sms);
		}
		catch (Exception exception)
		{
			_Logger.Error($"Error sending forgot username SMS: {exception.Message}");
			IncrementCounter("ForgotUsernameSms_ErrorSending");
			return new RecoverUsernameResult(UsernameResponseCodes.Unknown);
		}
		IncrementCounter("ForgotUsernameSms_Success");
		return new RecoverUsernameResult(UsernameResponseCodes.Ok, TransmissionType.Sms);
	}

	private void IncrementCounter(string counterName)
	{
		_EphemeralCounterFactory.GetCounter(counterName).IncrementInBackground();
	}

	internal virtual IFloodChecker GetIpFloodChecker(string ip)
	{
		return _FloodCheckerFactory.GetFloodChecker(null, $"ForgotUsernameSMSFloodChecker_IP:{ip}", () => _FloodCheckerSettings.ForgotUsernameSMSFloodCheckerLimit, () => _FloodCheckerSettings.ForgotUsernameSMSFloodCheckerExpiry, () => true, () => false, _Logger);
	}
}
