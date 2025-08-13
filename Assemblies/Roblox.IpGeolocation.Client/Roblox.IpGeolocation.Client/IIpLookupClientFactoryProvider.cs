namespace Roblox.IpGeolocation.Client;

/// <summary>
/// Class used to initialize an <see cref="T:Roblox.IpGeolocation.Client.IIpLookupClientFactory" />
/// with the required circuit breaker and local caching handlers.
/// </summary>
public interface IIpLookupClientFactoryProvider
{
	/// <summary>
	/// Gets a single instance of <see cref="T:Roblox.IpGeolocation.Client.IIpLookupClientFactory" /> that all consumers should use.
	/// </summary>
	IIpLookupClientFactory IpLookupClientFactoryInstance { get; }
}
