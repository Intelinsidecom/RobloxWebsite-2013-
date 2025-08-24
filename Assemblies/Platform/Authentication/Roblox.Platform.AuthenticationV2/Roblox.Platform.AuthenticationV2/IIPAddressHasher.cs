using System.Net;

namespace Roblox.AuthenticationV2;

/// <summary>
/// Computes hashes of <see cref="T:System.Net.IPAddress" />es
/// </summary>
public interface IIPAddressHasher
{
	/// <summary>
	/// Computes a SHA256 hash of the given <paramref name="ip" />
	/// </summary>
	/// <param name="ip">The <see cref="T:System.Net.IPAddress" /> to hash.</param>
	/// <returns>A Base64 encoded SHA256 hash of <paramref name="ip" /></returns>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="ip" /></exception>
	string SHA256(IPAddress ip);
}
