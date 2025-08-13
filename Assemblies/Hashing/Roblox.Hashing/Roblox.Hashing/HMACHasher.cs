using System;
using System.Security.Cryptography;
using System.Text;

namespace Roblox.Hashing;

public static class HMACHasher
{
	public static byte[] BuildHMACSHA256HashString(string stringToHash, string secretKey)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		byte[] bytes = Encoding.UTF8.GetBytes(secretKey);
		byte[] bytes2 = Encoding.UTF8.GetBytes(stringToHash);
		HMACSHA256 val = new HMACSHA256(bytes);
		try
		{
			return ((HashAlgorithm)(object)val).ComputeHash(bytes2);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}
}
