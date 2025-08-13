using System;
using System.Collections;
using System.Collections.Specialized;
using System.Net.Http;
using System.Web;

namespace Roblox.Web;

/// <summary>
/// A class that has validation methods for requests from game servers
/// </summary>
public interface IGameServerRequestValidator
{
	/// <summary>
	/// Determines whether or not an <see cref="T:System.Web.HttpContext" /> could potentially be a game server.
	/// </summary>
	/// <remarks>
	/// This method should be called before <see cref="M:Roblox.Web.IGameServerRequestValidator.IsValidGameServerRequest(System.Web.HttpContext)" />
	/// if the request could potentially be made by a client that isn't a game server. 
	/// </remarks>
	/// <param name="context">The <see cref="T:System.Web.HttpContext" />.</param>
	/// <returns><c>true</c> if the request is potentially from a game server.</returns>
	bool IsPotentialGameServer(HttpContext context);

	/// <summary>
	/// Determines whether or not an <see cref="T:System.Web.HttpContextBase" /> could potentially be a game server.
	/// </summary>
	/// <remarks>
	/// This method should be called before <see cref="M:Roblox.Web.IGameServerRequestValidator.IsValidGameServerRequest(System.Web.HttpContextBase)" />
	/// if the request could potentially be made by a client that isn't a game server. 
	/// </remarks>
	/// <param name="context">The <see cref="T:System.Web.HttpContextBase" />.</param>
	/// <returns><c>true</c> if the request is potentially from a game server.</returns>
	bool IsPotentialGameServer(HttpContextBase context);

	/// <summary>
	/// Determines whether or not a request with specified headers could potentially be a game server.
	/// </summary>
	/// <remarks>
	/// This method should be called before <see cref="M:Roblox.Web.IGameServerRequestValidator.IsValidGameServerRequest(System.Web.HttpContextBase)" />
	/// if the request could potentially be made by a client that isn't a game server. 
	/// </remarks>
	/// <param name="headers">Request Headers collection.</param>
	/// <returns><c>true</c> if the request is potentially from a game server.</returns>
	bool IsPotentialGameServer(NameValueCollection headers);

	/// <summary>
	/// Determines whether or not a request is from a game server based off <see cref="T:System.Web.HttpContext" />.
	/// </summary>
	/// <param name="context">The <see cref="T:System.Web.HttpContext" />.</param>
	/// <returns><c>true</c> if the request is from a game server.</returns>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="context" /> is null.</exception>
	bool IsValidGameServerRequest(HttpContext context);

	/// <summary>
	/// Determines whether or not a request is from a game server based off <see cref="T:System.Web.HttpContext" />.
	/// </summary>
	/// <param name="context">The <see cref="T:System.Web.HttpContext" />.</param>
	/// <returns><c>true</c> if the request is from a game server.</returns>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="context" /> is null.</exception>
	bool IsValidGameServerRequest(HttpContextBase context);

	/// <summary>
	/// Determines whether or not a request is from a game server based off <see cref="T:System.Web.HttpContext" />.
	/// </summary>
	/// <param name="ipAddress">The Ip Address of the requester.</param>
	/// <param name="headers">The request headers collection</param>
	/// <param name="requestItems">Dictionary of request items <seealso cref="T:System.Web.HttpRequest" /></param>
	/// <returns><c>true</c> if the request is from a game server.</returns>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="context" /> is null.</exception>
	bool IsValidGameServerRequest(string ipAddress, NameValueCollection headers, IDictionary requestItems);

	/// <summary>
	/// Verifies only the IP address of a game server.
	/// </summary>
	/// <param name="ipAddress">The IP address.</param>
	/// <returns><c>true</c> if the IP address matches a known/verified game server.</returns>
	bool VerifyIpAccess(string ipAddress);

	/// <summary>
	/// Pull the player count from the headers of the given request.
	/// </summary>
	/// <param name="request">A <see cref="T:System.Net.Http.HttpRequestMessage" /></param>
	/// <returns>The number represented in the Header. 0 if nothing is found.</returns>
	int GetCurrentNumberOfPlayers(HttpRequestMessage request);

	/// <summary>
	/// Pull the player count from the headers of the given request.
	/// </summary>
	/// <param name="requestHeaders">The headers of the <see cref="T:System.Web.HttpRequestBase" /></param>
	/// <returns>The number represented in the Header. 0 if nothing is found.</returns>
	int GetCurrentNumberOfPlayers(NameValueCollection requestHeaders);

	/// <summary>
	/// Pull the Game Instance ID from the headers of the given request.
	/// </summary>
	/// <param name="request">A <see cref="T:System.Net.Http.HttpRequestMessage" /></param>
	/// <returns>A <see cref="T:System.Guid" /> representing the game instance. Or Guid.Empty if nothing exists.</returns>
	Guid GetGameInstanceId(HttpRequestMessage request);

	/// <summary>
	/// Pull the Game Instance ID from the headers of the given request.
	/// </summary>
	/// <param name="requestHeaders">The headers of the <see cref="T:System.Web.HttpRequestBase" /></param>
	/// <returns>A <see cref="T:System.Guid" /> representing the game instance. Or Guid.Empty if nothing exists.</returns>
	Guid GetGameInstanceId(NameValueCollection requestHeaders);

	/// <summary>
	/// Pull the Place ID from the headers of the given request.
	/// </summary>
	/// <param name="request">A <see cref="T:System.Net.Http.HttpRequestMessage" /></param>
	/// <returns>A <see cref="T:System.Int64" /> representing the place. Or 0 if nothing exists.</returns>
	long GetPlaceId(HttpRequestMessage request);

	/// <summary>
	/// Pull the Place ID from the headers of the given request.
	/// </summary>
	/// <param name="requestHeaders">The headers of the <see cref="T:System.Web.HttpRequestBase" /></param>
	/// <returns>A <see cref="T:System.Int64" /> representing the place. Or 0 if nothing exists.</returns>
	long GetPlaceId(NameValueCollection requestHeaders);
}
