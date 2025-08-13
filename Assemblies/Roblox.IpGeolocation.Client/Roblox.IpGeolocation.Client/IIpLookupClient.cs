using System.CodeDom.Compiler;
using System.Threading;
using System.Threading.Tasks;

namespace Roblox.IpGeolocation.Client;

[GeneratedCode("NSwag", "13.1.6.0 (NJsonSchema v10.0.28.0 (Newtonsoft.Json v12.0.0.0))")]
public interface IIpLookupClient
{
	/// <returns>Success</returns>
	/// <exception cref="T:Roblox.IpGeolocation.Client.SwaggerException">A server side error occurred.</exception>
	Task<IpGeolocationResponse> LookupAsync(string ipAddress);

	/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
	/// <returns>Success</returns>
	/// <exception cref="T:Roblox.IpGeolocation.Client.SwaggerException">A server side error occurred.</exception>
	Task<IpGeolocationResponse> LookupAsync(string ipAddress, CancellationToken cancellationToken);
}
