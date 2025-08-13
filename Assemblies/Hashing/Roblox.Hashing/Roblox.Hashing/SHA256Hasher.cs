using System;
using System.Security.Cryptography;
using System.Text;

namespace Roblox.Hashing;

public static class SHA256Hasher
{
	public static string BuildSHA256HashString(byte[] bytes)
	{
		byte[] sHA256Bytes = GetSHA256Bytes(bytes);
		StringBuilder stringBuilder = new StringBuilder();
		byte[] array = sHA256Bytes;
		foreach (byte b in array)
		{
			stringBuilder.Append(b.ToString("x2"));
		}
		return stringBuilder.ToString();
	}

	public static string BuildSHA256HashString(string stringToHash)
	{
		return BuildSHA256HashString(Encoding.UTF8.GetBytes(stringToHash));
	}

	private static byte[] GetSHA256Bytes(byte[] originalBytes)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		SHA256Managed val = new SHA256Managed();
		try
		{
			return ((HashAlgorithm)(object)val).ComputeHash(originalBytes);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}
}
