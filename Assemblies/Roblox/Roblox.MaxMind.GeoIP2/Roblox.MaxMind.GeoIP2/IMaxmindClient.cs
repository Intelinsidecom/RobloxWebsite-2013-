namespace Roblox.MaxMind.GeoIP2;

/// <summary>
/// This interface generated for future unit test purpose
/// </summary>
public interface IMaxmindClient
{
	/// <summary>
	/// The <see cref="T:Roblox.MaxMind.GeoIP2.IPLookupResult" /> from MaxMind
	/// </summary>
	IIPLookupResult Lookup(string ip, IPLookupType ipLookupType);
}
