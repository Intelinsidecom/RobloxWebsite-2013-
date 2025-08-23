using System;

namespace Roblox.Web.Security;

public class UsernameHashValidator
{
	private string _salt;

	/// <summary>
	/// Create instance of the UsernameHashValidator
	/// </summary>
	/// <param name="salt">The secret that is prepended to the username before hashing</param>
	public UsernameHashValidator(string salt)
	{
		_salt = salt;
	}

	/// <summary>
	/// Verifies that a hashed username equals the same hashedData from an external source
	/// </summary>
	/// <param name="username">The username to hash</param>
	/// <param name="hashedData">The hashed data from another source to verify</param>
	/// <returns></returns>
	public bool VerifyUsernameHash(string username, string hashedData)
	{
		string prehashString = _salt + username;
		string hashedUsername = new SHA256Util().ComputeHexHash(prehashString);
		return hashedData.Equals(hashedUsername, StringComparison.OrdinalIgnoreCase);
	}
}
