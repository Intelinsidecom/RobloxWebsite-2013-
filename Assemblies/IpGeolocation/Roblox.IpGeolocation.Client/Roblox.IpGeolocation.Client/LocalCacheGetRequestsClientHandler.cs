using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Roblox.Collections;

namespace Roblox.IpGeolocation.Client;

/// <summary>
/// <see cref="T:System.Net.Http.DelegatingHandler" /> that locally caches all HTTP GET requests
/// based on the full URI of the request.
/// </summary>
public class LocalCacheGetRequestsClientHandler : DelegatingHandler
{
	private readonly ExpirableDictionary<string, byte[]> _RequestCache;

	/// <summary>
	/// Constructor
	/// </summary>
	/// <param name="cacheTimeToLiveGetter">Expiration of cached requests</param>
	/// <param name="cacheTraversalInterval">How often expired entries will be purged</param>
	public LocalCacheGetRequestsClientHandler(Func<TimeSpan> cacheTimeToLiveGetter, TimeSpan cacheTraversalInterval)
	{
		_RequestCache = new ExpirableDictionary<string, byte[]>(cacheTimeToLiveGetter, cacheTraversalInterval, ExpirationPolicy.NeverRenew);
	}

	protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
	{
		if (request.Method != HttpMethod.Get)
		{
			return await base.SendAsync(request, cancellationToken);
		}
		string cacheKey = request.RequestUri.AbsoluteUri;
		byte[] array = _RequestCache.Get(cacheKey);
		if (array != null)
		{
			MemoryStream content = new MemoryStream(array);
			return new HttpResponseMessage(HttpStatusCode.OK)
			{
				Content = new StreamContent(content)
			};
		}
		HttpResponseMessage result = await base.SendAsync(request, cancellationToken);
		if (result.StatusCode == HttpStatusCode.OK)
		{
			byte[] value = await result.Content.ReadAsByteArrayAsync();
			_RequestCache.Set(cacheKey, value);
		}
		return result;
	}
}
