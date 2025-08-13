using System;
using System.Web;
using Roblox.EphemeralCounters;
using Roblox.Platform.Captcha.Properties;
using Roblox.Platform.Counters;
using Roblox.Platform.Games.Counters;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Captcha;

/// <summary>
/// Verifies if Captcha is enabled and needed for a specific <see cref="T:Roblox.Platform.Captcha.RequestType" />
/// </summary>
public class CaptchaVerifier : ICaptchaVerifier
{
	private readonly RequestType _RequestType;

	private readonly IUser _AuthenticatedUser;

	private CaptchaNeededManager _CaptchaNeededManager;

	private readonly IDurableCounterFactory _DurableCounterFactory;

	private readonly IEphemeralCounterFactory _EphemeralCounterFactory;

	/// <summary>
	/// Gets or sets the <see cref="T:Roblox.Platform.Captcha.Action" />
	/// </summary>
	protected IAction CaptchaAction { get; set; }

	/// <summary>
	/// Checks if Captcha is enabled based on Settings
	/// </summary>
	public bool IsCaptchaEnabled => _RequestType switch
	{
		RequestType.PrivateMessage => IsPrivateMessageFeatureEnabled(), 
		RequestType.FollowRequest => IsFollowRequestFeatureEnabled(), 
		RequestType.FriendRequest => IsFriendRequestFeatureEnabled(), 
		RequestType.JoinGroup => IsJoinGroupFeatureEnabled(), 
		RequestType.PostComment => IsPostCommentFeatureEnabled(), 
		RequestType.ClothingUpload => IsClothingUploadFeatureEnabled(), 
		RequestType.Favorite => IsFavoriteFeatureEnabled(), 
		RequestType.GroupWallPost => IsGroupWallPostCaptchaEnabled(), 
		_ => false, 
	};

	/// <summary>
	/// Gets a <see cref="P:Roblox.Platform.Captcha.CaptchaVerifier.CaptchaNeededManager" />
	/// </summary>
	protected virtual CaptchaNeededManager CaptchaNeededManager
	{
		get
		{
			if (_CaptchaNeededManager == null)
			{
				_CaptchaNeededManager = new CaptchaNeededManager(new CaptchaCompletedReverseFloodChecker(HttpUtility.UrlEncode(_AuthenticatedUser.Name), _AuthenticatedUser.Id), _AuthenticatedUser, GetMinUserAgeInDays(), new TimeInGameCounter(_DurableCounterFactory), (_EphemeralCounterFactory != null) ? new CaptchaNeededMetricsCounter(_EphemeralCounterFactory) : null);
			}
			return _CaptchaNeededManager;
		}
	}

	/// <summary>
	/// Creates a CaptchaVerifier class with a CaptchaAction based on the requestType and username
	/// </summary>
	/// <param name="requestType"></param>
	/// <param name="authenticatedUser"></param>
	/// <param name="captchaAction">Generally a User action.</param>
	/// <param name="durableCounterFactory"></param>
	/// <param name="ephemeralCounterFactory"></param>
	public CaptchaVerifier(RequestType requestType, IUser authenticatedUser, IAction captchaAction, IDurableCounterFactory durableCounterFactory, IEphemeralCounterFactory ephemeralCounterFactory = null)
	{
		_RequestType = requestType;
		_AuthenticatedUser = authenticatedUser;
		CaptchaAction = captchaAction;
		_DurableCounterFactory = durableCounterFactory;
		_EphemeralCounterFactory = ephemeralCounterFactory;
	}

	/// <summary>
	/// Checks the Floodchecker, action and settings and returns whether Captcha Is needed.
	/// </summary>
	/// <param name="inApp">set to true if the request is being made from mobile app.</param>
	/// <returns>true if Captcha is needed</returns>
	public bool IsCaptchaNeeded(bool inApp = false)
	{
		if (inApp || !IsCaptchaEnabled)
		{
			return false;
		}
		bool num = ShouldShowCaptcha();
		bool actionPassed = HasActionPassed(DateTime.Now);
		if (actionPassed)
		{
			UpdateFloodCheckerCount();
		}
		if (num)
		{
			return !actionPassed;
		}
		return false;
	}

	/// <summary>
	/// Updates the FloodChecker count.
	/// </summary>
	protected virtual void UpdateFloodCheckerCount()
	{
		CaptchaNeededManager.UpdateCaptchaReverseFloodCheckCount();
	}

	/// <summary>
	/// Checks if the Private Message Feature is enabled based on settings
	/// </summary>
	/// <returns>true if feature is enabled</returns>
	protected virtual bool IsPrivateMessageFeatureEnabled()
	{
		return PermissionsVerifier.IsFeaturedEnabledOnSettings(_AuthenticatedUser, isGuestAllowed: false, soothsayerSetting: false, betaTesterSetting: false, 0, Settings.Default.IsCaptchaFirstMessageEnabledForAll);
	}

