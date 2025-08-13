using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Roblox;

public static class HashGenerator
{
	private static readonly char[][] _ByteToHexStringMap = (from i in Enumerable.Range(0, 256)
		select i.ToString("X2").ToCharArray()).ToArray();

	/// <summary>
	/// Creates new secure hash
	/// </summary>
	[Obsolete("Do not hash your own passwords. Use IPasswordsClient.")]
	public static string HashPassword(string password)
	{
		string sha1Hash = GetSHA1(password);
		string randomSalt = GetRandomSalt();
		string hash = HashString(randomSalt, sha1Hash);
		return randomSalt + hash;
	}

	/// <summary>
	/// Checks if a password matches its secure hash
	/// </summary>
	[Obsolete("Do not hash your own passwords. Use IPasswordsClient.")]
	public static bool ValidatePassword(string passwordToCheck, string correctHash)
	{
		if (correctHash == null || correctHash.Length != 128)
		{
			return false;
		}
		string salt = correctHash.Substring(0, 64);
		string validHash = correctHash.Substring(64, 64);
		string sha1Hash = GetSHA1(passwordToCheck);
		string passHash = HashString(salt, sha1Hash);
		return validHash == passHash;
	}

	public static string HashString(string salt, string stringToHash)
	{
		return GetSHA256(salt + stringToHash);
	}

	/// <summary>
	/// Returns a random 64 character hex string (256 bits)
	/// </summary>
	private static string GetRandomSalt()
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] salt = new byte[32];
		rNGCryptoServiceProvider.GetBytes(salt);
		return ByteArrayToHexString(salt);
	}

	public static string GetSHA1(string stringToHash)
	{
		return ByteArrayToHexString(new SHA1Managed().ComputeHash(Encoding.UTF8.GetBytes(stringToHash)));
	}

	public static string GetSHA256(string stringToHash)
	{
		return ByteArrayToHexString(new SHA256Managed().ComputeHash(Encoding.UTF8.GetBytes(stringToHash)));
	}

	private static string ByteArrayToHexString(byte[] data)
	{
		if (data == null || data.Length == 0)
		{
			return string.Empty;
		}
		StringBuilder sb = new StringBuilder(data.Length * 2);
		foreach (byte b in data)
		{
			char[] s = _ByteToHexStringMap[b];
			sb.Append(s);
		}
		return sb.ToString();
	}
}
