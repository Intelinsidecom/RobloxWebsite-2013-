using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Threading.Tasks;
using Gigya.Socialize.SDK;
using Roblox.EventLog;
using Roblox.Gigya.Properties;
using Roblox.Instrumentation;
using Roblox.Platform.Membership;

namespace Roblox.Gigya;

public class GigyaClient : IGigyaClient
{
	private readonly ILogger _Logger;

	private readonly GigyaPerformanceMonitor LogoutPerfmon;

	private readonly GigyaPerformanceMonitor NotifyLoginPerfmon;

	private readonly GigyaPerformanceMonitor GetUserInfoPerfmon;

	private readonly GigyaPerformanceMonitor GetSessionInfoPerfmon;

	private readonly GigyaPerformanceMonitor NotifyRegistrationPerfmon;

	private static int TimeoutInMilliseconds => (int)Settings.Default.GigyaClientTimeout.TotalMilliseconds;

	public GigyaClient(ICounterRegistry counterRegistry, ILogger logger)
	{
		if (counterRegistry == null)
		{
			throw new ArgumentNullException("counterRegistry");
		}
		_Logger = logger ?? throw new ArgumentNullException("logger");
		LogoutPerfmon = new GigyaPerformanceMonitor(counterRegistry, "socialize.logout");
		NotifyLoginPerfmon = new GigyaPerformanceMonitor(counterRegistry, "socialize.notifyLogin");
		GetUserInfoPerfmon = new GigyaPerformanceMonitor(counterRegistry, "socialize.getUserInfo");
		GetSessionInfoPerfmon = new GigyaPerformanceMonitor(counterRegistry, "socialize.getSessionInfo");
		NotifyRegistrationPerfmon = new GigyaPerformanceMonitor(counterRegistry, "socialize.notifyRegistration");
	}

	public Task<bool> LogoutInBackground(IUser user)
	{
		return Task.Factory.StartNew(delegate
		{
			try
			{
				return Logout(user);
			}
			catch (Exception ex)
			{
				_Logger.Error(ex.Message);
				return false;
			}
		});
	}

