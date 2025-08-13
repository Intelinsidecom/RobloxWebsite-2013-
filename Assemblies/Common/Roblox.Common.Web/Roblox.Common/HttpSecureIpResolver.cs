using System;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;

namespace Roblox.Common;

public class HttpSecureIpResolver : IIpResolver<HttpHeaderSecureIpResolverModel>, IHttpSecureIpResolver
{
	internal virtual bool IsAllowedSecureIp(string trueIp, string proxyUrl, string nonce, Tuple<string, string> hashAndKeyPair1, Tuple<string, string> hashAndKeyPair2)
	{
		if (string.IsNullOrEmpty(trueIp) || string.IsNullOrEmpty(proxyUrl) || string.IsNullOrEmpty(nonce))
		{
			return false;
		}
		if (hashAndKeyPair1 != null && !string.IsNullOrEmpty(hashAndKeyPair1.Item1) && !string.IsNullOrEmpty(hashAndKeyPair1.Item2))
		{
			return IsAllowedSecureIpImpl(trueIp, proxyUrl, nonce, hashAndKeyPair1);
		}
		if (hashAndKeyPair2 != null && !string.IsNullOrEmpty(hashAndKeyPair2.Item1) && !string.IsNullOrEmpty(hashAndKeyPair2.Item2))
		{
			return IsAllowedSecureIpImpl(trueIp, proxyUrl, nonce, hashAndKeyPair2);
		}
		return false;
	}

	internal bool IsAllowedSecureIpImpl(string trueIp, string proxyUrl, string nonce, Tuple<string, string> hashAndKeyPair)
	{
		Encoding enc = Encoding.ASCII;
		HMACSHA1 hMACSHA = new HMACSHA1(enc.GetBytes(hashAndKeyPair.Item2));
		hMACSHA.Initialize();
		string signatureString = $"{proxyUrl} {trueIp} {nonce}";
		byte[] buffer = enc.GetBytes(signatureString);
		byte[] first = hMACSHA.ComputeHash(buffer);
		byte[] secureRobloxBytes = SafeConvertFromBase64String(hashAndKeyPair.Item1);
		return first.SequenceEqual(secureRobloxBytes);
	}

	internal byte[] SafeConvertFromBase64String(string s)
	{
		try
		{
			return Convert.FromBase64String(s);
		}
		catch
		{
			return new byte[0];
		}
	}

	public IPAddress ResolveOriginIpFromSecureIpHeaders(string trueIp, string proxyUrl, string nonce, bool enableHash, Tuple<string, string> hashAndKeyPair1, Tuple<string, string> hashAndKeyPair2)
	{
		IPAddress ip = null;
		if (enableHash)
		{
			if (IsAllowedSecureIp(trueIp, proxyUrl, nonce, hashAndKeyPair1, hashAndKeyPair2))
			{
				IPAddress.TryParse(trueIp, out ip);
			}
		}
		else if (!string.IsNullOrEmpty(trueIp))
		{
			IPAddress.TryParse(trueIp, out ip);
		}
		return ip;
	}

	public IPAddress Resolve(HttpHeaderSecureIpResolverModel data)
	{
		return ResolveOriginIpFromSecureIpHeaders(data.TrueIp, data.ProxyUrl, data.Nonce, data.EnableHashCheck, Tuple.Create(data.SecureHash1, data.Key1), Tuple.Create(data.SecureHash2, data.Key2));
	}
}
