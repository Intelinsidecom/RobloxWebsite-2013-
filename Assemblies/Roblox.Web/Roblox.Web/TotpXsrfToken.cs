using System;
using System.Linq;
using System.Security.Cryptography;
using Roblox.Hashing;
using Roblox.Web.Properties;

namespace Roblox.Web;

internal class TotpXsrfToken
{
	private readonly string _SecretKey;

	private readonly bool _OffsetTotpXsrfExpirationEnabled;

	public TotpXsrfToken()
		: this(Settings.Default.TotpXsrfTokenSecretKey, Settings.Default.OffsetTotpXsrfExpirationEnabled)
	{
	}

	public TotpXsrfToken(string secretKey, bool offsetTotpXsrfExpirationEnabled)
	{
		_SecretKey = secretKey;
		_OffsetTotpXsrfExpirationEnabled = offsetTotpXsrfExpirationEnabled;
	}

	public string GetTotpXsrfToken(string tokenKey, DateTime currentTime, TimeSpan totpInterval)
	{
		int currentTimeOffsetSeconds = 0;
		if (_OffsetTotpXsrfExpirationEnabled)
		{
			currentTimeOffsetSeconds = ConsistentHash<string>.BetterHash(tokenKey) % (Convert.ToInt32(totpInterval.TotalSeconds) / 2);
		}
		long currentTickInterval = currentTime.AddSeconds(currentTimeOffsetSeconds).Ticks / totpInterval.Ticks * totpInterval.Ticks;
		using HMACSHA1 hasher = new HMACSHA1(Convert.FromBase64String(_SecretKey));
		byte[] messageChars = (from c in (tokenKey + "_" + currentTickInterval).ToCharArray()
			select (byte)c).ToArray();
		return Convert.ToBase64String(hasher.ComputeHash(messageChars), 11, 9);
	}

	public bool ValidateTotpXsrfToken(string tokenKey, string value, DateTime currentTime, TimeSpan totpInterval)
	{
		if (GetTotpXsrfToken(tokenKey, currentTime, totpInterval) == value)
		{
			return true;
		}
		if (GetTotpXsrfToken(tokenKey, currentTime + totpInterval, totpInterval) == value)
		{
			return true;
		}
		return false;
	}
}