	public bool Logout(IUser user)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		string gigyaUid = ConstructGigyaUid(user.Id);
		return Logout(gigyaUid);
	}

	private bool Logout(string gigyaUid)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		if (string.IsNullOrEmpty(gigyaUid))
		{
			return true;
		}
		GSRequest request = new GSRequest(Settings.Default.GigyaAPIKey, Settings.Default.GigyaSecretKey, "socialize.logout", true);
		request.SetParam("UID", gigyaUid);
		if (SendRequest(request, LogoutPerfmon).GetErrorCode() != 0)
		{
			return false;
		}
		return true;
	}

	public IGigyaNotifyLoginResponse NotifyLogin(IUser user, string currentUid, bool isNewUser)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		string expectedUid = ConstructGigyaUid(user.Id);
		if (expectedUid == currentUid)
		{
			return null;
		}
		Logout(currentUid);
		GSRequest request = new GSRequest(Settings.Default.GigyaAPIKey, Settings.Default.GigyaSecretKey, "socialize.notifyLogin", true);
		request.SetParam("siteUID", expectedUid);
		request.SetParam("newUser", isNewUser);
		request.SetParam("signIDs", true);
		GigyaNotifyLoginResponse notifyLoginResponse = new GigyaNotifyLoginResponse(SendRequest(request, NotifyLoginPerfmon));
		if (!notifyLoginResponse.IsSuccess)
		{
			return notifyLoginResponse;
		}
		if (!notifyLoginResponse.IsValid)
		{
			_Logger.Error($"gigya.socialize.notifyLogin call could not be validated for UserID={user.Id}");
		}
		if (notifyLoginResponse.UID != expectedUid)
		{
			_Logger.Error($"gigya.socialize.notifyLogin call succeeded but did not return expected UID for UserID={user.Id}");
			notifyLoginResponse.IsValid = false;
			notifyLoginResponse.ErrorMessage = "Response data was corrupt.";
		}
		return notifyLoginResponse;
	}

	public IGigyaNotifyRegistrationResponse NotifyRegistration(IUser user, string temporaryGigyaUid)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		GSRequest request = new GSRequest(Settings.Default.GigyaAPIKey, Settings.Default.GigyaSecretKey, "socialize.notifyRegistration", true);
		string gigyaUid = ConstructGigyaUid(user.Id);
		request.SetParam("siteUID", gigyaUid);
		request.SetParam("UID", temporaryGigyaUid);
		GigyaNotifyRegistrationResponse notifyRegistrationResponse = new GigyaNotifyRegistrationResponse(SendRequest(request, NotifyRegistrationPerfmon));
		if (!notifyRegistrationResponse.IsSuccess)
		{
			return notifyRegistrationResponse;
		}
		notifyRegistrationResponse.UID = gigyaUid;
		return notifyRegistrationResponse;
	}

	public IGigyaUserInfoResponse GetUserInfo(IUser user)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		string uid = ConstructGigyaUid(user.Id);
		return GetUserInfo(uid);
	}

	public IGigyaUserInfoResponse GetUserInfo(string gigyaUID)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		GSRequest request = new GSRequest(Settings.Default.GigyaAPIKey, Settings.Default.GigyaSecretKey, "socialize.getUserInfo", true);
		request.SetParam("uid", gigyaUID);
		request.SetParam("signIDs", true);
		GigyaUserInfoResponse userInfoResponse = new GigyaUserInfoResponse(SendRequest(request, GetUserInfoPerfmon));
		if (!userInfoResponse.IsSuccess)
		{
			userInfoResponse.ErrorMessage = "Could not retrieve information for user. " + userInfoResponse.ErrorMessage;
			return userInfoResponse;
		}
		if (!userInfoResponse.IsValid)
		{
			_Logger.Error($"gigya.socialize.getUserInfo call succeeded but failed validation for Gigya UID={gigyaUID}");
			return userInfoResponse;
		}
		if (userInfoResponse.User.UID != gigyaUID)
		{
			_Logger.Error($"gigya.socialize.getUserInfo call succeeded but did not return expected UID for Gigya UID={gigyaUID}");
			userInfoResponse.IsValid = false;
			userInfoResponse.ErrorMessage = "Response data was corrupt.";
		}
		return userInfoResponse;
	}

	public IGigyaSessionInfoResponse GetSessionInfo(IUser user, GigyaProviderType provider)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		string gigyaUid = ConstructGigyaUid(user.Id);
		GSRequest request = new GSRequest(Settings.Default.GigyaAPIKey, Settings.Default.GigyaSecretKey, "socialize.getSessionInfo", true);
		request.SetParam("UID", gigyaUid);
		request.SetParam("signIDs", true);
		request.SetParam("provider", GigyaProviderTranslator.TranslateFromGigyaProvider(provider));
		GigyaSessionInfoResponse sessionInfoResponse = new GigyaSessionInfoResponse(SendRequest(request, GetSessionInfoPerfmon));
		if (!sessionInfoResponse.IsSuccess)
		{
			sessionInfoResponse.ErrorMessage = "Could not retrieve session information. " + sessionInfoResponse.ErrorMessage;
			return sessionInfoResponse;
		}
		if (!sessionInfoResponse.IsValid)
		{
			_Logger.Error($"gigya.socialize.getSessionInfo call succeeded but failed validation for UID={gigyaUid}");
			sessionInfoResponse.ErrorMessage = "Response data was corrupt.";
		}
		return sessionInfoResponse;
	}

	public IGigyaUser HandlePostLoginResponse(NameValueCollection nameValueCollection)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		GSObject val = new GSObject();
		val.ParseQuerystring(nameValueCollection.ToString());
		return new GigyaUser(val);
	}

	public void RemoveConnection(IUser user, GigyaProviderType provider)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		if (user == null)
		{
			throw new ArgumentNullException();
		}
		if (provider != 0)
		{
			GSRequest val = new GSRequest(Settings.Default.GigyaAPIKey, Settings.Default.GigyaSecretKey, "socialize.removeConnection", true);
			string uid = ConstructGigyaUid(user.Id);
			val.SetParam("UID", uid);
			val.SetParam("provider", GigyaProviderTranslator.TranslateFromGigyaProvider(provider));
			val.Send(TimeoutInMilliseconds);
		}
	}

	public void DeleteAccount(IUser user)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if (user == null)
		{
			throw new ArgumentNullException();
		}
		GSRequest val = new GSRequest(Settings.Default.GigyaAPIKey, Settings.Default.GigyaSecretKey, "socialize.deleteAccount", true);
		string uid = ConstructGigyaUid(user.Id);
		val.SetParam("UID", uid);
		val.Send(TimeoutInMilliseconds);
	}

	/// <summary>
	/// Constructs the Gigya unique identifier, based off our userID and an environment prefix.
	/// </summary>
	/// <param name="userId"></param>
	/// <returns></returns>
	internal static string ConstructGigyaUid(long userId)
	{
		if (userId == 0L)
		{
			throw new ArgumentException("userid cannot be default");
		}
		return Settings.Default.GigyaIdentityEnvironmentPrefix + userId;
	}

	private GSResponse SendRequest(GSRequest request, GigyaPerformanceMonitor perfmon)
	{
		Stopwatch stopwatch = Stopwatch.StartNew();
		GSResponse response = request.Send(TimeoutInMilliseconds);
		stopwatch.Stop();
		perfmon.Increment(request, response, stopwatch.Elapsed);
		return response;
	}
}
