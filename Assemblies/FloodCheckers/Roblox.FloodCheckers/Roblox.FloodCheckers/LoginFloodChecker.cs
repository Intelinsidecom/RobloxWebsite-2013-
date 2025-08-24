using System;
using System.Web;
using Roblox.Caching.Shared;
using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class LoginFloodChecker : FloodChecker
{
	private string _MemcacheKey;

	private readonly ISharedCacheClient _MemcachedClient = SharedCacheWebClient.GetSingleton();

	public LoginFloodChecker(string ipAddress, string username)
		: base($"LoginFloodChecker_IPAddress:{ipAddress}", Settings.Default.LoginFloodCheckLimitPerHour, Settings.Default.LoginFloodCheckExpiry)
	{
		username = username ?? string.Empty;
		string safeUsername = HttpUtility.UrlEncode(username);
		_MemcacheKey = $"LoginFloodChecker_IPAddress:{ipAddress}_Username:{safeUsername}";
	}

	public override void UpdateCount()
	{
		if (Settings.Default.LoginFloodCheckOnMultipleUsernames && !string.IsNullOrEmpty(_MemcacheKey))
		{
			string dummy = string.Empty;
			try
			{
				if (!_MemcachedClient.Query<string>(_MemcacheKey, out dummy))
				{
					_MemcachedClient.Add(_MemcacheKey, string.Empty, Settings.Default.LoginFloodCheckExpiry);
					base.UpdateCount();
				}
				return;
			}
			catch (Exception ex)
			{
				ExceptionHandler.LogException(ex);
				return;
			}
		}
		base.UpdateCount();
	}
}
