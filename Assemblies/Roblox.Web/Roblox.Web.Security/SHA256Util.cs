using System;
using System.Security.Cryptography;
using System.Text;

namespace Roblox.Web.Security;

public class SHA256Util
{
	private SHA256 _Hasher;

	private Encoding _Encoding;

	/// <summary>
	/// Create a default instance of a SHA256 hasher and by default uses UTF8 byte encoding
	/// </summary>
	public SHA256Util()
		: this(Encoding.UTF8)
	{
	}

	/// <summary>
	/// Create an instance of a SHA256 hasher with a specific encoder
	/// </summary>
	/// <param name="encoding">The encoding to use when converting strings to bytes. Important when you are comparing hashes against different types of platforms and systems which can use specific byte encodings</param>
	public SHA256Util(Encoding encoding)
	{
		_Hasher = SHA256.Create();
		_Encoding = encoding;
	}

	/// <summary>
	/// Takes a string and computes the SHA256 hash and returns the byte array as a hex string
	/// </summary>
	/// <param name="data">String to be hashed</param>
	/// <returns></returns>
	public string ComputeHexHash(string data)
	{
		byte[] dataBytes = _Encoding.GetBytes(data);
		return BitConverter.ToString(_Hasher.ComputeHash(dataBytes)).Replace("-", string.Empty);
	}
}
