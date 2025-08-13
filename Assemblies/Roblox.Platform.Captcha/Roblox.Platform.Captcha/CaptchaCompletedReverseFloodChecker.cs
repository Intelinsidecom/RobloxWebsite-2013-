using Roblox.FloodCheckers;
using Roblox.FloodCheckers.Core;
using Roblox.Platform.Captcha.Properties;

namespace Roblox.Platform.Captcha;

/// <summary>
/// Floodchecker used to record when an authenticated user solves captcha. A user will not be challenged if this is flooded.
/// This is used, for example, to ensure that an authenticated user does not need to pass captcha more than 1 time every 6 hours
/// inside the website.
/// </summary>
internal class CaptchaCompletedReverseFloodChecker : IFloodChecker, IBasicFloodChecker
{
	private readonly IFloodChecker _UsernameFloodChecker;

	private readonly IFloodChecker _UserIdFloodChecker;

	internal CaptchaCompletedReverseFloodChecker(string userName, long userId)
	{
		_UsernameFloodChecker = new FloodChecker("Captcha", $"Captcha_Completed_{userName}", Settings.Default.CaptchaCompletedReverseFloodCheckerLimit, Settings.Default.CaptchaCompletedReverseFloodCheckerExpiry, Settings.Default.CaptchaCompletedReverseFloodCheckerEnabled);
		_UserIdFloodChecker = new FloodChecker("Captcha", $"Captcha_Completed_UserId_{userId}", Settings.Default.CaptchaCompletedReverseFloodCheckerLimit, Settings.Default.CaptchaCompletedReverseFloodCheckerExpiry, Settings.Default.CaptchaCompletedReverseFloodCheckerEnabled);
	}

	public bool IsFlooded()
	{
		bool userIdFloodCheckerFlooded = Settings.Default.CaptchaCompletedReverseFloodCheckerUserIdKeyEnabled && _UserIdFloodChecker.IsFlooded();
		return (Settings.Default.CaptchaCompletedReverseFloodCheckerUsernameKeyEnabled && _UsernameFloodChecker.IsFlooded()) || userIdFloodCheckerFlooded;
	}

	public void UpdateCount()
	{
		if (Settings.Default.CaptchaCompletedReverseFloodCheckerUserIdKeyEnabled)
		{
			_UserIdFloodChecker.UpdateCount();
		}
		if (Settings.Default.CaptchaCompletedReverseFloodCheckerUsernameKeyEnabled)
		{
			_UsernameFloodChecker.UpdateCount();
		}
	}

	public void Reset()
	{
		if (Settings.Default.CaptchaCompletedReverseFloodCheckerUserIdKeyEnabled)
		{
			_UserIdFloodChecker.Reset();
		}
		if (Settings.Default.CaptchaCompletedReverseFloodCheckerUsernameKeyEnabled)
		{
			_UsernameFloodChecker.Reset();
		}
	}

	public IFloodCheckerStatus Check()
	{
		if (Settings.Default.CaptchaCompletedReverseFloodCheckerUserIdKeyEnabled)
		{
			IFloodCheckerStatus userIdFloodCheckerStatus = _UserIdFloodChecker.Check();
			if (userIdFloodCheckerStatus.IsFlooded || !Settings.Default.CaptchaCompletedReverseFloodCheckerUsernameKeyEnabled)
			{
				return userIdFloodCheckerStatus;
			}
		}
		return _UsernameFloodChecker.Check();
	}

	public int GetCount()
	{
		if (Settings.Default.CaptchaCompletedReverseFloodCheckerUserIdKeyEnabled && (_UserIdFloodChecker.GetCount() > 0 || !Settings.Default.CaptchaCompletedReverseFloodCheckerUsernameKeyEnabled))
		{
			return _UserIdFloodChecker.GetCount();
		}
		return _UsernameFloodChecker.GetCount();
	}

	public int GetCountOverLimit()
	{
		if (Settings.Default.CaptchaCompletedReverseFloodCheckerUserIdKeyEnabled)
		{
			int userIdFloodCheckerCountOverLimit = _UserIdFloodChecker.GetCountOverLimit();
			if (userIdFloodCheckerCountOverLimit > 0 || !Settings.Default.CaptchaCompletedReverseFloodCheckerUsernameKeyEnabled)
			{
				return userIdFloodCheckerCountOverLimit;
			}
		}
		return _UsernameFloodChecker.GetCountOverLimit();
	}
}
