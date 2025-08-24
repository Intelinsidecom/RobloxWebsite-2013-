using System;
using Roblox.FloodCheckers.Core;
using Roblox.Platform.Captcha.Properties;
using Roblox.Platform.Core;
using Roblox.Platform.Games.Counters;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Captcha;

/// <summary>
/// Class containing the business logic that determines if captcha should be shown.
/// Captcha can potentially be bypassed based on time in game, account age, transaction history,
/// or previous captcha success.
/// </summary>
public class CaptchaNeededManager
{
	private readonly IFloodChecker _CaptchaCompletedReverseFloodChecker;

	private readonly IUser _User;

	private readonly int _MinUserAgeInDays;

	private readonly ISettings _Settings;

	private readonly ITimeInGameCounter _TimeInGameCounter;

	private readonly CaptchaNeededMetricsCounter _MetricsCounter;

	/// <summary>
	///
	/// </summary>
	/// <param name="captchaCompletedReverseFloodChecker"></param>
	/// <param name="user">User whose account age and transaction count are checked</param>
	/// <param name="minUserAgeInDays">Max age of a user's account to be captcha-ed</param>
	/// <param name="timeInGameCounter">Object used to allow users with TimeInGame to be exempt from captcha</param>
	/// <param name="metricsCounter">Used to log captcha bypass reasons</param>"
	public CaptchaNeededManager(IFloodChecker captchaCompletedReverseFloodChecker, IUser user, int minUserAgeInDays, ITimeInGameCounter timeInGameCounter, CaptchaNeededMetricsCounter metricsCounter = null)
	{
		_CaptchaCompletedReverseFloodChecker = captchaCompletedReverseFloodChecker;
		_User = user;
		_MinUserAgeInDays = minUserAgeInDays;
		_Settings = Settings.Default;
		_TimeInGameCounter = timeInGameCounter;
		_MetricsCounter = metricsCounter;
	}

	/// <summary>
	///
	/// </summary>
	/// <param name="captchaCompletedReverseFloodChecker"></param>
	/// <param name="user">User whose account age and transaction count are checked</param>
	/// <param name="minUserAgeInDays">Max age of a user's account to be captcha-ed</param>
	/// <param name="timeInGameCounter">TimeInGameCounter object that can be faked for testing</param>
	/// <param name="metricsCounter">Counter object for tracking bypass reasons</param>
	/// <param name="settings">Used to override default settings for testing</param>
	internal CaptchaNeededManager(IFloodChecker captchaCompletedReverseFloodChecker, IUser user, int minUserAgeInDays, ITimeInGameCounter timeInGameCounter, CaptchaNeededMetricsCounter metricsCounter, ISettings settings)
	{
		_CaptchaCompletedReverseFloodChecker = captchaCompletedReverseFloodChecker;
		_User = user;
		_MinUserAgeInDays = minUserAgeInDays;
		_Settings = settings;
		_TimeInGameCounter = timeInGameCounter;
		_MetricsCounter = metricsCounter;
	}

	private double GetSecondsInGame()
	{
		if (_TimeInGameCounter == null)
		{
			return 0.0;
		}
		double seconds = 0.0;
		try
		{
			if (_Settings.TimeInGameBypassOnlyIncludeRecentMonths)
			{
				for (int i = 0; i < _Settings.TimeInGameMonthsRangeFromCurrentInclusive; i++)
				{
					DateTime targetMonth = DateTime.UtcNow.AddMonths(-i);
					seconds += _TimeInGameCounter.GetSecondsInGameByUserIdForMonth(_User.Id, targetMonth.Month, targetMonth.Year);
				}
			}
			else
			{
				seconds = _TimeInGameCounter.GetTotalSecondsInGameByUserId(_User.Id);
			}
		}
		catch (PlatformException)
		{
			seconds = 0.0;
		}
		return seconds;
	}

	/// <summary>
	/// Allow a user to bypass captcha if his or her account meets a minimum age requirement.
	/// </summary>
	/// <returns></returns>
	private bool BypassForAccountAge()
	{
		int num;
		if (_Settings.IsAccountAgeBypassCaptchaEnabled)
		{
			num = ((_User.Created < DateTime.Now.AddDays(-_MinUserAgeInDays)) ? 1 : 0);
			if (num != 0)
			{
				CaptchaNeededMetricsCounter metricsCounter = _MetricsCounter;
				if (metricsCounter == null)
				{
					return (byte)num != 0;
				}
				metricsCounter.IncrementAccountAgeBypassCounter();
			}
		}
		else
		{
			num = 0;
		}
		return (byte)num != 0;
	}

	/// <summary>
	/// Allow a user to bypass captcha if he or she has spent a minumum amount of time in game sessions
	/// </summary>
	/// <returns></returns>
	private bool BypassForTimeInGame()
	{
		double secondsInGame = GetSecondsInGame();
		int num;
		if (_Settings.IsTimeInGameBypassCaptchaEnabled)
		{
			num = ((secondsInGame > (double)_Settings.TimeInGameSecondsBypassCaptchaThreshold) ? 1 : 0);
			if (num != 0)
			{
				CaptchaNeededMetricsCounter metricsCounter = _MetricsCounter;
				if (metricsCounter == null)
				{
					return (byte)num != 0;
				}
				metricsCounter.IncrementTimeInGameBypassCounter();
			}
		}
		else
		{
			num = 0;
		}
		return (byte)num != 0;
	}

	/// <summary>
	/// Allow someone who has previously passed a captcha (before the captcha passed reverse floodchecker expiry time) 
	/// to bypass
	/// </summary>
	/// <returns></returns>
	private bool BypassForPreviousCaptchaSuccess()
	{
		bool num = _CaptchaCompletedReverseFloodChecker.IsFlooded();
		if (num)
		{
			CaptchaNeededMetricsCounter metricsCounter = _MetricsCounter;
			if (metricsCounter == null)
			{
				return num;
			}
			metricsCounter.IncrementPreviousSuccessCounter();
		}
		return num;
	}

	/// <summary>
	/// Check if Captcha should be shown based on age of account, number of completed transactions
	/// and floodchecker status.
	/// </summary>
	/// <returns>true if captcha should be shown</returns>
	public bool ShouldShowCaptcha()
	{
		if (!BypassForTimeInGame() && !BypassForAccountAge())
		{
			return !BypassForPreviousCaptchaSuccess();
		}
		return false;
	}

	/// <summary>
	/// Updates the reverse flood checker count
	/// </summary>
	public void UpdateCaptchaReverseFloodCheckCount()
	{
		_CaptchaCompletedReverseFloodChecker.UpdateCount();
	}
}