	/// <summary>
	/// Checks if the Friend Request Feature is enabled based on settings
	/// </summary>
	/// <returns>true if feature is enabled</returns>
	protected virtual bool IsFriendRequestFeatureEnabled()
	{
		return PermissionsVerifier.IsFeaturedEnabledOnSettings(_AuthenticatedUser, isGuestAllowed: false, soothsayerSetting: false, betaTesterSetting: false, 0, Settings.Default.CaptchaFirstFriendRequestEnabledForAll);
	}

	/// <summary>
	/// Checks if the Follow Request Feature is enabled based on settings
	/// </summary>
	/// <returns>true if feature is enabled</returns>
	protected virtual bool IsFollowRequestFeatureEnabled()
	{
		return PermissionsVerifier.IsFeaturedEnabledOnSettings(_AuthenticatedUser, isGuestAllowed: false, soothsayerSetting: false, betaTesterSetting: false, 0, Settings.Default.CaptchaFirstFollowRequestEnabledForAll);
	}

	/// <summary>
	/// Checks if the Join Group Feature is enabled based on settings
	/// </summary>
	/// <returns>true if feature is enabled</returns>
	protected virtual bool IsJoinGroupFeatureEnabled()
	{
		return PermissionsVerifier.IsFeaturedEnabledOnSettings(_AuthenticatedUser, isGuestAllowed: false, soothsayerSetting: false, betaTesterSetting: false, 0, Settings.Default.CaptchaFirstGroupJoinEnabledForAll);
	}

	/// <summary>
	/// Checks if the Post Comment Feature is enabled based on settings
	/// </summary>
	/// <returns>true if feature is enabled</returns>
	protected virtual bool IsPostCommentFeatureEnabled()
	{
		return PermissionsVerifier.IsFeaturedEnabledOnSettings(_AuthenticatedUser, isGuestAllowed: false, Settings.Default.CaptchaFirstPostCommentEnabledForSoothsayers, betaTesterSetting: false, 0, Settings.Default.CaptchaFirstPostCommentEnabledForAll);
	}

	/// <summary>
	/// Checks if the Clothing Upload Feature is enabled based on settings
	/// </summary>
	/// <returns>true if feature is enabled</returns>
	protected virtual bool IsClothingUploadFeatureEnabled()
	{
		return PermissionsVerifier.IsFeaturedEnabledOnSettings(_AuthenticatedUser, isGuestAllowed: false, Settings.Default.IsCaptchaOnClothingUploadsEnabledForSoothsayers, betaTesterSetting: false, 0, Settings.Default.IsCaptchaOnClothingUploadsEnabledForAll);
	}

	/// <summary>
	/// Checks if the Favortive Captcha Feature is enabled based on settings
	/// </summary>
	/// <returns>true if feature is enabled</returns>
	protected virtual bool IsFavoriteFeatureEnabled()
	{
		return PermissionsVerifier.IsFeaturedEnabledOnSettings(_AuthenticatedUser, isGuestAllowed: false, Settings.Default.CaptchaFavoritesEnabledForSoothsayers, betaTesterSetting: false, 0, Settings.Default.CaptchaFavoritesEnabledForAll);
	}

	/// <summary>
	/// Checks if the group wall post captcha is enabled based on settings.
	/// </summary>
	/// <returns><c>true</c> if group wall post captcha is enabled.</returns>
	protected virtual bool IsGroupWallPostCaptchaEnabled()
	{
		return PermissionsVerifier.IsFeaturedEnabledOnSettings(_AuthenticatedUser, isGuestAllowed: false, soothsayerSetting: false, betaTesterSetting: false, 0, Settings.Default.GroupWallPostCaptchaEnabledForAll);
	}

	/// <summary>
	/// Gets the minimum user age in days to be used by Floodchecker. Retrieved from settings.
	/// </summary>
	/// <returns>Number of days</returns>
	protected virtual int GetMinUserAgeInDays()
	{
		return _RequestType switch
		{
			RequestType.PrivateMessage => Settings.Default.MessageCaptchaMinUserAgeInDays, 
			RequestType.FollowRequest => Settings.Default.FollowCaptchaMinUserAgeInDays, 
			RequestType.FriendRequest => Settings.Default.FriendRequestCaptchaMinUserAgeInDays, 
			RequestType.JoinGroup => Settings.Default.GroupJoinCaptchaMinUserAgeInDays, 
			RequestType.ClothingUpload => Settings.Default.ClothingUploadCaptchaMinUserAgeInDays, 
			_ => 365, 
		};
	}

	/// <summary>
	/// Checks the CaptchaNeededManager to see if Captcha should be shown
	/// </summary>
	/// <returns>true if captcha should be shown</returns>
	protected virtual bool ShouldShowCaptcha()
	{
		return CaptchaNeededManager.ShouldShowCaptcha();
	}

	/// <summary>
	/// Checks the <see cref="T:Roblox.Platform.Captcha.Action" /> to see if it has passed before the specified date and time
	/// </summary>
	/// <param name="atDateTime">Threshold for checking if <see cref="T:Roblox.Platform.Captcha.Action" /> has passed.</param>
	/// <returns>true if <see cref="T:Roblox.Platform.Captcha.Action" /> has passed</returns>
	protected virtual bool HasActionPassed(DateTime atDateTime)
	{
		return CaptchaAction.HasPassed(atDateTime);
	}
}
