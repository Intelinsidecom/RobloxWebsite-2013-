using System.CodeDom.Compiler;

namespace Roblox.IpGeolocation.Client;

/// <summary>
/// Service client factory
/// </summary>
[GeneratedCode("Roblox.Nswag.Augmentor", "3.0.0.0")]
public interface IIpLookupClientFactory
{
	/// <summary>
	/// Instantiates a new HttpClient
	/// </summary>
	/// <returns><see cref="T:Roblox.IpGeolocation.Client.IIpLookupClient" /></returns>
	IIpLookupClient Create();
}
