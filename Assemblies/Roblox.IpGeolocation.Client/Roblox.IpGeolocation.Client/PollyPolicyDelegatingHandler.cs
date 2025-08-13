using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Polly;

namespace Roblox.IpGeolocation.Client;

/// <summary>
/// Class used to wrap a <see cref="T:Polly.Policy" /> when Polly.Policy is used
/// without the .NET Core HttpClientFactory
/// </summary>
public class PollyPolicyDelegatingHandler : DelegatingHandler
{
	private readonly Policy _Policy;

	public PollyPolicyDelegatingHandler(Policy policy)
	{
		_Policy = policy;
	}

	/// <summary>
	/// Executes the base handler's SendAsync method through Polly's <see cref="T:Polly.Policy" />
	/// </summary>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
	{
		return await _Policy.Execute<Task<HttpResponseMessage>>((Func<Task<HttpResponseMessage>>)(() => base.SendAsync(request, cancellationToken)));
	}
}
