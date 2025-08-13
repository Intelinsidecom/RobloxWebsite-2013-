using System;
using Roblox.AuthenticationV2.Client.Properties;
using Roblox.Http;
using Roblox.Http.Client;
using Roblox.Instrumentation;

namespace Roblox.AuthenticationV2.Client;

/// <inheritdoc cref="T:Roblox.AuthenticationV2.Client.IAuthenticationV2Client" />
public class AuthenticationV2Client : HttpRequestSender, IAuthenticationV2Client
{
	public AuthenticationV2Client(ICounterRegistry counterRegistry)
		: this(new AuthenticationV2HttpClientBuilder(Settings.Default, counterRegistry).Build(), new HttpRequestBuilder(Settings.Default.Endpoint))
	{
	}

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.AuthenticationV2.Client.AuthenticationV2Client" />.
	/// </summary>
	/// <param name="httpClient">An <see cref="T:Roblox.Http.Client.IHttpClient" />.</param>
	/// <param name="httpRequestBuilder">An <see cref="T:Roblox.Http.Client.IHttpRequestBuilder" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	/// - <paramref name="httpClient" />
	/// - <paramref name="httpRequestBuilder" />
	/// </exception>
	internal AuthenticationV2Client(IHttpClient httpClient, IHttpRequestBuilder httpRequestBuilder)
		: base(httpClient, httpRequestBuilder)
	{
	}

	/// <inheritdoc />
	public string SyncRobloxUserSession(string type, string user, Guid token, DateTime expiration, string ipAddressHash, TimeSpan timeToLive)
	{
		SyncRobloxUserSessionRequest request = new SyncRobloxUserSessionRequest
		{
			Type = type,
			User = user,
			Token = token,
			Expiration = expiration,
			IPAddressHash = ipAddressHash,
			TimeToLive = timeToLive
		};
		return SendRequestWithJsonBody<SyncRobloxUserSessionRequest, string>(HttpMethod.Post, "authentication/SyncRobloxUserSession", request);
	}

	/// <inheritdoc />
	public void DeleteRobloxUserSession(Guid token)
	{
		DeleteRobloxUserSessionRequest request = new DeleteRobloxUserSessionRequest
		{
			Token = token
		};
		SendRequestWithJsonBody(HttpMethod.Post, "authentication/DeleteRobloxUserSession", request);
	}

	/// <inheritdoc />
	public void DeleteAllRobloxUserSessions(string type, string user)
	{
		DeleteAllRobloxUserSessionsRequest request = new DeleteAllRobloxUserSessionsRequest
		{
			Type = type,
			User = user
		};
		SendRequestWithJsonBody(HttpMethod.Post, "authentication/DeleteAllRobloxUserSessions", request);
	}
}
