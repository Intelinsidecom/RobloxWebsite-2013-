using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

/// <summary>
/// Represents a <see cref="T:Roblox.FloodCheckers.FloodChecker" /> that flood checks requesting comments on a per-ip basis.
/// </summary>
public class RequestCommentsByIpFloodChecker : FloodChecker
{
	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.FloodCheckers.RequestCommentsByIpFloodChecker" /> class
	/// for given IP requesting comments.
	/// </summary>
	/// <param name="ipAddress">The IP of the client requesting comments.</param>
	public RequestCommentsByIpFloodChecker(string ipAddress)
		: base($"RequestCommentsByIpFloodCheck_IpAddress:{ipAddress}", Settings.Default.RequestCommentsByIpFloodCheckLimit, Settings.Default.RequestCommentsByIpFloodCheckExpiry)
	{
	}
}
