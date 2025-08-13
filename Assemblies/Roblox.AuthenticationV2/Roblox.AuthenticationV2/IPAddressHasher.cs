using System;
using System.Net;
using System.Security.Cryptography;
using Roblox.AuthenticationV2.Properties;

namespace Roblox.AuthenticationV2;

/// <inheritdoc />
public class IPAddressHasher : IIPAddressHasher
{
	private readonly IIPAddressHasherSettings _Settings;

	/// <summary>
	/// Creates an new see <see cref="T:Roblox.AuthenticationV2.IPAddressHasher" />.
	/// </summary>
	public IPAddressHasher()
	{
		_Settings = Settings.Default;
	}

	/// <inheritdoc />
	public string SHA256(IPAddress ip)
	{
		if (ip == null)
		{
			throw new ArgumentNullException("ip");
		}
		using SHA256 sha256Hash = System.Security.Cryptography.SHA256.Create();
		byte[] saltBytes = Convert.FromBase64String(_Settings.IPAddressHashingSalt);
		byte[] ipBytes = ip.GetAddressBytes();
		byte[] bytesToHash = new byte[saltBytes.Length + ipBytes.Length];
		Buffer.BlockCopy(ipBytes, 0, bytesToHash, 0, ipBytes.Length);
		Buffer.BlockCopy(saltBytes, 0, bytesToHash, ipBytes.Length, saltBytes.Length);
		return Convert.ToBase64String(sha256Hash.ComputeHash(bytesToHash));
	}
}
